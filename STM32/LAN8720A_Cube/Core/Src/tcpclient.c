#include "lwip/netif.h"
#include "lwip/ip.h"
#include "lwip/tcp.h"
#include "lwip/init.h"
#include "netif/etharp.h"
#include "lwip/udp.h"
#include "lwip/pbuf.h"
#include <stdio.h>	
#include <string.h>
#include "main.h"

#include "tcpclient.h"


static void client_err(void *arg, err_t err)  //出現錯誤時調用這個函數, 打印錯誤信息, 並嘗試重新連結
{
	//連結失敗的時候釋放TCP控制塊內存
  //tcp_close(client_pcb); 
  
	//重新連結
	TCP_Client_Init();
}


static err_t client_send(void *arg, struct tcp_pcb *tpcb)   //發送函數, 調用了tcp_write函數
{
  uint8_t send_buf[]= "Hello LwIP\n";
  
	//發送數據到服務器
  tcp_write(tpcb, send_buf, sizeof(send_buf), 1); 
  
  return ERR_OK;
}

static err_t client_recv(void *arg, struct tcp_pcb *tpcb, struct pbuf *p, err_t err)
{
  if (p != NULL) 
  {        
		//接收數據
    tcp_recved(tpcb, p->tot_len);
      
		//返回接收到的數據
    tcp_write(tpcb, p->payload, p->tot_len, 1);
      
    memset(p->payload, 0 , p->tot_len);
    pbuf_free(p);
  } 
  else if (err == ERR_OK) 
  {
		//服務器斷開連結
    tcp_close(tpcb);
    
		//重新連結
    TCP_Client_Init();
  }
  return ERR_OK;
}

static err_t client_connected(void *arg, struct tcp_pcb *pcb, err_t err)
{
	//註冊一個週期性回調函數
  tcp_poll(pcb,client_send,2);
  
	//註冊一個接收函數
  tcp_recv(pcb,client_recv);
  
  return ERR_OK;
}


void TCP_Client_Init(void)
{        
	struct tcp_pcb *client_pcb = NULL;   //這一行一定要放裡面, 否則沒用
  ip4_addr_t server_ip;     //因為客戶端要主動去連結服務器, 所以要知道服務器的IP地址

  client_pcb = tcp_new();	  

  IP4_ADDR(&server_ip, DEST_IP_ADDR0,DEST_IP_ADDR1,DEST_IP_ADDR2,DEST_IP_ADDR3);//合併IP地址
  
	//開始連結
  tcp_connect(client_pcb, &server_ip, TCP_CLIENT_PORT, client_connected);
	ip_set_option(client_pcb, SOF_KEEPALIVE);	
	
  //註冊異常處理
  tcp_err(client_pcb, client_err);
}

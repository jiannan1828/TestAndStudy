#include "tcpserver.h"
#include "lwip/netif.h"
#include "lwip/ip.h"
#include "lwip/tcp.h"
#include "lwip/init.h"
#include "netif/etharp.h"
#include "lwip/udp.h"
#include "lwip/pbuf.h"
#include <stdio.h>	
#include <string.h>



static err_t tcpecho_recv(void *arg, struct tcp_pcb *tpcb, struct pbuf *p, err_t err)
	{                                   //對應接收數據連接的控制塊 接收到的數據
  if (p != NULL) 
  {        
	//int a = 666;
	/* 更新窗口 */
	tcp_recved(tpcb, p->tot_len);     //讀取數據的控制塊 得到所有數據的長度
			
    /* 返回接收到的數據 */  
  //tcp_write(tpcb, p->payload, p->tot_len, 1);

	uint8_t send_buf1[]= "Get Message!";
	uint8_t send_buf2[]= "Right? \n";	
	tcp_write(tpcb, send_buf1, sizeof(send_buf1), 1);
	tcp_write(tpcb, p->payload, p->tot_len, 1);	
	tcp_write(tpcb, send_buf2, sizeof(send_buf2), 1);	
    
  memset(p->payload, 0 , p->tot_len);
  pbuf_free(p);
    
  } 
  else if (err == ERR_OK)    //檢測到對方主動關閉連結時, 也會調用recv函數, 此時p為空
  {
    return tcp_close(tpcb);
  }
  return ERR_OK;
}

static err_t tcpecho_accept(void *arg, struct tcp_pcb *newpcb, err_t err) //由於這個函數是*tcp_accept_fn類型的
{     
  tcp_recv(newpcb, tcpecho_recv);    //當收到數據時, 回調用戶自己寫的tcpecho_recv
  return ERR_OK;
}

void TCP_Echo_Init(void)
{
  struct tcp_pcb *server_pcb = NULL;	            		
  
  /* 創建一個TCP控制塊 */
  server_pcb = tcp_new();	
  
  /* 綁定TCP控制塊 */
  tcp_bind(server_pcb, IP_ADDR_ANY, TCP_ECHO_PORT);       

  /* 進入監聽狀態 */
  server_pcb = tcp_listen(server_pcb);

  /* 處理連結 註冊函數 監聽到連結時被註冊的函數被回調 */	
  tcp_accept(server_pcb, tcpecho_accept);  //監聽到連結後, 回調用戶編寫的tcpecho_accept
																					 //這個函數是*tcp_accept_fn
}


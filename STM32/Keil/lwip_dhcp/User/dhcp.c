#include "lwip/opt.h"
#include "lwip/arch.h"
#include "lwip/api.h"
#include "lwip/dhcp.h"
#include "lwip/inet.h"

#include "dhcp.h"

#if LWIP_NETCONN

#define MAX_BUFFER_LEN 256

char sendbuf[MAX_BUFFER_LEN];

extern struct netif gnetif;

static void dhcp_thread(void *arg)
{
	struct netconn *conn;
	ip4_addr_t ipaddr;
  int ret;
	int strlen = 0;
  
  while(ip_addr_cmp(&(gnetif.ip_addr),&ipaddr))   //�ȴ�dhcp�����ip��Ч
  {
    vTaskDelay(1);
  }
  
	while(1)
	{
    conn = netconn_new(NETCONN_TCP);
    if (conn == NULL)
    {
      printf("create conn failed!\n");
      vTaskDelay(10);
      continue;
    }

    printf("create conn success...\n");
    
    IP4_ADDR(&ipaddr,192,168,1,112); 			//���������IP��ַ
    
    ret = netconn_connect(conn,&ipaddr,5001);	//���ӷ��������˿ں�5001
    
    if (ret == -1)
    {
      printf("Connect failed!\n");
      netconn_close(conn);
      vTaskDelay(10);
      continue;
    }
    
    printf("Connect to server successful!\n");
    
    strlen = sprintf(sendbuf,"A LwIP client Using DHCP Address: %s\n", \
    ipaddr_ntoa((ip_addr_t *)&(gnetif.ip_addr)));
    
    while(1)
    {
      printf("%s",sendbuf);
      ret=netconn_write(conn,sendbuf, strlen, NETCONN_NOCOPY);
      if (ret == ERR_OK)
      {
         printf("write success...\n");
      }
      vTaskDelay(1000); 
    }
    
//    printf("Connection failed \n");
//    netconn_close(conn); 						//�ر�����
//    netconn_delete(conn);						//ɾ�����ӽṹ
  }
}


void dhcp_netconn_init()
{
  sys_thread_new("dhcp_thread", dhcp_thread, NULL, 2048, 4);
}

#endif /* LWIP_NETCONN*/

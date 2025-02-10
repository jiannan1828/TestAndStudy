#include "stm32f4xx.h"
#include "bsp_SysTick.h"
#include "stm32f429_phy.h"
#include "netconf.h"
#include "tcp_echoclient.h"
#include "tim.h"
#include "stm32f429_eth.h"

int main(void)
{  
  /* 初始化系統定時器 */
	SysTick_Init();
  
	/* 配置 LAN8720 GPIO, Clock, MAC, DMA */
	ETH_BSP_Config();
	
	/* 初始化 LwIP */
	LwIP_Init();
	
	tcp_echoclient_connect();

	while (1)
	{
			if (ETH_CheckFrameReceived())
			{
				LwIP_Pkt_Handle();
			}
	
			LwIP_Periodic_Handle(LocalTime);
			// tcp_echoclient_disconnect(pcb);
	}
}


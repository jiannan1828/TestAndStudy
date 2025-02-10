#include "bsp_SysTick.h"

static __IO u32 TimingDelay;
 
void SysTick_Init(void)
{
	if (SysTick_Config(SystemCoreClock / 1800)) // 這邊要注意有沒有進入死循環, 代表系統定時器初始化失敗
	{ 
		/* Capture error */ 
		while (1);
	}
}

void Delay_ms(__IO u32 nTime)
{ 
	TimingDelay = nTime;	

	while(TimingDelay != 0);
}

void TimingDelay_Decrement(void)
{
	if (TimingDelay != 0x00)
	{ 
		TimingDelay--;
	}
}
/*********************************************END OF FILE**********************/

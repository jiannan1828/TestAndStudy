#include "bsp_SysTick.h"

static __IO u32 TimingDelay;
 
void SysTick_Init(void)
{
	if (SysTick_Config(SystemCoreClock / 1800)) // �o��n�`�N���S���i�J���`��, �N��t�Ωw�ɾ���l�ƥ���
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

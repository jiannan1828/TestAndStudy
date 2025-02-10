#include "stm32f4xx.h"
#include "tim.h"

uint32_t LocalTime = 0;

void TIM3_Config(void)
{
		// 設置一個每10ms 就觸發一次中斷的TIMER
    TIM_TimeBaseInitTypeDef TIM_TimeBaseStructure;
		NVIC_InitTypeDef NVIC_InitStructure;

    RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM3, ENABLE);

    TIM_TimeBaseStructure.TIM_Period = 249;            // 從 0 數到 999
    TIM_TimeBaseStructure.TIM_Prescaler = 1799;        // 180 MHz / 1799 + 1 = 100kHz 請查看 system_stm32f4xx.c 的註解
    TIM_TimeBaseStructure.TIM_ClockDivision = TIM_CKD_DIV1;
    TIM_TimeBaseStructure.TIM_CounterMode = TIM_CounterMode_Up;

    TIM_TimeBaseInit(TIM3, &TIM_TimeBaseStructure);

    TIM_ITConfig(TIM3, TIM_IT_Update, ENABLE);

    TIM_Cmd(TIM3, ENABLE);

    NVIC_InitStructure.NVIC_IRQChannel = TIM3_IRQn;
    NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority = 0x01;  
    NVIC_InitStructure.NVIC_IRQChannelSubPriority = 0x03;         
    NVIC_InitStructure.NVIC_IRQChannelCmd = ENABLE;

    NVIC_Init(&NVIC_InitStructure);
}

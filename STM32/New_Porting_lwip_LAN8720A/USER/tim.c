#include "stm32f4xx.h"
#include "tim.h"

uint32_t LocalTime = 0;

void TIM3_Config(void)
{
		// �]�m�@�ӨC10ms �NĲ�o�@�����_��TIMER
    TIM_TimeBaseInitTypeDef TIM_TimeBaseStructure;
		NVIC_InitTypeDef NVIC_InitStructure;

    RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM3, ENABLE);

    TIM_TimeBaseStructure.TIM_Period = 999;            // �q 0 �ƨ� 999
    TIM_TimeBaseStructure.TIM_Prescaler = 1679;        // 168 MHz / 1680 = 100kHz
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

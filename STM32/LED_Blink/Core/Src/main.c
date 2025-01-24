/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2024 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "gpio.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */

/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */
uint32_t led1_cnt    = 0;
uint32_t led1_B      = 0;
uint32_t led1_isPlus = 0;

uint32_t led2_cnt    = 0;
uint32_t led2_B      = 0;
uint32_t led2_isPlus = 0;

uint32_t led3_cnt    = 0;
uint32_t led3_B      = 0;
uint32_t led3_isPlus = 0;

uint32_t delaycnt = 0;

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{

  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();
  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  /* USER CODE BEGIN 2 */

  /* USER CODE END 2 */
  led1_B = 25;
  led2_B = 50;
  led3_B = 75;
  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
	if(0) {
		HAL_GPIO_WritePin(GPIOH, GPIO_PIN_10, GPIO_PIN_RESET);
		HAL_Delay(50);
		HAL_GPIO_WritePin(GPIOH, GPIO_PIN_10, GPIO_PIN_SET);
		HAL_GPIO_WritePin(GPIOH, GPIO_PIN_11, GPIO_PIN_RESET);
		HAL_Delay(50);
		HAL_GPIO_WritePin(GPIOH, GPIO_PIN_11, GPIO_PIN_SET);
		HAL_GPIO_WritePin(GPIOH, GPIO_PIN_12, GPIO_PIN_RESET);
		HAL_Delay(50);
		HAL_GPIO_WritePin(GPIOH, GPIO_PIN_12, GPIO_PIN_SET);
	} else {
		//Xavier_Tsai
		delaycnt++;
		if(delaycnt>=1000) {
			delaycnt = 0;


			if(led1_isPlus) {
				//+
				led1_B++;
				if(led1_B>=100) {
					led1_isPlus = 0;
				}
			} else {
				//-
				led1_B--;
				if(led1_B<=0) {
					led1_isPlus = 1;
				}
			}

			if(led2_isPlus) {
				//+
				led2_B++;
				if(led2_B>=100) {
					led2_isPlus = 0;
				}
			} else {
				//-
				led2_B--;
				if(led2_B<=0) {
					led2_isPlus = 1;
				}
			}

			if(led3_isPlus) {
				//+
				led3_B++;
				if(led3_B>=100) {
					led3_isPlus = 0;
				}
			} else {
				//-
				led3_B--;
				if(led3_B<=0) {
					led3_isPlus = 1;
				}
			}
		}

		led1_cnt++;
		led2_cnt++;
		led3_cnt++;

		if(led1_cnt>=100) {
			led1_cnt = 0;
		}

		if(led2_cnt>=100) {
			led2_cnt = 0;
		}

		if(led3_cnt>=100) {
			led3_cnt = 0;
		}

		if(led1_cnt<led1_B) {
		    //LED ON
			HAL_GPIO_WritePin(GPIOH, GPIO_PIN_10, GPIO_PIN_RESET);
		} else {
			//LED OFF
			HAL_GPIO_WritePin(GPIOH, GPIO_PIN_10, GPIO_PIN_SET);
		}

		if(led2_cnt<led2_B) {
		    //LED ON
			HAL_GPIO_WritePin(GPIOH, GPIO_PIN_11, GPIO_PIN_RESET);
		} else {
			//LED OFF
			HAL_GPIO_WritePin(GPIOH, GPIO_PIN_11, GPIO_PIN_SET);
		}

		if(led3_cnt<led3_B) {
		    //LED ON
			HAL_GPIO_WritePin(GPIOH, GPIO_PIN_12, GPIO_PIN_RESET);
		} else {
			//LED OFF
			HAL_GPIO_WritePin(GPIOH, GPIO_PIN_12, GPIO_PIN_SET);
		}
	}

  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Configure the main internal regulator output voltage
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE3);

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = RCC_HSICALIBRATION_DEFAULT;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_NONE;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_HSI;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV1;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_0) != HAL_OK)
  {
    Error_Handler();
  }
}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

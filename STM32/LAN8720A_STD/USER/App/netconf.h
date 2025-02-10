/**
  ******************************************************************************
  * @file    netconf.h
  * @author  MCD Application Team
  * @version V1.1.0
  * @date    31-July-2013 
  * @brief   This file contains all the functions prototypes for the netconf.c 
  *          file.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; COPYRIGHT 2013 STMicroelectronics</center></h2>
  *
  * Licensed under MCD-ST Liberty SW License Agreement V2, (the "License");
  * You may not use this file except in compliance with the License.
  * You may obtain a copy of the License at:
  *
  *        http://www.st.com/software_license_agreement_liberty_v2
  *
  * Unless required by applicable law or agreed to in writing, software 
  * distributed under the License is distributed on an "AS IS" BASIS, 
  * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  * See the License for the specific language governing permissions and
  * limitations under the License.
  *
  ******************************************************************************
  */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __NETCONF_H
#define __NETCONF_H

#ifdef __cplusplus
 extern "C" {
#endif

/* DHCP ���A */
#define DHCP_START                 1
#define DHCP_WAIT_ADDRESS          2
#define DHCP_ADDRESS_ASSIGNED      3
#define DHCP_TIMEOUT               4
#define DHCP_LINK_DOWN             5
	 
/* �q����ip���ɾ����a�} */
#define DEST_IP_ADDR0  192
#define DEST_IP_ADDR1  168
#define DEST_IP_ADDR2  1
#define DEST_IP_ADDR3  50  
#define DEST_PORT      5000 

 /* STM32 MAC�a�} */
#define MAC_ADDR0  0x00
#define MAC_ADDR1  0x80
#define MAC_ADDR2  0xE1
#define MAC_ADDR3  0x00
#define MAC_ADDR4  0x00
#define MAC_ADDR5  0x00
	 
/* STM32 IP�a�} */
#define IP_ADDR0         192
#define IP_ADDR1         168
#define IP_ADDR2           1
#define IP_ADDR3          100

/* STM32 �B���X */
#define NETMASK_ADDR0    255
#define NETMASK_ADDR1    255
#define NETMASK_ADDR2    255
#define NETMASK_ADDR3      0

/* ���ަa�} */
#define GW_ADDR0         192
#define GW_ADDR1         168
#define GW_ADDR2           1
#define GW_ADDR3           1

/* �ˬd PHY �s�����A���ɶ����j */
#define LINK_TIMER_INTERVAL    1000

/* ���RMII�Ҧ� */
#define RMII_MODE
	 
void LwIP_Init(void);
void LwIP_Pkt_Handle(void);
void LwIP_Periodic_Handle(__IO uint32_t localtime);

#ifdef __cplusplus
}
#endif

#endif /* __NETCONF_H */


/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/


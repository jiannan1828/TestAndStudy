#ifndef __ETHERNETIF_H__
#define __ETHERNETIF_H__


#include "lwip/err.h"
#include "lwip/netif.h"

err_t ethernetif_init(struct netif *netif);
err_t ethernetif_input(struct netif *netif);

/* MAC Address Definition */
#define MAC_ADDR0  0x00
#define MAC_ADDR1  0x80
#define MAC_ADDR2  0xE1
#define MAC_ADDR3  0x00
#define MAC_ADDR4  0x00
#define MAC_ADDR5  0x00

#endif

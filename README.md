# DHL API C# implementation
A C# implementation for DHL webservices call, to serve as an example for using basic DHL calls.


## API reference
Following examples from [here](http://www.dhl.com/content/dam/downloads/g0/express/solutions/ecom_tools/dhl_webshipping/dhl_web_shipping_user_guide_en.pdf)
The API guide : version 5.0 - and reference using [DHL Express global web services developer guide 3.0.1](https://usermanual.wiki/Pdf/DHL20Express20Global20Web20Services2020Developer20Guide20V31.1018236549.pdf)

## How to build
### Prerequisits : VS2017
### Open solution file
### Build and run

## Tests

## Main flows
Usecase example is as follows:
```
+---------+                             +---------+                                                                                                  +-----+
| CLIENT  |                             | SERVER  |                                                                                                  | DHL |
+---------+                             +---------+                                                                                                  +-----+
     |                                       |                                                                                                          |
     | request package size for product      |                                                                                                          |
     |-------------------------------------->|                                                                                                          |
     |                                       |                                                                                                          |
     |                                       | RateRequest                                                                                              |
     |                                       |--------------------------------------------------------------------------------------------------------->|
     |                                       |                                                                                                          |
     |                                       |    corresponding available DHL products, along with rate estimates and estimated delivery date and time. |
     |                                       |<---------------------------------------------------------------------------------------------------------|
     |                                       |                                                                                                          |
     |                             same list |                                                                                                          |
     |<--------------------------------------|                                                                                                          |
     |                                       |                                                                                                          |
     | selects rate and shipment             |                                                                                                          |
     |-------------------------------------->|                                                                                                          |
     |                                       |                                                                                                          |
     |                                       | ShipmentRequest                                                                                          |
     |                                       |--------------------------------------------------------------------------------------------------------->|
     |                                       |                                                                                                          |
     |                                       |                                                                                 refId and shipping label |
     |                                       |<---------------------------------------------------------------------------------------------------------|
     |                                       |                                                                                                          |
     |              refId and shipping label |                                                                                                          |
     |<--------------------------------------|                                                                                                          |
     |                                       |                                                                                                          |
     | selects pickup?                       |                                                                                                          |
     |-------------------------------------->|                                                                                                          |
     |                                       |                                                                                                          |
     |                                       | requestPickup                                                                                            |
     |                                       |--------------------------------------------------------------------------------------------------------->|
     |                                       |                                                                                                          |
     |                                       |                                                                                                pickupId? |
     |                                       |<---------------------------------------------------------------------------------------------------------|
     |                                       |                                                                                                          |
     |              refid and shipping label |                                                                                                          |
     |<--------------------------------------|                                                                                                          |
     |                                       |                                                                                                          |

```

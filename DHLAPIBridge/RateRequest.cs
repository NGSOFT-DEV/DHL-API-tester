using DHLAPIBridge.expressRateBookServiceReference;


namespace DHLAPIBridge
{
    public class RateRequest
    {

        public static object send()
        {
            var clientRequest = new gblExpressRateBookClient(); 

            var requestedShipment = getRequestedShipment();
            var response = clientRequest.getRateRequest(null, requestedShipment);
            return response;
        }

        private static docTypeRef_RequestedShipmentType2 getRequestedShipment()
        {
            return new docTypeRef_RequestedShipmentType2()
            {
                DropOffType = DropOffType2.REQUEST_COURIER,
                Ship = new docTypeRef_ShipType2()
                {
                    Shipper = new docTypeRef_AddressType2
                    {
                        StreetLines = "1-16-24, Minami-gyotoku",
                        City = "Ichikawa-shi, Chiba",
                        PostalCode = "272-0138",
                        CountryCode = "JP"
                    },
                    Recipient = new docTypeRef_AddressType2
                    {
                        StreetLines = "63 RENMIN LU, QINGDAO SHI",
                        City = "QINGDAO SHI",
                        PostalCode = "266033",
                        CountryCode = "CN"
                    }
                },
                Packages = new docTypeRef_RequestedPackagesType2[]
                {
                    new docTypeRef_RequestedPackagesType2()
                    {
                        numberSpecified = true,
                        number = 1,
                        //Items = new object[] {
                        //     new docTypeRef_DimensionsType2()
                        //    {
                        //        Length =13m,
                        //        Width = 12m,
                        //        Height = 9m
                        //    },
                        //    new docTypeRef_WeightType(){
                        //        Value = 2.0m
                        //    }

                        //}
                    }
                },
                ShipTimestamp = "2010-11-26T12:00:00GMT-06:00",
                UnitOfMeasurement = UnitOfMeasurement2.SU,
                Content = Content2.NON_DOCUMENTS,
                DeclaredValue = 0000000200m,
                DeclaredValueCurrencyCode = "USD",
                PaymentInfo = PaymentInfo2.DAP,
                PaymentInfoSpecified = true,
                Account = "411228399"
            };
        }
    }
}

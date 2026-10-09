using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask05
{
    static class DeliveryHelper 
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask05
{
    internal abstract class Shipment
    {
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return _trackingCode; }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
            _description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
            _weight = weight > 0 ? weight : 1.0m;
            _deliveryFee = deliveryFee > 0 ? deliveryFee : 50.0m;

            Destination = destination;
        }

        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1.0m, 50.0m, new DeliveryAddress("Cairo", "Main St.", 1)) { }

        public abstract decimal EstimatedCost { get; }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }
        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {
            if (baseWeight > 0 && extraPackingWeight >= 0)
            {
                Weight = baseWeight + extraPackingWeight;
            }
        }
        public abstract void PrintShipment (); 

      
    }


    }
}

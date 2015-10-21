using System;

namespace OnlineOrdering.Common.Messages
{
    public class Order
    {
        public Guid TrackingNumber { get; private set; }
        public int OrderId { get; private set; }
        public string Item { get; private set; }
        public int Quantity { get; private set; }

        public Order(int id, string item, int quantity)
        {
            // This creates new GUID whenever new order object gets create
            TrackingNumber = Guid.NewGuid();
            OrderId = id;
            Item = item;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("TrackingNumber: {0} OrderId:{1} Item:{2} Quantity:{3}", 
                this.TrackingNumber, this.OrderId, this.Item, this.Quantity);
        }
    }
}

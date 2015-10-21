using Akka.Actor;
using OnlineOrdering.Common.Messages;

namespace OnlineOrdering.Common.Actors
{
    public class PlaceOrder:ReceiveActor
    {
        public string OrderProcesserActorPath { get; private set; }

        public PlaceOrder(string orderProcesserActorPath)
        {
            this.OrderProcesserActorPath = orderProcesserActorPath;
            Receive<Order>(m =>OrderReceiveHandler(m));
        }

        private void OrderReceiveHandler(Order m)
        {
            // Select actor from OrderProcessor actor path
            Context.ActorSelection(OrderProcesserActorPath).Tell(m);
        }
    }
}


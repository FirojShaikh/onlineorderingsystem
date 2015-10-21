using Akka.Actor;
using System;

namespace ProcessOrder.Backend
{
    class Program
    {
        private static ActorSystem OrderProcessingActorSystem;

        static void Main(string[] args)
        {
            Console.WriteLine("Order processing actor system is created...");

            // Create Order processing actor system
            OrderProcessingActorSystem = ActorSystem.Create("OrderProcessingActorSystem");

            // Create ProcessOrder actor in actor system
            OrderProcessingActorSystem.ActorOf<OnlineOrdering.Common.Actors.ProcessOrder>("ProcessOrder");

            OrderProcessingActorSystem.AwaitTermination();
        }
    }
}

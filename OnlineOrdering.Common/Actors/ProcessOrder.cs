using Akka.Actor;
using System;

namespace OnlineOrdering.Common.Actors
{
    /// <summary>
    /// Responsible for processing order
    /// </summary>
    public class ProcessOrder : ReceiveActor
    {
        public ProcessOrder()
        {
            Receive<Messages.Order>(m => Console.WriteLine("Order received for processing. {0}", m));
        }
    }
}

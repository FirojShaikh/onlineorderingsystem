using Akka.Actor;
using OnlineOrdering.Common.Messages;
using System.Web.Http;

namespace PlaceOrder.WebAPI.Controllers
{
    public class PlaceOrderController : ApiController
    {
        // POST: api/PlaceOrder
        [HttpPost]
        public IHttpActionResult Post([FromBody]Order order)
        {
            var orderProcesserActorPath = "akka.tcp://OrderProcessingActorSystem@localhost:8091/user/ProcessOrder";

            // Create an order submitter actor
            var orderSubmitter =
                WebApiApplication.OrderPlacingActorSystem.ActorOf(
                    Props.Create(
                        () =>
                            new OnlineOrdering.Common.Actors.PlaceOrder(orderProcesserActorPath)));

            // Tell backend Order Processor actor about new order
            orderSubmitter.Tell(order);

            // Return same order object
            return Ok(order);
        }
    }
}

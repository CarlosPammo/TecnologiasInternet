using System.Net;
using System.Net.Http;
using System.Web.Http;
using USIP.Model;

namespace USIP.Controller
{
    [AllowAnonymous]
    public class BClientController : BaseController
    {
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var bClients = Repository<BClient>().Select(bClient => true);
            return Request.CreateResponse(HttpStatusCode.OK, new { bClients });
        }

        [HttpPost]
        public HttpResponseMessage Insert(BClient bClient)
        {
            var response = Repository<BClient>();
            
            return response !=null
                ? Request.CreateResponse(HttpStatusCode.OK, response)
                : Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public HttpResponseMessage Update(BClient bClient)
        {
            var response = Repository<BClient>().Update(bClient);
            return response >0
                ? Request.CreateResponse(HttpStatusCode.OK)
                : Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var response = Repository<BClient>().Delete(bClient=>bClient.Id.Equals(id));
            return response 
                ? Request.CreateResponse(HttpStatusCode.OK)
                : Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}

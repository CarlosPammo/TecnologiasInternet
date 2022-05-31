using System.Net;
using System.Net.Http;
using System.Web.Http;
using USIP.Model;

namespace USIP.Controller
{
	[AllowAnonymous]
	public class CredentialController : BaseController
	{
		[HttpGet]
		public HttpResponseMessage GetAll()
		{
			// SELECT * FROM Estudiantes
			var credentials = Repository<Credentials>()
				.Select(RolMain => true);

			return Request.CreateResponse(
				HttpStatusCode.OK,
				new
				{
                    credentials
                });
		}

		[HttpPost]
		public HttpResponseMessage Insert(Credentials credentials)
		{
			var response = Repository<Credentials>()
				.Insert(credentials);

			return response != null
				? Request.CreateResponse(HttpStatusCode.OK, response)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpPut]
		public HttpResponseMessage Update(Credentials credentials)
		{
			var response = Repository<Credentials>()
				.Update(credentials);

			return response > 0
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			var response = Repository<Credentials>()
				.Delete(credentials => credentials.Id.Equals(id));

			return response
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}
	}
}

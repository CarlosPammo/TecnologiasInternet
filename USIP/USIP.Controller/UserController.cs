using System.Net;
using System.Net.Http;
using System.Web.Http;
using USIP.Model;

namespace USIP.Controller
{
	[AllowAnonymous]
	public class UserController : BaseController
	{
		[HttpGet]
		public HttpResponseMessage GetAll()
		{
			// SELECT * FROM Estudiantes
			var user = Repository<User>()
				.Select(User => true);

			return Request.CreateResponse(
				HttpStatusCode.OK,
				new
				{
                    User
                });
		}

		[HttpPost]
		public HttpResponseMessage Insert(User user)
		{
			var response = Repository<User>()
				.Insert(user);

			return response != null
				? Request.CreateResponse(HttpStatusCode.OK, response)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpPut]
		public HttpResponseMessage Update(User user)
		{
			var response = Repository<User>()
				.Update(user);

			return response > 0
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			var response = Repository<User>()
				.Delete(user => user.Id.Equals(id));

			return response
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}
	}
}

using System.Net;
using System.Net.Http;
using System.Web.Http;
using USIP.Model;

namespace USIP.Controller
{   
	[AllowAnonymous]
	public class RolController : BaseController
	{
		[HttpGet]
		public HttpResponseMessage GetAll()
		{
			// SELECT * FROM Estudiantes
			var rol = Repository<RolMain>()
				.Select(RolMain => true);

			return Request.CreateResponse(
				HttpStatusCode.OK,
				new
				{
					rol
				});
		}

		[HttpPost]
		public HttpResponseMessage Insert(RolMain rol)
		{
			var response = Repository<RolMain>()
				.Insert(rol);

			return response != null
				? Request.CreateResponse(HttpStatusCode.OK, response)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpPut]
		public HttpResponseMessage Update(RolMain rol)
		{
			var response = Repository<RolMain>()
				.Update(rol);

			return response > 0
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			var response = Repository<RolMain>()
				.Delete(rol => rol.IdRol.Equals(id));

			return response
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}
	}
}

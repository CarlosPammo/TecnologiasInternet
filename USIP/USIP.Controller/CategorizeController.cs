using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using USIP.Model;

namespace USIP.Controller
{
	[AllowAnonymous]
	public class CategorizeController : BaseController
	{

		[HttpGet]
		public HttpResponseMessage GetAll()
		{

			var categoryzes = Repository<Categoryze>()
				.Select(categoryze => true);

			return Request.CreateResponse(
				HttpStatusCode.OK,
				new
				{
					categoryzes
				});
		}

		[HttpPost]
		public HttpResponseMessage Insert(Categoryze categoryze)
		{
			var response = Repository<Categoryze>()
				.Insert(categoryze);

			return response != null
				? Request.CreateResponse(HttpStatusCode.OK, response)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpPut]
		public HttpResponseMessage Update(Categoryze categoryze)
		{
			var response = Repository<Categoryze>()
				.Update(categoryze);

			return response > 0
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			var response = Repository<Categoryze>()
				.Delete(categoryze => categoryze.Id.Equals(id));

			return response
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}
	}
}

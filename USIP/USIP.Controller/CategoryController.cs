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
    public class CategoryController : BaseController
    {
		[HttpGet]
		public HttpResponseMessage GetAll()
		{
			var categorys = Repository<Category>()
				.Select(category => true);

			return Request.CreateResponse(
				HttpStatusCode.OK,
				new
				{
					categorys
				});
		}

		[HttpPost]
		public HttpResponseMessage Insert(Category category)
		{
			var response = Repository<Category>()
				.Insert(category);

			return response != null
				? Request.CreateResponse(HttpStatusCode.OK, response)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpPut]
		public HttpResponseMessage Update(Category category)
		{
			var response = Repository<Category>()
				.Update(category);

			return response > 0
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			var response = Repository<Category>()
				.Delete(category => category.Id.Equals(id));

			return response
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}
	}
}

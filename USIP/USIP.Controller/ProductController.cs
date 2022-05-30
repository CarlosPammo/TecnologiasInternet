using System.Net;
using System.Net.Http;
using System.Web.Http;
using USIP.Model;

namespace USIP.Controller
{
	[AllowAnonymous]
	public class ProductController : BaseController
	{
		
		[HttpGet]
		public HttpResponseMessage GetAll()
		{
			// SELECT * FROM Estudiantes
			var products = Repository<Product>()
				.Select(product => true);

			return Request.CreateResponse(
				HttpStatusCode.OK,
				new
				{
					products
				});
		}

		[HttpPost]
		public HttpResponseMessage Insert(Product product)
		{
			var response = Repository<Product>()
				.Insert(product);

			return response != null
				? Request.CreateResponse(HttpStatusCode.OK, response)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpPut]
		public HttpResponseMessage Update(Product product)
		{
			var response = Repository<Product>()
				.Update(product);

			return response > 0
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}

		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			var response = Repository<Product>()
				.Delete(product => product.Id.Equals(id));

			return response
				? Request.CreateResponse(HttpStatusCode.OK)
				: Request.CreateResponse(HttpStatusCode.BadRequest);
		}
	}
}

using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace USIP.Core
{
	public class ErrorHandler : ApiControllerActionInvoker
	{
		public override Task<HttpResponseMessage> InvokeActionAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
		{
			var response = base.InvokeActionAsync(actionContext, cancellationToken);
			if (response.Exception == null)
			{
				return response;
			}

			//TODO: Log and track exception
			var content = JsonConvert.SerializeObject(new
			{
				type = response.Exception.GetType(),
				Message = response.Exception.Message
			});

			response = Task.Run(() => new HttpResponseMessage(HttpStatusCode.InternalServerError)
			{
				Content = new StringContent(content),
				ReasonPhrase = "An Exception Ocurred"
			}, cancellationToken);

			return response;
		}
	}
}

using Microsoft.Owin.Security.OAuth;

namespace USIP.Core
{
	//Owin
	public class AccessProvider : OAuthAuthorizationServerProvider
	{
		private readonly string clientId;

		public AccessProvider(string clientId)
		{
			this.clientId = clientId;
		}
	}
}

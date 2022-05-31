using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using USIP.Data;
using USIP.Data.Context;
using USIP.Error.Bussiness;
using USIP.Model;

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

		public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
		{
            
            var user = IsAValidUser(context.UserName);
           
			if (user == null)
			{
				throw new NotValidCredentialsException(context.UserName);
			}
            if (user.Password != context.Password)
            {
                throw new NotValidCredentialsException(context.Password);
            }
            var repository = new Repository<RolMain>(new BaseContext());
            var rol = repository.Select(r => r.IdRol.Equals(user.IdRol)).FirstOrDefault();

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
			identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
			var properties = new Dictionary<string, string>
			{
				{ "username", context.UserName},
                { "rol", Newtonsoft.Json.JsonConvert.SerializeObject(rol)}

				// Other User Custom Settings
			};

			var ticket = new AuthenticationTicket(identity, new AuthenticationProperties(properties));
			context.Validated(ticket);

			return base.GrantResourceOwnerCredentials(context);
		}

		public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
		{
			if (context.ClientId == null)
			{
				context.Validated();
			}
            var rol = context.Parameters.First(n => n.Key.Equals("rol")).Value;
            context.OwinContext.Set("rol",rol.FirstOrDefault());
			return Task.FromResult<object>(null);
		}

		public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
		{
			return context.ClientId != clientId
				? Task.FromResult<object>(null)
				: base.ValidateClientRedirectUri(context);
		}

		public override Task TokenEndpoint(OAuthTokenEndpointContext context)
		{
			foreach (var property in context.Properties.Dictionary)
			{
				context.AdditionalResponseParameters.Add(property.Key, property.Value);
			}
			return Task.FromResult<object>(null);
		}

		private Credentials IsAValidUser(string username )
		{
            var repository = new Repository<Credentials>(new BaseContext());

            // SELECT * FROM Estudiantes
            var user = repository
                .Select(u => u.UserName == username ) //&& u.Rols.Equals(credentials.Rols()))
                .FirstOrDefault();

            return user;
            
		}
	}
}

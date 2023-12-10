using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.DTO;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
	public class AuthService : BaseService, IAuthService
	{
		private readonly IHttpClientFactory _clientFactory;
		private string villaUrl;

        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
			_clientFactory = clientFactory;
			villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");

		}


        public Task<T> LoginAsync<T>(LoginRequestDTO objToCreate)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Url = villaUrl + "/api/v1/UsersAuth/login",
				Data = objToCreate
			});
		}

		public Task<T> RegisterAsync<T>(RegistrationRequestDTO objToCreate)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Url = villaUrl + "/api/v1/UsersAuth/register",
				Data = objToCreate
			});
		}
	}
}

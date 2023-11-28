using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel {
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }

        public Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FlickerApiApp.Controllers
{
    using Models;
    using Services;
    public class FlickerApiController : ApiController
    {
        [Route("api/query/{page_id:int=1}")]
        [HttpGet]
        public async Task<object> GetFlickerPhotosAsync(int page_id=1)
        {
            FlickerApiService api = new FlickerApiService();

            return await api.GetPhotos(page_id);
        }

    }
}
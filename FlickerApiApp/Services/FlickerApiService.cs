using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlickerApiApp.Services
{
    using Models;
    using Newtonsoft.Json;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    public class FlickerApiService
    {

        #region Initialization
        private string method = "flickr.photos.search";
        public string Method
        {
            get { return method; }
            set { method = value; }
        }

        private string tags = "soccer";

        public string Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        private string api_key = "84b888e09ee680cb603ab7ec3621bd2d";

        private int page = 1;

        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        public string Endpoint
        {
            get
            {
                return "https://api.flickr.com/services/rest/?method=" + Method + "&tags=" + Tags + "&api_key=" + api_key + "&format=json&nojsoncallback=1&per_page=10&page="+Page;
            }
        }
        #endregion

        public async Task<RootObject> GetPhotos(int page_id=1)
        {
            Page = page_id;

            var request = WebRequest.Create(Endpoint);
            request.ContentType = "application/json; charset=utf-8";
            string json;
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                json = sr.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<RootObject>(json); ;
        }
    }
}
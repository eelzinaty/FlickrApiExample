using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlickerApiApp.Models
{
    public class PhotoItem
    {
        public decimal id {get; set;}
        public string owner {get; set;}
        public string secret{get; set;}
        public int server{get; set;}
        public int farm{get; set;}
        public string title{get; set;}
        public bool ispublic{get; set;}
        public bool isfriend{get; set;}
        public bool isfamily { get; set; }

        public string image_url
        {
            get
            {
                return "https://farm" + farm + ".staticflickr.com/" + server + "/" + id + "_" + secret + ".jpg";
            }
        }
    }

    public class Photos
    {
        public int page{get; set;}
        public int pages{get; set;}
        public int perpage{get; set;}
        public int total { get; set; }
        public List<PhotoItem> photo { get; set; }
    }

    public class RootObject
    {
        public Photos photos { get; set; }
        public string stat { get; set; }
    }  
}
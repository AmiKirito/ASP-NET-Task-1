using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_Task_1.Models
{
    public class Survey
    {
        public string AuthorName{ get; set; }
        public DateTime PostDate { get; set; }
        public string ReviewText { get; set; }
    }
}
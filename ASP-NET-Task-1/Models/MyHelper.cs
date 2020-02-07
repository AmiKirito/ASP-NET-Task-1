using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_Task_1.Models
{
    public static class MyHelper
    {
        public static MvcHtmlString UlHelper(this HtmlHelper html, List<string> data)
        {
            var ul = new TagBuilder("ul");
            foreach (var item in data)
            {
                var li = new TagBuilder("li");
                li.InnerHtml = item.ToString();
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }
    }
}
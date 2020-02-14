using System.Web.Mvc;
using System.Collections.Generic;

namespace ASP_NET_Task_1.Helpers.HtmlHelperExtensions
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
        public static MvcHtmlString OlHelper(this HtmlHelper html, List<string> data)
        {
            var ul = new TagBuilder("ol");
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
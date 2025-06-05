using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebBanHangOnline.Helpers
{
    public static class HtmlHelpers
    {


        public static IHtmlString CustomTag(this HtmlHelper htmlHelper, string tagName, string className, string content)
        {
            var tagBuilder = new TagBuilder(tagName);
            tagBuilder.AddCssClass(className);
            tagBuilder.SetInnerText(content);
            return new HtmlString(tagBuilder.ToString());
        }

    }
}
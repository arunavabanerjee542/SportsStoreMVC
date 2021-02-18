using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportsStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory _urlHelper;

        public PageLinkTagHelper(IUrlHelperFactory urlHelper)
        {
            _urlHelper = urlHelper;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext CurrentContext { get; set; }

        public string Action { get; set; }
        public PageInfo PageModel { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper url = _urlHelper.GetUrlHelper(CurrentContext);
            var tagDiv = new TagBuilder("div");
            for (int i=1;i<=PageModel.TotalPages;i++)
            {
                var tagRef = new TagBuilder("a");
                tagRef.Attributes["href"] = url.Action(Action, new { pagesize = i });
                tagRef.InnerHtml.Append(i.ToString());
                tagDiv.InnerHtml.AppendHtml(tagRef);

            }

            output.Content.AppendHtml(tagDiv.InnerHtml);

        }






    }
}

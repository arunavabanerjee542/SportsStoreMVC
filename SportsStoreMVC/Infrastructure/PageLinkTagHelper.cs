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

        public string PageAction { get; set; }
        public PageInfo PageModel { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix ="page-url-")]
        public Dictionary<string, object> PageLinkUrls { get; set; }
            = new Dictionary<string, object>();
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper url = _urlHelper.GetUrlHelper(CurrentContext);
            var tagDiv = new TagBuilder("div");
            for (int i=1;i<=PageModel.TotalPages;i++)
            {
                var tagRef = new TagBuilder("a");
                PageLinkUrls["pagesize"] = i;
                tagRef.Attributes["href"] = url.Action(PageAction, PageLinkUrls);

                if (PageClassesEnabled)
                {
                    tagRef.AddCssClass(PageClass);
                    tagRef.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }
                tagRef.InnerHtml.Append(i.ToString());
                tagDiv.InnerHtml.AppendHtml(tagRef);

            }
            output.Content.AppendHtml(tagDiv.InnerHtml);

        }

    }
}

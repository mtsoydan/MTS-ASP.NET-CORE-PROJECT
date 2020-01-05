using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Northwind.AspMvcCoreUI.TagHelpers
{
    //html içinde ne isimle kullanmak istiyoruz
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper:TagHelper
    {
        //kaç sayfa kaç pagesize vs oluşturuluyor
        [HtmlAttributeName("page-size")] 
        public int pageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int pageCount { get; set; }
        [HtmlAttributeName("page-currentCategory")]
        public int currentCategory { get; set; }
        [HtmlAttributeName("page-currentPage")]
        public int currentPage { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
             stringBuilder.AppendFormat("<nav aria-label='Page navigation example'>");

            stringBuilder.Append("<ul class='pagination '>");
            for (int i = 1; i <= pageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='page-item {0}'>", i==currentPage ? "active " :"");
                stringBuilder.AppendFormat("<a class='page-link' href='/product/index?pageID={0}&categoryID={1}'>{2}</a>", i,currentCategory,i);
                stringBuilder.AppendFormat("</li>");

            }
            stringBuilder.AppendFormat("</nav>");

            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);  
        }
    }
}

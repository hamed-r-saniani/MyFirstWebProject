using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private string EmailDomain = "outlook.com";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var Content = await output.GetChildContentAsync();
            var Target = Content.GetContent() + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + Target);
            output.Content.SetContent(Target);
        }

        // I Am Use It In Index View In Sample Controller With Tag <email>...</email>
    }
}

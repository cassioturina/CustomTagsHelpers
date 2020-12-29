using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace CustomTagsHelpers.Extensions
{
    [HtmlTargetElement("a", Attributes = "somente-admin")]
    public class SomenteAdminTagHelper : TagHelper
    {
        [HtmlAttributeName("somente-admin")]
        public bool EhAdmin { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (output == null)
                throw new ArgumentNullException(nameof(output));


            if (EhAdmin) return;

            output.Attributes.RemoveAll("href");
            output.Attributes.Add(new TagHelperAttribute("style", "cursor: not-allowed"));
            output.Attributes.Add(new TagHelperAttribute("title", "Acesso Somente para Administradores"));
        }
    }

}
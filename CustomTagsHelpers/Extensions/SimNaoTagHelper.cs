using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace CustomTagsHelpers.Extensions
{
    [HtmlTargetElement("span", Attributes = "sim-nao")]
    public class SimNaoTagHelper : TagHelper
    {
        [HtmlAttributeName("sim-nao")]
        public bool Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var badgeType = Value ? "badge-success" : "badge-danger";

            var texto = Value ? "SIM" : "NÃO";

            output.Attributes.Add(new TagHelperAttribute("class", $"badge badge-pill p-2 rounded  {badgeType}"));
            output.Content.Append(texto);
        }


    }

}
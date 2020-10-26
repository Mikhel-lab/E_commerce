#pragma checksum "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c4d4242b3ea0193ef2fc9c743a87ea68efb5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c4d4242b3ea0193ef2fc9c743a87ea68efb5ab", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3020564cfdc9765f49d55435a4ba3dac0d5190e0", @"/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
   
	ViewData["Title"] = "Details";
	Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(91, 59, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"span9\">\r\n\t<ul class=\"breadcrumb\">\r\n\t\t<li>");
            EndContext();
            BeginContext(150, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48c4d4242b3ea0193ef2fc9c743a87ea68efb5ab3893", async() => {
                BeginContext(194, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(202, 455, true);
            WriteLiteral(@" <span class=""divider"">/</span></li>
		<li class=""active"">Invoice Details</li>
	</ul>

</div>

<section id=""Table"">
	<div class=""page-header"">
		<h3>Invoice Details</h3>
	</div>
	<div class=""row-fluid"">
		<div class=""span6"">
			<table class=""table"">
				<thead>
					<tr>
						<th>Product Id</th>
						<th>Product Name</th>
						<th>Price</th>
						<th>Quantity</th>
						<td>Sub Total</td>
					</tr>
				</thead>
				<tbody>
");
            EndContext();
#line 34 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
                     foreach (var invoiceDetail in ViewBag.invoiceDetails)
					{

#line default
#line hidden
            BeginContext(726, 21, true);
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(748, 24, false);
#line 37 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
                       Write(invoiceDetail.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(772, 17, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(790, 26, false);
#line 38 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
                       Write(invoiceDetail.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(816, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>$");
            EndContext();
            BeginContext(835, 19, false);
#line 39 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
                        Write(invoiceDetail.Price);

#line default
#line hidden
            EndContext();
            BeginContext(854, 17, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(872, 22, false);
#line 40 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
                       Write(invoiceDetail.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(894, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>$");
            EndContext();
            BeginContext(914, 45, false);
#line 41 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
                         Write(invoiceDetail.Price * invoiceDetail.Quantity );

#line default
#line hidden
            EndContext();
            BeginContext(960, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 43 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Customer\Details.cshtml"
					}

#line default
#line hidden
            BeginContext(987, 60, true);
            WriteLiteral("\r\n\t\t\t\t</tbody>\r\n\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
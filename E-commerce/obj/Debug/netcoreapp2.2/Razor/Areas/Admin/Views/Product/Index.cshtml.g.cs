#pragma checksum "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d50107ba6a40db426afcd35f563062b5715b4070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50107ba6a40db426afcd35f563062b5715b4070", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3020564cfdc9765f49d55435a4ba3dac0d5190e0", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onClick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "photo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(99, 160, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<section class=\"content-header\">\r\n\r\n\t<h2>Product List</h2>\r\n\r\n</section>\r\n\r\n<section class=\"content\">\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-xs-12\">\r\n");
            EndContext();
#line 19 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
             if (TempData["error"] != null)
			{

#line default
#line hidden
            BeginContext(301, 56, true);
            WriteLiteral("\t\t\t\t<div class=\"alert alert-danger alert-dismissible\">\r\n");
            EndContext();
            BeginContext(454, 85, true);
            WriteLiteral("\t\t\t\t\t<h4><i class=\"icon fa fa-ban\"></i>Failed</h4>\r\n\t\t\t\t\tDeleted Failed\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 26 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(545, 597, true);
            WriteLiteral(@"

		</div>
	</div>
	<div class=""row"">
		<div class=""col-xs-12"">

			<div class=""box"">
				<div class=""box-header"">
					<h3 class=""box-title"">
						Product List
					</h3>
				</div>
			</div>


			<!-- /.box-header -->
			<div class=""box-body"">
				<table id=""productListTable"" class=""table table-bordered table-hover"">
					<thead>
						<tr>
							<th>Id</th>
							<th>Name</th>
							<th>Photo</th>
							<th>Price</th>
							<th>Status</th>
							<th>Category</th>
							<th>Featured</th>
							<th>Action</th>
						</tr>
					</thead>
					<tbody>
");
            EndContext();
#line 59 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                         foreach (var product in ViewBag.Products)
						{
							E_commerce.Models.Product pr = (E_commerce.Models.Product)product;
							var photo = pr.Photos.SingleOrDefault(p => p.Featured == true);

#line default
#line hidden
            BeginContext(1348, 23, true);
            WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1372, 10, false);
#line 64 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                           Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1382, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1401, 12, false);
#line 65 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                           Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 25, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td></td>\r\n");
            EndContext();
            BeginContext(1507, 11, true);
            WriteLiteral("\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1519, 13, false);
#line 68 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1552, 32, false);
#line 69 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                            Write(product.Status ? "Show" : "Hide");

#line default
#line hidden
            EndContext();
            BeginContext(1585, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1605, 34, false);
#line 70 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                            Write(product.Featured ? "Featured" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1640, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1660, 21, false);
#line 71 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                            Write(product.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1682, 30, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>\r\n\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1712, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50107ba6a40db426afcd35f563062b5715b407010255", async() => {
                BeginContext(1802, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1810, 14, true);
            WriteLiteral(" |\r\n\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1824, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50107ba6a40db426afcd35f563062b5715b407013081", async() => {
                BeginContext(1957, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                   WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1967, 16, true);
            WriteLiteral(" |\r\n\r\n\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1983, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50107ba6a40db426afcd35f563062b5715b407015998", async() => {
                BeginContext(2072, 10, true);
                WriteLiteral("Photo List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2086, 14, true);
            WriteLiteral(" |\r\n\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2100, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50107ba6a40db426afcd35f563062b5715b407018830", async() => {
                BeginContext(2187, 9, true);
                WriteLiteral("Add Photo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                              WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2200, 31, true);
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 85 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Areas\Admin\Views\Product\Index.cshtml"

						}

#line default
#line hidden
            BeginContext(2242, 573, true);
            WriteLiteral(@"
					</tbody>
					<tfoot>
						<tr>
							<th>Id</th>
							<th>Name</th>
							<th>Photo</th>
							<th>Price</th>
							<th>Status</th>
							<th>Category</th>
							<th>Featured</th>
							<th>Action</th>
						</tr>
					</tfoot>
				</table>
			</div>
			<!-- /.box-body -->
		</div>
	</div>
</section>

<script>
	$(function () {

		$('#productListTable').DataTable({
			'paging': true,
			'lengthChange': false,
			'searching': false,
			'ordering': true,
			'info': true,
			'autoWidth': false
		})
	})
</script>




");
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

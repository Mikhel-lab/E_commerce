#pragma checksum "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d78d516083ae706641f47688f207e5fe0f7f336c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Search_Index), @"mvc.1.0.view", @"/Views/Shared/Components/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Search/Index.cshtml", typeof(AspNetCore.Views_Shared_Components_Search_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78d516083ae706641f47688f207e5fe0f7f336c", @"/Views/Shared/Components/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3020564cfdc9765f49d55435a4ba3dac0d5190e0", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 948, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d78d516083ae706641f47688f207e5fe0f7f336c4452", async() => {
                BeginContext(98, 65, true);
                WriteLiteral("\r\n\t<input id=\"srchFld\" class=\"srchTxt\" type=\"text\" name=\"keyword\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 163, "\"", 185, 1);
#line 2 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
WriteAttributeValue("", 171, Model.keyword, 171, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(186, 52, true);
                WriteLiteral("/>\r\n\t<select class=\"srchTxt\" name=\"categoryId\"> \r\n\r\n");
                EndContext();
#line 5 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
         foreach (var category in Model.categories)
		{
			

#line default
#line hidden
#line 7 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
             if (category.InverseParents != null && category.InverseParents.Count > 0)
			{

#line default
#line hidden
                BeginContext(375, 11, true);
                WriteLiteral("\t\t<optgroup");
                EndContext();
                BeginWriteAttribute("label", " label=\"", 386, "\"", 408, 1);
#line 9 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
WriteAttributeValue("", 394, category.Name, 394, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(409, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 10 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                     foreach (var subCategory in category.InverseParents)
					{

						

#line default
#line hidden
#line 13 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                         if (subCategory.Status)
						{

#line default
#line hidden
                BeginContext(523, 7, true);
                WriteLiteral("\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(530, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d78d516083ae706641f47688f207e5fe0f7f336c6926", async() => {
                    BeginContext(630, 16, false);
#line 15 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                                                                                                                          Write(subCategory.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 15 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                               WriteLiteral(subCategory.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
AddHtmlAttributeValue("", 571, subCategory.Id == Model.categoryId ? "selected" : "", 571, 55, false);

#line default
#line hidden
                AddHtmlAttributeValue(" ", 626, "", 627, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(655, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
						}

#line default
#line hidden
#line 16 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                         

					}

#line default
#line hidden
                BeginContext(676, 21, true);
                WriteLiteral("\t\t\t \r\n\t\t</optgroup>\r\n");
                EndContext();
#line 21 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
			}
			else
			{

#line default
#line hidden
                BeginContext(718, 4, true);
                WriteLiteral("\t\t\t\t");
                EndContext();
                BeginContext(722, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d78d516083ae706641f47688f207e5fe0f7f336c10366", async() => {
                    BeginContext(816, 13, false);
#line 24 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                                                                                                        Write(category.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 24 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
                   WriteLiteral(category.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
AddHtmlAttributeValue("", 761, category.Id == Model.categoryId ? "selected" : "", 761, 52, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(838, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
			}

#line default
#line hidden
#line 25 "C:\Users\SDSD\source\repos\E-commerce\E-commerce\Views\Shared\Components\Search\Index.cshtml"
             
		}

#line default
#line hidden
                BeginContext(851, 90, true);
                WriteLiteral("\t</select>\r\n\t<button type=\"submit\" id=\"submitButton\" class=\"btn btn-primary\">Go</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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

#pragma checksum "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92d398cc317bad9a291d162bf4ee2ae3793dbeb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drive_ShowMore), @"mvc.1.0.view", @"/Views/Drive/ShowMore.cshtml")]
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
#nullable restore
#line 1 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
using Constructor.Storage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d398cc317bad9a291d162bf4ee2ae3793dbeb3", @"/Views/Drive/ShowMore.cshtml")]
    #nullable restore
    public class Views_Drive_ShowMore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Drive>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d398cc317bad9a291d162bf4ee2ae3793dbeb32838", async() => {
                WriteLiteral("\r\n        <label>Id   </label>");
#nullable restore
#line 5 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                       Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Название   </label>");
#nullable restore
#line 7 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Ссылка   </label>");
#nullable restore
#line 9 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                           Write(Model.Img);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Количество   </label>");
#nullable restore
#line 11 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Цена   </label>");
#nullable restore
#line 13 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                         Write(Model.Cost);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Размер   </label>");
#nullable restore
#line 15 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                           Write(Model.Size);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Емкость  </label>");
#nullable restore
#line 17 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
                           Write(Model.Volume);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <br /><br /><br />\r\n");
#nullable restore
#line 20 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
         using (Html.BeginForm("MainPage", "Main"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" value=\"В главное меню\">\r\n");
#nullable restore
#line 23 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\Drive\ShowMore.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Drive> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

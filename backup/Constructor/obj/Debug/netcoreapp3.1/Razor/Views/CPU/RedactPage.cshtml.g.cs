#pragma checksum "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d7017f9205a22804b56d47749b1d071bc2bc77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CPU_RedactPage), @"mvc.1.0.view", @"/Views/CPU/RedactPage.cshtml")]
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
#line 1 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
using Constructor.Storage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d7017f9205a22804b56d47749b1d071bc2bc77", @"/Views/CPU/RedactPage.cshtml")]
    #nullable restore
    public class Views_CPU_RedactPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CPU>
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d7017f9205a22804b56d47749b1d071bc2bc772840", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
         using (Html.BeginForm("RedactCpu", "CPU", FormMethod.Post))
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Название   </label><input type=\"text\" name=\"_Name\"");
                BeginWriteAttribute("value", " value=", 217, "", 235, 1);
#nullable restore
#line 9 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 224, Model.Name, 224, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Ссылка   </label><input type=\"text\" name=\"_Img\"");
                BeginWriteAttribute("value", " value=", 312, "", 329, 1);
#nullable restore
#line 10 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 319, Model.Img, 319, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Количество   </label><input type=\"text\" name=\"_Count\"");
                BeginWriteAttribute("value", " value=", 412, "", 431, 1);
#nullable restore
#line 11 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 419, Model.Count, 419, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Цена   </label><input type=\"text\" name=\"_Cost\"");
                BeginWriteAttribute("value", " value=", 507, "", 525, 1);
#nullable restore
#line 12 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 514, Model.Cost, 514, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Сокет   </label><input type=\"text\" name=\"_Socket\"");
                BeginWriteAttribute("value", " value=", 604, "", 624, 1);
#nullable restore
#line 13 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 611, Model.Socket, 611, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>Частота   </label>       <input type=\"text\" name=\"_Frequency\"");
                BeginWriteAttribute("value", " value=", 715, "", 738, 1);
#nullable restore
#line 14 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 722, Model.Frequency, 722, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>ECC  </label><input type=\"text\" name=\"_ECC\"");
                BeginWriteAttribute("value", " value=", 811, "", 828, 1);
#nullable restore
#line 15 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 818, Model.ECC, 818, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <label>TDP </label><input type=\"text\" name=\"_TDP\"");
                BeginWriteAttribute("value", " value=", 900, "", 917, 1);
#nullable restore
#line 16 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 907, Model.TDP, 907, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 970, "\"", 987, 1);
#nullable restore
#line 17 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
WriteAttributeValue("", 978, Model.Id, 978, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"submit\" value=\"Изменить запись\">\r\n");
#nullable restore
#line 19 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br /><br /><br />\r\n");
#nullable restore
#line 21 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
         using (Html.BeginForm("MainPage", "Main"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" value=\"В главное меню\">\r\n");
#nullable restore
#line 24 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\CPU\RedactPage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CPU> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7144b681300fecfc50c8e059571c10a8ef53425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DbChange_AddToDb), @"mvc.1.0.view", @"/Views/DbChange/AddToDb.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7144b681300fecfc50c8e059571c10a8ef53425", @"/Views/DbChange/AddToDb.cshtml")]
    #nullable restore
    public class Views_DbChange_AddToDb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7144b681300fecfc50c8e059571c10a8ef534252617", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddCase", "Case", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
        <input type=""text"" name=""_FormFactor"" placeholder=""Формфактор"" /><br />
        <input type=""text"" name=""_FAN140Count"" placeholder=""Количество вентиляторов 140мм"" /><br />
        <input type=""text"" name=""_FAN120Count"" placeholder=""Количество вентиляторов 120мм"" /><br />
        <input type=""text"" name=""_FAN90Count"" placeholder=""Количество вентиляторов 90мм"" /><br />
        <input type=""text"" name=""_Drive25Count"" placeholder=""Количество ЖД 2.5"" /><br />
        <input type=""text"" name=""_Drive35Count"" placeholder=""Количество ЖД 3.5"" /><br />
");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить корпус\">\r\n");
#nullable restore
#line 18 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddCpu", "CPU", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral(@"        <input type=""text"" name=""_Socket"" placeholder=""Сокет"" /><br />
        <input type=""text"" name=""_Frequency"" placeholder=""Частота"" /><br />
        <input type=""text"" name=""_ECC"" placeholder=""ЕСС"" /><br />
        <input type=""text"" name=""_TDP"" placeholder=""TDP"" /><br />
");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить CPU\">\r\n");
#nullable restore
#line 34 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 36 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddDrive", "Drive", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral("        <input type=\"text\" name=\"_Size\" placeholder=\"Размер ЖД\" /><br />\r\n        <input type=\"text\" name=\"_Volume\" placeholder=\"Объем ЖД\" /><br />\r\n");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить ЖД\">\r\n");
#nullable restore
#line 48 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 50 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddFAN", "FAN", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral("        <input type=\"text\" name=\"_Size\" placeholder=\"Размер\" /><br />\r\n");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить Вентилятор\">\r\n");
#nullable restore
#line 61 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 63 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddFSP", "FSP", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral("        <input type=\"text\" name=\"_Output\" placeholder=\"Мощность\" /><br />\r\n        <input type=\"text\" name=\"_FormFactor\" placeholder=\"Формфактор\" /><br />\r\n");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить блок питания\">\r\n");
#nullable restore
#line 75 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 77 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddGPU", "GPU", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral(@"        <input type=""text"" name=""_Clock"" placeholder=""Частота"" /><br />
        <input type=""text"" name=""_MemorySize"" placeholder=""Объем памяти"" /><br />
        <input type=""text"" name=""_MemoryType"" placeholder=""Тип памяти"" /><br />
        <input type=""text"" name=""_TDP"" placeholder=""TDP"" /><br />
        <input type=""text"" name=""_RecommendFSPPower"" placeholder=""Рекомендуемая мощность блока питания"" /><br />
");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить GPU\">\r\n");
#nullable restore
#line 92 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 94 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddMotherboard", "Motherboard", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral(@"        <input type=""text"" name=""_Socket"" placeholder=""Сокет"" /><br />
        <input type=""text"" name=""_Chipset"" placeholder=""Чипсчет"" /><br />
        <input type=""text"" name=""_MemoryType"" placeholder=""Тип памяти"" /><br />
        <input type=""text"" name=""_ECC"" placeholder=""ECC"" /><br />
        <input type=""text"" name=""_RAMCount"" placeholder=""Количество ОЗУ"" /><br />
        <input type=""text"" name=""_FANCount"" placeholder=""Количество Вентиляторв"" /><br />
        <input type=""text"" name=""_DriveCount"" placeholder=""Количество ЖД"" /><br />
        <input type=""text"" name=""_Formfactor"" placeholder=""Формфактор"" /><br />
");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить материнскую плату\">\r\n");
#nullable restore
#line 113 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 115 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddRAM", "RAM", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral(@"        <input type=""text"" name=""_MemorySize"" placeholder=""Объем памяти"" /><br />
        <input type=""text"" name=""_MemoryType"" placeholder=""Тип памяти"" /><br />
        <input type=""text"" name=""_ECC"" placeholder=""ECC"" /><br />
        <input type=""submit"" value=""Добавить ОЗУ"">
");
#nullable restore
#line 127 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n");
#nullable restore
#line 129 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("AddCpuFan", "CpuFan", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <input type=""text"" name=""_Name"" placeholder=""Название"" /><br />
        <input type=""text"" name=""_Img"" placeholder=""Ссылка на изображение"" /><br />
        <input type=""text"" name=""_Count"" placeholder=""Количество"" /><br />
        <input type=""text"" name=""_Cost"" placeholder=""цена"" /><br />
");
                WriteLiteral("        <input type=\"text\" name=\"_TDP\" placeholder=\"Максимальное тепловыделение процессора\" /><br />\r\n        <input type=\"text\" name=\"_Sockets\" placeholder=\"Список поддерживаемых сокетов\" /><br />\r\n        <input type=\"submit\" value=\"Добавить кулер\">\r\n");
#nullable restore
#line 140 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br /><br /><br />\r\n");
#nullable restore
#line 142 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
     using (Html.BeginForm("MainPage", "Main"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\" value=\"В главное меню\">\r\n");
#nullable restore
#line 145 "C:\Users\S7yka4\Desktop\Constructor\backup\Constructor\Views\DbChange\AddToDb.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
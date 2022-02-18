#pragma checksum "D:\DoAn_HK5_2021_2022\DoAnKTPM\DoAnKTPM\Areas\Admin\Views\Accounts\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6e62435c2012db54dcfaa4df0b71f909636381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Accounts_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Accounts/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6e62435c2012db54dcfaa4df0b71f909636381", @"/Areas/Admin/Views/Accounts/Edit.cshtml")]
    public class Areas_Admin_Views_Accounts_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnKTPM.Models.Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAn_HK5_2021_2022\DoAnKTPM\DoAnKTPM\Areas\Admin\Views\Accounts\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Account</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Username"" class=""control-label""></label>
                <input asp-for=""Username"" class=""form-control"" />
                <span asp-validation-for=""Username"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Password"" class=""control-label""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validatio");
            WriteLiteral(@"n-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Phone"" class=""control-label""></label>
                <input asp-for=""Phone"" class=""form-control"" />
                <span asp-validation-for=""Phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address"" class=""control-label""></label>
                <input asp-for=""Address"" class=""form-control"" />
                <span asp-validation-for=""Address"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FullName"" class=""control-label""></label>
                <input asp-for=""FullName"" class=""form-control"" />
                <span asp-validation-for=""FullName"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""");
            WriteLiteral("form-check-input\" asp-for=\"IsAdmin\" /> ");
#nullable restore
#line 49 "D:\DoAn_HK5_2021_2022\DoAnKTPM\DoAnKTPM\Areas\Admin\Views\Accounts\Edit.cshtml"
                                                                    Write(Html.DisplayNameFor(model => model.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""Avatar"" class=""control-label""></label>
                <input asp-for=""Avatar"" class=""form-control"" />
                <span asp-validation-for=""Avatar"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Status"" /> ");
#nullable restore
#line 59 "D:\DoAn_HK5_2021_2022\DoAnKTPM\DoAnKTPM\Areas\Admin\Views\Accounts\Edit.cshtml"
                                                                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnKTPM.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
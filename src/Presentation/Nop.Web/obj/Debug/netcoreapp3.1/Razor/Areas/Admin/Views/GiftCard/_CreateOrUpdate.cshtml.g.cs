#pragma checksum "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GiftCard__CreateOrUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/GiftCard/_CreateOrUpdate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb89", @"/Areas/Admin/Views/GiftCard/_CreateOrUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fc001bec9b9051be7c0e8384dd6aba6ede59658", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_GiftCard__CreateOrUpdate : Nop.Web.Framework.Mvc.Razor.NopRazorPage<GiftCardModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-name", "gift-card-info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-icon", "fa fa-info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-name", "gift-card-usage-history", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-icon", "fa fa-history", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("gift-card-panels"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopPanelsTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopPanelsTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopPanelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
  
    const string hideInfoBlockAttributeName = "GiftCardPage.HideInfoBlock";
    var hideInfoBlock = genericAttributeService.GetAttribute<bool>(workContext.CurrentCustomer, hideInfoBlockAttributeName);

    const string hideUsageHistoryBlockAttributeName = "GiftCardPage.HideUsageHistoryBlock";
    var HideUsageHistoryBlock = genericAttributeService.GetAttribute<bool>(workContext.CurrentCustomer, hideUsageHistoryBlockAttributeName, defaultValue: true);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb8915280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb8916802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 14 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"content\">\r\n    <div class=\"form-horizontal\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-panels", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb8919102", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-panel", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb8919379", async() => {
#nullable restore
#line 19 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
                                                                                                                                                                                                                    Write(await Html.PartialAsync("_CreateOrUpdate.Info", Model));

#line default
#line hidden
#nullable disable
                }
                );
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopPanelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper);
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.PanelIconIsAdvanced = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
                                                                      WriteLiteral(T("Admin.GiftCards.Info"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.Title = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-title", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
                                                                                                                                 WriteLiteral(hideInfoBlockAttributeName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.HideBlockAttributeName = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide-block-attribute-name", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.HideBlockAttributeName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsHide = hideInfoBlock;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsHide, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsAdvanced = false;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-advanced", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsAdvanced, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            \r\n");
#nullable restore
#line 21 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
             if (Model.Id > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-panel", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f8e8e5381412a8d7c9fcd2b74d1a9c39b06fb8924046", async() => {
#nullable restore
#line 23 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
                                                                                                                                                                                                                                                       Write(await Html.PartialAsync("_CreateOrUpdate.History", Model));

#line default
#line hidden
#nullable disable
                }
                );
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopPanelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper);
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.PanelIconIsAdvanced = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
                                                                                      WriteLiteral(T("Admin.GiftCards.History"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.Title = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-title", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
                                                                                                                                                    WriteLiteral(hideUsageHistoryBlockAttributeName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.HideBlockAttributeName = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide-block-attribute-name", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.HideBlockAttributeName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsHide = HideUsageHistoryBlock;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsHide, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsAdvanced = false;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-advanced", __Nop_Web_Framework_TagHelpers_Admin_NopPanelTagHelper.IsAdvanced, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 24 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n            ");
#nullable restore
#line 26 "E:\Noop\src\Presentation\Nop.Web\Areas\Admin\Views\GiftCard\_CreateOrUpdate.cshtml"
       Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.GiftCardDetailsBlock, additionalData = Model }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopPanelsTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopPanelsTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopPanelsTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GiftCardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

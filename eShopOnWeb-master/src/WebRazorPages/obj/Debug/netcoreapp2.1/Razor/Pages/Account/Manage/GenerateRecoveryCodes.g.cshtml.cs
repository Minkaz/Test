#pragma checksum "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32c17108b9758f82d2520412f249ed39c5cb196c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.RazorPages.Pages.Account.Manage.Pages_Account_Manage_GenerateRecoveryCodes), @"mvc.1.0.razor-page", @"/Pages/Account/Manage/GenerateRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/Manage/GenerateRecoveryCodes.cshtml", typeof(Microsoft.eShopWeb.RazorPages.Pages.Account.Manage.Pages_Account_Manage_GenerateRecoveryCodes), null)]
namespace Microsoft.eShopWeb.RazorPages.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages;

#line default
#line hidden
#line 2 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
#line 1 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\_ViewImports.cshtml"
using Microsoft.eShopWeb.RazorPages.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c17108b9758f82d2520412f249ed39c5cb196c", @"/Pages/Account/Manage/GenerateRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb9fa38969894e8ad22792b1abe78d5be5a41ca", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6bde7bcb9243cbfbacb021c8de1205287da9d9", @"/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Pages_Account_Manage_GenerateRecoveryCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData["ActivePage"] = "TwoFactorAuthentication";

#line default
#line hidden
            BeginContext(143, 5, true);
            WriteLiteral("\n<h4>");
            EndContext();
            BeginContext(149, 17, false);
#line 8 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 365, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
            EndContext();
#line 20 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Count(); row += 2)
        {

#line default
#line hidden
            BeginContext(613, 18, true);
            WriteLiteral("            <code>");
            EndContext();
            BeginContext(632, 24, false);
#line 22 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(656, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(669, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(682, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(689, 28, false);
#line 22 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(717, 14, true);
            WriteLiteral("</code><br />\n");
            EndContext();
#line 23 "C:\Users\mindaugas.kazukauska\Desktop\eShopOnWeb-master\src\WebRazorPages\Pages\Account\Manage\GenerateRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(741, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenerateRecoveryCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenerateRecoveryCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenerateRecoveryCodesModel>)PageContext?.ViewData;
        public GenerateRecoveryCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

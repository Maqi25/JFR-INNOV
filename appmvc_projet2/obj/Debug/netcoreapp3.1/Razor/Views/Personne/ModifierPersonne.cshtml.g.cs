#pragma checksum "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ab19daff78c3319094e7477d6b25ab01de6f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personne_ModifierPersonne), @"mvc.1.0.view", @"/Views/Personne/ModifierPersonne.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ab19daff78c3319094e7477d6b25ab01de6f2f", @"/Views/Personne/ModifierPersonne.cshtml")]
    #nullable restore
    public class Views_Personne_ModifierPersonne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<appmvc_projet2.Models.Personne>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
  
    ViewBag.Title = "Modifier";
    Layout = "Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset>\r\n            <legend>Modifier une personne : </legend>\r\n            ");
#nullable restore
#line 11 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
       Write(Html.LabelFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p style=\"margin:0px 10px 5px 0px\">");
#nullable restore
#line 12 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                          Write(Html.TextBoxFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            \r\n            \r\n             ");
#nullable restore
#line 15 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.LabelFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <p style=\"margin:0px 10px 5px 0px\">");
#nullable restore
#line 16 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                           Write(Html.TextBoxFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n            \r\n");
            WriteLiteral("           \r\n             ");
#nullable restore
#line 22 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.LabelFor(m => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <p style=\"margin:0px 10px 5px 0px\">");
#nullable restore
#line 23 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                           Write(Html.TextBoxFor(m => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
       Write(Html.LabelFor(m => Model.NumeroTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <p style=\"margin:0px 10px 5px 0px\">");
#nullable restore
#line 27 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                           Write(Html.TextBoxFor(m => Model.NumeroTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("         \r\n             ");
#nullable restore
#line 30 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
        Write(Html.LabelFor(m => Model.Adresse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <p style=\"margin:0px 10px 5px 0px\">");
#nullable restore
#line 31 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                           Write(Html.TextBoxFor(m => Model.Adresse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("           \r\n              \r\n           \r\n");
            WriteLiteral("      \r\n            <input type=\"submit\" value=\"Modifier\" />\r\n        </fieldset>\r\n");
#nullable restore
#line 43 "D:\Formation_ISIKA\ISIKA\WorkCDA17\Projet2\JRFInnov\appmvc_projet2\appmvc_projet2\Views\Personne\ModifierPersonne.cshtml"
                                                                                             
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<appmvc_projet2.Models.Personne> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

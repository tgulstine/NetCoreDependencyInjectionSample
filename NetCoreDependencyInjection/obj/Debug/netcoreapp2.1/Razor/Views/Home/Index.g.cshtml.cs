#pragma checksum "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129af05e2e5101d905fb2b5049699cc8dfacf2b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\_ViewImports.cshtml"
using NetCoreDependencyInjection;

#line default
#line hidden
#line 2 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\_ViewImports.cshtml"
using NetCoreDependencyInjection.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129af05e2e5101d905fb2b5049699cc8dfacf2b7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"337f945d3bf1938dda8fc45dec7d5377754b71c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCoreDependencyInjection.Controllers.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 24, true);
            WriteLiteral("\r\n<h2>Customers</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\Home\Index.cshtml"
 foreach (var customer in Model)
{

#line default
#line hidden
            BeginContext(123, 67, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-1\">\r\n            ");
            EndContext();
            BeginContext(191, 11, false);
#line 9 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\Home\Index.cshtml"
       Write(customer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(202, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(265, 13, false);
#line 12 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\Home\Index.cshtml"
       Write(customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(278, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(341, 16, false);
#line 15 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\Home\Index.cshtml"
       Write(customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(357, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Projects\NetCoreDependencyInjection\NetCoreDependencyInjection\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetCoreDependencyInjection.Controllers.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\SucceededJobs.cshtml"
    using HangFire.Web.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.3.0")]
    internal partial class SucceededJobs : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("              \r\n");


            
            #line 5 "..\..\Pages\SucceededJobs.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Succeeded Jobs"
        };


            
            #line default
            #line hidden
WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Type</th>\r\n  " +
"          <th>Queue</th>\r\n            <th>Args</th>\r\n        </tr>\r\n    </thead>" +
"\r\n    <tbody>\r\n");


            
            #line 22 "..\..\Pages\SucceededJobs.cshtml"
         foreach (var job in Storage.SucceededJobs())
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");


            
            #line 25 "..\..\Pages\SucceededJobs.cshtml"
               Write(job.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 26 "..\..\Pages\SucceededJobs.cshtml"
               Write(job.Queue);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 27 "..\..\Pages\SucceededJobs.cshtml"
               Write(job.Args);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");


            
            #line 29 "..\..\Pages\SucceededJobs.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");


        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\n.zulpykharov\source\repos\ETextBook\ETextBook\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de8c0701eece5ab8da9f581f38d4a5dbb3e8908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "C:\Users\n.zulpykharov\source\repos\ETextBook\ETextBook\Views\_ViewImports.cshtml"
using ETextBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n.zulpykharov\source\repos\ETextBook\ETextBook\Views\_ViewImports.cshtml"
using ETextBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de8c0701eece5ab8da9f581f38d4a5dbb3e8908", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00b2349f58cf4f3864d4815cf13c53a7da3d2f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETextBook.Models.PostVM.PostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\n.zulpykharov\source\repos\ETextBook\ETextBook\Views\Post\Index.cshtml"
   
    Layout = "_ReadLayout";
    ViewData["HeaderImage"] = $"../../UserFiles/Posts/{Model.Post.Id}/HeaderImage.jpg";
    ViewData["HeaderTitle"] = Model.Post.Title;
    ViewData["AuthorName"] = $"{Model.Post.Creator.FirstName} {Model.Post.Creator.LastName}";
    ViewData["PostDate"] = Model.Post.UpdatedOn.ToString("MMMM d, yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n                ");
#nullable restore
#line 14 "C:\Users\n.zulpykharov\source\repos\ETextBook\ETextBook\Views\Post\Index.cshtml"
           Write(Html.Raw(Model.Post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETextBook.Models.PostVM.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

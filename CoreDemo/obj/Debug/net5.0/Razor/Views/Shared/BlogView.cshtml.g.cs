#pragma checksum "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c48bb40280f74dc73913b7dc121dbbb9f8f5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BlogView), @"mvc.1.0.view", @"/Views/Shared/BlogView.cshtml")]
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
#line 1 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c48bb40280f74dc73913b7dc121dbbb9f8f5d6", @"/Views/Shared/BlogView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_BlogView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Blog Posts</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<!--left-->\r\n\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 10 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
                     foreach(var item in Model) {
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 card\">\r\n\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 414, "\"", 444, 1);
#nullable restore
#line 14 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
WriteAttributeValue("", 420, item.BlogThumbnailImage, 420, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\" width=\"100\" height=\"100\">\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 20 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
                                                                           Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t<a href=\"single.html\">");
#nullable restore
#line 27 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 29 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
                                                     Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\t\t\t\t\t\t\t\t<a href=\"single.html\" class=\"btn btn-primary read-m\">Read More</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 33 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\BlogView.cshtml"
							
							
						
						}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						<nav aria-label=""Page navigation example"">
							<ul class=""pagination justify-content-left mt-4"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">1</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">2</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">3</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">Next</a>
								</li>
							</ul>
						</nav>
					</div>
				<!--//left-->
			</div>
		</div>
	</div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
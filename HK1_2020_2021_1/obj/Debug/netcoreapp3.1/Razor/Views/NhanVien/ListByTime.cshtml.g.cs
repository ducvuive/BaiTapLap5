#pragma checksum "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\NhanVien\ListByTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d4b428fbefc80a3dc6762258ed839abde2f453"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ListByTime), @"mvc.1.0.view", @"/Views/NhanVien/ListByTime.cshtml")]
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
#line 1 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\_ViewImports.cshtml"
using HK1_2020_2021_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\_ViewImports.cshtml"
using HK1_2020_2021_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5d4b428fbefc80a3dc6762258ed839abde2f453", @"/Views/NhanVien/ListByTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181117f5dbeb9d65d559f0ceb9a226a0690ed517", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ListByTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Tên nhân viên</th>\r\n        <th>Số điện thoại</th>\r\n        <th>Số lần sửa</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\NhanVien\ListByTime.cshtml"
     foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 18 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\NhanVien\ListByTime.cshtml"
                   Write(item.GetType().GetProperty("MaNV").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 21 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\NhanVien\ListByTime.cshtml"
                   Write(item.GetType().GetProperty("SoDT").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 24 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\NhanVien\ListByTime.cshtml"
                   Write(item.GetType().GetProperty("SoLan").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "E:\UIT\Nam3\Xây dựng HTTT trên các framework\Project_DeCK\HK1_2020_2021_1\HK1_2020_2021_1\Views\NhanVien\ListByTime.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591

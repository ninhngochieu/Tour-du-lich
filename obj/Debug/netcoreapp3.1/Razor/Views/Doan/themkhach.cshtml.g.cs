#pragma checksum "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\Doan\themkhach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8227deb341d1e5e32d6b550b4056f9e4373c4639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doan_themkhach), @"mvc.1.0.view", @"/Views/Doan/themkhach.cshtml")]
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
#line 1 "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\_ViewImports.cshtml"
using tour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\_ViewImports.cshtml"
using tour.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8227deb341d1e5e32d6b550b4056f9e4373c4639", @"/Views/Doan/themkhach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff28e97584599c34362f97f18e157895449dbb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Doan_themkhach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\Doan\themkhach.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Thêm khách trong đoàn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1>Thêm người đi</h1>
          </div>
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
              <li class=""breadcrumb-item active"">Thêm người đi</li>
            </ol>
          </div>
        </div>
      </div><!-- /.container-fluid -->
    </section>
    <section class=""content"">
      <div class=""container-fluid card"">
        <div class=""col-12"">
          <div class=""row"">
            <div class=""col-12 form_tour_"">
                <div class=""d-flex justify-content-center"" style=""margin-bottom: 20px;"">
                  <h3 class=""text-danger"">Gá tour cơ bản</h3>
                </div>
                <table class=""table table-bordered"">
                  <thead>
                    <tr>");
            WriteLiteral(@"
                      <th scope=""col"">Mã tour</th>
                      <th scope=""col"">Giá tour</th>
                      <th scope=""col"">Người lớn (Từ 12 tuổi trở lên)</th>
                      <th scope=""col"">Trẻ em (Từ 5 tuổi đến dưới 12 tuổi</th>
                      <th scope=""col"">Giá phòng khách sạn</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope=""row"">HD001</th>
                      <td>2.499.000 VNĐ</td>
                      <td>2.499.000 VNĐ</td>
                      <td>1.299.000 VNĐ</td>
                      <td>1.000.000 VNĐ</td>
                    </tr>
                  </tbody>
                </table>
              </div>
              <div class=""col-12 form_tour_"" style=""padding: 20px;"">
                <div class=""d-flex justify-content-center"" style=""margin-bottom: 12px;"">
                  <h3 class=""text-danger"">Khách hàng</h3>
                </div>
            ");
            WriteLiteral(@"    <div class=""row"">
                  <div class=""col"">
                    <label>Người lớn</label>
                    <input type=""number"" class=""form-control"" value=""1"" id=""nguoi_lon"">
                  </div>
                  <div class=""col"">
                    <label>Trẻ em</label>
                    <input type=""number"" class=""form-control"" value=""0"" id=""tre_em"">
                  </div>
                  <div class=""col"">
                    <label>Số khách</label>
                    <input type=""text"" class=""form-control"" value=""1"" id=""tong_ng_di"" readonly>
                  </div>
                  <div class=""col"">
                      <label>Xử lý</label>
                      <button type=""button"" class=""form-control btn btn-primary"" id=""btn_khach_hang"">Xác nhận</button>
                  </div>
                </div>
              </div>
              <div class=""col-12 collapse form_list_customer"">
                <div class=""d-flex justify-content-center"" style=""mar");
            WriteLiteral(@"gin-bottom: 20px;"">
                  <h3 class=""text-danger"">Danh sách khách hàng</h3>
                </div>
                <div class=""card"" id=""list_customer_main"">
                  <!-- <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">Khách hàng 1</li>
                    <li class=""list-group-item"">
                      <div class=""row"">
                        <div class=""col"">
                          <label>Họ tên</label>
                          <input type=""text"" class=""form-control"" placeholder=""Nhập họ tên"">
                        </div>
                        <div class=""col"">
                          <label>Số CMND</label>
                          <input type=""text"" class=""form-control"" placeholder=""Nhập số chứng minh"">
                        </div>
                        <div class=""col"">
                          <label>Địa chỉ</label>
                          <input type=""text"" class=""form-control"" placeholder=""Nhập địa ch");
            WriteLiteral(@"ỉ"">
                        </div>
                        <div class=""col"">
                          <label>Số điện thoại</label>
                          <input type=""text"" class=""form-control"" placeholder=""Nhập số điện thoại"">
                        </div>
                        <div class=""col-3"">
                          <label>Ngày sinh</label>
                          <div class=""d-flex justify-content-end"">
                            <select class=""form-control"">
                              <option value='0' selected='true'>Ngày</option>
                              <option>2</option>
                            </select>
                            <select class=""form-control"">
                              <option value='1' selected='true'>Tháng</option>
                              <option>2</option>
                            </select>
                            <select class=""form-control"">
                              <option value='1' selected='true'>Năm</option>");
            WriteLiteral(@"
                              <option>2</option>
                            </select>
                          </div>
                        </div>
                      </div>
                    </li>
                    <li class=""list-group-item"">
                      <div class=""d-flex justify-content-end"">Trị giá :&nbsp
                        <label class=""text-danger"">2.399.000 VNĐ</label>
                      </div>
                    </li>
                  </ul> -->
                </div>
              </div>
              <div class=""col-12"" style=""padding: 20px;"">
                <div class=""d-flex justify-content-end"">
                  <button type=""button"" class=""btn btn-primary"" id=""btn_save_tour"">Lưu thông tin</button>
                </div>
              </div>
          </div>
        </div>
      </div>
    </section>
  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

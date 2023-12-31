#pragma checksum "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71ed73bd8d52d943042eb58d812aaac34178054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71ed73bd8d52d943042eb58d812aaac34178054", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af35a328bfe0c906f75d04efeba14f80e1f583b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeManagement.Models.Employee>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Include the partial view for displaying employee details -->\r\n \r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71ed73bd8d52d943042eb58d812aaac341780543586", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Employee Listing</title>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"">
    <!-- Include jQuery -->
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71ed73bd8d52d943042eb58d812aaac341780545071", async() => {
                WriteLiteral(@"

    <h2>Employee List</h2>
    <button class=""btn btn-success"" onclick=""openAddEmployeeModal()"">Add Employee</button>
     


    <table class=""table"">
        <thead>
            <tr>
                <th>Employee Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>City</th>
                <th>Zip</th>
                <th>Salary</th>
                <th>Salary</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 43 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
             foreach (var employee in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1329, "\"", 1377, 3);
                WriteAttributeValue("", 1339, "openEmployeeDetailsModal(", 1339, 25, true);
#nullable restore
#line 47 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1364, employee.Id, 1364, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1376, ")", 1376, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
                                                                            Write(employee.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
               Write(employee.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
               Write(employee.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
               Write(employee.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
               Write(employee.Zip);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-info\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1662, "\"", 1708, 3);
                WriteAttributeValue("", 1672, "openSalaryRecordsModal(", 1672, 23, true);
#nullable restore
#line 54 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1695, employee.Id, 1695, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1707, ")", 1707, 1, true);
                EndWriteAttribute();
                WriteLiteral(">View</button>\r\n                </td>\r\n                <td>\r\n                    <button class=\"btn btn-info\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1818, "\"", 1860, 3);
                WriteAttributeValue("", 1828, "openAddSalaryModal(", 1828, 19, true);
#nullable restore
#line 57 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1847, employee.Id, 1847, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1859, ")", 1859, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Add</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\hp\Desktop\Projects\EmployeeManagement\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>

    <!-- Modal for Employee Details -->
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""employeeDialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Edit Employee Details</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""employeeDetails"">
                    <!-- Content will be loaded dynamically -->
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>

    <!-- Modal for Salary Details -->
    <div class=""modal"" tabindex=""-1");
                WriteLiteral(@""" role=""dialog"" id=""salaryDetailsModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Salary Details</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""salaryDetailsContent"">
                    <!-- Content will be loaded dynamically -->
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""addEmployeeModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
              ");
                WriteLiteral(@"  <div class=""modal-header"">
                    <h5 class=""modal-title"">Add New Employee</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""addEmployeeContent"">
                    <!-- Content will be loaded dynamically -->
                    <!-- Include the partial view for adding a new employee -->
");
                WriteLiteral(@"                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>


    <!-- Add Salary Modal -->
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""addSalaryModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Add Salary</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""addSalaryContent"">
                    <!-- Content will be loaded dynamically -->
                    <!-- Include the partial view for adding salary -->
");
                WriteLiteral(@"                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>


    <script>
        function openAddEmployeeModal() {
            // Use AJAX to load the partial view into the modal dialog
            $.get(""/Employee/AddEmployee"", function (data) {
                $(""#addEmployeeContent"").html(data);
                $(""#addEmployeeModal"").modal(""show"");
            });
        }
        function openAddSalaryModal(employeeId) {

            $.ajax({
                url: ""/Employee/AddSalary/"" + employeeId,
                type: ""GET"",
                success: function (data) {
                    $(""#addSalaryContent"").html(data);
                    $(""#addSalaryModal"").modal(""show"");
                },
                error: function (error) {
                    console.error(""Error fetching salary detail");
                WriteLiteral(@"s:"", error);
                }
            });
            
        }
        function openEmployeeDetailsModal(employeeId) {
            $.ajax({
                url: ""/Employee/Edit/"" + employeeId,
                type: ""GET"",
                success: function (data) {
                    $(""#employeeDetails"").html(data);
                    $(""#employeeDialog"").modal(""show"");
                },
                error: function (error) {
                    console.error(""Error fetching employee details:"", error);
                }
            });
        }

        function openSalaryRecordsModal(employeeId) {
            $.ajax({
                url: ""/Employee/SalaryRecords/"" + employeeId,
                type: ""GET"",
                success: function (data) {
                    $(""#salaryDetailsContent"").html(data);
                    $(""#salaryDetailsModal"").modal(""show"");
                },
                error: function (error) {
                    console.error(""Error ");
                WriteLiteral("fetching salary details:\", error);\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeManagement.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591

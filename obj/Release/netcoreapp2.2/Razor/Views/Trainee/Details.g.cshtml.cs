#pragma checksum "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac4090db6e6881a5daf37474d5c2115620a7d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainee_Details), @"mvc.1.0.view", @"/Views/Trainee/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Trainee/Details.cshtml", typeof(AspNetCore.Views_Trainee_Details))]
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
#line 1 "/home/office/Downloads/AppProject/Views/_ViewImports.cshtml"
using AppProject;

#line default
#line hidden
#line 2 "/home/office/Downloads/AppProject/Views/_ViewImports.cshtml"
using AppProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac4090db6e6881a5daf37474d5c2115620a7d48", @"/Views/Trainee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f974743dfdac9f2662d6b767297e7963f729dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppProject.Models.Trainee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 428, true);
            WriteLiteral(@"


<div>
   
    
    <div class=""row"">
        <div class=""col-md-4"">
             <h4>Trainee Info</h4>
            
        </div>
        <div class=""col-md-8"">
            <h3 style=""text-align:right"" class=""print""><a href=""#"" <i class=""fas fa-print""></i></a></h3>
        </div>

    </div>
    <hr />
    <div class=""row"">
        <h4 class=""col-md-10 text-left SL""><span class=""SL""> SERIAL NO.</span>  ");
            EndContext();
            BeginContext(508, 10, false);
#line 24 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
                                                                           Write(ViewBag.SL);

#line default
#line hidden
            EndContext();
            BeginContext(518, 129, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <dl class=\"row\">\r\n            <!--  DSHE SERIAL -->\r\n             <dt class=\"col-sm-4\">\r\n                 ");
            EndContext();
            BeginContext(648, 42, false);
#line 29 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
            Write(Html.DisplayNameFor(model => model.DsheSL));

#line default
#line hidden
            EndContext();
            BeginContext(690, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(818, 38, false);
#line 32 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
           Write(Html.DisplayFor(model => model.DsheSL));

#line default
#line hidden
            EndContext();
            BeginContext(856, 73, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                 ");
            EndContext();
            BeginContext(930, 47, false);
#line 35 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
            Write(Html.DisplayNameFor(model => model.TraineeType));

#line default
#line hidden
            EndContext();
            BeginContext(977, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1105, 43, false);
#line 38 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
           Write(Html.DisplayFor(model => model.TraineeType));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 107, true);
            WriteLiteral("\r\n            </dd>\r\n           <!--  Course Info -->\r\n            <dt class=\"col-sm-4\">\r\n                 ");
            EndContext();
            BeginContext(1256, 47, false);
#line 42 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
            Write(Html.DisplayNameFor(model => model.Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1431, 43, false);
#line 45 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
           Write(Html.DisplayFor(model => model.Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 77, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n             <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(1552, 43, false);
#line 49 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayNameFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1723, 39, false);
#line 52 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
           Write(Html.DisplayFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 75, true);
            WriteLiteral("\r\n            </dd>\r\n             <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(1838, 47, false);
#line 55 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayNameFor(model => model.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 132, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                From ");
            EndContext();
            BeginContext(2018, 43, false);
#line 58 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
                Write(Html.DisplayFor(model => model.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 5, true);
            WriteLiteral(" to  ");
            EndContext();
            BeginContext(2067, 43, false);
#line 58 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
                                                                 Write(Html.DisplayFor(model => model.ClosingDate));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
            BeginContext(2466, 108, true);
            WriteLiteral("            \r\n            <!-- Personal Info -->\r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(2575, 40, false);
#line 69 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(2749, 36, false);
#line 72 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2785, 80, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(2866, 52, false);
#line 75 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.ProfileImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(2918, 137, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3055, "\"", 3110, 1);
#line 78 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
WriteAttributeValue("", 3061, Html.DisplayFor(model => model.ProfileImagePath), 3061, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3111, 108, true);
            WriteLiteral(" width=\"180\" height=\"150\"/>\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3220, 46, false);
#line 81 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(3266, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(3401, 42, false);
#line 84 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(3443, 81, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3525, 46, false);
#line 87 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.MotherName));

#line default
#line hidden
            EndContext();
            BeginContext(3571, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(3706, 42, false);
#line 90 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.MotherName));

#line default
#line hidden
            EndContext();
            BeginContext(3748, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3829, 42, false);
#line 93 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3871, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(4005, 38, false);
#line 96 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(4043, 79, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(4123, 47, false);
#line 99 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(4170, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(4304, 43, false);
#line 102 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(4347, 82, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n\r\n             <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(4430, 46, false);
#line 107 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.BloodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(4476, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(4611, 42, false);
#line 110 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.BloodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(4653, 93, true);
            WriteLiteral("\r\n              </dd>\r\n             \r\n             <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(4747, 49, false);
#line 114 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
            EndContext();
            BeginContext(4796, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(4930, 45, false);
#line 117 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
            EndContext();
            BeginContext(4975, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n               <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(5057, 39, false);
#line 121 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5096, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(5230, 35, false);
#line 124 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5265, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(5346, 42, false);
#line 127 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CellNo));

#line default
#line hidden
            EndContext();
            BeginContext(5388, 131, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(5520, 38, false);
#line 130 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
           Write(Html.DisplayFor(model => model.CellNo));

#line default
#line hidden
            EndContext();
            BeginContext(5558, 77, true);
            WriteLiteral("\r\n              </dd>\r\n             <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(5636, 41, false);
#line 133 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(5677, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(5812, 37, false);
#line 136 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(5849, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n              <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(5931, 39, false);
#line 140 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.NID));

#line default
#line hidden
            EndContext();
            BeginContext(5970, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(6104, 35, false);
#line 143 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.NID));

#line default
#line hidden
            EndContext();
            BeginContext(6139, 82, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(6222, 52, false);
#line 147 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PermanentAddress));

#line default
#line hidden
            EndContext();
            BeginContext(6274, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(6408, 48, false);
#line 150 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.PermanentAddress));

#line default
#line hidden
            EndContext();
            BeginContext(6456, 127, true);
            WriteLiteral("\r\n              </dd>\r\n             \r\n            <!--  JOB INFO -->\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(6584, 47, false);
#line 155 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(6631, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(6765, 43, false);
#line 158 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(6808, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(6889, 43, false);
#line 161 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(6932, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(7067, 39, false);
#line 164 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(7106, 80, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(7187, 43, false);
#line 167 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.IndexNo));

#line default
#line hidden
            EndContext();
            BeginContext(7230, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(7364, 39, false);
#line 170 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.IndexNo));

#line default
#line hidden
            EndContext();
            BeginContext(7403, 83, true);
            WriteLiteral("\r\n              </dd>\r\n                  <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(7487, 47, false);
#line 173 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.NameOfCadre));

#line default
#line hidden
            EndContext();
            BeginContext(7534, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(7669, 43, false);
#line 176 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.NameOfCadre));

#line default
#line hidden
            EndContext();
            BeginContext(7712, 80, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(7793, 46, false);
#line 179 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.BCSBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(7839, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(7973, 42, false);
#line 182 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.BCSBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(8015, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n             <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(8097, 52, false);
#line 186 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(8149, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(8284, 48, false);
#line 189 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(8332, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(8413, 42, false);
#line 192 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EiinNo));

#line default
#line hidden
            EndContext();
            BeginContext(8455, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(8590, 38, false);
#line 195 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.EiinNo));

#line default
#line hidden
            EndContext();
            BeginContext(8628, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n             <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(8710, 57, false);
#line 199 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.AcademicQualification));

#line default
#line hidden
            EndContext();
            BeginContext(8767, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(8902, 53, false);
#line 202 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.AcademicQualification));

#line default
#line hidden
            EndContext();
            BeginContext(8955, 159, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n               \r\n\r\n              <!-- EMMERGENCY CONTACT INFO -->\r\n            \r\n            <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(9115, 57, false);
#line 210 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayNameFor(model => model.EmmergencyContactName));

#line default
#line hidden
            EndContext();
            BeginContext(9172, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(9306, 53, false);
#line 213 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.EmmergencyContactName));

#line default
#line hidden
            EndContext();
            BeginContext(9359, 92, true);
            WriteLiteral("\r\n              </dd>\r\n            \r\n              <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(9452, 59, false);
#line 217 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayNameFor(model => model.EmmergencyContactCellNo));

#line default
#line hidden
            EndContext();
            BeginContext(9511, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(9645, 55, false);
#line 220 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
             Write(Html.DisplayFor(model => model.EmmergencyContactCellNo));

#line default
#line hidden
            EndContext();
            BeginContext(9700, 93, true);
            WriteLiteral("\r\n              </dd>\r\n          \r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(9794, 52, false);
#line 224 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.SignatureImgPath));

#line default
#line hidden
            EndContext();
            BeginContext(9846, 138, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9984, "\"", 10039, 1);
#line 227 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
WriteAttributeValue("", 9990, Html.DisplayFor(model => model.SignatureImgPath), 9990, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10040, 107, true);
            WriteLiteral(" width=\"180\" height=\"150\"/>\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(10148, 43, false);
#line 230 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayNameFor(model => model.RegDate));

#line default
#line hidden
            EndContext();
            BeginContext(10191, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(10326, 39, false);
#line 233 "/home/office/Downloads/AppProject/Views/Trainee/Details.cshtml"
              Write(Html.DisplayFor(model => model.RegDate));

#line default
#line hidden
            EndContext();
            BeginContext(10365, 120, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n\r\n               </dt>\r\n        </dl>\r\n</div> \r\n\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(10547, 6, true);
            WriteLiteral("|\r\n   ");
            EndContext();
            BeginContext(10553, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ac4090db6e6881a5daf37474d5c2115620a7d4833462", async() => {
                BeginContext(10587, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10595, 3, true);
            WriteLiteral("|\r\n");
            EndContext();
            BeginContext(10646, 5, true);
            WriteLiteral("     ");
            EndContext();
            BeginContext(10651, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ac4090db6e6881a5daf37474d5c2115620a7d4835422", async() => {
                BeginContext(10672, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10688, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppProject.Models.Trainee> Html { get; private set; }
    }
}
#pragma warning restore 1591
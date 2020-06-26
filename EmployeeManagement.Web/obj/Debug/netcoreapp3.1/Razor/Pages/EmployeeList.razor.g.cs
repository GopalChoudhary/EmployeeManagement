#pragma checksum "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a9bd67a35999da275861012df727a321a6805ec"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Selected Employees Count: ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                               SelectedEmployeesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-check");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "class", "form-check-input");
            __builder.AddAttribute(10, "id", "showFooter");
            __builder.AddAttribute(11, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                           ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<label class=\"form-check-label\" for=\"showFooter\">Show Footer</label>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-deck");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 9 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
     if (Employees == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "        <div class=\"loader\"></div>\r\n");
#nullable restore
#line 12 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenComponent<EmployeeManagement.Web.Pages.DisplayEmployee>(21);
            __builder.AddAttribute(22, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EmployeeManagement.Models.Employee>(
#nullable restore
#line 18 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                       employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                             ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 18 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                                                              EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 20 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Work\Blazor\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e4b5b150740901bde79610e870fe6584727846"
// <auto-generated/>
#pragma warning disable 1591
namespace contactManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using contactManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\_Imports.razor"
using contactManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
using contactManagement.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletecontact/{CurrentID}")]
    public partial class DeleteContact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DeleteContact</h3>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>\r\n    Are you sure you want to delete this?\r\n</h4>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-8");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<label>Contact ID:</label>\r\n        ");
            __builder.OpenElement(9, "label");
            __builder.AddContent(10, 
#nullable restore
#line 16 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
                contactInfo.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<label>Last Name:</label>\r\n        ");
            __builder.OpenElement(17, "label");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
                contactInfo.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<label>First Name:</label>\r\n        ");
            __builder.OpenElement(25, "label");
            __builder.AddContent(26, 
#nullable restore
#line 24 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
                contactInfo.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-4");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-danger");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
                                                                   DeleteAContact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\3pear\Desktop\Personal projects\contactManagement\contactManagement\Pages\DeleteContact.razor"
       
    [Parameter]
    public string CurrentID { get; set; }

    ContactInfo contactInfo = new ContactInfo();

    protected override async Task OnInitializedAsync()
    {
        contactInfo.Id = Guid.Parse(CurrentID);
        contactInfo = await Task.Run(() => contactService.GetContactById(Guid.Parse(CurrentID)));
    }

    protected void DeleteAContact()
    {

        contactService.DeleteContactInfo(contactInfo);
        navigationManager.NavigateTo("contacts");
    }

    void Cancel()
    {
        navigationManager.NavigateTo("contacts");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactService contactService { get; set; }
    }
}
#pragma warning restore 1591

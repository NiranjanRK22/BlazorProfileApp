#pragma checksum "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5e30605ec5c2854e13c12edcdf2352ae2df272"
// <auto-generated/>
#pragma warning disable 1591
namespace ProfileApp.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using ProfileApp.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blazor\ProfileApp\ProfileApp.Server\_Imports.razor"
using ProfileApp.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
using ProfileApp.Server.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class MyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.AddMarkupContent(2, "<h3 class=\"card-title text-primary\">My Profile</h3>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                 profileDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                                                ValidateProfileDetails

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                                profileDetails.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => profileDetails.Name = __value, profileDetails.Name))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => profileDetails.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __Blazor.ProfileApp.Server.Pages.MyProfile.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 17 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                                () => profileDetails.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label>Age</label>\r\n                        ");
                __Blazor.ProfileApp.Server.Pages.MyProfile.TypeInference.CreateInputNumber_1(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 21 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                                  profileDetails.Age

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => profileDetails.Age = __value, profileDetails.Age)), 34, () => profileDetails.Age);
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __Blazor.ProfileApp.Server.Pages.MyProfile.TypeInference.CreateValidationMessage_2(__builder2, 36, 37, 
#nullable restore
#line 22 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                                () => profileDetails.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(41);
                __builder2.AddAttribute(42, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 25 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(43, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "row");
#nullable restore
#line 27 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                             if (profileDetails.ImageUrls!=null && profileDetails.ImageUrls.Count>0)
                            {
                                int serial = 1;
                                foreach(var profileImage in profileDetails.ImageUrls)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-2 mt-3");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "profile-image");
                __builder2.AddAttribute(51, "style", "background:" + " url(" + (
#nullable restore
#line 33 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                                                                       profileImage

#line default
#line hidden
#nullable disable
                ) + ")" + " 50%" + " 50%;");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                                    ");
                __builder2.OpenElement(53, "span");
                __builder2.AddAttribute(54, "class", "profile-image-title");
#nullable restore
#line 34 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
__builder2.AddContent(55, serial);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 36 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
                                    serial++;
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.AddMarkupContent(57, "<button class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "E:\Blazor\ProfileApp\ProfileApp.Server\Pages\MyProfile.razor"
       
    private ProfileDTO profileDetails { get; set; } = new ProfileDTO();
    private ProfileImageDTO ProfileImage { get; set; } = new();

    private string message = "Profile created successfully";

    private async Task ValidateProfileDetails()
    {
        await JsRuntime.InvokeAsync<bool>("created", message);
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach(var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                }
                if (images.Any())
                {
                    if (profileDetails.ImageUrls != null && profileDetails.ImageUrls.Any())
                    {
                        profileDetails.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        profileDetails.ImageUrls = new List<string>();
                        profileDetails.ImageUrls.AddRange(images);
                    }
                }
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
    }
}
namespace __Blazor.ProfileApp.Server.Pages.MyProfile
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

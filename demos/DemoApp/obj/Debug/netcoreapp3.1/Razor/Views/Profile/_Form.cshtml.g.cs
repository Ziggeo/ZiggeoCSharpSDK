#pragma checksum "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21219461baa3df4490ea9ce31cab9f3c5eb94130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile__Form), @"mvc.1.0.view", @"/Views/Profile/_Form.cshtml")]
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
#line 1 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/_ViewImports.cshtml"
using ZiggeoDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/_ViewImports.cshtml"
using ZiggeoDemoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21219461baa3df4490ea9ce31cab9f3c5eb94130", @"/Views/Profile/_Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3609ada660c874bc551e124bf541e462ab6e0de", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile__Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("apply-effect-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    let URL = ""/Profile/Add"", addEffectProfileForm, submitButton, profileKeySelector, profileTiitleSelector;
    let state = {
        isCreating: true,
        profileKey: """",
        profileTitle: """",
        profileToken: """",
        isDefault: false
    };
    
    if (""");
#nullable restore
#line 11 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
    Write(Model.isCreate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""".toUpperCase() !== ""TRUE"") {
        state = {...state,  isCreating: false};
        URL = ""/Profile/Edit"";
    }
        
    /**
    * Verify on each step
    */
    const verify = () => {
        hideMessage();
        console.log('State', state);
        const {profileKey, profileTitle, isCreating} = state;
        if ((profileKey && profileTitle) || !isCreating) {
            submitButton.prop(""disabled"", false);
            return true;
        } else {
            showMessage(""Please fill all required fields"", ""danger"");
            submitButton.prop(""disabled"", true);
            return false;
        }
    }
    
    
    const onInputChangeHandler = (ev) => {
        ev.preventDefault();
        const { name, value } = ev.target;
        state[name] = value;
        verify();
    }
    
    const checkBoxHandler = (ev) => {
        const { name, checked } = ev.target;
        state[name] = checked;
        verify();
    }   
    
    const addEffectProfile = () => { 
        hideMessage();
        ");
            WriteLiteral(@"hideLoader(); 
        if (verify()) {
            const { profileKey, profileTitle, isDefault, profileToken } = state;
            const postData = { profileKey, profileTitle, isDefault, profileToken };
            // const data = addEffectProfileForm.serialize();
            $.ajax({
                url: URL,
                method: ""POST"",
                // data: {addEffectModel: JSON.stringify(postData)},
                data: JSON.stringify(postData),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                beforeSend: () => {
                    showLoader();
                    console.log('Request Started');
                },
                
                success: (res) => {
                    const {success, message} = res;
                    console.log(""success Response: "",  message);
                    Boolean(success) ? showMessage(message) : showMessage(""We have response: "" + JSON.stringify(res), ""danger"");
                    hide");
            WriteLiteral(@"Loader();
                },
                error: (error) => {
                    const {readyState, responseText} = error;
                    if (readyState === 4) {
                        showMessage(responseText, ""danger""); 
                    } else {
                        showMessage(""We have an error"" + JSON.stringify(error), ""danger""); 
                    }
                    hideLoader();
                },
                failure: function (jqXHR, textStatus, errorThrown) {                  
                    let message = ""HTTP Status: "" + jqXHR.status + ""; Error Text: "" + jqXHR.responseText; 
                    showMessage(message, ""danger"");
                    hideLoader();
                }
            }); 
        }
    }
         
    window.addEventListener(""load"", (ev) => { 
        addEffectProfileForm = $(""#apply-effect-form"");
        submitButton = jQuery(""#submit-button"");
        submitButton.prop(""disabled"", false);
        profileSelectSelector = $(""#profile-select"");
  ");
            WriteLiteral(@"      videoSelectSelector = $(""#video-select"");
    
        const inputElementsSelector = $("".text-input"");
        if (inputElementsSelector)  {
            $.each(inputElementsSelector, (index, element) => {
                element.onkeyup = (ev) => onInputChangeHandler(ev);
            });
        }
        
        const hiddenInputs = $("".hidden-inputs"");
        if (hiddenInputs) { 
            $.each(hiddenInputs, (index, element) => {
                const name = $(element).attr(""name"");
                const value = $(element).val();
                if (name && value) {
                    state[name] = value;
                }
            });
        }
        
        $(""#is-default"").on(""change"" , (ev) => checkBoxHandler(ev));        
    });
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21219461baa3df4490ea9ce31cab9f3c5eb941308676", async() => {
                WriteLiteral("\n    \n");
#nullable restore
#line 121 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
     if (@Model.isCreate)
    {
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""form-group row"">
            <label for=""profile-title"" class=""col-sm-3 col-form-label"">Profile Title</label>
            <div class=""col-sm-9"">
                <input
                    id=""profile-title"" name=""profileTitle""
                    placeholder=""Profile Title""");
                BeginWriteAttribute("value", "\n                    value=\"", 4566, "\"", 4613, 1);
#nullable restore
#line 130 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
WriteAttributeValue("", 4594, Model.profileTitle, 4594, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                    class=\"text-input form-control\"\n                />\n            </div>\n        </div>\n");
                WriteLiteral("        <div class=\"form-group row\">\n            <label for=\"profile-key\" class=\"col-sm-3 col-form-label\">Please Key</label>\n            <div class=\"col-sm-9\">\n                <input\n                    id=\"profile-key\" name=\"profileKey\"");
                BeginWriteAttribute("value", "\n                    value=\"", 4958, "\"", 5003, 1);
#nullable restore
#line 141 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
WriteAttributeValue("", 4986, Model.profileKey, 4986, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                    class=\"text-input form-control\" placeholder=\"Profile Key\"\n                    />\n            </div>\n        </div>\n");
#nullable restore
#line 146 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" class=\"hidden-inputs\" name=\"profileToken\"");
                BeginWriteAttribute("value", " value=\"", 5231, "\"", 5258, 1);
#nullable restore
#line 149 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
WriteAttributeValue("", 5239, Model.profileToken, 5239, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
#nullable restore
#line 150 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div class=\"form-group\">\n        <div class=\"form-check\">\n            <input\n                id=\"is-default\" type=\"checkbox\"\n                class=\"checkbox-input form-check-input\"");
                BeginWriteAttribute("checked", "\n                checked=\"", 5454, "\"", 5496, 1);
#nullable restore
#line 157 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
WriteAttributeValue("", 5480, Model.isDefault, 5480, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                name=\"isDefault\"\n                />\n            <label for=\"is-default\" class=\"form-check-label\">Will be default ?</label>\n        </div>\n    </div>\n");
#nullable restore
#line 163 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
     if (@Model.isCreate)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button\n            id=\"submit-button\" type=\"submit\"\n            class=\"btn btn-success\"\n            onclick=\"addEffectProfile()\"\n            disabled\n        >Create Profile</button>\n");
#nullable restore
#line 171 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button\n            id=\"submit-button\" type=\"submit\"\n            class=\"btn btn-success\"\n            onclick=\"addEffectProfile()\"\n            disabled\n        >Update Profile</button>\n");
#nullable restore
#line 180 "/Users/rashad/Ziggeo/C#/ZiggeoDemoApp/Views/Profile/_Form.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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

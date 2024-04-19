using BlazorAzureAD_WA.Pages;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAzureAD_WATest
{
    public class StylePageTest : TestContext
    {
        /// <summary>
        /// This test method will test the stylepage.
        /// It will check query parameter which is passed in url should be match with titleStyle string in code(fw-bold).
        /// Because in code it's using this titleStyle as a class for p tag to display the text as per class.
        /// </summary>
        [Fact]
        public void StylePage_QueryString_Parameter_Bold()
        {
            var navigationManager = Services.GetRequiredService<NavigationManager>();
            var uri = navigationManager.GetUriWithQueryParameter("titleStyle", "fw-bold");
            navigationManager.NavigateTo(uri);

            var cut = RenderComponent<StylePage>();
            cut.Instance.titleStyle.ShouldBe("fw-bold");
        }
        /// <summary>
        /// This test method will test the stylepage.
        /// It will check query parameter which is passed in url should be match with titleStyle string in code(fst-italic).
        /// Because in code it's using this titleStyle as a class for p tag to display the text as per class.
        /// </summary>
        [Fact]
        public void StylePage_QueryString_Parameter_Italic()
        {
            var navigationManager = Services.GetRequiredService<NavigationManager>();
            var uri = navigationManager.GetUriWithQueryParameter("titleStyle", "fst-italic");
            navigationManager.NavigateTo(uri);

            var cut = RenderComponent<StylePage>();
            cut.Instance.titleStyle.ShouldBe("fst-italic");
        }
        /// <summary>
        /// This test method will test the stylepage.
        /// It will check query parameter which is passed in url should be match with titleStyle string in code(text-danger).
        /// Because in code it's using this titleStyle as a class for p tag to display the text as per class.
        /// </summary>
        [Fact]
        public void StylePage_QueryString_Parameter_Text_Danger()
        {
            var navigationManager = Services.GetRequiredService<NavigationManager>();
            var uri = navigationManager.GetUriWithQueryParameter("titleStyle", "text-danger");
            navigationManager.NavigateTo(uri);

            var cut = RenderComponent<StylePage>();
            cut.Instance.titleStyle.ShouldBe("text-danger");
        }
        /// <summary>
        /// This test method will test the stylepage.
        /// It will check query parameter which is passed in url should be match with titleStyle string in code(text-uppercase).
        /// Because in code it's using this titleStyle as a class for p tag to display the text as per class.
        /// </summary>
        [Fact]
        public void StylePage_QueryString_Parameter_Text_UpperCase()
        {
            var navigationManager = Services.GetRequiredService<NavigationManager>();
            var uri = navigationManager.GetUriWithQueryParameter("titleStyle", "text-uppercase");
            navigationManager.NavigateTo(uri);

            var cut = RenderComponent<StylePage>();
            cut.Instance.titleStyle.ShouldBe("text-uppercase");
        }
        /// <summary>
        /// This test method will test the stylepage.
        /// It will check query parameter which is passed in url should be match with titleStyle string in code(h1).
        /// Because in code it's using this titleStyle as a class for p tag to display the text as per class.
        /// </summary>
        [Fact]
        public void StylePage_QueryString_Parameter_h1()
        {
            var navigationManager = Services.GetRequiredService<NavigationManager>();
            var uri = navigationManager.GetUriWithQueryParameter("titleStyle", "h1");
            navigationManager.NavigateTo(uri);

            var cut = RenderComponent<StylePage>();
            cut.Instance.titleStyle.ShouldBe("h1");
        }
    }
}
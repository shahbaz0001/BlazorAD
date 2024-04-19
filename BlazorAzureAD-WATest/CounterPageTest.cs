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
    public class CounterPageTest : TestContext
    {
        /// <summary>
        /// CounterPageTest
        /// This test method will test the counter page.
        /// It will check the button click on counter page and check that when button is clicked current count should be match with 1
        /// Because there is a logic when button is click, count will increase from 0(default) to 1 when page is load.
        /// </summary>
        [Fact]
        public void Counter_Increment_While_Button_Clicked()
        {
            var cut = RenderComponent<Counter>();
            cut.Find("button").Click();
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}
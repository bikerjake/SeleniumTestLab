using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace SeleniumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //create a browser driver
                IWebDriver _browser = new ChromeDriver();

                //go to a URL
                _browser.Navigate().GoToUrl("https://stackoverflow.com");

                //find the search box element on screen
                IWebElement searchBox = _browser.FindElement(By.Name("q"));

                //send some text (key presses) to the text box
                searchBox.SendKeys("Selenium ChromeDriver C#");

                //simulate the user pressing "Enter"
                searchBox.Submit();

                //write a log
                Debug.WriteLine("Success!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Doh, something done fucked up! ({ex})");
            }
        }
    }
}




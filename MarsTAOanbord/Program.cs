using Microsoft.VisualStudio.Services.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsTAOanbord
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // open chrome browser
           IWebDriver driver = new ChromeDriver();

            //lunch turnup portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            // click on the sign in button
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/a"));
            signInButton.Click();

            // identify emailID textbox and enter valid emailID
            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            emailTextbox.SendKeys("antonythomas03@hotmail.com");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("IcanDo!t1");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

/*          //  check if user is logged in successfully
           IWebElement helloAntony = driver.FindElement(By.XPath("//*--[@id='account - profile - section']/div/div[1]/div[2]/div/a[2]/button"));

            if (helloAntony.Text == "Hello antony!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("");
            }*/

        }
    }
}

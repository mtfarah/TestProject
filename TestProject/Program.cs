using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;



namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            // 1
            driver.Navigate().GoToUrl("https://subline-test.artsrn.ualberta.ca/Registration/Create/54?eventItemDef=399");


            // 2
            var subTotalValue = driver.FindElement(By.Id("subTotal")).GetAttribute("value");
            Console.WriteLine("SubTotal Value is " + subTotalValue);


            // 3

            IWebElement radioButtonOne = driver.FindElement(By.Name("Elements[1].ExtendedValue[0]"));
            // Taking a pause to execute 
            System.Threading.Thread.Sleep(5000);
            radioButtonOne.Click();
            

            // 4
           var newSubTotalValue = driver.FindElement(By.Id("subTotal")).GetAttribute("value");
            Console.WriteLine("The changed Subtotal Value is " + newSubTotalValue);


          
           
            System.Threading.Thread.Sleep(5000);
           

        }
    }
}

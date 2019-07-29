using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CarList_Khairunnisa
{
	class CarList
	{
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //Navigate to webpage
            driver.Navigate().GoToUrl("http://carlist.my");
            //Select "Used" radio button
            driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/div[1]/div/div/div[2]/form/div[1]/div[2]/label/span")).Click();
            //Click on Search button
            driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/div[1]/div/div/div[2]/form/div[7]/button")).Click();
            //Click on the first result (car)
            driver.FindElement(By.CssSelector("a[href*='https://www.carlist.my/used-cars/2001-alfa-romeo-147-2-0-t-spark-hatchback-2doors/6040644?kurnia=true']")).Click();

            int compare = 1000;
            String price = driver.FindElement(By.XPath("//*[@id='listing_6045474']/div[2]/div[1]/div[1]/div/div[2]/div[2]")).Text;
            int p = Int32.Parse(price);
            if (p > compare)
            {
                Console.WriteLine("Car price is more than RM1,000");
            }
            else
            {
                Console.WriteLine("Car price is lower than RM1,000");
            }
        }
	}
}

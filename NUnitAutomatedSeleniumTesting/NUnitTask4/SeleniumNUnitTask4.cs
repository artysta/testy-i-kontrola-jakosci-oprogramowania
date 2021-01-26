using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System;

namespace NUnitTask4
{
	[TestFixture]
	public class SeleniumNUnitTask4
	{
		[Test]
		[Author("Sample name", "sample@email.com")]
        [Description("Facebook login Verify")]
        [TestCaseSource("DataDrivenTesting")]
		public void Test1(string url)
		{
            IWebDriver driver = null;

            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/register";
                driver.Url = url;
                //IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='u_0_s']"));
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("D:\\sample\\path\\screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
		}

        public static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();

            list.Add("https://www.facebook.com/register");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.google.com/");

            return list;
        }

		//[Test]
		//[Author("Sample name", "sample@email.com")]
        //[Description("Facebook login Verify")]
        //public void Test2()
		//{
		//	IWebDriver driver = new ChromeDriver();
		//	driver.Manage().Window.Maximize();
		//	driver.Url = "https://www.facebook.com/register";
		//	IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='u_0_s']"));
		//	emailTextField.SendKeys("Selenium C#");
		//	driver.Quit();
		//}
	}
}

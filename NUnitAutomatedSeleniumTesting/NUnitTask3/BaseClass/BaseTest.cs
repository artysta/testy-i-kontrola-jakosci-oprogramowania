using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTask3.BaseClass
{
	public class BaseTest
	{
		public IWebDriver driver;

		[SetUp]
		public void Open()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Url = "https://www.facebook.com/register";
		}

		[TearDown]
		public void Close()
		{
			driver.Quit();
		}
	}
}

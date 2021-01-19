using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTask1.BaseClass
{
	public class BaseTest
	{
		public IWebDriver driver;

		[OneTimeSetUp]
		public void Open()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Url = "https://www.facebook.com/register";
		}

		[OneTimeTearDown]
		public void Close()
		{
			driver.Quit();
		}
	}
}

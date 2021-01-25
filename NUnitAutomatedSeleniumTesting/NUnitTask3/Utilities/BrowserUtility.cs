﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTask3.Utilities
{
	public class BrowserUtility
	{
		public IWebDriver Init(IWebDriver driver)
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Url = "https://www.facebook.com/register";
			return driver;
		}
	}
}

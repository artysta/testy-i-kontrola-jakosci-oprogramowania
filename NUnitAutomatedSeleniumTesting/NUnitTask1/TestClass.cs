// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using NUnitTask1.BaseClass;
using OpenQA.Selenium;
using System.Threading;

namespace NUnitTask1
{
	[TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}

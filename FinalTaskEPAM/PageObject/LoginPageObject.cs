using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FinalTaskEPAM.PageObject
{
	public class LoginPageObject
	{
		private readonly IWebDriver _driver;

		public LoginPageObject(IWebDriver driver)
		{
			_driver = driver;
			_driver.Navigate().GoToUrl("https://www.saucedemo.com/");
		}

		public IWebElement UsernameField => _driver.FindElement(By.Id("user-name"));
		public IWebElement PasswordField => _driver.FindElement(By.Id("password"));
		public IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));
		public IWebElement ErrorMessage => _driver.FindElement(By.CssSelector("[data-test='error']"));

		public void Login(string username, string password)
		{
			UsernameField.SendKeys(username);
			PasswordField.SendKeys(password);
			LoginButton.Click();
		}

		public void ClearUsernameField()
		{
			UsernameField.Clear();
		}
		
		public void ClearPasswordField()
		{
			PasswordField.Clear();
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTaskEPAM.Drivers;
using FinalTaskEPAM.PageObject;
using FinalTaskEPAM.Utils;
using FluentAssertions;
using OpenQA.Selenium;

namespace FinalTaskEPAM.Tests
{
	public class ChromeLoginTests : IDisposable
	{
		private readonly IWebDriver _driver;
		private readonly LoginPageObject _loginPage;

		public ChromeLoginTests()
		{
			_driver = WebDriverFactory.CreateWebDriver("chrome");
			_loginPage = new LoginPageObject(_driver);
		}

		[Theory]
		[InlineData("", "")]
		public void UC1_LoginWithEmptyCredentials_ShowsErrorMessage(string username, string password)
		{
			TestLogger.Logger.Information("Starting UC1 test with empty credentials");

			_loginPage.Login(username, password);
			
			_loginPage.ClearUsernameField();
			_loginPage.ClearPasswordField();
			_loginPage.ErrorMessage.Text.Should().Be("Epic sadface: Username is required");

			TestLogger.Logger.Information("UC1 test completed successfully");
		}

		[Theory]
		[InlineData("standard_user", "")]
		public void UC2_LoginWithEmptyPassword_ShowsErrorMessage(string username, string password)
		{
			TestLogger.Logger.Information("Starting UC2 test with empty password");

			_loginPage.Login(username, password);

			_loginPage.ClearPasswordField();

			_loginPage.ErrorMessage.Text.Should().Be("Epic sadface: Password is required");

			TestLogger.Logger.Information("UC2 test completed successfully");
		}

		[Theory]
		[InlineData("standard_user", "secret_sauce")]
		public void UC3_LoginWithValidCredentials_RedirectsToDashboard(string username, string password)
		{
			TestLogger.Logger.Information("Starting UC3 test with valid credentials");

			_loginPage.ClearUsernameField();
			_loginPage.ClearPasswordField();
			_loginPage.Login(username, password);

			_driver.Title.Should().Be("Swag Labs");

			TestLogger.Logger.Information("UC3 test completed successfully");
		}

		public void Dispose()
		{
			_driver.Quit();
			_driver.Dispose();
		}

	}
}

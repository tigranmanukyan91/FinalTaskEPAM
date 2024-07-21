using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace FinalTaskEPAM.Drivers
{
	public class WebDriverFactory
	{
		public static IWebDriver CreateWebDriver(string browser)
		{
			return browser.ToLower() switch
			{
				"firefox" => new FirefoxDriver(),
				"chrome" => new ChromeDriver(),
				_ => throw new ArgumentException("Unsupported browser"),
			};
		}
	}
}


/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
namespace BooksWagonTestProject.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        public static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        //giving the url and setting up the process
        [SetUp]
        public void Setup()
        {
            var fileInfo = new FileInfo(@"App.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");
            try
            {

                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-notifications");

                driver = new ChromeDriver(options);
                //Giving maxmize method to maxmize the screen
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.bookswagon.com/";
                log.Debug("navigating to url");

                log.Info("Exiting setup");

            }
            //Using the custom exceptions
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session is not estbalished");
            }

            //Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);



            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        //Closing the Entriepage 
        [TearDown]
        public void TearDown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            driver.Quit();
        }

        //using the TakeScreenShotMethod to take Screenshots
        public static void TakeScreenshot1()
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\ScreenShot\Purchasing.jpg");
            System.Threading.Thread.Sleep(900);
        }
    }
}

    

/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class LogOutPage
    {
        //using the pagefactory
        public LogOutPage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }
        //used to find and click on the profile button by speifying its locator
        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li/a/span")]
        [CacheLookup]
        public IWebElement profileButton;

        //used to find and click on the profile button by speifying its locator
        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li/div/div/div[1]/ul/li[8]/a")]
        [CacheLookup]
        public IWebElement LogoutButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='site-wrapper']")]
        [CacheLookup]
        public IWebElement Loginpage;
    }
}

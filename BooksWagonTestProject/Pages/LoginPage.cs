/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //used to find and click on the Login button by speifying its locator
        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li[1]/a")]
        [CacheLookup]
        public IWebElement LoginButton;

        //used to find and click on the Email field by speifying its locator
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement EmailField;

        //used to find and click on the password field by speifying its locator
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement PasswordField;

        //Enter the Login button in the particular field
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[5]/input[1]")]
        [CacheLookup]
        public IWebElement LoginBtn;

    }
}

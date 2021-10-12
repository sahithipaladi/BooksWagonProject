/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class InvalidSignUp
    {
        public InvalidSignUp(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Click on the Signup button
        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li[2]/a")]
        [CacheLookup]
        public IWebElement SignUpButton;

        //Enter the Email in the particular field
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement Username;

        //Enter the Password in the particular field
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[3]/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement Password;

        //Enter the ReConfirmPassword in the particular field
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[4]/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement ConfirmPassword;

        //Enter the CreateNewAcoount in the particular field
        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$btnSubmit")]
        [CacheLookup]
        public IWebElement CreateAccountButton;

       
    }
}

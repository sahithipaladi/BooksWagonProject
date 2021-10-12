/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BooksWagonTestProject.Pages
{
    public class PurchasingProduct
    {
        public PurchasingProduct(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div[3]/div[2]/div[1]/div[2]/div/div/div/a")]
        [CacheLookup]
        public IWebElement ContinueBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewRecipientName")]
        [CacheLookup]
        public IWebElement Name;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCompanyName")]
        [CacheLookup]
        public IWebElement Companyname;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewAddress")]
        [CacheLookup]
        public IWebElement address;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewCountry")]
        [CacheLookup]
        public IWebElement country;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewState")]
        [CacheLookup]
        public IWebElement State;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewCities")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]
        [CacheLookup]
        public IWebElement pincode;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]
        [CacheLookup]
        public IWebElement phonenumber;


        [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]
        [CacheLookup]
        public IWebElement savebutton;

    }
}
    


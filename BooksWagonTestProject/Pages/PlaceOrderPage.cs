/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class PlaceOrderPage
    {
        public PlaceOrderPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[3]/div[2]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[3]/input[1]")]
        [CacheLookup]
        public IWebElement QuantityBtn;

        //used to click the placeorder button by speifying its locator
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[2]/div[1]/div[1]/div[4]/table[1]/tbody[1]/tr[1]/td[3]/input[1]")]
        [CacheLookup]
        public IWebElement PlaceOrderButton;


       
    }
}

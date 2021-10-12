/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class WishlistPage
    {
        public WishlistPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       

        //used to find and click on the Login button by speifying its locator
        [FindsBy(How = How.Id, Using = "ctl00_phBody_lblheading")]
        [CacheLookup]
        public IWebElement mywishlist;
    }

}

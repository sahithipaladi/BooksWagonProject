/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class SearchPage
    {
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //searching the items from myntra using findsby method
        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        [CacheLookup]
        public IWebElement Searchbar;

        //used to find and click on the product by speifying its locator
        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$Button1")]
        [CacheLookup]
        public IWebElement SearchIcon;

        //used to find and click on the Login button by speifying its locator
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[3]/div[2]/div[1]/div[4]/div[5]/a[2]/input[1]")]
        [CacheLookup]
        public IWebElement WishlistButton;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[4]/div[4]/table[1]/tbody[1]/tr[3]/td[1]/div[1]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement BuyNow;


       


    }
}

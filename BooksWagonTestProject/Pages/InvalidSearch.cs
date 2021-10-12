/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagonTestProject.Pages
{
    public class InvaildSearch
    {
        //using the pagefactory
        public InvaildSearch(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }
        //searching the items from myntra using findsby method
        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        [CacheLookup]
        public IWebElement SearchBar;

        //used to find and click on the search by speifying its locator
        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$Button1")]
        [CacheLookup]
        public IWebElement SearchButton;

        //used to find and click on the invalidtext by speifying its locator
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[3]/div[1]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement invalidText;

    }
}

   
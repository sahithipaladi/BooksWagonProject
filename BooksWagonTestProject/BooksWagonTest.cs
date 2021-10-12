/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;


namespace BooksWagonTestProject
{
    [TestFixture]
    [AllureNUnit]
    public class Tests : Base.BaseClass
    {
       
        //Passing the TestCases
        [Test, Order(1)]
        public void SignUpIntoBookswagon()
        {
           
            ActionDo.ActionDo.SignUpToBooksWagon(driver);
            TakeScreenshot1();
          
        }
        [Test(Description = "login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //Passing the TestCases
        // [Test, Order(2)]
        public void LoginIntoBooksWagon()
        {
            
            ActionDo.ActionDo.LoginToBooksWagon();
            TakeScreenshot1();
        }
        [Test(Description = "login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //Testing for SearchinganItem
        //[Test, Order(3)]
        public void SearchinganItem()
        {
           
            ActionDo.ActionDo.SearchintoBookswagon(driver);
           
            TakeScreenshot1();
         }
        //Testing for Addingintowishlist
        [Test, Order(4)]
        public void WishlistAdding()
        {
           
            ActionDo.ActionDo.AddingIntoWishlist(driver);
            TakeScreenshot1();
        }
        [Test, Order(5)]

        public void PlaceOrder()
        {
            
            ActionDo.ActionDo.PlaceOrderFeature();
            TakeScreenshot1();

        }
        [Test, Order(6)]

        public void purchasingaproduct()
        {

            ActionDo.ActionDo.PurchasingaProduct();
            TakeScreenshot1();

        }
        [Test, Order(7)]

        public void LogOutFeature()
        {

            ActionDo.ActionDo.LogoutPage(driver);
            TakeScreenshot1();
        }

        //Testing for the invalid data
        [Test, Order(8)]

        public void InvaildLogin()
        {
           
            ActionDo.ActionDo.InVaildDataSending();
            TakeScreenshot1();
        }
        //Testing for the invalid data
        [Test, Order(9)]

        public void InvaildSearching()
        {

            ActionDo.ActionDo.InVaildSearching();
            TakeScreenshot1();
        }
        //Testing for the invalid data
        [Test, Order(10)]

        public void Invalidsignup()
        {

            ActionDo.ActionDo.InVaildSignUp();
            TakeScreenshot1();
        }


    }
}
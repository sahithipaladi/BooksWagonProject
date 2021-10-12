/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   5/10/2021
 */
using BooksWagonTestProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BooksWagonTestProject.ActionDo
{
    public class ActionDo : Base.BaseClass
    {
        public static LoginPage login;
        //Asserting the title
        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Online Bookstore | Buy Books Online | Read Books Online";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void SignUpToBooksWagon(IWebDriver driver)
        {
            try
            {
                //using Excel Operations and Reading from it
                ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\SignUpData.xlsx");
                SignUpPage SignUp = new SignUpPage(driver);

                //Click on the signup button
                SignUp.SignUpButton.Click();
                System.Threading.Thread.Sleep(1000);

                //Enter the Email in the particular field
                SignUp.Email.SendKeys(ExcelOperations.ReadData(1, "Email"));
                System.Threading.Thread.Sleep(1000);

                //Enter the Password in that field
                SignUp.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                //Enter the ReConfirmPassword in the that field
                SignUp.ReconfirmPassword.SendKeys(ExcelOperations.ReadData(1, "ReConfirmPassword"));
                System.Threading.Thread.Sleep(1000);

                //Click on the CreatenewAccount button
                SignUp.CreateAccountButton.Click();
                System.Threading.Thread.Sleep(1000);

                //Adding validations 
                Assert.IsTrue(SignUp.SignupPage.Displayed);

            }
            catch
            {
                //giving the Custom Exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }
        }
        public static void LoginToBooksWagon()
        {
            try
            {
                //Using the Excel operations and reading from it
                ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\LoginData.xlsx");

                login = new LoginPage(driver);

                //clicking on the profile button
                login.LoginButton.Click();
                System.Threading.Thread.Sleep(300);

                //clicking on signbutton
                login.EmailField.SendKeys(ExcelOperations.ReadData(1, "EmailField"));
                System.Threading.Thread.Sleep(300);

                //enter the mobilenumber in the particular field
                login.PasswordField.SendKeys(ExcelOperations.ReadData(1, "PasswordField"));
                System.Threading.Thread.Sleep(2000);

                //clicking on the continuebutton
                login.LoginBtn.Click();
                System.Threading.Thread.Sleep(500);

                //giving the validations
                string actualUrl = "https://www.bookswagon.com/myaccount.aspx";
                string expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }
        }
        public static SearchPage search;

        public static void SearchintoBookswagon(IWebDriver driver)
        {
            try
            {
                //Using the Excel operations and reading from it
                ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\SearchData.xlsx");

                search = new SearchPage(driver);

                //enter the item name in the searchbar
                search.Searchbar.SendKeys(ExcelOperations.ReadData(1, "SearchItem"));
                if (search.Searchbar != null)
                {
                    //using the keys class
                    search.Searchbar.SendKeys(Keys.ArrowDown);
                    search.Searchbar.SendKeys(Keys.Enter);
                    //Clicking on the searchicon
                    search.SearchIcon.Click();
                    //Adding books into Wishlist
                    search.WishlistButton.Click();
                    search.BuyNow.Click();                
                }


            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }

        }
        public static WishlistPage wishlist;

        public static void AddingIntoWishlist(IWebDriver driver)
        {
            try
            {
                wishlist = new WishlistPage(driver);
                ActionDo.LoginToBooksWagon();
                ActionDo.SearchintoBookswagon(driver);



                //giving the validations
                Assert.IsTrue(wishlist.mywishlist.Displayed);
                System.Threading.Thread.Sleep(500);
            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }
        }
        public static PlaceOrderPage PlaceOrder;
        public static void PlaceOrderFeature()
        {
            try
            {


                PlaceOrder = new PlaceOrderPage(driver);

                ActionDo.LoginToBooksWagon();
                ActionDo.SearchintoBookswagon(driver);

                //Using the switch to command anf frame 
                 driver.SwitchTo().Frame(0);

                 //Changing the quantity
                 PlaceOrder.QuantityBtn.Click();

                //Click on the olaceorderbutton
                PlaceOrder.PlaceOrderButton.Click();
                System.Threading.Thread.Sleep(4000);



            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }
        }
        public static PurchasingProduct Purchasing;
        public static void PurchasingaProduct()
        {
            try
            {
                //Using the Excel operations and reading from it
                ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\PurchasingProductData.xlsx");

                PurchasingProduct purchasing = new PurchasingProduct(driver);
                //ActionDo.LoginToBooksWagon();
                //ActionDo.SearchintoBookswagon(driver);
                ActionDo.PlaceOrderFeature();

                //Clicking on the Continue  button
                 purchasing.ContinueBtn.Click();
                 System.Threading.Thread.Sleep(2000);

                //Clicking on Name
                purchasing.Name.SendKeys(ExcelOperations.ReadData(1, "Name"));

                //Entering the company name
                purchasing.Companyname.SendKeys(ExcelOperations.ReadData(1, "Companyname"));

                //Entering the address
                purchasing.address.SendKeys(ExcelOperations.ReadData(1, "address"));

                //Entering the country
                purchasing.country.SendKeys(ExcelOperations.ReadData(1, "country"));

                //Entering the state
                purchasing.State.SendKeys(ExcelOperations.ReadData(1, "State"));

                //Entering the city
                purchasing.city.SendKeys(ExcelOperations.ReadData(1, "city"));

                //Entering the pincode
                purchasing.pincode.SendKeys(ExcelOperations.ReadData(1, "pincode"));

                //Entering the phonrnumber
                purchasing.phonenumber.SendKeys(ExcelOperations.ReadData(1, "phonenumber"));

                //Clicking on the save button
                purchasing.savebutton.Click();
                System.Threading.Thread.Sleep(500);
            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }

        }
        public static LogOutPage Logout;
        public static void LogoutPage(IWebDriver driver)
        {
            try
            {
                Logout  = new LogOutPage(driver);


               //click on the login
               ActionDo.LoginToBooksWagon();


                //click on the profile button
                Logout.profileButton.Click();

                //Clicking on the logout button
                Logout.LogoutButton.Click();
                System.Threading.Thread.Sleep(500);



                Assert.IsTrue(Logout.Loginpage.Displayed);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");
            }
        }



        public static InvaildData invalid;
        public static void InVaildDataSending()
        {
            try
            {

                //Using the Excel operations and reading from it
                ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\InvalidLoginData.xlsx");

                InvaildData invaild = new InvaildData(driver);

                //Clicking on the profile button
                invaild.LoginButton.Click();
                //Clicking on the profile button
                invaild.UserName.SendKeys(ExcelOperations.ReadData(1, "UserName"));
                //Clicking on the profile button
                invaild.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                //Clicking on the profile button
                invaild.LoginIcon.Click();
                
                //Adding Validation Using Text
                string expected = "Please enter correct Email or Password.";
                string actual = driver.FindElement(By.Id("ctl00_phBody_SignIn_lblmsg")).Text;
                Console.WriteLine("Message: {0}", actual);
                Assert.AreEqual(expected, actual);
                try
                {
                    Console.WriteLine("sucessful");
                }
                catch
                {
                    Console.WriteLine("not sucessful");
                }
            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }

        }
        public static InvaildSearch Invalid;
        public static void InVaildSearching()
        {
            try
            {

                //Using the Excel operations and reading from it
                ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\InvalidSearchData.xlsx");

                InvaildSearch invalid = new InvaildSearch(driver);
                //searching an product
                invalid.SearchBar.SendKeys(ExcelOperations.ReadData(1, "SearchedProduct"));
                //Clicking on the searchicon
                invalid.SearchButton.Click();

                //giving the validations
                Assert.IsTrue(invalid.invalidText.Displayed);
            }
            catch
            {
                //using the custom exceptions
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Element is not found in the application");
            }
        }
        public static InvalidSignUp signup;
        public static void InVaildSignUp()
        {


            //Using the Excel operations and reading from it
            ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\BooksWagonTestProject\BooksWagonTestProject\TestDataFiles\InvalidSignup.xlsx");

            InvalidSignUp invalid = new InvalidSignUp(driver);
            invalid.SignUpButton.Click();
            invalid.Username.SendKeys(ExcelOperations.ReadData(1, "Username"));
            invalid.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
            invalid.ConfirmPassword.SendKeys(ExcelOperations.ReadData(1, "ConfirmPassword"));
            invalid.CreateAccountButton.Click();

            //Adding Validation Using Text
            string expected = "Password Mismatch";
            string actual = driver.FindElement(By.Id("ctl00_phBody_SignUp_cvPassword")).Text;
            Console.WriteLine("Message: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("sucessful");
            }
            catch
            {
                Console.WriteLine("not sucessful");
            }

        }
    }
}
















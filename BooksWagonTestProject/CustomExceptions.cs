/*
 * Project: Using BooksWagon Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using System;
namespace BooksWagonTestProject
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            //Adding the custom exceptions
            NULL_EXCEPTION, CLASS_NOT_FOUND, METHOD_NOT_FOUND, WebDriverException, NoSuchElementException, NoSuchWindowException, InvalidSelectorException, NoSuchSessionException, FileNotFoundException
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}


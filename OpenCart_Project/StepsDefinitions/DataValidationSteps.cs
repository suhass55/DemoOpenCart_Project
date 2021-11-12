using log4net;
using NUnit.Framework;
using OpenCart.Pages.PageParts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumAutomation.Base;
using SeleniumAutomation.Selenium;
using SeleniumAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenCart.Pages.PageConstants;
using OpenQA.Selenium.Chrome;

namespace OpenCart.StepsDefinitions
{
    [Binding]
    public class DataValidationSteps : BaseClass
    {
        public DataValidationPage _DataValidationPage;
        public string Filename;
        public string CompanyName1;
        public string ImportError;
        public IWebDriver driver;
        public ILog log4Net;
        public string FinitiveTestSetup;
        public string CompanyDateToUpdate;
        public string CompanyDateReceived;


        public Dictionary<string, string> _QTDDictionary = new Dictionary<string, string>();
        public Dictionary<string, string> _YTDDictionary = new Dictionary<string, string>();
        public string _QERQuarter;
        public List<string> _Covid19LinksTaxData = new List<string>();
        public DataValidationSteps(IWebDriver _driver)
        {
            driver = _driver;
            log4Net = LogManager.GetLogger("DataValidationSteps");
            _autoutilities = new AutomationUtilities();
            _DataValidationPage = new DataValidationPage(driver);
            FinitiveTestSetup = TestContext.Parameters["Setup"];
        }
        public string TaxCode { get; set; }
        public string ReportCode { get; set; }
        public string EmployeeSSN { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        public string DataSetup { get; private set; }

        public string Resources_Path;
        public string CompName;
        public string CompName2;
        public string CompName3;
        public string CompName1;
        public string Url;
        public string portlet;
        public int iCategory, iCode;
        public static string cname = null;
        public static string ccode = null;
        public static string EIN = null;
        public static string cname2 = null;
        public static string cname3 = null;
        public static string Portlet = null;
        public string FileNameToImport = "XMLWithCurrentQuarter";


        [Given(@"Navigate to Finitive url And Verify '(.*)'")]
        public void ThenNavigateToUrl(string PageTitle)
        {
            if (FinitiveTestSetup == "Yes")
            {
                Url = "https://demo.opencart.com/";
                driver.Navigate().GoToUrl(Url);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Manage().Window.Maximize();
                string ActualTitle = driver.Title;
                Assert.AreEqual(PageTitle, ActualTitle);
                log4Net.Info("Finitive site title verified and user navigated successfully");

            }
        }

        [Then(@"Click On '(.*)' Button In The DropDown")]
        public void ThenClickOnRegisterButton(string RegisterButton)
        {
            _DataValidationPage.ClickOnRegisterButton(RegisterButton);
        }

        [Then(@"Verify '(.*)' page is displayed")]
        public void ThenVerifyRegisterAccountPageIsDisplayed(string RegisterAccountExpectedText)
        {
            _DataValidationPage.VerifyRegisterAccountPageIsDisplayed(RegisterAccountExpectedText);
        }

        [Then(@"Enter All Personal Details In The Register Account Page")]
        public void EnterRegistrationDetails()
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            _DataValidationPage.EnterRegistrationDetails("Test", "DOC", "Test" + milliseconds + "@gmail.com", "9112233445", "Test@321", "Test@321");

        }

        [Then(@"Click On Continue Button")]
        public void ClickContinueButton()
        {
            _DataValidationPage.ClickOnContinueButton();
        }

        [Then(@"Verify '(.*)' Text Is Displayed")]
        public void VerifyAccountCreatedTextIsDisplayed(string AccountCreatedMessage)
        {
            _DataValidationPage.VerifyAccountCreatedTextIsDisplayed(AccountCreatedMessage);
        }

        [Then(@"Click On '(.*)' Button")]
        public void ClickOnLogoutButton(string Logout)
        {
            _DataValidationPage.ClickOnLogoutButton(Logout);
        }

        [Then(@"Verify '(.*)' Message Is Displayed")]
        public void VerifyAccountLogoutMessageIsDisplayed(string Logout_Message)
        {
            _DataValidationPage.VerifyAccountLogoutMessageIsDisplayed(Logout_Message);
        }

        [Then(@"Login with credintials '(.*)' and '(.*)'")]
        public void LoginToOpenCart(string ID, string pwd)
        {
            _DataValidationPage.LoginToOpenCart(ID, pwd);

        }

        [Then(@"Click on Home button")]
        public void ClickOnHomeButton()
        {
            _DataValidationPage.ClickOnHomeButton();
        }

        [Then(@"Verify '(.*)' is displayed")]
        public void VerifyYourStorePageIsDisplayed(string HomePageText)
        {
            _DataValidationPage.VerifyYourStorePageIsDisplayed(HomePageText);
        }


        [Then(@"Click on currency dropdown and select '(.*)'")]
        public void ClickOnCurrencyDropAndSelectACurrency(string Currency)
        {
            _DataValidationPage.ClickOnCurrencyDropAndSelectACurrency(Currency);
        }

        [Then(@"Verify if all product is displayed with '(.*)' currecy")]
        public void VerifyIfAllProductIsDisplayedWithCurrecySelected(string Currency_Symbol)
        {
            _DataValidationPage.VerifyIfAllProductIsDisplayedWithCurrecySelected(Currency_Symbol);
        }

        [Then(@"Click on Add To Cart button for '(.*)' product")]
        public void ClickOnAddToCartForAProduct(string Product_Name)
        {
            _DataValidationPage.ClickOnAddToCartForAProduct(Product_Name);

        }

        [Then(@"Clik on cart button")]
        public void ClikOnCartButton()
        {
            _DataValidationPage.ClikOnCartButton();
        }

        [Then(@"Verify if the product '(.*)' is added to cart")]
        public void VerifyIfTheProductIsAddedToCart(string Product_Name)
        {
            _DataValidationPage.VerifyIfTheProductIsAddedToCart(Product_Name);
        }

        [Then(@"MouseHover On Desktop Header And Click On '(.*)'")]
        public void MouseHoverOnDesktopHeaderAndClickOnMacButton(string Button)
        {
            _DataValidationPage.MouseHoverOnDesktopHeaderAndClickOnMacButton( Button);
        }

        public string Product_Name;
        public string Product_Price;
        [Then(@"Fetch Product Details And Add To WishList")]
        public void FetchProductDetailsAndAddProductToWishList()
        {
            Product_Name = _DataValidationPage.FetchProductName();
            Product_Price =  _DataValidationPage.FetchProductPriceAndAddProductToWishList();
        }

        [Then(@"Verify '(.*)' Message is Displayed")]
        public void VerifySuccessfullAddedMessageIsDisplayed(string ExpectedMessage)
        {
            _DataValidationPage.VerifySuccessfullAddedMessageIsDisplayed(ExpectedMessage);

        }

        [Then(@"Click On Wish List")]
        public void ClickOnWishList()
        {
            _DataValidationPage.ClickOnWishList();
        }

        [Then(@"Verify The Product In WishList")]
        public void VerifyProductInWishList()
        {
            _DataValidationPage.VerifyProductInWishList(Product_Name, Product_Price);
        }

        [Then(@"Remove Product From WishList")]
        public void RemoveProductFromWishList()
        {
            _DataValidationPage.RemoveProductFromWishList();
        }

        [Then(@"Click '(.*)' Button")]
        public void ClickEditAccountButton(string Edit_Button)
        {
            _DataValidationPage.ClickEditAccountButton(Edit_Button);
        }

        [Then(@"Verify '(.*)' Page Is Displayed")]
        public void VerifyAccountInfoPageIsDisplayed(string Page_Title)
        {
            _DataValidationPage.VerifyAccountInfoPageIsDisplayed(Page_Title);
        }

        [Then(@"Change FirstName LastName Click Continue Button")]
        public void ChangeFirstAndLastNameAndClickContinueBUtton()
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            _DataValidationPage.ChangeFirstAndLastNameAndClickContinueBUtton("Test"+milliseconds, "zenq"+milliseconds);
        }

        [Then(@"Verify '(.*)' Is Displayed")]
        public void VerifySuccessMessageIsDislayed(string SuccessfullyUpdated_Message)
        {
            _DataValidationPage.VerifySuccessMessageIsDislayed(SuccessfullyUpdated_Message);
        }
    }
}

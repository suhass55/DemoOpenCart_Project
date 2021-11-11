using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OpenCart.Pages.PageConstants
{
    class DataValidationPageLocators
    {
        // For Finitive application...
        public static By UserNameForTaxEx = By.Id("input-email");
        public static By PasswordForTaxEx = By.Id("input-password");
        public static By SignInButton = By.XPath("//input[@type='submit']");
        public static By SignupButton = By.XPath("//a[@class='btn-link mainMenu__link mainMenu__link_button']");
        public static By SignupPage = By.Id("signUp");
        public static By FirstNameTextField = By.Id("FirstName");
        public static By LastNameTextField = By.Id("LastName");
        public static By CompanyNameTextField = By.Id("CompanyName");
        public static By PositionTextField = By.Id("Position");
        public static By CompanyWebsiteUrl = By.Id("BusinessUrl");
        public static By CountryCodeDropdown = By.XPath("//div[@aria-controls='iti-0__country-listbox']");
        public static By CountryCodeDropdownList = By.XPath("//ul[@class='iti__country-list iti__country-list--dropup']/li");
        public static By TelephoneNumberTextfield = By.XPath("//input[@id='PhoneNumber']");
        public static By CountryDropdown = By.Id("CountryId");
        public static By CountryDropdownList = By.XPath("//select[@id='CountryId']/option");
        public static By MarketingSourceDropdown = By.Id("MarketingSourceId");
        public static By MarketingSourceDropdownList = By.XPath("//select[@name='MarketingSourceId']/option");
        public static By FinitivePlateformList = By.XPath("//div[@class='finitiveForm__groups signUpForm__groups']/div/label");
        public static By BusinessEmailTextField = By.Id("Email");
        public static By PasswordTextField = By.Id("Password");
        public static By InstitutionalInvestorCheckbox = By.XPath("//div[@class='finitiveForm__groups signUpForm__institutionalInvestorOptions']/div/label");
        public static By DescribeYourCompanyCheckbox = By.XPath("//div[@class='finitiveForm__groups signUpForm__institutionalInvestorCompanyDescriptionOptions']/div/label");
        public static By ButtonSignup = By.XPath("//button[@type='submit']");
        public static By TermsprivacyCheckbox = By.Id("HasAgreedToTerms");
        public static By EmailVerificationPendingText = By.XPath("//h1[@class='finitiveForm__title confirmEmailForm__title']");
        public static By LoginEmailTextField = By.XPath("//input[contains(@class,'input form-control')]");

        public static By ApplicationTitle = By.XPath("//a[@class='navbar-brand']/following-sibling::p");
        public static By SignUpPageText = By.XPath("//h2[@class='finitiveForm__title signUpForm__title text-center']");
        public static By ExpectedQuestion = By.XPath("//div[contains(@class,'Form__institutionalInvestor collapse')]/span");
        public static By QuestionExpected = By.XPath("//div[contains(@class,'Form__institutionalInvestorType collapse')]/span");
        public static By EmailVerificationSuccessful = By.XPath("//p[contains(@class,'emailConfirmedForm__text')]");
        public static By LoginButton = By.XPath("//a[contains(@class,'Menu__link_button_login')]");
        public static By LoginSubmitButton = By.XPath("//button[contains(@class,'loginForm__loginButton')]");
        public static By UserNameButton = By.XPath("//a[contains(@class,'username ')]");
        public static By LogOffButton = By.XPath("//form[contains(@class,'form-inline')]");
        public static By MenuDropDown = By.XPath("//a[contains(@class,'username ')]/following-sibling::div/a");
        public static By NotificationDropdown = By.Id("notifications");

        //For OpenCart Application
        public static By MyAccountButton = By.XPath("//a[@title='My Account']");
        public static By MyAccountDropDownList = By.XPath("//a[@title='My Account']/following-sibling::ul/li");
        public static By RegisterAccountActualText = By.XPath("//div[@id='content']/h1");
        public static By RegisterFirstNameTextField = By.Id("input-firstname");
        public static By RegisterlastNameTextField = By.Id("input-lastname");
        public static By RegisterEmailTextField = By.Id("input-email");
        public static By RegisterTelephoneTextField = By.Id("input-telephone");
        public static By RegisterPasswordTextField = By.Id("input-password");
        public static By ConfirmPasswordTextField = By.Id("input-confirm");
        public static By PrivacyPolicyCheckBox = By.XPath("//input[@name='agree']");
        public static By RegisterAccountContinueButton = By.XPath("//input[@type='submit']");
        public static By AccountCreatedMessage = By.XPath("//div[@id='content']/h1");
        public static By AccountLoggedOutMessage = By.XPath("//div[@id='content']/h1");
        public static By OpenCartEmailTextField = By.Id("input-email");
        public static By OpenCartPasswordTextField = By.Id("input-password");
        public static By OpenCartLoginButton = By.XPath("//input[@type = 'submit']");
        public static By HomeButton = By.XPath("//i[@class = 'fa fa-home']");
        public static By CurrencyDropDown = By.XPath("//form[@id = 'form-currency']/div/button");
        public static By CurrencyList = By.XPath("//ul[@class='dropdown-menu']/li");
        public static By CurrectSelected = By.XPath("//button[@data-toggle = 'dropdown']/strong");
        public static By HomePageActualTitle = By.Id("logo");
        public static By OpenCartProductList = By.XPath("//div[@class='row']/div/div/div/following-sibling::div/h4/a");
        public static By OpenCartAddToCartButton = By.Id("button-cart");
        public static By CartButton = By.Id("cart");
        public static By ProductInCart = By.XPath("//div[@id='cart']/button/following-sibling::ul/descendant::td/following-sibling::td/a");
        public static By RemoveProductFromCart = By.XPath("//button[@title='Remove']");



    }
}

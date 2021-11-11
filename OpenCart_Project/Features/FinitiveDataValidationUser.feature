Feature: OpenCartDataValidationUser
	#RegistrationTest

	@1 @Regression @Smoke
Scenario: 1: Demo.OpenCart Registration process in the Application
	Given Navigate to Finitive url And Verify 'Your Store'
	Then Click On 'Register' Button In The DropDown
	And Verify 'Register Account' page is displayed
	Then Enter All Personal Details In The Register Account Page
	And Click On Continue Button
	Then Verify 'Your Account Has Been Created!' Text Is Displayed
	Then Click On 'Logout' Button
	And Verify 'Account Logout' Message Is Displayed

	@2 @Regression @Smoke
Scenario: 2: Demo.OpenCart Adding Product To Cart
	Given Navigate to Finitive url And Verify 'Your Store'
	Then Click On 'Login' Button In The DropDown
	And Login with credintials 'Testzenq55@gmail.com' and 'Test321' 
	Then Click on Home button
	And Verify 'Your Store' is displayed
	Then Click on currency dropdown and select '£ Pound Sterling'
	And Verify if all product is displayed with '£' currecy
	Then Click on Add To Cart button for 'MacBook' product
	Then Clik on cart button 
	And Verify if the product 'MacBook' is added to cart
	Then Click On 'Logout' Button
	And Verify 'Account Logout' Message Is Displayed
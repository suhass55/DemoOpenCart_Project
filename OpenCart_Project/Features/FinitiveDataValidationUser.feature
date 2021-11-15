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

		@3 @Regression @Smoke
Scenario: 3: Demo.OpenCart Adding Product To WishList
	Given Navigate to Finitive url And Verify 'Your Store'
	Then Click On 'Login' Button In The DropDown
	And Login with credintials 'Testzenq55@gmail.com' and 'Test321'
	Then Click on Home button
	And Verify 'Your Store' is displayed
	Then MouseHover On Desktop Header And Click On 'Mac (1)'
	Then Fetch Product Details And Add To WishList
	And Verify 'Success: You have added iMac to your wish list!' Message is Displayed
	Then Click On Wish List
	And Verify The Product In WishList 
	Then Remove Product From WishList
	Then Click On 'Logout' Button
	And Verify 'Account Logout' Message Is Displayed

	@4 @Regression @Smoke
Scenario: 4: Demo.OpenCart ChangingUser Name
	Given Navigate to Finitive url And Verify 'Your Store'
	Then Click On 'Login' Button In The DropDown
	And Login with credintials 'Testzenq55@gmail.com' and 'Test321'
	Then Click 'Edit Account' Button
	And Verify 'My Account Information' Page Is Displayed
	Then Change FirstName LastName Click Continue Button
	And Verify 'Success: Your account has been successfully updated.' Is Displayed
	Then Click On 'Logout' Button
	And Verify 'Account Logout' Message Is Displayed

	@5 @Regression @Smoke
Scenario: 5: Demo.OpenCart Writing Review On Product
	Given Navigate to Finitive url And Verify 'Your Store'
	Then Click On 'Login' Button In The DropDown
	And Login with credintials 'Testzenq55@gmail.com' and 'Test321' 
	Then Click on Home button
	And Verify 'Your Store' is displayed
	Then Open 'MacBook' Product Page
	And Verify If 'MacBook' Page Is Displayed
	Then Write a Review And Click Continue
	And Verify that 'Thank you for your review. It has been submitted to the webmaster for approval.' Is Displayed
	Then Click On 'Logout' Button
	And Verify 'Account Logout' Message Is Displayed

	@6 @Regression @Smoke
Scenario: 6: Demo.OpenCart Search For a Product And Verify
	Given Navigate to Finitive url And Verify 'Your Store'
	Then Click On 'Login' Button In The DropDown
	And Login with credintials 'Testzenq55@gmail.com' and 'Test321'
	Then Search For 'iPhone' Product
	And Verify That The 'iPhone' Product Is Displayed
	Then Click On 'Logout' Button
	And Verify 'Account Logout' Message Is Displayed
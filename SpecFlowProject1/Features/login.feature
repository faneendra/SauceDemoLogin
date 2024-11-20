Feature: Login Functionality
  As a user of Sauce Demo
  I want to be able to log in with valid credentials
  So that I can access the product page

  Scenario: Valid Login
    Given I am on the Sauce Demo login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the products page
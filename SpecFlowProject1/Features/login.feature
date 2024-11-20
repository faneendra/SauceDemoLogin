Feature: Login Functionality

  Scenario: Valid Login
    Given I am on the login page of Sauce Demo
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the products page
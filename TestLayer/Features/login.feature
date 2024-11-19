Feature: Login Functionality

  Scenario: Successful Login
    Given I am on the SauceDemo login page
    When I enter valid credentials
    And I click on the login button
    Then I should be redirected to the products page
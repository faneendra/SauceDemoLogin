Feature: Login Functionality

  Scenario: Valid Login
    Given I am on the Swag Labs login page
    When I enter a valid username 'standard_user'
    And I enter the corresponding password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the products page

  Scenario: Invalid Login
    Given I am on the Swag Labs login page
    When I enter an invalid username 'invalid_user'
    And I enter any password
    And I click the login button
    Then I should remain on the login page and receive an error message about invalid credentials

  Scenario: Empty Username
    Given I am on the Swag Labs login page
    When I leave the username field empty
    And I enter a valid password
    And I click the login button
    Then I should remain on the login page and receive an error message about the necessity to enter a username

  Scenario: Empty Password
    Given I am on the Swag Labs login page
    When I enter a valid username
    And I leave the password field empty
    And I click the login button
    Then I should remain on the login page and receive an error message about the necessity to enter a password
Feature: Login Functionality

  Scenario: Valid Login
    Given I navigate to the Swag Labs login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the products page

  Scenario: Invalid Login
    Given I navigate to the Swag Labs login page
    When I enter invalid username 'invalid_user' and any password
    And I click the login button
    Then I should remain on the login page and receive an error message about invalid credentials

  Scenario: Empty Username
    Given I navigate to the Swag Labs login page
    When I leave the username field empty and enter a valid password
    And I click the login button
    Then I should remain on the login page and receive an error message about the necessity to enter a username

  Scenario: Empty Password
    Given I navigate to the Swag Labs login page
    When I enter a valid username and leave the password field empty
    And I click the login button
    Then I should remain on the login page and receive an error message about the necessity to enter a password
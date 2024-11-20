Feature: Login Functionality

  Scenario: Valid Login
    Given the user is on the login page
    When the user enters valid username 'standard_user' and password 'secret_sauce'
    And the user clicks on login button
    Then the user should be redirected to the products page

  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid username 'invalid_user' and any password
    And the user clicks on login button
    Then the user remains on the login page and receives an error message about invalid credentials

  Scenario: Empty Username
    Given the user is on the login page
    When the user leaves the username field empty and enters a valid password
    And the user clicks on login button
    Then the user remains on the login page and receives an error message about the necessity to enter a username

  Scenario: Empty Password
    Given the user is on the login page
    When the user enters a valid username and leaves the password field empty
    And the user clicks on login button
    Then the user remains on the login page and receives an error message about the necessity to enter a password
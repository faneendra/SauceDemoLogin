Feature: Login Functionality

  Scenario: Valid Login
    Given the user is on the login page
    When the user enters valid username and password
    And the user clicks on login button
    Then the user should be redirected to the products page

  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid username and password
    And the user clicks on login button
    Then an error message should be displayed

  Scenario: Empty Username
    Given the user is on the login page
    When the user leaves the username empty
    And the user clicks on login button
    Then an error message should be displayed

  Scenario: Empty Password
    Given the user is on the login page
    When the user enters a valid username
    And the user leaves the password empty
    And the user clicks on login button
    Then an error message should be displayed
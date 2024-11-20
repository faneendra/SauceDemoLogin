Feature: Login Functionality

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the products page

  Scenario: Invalid Login
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message about invalid credentials

  Scenario: Empty Username
    Given I am on the login page
    When I leave the username field empty
    And I enter a valid password
    And I click the login button
    Then I should see an error message about the necessity to enter a username

  Scenario: Empty Password
    Given I am on the login page
    When I enter a valid username
    And I leave the password field empty
    And I click the login button
    Then I should see an error message about the necessity to enter a password
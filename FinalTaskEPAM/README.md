# Saucedemo Login Automation

This project contains automated tests for the login functionality of the Saucedemo application using Selenium WebDriver, xUnit, and Fluent Assertions.

## Test Cases

1. **UC-1 Test Login with Empty Credentials**
   - Type any credentials into the "Username" and "Password" fields.
   - Clear the inputs.
   - Hit the "Login" button.
   - Check the error message: "Username is required".

2. **UC-2 Test Login with Empty Password**
   - Type any credentials in the username field.
   - Enter password.
   - Clear the "Password" input.
   - Hit the "Login" button.
   - Check the error message: "Password is required".

3. **UC-3 Test Login with Valid Credentials**
   - Type credentials in the username field (under "Accepted usernames").
   - Enter password as "secret_sauce".
   - Click on Login and validate the title "Swag Labs" in the dashboard.

## Setup

1. Clone the repository.
2. Install the required NuGet packages.
3. Run the tests using the xUnit test runner.

## Patterns and Practices

- **Test Automation Tool**: Selenium WebDriver
- **Browsers**: Firefox, Chrome
- **Locators**: CSS
- **Test Runner**: xUnit
- **BDD Approach**: Used for defining test cases
- **Assertions**: Fluent Assertions
- **Logging**: SeriLog
- **Patterns**: Factory Method, Abstract Factory, Chain of Responsibility

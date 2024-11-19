namespace PageObject
{
    public class Login
    {
        protected By UserName => By.Name("user-name");
        protected By Password => By.XPath("//input[@name='password' and @id = 'password']");
        protected By SubmitButton => By.Id("login-button");
        protected By ErrorButton => By.CssSelector(".error-button");

        protected By AddToCartSelect => By.Id("add-to-cart-sauce-labs-backpack");
    }
}

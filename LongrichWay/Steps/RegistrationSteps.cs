using LongrichWay.PageObject;
using System;
using TechTalk.SpecFlow;

namespace LongrichWay.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        RegPage regPage = new RegPage

        [Given(@"I navigate to ""(.*)""")];
        public void GivenINavigateTo(string url)
        {
            regPage.NavigateToWebsite(url);
        }
        
        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            regPage.ClickRegister();
        }
        
        [When(@"I enter First Name ""(.*)""")]
        public void WhenIEnterFirstName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Last Name ""(.*)""")]
        public void WhenIEnterLastName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Phone Number ""(.*)""")]
        public void WhenIEnterPhoneNumber(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Confirm Password ""(.*)""")]
        public void WhenIEnterConfirmPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Address ""(.*)""")]
        public void WhenIEnterAddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Town ""(.*)""")]
        public void WhenIEnterTown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter State ""(.*)""")]
        public void WhenIEnterState(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Create Account Button")]
        public void WhenIClickOnCreateAccountButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

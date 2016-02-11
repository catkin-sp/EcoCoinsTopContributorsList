using System;
using TechTalk.SpecFlow;

namespace EcoCoins.Tests
{
    [Binding]
    public class ShowTopUsersSteps
    {
        [Given(@"we have on people holding ecocoins")]
        public void GivenWeHaveOnPeopleHoldingEcocoins()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"we have less than (.*) people holding ecocoins")]
        public void GivenWeHaveLessThanPeopleHoldingEcocoins(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"we have (.*) people holding ecocoins")]
        public void GivenWeHavePeopleHoldingEcocoins(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"we have more than (.*) people holding ecocoins")]
        public void GivenWeHaveMoreThanPeopleHoldingEcocoins(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"two or more people have same amount of ecocoins")]
        public void GivenTwoOrMorePeopleHaveSameAmountOfEcocoins()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"people registered their eococins at different times")]
        public void GivenPeopleRegisteredTheirEococinsAtDifferentTimes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user opens '(.*)' page")]
        public void WhenUserOpensPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get '(.*)'")]
        public void ThenGet(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"show all people who holding ecocoins")]
        public void ThenShowAllPeopleWhoHoldingEcocoins()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"sort by decending order")]
        public void ThenSortByDecendingOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"show (.*) Andrei who holding ecocoins")]
        public void ThenShowAndreiWhoHoldingEcocoins(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get the first (.*) people who have more ecocoins")]
        public void ThenGetTheFirstPeopleWhoHaveMoreEcocoins(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"show (.*) people who holding ecocoins")]
        public void ThenShowPeopleWhoHoldingEcocoins(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"get the people who have ecocoins")]
        public void ThenGetThePeopleWhoHaveEcocoins()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"if coint amount is equal for sereval people, sort these people by registration date")]
        public void ThenIfCointAmountIsEqualForSerevalPeopleSortThesePeopleByRegistrationDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"show (.*) first people")]
        public void ThenShowFirstPeople(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

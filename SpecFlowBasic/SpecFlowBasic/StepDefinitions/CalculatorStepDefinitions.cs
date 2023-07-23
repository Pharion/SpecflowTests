namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"{ nameof(GivenTheFirstNumberIs)} : {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
     
        }

        [Then(@"the test should pass ""([^""]*)""")]
        public void ThenTheTestShouldPass(string result)
        {
            Console.WriteLine($"{nameof(ThenTheTestShouldPass)} : {result}");
        }

 
    }
}
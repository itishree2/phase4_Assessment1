using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowProject_assessment.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    { 
    private readonly ScenarioContext scenarioContext;
    private readonly Calculator calculator;
    private int result;
    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        this.scenarioContext = scenarioContext;
        this.calculator = new Calculator();
    }
    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        calculator.Fnum = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        calculator.Snum = number;
    }

    [When("the two numbers are multiplay")]
    public void WhenTheTwoNumbersAreMultiply()
    {
        result = calculator.Mult();
    }

    [When("the two numbers are subsracted")]
        public void WhenTheTwoNumbersAreSubstract()
        {
            result = calculator.Sub();
        }

    [When("the two numbers are Division")]
        public void WhenTheTwoNumbersAreDiv()
        {
            result = calculator.Div();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }
    }
}

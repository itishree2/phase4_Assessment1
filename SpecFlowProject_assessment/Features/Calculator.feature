Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject_assessment/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: multiplay two number
	Given the first number is 50
	And the second number is 2
	When the two numbers are multiplay
	Then the result should be 100

	Scenario: Substract two number
	Given the first number is 50
	And the second number is 2
	When the two numbers are subsracted
	Then the result should be 48
	Scenario: Div two number
	Given the first number is 50
	And the second number is 2
	When the two numbers are Division
	Then the result should be 25


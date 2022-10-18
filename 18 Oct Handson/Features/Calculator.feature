Feature: Calculator

A short summary of the feature

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

 Scenario: Subtract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are subtracted
	Then the output should be 20

	Scenario: Multiply two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are multiplied
	Then the answer should be 3500

	Scenario: Divide two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are divided
	Then the divans should be 3

	Scenario: Sqrt of a number
	Given the first number is 49
	When the two numbers are sqrt
	Then the sqrtans should be 7


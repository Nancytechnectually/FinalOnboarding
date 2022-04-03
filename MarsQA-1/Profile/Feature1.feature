Feature: Feature1

A short summary of the feature

@tag1
Scenario: TC_1_Create Check if the seller is able to Create description in his profile.
	Given I am on Profile page
	When  I add a Description
	Then Actual Description is same as expected description

@tag1
Scenario: TC_2_Check Check if the seller is able to see description in his profile.

	Given I am on Profile page 
	When I check the Seller description Field 
	Then  Description is visible 


@tag1
Scenario: TC_3_Update Check if the seller is able to Update description in his profile.
	Given I am on Profile page 
	When  I Click on Edit description icon  
	Then updated Description is same as expected description

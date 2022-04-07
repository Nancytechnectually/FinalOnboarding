Feature: Feature2Language

Check if seller is able to do CRUD operations on Seller Add Language feature


(Because language can not be added twice ,
make sure it is not already added before 
running a "create" test case. )

(a language must be added before running 
"update" or "delete" Test case)


 
 @tag1
Scenario Outline: TC_1_Create_002 Seller can Create new Language 

		Given I am on Profile page
		And I Click on Language Tab
		When I Create "<Language>" Seller can speak
		Then  Check new Languages has been Added
		
		Examples: 

		| Language |
		| English  |
		| French   |
		| Hindi    |


 @tag1
Scenario:TC_2_Check_002	Check if the seller is able to Read Language in his profile.
Given I am on Profile page
And I Click on Language Tab
When I check the Languages Seller can speak
Then   Languages are visible on Profile page


   @tag1
Scenario: TC_3_Update_002	Check if the seller is able to Update Language in his profile.
		Given I am on Profile page
		And I Click on Language Tab
		When I Update Language Seller can speak
		Then  Check Languages has been updated 




 @tag1
Scenario: TC_4_Delete_002	Check if the seller is able to Delete Language in his profile.
		Given I am on Profile page
		And I Click on Language Tab
		When  I Delete language Seller can speak
		Then  Check Language has been deleted

		





















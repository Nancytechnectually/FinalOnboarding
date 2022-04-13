Feature: Feature2Skills

Check if seller is able to do CRUD operations on Seller Add Skill feature 

(Because Skill can not be added twice ,
make sure it is not already added before 
running a "create" test case. )

(a Skill must be added before running 
"update" or "delete" Test case)


@tag1
Scenario Outline: TC_1_Create_005	Check if the seller is able to Create Skills in his profile.

Given I am on Profile page
And I Click on Skills Tab
When I Create a new  Skill "<Skill>" at "<Level>"
Then  Check New Skill  has been added


Examples: 
|   Skill     | Level       |
|   Skill1    |Beginner     |
|   Skill2    |Intermediate |
|   Skill3    |Expert       |

@tag1
Scenario:TC_2_Check_005	Check if the seller is able to Read Skills in his profile.
Given I am on Profile page
And I Click on Skills Tab
When I check the Skills Seller is offering
Then   Skills are visible on Profile page


@tag1
Scenario: TC_3_Update_005(Add new Skill for each update Test Or delete previous one )  Update Skills in his profile.

Given I am on Profile page
And I Click on Skills Tab
When I Update  Skills Seller is offering
Then  Check   Skills has been updated 





@tag1
Scenario:TC_4_Delete_005	Check if the seller is able to Delete Skills in his profile.
Given I am on Profile page
And I Click on Skills Tab
When I Delete a skill 
Then  Check Skill has been deleted




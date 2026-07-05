Feature: ManageListing

This feature test the functionality of  Edit, view or delete the listing

@tag4
Scenario: 08- Edit in Manage Listing
   Given  Come to the ManageListing tab
   When   I edit the listing by pencil icon
   Then   Listing should be updated successfully

Scenario: 09- View the Manage Listing
Given    Come to the ManageListing tab
When     I view the Listing by eye icon
Then     listin should be visible in new page

Scenario:  10- Delete the viewed Skill from Manage List
Given     Come to the ManageListing tab
When      I delete the viewed skill from list
Then      viewed skill should be deleted successfully
   

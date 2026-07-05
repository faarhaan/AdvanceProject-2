Feature: Education

This feature tests the functionality of adding Education in the SkillShare portal. short summary of the feature

@tag2
Scenario Outline:04- Add Education List
    Given I am on the Education tab
    When I add a new Education list.
    Then Education List should be added successfully

Scenario: 05- Update Education List
    Given  I am on the Education tab
    When   I update Education List
    Then   Education list should be updated successfully.

Scenario: 06- Delete Education List
   Given  I am on the Education tab
   When   I delete the Educaiton list
   Then   All Education entries should be deleted successfully
   
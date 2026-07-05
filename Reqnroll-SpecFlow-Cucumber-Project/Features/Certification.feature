Feature: Certification
This feature tests the functionality of adding certifications in the SkillShare portal.

@tag1
Scenario Outline:01- Add Certification List
    Given I am on the Certifications tab
    When I add a new certification
    Then The certification should be added successfully

Scenario: 02- Update certification List
    Given  I am on the Certifications tab
    When   I update Certification List
    Then   Certification list should be updated successfully.

Scenario: 03- Delete Certification List
   Given  I am on the Certifications tab
   When   I delete the Certification list
   Then   All Certification should deleted successfully
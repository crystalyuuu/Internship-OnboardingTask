Feature: AddSkills

Seller is able to add the Skills details to Profile.
	

@tag1
Scenario: [Add Skills]
	Given [Navigate to Skills page]
	When [I add '<Skill>' and '<SkillLevel>' to Skills page]
	Then [The '<Skill>' and '<SkillLevel>' has been created successfully]

Examples: 
	| Skill             | SkillLevel |
	| C#                | Beginner   |
	| Automatic Testing | Beginner   |

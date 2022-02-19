Feature: AddEducation

Seller is able to add the Education details to Profile.

@tag1
Scenario: [Add Education]
	Given [Navigate to Education page]
	When [I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education page]
	Then [The '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' have been created successfully.]

Examples: 
	| Country      | University | Title | Degree               | Year |
	| New Zealand  | UoA        | B.Sc  | Bachelor of Science  | 2021 |

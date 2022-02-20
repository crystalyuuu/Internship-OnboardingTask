Feature: AddUpdateDeleteLanguages

Seller is able to add, update and delete languages details to Profile

@tag1
Scenario: [first Add languages]
	Given [Navigate to Language page]
	When [I add '<Language>' and '<ChooseLanguageLevel>' to Language page]
	Then [The '<Language>' and '<ChooseLanguageLevel>' have been created successfully.]

Examples: 
	| Language | ChooseLanguageLevel  |
	| Chinese  | Native/Bilingual     |
	| English  | Conversational       |
    
Scenario: [second Update languages]
	Given [Navigate to the update Languages page]
	When [I update '<LanguageUpdate>' and '<UpdateChooseLanguageLevel>' in Languages page]
	Then [The '<LanguageUpdate>' and '<UpdateChooseLanguageLevel>' have been updated successfully.]

Examples: 
	| LanguageUpdate | UpdateChooseLanguageLevel  |
	| Japanese       | Basic                      |

Scenario: [third Delete languages]
	Given [Navigate to the delete Languages page]
	When  [I delete a Language in Languages page]
    Then [The language have been deleted successfully]

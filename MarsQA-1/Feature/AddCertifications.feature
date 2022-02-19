Feature: AddCertifications

Seller is able to add the Certification details to Profile.

@tag1
Scenario: [Add Certifications]
	Given [Navigate to Certifications page]
	When [I add '<Certificate>' and '<CertificateFrom>' and '<Year>' to Certifications page]
	Then [The '<Certificate>' and '<CertificateFrom>' and '<Year>' have been created successfully.]

Examples: 
	| Certificate                       | CertificateFrom   | Year |
	| Test Analyst Expert Certification | Industry Connect  | 2021 |
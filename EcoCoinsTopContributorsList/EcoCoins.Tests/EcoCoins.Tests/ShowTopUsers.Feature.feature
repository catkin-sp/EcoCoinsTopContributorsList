Feature: Show Top Users
	Show top 10 ecocoins holders

Scenario: No ecocoins holders
	Given we have on people holding ecocoins
	When user opens 'Top 10' page
	Then get 'not userd found'

Scenario: Less than 10 ecocoins holders
	Given we have less than 10 people holding ecocoins
	When user opens 'Top 10' page
	Then show all people who holding ecocoins
		And sort by decending order

Scenario Outline: 10 ecocoins holders
	Given we have 10 people holding ecocoins
	When user opens 'Top 10' page
	Then show 10 <users> who holding ecocoins
		And sort by decending order
		Examples: 
		| users |
		| Andrei |
		| Alex   |
		| Sergei |
		| Ivan   |
		| Anna   |
		| Julia  |
		| Steve  |
		| Dawn   |
		| Sergei |
		| Dave   |

Scenario: Over 10 ecocoins holders
	Given we have more than 10 people holding ecocoins
	When user opens 'Top 10' page
	Then get the first 10 people who have more ecocoins
		And show 10 people who holding ecocoins
		And sort by decending order

Scenario: Several people have some amount of ecocoins
	Given we have more than 10 people holding ecocoins
		And two or more people have same amount of ecocoins
		And people registered their eococins at different times
	When user opens 'Top 10' page
	Then get the people who have ecocoins
		And sort by decending order
		And if coint amount is equal for sereval people, sort these people by registration date
		And show 10 first people
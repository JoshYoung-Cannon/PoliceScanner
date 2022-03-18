# PoliceScanner
 
A simple tool that interacts with the UK police databse api.

# Requirements

Provide an application which allows a user to enter a valid latitude, longitude and month then use
this to display a summary of the crimes which occurred, grouped by the crime category.

## Acceptance Criteria:
  For any UK latitude/longitude and a month in the last year, a summary of crimes is returned.
  The count of crimes are shown, grouped by category.
  
## Technical Requirements:
  The solution should make use of .NET, but the type of application is not limited.
  You may use whatever libraries / packages you wish.
  Your solution must include tests.
  
### API Details
The UK crime data is available via a public API at https://data.police.uk. An example of an API call
which returns a list of crimes is as follows:

https://data.police.uk/api/crimes-street/all-crime?lat=51.44237&lng=-2.49810&date=2021-01

This returns all the crimes within a mile of 51.44237, -2.49810 for January 2021.
Note that the data is usually updated at the end of the month, and includes crimes which were
reported to the police in the preceding month. For example, a crime which was reported during
January will published on the last working day of February. This means that you will typically only be
able to report on crimes for a couple of months previous.

The date of the most recent data can be determined from the following API method:
https://data.police.uk/api/crime-last-updated

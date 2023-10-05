# DJValeting

Useful Config Info:
The database connection strings are set up to look for a local SQL Server instance.
Default connection - used for migration scripts
User connection - used by the command/query services to access appointment data
  The login "djvaleting" is configured as a public user in my local SQL Server, granted data-reader and data-writer to the DJValeting database

The layout has been kept from the built in Blazor Server App template, with the "Individual Accounts" authentication type option selected.
This gives a basic authentication feature:
  * Click Register in the top right
  * Enter email and password
  * Click the fake "validate this email" link
  * Click login and enter the email/password combination
The Request Appointment page is available without logging in.
Admin Area is only available when logged in.

Notes/Disclaimer:
I've not touched Blazor before, so this is my attempt after a couple of evenings looking at tutorials. I've based the project structure on a (rushed) version of clean architecture, and with more time would look at something like mediatr to move references to the data services away from the front end pages.

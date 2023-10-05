# DJValeting

Useful Config Info:
The database connection strings are set up to look for a local SQL Server instance.
Default connection - used for migration scripts
User connection - used by the command/query services to access appointment data
  The login "djvaleting" is configured as a public user in my local SQL Server, granted data-reader and data-writer to the DJValeting database

Notes/Disclaimer:
I've not touched Blazor before, so this is my attempt after a couple of evenings looking at tutorials. I've based the project structure on a (rushed) version of clean architecture, and with more time would look at something like mediatr to move references to the data services away from the front end pages.

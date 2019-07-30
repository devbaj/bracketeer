# bracketeer

## Development
<b>Requirements:</b><br>
Angular 8.1 or later, .NET Core SDK 2.2 or later<br>
This project is set up for PostGreSQL, but you can easily change it to your SQL server of choice.
Simply add the necessary .NET package and change the methods in Startup.cs accordingly.

<b>Before Coding:</b><br>
1. In the project directory, run `dotnet restore` to build the necessary files.
2. Still in the project directory, run `dotnet ef migrations add [MIGRATION_NAME]`, followed by `dotnet ef database update`.
Assuming you have set up your database connection properly, this should build the schema for you.
3. In the ClientApp directory, run `npm install` to install required Angular dependencies.

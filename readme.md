**Intro** (*~5 minutes*)

- Just a normal conversation, introducing myself, the team, the project
- No expectations except candidate is able to talk

**Tell me about your experiences** (*~10 minutes*)

- What have you built?
- Who was on your team, who brought you the tasks, how did you plan the work?
- How did you ensure what you built works?

**Technical assessment** (*~15-30 minutes*)

- How do you work with git?
	- branches / permissions
	- pull requests and reviews
	- merging, squashing, reverting
	- you have a merge conflict, what do you do?

- You need to add logging to your dotnet app, what do you do?
	- dependency injection
	- standard libraries
	- log destinations (console, app insights, splunk, etc)
	
- Code review: AzureApiService.cs
	- imagine this code is in a pull request, review it
	- what would you change and why?

- You need to add tests to your dotnet app, what do you do?
	- testing framework
	- unit / integration / end2end tests
	- mocking / substituting

- You need to add secrets to your dotnet app, what do you do?
	- where do you store the secrets?
		- key vault
		- env vars
	- how do you make your app use them?
		- how do you handle different environments? (dev / prod)
		- standard configuration library
		- json files

- You need to monitor your application, what do you do?
	- health checks, application insights, logs
	- what do you do if there is an unknown error in production? any debugging experience?

- You need to build a CI/CD pipeline, what do you do?
	- what steps do you consider important in a pipeline? (building, running tests, running static analyzers and security tools)
	- how do you handle secrets?

**Reverse interview** (*~remaining time*)

- Now we answer all questions the candidate might have

2025-05-06 
1120  // ISO 8601 date system
Created a new .NET 8.0.45 MVC project using Visual Studio
Localhost URL https://localhost:7223/

1145  
Verified project runs successfully in development.

1045
Added a new HelloWorldController using Visual Studio's scaffolding feature.
Implemented two basic action methods:
Index(): returns a plain string as default action.
Welcome(): returns a welcome message.

1114
Verified routing using default MVC route pattern

1140
Tested with  parameter based URL and it's working fine.

1216
Create a new Razor view and before that i updated HelloWorldController's Index method.
Then Created a new folder in Views and Name it HelloWorld.
After that created new razor view inside the HelloWorld foolder and name it Index by default

1230
Build the solution and tested the new index page and it's working fine.

1250
Change Views, Layout Pages and Update branding and links in footer and Rename the MVCMovie to Movie app.
tested in localhost and working fine.

1320
Update the Welcome() method woth two dynamic parameters and bind tha values in new View Welcome and assign that parametrs here.

1335
Tested with dynamic parameters and got the result with list .
log added and data also exported so what next ?    model binding

2025-05-20 
0920
Added a data model called Movie. Added Datatype and Displlay to enhance formatting. Used the Display(Name = "Release Date") attribute to change the label in the view.

0950
Use Use the scaffolding tool to produce CRUD operation.
Prepared for database integration using Entity Framework Core. Create Migartion and Update it.
20250520140032_InitialCreate 

1010
Tested the CRUD operation in localhost and it went well.

2025-05-26
18:05 
Create a new class named SeedData in the Models folder and Add the seed initializer in Program.cs 

1830
Test the changes in localhost. The app shows the seeded data. It went well.

1840
DataAnnotations added in the movie.ca like placeholder and datatype.

1850
Tested the form edit the data and getting validation if i leave blank. went well.

1905
Create a GitHub account, then sign in to GitHub within Visual Studio using your credentials.
After logging in, choose or create a repository. Once your code is ready, use Visual Studio to push your changes to the 
remote repository and pull updates when needed.

1930
added a new search filter to search the data and uodated controller.
Tested woth localhost.....working fine.

2000
Added new column rating in Movie modela and added data in SeedData and also updated Create and Edit view page/
Test and delete all data...Refresh

2005
20250527135320_Rating Rating migration added and update the db.

2010
Again rebuild and tested and it's working fine.


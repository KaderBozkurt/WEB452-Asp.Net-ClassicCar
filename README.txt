10/11/2022
I decided on a creative website about selling classic cars with ASP.NET MVC.
Website name: "ClassicCar.com"
This website should contain classic car sales information.
It should also include a list of classic cars for sale.
There should be pictures of these cars on the homepage, and clicking these pictures will take you to a list with customer reviews.

LET'S START!
Visual Studio 2019 and Asp.Net MVC are used for this website.
Initialize Default ASP.NET MVC Assignment
Create New Project/individual/HTTPS
Create Repository named WEB452-Asp.Net-ClassicCar/send first commit.
My project has been created.
First I override the "sslPort":4444 line in the Properties/launchSettinggs.json file.
I have attached the README.txt application.
I tested the app.
second;
Add Application Controller/ClassicCar.cs

After adding the controller, a callable HTTP endpoint was created in the ClassicCar.cs file.

As the third;
To add a new view, in the ClassicCar.cs file=>
Changed public IActionResult to Index(){return View();}.
Add App View/Car/Index.cshtml(First we create a file named Car in the view, then right click on this file and add index.cshtml with add/new item)
Change title and date in _Layout.cshtml
Added logo to _Layout.cshtml and change font family and size.
when i add image i change font size and font family for title and change width and height for logo.jpg
Change Privacy in footer-ClassicAutoCar.com
*****************************************************************************************************************
I first started the project with the product name "Car". After the steps I mentioned above, after adding Scaffold pages, it gave the following error.
![Test Image 4](https://github.com/KaderBozkurt/WEB452-Asp.Net-ClassicCar/wwwroot/img/error.jpg)

First, I updated the Nuget Package with its old versions (3.1.16)
I tried again later but it still gave the same error. I changed the project name to MvcCar and started all over again, but it still gave the same problem in the same place.
I've been searching on the internet but haven't found a solution yet. I tried to solve this problem all day but it didn't work.....
****************************************************************************************************************************************************
10/13/2022
I decided to start the project again today, I'm going to go back and change the name and try. 
As a result of my research on the internet, if the namespace and the class name are the same, it gives this error. 
This time I will start the name with my campany name, I hope there will be no problems.
My fictitious company's name is ClassicAutoCar, but because it's too long, I just used it as ClassicCar.
After doing the above steps again, I continued as follows...
Add NuGet Packages
This package came with Visual studio installed, but different versions were installed. I changed these versions first.
I skipped the Create Data folder (because it was loaded) and created the CarDbContext.cs class directly into the existing Data folder. I'm trying to make names unique.
I changed the connection server connection in the startup.cs file.
I changed the link to "CarDbContext" in appsettings.json file.
Adding scaffold sheets
Right click on the controller and add/New Scaffold Item
I used "ClassicCar.Data.CarDbContext".
And it worked....
I think the name change helped.
Initial Migration
I used the code below in this part that came as an installed package.
Since there are two contexts, the code is:
Add-Migration InitialCreate -Contex -CarDbContext
this part worked but the Update-Database part was not successful.
I tried it again as "Update-Database -context CarDbContext" but it still didn't work.
I checked all my codes, especially the migration section, but apparently there is no problem that I see.
******************<21:00pm>***********************
I went back to the project and looked again..
still nothing, but when I wrote the error on the internet, I found a few solutions and one of them was to replace the existing context.cs with my own context name. I tried this and changed the already existing context to my own CarDbContext.
RESULT: It worked... By the way, when we change the file name in Visual studio 2019, the names of all the referenced files also change.
"Update-Database -context CarDbContext " succeeded.
I ran the program and it worked... :)

I did my SQL server checks, it worked and I see the table as working on my own computer.
Finally, I changed the site title and added a logo in the View/Share/_Layout.cshtml file.
I changed the background color and font style in wwwroot/#site.css. By the way, I need to check the exam instructions..
And one more thing I should add is rating..
I used asterisk in html and css files.
I added the pictures in the Model/Home/Index.cshtml file and finally changed the links. I changed the Privary part to About Us.
I tested it and it seems to work...
*********************************************************************************************************************************************
10/14/2022

During the lesson, I could not open the project in any way and it did not work. I can't open (my non-working projects) because I have uploaded 3 reposities to GitHub..
I was able to open it at the end of the lesson, but I saw my list in SeedData on my own computer, but it does not appear on the school computer...
I came back home and looked again my list is visible but why not at school???

******************<17:00>*****************
The first time I opened it again on GitHub at school, it did not appear again, but when I did "Build" on the computer I opened and ran it again, it appeared. I hope this is taken into account when grading...
Just have to wait a bit....

******************<19:00pm>**********************************
I started make referance for image and add....
I created new logo and add.....

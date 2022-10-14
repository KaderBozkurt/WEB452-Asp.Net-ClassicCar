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

10/12/2022
Add Model Class
Right click the Models Folder >Add>Class. File name Car.cs
required by the database in this file
ad_Number, Model, Color, Transmission,AdDate(product release date),Fuel,Price are defined.
 Add NuGet PackagesAdd NuGet Packages
This package came with Visual studio installed, but different versions were installed. First I changed these versions.
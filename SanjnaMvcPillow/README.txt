NAME: SANJNA RANI
STUDENT ID:0769043
TOPIC:  PILLOWS

1.	Hello my topic is pillows
2.	Now first I create a new folder name SanjnaMvcPillow in the visiual studio code 2019 according to the given toutorial.
3.	I follow all the istruction like how to select folder and open in the visual studio code 2019.
4.	The project is loaded into the VS2019 ,I run it with the help of ISS exploer.
5.	WOW it works……
6.	I created first welcome on the web.
7.	Now part-2 add a controller to ASP.NET Core MVC app.
8.	For this I added a conrroller file into controller folder. And opt <VC controler as empty to add new scaffolded item.
9.	Controller file added autometically 
10.	Replaced the code as metioned in tutorial   
11.	I surpurised that code work fine and it work without errors…………….. happy 
12.	Now turn into add the View part
13.	Part 2 is really confussing and leanthy it look hours to complete
14.	And its work excely same as mentioned in tutorial 
15.	Lets move to net step which is Add A View
16.	I took a break to start new step……………………………………………………………………
17.	 Pert 3 start, fort step is to add a view under view folder. I loot Rozor view as empty and named as index.xshtml
18.	This whole step tought me about how to add new page and placed in navgation bar to nevigate the site. The tutorial is amazing and esay to understandable. I am happy for zeo error. Lest move to new step.
19.	Now I am started working on my actual project. The practice has done and to began I am adding Pillow class into models folder.
20.	I build controller and view pages easily now MODEL look like intersting part in MVC core.
21.	First add a new class of pillow.cs in the models folder, So according to my project I choose ProductName, Material, Size, Color and Price classes so futher get the data into tables .
22.	Then I add the NutGet package through NutGet package Manger thr Package Manger Console and run the command of Entity framwork  which is this :
23.	Install-Package Microsoft.EntityFrameworkCore.Design
24.	Now I Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model .
25.	While adding the MVC user entity framwork I chose my class which is decleared in class to add db entities.
26.	Mvc controller woth views are added. 
27.	Lets check the connection by adding initial migration package.
28.	while addig Packaging I am facing error - More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands. 
29.	After spending hours and done some research I find the solution to change in the package from Add-Migration InitialCreate to Add-Migration MyMigration -context MvcPillowContext its work. Yepp. 
30.	I am facing new type of error in my SQL Entities and the error is : No type was specified for the decimal property 'Price' on entity type 'Pillow'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType()', specify precision and scale using 'HasPrecision()' or configure a value converter using 'HasConversion()'.
31.	To undo this action, use Remove-Migration. 
32.	According to Tutorial this issue will fixed further, right now ignore it.
33.	Accoring to tutorial there is a need to change in the code of json file for geerating the database conncetion to transfer the valaues. 
34.	I opend appsetting file and add connection strings also pillows context path in this file.
35.	It look time to examine the code and little code to debug the errors.
36.	Again i added  "Microsoft.EntityFrameworkCore.Database.Command": "Information" code in appsetting development jason file and run the program lets see is working or not???
37.	Yep its work fine.
38.	Part 5 working with database.
39.	After cerefully examine the code I rached at db. 
40.	Lets check the data base design 
41.	To see the design I clicked on view and open SQL server object explore
42.	Then clcik on local db and see table folder to open my project db design 
43.	Every this is same as mentioned in tutorial… wowww
44.	And adding menualy information into databse, to do this I made a SeedData file and typed all the ten records in the form of Sql Command and save it.
45.	Lets sun the program again ………………..hope it work 
46.	Wow its really work… I am so happy 
47.	Project work fine now I am adding one field Rating into my project 
48.	rating added by using Add-Migration Rating -context SanjnaMvcPillowContext
49.	its work… wow it is sample process now 
50.	I enjoy doing this, for that I am adding some validation to text boxes 
51.	Each and every validation command mentioned on tutorial so its esay 
52.	It took time to placed the validation 
53.	Lets run the check ……..
54.	Wowww work fine 
55.	I am doing css work to customize the defult theme. 
56.	Lets found of what css and class’s position and file.
57.	Can not find ay thing its already a hour.
58.	Find something 
59.	Ok I am doing inline css to change the style of text.
60.	Added new fonts by adding google font link 
61.	I am taking help from bootstap and using their classes to change the layout of the projetct,
62.	lastly I added pages like projects, contact us, privacy policy to this project.
63.	Home page has all informtion regarding pillow company to look more dynamic I added three layer of slider and content. 
64.	I redesign rest of pages 
65.	Contact form added  manualy into contact us page to looks realistic 
66.	Added products imanges and decsription 
67.	Everything if fine frome my side and looks beautiful.
68.	Thank you…. 

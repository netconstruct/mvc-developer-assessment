# NetConstruct Developer Assessment

## Overview
We would like you to create a blog post page using the provided solution, example HTML and wireframes. The data to be displayed should be obtained from the included JSON file. Where asked to save data, this should be saved back to the JSON file.

The purpose of this assessment is to demonstrate:
1. ASP.NET MVC skills
2. Controllers and methods/routing
3. Basic CSS skills and recreating a visual
4. Ability to use a CSS framework (e.g. bootstrap)
5. Retrieving and persisting data
6. Form input and Validation
7. JavaScript knowledge

If you have time you then demonstrating any of the following would be considered as a bonus:
1. Responsive layout
2. Deliver via a GIT Repo (but zip file acceptable)
3. Add both client and server side validation
4. Use of JavaScript frameworks (e.g. react)

The provided solution contains a ```template.html``` file and a ```Blog-Posts.json```, found within in the ```App_Data``` and ```Assets/Html``` folders. 
The ```template.html``` includes some skeleton HTML code which will be used throughout the exercises.
The ```Blog-Posts.json``` file contains mock blog post data in JSON format, this will again be used throughout the exercises when required to read/write data. 

## Prerequisites
In order to run the provided solution the following software will need to be installed:

* Microsoft Visual Studio 2019 [here.](https://visualstudio.microsoft.com/vs/)
* .NET Framework 4.8 SDK [here.](https://dotnet.microsoft.com/download/visual-studio-sdks)

Once the prerequisites are installed the ```'/src/NetC.JuniorDeveloperExam.sln'``` file should be opened using Visual Studio and run via IIS Express.

## Exercise 1
Create an MVC view containing the blog post content, use the HTML found within the ```template.html``` file as the page layout.

Using the provided JSON file, replace the section marked ```<!—Blog post content-->``` with content found in the ```Blog-Posts.json``` file.

Load in specific blog post from the JSON file, based on blog post ID (via MVC routing and appropriate controller actions) 
Example: /blog/1/, /blog/2/, /blog/\<ID\>/ etc....

## Exercise 2
Display a list of blog post comments that are related to the blog post, obtained from the JSON file. Add this to the section marked ```<!—Blog post comments-->```

## Exercise 3
Add a comment form to the section marked ```<!—Blog post comment form-->``` that a user can use to submit a comment that is stored against the blog post item (within the Blogpost JSON). 

Form fields:
- Name (required field)
- Email address (required field)
- Comment (required field)

## Exercise 4 (Optional)
Add the ability to reply to a comment, save the reply in the appropriate location of the JSON file, and display underneath the comment the user has replied to.

Good luck!

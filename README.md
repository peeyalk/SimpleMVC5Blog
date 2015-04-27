# SimpleMVC5Blog

NOTE: this web app is still in development process, this is just a barebone.

This is a simple blog/portfolio website using asp.net mvc 5 and Entity Framework as backend.
All repo and entities classes will be in data folder, except for the view models.

Bootstrap template used in this project is called "Clean Blog" from startbootstrap.com

Link to the template: http://startbootstrap.com/template-overviews/clean-blog/

WHERE AND HOW:
* entity and repository classes will be in "~/Data" directory.
* To be able to test create/edit/delete blog, you need to log in, go to this url "yourlocalhost/Account/login".  Email of the admin role is "MainTest@yahoo.com", password is "Password2".
* To change admin's email and password, go to "~/Migrations/Configuration.cs", these options will be in the `Seed` method.
* To change home page content, go to "~/Views/Home/Index.cshtml".
* To change page master page content (navbar, footer, etc..), go to "~/Views/Shared/_Layout.cshtml".
* If you know you want certain javascript files to be applied to all pages, add them to the master page. or else put them in ```@section scripts { //javascripts file here }``` in the page you want.

UPDATED (4/26/15):
* Implemented email service for contact forms
* Added comments/docs to where you should change the contents.

UPDATED (4/25/15):
* Implemented Tiny MCE text editor to Create action in ```BlogsController.cs```
* Dependency injection on ```BLogsController.cs``` and db context class.
* Added some CRUD methods in ```BlogRepository.cs```.

UPDATED (4/24/15):

* Fixed summiting form issues by disabled the validation that came with the template.
* Added view model for contact form.
* Each view now has its own image for the into header.
* Disabled register routes.
* User and admin role will be created in the seed method of ```configuration.cs``` class in Migrations folder.

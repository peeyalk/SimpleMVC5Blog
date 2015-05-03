# SimpleMVC5Blog

[Live Preview] (http://simplemvcblog.long-nguyen.com/). I changed the admin's password and username for my own privacy, you can test CRUD operations on your local machine.

NOTE: this web app is just a simple one. CRUD operations implemented for blog contents (Make sure to log in at url "/Account/Login" first). Also I don't have a comment system because I think Disqus is better at this, so use Disqus instead.

This is a simple blog/portfolio website using asp.net mvc 5 and Entity Framework as backend.
All repo and entities classes will be in data folder, except for the view models.

Bootstrap template used in this project is called "Clean Blog" from startbootstrap.com
Link to the template: http://startbootstrap.com/template-overviews/clean-blog/

IMPORTANT: To be able to test create/edit/delete blog, you need to be logged in, go to this url "/Account/login".  Email of the admin role is "MainTest@yahoo.com", password is "Password2".

WHERE AND HOW:
* Please use your own Disqus scripts in "~/Scripts/Disqus/Disqus.js" for commenting system. (Disqus.js is included in `Details` view).
* entity and repository classes will be in "~/Data" directory.
* To change admin's email and password, go to "~/Migrations/Configuration.cs", these options will be in the `Seed` method.
* To change home page content, go to "~/Views/Home/Index.cshtml".
* To change page master page content (navbar, footer, etc..), go to "~/Views/Shared/_Layout.cshtml".
* If you know you want certain javascript files to be applied to all pages, add them to the master page. or else put them in ```@section scripts { //javascripts file here }``` in the page you want.

UPDATED (5/3/15):
* Edit some issues with bootstrap
* Make some changes to email service for contact form.

UPDATED (4/29/15):
* Blogs will be displayed by descending order (based on date created).
* Pagination implemented.
* Fixed email service for contact form.

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

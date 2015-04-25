# SimpleMVC5Blog

NOTE: this web app is still in development process, this is just a barebone.

This is a simple blog/portfolio website using asp.net mvc 5 and Entity Framework as backend.
All repo and entities classes will be in data folder, except for the view models.

Bootstrap template used in this project is called "Clean Blog" from startbootstrap.com

Link to the template: http://startbootstrap.com/template-overviews/clean-blog/

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

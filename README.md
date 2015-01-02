_**IMPORTANT NOTE:**_ This project is currently in beta and the documentation is currently incomplete. Please bear with us while the documentation is being written.

####SuperScript offers a means of declaring assets in one part of a .NET web solution and have them emitted somewhere else.


When developing web solutions, assets such as JavaScript declarations or HTML templates are frequently written in a location that differs from their desired output location.

For example, all JavaScript declarations should ideally be emitted together just before the HTML document is closed. And if caching is preferred then these declarations should be in an external file with caching headers set.

This is the functionality offered by SuperScript.



##Declare assets within MVC Razor Views

Although SuperScript allows declarations (instances of `SuperScript.Declarables.DeclarationBase`) to be declared in code at any location in the project, it might be preferable to place this declaration (eg, JavaScript, HTML template, _etc._) on a view. Aside from maintaining related code or script in the same file, this also helps with intellisense.

_**IMPORTANT NOTE:**_ This project does not wholly offer the functionality for working with, for example, JavaScript or HTML templates on Razor views. Rather, it offers the base functionality required by the related project `SuperScript.JavaScript.Mvc`.

##What's in this project?

* `SuperScript.Container.Mvc.BaseContainer`

  This is an abstract class which offers the base functionality required for a container block on an MVC Razor view.


##Dependencies
There are a variety of SuperScript projects, some being dependent upon others.

* [`SuperScript.Common`](https://github.com/Supertext/SuperScript.Common)

  This library contains the core classes which facilitate all other SuperScript modules but which won't produce any meaningful output on its own.


  
`SuperScript.Container.Mvc` has been made available under the [MIT License](https://github.com/Supertext/SuperScript.Container.Mvc/blob/master/LICENSE).

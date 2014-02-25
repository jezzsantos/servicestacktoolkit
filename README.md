ServiceStack Toolkit
===================

(The is a community run project, all contributions are very welcome)

A developer toolkit (for Visual Studio 2013) for building ServiceStack web services.

The toolkit is focused on applying good REST design rules, from the point of view of 'resources' with basic verbs: GET, POST, PUT, DELETE. 

The toolkit applies many of the recommended practices and patterns evolving in the ServiceStack community, by those experts in the community, for both REST service design and implementation of REST services using the excellent ServiceStack framework. There is no easier way to get started with creating, and maintaining your web service with ServiceStack.

Based upon simple configuration by the developer, the toolkit automates the creation of much of the plumbing and coding of the web service required to construct a fully functioning web service of your choice (from front to back). Including creating basic unit and integration tests. All that remains is for you (the developer) to code the logic and behaviour of the web service, let the toolkit take care of the rest.

# Contributions
If you like the toolkit and think we could/should improve it, then please go ahead and fork it and share your knowledge.

# Developing the Toolkit
To develop, improve, or contribute to the toolkit, you first need to install the 'NuPattern' tools to Visual Studio 2013. To install the 'NuPattern' tools, you first need to install the ['Visual Studio 2013 SDK'](http://www.microsoft.com/en-nz/download/details.aspx?id=40758). Do that before installing 'NuPattern'. Then download and install ['NuPattern'](http://nupattern.org) or install from within the 'Extensions and Updates' in Visual Studio 2013.
Then, just clone or fork the code from this site. Build the solution, and hit F5 or CTRL+F5 to run the toolkit in the 'Experimental Instance' of Visual Studio. 

# Using the Toolkit
At some point shortly after we start this project, we will have a binary release (a VSIX file) that you can download and install in Visual Studio, posted in the 'Releases' tab of this site.

Until then, you can simply compile and create the release yourself from the  source.
After you build the solution the VSIX file is automatically generated in the 'Binaries' folder next to the solution file in the source tree.

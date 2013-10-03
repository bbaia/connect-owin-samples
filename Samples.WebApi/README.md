# [ASP.NET WebApi](http://www.asp.net/web-api) Sample

Build the sources:

	$ msbuild Samples.WebApi.csproj
	$ npm install

## Using [Grunt](http://gruntjs.com/)

You'll need to install Grunt's command line interface (CLI) globally, if not installed yet:

	$ npm install -g grunt-cli

`grunt` starts a `connect` web server with `livereload` enabled and with the WebApi plugged in as a middleware:

	$ grunt server

This is useful while developing. 

## Using [express.js](http://expressjs.com/) 

	$ node server.js

Then open http://localhost:3000/index.html


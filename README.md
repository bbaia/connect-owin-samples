# [connect-owin](https://github.com/bbaia/connect-owin/) Samples Repository

Host your OWIN components on node.js using [connect-owin](https://github.com/bbaia/connect-owin/)

## [ASP.NET WebApi](http://www.asp.net/web-api) Sample

	$ cd Samples.WebApi

See [ReadMe](https://github.com/bbaia/connect-owin-samples/tree/master/Samples.WebApi)

## [Nancy](http://nancyfx.org/) Sample

	$ cd Samples.Nancy

Build the sources:

	$ msbuild Samples.Nancy.csproj   (.NET Framework)
	$ xbuild Samples.Nancy.csproj   (mono)

Retrieve node.js packages:

	$ npm install

Start [express.js](http://expressjs.com/) server:

	$ node server.js

Open http://localhost:3000/

## [ASP.NET SignalR](http://www.asp.net/signalr) Sample

`webSocket` transport not supported (requires [connect-owin](https://github.com/bbaia/connect-owin/) to support [OWIN WebSocket extension](http://owin.org/extensions/owin-WebSocket-Extension-v0.4.0.htm)).

	$ cd Samples.SignalR

Build the sources:

	$ msbuild Samples.SignalR.csproj   (.NET Framework)
	$ xbuild Samples.SignalR.csproj   (mono)

Retrieve node.js packages:

	$ npm install

Start [express.js](http://expressjs.com/) server:

	$ node server.js

Open http://localhost:3000/index.html

## [Simple.Web](https://github.com/markrendle/Simple.Web) with [Fix](https://github.com/FixProject/Fix) Sample

	$ cd Samples.Fix_SimpleWeb

Build the sources:

	$ msbuild Samples.Fix_SimpleWeb.csproj   (.NET Framework)
	$ xbuild Samples.Fix_SimpleWeb.csproj   (mono)

Retrieve node.js packages:

	$ npm install

Start [express.js](http://expressjs.com/) server:

	$ node server.js

Open http://localhost:3000/


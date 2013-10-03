# [connect-owin](https://github.com/bbaia/connect-owin/) Samples Repository

Host your OWIN components on node.js using [connect-owin](https://github.com/bbaia/connect-owin/)

## [ASP.NET WebApi](http://www.asp.net/web-api) Sample

	$ cd Samples.WebApi

See [ReadMe](https://github.com/bbaia/connect-owin-samples/tree/master/Samples.WebApi)

## [Nancy](http://nancyfx.org/) Sample

	$ cd Samples.Nancy
	$ msbuild Samples.Nancy.csproj
	$ npm install
	$ node server.js

Open http://localhost:3000/

## [ASP.NET SignalR](http://www.asp.net/signalr) Sample

`webSocket` transport not supported (requires [connect-owin](https://github.com/bbaia/connect-owin/) to support [OWIN WebSocket extension](http://owin.org/extensions/owin-WebSocket-Extension-v0.4.0.htm)).

	$ cd Samples.SignalR
	$ msbuild Samples.SignalR.csproj
	$ npm install
	$ node server.js

Open http://localhost:3000/index.html


# [connect-owin](https://github.com/bbaia/connect-owin/) Samples Repository

Host your OWIN components on node.js using [connect-owin](https://github.com/bbaia/connect-owin/)

## [ASP.NET WebApi](http://www.asp.net/web-api) Sample

	$ cd Samples.WebApi
	$ msbuild Samples.WebApi.csproj
	$ npm install
	$ node server.js

Open http://localhost:3000/Api/Hello/World

## [Nancy](http://nancyfx.org/) Sample

	$ cd Samples.Nancy
	$ msbuild Samples.Nancy.csproj
	$ npm install
	$ node server.js

Open http://localhost:3000/

## [ASP.NET SignalR](http://www.asp.net/signalr) Sample

Only supports `longPolling` tranport

	$ cd Samples.SignalR
	$ msbuild Samples.SignalR.csproj
	$ npm install
	$ node server.js

Open http://localhost:3000/index.html


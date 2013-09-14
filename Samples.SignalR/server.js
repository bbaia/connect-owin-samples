var owin = require('connect-owin'),
    express = require('express');

var app = express();
app.all('/signalr/*', owin(__dirname + '\\bin\\Debug\\Samples.SignalR.dll'));
app.use(express.static(__dirname));
app.listen(3000);

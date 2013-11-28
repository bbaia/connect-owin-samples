var owin = require('connect-owin'),
    connect = require('connect'),
    express = require('express');

var app = express();
app.use(connect.logger('dev'));
app.all('/signalr/*', owin(__dirname + '\\bin\\Debug\\Samples.SignalR.dll'));
app.use(express.static(__dirname));
app.listen(3000);

var owin = require('connect-owin'),
    connect = require('connect'),
    express = require('express');

var app = express();
app.use(connect.logger('dev'));
//app.use(express.compress());
app.all('/api/*', owin(__dirname + '/bin/Debug/Samples.WebApi.dll'));
app.use(express.static('Site'));
app.listen(3000);

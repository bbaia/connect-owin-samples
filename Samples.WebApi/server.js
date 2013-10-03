var owin = require('connect-owin'),
    express = require('express');

var app = express();
//app.use(express.compress()); // combine .NET & node middlewares
app.all('/api/*', owin(__dirname + '\\bin\\Debug\\Samples.WebApi.dll'));
app.use(express.static('Site'));
app.listen(3000);

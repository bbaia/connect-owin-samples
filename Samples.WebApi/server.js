var owin = require('connect-owin'),
    express = require('express');

var app = express();
app.all('/Api/*', owin(__dirname + '\\bin\\Debug\\Samples.WebApi.dll'));
app.all('/node', function (req, res) {
    res.send(200, 'Hello from JavaScript! Time on server ' + new Date());
});
app.listen(3000);

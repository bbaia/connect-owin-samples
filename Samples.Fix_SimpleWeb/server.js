var owin = require('connect-owin'),
    connect = require('connect'),
    express = require('express');

var app = express();
app.use(connect.logger('dev'));
app.all('/node', function (req, res) {
    res.send(200, 'Hello from JavaScript! Time on server ' + new Date());
});

app.all('/', owin({
    assemblyFile: __dirname + '\\bin\\Debug\\Samples.Fix_SimpleWeb.dll',
    typeName: 'Samples.Fix_SimpleWeb.FixConfig',
    methodName: 'Invoke'
}));

app.listen(3000);
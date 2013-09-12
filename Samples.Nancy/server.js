var owin = require('connect-owin'),
    express = require('express');

var app = express();
app.all('/node', function (req, res) {
    res.send(200, 'Hello from JavaScript! Time on server ' + new Date());
});
app.all('/', owin({
    assemblyFile: __dirname + '\\bin\\debug\\Samples.Nancy.dll',
    rootpath: __dirname
}));
app.listen(3000);

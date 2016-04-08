var express = require("express");
var webServer = express();
//var favicon = require('serve-favicon');
var fs = require("fs");
var url = require("url");
//var edge = require("edge"); //for .Net
var routes = require('./routes/indexRoutes');
var investments = require('./routes/investmentsRoutes');

webServer.use('/', routes);
webServer.use('/investments', investments);



webServer.get('/', function (request, response) {
    response.send("Hello World from Express");
});

var server = webServer.listen(8081, function () {
    var host = server.address().address;
    var port = server.address().port;

    console.log("Example app listening at http://%s:%s", host, port)
});


//to start server
//cd ExpressApi
//node HouseholdApi.js
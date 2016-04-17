var express = require('express');
var investmentRouter = express.Router();
var investments = require('../investments');

investmentRouter.get('/', function(request, response){
    response.send("score!");
});

investmentRouter.post('/insertData', function(request, response){
    response.send("inserted");
    investments.insert(response);
});




module.exports = investmentRouter;

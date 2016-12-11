var express = require('express');
var investmentRouter = express.Router();
var transactions = require('../Investments/transactions.js');

investmentRouter.get('/', function(request, response){
      response.send("score!");
  });


investmentRouter.post('/transaction', function(request, response){
    response.send("inserting now");
    transactions.insert(request);
    //response.send("investments router");
  });

module.exports = investmentRouter;

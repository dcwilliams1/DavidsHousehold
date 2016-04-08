var express = require('express');
var router = express.Router();
require('investments');


router.post('/insertData', function(request, response){
    //response.send("inserted");
    investments.insert(response);
});




module.exports = router;

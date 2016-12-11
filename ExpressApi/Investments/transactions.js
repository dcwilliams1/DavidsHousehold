var transactions = function(request){
    require("edge");
    this.insert = function(){response.send("dataInserted")};
};

module.exports = transactions;

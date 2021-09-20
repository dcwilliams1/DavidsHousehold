var transactions = function(request){
    require("edge");
    console.log('transactions', this);
    this.insert = function(){response.send("dataInserted")};
};

module.exports = transactions;

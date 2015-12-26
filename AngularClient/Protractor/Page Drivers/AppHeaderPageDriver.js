var AppHeader = function(){
    browser.get('');
};

AppHeader.prototype = Object.create({},{
    moneyLink: {
      get: function() {
          return element(by.id('lnkMoney'));
      }
    },
    categoriesLink: {
        get: function (){
            return element(by.linkText('Categories'));
        }
    }

});

module.exports = AppHeader;
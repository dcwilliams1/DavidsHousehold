var AppHeader = function(){
    browser.get('');
};

AppHeader.prototype = Object.create({},{
    categoriesLink: {
        get: function (){
            return element(by.linkText('Categories'));
        }
    }

});
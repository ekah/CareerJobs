Ext.define('TreeJsonStore', {  
    extend: 'Ext.data.TreeStore',
    autoLoad: true,
    autoDestroy: true,
    constructor: function (config) {
        var config = Ext.apply({}, config);
        this.callParent([config]);
    }
});

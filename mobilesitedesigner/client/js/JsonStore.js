Ext.define('JsonStore', {
    extend: 'Ext.data.Store',
    alias: ['store.app'],
    autoDestroy: true,
    remoteSort: true,
    remoteFilter: true,   
    constructor: function (config) {       
        var config = Ext.apply({}, config);
        this.callParent([config]);
    }
});

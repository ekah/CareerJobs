Ext.define('Contentstoremodel', {
    extend: 'Ext.data.Model',
    idProperty: 'ID',
    fields: [{
        name: 'ID',
        type: 'int'
    }, {
        name: 'SubDomain',
        type: 'string'
    }, {
        name: 'Title',
        type: 'string'
    }, {
        name: 'PageID',
        type: 'int'
    }, {
        name: 'Location',
        type: 'string'
    }, {
        name: 'ImageUrl',
        type: 'string'
    }, {
        name: 'Text',
        type: 'string'
    }]
});
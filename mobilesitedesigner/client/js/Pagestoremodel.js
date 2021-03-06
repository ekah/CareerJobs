﻿Ext.define('Pagestoremodel', {
    extend: 'Ext.data.Model',
    idProperty: 'ID',
    fields: [{
        name: 'ID',
        type: 'int'
    }, {
        name: 'ClientID',
        type: 'int'
    }, {
        name: 'MainSite',
        type: 'string'
    }, {
        name: 'Text',
        type: 'string'
    }, {
        name: 'SubDomain',
        type: 'string'
    }, {
        name: 'Location',
        type: 'string'
    }, {
        name: 'HeaderImage',
        type: 'string'
    }, {
        name: 'FooterImage',
        type: 'string'
    }, {
        name: 'PageImage',
        type: 'string'
    }, {
        name: 'HeaderText',
        type: 'string'
    }, {
        name: 'FooterText',
        type: 'string'
    }, {
        name: 'Def',
        type: 'bool'
    }, {
        name: 'Locked',
        type: 'bool'
    }]
});
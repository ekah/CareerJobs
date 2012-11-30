Ext.define('Gridbase', {
    extend: 'Ext.grid.Panel',
    alias: ['widget.Gridbase'],  

    constructor: function (config) {
        var config = Ext.applyIf({
            bbar: {
                xtype: 'pagingtoolbar',
                pageSize: config.store.pageSize,               
                store: config.store
            }
        }, config);
        if (!config.disableProgressBarPager) {
            config.bbar.plugins = Ext.create('Ext.ux.ProgressBarPager', {});
            config.bbar.displayInfo = true;
        }
        if (config.removeColumns) {
            config.columns = Ext.Array.filter(config.columns, function (item, index, array) {
                return !Ext.Array.contains(config.removeColumns, index);
            }, this);
        }
        if (config.addColumns) {
            Ext.Array.insert(config.columns, config.columns.length, config.addColumns);
        }
        if (!config.removeFilters) {
            Ext.Array.forEach(config.columns, function (item, index, array) {
                if (item.xtype != 'actioncolumn') {
                    item.filterable = item.filterable ? item.filterable : true;
                    item.filter = item.filter ? item.filter : true;
                }
            }, this);
            config.features = [{
                ftype: 'filters',
                encode: true
            }]
        }
        this.callParent([config]);
    }
});
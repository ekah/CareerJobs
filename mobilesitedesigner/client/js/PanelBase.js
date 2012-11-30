Ext.define('PanelBase', {
    extend: 'Ext.panel.Panel',
    alias: 'widget.panelbase',
    closeAction: 'destroy',
    closable: true,
    maximizable: true,
    draggable: true,
    resizable: true,
    parentOf: function (win) {
        if (!this.children)
            this.children = [];
        Ext.Array.insert(this.children, 0, [win]);
    },
    height: '80%',
    width: '80%',
    autoScroll: true,
    constructor: function (config) {
        var arr = Ext.ComponentQuery.query(Ext.String.format('{0}[name="{1}"]', this.getXType(), config.name));
        Ext.Array.forEach(arr, function (item, index, array) {
            if (item.close)
                item.close();
            else
                item.destroy();
        }, this);
        var config = Ext.applyIf({}, config);
        if (config.callConstructor) {
            var fn = Ext.Function.pass(config.callConstructor.fn, config);
            fn.call(config.callConstructor.scope || this);
        }
        this.callParent([config]);
    },
    initComponent: function (config) {
        this.on('beforeclose', function (win) {
            if (win.children) {
                Ext.Array.forEach(win.children, function (item, index, array) {
                    item.close();
                }, this);
            }
        }, this);
        this.callParent([config]);
    }
});
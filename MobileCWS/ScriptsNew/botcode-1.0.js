var gInitFunctions = '';
var $BOT = jQuery.noConflict();
$BOT(document).ready(
        function () {
            Botcode.init();
        }
        );
Botcode = {
    init: function () {
        if (typeof (gInitFunctions) == "undefined" || gInitFunctions == "") { } else {
            if (gInitFunctions.indexOf(";") > 0) {
                var aInitFunctions = gInitFunctions.split(";");
                for (gI = 0; gI < aInitFunctions.length; gI++) {
                    if (!Botcode.Common.isEmptyParam(aInitFunctions[gI])) {
                        eval(aInitFunctions[gI])()
                    }
                }
            } else {
                eval(gInitFunctions)()
            }
        }
        var sElement = $BOT("<div id='div_Process' name='div_Process' title='Process...'></div>");
        $BOT("body").append(sElement);
        $BOT("head").append("<link>");
        var css = $BOT("head").children(":last");
        css.attr({ rel: "stylesheet", type: "text/css", href: "/stylesnew/jquery-ui1.8.css" });
        $BOT.getScript("/scriptsnew/jquery-ui.min1.8.js", function () {
            $BOT('#div_Process').dialog({ modal: true, zIndex: 3999, autoOpen: false, draggable: false, title: "Process...", resizable: false });
        });

    },
    Common: {
        alert: function (msg) {
            alert(msg);
        },
        trim: function (str) {
            if (str == undefined)
                return false;
            return str.replace(/^\s+|\s+$/g, '');
        },
        isEmptyParam: function (param) {
            if (param == undefined || param == '')
                return true;
            else
                return false;
        },
        process: function (status, title, height, width) {
            if (status) {
                $BOT("#div_Process").dialog("close");
                if (Botcode.Common.isEmptyParam(height))
                    height = 110;
                if (Botcode.Common.isEmptyParam(width))
                    width = 200;
                if (Botcode.Common.isEmptyParam(title))
                    title = "Loading please wait...";
                $BOT("#div_Process").html("<br/><center><img src='/imagesnew/ajaxload.gif'/></center>");
                $BOT("#div_Process").dialog("option", "height", height);
                $BOT("#div_Process").dialog("option", "width", width);
                $BOT("#div_Process").dialog("option", "title", title);
                $BOT("#div_Process").dialog("option", "modal", true);
                $BOT("#div_Process").dialog("option", "closeOnEscape", false);
                $BOT("#div_Process").dialog("option", "position", "center");
                $BOT("#div_Process").dialog("option", "closeText", "hide");
                $BOT("#div_Process").dialog("option", "scroll", "none");
                $BOT("#div_Process").dialog("open");
                $BOT('a.ui-dialog-titlebar-close').hide();
                $BOT('.ui-dialog .ui-dialog-title').css('font-size', '0.8em');
                $BOT('.dummy-process div').show();



            }
            else
                $BOT("#div_Process").dialog("close");
        }
    },
    Form: {
        output: 'alert',
        error: 'alert',
        jsonData: null,
        url: "",
        method: 'POST',
        onSuccess: '',
        onFailure: '',
        showprocess: '1',
        post: function (holder, params, url, onSuccess, onFailure) {
            if (Botcode.Common.isEmptyParam(holder)) {
                Botcode.Form.process(params, url, 'POST', onSuccess, onFailure);
            }
            else {
                $BOT('#' + holder).bind('click', function (event) {
                    Botcode.Form.process(params, url, 'POST', onSuccess, onFailure);
                });
            }
        },
        process: function (params, url, method, onSuccess, onFailure) {
            jsonData = null;
            if (!Botcode.Common.isEmptyParam(onSuccess))
                Botcode.Form.onSuccess = onSuccess;
            if (!Botcode.Common.isEmptyParam(method))
                Botcode.Form.method = method;
            if (!Botcode.Common.isEmptyParam(url))
                Botcode.Form.url = url;
            if (!Botcode.Common.isEmptyParam(onFailure))
                Botcode.Form.onFailure = onFailure;
            if (Botcode.Common.isEmptyParam(params)) {
                jsonData = [{ name: "Empty", value: ""}];
            }
            else if (params.indexOf(',') > 0) {
                var aParams = params.split(',');
                for (i = 0; i < aParams.length; i++) {
                    param = '#' + aParams[i];
                    if ($BOT(param).is('form')) {
                        if (jsonData == null)
                            jsonData = $BOT(param).serializeArray();
                        else
                            jsonData.push($BOT(param).serializeArray());
                    }
                    else {
                        if (jsonData == null)
                            jsonData = [{ name: aParams[i].replace('#', ''), value: $BOT(param).val()}];
                        else
                            jsonData.push({ name: aParams[i].replace('#', ''), value: $BOT(param).val() });
                    }
                }
            }
            else {
                if ($BOT('#' + params).is('form')) {
                    jsonData = $BOT('#' + params).serializeArray();
                }
                else {
                    jsonData = [{ name: params, value: $BOT('#' + params).val()}];
                }
            }
            Botcode.Form.jsonData = jsonData;
            Botcode.Form.ajaxCall();
        },
        ajaxCall: function () {
            if (Botcode.Form.showprocess == '1')
                Botcode.Common.process(true, "Processing, please wait...", '', 260);
            $BOT.ajax({
                type: Botcode.Form.method,
                url: Botcode.Form.url,
                //processData: false,
                dataType: "json",
                data: Botcode.Form.jsonData,
                success: Botcode.Form.success,
                failure: Botcode.Form.failure
            });
        },
        success: function (o) {
            Botcode.Common.process(false);
            if (!Botcode.Common.isEmptyParam(Botcode.Form.onSuccess)) {
                eval(Botcode.Form.onSuccess)(o);
            }
            Botcode.Form.reset;
        },
        failure: function (o) {
            Botcode.Common.process(false);
            if (!Botcode.Common.isEmptyParam(Botcode.Form.onFailure)) {
                eval(Botcode.Form.onFailure)(o);
            }
            else {
                Botcode.Common.alert('oops something went wrong');
            }
            Botcode.Form.reset;
        },
        reset: function () {

            Botcode.Form.output = 'alert';
            Botcode.Form.error = 'alert';
            Botcode.Form.jsonData = null;
            Botcode.Form.method = 'POST';
            Botcode.Form.onSuccess = '';
            Botcode.Form.onFailure = '';
            Botcode.Form.showprocess = '1';
        }
    }
}
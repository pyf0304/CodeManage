(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCommonFunc4Web = exports.ChkClick1 = exports.arrSelectedKeys = void 0;
    var clsString_js_1 = require("./clsString.js");
    //--pyf2021-2-2627
    exports.arrSelectedKeys = new Array();
    function ChkClick1(myThis) {
        var strId = myThis.id;
        var strKey = strId.substring(3);
        if (myThis.checked == true) {
            if (exports.arrSelectedKeys.indexOf(strKey) < 0) {
                exports.arrSelectedKeys.push(strKey);
            }
        }
        else {
            var index = exports.arrSelectedKeys.indexOf(strKey);
            if (index > -1) {
                exports.arrSelectedKeys.splice(index, 1);
            }
        }
        var sstrKey = "";
        for (var _i = 0, arrSelectedKeys_1 = exports.arrSelectedKeys; _i < arrSelectedKeys_1.length; _i++) {
            var strK = arrSelectedKeys_1[_i];
            sstrKey += "".concat(strK, ",");
        }
        $('#spanResult').html(sstrKey);
    }
    exports.ChkClick1 = ChkClick1;
    //declare var strWebRoot;
    var clsCommonFunc4Web = /** @class */ (function () {
        function clsCommonFunc4Web() {
        }
        /*
         * 确认删除函数
         */
        //public static confirm_del(intCount: number) {
        //    var strMsg = clsString.Format("你真的确定要删除记录吗?");
        //    if (intCount > 0) {
        //        strMsg = clsString.Format("你真的确定要删除{0}条记录吗?", intCount);
        //    }
        //    var gnl = confirm(strMsg);
        //    if (gnl == true) {
        //        return true;
        //    }
        //    else {
        //        return false;
        //    }
        //} 
        /*
         * 检查层是否存在？
         */
        clsCommonFunc4Web.CheckDivExist = function (divName) {
            var objDiv = $("#".concat(divName));
            if (objDiv.length == 0) {
                var strMsg = clsString_js_1.clsString.Format("层:{0}不存在, 请检查！", divName);
                console.error(strMsg);
                throw (strMsg);
            }
        };
        clsCommonFunc4Web.CheckControlExist = function (divName, strControlType, strControlId) {
            var objDiv = $("#".concat(divName));
            if (objDiv.length == 0) {
                var strMsg = clsString_js_1.clsString.Format("层:{0}不存在, 请检查！", divName);
                console.error(strMsg);
                throw (strMsg);
            }
            var strId = "".concat(strControlType, "[id ^= \"").concat(strControlId, "\"]");
            var objControl = objDiv.find(strId);
            if (objControl.length == 0) {
                var strMsg = clsString_js_1.clsString.Format("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
                console.error(strMsg);
                throw (strMsg);
            }
        };
        clsCommonFunc4Web.SetSelectValue = function (objSelect, strValue) {
            for (var i = 0; i < objSelect.options.length; i++) {
                if (objSelect.options[i].value == strValue) {
                    objSelect.selectedIndex = i;
                    return;
                }
            }
        };
        clsCommonFunc4Web.SetSelectValueById = function (strSelectId, strValue) {
            var objSelect = document.getElementById(strSelectId);
            if (objSelect == null) {
                console.error("\u5728\u8BBE\u7F6E\u4E0B\u62C9\u6846\u503C\u65F6\uFF0C\u63A7\u4EF6\uFF1A".concat(strSelectId, "\u4E0D\u5B58\u5728\uFF01"));
                return;
            }
            for (var i = 0; i < objSelect.options.length; i++) {
                if (objSelect.options[i].value == strValue) {
                    objSelect.selectedIndex = i;
                    return;
                }
            }
        };
        clsCommonFunc4Web.BindEvent_Select = function (strSelectId, strEventName, func) {
            var objSelect = document.getElementById(strSelectId);
            if (strEventName == "onchange") {
                objSelect.onchange = (function () {
                    //alert("inner objSelect.onchange");
                    func.call(this);
                });
            }
        };
        clsCommonFunc4Web.BindEvent_Input = function (strInputId, strEventName, func) {
            var objInput = document.getElementById(strInputId);
            if (strEventName == "onblur") {
                objInput.onblur = (function () {
                    //alert("inner objSelect.onchange");
                    func.call(this);
                });
            }
        };
        //js获取网站根路径(站点及虚拟目录)，获得网站的根目录或虚拟目录的根地址     
        clsCommonFunc4Web.getRootPath = function () {
            var strFullPath = document.location.href;
            var strPath = document.location.pathname;
            var pos = strFullPath.indexOf(strPath);
            var prePath = strFullPath.substring(0, pos);
            var postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
            return (prePath + postPath);
        };
        /*
        * 重新转向本项目新的Url地址
        */
        clsCommonFunc4Web.Redirect = function (LocUrl) {
            var strWebRoot = this.getRootPath();
            console.log(strWebRoot);
            if (strWebRoot.indexOf("http://") >= 0 || strWebRoot.indexOf("https://") >= 0) {
                var strShortUrl_1 = "";
                if (LocUrl.substr(0, 1) == "/") {
                    strShortUrl_1 = strWebRoot + LocUrl;
                }
                else {
                    strShortUrl_1 = strWebRoot + "/" + LocUrl;
                }
                //显示信息框
                console.log(strShortUrl_1);
                window.location.href = strShortUrl_1;
                return;
            }
            var strProtocol = location.protocol;
            var strHost = location.host;
            var strPathName = location.pathname;
            var strShortUrl = "/".concat(strWebRoot, "/").concat(LocUrl);
            strShortUrl = strShortUrl.replace("//", "/");
            strShortUrl = strShortUrl.replace("//", "/");
            //显示信息框
            var strNewLink = "".concat(strProtocol, "//").concat(strHost).concat(strShortUrl);
            console.log(strNewLink);
            window.location.href = strNewLink;
        };
        /*
        *为下拉框绑定布尔型的值，"是","否"
        */
        clsCommonFunc4Web.BindDdl_TrueAndFalse = function (ddlTrueAndFalse) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlTrueAndFalse);
            if (objDdl == null) {
                var strMsg = "\u4E0B\u62C9\u6846:".concat(ddlTrueAndFalse, " \u4E0D\u5B58\u5728\uFF01");
                alert(strMsg);
                throw (strMsg);
            }
            var arrTrueFalseLst = [
                {
                    Text: "是",
                    Value: "01"
                },
                {
                    Text: "否",
                    Value: "02"
                },
            ];
            //在一行代码中不能同时使用两个其他类名
            //     clsCommonFunc4Web.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
            clsCommonFunc4Web.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, "Value", "Text", "是/否");
            console.log("完成BindDdl_TrueAndFalse!");
        };
        /*
       * 绑定下拉框
       */
        clsCommonFunc4Web.BindDdl_ObjLstWithSet = function (strDdlName, arrObjLst, strTabCnName) {
            var sltDdl = document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = "选" + strTabCnName + "...";
            //var objArrayItem: HTMLOptionElement = new HTMLOptionElement();
            //objArrayItem.text = strText;
            //objArrayItem.value = "0";
            //sltDdl.options.add(objArrayItem);
            sltDdl.options.add(new Option(strText, "0"));
            var i = 0;
            arrObjLst.forEach(function (element, index, array) {
                // element: 指向当前元素的值
                // index: 指向当前索引
                // array: 指向Array对象本身
                //alert(element);
                sltDdl.options.add(new Option(element, element));
            });
        };
        /*
         * 绑定下拉框
         */
        clsCommonFunc4Web.BindDdl_ObjLst = function (strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            var sltDdl = document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = "选" + strTabCnName + "...";
            //var objArrayItem: HTMLOptionElement = new HTMLOptionElement();
            //objArrayItem.text = strText;
            //objArrayItem.value = "0";
            //sltDdl.options.add(objArrayItem);
            sltDdl.options.add(new Option(strText, "0"));
            var i = 0;
            for (i = 0; i < arrObjLst.length; i++) {
                var objCurr = arrObjLst[i];
                sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
            }
        };
        /*
       * 绑定下拉框,在层(Div)内查找相应下拉框
       */
        clsCommonFunc4Web.BindDdl_ObjLstInDiv = function (strDivName, strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            var objDiv = document.getElementById(strDivName);
            if (objDiv == null) {
                var strMsg = clsString_js_1.clsString.Format("层:[{0}]在该界面不存在！", strDivName);
                throw (strMsg);
            }
            var arrSelect = objDiv.getElementsByTagName("select");
            var arrElements = clsCommonFunc4Web.GetArray(arrSelect);
            var sltDdl = arrElements.find(function (x) { return x.id == strDdlName; });
            if (sltDdl == null) {
                var strMsg = clsString_js_1.clsString.Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = "选" + strTabCnName + "...";
            sltDdl.options.add(new Option(strText, "0"));
            var i = 0;
            for (i = 0; i < arrObjLst.length; i++) {
                var objCurr = arrObjLst[i];
                sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
            }
        };
        /*
       * 绑定下拉框
       */
        clsCommonFunc4Web.BindDdl_ObjLstV2 = function (sltDdl, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = strTabCnName;
            //var objArrayItem: HTMLOptionElement = new HTMLOptionElement();
            //objArrayItem.text = strText;
            //objArrayItem.value = "0";
            //sltDdl.options.add(objArrayItem);
            sltDdl.options.add(new Option(strText, "0"));
            var i = 0;
            for (i = 0; i < arrObjLst.length; i++) {
                var objCurr = arrObjLst[i];
                sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
            }
        };
        /*
         * 获取对象的所有属性名列表
         */
        clsCommonFunc4Web.GetObjKeys = function (myObj) {
            var sstrKeys = [];
            for (var p1 in myObj) {
                if (myObj.hasOwnProperty(p1))
                    sstrKeys.push(p1);
            }
            return sstrKeys;
        };
        clsCommonFunc4Web.GetObjKeys_Sim = function (myObj) {
            var sstrKeys = [];
            for (var p1 in myObj) {
                if (Object.prototype.hasOwnProperty.call(myObj, p1))
                    sstrKeys.push(p1);
            }
            return sstrKeys;
        };
        /*
        * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个老版本(V2)
        */
        clsCommonFunc4Web.BindTab = function (divContainer, arrObjLst, sstrFldName, sstrColHeader, strKey) {
            //var o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //var sstrFldName: Array<string> = new Array<string>();
            //var sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("Memo"); sstrColHeader.push("备注");
            var table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            var tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            var intRowNum = arrObjLst.length;
            var intColNum = sstrFldName.length;
            var trHead = document.createElement("tr");
            trHead.className = "row-height";
            var td00 = document.createElement("td");
            var check00 = document.createElement("input");
            check00.type = "checkbox";
            check00.id = "chkHead";
            check00.name = "chkHead";
            check00.className = "CheckInTab";
            //check00.attributes["onclick"] = "SetAllCkechedKeys('tab4Bind')";   
            check00.onclick = (function () {
                SetAllCkechedKeys(divContainer);
            });
            td00.appendChild(check00);
            trHead.appendChild(td00);
            for (var j = 0; j < intColNum; j++) {
                var td = document.createElement("td");
                var a1 = document.createElement("a");
                a1.nodeValue = sstrColHeader[j]; //i + "" + j;
                a1.text = sstrColHeader[j]; //i + "" + j;
                a1.href = "javascript:SortBy('".concat(sstrFldName[j], "');");
                //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                td.appendChild(a1);
                //td.appendChild(document.createTextNode(i + "" + j));
                //td.style.color = "#FF0000";
                td.className = "text-center";
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objEN = arrObjLst[i];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                var td0 = document.createElement("td");
                var check = document.createElement("input");
                check.type = "checkbox";
                var strKeyValue = objEN[strKey];
                check.id = "chk".concat(strKeyValue);
                check.name = "chkInTab";
                check.className = "CheckInTab";
                //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                //check.onclick = (function () {
                //    ChkClick(this);
                //});
                td0.appendChild(check);
                tr.appendChild(td0);
                for (var j = 0; j < intColNum; j++) {
                    var td = document.createElement("td");
                    //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                    td.innerHTML = objEN[sstrFldName[j]]; //i + "" + j;
                    //td.appendChild(document.createTextNode(i + "" + j));
                    //td.style.color = "#FF0000";
                    td.className = "text-center";
                    tr.appendChild(td);
                }
                tbody.appendChild(tr);
            }
            table.appendChild(tbody);
            while (divContainer.childNodes.length > 0) {
                divContainer.removeChild(divContainer.childNodes[0]);
            }
            divContainer.appendChild(table);
            exports.arrSelectedKeys.splice(0);
        };
        /*
         * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V2)
         */
        clsCommonFunc4Web.BindTabV2 = function (divContainer, arrObjLst, arrDataColumn, strKey) {
            //var o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //var sstrFldName: Array<string> = new Array<string>();
            //var sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("Memo"); sstrColHeader.push("备注");
            var table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            var tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            var intRowNum = arrObjLst.length;
            var intColNum = arrDataColumn.length;
            var trHead = document.createElement("tr");
            trHead.className = "row-height";
            for (var j = 0; j < intColNum; j++) {
                var td = document.createElement("td");
                switch (arrDataColumn[j].ColumnType) {
                    case "CheckBox":
                        var check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = "chkHead";
                        check00.name = "chkHead";
                        check00.className = "CheckInTab";
                        //check00.attributes["onclick"] = "SetAllCkechedKeys('tab4Bind')";   
                        check00.onclick = (function () {
                            SetAllCkechedKeys(divContainer);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                        var a1 = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                        a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                        a1.href = "javascript:SortBy('".concat(arrDataColumn[j].SortBy, "');");
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        break;
                    case "Button":
                        try {
                            var span1 = document.createElement("span");
                            //console.log(arrDataColumn[j].ColHeader);
                            span1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].ColHeader; //i + "" + j;
                            //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            var a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.href = "javascript:SortBy('".concat(arrDataColumn[j].FldName, "');");
                            //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objEN = arrObjLst[i];
                var strKeyValue = objEN[strKey];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                tr.id = "tr".concat(strKeyValue);
                for (var j = 0; j < intColNum; j++) {
                    var td = document.createElement("td");
                    td.className = arrDataColumn[j].TdClass;
                    switch (arrDataColumn[j].ColumnType) {
                        case "CheckBox":
                            var check = document.createElement("input");
                            check.type = "checkbox";
                            check.id = "chk".concat(strKeyValue);
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            if (clsString_js_1.clsString.IsNullOrEmpty(objEN["CtrlId"]) == false) {
                                check.setAttribute("CtrlId", objEN["CtrlId"]);
                            }
                            //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                            //check.onclick = (function () {
                            //    ChkClick(this);
                            //});
                            td.appendChild(check);
                            break;
                        case "Label":
                            td.innerHTML = objEN[arrDataColumn[j].FldName]; //i + "" + j;
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            if (clsString_js_1.clsString.IsNullOrEmpty(td.className)) {
                                td.className = "text-center";
                            }
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                var strKeyValue = objEN[strKey];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text);
                                td.appendChild(btn1);
                                //var btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].Text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                var strKeyValue = objEN[strKey];
                                var strText = objEN[arrDataColumn[j].FldName];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, strText);
                                td.appendChild(btn1);
                                //var btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].Text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                    }
                    tr.appendChild(td);
                }
                tbody.appendChild(tr);
            }
            table.appendChild(tbody);
            while (divContainer.childNodes.length > 0) {
                divContainer.removeChild(divContainer.childNodes[0]);
            }
            divContainer.appendChild(table);
            exports.arrSelectedKeys.splice(0);
        };
        /*
    * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V2)
    */
        clsCommonFunc4Web.BindTabV2Where = function (divContainer, arrObjLst, arrDataColumn, strKey, strWhere) {
            //var o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //var sstrFldName: Array<string> = new Array<string>();
            //var sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("Memo"); sstrColHeader.push("备注");
            var table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            var tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            var intRowNum = arrObjLst.length;
            var intColNum = arrDataColumn.length;
            var trHead = document.createElement("tr");
            trHead.className = "row-height";
            for (var j = 0; j < intColNum; j++) {
                var td = document.createElement("td");
                switch (arrDataColumn[j].ColumnType) {
                    case "CheckBox":
                        var check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = "chkHead";
                        check00.name = "chkHead";
                        check00.className = "CheckInTab";
                        //check00.attributes["onclick"] = "SetAllCkechedKeys('tab4Bind')";   
                        check00.onclick = (function () {
                            SetAllCkechedKeys(divContainer);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                        var a1 = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                        a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                        //判断传入的值，然后显示调用不同的方法
                        if (strWhere == "TopicUser") {
                            //用户
                            a1.href = "javascript:SortByUser('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicRTUser") {
                            //主题用户关系
                            a1.href = "javascript:SortByRTUser('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicPaper") {
                            //论文
                            a1.href = "javascript:SortByPaper('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicRTPaper") {
                            //主题论文关系
                            a1.href = "javascript:SortByRTPaper('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicViewpoint") {
                            //个人观点
                            a1.href = "javascript:SortByViewpoint('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicRTViewpoint") {
                            //主题个人观点关系
                            a1.href = "javascript:SortByRTViewpoint('".concat(arrDataColumn[j].FldName, "');");
                        }
                        //else if (strWhere == "TopicExpertViewpoint") {
                        //    //专家观点
                        //    a1.href = `javascript:SortByExpertViewpoint('${arrDataColumn[j].FldName}');`;
                        //}
                        else if (strWhere == "TopicRTExpertViewpoint") {
                            //主题专家观点关系
                            a1.href = "javascript:SortByRTExpertViewpoint('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicConcept") {
                            //概念
                            a1.href = "javascript:SortByConcept('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicRTConcept") {
                            //主题概念关系
                            a1.href = "javascript:SortByRTConcept('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicObjectiveFact") {
                            //客观事实
                            a1.href = "javascript:SortByObjectiveFact('".concat(arrDataColumn[j].FldName, "');");
                        }
                        else if (strWhere == "TopicRTObjectiveFact") {
                            //主题客观事实关系
                            a1.href = "javascript:SortByRTObjectiveFact('".concat(arrDataColumn[j].FldName, "');");
                        }
                        //else if (strWhere == "TopicObjectiveBasis") {
                        //    //客观依据
                        //    a1.href = `javascript:SortByObjectiveBasis('${arrDataColumn[j].FldName}');`;
                        //}
                        else if (strWhere == "TopicRTObjectiveBasis") {
                            //主题客观依据关系
                            a1.href = "javascript:SortByRTObjectiveBasis('".concat(arrDataColumn[j].FldName, "');");
                        }
                        //else if (strWhere == "TopicPaperList") {
                        //    //论文列表
                        //    a1.href = `javascript:SortByPaperList('${arrDataColumn[j].FldName}');`;
                        //}
                        else {
                            a1.href = "javascript:SortBy('".concat(arrDataColumn[j].FldName, "');");
                        }
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        break;
                    case "Button":
                        try {
                            var span1 = document.createElement("span");
                            console.log(arrDataColumn[j].ColHeader);
                            span1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].ColHeader; //i + "" + j;
                            //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objEN = arrObjLst[i];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                for (var j = 0; j < intColNum; j++) {
                    var td = document.createElement("td");
                    switch (arrDataColumn[j].ColumnType) {
                        case "CheckBox":
                            var check = document.createElement("input");
                            check.type = "checkbox";
                            var strKeyValue = objEN[strKey];
                            check.id = "chk".concat(strKeyValue);
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                            //check.onclick = (function () {
                            //    ChkClick(this);
                            //});
                            td.appendChild(check);
                            break;
                        case "Label":
                            td.innerHTML = objEN[arrDataColumn[j].FldName]; //i + "" + j;
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                var strKeyValue = objEN[strKey];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text);
                                td.appendChild(btn1);
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                    }
                    tr.appendChild(td);
                }
                tbody.appendChild(tr);
            }
            table.appendChild(tbody);
            while (divContainer.childNodes.length > 0) {
                divContainer.removeChild(divContainer.childNodes[0]);
            }
            divContainer.appendChild(table);
            exports.arrSelectedKeys.splice(0);
        };
        /*
        * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V3)
        */
        clsCommonFunc4Web.BindTabV3 = function (divContainer, arrObjLst, arrDataColumn, strKey, objOperateList) {
            //var o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //var sstrFldName: Array<string> = new Array<string>();
            //var sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("Memo"); sstrColHeader.push("备注");
            var table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            var tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            var intRowNum = arrObjLst.length;
            var intColNum = arrDataColumn.length;
            var trHead = document.createElement("tr");
            trHead.className = "row-height";
            for (var j = 0; j < intColNum; j++) {
                var td = document.createElement("td");
                switch (arrDataColumn[j].ColumnType) {
                    case "CheckBox":
                        var check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = "chkHead";
                        check00.name = "chkHead";
                        check00.className = "CheckInTab";
                        //check00.attributes["onclick"] = "SetAllCkechedKeys('tab4Bind')";   
                        check00.onclick = (function () {
                            clsCommonFunc4Web.SetAllCkechedKeysV2(divContainer, this);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                        var strSortExpress = arrDataColumn[j].SortBy;
                        if (clsString_js_1.clsString.IsNullOrEmpty(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            var span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].ColHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                        else {
                            var a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.setAttribute("FldName", strSortExpress);
                            a1.href = 'javascript:';
                            a1.onclick = (function () {
                                objOperateList.SortBy(this);
                            });
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                        }
                        td.className = "text-center";
                        break;
                    case "Button":
                        try {
                            var span1 = document.createElement("span");
                            //console.log(arrDataColumn[j].ColHeader);
                            span1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].ColHeader; //i + "" + j;
                            //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            var a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.href = "javascript:SortBy('".concat(arrDataColumn[j].FldName, "');");
                            //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objEN = arrObjLst[i];
                var strKeyValue = objEN[strKey];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                tr.id = "tr".concat(strKeyValue);
                for (var j = 0; j < intColNum; j++) {
                    var td = document.createElement("td");
                    td.className = arrDataColumn[j].TdClass;
                    switch (arrDataColumn[j].ColumnType) {
                        case "CheckBox":
                            var check = document.createElement("input");
                            check.type = "checkbox";
                            check.id = "chk".concat(strKeyValue);
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            if (clsString_js_1.clsString.IsNullOrEmpty(objEN["CtrlId"]) == false) {
                                check.setAttribute("CtrlId", objEN["CtrlId"]);
                            }
                            //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                            //check.onclick = (function () {
                            //    ChkClick(this);
                            //});
                            td.appendChild(check);
                            break;
                        case "Label":
                            if (clsString_js_1.clsString.IsNullOrEmpty(arrDataColumn[j].FldName) == false) {
                                td.innerHTML = objEN[arrDataColumn[j].FldName]; //i + "" + j;
                                if (clsString_js_1.clsString.IsNullOrEmpty(td.className)) {
                                    td.className = "text-center";
                                }
                            }
                            else {
                                //调用外面的函数生成一个层放在该单元格中
                                var div1 = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text);
                                td.appendChild(div1);
                            }
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                var strKeyValue = objEN[strKey];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text);
                                td.appendChild(btn1);
                                //var btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].Text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                var strKeyValue = objEN[strKey];
                                var strText = objEN[arrDataColumn[j].FldName];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, strText);
                                td.appendChild(btn1);
                                //var btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].Text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                    }
                    tr.appendChild(td);
                }
                tbody.appendChild(tr);
            }
            table.appendChild(tbody);
            while (divContainer.childNodes.length > 0) {
                divContainer.removeChild(divContainer.childNodes[0]);
            }
            divContainer.appendChild(table);
            exports.arrSelectedKeys.splice(0);
        };
        clsCommonFunc4Web.BindTabV4 = function (divContainer, arrObjLst, arrDataColumn, strKey, objOperateList) {
            //var o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //var sstrFldName: Array<string> = new Array<string>();
            //var sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("Memo"); sstrColHeader.push("备注");
            var table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            var tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            var intRowNum = arrObjLst.length;
            var intColNum = arrDataColumn.length;
            var trHead = document.createElement("tr");
            trHead.className = "row-height";
            for (var j = 0; j < intColNum; j++) {
                var td = document.createElement("td");
                switch (arrDataColumn[j].ColumnType) {
                    case "CheckBox":
                        var check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = "chkHead";
                        check00.name = "chkHead";
                        check00.className = "CheckInTab";
                        //check00.attributes["onclick"] = "SetAllCkechedKeys('tab4Bind')";   
                        check00.onclick = (function () {
                            clsCommonFunc4Web.SetAllCkechedKeysV2(divContainer, this);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                        var strSortExpress = arrDataColumn[j].SortBy;
                        if (clsString_js_1.clsString.IsNullOrEmpty(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            var span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].ColHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                        else {
                            var a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.setAttribute("FldName", strSortExpress);
                            a1.href = 'javascript:';
                            a1.onclick = (function () {
                                objOperateList.SortBy(this);
                            });
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                        }
                        td.className = "text-center";
                        break;
                    case "Button":
                        try {
                            var span1 = document.createElement("span");
                            //console.log(arrDataColumn[j].ColHeader);
                            span1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].ColHeader; //i + "" + j;
                            //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            var a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.href = "javascript:SortBy('".concat(arrDataColumn[j].FldName, "');");
                            //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u5217\u5934:").concat(arrDataColumn[j].ColHeader);
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objEN = arrObjLst[i];
                var strKeyValue = objEN[strKey];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                tr.id = "tr".concat(strKeyValue);
                for (var j = 0; j < intColNum; j++) {
                    var td = document.createElement("td");
                    td.className = arrDataColumn[j].TdClass;
                    switch (arrDataColumn[j].ColumnType) {
                        case "CheckBox":
                            var check = document.createElement("input");
                            check.type = "checkbox";
                            check.id = "chk".concat(strKeyValue);
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            if (clsString_js_1.clsString.IsNullOrEmpty(objEN["CtrlId"]) == false) {
                                check.setAttribute("CtrlId", objEN["CtrlId"]);
                            }
                            //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                            //check.onclick = (function () {
                            //    ChkClick(this);
                            //});
                            td.appendChild(check);
                            break;
                        case "Label":
                            if (clsString_js_1.clsString.IsNullOrEmpty(arrDataColumn[j].FldName) == false) {
                                td.innerHTML = objEN[arrDataColumn[j].FldName]; //i + "" + j;
                                if (clsString_js_1.clsString.IsNullOrEmpty(td.className)) {
                                    td.className = "text-center";
                                }
                            }
                            else {
                                //调用外面的函数生成一个层放在该单元格中
                                var div1 = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text);
                                td.appendChild(div1);
                            }
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                var strKeyValue = objEN[strKey];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text);
                                td.appendChild(btn1);
                                //var btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].Text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                var strKeyValue = objEN[strKey];
                                var strText = objEN[arrDataColumn[j].FldName];
                                var btn1 = arrDataColumn[j].FuncName(strKeyValue, strText);
                                td.appendChild(btn1);
                                //var btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].Text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:".concat(arrDataColumn[j].ColumnType, ",\u6587\u672C:").concat(arrDataColumn[j].Text);
                                throw (strMsg);
                            }
                            break;
                    }
                    tr.appendChild(td);
                }
                tbody.appendChild(tr);
            }
            table.appendChild(tbody);
            while (divContainer.childNodes.length > 0) {
                divContainer.removeChild(divContainer.childNodes[0]);
            }
            divContainer.appendChild(table);
            exports.arrSelectedKeys.splice(0);
        };
        /*
         * 获取列表中所有被选的复选框的关键字值，以列表方式(Array<string>)返回
         */
        clsCommonFunc4Web.GetCheckedKeyIds = function () {
            var divList = document.getElementById("divList");
            var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            var arrChkLitems = this.GetArray(chkItems);
            var chkCheckedItems = arrChkLitems.filter(function (x) { return x.checked == true; });
            var arrSelectedKeys = chkCheckedItems.map(function (x) {
                var strId = x.id;
                var strKey = strId.substring(3);
                return strKey;
            });
            //var intCheckedCount = chkCheckedItems.length;
            //for (var i = 0; i < intCheckedCount; i++) {
            //    var chkItem: HTMLInputElement = chkCheckedItems[i] as HTMLInputElement;
            //    var strId = chkItem.id;
            //    var strKey = strId.substring(3);
            //    arrSelectedKeys.push(strKey);
            //}
            //    alert(intCount.toString() + "::" + intCheckedCount.toString());
            return arrSelectedKeys;
        };
        /*
         * 获取列表中第一个选中的复选框的关键字
         */
        clsCommonFunc4Web.GetFirstCheckedKeyId = function (divListName) {
            if (divListName == undefined) {
                alert("在GetFirstCheckedKeyId函数中divListName为空，请与管理员联系！");
                return "";
            }
            var divList = document.getElementById(divListName);
            var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            var arrChkLitems = this.GetArray(chkItems);
            var chkCheckedItems = arrChkLitems.filter(function (x) { return x.checked == true; });
            var intCheckedCount = chkCheckedItems.length;
            for (var i = 0; i < intCheckedCount; i++) {
                var chkItem = chkCheckedItems[i];
                if (chkItem.id == 'chkTabHead')
                    continue;
                var strId = chkItem.id;
                var strKey = strId.substring(3);
                return strKey;
            }
            //    alert(intCount.toString() + "::" + intCheckedCount.toString());
            return "";
        };
        ///*
        // * 获取列表中第一个选中的复选框的关键字
        // */
        //public static GetFirstCheckedKeyId(): string {
        //    var divList: HTMLDivElement = document.getElementById("divList") as HTMLDivElement;
        //    var chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
        //    let arrChkLitems: Array<HTMLInputElement> = this.GetArray(chkItems) as Array<HTMLInputElement>;
        //    var chkCheckedItems: Array<HTMLInputElement> = arrChkLitems.filter((x) => x.checked == true);
        //    var intCheckedCount = chkCheckedItems.length;
        //    for (var i = 0; i < intCheckedCount; i++) {
        //        var chkItem: HTMLInputElement = chkCheckedItems[i] as HTMLInputElement;
        //        var strId = chkItem.id;
        //        var strKey = strId.substring(3);
        //        return strKey;
        //    }
        //    //    alert(intCount.toString() + "::" + intCheckedCount.toString());
        //    return "";
        //}
        /*
         * 根据列表的左上角的复选框值，全选或全不选列表中所有复选框
         */
        clsCommonFunc4Web.SetAllCkechedKeys = function (tabName, thisChk) {
            var arrKeys = tabName.getElementsByClassName('CheckInTab');
            //var thisChk = EventTarget;//
            //var thisChk: HTMLInputElement = e.target as HTMLInputElement;  tabName.getElementsByClassName;// EventTarget as HTMLInputElement;
            var bolIsCheck = thisChk.checked;
            console.log(bolIsCheck);
            var arrKeyLst = this.GetArray(arrKeys);
            arrKeyLst.forEach(function (e) { return e.checked = bolIsCheck; });
            alert(arrKeys.length.toString());
        };
        clsCommonFunc4Web.SetAllCkechedKeysV2 = function (tabName, thisChk) {
            console.log("thisChk(In SetAllCkechedKeysV2):", thisChk);
            //event = window.event || event;
            var thisEventObj = thisChk;
            var arrKeys = tabName.getElementsByClassName('CheckInTab');
            var bolIsCheck = thisEventObj.checked;
            var arrKeyLst = this.GetArray(arrKeys);
            arrKeyLst.forEach(function (e) { return e.checked = bolIsCheck; });
            console.log("所选记录的个数:", arrKeys.length.toString());
        };
        /*
         * 设置使特定关键字的复选框被选
         * strKeyId:关键字
         */
        clsCommonFunc4Web.SetCkechedItem4KeyId = function (strArrayDiv, strKeyId) {
            //获取指定数据列表层
            var divList = document.getElementById(strArrayDiv);
            //根据ClassName获取数据列表层中的所有复选框
            var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            //把集合转换成Array
            var arrChkLitems = this.GetArray(chkItems);
            //根据关键字(strKeyId)获取相应的控件id
            var strCtrlId = "chk" + strKeyId;
            //在控件Array中查找第一个id为strCtrlId的复选框
            var chk4KeyId = arrChkLitems.find(function (x) { return x.id == strCtrlId; });
            //let chk4KeyId: HTMLInputElement = document.getElementById(strCtrlId);
            console.log(chk4KeyId);
            if (chk4KeyId == null) {
                var strMsg = "\u5173\u952E\u5B57:".concat(strCtrlId, "\u6CA1\u6709\u627E\u5230\uFF0C\u8BF7\u8054\u7CFB\u7BA1\u7406\u5458\uFF01");
                console.log(strMsg);
                //alert(strMsg);
                return;
            }
            chk4KeyId.checked = true;
        };
        /*
         * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
         */
        clsCommonFunc4Web.GetArray = function (arr) {
            var arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        };
        clsCommonFunc4Web.Test1 = function () {
            return "Test1";
        };
        /*
         * 确认删除函数
         */
        clsCommonFunc4Web.confirm_del = function (intCount) {
            var strMsg = clsString_js_1.clsString.Format("你真的确定要删除记录吗?");
            if (intCount > 0) {
                strMsg = clsString_js_1.clsString.Format("你真的确定要删除{0}条记录吗?", intCount);
            }
            var gnl = confirm(strMsg);
            if (gnl == true) {
                return true;
            }
            else {
                return false;
            }
        };
        clsCommonFunc4Web.GetExceptionStr = function (objException) {
            var strEx = "";
            if (typeof (objException) == "string") {
                strEx = objException;
            }
            else if (typeof (objException) == "number") {
                strEx = objException.toString();
            }
            else if (typeof (objException) == "boolean") {
                strEx = objException.toString();
            }
            else {
                strEx = "";
            }
            return strEx;
        };
        return clsCommonFunc4Web;
    }());
    exports.clsCommonFunc4Web = clsCommonFunc4Web;
});

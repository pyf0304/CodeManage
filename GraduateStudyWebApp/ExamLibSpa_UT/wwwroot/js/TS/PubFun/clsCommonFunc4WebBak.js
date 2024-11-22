(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.arrSelectedKeys = new Array();
    function ChkClick1Bak(myThis) {
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
            sstrKey += strK + ",";
        }
        $('#spanResult').html(sstrKey);
    }
    exports.ChkClick1Bak = ChkClick1Bak;
    var clsCommonFunc4WebBak = /** @class */ (function () {
        function clsCommonFunc4WebBak() {
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[College]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        clsCommonFunc4WebBak.BindDdl_TrueAndFalse = function (ddlTrueAndFalse) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlTrueAndFalse);
            if (objDdl == null) {
                var strMsg = "\u4E0B\u62C9\u6846\uFF1A" + ddlTrueAndFalse + " \u4E0D\u5B58\u5728\uFF01";
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
            clsCommonFunc4WebBak.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, "Value", "Text", "是/否");
            console.log("完成BindDdl_TrueAndFalse!");
        };
        /*
         * 重新转向本项目新的Url地址
         */
        clsCommonFunc4WebBak.Redirect = function (LocUrl) {
            var strProtocol = location.protocol;
            var strHost = location.host;
            var strPathName = location.pathname;
            var strShortUrl = "/" + strWebRoot + "/" + LocUrl;
            strShortUrl = strShortUrl.replace("//", "/");
            strShortUrl = strShortUrl.replace("//", "/");
            //显示信息框
            var strNewLink = strProtocol + "//" + strHost + strShortUrl;
            console.log(strNewLink);
            window.location.href = strNewLink;
        };
        clsCommonFunc4WebBak.BindDdl_ObjLst = function (strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            var sltDdl = document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = "请选择" + strTabCnName + "...";
            //var objListItem: HTMLOptionElement = new HTMLOptionElement();
            //objListItem.text = strText;
            //objListItem.value = "0";
            //sltDdl.options.add(objListItem);
            sltDdl.options.add(new Option(strText, "0"));
            var i = 0;
            for (i = 0; i < arrObjLst.length; i++) {
                var objCurr = arrObjLst[i];
                sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
            }
        };
        //获取对象的所有属性名列表
        clsCommonFunc4WebBak.GetObjKeys = function (myObj) {
            var sstrKeys = [];
            for (var p1 in myObj) {
                if (myObj.hasOwnProperty(p1))
                    sstrKeys.push(p1);
            }
            return sstrKeys;
        };
        clsCommonFunc4WebBak.BindTab = function (divContainer, arrUserIdentityObjLst, sstrFldName, sstrColHeader, strKey) {
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
            var intRowNum = arrUserIdentityObjLst.length;
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
                a1.href = "javascript:SortBy('" + sstrFldName[j] + "');";
                //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                td.appendChild(a1);
                //td.appendChild(document.createTextNode(i + "" + j));
                //td.style.color = "#FF0000";
                td.className = "text-center";
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objUserIdentityEN = arrUserIdentityObjLst[i];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                var td0 = document.createElement("td");
                var check = document.createElement("input");
                check.type = "checkbox";
                var strKeyValue = objUserIdentityEN[strKey];
                check.id = "chk" + strKeyValue;
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
                    //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                    td.innerHTML = objUserIdentityEN[sstrFldName[j]]; //i + "" + j;
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
        clsCommonFunc4WebBak.BindTabV2 = function (divContainer, arrUserIdentityObjLst, arrDataColumn, strKey) {
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
            table.className = "table table-sm table-striped table-condensed table-bordered";
            var tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            var intRowNum = arrUserIdentityObjLst.length;
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
                        a1.href = "javascript:SortBy('" + arrDataColumn[j].FldName + "');";
                        //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
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
                            //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:" + arrDataColumn[j].ColumnType + ",\u5217\u5934:" + arrDataColumn[j].ColHeader;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            var a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].ColHeader; //i + "" + j;
                            a1.href = "javascript:SortBy('" + arrDataColumn[j].FldName + "');";
                            //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:" + arrDataColumn[j].ColumnType + ",\u5217\u5934:" + arrDataColumn[j].ColHeader;
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (var i = 0; i < intRowNum; i++) {
                var objUserIdentityEN = arrUserIdentityObjLst[i];
                var tr = document.createElement("tr");
                tr.className = "row-height";
                for (var j = 0; j < intColNum; j++) {
                    var td = document.createElement("td");
                    switch (arrDataColumn[j].ColumnType) {
                        case "CheckBox":
                            var check = document.createElement("input");
                            check.type = "checkbox";
                            var strKeyValue = objUserIdentityEN[strKey];
                            check.id = "chk" + strKeyValue;
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                            //check.onclick = (function () {
                            //    ChkClick(this);
                            //});
                            td.appendChild(check);
                            break;
                        case "Label":
                            td.innerHTML = objUserIdentityEN[arrDataColumn[j].FldName]; //i + "" + j;
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                var strKeyValue = objUserIdentityEN[strKey];
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
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:" + arrDataColumn[j].ColumnType + ",\u6587\u672C:" + arrDataColumn[j].Text;
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                var strKeyValue = objUserIdentityEN[strKey];
                                var strText = objUserIdentityEN[arrDataColumn[j].FldName];
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
                                var strMsg = "\u7ED1\u5B9A\u8868\u884C\u4E0D\u6210\u529F\u3002\u7C7B\u578B:" + arrDataColumn[j].ColumnType + ",\u6587\u672C:" + arrDataColumn[j].Text;
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
        clsCommonFunc4WebBak.GetCheckedKeyIds = function () {
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
        clsCommonFunc4WebBak.GetFirstCheckedKeyId = function () {
            var divList = document.getElementById("divList");
            var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            var arrChkLitems = this.GetArray(chkItems);
            var chkCheckedItems = arrChkLitems.filter(function (x) { return x.checked == true; });
            var intCheckedCount = chkCheckedItems.length;
            for (var i = 0; i < intCheckedCount; i++) {
                var chkItem = chkCheckedItems[i];
                var strId = chkItem.id;
                var strKey = strId.substring(3);
                return strKey;
            }
            //    alert(intCount.toString() + "::" + intCheckedCount.toString());
            return "";
        };
        clsCommonFunc4WebBak.SetAllCkechedKeys = function (tabName, thisChk) {
            var arrKeys = tabName.getElementsByClassName('CheckInTab');
            //var thisChk = EventTarget;//
            //var thisChk: HTMLInputElement = e.target as HTMLInputElement;  tabName.getElementsByClassName;// EventTarget as HTMLInputElement;
            var bolIsCheck = thisChk.checked;
            console.log(bolIsCheck);
            var arrKeyLst = this.GetArray(arrKeys);
            arrKeyLst.forEach(function (e) { return e.checked = bolIsCheck; });
            alert(arrKeys.length.toString());
        };
        clsCommonFunc4WebBak.GetArray = function (arr) {
            var arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        };
        clsCommonFunc4WebBak.Test1 = function () {
            return "Test1";
        };
        return clsCommonFunc4WebBak;
    }());
    exports.clsCommonFunc4WebBak = clsCommonFunc4WebBak;
});
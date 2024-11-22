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
            sstrKey += strK + ",";
        }
        $('#spanResult').html(sstrKey);
    }
    exports.ChkClick1 = ChkClick1;
    var clsCommonFunc4Web = /** @class */ (function () {
        function clsCommonFunc4Web() {
        }
        /*
        * 重新转向本项目新的Url地址
        */
        clsCommonFunc4Web.Redirect = function (LocUrl) {
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
        /*
        *为下拉框绑定布尔型的值，"是","否"
        */
        clsCommonFunc4Web.BindDdl_TrueAndFalse = function (ddlTrueAndFalse) {
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
            //在一行代码中不能同时使用两个其他类名
            //     clsCommonFunc4Web.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
            clsCommonFunc4Web.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, "Value", "Text", "是/否");
            console.log("完成BindDdl_TrueAndFalse!");
        };
        /*
         * 绑定下拉框
         */
        clsCommonFunc4Web.BindDdl_ObjLst = function (strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            var sltDdl = document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = "选:" + strTabCnName + "...";
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
                a1.href = "javascript:SortBy('" + sstrFldName[j] + "');";
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
                        a1.href = "javascript:SortBy('" + arrDataColumn[j].FldName + "');";
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
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:" + arrDataColumn[j].ColumnType + ",\u5217\u5934:" + arrDataColumn[j].ColHeader;
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
                            a1.href = "javascript:SortByUser('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicRTUser") {
                            //主题用户关系
                            a1.href = "javascript:SortByRTUser('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicPaper") {
                            //论文
                            a1.href = "javascript:SortByPaper('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicRTPaper") {
                            //主题论文关系
                            a1.href = "javascript:SortByRTPaper('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicViewpoint") {
                            //个人观点
                            a1.href = "javascript:SortByViewpoint('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicRTViewpoint") {
                            //主题个人观点关系
                            a1.href = "javascript:SortByRTViewpoint('" + arrDataColumn[j].FldName + "');";
                        }
                        //else if (strWhere == "TopicExpertViewpoint") {
                        //    //专家观点
                        //    a1.href = `javascript:SortByExpertViewpoint('${arrDataColumn[j].FldName}');`;
                        //}
                        else if (strWhere == "TopicRTExpertViewpoint") {
                            //主题专家观点关系
                            a1.href = "javascript:SortByRTExpertViewpoint('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicConcept") {
                            //概念
                            a1.href = "javascript:SortByConcept('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicRTConcept") {
                            //主题概念关系
                            a1.href = "javascript:SortByRTConcept('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicObjectiveFact") {
                            //客观事实
                            a1.href = "javascript:SortByObjectiveFact('" + arrDataColumn[j].FldName + "');";
                        }
                        else if (strWhere == "TopicRTObjectiveFact") {
                            //主题客观事实关系
                            a1.href = "javascript:SortByRTObjectiveFact('" + arrDataColumn[j].FldName + "');";
                        }
                        //else if (strWhere == "TopicObjectiveBasis") {
                        //    //客观依据
                        //    a1.href = `javascript:SortByObjectiveBasis('${arrDataColumn[j].FldName}');`;
                        //}
                        else if (strWhere == "TopicRTObjectiveBasis") {
                            //主题客观依据关系
                            a1.href = "javascript:SortByRTObjectiveBasis('" + arrDataColumn[j].FldName + "');";
                        }
                        //else if (strWhere == "TopicPaperList") {
                        //    //论文列表
                        //    a1.href = `javascript:SortByPaperList('${arrDataColumn[j].FldName}');`;
                        //}
                        else {
                            a1.href = "javascript:SortBy('" + arrDataColumn[j].FldName + "');";
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
                            var strMsg = "\u5EFA\u7ACB\u8868\u5934\u4E0D\u6210\u529F\u3002\u7C7B\u578B:" + arrDataColumn[j].ColumnType + ",\u5217\u5934:" + arrDataColumn[j].ColHeader;
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
        clsCommonFunc4Web.GetFirstCheckedKeyId = function () {
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
        /*
         * 设置使特定关键字的复选框被选
         * strKeyId：关键字
         */
        clsCommonFunc4Web.SetCkechedItem4KeyId = function (strListDiv, strKeyId) {
            //获取指定数据列表层
            var divList = document.getElementById(strListDiv);
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
                var strMsg = "\u5173\u952E\u5B57:" + strCtrlId + "\u6CA1\u6709\u627E\u5230\uFF0C\u8BF7\u8054\u7CFB\u7BA1\u7406\u5458\uFF01";
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
        return clsCommonFunc4Web;
    }());
    exports.clsCommonFunc4Web = clsCommonFunc4Web;
});

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
        clsCommonFunc4Web.BindDdl_ObjLst = function (strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
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
        clsCommonFunc4Web.GetObjKeys = function (myObj) {
            var sstrKeys = [];
            for (var p1 in myObj) {
                if (myObj.hasOwnProperty(p1))
                    sstrKeys.push(p1);
            }
            return sstrKeys;
        };
        clsCommonFunc4Web.BindTab = function (divContainer, arrUserIdentityObjLst, sstrFldName, sstrColHeader, strKey) {
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

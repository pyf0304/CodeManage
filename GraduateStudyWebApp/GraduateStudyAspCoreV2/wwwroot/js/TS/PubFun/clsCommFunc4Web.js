/*
 * 功能:为Web提供一些公共的功能函数
 * 版本:2021-06-06-01
 * 作者:潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsCboObject.js", "./clsCommFunc4Ctrl.js", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.BindTabV2Where_V = exports.BindTabV2Where = exports.GetFirstCheckedKeyId = exports.GetCheckedKeyIdsInDiv = exports.GetCheckedKeyIds = exports.SortFun = exports.confirm_del = exports.Redirect = exports.sortFun = exports.GetObjKeys = exports.getRootPath = exports.GetExceptionStr = exports.SetAllCkechedKeysV2 = exports.SetCkechedItem4KeyId = exports.SetNotCkechedItem4KeyId = exports.BindDdl_ObjLst_V = exports.BindDdl_ObjLst = exports.BindDdl_ObjLstInDiv_V = exports.BindDdl_ObjLstInDiv = exports.myShowErrorMsg = exports.getElementByIdInDiv = exports.BindDdl_TrueAndFalseInDiv = exports.BindDdl_TrueAndFalse = exports.BindDdl_CboObjectInDiv = exports.BindDdl_CboObject = exports.confirm_del4Msg = exports.GetObjValueOfKey = exports.GetObjValueOfKeyV2 = exports.SetAllNotCkechedItem = exports.GetWidthByWordStr = exports.GetSortExpressInfo = exports.GetSortExpress = exports.ObjectAssignV2 = exports.ObjectAssign = exports.GetSpan4BoolTrue = exports.GetSpan4BoolFalse = exports.HideDiv = exports.ShowDiv = exports.ShowTr = exports.HideTd = exports.HideTr = exports.ShowDialog = exports.HideDialog = exports.BindTab_V = exports.BindTab = exports.BindTab_KeyLst = exports.clsCommFunc4WebBak = exports.ChkClick1 = exports.arrSelectedKeys = void 0;
    const clsCboObject_js_1 = require("./clsCboObject.js");
    const clsCommFunc4Ctrl_js_1 = require("./clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("./clsString.js");
    //import * as bootstrap from 'bootstrap';
    exports.arrSelectedKeys = new Array();
    function ChkClick1(myThis) {
        const strId = myThis.id;
        if (strId == 'chkTabHead')
            return "";
        const strKey = strId.substring(3);
        if (myThis.checked == true) {
            if (exports.arrSelectedKeys.indexOf(strKey) < 0) {
                exports.arrSelectedKeys.push(strKey);
            }
        }
        else {
            const index = exports.arrSelectedKeys.indexOf(strKey);
            if (index > -1) {
                exports.arrSelectedKeys.splice(index, 1);
            }
        }
        let sstrKey = "";
        for (const strK of exports.arrSelectedKeys) {
            sstrKey += `${strK},`;
        }
        $('#spanResult').html(sstrKey);
    }
    exports.ChkClick1 = ChkClick1;
    //declare const strWebRoot: string;
    class clsCommFunc4WebBak {
        //public static SetSelectValue(objSelect: HTMLSelectElement, strValue: string) {
        //    for (const i = 0; i < objSelect.options.length; i++) {
        //        if (objSelect.options[i].value == strValue) {
        //            objSelect.selectedIndex = i;
        //            return;
        //        }
        //    }
        //}
        //public static SetSelectValueById(strSelectId: string, strValue: string) {
        //    const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
        //    if (objSelect == null) {
        //        console.error(`在设置下拉框值时，控件：${strSelectId}不存在！`);
        //        return;
        //    }
        //    for (const i = 0; i < objSelect.options.length; i++) {
        //        if (objSelect.options[i].value == strValue) {
        //            objSelect.selectedIndex = i;
        //            return;
        //        }
        //    }
        //}
        //public static SetCheckBoxValueByIdInDiv(strDivId: string, strCheckId: string, bolValue: boolean) {
        //    const objDiv = $(`#${strDivId}`);
        //    CheckControlExist(strDivId, "input", strCheckId);
        //    const strId = Format("input[id ^= '{0}']", strCheckId);
        //    objDiv.find(strId).prop("checked", bolValue);
        //}
        //public static SetSelectValueByIdInDiv(strDivId: string, strSelectId: string, strValue: string) {
        //    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        //    if (objDiv == null) {
        //        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        //console.error(strMsg);
        //        throw (strMsg);
        //    }
        //    const arrSelect = objDiv.getElementsByTagName("select");
        //    const arrElements = GetArray(arrSelect);
        //    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
        //    if (sltDdl == null) {
        //        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
        //console.error(strMsg);
        //        throw (strMsg);
        //    }
        ////    const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
        ////    if (objSelect == null) {
        ////        console.error(`在设置下拉框值时，控件：${strSelectId}不存在！`);
        ////        return;
        ////    }
        //    for (const i = 0; i < sltDdl.options.length; i++) {
        //        if (sltDdl.options[i].value == strValue) {
        //            sltDdl.selectedIndex = i;
        //            return;
        //        }
        //    }
        //}
        //public static SetSelectValueByIdInDivBak(strDivId: string, strSelectId: string, strValue: string) {
        //    const objDiv = $(`#${strDivId}`);
        //    CheckControlExist(strDivId, "select", strSelectId);
        //    objDiv.find(`#${strSelectId} option:selected`).val(strValue);
        //}
        //    /**
        //* 获取在层下Select控件的值
        // * @param strDivId : 层Id
        // * @param strSelectId 下拉框Id
        // * @returns 字符型
        //**/
        //    public static GetSelectValueInDiv(strDivId: string, strSelectId:string): string {
        //        const objDiv = $(`#${strDivId}`);
        //        CheckControlExist(strDivId, "select", strSelectId);
        //        const strValue = objDiv.find(`#${strSelectId} option:selected`).val();
        //        return strValue;
        //    }
        //    public static GetInputValueInDiv(strDivId: string, strInputId: string): string {
        //        const objDiv = $(`#${strDivId}`);
        //        CheckControlExist(strDivId, "input", strInputId);
        //        const strValue = objDiv.find(`#${strInputId}`).val();
        //        return strValue;
        //    }
        //    public static GetButtonHtmlInDiv(strDivId: string, strButtonId: string): string {
        //        const objDiv = $(`#${strDivId}`);
        //        CheckControlExist(strDivId, "button", strButtonId);
        //        const strValue = objDiv.find(`#${strButtonId}`).html();
        //        return strValue;
        //    }
        static BindEvent_Select(strSelectId, strEventName, func) {
            const objSelect = document.getElementById(strSelectId);
            if (strEventName == "onchange") {
                objSelect.onchange = (function () {
                    //alert("inner objSelect.onchange");
                    func.call(this);
                });
            }
        }
        static BindEvent_Input(strInputId, strEventName, func) {
            const objInput = document.getElementById(strInputId);
            if (strEventName == "onblur") {
                objInput.onblur = (function () {
                    //alert("inner objSelect.onchange");
                    func.call(this);
                });
            }
        }
        //js获取网站根路径(站点及虚拟目录)，获得网站的根目录或虚拟目录的根地址     
        static getRootPath() {
            const strFullPath = document.location.href;
            const strPath = document.location.pathname;
            const pos = strFullPath.indexOf(strPath);
            const prePath = strFullPath.substring(0, pos);
            const postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
            return (prePath + postPath);
        }
        /*
        * 重新转向本项目新的Url地址
        */
        static Redirect(LocUrl) {
            const strWebRoot = this.getRootPath();
            //console.log(strWebRoot);
            if (strWebRoot.indexOf("http://") >= 0 || strWebRoot.indexOf("https://") >= 0) {
                let strShortUrl = "";
                if (LocUrl.substr(0, 1) == "/") {
                    strShortUrl = strWebRoot + LocUrl;
                }
                else {
                    strShortUrl = strWebRoot + "/" + LocUrl;
                }
                //显示信息框
                //console.log(strShortUrl);
                window.location.href = strShortUrl;
                return;
            }
            const strProtocol = location.protocol;
            const strHost = location.host;
            const strPathName = location.pathname;
            let strShortUrl = `/${strWebRoot}/${LocUrl}`;
            strShortUrl = strShortUrl.replace("//", "/");
            strShortUrl = strShortUrl.replace("//", "/");
            //显示信息框
            const strNewLink = `${strProtocol}//${strHost}${strShortUrl}`;
            console.log(strNewLink);
            window.location.href = strNewLink;
        }
        /*
       * 绑定下拉框
       */
        static BindDdl_ObjLstWithSet(strDdlName, arrObjLst, strTabCnName) {
            const sltDdl = document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            const strText = "选" + strTabCnName + "...";
            //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
            //objArrayItem.text = strText;
            //objArrayItem.value = "0";
            //sltDdl.options.add(objArrayItem);
            sltDdl.options.add(new Option(strText, "0"));
            const i = 0;
            arrObjLst.forEach(function (element, index, array) {
                // element: 指向当前元素的值
                // index: 指向当前索引
                // array: 指向Array对象本身
                //alert(element);
                sltDdl.options.add(new Option(element, element));
            });
        }
        /*
       * 绑定下拉框
       */
        static BindDdl_ObjLstV2(sltDdl, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            const strText = strTabCnName;
            //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
            //objArrayItem.text = strText;
            //objArrayItem.value = "0";
            //sltDdl.options.add(objArrayItem);
            sltDdl.options.add(new Option(strText, "0"));
            let i = 0;
            for (i = 0; i < arrObjLst.length; i++) {
                const objCurr = arrObjLst[i];
                sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
            }
        }
        /*
         * 获取对象的所有属性名列表
         */
        static GetObjKeys(myObj) {
            const sstrKeys = [];
            for (const p1 in myObj) {
                if (Object.prototype.hasOwnProperty.call(myObj, p1))
                    sstrKeys.push(p1);
            }
            return sstrKeys;
        }
        // public static GetObjValueOfKeyBak(myObj: object, key: string): string {
        //     //const bb = myObj[key];
        //     //const aa = Object.prototype.valueOf.(myObj);//..valueOf()[key];
        //     //if (aa == null) return "";
        //     //else {
        //     //    const bb = aa[key];
        //     //}
        //     let { keys, values, entries } = Object;
        //     const arrValues = Object.values(myObj);
        //     const arrKeys = Object.keys(myObj);
        //     for (let i = 0; i < arrKeys.length; i++) {
        //         if (arrKeys[i] == key) return arrValues[i];
        //     }
        //     return "";
        // }
        /*
        * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个老版本(V2)
        */
        static BindTabBak(divContainer, arrObjLst, sstrFldName, sstrColHeader, strKey) {
            //const o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //const sstrFldName: Array<string> = new Array<string>();
            //const sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("identityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("identityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("memo"); sstrColHeader.push("备注");
            const table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            const tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            const intRowNum = arrObjLst.length;
            const intColNum = sstrFldName.length;
            const trHead = document.createElement("tr");
            trHead.className = "row-height";
            const td00 = document.createElement("td");
            const check00 = document.createElement("input");
            check00.type = "checkbox";
            check00.id = `chkTabHead`;
            check00.name = "chkTabHead";
            check00.className = "CheckInTab";
            check00.onclick = (function () {
                SetAllCkechedKeys(divContainer);
            });
            td00.appendChild(check00);
            trHead.appendChild(td00);
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.id = (0, clsString_js_1.Format)("td{0}", sstrFldName[j]);
                const a1 = document.createElement("a");
                a1.nodeValue = sstrColHeader[j]; //i + "" + j;
                a1.text = sstrColHeader[j]; //i + "" + j;
                a1.href = `javascript:sortBy('${sstrFldName[j]}');`;
                //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                td.appendChild(a1);
                //td.appendChild(document.createTextNode(i + "" + j));
                //td.style.color = "#FF0000";
                td.className = "text-center";
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (let i = 0; i < intRowNum; i++) {
                const objEN = arrObjLst[i];
                const tr = document.createElement("tr");
                tr.className = "row-height";
                const td0 = document.createElement("td");
                const check = document.createElement("input");
                check.type = "checkbox";
                const strKeyValue = objEN.GetFldValue(strKey);
                check.id = `chk${strKeyValue}`;
                check.name = "chkInTab";
                check.className = "CheckInTab";
                td0.appendChild(check);
                tr.appendChild(td0);
                for (let j = 0; j < intColNum; j++) {
                    const td = document.createElement("td");
                    //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                    td.id = (0, clsString_js_1.Format)("td{0}", sstrFldName[j]);
                    td.innerHTML = objEN.GetFldValue(sstrFldName[j]); //i + "" + j;
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
        }
        /*
         * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V2)
         */
        static BindTab(divContainer, arrObjLst, arrDataColumn, strKey) {
            //const o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //const sstrFldName: Array<string> = new Array<string>();
            //const sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("identityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("identityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("memo"); sstrColHeader.push("备注");
            const table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            const tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            const intRowNum = arrObjLst.length;
            const intColNum = arrDataColumn.length;
            const trHead = document.createElement("tr");
            trHead.className = "row-height";
            let check00;
            let a1;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = `chkTabHead`;
                        check00.name = "chkTabHead";
                        check00.className = "CheckInTab";
                        check00.onclick = (function () {
                            SetAllCkechedKeys(divContainer);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                        a1 = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.href = `javascript:sortBy('${arrDataColumn[j].sortBy}');`;
                        //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        break;
                    case "Button":
                        try {
                            const span1 = document.createElement("span");
                            //console.log(arrDataColumn[j].colHeader);
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.href = `javascript:sortBy('${arrDataColumn[j].fldName}');`;
                            //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (let i = 0; i < intRowNum; i++) {
                const objEN = arrObjLst[i];
                const strKeyValue = objEN.GetFldValue(strKey);
                const tr = document.createElement("tr");
                tr.className = "row-height";
                tr.id = `tr${strKeyValue}`;
                let check;
                for (let j = 0; j < intColNum; j++) {
                    const td = document.createElement("td");
                    td.className = arrDataColumn[j].tdClass;
                    switch (arrDataColumn[j].columnType) {
                        case "CheckBox":
                            check = document.createElement("input");
                            check.type = "checkbox";
                            check.id = `chk${strKeyValue}`;
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            if ((0, clsString_js_1.IsNullOrEmpty)(objEN.GetFldValue("CtrlId")) == false) {
                                check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                            }
                            td.appendChild(check);
                            break;
                        case "Label":
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const btn1 = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                                td.appendChild(btn1);
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                                const btn1 = arrDataColumn[j].funcName(strKeyValue, strText);
                                td.appendChild(btn1);
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
        }
        /*
        * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V3)
        */
        static BindTabV3(divContainer, arrObjLst, arrDataColumn, strKey, objOperateList) {
            //const o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //const sstrFldName: Array<string> = new Array<string>();
            //const sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("identityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("identityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("memo"); sstrColHeader.push("备注");
            const table = document.createElement("table");
            table.id = "tab4Bind";
            table.className = "table table-striped table-condensed table-bordered";
            const tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            const intRowNum = arrObjLst.length;
            const intColNum = arrDataColumn.length;
            const trHead = document.createElement("tr");
            trHead.className = "row-height";
            let check00;
            let strSortExpress;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.id = (0, clsString_js_1.Format)("td{0}", arrDataColumn[j].fldName);
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = `chkTabHead`;
                        check00.name = "chkTabHead";
                        check00.className = "CheckInTab";
                        check00.onclick = (function () {
                            SetAllCkechedKeysV2(divContainer, this);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                        strSortExpress = arrDataColumn[j].sortBy;
                        if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                        else {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.setAttribute("fldName", strSortExpress);
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
                            const span1 = document.createElement("span");
                            //console.log(arrDataColumn[j].colHeader);
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.href = `javascript:sortBy('${arrDataColumn[j].fldName}');`;
                            //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
                            td.appendChild(a1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (let i = 0; i < intRowNum; i++) {
                const objEN = arrObjLst[i];
                const strKeyValue = objEN.GetFldValue(strKey);
                const tr = document.createElement("tr");
                tr.className = "row-height";
                tr.id = `tr${strKeyValue}`;
                let check;
                for (let j = 0; j < intColNum; j++) {
                    const td = document.createElement("td");
                    td.className = arrDataColumn[j].tdClass;
                    switch (arrDataColumn[j].columnType) {
                        case "CheckBox":
                            check = document.createElement("input");
                            check.type = "checkbox";
                            check.id = `chk${strKeyValue}`;
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            if ((0, clsString_js_1.IsNullOrEmpty)(objEN.GetFldValue("CtrlId")) == false) {
                                check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                            }
                            td.appendChild(check);
                            break;
                        case "Label":
                            if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                                td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                                if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                    td.className = "text-center";
                                }
                            }
                            else {
                                //调用外面的函数生成一个层放在该单元格中
                                const div1 = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                                if (div1 != null) {
                                    td.appendChild(div1);
                                }
                            }
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const btn1 = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                                td.appendChild(btn1);
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                                const btn1 = arrDataColumn[j].funcName(strKeyValue, strText);
                                td.appendChild(btn1);
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
        }
        static async BindTabV4(divContainer, arrObjLst, arrDataColumn, strKey, objOperateList) {
            //const o = document.getElementById("divResult13");
            //if (o == null) {
            //    alert("divResult13不存在！");
            //    return;
            //}
            //const sstrFldName: Array<string> = new Array<string>();
            //const sstrColHeader: Array<string> = new Array<string>();
            //sstrFldName.push("identityID"); sstrColHeader.push("身份Id");
            //sstrFldName.push("identityDesc"); sstrColHeader.push("身份名");
            //sstrFldName.push("memo"); sstrColHeader.push("备注");
            const table = document.createElement("table");
            table.id = "tab4Bind";
            if (objOperateList.bolIsTableSm == true) {
                table.className = "table table-striped table-condensed table-bordered table-sm";
            }
            else {
                table.className = "table table-striped table-condensed table-bordered";
            }
            const tbody = document.createElement("tbody");
            //table.width = intWidth;
            //table.height = h;
            //table.border = 1;
            //table.height = h;
            table.border = "1";
            const intRowNum = arrObjLst.length;
            const intColNum = arrDataColumn.length;
            const trHead = document.createElement("tr");
            trHead.className = "row-height";
            let check00;
            let strSortExpress;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.id = (0, clsString_js_1.Format)("td{0}", arrDataColumn[j].fldName);
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check00 = document.createElement("input");
                        check00.type = "checkbox";
                        check00.id = `chkTabHead`;
                        check00.name = "chkTabHead";
                        check00.className = "CheckInTab";
                        check00.onclick = (function () {
                            SetAllCkechedKeysV2(divContainer, this);
                        });
                        td.appendChild(check00);
                        break;
                    case "Label":
                    case "LabelOrDiv":
                    case "Label4Bool":
                    case "a":
                        strSortExpress = arrDataColumn[j].sortBy;
                        if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            //console.error(arrDataColumn[j].sortFun);
                            if (arrDataColumn[j].sortFun.name != "sortFun") {
                                const a2 = document.createElement("a");
                                a2.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                                a2.text = arrDataColumn[j].colHeader; //i + "" + j;
                                a2.setAttribute("fldName", strSortExpress);
                                a2.href = 'javascript:';
                                (function (sortFun1) {
                                    a2.onclick = (function () {
                                        objOperateList.SortBy(sortFun1);
                                    });
                                })(arrDataColumn[j].sortFun);
                                td.appendChild(a2);
                            }
                            else {
                                const span1 = document.createElement("span");
                                span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                                span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                                td.appendChild(span1);
                            }
                        }
                        else {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.setAttribute("fldName", strSortExpress);
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
                            const span1 = document.createElement("span");
                            //console.log(arrDataColumn[j].colHeader);
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                            td.appendChild(span1);
                            //td.appendChild(document.createTextNode(i + "" + j));
                            //td.style.color = "#FF0000";
                            td.className = "text-center";
                        }
                        catch (e) {
                            const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            const strSortExpress = arrDataColumn[j].sortBy;
                            if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                                const span1 = document.createElement("span");
                                span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                                span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                                td.appendChild(span1);
                            }
                            else {
                                const a1 = document.createElement("a");
                                a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                                a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                                a1.setAttribute("fldName", strSortExpress);
                                a1.href = 'javascript:';
                                a1.onclick = (function () {
                                    objOperateList.SortBy(this);
                                });
                                td.appendChild(a1);
                            }
                            td.className = "text-center";
                        }
                        catch (e) {
                            const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                            throw (strMsg);
                        }
                        break;
                }
                trHead.appendChild(td);
            }
            tbody.appendChild(trHead);
            for (let i = 0; i < intRowNum; i++) {
                const objEN = arrObjLst[i];
                const strKeyValue = objEN.GetFldValue(strKey);
                const tr = document.createElement("tr");
                tr.className = "row-height";
                tr.id = `tr${strKeyValue}`;
                let check;
                let div1;
                for (let j = 0; j < intColNum; j++) {
                    const td = document.createElement("td");
                    td.className = arrDataColumn[j].tdClass;
                    td.id = `td${strKeyValue}_${arrDataColumn[j].fldName}`;
                    switch (arrDataColumn[j].columnType) {
                        case "CheckBox":
                            check = document.createElement("input");
                            check.type = "checkbox";
                            check.id = `chk${strKeyValue}`;
                            check.name = "chkInTab";
                            check.className = "CheckInTab";
                            //if (IsNullOrEmpty(objEN.GetFldValue("CtrlId")) == false) {
                            //    check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                            //}
                            td.appendChild(check);
                            break;
                        case "Label":
                            if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                                td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                                if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                    td.className = "text-center";
                                }
                            }
                            else {
                                //调用外面的函数生成一个层放在该单元格中
                                const div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                                if (div1 != null) {
                                    td.appendChild(div1);
                                }
                            }
                            tr.appendChild(td);
                            break;
                        case "LabelOrDiv":
                            div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            if (div1.innerHTML == "") {
                                td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                                if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                    td.className = "text-center";
                                }
                            }
                            else {
                                td.appendChild(div1);
                            }
                            tr.appendChild(td);
                            break;
                        case "Label4Bool":
                            if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                                const bolFldValue = objEN.GetFldValue(arrDataColumn[j].fldName);
                                if (bolFldValue == true) {
                                    const spnBoolTrue = GetSpan4BoolTrue();
                                    td.appendChild(spnBoolTrue);
                                }
                                else {
                                    const spnBoolFalse = GetSpan4BoolFalse();
                                    td.appendChild(spnBoolFalse);
                                }
                                if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                    td.className = "text-center";
                                }
                            }
                            else {
                                //调用外面的函数生成一个层放在该单元格中
                                const div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                                if (div1 != null) {
                                    td.appendChild(div1);
                                }
                            }
                            tr.appendChild(td);
                            break;
                        case "Button":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const btn1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                                td.appendChild(btn1);
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                                throw (strMsg);
                            }
                            break;
                        case "LinkButton":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                                const btn1 = await arrDataColumn[j].funcName(strKeyValue, strText);
                                td.appendChild(btn1);
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                                throw (strMsg);
                            }
                            break;
                        case "a":
                            try {
                                const strKeyValue = objEN.GetFldValue(strKey);
                                const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                                const objA = await arrDataColumn[j].funcName(strKeyValue, strText);
                                if (objA != null) {
                                    td.appendChild(objA);
                                }
                                //const btn1: HTMLButtonElement = document.createElement("Button");
                                //btn1.innerText = arrDataColumn[j].text;
                                //btn1.className = "btn btn-outline-info";
                                //td.appendChild(btn1);
                                ////td.appendChild(document.createTextNode(i + "" + j));
                                ////td.style.color = "#FF0000";
                                //td.className = "text-center";
                            }
                            catch (e) {
                                console.error(e);
                                const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
        }
        /*
         * 根据列表的左上角的复选框值，全选或全不选列表中所有复选框
         */
        static SetAllCkechedKeys(tabName, thisChk) {
            const arrKeys = tabName.getElementsByClassName('CheckInTab');
            //const thisChk = EventTarget;//
            //const thisChk: HTMLInputElement = e.target as HTMLInputElement;  tabName.getElementsByClassName;// EventTarget as HTMLInputElement;
            const bolIsCheck = thisChk.checked;
            console.log(bolIsCheck);
            const arrKeyLst = this.GetArray(arrKeys);
            arrKeyLst.forEach((e) => e.checked = bolIsCheck);
            alert(arrKeys.length.toString());
        }
        /*
         * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
         */
        static GetArray(arr) {
            const arrLst = new Array();
            for (let i = 0; i < arr.length; i++) {
                const chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
        static Test1() {
            return "Test1";
        }
        static CheckControlExist(divName, strControlType, strControlId) {
            if ((0, clsString_js_1.IsNullOrEmpty)(strControlType) == true) {
                const strMsg = (0, clsString_js_1.Format)("在层:{0}中查找控件:[{1}]时, 类型不能为空！", divName, strControlId);
                console.error(strMsg);
                throw (strMsg);
            }
            const objDiv = $(`#${divName}`);
            if (objDiv.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("层:{0}不存在, 请检查！", divName);
                console.error(strMsg);
                throw (strMsg);
            }
            const strId = `${strControlType}[id ^= "${strControlId}"]`;
            const objControl = objDiv.find(strId);
            if (objControl.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
                console.error(strMsg);
                throw (strMsg);
            }
            //}
            //else {
            //    const objDiv1 = document.getElementById(divName);
            //    if (objDiv1 == null) {
            //        const strMsg = Format("层:{0}不存在, 请检查！", divName);
            //        console.error(strMsg);
            //        throw (strMsg);
            //    }
            //    const arrElements0 = objDiv1.childNodes;
            //    const arrElements = this.GetArray(arrElements0);
            //    const objElement: HTMLElement = <HTMLElement>arrElements.find(x => x.id == strControlId);
            //    if (objElement == null) {
            //        const strMsg = Format("在层:[{0}]内，不存在Id:[{1}]的元素, 请检查！", divName, strControlId);
            //        console.error(strMsg);
            //        throw (strMsg);
            //    }
            //}
        }
        /*
      * 绑定下拉框
      */
        static BindDdl_ObjLstWithSetInDiv(strDivName, strDdlName, arrObjLst, strTabCnName) {
            let sltDdl = document.getElementById(strDdlName);
            const objDiv = document.getElementById(strDivName);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
                console.error(strMsg);
                throw (strMsg);
            }
            else {
                const arrSelect = objDiv.getElementsByTagName("select");
                const arrElements = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrSelect);
                sltDdl = arrElements.find(x => x.id == strDdlName);
                if (sltDdl == null) {
                    const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
                    console.error(strMsg);
                    sltDdl = document.getElementById(strDdlName);
                }
            }
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在界面内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
                console.error(strMsg);
                throw (strMsg);
            }
            sltDdl.options.length = 0;
            const strText = "选" + strTabCnName + "...";
            sltDdl.options.add(new Option(strText, "0"));
            const i = 0;
            arrObjLst.forEach(function (element, index, array) {
                // element: 指向当前元素的值
                // index: 指向当前索引
                // array: 指向Array对象本身
                //alert(element);
                sltDdl.options.add(new Option(element, element));
            });
        }
        /*
         * 确认删除函数
         */
        static confirm_del(intCount) {
            let strMsg = (0, clsString_js_1.Format)("你真的确定要删除记录吗?");
            if (intCount > 0) {
                strMsg = (0, clsString_js_1.Format)("你真的确定要删除{0}条记录吗?", intCount);
            }
            const gnl = confirm(strMsg);
            if (gnl == true) {
                return true;
            }
            else {
                return false;
            }
        }
    }
    exports.clsCommFunc4WebBak = clsCommFunc4WebBak;
    /*
     * 专门针对有多个关键字段的表的绑定
     */
    async function BindTab_KeyLst(divContainer, arrObjLst, arrDataColumn, arrKeyLst, objOperateList) {
        const table = document.createElement("table");
        table.id = "tab4Bind";
        if (objOperateList.bolIsTableSm == true) {
            table.className = "table table-striped table-condensed table-bordered table-sm";
        }
        else {
            table.className = "table table-striped table-condensed table-bordered";
        }
        const tbody = document.createElement("tbody");
        //table.width = intWidth;
        //table.height = h;
        //table.border = 1;
        //table.height = h;
        table.border = "1";
        const intRowNum = arrObjLst.length;
        const intColNum = arrDataColumn.length;
        const trHead = document.createElement("tr");
        trHead.className = "row-height";
        let check00;
        let strSortExpress;
        for (let j = 0; j < intColNum; j++) {
            const td = document.createElement("td");
            td.id = (0, clsString_js_1.Format)("td{0}", arrDataColumn[j].fldName);
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkTabHead`;
                    check00.name = "chkTabHead";
                    check00.className = "CheckInTab";
                    check00.onclick = (function () {
                        SetAllCkechedKeysV2(divContainer, this);
                    });
                    td.appendChild(check00);
                    break;
                case "Label":
                case "LabelOrDiv":
                case "Label4Bool":
                case "a":
                    strSortExpress = arrDataColumn[j].sortBy;
                    if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                        //console.error(arrDataColumn[j].sortFun);
                        if (arrDataColumn[j].sortFun.name != "sortFun") {
                            const a2 = document.createElement("a");
                            a2.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a2.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a2.setAttribute("fldName", strSortExpress);
                            a2.href = 'javascript:';
                            (function (sortFun1) {
                                a2.onclick = (function () {
                                    objOperateList.SortBy(sortFun1);
                                });
                            })(arrDataColumn[j].sortFun);
                            td.appendChild(a2);
                        }
                        else {
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                    }
                    else {
                        const a1 = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.setAttribute("fldName", strSortExpress);
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
                        const span1 = document.createElement("span");
                        //console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                        //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        const strSortExpress = arrDataColumn[j].sortBy;
                        if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                        else {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.setAttribute("fldName", strSortExpress);
                            a1.href = 'javascript:';
                            a1.onclick = (function () {
                                objOperateList.SortBy(this);
                            });
                            td.appendChild(a1);
                        }
                        td.className = "text-center";
                    }
                    catch (e) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {
            const objEN = arrObjLst[i];
            let strKeyValue_Lst = "";
            let strKeyValue_Lst_Id = "";
            let bolIsError_Key = false;
            let intIndex = 0;
            for (const strKey of arrKeyLst) {
                const strTemp = objEN.GetFldValue(strKey);
                if ((0, clsString_js_1.IsNullOrEmpty)(strTemp) == true) {
                    bolIsError_Key = true;
                }
                if (intIndex == 0) {
                    strKeyValue_Lst = strTemp;
                    strKeyValue_Lst_Id = strTemp;
                }
                else {
                    strKeyValue_Lst += (0, clsString_js_1.Format)("|{0}", strTemp);
                    strKeyValue_Lst_Id += (0, clsString_js_1.Format)("_{0}", strTemp);
                }
                intIndex++;
            }
            const tr = document.createElement("tr");
            tr.className = "row-height";
            tr.id = `tr${strKeyValue_Lst_Id}`;
            let check;
            let div1;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.className = arrDataColumn[j].tdClass;
                td.id = `td${strKeyValue_Lst_Id}_${arrDataColumn[j].fldName}`;
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check = document.createElement("input");
                        check.type = "checkbox";
                        check.id = `chk${strKeyValue_Lst_Id}`;
                        check.setAttribute("keyValueLst", strKeyValue_Lst);
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        //if (IsNullOrEmpty(objEN.GetFldValue("CtrlId")) == false) {
                        //    check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                        //}
                        td.appendChild(check);
                        break;
                    case "Label":
                        if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1 = await arrDataColumn[j].funcName(strKeyValue_Lst, arrDataColumn[j].text);
                            if (div1 != null) {
                                td.appendChild(div1);
                            }
                        }
                        tr.appendChild(td);
                        break;
                    case "LabelOrDiv":
                        div1 = await arrDataColumn[j].funcName(strKeyValue_Lst, arrDataColumn[j].text);
                        if (div1.innerHTML == "") {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "Label4Bool":
                        if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                            const bolFldValue = objEN.GetFldValue(arrDataColumn[j].fldName);
                            if (bolFldValue == true) {
                                const spnBoolTrue = GetSpan4BoolTrue();
                                td.appendChild(spnBoolTrue);
                            }
                            else {
                                const spnBoolFalse = GetSpan4BoolFalse();
                                td.appendChild(spnBoolFalse);
                            }
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1 = await arrDataColumn[j].funcName(strKeyValue_Lst, arrDataColumn[j].text);
                            if (div1 != null) {
                                td.appendChild(div1);
                            }
                        }
                        tr.appendChild(td);
                        break;
                    case "Button":
                        try {
                            //const strKeyValue = objEN.GetFldValue(strKey);
                            const btn1 = await arrDataColumn[j].funcName(strKeyValue_Lst, arrDataColumn[j].text);
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            //const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const btn1 = await arrDataColumn[j].funcName(strKeyValue_Lst, strText);
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "a":
                        try {
                            //const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const objA = await arrDataColumn[j].funcName(strKeyValue_Lst, strText);
                            if (objA != null) {
                                td.appendChild(objA);
                            }
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
    }
    exports.BindTab_KeyLst = BindTab_KeyLst;
    async function BindTab(divContainer, arrObjLst, arrDataColumn, strKey, objOperateList) {
        const table = document.createElement("table");
        table.id = "tab4Bind";
        if (objOperateList.bolIsTableSm == true) {
            table.className = "table table-striped table-condensed table-bordered table-sm";
        }
        else {
            table.className = "table table-striped table-condensed table-bordered";
        }
        const tbody = document.createElement("tbody");
        //table.width = intWidth;
        //table.height = h;
        //table.border = 1;
        //table.height = h;
        table.border = "1";
        const intRowNum = arrObjLst.length;
        const intColNum = arrDataColumn.length;
        const trHead = document.createElement("tr");
        trHead.className = "row-height";
        let check00;
        let strSortExpress;
        for (let j = 0; j < intColNum; j++) {
            const td = document.createElement("td");
            td.id = (0, clsString_js_1.Format)("td{0}", arrDataColumn[j].fldName);
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkTabHead`;
                    check00.name = "chkTabHead";
                    check00.className = "CheckInTab";
                    check00.onclick = (function () {
                        SetAllCkechedKeysV2(divContainer, this);
                    });
                    td.appendChild(check00);
                    break;
                case "Label":
                case "LabelOrDiv":
                case "Label4Bool":
                case "a":
                    strSortExpress = arrDataColumn[j].sortBy;
                    if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                        //console.error(arrDataColumn[j].sortFun);
                        if (arrDataColumn[j].sortFun.name != "sortFun") {
                            const a2 = document.createElement("a");
                            a2.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a2.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a2.setAttribute("fldName", strSortExpress);
                            a2.href = 'javascript:';
                            (function (sortFun1) {
                                a2.onclick = (function () {
                                    objOperateList.SortBy(sortFun1);
                                });
                            })(arrDataColumn[j].sortFun);
                            td.appendChild(a2);
                        }
                        else {
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                    }
                    else {
                        const a1 = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.setAttribute("fldName", strSortExpress);
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
                        const span1 = document.createElement("span");
                        //console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                        //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        const strSortExpress = arrDataColumn[j].sortBy;
                        if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                        else {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.setAttribute("fldName", strSortExpress);
                            a1.href = 'javascript:';
                            a1.onclick = (function () {
                                objOperateList.SortBy(this);
                            });
                            td.appendChild(a1);
                        }
                        td.className = "text-center";
                    }
                    catch (e) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {
            const objEN = arrObjLst[i];
            const strKeyValue = objEN.GetFldValue(strKey);
            const tr = document.createElement("tr");
            tr.className = "row-height";
            tr.id = `tr${strKeyValue}`;
            let check;
            let div1;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.className = arrDataColumn[j].tdClass;
                td.id = `td${strKeyValue}_${arrDataColumn[j].fldName}`;
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check = document.createElement("input");
                        check.type = "checkbox";
                        check.id = `chk${strKeyValue}`;
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        //if (IsNullOrEmpty(objEN.GetFldValue("CtrlId")) == false) {
                        //    check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                        //}
                        td.appendChild(check);
                        break;
                    case "Label":
                        if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            if (div1 != null) {
                                td.appendChild(div1);
                            }
                        }
                        tr.appendChild(td);
                        break;
                    case "LabelOrDiv":
                        div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                        if (div1.innerHTML == "") {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "Label4Bool":
                        if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                            const bolFldValue = objEN.GetFldValue(arrDataColumn[j].fldName);
                            if (bolFldValue == true) {
                                const spnBoolTrue = GetSpan4BoolTrue();
                                td.appendChild(spnBoolTrue);
                            }
                            else {
                                const spnBoolFalse = GetSpan4BoolFalse();
                                td.appendChild(spnBoolFalse);
                            }
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            if (div1 != null) {
                                td.appendChild(div1);
                            }
                        }
                        tr.appendChild(td);
                        break;
                    case "Button":
                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const btn1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const btn1 = await arrDataColumn[j].funcName(strKeyValue, strText);
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "a":
                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const objA = await arrDataColumn[j].funcName(strKeyValue, strText);
                            if (objA != null) {
                                td.appendChild(objA);
                            }
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
    }
    exports.BindTab = BindTab;
    async function BindTab_V(divContainer, arrObjLst, arrDataColumn, strKey, objOperateList) {
        const table = document.createElement("table");
        table.id = "tab4Bind";
        if (objOperateList.bolIsTableSm == true) {
            table.className = "table table-striped table-condensed table-bordered table-sm";
        }
        else {
            table.className = "table table-striped table-condensed table-bordered";
        }
        const tbody = document.createElement("tbody");
        //table.width = intWidth;
        //table.height = h;
        //table.border = 1;
        //table.height = h;
        table.border = "1";
        const intRowNum = arrObjLst.length;
        const intColNum = arrDataColumn.length;
        const trHead = document.createElement("tr");
        trHead.className = "row-height";
        let check00;
        let strSortExpress;
        for (let j = 0; j < intColNum; j++) {
            const td = document.createElement("td");
            td.id = (0, clsString_js_1.Format)("td{0}", arrDataColumn[j].fldName);
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkTabHead`;
                    check00.name = "chkTabHead";
                    check00.className = "CheckInTab";
                    check00.onclick = (function () {
                        SetAllCkechedKeysV2(divContainer, this);
                    });
                    td.appendChild(check00);
                    break;
                case "Label":
                case "LabelOrDiv":
                case "Label4Bool":
                case "a":
                    strSortExpress = arrDataColumn[j].sortBy;
                    if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                        //console.error(arrDataColumn[j].sortFun);
                        if (arrDataColumn[j].sortFun.name != "sortFun") {
                            const a2 = document.createElement("a");
                            a2.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a2.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a2.setAttribute("fldName", strSortExpress);
                            a2.href = 'javascript:';
                            (function (sortFun1) {
                                a2.onclick = (function () {
                                    objOperateList.SortBy(sortFun1);
                                });
                            })(arrDataColumn[j].sortFun);
                            td.appendChild(a2);
                        }
                        else {
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                    }
                    else {
                        const a1 = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                        a1.setAttribute("fldName", strSortExpress);
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
                        const span1 = document.createElement("span");
                        //console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                        //                td.innerHTML = objEN["identityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        const strSortExpress = arrDataColumn[j].sortBy;
                        if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == true) { //如果没有排序字段，就不用超链接A
                            const span1 = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                            td.appendChild(span1);
                        }
                        else {
                            const a1 = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                            a1.setAttribute("fldName", strSortExpress);
                            a1.href = 'javascript:';
                            a1.onclick = (function () {
                                objOperateList.SortBy(this);
                            });
                            td.appendChild(a1);
                        }
                        td.className = "text-center";
                    }
                    catch (e) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {
            const objEN = arrObjLst[i];
            const strKeyValue = objEN.GetFldValue(strKey);
            const tr = document.createElement("tr");
            tr.className = "row-height";
            tr.id = `tr${strKeyValue}`;
            let check;
            let div1;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.className = arrDataColumn[j].tdClass;
                td.id = `td${strKeyValue}_${arrDataColumn[j].fldName}`;
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check = document.createElement("input");
                        check.type = "checkbox";
                        check.id = `chk${strKeyValue}`;
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        //if (IsNullOrEmpty(objEN.GetFldValue("CtrlId")) == false) {
                        //    check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                        //}
                        td.appendChild(check);
                        break;
                    case "Label":
                        if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            if (div1 != null) {
                                td.appendChild(div1);
                            }
                        }
                        tr.appendChild(td);
                        break;
                    case "LabelOrDiv":
                        div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                        if (div1.innerHTML == "") {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "Label4Bool":
                        if ((0, clsString_js_1.IsNullOrEmpty)(arrDataColumn[j].fldName) == false) {
                            const bolFldValue = objEN.GetFldValue(arrDataColumn[j].fldName);
                            if (bolFldValue == true) {
                                const spnBoolTrue = GetSpan4BoolTrue();
                                td.appendChild(spnBoolTrue);
                            }
                            else {
                                const spnBoolFalse = GetSpan4BoolFalse();
                                td.appendChild(spnBoolFalse);
                            }
                            if ((0, clsString_js_1.IsNullOrEmpty)(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            if (div1 != null) {
                                td.appendChild(div1);
                            }
                        }
                        tr.appendChild(td);
                        break;
                    case "Button":
                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const btn1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":
                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const btn1 = await arrDataColumn[j].funcName(strKeyValue, strText);
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "a":
                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const objA = await arrDataColumn[j].funcName(strKeyValue, strText);
                            if (objA != null) {
                                td.appendChild(objA);
                            }
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
    }
    exports.BindTab_V = BindTab_V;
    /**
     * 隐藏对话框
     **/
    function HideDialog(strDialogName) {
        console.log("隐藏对话框" + strDialogName);
        //$(strDialogName).modal('hide');
    }
    exports.HideDialog = HideDialog;
    /**
     * 显示对话框
    **/
    function ShowDialog(strDialogName) {
        console.log("显示对话框" + strDialogName);
        //$(strDialogName).modal('show');
    }
    exports.ShowDialog = ShowDialog;
    /**
    * 隐藏表格行 (tr))
    **/
    function HideTr(strDivName, strTr) {
        const objTr = (0, clsCommFunc4Ctrl_js_1.getTrObjByIdInDiv)(strDivName, strTr);
        objTr.style.visibility = "hidden";
        objTr.style.display = "none";
    }
    exports.HideTr = HideTr;
    function HideTd(strDivName, strTd) {
        const objTd = (0, clsCommFunc4Ctrl_js_1.getTdObjByIdInDiv)(strDivName, strTd);
        objTd.style.visibility = "hidden";
        objTd.style.display = "none";
    }
    exports.HideTd = HideTd;
    /**
    * 显示表格行 (tr))
    **/
    function ShowTr(strDivName, strTr) {
        const objTr = (0, clsCommFunc4Ctrl_js_1.getTrObjByIdInDiv)(strDivName, strTr);
        objTr.style.visibility = "visible";
        objTr.style.display = "table-row";
    }
    exports.ShowTr = ShowTr;
    function ShowDiv(strDivName) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        //objDiv4SelectFile.style.float = "center";
        //objDiv4SelectFile.style.border = "1px";
        objDiv.style.display = 'block';
        objDiv.style.visibility = "visible"; //显示
        //alert(objDiv4SelectFile);
    }
    exports.ShowDiv = ShowDiv;
    function HideDiv(strDivName) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        objDiv.style.display = 'none';
        objDiv.style.visibility = "hidden"; //隐藏  
        //alert(objDiv4SelectFile);
    }
    exports.HideDiv = HideDiv;
    function GetSpan4BoolFalse() {
        const objSpan = document.createElement("span");
        objSpan.classList.add("text-danger");
        objSpan.innerHTML = "×";
        return objSpan;
    }
    exports.GetSpan4BoolFalse = GetSpan4BoolFalse;
    function GetSpan4BoolTrue() {
        const objSpan = document.createElement("span");
        objSpan.classList.add("text-primary");
        objSpan.innerHTML = "√";
        return objSpan;
    }
    exports.GetSpan4BoolTrue = GetSpan4BoolTrue;
    /*
    * 获取对象的所有属性名列表
    */
    function ObjectAssign(myObjT, myObjS) {
        Object.assign(myObjT, myObjS);
        return true;
        //const objTypeName_S = myObjS.constructor.name;
        //const objTypeName_T = myObjT.constructor.name;
        //const sstrKeys_S: Array<string> = [];
        //if (objTypeName_S.endsWith("EN") == true) {
        //    const temp = myObjS.constructor.AttributeName;
        //    for (const strKey of temp) {
        //        sstrKeys_S.push(strKey);
        //    }
        //    sstrKeys_S.push("sf_UpdFldSetStr");
        //    sstrKeys_S.push("sf_FldComparisonOp");
        //}
        //else if (objTypeName_S.endsWith("ENEx") == true
        //    || objTypeName_S.indexOf("ENEx") > -1) {
        //    const temp = myObjS.constructor.AttributeName;
        //    for (const strKey of temp) {
        //        sstrKeys_S.push(strKey);
        //    }
        //    for (const p1 in myObjS) {
        //        if (Object.prototype.hasOwnProperty.call(myObjS, p1)) {
        //            if (sstrKeys_S.indexOf(p1) == -1) {
        //                sstrKeys_S.push(p1);
        //            }
        //        }
        //    }
        //    sstrKeys_S.push("sf_UpdFldSetStr");
        //    sstrKeys_S.push("sf_FldComparisonOp");
        //}
        //else {
        //    for (const p1 in myObjS) {
        //        if (Object.prototype.hasOwnProperty.call(myObjS, p1))
        //            sstrKeys_S.push(p1);
        //    }
        //}
        //const sstrKeys_T: Array<string> = [];
        //if (objTypeName_T.endsWith("EN") == true) {
        //    const temp = myObjT.constructor.AttributeName;
        //    for (const strKey of temp) {
        //        sstrKeys_T.push(strKey);
        //    }
        //    sstrKeys_T.push("sf_UpdFldSetStr");
        //    sstrKeys_T.push("sf_FldComparisonOp");
        //}
        //else if (objTypeName_T.endsWith("ENEx") == true || objTypeName_T.indexOf("ENEx") > -1) {
        //    const temp = myObjT.constructor.AttributeName;
        //    for (const strKey of temp) {
        //        sstrKeys_T.push(strKey);
        //    }
        //    for (const p1 in myObjT) {
        //        if (Object.prototype.hasOwnProperty.call(myObjT, p1)) {
        //            if (sstrKeys_T.indexOf(p1) == -1) {
        //                sstrKeys_T.push(p1);
        //            }
        //        }
        //    }
        //    sstrKeys_T.push("sf_UpdFldSetStr");
        //    sstrKeys_T.push("sf_FldComparisonOp");
        //}
        //else {
        //    for (const p1 in myObjT) {
        //        if (Object.prototype.hasOwnProperty.call(myObjT, p1))
        //            sstrKeys_T.push(p1);
        //    }
        //}
        ////for (const p1 in myObjT) {
        ////    if (Object.prototype.hasOwnProperty.call(myObjT, p1))
        ////        sstrKeys_T.push(p1);
        ////}
        //let value_S
        //for (const strKey of sstrKeys_S) {
        //    if (sstrKeys_T.indexOf(strKey) == -1) continue;
        //    if (objTypeName_S.endsWith("_Sim") == true) {
        //        value_S = myObjS[strKey];
        //    }
        //    else if (objTypeName_S.endsWith("EN") == true) {
        //        value_S = myObjS.GetFldValue(strKey);
        //    }
        //    else if (objTypeName_S.endsWith("ENEx") == true) {
        //        value_S = myObjS.GetFldValue(strKey);
        //    }
        //    else if (objTypeName_S.indexOf("ENEx") > -1) {
        //        value_S = myObjS.GetFldValue(strKey);
        //    }
        //    else {
        //        value_S = myObjS[strKey];
        //    }
        //    if (objTypeName_T.endsWith("_Sim") == true) {
        //        myObjT[strKey] = value_S;
        //    }
        //    else if (objTypeName_T.endsWith("EN") == true) {
        //        myObjT.SetFldValue(strKey, value_S);
        //    }
        //    else if (objTypeName_T.endsWith("ENEx") == true) {
        //        myObjT.SetFldValue(strKey, value_S);
        //    }
        //    else if (objTypeName_T.indexOf("ENEx") > -1) {
        //        myObjT.SetFldValue(strKey, value_S);
        //    }
        //    else {
        //        myObjT[strKey] = value_S
        //    }
        //}
        //return true;
    }
    exports.ObjectAssign = ObjectAssign;
    function ObjectAssignV2(myObjT, myObjS) {
        //Object.assign(myObjT, myObjS);
        //return true;
        const objTypeName_S = myObjS.constructor.name;
        const objTypeName_T = myObjT.constructor.name;
        const sstrKeys_S = [];
        if (objTypeName_S.endsWith("EN") == true) {
            const temp = myObjS.constructor.AttributeName;
            for (const strKey of temp) {
                sstrKeys_S.push(strKey);
            }
            sstrKeys_S.push("sf_UpdFldSetStr");
            sstrKeys_S.push("sf_FldComparisonOp");
        }
        else if (objTypeName_S.endsWith("ENEx") == true
            || objTypeName_S.indexOf("ENEx") > -1) {
            const temp = myObjS.constructor.AttributeName;
            for (const strKey of temp) {
                sstrKeys_S.push(strKey);
            }
            //for (const p1 in myObjS) {
            //    if (Object.prototype.hasOwnProperty.call(myObjS, p1)) {
            //        if (sstrKeys_S.indexOf(p1) == -1) {
            //            sstrKeys_S.push(p1);
            //        }
            //    }
            //}
            sstrKeys_S.push("sf_UpdFldSetStr");
            sstrKeys_S.push("sf_FldComparisonOp");
        }
        else {
            for (const p1 in myObjS) {
                if (Object.prototype.hasOwnProperty.call(myObjS, p1))
                    sstrKeys_S.push(p1);
            }
        }
        const sstrKeys_T = [];
        if (objTypeName_T.endsWith("EN") == true) {
            const temp = myObjT.constructor.AttributeName;
            for (const strKey of temp) {
                sstrKeys_T.push(strKey);
            }
            sstrKeys_T.push("sf_UpdFldSetStr");
            sstrKeys_T.push("sf_FldComparisonOp");
        }
        else if (objTypeName_T.endsWith("ENEx") == true || objTypeName_T.indexOf("ENEx") > -1) {
            const temp = myObjT.constructor.AttributeName;
            for (const strKey of temp) {
                sstrKeys_T.push(strKey);
            }
            //for (const p1 in myObjT) {
            //    if (Object.prototype.hasOwnProperty.call(myObjT, p1)) {
            //        if (sstrKeys_T.indexOf(p1) == -1) {
            //            sstrKeys_T.push(p1);
            //        }
            //    }
            //}
            sstrKeys_T.push("sf_UpdFldSetStr");
            sstrKeys_T.push("sf_FldComparisonOp");
        }
        else {
            for (const p1 in myObjT) {
                if (Object.prototype.hasOwnProperty.call(myObjT, p1))
                    sstrKeys_T.push(p1);
            }
        }
        //for (const p1 in myObjT) {
        //    if (Object.prototype.hasOwnProperty.call(myObjT, p1))
        //        sstrKeys_T.push(p1);
        //}
        let value_S;
        for (const strKey of sstrKeys_S) {
            if (sstrKeys_T.indexOf(strKey) == -1)
                continue;
            if (objTypeName_S.endsWith("_Sim") == true) {
                value_S = myObjS[strKey];
            }
            else if (objTypeName_S.endsWith("EN") == true) {
                value_S = myObjS.GetFldValue(strKey);
            }
            else if (objTypeName_S.endsWith("ENEx") == true) {
                value_S = myObjS.GetFldValue(strKey);
            }
            else if (objTypeName_S.indexOf("ENEx") > -1) {
                value_S = myObjS.GetFldValue(strKey);
            }
            else {
                value_S = myObjS[strKey];
            }
            if (objTypeName_T.endsWith("_Sim") == true) {
                myObjT[strKey] = value_S;
            }
            else if (objTypeName_T.endsWith("EN") == true) {
                myObjT.SetFldValue(strKey, value_S);
            }
            else if (objTypeName_T.endsWith("ENEx") == true) {
                myObjT.SetFldValue(strKey, value_S);
            }
            else if (objTypeName_T.indexOf("ENEx") > -1) {
                myObjT.SetFldValue(strKey, value_S);
            }
            else {
                myObjT[strKey] = value_S;
            }
        }
        return true;
    }
    exports.ObjectAssignV2 = ObjectAssignV2;
    function GetSortExpress(objPagerPara) {
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1)
                strSortType = sstrSplit[1];
            //arrPrjTab_Sel = arrPrjTab_Sel.sort(PrjTabEx_SortFunByKey(strSortFld, strSortType));
            return strSortFld;
        }
        return "";
    }
    exports.GetSortExpress = GetSortExpress;
    function GetSortExpressInfo(objPagerPara) {
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1)
                strSortType = sstrSplit[1];
            //arrPrjTab_Sel = arrPrjTab_Sel.sort(PrjTabEx_SortFunByKey(strSortFld, strSortType));
            return {
                SortFld: strSortFld,
                SortType: strSortType
            };
        }
        return {
            SortFld: "",
            SortType: ""
        };
    }
    exports.GetSortExpressInfo = GetSortExpressInfo;
    /*
    * 根据字符串的长度决定显示的宽度
    */
    function GetWidthByWordStr(strWord) {
        if (strWord.length < 3)
            return 40;
        else if (strWord.length < 4)
            return 50;
        else if (strWord.length < 5)
            return 60;
        else if (strWord.length < 6)
            return 70;
        else if (strWord.length < 7)
            return 80;
        else if (strWord.length < 8)
            return 90;
        else if (strWord.length < 9)
            return 100;
        else if (strWord.length < 10)
            return 110;
        else if (strWord.length < 11)
            return 120;
        else
            return 150;
    }
    exports.GetWidthByWordStr = GetWidthByWordStr;
    function SetAllNotCkechedItem(strArrayDiv) {
        //获取指定数据列表层
        const divList = document.getElementById(strArrayDiv);
        //根据className获取数据列表层中的所有复选框
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        //把集合转换成Array
        const arrChkLitems = (0, clsCommFunc4Ctrl_js_1.GetArray)(chkItems);
        for (const chkItem of arrChkLitems) {
            chkItem.checked = false;
        }
    }
    exports.SetAllNotCkechedItem = SetAllNotCkechedItem;
    function GetObjValueOfKeyV2(myObj, strKey) {
        const { keys, values, entries } = Object;
        const arrEntries = Object.entries(myObj);
        for (const [key, value] of arrEntries) {
            if (strKey == key)
                return value;
        }
        return "";
    }
    exports.GetObjValueOfKeyV2 = GetObjValueOfKeyV2;
    function GetObjValueOfKey(myObj, strKey) {
        //let { keys, values, entries } = Object;
        const arrEntries = Object.entries(myObj);
        const map = new Map(arrEntries);
        const strValue = map.get(strKey);
        return strValue;
    }
    exports.GetObjValueOfKey = GetObjValueOfKey;
    function confirm_del4Msg(strMsg) {
        const gnl = confirm(strMsg);
        if (gnl == true) {
            return true;
        }
        else {
            return false;
        }
    }
    exports.confirm_del4Msg = confirm_del4Msg;
    /*
      * 绑定下拉框
      */
    function BindDdl_CboObject(strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
        const sltDdl = document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        const strText = "选" + strTabCnName + "...";
        //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
        //objArrayItem.text = strText;
        //objArrayItem.value = "0";
        //sltDdl.options.add(objArrayItem);
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0;
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(clsCboObject_js_1.clsCboObject.GetFldValue(objCurr, strTextFldName), clsCboObject_js_1.clsCboObject.GetFldValue(objCurr, strValueFldName)));
        }
    }
    exports.BindDdl_CboObject = BindDdl_CboObject;
    function BindDdl_CboObjectInDiv(strDivName, strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
        let sltDdl;
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            sltDdl = document.getElementById(strDdlName);
        }
        else {
            const arrSelect = objDiv.getElementsByTagName("select");
            const arrElements = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrSelect);
            sltDdl = arrElements.find(x => x.id == strDdlName);
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
                console.error(strMsg);
                sltDdl = document.getElementById(strDdlName);
            }
        }
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在界面内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
            console.error(strMsg);
            throw (strMsg);
        }
        sltDdl.options.length = 0;
        const strText = "选" + strTabCnName + "...";
        //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
        //objArrayItem.text = strText;
        //objArrayItem.value = "0";
        //sltDdl.options.add(objArrayItem);
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0;
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(clsCboObject_js_1.clsCboObject.GetFldValue(objCurr, strTextFldName), clsCboObject_js_1.clsCboObject.GetFldValue(objCurr, strValueFldName)));
        }
    }
    exports.BindDdl_CboObjectInDiv = BindDdl_CboObjectInDiv;
    /*
    *为下拉框绑定布尔型的值，"是","否"
    */
    function BindDdl_TrueAndFalse(ddlTrueAndFalse) {
        //const strWhereCond = " 1 =1 ";
        const objDdl = document.getElementById(ddlTrueAndFalse);
        if (objDdl == null) {
            const strMsg = `下拉框:${ddlTrueAndFalse} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        const arrTrueFalseLst = [
            {
                text: "是",
                value: "01"
            },
            {
                text: "否",
                value: "02"
            },
        ];
        //在一行代码中不能同时使用两个其他类名
        //     BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
        BindDdl_CboObject(ddlTrueAndFalse, arrTrueFalseLst, "value", "text", "是/否");
        //console.log("1完成BindDdl_TrueAndFalse!");
    }
    exports.BindDdl_TrueAndFalse = BindDdl_TrueAndFalse;
    /*
    *为下拉框绑定布尔型的值，"是","否"
    */
    function BindDdl_TrueAndFalseInDiv(strDivName, ddlTrueAndFalse) {
        let sltDdl;
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            sltDdl = document.getElementById(ddlTrueAndFalse);
        }
        else {
            const arrSelect = objDiv.getElementsByTagName("select");
            const arrElements = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrSelect);
            sltDdl = arrElements.find(x => x.id == ddlTrueAndFalse);
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, ddlTrueAndFalse);
                console.error(strMsg);
                sltDdl = document.getElementById(ddlTrueAndFalse);
            }
        }
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在界面内，不存在下拉框:[{1}], 请检查！", strDivName, ddlTrueAndFalse);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrTrueFalseLst = [
            {
                text: "是",
                value: "01"
            },
            {
                text: "否",
                value: "02"
            },
        ];
        //在一行代码中不能同时使用两个其他类名
        //     clsCommFunc4Ctrl.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
        BindDdl_CboObject(ddlTrueAndFalse, arrTrueFalseLst, "value", "text", "是/否");
        //console.log("1完成BindDdl_TrueAndFalse!");
    }
    exports.BindDdl_TrueAndFalseInDiv = BindDdl_TrueAndFalseInDiv;
    /*
    * 根据Id获取元素,在层(Div)内查找相应元素
    */
    function getElementByIdInDiv(strDivName, strControlType, strControlId) {
        if ((0, clsString_js_1.IsNullOrEmpty)(strControlType) == true) {
            const strMsg = (0, clsString_js_1.Format)("在层:{0}中查找控件:[{1}]时, 类型不能为空！", strDivName, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName(strControlType);
        const arrElements = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrElements0);
        const objElement = arrElements.find(x => x.id == strControlId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[{1}]的元素:[{2}], 请检查！", strDivName, strControlType, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getElementByIdInDiv = getElementByIdInDiv;
    function myShowErrorMsg(strErrInfo) {
        let funCurrFunction = arguments.callee; //获取函数定义的全部内容
        const arrFuncName = [];
        while (funCurrFunction !== null) {
            arrFuncName.push((funCurrFunction).name);
            //arrFuncName.push(funCurrFunction.toString());
            funCurrFunction = funCurrFunction.caller;
        }
        let strPath = "";
        let strTop = arrFuncName.pop();
        while (arrFuncName.length >= 0) {
            if (strTop === "") {
                strTop = "匿名";
            }
            if (strPath === "") {
                strPath = strTop + "()";
            }
            else {
                if (strTop !== "匿名") {
                    strPath = strPath + "->" + strTop + "()";
                }
            }
            if (arrFuncName.length === 0) {
                break;
            }
            strTop = arrFuncName.pop();
        }
        const strErrorMsg = `出错信息:${strErrInfo} (错误来自于函数:${strPath})`;
        console.error(strErrorMsg);
        alert(strErrorMsg);
    }
    exports.myShowErrorMsg = myShowErrorMsg;
    /*
     * 绑定下拉框,在层(Div)内查找相应下拉框
     */
    function BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
        let sltDdl;
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            sltDdl = document.getElementById(strDdlName);
        }
        else {
            const arrSelect = objDiv.getElementsByTagName("select");
            const arrElements = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrSelect);
            sltDdl = arrElements.find(x => x.id == strDdlName);
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
                console.error(strMsg);
                sltDdl = document.getElementById(strDdlName);
            }
        }
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在界面内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
            console.error(strMsg);
            throw (strMsg);
        }
        //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        const strText = "选" + strTabCnName + "...";
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0;
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
        }
    }
    exports.BindDdl_ObjLstInDiv = BindDdl_ObjLstInDiv;
    /*
     * 绑定下拉框,在层(Div)内查找相应下拉框
     */
    function BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
        let sltDdl;
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            sltDdl = document.getElementById(strDdlName);
        }
        else {
            const arrSelect = objDiv.getElementsByTagName("select");
            const arrElements = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrSelect);
            sltDdl = arrElements.find(x => x.id == strDdlName);
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
                console.error(strMsg);
                sltDdl = document.getElementById(strDdlName);
            }
        }
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在界面内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
            console.error(strMsg);
            throw (strMsg);
        } //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        const strText = "选" + strTabCnName + "...";
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0;
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
        }
    }
    exports.BindDdl_ObjLstInDiv_V = BindDdl_ObjLstInDiv_V;
    /*
      * 绑定下拉框
      */
    function BindDdl_ObjLst(strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
        const sltDdl = document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        const strText = "选" + strTabCnName + "...";
        //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
        //objArrayItem.text = strText;
        //objArrayItem.value = "0";
        //sltDdl.options.add(objArrayItem);
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0;
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
        }
    }
    exports.BindDdl_ObjLst = BindDdl_ObjLst;
    /*
      * 绑定下拉框
      */
    function BindDdl_ObjLst_V(strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
        const sltDdl = document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        const strText = "选" + strTabCnName + "...";
        //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
        //objArrayItem.text = strText;
        //objArrayItem.value = "0";
        //sltDdl.options.add(objArrayItem);
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0;
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
        }
    }
    exports.BindDdl_ObjLst_V = BindDdl_ObjLst_V;
    /*
     * 设置使特定关键字的复选框被选
     * strKeyId:关键字
     */
    function SetNotCkechedItem4KeyId(strArrayDiv, strKeyId) {
        //获取指定数据列表层
        const divList = document.getElementById(strArrayDiv);
        //根据className获取数据列表层中的所有复选框
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        //把集合转换成Array
        const arrChkLitems = (0, clsCommFunc4Ctrl_js_1.GetArray)(chkItems);
        //根据关键字(strKeyId)获取相应的控件id
        const strCtrlId = "chk" + strKeyId;
        //在控件Array中查找第一个id为strCtrlId的复选框
        const chk4KeyId = arrChkLitems.find((x) => x.id == strCtrlId);
        //let chk4KeyId: HTMLInputElement = document.getElementById(strCtrlId);
        console.log(chk4KeyId);
        if (chk4KeyId == null) {
            const strMsg = `关键字:${strCtrlId}没有找到，请联系管理员！`;
            console.log(strMsg);
            //alert(strMsg);
            return;
        }
        chk4KeyId.checked = false;
    }
    exports.SetNotCkechedItem4KeyId = SetNotCkechedItem4KeyId;
    function SetCkechedItem4KeyId(strArrayDiv, strKeyId) {
        //获取指定数据列表层
        const divList = document.getElementById(strArrayDiv);
        //根据className获取数据列表层中的所有复选框
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        //把集合转换成Array
        const arrChkLitems = (0, clsCommFunc4Ctrl_js_1.GetArray)(chkItems);
        //根据关键字(strKeyId)获取相应的控件id
        const strCtrlId = "chk" + strKeyId;
        //在控件Array中查找第一个id为strCtrlId的复选框
        const chk4KeyId = arrChkLitems.find((x) => x.id == strCtrlId);
        //let chk4KeyId: HTMLInputElement = document.getElementById(strCtrlId);
        console.log(chk4KeyId);
        if (chk4KeyId == null) {
            const strMsg = `关键字:${strCtrlId}没有找到，请联系管理员！`;
            console.log(strMsg);
            //alert(strMsg);
            return;
        }
        chk4KeyId.checked = true;
    }
    exports.SetCkechedItem4KeyId = SetCkechedItem4KeyId;
    ///*
    // * 获取对象的所有属性名列表
    // */
    //export function GetObjKeys(myObj: clsGeneralTab_Sim): Array<string> {
    //    const sstrKeys: Array<string> = [];
    //    for (const p1 in myObj) {
    //        if (Object.prototype.hasOwnProperty.call(myObj, p1))
    //            sstrKeys.push(p1);
    //    }
    //    return sstrKeys;
    //}
    function SetAllCkechedKeysV2(tabName, thisChk) {
        console.log("thisChk(In SetAllCkechedKeysV2):", thisChk);
        //event = window.event || event;
        const thisEventObj = thisChk;
        const arrKeys = tabName.getElementsByClassName('CheckInTab');
        const bolIsCheck = thisEventObj.checked;
        const arrKeyLst = (0, clsCommFunc4Ctrl_js_1.GetArray)(arrKeys);
        arrKeyLst.forEach((e) => e.checked = bolIsCheck);
        console.log("所选记录的个数:", arrKeys.length.toString());
    }
    exports.SetAllCkechedKeysV2 = SetAllCkechedKeysV2;
    function GetExceptionStr(objException) {
        let strEx = "";
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
    }
    exports.GetExceptionStr = GetExceptionStr;
    //js获取网站根路径(站点及虚拟目录)，获得网站的根目录或虚拟目录的根地址     
    function getRootPath() {
        const strFullPath = document.location.href;
        const strPath = document.location.pathname;
        const pos = strFullPath.indexOf(strPath);
        const prePath = strFullPath.substring(0, pos);
        const postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
        return (prePath + postPath);
    }
    exports.getRootPath = getRootPath;
    /*
       * 获取对象的所有属性名列表
       */
    function GetObjKeys(myObj) {
        const sstrKeys = [];
        for (const p1 in myObj) {
            if (Object.prototype.hasOwnProperty.call(myObj, p1))
                sstrKeys.push(p1);
        }
        return sstrKeys;
    }
    exports.GetObjKeys = GetObjKeys;
    function sortFun() { }
    exports.sortFun = sortFun;
    /*
     * 重新转向本项目新的Url地址
     */
    function Redirect(LocUrl) {
        const strWebRoot = getRootPath();
        //console.log(strWebRoot);
        if (strWebRoot.indexOf("http://") >= 0 || strWebRoot.indexOf("https://") >= 0) {
            let strShortUrl = "";
            if (LocUrl.substr(0, 1) == "/") {
                strShortUrl = strWebRoot + LocUrl;
            }
            else {
                strShortUrl = strWebRoot + "/" + LocUrl;
            }
            //显示信息框
            //console.log(strShortUrl);
            window.location.href = strShortUrl;
            return;
        }
        const strProtocol = location.protocol;
        const strHost = location.host;
        const strPathName = location.pathname;
        let strShortUrl = `/${strWebRoot}/${LocUrl}`;
        strShortUrl = strShortUrl.replace("//", "/");
        strShortUrl = strShortUrl.replace("//", "/");
        //显示信息框
        const strNewLink = `${strProtocol}//${strHost}${strShortUrl}`;
        console.log(strNewLink);
        window.location.href = strNewLink;
    }
    exports.Redirect = Redirect;
    /*
      * 确认删除函数
      */
    function confirm_del(intCount) {
        let strMsg = (0, clsString_js_1.Format)("你真的确定要删除记录吗?");
        if (intCount > 0) {
            strMsg = (0, clsString_js_1.Format)("你真的确定要删除{0}条记录吗?", intCount);
        }
        const gnl = confirm(strMsg);
        if (gnl == true) {
            return true;
        }
        else {
            return false;
        }
    }
    exports.confirm_del = confirm_del;
    function SortFun() { }
    exports.SortFun = SortFun;
    /*
       * 获取列表中所有被选的复选框的关键字值，以列表方式(Array<string>)返回
       */
    function GetCheckedKeyIds() {
        var divList = document.getElementById("divList");
        var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        let arrChkLitems = (0, clsCommFunc4Ctrl_js_1.GetArray)(chkItems);
        var chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
        var arrSelectedKeys = chkCheckedItems.map((x) => {
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
    }
    exports.GetCheckedKeyIds = GetCheckedKeyIds;
    function GetCheckedKeyIdsInDiv(strDivName) {
        var divList = document.getElementById(strDivName);
        var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        let arrChkLitems = (0, clsCommFunc4Ctrl_js_1.GetArray)(chkItems);
        var chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
        var arrSelectedKeys = chkCheckedItems.map((x) => {
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
    }
    exports.GetCheckedKeyIdsInDiv = GetCheckedKeyIdsInDiv;
    /*
        * 获取列表中第一个选中的复选框的关键字
        */
    function GetFirstCheckedKeyId() {
        const divListName = "divDataLst";
        const divList = document.getElementById(divListName);
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        const arrChkLitems = (0, clsCommFunc4Ctrl_js_1.GetArray)(chkItems);
        const chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
        const intCheckedCount = chkCheckedItems.length;
        for (let i = 0; i < intCheckedCount; i++) {
            const chkItem = chkCheckedItems[i];
            if (chkItem.id == 'chkTabHead')
                continue;
            const strId = chkItem.id;
            const strKey = strId.substring(3);
            return strKey;
        }
        //    alert(intCount.toString() + "::" + intCheckedCount.toString());
        return "";
    }
    exports.GetFirstCheckedKeyId = GetFirstCheckedKeyId;
    /*
* 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V2)
*/
    function BindTabV2Where(divContainer, arrObjLst, arrDataColumn, strKey, strWhere) {
        //var o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //var sstrFldName: Array<string> = new Array<string>();
        //var sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
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
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    var check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkHead`;
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
                    a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                    a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                    //判断传入的值，然后显示调用不同的方法
                    if (strWhere == "TopicUser") {
                        //用户
                        a1.href = `javascript:SortByUser('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTUser") {
                        //主题用户关系
                        a1.href = `javascript:SortByRTUser('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicPaper") {
                        //论文
                        a1.href = `javascript:SortByPaper('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTPaper") {
                        //主题论文关系
                        a1.href = `javascript:SortByRTPaper('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicViewpoint") {
                        //个人观点
                        a1.href = `javascript:SortByViewpoint('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTViewpoint") {
                        //主题个人观点关系
                        a1.href = `javascript:SortByRTViewpoint('${arrDataColumn[j].fldName}');`;
                    }
                    //else if (strWhere == "TopicExpertViewpoint") {
                    //    //专家观点
                    //    a1.href = `javascript:SortByExpertViewpoint('${arrDataColumn[j].fldName}');`;
                    //}
                    else if (strWhere == "TopicRTExpertViewpoint") {
                        //主题专家观点关系
                        a1.href = `javascript:SortByRTExpertViewpoint('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicConcept") {
                        //概念
                        a1.href = `javascript:SortByConcept('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTConcept") {
                        //主题概念关系
                        a1.href = `javascript:SortByRTConcept('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicObjectiveFact") {
                        //客观事实
                        a1.href = `javascript:SortByObjectiveFact('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTObjectiveFact") {
                        //主题客观事实关系
                        a1.href = `javascript:SortByRTObjectiveFact('${arrDataColumn[j].fldName}');`;
                    }
                    //else if (strWhere == "TopicObjectiveBasis") {
                    //    //客观依据
                    //    a1.href = `javascript:SortByObjectiveBasis('${arrDataColumn[j].fldName}');`;
                    //}
                    else if (strWhere == "TopicRTObjectiveBasis") {
                        //主题客观依据关系
                        a1.href = `javascript:SortByRTObjectiveBasis('${arrDataColumn[j].fldName}');`;
                    }
                    //else if (strWhere == "TopicPaperList") {
                    //    //论文列表
                    //    a1.href = `javascript:SortByPaperList('${arrDataColumn[j].fldName}');`;
                    //}
                    else {
                        a1.href = `javascript:SortBy('${arrDataColumn[j].fldName}');`;
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
                        console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e) {
                        var strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
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
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        var check = document.createElement("input");
                        check.type = "checkbox";
                        var strKeyValue = objEN.GetFldValue(strKey);
                        check.id = `chk${strKeyValue}`;
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                        //check.onclick = (function () {
                        //    ChkClick(this);
                        //});
                        td.appendChild(check);
                        break;
                    case "Label":
                        td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        tr.appendChild(td);
                        break;
                    case "Button":
                        try {
                            var strKeyValue = objEN.GetFldValue(strKey);
                            var btn1 = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            td.appendChild(btn1);
                        }
                        catch (e) {
                            var strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
    }
    exports.BindTabV2Where = BindTabV2Where;
    /*
    * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V2)
    */
    function BindTabV2Where_V(divContainer, arrObjLst, arrDataColumn, strKey, strWhere) {
        //var o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //var sstrFldName: Array<string> = new Array<string>();
        //var sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
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
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    var check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkHead`;
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
                    a1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                    a1.text = arrDataColumn[j].colHeader; //i + "" + j;
                    //判断传入的值，然后显示调用不同的方法
                    if (strWhere == "TopicUser") {
                        //用户
                        a1.href = `javascript:SortByUser('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTUser") {
                        //主题用户关系
                        a1.href = `javascript:SortByRTUser('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicPaper") {
                        //论文
                        a1.href = `javascript:SortByPaper('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTPaper") {
                        //主题论文关系
                        a1.href = `javascript:SortByRTPaper('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicViewpoint") {
                        //个人观点
                        a1.href = `javascript:SortByViewpoint('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTViewpoint") {
                        //主题个人观点关系
                        a1.href = `javascript:SortByRTViewpoint('${arrDataColumn[j].fldName}');`;
                    }
                    //else if (strWhere == "TopicExpertViewpoint") {
                    //    //专家观点
                    //    a1.href = `javascript:SortByExpertViewpoint('${arrDataColumn[j].fldName}');`;
                    //}
                    else if (strWhere == "TopicRTExpertViewpoint") {
                        //主题专家观点关系
                        a1.href = `javascript:SortByRTExpertViewpoint('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicConcept") {
                        //概念
                        a1.href = `javascript:SortByConcept('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTConcept") {
                        //主题概念关系
                        a1.href = `javascript:SortByRTConcept('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicObjectiveFact") {
                        //客观事实
                        a1.href = `javascript:SortByObjectiveFact('${arrDataColumn[j].fldName}');`;
                    }
                    else if (strWhere == "TopicRTObjectiveFact") {
                        //主题客观事实关系
                        a1.href = `javascript:SortByRTObjectiveFact('${arrDataColumn[j].fldName}');`;
                    }
                    //else if (strWhere == "TopicObjectiveBasis") {
                    //    //客观依据
                    //    a1.href = `javascript:SortByObjectiveBasis('${arrDataColumn[j].fldName}');`;
                    //}
                    else if (strWhere == "TopicRTObjectiveBasis") {
                        //主题客观依据关系
                        a1.href = `javascript:SortByRTObjectiveBasis('${arrDataColumn[j].fldName}');`;
                    }
                    //else if (strWhere == "TopicPaperList") {
                    //    //论文列表
                    //    a1.href = `javascript:SortByPaperList('${arrDataColumn[j].fldName}');`;
                    //}
                    else {
                        a1.href = `javascript:SortBy('${arrDataColumn[j].fldName}');`;
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
                        console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader; //i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader; //i + "" + j;
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e) {
                        var strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
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
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        var check = document.createElement("input");
                        check.type = "checkbox";
                        var strKeyValue = objEN.GetFldValue(strKey);
                        check.id = `chk${strKeyValue}`;
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
                        //check.onclick = (function () {
                        //    ChkClick(this);
                        //});
                        td.appendChild(check);
                        break;
                    case "Label":
                        td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName); //i + "" + j;
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        tr.appendChild(td);
                        break;
                    case "Button":
                        try {
                            var strKeyValue = objEN.GetFldValue(strKey);
                            var btn1 = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text);
                            td.appendChild(btn1);
                        }
                        catch (e) {
                            var strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
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
    }
    exports.BindTabV2Where_V = BindTabV2Where_V;
});

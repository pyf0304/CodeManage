/*
 * 功能:为Web提供一些公共的功能函数
 * 版本:2021-06-06-01
 * 作者:潘以锋
 * */
/*import $ from "jquery";*/
import { clsCboObject } from "./clsCboObject.js";
import { GetArray, getTdObjByIdInDiv, getTrObjByIdInDiv } from "./clsCommFunc4Ctrl.js";
import { clsDataColumn } from "./clsDataColumn.js";
import { clsGeneralTab } from "./clsGeneralTab.js";
import { clsGeneralTabV } from "./clsGeneralTabV.js";
import { clsOperateList } from "./clsOperateList.js";
import { Format, IsNullOrEmpty } from "./clsString.js";
import { stuPagerPara } from "./stuPagerPara.js";

//import * as bootstrap from 'bootstrap';

export const arrSelectedKeys: Array<string> = new Array<string>();
export function ChkClick1(myThis: any) {

    const strId = myThis.id;
    if (strId == 'chkTabHead') return "";
    const strKey = strId.substring(3);
    if (myThis.checked == true) {
        if (arrSelectedKeys.indexOf(strKey) < 0) {
            arrSelectedKeys.push(strKey);
        }
    }
    else {
        const index = arrSelectedKeys.indexOf(strKey);
        if (index > -1) {
            arrSelectedKeys.splice(index, 1);
        }
    } let sstrKey = "";
    for (const strK of arrSelectedKeys) {
        sstrKey += `${strK},`;
    }
    $('#spanResult').html(sstrKey);
}
declare function ChkClick(myThis: any): void;
declare function SetAllCkechedKeys(myThis: any): void;
declare const document: any;
//declare const strWebRoot: string;

export class clsCommFunc4WebBak {

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
    //        throw (strMsg);
    //    }
    //    const arrSelect = objDiv.getElementsByTagName("select");
    //    const arrElements = GetArray(arrSelect);
    //    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
    //    if (sltDdl == null) {
    //        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
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

    public static BindEvent_Select(strSelectId: string, strEventName: string, func: () => void) {

        const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
        if (strEventName == "onchange") {
            objSelect.onchange = (function (this) {
                //alert("inner objSelect.onchange");
                func.call(this);
            });
        }
    }

    public static BindEvent_Input(strInputId: string, strEventName: string, func: () => void) {

        const objInput: HTMLInputElement = <HTMLInputElement>document.getElementById(strInputId);
        if (strEventName == "onblur") {
            objInput.onblur = (function (this) {
                //alert("inner objSelect.onchange");
                func.call(this);
            });
        }
    }
    //js获取网站根路径(站点及虚拟目录)，获得网站的根目录或虚拟目录的根地址     
    public static getRootPath() {
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
    public static Redirect(LocUrl: string) {
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
        const strPathName = location.pathname; let strShortUrl = `/${strWebRoot}/${LocUrl}`;
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
    public static BindDdl_ObjLstWithSet(strDdlName: string, arrObjLst: Set<string>, strTabCnName: string) {
        const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
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
    public static BindDdl_ObjLstV2(sltDdl: HTMLSelectElement, arrObjLst: Array<clsGeneralTab>,
        strValueFldName: string, strTextFldName: string, strTabCnName: string) {
        //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        const strText = strTabCnName;

        //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
        //objArrayItem.text = strText;
        //objArrayItem.value = "0";
        //sltDdl.options.add(objArrayItem);
        sltDdl.options.add(new Option(strText, "0"));
        let i = 0
        for (i = 0; i < arrObjLst.length; i++) {
            const objCurr = arrObjLst[i];

            sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
        }
    }

    /*
     * 获取对象的所有属性名列表
     */
    public static GetObjKeys(myObj: object): Array<string> {
        const sstrKeys: Array<string> = [];
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
    public static BindTab(divContainer: HTMLDivElement, arrObjLst: Array<clsGeneralTab>, sstrFldName: Array<string>, sstrColHeader: Array<string>, strKey: string) {
        //const o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //const sstrFldName: Array<string> = new Array<string>();
        //const sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
        const table: HTMLTableElement = document.createElement("table");
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
        const trHead: HTMLTableRowElement = document.createElement("tr");
        trHead.className = "row-height";
        const td00: HTMLTableDataCellElement = document.createElement("td");
        const check00: HTMLInputElement = document.createElement("input");
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
            td.id = Format("td{0}", sstrFldName[j]);
            const a1: HTMLAnchorElement = document.createElement("a");
            a1.nodeValue = sstrColHeader[j];//i + "" + j;
            a1.text = sstrColHeader[j];//i + "" + j;
            a1.href = `javascript:sortBy('${sstrFldName[j]}');`;
            //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
            td.appendChild(a1);
            //td.appendChild(document.createTextNode(i + "" + j));
            //td.style.color = "#FF0000";
            td.className = "text-center";
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {
            const objEN: clsGeneralTab = arrObjLst[i];
            const tr: HTMLTableRowElement = document.createElement("tr");
            tr.className = "row-height";
            const td0: HTMLTableDataCellElement = document.createElement("td");
            const check: HTMLInputElement = document.createElement("input");
            check.type = "checkbox";
            const strKeyValue = objEN.GetFldValue(strKey);
            check.id = `chk${strKeyValue}`;
            check.name = "chkInTab";
            check.className = "CheckInTab";
            td0.appendChild(check);
            tr.appendChild(td0);

            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                td.id = Format("td{0}", sstrFldName[j]);
                td.innerHTML = objEN.GetFldValue(sstrFldName[j]);//i + "" + j;
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
        arrSelectedKeys.splice(0);
    }
    /*
     * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V2)
     */
    public static BindTabV2(divContainer: HTMLDivElement, arrObjLst: Array<clsGeneralTab>, arrDataColumn: Array<clsDataColumn>, strKey: string) {
        //const o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //const sstrFldName: Array<string> = new Array<string>();
        //const sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
        const table: HTMLTableElement = document.createElement("table");
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
        const trHead: HTMLTableRowElement = document.createElement("tr");
        trHead.className = "row-height";
        let check00: HTMLInputElement;
        let a1: HTMLAnchorElement;
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
                    a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                    a1.text = arrDataColumn[j].colHeader;//i + "" + j;
                    a1.href = `javascript:sortBy('${arrDataColumn[j].sortBy}');`;
                    //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                    td.appendChild(a1);
                    //td.appendChild(document.createTextNode(i + "" + j));
                    //td.style.color = "#FF0000";

                    td.className = "text-center";
                    break;
                case "Button":
                    try {
                        const span1: HTMLSpanElement = document.createElement("span");
                        //console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e: any) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        const a1: HTMLAnchorElement = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.text = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.href = `javascript:sortBy('${arrDataColumn[j].fldName}');`;
                        //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";

                    }
                    catch (e: any) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {

            const objEN: clsGeneralTab = arrObjLst[i];
            const strKeyValue = objEN.GetFldValue(strKey);
            const tr: HTMLTableRowElement = document.createElement("tr");
            tr.className = "row-height";
            tr.id = `tr${strKeyValue}`;
            let check: HTMLInputElement;
            for (let j = 0; j < intColNum; j++) {
                const td: HTMLTableDataCellElement = document.createElement("td");
                td.className = arrDataColumn[j].tdClass;
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check = document.createElement("input");
                        check.type = "checkbox";

                        check.id = `chk${strKeyValue}`;
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        if (IsNullOrEmpty(objEN.GetFldValue("CtrlId")) == false) {
                            check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                        }
                        td.appendChild(check);
                        break;
                    case "Label":
                        td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName);//i + "" + j;
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        if (IsNullOrEmpty(td.className)) {
                            td.className = "text-center";
                        }
                        tr.appendChild(td);
                        break;
                    case "Button":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const btn1: HTMLElement = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e: any) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const btn1: HTMLElement = arrDataColumn[j].funcName(strKeyValue, strText)
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e: any) {
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
        arrSelectedKeys.splice(0);
    }

    /*
    * 把对象列表绑定到列表控件中，即把对象列表的值显示出来，这是一个新的版本(V3)
    */
    public static BindTabV3(divContainer: HTMLDivElement, arrObjLst: Array<clsGeneralTab>, arrDataColumn: Array<clsDataColumn>, strKey: string, objOperateList: IOperateList) {
        //const o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //const sstrFldName: Array<string> = new Array<string>();
        //const sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
        const table: HTMLTableElement = document.createElement("table");
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
        const trHead: HTMLTableRowElement = document.createElement("tr");
        trHead.className = "row-height";
        let check00: HTMLInputElement;
        let strSortExpress;
        for (let j = 0; j < intColNum; j++) {
            const td = document.createElement("td");
            td.id = Format("td{0}", arrDataColumn[j].fldName);
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkTabHead`;
                    check00.name = "chkTabHead";
                    check00.className = "CheckInTab";
                    check00.onclick = (function (this) {
                        SetAllCkechedKeysV2(divContainer, this);
                    });
                    td.appendChild(check00);

                    break;
                case "Label":

                    strSortExpress = arrDataColumn[j].sortBy;
                    if (IsNullOrEmpty(strSortExpress) == true) {//如果没有排序字段，就不用超链接A

                        const span1: HTMLSpanElement = document.createElement("span");
                        span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;

                        td.appendChild(span1);

                    }
                    else {
                        const a1: HTMLAnchorElement = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.text = arrDataColumn[j].colHeader;//i + "" + j;

                        a1.setAttribute("fldName", strSortExpress);

                        a1.href = 'javascript:';

                        a1.onclick = (function (this) {
                            objOperateList.sortBy(this);
                        });
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                    }

                    td.className = "text-center";
                    break;
                case "Button":
                    try {
                        const span1: HTMLSpanElement = document.createElement("span");
                        //console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e: any) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        const a1: HTMLAnchorElement = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.text = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.href = `javascript:sortBy('${arrDataColumn[j].fldName}');`;
                        //                td.innerHTML = objUserIdentityEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";

                    }
                    catch (e: any) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {

            const objEN: clsGeneralTab = arrObjLst[i];
            const strKeyValue = objEN.GetFldValue(strKey);
            const tr: HTMLTableRowElement = document.createElement("tr");
            tr.className = "row-height";
            tr.id = `tr${strKeyValue}`;
            let check: HTMLInputElement;
            for (let j = 0; j < intColNum; j++) {
                const td: HTMLTableDataCellElement = document.createElement("td");
                td.className = arrDataColumn[j].tdClass;
                switch (arrDataColumn[j].columnType) {
                    case "CheckBox":
                        check = document.createElement("input");
                        check.type = "checkbox";

                        check.id = `chk${strKeyValue}`;
                        check.name = "chkInTab";
                        check.className = "CheckInTab";
                        if (IsNullOrEmpty(objEN.GetFldValue("CtrlId")) == false) {
                            check.setAttribute("ctrlId", objEN.GetFldValue("CtrlId"));
                        }
                        td.appendChild(check);
                        break;
                    case "Label":
                        if (IsNullOrEmpty(arrDataColumn[j].fldName) == false) {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName);//i + "" + j;
                            if (IsNullOrEmpty(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1: HTMLDivElement = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "Button":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const btn1: HTMLElement = arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e: any) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const btn1: HTMLElement = arrDataColumn[j].funcName(strKeyValue, strText)
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e: any) {
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
        arrSelectedKeys.splice(0);
    }
    public static async BindTabV4(divContainer: HTMLDivElement, arrObjLst: Array<clsGeneralTab>, arrDataColumn: Array<clsDataColumn>, strKey: string, objOperateList: clsOperateList) {
        //const o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //const sstrFldName: Array<string> = new Array<string>();
        //const sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("IdentityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("IdentityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
        const table: HTMLTableElement = document.createElement("table");
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
        const trHead: HTMLTableRowElement = document.createElement("tr");
        trHead.className = "row-height";
        let check00: HTMLInputElement;
        let strSortExpress;
        for (let j = 0; j < intColNum; j++) {
            const td = document.createElement("td");
            td.id = Format("td{0}", arrDataColumn[j].fldName);
            switch (arrDataColumn[j].columnType) {
                case "CheckBox":
                    check00 = document.createElement("input");
                    check00.type = "checkbox";
                    check00.id = `chkTabHead`;
                    check00.name = "chkTabHead";
                    check00.className = "CheckInTab";
                    check00.onclick = (function (this) {
                        SetAllCkechedKeysV2(divContainer, this);
                    });
                    td.appendChild(check00);

                    break;
                case "Label":
                case "LabelOrDiv":
                case "Label4Bool":
                case "a":

                    strSortExpress = arrDataColumn[j].sortBy;
                    if (IsNullOrEmpty(strSortExpress) == true) {//如果没有排序字段，就不用超链接A

                        //console.error(arrDataColumn[j].sortFun);
                        if (arrDataColumn[j].sortFun.name != "SortFun") {
                            const a2: HTMLAnchorElement = document.createElement("a");
                            a2.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                            a2.text = arrDataColumn[j].colHeader;//i + "" + j;

                            a2.setAttribute("fldName", strSortExpress);

                            a2.href = 'javascript:';

                            (function (sortFun1) {
                                a2.onclick = (function (this) {
                                    objOperateList.SortBy(sortFun1);
                                });
                            })(arrDataColumn[j].sortFun);

                            td.appendChild(a2);
                        }
                        else {
                            const span1: HTMLSpanElement = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;

                            td.appendChild(span1);
                        }
                    }
                    else {
                        const a1: HTMLAnchorElement = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.text = arrDataColumn[j].colHeader;//i + "" + j;

                        a1.setAttribute("fldName", strSortExpress);

                        a1.href = 'javascript:';

                        a1.onclick = (function (this) {
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
                        const span1: HTMLSpanElement = document.createElement("span");
                        //console.log(arrDataColumn[j].colHeader);
                        span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;
                        //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e: any) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        const strSortExpress = arrDataColumn[j].sortBy;
                        if (IsNullOrEmpty(strSortExpress) == true) {//如果没有排序字段，就不用超链接A

                            const span1: HTMLSpanElement = document.createElement("span");
                            span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                            span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;

                            td.appendChild(span1);

                        }
                        else {
                            const a1: HTMLAnchorElement = document.createElement("a");
                            a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                            a1.text = arrDataColumn[j].colHeader;//i + "" + j;

                            a1.setAttribute("fldName", strSortExpress);

                            a1.href = 'javascript:';

                            a1.onclick = (function (this) {
                                objOperateList.SortBy(this);
                            });
                            td.appendChild(a1);
                        }
                        td.className = "text-center";

                    }
                    catch (e: any) {
                        const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (let i = 0; i < intRowNum; i++) {

            const objEN: clsGeneralTab = arrObjLst[i];
            const strKeyValue = objEN.GetFldValue(strKey);
            const tr: HTMLTableRowElement = document.createElement("tr");
            tr.className = "row-height";
            tr.id = `tr${strKeyValue}`;
            let check: HTMLInputElement;
            let div1: HTMLDivElement;
            for (let j = 0; j < intColNum; j++) {
                const td = document.createElement("td");
                td.className = arrDataColumn[j].tdClass;
                td.id = `td${strKeyValue}_${arrDataColumn[j].fldName}`
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
                        if (IsNullOrEmpty(arrDataColumn[j].fldName) == false) {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName);//i + "" + j;
                            if (IsNullOrEmpty(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1: HTMLDivElement = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "LabelOrDiv":
                        div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                        if (div1.innerHTML == "") {
                            td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName);//i + "" + j;
                            if (IsNullOrEmpty(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "Label4Bool":
                        if (IsNullOrEmpty(arrDataColumn[j].fldName) == false) {
                            const bolFldValue = objEN.GetFldValue(arrDataColumn[j].fldName);
                            if (bolFldValue == true) {
                                const spnBoolTrue = GetSpan4BoolTrue();
                                td.appendChild(spnBoolTrue);
                            }
                            else {
                                const spnBoolFalse = GetSpan4BoolFalse();
                                td.appendChild(spnBoolFalse);
                            }
                            if (IsNullOrEmpty(td.className)) {
                                td.className = "text-center";
                            }
                        }
                        else {
                            //调用外面的函数生成一个层放在该单元格中
                            const div1: HTMLDivElement = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                            td.appendChild(div1);
                        }
                        tr.appendChild(td);
                        break;
                    case "Button":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const btn1: HTMLElement = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e: any) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const btn1: HTMLElement = await arrDataColumn[j].funcName(strKeyValue, strText)
                            td.appendChild(btn1);
                            //const btn1: HTMLButtonElement = document.createElement("Button");
                            //btn1.innerText = arrDataColumn[j].text;
                            //btn1.className = "btn btn-outline-info";
                            //td.appendChild(btn1);
                            ////td.appendChild(document.createTextNode(i + "" + j));
                            ////td.style.color = "#FF0000";
                            //td.className = "text-center";
                        }
                        catch (e: any) {
                            console.error(e);
                            const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                            throw (strMsg);
                        }
                        break;
                    case "a":

                        try {
                            const strKeyValue = objEN.GetFldValue(strKey);
                            const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                            const objA: HTMLAnchorElement = await arrDataColumn[j].funcName(strKeyValue, strText)
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
                        catch (e: any) {
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
        arrSelectedKeys.splice(0);
    }

    /*
     * 根据列表的左上角的复选框值，全选或全不选列表中所有复选框
     */
    public static SetAllCkechedKeys(tabName: HTMLDivElement, thisChk: HTMLInputElement) {
        const arrKeys = tabName.getElementsByClassName('CheckInTab');
        //const thisChk = EventTarget;//
        //const thisChk: HTMLInputElement = e.target as HTMLInputElement;  tabName.getElementsByClassName;// EventTarget as HTMLInputElement;
        const bolIsCheck = thisChk.checked;
        console.log(bolIsCheck);
        const arrKeyLst: Array<HTMLInputElement> = this.GetArray(arrKeys) as Array<HTMLInputElement>;

        arrKeyLst.forEach((e) => e.checked = bolIsCheck);
        alert(arrKeys.length.toString());
    }


    /*
     * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
     */
    public static GetArray(arr: any): Array<HTMLElement> {
        const arrLst: Array<HTMLElement> = new Array<HTMLElement>();
        for (let i = 0; i < arr.length; i++) {
            const chk: HTMLElement = arr[i];// as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    public static Test1(): string {
        return "Test1";
    }
    public static CheckControlExist(divName: string, strControlType: string, strControlId: string): void {
        if (IsNullOrEmpty(strControlType) == true) {
            const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", divName, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDiv = $(`#${divName}`);
        if (objDiv.length == 0) {
            const strMsg = Format("层:{0}不存在, 请检查！", divName);
            console.error(strMsg);
            throw (strMsg);
        }
        const strId = `${strControlType}[id ^= "${strControlId}"]`;
        const objControl = objDiv.find(strId);
        if (objControl.length == 0) {
            const strMsg = Format("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
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
    public static BindDdl_ObjLstWithSetInDiv(strDivName: string, strDdlName: string, arrObjLst: Set<string>, strTabCnName: string) {
        let sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
            throw (strMsg);
        }
        const arrSelect = objDiv.getElementsByTagName("select");
        const arrElements = GetArray(arrSelect);
        sltDdl = <HTMLSelectElement>arrElements.find(x => x.id == strDdlName);
        if (sltDdl == null) {
            const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
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
    public static confirm_del(intCount: number) {
        let strMsg = Format("你真的确定要删除记录吗?");
        if (intCount > 0) {
            strMsg = Format("你真的确定要删除{0}条记录吗?", intCount);
        }
        const gnl = confirm(strMsg);
        if (gnl == true) {
            return true;
        }
        else {
            return false;
        }
    }

    //  /**
    //* 显示表格行 (tr))
    //**/
    //  public static ShowTr(divName4Edit: string, strTr: string) {
    //      const objDiv = $(`#${divName4Edit}`);
    //      CheckControlExist(divName4Edit, "tr", strTr);
    //      const strId = Format("tr[id ^= '{0}']", strTr);
    //      objDiv.find(strId).show();
    //  }

    //    /**
    //* 隐藏表格行 (tr))
    //**/
    //    public static HideTr(divName4Edit: string, strTr: string) {
    //        const objDiv = $(`#${divName4Edit}`);
    //        CheckControlExist(divName4Edit, "tr", strTr);
    //        const strId = Format("tr[id ^= '{0}']", strTr);
    //        objDiv.find(strId).hide();
    //    }
    //    /**
    //* 设置Label值
    //**/
    //    public static SetLabelValue(divName4Edit: string, strLabel: string, value: string) {
    //        const objDiv = $(`#${divName4Edit}`);
    //        CheckControlExist(divName4Edit, "label", strLabel);
    //        const strId = Format("label[id ^= '{0}']", strLabel);
    //        objDiv.find(strId).html(value);
    //    }

    //   /**
    // * 隐藏对话框
    //**/
    //   public static HideDialog(strDialogName: string) {
    //       console.log("隐藏对话框" + strDialogName);
    //       $(strDialogName).modal('hide');
    //   }

    //   /**
    //    * 显示对话框
    //   **/
    //   public static ShowDialog(strDialogName: string) {
    //       console.log("显示对话框" + strDialogName);
    //       $(strDialogName).modal('show');
    //   }

}

export async function BindTab(divContainer: HTMLDivElement, arrObjLst: Array<clsGeneralTab>, arrDataColumn: Array<clsDataColumn>, strKey: string, objOperateList: clsOperateList) {

    const table: HTMLTableElement = document.createElement("table");
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
    const trHead: HTMLTableRowElement = document.createElement("tr");
    trHead.className = "row-height";
    let check00: HTMLInputElement;
    let strSortExpress;
    for (let j = 0; j < intColNum; j++) {
        const td = document.createElement("td");
        td.id = Format("td{0}", arrDataColumn[j].fldName);
        switch (arrDataColumn[j].columnType) {
            case "CheckBox":
                check00 = document.createElement("input");
                check00.type = "checkbox";
                check00.id = `chkTabHead`;
                check00.name = "chkTabHead";
                check00.className = "CheckInTab";
                check00.onclick = (function (this) {
                    SetAllCkechedKeysV2(divContainer, this);
                });
                td.appendChild(check00);

                break;
            case "Label":
            case "LabelOrDiv":
            case "Label4Bool":
            case "a":

                strSortExpress = arrDataColumn[j].sortBy;
                if (IsNullOrEmpty(strSortExpress) == true) {//如果没有排序字段，就不用超链接A

                    //console.error(arrDataColumn[j].sortFun);
                    if (arrDataColumn[j].sortFun.name != "SortFun") {
                        const a2: HTMLAnchorElement = document.createElement("a");
                        a2.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        a2.text = arrDataColumn[j].colHeader;//i + "" + j;

                        a2.setAttribute("fldName", strSortExpress);

                        a2.href = 'javascript:';

                        (function (sortFun1) {
                            a2.onclick = (function (this) {
                                objOperateList.SortBy(sortFun1);
                            });
                        })(arrDataColumn[j].sortFun);

                        td.appendChild(a2);
                    }
                    else {
                        const span1: HTMLSpanElement = document.createElement("span");
                        span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;

                        td.appendChild(span1);
                    }
                }
                else {
                    const a1: HTMLAnchorElement = document.createElement("a");
                    a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                    a1.text = arrDataColumn[j].colHeader;//i + "" + j;

                    a1.setAttribute("fldName", strSortExpress);

                    a1.href = 'javascript:';

                    a1.onclick = (function (this) {
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
                    const span1: HTMLSpanElement = document.createElement("span");
                    //console.log(arrDataColumn[j].colHeader);
                    span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                    span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;
                    //                td.innerHTML = objEN["IdentityDesc"];//i + "" + j;
                    td.appendChild(span1);
                    //td.appendChild(document.createTextNode(i + "" + j));
                    //td.style.color = "#FF0000";
                    td.className = "text-center";
                }
                catch (e: any) {
                    const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                    throw (strMsg);
                }
                break;
            case "LinkButton":
                try {
                    const strSortExpress = arrDataColumn[j].sortBy;
                    if (IsNullOrEmpty(strSortExpress) == true) {//如果没有排序字段，就不用超链接A

                        const span1: HTMLSpanElement = document.createElement("span");
                        span1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].colHeader;//i + "" + j;

                        td.appendChild(span1);

                    }
                    else {
                        const a1: HTMLAnchorElement = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].colHeader;//i + "" + j;
                        a1.text = arrDataColumn[j].colHeader;//i + "" + j;

                        a1.setAttribute("fldName", strSortExpress);

                        a1.href = 'javascript:';

                        a1.onclick = (function (this) {
                            objOperateList.SortBy(this);
                        });
                        td.appendChild(a1);
                    }
                    td.className = "text-center";

                }
                catch (e: any) {
                    const strMsg = `建立表头不成功。类型:${arrDataColumn[j].columnType},列头:${arrDataColumn[j].colHeader}`;
                    throw (strMsg);
                }
                break;
        }
        trHead.appendChild(td);
    }
    tbody.appendChild(trHead);
    for (let i = 0; i < intRowNum; i++) {

        const objEN: clsGeneralTab = arrObjLst[i];
        const strKeyValue = objEN.GetFldValue(strKey);
        const tr: HTMLTableRowElement = document.createElement("tr");
        tr.className = "row-height";
        tr.id = `tr${strKeyValue}`;
        let check: HTMLInputElement;
        let div1: HTMLDivElement;
        for (let j = 0; j < intColNum; j++) {
            const td = document.createElement("td");
            td.className = arrDataColumn[j].tdClass;
            td.id = `td${strKeyValue}_${arrDataColumn[j].fldName}`
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
                    if (IsNullOrEmpty(arrDataColumn[j].fldName) == false) {
                        td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName);//i + "" + j;
                        if (IsNullOrEmpty(td.className)) {
                            td.className = "text-center";
                        }
                    }
                    else {
                        //调用外面的函数生成一个层放在该单元格中
                        const div1: HTMLDivElement = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                        td.appendChild(div1);
                    }
                    tr.appendChild(td);
                    break;
                case "LabelOrDiv":
                    div1 = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                    if (div1.innerHTML == "") {
                        td.innerHTML = objEN.GetFldValue(arrDataColumn[j].fldName);//i + "" + j;
                        if (IsNullOrEmpty(td.className)) {
                            td.className = "text-center";
                        }
                    }
                    else {
                        td.appendChild(div1);
                    }
                    tr.appendChild(td);
                    break;
                case "Label4Bool":
                    if (IsNullOrEmpty(arrDataColumn[j].fldName) == false) {
                        const bolFldValue = objEN.GetFldValue(arrDataColumn[j].fldName);
                        if (bolFldValue == true) {
                            const spnBoolTrue = GetSpan4BoolTrue();
                            td.appendChild(spnBoolTrue);
                        }
                        else {
                            const spnBoolFalse = GetSpan4BoolFalse();
                            td.appendChild(spnBoolFalse);
                        }
                        if (IsNullOrEmpty(td.className)) {
                            td.className = "text-center";
                        }
                    }
                    else {
                        //调用外面的函数生成一个层放在该单元格中
                        const div1: HTMLDivElement = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                        td.appendChild(div1);
                    }
                    tr.appendChild(td);
                    break;
                case "Button":

                    try {
                        const strKeyValue = objEN.GetFldValue(strKey);
                        const btn1: HTMLElement = await arrDataColumn[j].funcName(strKeyValue, arrDataColumn[j].text)
                        td.appendChild(btn1);
                        //const btn1: HTMLButtonElement = document.createElement("Button");
                        //btn1.innerText = arrDataColumn[j].text;
                        //btn1.className = "btn btn-outline-info";
                        //td.appendChild(btn1);
                        ////td.appendChild(document.createTextNode(i + "" + j));
                        ////td.style.color = "#FF0000";
                        //td.className = "text-center";
                    }
                    catch (e: any) {
                        console.error(e);
                        const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":

                    try {
                        const strKeyValue = objEN.GetFldValue(strKey);
                        const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                        const btn1: HTMLElement = await arrDataColumn[j].funcName(strKeyValue, strText)
                        td.appendChild(btn1);
                        //const btn1: HTMLButtonElement = document.createElement("Button");
                        //btn1.innerText = arrDataColumn[j].text;
                        //btn1.className = "btn btn-outline-info";
                        //td.appendChild(btn1);
                        ////td.appendChild(document.createTextNode(i + "" + j));
                        ////td.style.color = "#FF0000";
                        //td.className = "text-center";
                    }
                    catch (e: any) {
                        console.error(e);
                        const strMsg = `绑定表行不成功。类型:${arrDataColumn[j].columnType},文本:${arrDataColumn[j].text}`;
                        throw (strMsg);
                    }
                    break;
                case "a":

                    try {
                        const strKeyValue = objEN.GetFldValue(strKey);
                        const strText = objEN.GetFldValue(arrDataColumn[j].fldName);
                        const objA: HTMLAnchorElement = await arrDataColumn[j].funcName(strKeyValue, strText)
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
                    catch (e: any) {
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
    arrSelectedKeys.splice(0);
}


/**
 * 隐藏对话框
 **/
export function HideDialog(strDialogName: string) {
    console.log("隐藏对话框" + strDialogName);
    //$(strDialogName).modal('hide');
}

/**
 * 显示对话框
**/
export function ShowDialog(strDialogName: string) {
    console.log("显示对话框" + strDialogName);
    //$(strDialogName).modal('show');
}


/**
* 隐藏表格行 (tr))
**/
export function HideTr(strDivName: string, strTr: string) {
    const objTr = getTrObjByIdInDiv(strDivName, strTr);
    objTr.style.visibility = "hidden";
    objTr.style.display = "none";
}

export function HideTd(strDivName: string, strTd: string) {
    const objTd = getTdObjByIdInDiv(strDivName, strTd);
    objTd.style.visibility = "hidden";
    objTd.style.display = "none";
}
/**
* 显示表格行 (tr))
**/
export function ShowTr(strDivName: string, strTr: string) {
    const objTr = getTrObjByIdInDiv(strDivName, strTr);
    objTr.style.visibility = "visible";
    objTr.style.display = "table-row";

}
export function ShowDiv(strDivName: string) {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        console.error(strMsg);
        throw (strMsg);
    }
    //objDiv4SelectFile.style.float = "center";
    //objDiv4SelectFile.style.border = "1px";
    objDiv.style.display = 'block';
    objDiv.style.visibility = "visible";//显示
    //alert(objDiv4SelectFile);
}

export function HideDiv(strDivName: string) {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        console.error(strMsg);
        throw (strMsg);
    }
    objDiv.style.display = 'none';
    objDiv.style.visibility = "hidden";//隐藏  
    //alert(objDiv4SelectFile);
}
export function GetSpan4BoolFalse(): HTMLSpanElement {
    const objSpan: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
    objSpan.classList.add("text-danger");
    objSpan.innerHTML = "×";
    return objSpan;
}
export function GetSpan4BoolTrue(): HTMLSpanElement {
    const objSpan: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
    objSpan.classList.add("text-primary");
    objSpan.innerHTML = "√";
    return objSpan;
}

/*
* 获取对象的所有属性名列表
*/
export function ObjectAssign(myObjT: any, myObjS: any): boolean {
    Object.assign(myObjT, myObjS);
    return true;
    const objTypeName_S = myObjS.constructor.name;
    const objTypeName_T = myObjT.constructor.name;

    const sstrKeys_S: Array<string> = [];

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
        for (const p1 in myObjS) {
            if (Object.prototype.hasOwnProperty.call(myObjS, p1)) {
                if (sstrKeys_S.indexOf(p1) == -1) {
                    sstrKeys_S.push(p1);
                }
            }
        }
        sstrKeys_S.push("sf_UpdFldSetStr");
        sstrKeys_S.push("sf_FldComparisonOp");
    }
    else {
        for (const p1 in myObjS) {
            if (Object.prototype.hasOwnProperty.call(myObjS, p1))
                sstrKeys_S.push(p1);
        }
    }


    const sstrKeys_T: Array<string> = [];
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
        for (const p1 in myObjT) {
            if (Object.prototype.hasOwnProperty.call(myObjT, p1)) {
                if (sstrKeys_T.indexOf(p1) == -1) {
                    sstrKeys_T.push(p1);
                }
            }
        }
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

    let value_S
    for (const strKey of sstrKeys_S) {
        if (sstrKeys_T.indexOf(strKey) == -1) continue;
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
            myObjT[strKey] = value_S
        }
    }
    return true;
}

export function ObjectAssignV2(myObjT: any, myObjS: any): boolean {
    //Object.assign(myObjT, myObjS);
    //return true;
    const objTypeName_S = myObjS.constructor.name;
    const objTypeName_T = myObjT.constructor.name;

    const sstrKeys_S: Array<string> = [];

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


    const sstrKeys_T: Array<string> = [];
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

    let value_S
    for (const strKey of sstrKeys_S) {
        if (sstrKeys_T.indexOf(strKey) == -1) continue;
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
            myObjT[strKey] = value_S
        }
    }
    return true;
}

export function GetSortExpress(objPagerPara: stuPagerPara): string {
    if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
        const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
        let strSortType = "asc";
        const strSortFld = sstrSplit[0];
        if (sstrSplit.length > 1) strSortType = sstrSplit[1];
        //arrPrjTab_Sel = arrPrjTab_Sel.sort(PrjTabEx_SortFunByKey(strSortFld, strSortType));
        return strSortFld;
    }
    return "";
}
export function GetSortExpressInfo(objPagerPara: stuPagerPara) {
    if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
        const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
        let strSortType = "asc";
        const strSortFld = sstrSplit[0];
        if (sstrSplit.length > 1) strSortType = sstrSplit[1];
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

/*
* 根据字符串的长度决定显示的宽度
*/
export function GetWidthByWordStr(strWord: string): number {
    if (strWord.length < 3) return 40;
    else if (strWord.length < 4) return 50;
    else if (strWord.length < 5) return 60;
    else if (strWord.length < 6) return 70;
    else if (strWord.length < 7) return 80;
    else if (strWord.length < 8) return 90;
    else if (strWord.length < 9) return 100;
    else if (strWord.length < 10) return 110;
    else if (strWord.length < 11) return 120;
    else return 150;
}

export function SetAllNotCkechedItem(strArrayDiv: string) {
    //获取指定数据列表层
    const divList: HTMLDivElement = document.getElementById(strArrayDiv) as HTMLDivElement;
    //根据className获取数据列表层中的所有复选框
    const chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
    //把集合转换成Array
    const arrChkLitems: Array<HTMLInputElement> = GetArray(chkItems) as Array<HTMLInputElement>;
    for (const chkItem of arrChkLitems) {
        chkItem.checked = false;
    }

}
export function GetObjValueOfKeyV2(myObj: object, strKey: string): string {
    const { keys, values, entries } = Object;
    const arrEntries = Object.entries(myObj);

    for (const [key, value] of arrEntries) {
        if (strKey == key) return value;
    }
    return "";
}
export function GetObjValueOfKey(myObj: object, strKey: string): string {

    //let { keys, values, entries } = Object;
    const arrEntries = Object.entries(myObj);
    const map = new Map(arrEntries);
    const strValue = map.get(strKey);
    return strValue;
}


export function confirm_del4Msg(strMsg: string) {
    const gnl = confirm(strMsg);
    if (gnl == true) {
        return true;
    }
    else {
        return false;
    }
}
/*
  * 绑定下拉框
  */
export function BindDdl_CboObject(strDdlName: string, arrObjLst: Array<clsCboObject>,
    strValueFldName: string, strTextFldName: string, strTabCnName: string) {
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
    sltDdl.options.length = 0;
    const strText = "选" + strTabCnName + "...";

    //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
    //objArrayItem.text = strText;
    //objArrayItem.value = "0";
    //sltDdl.options.add(objArrayItem);
    sltDdl.options.add(new Option(strText, "0"));
    let i = 0
    for (i = 0; i < arrObjLst.length; i++) {
        const objCurr = arrObjLst[i];

        sltDdl.options.add(new Option(clsCboObject.GetFldValue(objCurr, strTextFldName), clsCboObject.GetFldValue(objCurr, strValueFldName)));
    }
}

export function BindDdl_CboObjectInDiv(strDivName: string, strDdlName: string, arrObjLst: Array<clsCboObject>,
    strValueFldName: string, strTextFldName: string, strTabCnName: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strDdlName);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
        throw (strMsg);
    }

    sltDdl.options.length = 0;
    const strText = "选" + strTabCnName + "...";

    //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
    //objArrayItem.text = strText;
    //objArrayItem.value = "0";
    //sltDdl.options.add(objArrayItem);
    sltDdl.options.add(new Option(strText, "0"));
    let i = 0
    for (i = 0; i < arrObjLst.length; i++) {
        const objCurr = arrObjLst[i];

        sltDdl.options.add(new Option(clsCboObject.GetFldValue(objCurr, strTextFldName), clsCboObject.GetFldValue(objCurr, strValueFldName)));
    }
}
/*
*为下拉框绑定布尔型的值，"是","否"
*/
export function BindDdl_TrueAndFalse(ddlTrueAndFalse: string) {
    //const strWhereCond = " 1 =1 ";
    const objDdl = document.getElementById(ddlTrueAndFalse);
    if (objDdl == null) {
        const strMsg = `下拉框:${ddlTrueAndFalse} 不存在！`;
        alert(strMsg);
        throw (strMsg);
    }
    const arrTrueFalseLst: Array<clsCboObject> = [
        {
            text: "是",
            value: "01"
        },
        {
            text: "否",
            value: "02"
        },
    ]
    //在一行代码中不能同时使用两个其他类名
    //     BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
    BindDdl_CboObject(ddlTrueAndFalse, arrTrueFalseLst, "value", "text", "是/否");
    //console.log("1完成BindDdl_TrueAndFalse!");
}


/*
*为下拉框绑定布尔型的值，"是","否"
*/
export function BindDdl_TrueAndFalseInDiv(strDivName: string, ddlTrueAndFalse: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == ddlTrueAndFalse);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, ddlTrueAndFalse);
        throw (strMsg);
    }

    const arrTrueFalseLst: Array<clsCboObject> = [
        {
            text: "是",
            value: "01"
        },
        {
            text: "否",
            value: "02"
        },
    ]
    //在一行代码中不能同时使用两个其他类名
    //     clsCommFunc4Ctrl.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
    BindDdl_CboObject(ddlTrueAndFalse, arrTrueFalseLst, "value", "text", "是/否");
    //console.log("1完成BindDdl_TrueAndFalse!");
}

/*
* 根据Id获取元素,在层(Div)内查找相应元素 
*/
export function getElementByIdInDiv(strDivName: string, strControlType: string, strControlId: string): HTMLElement {
    if (IsNullOrEmpty(strControlType) == true) {
        const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", strDivName, strControlId);
        console.error(strMsg);
        throw (strMsg);
    }

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName(strControlType);
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLElement = <HTMLElement>arrElements.find(x => x.id == strControlId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[{1}]的元素:[{2}], 请检查！", strDivName, strControlType, strControlId);
        throw (strMsg);
    }
    return objElement;

}
export function myShowErrorMsg(strErrInfo: string) {
    let funCurrFunction = arguments.callee;//获取函数定义的全部内容
    const arrFuncName: Array<string>= [];
    while (funCurrFunction !== null) {
        arrFuncName.push((<any>(funCurrFunction)).name);
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
/*
 * 绑定下拉框,在层(Div)内查找相应下拉框 
 */
export function BindDdl_ObjLstInDiv(strDivName: string, strDdlName: string, arrObjLst: Array<clsGeneralTab>,
    strValueFldName: string, strTextFldName: string, strTabCnName: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strDdlName);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
        throw (strMsg);
    }
    //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
    sltDdl.options.length = 0;
    const strText = "选" + strTabCnName + "...";

    sltDdl.options.add(new Option(strText, "0")); let i = 0
    for (i = 0; i < arrObjLst.length; i++) {
        const objCurr = arrObjLst[i];

        sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
    }
}

/*
 * 绑定下拉框,在层(Div)内查找相应下拉框 
 */
export function BindDdl_ObjLstInDiv_V(strDivName: string, strDdlName: string, arrObjLst: Array<clsGeneralTabV>,
    strValueFldName: string, strTextFldName: string, strTabCnName: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strDdlName);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strDdlName);
        throw (strMsg);
    }
    //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
    sltDdl.options.length = 0;
    const strText = "选" + strTabCnName + "...";

    sltDdl.options.add(new Option(strText, "0")); let i = 0
    for (i = 0; i < arrObjLst.length; i++) {
        const objCurr = arrObjLst[i];

        sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
    }
}
/*
  * 绑定下拉框
  */
export function BindDdl_ObjLst(strDdlName: string, arrObjLst: Array<clsGeneralTab>,
    strValueFldName: string, strTextFldName: string, strTabCnName: string) {
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
    sltDdl.options.length = 0;
    const strText = "选" + strTabCnName + "...";

    //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
    //objArrayItem.text = strText;
    //objArrayItem.value = "0";
    //sltDdl.options.add(objArrayItem);
    sltDdl.options.add(new Option(strText, "0")); let i = 0
    for (i = 0; i < arrObjLst.length; i++) {
        const objCurr = arrObjLst[i];

        sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
    }
}

/*
  * 绑定下拉框
  */
export function BindDdl_ObjLst_V(strDdlName: string, arrObjLst: Array<clsGeneralTabV>,
    strValueFldName: string, strTextFldName: string, strTabCnName: string) {
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
    sltDdl.options.length = 0;
    const strText = "选" + strTabCnName + "...";

    //const objArrayItem: HTMLOptionElement = new HTMLOptionElement();
    //objArrayItem.text = strText;
    //objArrayItem.value = "0";
    //sltDdl.options.add(objArrayItem);
    sltDdl.options.add(new Option(strText, "0")); let i = 0
    for (i = 0; i < arrObjLst.length; i++) {
        const objCurr = arrObjLst[i];

        sltDdl.options.add(new Option(objCurr.GetFldValue(strTextFldName), objCurr.GetFldValue(strValueFldName)));
    }
}
/*
 * 设置使特定关键字的复选框被选
 * strKeyId:关键字
 */
export function SetNotCkechedItem4KeyId(strArrayDiv: string, strKeyId: string) {
    //获取指定数据列表层
    const divList: HTMLDivElement = document.getElementById(strArrayDiv) as HTMLDivElement;
    //根据className获取数据列表层中的所有复选框
    const chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
    //把集合转换成Array
    const arrChkLitems: Array<HTMLInputElement> = GetArray(chkItems) as Array<HTMLInputElement>;
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
export function SetAllCkechedKeysV2(tabName: HTMLDivElement, thisChk: any) {

    console.log("thisChk(In SetAllCkechedKeysV2):", thisChk);
    //event = window.event || event;
    const thisEventObj: HTMLInputElement = thisChk;

    const arrKeys = tabName.getElementsByClassName('CheckInTab');
    const bolIsCheck = thisEventObj.checked;

    const arrKeyLst: Array<HTMLInputElement> = GetArray(arrKeys) as Array<HTMLInputElement>;

    arrKeyLst.forEach((e) => e.checked = bolIsCheck);
    console.log("所选记录的个数:", arrKeys.length.toString());
}
export function GetExceptionStr(objException: any) {
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

//js获取网站根路径(站点及虚拟目录)，获得网站的根目录或虚拟目录的根地址     
export function getRootPath() {
    const strFullPath = document.location.href;
    const strPath = document.location.pathname;
    const pos = strFullPath.indexOf(strPath);
    const prePath = strFullPath.substring(0, pos);
    const postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
    return (prePath + postPath);
}
/*
   * 获取对象的所有属性名列表
   */
export function GetObjKeys(myObj: object): Array<string> {
    const sstrKeys: Array<string> = [];
    for (const p1 in myObj) {
        if (Object.prototype.hasOwnProperty.call(myObj, p1))
            sstrKeys.push(p1);
    }
    return sstrKeys;
}

export function SortFun() { }
/*
 * 重新转向本项目新的Url地址
 */
export function Redirect(LocUrl: string) {
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
    const strPathName = location.pathname; let strShortUrl = `/${strWebRoot}/${LocUrl}`;
    strShortUrl = strShortUrl.replace("//", "/");
    strShortUrl = strShortUrl.replace("//", "/");
    //显示信息框
    const strNewLink = `${strProtocol}//${strHost}${strShortUrl}`;

    console.log(strNewLink);
    window.location.href = strNewLink;
}
/*
  * 确认删除函数
  */
export function confirm_del(intCount: number) {
    let strMsg = Format("你真的确定要删除记录吗?");
    if (intCount > 0) {
        strMsg = Format("你真的确定要删除{0}条记录吗?", intCount);
    }
    const gnl = confirm(strMsg);
    if (gnl == true) {
        return true;
    }
    else {
        return false;
    }
}

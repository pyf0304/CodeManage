/*
 * 功能：为Web提供一些公共的功能函数
 * 版本：2019-08-03-01
 * 作者：潘以锋
 * */
import { clsDataColumn } from "./clsDataColumn.js";
import { clsCboObject } from "./clsCboObject2.js";

export var arrSelectedKeys: Array<string> = new Array<string>();
export function ChkClick1Bak(myThis) {
    var strId = myThis.id;
    var strKey = strId.substring(3);
    if (myThis.checked == true) {
        if (arrSelectedKeys.indexOf(strKey) < 0) {
            arrSelectedKeys.push(strKey);
        }
    }
    else {
        var index = arrSelectedKeys.indexOf(strKey);
        if (index > -1) {
            arrSelectedKeys.splice(index, 1);
        }
    }
    var sstrKey = "";
    for (let strK of arrSelectedKeys) {
        sstrKey += `${strK},`;
    }
    $('#spanResult').html(sstrKey);
}
declare function ChkClick(myThis): void;
declare function SetAllCkechedKeys(myThis): void;
declare var document;
declare var strWebRoot;

export class clsCommonFunc4WebBak {
    /// <summary>
    /// 为下拉框获取数据,从表:[College]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public static BindDdl_TrueAndFalse(ddlTrueAndFalse: string) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlTrueAndFalse);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlTrueAndFalse} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        var arrTrueFalseLst: Array<clsCboObject> = [
            {
                Text: "是",
                Value: "01"
            },
            {
                Text: "否",
                Value: "02"
            },
        ]
        clsCommonFunc4WebBak.BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, "Value", "Text", "是/否");
        console.log("完成BindDdl_TrueAndFalse!");

    }
    /*
     * 重新转向本项目新的Url地址
     */
    public static Redirect(LocUrl:string) {
        var strProtocol = location.protocol;
        var strHost = location.host;
        var strPathName = location.pathname;
        var strShortUrl = `/${strWebRoot}/${LocUrl}`;
        strShortUrl = strShortUrl.replace("//", "/");
        strShortUrl = strShortUrl.replace("//", "/");
        //显示信息框
        var strNewLink = `${strProtocol}//${strHost}${strShortUrl}`;

        console.log(strNewLink);
        window.location.href = strNewLink;
    }
    public static BindDdl_ObjLst(strDdlName: string, arrObjLst: Array<object>,
        strValueFldName: string, strTextFldName: string, strTabCnName: string) {
        var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        var strText = "请选择" + strTabCnName + "...";

        //var objListItem: HTMLOptionElement = new HTMLOptionElement();
        //objListItem.text = strText;
        //objListItem.value = "0";
        //sltDdl.options.add(objListItem);
        sltDdl.options.add(new Option(strText, "0"));

        var i = 0
        for (i = 0; i < arrObjLst.length; i++) {
            var objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
        }
    }

    //获取对象的所有属性名列表
    public static GetObjKeys(myObj: object): Array<string> {
        var sstrKeys: Array<string> = [];
        for (var p1 in myObj) {
            if (myObj.hasOwnProperty(p1))
                sstrKeys.push(p1);
        }
        return sstrKeys;
    }
    public static BindTab(divContainer: HTMLDivElement, arrUserIdentityObjLst: Array<object>, sstrFldName: Array<string>, sstrColHeader: Array<string>, strKey: string) {
        //var o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //var sstrFldName: Array<string> = new Array<string>();
        //var sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("identityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("identityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
        var table: HTMLTableElement = document.createElement("table");
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
        var trHead: HTMLTableRowElement = document.createElement("tr");
        trHead.className = "row-height";
        var td00: HTMLTableDataCellElement = document.createElement("td");
        var check00: HTMLInputElement = document.createElement("input");
        check00.type = "checkbox";
        check00.id = `chkHead`;
        check00.name = "chkHead";
        check00.className = "CheckInTab";
        //check00.attributes["onclick"] = "SetAllCkechedKeys('tab4Bind')";   
        check00.onclick = (function () {
            SetAllCkechedKeys(divContainer);
        });
        td00.appendChild(check00);
        trHead.appendChild(td00);
        for (var j = 0; j < intColNum; j++) {
            var td: HTMLTableDataCellElement = document.createElement("td");
            var a1: HTMLAnchorElement = document.createElement("a");
            a1.nodeValue = sstrColHeader[j];//i + "" + j;
            a1.text = sstrColHeader[j];//i + "" + j;
            a1.href = `javascript:SortBy('${sstrFldName[j]}');`;
            //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
            td.appendChild(a1);
            //td.appendChild(document.createTextNode(i + "" + j));
            //td.style.color = "#FF0000";
            td.className = "text-center";
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (var i = 0; i < intRowNum; i++) {
            var objUserIdentityEN: object = arrUserIdentityObjLst[i];
            var tr: HTMLTableRowElement = document.createElement("tr");
            tr.className = "row-height";
            var td0: HTMLTableDataCellElement = document.createElement("td");
            var check: HTMLInputElement = document.createElement("input");
            check.type = "checkbox";
            var strKeyValue = objUserIdentityEN[strKey];
            check.id = `chk${strKeyValue}`;
            check.name = "chkInTab";
            check.className = "CheckInTab";
            //            check.attributes["onclick"] = `ChkClick(this, '${strKeyValue}')`;
            //check.onclick = (function () {
            //    ChkClick(this);
            //});
            td0.appendChild(check);
            tr.appendChild(td0);

            for (var j = 0; j < intColNum; j++) {
                var td: HTMLTableDataCellElement = document.createElement("td");
                //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
                td.innerHTML = objUserIdentityEN[sstrFldName[j]];//i + "" + j;
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

    public static BindTabV2(divContainer: HTMLDivElement, arrUserIdentityObjLst: Array<object>, arrDataColumn: Array<clsDataColumn>, strKey: string) {
        //var o = document.getElementById("divResult13");
        //if (o == null) {
        //    alert("divResult13不存在！");
        //    return;
        //}
        //var sstrFldName: Array<string> = new Array<string>();
        //var sstrColHeader: Array<string> = new Array<string>();
        //sstrFldName.push("identityID"); sstrColHeader.push("身份Id");
        //sstrFldName.push("identityDesc"); sstrColHeader.push("身份名");
        //sstrFldName.push("memo"); sstrColHeader.push("备注");
        var table: HTMLTableElement = document.createElement("table");
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
        var trHead: HTMLTableRowElement = document.createElement("tr");
        trHead.className = "row-height";

        for (var j = 0; j < intColNum; j++) {
            var td: HTMLTableDataCellElement = document.createElement("td");
            switch (arrDataColumn[j].ColumnType) {
                case "CheckBox":             
                    var check00: HTMLInputElement = document.createElement("input");
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
                    var a1: HTMLAnchorElement = document.createElement("a");
                    a1.nodeValue = arrDataColumn[j].ColHeader;//i + "" + j;
                    a1.text = arrDataColumn[j].ColHeader;//i + "" + j;
                    a1.href = `javascript:SortBy('${arrDataColumn[j].FldName}');`;
                    //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
                    td.appendChild(a1);
                    //td.appendChild(document.createTextNode(i + "" + j));
                    //td.style.color = "#FF0000";
                    td.className = "text-center";
                    break;
                case "Button":
                    try {
                        var span1: HTMLSpanElement = document.createElement("span");
                        console.log(arrDataColumn[j].ColHeader);
                        span1.nodeValue = arrDataColumn[j].ColHeader;//i + "" + j;
                        span1.innerText = arrDataColumn[j].ColHeader;//i + "" + j;
                        //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
                        td.appendChild(span1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                    }
                    catch (e) {
                        var strMsg = `建立表头不成功。类型:${arrDataColumn[j].ColumnType},列头:${arrDataColumn[j].ColHeader}`;
                        throw (strMsg);
                    }
                    break;
                case "LinkButton":
                    try {
                        var a1: HTMLAnchorElement = document.createElement("a");
                        a1.nodeValue = arrDataColumn[j].ColHeader;//i + "" + j;
                        a1.text = arrDataColumn[j].ColHeader;//i + "" + j;
                        a1.href = `javascript:SortBy('${arrDataColumn[j].FldName}');`;
                        //                td.innerHTML = objUserIdentityEN["identityDesc"];//i + "" + j;
                        td.appendChild(a1);
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        
                    }
                    catch (e) {
                        var strMsg = `建立表头不成功。类型:${arrDataColumn[j].ColumnType},列头:${arrDataColumn[j].ColHeader}`;
                        throw (strMsg);
                    }
                    break;
            }
            trHead.appendChild(td);
        }
        tbody.appendChild(trHead);
        for (var i = 0; i < intRowNum; i++) {

            var objUserIdentityEN: object = arrUserIdentityObjLst[i];
            var tr: HTMLTableRowElement = document.createElement("tr");
            tr.className = "row-height";
            

            for (var j = 0; j < intColNum; j++) {
                var td: HTMLTableDataCellElement = document.createElement("td");
                switch (arrDataColumn[j].ColumnType) {
                    case "CheckBox":
                        var check: HTMLInputElement = document.createElement("input");
                        check.type = "checkbox";
                        var strKeyValue = objUserIdentityEN[strKey];
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
                        td.innerHTML = objUserIdentityEN[arrDataColumn[j].FldName];//i + "" + j;
                        //td.appendChild(document.createTextNode(i + "" + j));
                        //td.style.color = "#FF0000";
                        td.className = "text-center";
                        tr.appendChild(td);
                        break;
                    case "Button":

                        try {
                            var strKeyValue = objUserIdentityEN[strKey];
                            var btn1: HTMLElement = arrDataColumn[j].FuncName(strKeyValue, arrDataColumn[j].Text)
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
                            var strMsg = `绑定表行不成功。类型:${arrDataColumn[j].ColumnType},文本:${arrDataColumn[j].Text}`;
                            throw (strMsg);
                        }
                        break;
                    case "LinkButton":

                        try {
                            var strKeyValue = objUserIdentityEN[strKey];
                            var strText = objUserIdentityEN[arrDataColumn[j].FldName];
                            var btn1: HTMLElement = arrDataColumn[j].FuncName(strKeyValue, strText)
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
                            var strMsg = `绑定表行不成功。类型:${arrDataColumn[j].ColumnType},文本:${arrDataColumn[j].Text}`;
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

    public static GetCheckedKeyIds(): Array<string> {
        var divList: HTMLDivElement = document.getElementById("divList") as HTMLDivElement;
        var chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
        let arrChkLitems: Array<HTMLInputElement> = this.GetArray(chkItems) as Array<HTMLInputElement>;

        var chkCheckedItems: Array<HTMLInputElement> = arrChkLitems.filter((x) => x.checked == true);

        var arrSelectedKeys: Array<string> =
            chkCheckedItems.map((x) => {
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

    public static GetFirstCheckedKeyId(): string {
        var divList: HTMLDivElement = document.getElementById("divList") as HTMLDivElement;
        var chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
        let arrChkLitems: Array<HTMLInputElement> = this.GetArray(chkItems) as Array<HTMLInputElement>;

        var chkCheckedItems: Array<HTMLInputElement> = arrChkLitems.filter((x) => x.checked == true);


        var intCheckedCount = chkCheckedItems.length;
        for (var i = 0; i < intCheckedCount; i++) {
            var chkItem: HTMLInputElement = chkCheckedItems[i] as HTMLInputElement;
            var strId = chkItem.id;
            var strKey = strId.substring(3);
            return strKey;
        }
        //    alert(intCount.toString() + "::" + intCheckedCount.toString());
        return "";
    }
    public static SetAllCkechedKeys(tabName: HTMLDivElement, thisChk: HTMLInputElement) {
        var arrKeys = tabName.getElementsByClassName('CheckInTab');
        //var thisChk = EventTarget;//
        //var thisChk: HTMLInputElement = e.target as HTMLInputElement;  tabName.getElementsByClassName;// EventTarget as HTMLInputElement;
        var bolIsCheck = thisChk.checked;
        console.log(bolIsCheck);
        let arrKeyLst: Array<HTMLInputElement> = this.GetArray(arrKeys) as Array<HTMLInputElement>;

        arrKeyLst.forEach((e) => e.checked = bolIsCheck);
        alert(arrKeys.length.toString());
    }
    public static GetArray(arr): Array<HTMLElement> {
        let arrLst: Array<HTMLElement> = new Array<HTMLElement>();
        for (var i = 0; i < arr.length; i++) {
            var chk: HTMLElement = arr[i];// as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    public static Test1(): string {
        return "Test1";
    }
}

import { clsCboObject } from "./clsCboObject.js";
import { Format, IsNullOrEmpty } from "./clsString.js";

export class clsCommFunc4CtrlBak {

    public static insertAfter(newElement: HTMLElement, targetElement: HTMLElement) {
        const parent = targetElement.parentNode; //获取目标节点的父级标签
        if (parent == null) {
            console.error("当前结点没有父结点！", targetElement);
            return;
        }
        if (parent.lastChild == targetElement) {//如果目标节点正好是最后一个节点，使用appendChild插入
            parent.appendChild(newElement);

        } else {
            parent.insertBefore(newElement, targetElement.nextSibling);//一般情况下要取得目标节点的下一个节点，再使用insertBefore()方法。

        }

    }

    public static getHiddenValue(strDivName: string, strControlId: string): string {
        //if (IsNullOrEmpty(strControlType) == true) {
        //    const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", strDivName, strControlId);
        //    console.error(strMsg);
        //    throw (strMsg);
        //}

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrElements0);
        const objElement: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strControlId);
        if (objElement == null) {
            const strMsg = Format("在层:[{0}]内，不存在元素:[{1}], 请检查！", strDivName, strControlId);
            console.error(strMsg);
            return "";
        }
        return objElement.value;

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

    /**
* 获取在层下Select控件的值
* @param strDivId : 层Id
* @param strSelectId 下拉框Id
* @returns 字符型
**/
    public static GetSelectValueInDiv(strDivId: string, strSelectId: string): string {

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrSelect = objDiv.getElementsByTagName("select");
        const arrElements = GetArray(arrSelect);
        const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
        if (sltDdl == null) {
            const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
            throw (strMsg);
        }
        if (sltDdl.selectedIndex < 0) return "";
        const objOption_Sel = sltDdl.options[sltDdl.selectedIndex];
        const strValue = objOption_Sel.value;
        return strValue;
    }
    public static GetInputValueInDiv(strDivId: string, strInputId: string): string {
        //const objDiv = $(`#${strDivId}`);
        //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objInput: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = Format("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
            throw (strMsg);
        }
        const strValue = objInput.value;
        return strValue;

    }
    public static GetCheckBoxValueInDiv(strDivId: string, strCheckId: string): boolean {
        //const objDiv = $(`#${strDivId}`);
        //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objCheck: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strCheckId);
        if (objCheck == null) {
            const strMsg = Format("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
            throw (strMsg);
        }
        const bolValue = objCheck.checked;
        return bolValue;

    }

    public static GetLabelHtmlInDiv(strDivId: string, strLabelId: string): string {

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrlabel = objDiv.getElementsByTagName("label");
        const arrElements = GetArray(arrlabel);
        const objLabel: HTMLLabelElement = <HTMLLabelElement>arrElements.find(x => x.id == strLabelId);
        if (objLabel == null) {
            const strMsg = Format("在层:[{0}]内，不存在Label:[{1}], 请检查！", strDivId, strLabelId);
            throw (strMsg);
        }
        const strValue = objLabel.innerHTML;
        return strValue;
    }

    public static GetButtonHtmlInDiv(strDivId: string, strButtonId: string): string {

        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrButton = objDiv.getElementsByTagName("button");
        const arrElements = GetArray(arrButton);
        const objButton: HTMLButtonElement = <HTMLButtonElement>arrElements.find(x => x.id == strButtonId);
        if (objButton == null) {
            const strMsg = Format("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivId, strButtonId);
            throw (strMsg);
        }
        const strValue = objButton.innerHTML;
        return strValue;
    }

    public static CheckControlExist(divName: string, strControlType: string, strControlId: string): void {
        if (IsNullOrEmpty(strControlType) == true) {
            const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", divName, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDiv = <HTMLDivElement>document.getElementById(divName);
        if (objDiv == null) {
            const strMsg = Format("层:{0}不存在, 请检查！", divName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName(strControlType);
        const arrElements = GetArray(arrInput);
        const arrElements_Sel = arrElements.filter(x => x.id == strControlId);

        if (arrElements_Sel.length == 0) {
            const strMsg = Format("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    public static SetSelectValueByIdInDiv(strDivId: string, strSelectId: string, strValue: string) {
        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSelect = objDiv.getElementsByTagName("select");
        const arrElements = GetArray(arrSelect);
        const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
        if (sltDdl == null) {
            const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
            console.error(strMsg);
            throw (strMsg);
        }

        //    const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
        //    if (objSelect == null) {
        //        console.error(`在设置下拉框值时，控件：${strSelectId}不存在！`);
        //        return;
        //    }
        if (sltDdl.options.length == 0) {
            if (IsNullOrEmpty(strValue) == true) return;
            const strMsg = Format("在层:[{0}]内，下拉框:[{1}]可能还没有绑定, 请检查！", strDivId, strSelectId);
            console.error(strMsg);
            throw (strMsg);
        }
        for (let i = 0; i < sltDdl.options.length; i++) {
            if (sltDdl.options[i].value == strValue) {
                sltDdl.selectedIndex = i;
                return;
            }
        }
        if (IsNullOrEmpty(strValue) == false) {
            const strMsg = Format("在层:[{0}]内，下拉框:[{1}]不能赋值:[{2}], 请检查！", strDivId, strSelectId, strValue);
            console.error(strMsg);
        }
    }
    public static SetCheckBoxValueByIdInDiv(strDivId: string, strCheckId: string, bolValue: boolean) {
        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objCheck: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strCheckId);
        if (objCheck == null) {
            const strMsg = Format("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
            throw (strMsg);
        }
        objCheck.checked = bolValue;

    }

    public static SetInputValueByIdInDiv(strDivId: string, strInputId: string, strValue: string) {
        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objInput: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = Format("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
            throw (strMsg);
        }
        objInput.value = strValue;

    }
    public static SetLabelHtmlByIdInDiv(strDivId: string, strLabelId: string, strValue: string) {
        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
            throw (strMsg);
        }
        const arrLabel = objDiv.getElementsByTagName("label");
        const arrElements = GetArray(arrLabel);
        const objLabel: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strLabelId);
        if (objLabel == null) {
            const strMsg = Format("在层:[{0}]内，不存在Label框:[{1}], 请检查！", strDivId, strLabelId);
            throw (strMsg);
        }
        objLabel.innerHTML = strValue;

    }
    
    public static GetCheckedObjLstInDiv(strDivId: string): Array<HTMLInputElement> {
        const divList: HTMLDivElement = document.getElementById(strDivId) as HTMLDivElement;

        const arrInput = divList.getElementsByTagName("input");
        const arrElements = <Array<HTMLInputElement>>GetArray(arrInput);
        const arrCheckBox = arrElements.filter(x => x.type == "checkbox" && x.checked == true);
        if (arrCheckBox == null) {
            const strMsg = Format("在层:[{0}]内，不存在复选框, 请检查！", strDivId);
            throw (strMsg);
        }
        return arrCheckBox;

    }
    public static GetCheckedKeyIdsInDiv(strDivName4List: string): Array<string> {
        const divList: HTMLDivElement = document.getElementById(strDivName4List) as HTMLDivElement;
        const chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
        const arrChkLitems: Array<HTMLInputElement> = this.GetArray(chkItems) as Array<HTMLInputElement>;

        const chkCheckedItems: Array<HTMLInputElement> = arrChkLitems.filter((x) => x.checked == true);

        const arrSelectedKeys: Array<string> =
            chkCheckedItems
                .filter(x => x.id != 'chkTabHead')
                .map((x) => {
                    const strId = x.id;
                    const strKey = strId.substring(3);
                    return strKey;
                });
        return arrSelectedKeys;
    }

    //    /*
    //* 根据Id获取元素,在层(Div)内查找相应元素
    //*/
    //    public static getElementByIdInDiv(strDivName: string, strControlType: string, strControlId: string): HTMLElement {
    //        if (IsNullOrEmpty(strControlType) == true) {
    //            const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", strDivName, strControlId);
    //            console.error(strMsg);
    //            throw (strMsg);
    //        }

    //        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    //        if (objDiv == null) {
    //            const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
    //            throw (strMsg);
    //        }
    //        const arrElements0 = objDiv.getElementsByTagName(strControlType);
    //        const arrElements = GetArray(arrElements0);
    //        const objElement: HTMLElement = <HTMLElement>arrElements.find(x => x.id == strControlId);
    //        if (objElement == null) {
    //            const strMsg = Format("在层:[{0}]内，不存在类型为:[{1}]的元素:[{2}], 请检查！", strDivName, strControlType, strControlId);
    //            throw (strMsg);
    //        }
    //        return objElement;

    //    }

    /**
    * 在层中根据Span对象的Id获取相关对象
    * @param strDivName: 层名
    * @param strSpanId: Span元素的Id
    * @returns 返回获取的对象，如果不存在就抛出错误信息
    */
    public static GetSpanObjInDiv(strDivName: string, strSpanId: string): HTMLSpanElement {
        const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
            throw (strMsg);
        }
        const arrSpan = objDiv.getElementsByTagName("span");
        const arrElements = GetArray(arrSpan);
        const objSpan: HTMLSpanElement = <HTMLSpanElement>arrElements.find(x => x.id == strSpanId);
        if (objSpan == null) {
            const strMsg = Format("在层:[{0}]内，不存在Span控件:[{1}], 请检查！", strDivName, strSpanId);
            throw (strMsg);
        }
        return objSpan;
    }

    /*
     * 绑定下拉框
     */
    public static BindDdl_CboObject(strDdlName: string, arrObjLst: Array<clsCboObject>,
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


    public static HideA(strAName: string) {

        const objA: HTMLAnchorElement = <HTMLAnchorElement>document.getElementById(strAName);
        if (objA == null) {
            const strMsg = Format("超链接:[{0}]在该界面不存在！", strAName);
            console.error(strMsg);
            throw (strMsg);
        }
        objA.style.display = 'none';
        objA.style.visibility = "hidden";//隐藏  
        //alert(objDiv4SelectFile);
    }

    public static ShowA(strAName: string) {

        const objA: HTMLAnchorElement = <HTMLAnchorElement>document.getElementById(strAName);
        if (objA == null) {
            const strMsg = Format("超链接:[{0}]在该界面不存在！", strAName);
            console.error(strMsg);
            throw (strMsg);
        }
        objA.style.display = 'block';
        objA.style.visibility = "visible";//显示     
    }

}

export function GetCheckedObjLstInDiv(strDivId: string): Array<HTMLInputElement> {
    const divList: HTMLDivElement = document.getElementById(strDivId) as HTMLDivElement;

    const arrInput = divList.getElementsByTagName("input");
    const arrElements = <Array<HTMLInputElement>>GetArray(arrInput);
    const arrCheckBox = arrElements.filter(x => x.type == "checkbox" && x.checked == true);
    if (arrCheckBox == null) {
        const strMsg = Format("在层:[{0}]内，不存在复选框, 请检查！", strDivId);
        throw (strMsg);
    }
    return arrCheckBox;

}

export function GetCheckedKeyIdsInDiv(strDivName4List: string): Array<string> {
    const divList: HTMLDivElement = document.getElementById(strDivName4List) as HTMLDivElement;
    const chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
    const arrChkLitems: Array<HTMLInputElement> = GetArray(chkItems) as Array<HTMLInputElement>;

    const chkCheckedItems: Array<HTMLInputElement> = arrChkLitems.filter((x) => x.checked == true);

    const arrSelectedKeys: Array<string> =
        chkCheckedItems
            .filter(x => x.id != 'chkTabHead')
            .map((x) => {
                const strId = x.id;
                const strKey = strId.substring(3);
                return strKey;
            });
    return arrSelectedKeys;
}

/*
 * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
 */
export function GetArray(arr: any): Array<HTMLElement> {
    const arrLst: Array<HTMLElement> = new Array<HTMLElement>();
    for (let i = 0; i < arr.length; i++) {
        const chk: HTMLElement = arr[i];// as HTMLElement;
        arrLst.push(chk);
    }
    return arrLst;
}
/**
* 获取在层下Select控件的值
* @param strDivId : 层Id
* @param strSelectId 下拉框Id
* @returns 字符型
**/
export function GetSelectValueInDiv(strDivId: string, strSelectId: string): string {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
        throw (strMsg);
    }
    if (sltDdl.selectedIndex < 0) return "";
    const objOption_Sel = sltDdl.options[sltDdl.selectedIndex];
    const strValue = objOption_Sel.value;
    return strValue;
}
export function SetSelectValueByIdInDiv(strDivId: string, strSelectId: string, strValue: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        console.error(strMsg);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
        console.error(strMsg);
        throw (strMsg);
    }

    //    const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
    //    if (objSelect == null) {
    //        console.error(`在设置下拉框值时，控件：${strSelectId}不存在！`);
    //        return;
    //    }
    if (sltDdl.options.length == 0) {
        if (IsNullOrEmpty(strValue) == true) return;
        const strMsg = Format("在层:[{0}]内，下拉框:[{1}]可能还没有绑定, 请检查！", strDivId, strSelectId);
        console.error(strMsg);
        throw (strMsg);
    }
    for (let i = 0; i < sltDdl.options.length; i++) {
        if (sltDdl.options[i].value == strValue) {
            sltDdl.selectedIndex = i;
            return;
        }
    }
    if (IsNullOrEmpty(strValue) == false) {
        const strMsg = Format("在层:[{0}]内，下拉框:[{1}]不能赋值:[{2}], 请检查！", strDivId, strSelectId, strValue);
        console.error(strMsg);
    }
}

export function GetInputValueInDiv(strDivId: string, strInputId: string): string {
    //const objDiv = $(`#${strDivId}`);
    //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrInput);
    const objInput: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strInputId);
    if (objInput == null) {
        const strMsg = Format("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
        throw (strMsg);
    }
    const strValue = objInput.value;
    return strValue;
}
export function SetInputValueByIdInDiv(strDivId: string, strInputId: string, strValue: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrInput);
    const objInput: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strInputId);
    if (objInput == null) {
        const strMsg = Format("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
        throw (strMsg);
    }
    objInput.value = strValue;

}

export function SetLabelHtmlByIdInDiv(strDivId: string, strLabelId: string, strValue: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrLabel = objDiv.getElementsByTagName("label");
    const arrElements = GetArray(arrLabel);
    const objLabel: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strLabelId);
    if (objLabel == null) {
        const strMsg = Format("在层:[{0}]内，不存在Label框:[{1}], 请检查！", strDivId, strLabelId);
        throw (strMsg);
    }
    objLabel.innerHTML = strValue;

}


export function SetSpanHtmlByIdInDiv(strDivId: string, strSpanId: string, strValue: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrLabel = objDiv.getElementsByTagName("span");
    const arrElements = GetArray(arrLabel);
    const objLabel: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strSpanId);
    if (objLabel == null) {
        const strMsg = Format("在层:[{0}]内，不存在Span框:[{1}], 请检查！", strDivId, strSpanId);
        throw (strMsg);
    }
    objLabel.innerHTML = strValue;

}


export function GetLabelHtmlInDiv(strDivId: string, strLabelId: string): string {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrlabel = objDiv.getElementsByTagName("label");
    const arrElements = GetArray(arrlabel);
    const objLabel: HTMLLabelElement = <HTMLLabelElement>arrElements.find(x => x.id == strLabelId);
    if (objLabel == null) {
        const strMsg = Format("在层:[{0}]内，不存在Label:[{1}], 请检查！", strDivId, strLabelId);
        throw (strMsg);
    }
    const strValue = objLabel.innerHTML;
    return strValue;
}
export function GetCheckBoxValueInDiv(strDivId: string, strCheckId: string): boolean {
    //const objDiv = $(`#${strDivId}`);
    //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrInput);
    const objCheck: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strCheckId);
    if (objCheck == null) {
        const strMsg = Format("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
        throw (strMsg);
    }
    const bolValue = objCheck.checked;
    return bolValue;

}

export function GetButtonHtmlInDiv(strDivId: string, strButtonId: string): string {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrButton = objDiv.getElementsByTagName("button");
    const arrElements = GetArray(arrButton);
    const objButton: HTMLButtonElement = <HTMLButtonElement>arrElements.find(x => x.id == strButtonId);
    if (objButton == null) {
        const strMsg = Format("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivId, strButtonId);
        throw (strMsg);
    }
    const strValue = objButton.innerHTML;
    return strValue;
}
export function SetCheckBoxValueByIdInDiv(strDivId: string, strCheckId: string, bolValue: boolean) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrInput);
    const objCheck: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strCheckId);
    if (objCheck == null) {
        const strMsg = Format("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
        throw (strMsg);
    }
    objCheck.checked = bolValue;

}

export function CheckControlExist(divName: string, strControlType: string, strControlId: string): void {
    if (IsNullOrEmpty(strControlType) == true) {
        const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", divName, strControlId);
        console.error(strMsg);
        throw (strMsg);
    }
    const objDiv = <HTMLDivElement>document.getElementById(divName);
    if (objDiv == null) {
        const strMsg = Format("层:{0}不存在, 请检查！", divName);
        console.error(strMsg);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName(strControlType);
    const arrElements = GetArray(arrInput);
    const arrElements_Sel = arrElements.filter(x => x.id == strControlId);

    if (arrElements_Sel.length == 0) {
        const strMsg = Format("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
        console.error(strMsg);
        throw (strMsg);
    }
}

/*
 * 检查层是否存在？
 */
export function CheckDivExist(divName: string): void {
    const objDiv = <HTMLDivElement>document.getElementById(divName);
    if (objDiv == null) {
        const strMsg = Format("层:{0}不存在, 请检查！", divName);
        console.error(strMsg);
        throw (strMsg);
    }
}

export function SetButtonHtmlByIdInDiv(strDivId: string, strButtonId: string, strValue: string) {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrButton = objDiv.getElementsByTagName("button");
    const arrElements = GetArray(arrButton);
    const objButton: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strButtonId);
    if (objButton == null) {
        const strMsg = Format("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivId, strButtonId);
        throw (strMsg);
    }
    objButton.innerHTML = strValue;

}

export function getTdObjByIdInDiv(strDivName: string, strTdId: string): HTMLTableColElement {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("td");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLTableColElement = <HTMLTableColElement>arrElements.find(x => x.id == strTdId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[td]的元素:[{1}], 请检查！", strDivName, strTdId);
        throw (strMsg);
    }
    return objElement;

}
export function getTrObjByIdInDiv(strDivName: string, strTrId: string): HTMLTableRowElement {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("tr");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLTableRowElement = <HTMLTableRowElement>arrElements.find(x => x.id == strTrId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[tr]的元素:[{1}], 请检查！", strDivName, strTrId);
        throw (strMsg);
    }
    return objElement;

}
export function GetCheckObjInDiv(strDivName: string, strCheckId: string): HTMLInputElement {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrInput);
    const objInput: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strCheckId);
    if (objInput == null) {
        const strMsg = Format("在层:[{0}]内，不存在Input控件:[{1}], 请检查！", strDivName, strCheckId);
        throw (strMsg);
    }
    return objInput;

}
/**
* 在层中根据Select对象的Id获取相关对象
* @param strDivName: 层名
* @param strSelectId: Select元素的Id
* @returns 返回获取的对象，如果不存在就抛出错误信息
*/
export function GetSelectObjInDiv(strDivName: string, strSelectId: string): HTMLSelectElement {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrSelect = objDiv.getElementsByTagName("select");
    const arrElements = GetArray(arrSelect);
    const sltDdl: HTMLSelectElement = <HTMLSelectElement>arrElements.find(x => x.id == strSelectId);
    if (sltDdl == null) {
        const strMsg = Format("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strSelectId);
        throw (strMsg);
    }
    return sltDdl;

}

/*
   * 设置使特定关键字的复选框被选
   * strKeyId:关键字
   */
export function SetCheckedItem4KeyId(strArrayDiv: string, strKeyId: string) {
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
    chk4KeyId.checked = true;
}
export function GetLabelValueInDiv(strDivId: string, strLabelId: string): string {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivId);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivId);
        throw (strMsg);
    }
    const arrlabel = objDiv.getElementsByTagName("label");
    const arrElements = GetArray(arrlabel);
    const objLabel: HTMLLabelElement = <HTMLLabelElement>arrElements.find(x => x.id == strLabelId);
    if (objLabel == null) {
        const strMsg = Format("在层:[{0}]内，不存在Label:[{1}], 请检查！", strDivId, strLabelId);
        throw (strMsg);
    }
    const strValue = objLabel.innerText;
    return strValue;
}

/**
 * 在层中根据Button对象的Id获取相关对象
 * @param strDivName: 层名
 * @param strButtonId: Button元素的Id
 * @returns 返回获取的对象，如果不存在就抛出错误信息
 */
export function GetButtonObjInDiv(strDivName: string, strButtonId: string): HTMLButtonElement {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        console.error(strMsg);
        throw (strMsg);
    }
    const arrButton = objDiv.getElementsByTagName("button");
    const arrElements = GetArray(arrButton);
    const objButton: HTMLButtonElement = <HTMLButtonElement>arrElements.find(x => x.id == strButtonId);
    if (objButton == null) {
        const strMsg = Format("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivName, strButtonId);
        throw (strMsg);
    }
    return objButton;

}
export function HideButtonInDiv(strDivName: string, strButtonId: string) {

    const objButton = getButtonObjByIdInDiv(strDivName, strButtonId);
    objButton.style.visibility = "hidden";
    objButton.style.display = "none";

}
export function ShowDivInDivV2(strDivName: string, strDivIdIn: string) {

    const objDiv = getDivObjByIdInDiv(strDivName, strDivIdIn);
    objDiv.style.visibility = "visible";
    objDiv.style.display = "table-row";

}
export function HideDivInDiv(strDivName: string, strDivIdIn: string) {

    const objDiv = getDivObjByIdInDiv(strDivName, strDivIdIn);
    objDiv.style.visibility = "hidden";
    objDiv.style.display = "none";

}
export function getButtonObjByIdInDiv(strDivName: string, strButtonId: string): HTMLButtonElement {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("button");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLButtonElement = <HTMLButtonElement>arrElements.find(x => x.id == strButtonId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[button]的元素:[{1}], 请检查！", strDivName, strButtonId);
        throw (strMsg);
    }
    return objElement;

}

export function getDivObjByIdInDiv(strDivName: string, strDivIdIn: string): HTMLDivElement {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("div");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLDivElement = <HTMLDivElement>arrElements.find(x => x.id == strDivIdIn);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[div]的元素:[{1}], 请检查！", strDivName, strDivIdIn);
        throw (strMsg);
    }
    return objElement;

}

export function ShowDivInDiv(strDivName: string, strDivIdIn: string) {

    const objDiv = getDivObjByIdInDiv(strDivName, strDivIdIn);
    objDiv.style.visibility = "visible";
    objDiv.style.display = "block";
}

export function ShowButtonInDiv(strDivName: string, strButtonId: string) {

    const objButton = getButtonObjByIdInDiv(strDivName, strButtonId);
    objButton.style.visibility = "visible";
    objButton.style.display = "block";

}
/*
    * 获取列表中第一个选中的复选框的关键字
    */
export function GetFirstCheckedKeyIdInDiv(divListName: string): string {
    const divList: HTMLDivElement = document.getElementById(divListName) as HTMLDivElement;
    const chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
    const arrChkLitems: Array<HTMLInputElement> = GetArray(chkItems) as Array<HTMLInputElement>;

    const chkCheckedItems: Array<HTMLInputElement> = arrChkLitems.filter((x) => x.checked == true);

    const intCheckedCount = chkCheckedItems.length;
    for (let i = 0; i < intCheckedCount; i++) {

        const chkItem: HTMLInputElement = chkCheckedItems[i] as HTMLInputElement;
        if (chkItem.id == 'chkTabHead') continue;
        const strId = chkItem.id;
        const strKey = strId.substring(3);
        return strKey;
    }
    //    alert(intCount.toString() + "::" + intCheckedCount.toString());
    return "";
}
export function getAObjByIdInDiv(strDivName: string, strAId: string): HTMLAnchorElement {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("a");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLAnchorElement = <HTMLAnchorElement>arrElements.find(x => x.id == strAId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[a]的元素:[{1}], 请检查！", strDivName, strAId);
        throw (strMsg);
    }
    return objElement;

}
export function getLiObjByIdInDiv(strDivName: string, strLiId: string): HTMLLIElement {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("li");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLLIElement = <HTMLLIElement>arrElements.find(x => x.id == strLiId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在类型为:[li]的元素:[{1}], 请检查！", strDivName, strLiId);
        throw (strMsg);
    }
    return objElement;

}
export function SetInputReadOnly(strDivName: string, strControlId: string, bolIsReadOnly: boolean): void {

    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        console.error(strMsg);
        throw (strMsg);
    }
    const arrElements0 = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrElements0);
    const objElement: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strControlId);
    if (objElement == null) {
        const strMsg = Format("在层:[{0}]内，不存在元素:[{1}], 请检查！", strDivName, strControlId);
        console.error(strMsg);
        return;
    }
    objElement.readOnly = bolIsReadOnly;

}

/*
  * 把字符串列表转换成唯一性字符串列表
  * 
  */
export function GetDistinctArray(arrStrLst: Array<string>): Array<string> {

    const setStrLst = new Set(arrStrLst);
    const arrStrLst_New: Array<string> = Array.from(setStrLst);
    return arrStrLst_New;
}
/**
  * 在层中根据Input对象的Id获取相关对象
  * @param strDivName: 层名
  * @param strInputId: Input元素的Id
  * @returns 返回获取的对象，如果不存在就抛出错误信息
  */
export function GetInputObjInDiv(strDivName: string, strInputId: string): HTMLInputElement {
    const objDiv: HTMLDivElement = <HTMLDivElement>document.getElementById(strDivName);
    if (objDiv == null) {
        const strMsg = Format("层:[{0}]在该界面不存在！", strDivName);
        throw (strMsg);
    }
    const arrInput = objDiv.getElementsByTagName("input");
    const arrElements = GetArray(arrInput);
    const objInput: HTMLInputElement = <HTMLInputElement>arrElements.find(x => x.id == strInputId);
    if (objInput == null) {
        const strMsg = Format("在层:[{0}]内，不存在Input控件:[{1}], 请检查！", strDivName, strInputId);
        throw (strMsg);
    }
    return objInput;

}


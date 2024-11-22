(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsCboObject.js", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.GetArray_Svg = exports.IsExistDiv = exports.GetFirstCheckedKeyLstInDiv = exports.GetCheckedKeyLstsInDiv = exports.GetA_Empty = exports.GetButton_Empty = exports.GetLabel_Empty = exports.GetDiv_Empty = exports.GetTd_Empty = exports.GetTr_Empty = exports.GetTable_Empty = exports.GetSelect_Empty = exports.GetTextBox_Empty = exports.GetTextArea_Empty = exports.GetBr_Empty = exports.GetSpan_Empty = exports.GetUl_Empty = exports.GetLi_Empty = exports.GetInputObjInDiv = exports.differenceSet = exports.unionSet = exports.intersectSets = exports.GetDistinctArray = exports.SetInputReadOnly = exports.getLiObjByIdInDiv = exports.getAObjByIdInDiv = exports.GetFirstCheckedKeyIdInDiv = exports.ShowButtonInDiv = exports.ShowDivInDiv = exports.getDivObjByIdInDiv = exports.getDivObjById = exports.getButtonObjByIdInDiv = exports.HideDivInDiv = exports.ShowDivInDivV2 = exports.HideButtonInDiv = exports.GetButtonObjInDiv = exports.GetLabelValueInDiv = exports.SetCheckedItem4KeyId = exports.GetSelectObjInDiv = exports.GetCheckObjInDiv = exports.getTrObjByIdInDiv = exports.getTdObjByIdInDiv = exports.SetButtonHtmlByIdInDiv = exports.CheckDivExist = exports.CheckControlExist = exports.SetCheckBoxValueByIdInDiv = exports.GetButtonHtmlInDiv = exports.GetCheckBoxObjInDiv = exports.GetCheckBoxValueInDiv = exports.GetLabelHtmlInDiv = exports.SetH4HtmlByIdInDiv = exports.SetSpanHtmlByIdInDiv = exports.SetLabelHtmlByIdInDiv = exports.SetInputValueByIdInDiv = exports.GetInputValueInDiv = exports.GetInputValue = exports.SetTextAreaValueByIdInDiv = exports.GetTextAreaValueInDiv = exports.SetSelectValueByIdInDiv = exports.GetSelectValueInDiv = exports.GetArray = exports.GetCheckedKeyIdsInDiv = exports.GetCheckedObjLstInDiv = exports.clsCommFunc4CtrlBak = void 0;
    const clsCboObject_js_1 = require("./clsCboObject.js");
    const clsString_js_1 = require("./clsString.js");
    class clsCommFunc4CtrlBak {
        static insertAfter(newElement, targetElement) {
            const parent = targetElement.parentNode; //获取目标节点的父级标签
            if (parent == null) {
                console.error("当前结点没有父结点！", targetElement);
                return;
            }
            if (parent.lastChild == targetElement) { //如果目标节点正好是最后一个节点，使用appendChild插入
                parent.appendChild(newElement);
            }
            else {
                parent.insertBefore(newElement, targetElement.nextSibling); //一般情况下要取得目标节点的下一个节点，再使用insertBefore()方法。
            }
        }
        static getHiddenValue(strDivName, strControlId) {
            //if (IsNullOrEmpty(strControlType) == true) {
            //    const strMsg = Format("在层:{0}中查找控件:[{1}]时, 类型不能为空！", strDivName, strControlId);
            //    console.error(strMsg);
            //    throw (strMsg);
            //}
            const objDiv = document.getElementById(strDivName);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrElements0 = objDiv.getElementsByTagName("input");
            const arrElements = GetArray(arrElements0);
            const objElement = arrElements.find(x => x.id == strControlId);
            if (objElement == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在元素:[{1}], 请检查！", strDivName, strControlId);
                console.error(strMsg);
                return "";
            }
            return objElement.value;
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
        /**
    * 获取在层下Select控件的值
    * @param strDivId : 层Id
    * @param strSelectId 下拉框Id
    * @returns 字符型
    **/
        static GetSelectValueInDiv(strDivId, strSelectId) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrSelect = objDiv.getElementsByTagName("select");
            const arrElements = GetArray(arrSelect);
            const sltDdl = arrElements.find(x => x.id == strSelectId);
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
                console.error(strMsg);
                throw (strMsg);
            }
            if (sltDdl.selectedIndex < 0)
                return "";
            const objOption_Sel = sltDdl.options[sltDdl.selectedIndex];
            const strValue = objOption_Sel.value;
            return strValue;
        }
        static GetInputValueInDiv(strDivId, strInputId) {
            //const objDiv = $(`#${strDivId}`);
            //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrInput = objDiv.getElementsByTagName("input");
            const arrElements = GetArray(arrInput);
            const objInput = arrElements.find(x => x.id == strInputId);
            if (objInput == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
                console.error(strMsg);
                throw (strMsg);
            }
            const strValue = objInput.value;
            return strValue;
        }
        static GetCheckBoxValueInDiv(strDivId, strCheckId) {
            //const objDiv = $(`#${strDivId}`);
            //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrInput = objDiv.getElementsByTagName("input");
            const arrElements = GetArray(arrInput);
            const objCheck = arrElements.find(x => x.id == strCheckId);
            if (objCheck == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
                console.error(strMsg);
                throw (strMsg);
            }
            const bolValue = objCheck.checked;
            return bolValue;
        }
        static GetLabelHtmlInDiv(strDivId, strLabelId) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrlabel = objDiv.getElementsByTagName("label");
            const arrElements = GetArray(arrlabel);
            const objLabel = arrElements.find(x => x.id == strLabelId);
            if (objLabel == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Label:[{1}], 请检查！", strDivId, strLabelId);
                console.error(strMsg);
                throw (strMsg);
            }
            const strValue = objLabel.innerHTML;
            return strValue;
        }
        static GetButtonHtmlInDiv(strDivId, strButtonId) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrButton = objDiv.getElementsByTagName("button");
            const arrElements = GetArray(arrButton);
            const objButton = arrElements.find(x => x.id == strButtonId);
            if (objButton == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivId, strButtonId);
                console.error(strMsg);
                throw (strMsg);
            }
            const strValue = objButton.innerHTML;
            return strValue;
        }
        static CheckControlExist(divName, strControlType, strControlId) {
            if ((0, clsString_js_1.IsNullOrEmpty)(strControlType) == true) {
                const strMsg = (0, clsString_js_1.Format)("在层:{0}中查找控件:[{1}]时, 类型不能为空！", divName, strControlId);
                console.error(strMsg);
                throw (strMsg);
            }
            const objDiv = document.getElementById(divName);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:{0}不存在, 请检查！", divName);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrInput = objDiv.getElementsByTagName(strControlType);
            const arrElements = GetArray(arrInput);
            const arrElements_Sel = arrElements.filter(x => x.id == strControlId);
            if (arrElements_Sel.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
                console.error(strMsg);
                throw (strMsg);
            }
        }
        static SetSelectValueByIdInDiv(strDivId, strSelectId, strValue) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrSelect = objDiv.getElementsByTagName("select");
            const arrElements = GetArray(arrSelect);
            const sltDdl = arrElements.find(x => x.id == strSelectId);
            if (sltDdl == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
                console.error(strMsg);
                throw (strMsg);
            }
            //    const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
            //    if (objSelect == null) {
            //        console.error(`在设置下拉框值时，控件：${strSelectId}不存在！`);
            //        return;
            //    }
            if (sltDdl.options.length == 0) {
                if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                    return;
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，下拉框:[{1}]可能还没有绑定, 请检查！", strDivId, strSelectId);
                console.error(strMsg);
                throw (strMsg);
            }
            for (let i = 0; i < sltDdl.options.length; i++) {
                if (sltDdl.options[i].value == strValue) {
                    sltDdl.selectedIndex = i;
                    return;
                }
            }
            if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == false) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，下拉框:[{1}]不能赋值:[{2}], 请检查！", strDivId, strSelectId, strValue);
                console.error(strMsg);
                throw (strMsg);
            }
        }
        static SetCheckBoxValueByIdInDiv(strDivId, strCheckId, bolValue) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrInput = objDiv.getElementsByTagName("input");
            const arrElements = GetArray(arrInput);
            const objCheck = arrElements.find(x => x.id == strCheckId);
            if (objCheck == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
                console.error(strMsg);
                throw (strMsg);
            }
            objCheck.checked = bolValue;
        }
        static SetInputValueByIdInDiv(strDivId, strInputId, strValue) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrInput = objDiv.getElementsByTagName("input");
            const arrElements = GetArray(arrInput);
            const objInput = arrElements.find(x => x.id == strInputId);
            if (objInput == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
                console.error(strMsg);
                throw (strMsg);
            }
            objInput.value = strValue;
        }
        static SetLabelHtmlByIdInDiv(strDivId, strLabelId, strValue) {
            const objDiv = document.getElementById(strDivId);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrLabel = objDiv.getElementsByTagName("label");
            const arrElements = GetArray(arrLabel);
            const objLabel = arrElements.find(x => x.id == strLabelId);
            if (objLabel == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Label框:[{1}], 请检查！", strDivId, strLabelId);
                console.error(strMsg);
                throw (strMsg);
            }
            objLabel.innerHTML = strValue;
        }
        static GetCheckedObjLstInDiv(strDivId) {
            const divList = document.getElementById(strDivId);
            const arrInput = divList.getElementsByTagName("input");
            const arrElements = GetArray(arrInput);
            const arrCheckBox = arrElements.filter(x => x.type == "checkbox" && x.checked == true);
            if (arrCheckBox == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在复选框, 请检查！", strDivId);
                console.error(strMsg);
                throw (strMsg);
            }
            return arrCheckBox;
        }
        static GetCheckedKeyIdsInDiv(strDivName4List) {
            const divList = document.getElementById(strDivName4List);
            const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            const arrChkLitems = this.GetArray(chkItems);
            const chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
            const arrSelectedKeys = chkCheckedItems
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
        //console.error(strMsg);
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
        static GetSpanObjInDiv(strDivName, strSpanId) {
            const objDiv = document.getElementById(strDivName);
            if (objDiv == null) {
                const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
                console.error(strMsg);
                throw (strMsg);
            }
            const arrSpan = objDiv.getElementsByTagName("span");
            const arrElements = GetArray(arrSpan);
            const objSpan = arrElements.find(x => x.id == strSpanId);
            if (objSpan == null) {
                const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Span控件:[{1}], 请检查！", strDivName, strSpanId);
                console.error(strMsg);
                throw (strMsg);
            }
            return objSpan;
        }
        /*
         * 绑定下拉框
         */
        static BindDdl_CboObject(strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
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
        static HideA(strAName) {
            const objA = document.getElementById(strAName);
            if (objA == null) {
                const strMsg = (0, clsString_js_1.Format)("超链接:[{0}]在该界面不存在！", strAName);
                console.error(strMsg);
                throw (strMsg);
            }
            objA.style.display = 'none';
            objA.style.visibility = "hidden"; //隐藏  
            //alert(objDiv4SelectFile);
        }
        static ShowA(strAName) {
            const objA = document.getElementById(strAName);
            if (objA == null) {
                const strMsg = (0, clsString_js_1.Format)("超链接:[{0}]在该界面不存在！", strAName);
                console.error(strMsg);
                throw (strMsg);
            }
            objA.style.display = 'block';
            objA.style.visibility = "visible"; //显示     
        }
    }
    exports.clsCommFunc4CtrlBak = clsCommFunc4CtrlBak;
    function GetCheckedObjLstInDiv(strDivId) {
        const divList = document.getElementById(strDivId);
        const arrInput = divList.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const arrCheckBox = arrElements.filter(x => x.type == "checkbox" && x.checked == true);
        if (arrCheckBox == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在复选框, 请检查！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        return arrCheckBox;
    }
    exports.GetCheckedObjLstInDiv = GetCheckedObjLstInDiv;
    function GetCheckedKeyIdsInDiv(strDivName4List) {
        const divList = document.getElementById(strDivName4List);
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        const arrChkLitems = GetArray(chkItems);
        const chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
        const arrSelectedKeys = chkCheckedItems
            .filter(x => x.id != 'chkTabHead')
            .map((x) => {
            const strId = x.id;
            const strKey = strId.substring(3);
            return strKey;
        });
        return arrSelectedKeys;
    }
    exports.GetCheckedKeyIdsInDiv = GetCheckedKeyIdsInDiv;
    /*
     * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
     */
    function GetArray(arr) {
        const arrLst = new Array();
        for (let i = 0; i < arr.length; i++) {
            const chk = arr[i]; // as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    exports.GetArray = GetArray;
    /**
    * 获取在层下Select控件的值
    * @param strDivId : 层Id
    * @param strSelectId 下拉框Id
    * @returns 字符型
    **/
    function GetSelectValueInDiv(strDivId, strSelectId) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSelect = objDiv.getElementsByTagName("select");
        const arrElements = GetArray(arrSelect);
        const sltDdl = arrElements.find(x => x.id == strSelectId);
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
            console.error(strMsg);
            throw (strMsg);
        }
        if (sltDdl.selectedIndex < 0)
            return "";
        const objOption_Sel = sltDdl.options[sltDdl.selectedIndex];
        const strValue = objOption_Sel.value;
        return strValue;
    }
    exports.GetSelectValueInDiv = GetSelectValueInDiv;
    function SetSelectValueByIdInDiv(strDivId, strSelectId, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSelect = objDiv.getElementsByTagName("select");
        const arrElements = GetArray(arrSelect);
        const sltDdl = arrElements.find(x => x.id == strSelectId);
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivId, strSelectId);
            console.error(strMsg);
            throw (strMsg);
        }
        //    const objSelect: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strSelectId);
        //    if (objSelect == null) {
        //        console.error(`在设置下拉框值时，控件：${strSelectId}不存在！`);
        //        return;
        //    }
        if (sltDdl.options.length == 0) {
            if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return;
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，下拉框:[{1}]可能还没有绑定, 请检查！", strDivId, strSelectId);
            console.error(strMsg);
            throw (strMsg);
        }
        for (let i = 0; i < sltDdl.options.length; i++) {
            if (sltDdl.options[i].value == strValue) {
                sltDdl.selectedIndex = i;
                return;
            }
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == false) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，下拉框:[{1}]不能赋值:[{2}], 请检查！", strDivId, strSelectId, strValue);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SetSelectValueByIdInDiv = SetSelectValueByIdInDiv;
    function GetTextAreaValueInDiv(strDivId, strInputId) {
        //const objDiv = $(`#${strDivId}`);
        //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("textarea");
        const arrElements = GetArray(arrInput);
        const objInput = arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在文本框(textarea):[{1}], 请检查！", strDivId, strInputId);
            console.error(strMsg);
            throw (strMsg);
        }
        const strValue = objInput.value;
        return strValue;
    }
    exports.GetTextAreaValueInDiv = GetTextAreaValueInDiv;
    function SetTextAreaValueByIdInDiv(strDivId, strInputId, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("textarea");
        const arrElements = GetArray(arrInput);
        const objInput = arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在文本框(textarea):[{1}], 请检查！", strDivId, strInputId);
            console.error(strMsg);
            throw (strMsg);
        }
        objInput.value = strValue;
    }
    exports.SetTextAreaValueByIdInDiv = SetTextAreaValueByIdInDiv;
    function GetInputValue(strInputId) {
        //const objDiv = $(`#${strDivId}`);
        //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);
        const objInput = document.getElementById(strInputId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在document内，不存在文本框:[{0}], 请检查！", strInputId);
            console.error(strMsg);
            throw (strMsg);
        }
        const strValue = objInput.value;
        return strValue;
    }
    exports.GetInputValue = GetInputValue;
    function GetInputValueInDiv(strDivId, strInputId) {
        //const objDiv = $(`#${strDivId}`);
        //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objInput = arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
            console.error(strMsg);
            throw (strMsg);
        }
        const strValue = objInput.value;
        return strValue;
    }
    exports.GetInputValueInDiv = GetInputValueInDiv;
    function SetInputValueByIdInDiv(strDivId, strInputId, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objInput = arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在文本框:[{1}], 请检查！", strDivId, strInputId);
            console.error(strMsg);
            throw (strMsg);
        }
        objInput.value = strValue;
    }
    exports.SetInputValueByIdInDiv = SetInputValueByIdInDiv;
    function SetLabelHtmlByIdInDiv(strDivId, strLabelId, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrLabel = objDiv.getElementsByTagName("label");
        const arrElements = GetArray(arrLabel);
        const objLabel = arrElements.find(x => x.id == strLabelId);
        if (objLabel == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Label框:[{1}], 请检查！", strDivId, strLabelId);
            console.error(strMsg);
            throw (strMsg);
        }
        objLabel.innerHTML = strValue;
    }
    exports.SetLabelHtmlByIdInDiv = SetLabelHtmlByIdInDiv;
    function SetSpanHtmlByIdInDiv(strDivId, strSpanId, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrLabel = objDiv.getElementsByTagName("span");
        const arrElements = GetArray(arrLabel);
        const objLabel = arrElements.find(x => x.id == strSpanId);
        if (objLabel == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Span框:[{1}], 请检查！", strDivId, strSpanId);
            console.error(strMsg);
            throw (strMsg);
        }
        objLabel.innerHTML = strValue;
    }
    exports.SetSpanHtmlByIdInDiv = SetSpanHtmlByIdInDiv;
    function SetH4HtmlByIdInDiv(strDivId, strH4Id, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrLabel = objDiv.getElementsByTagName("h4");
        const arrElements = GetArray(arrLabel);
        const objLabel = arrElements.find(x => x.id == strH4Id);
        if (objLabel == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在h4标题框:[{1}], 请检查！", strDivId, strH4Id);
            console.error(strMsg);
            throw (strMsg);
        }
        objLabel.innerHTML = strValue;
    }
    exports.SetH4HtmlByIdInDiv = SetH4HtmlByIdInDiv;
    function GetLabelHtmlInDiv(strDivId, strLabelId) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrlabel = objDiv.getElementsByTagName("label");
        const arrElements = GetArray(arrlabel);
        const objLabel = arrElements.find(x => x.id == strLabelId);
        if (objLabel == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Label:[{1}], 请检查！", strDivId, strLabelId);
            console.error(strMsg);
            throw (strMsg);
        }
        const strValue = objLabel.innerHTML;
        return strValue;
    }
    exports.GetLabelHtmlInDiv = GetLabelHtmlInDiv;
    function GetCheckBoxValueInDiv(strDivId, strCheckId) {
        //const objDiv = $(`#${strDivId}`);
        //clsCommFunc4Ctrl.CheckControlExist(strDivId, "input", strInputId);
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objCheck = arrElements.find(x => x.id == strCheckId);
        if (objCheck == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
            console.error(strMsg);
            throw (strMsg);
        }
        const bolValue = objCheck.checked;
        return bolValue;
    }
    exports.GetCheckBoxValueInDiv = GetCheckBoxValueInDiv;
    function GetCheckBoxObjInDiv(strDivId, strCheckId) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objCheck = arrElements.find(x => x.id == strCheckId);
        return objCheck;
    }
    exports.GetCheckBoxObjInDiv = GetCheckBoxObjInDiv;
    function GetButtonHtmlInDiv(strDivId, strButtonId) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrButton = objDiv.getElementsByTagName("button");
        const arrElements = GetArray(arrButton);
        const objButton = arrElements.find(x => x.id == strButtonId);
        if (objButton == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivId, strButtonId);
            console.error(strMsg);
            throw (strMsg);
        }
        const strValue = objButton.innerHTML;
        return strValue;
    }
    exports.GetButtonHtmlInDiv = GetButtonHtmlInDiv;
    function SetCheckBoxValueByIdInDiv(strDivId, strCheckId, bolValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objCheck = arrElements.find(x => x.id == strCheckId);
        if (objCheck == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在复选框:[{1}], 请检查！", strDivId, strCheckId);
            console.error(strMsg);
            throw (strMsg);
        }
        objCheck.checked = bolValue;
    }
    exports.SetCheckBoxValueByIdInDiv = SetCheckBoxValueByIdInDiv;
    function CheckControlExist(divName, strControlType, strControlId) {
        if ((0, clsString_js_1.IsNullOrEmpty)(strControlType) == true) {
            const strMsg = (0, clsString_js_1.Format)("在层:{0}中查找控件:[{1}]时, 类型不能为空！", divName, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDiv = document.getElementById(divName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:{0}不存在, 请检查！", divName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName(strControlType);
        const arrElements = GetArray(arrInput);
        const arrElements_Sel = arrElements.filter(x => x.id == strControlId);
        if (arrElements_Sel.length == 0) {
            const strMsg = (0, clsString_js_1.Format)("在层:{0}中, 类型为:{1}的控件:{2}不存在, 请检查！", divName, strControlType, strControlId);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CheckControlExist = CheckControlExist;
    /*
     * 检查层是否存在？
     */
    function CheckDivExist(divName) {
        const objDiv = document.getElementById(divName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:{0}不存在, 请检查！", divName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CheckDivExist = CheckDivExist;
    function SetButtonHtmlByIdInDiv(strDivId, strButtonId, strValue) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrButton = objDiv.getElementsByTagName("button");
        const arrElements = GetArray(arrButton);
        const objButton = arrElements.find(x => x.id == strButtonId);
        if (objButton == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivId, strButtonId);
            console.error(strMsg);
            throw (strMsg);
        }
        objButton.innerHTML = strValue;
    }
    exports.SetButtonHtmlByIdInDiv = SetButtonHtmlByIdInDiv;
    function getTdObjByIdInDiv(strDivName, strTdId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("td");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strTdId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[td]的元素:[{1}], 请检查！", strDivName, strTdId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getTdObjByIdInDiv = getTdObjByIdInDiv;
    function getTrObjByIdInDiv(strDivName, strTrId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("tr");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strTrId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[tr]的元素:[{1}], 请检查！", strDivName, strTrId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getTrObjByIdInDiv = getTrObjByIdInDiv;
    function GetCheckObjInDiv(strDivName, strCheckId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objInput = arrElements.find(x => x.id == strCheckId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Input控件:[{1}], 请检查！", strDivName, strCheckId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objInput;
    }
    exports.GetCheckObjInDiv = GetCheckObjInDiv;
    /**
    * 在层中根据Select对象的Id获取相关对象
    * @param strDivName: 层名
    * @param strSelectId: Select元素的Id
    * @returns 返回获取的对象，如果不存在就抛出错误信息
    */
    function GetSelectObjInDiv(strDivName, strSelectId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSelect = objDiv.getElementsByTagName("select");
        const arrElements = GetArray(arrSelect);
        const sltDdl = arrElements.find(x => x.id == strSelectId);
        if (sltDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在下拉框:[{1}], 请检查！", strDivName, strSelectId);
            console.error(strMsg);
            throw (strMsg);
        }
        return sltDdl;
    }
    exports.GetSelectObjInDiv = GetSelectObjInDiv;
    /*
       * 设置使特定关键字的复选框被选
       * strKeyId:关键字
       */
    function SetCheckedItem4KeyId(strArrayDiv, strKeyId) {
        //获取指定数据列表层
        const divList = document.getElementById(strArrayDiv);
        //根据className获取数据列表层中的所有复选框
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        //把集合转换成Array
        const arrChkLitems = GetArray(chkItems);
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
    exports.SetCheckedItem4KeyId = SetCheckedItem4KeyId;
    function GetLabelValueInDiv(strDivId, strLabelId) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivId);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrlabel = objDiv.getElementsByTagName("label");
        const arrElements = GetArray(arrlabel);
        const objLabel = arrElements.find(x => x.id == strLabelId);
        if (objLabel == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Label:[{1}], 请检查！", strDivId, strLabelId);
            console.error(strMsg);
            throw (strMsg);
        }
        const strValue = objLabel.innerText;
        return strValue;
    }
    exports.GetLabelValueInDiv = GetLabelValueInDiv;
    /**
     * 在层中根据Button对象的Id获取相关对象
     * @param strDivName: 层名
     * @param strButtonId: Button元素的Id
     * @returns 返回获取的对象，如果不存在就抛出错误信息
     */
    function GetButtonObjInDiv(strDivName, strButtonId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrButton = objDiv.getElementsByTagName("button");
        const arrElements = GetArray(arrButton);
        const objButton = arrElements.find(x => x.id == strButtonId);
        if (objButton == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在按钮:[{1}], 请检查！", strDivName, strButtonId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objButton;
    }
    exports.GetButtonObjInDiv = GetButtonObjInDiv;
    function HideButtonInDiv(strDivName, strButtonId) {
        const objButton = getButtonObjByIdInDiv(strDivName, strButtonId);
        objButton.style.visibility = "hidden";
        objButton.style.display = "none";
    }
    exports.HideButtonInDiv = HideButtonInDiv;
    function ShowDivInDivV2(strDivName, strDivIdIn) {
        const objDiv = getDivObjByIdInDiv(strDivName, strDivIdIn);
        objDiv.style.visibility = "visible";
        objDiv.style.display = "table-row";
    }
    exports.ShowDivInDivV2 = ShowDivInDivV2;
    function HideDivInDiv(strDivName, strDivIdIn) {
        const objDiv = getDivObjByIdInDiv(strDivName, strDivIdIn);
        objDiv.style.visibility = "hidden";
        objDiv.style.display = "none";
    }
    exports.HideDivInDiv = HideDivInDiv;
    function getButtonObjByIdInDiv(strDivName, strButtonId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("button");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strButtonId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[button]的元素:[{1}], 请检查！", strDivName, strButtonId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getButtonObjByIdInDiv = getButtonObjByIdInDiv;
    function getDivObjById(strDivName) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        return objDiv;
    }
    exports.getDivObjById = getDivObjById;
    function getDivObjByIdInDiv(strDivName, strDivIdIn) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("div");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strDivIdIn);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[div]的元素:[{1}], 请检查！", strDivName, strDivIdIn);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getDivObjByIdInDiv = getDivObjByIdInDiv;
    function ShowDivInDiv(strDivName, strDivIdIn) {
        const objDiv = getDivObjByIdInDiv(strDivName, strDivIdIn);
        objDiv.style.visibility = "visible";
        objDiv.style.display = "block";
    }
    exports.ShowDivInDiv = ShowDivInDiv;
    function ShowButtonInDiv(strDivName, strButtonId) {
        const objButton = getButtonObjByIdInDiv(strDivName, strButtonId);
        objButton.style.visibility = "visible";
        objButton.style.display = "block";
    }
    exports.ShowButtonInDiv = ShowButtonInDiv;
    /*
        * 获取列表中第一个选中的复选框的关键字
        */
    function GetFirstCheckedKeyIdInDiv(divListName) {
        const divList = document.getElementById(divListName);
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        const arrChkLitems = GetArray(chkItems);
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
    exports.GetFirstCheckedKeyIdInDiv = GetFirstCheckedKeyIdInDiv;
    function getAObjByIdInDiv(strDivName, strAId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("a");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strAId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[a]的元素:[{1}], 请检查！", strDivName, strAId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getAObjByIdInDiv = getAObjByIdInDiv;
    function getLiObjByIdInDiv(strDivName, strLiId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("li");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strLiId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在类型为:[li]的元素:[{1}], 请检查！", strDivName, strLiId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objElement;
    }
    exports.getLiObjByIdInDiv = getLiObjByIdInDiv;
    function SetInputReadOnly(strDivName, strControlId, bolIsReadOnly) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrElements0 = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrElements0);
        const objElement = arrElements.find(x => x.id == strControlId);
        if (objElement == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在元素:[{1}], 请检查！", strDivName, strControlId);
            console.error(strMsg);
            return;
        }
        objElement.readOnly = bolIsReadOnly;
    }
    exports.SetInputReadOnly = SetInputReadOnly;
    /*
      * 把字符串列表转换成唯一性字符串列表
      *
      */
    function GetDistinctArray(arrStrLst) {
        const setStrLst = new Set(arrStrLst);
        const arrStrLst_New = Array.from(setStrLst);
        return arrStrLst_New;
    }
    exports.GetDistinctArray = GetDistinctArray;
    /*
     * 集合的交
     */
    function intersectSets(arrA, arrB) {
        let intersection = new Set();
        const setA = new Set(arrA);
        const setB = new Set(arrB);
        for (let ele of setB) {
            if (setA.has(ele)) {
                intersection.add(ele);
            }
        }
        return Array.from(intersection);
    }
    exports.intersectSets = intersectSets;
    /*
     * 集合的并
     */
    function unionSet(setA, setB) {
        let union = new Set(setA);
        //const setA = new Set(arrA);
        //const setB = new Set(arrB);
        for (let elem of setB) {
            union.add(elem);
        }
        return union;
    }
    exports.unionSet = unionSet;
    /*
     * 集合的差
     */
    function differenceSet(setA, setB) {
        let difference = new Set(setA);
        for (let ele of setB) {
            difference.delete(ele);
        }
        return difference;
    }
    exports.differenceSet = differenceSet;
    /*
     * 是否超集
     */
    function isSuperset(arrA, arrSubset) {
        const setA = new Set(arrA);
        const subset = new Set(arrSubset);
        for (let elem of subset) {
            if (!setA.has(elem)) {
                return false;
            }
        }
        return true;
    }
    /**
      * 在层中根据Input对象的Id获取相关对象
      * @param strDivName: 层名
      * @param strInputId: Input元素的Id
      * @returns 返回获取的对象，如果不存在就抛出错误信息
      */
    function GetInputObjInDiv(strDivName, strInputId) {
        const objDiv = document.getElementById(strDivName);
        if (objDiv == null) {
            const strMsg = (0, clsString_js_1.Format)("层:[{0}]在该界面不存在！", strDivName);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrInput = objDiv.getElementsByTagName("input");
        const arrElements = GetArray(arrInput);
        const objInput = arrElements.find(x => x.id == strInputId);
        if (objInput == null) {
            const strMsg = (0, clsString_js_1.Format)("在层:[{0}]内，不存在Input控件:[{1}], 请检查！", strDivName, strInputId);
            console.error(strMsg);
            throw (strMsg);
        }
        return objInput;
    }
    exports.GetInputObjInDiv = GetInputObjInDiv;
    function GetLi_Empty(strClassName) {
        const objLi = document.createElement("li");
        objLi.className = strClassName;
        return objLi;
    }
    exports.GetLi_Empty = GetLi_Empty;
    function GetUl_Empty(strClassName) {
        const objUl = document.createElement("ul");
        objUl.className = strClassName;
        return objUl;
    }
    exports.GetUl_Empty = GetUl_Empty;
    function GetSpan_Empty(strClassName) {
        const objSpan = document.createElement("span");
        if ((0, clsString_js_1.IsNullOrEmpty)(strClassName) == false) {
            if (strClassName.indexOf(' ') > -1) {
                objSpan.className = strClassName;
            }
            else {
                objSpan.classList.add(strClassName);
            }
        }
        return objSpan;
    }
    exports.GetSpan_Empty = GetSpan_Empty;
    //export function GetLabel_Empty(strClassName: string): HTMLLabelElement {
    //    const objSpan: HTMLLabelElement = <HTMLLabelElement>document.createElement("label");
    //    if (IsNullOrEmpty(strClassName) == false) {
    //        if (strClassName.indexOf(' ') > -1) {
    //            objSpan.className = strClassName;
    //        }
    //        else {
    //            objSpan.classList.add(strClassName);
    //        }
    //    }
    //    return objSpan;
    //}
    function GetBr_Empty() {
        const objBr = document.createElement("br");
        return objBr;
    }
    exports.GetBr_Empty = GetBr_Empty;
    //export function GetBr_Empty(strClassName: string): HTMLBRElement {
    //    const objBr = document.createElement("br");
    //    objBr.className = strClassName;
    //    return objBr;
    //}
    function GetTextArea_Empty(strClassName) {
        const objTextArea = document.createElement("textarea");
        objTextArea.className = strClassName;
        return objTextArea;
    }
    exports.GetTextArea_Empty = GetTextArea_Empty;
    function GetTextBox_Empty(strClassName) {
        const objTextBox = document.createElement("input");
        objTextBox.type = "text";
        objTextBox.className = strClassName;
        return objTextBox;
    }
    exports.GetTextBox_Empty = GetTextBox_Empty;
    function GetSelect_Empty(strClassName) {
        const objSelect = document.createElement("select");
        objSelect.className = strClassName;
        return objSelect;
    }
    exports.GetSelect_Empty = GetSelect_Empty;
    function GetTable_Empty(strClassName) {
        const objTable = document.createElement("table");
        objTable.className = strClassName;
        return objTable;
    }
    exports.GetTable_Empty = GetTable_Empty;
    function GetTr_Empty(strClassName) {
        const objTableRow = document.createElement("tr");
        objTableRow.className = strClassName;
        return objTableRow;
    }
    exports.GetTr_Empty = GetTr_Empty;
    function GetTd_Empty(strClassName) {
        const objTableCell = document.createElement("td");
        objTableCell.className = strClassName;
        return objTableCell;
    }
    exports.GetTd_Empty = GetTd_Empty;
    function GetDiv_Empty(strClassName) {
        const objDiv = document.createElement("div");
        if ((0, clsString_js_1.IsNullOrEmpty)(strClassName) == false) {
            objDiv.className = strClassName;
        }
        return objDiv;
    }
    exports.GetDiv_Empty = GetDiv_Empty;
    function GetLabel_Empty(strClassName) {
        const objLabel = document.createElement("label");
        if ((0, clsString_js_1.IsNullOrEmpty)(strClassName) == false) {
            objLabel.className = strClassName;
        }
        return objLabel;
    }
    exports.GetLabel_Empty = GetLabel_Empty;
    function GetButton_Empty(strClassName) {
        const objButton = document.createElement("button");
        if ((0, clsString_js_1.IsNullOrEmpty)(strClassName) == false) {
            objButton.className = strClassName;
        }
        return objButton;
    }
    exports.GetButton_Empty = GetButton_Empty;
    function GetA_Empty(strClassName) {
        const objA = document.createElement("a");
        if ((0, clsString_js_1.IsNullOrEmpty)(strClassName) == false) {
            objA.className = strClassName;
        }
        return objA;
    }
    exports.GetA_Empty = GetA_Empty;
    function GetCheckedKeyLstsInDiv(strDivName4List) {
        const divList = document.getElementById(strDivName4List);
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        const arrChkLitems = GetArray(chkItems);
        const chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
        const arrSelectedKeys = chkCheckedItems
            .filter(x => x.id != 'chkTabHead')
            .map((x) => {
            const strId = x.id;
            const strKey = strId.substring(3);
            const strKeyLst = x.getAttribute("keyValueLst");
            if (strKeyLst == null)
                return strKey;
            return strKeyLst;
        });
        return arrSelectedKeys;
    }
    exports.GetCheckedKeyLstsInDiv = GetCheckedKeyLstsInDiv;
    function GetFirstCheckedKeyLstInDiv(divListName) {
        const divList = document.getElementById(divListName);
        const chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
        const arrChkLitems = GetArray(chkItems);
        const chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
        const intCheckedCount = chkCheckedItems.length;
        for (let i = 0; i < intCheckedCount; i++) {
            const chkItem = chkCheckedItems[i];
            if (chkItem.id == 'chkTabHead')
                continue;
            const strId = chkItem.id;
            const strKey = strId.substring(3);
            const strKeyLst = chkItem.getAttribute("keyValueLst");
            if (strKeyLst == null)
                return strKey;
            return strKeyLst;
        }
        //    alert(intCount.toString() + "::" + intCheckedCount.toString());
        return "";
    }
    exports.GetFirstCheckedKeyLstInDiv = GetFirstCheckedKeyLstInDiv;
    /**
    * 获取在层下Select控件的值
    * @param strDivId : 层Id
    * @param strSelectId 下拉框Id
    * @returns 字符型
    **/
    function IsExistDiv(strDivId) {
        const objDiv = document.getElementById(strDivId);
        if (objDiv == null) {
            return false;
        }
        return true;
    }
    exports.IsExistDiv = IsExistDiv;
    function GetArray_Svg(arr) {
        let arrLst = new Array();
        for (var i = 0; i < arr.length; i++) {
            var chk = arr[i]; // as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    exports.GetArray_Svg = GetArray_Svg;
});
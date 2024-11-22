/*
 * 功能：用于显示列表具有分页功能的函数
 * 版本：2022-02-26-01
 * 作者：潘以锋
 * */
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
    exports.GetSortBy = exports.GetCurrPageIndex = exports.ShowEmptyRecNumInfo = void 0;
    const clsString_js_1 = require("./clsString.js");
    function ShowEmptyRecNumInfo(strListDiv, strInfo) {
        const o = document.getElementById(strListDiv);
        if (o == null) {
            alert(`用于显示列表的层:${strListDiv}不存在！`);
            return;
        }
        o.innerHTML = "";
        const objSpan_Info = document.createElement("span");
        objSpan_Info.setAttribute("class", "text-warning font-weight-bold mt-2");
        objSpan_Info.innerHTML = strInfo;
        o.appendChild(objSpan_Info);
    }
    exports.ShowEmptyRecNumInfo = ShowEmptyRecNumInfo;
    // export function SetCurrPageIndex(value: number, strDivName4Pager: string) {
    //     this.objPager.currPageIndex = value;
    // }
    function GetCurrPageIndex(intCurrPageIndex) {
        if (intCurrPageIndex == 0) {
            return 1;
        }
        if (intCurrPageIndex < 1)
            return 1;
        return intCurrPageIndex;
    }
    exports.GetCurrPageIndex = GetCurrPageIndex;
    /** 函数功能:从界面列表中根据某一个字段排序
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    * @param objAnchorElement:带有排序字段的Anchors
    **/
    function GetSortBy(objAnchorElement, strAscOrDesc4SortFun, strSortBy, strSortExpress) {
        const strThisFuncName = "GetSortBy";
        console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
        //event = window.event || event;
        let sortFun0 = (ascOrDesc) => (x, y) => { return 0; };
        let ascOrDesc4SortFun0 = "";
        let sortBy0 = "";
        if (typeof (objAnchorElement) == "function") {
            sortFun0 = objAnchorElement;
            if (strAscOrDesc4SortFun.indexOf("Asc") >= 0) {
                ascOrDesc4SortFun0 = "Desc";
            }
            else {
                ascOrDesc4SortFun0 = "Asc";
            }
            sortBy0 = "";
        }
        else {
            // const thisEventObj: HTMLInputElement = objAnchorElement;
            // const strFldName: string = thisEventObj.getAttribute("FldName") as string;
            if ((0, clsString_js_1.IsNullOrEmpty)(strSortExpress) == false) {
                const strSortByFld = strSortExpress;
                if (strSortBy.indexOf(strSortByFld) >= 0) {
                    if (strSortBy.indexOf("Asc") >= 0) {
                        sortBy0 = (0, clsString_js_1.Format)("{0} Desc", strSortByFld);
                    }
                    else {
                        sortBy0 = (0, clsString_js_1.Format)("{0} Asc", strSortByFld);
                    }
                }
                else {
                    sortBy0 = (0, clsString_js_1.Format)("{0} Asc", strSortByFld);
                }
            }
        }
        return {
            sortFun: sortFun0,
            ascOrDesc4SortFun: ascOrDesc4SortFun0,
            sortBy: sortBy0
        };
        // return [
        //   sortFun0,
        //   ascOrDesc4SortFun0,
        //   sortBy0  ];
    }
    exports.GetSortBy = GetSortBy;
});

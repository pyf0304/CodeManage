/*
 * 功能：用于显示列表具有分页功能的函数
 * 版本：2021-06-05-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsString2.js", "./clsPager.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsOperateList = void 0;
    const clsString2_js_1 = require("./clsString2.js");
    const clsPager_js_1 = require("./clsPager.js");
    class clsOperateList {
        constructor() {
            this.divName4List = "divList"; //列表区的层Id
            this.divName4DataList = "divDataLst"; //列表中数据区的层Id
            this.divName4Pager = "divPager"; //列表中的分页区的层Id
            this.bolIsInitShow = false; //记录是否导入分页区的变量
            this.mstrListDiv = "divDataLst"; //列表区数据列表层id
            this.objPager = new clsPager_js_1.clsPager();
        }
        async SortBy(objAnchorElement) {
        }
        async IndexPage(intPageIndex) {
        }
        /* 函数功能:在数据列表中跳转到前一页
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PrevPage)
    */
        async PrevPage(strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            var hidCurrPageIndex = `input[id ^= "hidCurrPageIndex"]`;
            var strCurrPageIndex = objDiv.find(hidCurrPageIndex).val(); //当前页
            //var strCurrPageIndex = $("#hidCurrPageIndex").val();
            var intCurrPageIndex = 0;
            if (clsString2_js_1.clsString.IsNullOrEmpty(strCurrPageIndex)) {
                intCurrPageIndex = 0;
            }
            else {
                intCurrPageIndex = Number(strCurrPageIndex);
            }
            //var intCurrPageIndex = $('#hidCurrPageIndex').val();
            var intPageIndex = intCurrPageIndex - 1;
            if (intPageIndex < 1)
                intPageIndex = 1;
            console.log("跳转到" + intPageIndex + "页");
            this.IndexPage(intPageIndex);
        }
        /* 函数功能:在数据列表中跳转到下一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_NextPage)
       */
        async NextPage(strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            var hidCurrPageIndex = `input[id ^= "hidCurrPageIndex"]`;
            var strCurrPageIndex = objDiv.find(hidCurrPageIndex).val(); //当前页
            //var strCurrPageIndex = $("#hidCurrPageIndex").val();
            var intCurrPageIndex = 0;
            if (clsString2_js_1.clsString.IsNullOrEmpty(strCurrPageIndex)) {
                intCurrPageIndex = 0;
            }
            else {
                intCurrPageIndex = Number(strCurrPageIndex);
            }
            //var intCurrPageIndex = $('#hidCurrPageIndex').val();
            var intPageIndex = Number(intCurrPageIndex) + 1;
            console.log("跳转到" + intPageIndex + "页");
            this.IndexPage(intPageIndex);
        }
        /*
    * 获取当前页序号(Used In BindGv_Cache)
    */
        getCurrPageIndex(strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            var hidCurrPageIndex = `input[id ^= "hidCurrPageIndex"]`;
            var strCurrPageIndex = objDiv.find(hidCurrPageIndex).val(); //当前页
            //var strCurrPageIndex = $("#hidCurrPageIndex").val();        
            if (clsString2_js_1.clsString.IsNullOrEmpty(strCurrPageIndex)) {
                const strMsg = clsString2_js_1.clsString.Format("在分页层:{0}中没有:[hidCurrPageIndex], 可能对分页初始化。", strDivName4Pager);
                console.error(strMsg);
                return 1;
            }
            let intCurrPageIndex = Number(strCurrPageIndex);
            if (intCurrPageIndex < 1)
                intCurrPageIndex = 1;
            return intCurrPageIndex;
        }
        /*
        * 设置当前页序号
       */
        setCurrPageIndex(value, strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            var hidCurrPageIndex = `input[id ^= "hidCurrPageIndex"]`;
            objDiv.find(hidCurrPageIndex).val(value);
            //$("#hidCurrPageIndex").val(value);
        }
        /**
         * 清空列表的记录，并显示相关信息
         * @param strListDiv
         * @param strInfo
         */
        ShowEmptyRecNumInfo(strListDiv, strInfo) {
            var o = document.getElementById(strListDiv);
            if (o == null) {
                alert(`用于显示列表的层:${strListDiv}不存在！`);
                return;
            }
            o.innerHTML = "";
            var objSpan_Info = document.createElement("span");
            objSpan_Info.setAttribute("class", "text-warning font-weight-bold mt-2");
            objSpan_Info.innerHTML = strInfo;
            o.appendChild(objSpan_Info);
        }
    }
    exports.clsOperateList = clsOperateList;
});

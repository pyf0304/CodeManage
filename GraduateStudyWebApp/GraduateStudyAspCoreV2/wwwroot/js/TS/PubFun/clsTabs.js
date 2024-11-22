/*
 * 功能：用于分页的功能函数
 * 版本：2021-06-05-01
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
    exports.clsTabInfo = exports.clsTabs = void 0;
    const clsString_js_1 = require("./clsString.js");
    class clsTabs {
        constructor() {
            this.TabLst = [];
            this.mintPageIndex = 1;
            this.mintPageCount = 0;
            /// <summary>
            /// 专门用于记录GridView中的每页记录数
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPageSizeViewState)
            /// </summary>
            this.PageNum = 2;
            this.DivName = "";
            this.RootDivClassName = "";
        }
        //public strDivName4Pager: string = "";
        /// <summary>
        /// 设置GridView中的页序号
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageIndex)
        /// </summary>
        get PageIndex() {
            return this.mintPageIndex;
        }
        set PageIndex(value) {
            this.mintPageIndex = value;
        }
        CreateTabs() {
            const divRoot = this.GetDiv_Root();
            const ulField = this.GetUl_Tabs();
            const divTabContent = this.GetDiv_TabContent();
            divRoot.appendChild(ulField);
            divRoot.appendChild(divTabContent);
            return divRoot;
        }
        GetDiv_Root() {
            const divRoot = document.createElement("div");
            divRoot.className = this.RootDivClassName;
            //divRoot.style.width = "100%";
            divRoot.id = this.DivName;
            return divRoot;
        }
        GetUl_Tabs() {
            const ulField = document.createElement("ul");
            //ulField.id = Format("ul{0}", objTabFeature.tabId);
            ulField.className = "nav nav-tabs";
            ulField.setAttribute("role", "navigation");
            for (const objTabInfo of this.TabLst) {
                //<li class="nav-item " > <a class="nav-link active" href = "#tab1" onclick = "btn_Click('Tab', '0173')" data - toggle="tab" role = "tab" > 绑定下拉框 < /a></li >
                const li_Field = this.GetLi_TabInfo(objTabInfo);
                ulField.appendChild(li_Field);
            }
            return ulField;
        }
        GetLi_TabInfo(objTabInfo) {
            const li_Field = document.createElement("li");
            li_Field.className = "nav-item";
            const A_Field = this.GetA_TabInfo(objTabInfo);
            li_Field.appendChild(A_Field);
            return li_Field;
        }
        GetA_TabInfo(objTabInfo) {
            //<a class="nav-link active" href = "#tab1" onclick = "btn_Click('Tab', '0173')" data - toggle="tab" role = "tab" > 绑定下拉框 < /a>
            const A_Field = document.createElement("a");
            A_Field.className = "nav-link";
            if (objTabInfo.IsActive) {
                A_Field.className = "nav-link active";
            }
            A_Field.href = (0, clsString_js_1.Format)("#{0}", objTabInfo.tabId);
            A_Field.setAttribute("onclick", objTabInfo.TabClick);
            A_Field.setAttribute("data-toggle", "tab");
            A_Field.setAttribute("role", "tab");
            A_Field.innerText = objTabInfo.TabTitle;
            return A_Field;
        }
        GetDiv_TabContent() {
            const divTabContent = document.createElement("div");
            divTabContent.className = "tab-content";
            //divRoot.style.width = "100%";
            for (const objTabInfo of this.TabLst) {
                //<li class="nav-item " > <a class="nav-link active" href = "#tab1" onclick = "btn_Click('Tab', '0173')" data - toggle="tab" role = "tab" > 绑定下拉框 < /a></li >
                const divSubTab = this.GetDiv_SubTab(objTabInfo);
                divTabContent.appendChild(divSubTab);
            }
            return divTabContent;
        }
        GetDiv_SubTab(objTabInfo) {
            //<div class="tab-pane active" id = "tab1" >
            const divSubTab = document.createElement("div");
            divSubTab.className = "tab-pane";
            //divRoot.style.width = "100%";
            if (objTabInfo.IsActive) {
                divSubTab.className = "tab-pane active";
            }
            divSubTab.id = objTabInfo.tabId;
            divSubTab.appendChild(objTabInfo.DivContent);
            return divSubTab;
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
    }
    exports.clsTabs = clsTabs;
    class clsTabInfo {
        constructor() {
            this.tabId = "";
            this.TabClick = "";
            this.TabTitle = "";
            this.IsActive = false;
            this.DivContent = document.createElement("div");
        }
    }
    exports.clsTabInfo = clsTabInfo;
});

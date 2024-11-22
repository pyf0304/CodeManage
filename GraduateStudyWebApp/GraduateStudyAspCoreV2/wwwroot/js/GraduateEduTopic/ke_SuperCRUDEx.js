(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/ke_SuperCRUD.js", "../TS/L3_ForWApi/GraduateEduTopic/clske_SuperWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsString.js", "./ke_Super_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ke_SuperCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:ke_SuperCRUDEx
    表名:ke_Super(01120661)
    生成代码版本:2020.06.05.2
    生成日期:2020/06/08 16:47:09
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const ke_SuperCRUD_js_1 = require("../PagesBase/GraduateEduTopic/ke_SuperCRUD.js");
    const clske_SuperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clske_SuperWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const ke_Super_EditEx_js_1 = require("./ke_Super_EditEx.js");
    /* ke_SuperCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ke_SuperCRUDEx extends ke_SuperCRUD_js_1.ke_SuperCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortke_SuperBy: string = "ke_SuperId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_ke_Super();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "ke_Super":
                    alert('该类没有绑定该函数：[this.BindGv_ke_Super_Cache]！');
                    //this.BindGv_ke_Super_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (ke_SuperCRUD_js_1.ke_SuperCRUD.objPage_CRUD == null) {
                ke_SuperCRUD_js_1.ke_SuperCRUD.objPage_CRUD = new ke_SuperCRUDEx();
                objPage = ke_SuperCRUD_js_1.ke_SuperCRUD.objPage_CRUD;
            }
            else {
                objPage = ke_SuperCRUD_js_1.ke_SuperCRUD.objPage_CRUD;
            }
            const objPage_Edit = new ke_Super_EditEx_js_1.ke_Super_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    ;
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_ke_Super() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.Combineke_SuperCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrke_SuperObjLst = [];
            try {
                this.recCount = await (0, clske_SuperWApi_js_1.ke_Super_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: ke_SuperCRUD_js_1.ke_SuperCRUD.sortke_SuperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clske_SuperWApi_js_1.ke_Super_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrke_SuperObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrke_SuperObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_ke_Super(strListDiv, arrke_SuperObjLst);
                console.log("完成BindGv_ke_Super!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示ke_Super对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrke_SuperObjLst">需要绑定的对象列表</param>
    */
        async BindTab_ke_Super(divContainer, arrke_SuperObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "ke_SuperId",
                    colHeader: "知识分类Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "ke_SuperName_cn",
                    colHeader: "知识分类名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "ke_SuperName_en",
                    colHeader: "知识分类英文名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "ke_SuperDescribe_cn",
                    colHeader: "知识分类描述",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "ke_SuperDescribe_en",
                    colHeader: "知识分类英文描述",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTab)(o, arrke_SuperObjLst, arrDataColumn, "ke_SuperId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    exports.ke_SuperCRUDEx = ke_SuperCRUDEx;
});

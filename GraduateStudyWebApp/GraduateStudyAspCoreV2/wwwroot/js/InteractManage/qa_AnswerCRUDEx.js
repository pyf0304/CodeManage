(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsCommFunc4Web.js", "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js", "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../PagesBase/InteractManage/qa_AnswerCRUD.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsString.js", "./qa_Answer_EditEx.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_AnswerCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:qa_AnswerCRUDEx
    表名:qa_Answer(01120641)
    生成代码版本:2020.05.28.1
    生成日期:2020/06/03 00:17:06
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:互动管理
    模块英文名:InteractManage
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsvqa_AnswerEN_js_1 = require("../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js");
    const clsvqa_AnswerWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const qa_AnswerCRUD_js_1 = require("../PagesBase/InteractManage/qa_AnswerCRUD.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const qa_Answer_EditEx_js_1 = require("./qa_Answer_EditEx.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* qa_AnswerCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class qa_AnswerCRUDEx extends qa_AnswerCRUD_js_1.qa_AnswerCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvqa_AnswerBy: string = "answerId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vqa_Answer();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vqa_Answer":
                    alert('该类没有绑定该函数：[this.BindGv_vqa_Answer_Cache]！');
                    //this.BindGv_vqa_Answer_Cache();
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
            if (qa_AnswerCRUD_js_1.qa_AnswerCRUD.objPage_CRUD == null) {
                qa_AnswerCRUD_js_1.qa_AnswerCRUD.objPage_CRUD = new qa_AnswerCRUDEx();
                objPage = qa_AnswerCRUD_js_1.qa_AnswerCRUD.objPage_CRUD;
            }
            else {
                objPage = qa_AnswerCRUD_js_1.qa_AnswerCRUD.objPage_CRUD;
            }
            const objPage_Edit = new qa_Answer_EditEx_js_1.qa_Answer_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
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
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async Combinevqa_AnswerCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.QuestionsId_q != "") {
                //    strWhereCond += ` And ${clsvqa_AnswerEN.con_QuestionsId} like '% ${this.QuestionsId_q}%'`;
                //}
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.questionsContent != "") {
                    strWhereCond += ` And ${clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent} like '% ${this.questionsContent}%'`;
                }
                if (this.userName_q != "") {
                    strWhereCond += ` And ${clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName} like '% ${this.userName_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                }
                strWhereCond += " and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combineqa_AnswerCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vqa_Answer() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.Combinevqa_AnswerCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvqa_AnswerObjLst = [];
            try {
                this.recCount = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: qa_AnswerCRUD_js_1.qa_AnswerCRUD.sortvqa_AnswerBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvqa_AnswerObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvqa_AnswerObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vqa_Answer(strListDiv, arrvqa_AnswerObjLst);
                console.log("完成BindGv_vqa_Answer!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vqa_Answer对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrqa_AnswerObjLst">需要绑定的对象列表</param>
      */
        async BindTab_vqa_Answer(divContainer, arrvqa_AnswerObjLst) {
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
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "questionsContent",
                    colHeader: "问题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "QuestUserName",
                    colHeader: "提问人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "answerContent",
                    colHeader: "回答",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "回答日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "删除",
                    text: "删除", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    fldName: "",
                    colHeader: "进入答疑",
                    text: "问题", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnAnswer_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvqa_AnswerObjLst, arrDataColumn, "answerId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        async btnAnswer_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText1 = (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjByAnswerIdAsync)(strKeyId).then((jsonData) => {
                    var objvqa_AnswerEN = jsonData;
                    if (objvqa_AnswerEN != null) {
                        var strPaperId = objvqa_AnswerEN.paperId;
                        var strQuestionsId = objvqa_AnswerEN.questionsId;
                        //var strid_CurrEduCls = objvqa_AnswerEN.id_CurrEduCls;
                        var strHref = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperId=" + strPaperId + "&questionsId=" + strQuestionsId + "&questionsTypeId=01&id_CurrEduCls=";
                        xadminopen("Pdf论文答疑", strHref);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
    * 论文标题
    */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        /*
    * 论文标题
    */
        get questionsContent() {
            return $("#txtQuestionsContent_q").val();
        }
        /*
    * 用户名
    */
        get userName_q() {
            return $("#txtUserName_q").val();
        }
        /*
    * 修改日期
    */
        get updDate_q() {
            return $("#txtUpdDate_q").val();
        }
    }
    exports.qa_AnswerCRUDEx = qa_AnswerCRUDEx;
});

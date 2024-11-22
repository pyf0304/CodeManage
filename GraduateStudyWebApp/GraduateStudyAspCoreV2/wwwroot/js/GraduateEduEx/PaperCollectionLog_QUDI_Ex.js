(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCollectionLogCRUD.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperCollectionLogEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCollectionLogWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperCollectionLog_QUDI_Ex = void 0;
    const PaperCollectionLogCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCollectionLogCRUD.js");
    const clsPaperCollectionLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsvPaperCollectionLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperCollectionLogEN.js");
    const clsPaperCollectionLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperCollectionLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCollectionLogWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* PaperCollectionLog_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperCollectionLog_QUDI_Ex extends PaperCollectionLogCRUD_js_1.PaperCollectionLogCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperCollectionLogBy: string = "paperCollectionLogId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                if (strUserId != "") {
                    //1、为下拉框设置数据源,绑定列表数据
                    const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
                    PaperCollectionLogCRUD_js_1.PaperCollectionLogCRUD.sortvPaperCollectionLogBy = "updDate Desc";
                    var strWhereCond = await this.CombinevPaperCollectionLogCondition();
                    this.recCount = await (0, clsvPaperCollectionLogWApi_js_1.vPaperCollectionLog_GetRecCountByCondAsync)(strWhereCond);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vPaperCollectionLog();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Paper]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_PaperId(ddlPaperId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlPaperId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlPaperId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrPaperObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlPaperId, arrPaperObjLst, clsPaperEN_js_1.clsPaperEN.con_PaperId, clsPaperEN_js_1.clsPaperEN.con_PaperTitle, "");
                        console.log("完成BindDdl_PaperId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevPaperCollectionLogCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            $("#hidUserId").val(strUserId);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                }
                strWhereCond += " And updUser='" + strUserId + "'";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCollectionLogCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vPaperCollectionLog对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrPaperCollectionLogObjLst">需要绑定的对象列表</param>
       */
        async BindTab_vPaperCollectionLog(divContainer, arrvPaperCollectionLogObjLst) {
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
                    fldName: "updDate",
                    colHeader: "收藏日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
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
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "阅读",
                //    Text: "阅读",
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
                {
                    fldName: "",
                    colHeader: "取消收藏",
                    text: "取消收藏", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
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
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvPaperCollectionLogObjLst, arrDataColumn, "paperCollectionLogId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /*
       在数据表里删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
      */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要取消的收藏！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                const responseText2 = await this.BindGv_vPaperCollectionLog();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收藏不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
       根据关键字删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
      */
        async DelRecord(lngPaperCollectionLogId) {
            try {
                const returnInt = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_DelRecordAsync)(lngPaperCollectionLogId);
                if (returnInt > 0) {
                    var strInfo = `取消收藏成功,共取消${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `收藏不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收藏不成功. ${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.PaperCollectionLog_QUDI_Ex = PaperCollectionLog_QUDI_Ex;
});

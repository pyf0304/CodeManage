(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvSectionWApi.js", "../TS/PubFun/clsPubSessionStorage.js", "./Section_QUDI_TS.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Section_QUDI_TSEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:Section_QUDI_TSEx
    表名:Section(01120558)
    生成代码版本:2020.01.06.1
    生成日期:2020/01/07 15:46:30
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsvSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js");
    const clsSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsvSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvSectionWApi.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const Section_QUDI_TS_js_1 = require("./Section_QUDI_TS.js");
    /* Section_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Section_QUDI_TSEx extends Section_QUDI_TS_js_1.Section_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvSectionBy: string = "sectionId";
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
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    //1、为下拉框设置数据源,绑定列表数据
                    this.hidSortvSectionBy = "sectionId Asc";
                    var strWhereCond = this.CombinevSectionCondition();
                    const responseText = await (0, clsvSectionWApi_js_1.vSection_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.RecCount = jsonData;
                    });
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSection();
                    $("#hidUserId").val(strUserId);
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
        /* 添加新记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordSave() {
            try {
                const responseText = (0, clsSectionWApi_js_1.Section_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表Section的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtSectionId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            this.DivName = "divAddNewRecordSave";
            var objSectionEN = new clsSectionEN_js_1.clsSectionEN();
            this.PutDataToSectionClass(objSectionEN);
            try {
                //const responseText = await Section_IsExistAsync(objSectionEN.sectionId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objSectionEN.sectionId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsSectionWApi_js_1.Section_AddNewRecordAsync)(objSectionEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        CombinevSectionCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperId = $("#hidPaperId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.SectionName_q != "") {
                    strWhereCond += ` And ${clsvSectionEN_js_1.clsvSectionEN.con_SectionName} like '% ${this.SectionName_q}%'`;
                }
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvSectionEN_js_1.clsvSectionEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                //论文ID
                strWhereCond += ` And ${clsvSectionEN_js_1.clsvSectionEN.con_PaperId} = '${strPaperId}'`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSectionCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjSectionEN">数据传输的目的类对象</param>
      */
        PutDataToSectionClass(pobjSectionEN) {
            pobjSectionEN.sectionId = this.sectionId; // 节Id
            pobjSectionEN.sectionName = this.sectionName; // 节名
            pobjSectionEN.paperId = $("#hidPaperId").val(); // 论文Id
            pobjSectionEN.orderNum = Number(this.orderNum); // 排序
            pobjSectionEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjSectionEN.updUser = $("#hidUserId").val();
            ; // 修改人
            pobjSectionEN.memo = this.memo; // 备注
        }
        /*
    * 获取年月日
    */
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vSection() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevSectionCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSectionObjLst = [];
            try {
                const responseRecCount = await (0, clsvSectionWApi_js_1.vSection_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSectionBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSectionWApi_js_1.vSection_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSectionObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSectionObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vSection(strListDiv, arrvSectionObjLst);
                console.log("完成BindGv_vSection!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.Section_QUDI_TSEx = Section_QUDI_TSEx;
});

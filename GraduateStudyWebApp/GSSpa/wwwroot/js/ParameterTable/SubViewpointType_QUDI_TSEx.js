(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../TS/PubFun/clsPubSessionStorage.js", "./SubViewpointType_QUDI_TS.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SubViewpointType_QUDI_TSEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SubViewpointType_QUDI_TSEx
    表名:SubViewpointType(01120533)
    生成代码版本:2019.12.06.1
    生成日期:2019/12/27 14:25:08
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
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const SubViewpointType_QUDI_TS_js_1 = require("./SubViewpointType_QUDI_TS.js");
    /* SubViewpointType_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class SubViewpointType_QUDI_TSEx extends SubViewpointType_QUDI_TS_js_1.SubViewpointType_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortSubViewpointTypeBy: string = "subViewpointTypeId";
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
                    this.hidSortSubViewpointTypeBy = "subViewpointTypeId Asc";
                    var strWhereCond = this.CombineSubViewpointTypeCondition();
                    const responseText = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.RecCount = jsonData;
                    });
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_SubViewpointType();
                    $("#hidUserId").val(strUserId);
                    //管理员 判断角色 
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#tab4Bind tr").find("td:eq(7)").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").hide();
                        $("#tab4Bind tr").find("td:eq(7)").hide();
                    }
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
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjSubViewpointTypeEN">数据传输的目的类对象</param>
       */
        PutDataToSubViewpointTypeClass(pobjSubViewpointTypeEN) {
            pobjSubViewpointTypeEN.subViewpointTypeId = this.subViewpointTypeId; // 类型Id
            pobjSubViewpointTypeEN.subViewpointTypeName = this.subViewpointTypeName; // 类型名称
            pobjSubViewpointTypeEN.orderNum = this.orderNum; // 序号
            pobjSubViewpointTypeEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjSubViewpointTypeEN.updUserId = $("#hidUserId").val(); // 修改用户Id
            pobjSubViewpointTypeEN.memo = this.memo; // 备注
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_SubViewpointType() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombineSubViewpointTypeCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrSubViewpointTypeObjLst = [];
            try {
                const responseRecCount = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortSubViewpointTypeBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrSubViewpointTypeObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrSubViewpointTypeObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_SubViewpointType(strListDiv, arrSubViewpointTypeObjLst);
                console.log("完成BindGv_SubViewpointType!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.SubViewpointType_QUDI_TSEx = SubViewpointType_QUDI_TSEx;
});

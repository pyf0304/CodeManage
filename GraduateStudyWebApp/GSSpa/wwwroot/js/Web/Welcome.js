(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Welcome = void 0;
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsvXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsvPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js");
    const clsPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js");
    const clsTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js");
    const clsViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js");
    const clsvPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Welcome {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //管理员 判断角色 
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                    $("#Personaldiv").hide();
                }
                else {
                    //学生00620003 教师 
                    $("#Personaldiv").show();
                }
                const response1 = await this.Bind_Major();
                const response2 = await this.Bind_AllCount();
                const response3 = await this.Bind_PersonalAllCount();
                $("#divLoading").hide();
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async Bind_Major() {
            try {
                var arrvXzMajorDirectionObjLst = [];
                var objvXzMajorDirection_Cond = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
                objvXzMajorDirection_Cond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_id_XzMajor(), "=");
                const responseObjLst = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetSubObjLst_Cache)(objvXzMajorDirection_Cond).then((jsonData) => {
                    arrvXzMajorDirectionObjLst = jsonData;
                });
                //var strWhereCond = " id_XzMajor='" + clsPubSessionStorage.GetSession_id_XzMajor() + "'";
                //const responseObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
                //});
                var strMajorDirection = "";
                for (var i = 0; i < arrvXzMajorDirectionObjLst.length; i++) {
                    strMajorDirection += arrvXzMajorDirectionObjLst[i].majorDirectionName + ",";
                }
                $('#spanMajordirection').html(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserName() + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_majorName() + '专业，专业方向包含(' + strMajorDirection + ')');
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async Bind_AllCount() {
            try {
                var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                //论文统计
                var objvPaper_Cond1 = new clsvPaperEN_js_1.clsvPaperEN();
                const responseRecCount1 = await (0, clsvPaperExWApi_js_1.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache)(objvPaper_Cond1, strid_CurrEducls).then((jsonData) => {
                    var RecCount = jsonData;
                    $('#PaperNum').html(RecCount);
                });
                //引用论文统计
                var objvPaper_Cond2 = new clsvPaperEN_js_1.clsvPaperEN();
                objvPaper_Cond2.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis, 1, "=");
                const responseRecCount2 = await (0, clsvPaperExWApi_js_1.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache)(objvPaper_Cond2, strid_CurrEducls).then((jsonData) => {
                    var RecCount = jsonData;
                    $('#QuotePaperNum').html(RecCount);
                });
                //本组论文统计
                var objvPaper_Cond3 = new clsvPaperEN_js_1.clsvPaperEN();
                objvPaper_Cond3.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis, 0, "=");
                const responseRecCount3 = await (0, clsvPaperExWApi_js_1.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache)(objvPaper_Cond3, strid_CurrEducls).then((jsonData) => {
                    var RecCount = jsonData;
                    $('#GroupPaperNum').html(RecCount);
                });
                //论文阅读数
                var objvPaperReadWrite_Cond1 = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
                objvPaperReadWrite_Cond1.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "01", "=");
                const responseRecCount4 = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCond_Cache)(objvPaperReadWrite_Cond1, strid_CurrEducls).then((jsonData) => {
                    var RecCount = jsonData;
                    $('#PaperReadNum').html(RecCount);
                });
                //论文写作数
                var objvPaperReadWrite_Cond2 = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
                objvPaperReadWrite_Cond2.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
                const responseRecCount5 = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCond_Cache)(objvPaperReadWrite_Cond2, strid_CurrEducls).then((jsonData) => {
                    var RecCount = jsonData;
                    $('#PaperWriteNum').html(RecCount);
                });
                //论文子观点统计
                const responseRecCount6 = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetRecCountByCondAsync)("1=1").then((jsonData) => {
                    var RecCount = jsonData;
                    $('#PaperSubViewpointNum').html(RecCount);
                    //
                    ////加载页面所需数据源到缓存
                    //vPaper_GetObjLstAsync("1=1");
                    //const arrvPaper_Cache = await vPaper_GetObjLstAsync("1=1");
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //个人数据统计
        async Bind_PersonalAllCount() {
            //获取当前登录人Id
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var objvPaper_Cond1 = new clsvPaperEN_js_1.clsvPaperEN();
            objvPaper_Cond1.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis, 1, "=");
            objvPaper_Cond1.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_UpdUser, strUserId, "=");
            //论文；
            const responseRecCount1 = await (0, clsvPaperExWApi_js_1.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache)(objvPaper_Cond1, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalPaperNum').html(RecCount);
            });
            //论文阅读
            var objvPaperReadWrite_Cond1 = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
            objvPaperReadWrite_Cond1.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "01", "=");
            objvPaperReadWrite_Cond1.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser, strUserId, "=");
            const responseRecCount2 = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCond_Cache)(objvPaperReadWrite_Cond1, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalPaperReadNum').html(RecCount);
            });
            //论文阅读
            var objvPaperReadWrite_Cond2 = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
            objvPaperReadWrite_Cond2.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
            objvPaperReadWrite_Cond2.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser, strUserId, "=");
            const responseRecCount3 = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCond_Cache)(objvPaperReadWrite_Cond2, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalPaperWriteNum').html(RecCount);
            });
            //论文阅读
            //var strWhereCond4 = "";
            //const responseRecCount2 = await PaperReadWrite_GetRecCountByCondAsync("operationTypeId=01 And updUser='" + strUserId + "'").then((jsonData) => {
            //    var RecCount = jsonData;
            //    $('#PersonalPaperReadNum').html(RecCount);
            //});
            //论文读写
            //const responseRecCount3 = await PaperReadWrite_GetRecCountByCondAsync("operationTypeId=02 And updUser='" + strUserId + "'").then((jsonData) => {
            //    var RecCount = jsonData;
            //    $('#PersonalPaperWriteNum').html(RecCount);
            //});
            //论文子观点
            const responseRecCount4 = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetRecCountByCondAsync)("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalPaperSubViewpointNum').html(RecCount);
            });
            //主题个人观点
            const responseRecCount5 = await (0, clsViewpointWApi_js_1.Viewpoint_GetRecCountByCondAsync)("1=1 And userTypeId = '01' And updUser='" + strUserId + "'").then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalViewpointNum').html(RecCount);
            });
            //主题专家观点
            const responseRecCount6 = await (0, clsViewpointWApi_js_1.Viewpoint_GetRecCountByCondAsync)("1=1 And userTypeId = '02' And updUser='" + strUserId + "'").then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalExpertViewpointNum').html(RecCount);
            });
            //主题概念
            const responseRecCount7 = await (0, clsConceptWApi_js_1.Concept_GetRecCountByCondAsync)("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalConceptNum').html(RecCount);
            });
            //客观事实
            const responseRecCount8 = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetRecCountByCondAsync)("1=1 And objectiveType = '01' And updUser='" + strUserId + "'").then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalObjectiveFact').html(RecCount);
            });
            //客观数据
            const responseRecCount9 = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetRecCountByCondAsync)("1=1 And objectiveType = '02' And updUser='" + strUserId + "'").then((jsonData) => {
                var RecCount = jsonData;
                $('#PersonalObjectiveBasis').html(RecCount);
            });
        }
    }
    exports.Welcome = Welcome;
});
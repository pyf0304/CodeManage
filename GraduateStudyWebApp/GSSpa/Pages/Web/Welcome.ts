
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsvXzMajorDirectionEN } from "../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { vXzMajorDirection_GetSubObjLst_Cache } from "../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js";
import { PaperSubViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { vPaperReadWrite_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { Concept_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { TopicObjective_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { Viewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vPaperEx_GetRecCountByCondById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Welcome {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }



    public async Page_Load() {
        // 在此处放置用户代码以初始化页面

        try {
            //管理员 判断角色 
            if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {
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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    public async Bind_Major() {

        try {
            var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = [];

            var objvXzMajorDirection_Cond: clsvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
            objvXzMajorDirection_Cond.SetCondFldValue(clsvXzMajorDirectionEN.con_id_XzMajor, clsPubSessionStorage.GetSession_id_XzMajor(), "=");


            const responseObjLst = await vXzMajorDirection_GetSubObjLst_Cache(objvXzMajorDirection_Cond).then((jsonData) => {
                arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
            });

            //var strWhereCond = " id_XzMajor='" + clsPubSessionStorage.GetSession_id_XzMajor() + "'";
            //const responseObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
            //});

            var strMajorDirection = "";
            for (var i = 0; i < arrvXzMajorDirectionObjLst.length; i++) {
                strMajorDirection += arrvXzMajorDirectionObjLst[i].majorDirectionName + ",";
            }

            $('#spanMajordirection').html(clsPubSessionStorage.GetSession_UserName() + clsPubSessionStorage.GetSession_majorName() + '专业，专业方向包含(' + strMajorDirection + ')');
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }
    public async Bind_AllCount() {

        try {
            var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
            //论文统计
            var objvPaper_Cond1: clsvPaperEN = new clsvPaperEN();
            const responseRecCount1 = await vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond1, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#PaperNum').html(RecCount);
            });

            //引用论文统计
            var objvPaper_Cond2: clsvPaperEN = new clsvPaperEN();
            objvPaper_Cond2.SetCondFldValue(clsvPaperEN.con_IsQuotethesis, 1, "=");
            const responseRecCount2 = await vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond2, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#QuotePaperNum').html(RecCount);
            });

            //本组论文统计
            var objvPaper_Cond3: clsvPaperEN = new clsvPaperEN();
            objvPaper_Cond3.SetCondFldValue(clsvPaperEN.con_IsQuotethesis, 0, "=");
            const responseRecCount3 = await vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond3, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#GroupPaperNum').html(RecCount);
            });


            //论文阅读数
            var objvPaperReadWrite_Cond1: clsvPaperReadWriteEN = new clsvPaperReadWriteEN();
            objvPaperReadWrite_Cond1.SetCondFldValue(clsvPaperReadWriteEN.con_OperationTypeId, "01", "=");
            const responseRecCount4 = await vPaperReadWrite_GetRecCountByCond_Cache(objvPaperReadWrite_Cond1, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#PaperReadNum').html(RecCount);
            });

            //论文写作数
            var objvPaperReadWrite_Cond2: clsvPaperReadWriteEN = new clsvPaperReadWriteEN();
            objvPaperReadWrite_Cond2.SetCondFldValue(clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
            const responseRecCount5 = await vPaperReadWrite_GetRecCountByCond_Cache(objvPaperReadWrite_Cond2, strid_CurrEducls).then((jsonData) => {
                var RecCount = jsonData;
                $('#PaperWriteNum').html(RecCount);
            });


            //论文子观点统计
            const responseRecCount6 = await PaperSubViewpoint_GetRecCountByCondAsync("1=1").then((jsonData) => {
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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }

    //个人数据统计
    public async Bind_PersonalAllCount() {

        //获取当前登录人Id
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();

        var objvPaper_Cond1: clsvPaperEN = new clsvPaperEN();
        objvPaper_Cond1.SetCondFldValue(clsvPaperEN.con_IsQuotethesis, 1, "=");
        objvPaper_Cond1.SetCondFldValue(clsvPaperEN.con_UpdUser, strUserId, "=");
        //论文；
        const responseRecCount1 = await vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond1, strid_CurrEducls).then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalPaperNum').html(RecCount);
        });

        //论文阅读
        var objvPaperReadWrite_Cond1: clsvPaperReadWriteEN = new clsvPaperReadWriteEN();
        objvPaperReadWrite_Cond1.SetCondFldValue(clsvPaperReadWriteEN.con_OperationTypeId, "01", "=");
        objvPaperReadWrite_Cond1.SetCondFldValue(clsvPaperReadWriteEN.con_UpdUser, strUserId, "=");
        const responseRecCount2 = await vPaperReadWrite_GetRecCountByCond_Cache(objvPaperReadWrite_Cond1, strid_CurrEducls).then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalPaperReadNum').html(RecCount);
        });

        //论文阅读
        var objvPaperReadWrite_Cond2: clsvPaperReadWriteEN = new clsvPaperReadWriteEN();
        objvPaperReadWrite_Cond2.SetCondFldValue(clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
        objvPaperReadWrite_Cond2.SetCondFldValue(clsvPaperReadWriteEN.con_UpdUser, strUserId, "=");
        const responseRecCount3 = await vPaperReadWrite_GetRecCountByCond_Cache(objvPaperReadWrite_Cond2, strid_CurrEducls).then((jsonData) => {
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
        const responseRecCount4 = await PaperSubViewpoint_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalPaperSubViewpointNum').html(RecCount);
        });

        //主题个人观点
        const responseRecCount5 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '01' And updUser='" + strUserId + "'").then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalViewpointNum').html(RecCount);
        });
        //主题专家观点
        const responseRecCount6 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '02' And updUser='" + strUserId + "'").then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalExpertViewpointNum').html(RecCount);
        });
        //主题概念
        const responseRecCount7 = await Concept_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalConceptNum').html(RecCount);
        });
        //客观事实
        const responseRecCount8 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '01' And updUser='" + strUserId + "'").then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalObjectiveFact').html(RecCount);
        });
        //客观数据
        const responseRecCount9 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '02' And updUser='" + strUserId + "'").then((jsonData) => {
            var RecCount = jsonData;
            $('#PersonalObjectiveBasis').html(RecCount);
        });

    }
    



}
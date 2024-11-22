﻿import { gs_TotalDataStatisticsCRUD } from "../PagesBase/GraduateEduTools/gs_TotalDataStatisticsCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js";
import { clsgs_AnswerCountEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js";
import { clsgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { clsgs_TotalDataTypeEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataTypeEN.js";
import { clsSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js";
import { clsvgs_TotalDataStatisticsEN } from "../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { vCurrEduClsStu_GetSubObjLst_Cache } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js";
import { gs_AnswerCount_GetSubObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js";
import { gs_TeachingDate_GetFirstObjAsync, gs_TeachingDate_GetObjLst_Cache, gs_TeachingDate_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache, gs_TotalDataType_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js";
import { SysComment_GetSubObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { vgs_TotalDataStatistics_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { SysCommentEx_UpdateCommentWeekAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js";
import { gs_AnswerCountEx_GetAnswerCountByTableAsync, gs_AnswerCountEx_GetAnswerCountNumObjLstAsync, gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_AnswerCountExWApi.js";
import { gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { vgs_TotalDataStatisticsEx_GetObjLst_Cache, vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync, vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync, vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync, vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst, BindDdl_ObjLst_V, BindTab } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { gs_TeachingDate_EditEx } from "./gs_TeachingDate_EditEx.js";

declare function Canvas1(str1, str2): void;
//declare function Canvas2(str1, str2, str3): void;
//declare function Canvas3(str1, str2): void;
//declare function Canvas4(str1, str2, str3): void;

//declare function Canvas5(str1, str2, str3): void;
//declare function Canvas6(str1, str2): void;
//declare function Canvas7(str1, str2): void;
declare function Canvas3(str1, str2, Number, strUserIdorCurrEduClsId): void;//图标方法


declare function Canvas2(str1, str2, str3, Number, strUserIdorCurrEduClsId): void;
declare function Canvas4(str1, str2, str3, Number, strUserIdorCurrEduClsId): void;

declare function Canvas5(str1, str2, str3, Number, strUserIdorCurrEduClsId): void;
declare function Canvas6(str1, str2, Number, strUserIdorCurrEduClsId): void;
declare function Canvas7(str1, str2, Number, strUserIdorCurrEduClsId): void;

declare function btn_Click(): void;
declare function tbody(): void;
declare function Alert1(strMsg): void;
declare function Alert2(strMsg): void;
declare function Alert3(strMsg): void;
declare function Alert4(strMsg): void;

declare var $;
declare var window;
/* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class TotalDataStatisticsEx extends gs_TotalDataStatisticsCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 50;
    }

    BindGv(strType: string, strPara: string) {
        //this.BindGv_vgs_TeachingDate();
        var strid_CurrEdu: string = "";
        var strPageStata: string = "";
        this.Bind_AllData();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "vgs_TeachingDate":
                alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                //this.BindGv_vgs_TeachingDate_Cache();
                break;
        }
    }
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.id_CurrEduCls != "") {

                //1、从教学班表内获取当前教学班学生

                await clsDropDownList.BindDdl_CurrEduClsStuUser("ddlUserId_q");
                //const ddl_UserId_q = await this.BindDdl_UserName("ddlUserId_q");

                await gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache(this.divName4Query, "ddlTotalDataTypeId_q");

                await clsDropDownList.BindDdl_TopicId("ddlTopicId_q");


                //默认显示第3个；参数可以变换；
                //if (this.userId_q != "" && this.userId_q != "0") {
                //    // const gvResult1 = await this.BindGv_UserNum();
                //}
                //else {
                //    //默认显示第3个；参数可以变换；
                //    $('#ddlUserId_q').prop('selectedIndex', 2);
                //}




                //获取教学班时间范围
                const gvResult = await this.GetEduDataRandge();
                var strid_CurrEdu: string = "";
                var strPageStata: string = "";
               
                //默认显示数据,因为是本界面调用，所以参数赋 空值；
                const gvResult1 = await this.Bind_AllData();
                //const gvResult1 = await this.Bind_AllData()
                $("#divLoading").hide();


            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //教学班学生关系
    public async BindDdl_UserName(ddlUserId_q: string) {
        //var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        var objDdl = document.getElementById(ddlUserId_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlUserId_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {

            var arrObjLst_Sel: Array<clsvgs_TotalDataStatisticsEN> = await vgs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls);
            //var arrObjLst_Sel: Array<clsvgs_TotalDataStatisticsEN> = await vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync(strWhereCond);

            //arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02");//客观数据；

            var arrUserId_Set: Set<string> = new Set(arrObjLst_Sel.map(x => x.updUser));
            console.log(arrUserId_Set);

            var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
            var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
            console.log(arrUsersList_Sel);
            arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);

            BindDdl_ObjLst_V(ddlUserId_q, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "教学班用户");


            //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvgs_TotalDataStatisticsEN.con_UpdUser]);

            //BindDdl_ObjLst(ddlUserId_q, arrObjLst_Sel, clsvCurrEduClsStuEN.con_StuID, clsvCurrEduClsStuEN.con_StuName, "教学班学生");

            console.log("完成BindDdl_vCurrEduClsStuId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    //获取教学班时间范围
    public async GetEduDataRandge() {
       // var strWhereCond: string = " 1 = 1 and id_CurrEduCls=" + clsPublocalStorage.id_CurrEduCls;
        var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;

        var arrgs_TeachingDateObjLst: Array<clsgs_TeachingDateEN> = [];
        const responseText1 = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls).then((jsonData) => {
            //const responseText1 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
            arrgs_TeachingDateObjLst = <Array<clsgs_TeachingDateEN>>jsonData;
            console.log("获取教学班日期成功");
        });

        //通过教学班得到教学班时间范围；、
       // const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereCond);
        var objgs_TeachingDateEN = arrgs_TeachingDateObjLst.find(x => x.id_CurrEduCls == strid_CurrEduCls);
    //    var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
        if (objgs_TeachingDateEN != null) {
            $("#hidStartDate").val(objgs_TeachingDateEN.startDate);
            $("#hiEndDate").val(objgs_TeachingDateEN.endDate);
            this.StartDate_q = objgs_TeachingDateEN.startDate;
            this.EndDate_q = objgs_TeachingDateEN.endDate;


        }
    }



    //设置教学班范围时间；
    public async btnSetUpDateRecord_Click() {
        var objPage: TotalDataStatisticsEx = new TotalDataStatisticsEx();
        var objPage_Edit: gs_TeachingDate_EditEx = new gs_TeachingDate_EditEx(objPage);
        var strKeyId = clsPublocalStorage.id_CurrEduCls;
        //判断教学班数据是否已经被设置
        var strWhere = " 1 = 1 And id_CurrEduCls = '" + strKeyId + "'";
        const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhere);
        var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
        if (objgs_TeachingDateEN != null) {
            //赋值，弹出框
            //存放教学班日期范围表主键
            $("#hidgs_DateId").val(objgs_TeachingDateEN.mId);
            objPage_Edit.btnUpdateRecordInTab_Click(objgs_TeachingDateEN.mId.toString());
        }
        else {
            //添加 需要清空下隐藏数据
            $("#hidgs_DateId").val("");
            objPage_Edit.btnAddNewRecord_Click();

        }
    }
    //一个是教学班，一个是判断调用函数的类型参数；
    public async Bind_AllData() {
       ////如果传入的教学班为空，那么则可以判断不是其他界面调用此函数；
       // var hQstata: string = "";
       // //如果等于空，则是 本界面调用，那么类型参数按照本界面执行，否则按照传入的参数调用执行；
       // if (strId_CurrEduCls != "") {
       //     hQstata = strPageStata;
       // }
       // else {
       //     hQstata = $("#hidQueryStata").val();
       // }

        var hQstata = $("#hidQueryStata").val();
        //赋值等于空，则是本界面调用，否则按照传入的参数调用执行
        var strId_CurrEduCls: string = "";
        var Number: string = "";
        var strUserIdorCurrEduClsId: string = "";
        switch (hQstata) {
            case "1":
                if (this.userId_q != "" && this.userId_q != "0") {

                }
                else {
                    $('select').prop('selectedIndex', 1);
                }
                const gvResult1 = await this.BindGv_UserNum(strId_CurrEduCls);
                const gvResult_1 = await this.BindGv_UserNumTable();
                break;
            case "2":
                const gvResult2 = await this.BindGv_TeaClassNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                const gvResult_2 = await this.BindGv_UserNumTable();
                break;
            case "3":
                const gvResult3 = await this.BindGv_TotalDataNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                const gvResult_3 = await this.BindGv_TotalDataNumTable();
                break;
            case "4":
                const gvResult4 = await this.BindGv_AVGTeaScore(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                const gvResult_4 = await this.BindGv_TeaClassAverageTab();
                break;
            case "5":
                const gvResult5 = await this.BindChart_TeaClassComment(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                break;
            case "6":
                const gvResult6 = await this.BindChart_UserCommentNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                break;
            case "7":
                const gvResult7 = await this.BindChart_UserDiscussNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                const gvResult_7 = await this.BindGv_UserDiscussNumTable();
                break;

        }



        //if (hQstata == "1") {
        //    if (this.userId_q != "" && this.userId_q != "0") {
        //    }
        //    else {
        //        $('select').prop('selectedIndex', 1);

        //    }

        //    const gvResult = await this.BindGv_UserNum();
        //    const gvResult1 = await this.BindGv_UserNumTable();
        //} else if (hQstata == "2") {


        //    const gvResult = await this.BindGv_TeaClassNum();
        //    const gvResult1 = await this.BindGv_UserNumTable();

        //} else if (hQstata == "3") {
        //    const gvResult = await this.BindGv_TotalDataNum();
        //    const gvResult1 = await this.BindGv_TotalDataNumTable();
        //}
        //else if (hQstata == "4") {
        //    const gvResult = await this.BindGv_AVGTeaScore();
        //    const gvResult1 = await this.BindGv_TeaClassAverageTab();
        //}
        //else if (hQstata == "5") {
        //    const gvResult = await this.BindChart_TeaClassComment();
        //}
        //else if (hQstata == "6") {
        //    const gvResult = await this.BindChart_UserCommentNum();
        //}
    }


    //同步总数据统计
    public async btnSynTotalDataStatistics_Click() {
        $("#divLoading").show();
        var strUserId = clsPublocalStorage.userId;
        var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        try {
            const responseText1 = await gs_TeachingDate_IsExistRecordAsync("id_CurrEduCls =" + strid_CurrEduCls);
            var returnBool1: boolean = !!responseText1;
            if (returnBool1 == true) {
                const responseText2 = await gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strid_CurrEduCls, strUserId);
                var returnBool2: boolean = !!responseText2;
                if (returnBool2 == true) {
                    const responseText3 = await SysCommentEx_UpdateCommentWeekAsync(strid_CurrEduCls, strUserId);
                    var returnBool3: boolean = !!responseText2;
                    if (returnBool3 == true) {
                        var strInfo: string = `同步数据成功!`;
                        //$('#lblResult46').val(strInfo);
                        //显示信息框
                        //Alert1(strInfo);
                        alert(strInfo);
                        $("#divLoading").hide();
                    } else {
                        var strInfo: string = `同步数据成功,但同步评论出错!`;
                        //$('#lblResult46').val(strInfo);
                        //显示信息框
                        //Alert1(strInfo);
                        alert(strInfo);
                        $("#divLoading").hide();
                    }


                }
                else {
                    var strInfo: string = `同步数据不成功!`;
                    //$('#lblResult46').val(strInfo);
                    //显示信息框
                    //Alert1(strInfo);
                    alert(strInfo);
                    $("#divLoading").hide();
                }



                return responseText2;//一定要有一个返回值，否则会出错！
            } else {
                $("#divLoading").hide();
                var strInfo: string = `当前教学班还没有添加教学班时间，请到教学班维护界面添加教学班时间!`;
                alert(strInfo);

            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `统计核算异常,${e}.`;
            alert(strMsg);
            $("#divLoading").hide();
        }
    }


    //同步总数据统计
    public async btnSynAnswerCount_Click() {
        $("#divLoading").show();
        var strUserId = clsPublocalStorage.userId;
        var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        try {
            const responseText1 = await gs_TeachingDate_IsExistRecordAsync("id_CurrEduCls =" + strid_CurrEduCls);
            var returnBool1: boolean = !!responseText1;
            if (returnBool1 == true) {
                const responseText2 = await gs_AnswerCountEx_GetAnswerCountByTableAsync(strid_CurrEduCls, strUserId);
                var returnBool2: boolean = !!responseText2;
                if (returnBool2 == true) {
                    var strInfo: string = `同步数据成功!`;
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                else {
                    var strInfo: string = `同步数据不成功!`;
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                return responseText2;//一定要有一个返回值，否则会出错！
            } else {
                $("#divLoading").hide();
                var strInfo: string = `当前教学班还没有添加教学班时间，请到教学班维护界面添加教学班时间!`;
                alert(strInfo);

            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `统计核算异常,${e}.`;
            alert(strMsg);
            $("#divLoading").hide();
        }
    }





    /* 用户统计
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_liUserNum_Click)
*/
    public async liUserNum_Click() {
        try {
            var strid_CurrEdu: string = "";
            if (this.userId_q != "" && this.userId_q != "0") {
                const gvResult1 = await this.BindGv_UserNum(strid_CurrEdu);

                const gvResult2 = await this.BindGv_UserNumTable();
            }
            else {
                Alert2("请先选择用户并查询！");
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }
    //用户统计列表
    public async BindGv_UserNumTable() {
        var strid_CurrEdu: string = "";
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        //周合集、观点合集
        var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //所有观点详细
        var arrvgs_TotalDetailObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //某一类型观点详细
        var ChildarrvSysCommentObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //获取统计类型数据；
        var gs_TotalDataTypeObjLst: Array<clsgs_TotalDataTypeEN> = [];

        try {
            //获取周和观点数据
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("获取周和观点数据成功");
            });
            //获取观点详细数据；
            const responseText1 = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDetailObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("获取详细数据成功");
            });
            ////获取统计类型数据；
            //const responseText2 = await gs_TotalDataType_GetObjLstAsync("1=1").then((jsonData) => {
            //    gs_TotalDataTypeObjLst = <Array<clsgs_TotalDataTypeEN>>jsonData;
            //    console.log("获取统计类型数据成功");
            //});
            gs_TotalDataTypeObjLst = await gs_TotalDataType_GetObjLst_Cache();
           // arrObjLst_Sel = arrObjLst_Sel.filter(x => x.totalDataTypeId != "02");

            var strhtml = "";
            var cateid: number = 0;
            var cateid_: number = 0;
            if ($("#hidQueryStata").val() == "1") {
                $('#tbListUserNum tr').remove();
            }
            else {
                $('#tbListTeaClassNum tr').remove();
            }

            if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                //得到数据源循环数据
                for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                    cateid++;
                    // intJ++;
                    var fid: number = 0;
                    //周；
                    var strWeek = arrvgs_TotalDataStatisticsObjLst[i].week;
                    //周日期范围
                    var strWeekTimeFrame = arrvgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                    //记录数
                    var strNum = arrvgs_TotalDataStatisticsObjLst[i].memo;


                    //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                    ChildarrvSysCommentObjLst = arrvgs_TotalDetailObjLst.filter(x => x.week == strWeek);

                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                    //周
                    strhtml += '<td>' + strWeek + '</td>';
                    //周日期范围
                    strhtml += '<td>' + strWeekTimeFrame + '</td>';

                    strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strNum + '</td>';


                    //结束
                    strhtml += '</tr>';

                    //父节点转化
                    cateid_ = cateid;

                    //子数据
                    if (ChildarrvSysCommentObjLst.length > 0) {
                        //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                        // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                        //循环统计类型；
                        for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                            var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                            var DetailTypeObjLst = ChildarrvSysCommentObjLst.filter(x => x.totalDataTypeId == strTypeId);
                            //如果大于0 ，说明有此类型数据，需要输出；
                            if (DetailTypeObjLst.length > 0) {
                                for (var j = 0; j < DetailTypeObjLst.length; j++) {
                                    cateid++;
                                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                                    //周
                                    strhtml += '<td>' + strWeek + '</td>';
                                    //周日期范围
                                    strhtml += '<td>' + strWeekTimeFrame + '</td>';
                                    strhtml += '<td>' + DetailTypeObjLst[j].totalDataTypeName + '[' + DetailTypeObjLst.length + ']</td>';


                                    strhtml += '</tr>';
                                    //因为统计一个类型数据量，所以直接break；
                                    break;
                                }


                            }
                        }
                    }

                }
            }


            //拼接；
            if ($("#hidQueryStata").val() == "1") {
                $("#tbListUserNum").html(strhtml);
            }
            else {
                $("#tbListTeaClassNum").html(strhtml);

            }


            tbody();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取用户统计数据不成功,${e}.`;
            alert(strMsg);
        }
    }





    /* 教学班统计
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_liTeaClassNum_Click)
*/
    public async liTeaClassNum_Click() {
        try {
            var strid_CurrEdu: string = ""; //其他界面调用共参；
            var Number: string = "";
            var strUserIdorCurrEduClsId: string = "";
            const gvResult = await this.BindGv_TeaClassNum(strid_CurrEdu, Number, strUserIdorCurrEduClsId);
            const gvResult1 = await this.BindGv_UserNumTable();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    //教学班平均分
    public async TeaClassAverage_Click() {
        try {
            var strId_CurrEduCls: string = "";
            var Number: string = "";
            var strUserIdorCurrEduClsId: string = "";
            const gvResult = await this.BindGv_AVGTeaScore(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
            const gvResult1 = await this.BindGv_TeaClassAverageTab();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    // //教学班平均分 列表
    public async BindGv_TeaClassAverageTab() {
        var strid_CurrEdu: string = "";
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //所有观点详细
        var arrvgs_TotalDetailObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //某一类型观点详细
        var ChildarrvSysCommentObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //获取统计类型数据；
        var gs_TotalDataTypeObjLst: Array<clsgs_TotalDataTypeEN> = [];

        try {
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("获取统计平均分成功！");
            });

            //获取观点详细数据；
            const responseText1 = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDetailObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("获取详细数据成功");
            });
            ////获取统计类型数据；
            //const responseText2 = await gs_TotalDataType_GetObjLstAsync("1=1").then((jsonData) => {
            //    gs_TotalDataTypeObjLst = <Array<clsgs_TotalDataTypeEN>>jsonData;
            //    console.log("获取统计类型数据成功");
            //});
            gs_TotalDataTypeObjLst = await gs_TotalDataType_GetObjLst_Cache();

            var strhtml = "";
            var cateid: number = 0;
            var cateid_: number = 0;
            $('#tbListClassAverage tr').remove();

            //得到统计平均分 分类数据
            if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                //得到数据源循环数据
                for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                    cateid++;
                    // intJ++;
                    var fid: number = 0;
                    //周；
                    var strWeek = arrvgs_TotalDataStatisticsObjLst[i].week;
                    //平均分
                    var strScore = arrvgs_TotalDataStatisticsObjLst[i].memo;
                    //周日期范围
                    var strWeekTimeFrame = arrvgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                    //周
                    strhtml += '<td>' + strWeek + '</td>';
                    strhtml += '<td>' + strWeekTimeFrame + '</td>';
                    strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strScore + '</td>';


                    //结束
                    strhtml += '</tr>';

                    //父节点转化
                    cateid_ = cateid;
                    //如果平均分大于0 则查询子数据
                    if (strScore != "0") {
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        ChildarrvSysCommentObjLst = arrvgs_TotalDetailObjLst.filter(x => x.week == strWeek);
                        //子数据
                        if (ChildarrvSysCommentObjLst.length > 0) {
                            //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                            // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                            //循环统计类型；
                            for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                                var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                                var strTypeName = gs_TotalDataTypeObjLst[k].totalDataTypeName;
                                var DetailTypeObjLst = ChildarrvSysCommentObjLst.filter(x => x.totalDataTypeId == strTypeId);
                                //如果大于0 ，说明有此类型数据，需要输出；
                                if (DetailTypeObjLst.length > 0) {
                                    //对象列表某一列求和
                                    //var ScoreSum = DetailTypeObjLst.reduce((p, e) => p + e.teaScore, 0);
                                    //获取只打分的观点数
                                    var DetailNumObjLst = DetailTypeObjLst.filter(x => x.teaScore != 0);
                                    //for (var j = 0; j < DetailTypeObjLst.length; j++) {
                                    cateid++;
                                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                                    //周
                                    strhtml += '<td>' + strWeek + '</td>';
                                    strhtml += '<td>' + strWeekTimeFrame + '</td>';
                                    strhtml += '<td>' + strTypeName + '[' + DetailNumObjLst.length + '/' + DetailTypeObjLst.length + ']</td>';


                                    strhtml += '</tr>';
                                    //因为只需要一个统计类型；
                                    //    break;
                                    //}


                                }
                            }
                        }
                    }
                }
            }
            $("#tbListClassAverage").html(strhtml);

            $("#Canvas2").removeClass("");
            tbody();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 总数统计
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async liTotalDataNum_Click() {
        try {
            var strId_CurrEduCls: string = "";
            var Number: string = "";
            var strUserIdorCurrEduClsId: string = "";
            const gvResult = await this.BindGv_TotalDataNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
            const gvResult1 = await this.BindGv_TotalDataNumTable();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //所有学生教学班周统计；
    public async BindGv_TotalDataNumTable() {
        var strid_CurrEdu: string = "";
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        var arrvgs_TotalDataStatisticsObjLst3: Array<clsvgs_TotalDataStatisticsEN> = [];
        //所有观点详细
        var arrvgs_TotalDetailObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //临时
        var arrvgs_TotalDataStatisticsObjLst4: Array<clsvgs_TotalDataStatisticsEN> = [];
        //获取统计类型数据；
        var gs_TotalDataTypeObjLst: Array<clsgs_TotalDataTypeEN> = [];

        try {

            //获取观点详细数据；
            const responseText1 = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDetailObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("获取详细数据成功");
            });
            //用户、周
            const responseText3 = await vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst3 = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("3-3");
            });
            ////获取统计类型数据；
            //const responseText2 = await gs_TotalDataType_GetObjLstAsync("1=1").then((jsonData) => {
            //    gs_TotalDataTypeObjLst = <Array<clsgs_TotalDataTypeEN>>jsonData;
            //    console.log("获取统计类型数据成功");
            //});
            gs_TotalDataTypeObjLst = await gs_TotalDataType_GetObjLst_Cache();


            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            var strhtml = "";
            var cateid: number = 0;
            var cateid_: number = 0;
            $('#tbListTotalDataNum tr').remove();
            //首先得到用户 周 观点统计
            if (arrvgs_TotalDataStatisticsObjLst3.length > 0) {
                //得到数据源循环数据
                for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst3.length; i++) {
                    cateid++;
                    // intJ++;
                    var fid: number = 0;
                    //用户
                    var strUserId = arrvgs_TotalDataStatisticsObjLst3[i].dataUser
                    //周；
                    var strWeek = arrvgs_TotalDataStatisticsObjLst3[i].week;
                    //记录数
                    var strNum = arrvgs_TotalDataStatisticsObjLst3[i].memo;
                    //用户名
                    var objUser = arrUsers.find(x => x.userId == strUserId);

                    //周日期范围
                    var strWeekTimeFrame = arrvgs_TotalDataStatisticsObjLst3[i].weekTimeRange;

                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                    //周
                    strhtml += '<td>' + strWeek + '</td>';
                    strhtml += '<td>' + strWeekTimeFrame + '</td>';
                    if (objUser != null) {
                        //用户
                        strhtml += '<td>' + objUser.userName + '</td>';
                    }
                    else {
                        //用户
                        strhtml += '<td></td>';
                    }
                    strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strNum + '</td>';



                    //结束
                    strhtml += '</tr>';

                    //父节点转化
                    cateid_ = cateid;
                    //先过滤当前循环用户的数据，再过滤当前数据周的数据 然后数据输出；
                    arrvgs_TotalDataStatisticsObjLst4 = arrvgs_TotalDetailObjLst.filter(x => x.dataUser == strUserId && x.week == strWeek);
                    //子数据
                    if (arrvgs_TotalDataStatisticsObjLst4.length > 0) {
                        //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                        // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                        //循环统计类型；
                        for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                            var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                            var DetailTypeObjLst = arrvgs_TotalDataStatisticsObjLst4.filter(x => x.totalDataTypeId == strTypeId);
                            //如果大于0 ，说明有此类型数据，需要输出；
                            if (DetailTypeObjLst.length > 0) {
                                for (var j = 0; j < DetailTypeObjLst.length; j++) {
                                    cateid++;
                                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                                    //周
                                    strhtml += '<td>' + strWeek + '</td>';
                                    strhtml += '<td>' + strWeekTimeFrame + '</td>';
                                    //用户
                                    if (objUser != null) {
                                        //用户
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                    else {
                                        //用户
                                        strhtml += '<td></td>';
                                    }
                                    strhtml += '<td>' + DetailTypeObjLst[j].totalDataTypeName + '[' + DetailTypeObjLst.length + ']</td>';

                                    strhtml += '</tr>';
                                    //因为统计一个类型数据量，所以直接break；
                                    break;
                                }
                            }
                        }
                    }


                }
            }
            $("#tbListTotalDataNum").html(strhtml);
            tbody();

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }




    public CombineCondition1(strid_CurrEdu: string): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1";
         // var  strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;

        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;

            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                }
                if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                }
                //管理员
                //if ($("#hidQueryStata").val() == "1") {
                if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                    if (this.userId_q != "" && this.userId_q != "0") {
                        strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                    }
                    if (this.TopicId_q != "0" && this.TopicId_q != "") {
                        strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                    }
                    if (this.isRecommend == true) {
                        strWhereCond += ` And isRecommend=1`;
                    }

                }
                //if ($("#hidRoleId").val() == "00620001") { }
                //教师
                //else if ($("#hidRoleId").val() == "00620002") {
                //    $("#td_UserId").hide();
                //    strWhereCond += " and dataUser='" + clsPublocalStorage.userId + "'";

                //}
                ////学生
                //else {
                //    $("#td_UserId").hide();
                //    strWhereCond += " and dataUser='" + clsPublocalStorage.userId + "'";

                //}


            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }


        //例如 1 = 1 && userName = '张三'
         strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";

        //通过教学班得到教学班时间范围；、

        //if (this.EndDate_q == "") {
        //    if ($("#hidQueryStata").val() == "2" || $("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "4") {
        //        if ($("#hidStartDate").val() != "" && $("#hiEndDate").val() != "") {
        //            var startDate = $("#hidStartDate").val();
        //            var endDate = $("#hiEndDate").val();
        //            strWhereCond += " And dataAddDate >= '" + startDate + "' And dataAddDate <= '" + endDate + "'";
        //        }
        //    }
        //}

        //var strPaperTypeId = $("#hidPaperTypeId").val();
  
        return strWhereCond;
    }


    public CombineConditionObj1(strid_CurrEdu: string): clsvgs_TotalDataStatisticsEN  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        var objvgs_TotalDataStatistics_Cond: clsvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            try {
                if (this.StartDate_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;

                    objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.StartDate_q, ">=");
                }
                if (this.EndDate_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                    objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                }
                if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                    objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                }
                //管理员
                //if ($("#hidQueryStata").val() == "1") {
                if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                    if (this.userId_q != "" && this.userId_q != "0") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                        objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    if (this.TopicId_q != "0" && this.TopicId_q != "") {
                        //  strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                        objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                }

            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }

        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }
       
        objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, strId_CurrEduCls, "=");

        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
       
        return objvgs_TotalDataStatistics_Cond;
    }


    public CombineCondition2(strid_CurrEdu: string): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            try {
                if (this.userId_q != "" && this.userId_q != "0") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN.con_StuID} = '${this.userId_q}'`;
                }

               
            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }
        strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
        strWhereCond += ' order by stuName Asc';
        return strWhereCond;
    }
    public CombineConditionObj2(strid_CurrEdu: string): clsvCurrEduClsStuEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvCurrEduClsStu_Cond: clsvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
        
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            try {
                if (this.userId_q != "" && this.userId_q != "0") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN.con_StuID} = '${this.userId_q}'`;
                    objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN.con_StuID, this.userId_q, "=");
                }


            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；


        }

        objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN.con_id_CurrEduCls, strId_CurrEduCls, "=");

      //  strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
        //strWhereCond += ' order by stuName Asc';
        return objvCurrEduClsStu_Cond;
    }



    public CombineCondition3(strid_CurrEdu: string): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1";
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsSysCommentEN.con_UpdDate} >= '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsSysCommentEN.con_UpdDate} <= '${this.EndDate_q}'`;
                }
                if (this.userId_q != "" && this.userId_q != "0") {
                    strWhereCond += ` And ${clsSysCommentEN.con_UpdUser} = '${this.userId_q}'`;
                }

            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }
        strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";


       
        return strWhereCond;
    }
    public CombineConditionObj3(strid_CurrEdu:string): clsSysCommentEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,

        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }
        var objSysComment_Cond: clsSysCommentEN = new clsSysCommentEN();
        objSysComment_Cond.SetCondFldValue(clsSysCommentEN.con_id_CurrEduCls, strId_CurrEduCls, "=");

        //例如 1 = 1 && userName = '张三'
      //  var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.StartDate_q != "") {
            //    strWhereCond += ` And ${clsSysCommentEN.con_UpdDate} >= '${this.StartDate_q}'`;
                objSysComment_Cond.SetCondFldValue(clsSysCommentEN.con_UpdDate, this.StartDate_q, ">=");
            }
            if (this.EndDate_q != "") {
            //    strWhereCond += ` And ${clsSysCommentEN.con_UpdDate} <= '${this.EndDate_q}'`;
                objSysComment_Cond.SetCondFldValue(clsSysCommentEN.con_UpdDate, this.EndDate_q, "<=");
            }
            if (this.userId_q != "" && this.userId_q != "0") {
             //   strWhereCond += ` And ${clsSysCommentEN.con_UpdUser} = '${this.userId_q}'`;
                objSysComment_Cond.SetCondFldValue(clsSysCommentEN.con_UpdUser, this.userId_q, "=");
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objSysComment_Cond;
    }

    //绑定学生数据统计
    public async BindGv_UserNum(strid_CurrEdu: string) {
        
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        // var ChildarrvSysCommentObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        var arrgs_TeachingDateENObjLst: clsgs_TeachingDateEN;


        try {
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("1-0");
            });
            //教学班
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
            //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
            //if (objgs_TeachingDateEN != null) {
            //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
            //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
            //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();

            //    //计算出相差天数
            //    var days = Math.floor(duration / (24 * 3600 * 1000));
            //    //天数除以7得到周；
            //    var WeekNum = Math.ceil(days / 7);

            var strId_CurrEduCls: string = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
            }
            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {

                if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                    var strWeek: string = "[";
                    var strNum: string = "[";

                    //for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                    //    strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
                    //    strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
                    //}
                    for (var i = 1; i <= WeekNum; i++) {
                        //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        var ChildarrvSysCommentObjLst = arrvgs_TotalDataStatisticsObjLst.find(x => x.week == i);
                        if (ChildarrvSysCommentObjLst == null) {
                            strWeek += '"第' + i + '周",';
                            strNum += "0" + ',';

                        }
                        else {
                            strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                            strNum += ChildarrvSysCommentObjLst.memo + ',';
                        }


                    }
                    strWeek = strWeek.substr(0, strWeek.length - 1);
                    strNum = strNum.substr(0, strNum.length - 1);
                    strWeek += "]";
                    strNum += "]";
                    var strLabelsJson = eval(strWeek);
                    var strDatasetsJson = eval(strNum);
                    Canvas1(strLabelsJson, strDatasetsJson);
                }
                else {
                    var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                    alert(strMsg);

                }

            }
            else {
                var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                alert(strMsg);

            }



        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    //获取教学班周教师打分平均分
    public async BindGv_AVGTeaScore(strid_CurrEdu: string, Number: string, strUserIdorCurrEduClsId: string) {
        
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }
        //var objvgs_TotalDataStatistics_Cond = this.CombineConditionObj1(strId_CurrEduCls);
        //var strWhereCond = JSON.stringify(objvgs_TotalDataStatistics_Sim);



        try {
            //const responseText = await vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("1-0");
            });

            //教学班
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
            //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
            //if (objgs_TeachingDateEN != null) {
            //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
            //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
            //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();

            //    //计算出相差天数
            //    var days = Math.floor(duration / (24 * 3600 * 1000));
            //    //天数除以7得到周；
            //    var WeekNum = Math.ceil(days / 7);
           
            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {
                if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                    //var strcolor = this.getRandomColor();
                    var strWeek: string = "[";
                    var strNum: string = "[";
                    var strColor: string = "[";
                    for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                        strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
                        strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
                        strColor += '"' + this.getRandomColor() + '",';
                    }


                    strWeek = strWeek.substr(0, strWeek.length - 1);
                    strNum = strNum.substr(0, strNum.length - 1);
                    strColor = strColor.substr(0, strColor.length - 1);
                    strWeek += "]";
                    strNum += "]";
                    strColor += "]";

                    var strLabelsJson = eval(strWeek);
                    var strDatasetsJson = eval(strNum);
                    var strColorJson = eval(strColor);
                    Canvas4(strLabelsJson, strDatasetsJson, strColorJson, Number, strUserIdorCurrEduClsId);
                }
                else {
                    var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                    alert(strMsg);

                }
            } else {
                var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                alert(strMsg);

            }
            //}
            //else {
            //    var strMsg: string = `当前教学班没有设置时间范围`;
            //console.error(strMsg);
            //    alert(strMsg);
            //}
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    //绑定教学班统计
    public async BindGv_TeaClassNum(strid_CurrEdu: string, Number: string, strUserIdorCurrEduClsId: string) {
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }

        //var objvgs_TotalDataStatistics_Cond = this.CombineConditionObj1(strId_CurrEduCls);
        //var strWhereCond = JSON.stringify(objvgs_TotalDataStatistics_Sim);



        var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];


        try {

            //const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
            const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("1-0");
            });
            ////教学班
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
            //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
            //if (objgs_TeachingDateEN != null) {
            //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
            //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
            //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();

            //    //计算出相差天数
            //    var days = Math.floor(duration / (24 * 3600 * 1000));
            //    //天数除以7得到周；
            //    var WeekNum = Math.ceil(days / 7);
           
            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {

                if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                    //var strcolor = this.getRandomColor();
                    var strWeek: string = "[";
                    var strNum: string = "[";
                    var strColor: string = "[";



                    //for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                    //    strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
                    //    strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
                    //    strColor += '"' + this.getRandomColor() + '",';
                    //}
                    for (var i = 1; i <= WeekNum; i++) {
                        //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        var ChildarrvSysCommentObjLst = arrvgs_TotalDataStatisticsObjLst.find(x => x.week == i);
                        if (ChildarrvSysCommentObjLst == null) {
                            strWeek += '"第' + i + '周",';
                            strNum += "0" + ',';
                            strColor += '"' + this.getRandomColor() + '",';
                        }
                        else {
                            strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                            strNum += ChildarrvSysCommentObjLst.memo + ',';
                            strColor += '"' + this.getRandomColor() + '",';
                        }


                    }

                    strWeek = strWeek.substr(0, strWeek.length - 1);
                    strNum = strNum.substr(0, strNum.length - 1);
                    strColor = strColor.substr(0, strColor.length - 1);
                    strWeek += "]";
                    strNum += "]";
                    strColor += "]";

                    var strLabelsJson = eval(strWeek);
                    var strDatasetsJson = eval(strNum);
                    var strColorJson = eval(strColor);
                    Canvas2(strLabelsJson, strDatasetsJson, strColorJson, Number, strUserIdorCurrEduClsId);

                } else {
                    var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                    console.error(strMsg);
                    alert(strMsg);

                }
            }
            else {
                var strMsg: string = `当前教学班没有设置时间范围`;
                console.error(strMsg);
                alert(strMsg);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    ////得到教学班平均分统计
    //public async  TeaClassAverage() {
    //    var strWhereCond = await this.CombineCondition1();
    //    var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];


    //    try {
    //        const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
    //            arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
    //            console.log("1-0");
    //        });
    //        //var strcolor = this.getRandomColor();
    //        var strWeek: string = "[";
    //        var strNum: string = "[";
    //        var strColor: string = "[";
    //        for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
    //            strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
    //            strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
    //            strColor += '"' + this.getRandomColor() + '",';
    //        }
    //        strWeek = strWeek.substr(0, strWeek.length - 1);
    //        strNum = strNum.substr(0, strNum.length - 1);
    //        strColor = strColor.substr(0, strColor.length - 1);
    //        strWeek += "]";
    //        strNum += "]";
    //        strColor += "]";

    //        var strLabelsJson = eval(strWeek);
    //        var strDatasetsJson = eval(strNum);
    //        var strColorJson = eval(strColor);
    //        Canvas2(strLabelsJson, strDatasetsJson, strColorJson);

    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //}


    //绑定所有学生数据统计

    public async BindGv_TotalDataNum(strid_CurrEdu: string, Number: string, strUserIdorCurrEduClsId: string) {
        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
        var arrvgs_TotalDataStatisticsObjLst1: Array<clsvgs_TotalDataStatisticsEN> = [];
        //var arrvgs_TotalDataStatisticsObjLst2: Array<clsvgs_TotalDataStatisticsEN> = [];
        var arrvgs_TotalDataStatisticsObjLst3: Array<clsvgs_TotalDataStatisticsEN> = [];

        //临时
        var arrvgs_TotalDataStatisticsObjLst4: Array<clsvgs_TotalDataStatisticsEN> = [];


        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }
        //var objvgs_TotalDataStatistics_Cond = this.CombineConditionObj1(strId_CurrEduCls);
        //var strWhere_Cond = JSON.stringify(objvgs_TotalDataStatistics_Sim);



        try {
            //用户
            //const responseText1 = await vgs_TotalDataStatisticsEx_GetUserNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
            const responseText1 = await vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst1 = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("3-1");
            });

            //周
            //const responseText2 = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrvgs_TotalDataStatisticsObjLst2 = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
            //    console.log("3-2");
            //});

            //用户、周
           // const responseText3 = await vgs_TotalDataStatisticsEx_GetUser_WeekNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
            const responseText3 = await vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_TotalDataStatisticsObjLst3 = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                console.log("3-3");
            });
            //教学班
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
            //const responseText5 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText5;


            //if (objgs_TeachingDateEN != null) {
            //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
            //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
            //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();

            //    //计算出相差天数
            //    var days = Math.floor(duration / (24 * 3600 * 1000));
            //    //天数除以7得到周；
            //    var WeekNum = Math.ceil(days / 7);

            var strId_CurrEduCls: string = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
            }
            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {

                var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);


                /*********************************周列表*********************************/
                var strWeek: string = "[";
                //for (var j = 0; j < arrvgs_TotalDataStatisticsObjLst2.length; j++) {
                //    strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst2[j].week + '周",';

                //}
                for (var j = 1; j <= WeekNum; j++) {
                    //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                    //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                    //var ChildarrvSysCommentObjLst = arrvgs_TotalDataStatisticsObjLst2.find(x => x.week == i);
                    //if (ChildarrvSysCommentObjLst == null) {
                    strWeek += '"第' + j + '周",';

                    //}
                    //else {
                    //    strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                    //}


                }

                strWeek = strWeek.substr(0, strWeek.length - 1);
                strWeek += "]";

                var strLabelsJson = eval(strWeek);


                if (arrvgs_TotalDataStatisticsObjLst1.length > 0) {


                    /******************************************************************/

                    //var spanUserName1 = '<span style="font-weight: 500;"><i class="fa fa-square" style="color:'
                    //var spanUserName2 = ';font-size: 20px; padding-right: 5px; vertical-align: middle; margin-top: -3px;"></i>'
                    //var spanUserName3 = '</span>'
                    //var strHtml = "";
                    var strNum: string = "[";
                    for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst1.length; i++) {
                        //获取色码
                        var strcolor = this.getRandomColor();

                        var objUser = arrUsers.find(x => x.userId == arrvgs_TotalDataStatisticsObjLst1[i].dataUser);
                        if (objUser != null) {
                            //strHtml += spanUserName1 + strcolor + spanUserName2 + objUser.userName + spanUserName3;


                            //strNum += "{ label: \"" + objUser.userName + "\",fillColor: \"rgba(220,220,220, 0.01)\",strokeColor: \"" + strcolor + "\",pointColor: \"" + strcolor + "\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"" + strcolor + "\",data: [";
                            strNum += "{ label: \"" + objUser.userName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                            arrvgs_TotalDataStatisticsObjLst4 = arrvgs_TotalDataStatisticsObjLst3.filter(x => x.dataUser == arrvgs_TotalDataStatisticsObjLst1[i].dataUser);

                            //for (var j = 0; j < arrvgs_TotalDataStatisticsObjLst2.length; j++) {
                            for (var j = 1; j <= WeekNum; j++) {
                                if (arrvgs_TotalDataStatisticsObjLst4.length > 0) {
                                    //var objWeek = arrvgs_TotalDataStatisticsObjLst4.find(x => x.week == arrvgs_TotalDataStatisticsObjLst2[j].week);
                                    var objWeek = arrvgs_TotalDataStatisticsObjLst4.find(x => x.week == j);
                                    if (objWeek != null) {
                                        strNum += objWeek.memo + ',';
                                    }
                                    else {
                                        strNum += '0,';
                                    }
                                } else {
                                    strNum += '0,';
                                }
                            }
                            strNum = strNum.substr(0, strNum.length - 1);
                            strNum += "]},";

                        }
                    }

                    strNum = strNum.substr(0, strNum.length - 1);
                    strNum += "]";

                    var strDatasetsJson = eval(strNum);


                    Canvas3(strLabelsJson, strDatasetsJson, Number, strUserIdorCurrEduClsId);

                }
                else {
                    var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                    console.error(strMsg);
                    alert(strMsg);

                }
            }
            else {
                var strMsg: string = `当前教学班没有设置时间范围`;
                console.error(strMsg);
                alert(strMsg);
            }

            //$("#divUserLst").html(strHtml);


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }





    //绑定教学班周评论统计
    public async BindChart_TeaClassComment(strid_CurrEdu: string, Number:string, strUserIdorCurrEduClsId:string) {
        //var strWhereCond = await this.CombineCondition3();


        var objclsSysComment_Cond = this.CombineConditionObj3(strid_CurrEdu);
        var strWhereCond = JSON.stringify(objclsSysComment_Cond);


        var arrSysCommentObjLst0: Array<clsSysCommentEN> = [];
        var arrSysCommentObjLst: Array<clsSysCommentEN> = [];
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }

        try {
            const responseText = await SysComment_GetSubObjLst_Cache(objclsSysComment_Cond, strId_CurrEduCls).then((jsonData) => {
            //const responseText = await SysComment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrSysCommentObjLst0 = <Array<clsSysCommentEN>>jsonData;
                console.log("5-0");
            });
            //教学班
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;

            //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";

            //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
            //if (objgs_TeachingDateEN != null) {
            //var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
            //var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
            //var duration = eventEndTime.valueOf() - eventStartTime.valueOf();

            ////计算出相差天数
            //var days = Math.floor(duration / (24 * 3600 * 1000));
            ////天数除以7得到周；
            //var WeekNum = Math.ceil(days / 7);

            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {
                if (arrSysCommentObjLst0.length > 0) {
                    var strWeek: string = "[";
                    var strNum: string = "[";
                    var strColor: string = "[";

                    for (var i = 1; i <= WeekNum; i++) {
                        //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        arrSysCommentObjLst = arrSysCommentObjLst0.filter(x => x.week == i);
                        strWeek += '"第' + i + '周",';
                        strNum += arrSysCommentObjLst.length + ',';
                        strColor += '"' + this.getRandomColor() + '",';
                    }

                    strWeek = strWeek.substr(0, strWeek.length - 1);
                    strNum = strNum.substr(0, strNum.length - 1);
                    strColor = strColor.substr(0, strColor.length - 1);
                    strWeek += "]";
                    strNum += "]";
                    strColor += "]";

                    var strLabelsJson = eval(strWeek);
                    var strDatasetsJson = eval(strNum);
                    var strColorJson = eval(strColor);
                    Canvas5(strLabelsJson, strDatasetsJson, strColorJson, Number, strUserIdorCurrEduClsId);

                } else {
                    var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                    alert(strMsg);

                }
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }






    //绑定当前教学班用户周期评论数据
    public async BindChart_UserCommentNum(strid_CurrEdu: string, Number: string, strUserIdorCurrEduClsId: string) {

        //var strWhereCond = await this.CombineCondition3(strid_CurrEdu);

        var objclsSysComment_Cond = this.CombineConditionObj3(strid_CurrEdu);
        var strWhereCond = JSON.stringify(objclsSysComment_Cond);

       // var strWhereCond2 = this.CombineCondition2(strid_CurrEdu);
        var objclsvCurrEduClsStu_Cond = this.CombineConditionObj2(strid_CurrEdu);
        var strWhereCond = JSON.stringify(objclsvCurrEduClsStu_Cond);

        var arrSysCommentObjLst0: Array<clsSysCommentEN> = [];
        var arrSysCommentObjLst1: Array<clsSysCommentEN> = [];
        var arrSysCommentObjLst2: Array<clsSysCommentEN> = [];

        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }

        try {
            //var strWhereCond2 = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "' order by stuName Asc";
            var arrCurrEduClsUserObjLst: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetSubObjLst_Cache(objclsvCurrEduClsStu_Cond, strId_CurrEduCls);
            //var arrCurrEduClsUserObjLst: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetObjLstAsync(strWhereCond2);
            console.log("6-1");
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
            console.log("6-2");
            const responseText = await SysComment_GetSubObjLst_Cache(objclsSysComment_Cond, strId_CurrEduCls).then((jsonData) => {
            //const responseText = await SysComment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrSysCommentObjLst0 = <Array<clsSysCommentEN>>jsonData;
                console.log("6-3");
            });
            //var strId_CurrEduCls: string = "";
            //if (strid_CurrEdu == "") {
            //    strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //}
            //else {
            //    strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
            //}

            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {
                /*********************************周列表*********************************/

                var strWeek: string = "[";

                for (var j = 1; j <= WeekNum; j++) {
                    strWeek += '"第' + j + '周",';

                }

                strWeek = strWeek.substr(0, strWeek.length - 1);
                strWeek += "]";

                var strLabelsJson = eval(strWeek);





                /************************************用户和评论数******************************/

                var strNum: string = "[";
                for (var i = 0; i < arrCurrEduClsUserObjLst.length; i++) {
                    //获取色码
                    var strcolor = this.getRandomColor();
                    strNum += "{ label: \"" + arrCurrEduClsUserObjLst[i].stuName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                    arrSysCommentObjLst1 = arrSysCommentObjLst0.filter(x => x.updUser == arrCurrEduClsUserObjLst[i].stuID);
                    for (var j = 1; j <= WeekNum; j++) {
                        arrSysCommentObjLst2 = arrSysCommentObjLst1.filter(x => x.week == j);
                        strNum += arrSysCommentObjLst2.length + ',';
                    }
                    strNum = strNum.substr(0, strNum.length - 1);
                    strNum += "]},";
                }

                strNum = strNum.substr(0, strNum.length - 1);
                strNum += "]";

                var strDatasetsJson = eval(strNum);


                Canvas6(strLabelsJson, strDatasetsJson, Number, strUserIdorCurrEduClsId);

            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }


    public CombineConditionObjgs_AnswerCount(strid_CurrEdu: string): clsgs_AnswerCountEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        var objgs_AnswerCount_Cond: clsgs_AnswerCountEN = new clsgs_AnswerCountEN();
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            try {
                if (this.StartDate_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;

                    objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.StartDate_q, ">=");
                }
                if (this.EndDate_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                    objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                }
                if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                    objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                }
                //管理员
                //if ($("#hidQueryStata").val() == "1") {
                if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                    if (this.userId_q != "" && this.userId_q != "0") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    if (this.TopicId_q != "0" && this.TopicId_q != "") {
                        //  strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                }

            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }

        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }

        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_id_CurrEduCls, strId_CurrEduCls, "=");

        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

        return objgs_AnswerCount_Cond;
    }

    public CombineConditiongs_AnswerCountObj1(strid_CurrEdu: string): clsgs_AnswerCountEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        var objgs_AnswerCount_Cond: clsgs_AnswerCountEN = new clsgs_AnswerCountEN();
        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            try {
                if (this.StartDate_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;

                    objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.StartDate_q, ">=");
                }
                if (this.EndDate_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                    objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                }
                if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                    // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                    objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                }
                //管理员
                //if ($("#hidQueryStata").val() == "1") {
                if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                    if (this.userId_q != "" && this.userId_q != "0") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    if (this.TopicId_q != "0" && this.TopicId_q != "") {
                        //  strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                }

            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }

        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }

        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN.con_id_CurrEduCls, strId_CurrEduCls, "=");

        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

        return objgs_AnswerCount_Cond;
    }


    //绑定当前教学班用户讨论回答统计数据
    public async BindChart_UserDiscussNum(strid_CurrEdu: string, Number: string, strUserIdorCurrEduClsId: string) {

        var strWhereCond = await this.CombineCondition1(strid_CurrEdu);

        //var strWhereCond = await this.CombineConditionObj1(strid_CurrEdu);

        var strId_CurrEduCls: string = "";
        if (strid_CurrEdu == "") {
            strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        }

        //var objgs_AnswerCount1_Cond = this.CombineConditiongs_AnswerCountObj1(strId_CurrEduCls);
        //var strWhere_Cond = JSON.stringify(objgs_AnswerCount_Sim);



        var objgs_AnswerCount_Cond = this.CombineConditionObjgs_AnswerCount(strid_CurrEdu);
        var strWhereCond1 = JSON.stringify(objgs_AnswerCount_Cond);

        var arrgs_AnswerCountUserNum: Array<clsgs_AnswerCountEN> = [];
        //var arrgs_AnswerCountObjLst2: Array<clsgs_AnswerCountEN> = [];
        var arrgs_AnswerCountObjLst1: Array<clsgs_AnswerCountEN> = [];

        //临时
        var arrgs_AnswerCountObjLst2: Array<clsgs_AnswerCountEN> = [];
        var arrgs_AnswerCountObjLst3: Array<clsgs_AnswerCountEN> = [];


        //var strId_CurrEduCls: string = "";
        //if (strid_CurrEdu == "") {
        //    strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        //}
        //else {
        //    strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
        //}

      
        try {
            //用户
            //const responseText1 = await gs_AnswerCountEx_GetSubObjLst_Cache(objgs_AnswerCount1_Cond, strId_CurrEduCls).then((jsonData) => {
            const responseText1 = await gs_AnswerCountEx_GetAnswerCountNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_AnswerCountUserNum = <Array<clsgs_AnswerCountEN>>jsonData;
                console.log("3-1");
            });

            //用户、周
            const responseText3 = await gs_AnswerCount_GetSubObjLst_Cache(objgs_AnswerCount_Cond, strId_CurrEduCls).then((jsonData) => {
            //const responseText3 = await gs_AnswerCount_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_AnswerCountObjLst1 = <Array<clsgs_AnswerCountEN>>jsonData;
                console.log("3-3");
            });

           
            //教学班
            var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);

            if (WeekNum != 0) {

                var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);


                /*********************************周列表*********************************/
                var strWeek: string = "[";
                //for (var j = 0; j < arrgs_AnswerCountObjLst2.length; j++) {
                //    strWeek += '"第' + arrgs_AnswerCountObjLst2[j].week + '周",';

                //}
                for (var j = 1; j <= WeekNum; j++) {
                    //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                    //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                    //var ChildarrvSysCommentObjLst = arrgs_AnswerCountObjLst2.find(x => x.week == i);
                    //if (ChildarrvSysCommentObjLst == null) {
                    strWeek += '"第' + j + '周",';

                    //}
                    //else {
                    //    strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                    //}


                }

                strWeek = strWeek.substr(0, strWeek.length - 1);
                strWeek += "]";

                var strLabelsJson = eval(strWeek);


                if (arrgs_AnswerCountUserNum.length > 0) {


                    /******************************************************************/

                    //var spanUserName1 = '<span style="font-weight: 500;"><i class="fa fa-square" style="color:'
                    //var spanUserName2 = ';font-size: 20px; padding-right: 5px; vertical-align: middle; margin-top: -3px;"></i>'
                    //var spanUserName3 = '</span>'
                    //var strHtml = "";
                    var strNum: string = "[";
                    for (var i = 0; i < arrgs_AnswerCountUserNum.length; i++) {
                        //获取色码
                        var strcolor = this.getRandomColor();

                        //var objUser = arrUsers.find(x => x.userId == arrgs_AnswerCountUserNum[i].dataUser);
                        //if (objUser != null) {
                        //strHtml += spanUserName1 + strcolor + spanUserName2 + objUser.userName + spanUserName3;


                        //strNum += "{ label: \"" + objUser.userName + "\",fillColor: \"rgba(220,220,220, 0.01)\",strokeColor: \"" + strcolor + "\",pointColor: \"" + strcolor + "\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"" + strcolor + "\",data: [";
                        strNum += "{ label: \"" + arrgs_AnswerCountUserNum[i].userName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                        arrgs_AnswerCountObjLst2 = arrgs_AnswerCountObjLst1.filter(x => x.dataUser == arrgs_AnswerCountUserNum[i].dataUser);

                        //for (var j = 0; j < arrgs_AnswerCountObjLst2.length; j++) {
                        for (var j = 1; j <= WeekNum; j++) {
                            if (arrgs_AnswerCountObjLst2.length > 0) {
                                arrgs_AnswerCountObjLst3 = arrgs_AnswerCountObjLst2.filter(x => x.week == j);

                                if (arrgs_AnswerCountObjLst3.length > 0) {
                                    strNum += arrgs_AnswerCountObjLst3.length + ',';
                                } else {
                                    strNum += '0,';
                                }
                                //var objWeek = arrgs_AnswerCountObjLst4.find(x => x.week == arrgs_AnswerCountObjLst2[j].week);
                                //var objWeek = arrgs_AnswerCountObjLst4.find(x => x.week == j);

                                //if (objWeek != null) {
                                //    strNum += objWeek.memo + ',';
                                //}
                                //else {
                                //    strNum += '0,';
                                //}



                            } else {
                                strNum += '0,';
                            }
                        }
                        strNum = strNum.substr(0, strNum.length - 1);
                        strNum += "]},";

                        //}
                    }

                    strNum = strNum.substr(0, strNum.length - 1);
                    strNum += "]";

                    var strDatasetsJson = eval(strNum);


                    Canvas7(strLabelsJson, strDatasetsJson, Number, strUserIdorCurrEduClsId);

                }
                else {
                    var strMsg: string = `当前无数据,请选择其他条件或切换教学班`;
                    console.error(strMsg);
                    alert(strMsg);

                }
            }
            else {
                var strMsg: string = `当前教学班没有设置时间范围`;
                console.error(strMsg);
                alert(strMsg);
            }

            //$("#divUserLst").html(strHtml);


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }


    //用户统计列表
    public async BindGv_UserDiscussNumTable() {
        var strId_CurrEduCls: string = "";
        var strWhereCond = await this.CombineCondition1(strId_CurrEduCls);
        var arrgs_AnswerCountUserNum: Array<clsgs_AnswerCountEN> = [];
        var arrgs_WeekAnswerCountUserNum: Array<clsgs_AnswerCountEN> = [];
        
        
        var arrgs_AnswerCountObjLst1: Array<clsgs_AnswerCountEN> = [];
        //临时
        var arrgs_AnswerCountObjLst2: Array<clsgs_AnswerCountEN> = [];
        var arrgs_AnswerCountObjLst3: Array<clsgs_AnswerCountEN> = [];

        try {
            //用户
            //const responseText1 = await gs_AnswerCountEx_GetAnswerCountNumObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrgs_AnswerCountUserNum = <Array<clsgs_AnswerCountEN>>jsonData;
            //    console.log("7-1");
            //});

            //周
            const responseText2 = await gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_WeekAnswerCountUserNum = <Array<clsgs_AnswerCountEN>>jsonData;
                console.log("7-1");
            });

            //用户、周

            //const responseText3 = await gs_AnswerCount_GetObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrgs_AnswerCountObjLst1 = <Array<clsgs_AnswerCountEN>>jsonData;
            //    console.log("7-3");
            //});


            var strhtml = "";
            var cateid: number = 0;
            var cateid_: number = 0;
            if ($("#hidQueryStata").val() == "1") {
                $('#tbListUserNum tr').remove();
            }
            else {
                $('#tbListTeaClassNum tr').remove();
            }

            if (arrgs_WeekAnswerCountUserNum.length > 0) {
                //得到数据源循环数据
                for (var i = 0; i < arrgs_WeekAnswerCountUserNum.length; i++) {
                    cateid++;
                    // intJ++;
                    var fid: number = 0;
                    //周；
                    var strWeek = arrgs_WeekAnswerCountUserNum[i].week;
                    //周日期范围
                    var strWeekTimeFrame = arrgs_WeekAnswerCountUserNum[i].weekTimeRange;
                    //记录数
                    var strNum = arrgs_WeekAnswerCountUserNum[i].memo;


                    //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                    //ChildarrvSysCommentObjLst = arrvgs_TotalDetailObjLst.filter(x => x.week == strWeek);

                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                    //周
                    strhtml += '<td>' + strWeek + '</td>';
                    //周日期范围
                    strhtml += '<td>' + strWeekTimeFrame + '</td>';

                    strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strNum + '</td>';


                    //结束
                    strhtml += '</tr>';

                    ////父节点转化
                    //cateid_ = cateid;

                    ////子数据
                    //if (ChildarrvSysCommentObjLst.length > 0) {
                    //    //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                    //    // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                    //    //循环统计类型；
                    //    for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                    //        var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                    //        var DetailTypeObjLst = ChildarrvSysCommentObjLst.filter(x => x.totalDataTypeId == strTypeId);
                    //        //如果大于0 ，说明有此类型数据，需要输出；
                    //        if (DetailTypeObjLst.length > 0) {
                    //            for (var j = 0; j < DetailTypeObjLst.length; j++) {
                    //                cateid++;
                    //                strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                    //                //周
                    //                strhtml += '<td>' + strWeek + '</td>';
                    //                //周日期范围
                    //                strhtml += '<td>' + strWeekTimeFrame + '</td>';
                    //                strhtml += '<td>' + DetailTypeObjLst[j].totalDataTypeName + '[' + DetailTypeObjLst.length + ']</td>';


                    //                strhtml += '</tr>';
                    //                //因为统计一个类型数据量，所以直接break；
                    //                break;
                    //            }


                    //        }
                    //    }
                    //}

                }
            }



            $("#tbListUserDiscussNum").html(strhtml);



            //tbody();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取用户统计数据不成功,${e}.`;
            alert(strMsg);
        }
    }




    //获取教学班的时间得到周数
    public async GetTeachingDateWeek(strId_CurrEduCls:string): Promise<number> {
        var strid_CurrEduCls: string = "";
        if (strId_CurrEduCls == "") {
            strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        }
        else {
            strid_CurrEduCls = strId_CurrEduCls
        }
        //教学班
        //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
    //    var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";


        
        const arrgs_TeachingDateObjLst = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_TeachingDateObjLst.length > 0) {
            console.log("获取教学班日期成功");
        }

        //通过教学班得到教学班时间范围；、
        // const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereCond);
        var objgs_TeachingDateEN = arrgs_TeachingDateObjLst.find(x => x.id_CurrEduCls == strid_CurrEduCls);


        //const responseText5 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
        //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText5;

        if (objgs_TeachingDateEN != null) {
            var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
            var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
            var duration = eventEndTime.valueOf() - eventStartTime.valueOf();

            //计算出相差天数
            var days = Math.floor(duration / (24 * 3600 * 1000));
            //天数除以7得到周；
            var WeekNum = Math.ceil(days / 7);
            return WeekNum;
        }
        else {
            var strMsg: string = `当前教学班没有设置时间范围`;
            alert(strMsg);
            return 0;
        }
    }





    //获取不同色码
    public getRandomColor(): string {
        return '#' + ('00000' + (Math.random() * 0x1000000 << 0).toString(16)).substr(-6);
    }



    /*
   * 起始时间
  */
    public get StartDate_q(): string {
        return $("#txtStartDate_q").val();
    }
    /*
    * 起始时间
   */
    public set StartDate_q(value: string) {
        $("#txtStartDate_q").val(value);
    }

    /*
   * 结束时间
  */
    public get EndDate_q(): string {
        return $("#txtEndDate_q").val();
    }
    /*
    * 结束时间
   */
    public set EndDate_q(value: string) {
        $("#txtEndDate_q").val(value);
    }


    /*
   * 用户
  */
    public get userId_q(): string {
        return $("#ddlUserId_q").val();
    }
    /*
    * 用户
   */
    public set userId_q(value: string) {
        $("#ddlUserId_q").val(value);
    }


    /*
  * 数据类型
 */
    public get TotalDataTypeId_q(): string {
        return $("#ddlTotalDataTypeId_q").val();
    }
    /*
    * 数据类型
   */
    public set TotalDataTypeId_q(value: string) {
        $("#ddlTotalDataTypeId_q").val(value);
    }


    /*
    * 是否推荐
   */
    public set isRecommend(value: boolean) {
        $("#chkIsRecommend").val(value);
    }
    /*
    * 是否推荐
   */
    public get isRecommend(): boolean {
        return $("#chkIsRecommend").prop("checked");
    }


    /*
 * 主题
*/
    public get TopicId_q(): string {
        return $("#ddlTopicId_q").val();
    }
    /*
    * 主题
   */
    public set TopicId_q(value: string) {
        $("#ddlTopicId_q").val(value);
    }

}
import { sys_RequestPushCRUD } from "../PagesBase/GraduateEduTools/sys_RequestPushCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clssys_RequestPushEN } from "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsvResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js";
import { clsgs_ColorEN } from "../TS/L0_Entity/ParameterTable/clsgs_ColorEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { CurrEduCls_GetObjByid_CurrEduCls_Cache } from "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { sys_RequestPush_AddNewRecordAsync, sys_RequestPush_GetObjLstAsync, sys_RequestPush_GetRecCountByCondAsync, sys_RequestPush_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js";
import { ResearchTopic_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTUserRela_AddNewRecordAsync, RTUserRela_GetFirstObjAsync, RTUserRela_GetObjLstAsync, RTUserRela_IsExistRecordAsync, RTUserRela_ReOrderAsync, RTUserRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { vResearchTopic_GetObjLstByPagerAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvResearchTopicWApi.js";
import { gs_Color_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format } from "../TS/PubFun/clsString.js";

import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function Alert1(strMsg): void;
declare function Alert2(strMsg): void;
declare function Alert3(strMsg): void;
declare function Alert4(strMsg): void;

declare function CloseWindow(): void;
//declare function tbody(): void;

declare var $;
declare var window;
/* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ApplyTopic extends sys_RequestPushCRUD {
    public static requestStata = "";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 50;
    }


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            //1、为下拉框设置数据源,绑定列表数据
            if (clsPublocalStorage.userId != "") {
                this.hidSortBy = "updDate Desc";
                //绑定主题
                const gvResult1 = await this.BindGv_Topic();

                const gvResult2 = await this.Bind_RequestPushCount();


                //请求
                ApplyTopic.requestStata = "1";
                const gvResult3 = await this.BindGv_sys_RequestPush();
                //通知
                ApplyTopic.requestStata = "2";
                const gvResult4 = await this.BindGv_sys_RequestPush();


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


    /* 查询
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async btnQuery_Click() {
        try {

            const gvResult = await this.BindGv_Topic();

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /*历史请求*/
    public async history_Request_Click() {
        try {
            //请求
            ApplyTopic.requestStata = "3";
            const gvResult3 = await this.BindGv_sys_RequestPush();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*历史通知*/
    public async history_Notice_Click() {
        try {
            //历史通知
            ApplyTopic.requestStata = "4";
            const gvResult3 = await this.BindGv_sys_RequestPush();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    public CombineCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

        strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";

        try {

            if (this.topicName_q != "") {
                strWhereCond += ` And ${clsvResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
            }
            if (this.TopicProposePeople_q != "") {
                strWhereCond += ` And ${clsvResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
            }

            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_UpdDate} > '${this.StartDate_q}'`;
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_UpdDate} < '${this.EndDate_q}'`;
            }
            if (clsPublocalStorage.id_CurrEduCls == "00000050") {
                strWhereCond += " and updUser='" + clsPublocalStorage.userId + "'";
            } else {
                strWhereCond += " and topicId not in(select topicId from RTUserRela where UserID='" + clsPublocalStorage.userId + "')";
            }



        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    public CombineCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_UpdDate} > '${this.StartDate_q}'`;
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_UpdDate} < '${this.EndDate_q}'`;
            }

            strWhereCond += " And updUser = '" + clsPublocalStorage.userId + "'";


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    //主题讨论评论
    public async BindGv_Topic() {

        const strCourseId = clsPublocalStorage.courseId;
        var strWhereCond = await this.CombineCondition1();

        var arrvResearchTopicObjLst: Array<clsvResearchTopicEN> = [];
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        try {
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };

            arrvResearchTopicObjLst = await vResearchTopic_GetObjLstByPagerAsync(objPagerPara);
            if (arrvResearchTopicObjLst.length == 0) {

                const strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                const objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
                const strMsg = Format("没有可申请的研究主题。当前教学班:[{0}].", objCurrEduCls?.eduClsName);
                alert(strMsg);
                return;
            }

            var arrTopicId = "";
            for (var i = 0; i < arrvResearchTopicObjLst.length; i++) {
                arrTopicId += arrvResearchTopicObjLst[i].topicId + ",";
            }
            arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);



            //主题用户关系
            var strWhereCond2 = "topicId in(" + arrTopicId + ")";
            //var strWhereCond3 = "UserID ='" + clsPublocalStorage.userId + "'";
            var arrRTUserRelaObjLst: Array<clsRTUserRelaEN> = [];
            var arrRTUserRelaObjLst2: Array<clsRTUserRelaEN> = [];
            arrRTUserRelaObjLst = await RTUserRela_GetObjLstAsync(strWhereCond2);

            var strhtml = "";
            var cateid: number = 0;
            //$('#tbList tr').remove();

            for (var i = 0; i < arrvResearchTopicObjLst.length; i++) {

                var strTopicName: string = arrvResearchTopicObjLst[i].topicName;
                //var strAppraiseScore: number = arrvResearchTopicObjLst[i].AppraiseScore;
                var strTopicContent: string = arrvResearchTopicObjLst[i].topicContent;
                if (strTopicContent.length > 15) {
                    strTopicContent = strTopicContent.substr(0, 15) + "...";
                }

                var html_TopicContent = '<a style="color:#436EEE;" title="' + arrvResearchTopicObjLst[i].topicContent + '">' + strTopicContent + '</a>';

                var strUserName: string = arrvResearchTopicObjLst[i].updUser + "(" + arrvResearchTopicObjLst[i].userName + ")";
                arrRTUserRelaObjLst2 = arrRTUserRelaObjLst.filter(x => x.topicId == arrvResearchTopicObjLst[i].topicId);
                var strUserNum = arrRTUserRelaObjLst2.length;

                var streduClsName = clsPublocalStorage.eduClsName;

                var html_ApplyTopic = '<button title="申请加入" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnApplyTopic_Click("' + arrvResearchTopicObjLst[i].topicId + '","' + arrvResearchTopicObjLst[i].updUser + '");><i class="layui-icon">&#xe654;</i>申请加入</button>';

                strhtml += '<tr><td>' + strTopicName + '</td><td>' + html_TopicContent + '</td><td>' + strUserName + '</td><td>' + strUserNum + '</td><td>' + streduClsName + '</td><td>' + html_ApplyTopic + '</td></tr>';
            }
            //拼接；
            //$("#tbList").append(strhtml);
            $("#tbApplyTopicList").html(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }





    //申请加入主题
    public async btnApplyTopic_Click(topicId: string, updUser: string) {

        var strUserId = clsPublocalStorage.userId;
        var strRoleId = clsPublocalStorage.roleId;

        var objsys_RequestPushEN: clssys_RequestPushEN = new clssys_RequestPushEN();
        //this.PutDataTosys_RequestPushClass(objsys_RequestPushEN);
        objsys_RequestPushEN.SetTableKey(topicId);
        objsys_RequestPushEN.SetRequesTypeId("02");
        //objsys_RequestPushEN.SetParentId($("#hidParentId").val();
        //objsys_RequestPushEN.SetPubParentId($("#hidPubParentId").val();
        objsys_RequestPushEN.SetReceiveUser(updUser);//接收用户

        objsys_RequestPushEN.SetRequestUser(strUserId);//请求用户
        objsys_RequestPushEN.SetIsReply(false);//请求用户
        objsys_RequestPushEN.SetRequestStata("请求中");//请求用户
        objsys_RequestPushEN.SetRequestDate(clsPubFun4Web.getNowDate());//请求日期

        objsys_RequestPushEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);

        try {
            const responseText2 = await sys_RequestPush_AddNewRecordAsync(objsys_RequestPushEN);
            //const responseText2 = await sys_RequestPush_AddNewRecordWithMaxIdAsync(objsys_RequestPushEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `申请成功,请等待主题负责人通过申请才可加入!`;
                ////$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);
                Alert1(strInfo);
                ApplyTopic.requestStata = "1";
                const gvResult3 = await this.BindGv_sys_RequestPush();
                //CloseWindow();
            }
            else {
                var strInfo: string = `申请失败!`;
                //$('#lblResult40').val(strInfo);
                //显示信息框
                Alert1(strInfo);

            }

            //$("#J_PostBtn").attr("disabled", false);
            //$("#btnOKUpdAppraise").attr("disabled", false);
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            //$("#J_PostBtn").attr("disabled", false);
            //$("#btnOKUpdAppraise").attr("disabled", false);
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加评论不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！

    }







    /****************************************************答疑邀请相关 Start***************************************************/

    //请求
    public Combinesys_RequestPushCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //strWhereCond += " and id_CurrEduCls=" + clsPublocalStorage.id_CurrEduCls;
            strWhereCond += " and requesTypeId='02' and requestUser='" + clsPublocalStorage.userId + "' ";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //接收
    public Combinesys_RequestPushCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //strWhereCond += " and id_CurrEduCls=" + clsPublocalStorage.id_CurrEduCls;
            strWhereCond += " and requesTypeId='02' and receiveUser='" + clsPublocalStorage.userId + "' ";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //申请请求接收推送统计
    public async Bind_RequestPushCount() {
        try {
            var strWhereCond1 = this.Combinesys_RequestPushCondition1();
            strWhereCond1 += " and isReply=0";
            var strWhereCond2 = this.Combinesys_RequestPushCondition2();
            strWhereCond2 += " and isReply=0";
            var int_requestCount = await sys_RequestPush_GetRecCountByCondAsync(strWhereCond1);
            var int_noticeCount = await sys_RequestPush_GetRecCountByCondAsync(strWhereCond2);

            $("#requestCount").html(int_requestCount);
            $("#noticeCount").html(int_noticeCount);

            var int_RequestPushCount = int_requestCount + int_noticeCount;

            $("#RequestPushCount").html(int_RequestPushCount);
            $("#hidRequestPushCount").val(int_RequestPushCount);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //请求列表
    public async BindGv_sys_RequestPush() {
//    public async BindGv_sys_RequestPush(requestStata: string) {

        var strWhereCond = "";
        switch (ApplyTopic.requestStata) {
            case "1":
                strWhereCond += this.Combinesys_RequestPushCondition1();
                strWhereCond += " and isReply=0";
                break;
            case "2":
                strWhereCond += this.Combinesys_RequestPushCondition2();
                strWhereCond += " and isReply=0";
                break;
            case "3":
                strWhereCond += this.Combinesys_RequestPushCondition1();
                strWhereCond += " and isReply=1";
                break;
            case "4":
                strWhereCond += this.Combinesys_RequestPushCondition2();
                strWhereCond += " and isReply=1";
                break;
        }
        //if (requestStata == "1") {
        //    strWhereCond += this.Combinesys_RequestPushCondition1();
        //    strWhereCond += " and isReply=0";
        //} else {
        //    strWhereCond += this.Combinesys_RequestPushCondition2();
        //    strWhereCond += " and isReply=0";
        //}



        //strWhereCond += " order by requestDate Asc";



        //var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrsys_RequestPushObjLst: Array<clssys_RequestPushEN> = [];
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        var arrUsers: Array<clsvUsersSimEN> = [];

        try {

            const responseObjLst = await sys_RequestPush_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrsys_RequestPushObjLst = <Array<clssys_RequestPushEN>>jsonData;
            });

            if (arrsys_RequestPushObjLst.length > 0) {
                //通过主题id获取到对应的主题对象
                var arrTopicId = "";
                for (var i = 0; i < arrsys_RequestPushObjLst.length; i++) {
                    arrTopicId += arrsys_RequestPushObjLst[i].tableKey + ",";
                }
                arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);

                var strWhereCond2 = "topicId in(" + arrTopicId + ")";
                //声明主题变量
                const responseObjLst2 = await ResearchTopic_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                    arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;

                });
            }
            //获取用户缓存数据
            arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定推送数据不成功,${e}.`;
            alert(strMsg);
        }


        try {
            var strhtml = "";
            if (ApplyTopic.requestStata == "1") {
                //请求
                strhtml += '<div class="info" id="infoRequest">';
            } else {
                //通知
                strhtml += '<div class="info" id="infonotice">';
            }
            strhtml += '<ul class="artlist">';

            var k = 0;
            for (var i = 0; i < arrsys_RequestPushObjLst.length; i++) {
                k++;
                var objUser = arrUsers.find(x => x.userId == arrsys_RequestPushObjLst[i].requestUser);
                if (objUser != null) {
                    strhtml += '<li id="li' + arrsys_RequestPushObjLst[i].requestId + '">';
                    strhtml += '<div style="text-align:left; float:left; width:65%;">';
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">' + k + '、</span>';
                    var objResearchTopic = arrResearchTopicObjLst.find(x => x.topicId == arrsys_RequestPushObjLst[i].tableKey);
                    if (objResearchTopic != null) {
                        if (ApplyTopic.requestStata == "1") {
                            //请求
                            strhtml += '<span class="title btn-1"><a href="#"  class="abstract-text">' + objUser.userName + '申请参加"' + objResearchTopic.topicName + '"主题！</a></span>';
                        } else {
                            //通知
                            strhtml += '<span class="title btn-1"><a href="#"  class="abstract-text">' + objUser.userName + '申请参加"' + objResearchTopic.topicName + '"主题，您是否同意？</a></span>';
                        }
                    }
                    //}
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="badge badge-pill badge-success" title="' + arrsys_RequestPushObjLst[i].requestStata + '">' + arrsys_RequestPushObjLst[i].requestStata + '</span>';

                    if (ApplyTopic.requestStata == "2") {

                        //同意
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="同意" class="layui-btn layui-btn layui-btn-xs" onclick=btn_OK_Click(' + arrsys_RequestPushObjLst[i].requestId + ',"' + arrsys_RequestPushObjLst[i].tableKey + '","' + arrsys_RequestPushObjLst[i].requestUser + '")><i class="layui-icon">&#xe605;</i></button>';
                        //拒绝
                        strhtml += '&nbsp;<button title="拒绝" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btn_NO_Click(' + arrsys_RequestPushObjLst[i].requestId + ') href="javascript:;"><i class="layui-icon">&#x1006;</i></button>';

                    }
                    strhtml += '</div>';
                    //strhtml += '</li>';
                    //strhtml += '<li style="text-align:right;>';
                    strhtml += '<div style="text-align:right; float:right; width:34%;">';

                    strhtml += '<span class="rowtit color5"></span>' + objUser.userName + '<span class="rowtit color5">&nbsp;/&nbsp;</span>' + arrsys_RequestPushObjLst[i].requestDate;
                    //}
                    strhtml += '</div>';
                    strhtml += '</li>';

                }
            }
            strhtml += '</ul>';
            strhtml += '</div>';

            //if (requestStata == "1") {
            //    //请求
            //    $("#Request").html(strhtml);
            //    console.log("完成BindGv_request!");
            //} else {
            //    //通知
            //    $("#Notice").html(strhtml);
            //    console.log("完成BindGv_notice!");
            //}

            switch (ApplyTopic.requestStata) {
                case "1":
                    //请求
                    $("#Request").html(strhtml);
                    console.log("完成BindGv_request!");
                    break;
                case "2":
                    //通知
                    $("#Notice").html(strhtml);
                    console.log("完成BindGv_notice!");
                    break;
                case "3":
                    //历史请求
                    $("#history_Request").html(strhtml);
                    console.log("完成BindGv_history_Request!");
                    break;
                case "4":
                    //历史通知
                    $("#history_Notice").html(strhtml);
                    console.log("完成BindGv_history_Notice!");
                    break;
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定推送列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 同意
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async btn_OK_Click(requestId: number, strTopicId: string, strRequestUser: string) {
        const strThisFuncName = this.btn_OK_Click.name;
        var objsys_RequestPushEN: clssys_RequestPushEN = new clssys_RequestPushEN();
        objsys_RequestPushEN.SetRequestId(requestId);

        objsys_RequestPushEN.SetIsReply(true);
        objsys_RequestPushEN.SetReplyDate(clsPubFun4Web.getNowDate());
        objsys_RequestPushEN.SetRequestStata("同意");
        objsys_RequestPushEN.sfUpdFldSetStr = objsys_RequestPushEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objsys_RequestPushEN.requestId == 0 || objsys_RequestPushEN.requestId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await sys_RequestPush_UpdateRecordAsync(objsys_RequestPushEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //Alert1("当前申请已同意！");
                ////通知
                //const gvResult4 = await this.BindGv_sys_RequestPush("2");
                console.log("完成请求推送的修改!");
                //增加主题用户关系
                const responseText2 = await this.AddNewTopicAndRecordSaveUserRela(strTopicId, strRequestUser);
                var returnBool2: boolean = !!responseText2;
                if (returnBool2 == true) {
                    Alert1("当前申请已同意！");
                    //通知
                    ApplyTopic.requestStata = "2";
                    const gvResult4 = await this.BindGv_sys_RequestPush();
                }

            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    /* 添加主题同时把用户作为组长存放到主题用户关系表*/
    public async AddNewTopicAndRecordSaveUserRela(strTopicId: string, strRequestUser: string) {


        var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        objRTUserRelaEN.SetTopicId(strTopicId);
        objRTUserRelaEN.SetUserId(strRequestUser);
        objRTUserRelaEN.SetTopicUserRoleId("0003"); //主题成员
        objRTUserRelaEN.SetOrderNum(30);
        objRTUserRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objRTUserRelaEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户

        try {
            // 同一主题 同一用户 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strRequestUser + "'";
            const responseText = await RTUserRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个用户！`;
                //alert(strMsg);
                Alert2(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);
            var returnBool: boolean = !!responseText2;
            //if (returnBool == true) {
            //    console.log("完成主题用户关系!");

            //}
            if (returnBool == true) {
                console.log("完成主题用户关系!");

                const responseText3 = await this.btnReOrder_Click(strTopicId);

                //获取缓存色码表；
                var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
                //获取色码数据
                const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
                    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;
                });
                //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
                var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strRequestUser + "'";
                //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
                const responseText = await RTUserRela_GetFirstObjAsync(strWhereUserRela).then((jsonData) => {
                    var objRTUserRelaEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;

                    if (objRTUserRelaEN != null) {
                        //得到用户排序号
                        var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
                        if (Objgs_Color != null) {
                            //得到色码

                            var objUpdateRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
                            objUpdateRTUserRelaEN.SetmId(objRTUserRelaEN.mId);
                            objUpdateRTUserRelaEN.SetColorId(Objgs_Color.colorId);

                            objUpdateRTUserRelaEN.sfUpdFldSetStr = objUpdateRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)

                            const responseText = RTUserRela_UpdateRecordAsync(objUpdateRTUserRelaEN).then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    return true;
                                }
                                else {
                                    var strInfo: string = `修改用户色码不成功!`;
                                    alert(strInfo);
                                    console.log("修改用户色码不成功");
                                    return false;
                                }

                            });



                        }
                    }
                })
            }
            else {
                var strInfo: string = `添加主题用户关系不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
        }
        //return true;//一定要有一个返回值，否则会出错！
    }

    public async btnReOrder_Click(strTopicId: string) {
        //var strTopicId = clsPrivateSessionStorage.topicId;
        // if (this.PreCheck4Order() == false) return;
        //var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "topicId": strTopicId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await RTUserRela_ReOrderAsync(objOrderByData);
            //gs_PaperParagraph_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
    }

    /* 添加主题同时把用户作为组长存放到主题用户关系表*/
    //public async AddNewTopicAndRecordSaveUserRela() {
    //    var strTopicId = clsPrivateSessionStorage.topicId;
    //    var strUserId = clsPublocalStorage.userId;
    //    var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
    //    this.PutDataToRTUserRelaClassWhere(objRTUserRelaEN, strTopicId);
    //    //获取缓存色码表；
    //    var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
    //    try {
    //        // 同一主题 同一用户 只能添加一次；
    //        var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
    //        const responseText = await RTUserRela_IsExistRecordAsync(strWhere);
    //        var bolIsExist: boolean = responseText;
    //        if (bolIsExist == true) {
    //            var strMsg: string = `同一主题不能重复添加同一个用户！`;
    //            alert(strMsg);
    //            return responseText;//一定要有一个返回值，否则会出错！
    //        }

    //        const responseText2 = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);
    //        var returnBool: boolean = !!responseText2;
    //        if (returnBool == true) {
    //            var strInfo: string = `添加成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //隐藏用户框
    //            HideDialogFour();
    //            //显示信息框
    //            alert(strInfo);
    //            const responseText3 = await this.btnReOrder_Click();
    //            //获取色码数据
    //            const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
    //                arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

    //            });
    //            //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
    //            var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
    //            //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
    //            const responseText = await RTUserRela_GetFirstObjAsync(strWhereUserRela).then((jsonData) => {
    //                var objRTUserRelaEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;

    //                if (objRTUserRelaEN != null) {
    //                    //得到用户排序号
    //                    var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
    //                    if (Objgs_Color != null) {
    //                        //得到色码

    //                        var objUpdateRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
    //                        objUpdateRTUserRelaEN.SetmId(objRTUserRelaEN.mId;
    //                        objUpdateRTUserRelaEN.SetUserBgColor(Objgs_Color.colorCode;

    //                        objUpdateRTUserRelaEN.sfUpdFldSetStr = objUpdateRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)

    //                        const responseText = RTUserRela_UpdateRecordAsync(objUpdateRTUserRelaEN).then((jsonData) => {
    //                            var returnBool: boolean = jsonData;
    //                            if (returnBool == true) {
    //                                return true;
    //                            }
    //                            else {
    //                                var strInfo: string = `修改用户色码不成功!`;
    //                                alert(strInfo);
    //                                console.log("修改用户色码不成功");
    //                                return false;
    //                            }

    //                        });



    //                    }
    //                }
    //            })



    //            this.BindGv_vRTUserRela();
    //            ////主题Id
    //            //window.location.href = "../GraduateEdu/WApiRTUserRela_QUDI_TS?TopicRelaId='01'";
    //        }
    //        else {
    //            var strInfo: string = `添加不成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //显示信息框
    //            alert(strInfo);
    //        }
    //        return responseText2;//一定要有一个返回值，否则会出错！
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `添加记录不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //    return true;//一定要有一个返回值，否则会出错！
    //}


    /* 拒绝
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async btn_NO_Click(requestId: number) {
        const strThisFuncName = this.btn_NO_Click.name;

        var objsys_RequestPushEN: clssys_RequestPushEN = new clssys_RequestPushEN();
        objsys_RequestPushEN.SetRequestId(requestId);
        objsys_RequestPushEN.SetIsReply(true);
        objsys_RequestPushEN.SetReplyDate(clsPubFun4Web.getNowDate());
        objsys_RequestPushEN.SetRequestStata("拒绝");
        objsys_RequestPushEN.sfUpdFldSetStr = objsys_RequestPushEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objsys_RequestPushEN.requestId == 0 || objsys_RequestPushEN.requestId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await sys_RequestPush_UpdateRecordAsync(objsys_RequestPushEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                Alert1("当前申请已拒绝！");

                console.log("当前申请已拒绝!");
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `拒绝不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }




    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }

    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortBy(value: string) {
        $("#hidSortBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortBy(): string {
        return $("#hidSortBy").val();
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
    * 栏目主题
   */
    public get topicName_q(): string {
        return $("#txtTopicName_q").val();
    }

    /*
    * 主题提出人
   */
    public get TopicProposePeople_q(): string {
        return $("#txtTopicProposePeople_q").val();
    }

}
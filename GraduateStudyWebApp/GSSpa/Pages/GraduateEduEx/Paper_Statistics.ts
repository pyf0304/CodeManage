
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPaperEduClsRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsvSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js";
import { clsvSysVoteEN } from "../TS/L0_Entity/InteractManage/clsvSysVoteEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { vSysComment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js";
import { vSysVote_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsvSysVoteWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vPaperEx_GetUserNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { clsvPaperReadWriteWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperReadWriteWApiEx.js";
import { vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperSubViewpointExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialog3(): void;

declare function Canvas1(strJson): void;
declare function Canvas2(strJson): void;
declare function Canvas3(strJson): void;
//declare function tbody(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_Statistics {
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
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            if (strUserId != "") {
             
                $("#hidUserId").val(strUserId);
                $("#hidRoleId").val(strRoleId);

                //1、为下拉框设置数据源,绑定列表数据
                //const ddl_UserId_q = await this.BindDdl_UserId1("ddlUserId_q");
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);
               
                const gvResult = await this.BindGv_vPaperReadWrite_Statistics();
                //tbody();
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
    public async btnQuery_Click(strListDiv: string) {
        try {

            if ($("#hidQueryStata").val() == "1") {
                const gvResult = await this.BindGv_vPaperReadWrite_Statistics();
            } else if ($("#hidQueryStata").val() == "2") {
                const gvResult = await this.BindGv_vPaper_Statistics();
            } else {
                const gvResult = await this.BindGv_vPaperSubViewpoint_Statistics();
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    /* 论文读写统计
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async liPaperReadWriteStatistics_Click(strListDiv: string) {
        try {
            var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
            const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);
            //const ddl_UserId_q = await this.BindDdl_UserId1("ddlUserId_q");
            const gvResult = await this.BindGv_vPaperReadWrite_Statistics();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 论文统计
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async liPaperStatistics_Click(strListDiv: string) {
        try {
            var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
            const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);
            //const ddl_UserId_q = await this.BindDdl_UserId2("ddlUserId_q");
            const gvResult = await this.BindGv_vPaper_Statistics();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 论文子观点统计
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async liPaperSubViewpointStatistics_Click(strListDiv: string) {
        try {
            var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
            const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaperSubviewpoint_Cache("ddlUserId_q", objUsers_Cond);
           // const ddl_UserId_q = await this.BindDdl_UserId3("ddlUserId_q");
            const gvResult = await this.BindGv_vPaperSubViewpoint_Statistics();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    ////论文读写用户下拉框绑定
    //public async BindDdl_UserId1(ddlUserId: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvPaperReadWriteEN> = <Array<clsvPaperReadWriteEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperReadWriteEN.con_UpdUser, clsvPaperReadWriteEN.con_UserName, "读写用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

    ////论文下拉框绑定
    //public async BindDdl_UserId2(ddlUserId: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vPaperEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "论文用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

    ////论文下拉框绑定
    //public async BindDdl_UserId3(ddlUserId: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvPaperSubViewpointEN> = <Array<clsvPaperSubViewpointEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperSubViewpointEN.con_UpdUser, clsvPaperSubViewpointEN.con_UserName, "子观点用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

    public CombineCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        let strId_CurrEduCls = "";
        if ($("#txtid_CurrEduCls").val() == "") {
            strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        }
        else {
            strId_CurrEduCls = $("#txtid_CurrEduCls").val();
            if (clsString.IsNullOrEmpty(strId_CurrEduCls)) {
                strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            }
        }

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
            //管理员
            if ($("#hidRoleId").val() == "00620001") {

                if (this.UserId_q != "" && this.UserId_q != "0") {
                    strWhereCond += ` And ${clsPaperReadWriteEN.con_UpdUser} = '${this.UserId_q}'`;
                }
            }
            //教师
            else if ($("#hidRoleId").val() == "00620002") {
                $("#td_UserId").hide();
                strWhereCond += clsString.Format(" and {0}='{1}'", clsvPaperReadWriteEN.con_id_CurrEduCls, strId_CurrEduCls);

            }
            //学生
            else {
                $("#td_UserId").hide();
                strWhereCond += " and updUser='" + $("#hidUserId").val() + "'";

            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public CombineCondition_Paper(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        let strId_CurrEduCls = "";
        if ($("#txtid_CurrEduCls").val() == "") {
            strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        }
        else {
            strId_CurrEduCls = $("#txtid_CurrEduCls").val();
            if (clsString.IsNullOrEmpty(strId_CurrEduCls)) {
                strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            }
        }

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
            //管理员
            if ($("#hidRoleId").val() == "00620001") {

                if (this.UserId_q != "" && this.UserId_q != "0") {
                    strWhereCond += ` And ${clsPaperReadWriteEN.con_UpdUser} = '${this.UserId_q}'`;
                }
            }
            //教师
            else if ($("#hidRoleId").val() == "00620002") {
                $("#td_UserId").hide();
                strWhereCond += clsString.Format(" and {0} in (Select {0} From {1} Where {2}='{3}')",
                    clsvPaperEN.con_PaperId,
                    clsPaperEduClsRelaEN._CurrTabName, clsPaperEduClsRelaEN.con_id_CurrEduCls, strId_CurrEduCls);

            }
            //学生
            else {
                $("#td_UserId").hide();
                strWhereCond += " and updUser='" + $("#hidUserId").val() + "'";

            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

  

    //public CombineCondition3(): string {
    //    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
    //    //例如 1 = 1 && userName = '张三'
    //    var strWhereCond: string = " 1 = 1 ";
    //    //var strPaperTypeId = $("#hidPaperTypeId").val();
    //    //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
    //    try {
    //        if (this.StartDate_q != "") {
    //            strWhereCond += ` And ${clsvPaperSubViewpointEN.con_UpdDate} > '${this.StartDate_q}'`;
    //        }
    //        if (this.EndDate_q != "") {
    //            strWhereCond += ` And ${clsvPaperSubViewpointEN.con_UpdDate} < '${this.EndDate_q}'`;
    //        }

    //        if (this.UserId_q != "" && this.UserId_q != "0") {
    //            strWhereCond += ` And ${clsvPaperSubViewpointEN.con_UpdUser} = '${this.UserId_q}'`;
    //        }



    //    }
    //    catch (objException) {
    //        var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
    //        throw strMsg;
    //    }
    //    return strWhereCond;
    //}
   
    //绑定论文读写统计
    public async  BindGv_vPaperReadWrite_Statistics() {

        var strCon = this.CombineCondition1();
        var strWhereCond = strCon;
        var strWhereCond1 = strCon + "and operationTypeId='01'";
        var strWhereCond2 = strCon + "and operationTypeId='02'";

        //var strWhereCond3 = strCon + "and operationTypeId='01' and pcount > 5 ";
        //var strWhereCond4 = strCon + "and operationTypeId='02' and pcount > 5 ";
        var strWhereCond3 = strCon + "and operationTypeId='01' and subVCount > 5 "; //新0605
        var strWhereCond4 = strCon + "and operationTypeId='02' and subVCount > 5 ";//新0605
                //var arrvGroupPaperReadWriteObjLst: Array<clsvPaperReadWriteEN> = [];

        //var arrvGroupPaperReadWrite01ObjLst: Array<clsvPaperReadWriteEN> = [];

        //var arrvGroupPaperReadWrite02ObjLst: Array<clsvPaperReadWriteEN> = [];

        //var arrvGroupPaperReadWrite03ObjLst: Array<clsvPaperReadWriteEN> = [];

        //var arrvGroupPaperReadWrite04ObjLst: Array<clsvPaperReadWriteEN> = [];

        try {

            const arrvGroupPaperReadWriteObjLst = await clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond);

                console.log("1-0");

            const arrvGroupPaperReadWrite01ObjLst = await clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond1);
                 
                console.log("1-1");
            

            const arrvGroupPaperReadWrite02ObjLst = await clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond2);                 
            console.log("1-2");
            

            const arrvGroupPaperReadWrite03ObjLst = await clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond3);
                console.log("1-3");

            const arrvGroupPaperReadWrite04ObjLst = await clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond4);

            console.log("1-4");



            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            //const responseText5 = await this.BindList_Statistics(arrvGroupPaperReadWriteObjLst, arrvGroupPaperReadWrite01ObjLst, arrvGroupPaperReadWrite02ObjLst, arrvGroupPaperReadWrite03ObjLst, arrvGroupPaperReadWrite04ObjLst);

            //arrvGroupPaperReadWrite03ObjLst = arrvGroupPaperReadWrite01ObjLst.filter(x => x.pcount > 5);
            //arrvGroupPaperReadWrite04ObjLst = arrvGroupPaperReadWrite02ObjLst.filter(x => x.pcount > 5);


            var strhtml = "";
            var cateid: number = 0;
            //$('#tbList tr').remove();

            var strNum: string = "";
            var strNum1: number = 0;
            var strNum2: number = 0;
            var strNum3: number = 0;
            var strNum4: number = 0;
            var strUserName: string = "";
            var strcollegeName: string = "";
            var strmajorName: string = "";

            for (var i = 0; i < arrvGroupPaperReadWriteObjLst.length; i++) {


                var strUpdUser: string = arrvGroupPaperReadWriteObjLst[i].updUser;
                var objUser = arrUsers.find(x => x.userId == arrvGroupPaperReadWriteObjLst[i].updUser);
                if (objUser != null) {
                    strUserName = objUser.userName;
                    strcollegeName = objUser.collegeName;
                    strmajorName = objUser.majorName;
                }
               

                strNum = arrvGroupPaperReadWriteObjLst[i].memo;

                cateid++;


                var objPaperReadWrite01 = arrvGroupPaperReadWrite01ObjLst.find(x => x.updUser == strUpdUser);
                if (objPaperReadWrite01 != null) {
                    strNum1 = parseInt(objPaperReadWrite01.memo);
                }

                var objPaperReadWrite02 = arrvGroupPaperReadWrite02ObjLst.find(x => x.updUser == strUpdUser);
                if (objPaperReadWrite02 != null) {
                    strNum2 = parseInt(objPaperReadWrite02.memo);
                }

                var objPaperReadWrite03 = arrvGroupPaperReadWrite03ObjLst.find(x => x.updUser == strUpdUser);
                if (objPaperReadWrite03 != null) {
                    strNum3 = parseInt(objPaperReadWrite03.memo);
                }

                var objPaperReadWrite04 = arrvGroupPaperReadWrite04ObjLst.find(x => x.updUser == strUpdUser);
                if (objPaperReadWrite04 != null) {
                    strNum4 = parseInt(objPaperReadWrite04.memo);
                }

                strhtml += '<tr><td><input type="checkbox" name="" lay-skin="primary"></td><td>' + cateid + '</td><td>' + strUserName + '</td><td>' + strcollegeName + '</td><td>' + strmajorName + '</td><td>' + strNum + '</td><td>' + strNum1 + '</td><td>' + strNum2 + '</td><td>' + strNum3 + '</td><td>' + strNum4 + '</td></tr>';



            }
            //拼接；
            //$("#tbList").append(strhtml);
            $("#tbList1").html(strhtml);

            console.log(strNum);

            //不等于管理员
            if ($("#hidRoleId").val() != "00620001") {

                $("#div_Canvas1").show();
                var obj = '[' + strNum + ',' + strNum1 + ',' + strNum2 + ',' + strNum3 + ',' + strNum4 + ']';
                var strJson = eval(obj);
                Canvas1(strJson);

            } else {
                if (this.UserId_q != "" && this.UserId_q != "0") {
                    $("#div_Canvas1").show();
                    var obj = '[' + strNum + ',' + strNum1 + ',' + strNum2 + ',' + strNum3 + ',' + strNum4 + ']';
                    var strJson = eval(obj);
                    Canvas1(strJson);
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

    //绑定个性化论文列表
    //public async BindList_Statistics(arrvGroupPaperReadWriteObjLst: Array<clsvPaperReadWriteEN>, arrvGroupPaperReadWrite01ObjLst: Array<clsvPaperReadWriteEN>, arrvGroupPaperReadWrite02ObjLst: Array<clsvPaperReadWriteEN>, arrvGroupPaperReadWrite03ObjLst: Array<clsvPaperReadWriteEN>, arrvGroupPaperReadWrite04ObjLst: Array<clsvPaperReadWriteEN>) {
    //    try {
    //        var strhtml = "";
    //        var cateid: number = 0;
    //        //$('#tbList tr').remove();

    //        for (var i = 0; i < arrvGroupPaperReadWriteObjLst.length; i++) {


    //            var strUpdUser: string = arrvGroupPaperReadWriteObjLst[i].updUser;
    //            var strUserName: string = arrvGroupPaperReadWriteObjLst[i].userName;

    //            var strcollegeName: string = arrvGroupPaperReadWriteObjLst[i].collegeName;
    //            var strmajorName: string = arrvGroupPaperReadWriteObjLst[i].majorName;

    //            var strNum: string = arrvGroupPaperReadWriteObjLst[i].memo;

    //            var strNum1: number = 0;
    //            var strNum2: number = 0;
    //            var strNum3: number = 0;
    //            var strNum4: number = 0;
    //            cateid++;


    //            var objPaperReadWrite01 = arrvGroupPaperReadWrite01ObjLst.find(x => x.updUser == strUpdUser);
    //            if (objPaperReadWrite01 != null) {
    //                strNum1 = parseInt(objPaperReadWrite01.memo);
    //            }

    //            var objPaperReadWrite02 = arrvGroupPaperReadWrite02ObjLst.find(x => x.updUser == strUpdUser);
    //            if (objPaperReadWrite02 != null) {
    //                strNum2 = parseInt(objPaperReadWrite02.memo);
    //            }

    //            var objPaperReadWrite03 = arrvGroupPaperReadWrite03ObjLst.find(x => x.updUser == strUpdUser);
    //            if (objPaperReadWrite03 != null) {
    //                strNum3 = parseInt(objPaperReadWrite03.memo);
    //            }

    //            var objPaperReadWrite04 = arrvGroupPaperReadWrite04ObjLst.find(x => x.updUser == strUpdUser);
    //            if (objPaperReadWrite04 != null) {
    //                strNum4 = parseInt(objPaperReadWrite04.memo);
    //            }

    //            strhtml += '<tr><td><input type="checkbox" name="" lay-skin="primary"></td><td>' + cateid + '</td><td>' + strUserName + '</td><td>' + strcollegeName + '</td><td>' + strmajorName + '</td><td>' + strNum + '</td><td>' + strNum1 + '</td><td>' + strNum2 + '</td><td>' + strNum3 + '</td><td>' + strNum4 + '</td></tr>';



    //        }
    //        //拼接；
    //        //$("#tbList").append(strhtml);
    //        $("#tbList1").html(strhtml);

    //        console.log("5");
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
    //        alert(strMsg);
    //    }
    //}



    public CombineCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        let strId_CurrEduCls = "";
        if ($("#txtid_CurrEduCls").val() == "") {
            strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        }
        else {
            strId_CurrEduCls = $("#txtid_CurrEduCls").val();
            if (clsString.IsNullOrEmpty(strId_CurrEduCls)) {
                strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            }
        }
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsvSysVoteEN.con_UpdDate} > '${this.StartDate_q}'`;
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsvSysVoteEN.con_UpdDate} < '${this.EndDate_q}'`;
            }



            //管理员
            if ($("#hidRoleId").val() == "00620001") {

                if (this.UserId_q != "" && this.UserId_q != "0") {
                    strWhereCond += ` And ${clsvSysVoteEN.con_UpdUser} = '${this.UserId_q}'`;
                }
            }
            //教师
            else if ($("#hidRoleId").val() == "00620002") {

                $("#td_UserId").hide();
    
                strWhereCond += clsString.Format(" and {0}='{1}'", clsvPaperReadWriteEN.con_id_CurrEduCls, strId_CurrEduCls);

            }
            //学生
            else {
                $("#td_UserId").hide();
                strWhereCond += " and updUser='" + $("#hidUserId").val() + "'";

            }



        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
   // 绑定论文统计数据

    public async  BindGv_vPaper_Statistics() {

        var strCon_Paper = this.CombineCondition_Paper();
        var strCon2 = this.CombineCondition2();




        //var arrvPaperObjLst: Array<clsvPaperEN> = [];
        ////点赞
        //var arrvSysVoteObjLst: Array<clsvSysVoteEN> = [];
        ////评论
        //var arrvSysCommentObjLst: Array<clsvSysCommentEN> = [];



        try {


            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const arrvPaperObjLst = await vPaperEx_GetUserNumObjLstAsync(strCon_Paper);
                
                console.log("2-1");
            

            var strVote = strCon2 + " And voteTypeId ='01' ";//论文
            const arrvSysVoteObjLst = await vSysVote_GetObjLstAsync(strVote);
                           console.log("2-2");
            
            var strComment = strCon2 + " And commentTypeId ='01' ";//论文
            const arrvSysCommentObjLst = await vSysComment_GetObjLstAsync(strComment);
            console.log("2-3");



            var strhtml = "";
            var cateid: number = 0;

            var strNum;
            var strOkCount;
            var strAppraiseCount;
            var strNum1: number = 0;
            var strNum2: number = 0;
            //$('#tbList tr').remove();

            for (var i = 0; i < arrvPaperObjLst.length; i++) {

                var strUserName: string = "";
                var strUpdUser: string = arrvPaperObjLst[i].updUser;
                var objUser = arrUsers.find(x => x.userId == arrvPaperObjLst[i].updUser);
                if (objUser != null) {
                    strUserName = objUser.userName;
                }
                

                strNum = arrvPaperObjLst[i].memo;
                strOkCount = arrvPaperObjLst[i].okCount;
                strAppraiseCount = arrvPaperObjLst[i].appraiseCount;

                cateid++;

                //点赞
                var arrVoteObjLst: Array<clsvSysVoteEN> = [];
               
                arrVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == strUpdUser);
                if (arrVoteObjLst.length > 0) {
                    strNum1 = parseInt(arrVoteObjLst.length.toString());
                }
                else {
                    strNum1 = 0;
                }
                //if (objvPaperLikeLog != null) {
                //    strNum1 = parseInt(objvPaperLikeLog.memo);
                //}
                //评论
                var arrCommentObjLst: Array<clsvSysCommentEN> = [];

                arrCommentObjLst = arrvSysCommentObjLst.filter(x => x.updUser == strUpdUser);
                if (arrCommentObjLst.length > 0) {
                    strNum2 = parseInt(arrCommentObjLst.length.toString());
                }
                else {
                    strNum2 = 0;
                }
                strhtml += '<tr><td><input type="checkbox" name="" lay-skin="primary"></td><td>' + cateid + '</td><td>' + strUserName + '</td><td>' + strNum + '</td><td>' + strOkCount + '</td><td>' + strAppraiseCount + '</td><td>' + strNum1 + '</td><td>' + strNum2 + '</td></tr>';

            }
            //拼接；
            //$("#tbList").append(strhtml);
            $("#tbList2").html(strhtml);

            console.log("2-4");


            //不等于管理员
            if ($("#hidRoleId").val() != "00620001") {

                $("#div_Canvas2").show();
                var obj = '[' + strNum + ',' + strOkCount + ',' + strAppraiseCount + ',' + strNum1 + ',' + strNum2 + ']';
                var strJson = eval(obj);
                Canvas2(strJson);

            } else {
                if (this.UserId_q != "" && this.UserId_q != "0") {
                    $("#div_Canvas2").show();
                    var obj = '[' + strNum + ',' + strOkCount + ',' + strAppraiseCount + ',' + strNum1 + ',' + strNum2 + ']';
                    var strJson = eval(obj);
                    Canvas2(strJson);
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

    //绑定子观点统计数据
    public async  BindGv_vPaperSubViewpoint_Statistics() {

        var strCon1 = this.CombineCondition1();
        var strCon2 = this.CombineCondition2();

        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];

        //var arrvPaperSubViewpointLikeLogObjLst: Array<clsvPaperSubViewpointLikeLogEN> = [];

        //var arrvPaperSubViewpointAppraiseObjLst: Array<clsvPaperSubViewpointAppraiseEN> = [];

        //点赞
        var arrvSysVoteObjLst: Array<clsvSysVoteEN> = [];
        //评论
        var arrvSysCommentObjLst: Array<clsvSysCommentEN> = [];

        try {


            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const responseText1 = await vPaperSubViewpointEx_GetSubViewpointNumObjLstAsync(strCon1).then((jsonData) => {
                arrvPaperSubViewpointObjLst = <Array<clsvPaperSubViewpointEN>>jsonData;
                console.log("3-1");
            });

            //const responseText2 = await vPaperSubViewpointEx_GetSubViewpointLikeNumObjLstAsync(strCon1).then((jsonData) => {
            //    arrvPaperSubViewpointLikeLogObjLst = <Array<clsvPaperSubViewpointLikeLogEN>>jsonData;
            //    console.log("3-2");
            //});

            //const responseText3 = await vPaperSubViewpointEx_GetSubViewpointAppraiseNumObjLstAsync(strCon1).then((jsonData) => {
            //    arrvPaperSubViewpointAppraiseObjLst = <Array<clsvPaperSubViewpointAppraiseEN>>jsonData;
            //    console.log("3-3");
            //});
            var strVote = strCon2 + " And voteTypeId ='02' ";//论文
            const responseText2 = await vSysVote_GetObjLstAsync(strVote).then((jsonData) => {
                arrvSysVoteObjLst = <Array<clsvSysVoteEN>>jsonData;
                console.log("2-2");
            });
            var strComment = strCon2 + " And commentTypeId ='02' ";//论文
            const responseText3 = await vSysComment_GetObjLstAsync(strComment).then((jsonData) => {
                arrvSysCommentObjLst = <Array<clsvSysCommentEN>>jsonData;
                console.log("2-3");
            });

            var strhtml = "";
            var cateid: number = 0;

            var strNum;
            var strOkCount;
            var strAppraiseCount;
            var strNum1: number = 0;
            var strNum2: number = 0;
            var strUserName: string = "";
            //$('#tbList tr').remove();

            for (var i = 0; i < arrvPaperSubViewpointObjLst.length; i++) {

                
                var strUpdUser: string = arrvPaperSubViewpointObjLst[i].updUser;
                var objUser = arrUsers.find(x => x.userId == arrvPaperSubViewpointObjLst[i].updUser);
                if (objUser != null) {
                    strUserName = objUser.userName;
                }
                

                strNum = arrvPaperSubViewpointObjLst[i].memo;
                strOkCount = arrvPaperSubViewpointObjLst[i].okCount;
                strAppraiseCount = arrvPaperSubViewpointObjLst[i].appraiseCount;

                cateid++;
                //var objvPaperSubViewpointLikeLog = arrvPaperSubViewpointLikeLogObjLst.find(x => x.updUser == strUpdUser);
                //if (objvPaperSubViewpointLikeLog != null) {
                //    strNum1 = parseInt(objvPaperSubViewpointLikeLog.memo);
                //}

                //var objvPaperSubViewpointAppraise = arrvPaperSubViewpointAppraiseObjLst.find(x => x.updUser == strUpdUser);
                //if (objvPaperSubViewpointAppraise != null) {
                //    strNum2 = parseInt(objvPaperSubViewpointAppraise.meno);
                //}

                //点赞
                var arrVoteObjLst: Array<clsvSysVoteEN> = [];

                arrVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == strUpdUser);
                if (arrVoteObjLst.length > 0) {
                    strNum1 = parseInt(arrVoteObjLst.length.toString());
                }
                else {
                    strNum1 = 0;
                }
                //if (objvPaperLikeLog != null) {
                //    strNum1 = parseInt(objvPaperLikeLog.memo);
                //}
                //评论
                var arrCommentObjLst: Array<clsvSysCommentEN> = [];

                arrCommentObjLst = arrvSysCommentObjLst.filter(x => x.updUser == strUpdUser);
                if (arrCommentObjLst.length > 0) {
                    strNum2 = parseInt(arrCommentObjLst.length.toString());
                }
                else {
                    strNum2 = 0;
                }

                strhtml += '<tr><td><input type="checkbox" name="" lay-skin="primary"></td><td>' + cateid + '</td><td>' + strUserName + '</td><td>' + strNum + '</td><td>' + strOkCount + '</td><td>' + strAppraiseCount + '</td><td>' + strNum1 + '</td><td>' + strNum2 + '</td></tr>';



            }
            //拼接；
            //$("#tbList").append(strhtml);
            $("#tbList3").html(strhtml);

            console.log("3-4");


            //不等于管理员
            if ($("#hidRoleId").val() != "00620001") {

                $("#div_Canvas3").show();
                var obj = '[' + strNum + ',' + strOkCount + ',' + strAppraiseCount + ',' + strNum1 + ',' + strNum2 + ']';
                var strJson = eval(obj);
                Canvas3(strJson);
            } else {
                if (this.UserId_q != "" && this.UserId_q != "0") {
                    $("#div_Canvas3").show();
                    var obj = '[' + strNum + ',' + strOkCount + ',' + strAppraiseCount + ',' + strNum1 + ',' + strNum2 + ']';
                    var strJson = eval(obj);
                    Canvas3(strJson);
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
    public get UserId_q(): string {
        return $("#ddlUserId_q").val();
    }
    /*
    * 用户
   */
    public set UserId_q(value: string) {
        $("#ddlUserId_q").val(value);
    }
}
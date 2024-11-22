import { clsXzMajorEN } from "../L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsvCurrEduClsStuEN } from "../L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js";

import { clsvCurrEduClsTeacherEN } from "../L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js";
import { clsPaperEN } from "../L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../L0_Entity/GraduateEduPaper/clsPaperENEx.js";

import { clsvPaperReadWriteEN } from "../L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsvPaperSubViewpointEN } from "../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsgs_TotalDataTypeEN } from "../L0_Entity/GraduateEduTools/clsgs_TotalDataTypeEN.js";
import { clsResearchTopicEN } from "../L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsvConceptEN } from "../L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvTopicObjectiveEN } from "../L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsvUsersSimEN } from "../L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { vCurrEduClsStu_GetObjLstAsync, vCurrEduClsStu_GetObjLst_Cache } from "../L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js";

import { vCurrEduClsTeacher_GetObjLstAsync } from "../L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js";
import { vPaperReadWrite_GetObjLst_Cache } from "../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetObjLst_Cache } from "../L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { gs_TotalDataType_GetObjLstAsync } from "../L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js";
import { ResearchTopic_GetObjLst_Cache } from "../L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { vConcept_GetObjLst_Cache } from "../L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vTopicObjective_GetObjLst_Cache } from "../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vViewpoint_GetObjLst_Cache } from "../L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { PaperEx_GetObjLstById_CurrEduCls_Cache } from "../L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsSysPara4WebApi } from "../PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst, BindDdl_ObjLst_V } from "../PubFun/clsCommFunc4Web.js";

import { clsPublocalStorage } from "../PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../PubFun/clsPubSessionStorage.js";

export class clsDropDownList {


    ///// <summary>
    ///// 绑定基于论文缓存的用户下拉框
    ///// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    ///// </summary>
    ///// <param name = "objDDL">需要绑定当前表的下拉框</param>
    //public static async BindDdl_UsersInvPaperSim_Cache2(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
    //    var strid_Curreducls = clsPublocalStorage.id_CurrEduCls;
    //    var objDdl = document.getElementById(strDdlName);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${strDdlName} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    //为数据源于表的下拉框设置内容
    //    console.log("开始：BindDdl_UserId_Cache");
    //    var arrvPaper: Array<clsPaperEN> = await vPaper_GetObjLst_Cache(strid_Curreducls);
    //    var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvPaper.map(clsDropDownList.GetUsersBvPaper);
    //    arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
    //    console.log(arrObjLst_Sel);
    //    arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
    //    BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    //}

    //public static UserUniq(arr: Array<clsvUsersSimEN>): Array<clsvUsersSimEN> {
    //    let arrObjLst_New: Array<clsvUsersSimEN> = new Array<clsvUsersSimEN>();
    //    for (let x of arr) {
    //        if (clsDropDownList.UserIsExist(arrObjLst_New, x) == false) {
    //            arrObjLst_New.push(x);
    //        }
    //    }
    //    return arrObjLst_New;
    //}

    //public static UserIsExist(arr: Array<clsvUsersSimEN>, key: clsvUsersSimEN) {
    //    let arr_Sel = arr.filter(x => x.userId == key.userId);
    //    if (arr_Sel.length > 0) return true;
    //    return false;
    //}


    //public static GetUsersBvPaper(objvPaper: clsPaperEN): clsvUsersSimEN {
    //    var objUsers: clsvUsersSimEN = new clsvUsersSimEN();
    //    objUsers.userId = objvPaper.updUser;
    //    objUsers.userName = objvPaper.userName;
    //    return objUsers;
    //}




    /// <summary>
    /// 绑定基于论文缓存的专业下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_XzMajorInvPaper_Cache(strDdlName: string, objXzMajor_Cond: clsXzMajorEN, strCourseId: string) {
        var strid_Curreducls = clsPublocalStorage.id_CurrEduCls;
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_id_XzMajor_Cache");
        var arrvPaper = await PaperEx_GetObjExLstById_CurrEduCls(strid_Curreducls, strCourseId);
        //得到论文用户
        var arrUserId_Set: Set<string> = new Set(arrvPaper.map(x => x.updUser));
        console.log(arrUserId_Set);
        //得到论文数据缓存
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_id_XzMajor, clsvUsersSimEN.con_MajorName, "专业");

        //var arrObjLst_Sel: Array<clsXzMajorEN> = arrvPaper.map(clsDropDownList.GetXzMajorBvPaper);
        //arrObjLst_Sel = clsDropDownList.XzMajorUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsXzMajorEN.con_MajorName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
    }

    public static XzMajorUniq(arr: Array<clsXzMajorEN>): Array<clsXzMajorEN> {
        let arrObjLst_New: Array<clsXzMajorEN> = new Array<clsXzMajorEN>();
        for (let x of arr) {
            if (clsDropDownList.XzMajorIsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }

    public static XzMajorIsExist(arr: Array<clsXzMajorEN>, key: clsXzMajorEN) {
        let arr_Sel = arr.filter(x => x.id_XzMajor == key.id_XzMajor);
        if (arr_Sel.length > 0) return true;
        return false;
    }


    //public static GetXzMajorBvPaper(objvPaper: clsPaperEN): clsXzMajorEN {
    //    var objXzMajor: clsXzMajorEN = new clsXzMajorEN();
    //    objXzMajor.id_XzMajor = objvPaper.id_XzMajor;
    //    objXzMajor.majorName = objvPaper.majorName;
    //    return objXzMajor;
    //}





    /// <summary>
    /// 绑定基于论文读写缓存的用户下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UsersInvPaperReadWrite_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var strid_Curreducls = clsPublocalStorage.id_CurrEduCls;
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserId_Cache");
        var arrvPaperReadWrite: Array<clsvPaperReadWriteEN> = await vPaperReadWrite_GetObjLst_Cache(strid_Curreducls);

        var arrUserId_Set: Set<string> = new Set(arrvPaperReadWrite.map(x => x.updUser));
        console.log(arrUserId_Set);


        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "用户");

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvPaperReadWrite.map(clsDropDownList.GetUsersBvPaperReadWrite);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }

    //public static UserUniq(arr: Array<clsvUsersSimEN>): Array<clsvUsersSimEN> {
    //    let arrObjLst_New: Array<clsvUsersSimEN> = new Array<clsvUsersSimEN>();
    //    for (let x of arr) {
    //        if (clsDropDownList.UserIsExist(arrObjLst_New, x) == false) {
    //            arrObjLst_New.push(x);
    //        }
    //    }
    //    return arrObjLst_New;
    //}

    //public static UserIsExist(arr: Array<clsvUsersSimEN>, key: clsvUsersSimEN) {
    //    let arr_Sel = arr.filter(x => x.userId == key.userId);
    //    if (arr_Sel.length > 0) return true;
    //    return false;
    //}


    public static GetUsersBvPaperReadWrite(objvPaperReadWrite: clsvPaperReadWriteEN): clsvUsersSimEN {
        var objUsers: clsvUsersSimEN = new clsvUsersSimEN();
        objUsers.userId = objvPaperReadWrite.updUser;
        //objUsers.userName = objvPaperReadWrite.userName;
        return objUsers;
    }


    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UsersInvPaperSubviewpoint_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var strid_Curreducls = clsPublocalStorage.id_CurrEduCls;
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserId_Cache");
        var arrUser: Array<clsvPaperSubViewpointEN> = await vPaperSubViewpoint_GetObjLst_Cache(strid_Curreducls);

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvPaper.map(clsDropDownList.GetUsersBvPaper);

        //var arrUserId_Sel: Array<string> = arrUser.map(x => x.userId);
        //var arrUserId_Set: Set<string> = new Set(arrUserId_Sel);
        var arrUserId_Set: Set<string> = new Set(arrUser.map(x => x.updUser));
        console.log(arrUserId_Set);


        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "用户");


        //var arrUsersList_Sel: Array<clsPaperEN> = arrUser.filter(x => arrUserId_Set.has(x.updUser));

        //console.log(arrUsersList_Sel);
        //arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsPaperEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrUsersList_Sel, clsPaperEN.con_UpdUser, clsPaperEN.con_UserName, "用户");

    }

    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UsersInvPaper_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var strid_Curreducls = clsPublocalStorage.id_CurrEduCls;
        const strCourseId = clsPublocalStorage.courseId;
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserId_Cache");
        var arrPaper = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_Curreducls);

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvPaper.map(clsDropDownList.GetUsersBvPaper);

        //var arrUserId_Sel: Array<string> = arrUser.map(x => x.userId);
        //var arrUserId_Set: Set<string> = new Set(arrUserId_Sel);
        var arrUserId_Set: Set<string> = new Set(arrPaper.map(x => x.updUser));
        console.log(arrUserId_Set);


        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "用户");


        //var arrUsersList_Sel: Array<clsPaperEN> = arrUser.filter(x => arrUserId_Set.has(x.updUser));

        //console.log(arrUsersList_Sel);
        //arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsPaperEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrUsersList_Sel, clsPaperEN.con_UpdUser, clsPaperEN.con_UserName, "用户");

    }
    //public static unique(arr: Array<string>): Array<string> {
    //    let arr_New: Array<string> = Array.from(new Set(arr));
    //    return arr_New;
    //}



    //从观点表表中得到专家观点用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UserIdInvExpertviewpoint_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvViewpointList: Array<clsvViewpointEN> = await vViewpoint_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls);

        //获取个人观点数据；

        var arrvViewpoint: Array<clsvViewpointEN> = new Array<clsvViewpointEN>();
        arrvViewpoint = arrvViewpointList.filter(x => x.userTypeId == "02");//专家观点；

        var arrUserId_Set: Set<string> = new Set(arrvViewpoint.map(x => x.updUser));
        console.log(arrUserId_Set);

        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLstAsync("1=1");
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");




        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvViewpoint.map(clsDropDownList.GetUsersByvViewpoint);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }


    //public static GetUsersByvViewpoint(objvViewpoint: clsvViewpointEN): clsvUsersSimEN {
    //    var objUsers: clsvUsersSimEN = new clsvUsersSimEN();
    //    objUsers.userId = objvViewpoint.updUser;
    //    objUsers.userName = objvViewpoint.userName;
    //    return objUsers;
    //}


    //从观点表表中得到用户数据 通过参数判断个人、或专家；
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_ViewpointUserIdByPara_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN,strUserType:string) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvViewpointList: Array<clsvViewpointEN> = await vViewpoint_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls);

        //获取个人观点数据；

        var arrvViewpoint: Array<clsvViewpointEN> = new Array<clsvViewpointEN>();
        arrvViewpoint = arrvViewpointList.filter(x => x.userTypeId == strUserType);//01或02

        var arrUserId_Set: Set<string> = new Set(arrvViewpoint.map(x => x.updUser));
        console.log(arrUserId_Set);

        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLstAsync("1=1");
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvViewpoint.map(clsDropDownList.GetUsersByvViewpoint);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }

    //从观点表表中得到个人观点用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UserIdInvViewpoint_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvViewpointList: Array<clsvViewpointEN> = await vViewpoint_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls);

        //获取个人观点数据；

        var arrvViewpoint: Array<clsvViewpointEN> = new Array<clsvViewpointEN>();
        arrvViewpoint = arrvViewpointList.filter(x => x.userTypeId == "01");//个人观点；

        var arrUserId_Set: Set<string> = new Set(arrvViewpoint.map(x => x.updUser));
        console.log(arrUserId_Set);

        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLstAsync("1=1");
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvViewpoint.map(clsDropDownList.GetUsersByvViewpoint);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }
    

    //从概念表中得到用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UserIdInvConcept_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvConcept: Array<clsvConceptEN> = await vConcept_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls);
       
        var arrUserId_Set: Set<string> = new Set(arrvConcept.map(x => x.updUser));
        console.log(arrUserId_Set);

        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
       // var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLstAsync("1=1");
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvConcept.map(clsDropDownList.GetUsersByvConcept);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }
    public static GetUsersByvConcept(objvConcept: clsvConceptEN): clsvUsersSimEN {
        var objUsers: clsvUsersSimEN = new clsvUsersSimEN();
        objUsers.userId = objvConcept.updUser;
        var strUserName: string = "";
        //var userName = this.GetUserNameByUserId(objvConcept.updUser).then((jsonData) => {
        //     strUserName = <string>jsonData;
          
        //});
        objUsers.userName = strUserName;
        return objUsers;
    }
   
    ////通过ID得到名称
    //public static async GetUserNameByUserId(strUserId: string) {
    //    var strUserName: string = "";
    //    var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
    //    var objUser = arrUsers.find(x => x.userId == strUserId);
    //    if (objUser != null) {
    //        strUserName = objUser.userName;
    //    }
    //    return strUserName;

    //}

    //从客观事实表中得到用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UserIdInvTopicObjectiveFact_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvObjlist: Array<clsvTopicObjectiveEN> = await vTopicObjective_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls);


        //获取客观事实
        var arrvclsvTopicObjectiveEN: Array<clsvTopicObjectiveEN> = new Array<clsvTopicObjectiveEN>();
        arrvclsvTopicObjectiveEN = arrvObjlist.filter(x => x.objectiveType == "01");//客观事实；


        var arrUserId_Set: Set<string> = new Set(arrvclsvTopicObjectiveEN.map(x => x.updUser));
        console.log(arrUserId_Set);

        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvclsvTopicObjectiveEN.map(clsDropDownList.GetUsersByvTopicObjective);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }

    //public static GetUsersByvTopicObjective(objvTopicObjective: clsvTopicObjectiveEN): clsvUsersSimEN {
    //    var objUsers: clsvUsersSimEN = new clsvUsersSimEN();
    //    objUsers.userId = objvTopicObjective.updUser;
    //    objUsers.userName = objvTopicObjective.userName;
    //    return objUsers;
    //}
    //从客观数据表中得到用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public static async BindDdl_UserIdInvTopicObjectiveBasis_Cache(strDdlName: string, objUsers_Cond: clsvUsersSimEN) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvObjList: Array<clsvTopicObjectiveEN> = await vTopicObjective_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls);

        //获取客观数据
        var arrvclsvTopicObjectiveEN: Array<clsvTopicObjectiveEN> = new Array<clsvTopicObjectiveEN>();
        arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02");//客观数据；

        var arrUserId_Set: Set<string> = new Set(arrvclsvTopicObjectiveEN.map(x => x.updUser));
        console.log(arrUserId_Set);

        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);

        BindDdl_ObjLst_V(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");

        //var arrObjLst_Sel: Array<clsvUsersSimEN> = arrvclsvTopicObjectiveEN.map(clsDropDownList.GetUsersByvTopicObjective);
        //arrObjLst_Sel = clsDropDownList.UserUniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    }



    //教学班学生关系
    public static async BindDdl_CurrEduClsStuUser(ddlUserId_q: string) {
        //var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "' order by stuName Asc";
        var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        var objDdl = document.getElementById(ddlUserId_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlUserId_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {
            var arrObjLst_Sel: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
            //var arrObjLst_Sel: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvCurrEduClsStuEN.con_StuID]);
            BindDdl_ObjLst_V(ddlUserId_q, arrObjLst_Sel, clsvCurrEduClsStuEN.con_StuID, clsvCurrEduClsStuEN.con_StuName, "教学班学生");
            console.log("完成BindDdl_vCurrEduClsStuId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //教学班主题
    public static async BindDdl_TopicId(ddlTopicId_q: string) {
        //var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "' order by topicName Asc";
        var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        var objDdl = document.getElementById(ddlTopicId_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlTopicId_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {
            var arrObjLst_Sel: Array<clsResearchTopicEN> = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
            //var arrObjLst_Sel: Array<clsResearchTopicEN> = await ResearchTopic_GetObjLstAsync(strWhereCond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsResearchTopicEN.con_TopicId]);
            BindDdl_ObjLst(ddlTopicId_q, arrObjLst_Sel, clsResearchTopicEN.con_TopicId, clsResearchTopicEN.con_TopicName, "教学班主题");
            console.log("完成BindDdl_ResearchTopicId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //总表类型数据
    public static async BindDdl_TotalTypeId(ddlTotalType_q: string) {
        var strWhereCond = " totalDataTypeId !='02'";
        var objDdl = document.getElementById(ddlTotalType_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlTotalType_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {

            var arrObjLst_Sel: Array<clsgs_TotalDataTypeEN> = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsgs_TotalDataTypeEN.con_TotalDataTypeId]);
            BindDdl_ObjLst(ddlTotalType_q, arrObjLst_Sel, clsgs_TotalDataTypeEN.con_TotalDataTypeId, clsgs_TotalDataTypeEN.con_TotalDataTypeName, "问题回答");
            console.log("完成BindDdl_ResearchTopicId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

  

    //教学班学生关系
    public static async BindDdl_CurrEduClsStu(ddlCurrEduCls_q: string) {
        var strWhereCond = " stuID='" + clsPublocalStorage.userId + "' order by modifyDate Desc";
        var objDdl = document.getElementById(ddlCurrEduCls_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlCurrEduCls_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {

            var arrObjLst_Sel: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvCurrEduClsStuEN.con_id_CurrEduCls]);
            BindDdl_ObjLst_V(ddlCurrEduCls_q, arrObjLst_Sel, clsvCurrEduClsStuEN.con_id_CurrEduCls, clsvCurrEduClsStuEN.con_EduClsName, "其他教学班");
            console.log("完成BindDdl_vCurrEduClsStuId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //教学班教师关系
    public static async BindDdl_CurrEduClsTea(ddlCurrEduCls_q: string) {
        var strWhereCond = " teacherID='" + clsPublocalStorage.userId + "' order by updDate Desc";
        var objDdl = document.getElementById(ddlCurrEduCls_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlCurrEduCls_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {

            var arrObjLst_Sel: Array<clsvCurrEduClsTeacherEN> = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvCurrEduClsTeacherEN.con_id_CurrEduCls]);
            BindDdl_ObjLst_V(ddlCurrEduCls_q, arrObjLst_Sel, clsvCurrEduClsTeacherEN.con_id_CurrEduCls, clsvCurrEduClsTeacherEN.con_EduClsName, "其他教学班");
            console.log("完成BindDdl_vCurrEduClsTeacherId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

}

function PaperEx_GetObjExLstById_CurrEduCls(strid_Curreducls: string, strCourseId: string): clsPaperEN[] | PromiseLike<clsPaperEN[]> {
    throw new Error("Function not implemented.");
}

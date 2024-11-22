0
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCurrEduClsWApi
表名:CurrEduCls(01120123)
生成代码版本:2020.04.24.1
生成日期:2020/04/25 17:22:23
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// 当前教学班(CurrEduCls)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2020年04月25日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import { tzResponseData } from "./tzResponseData";
//import * as QQ from "q";
var ResponseData: tzResponseData;
export class clsPubSessionStorage {


    ////////////////////////////////////////////////////////////教学班Id/////////////////////////////////////////////////////////////
    ////获取教学班Id
    //public static GetSession_id_CurrEduCls(): string {

    //    var strKey: string = "id_CurrEduCls";
    //    var strid_CurrEduCls: string = "";
    //    if (sessionStorage.hasOwnProperty(strKey)) {
    //        //缓存存在，直接返回
    //        strid_CurrEduCls = sessionStorage.getItem(strKey) as string;

    //    }
    //    else {
    //        console.log("缓存id_CurrEduCls为空！");
    //    }
    //    return strid_CurrEduCls;
    //}

    ////设置教学班Id
    //public static SetSession_id_CurrEduCls(strid_CurrEduCls: string) {
    //    try {
    //        //清空本类缓存
    //        var strKey: string = "id_CurrEduCls";
    //        sessionStorage.removeItem(strKey);
    //        //把值存入session
    //        sessionStorage.setItem(strKey, strid_CurrEduCls);
    //    }
    //    catch (e) {
    //        console.error(e);
    //        var strMsg: string = `存入缓存出错,${e}.`;
    //        throw (strMsg);
    //    }
    //}

    //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetSession_UserId(): string {

        var strKey: string = "userId";
        var strUserId: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strUserId = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存userId为空！");
        }
        return strUserId;
    }
    //设置用户Id
    public static SetSession_UserId(strUserId: string) {
        try {
            //清空本类缓存
            var strKey: string = "userId";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strUserId);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////用户名称/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetSession_UserName(): string {

        var strKey: string = "userName";
        var strUserName: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strUserName = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存userName为空！");
        }
        return strUserName;
    }

    //设置用户Id
    public static SetSession_UserName(strUserName: string) {
        try {
            //清空本类缓存
            var strKey: string = "userName";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strUserName);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////角色Id/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetSession_RoleId(): string {

        var strKey: string = "roleId";
        var strRoleId: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strRoleId = sessionStorage.getItem(strKey) as string;
        }
        else {
            console.log("缓存roleId为空！");
        }
        return strRoleId;
    }

    //设置用户Id
    public static SetSession_RoleId(strRoleId: string) {
        try {
            //清空本类缓存
            var strKey: string = "roleId";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strRoleId);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////角色名称/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetSession_RoleName(): string {

        var strKey: string = "roleName";
        var strRoleName: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strRoleName = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存roleName为空！");
        }
        return strRoleName;
    }

    //设置用户Id
    public static SetSession_RoleName(strRoleName: string) {
        try {
            //清空本类缓存
            var strKey: string = "roleName";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strRoleName);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////专业ID/////////////////////////////////////////////////////////////
    //专业ID
    public static GetSession_id_XzMajor(): string {

        var strKey: string = "id_XzMajor";
        var strid_XzMajor: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strid_XzMajor = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存id_XzMajor为空！");
        }
        return strid_XzMajor;
    }

    //设置用户Id
    public static SetSession_id_XzMajor(strid_XzMajor: string) {
        try {
            //清空本类缓存
            var strKey: string = "id_XzMajor";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strid_XzMajor);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }

    //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetSession_majorName(): string {

        var strKey: string = "majorName";
        var strmajorName: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strmajorName = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存majorName为空！");
        }
        return strmajorName;
    }

    //设置用户Id
    public static SetSession_majorName(strmajorName: string) {
        try {
            //清空本类缓存
            var strKey: string = "majorName";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strmajorName);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////用户List/////////////////////////////////////////////////////////////
    //获取用户Lst
    public static GetUserLst(): string {

        var strKey: string = "UserLst";
        var strUserId: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strUserId = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存用户Lst为空！");
        }
        return strUserId;
    }
    //设置用户Lst
    public static SetUserLst(strUserLst: string) {
        try {
            //清空本类缓存
            var strKey: string = "UserLst";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strUserLst);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }

    //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
    //获取用户ID
    public static get userId(): string {

        var strKey: string = "userId";
        var strUserId: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strUserId = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.error("缓存userId为空！");
        }
        return strUserId;
    }
    //设置用户Id
    public static set userId(strUserId: string) {
        try {
            //清空本类缓存
            var strKey: string = "userId";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strUserId);
        }
        catch (e) {

            var strMsg: string = `存入缓存出错,${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }

};
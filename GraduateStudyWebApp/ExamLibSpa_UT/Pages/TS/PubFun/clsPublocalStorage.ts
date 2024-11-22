
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
import * as $ from "jquery";
//import { clsCurrEduClsWApi } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsWApi";
import { tzResponseData } from "./tzResponseData";
//import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN";
//import * as QQ from "q";


var ResponseData: tzResponseData;
export class clsPublocalStorage {

   

    ////获取教学班对象
    //public static async GetCurrEduClsObjLst() {
      
    //    //初始化列表缓存
    //    var strWhereCond: string = "1=1";
    //    clsCurrEduClsWApi.InitListCache();
    //    var strKey: string = clsCurrEduClsEN._CurrTabName;
    //    if (strKey == "") {
    //        console.log("关键字为空！不正确");
    //        throw new Error("关键字为空！不正确");
    //    }
    //    if (localStorage.hasOwnProperty(strKey)) {
    //        //缓存存在，直接返回
    //        var strTempObjLst: string = localStorage.getItem(strKey) as string;
    //        var arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
    //        return arrCurrEduClsObjLst_Cache;
    //    }
       
    //}

    //public static async SetCurrEduClsObjLstObjLst(strid_CurrEduClass: string) {
    //    //清空本类缓存
    //    const responseText0 = await clsCurrEduClsWApi.ReFreshThisCache();
    //    //初始化列表缓存
    //    var strWhereCond: string = "1=1 and id_CurrEduClass='" + strid_CurrEduClass+"'";
    //    clsCurrEduClsWApi.InitListCache();
    //    var strKey: string = clsCurrEduClsEN._CurrTabName;
    //    if (strKey == "") {
    //        console.log("关键字为空！不正确");
    //        throw new Error("关键字为空！不正确");
    //    }
    //    try {
    //        //把当前教学班存入缓存内
    //        const responseText = await clsCurrEduClsWApi.GetObjLstAsync(strWhereCond);
    //        var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = <Array<clsCurrEduClsEN>>responseText;
    //        localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsObjLst));
    //        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrCurrEduClsObjLst.length}!`;
    //        console.log(strInfo);
    //        return arrCurrEduClsObjLst;
    //    }
    //    catch (e) {
    //        console.log("GetObjLst_Cache:e");
    //        console.log(e);
    //        var strMsg: string = `从缓存中获取所有对象列表出错,${e}.`;
    //        throw (strMsg);
    //    }
    //}

    //////////////////////////////////////////////////////////教学班Id/////////////////////////////////////////////////////////////
    //获取教学班Id
    public static Getid_CurrEduClass(): string {

        var strKey: string = "id_CurrEduClass";
        var strid_CurrEduClass: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strid_CurrEduClass = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存id_CurrEduClass为空！");
        }
        return strid_CurrEduClass;
    }

    //设置教学班Id
    public static Setid_CurrEduClass(strid_CurrEduClass: string) {
        try {
            //清空本类缓存
            var strKey: string = "id_CurrEduClass";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strid_CurrEduClass);
        }
        catch (e) {
            console.log(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////教学班类型Id/////////////////////////////////////////////////////////////
    //获取教学班Id
    public static get EduClassTypeID(): string {

        var strKey: string = "EduClassTypeID";
        var strEduClassTypeID: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strEduClassTypeID = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存strEduClassTypeID为空！");
        }
        return strEduClassTypeID;
    }

    //设置教学班Id
    public static set EduClassTypeID(strEduClassTypeID: string) {
        try {
            //清空本类缓存
            var strKey: string = "EduClassTypeID";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strEduClassTypeID);
        }
        catch (e) {
            console.log(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }
    //////////////////////////////////////////////////////////教学班/////////////////////////////////////////////////////////////
    //获取教学班名称
    public static GetEduClassName(): string {

        var strKey: string = "EduClassName";
        var strid_CurrEduClass: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strid_CurrEduClass = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存EduClassName为空！");
        }
        return strid_CurrEduClass;
    }

    //设置教学班名称
    public static SetEduClassName(strEduClassName: string) {
        try {
            //清空本类缓存
            var strKey: string = "EduClassName";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strEduClassName);
        }
        catch (e) {
            console.log(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }
    //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetUserId(): string {

        var strKey: string = "UserId";
        var strUserId: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strUserId = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存UserId为空！");
        }
        return strUserId;
    }
    //设置用户Id
    public static SetUserId(strUserId: string) {
        try {
            //清空本类缓存
            var strKey: string = "UserId";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strUserId);
        }
        catch (e) {
            console.log(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }



     //////////////////////////////////////////////////////////主题用户关系列表/////////////////////////////////////////////////////////////
    //获取主题用户关系
    public static get TopicUserList(): string {

        var strKey: string = "TopicUserList";
        var strTopicUserList: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strTopicUserList = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存strEduClassTypeID为空！");
        }
        return strTopicUserList;
    }

    //设置主题用户关系
    public static set TopicUserList(strTopicUserList: string) {
        try {
            //清空本类缓存
            var strKey: string = "TopicUserList";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strTopicUserList);
        }
        catch (e) {
            console.log(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }
 
};
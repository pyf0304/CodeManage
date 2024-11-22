
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApigs_PaperGroup_UT_TS
表名:gs_PaperGroup(01120749)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 23:16:54
生成者:pyf2
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_界面UT后台_TS(WA_ViewUTScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsgs_PaperGroupWApi, clsgs_PaperGroupBL } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web.js";
import { stuTopPara } from "../TS/PubFun/stuTopPara.js";
import { stuRangePara } from "../TS/PubFun/stuRangePara.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { CacheHelper } from "../TS/PubFun/CacheHelper.js";
import { clsFldComparisonObj } from "../TS/PubFun/clsFldComparisonObj.js";
declare var $;
/// <summary>
/// WApigs_PaperGroup_UT_TS 的摘要说明。其中Q代表查询,U代表修改
/// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:GeneCode)
/// </summary>
export class WApigs_PaperGroup_UT_TS {


    /// <summary>
    /// 检查相应关键字的记录是否存在
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExist)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    public static async btnIsExist_Click() {
        $('#hidDivName').val("divIsExist");
        var strKeyId: string = $('#txtstrKeyId1').val();
        var strPaperGroupId: string = strKeyId;
        try {
            const responseText = await clsgs_PaperGroupWApi.IsExistAsync(strPaperGroupId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strKeyId}] 的记录不存在!`;
                $('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `关键字:[${strKeyId}]的相关记录存在!`;
                $('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 检查相应关键字的记录是否存在
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExist_Cache)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    public static async btnIsExist_Cache_Click() {
        $('#hidDivName').val("divIsExist_Cache");
        var strKeyId: string = $('#txtstrKeyId2').val();
        var strPaperGroupId: string = strKeyId;
        try {
            const responseText = await clsgs_PaperGroupWApi.IsExist_Cache(strPaperGroupId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strKeyId}] 的记录不存在!`;
                $('#lblResult2').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `关键字:[${strKeyId}]的相关记录存在!`;
                $('#lblResult2').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 检查相应关键字的记录是否存在
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExistRecord)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    public static async btnIsExistRecord_Click() {
        $('#hidDivName').val("divIsExistRecord");
        var strWhereCond: string = $('#txtstrWhereCond3').val();
        try {
            const responseText = await clsgs_PaperGroupWApi.IsExistRecordAsync(strWhereCond);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                strWhereCond = $('#txtstrWhereCond3').val();
                var strInfo: string = `根据条件:[${strWhereCond}] 的记录不存在!`;
                $('#lblResult3').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                strWhereCond = $('#txtstrWhereCond3').val();
                var strInfo: string = `根据条件:[${strWhereCond}]的相关记录存在!`;
                $('#lblResult3').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `检查条件的记录存在不成功, ${(e)}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 检查相应关键字的记录是否存在
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExistRecord_Cache)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    public static async btnIsExistRecord_Cache_Click() {
        $('#hidDivName').val("divIsExistRecord_Cache");
        var objTabName_Cond: Object = $('#txtobjTabName_Cond4').val();
        var objgs_PaperGroup_Cond: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        var arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
        console.log(`字段比较对象记录数(本地获取)：${arrFldComparisonObj.length}`);
        arrFldComparisonObj.forEach(x => { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
        var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
        console.log(objgs_PaperGroupEN_Sim);
        try {
            const responseText = await clsgs_PaperGroupWApi.IsExistRecord_Cache(objgs_PaperGroup_Cond);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperGroup_Cond)}]的记录不存在!`;
                $('#lblResult4').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperGroup_Cond)}]的相关记录存在!`;
                $('#lblResult4').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `检查条件的记录存在不成功, ${(e)}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 获取某一条件的记录数
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetRecCountByCond)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    public static async btnGetRecCountByCond_Click() {
        $('#hidDivName').val("divGetRecCountByCond");
        var strWhereCond: string = $('#txtstrWhereCond5').val();
        try {
            const responseText = await clsgs_PaperGroupWApi.GetRecCountByCondAsync(strWhereCond);
            var returnInt: number = Number(responseText);
            strWhereCond = $('#txtstrWhereCond5').val();
            var strInfo: string = `根据条件:${strWhereCond}的记录数:${returnInt}!`;
            $('#lblResult5').val(strInfo);
            //显示信息框
            alert(strInfo);
        }
        catch (e) {
            var strMsg: string = `获取某一条件的记录数不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 获取某一条件的记录数
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetRecCountByCond_Cache)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    public static async btnGetRecCountByCond_Cache_Click() {
        $('#hidDivName').val("divGetRecCountByCond_Cache");
        var objTabName_Cond: Object = $('#txtobjTabName_Cond6').val();
        var objgs_PaperGroup_Cond: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        var arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
        console.log(`字段比较对象记录数(本地获取)：${arrFldComparisonObj.length}`);
        arrFldComparisonObj.forEach(x => { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
        var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
        console.log(objgs_PaperGroupEN_Sim);
        try {
            const responseText = await clsgs_PaperGroupWApi.GetRecCountByCond_Cache(objgs_PaperGroup_Cond);
            var returnInt: number = Number(responseText);
            var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperGroup_Cond)}]的记录数:${returnInt}!`;
            $('#lblResult6').val(strInfo);
            //显示信息框
            alert(strInfo);
        }
        catch (e) {
            var strMsg: string = `获取某一条件的记录数不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 添加新记录
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickAddNewRecord)
    /// </summary>
    /// <returns></returns>
    public static async btnAddNewRecord_Click() {
        $('#hidDivName').val("divAddNewRecord");
        var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        objgs_PaperGroupEN.PaperGroupId = "11111111";
        objgs_PaperGroupEN.PaperGroupName = "11111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.UpdUser = "11111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.UpdDate = "11111111111111111111";
        objgs_PaperGroupEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
        try {
            const responseText = await clsgs_PaperGroupWApi.IsExistAsync(objgs_PaperGroupEN.PaperGroupId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_PaperGroupEN.PaperGroupId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await clsgs_PaperGroupWApi.AddNewRecordAsync(objgs_PaperGroupEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult7').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult7').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 添加新记录
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickAddNewRecord4GetMaxStrId)
    /// </summary>
    /// <returns></returns>
    public static async btnAddNewRecord4GetMaxStrId_Click() {
        $('#hidDivName').val("divAddNewRecord4GetMaxStrId");
        const responseText = await clsgs_PaperGroupWApi.GetMaxStrIdAsync();
        var returnString: string = responseText.toString();
        var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        objgs_PaperGroupEN.PaperGroupId = returnString;
        objgs_PaperGroupEN.PaperGroupName = "11111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.UpdUser = "11111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.UpdDate = "11111111111111111111";
        objgs_PaperGroupEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
        try {
            const responseText = await clsgs_PaperGroupWApi.AddNewRecordAsync(objgs_PaperGroupEN);
            var returnBool: boolean = responseText;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult8').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult8').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `添加记录不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetMaxStrId)
    /// </summary>
    /// <returns></returns>
    public static async btnGetMaxStrId_Click() {
        $('#hidDivName').val("divGetMaxStrId");
        try {
            const responseText = await clsgs_PaperGroupWApi.GetMaxStrIdAsync();
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表gs_PaperGroup的最大关键字为空，不成功，请检查!`;
                $('#lblResult9').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `获取表gs_PaperGroup的最大关键字为：${returnString}!`;
                $('#lblResult9').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetMaxStrIdByPrefix)
    /// </summary>
    /// <returns></returns>
    public static async btnGetMaxStrIdByPrefix_Click() {
        $('#hidDivName').val("divGetMaxStrIdByPrefix");
        var strPrefix: string = $('#txtstrPrefix10').val();
        try {
            const responseText = await clsgs_PaperGroupWApi.GetMaxStrIdByPrefixAsync(strPrefix);
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表gs_PaperGroup的最大关键字为空，不成功，请检查!`;
                $('#lblResult10').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `获取表gs_PaperGroup的最大关键字为：${returnString}!`;
                $('#lblResult10').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 修改记录
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickUpdateRecord)
    /// </summary>
    /// <returns></returns>
    public static async btnUpdateRecord_Click() {
        $('#hidDivName').val("divUpdateRecord");
        var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        objgs_PaperGroupEN.PaperGroupId = "11111111";
        objgs_PaperGroupEN.PaperGroupName = "11111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.UpdUser = "11111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.UpdDate = "11111111111111111111";
        objgs_PaperGroupEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
        objgs_PaperGroupEN.sf_UpdFldSetStr = objgs_PaperGroupEN.UpdFldString;//设置哪些字段被修改(脏字段)
        try {
            const responseText = await clsgs_PaperGroupWApi.UpdateRecordAsync(objgs_PaperGroupEN);
            var returnBool: boolean = responseText;
            if (returnBool == true) {
                var strInfo: string = `修改记录成功!`;
                $('#lblResult11').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `修改记录不成功!`;
                $('#lblResult11').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 删除记录
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelRecord)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnDelRecord_Click() {
        $('#hidDivName').val("divDelRecord");
        var strKeyId: string = $('#txtstrKeyId12').val();
        var strPaperGroupId: string = strKeyId;
        try {
            const responseText = await clsgs_PaperGroupWApi.DelRecordAsync(strPaperGroupId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功, 共删除了${returnInt}条记录!`;
                $('#lblResult12').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                $('#lblResult12').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字列表删除记录
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelMultiRecord)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnDelgs_PaperGroups_Click() {
        $('#hidDivName').val("divDel[TabName]s");
        var strKeyIdLst: string = $('#txtarrKeyId13').val();
        var arrPaperGroupId: Array<string> = strKeyIdLst.split(',');
        try {
            const responseText = await clsgs_PaperGroupWApi.Delgs_PaperGroupsAsync(arrPaperGroupId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                $('#lblResult13').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                $('#lblResult13').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件删除多条记录
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelMultiRecordByCond)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnDelMultiRecordByCond_Click() {
        $('#hidDivName').val("divDelMultiRecordByCond");
        var strWhereCond: string = $('#txtstrWhereCond14').val();
        try {
            const responseText = await clsgs_PaperGroupWApi.Delgs_PaperGroupsByCondAsync(strWhereCond);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                $('#lblResult14').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                $('#lblResult14').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的第一条记录的对象
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetFirstObj)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetFirstObj_Click() {
        $('#hidDivName').val("divGetFirstObj");
        var strWhereCond: string = $('#txtstrWhereCond15').val();
        try {
            const responseText = await clsgs_PaperGroupWApi.GetFirstObjAsync(strWhereCond);
            var objgs_PaperGroupEN: clsgs_PaperGroupEN = <clsgs_PaperGroupEN>responseText;
            strWhereCond = $('#txtstrWhereCond15').val();
            var strInfo: string = `根据条件:[${strWhereCond}] 获取第一个记录对象：${objgs_PaperGroupEN.PaperGroupId}!`;
            $('#lblResult15').val(strInfo);
            //显示信息框
            alert(strInfo);
            this.Showgs_PaperGroupObj("divList15", objgs_PaperGroupEN);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的第一条记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey)
    /// </summary>
    /// <param name = "sender">参数列表</param>
    /// <returns></returns>
    public static async btnGetObjByPaperGroupId_Click() {
        $('#hidDivName').val("divGetObjBy[Key]");
        var strKeyId: string = $('#txtvarKeyId16').val();
        var strPaperGroupId: string = strKeyId;
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjByPaperGroupIdAsync(strPaperGroupId);
            var objgs_PaperGroupEN: clsgs_PaperGroupEN = <clsgs_PaperGroupEN>responseText;
            var strInfo: string = `根据关键字:[${strKeyId}]获取对象：${objgs_PaperGroupEN.PaperGroupId}!`;
            $('#lblResult16').val(strInfo);
            //显示信息框
            alert(strInfo);
            this.Showgs_PaperGroupObj("divList16", objgs_PaperGroupEN);
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey_Cache)
    /// </summary>
    /// <param name = "sender">参数列表</param>
    /// <returns></returns>
    public static async btnGetObjByPaperGroupId_Cache_Click() {
        $('#hidDivName').val("divGetObjBy[Key]_Cache");
        var strKeyId: string = $('#txtvarKeyId17').val();
        var strPaperGroupId: string = strKeyId;
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjByPaperGroupId_Cache(strPaperGroupId);
            var objgs_PaperGroupEN: clsgs_PaperGroupEN = <clsgs_PaperGroupEN>responseText;
            var strInfo: string = `根据关键字:[${strKeyId}]获取对象：${objgs_PaperGroupEN.PaperGroupId}!`;
            $('#lblResult17').val(strInfo);
            //显示信息框
            alert(strInfo);
            this.Showgs_PaperGroupObj("divList17", objgs_PaperGroupEN);
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey_WA_Cache)
    /// </summary>
    /// <param name = "sender">参数列表</param>
    /// <returns></returns>
    public static async btnGetObjByPaperGroupId_WA_Cache_Click() {
        $('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
        var strKeyId: string = $('#txtvarKeyId18').val();
        var strPaperGroupId: string = strKeyId;
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjByPaperGroupId_WA_CacheAsync(strPaperGroupId);
            var objgs_PaperGroupEN: clsgs_PaperGroupEN = <clsgs_PaperGroupEN>responseText;
            var strInfo: string = `根据关键字:[${strKeyId}]获取对象：${objgs_PaperGroupEN.PaperGroupId}!`;
            $('#lblResult18').val(strInfo);
            //显示信息框
            alert(strInfo);
            this.Showgs_PaperGroupObj("divList18", objgs_PaperGroupEN);
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLst)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLst_Click() {
        $('#hidDivName').val("divGetObjLst");
        var strWhereCond: string = $('#txtstrWhereCond19').val();
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${strWhereCond}]共获取对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult19').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList19", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的对象列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字列表获取相应的对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByKeyLst_Click() {
        $('#hidDivName').val("divGetObjLstByKeyLst");
        var strKeyIdLst: string = $('#txtarrKeyId20').val();
        var arrPaperGroupId: Array<string> = strKeyIdLst.split(',');
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLstAsync(arrPaperGroupId);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult20').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList20", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据关键字列表获取相应对象列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字列表获取相应的对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst_Cache)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByKeyLst_Cache_Click() {
        $('#hidDivName').val("divGetObjLstByKeyLst_Cache");
        var strKeyIdLst: string = $('#txtarrKeyId21').val();
        var arrPaperGroupId: Array<string> = strKeyIdLst.split(',');
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLst_Cache(arrPaperGroupId);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult21').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList21", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据关键字列表获取相应对象列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据关键字列表获取相应的对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst_WA_Cache)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByKeyLst_WA_Cache_Click() {
        $('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
        var strKeyIdLst: string = $('#txtarrKeyId22').val();
        var arrPaperGroupId: Array<string> = strKeyIdLst.split(',');
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLst_WA_CacheAsync(arrPaperGroupId);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult22').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList22", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据关键字列表获取相应对象列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的分页对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetSubObjLst_Cache)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetSubObjLst_Cache_Click() {
        $('#hidDivName').val("divGetSubObjLst_Cache");
        var objTabName_Cond: Object = $('#txtobjTabName_Cond23').val();
        var objgs_PaperGroup_Cond: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        var arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
        console.log(`字段比较对象记录数(本地获取)：${arrFldComparisonObj.length}`);
        arrFldComparisonObj.forEach(x => { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
        var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
        console.log(objgs_PaperGroupEN_Sim);
        try {
            const responseText = await clsgs_PaperGroupWApi.GetSubObjLst_Cache(objgs_PaperGroup_Cond);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperGroup_Cond)}],共获取对象列表子集数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult23').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList23", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件对象获取相应的对象列表子集不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的分页对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetSubObjLst_WA_Cache)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetSubObjLst_WA_Cache_Click() {
        $('#hidDivName').val("divGetSubObjLst_WA_Cache");
        var objTabName_Cond: Object = $('#txtobjTabName_Cond24').val();
        var objgs_PaperGroup_Cond: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        var arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
        console.log(`字段比较对象记录数(本地获取)：${arrFldComparisonObj.length}`);
        arrFldComparisonObj.forEach(x => { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
        var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
        console.log(objgs_PaperGroupEN_Sim);
        try {
            const responseText = await clsgs_PaperGroupWApi.GetSubObjLst_WA_CacheAsync(objgs_PaperGroup_Cond);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${JSON.stringify(objgs_PaperGroup_Cond)}],共获取对象列表子集数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult24').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList24", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件对象获取相应的对象列表子集不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的顶部对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetTopObjLst)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetTopObjLst_Click() {
        $('#hidDivName').val("divGetTopObjLst");
        var intTopSize: number = Number($('#txtintTopSize25').val());
        var strOrderBy: string = $('#txtstrOrderBy25').val();
        var strWhereCond: string = $('#txtstrWhereCond25').val();
        var objTopPara: stuTopPara =
        {
            WhereCond: strWhereCond,
            TopSize: intTopSize,
            OrderBy: "",
            IsCheckSQLAttack: "false",
            Exclude: ""
        }
        try {
            const responseText = await clsgs_PaperGroupWApi.GetTopObjLstAsync(objTopPara);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${strWhereCond}],顶部数:[${intTopSize}]共获取顶部对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult25').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList25", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的顶部对象列表不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的分页对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByPager_Click() {
        $('#hidDivName').val("divGetObjLstByPager");
        var intPageIndex: number = Number($('#txtintPageIndex26').val());
        var intPageSize: number = Number($('#txtintPageSize26').val());
        var strOrderBy: string = $('#txtstrOrderBy26').val();
        var strWhereCond: string = $('#txtstrWhereCond26').val();
        var objPagerPara: stuPagerPara = {
            PageIndex: intPageIndex,
            PageSize: intPageSize,
            WhereCond: strWhereCond,
            OrderBy: strOrderBy
        };
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByPagerAsync(objPagerPara);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${strWhereCond}],每页记录数:[${intPageSize}],第[${intPageIndex}]页,共获取分页对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult26').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList26", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的分页对象列表不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的分页对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager_Cache)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByPager_Cache_Click() {
        $('#hidDivName').val("divGetObjLstByPager_Cache");
        var intPageIndex: number = Number($('#txtintPageIndex27').val());
        var intPageSize: number = Number($('#txtintPageSize27').val());
        var strOrderBy: string = $('#txtstrOrderBy27').val();
        var strWhereCond: string = $('#txtstrWhereCond27').val();
        var objgs_PaperGroup_Cond: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        var arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
        console.log(`字段比较对象记录数(本地获取)：${arrFldComparisonObj.length}`);
        arrFldComparisonObj.forEach(x => { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
        var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
        console.log(objgs_PaperGroupEN_Sim);
        strWhereCond = JSON.stringify(objgs_PaperGroupEN_Sim);
        var objPagerPara: stuPagerPara = {
            PageIndex: intPageIndex,
            PageSize: intPageSize,
            WhereCond: strWhereCond,
            OrderBy: strOrderBy
        };
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByPager_Cache(objPagerPara);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${strWhereCond}],每页记录数:[${intPageSize}],第[${intPageIndex}]页,共获取分页对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult27').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList27", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的分页对象列表不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取相应的分页对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager_WA_Cache)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByPager_WA_Cache_Click() {
        $('#hidDivName').val("divGetObjLstByPager_WA_Cache");
        var intPageIndex: number = Number($('#txtintPageIndex28').val());
        var intPageSize: number = Number($('#txtintPageSize28').val());
        var strOrderBy: string = $('#txtstrOrderBy28').val();
        var strWhereCond: string = $('#txtstrWhereCond28').val();
        var objgs_PaperGroup_Cond: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
        var arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
        console.log(`字段比较对象记录数(本地获取)：${arrFldComparisonObj.length}`);
        arrFldComparisonObj.forEach(x => { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
        var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
        console.log(objgs_PaperGroupEN_Sim);
        strWhereCond = JSON.stringify(objgs_PaperGroupEN_Sim);
        var objPagerPara: stuPagerPara = {
            PageIndex: intPageIndex,
            PageSize: intPageSize,
            WhereCond: strWhereCond,
            OrderBy: strOrderBy
        };
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByPager_WA_CacheAsync(objPagerPara);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${strWhereCond}],每页记录数:[${intPageSize}],第[${intPageIndex}]页,共获取分页对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult28').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList28", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的分页对象列表不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 根据条件获取范围内相应的对象列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByRange)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnGetObjLstByRange_Click() {
        $('#hidDivName').val("divGetObjLstByRange");
        var strOrderBy: string = $('#txtstrOrderBy29').val();
        var intMaxNum: number = Number($('#txtintMaxNum29').val());
        var intMinNum: number = Number($('#txtintMinNum29').val());
        var strWhereCond: string = $('#txtstrWhereCond29').val();
        var objRangePara: stuRangePara = {
            MaxNum: intMaxNum,
            MinNum: intMinNum,
            WhereCond: strWhereCond,
            OrderBy: strOrderBy
        };
        try {
            const responseText = await clsgs_PaperGroupWApi.GetObjLstByRangeAsync(objRangePara);
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            var strInfo: string = `根据条件:[${strWhereCond}],最小记录号:[${intMinNum}],最大记录号:[${intMaxNum}],共获取分页对象列表数：${arrgs_PaperGroupObjLst.length}!`;
            $('#lblResult29').val(strInfo);
            //显示信息框
            //alert(strInfo);
            this.BindTab_gs_PaperGroup("divList29", arrgs_PaperGroupObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取范围内相应的对象列表不成功, ${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 显示gs_PaperGroup对象的所有属性值
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_BindTab)
    /// </summary>
    /// <param name = "divContainer">显示容器</param>
    /// <param name = "arrgs_PaperGroupObjLst">需要绑定的对象列表</param>
    /// <returns></returns>
    public static BindTab_gs_PaperGroup(divContainer: string, arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrFldName: Array<string> = new Array<string>();
        var sstrColHeader: Array<string> = new Array<string>();
        sstrFldName.push("PaperGroupId"); sstrColHeader.push("组Id");
        sstrFldName.push("PaperGroupName"); sstrColHeader.push("组名");
        sstrFldName.push("UpdUser"); sstrColHeader.push("修改人");
        sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
        sstrFldName.push("Meno"); sstrColHeader.push("备注");
        clsCommonFunc4Web.BindTab(o, arrgs_PaperGroupObjLst, sstrFldName, sstrColHeader, "PaperGroupId");
    }

    /// <summary>
    /// 显示{0}对象的所有属性值
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_ShowTabObj)
    /// </summary>
    /// <param name = "divContainer">显示容器</param>
    /// <param name = "objgs_PaperGroup">需要显示的对象</param>
    /// <returns></returns>
    public static Showgs_PaperGroupObj(divContainer: string, objgs_PaperGroup: clsgs_PaperGroupEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_PaperGroup[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /// <summary>
    /// 获取当前表的字段名列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_FldComparison)
    /// </summary>
    /// <returns></returns>
    public static AddDPV_FldComparison(divName4Edit: string) {
        var objLst = document.getElementsByTagName("div");
        var strStartName: string = "divEditFldComparison";
        let arrElement: Array<HTMLElement> = WApigs_PaperGroup_UT_TS.GetArray(objLst) as Array<HTMLElement>;
        let arrDiv: Array<HTMLDivElement> = arrElement as Array<HTMLDivElement>;
        let arrFind: Array<HTMLDivElement> = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);
        arrFind.forEach(x => x.innerHTML = "");
        //var o: HTMLDivElement = document.getElementById("div") as HTMLDivElement;
        var strUrl: string = "../Test/_FldComparison/";
        console.log("divName4Edit:(In AddDPV_FldComparison)" + divName4Edit);
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "html",
            data: {},
            success: function (data) {
                console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                $('#' + divName4Edit).html(data);
                //setTimeout(() => { clsFldComparisonObj.BindTab(); }, 100);
                clsFldComparisonObj.BindTab();
            },
            error: (e) => {
                console.error(e);
            }
        });
    };

    /// <summary>
    /// 获取当前表的字段名列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFldNameLst)
    /// </summary>
    /// <returns></returns>
    public static GetFldNameLst(func: (strKey: string) => any) {
        var arrFldName: Array<string> = clsgs_PaperGroupEN.AttributeName;
        var strFldNameLst1 = arrFldName.join(",");
        clsFldComparisonObj.arrFldNameLst = arrFldName;
        func(strFldNameLst1);
    }

    /// <summary>
    /// 获取当前表的字段名列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetLocalObjLst)
    /// </summary>
    /// <returns></returns>
    public static GetLocalObjLst(): Array<clsFldComparisonObj> {
        var strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
        if (strFldComparisonObjLst == null || strFldComparisonObjLst == "") {
            return new Array<clsFldComparisonObj>();
        }
        var arrFldComparisonObj: Array<clsFldComparisonObj> = JSON.parse(strFldComparisonObjLst);
        return arrFldComparisonObj;
    };

    /// <summary>
    /// 建立缓存
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_CreateCache)
    /// </summary>
    /// <returns></returns>
    public static async CreateCache() {
        var strKey: string = "";
        try {
            console.log("开始获取缓存：gs_PaperGroup");
            strKey = clsgs_PaperGroupEN._CurrTabName;
            const responseText = await clsgs_PaperGroupWApi.GetObjLst_Cache();
            console.log("获取缓存完成！gs_PaperGroup");
            var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = CacheHelper.Get(strKey);
            if (arrgs_PaperGroupObjLst != null) {
                var strInfo: string = `建立缓存Key=[${strKey}]完成: 共获取对象列表数：${arrgs_PaperGroupObjLst.length}!`;
                $('#lblPageStatusContent').html(strInfo);
            }
            else {
                var strInfo: string = `建立缓存Key=[${strKey}]不成功!`;
                $('#lblPageStatusContent').html(strInfo);
            }
        }
        catch (e) {
            console.log("WApigs_PaperGroup_UT_TS: CreateCache()不成功！");
            console.error(e);
            var strInfo: string = `建立缓存Key=[${strKey}]失败:${e}!`;
            console.log(strInfo);
            $('#lblPageStatusContent').html(strInfo);
        }
    }

    /// <summary>
    /// 把Html控件集合转换成Array列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetArray)
    /// </summary>
    /// <returns></returns>
    public static GetArray(arr): Array<HTMLElement> {
        let arrLst: Array<HTMLElement> = new Array<HTMLElement>();
        for (var i = 0; i < arr.length; i++) {
            var chk: HTMLElement = arr[i];// as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    };
}
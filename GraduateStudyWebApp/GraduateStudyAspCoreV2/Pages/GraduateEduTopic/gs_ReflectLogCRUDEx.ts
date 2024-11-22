
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ReflectLogCRUDEx
表名:gs_ReflectLog(01120702)
生成代码版本:2020.07.13.1
生成日期:2020/07/14 16:02:06
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";

import { gs_ReflectLogCRUD } from "../PagesBase/GraduateEduTopic/gs_ReflectLogCRUD.js";
import { clsgs_ReflectLogEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { gs_ReflectLog_GetObjLstByPagerAsync, gs_ReflectLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ReflectLogWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { GetCheckedKeyIds } from "../TS/PubFun/clsCommFunc4Web.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { gs_ReflectLog_EditEx } from "./gs_ReflectLog_EditEx.js";
declare function ShowDialog_gs_ReflectLog(strOpType): void;
declare function HideDialog_gs_ReflectLog(): void;
declare var $;
declare var window;
/* gs_ReflectLogCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_ReflectLogCRUDEx extends gs_ReflectLogCRUD implements IShowList {
    public divName4Pager_ReflectLog = "divPagergsReflectLog";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortgs_ReflectLogBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_gs_ReflectLog();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "gs_ReflectLog":
                alert('该类没有绑定该函数：[this.BindGv_gs_ReflectLog_Cache]！');
                this.BindGv_gs_ReflectLog_Cache();
                break;
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_Old_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public async Combinegs_ReflectLogCondition(): Promise<string> {

            //if (this.ReflectLogName_q != "") {
            //    strWhereCond += ` And ${clsgs_ReflectLogEN.con_ReflectLogName} like '% ${this.ReflectLogName_q}%'`;
            //}
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond: string = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsgs_ReflectLogEN.con_TopicId} = '${strTopicId}'`;
                }
                //判断角色 
                //管理员
                if (clsPublocalStorage.roleId == "00620001") {

                }
                else if (clsPublocalStorage.roleId == "00620002") {
                    //教师
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsgs_ReflectLogEN.con_UpdUser} = '${clsPublocalStorage.userId}'`;
                }
            }
            catch (objException) {
                var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
        }

        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_Old_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_gs_ReflectLog() {
        if (this.bolIsInitShow == false)  //
        {
            this.objPager.InitShow(this.divName4Pager_ReflectLog);
            this.bolIsInitShow = true;  //
        }

        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.Combinegs_ReflectLogCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrgs_ReflectLogObjLst: Array<clsgs_ReflectLogEN> = [];
        var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
        try {
            this.recCount = await gs_ReflectLog_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: gs_ReflectLogCRUD.sortgs_ReflectLogBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await gs_ReflectLog_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrgs_ReflectLogObjLst = <Array<clsgs_ReflectLogEN>>jsonData;
            });

            //获取用户缓存数据；
            arrvUsersObjLst = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {
            this.Bindgs_ReflectLog(arrgs_ReflectLogObjLst, arrvUsersObjLst);
            console.log("完成BindGv_gs_ReflectLog!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    public async Bindgs_ReflectLog(arrgs_ReflectLogObjLst: Array<clsgs_ReflectLogEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {
        
        var strhtml = "";
        var strUserId = clsPublocalStorage.userId;
        strhtml += '<div class="info" id="infogs_ReflectLog"><div class="title btn-4">';
        strhtml += '<div style="float:left;"><a href="#" title="反思">反思</a></div>';
        strhtml += '</div><ul class="artlist">';
        var v = 0;//给内容加个序号
        for (var i = 0; i < arrgs_ReflectLogObjLst.length; i++) {

            //得到MId；
            var strmId = arrgs_ReflectLogObjLst[i].mId;
            v++;
            strhtml += '<li><span class="rowtit color4">' + v + '.[名称]：</span><span class="abstract-text">' + arrgs_ReflectLogObjLst[i].reflectLogName + '</span></li>';

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrgs_ReflectLogObjLst[i].reflectLogContent + '</span></li>';
            //获取引用人；编辑人、用户名称
            //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
            var arrvUsers: Array<clsvUsersSimEN> = [];
            var UpdUserName;//编辑人

            //获取技能编辑人；
            arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrgs_ReflectLogObjLst[i].updUser);//编辑人
            for (var j = 0; j < arrvUsers.length; j++) {
                UpdUserName = arrvUsers[j].userName;
                break;
            }

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';
            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作时间]：' + arrgs_ReflectLogObjLst[i].updDate + '</span>'
            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span>' + UpdUserName;

            if (clsPublocalStorage.roleId == "00620003") {
                //登录用户和upduser一致则显示；
                if (arrgs_ReflectLogObjLst[i].updUser == clsPublocalStorage.userId) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskDel" style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelgs_ReflectLog_Click(' + arrgs_ReflectLogObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                    strhtml += Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id=\"gsTeacherTaskUpd\" style=\"float:right;\" title=\"修改\" class=\"layui-btn layui-btn layui-btn layui-btn-xs\" onclick=btn_Click('{0}','{1}') > <i class=\"layui-icon\" >& #xe642; </i>修改</button > ",
                       "Updategs_ReflectLog", arrgs_ReflectLogObjLst[i].mId);
                }
            }
            else {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskDel" style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelgs_ReflectLog_Click(' + arrgs_ReflectLogObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                strhtml += Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id=\"gsTeacherTaskUpd\" style=\"float: right; \" title=\"修改\" class=\"layui-btn layui-btn layui-btn layui-btn-xs\" onclick=btn_Click('{0}','{1}') > <i class=\"layui-icon\" >&#xe642;</i>修改</button>",
                    "Updategs_ReflectLog", arrgs_ReflectLogObjLst[i].mId);
            }
            strhtml += '</span></li>';

            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';
        //拼接；
        $("#divgsReflectLogDataLst").html(strhtml);

        if (arrgs_ReflectLogObjLst.length > 10) {
            $("#divPagergsReflectLog").show();
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager_ReflectLog);
        }
    }

    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_Old_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                const responseBindGv = await this.BindGv_gs_ReflectLog();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_ReflectLogCRUDEx = new gs_ReflectLogCRUDEx();
        var objPage_Edit: gs_ReflectLog_EditEx = new gs_ReflectLog_EditEx(objPage);
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "UpdateRecordInTab":            //修改记录InTab
                objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordInTab":   //删除记录InTab 
                objPage.btnDelRecordInTab_Click(strKeyId);
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(gs_ReflectLogCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }
}
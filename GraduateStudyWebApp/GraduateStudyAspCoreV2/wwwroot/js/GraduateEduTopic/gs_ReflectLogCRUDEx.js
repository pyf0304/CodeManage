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
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/gs_ReflectLogCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ReflectLogWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./gs_ReflectLog_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ReflectLogCRUDEx = void 0;
    const gs_ReflectLogCRUD_js_1 = require("../PagesBase/GraduateEduTopic/gs_ReflectLogCRUD.js");
    const clsgs_ReflectLogEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js");
    const clsgs_ReflectLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ReflectLogWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const gs_ReflectLog_EditEx_js_1 = require("./gs_ReflectLog_EditEx.js");
    /* gs_ReflectLogCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_ReflectLogCRUDEx extends gs_ReflectLogCRUD_js_1.gs_ReflectLogCRUD {
        constructor() {
            super(...arguments);
            this.divName4Pager_ReflectLog = "divPagergsReflectLog";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortgs_ReflectLogBy: string = "mId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_gs_ReflectLog();
        }
        BindGv_Cache(strType, strPara) {
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
        async Combinegs_ReflectLogCondition() {
            //if (this.ReflectLogName_q != "") {
            //    strWhereCond += ` And ${clsgs_ReflectLogEN.con_ReflectLogName} like '% ${this.ReflectLogName_q}%'`;
            //}
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId} = '${strTopicId}'`;
                }
                //判断角色 
                //管理员
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
                }
                else if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620002") {
                    //教师
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser} = '${clsPublocalStorage_js_1.clsPublocalStorage.userId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_Old_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_gs_ReflectLog() {
            if (this.bolIsInitShow == false) //
             {
                this.objPager.InitShow(this.divName4Pager_ReflectLog);
                this.bolIsInitShow = true; //
            }
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.Combinegs_ReflectLogCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrgs_ReflectLogObjLst = [];
            var arrvUsersObjLst = [];
            try {
                this.recCount = await (0, clsgs_ReflectLogWApi_js_1.gs_ReflectLog_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: gs_ReflectLogCRUD_js_1.gs_ReflectLogCRUD.sortgs_ReflectLogBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsgs_ReflectLogWApi_js_1.gs_ReflectLog_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrgs_ReflectLogObjLst = jsonData;
                });
                //获取用户缓存数据；
                arrvUsersObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.Bindgs_ReflectLog(arrgs_ReflectLogObjLst, arrvUsersObjLst);
                console.log("完成BindGv_gs_ReflectLog!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        async Bindgs_ReflectLog(arrgs_ReflectLogObjLst, arrvUsersObjLst) {
            var strhtml = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            strhtml += '<div class="info" id="infogs_ReflectLog"><div class="title btn-4">';
            strhtml += '<div style="float:left;"><a href="#" title="反思">反思</a></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrgs_ReflectLogObjLst.length; i++) {
                //得到MId；
                var strmId = arrgs_ReflectLogObjLst[i].mId;
                v++;
                strhtml += '<li><span class="rowtit color4">' + v + '.[名称]：</span><span class="abstract-text">' + arrgs_ReflectLogObjLst[i].reflectLogName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrgs_ReflectLogObjLst[i].reflectLogContent + '</span></li>';
                //获取引用人；编辑人、用户名称
                //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
                var arrvUsers = [];
                var UpdUserName; //编辑人
                //获取技能编辑人；
                arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrgs_ReflectLogObjLst[i].updUser); //编辑人
                for (var j = 0; j < arrvUsers.length; j++) {
                    UpdUserName = arrvUsers[j].userName;
                    break;
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作时间]：' + arrgs_ReflectLogObjLst[i].updDate + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span>' + UpdUserName;
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620003") {
                    //登录用户和upduser一致则显示；
                    if (arrgs_ReflectLogObjLst[i].updUser == clsPublocalStorage_js_1.clsPublocalStorage.userId) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskDel" style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelgs_ReflectLog_Click(' + arrgs_ReflectLogObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                        strhtml += (0, clsString_js_1.Format)("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id=\"gsTeacherTaskUpd\" style=\"float:right;\" title=\"修改\" class=\"layui-btn layui-btn layui-btn layui-btn-xs\" onclick=btn_Click('{0}','{1}') > <i class=\"layui-icon\" >& #xe642; </i>修改</button > ", "Updategs_ReflectLog", arrgs_ReflectLogObjLst[i].mId);
                    }
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskDel" style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelgs_ReflectLog_Click(' + arrgs_ReflectLogObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                    strhtml += (0, clsString_js_1.Format)("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id=\"gsTeacherTaskUpd\" style=\"float: right; \" title=\"修改\" class=\"layui-btn layui-btn layui-btn layui-btn-xs\" onclick=btn_Click('{0}','{1}') > <i class=\"layui-icon\" >&#xe642;</i>修改</button>", "Updategs_ReflectLog", arrgs_ReflectLogObjLst[i].mId);
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
        async btnDelRecordInTab_Click(strKeyId) {
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
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_ReflectLogCRUDEx();
            var objPage_Edit = new gs_ReflectLog_EditEx_js_1.gs_ReflectLog_EditEx(objPage);
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(gs_ReflectLogCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
    }
    exports.gs_ReflectLogCRUDEx = gs_ReflectLogCRUDEx;
});

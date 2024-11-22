(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/gs_TeacherTaskCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_TeacherTaskEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TeacherTaskWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TeacherTaskCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_TeacherTaskCRUDEx
    表名:gs_TeacherTask(01120686)
    生成代码版本:2020.06.27.2
    生成日期:2020/07/01 16:14:28
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
    const gs_TeacherTaskCRUD_js_1 = require("../PagesBase/GraduateEduTopic/gs_TeacherTaskCRUD.js");
    const clsgs_TeacherTaskEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_TeacherTaskEN.js");
    const clsgs_TeacherTaskWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_TeacherTaskWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* gs_TeacherTaskCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    //export class gs_TeacherTaskCRUDEx extends gs_TeacherTaskCRUD {
    class gs_TeacherTaskCRUDEx extends gs_TeacherTaskCRUD_js_1.gs_TeacherTaskCRUD {
        constructor() {
            super(...arguments);
            this.recCount = 0;
            //布置任务
            this.mstrListDivgs_TeacherTask = "divgs_TeacherTaskDataLst";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortgs_TeacherTaskBy: string = "mId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_TeacherTaskCRUDEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    //objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    //objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
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
                    //objPage.btnDelRecord_Click();
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
                    var strMsg = '命令:' + strCommandName + "在函数(gs_TeacherTaskCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        //////////////////////////////////////------------------------------ 教师任务布置
        //教师任务
        async liTeacherTaskClick() {
            try {
                //教师布置任务
                const gvResult = await this.BindGv_gs_TeacherTask();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取客观依据列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_gs_TeacherTask() {
            var strListDiv = this.mstrListDivgs_TeacherTask;
            var strWhereCond = await this.Combinegs_TeacherTaskCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrgs_TeacherTaskObjLst = [];
            try {
                this.recCount = await (0, clsgs_TeacherTaskWApi_js_1.gs_TeacherTask_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortgs_TeacherTaskBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsgs_TeacherTaskWApi_js_1.gs_TeacherTask_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrgs_TeacherTaskObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_gs_TeacherTask(strListDiv, arrgs_TeacherTaskObjLst);
                console.log("完成BindGv_gs_TeacherTask!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示gs_TeacherTask对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_TeacherTaskObjLst">需要绑定的对象列表</param>
    */
        async BindTab_gs_TeacherTask(divContainer, arrgs_TeacherTaskObjLst) {
            var strhtml = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            strhtml += '<div class="info" id="infoTeacherTask"><div class="title btn-4">';
            strhtml += '<div style="float:left;"><a href="#" title="任务布置">任务布置</a></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrgs_TeacherTaskObjLst.length; i++) {
                //得到MId；
                var strmId = arrgs_TeacherTaskObjLst[i].mId;
                v++;
                strhtml += '<li><span class="rowtit color4">' + v + '.[任务说明]：</span><span class="abstract-text">' + arrgs_TeacherTaskObjLst[i].missionStatement + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[任务要求]：</span><span class="abstract-text">' + arrgs_TeacherTaskObjLst[i].missionRequirement + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[发布时间]：' + arrgs_TeacherTaskObjLst[i].updDate + '</span>';
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskDel" style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelgs_TeacherTask_Click(' + arrgs_TeacherTaskObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskUpd" style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btn_Click(\'Updategs_TeacherTask\',\'' + arrgs_TeacherTaskObjLst[i].mId + '\') > <i class="layui-icon" >&#xe642;</i>修改</button>';
                }
                else if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620002") {
                    //登录用户和upduser一致则显示；
                    if (arrgs_TeacherTaskObjLst[i].updUser == clsPublocalStorage_js_1.clsPublocalStorage.userId) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskDel" style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelgs_TeacherTask_Click(' + arrgs_TeacherTaskObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id="gsTeacherTaskUpd" style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_TeacherTask_Click("' + arrgs_TeacherTaskObjLst[i].mId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                    }
                }
                else {
                }
                strhtml += '</span></li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divgs_TeacherTaskDataLst").html(strhtml);
            if (arrgs_TeacherTaskObjLst.length > 10) {
                $("#divgs_TeacherTask").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async Combinegs_TeacherTaskCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1  and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId} = '${strTopicId}'`;
                }
                //判断角色 
                //管理员
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
                    $("#btnAddgs_TeacherTask").show();
                }
                else if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620002") {
                    //教师
                    $("#btnAddgs_TeacherTask").show();
                }
                else {
                    //学生； 
                    $("#btnAddgs_TeacherTask").hide();
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combinegs_TeacherTaskCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortgs_TeacherTaskBy(value) {
            $("#hidSortgs_TeacherTaskBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortgs_TeacherTaskBy() {
            return $("#hidSortgs_TeacherTaskBy").val();
        }
        /*
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    */
        async btnDelgs_TeacherTask_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                //得到当前登录的教师角色
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strRoleId == "00620003") {
                    //提示学生不可删除数据；
                    var strInfo = `您权限不够，不可删除`;
                    //显示信息框
                    alert(strInfo);
                    return;
                }
                else {
                    var lngKeyId = Number(strKeyId);
                    const responseText = await this.Delgs_TeacherTaskRecord(lngKeyId);
                    const responseBindGv = await this.BindGv_gs_TeacherTask();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
     根据关键字删除记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async Delgs_TeacherTaskRecord(lngmId) {
            try {
                const responseText = await (0, clsgs_TeacherTaskWApi_js_1.gs_TeacherTask_DelRecordAsync)(lngmId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
       * 获取当前页序号
      */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
    }
    exports.gs_TeacherTaskCRUDEx = gs_TeacherTaskCRUDEx;
});

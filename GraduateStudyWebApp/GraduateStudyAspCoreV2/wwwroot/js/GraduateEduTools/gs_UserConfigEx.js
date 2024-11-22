(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/ExamManage/gs_UserConfigCRUD.js", "../TS/L0_Entity/ExamManage/clsgs_UserConfigEN.js", "../TS/L3_ForWApi/ExamManage/clsgs_UserConfigWApi.js", "../TS/L3_ForWApi/ExamManage/clsvgs_UserConfigWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_UserConfigEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_UserConfigCRUD
    表名:gs_UserConfig(01120693)
    生成代码版本:2020.07.09.1
    生成日期:2020/07/09 22:22:27
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:考试管理
    模块英文名:ExamManage
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const gs_UserConfigCRUD_js_1 = require("../PagesBase/ExamManage/gs_UserConfigCRUD.js");
    const clsgs_UserConfigEN_js_1 = require("../TS/L0_Entity/ExamManage/clsgs_UserConfigEN.js");
    const clsgs_UserConfigWApi_js_1 = require("../TS/L3_ForWApi/ExamManage/clsgs_UserConfigWApi.js");
    const clsvgs_UserConfigWApi_js_1 = require("../TS/L3_ForWApi/ExamManage/clsvgs_UserConfigWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* gs_UserConfigCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class gs_UserConfigEx extends gs_UserConfigCRUD_js_1.gs_UserConfigCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.divName4Detail = "divDetail"; //详细信息区的Id
            this.recCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //// 为查询区绑定下拉框
                //const gvBindDdl = await this.BindDdl4QueryRegion();
                //获取当前用户 查询配置表，不存在数据则默认赋值等；
                const gvResultOne = await this.SelectConfigAddSave();
                this.hidSortvgs_UserConfigBy = "configTypeName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                ////2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_gs_UserConfig();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        //用户查询当前用户是否有配置信息 没有则默认赋值等；
        async SelectConfigAddSave() {
            try {
                const responseText2 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetAddConfig)(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    console.log("配置查询完成");
                }
                else {
                    console.error("配置查询失败");
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        Combinevgs_UserConfig() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //学生 判断角色 
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620003") {
                    strWhereCond += " and updUser ='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                }
                else {
                    //管理员 教师 
                    //strWhereCond += ` And ${clsvgs_UserConfigEN.con_ con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                }
                strWhereCond += " order by updDate Desc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combinevgs_UserConfig)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_gs_UserConfig() {
            var strWhereCond = await this.Combinevgs_UserConfig();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            //var arrvSysScoreSummaryNumObjLst: Array<clsvSysScoreSummaryEN> = [];
            var arrgs_UserConfigObjLst = [];
            var arrgs_ShareObjLst = [];
            var arrUsers = [];
            try {
                //this.recCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_UserConfigBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvgs_UserConfigWApi_js_1.vgs_UserConfig_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_UserConfigObjLst = jsonData;
                });
                //获取分享权限的下拉框
                const responseObjLst1 = await (0, clsgs_ShareWApi_js_1.gs_Share_GetObjLstAsync)("1=1").then((jsonData) => {
                    arrgs_ShareObjLst = jsonData;
                });
                //获取用户名称；根据id；
                arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                var strhtml = "";
                var cateid = 0;
                //$('#tbList tr').remove();
                for (var i = 0; i < arrgs_UserConfigObjLst.length; i++) {
                    var configId = arrgs_UserConfigObjLst[i].configId;
                    var strConfigTypeId = arrgs_UserConfigObjLst[i].configTypeId;
                    var strConfigTypeName = arrgs_UserConfigObjLst[i].configTypeName;
                    var strShareId = arrgs_UserConfigObjLst[i].shareId;
                    var strShareName = arrgs_UserConfigObjLst[i].shareName;
                    var strDataTableId = arrgs_UserConfigObjLst[i].dataTableId;
                    var strDataTable = arrgs_UserConfigObjLst[i].dataTable;
                    var strUpdUser = arrgs_UserConfigObjLst[i].updUser;
                    var strUpdDate = arrgs_UserConfigObjLst[i].updDate;
                    strhtml += '<tr>';
                    strhtml += '<td>' + strConfigTypeId + '</td>';
                    strhtml += '<td>' + strConfigTypeName + '</td>';
                    var gs_ShareObj = arrgs_ShareObjLst.find(x => x.shareId == strShareId);
                    if (gs_ShareObj != null) {
                        //strhtml += '<td> <select id="ddlShardId' + configId + '" name = "ddlShardId" class="form-control" style = "width:170px;" onchange="ddlShardIdfunc(' + configId + ')" >';
                        //strhtml += '<td> <div class="TopNameMenu" style = "width:25%;float:left;border:1px solid #dee2e6;line-height: 2.5;margin-top:5px;margin-left:1px;" >';
                        strhtml += '<td>';
                        strhtml += '<ul class="layui-nav left fast-add" lay - filter="" id = "paperId" >';
                        strhtml += '<li class="layui-nav-item" >';
                        strhtml += '<a href="javascript:;" >';
                        strhtml += '<div style="width:100%;  line-height: 2.5;margin-top:10px;" onclick=ShardIdfunc("' + configId + '","' + strShareId + '") >';
                        strhtml += '<span id = "paperTitle' + configId + '" >' + strShareName + '</span>';
                        strhtml += ' </div></a>';
                        strhtml += '<select id="ddlShardId' + configId + '" name ="ddlShardId" class="form-control" style = "width:170px;display:none;" onchange=BtnShardName_Click("' + configId + '",this.options[this.options.selectedIndex].value)>';
                        //for循环共享对象
                        for (var k = 0; k < arrgs_ShareObjLst.length; k++) {
                            //如果过滤的shardId 和循环的id匹配，那么则默认显示当前循环的Id
                            //if (gs_ShareObj.shareId == arrgs_ShareObjLst[k].shareId) {
                            //    //strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + ' onclick="ShardIdfunc(' + arrgs_ShareObjLst[k].shareId + ',' + configId + ')" >' + arrgs_ShareObjLst[k].shareName + '</option>';
                            //    strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + '>' + arrgs_ShareObjLst[k].shareName + '</option>';
                            //    // $('#ddlShardId' + configId + ').find("option[value=' + arrgs_ShareObjLst[k].shareId + ']").prop("selected",true);
                            //    // $('#selectId' + configId + ' option[value=' + arrgs_ShareObjLst[k].shareId + ']').prop("selected", true);
                            //}
                            //else {
                            //    strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + '>' + arrgs_ShareObjLst[k].shareName + '</option>';
                            //}
                            strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + '>' + arrgs_ShareObjLst[k].shareName + '</option>';
                            //  strhtml += '<dd><a onclick=BtnShardName_Click("' + arrgs_ShareObjLst[k].shareId + '","' + configId + '","'+arrgs_ShareObjLst[k].shareName+'")> ' + arrgs_ShareObjLst[k].shareName + '</a></dd>';
                        }
                        strhtml += '</li></ul>';
                        //strhtml += '</dl></li></ul>';
                        //strhtml += '</select></td>';
                        //  $('#selectId' + configId + ').prop(selectedIndex', k);
                    }
                    // strhtml += '<td>' + strShareId + '</td>';
                    //strhtml += '<td>' + strShareName + '</td>';
                    strhtml += '<td>' + strDataTableId + '</td>';
                    strhtml += '<td>' + strDataTable + '</td>';
                    //获取用户名；
                    var arrUserName = arrUsers.filter(x => x.userId == strUpdUser); //专家观点；
                    for (var j = 0; j < arrUserName.length; j++) {
                        strhtml += '<td>' + arrUserName[j].userName + '</td>';
                        break;
                    }
                    strhtml += '<td>' + strUpdDate + '</td>';
                    strhtml += '</tr>';
                }
                //拼接；
                $("#tbList1").html(strhtml);
                console.log("完成BindGv_gs_UserConfig!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //点击下拉框
        async BtnShardName_Click(strkey, strShardId) {
            //$("#hidshardIdId").val(strShardId);
            $("#hidConfigId").val(strkey);
            //通过ID查询得到修改实体数据；
            const responseObj1 = await (0, clsgs_ShareWApi_js_1.gs_Share_GetObjByShareIdAsync)(strShardId);
            var objgs_ShareEN = responseObj1;
            if (objgs_ShareEN != null) {
                $("#paperTitle" + strkey + "").val(objgs_ShareEN.shareName);
            }
            //通过ID查询得到修改实体数据；
            const responseObj = await (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_GetObjByConfigIdAsync)(Number(strkey));
            var objgs_UserConfigEN = responseObj;
            if (objgs_UserConfigEN != null) {
                //获取下拉框选中的值
                var objgs_UserConfigUpdEN = new clsgs_UserConfigEN_js_1.clsgs_UserConfigEN();
                objgs_UserConfigUpdEN.configId = Number(strkey);
                objgs_UserConfigUpdEN.SetShareId(strShardId);
                objgs_UserConfigUpdEN.sf_UpdFldSetStr = objgs_UserConfigUpdEN.updFldString; //设置哪些字段被修改(脏字段)
                const responseText3 = await (0, clsgs_UserConfigWApi_js_1.gs_UserConfig_UpdateRecordAsync)(objgs_UserConfigUpdEN);
                var returnBool = !!responseText3;
                if (returnBool == true) {
                    var strInfo = '操作成功';
                    alert(strInfo);
                    //再次绑定
                    const responseBind = await this.BindGv_gs_UserConfig();
                    return true;
                }
                else {
                    var strInfo = '操作失败';
                    alert(strInfo);
                    return false;
                }
            }
        }
        /*
    * 设置当前页序号
    */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
     * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvgs_UserConfigBy(value) {
            $("#hidSortvgs_UserConfigBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_UserConfigBy() {
            return $("#hidSortvgs_UserConfigBy").val();
        }
    }
    exports.gs_UserConfigEx = gs_UserConfigEx;
});

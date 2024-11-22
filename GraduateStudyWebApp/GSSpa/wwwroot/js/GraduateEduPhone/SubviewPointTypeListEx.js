(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../ParameterTable/SubViewpointType_QUDI_TS.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSubViewpointTypeWApiEx.js", "../TS/PubFun/clsPager.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.WapiSubviewPointTypeListEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SubViewpointType_QUDI_TS
    表名:SubViewpointType(01120533)
    生成代码版本:2019.11.22.1
    生成日期:2019/12/01 21:01:29
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsSubViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const SubViewpointType_QUDI_TS_js_1 = require("../ParameterTable/SubViewpointType_QUDI_TS.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsSubViewpointTypeWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSubViewpointTypeWApiEx.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    /* SubViewpointType_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class WapiSubviewPointTypeListEx extends SubViewpointType_QUDI_TS_js_1.SubViewpointType_QUDI_TS {
        constructor() {
            super(...arguments);
            //public mstrListDiv: string = "divDataLst";
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
            this.arrSubViewpointTypeObjLstCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
     */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if ($("#hidUserId").val() != "") {
                    //1、为下拉框设置数据源,绑定列表数据
                    this.hidSortSubViewpointTypeBy = "subViewpointTypeId Asc";
                    //var strWhereCond = this.CombinevThesisCondition();
                    //const responseText = await vThesis_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_SubViewpointType();
                    //把论文ID存入session
                    var strThesisId = $("#hidThesisId").val();
                    const bolIsSuccess = this.SetSessionAsync("ThesisId", strThesisId);
                    //var strThesisId = $("#hidThesisId").val();
                    //var strJson = JSON.stringify(strThesisId);
                    //console.log(strJson);
                    //const bolIsSuccess = this.SetSessionAsync("ThesisId", strJson);
                }
                else {
                    window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_SubViewpointType() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombineSubViewpointTypeCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrSubViewpointTypeObjLst = [];
            try {
                const responseRecCount = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortSubViewpointTypeBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrSubViewpointTypeObjLst = jsonData;
                    this.arrSubViewpointTypeObjLstCount = arrSubViewpointTypeObjLst.length;
                    for (var i = 0; i < arrSubViewpointTypeObjLst.length; i++) {
                        $("#SubviewPointType").append('<li id="linumbers" class="ui-li-divider ui-bar-inherit ui-li-has-count ui-first-child"><a href="../GraduateEduEx/SubviewPointList?subViewpointTypeId=' + arrSubViewpointTypeObjLst[i].subViewpointTypeId + '" rel="external" class="ui-btn"><strong>' + arrSubViewpointTypeObjLst[i].subViewpointTypeName + '</strong></a></li>');
                    }
                    //var strThesisId = $("#hidThesisId").val();
                    //const bolIsSuccess = this.SetSessionAsync("ThesisId", strThesisId);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrSubViewpointTypeObjLst.length == 0) {
                var strMsg = `当前记录数为空！`;
                alert(strMsg);
                return;
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineSubViewpointTypeCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.SubViewpointTypeName_q != "") {
                //    strWhereCond += ` And ${clsSubViewpointTypeEN.con_SubViewpointTypeName} like '% ${this.SubViewpointTypeName_q}%'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSubViewpointTypeCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //添加数据事件
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                //这是一个单表的插入的代码,由于逻辑层太简单,
                //就把逻辑层合并到控制层,
                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        //HideDialog();
                        this.Clear();
                        window.location.href = "#pageOne";
                        //去掉主页动态标签防止缓存问题；
                        $("#SubviewPointType li").not(":first").remove();
                        this.BindGv_SubViewpointType();
                    }
                });
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objSubViewpointTypeEN = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN();
            this.PutDataToSubViewpointTypeClass(objSubViewpointTypeEN);
            try {
                //const responseText = await SubViewpointType_IsExistAsync(objSubViewpointTypeEN.subViewpointTypeId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objSubViewpointTypeEN.subViewpointTypeId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                //const responseText2 = await SubViewpointType_AddNewRecordAsync(objSubViewpointTypeEN);
                const responseText2 = await clsSubViewpointTypeWApiEx_js_1.clsSubViewpointTypeWApiEx.AddNewRecordAsyncEx(objSubViewpointTypeEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjSubViewpointTypeEN">数据传输的目的类对象</param>
      */
        PutDataToSubViewpointTypeClass(pobjSubViewpointTypeEN) {
            //pobjSubViewpointTypeEN.subViewpointTypeId = this.subViewpointTypeId;// 类型Id
            pobjSubViewpointTypeEN.subViewpointTypeName = this.subViewpointTypeName; // 类型名称
            pobjSubViewpointTypeEN.orderNum = this.arrSubViewpointTypeObjLstCount++; // 序号
            pobjSubViewpointTypeEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjSubViewpointTypeEN.updUserId = $("#hidUserId").val(); // 修改用户Id
            pobjSubViewpointTypeEN.memo = this.memo; // 备注
        }
        /*
    * 获取年月日
    */
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        /*
       * 序号
      */
        set orderNum(value) {
            $("#txtOrderNum").val(value);
        }
        /*
        * 序号
       */
        get orderNum() {
            return $("#txtOrderNum").val();
        }
        // /*
        // * 类型Id
        //*/
        // public set subViewpointTypeId(value: string) {
        //     $("#txtSubViewpointTypeId").val(value);
        // }
        // /*
        // * 类型Id
        //*/
        // public get subViewpointTypeId(): string {
        //     return $("#txtSubViewpointTypeId").val();
        // }
        /*
        * 类型名称
       */
        set subViewpointTypeName(value) {
            $("#txtSubViewpointTypeName").val(value);
        }
        /*
        * 类型名称
       */
        get subViewpointTypeName() {
            return $("#txtSubViewpointTypeName").val();
        }
        /*
         设置Session
         <param name = "Key">关键字</param>
         <param name = "Value">值</param>
        */
        static SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        //$('#myValue').val(text);
                        var strKey = data.key;
                        var strValue = data.value;
                        //$('#myKey').html(strKey);
                        //$('#myValue').html(strValue);
                        console.log(strKey + strValue);
                    }
                });
            });
        }
        /*
    获取Session 关键字的值
    <param name = "Key">关键字</param>
    <return>值</return>
    */
        static GetSessionAsync(Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: "/Session/GetString",
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key
                    },
                    success: function (data) {
                        var strValue = data.value;
                        console.log(Key + strValue);
                        resolve(data);
                    },
                    error: (e) => {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        }
    }
    exports.WapiSubviewPointTypeListEx = WapiSubviewPointTypeListEx;
});

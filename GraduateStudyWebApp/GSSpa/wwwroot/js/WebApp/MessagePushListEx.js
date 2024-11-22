(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/NewsAnnouncement/clsvMessagePushEN.js", "../TS/L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js", "../TS/PubFun/clsOperateList2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MessagePushListEx = void 0;
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsvMessagePushEN_js_1 = require("../TS/L0_Entity/NewsAnnouncement/clsvMessagePushEN.js");
    const clsvMessagePushWApi_js_1 = require("../TS/L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    /* MessagePush_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class MessagePushListEx extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        async Page_Load() {
            try {
                var strUserInfo_Hid = $("#hidUserInfo").val();
                if (strUserInfo_Hid != "") {
                    const gvResult = await this.BindGv_vMessagePush();
                }
                else {
                    window.location.href = "/ExamLibWebApp/WebApp/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 获取消息数据列表
            (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
          */
        async BindGv_vMessagePush() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevMessagePushCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvMessagePushObjLst = [];
            try {
                const responseRecCount = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: "updDate Desc",
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvMessagePushObjLst = jsonData;
                    for (var i = 0; i < arrvMessagePushObjLst.length; i++) {
                        $("#PrjList").append('<li class="ui-li-has-alt ui-first-child"><p style="width: 100%;height: 90%;padding:20px 20px 0px 20px;">' + arrvMessagePushObjLst[i].updDate + '</p><div style="width: 100%;height: 90%;padding:20px 20px 0px 20px;"><h6 class="jxz-title">' + arrvMessagePushObjLst[i].messageContent + '</h6></div></li>');
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvMessagePushObjLst.length == 0) {
                var strMsg = `根据条件获取的对象列表数为空！`;
                alert(strMsg);
                return;
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevMessagePushCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId_Hid = $("#hidUserId").val();
            try {
                if (strUserId_Hid != "") {
                    strWhereCond += ` And ${clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId} in ('00000001','00000002') And isAllpush='1'`;
                }
                //if (this.ReceivePeople_q != "") {
                //    strWhereCond += ` And ${clsvMessagePushEN.con_ReceivePeople} like '% ${this.ReceivePeople_q}%'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineMessagePushCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
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
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log(strKey + strValue);
                    }
                });
            });
        }
        /*
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortvMessagePushBy(value) {
            $("#hidSortvMessagePushBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvMessagePushBy() {
            return $("#hidSortvMessagePushBy").val();
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
    exports.MessagePushListEx = MessagePushListEx;
});

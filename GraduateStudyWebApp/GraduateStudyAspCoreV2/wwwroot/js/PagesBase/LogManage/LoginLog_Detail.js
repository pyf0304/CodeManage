(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LoginLog_Detail = void 0;
    /**
    * 类名:LoginLog_Detail(界面:LoginLogCRUD)
    * 表名:LoginLog(01120357)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:37:35
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:日志管理(LogManage)
    * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsLoginLogWApi_js_1 = require("../../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /* LoginLog_Detail 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
   */
    class LoginLog_Detail {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadDetailRegion = false; //记录是否导入编辑区的变量
            this.divName4Detail = "divDetail"; //编辑区的Id
            this.iShowList = objShowList;
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Detail(divName4Detail) {
            const strThisFuncName = this.AddDPV_Detail.name;
            const strUrl = "./LoginLog_Detail/";
            console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Detail).html(data);
                        resolve(true);
                        //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
                        //clsDetailObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        /**
         显示对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
        **/
        ShowDialog_LoginLog(strOp) {
            const strThisFuncName = this.ShowDialog_LoginLog.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_LoginLog");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "h4", "lblDialogTitle_LoginLog");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_LoginLog').html('添加记录');
                //LoginLog_DetailEx.GetMaxStrId('#txtLoginLogId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_LoginLog').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_LoginLog').hide();
                $('#lblDialogTitle_LoginLog').html('详细信息');
            }
            ShowDialog('#divDetailDialog_LoginLog');
        }
        /**
         隐藏对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_LoginLog() {
            const strThisFuncName = this.HideDialog_LoginLog.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_LoginLog");
            HideDialog('#divDetailDialog_LoginLog');
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
            const strThisFuncName = this.btnDetailRecordInTab_Click.name;
            this.opType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                const lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("详细信息记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        async DetailRecord(lngLoginLogId) {
            const strThisFuncName = this.DetailRecord.name;
            this.btnSubmit_d_LoginLog = "";
            this.btnCancel_d_LoginLog = "关闭";
            try {
                const objLoginLogEN = await (0, clsLoginLogWApi_js_1.LoginLog_GetObjByLoginLogIdAsync)(lngLoginLogId);
                if (objLoginLogEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.ShowDetailDataFromLoginLogClass(objLoginLogEN);
                console.log("完成DetailRecord!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("显示详细信息不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecord_Click)
       */
        async btnDetailRecord_Click(strKeyId) {
            const strThisFuncName = this.btnDetailRecord_Click.name;
            this.opType = "Detail";
            if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                const strMsg = "需要显示详细信息记录的关键字为空，请检查！";
                console.error(strMsg);
                alert(strMsg);
            }
            if (this.bolIsLoadDetailRegion == false) //
             {
                const responseBool = await this.AddDPV_Detail(this.divName4Detail);
                // 为编辑区绑定下拉框
                //const conBindDdl = await this.BindDdl4DetailRegion();
                this.bolIsLoadDetailRegion = true; //
                const lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
                this.ShowDialog_LoginLog('Detail');
            }
            else {
                const lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
                this.ShowDialog_LoginLog('Detail');
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
         <param name = "pobjLoginLogEN">表实体类对象</param>
       */
        ShowDetailDataFromLoginLogClass(pobjLoginLogEN) {
            const strThisFuncName = this.ShowDetailDataFromLoginLogClass.name;
            this.loginLogNumber_d = pobjLoginLogEN.loginLogNumber; // LoginLogNumber
            this.loginIP_d = pobjLoginLogEN.loginIP; // LoginIP
            this.failReason_d = pobjLoginLogEN.failReason; // FailReason
            this.loginResult_d = pobjLoginLogEN.loginResult; // LoginResult
            this.loginTime_d = pobjLoginLogEN.loginTime; // LoginTime
            this.loginUserId_d = pobjLoginLogEN.loginUserId; // LoginUserId
            this.onlineTime_d = pobjLoginLogEN.onlineTime; // OnlineTime
            this.outTime_d = pobjLoginLogEN.outTime; // OutTime
            this.memo_d = pobjLoginLogEN.memo; // 备注
        }
        /**
        * 设置取消按钮的标题(Used In DetailRecord())
        **/
        set btnCancel_d_LoginLog(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnCancel_d_LoginLog", value);
        }
        /**
        * 设置确定按钮的标题(Used In DetailRecord())
        **/
        set btnSubmit_d_LoginLog(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnSubmit_d_LoginLog", value);
        }
        /**
        * FailReason (Used In ShowDetailDataFromClass())
        **/
        set failReason_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblFailReason_d", value);
        }
        /**
        * LoginIP (Used In ShowDetailDataFromClass())
        **/
        set loginIP_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLoginIP_d", value);
        }
        /**
        * LoginLogNumber (Used In ShowDetailDataFromClass())
        **/
        set loginLogNumber_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLoginLogNumber_d", value);
        }
        /**
        * LoginResult (Used In ShowDetailDataFromClass())
        **/
        set loginResult_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLoginResult_d", value);
        }
        /**
        * LoginTime (Used In ShowDetailDataFromClass())
        **/
        set loginTime_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLoginTime_d", value);
        }
        /**
        * LoginUserId (Used In ShowDetailDataFromClass())
        **/
        set loginUserId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLoginUserId_d", value);
        }
        /**
        * 备注 (Used In ShowDetailDataFromClass())
        **/
        set memo_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMemo_d", value);
        }
        /**
        * OnlineTime (Used In ShowDetailDataFromClass())
        **/
        set onlineTime_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblOnlineTime_d", value);
        }
        /**
        * OutTime (Used In ShowDetailDataFromClass())
        **/
        set outTime_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblOutTime_d", value);
        }
    }
    exports.LoginLog_Detail = LoginLog_Detail;
});

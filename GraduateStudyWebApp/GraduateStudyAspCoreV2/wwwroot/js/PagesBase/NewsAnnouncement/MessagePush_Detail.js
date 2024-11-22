(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/NewsAnnouncement/clsMessagePushWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MessagePush_Detail = void 0;
    /**
    * 类名:MessagePush_Detail(界面:MessagePushCRUD)
    * 表名:MessagePush(01120280)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:40:36
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:新闻公告(NewsAnnouncement)
    * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsMessagePushWApi_js_1 = require("../../TS/L3_ForWApi/NewsAnnouncement/clsMessagePushWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /* MessagePush_Detail 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
   */
    class MessagePush_Detail {
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
            const strUrl = "./MessagePush_Detail/";
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
        ShowDialog_MessagePush(strOp) {
            const strThisFuncName = this.ShowDialog_MessagePush.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_MessagePush");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "h4", "lblDialogTitle_MessagePush");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_MessagePush').html('添加记录');
                //MessagePush_DetailEx.GetMaxStrId('#txtMessagePushId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_MessagePush').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_MessagePush').hide();
                $('#lblDialogTitle_MessagePush').html('详细信息');
            }
            ShowDialog('#divDetailDialog_MessagePush');
        }
        /**
         隐藏对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_MessagePush() {
            const strThisFuncName = this.HideDialog_MessagePush.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_MessagePush");
            HideDialog('#divDetailDialog_MessagePush');
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
                this.DetailRecord(strKeyId);
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
        async DetailRecord(strMessagePushId) {
            const strThisFuncName = this.DetailRecord.name;
            this.btnSubmit_d_MessagePush = "";
            this.btnCancel_d_MessagePush = "关闭";
            try {
                const objMessagePushEN = await (0, clsMessagePushWApi_js_1.MessagePush_GetObjByMessagePushIdAsync)(strMessagePushId);
                if (objMessagePushEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.ShowDetailDataFromMessagePushClass(objMessagePushEN);
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
                this.DetailRecord(strKeyId);
                this.ShowDialog_MessagePush('Detail');
            }
            else {
                this.DetailRecord(strKeyId);
                this.ShowDialog_MessagePush('Detail');
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
         <param name = "pobjMessagePushEN">表实体类对象</param>
       */
        ShowDetailDataFromMessagePushClass(pobjMessagePushEN) {
            const strThisFuncName = this.ShowDetailDataFromMessagePushClass.name;
            this.messagePushId_d = pobjMessagePushEN.messagePushId; // 消息Id
            this.messagePushNumber_d = pobjMessagePushEN.messagePushNumber; // 消息编号
            this.messageTitle_d = pobjMessagePushEN.messageTitle; // 消息标题
            this.messageContent_d = pobjMessagePushEN.messageContent; // 消息内容
            this.receivePeople_d = pobjMessagePushEN.receivePeople; // 接收人员
            this.messageTypeId_d = pobjMessagePushEN.messageTypeId; // 消息类型Id
            this.isAllpush_d = pobjMessagePushEN.isAllpush; // 是否全体推送
            this.isReceive_d = pobjMessagePushEN.isReceive; // 是否接收
            this.clientVersionTypeId_d = pobjMessagePushEN.clientVersionTypeId; // 客户端版本类型Id
            this.memo_d = pobjMessagePushEN.memo; // 备注
        }
        /**
        * 设置取消按钮的标题(Used In DetailRecord())
        **/
        set btnCancel_d_MessagePush(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnCancel_d_MessagePush", value);
        }
        /**
        * 设置确定按钮的标题(Used In DetailRecord())
        **/
        set btnSubmit_d_MessagePush(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnSubmit_d_MessagePush", value);
        }
        /**
        * 客户端版本类型Id (Used In ShowDetailDataFromClass())
        **/
        set clientVersionTypeId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblClientVersionTypeId_d", value);
        }
        /**
        * 是否全体推送 (Used In ShowDetailDataFromClass())
        **/
        set isAllpush_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsAllpush_d", value.toString());
        }
        /**
        * 是否接收 (Used In ShowDetailDataFromClass())
        **/
        set isReceive_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsReceive_d", value.toString());
        }
        /**
        * 备注 (Used In ShowDetailDataFromClass())
        **/
        set memo_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMemo_d", value);
        }
        /**
        * 消息内容 (Used In ShowDetailDataFromClass())
        **/
        set messageContent_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMessageContent_d", value);
        }
        /**
        * 消息Id (Used In ShowDetailDataFromClass())
        **/
        set messagePushId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMessagePushId_d", value);
        }
        /**
        * 消息编号 (Used In ShowDetailDataFromClass())
        **/
        set messagePushNumber_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMessagePushNumber_d", value);
        }
        /**
        * 消息标题 (Used In ShowDetailDataFromClass())
        **/
        set messageTitle_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMessageTitle_d", value);
        }
        /**
        * 消息类型Id (Used In ShowDetailDataFromClass())
        **/
        set messageTypeId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMessageTypeId_d", value);
        }
        /**
        * 接收人员 (Used In ShowDetailDataFromClass())
        **/
        set receivePeople_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblReceivePeople_d", value);
        }
    }
    exports.MessagePush_Detail = MessagePush_Detail;
});

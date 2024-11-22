(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./DiscussionType_QUDI_TS.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "../TS/L3_ForWApi/ParameterTable/clsDiscussionTypeWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.DiscussionType_QUDI_TSEx = void 0;
    const DiscussionType_QUDI_TS_js_1 = require("./DiscussionType_QUDI_TS.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const clsDiscussionTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsDiscussionTypeWApi.js");
    /* DiscussionType_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class DiscussionType_QUDI_TSEx extends DiscussionType_QUDI_TS_js_1.DiscussionType_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortDiscussionTypeBy: string = "discussionTypeId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
             (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
           */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //1、为下拉框设置数据源,绑定列表数据
                    this.hidSortDiscussionTypeBy = "discussionTypeId Asc";
                    var strWhereCond = this.CombineDiscussionTypeCondition();
                    const responseText = await (0, clsDiscussionTypeWApi_js_1.DiscussionType_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.RecCount = jsonData;
                    });
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_DiscussionType();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            var returnBool2 = jsonData;
                            if (clsString2_js_1.clsString.IsNullOrEmpty(returnBool2) == false) {
                                HideDialog();
                                this.BindGv_DiscussionType();
                            }
                        });
                        // if (this.OpType == "AddWithMaxId") {}
                        //else {
                        //    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        //        var returnBool: boolean = jsonData;
                        //        if (returnBool == true) {
                        //            HideDialog();
                        //            this.BindGv_DiscussionType();
                        //        }
                        //    });
                        //}
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_DiscussionType();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjDiscussionTypeEN">数据传输的目的类对象</param>
       */
        PutDataToDiscussionTypeClass(pobjDiscussionTypeEN) {
            pobjDiscussionTypeEN.discussionTypeName = this.discussionTypeName; // 讨论类型名称
            pobjDiscussionTypeEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjDiscussionTypeEN.updUser = $("#hidUserId").val();
            ; // 修改人
            pobjDiscussionTypeEN.memo = this.memo; // 备注
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
    }
    exports.DiscussionType_QUDI_TSEx = DiscussionType_QUDI_TSEx;
});

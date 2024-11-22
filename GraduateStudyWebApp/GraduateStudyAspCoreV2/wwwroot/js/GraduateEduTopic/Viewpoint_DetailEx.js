(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/Viewpoint_Detail.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/PubFun/clsString.js", "./ViewpointCRUDEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Viewpoint_DetailEx = void 0;
    /**
    * 类名:Viewpoint_DetailEx(界面:ViewpointCRUD)
    * 表名:Viewpoint(01120542)
    * 版本:2023.01.07.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/08 15:25:49
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
    * 编程语言:TypeScript
    **/
    const Viewpoint_Detail_js_1 = require("../PagesBase/GraduateEduTopic/Viewpoint_Detail.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const ViewpointCRUDEx_js_1 = require("./ViewpointCRUDEx.js");
    /* Viewpoint_DetailEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
    */
    class Viewpoint_DetailEx extends Viewpoint_Detail_js_1.Viewpoint_Detail {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
        **/
        btnDetail_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnDetail_Click.name;
            const objViewpointCRUD = new ViewpointCRUDEx_js_1.ViewpointCRUDEx();
            const objPage = new Viewpoint_DetailEx(objViewpointCRUD);
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ////objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(Viewpoint_DetailExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 根据关键字获取相应的记录的对象
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
      <param name = "sender">参数列表</param>
    */
        async DetailRecord(strViewpointId) {
            const strThisFuncName = this.DetailRecord.name;
            this.keyId = strViewpointId;
            try {
                const objvViewpointEN = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjByViewpointIdAsync)(strViewpointId);
                if (objvViewpointEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                //数据显示
                $("#txtViewpointNameDetail").html(objvViewpointEN.viewpointName);
                $("#txtViewpointTypeNameDetail").html(objvViewpointEN.viewpointTypeName);
                $("#txtViewpointContentDetail").html(objvViewpointEN.viewpointContent);
                $("#txtReasonDetail").html(objvViewpointEN.reason);
                $("#txtSourceDetail").html(objvViewpointEN.source);
                $("#txtMemoDetail").html(objvViewpointEN.memo);
            }
            catch (e) {
                console.error(e);
                var strMsg = `当前无数据获取失败,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 在数据表里修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
    */
        async btnDetailRecordInTab_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要的记录！");
                return "";
            }
            this.DetailRecord(strKeyId);
        }
    }
    exports.Viewpoint_DetailEx = Viewpoint_DetailEx;
});

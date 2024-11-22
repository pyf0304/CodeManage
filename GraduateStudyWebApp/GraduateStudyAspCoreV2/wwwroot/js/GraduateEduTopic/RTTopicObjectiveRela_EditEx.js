(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/RTTopicObjectiveRela_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTTopicObjectiveRela_EditEx = void 0;
    /**
    * 类名:RTTopicObjectiveRela_EditEx(界面:RTTopicObjectiveRelaCRUD)
    * 表名:RTTopicObjectiveRela(01120615)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:44:12
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const RTTopicObjectiveRela_Edit_js_1 = require("../PagesBase/GraduateEduTopic/RTTopicObjectiveRela_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsRTTopicObjectiveRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js");
    const clsTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsRTTopicObjectiveRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js");
    const clsTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* RTTopicObjectiveRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class RTTopicObjectiveRela_EditEx extends RTTopicObjectiveRela_Edit_js_1.RTTopicObjectiveRela_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = RTTopicObjectiveRela_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(RTTopicObjectiveRela_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            var strObjectiveId = $("#hidObjectiveId").val();
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTTopicObjectiveRelaEN = new clsRTTopicObjectiveRelaEN_js_1.clsRTTopicObjectiveRelaEN();
            this.PutDataToRTTopicObjectiveRelaClass(objRTTopicObjectiveRelaEN);
            try {
                //同一主题 同一客观事实 数据 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And topicObjectiveId = '" + strObjectiveId + "'";
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsRTTopicObjectiveRelaWApi_js_1.RTTopicObjectiveRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一用户不能重复添加同一个客观事实数据！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText = await (0, clsRTTopicObjectiveRelaWApi_js_1.RTTopicObjectiveRela_AddNewRecordAsync)(objRTTopicObjectiveRelaEN);
                    var returnBool = !!responseText;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult46').val(strInfo);
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and topicObjectiveId=" + strObjectiveId;
                        var intCitationCount = await (0, clsRTTopicObjectiveRelaWApi_js_1.RTTopicObjectiveRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                        objTopicObjectiveEN.SetTopicObjectiveId(strObjectiveId);
                        objTopicObjectiveEN.SetCitationCount(intCitationCount);
                        objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                        }
                        const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                            }
                            else {
                                var strInfo = `操作不成功!`;
                                alert(strInfo);
                                console.log("操作不成功");
                            }
                        });
                        //显示信息框
                        alert(strInfo);
                        HideDialogEight();
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
                        $('#lblResult46').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                }
                return responseText; //一定要有一个返回值，否则会出错！
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
     <param name = "pobjRTTopicObjectiveRelaEN">数据传输的目的类对象</param>
    */
        async PutDataToRTTopicObjectiveRelaClass(pobjRTTopicObjectiveRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strObjectiveId = $("#hidObjectiveId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            pobjRTTopicObjectiveRelaEN.Setid_CurrEduCls(strId_CurrEduCls);
            pobjRTTopicObjectiveRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTTopicObjectiveRelaEN.SetTopicObjectiveId(strObjectiveId); // 客观Id
            pobjRTTopicObjectiveRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTTopicObjectiveRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTTopicObjectiveRelaEN.SetMemo(this.memo); // 备注
            pobjRTTopicObjectiveRelaEN.SetClassificationId("0000000000"); // 分类为000000
        }
        //确定选择的客观观点 并添加到关系表中
        btnOkObjectiveInTab_Click(strkeyId) {
            //存放Id
            $("#hidObjectiveId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave();
        }
    }
    exports.RTTopicObjectiveRela_EditEx = RTTopicObjectiveRela_EditEx;
});

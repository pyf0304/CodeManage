(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/RTUserRela_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTUserRela_EditEx = void 0;
    /**
    * 类名:RTUserRela_EditEx(界面:RTUserRelaCRUD)
    * 表名:RTUserRela(01120582)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:44:36
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const RTUserRela_Edit_js_1 = require("../PagesBase/GraduateEduTopic/RTUserRela_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsTopicUserRoleEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js");
    const clsRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js");
    const clsgs_ColorWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    /* RTUserRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class RTUserRela_EditEx extends RTUserRela_Edit_js_1.RTUserRela_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = RTUserRela_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(RTUserRela_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 添加主题同时把用户作为组长存放到主题用户关系表*/
        async AddNewTopicAndRecordSaveUserRela(strTopicId) {
            RTUserRela_EditEx.TopicId_Static = strTopicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTUserRelaEN = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
            await this.PutDataToRTUserRelaClassWhere(objRTUserRelaEN, strTopicId);
            //获取缓存色码表；
            var arrGs_ColorObjLst = [];
            try {
                // 同一主题 同一用户 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
                const bolIsExist = await (0, clsRTUserRelaWApi_js_1.RTUserRela_IsExistRecordAsync)(strWhere);
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个用户！`;
                    //alert(strMsg);
                    console.log("同一主题不能重复添加同一个用户！");
                    return false;
                    // return responseText;//一定要有一个返回值，否则会出错！
                }
                const returnBool = await (0, clsRTUserRelaWApi_js_1.RTUserRela_AddNewRecordAsync)(objRTUserRelaEN);
                if (returnBool == true) {
                    (0, clsRTUserRelaWApi_js_1.RTUserRela_ReFreshCache)(strTopicId);
                    var strInfo = `添加成功!`;
                    //隐藏用户框
                    //HideDialogFour();
                    //显示信息框
                    //alert(strInfo);
                    const responseText3 = await this.btnReOrder_Click();
                    //获取色码数据
                    const arrGs_ColorObjLst = await (0, clsgs_ColorWApi_js_1.gs_Color_GetObjLst_Cache)();
                    //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
                    var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
                    //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
                    const objRTUserRelaEN = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetFirstObjAsync)(strWhereUserRela);
                    if (objRTUserRelaEN != null) {
                        //得到用户排序号
                        var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
                        if (Objgs_Color != null) {
                            //得到色码
                            var objUpdateRTUserRelaEN = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
                            objUpdateRTUserRelaEN.SetmId(objRTUserRelaEN.mId);
                            objUpdateRTUserRelaEN.SetColorId(Objgs_Color.colorId);
                            objUpdateRTUserRelaEN.SetUserBgColor(Objgs_Color.colorCode); //用户背景色码；
                            objUpdateRTUserRelaEN.sf_UpdFldSetStr = objUpdateRTUserRelaEN.updFldString; //设置哪些字段被修改(脏字段)
                            const responseText = (0, clsRTUserRelaWApi_js_1.RTUserRela_UpdateRecordAsync)(objUpdateRTUserRelaEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    return true;
                                }
                                else {
                                    var strInfo = `修改用户色码不成功!`;
                                    alert(strInfo);
                                    console.log("修改用户色码不成功");
                                    return false;
                                }
                            });
                        }
                    }
                    return true;
                    //this.BindGv_vRTUserRela();
                    ////主题Id
                    //window.location.href = "../GraduateEdu/WApiRTUserRela_QUDI_TS?TopicRelaId='01'";
                }
                else {
                    var strInfo = `添加不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    return false;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加主题用户关系不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
       */
        PutDataToRTUserRelaClassWhere(pobjRTUserRelaEN, strTopicId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTUserRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTUserRelaEN.SetUserId(strUserId); // 用户ID
            pobjRTUserRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTUserRelaEN.SetTopicUserRoleId(clsTopicUserRoleEN_js_1.enumTopicUserRole.TeamLeader_0002); //组成
            pobjRTUserRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTUserRelaEN.SetOrderNum(30);
            pobjRTUserRelaEN.SetColorId(""); //获取不同色码
            pobjRTUserRelaEN.SetMemo(""); // 备注
        }
        /*
    重序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    */
        async btnReOrder_Click() {
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "topicId": RTUserRela_EditEx.TopicId_Static,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsRTUserRelaWApi_js_1.RTUserRela_ReOrderAsync)(objOrderByData);
                (0, clsRTUserRelaWApi_js_1.RTUserRela_ReFreshCache)(RTUserRela_EditEx.TopicId_Static);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            //绑定主题用户关系；
            //this.BindGv_vRTUserRela();
        }
    }
    exports.RTUserRela_EditEx = RTUserRela_EditEx;
    RTUserRela_EditEx.TopicId_Static = "";
});

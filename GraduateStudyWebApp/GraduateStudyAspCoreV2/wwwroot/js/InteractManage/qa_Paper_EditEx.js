(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Pub_PaperList.js", "../PagesBase/InteractManage/qa_Paper_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/InteractManage/clsqa_PaperEN.js", "../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_Paper_EditEx = void 0;
    /**
    * 类名:qa_Paper_EditEx(界面:qa_PaperCRUD)
    * 表名:qa_Paper(01120643)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/08 01:11:37
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:互动管理(InteractManage)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const Pub_PaperList_js_1 = require("../GraduateEduPublicPage/Pub_PaperList.js");
    const qa_Paper_Edit_js_1 = require("../PagesBase/InteractManage/qa_Paper_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsqa_PaperEN_js_1 = require("../TS/L0_Entity/InteractManage/clsqa_PaperEN.js");
    const clsqa_PaperWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* qa_Paper_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class qa_Paper_EditEx extends qa_Paper_Edit_js_1.qa_Paper_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = qa_Paper_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(qa_Paper_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        async btnAddNewRecordWithMaxId_Click() {
            this.opType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    console.log('开始添加AddDPV_Edit界面');
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    console.log('结束AddDPV_Edit界面');
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    console.log('结束BindDdl4EditRegion绑定');
                    ShowDialog('Add');
                    //获取分享Id
                    const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("11", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    var strShareId = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                    await objPage_Paper.Page_Load();
                    //await objPage_Paper.BindGv_vPaper();
                    this.bolIsLoadEditRegion = true; //
                }
                else {
                    ShowDialog('Add');
                    console.log('开始绑定BindGv_vPaper');
                    const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                    await objPage_Paper.Page_Load();
                    //await objPage_Paper.BindGv_vPaper();
                    console.log('结束绑定BindGv_vPaper');
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
    */
        async AddNewRecordWithMaxIdSave() {
            var objqa_PaperEN = new clsqa_PaperEN_js_1.clsqa_PaperEN();
            this.PutDataToqa_PaperClass(objqa_PaperEN);
            try {
                const returnKeyId = await (0, clsqa_PaperWApi_js_1.qa_Paper_AddNewRecordWithMaxIdAsync)(objqa_PaperEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return returnKeyId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return "";
            }
            //return true;//一定要有一个返回值，否则会出错！
        }
        async PutDataToqa_PaperClass(pobjqa_PaperEN) {
            pobjqa_PaperEN.SetPaperId($("#hidPaperId").val()); // 论文Id
            pobjqa_PaperEN.SetIsPublic(true); // 是否公开
            pobjqa_PaperEN.SetIsSubmit(false); // 是否公开
            pobjqa_PaperEN.SetQuestionsCount(0);
            pobjqa_PaperEN.SetAnswerCount(0);
            pobjqa_PaperEN.SetShareId(this.shareId);
            pobjqa_PaperEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjqa_PaperEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改日期
            pobjqa_PaperEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班id
            pobjqa_PaperEN.SetMemo(this.memo); // 备注
        }
        //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////
        //确定选择的论文 并添加到关系表中
        async btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            //判断是否选择分配权限；没选择给出提示；
            //需要提示选择角色
            if (this.shareId != "" && this.shareId != "0") {
                const returnKeyId = await this.AddNewRecordWithMaxIdSave();
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    HideDialog();
                    this.iShowList.BindGv(clsqa_PaperEN_js_1.clsqa_PaperEN._CurrTabName, returnKeyId);
                }
            }
            else {
                var strInfo = `请选择分配权限下拉框!`;
                //显示信息框
                alert(strInfo);
                return;
            }
        }
        /*
    * 分享
    */
        set shareId(value) {
            $("#ddlShareId").val(value);
        }
        /*
        * 分享
        */
        get shareId() {
            return $("#ddlShareId").val();
        }
    }
    exports.qa_Paper_EditEx = qa_Paper_EditEx;
});

(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vqa_Answer_Detail = void 0;
    /**
    * 类名:vqa_Answer_Detail(界面:qa_AnswerCRUD)
    * 表名:qa_Answer(01120641)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:40:53
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:互动管理(InteractManage)
    * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsvqa_AnswerWApi_js_1 = require("../../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /* vqa_Answer_Detail 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
   */
    class vqa_Answer_Detail {
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
            const strUrl = "./vqa_Answer_Detail/";
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
        ShowDialog_qa_Answer(strOp) {
            const strThisFuncName = this.ShowDialog_qa_Answer.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_qa_Answer");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "h4", "lblDialogTitle_qa_Answer");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_qa_Answer').html('添加记录');
                //vqa_Answer_DetailEx.GetMaxStrId('#txtAnswerId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_qa_Answer').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_qa_Answer').hide();
                $('#lblDialogTitle_qa_Answer').html('详细信息');
            }
            ShowDialog('#divDetailDialog_qa_Answer');
        }
        /**
         隐藏对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_qa_Answer() {
            const strThisFuncName = this.HideDialog_qa_Answer.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_qa_Answer");
            HideDialog('#divDetailDialog_qa_Answer');
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
        async DetailRecord(strAnswerId) {
            const strThisFuncName = this.DetailRecord.name;
            this.btnSubmit_d_vqa_Answer = "";
            this.btnCancel_d_vqa_Answer = "关闭";
            try {
                const objvqa_AnswerEN = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjByAnswerIdAsync)(strAnswerId);
                if (objvqa_AnswerEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.ShowDetailDataFromvqa_AnswerClass(objvqa_AnswerEN);
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
            }
            else {
                this.DetailRecord(strKeyId);
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
         <param name = "pobjqa_AnswerEN">表实体类对象</param>
       */
        ShowDetailDataFromvqa_AnswerClass(pobjvqa_AnswerEN) {
            const strThisFuncName = this.ShowDetailDataFromvqa_AnswerClass.name;
            this.answerId_d = pobjvqa_AnswerEN.answerId; // 回答Id
            this.questionsId_d = pobjvqa_AnswerEN.questionsId; // 提问Id
            this.answerContent_d = pobjvqa_AnswerEN.answerContent; // 答案内容
            this.score_d = pobjvqa_AnswerEN.score; // 评分
            this.scoreType_d = pobjvqa_AnswerEN.scoreType; // 评分类型
            this.isRight_d = pobjvqa_AnswerEN.isRight; // 是否正确
            this.parentId_d = pobjvqa_AnswerEN.parentId; // 父节点Id
            this.voteCount_d = pobjvqa_AnswerEN.voteCount; // 点赞计数
            this.updUser_d = pobjvqa_AnswerEN.updUser; // 修改人
            this.userName_d = pobjvqa_AnswerEN.userName; // 用户名
            this.memo_d = pobjvqa_AnswerEN.memo; // 备注
            this.qa_PaperId_d = pobjvqa_AnswerEN.qa_PaperId; // 论文答疑Id
            this.questionsContent_d = pobjvqa_AnswerEN.questionsContent; // 提问内容
        }
        /**
        * 答案内容 (Used In ShowDetailDataFromClass())
        **/
        set answerContent_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblAnswerContent_d", value);
        }
        /**
        * 回答Id (Used In ShowDetailDataFromClass())
        **/
        set answerId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblAnswerId_d", value);
        }
        /**
        * 设置取消按钮的标题(Used In DetailRecord())
        **/
        set btnCancel_d_vqa_Answer(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnCancel_d_vqa_Answer", value);
        }
        /**
        * 设置确定按钮的标题(Used In DetailRecord())
        **/
        set btnSubmit_d_vqa_Answer(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnSubmit_d_vqa_Answer", value);
        }
        /**
        * 是否正确 (Used In ShowDetailDataFromClass())
        **/
        set isRight_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsRight_d", value.toString());
        }
        /**
        * 备注 (Used In ShowDetailDataFromClass())
        **/
        set memo_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMemo_d", value);
        }
        /**
        * 父节点Id (Used In ShowDetailDataFromClass())
        **/
        set parentId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblParentId_d", value);
        }
        /**
        * 论文答疑Id (Used In ShowDetailDataFromClass())
        **/
        set qa_PaperId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblqa_PaperId_d", value);
        }
        /**
        * 提问内容 (Used In ShowDetailDataFromClass())
        **/
        set questionsContent_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblQuestionsContent_d", value);
        }
        /**
        * 提问Id (Used In ShowDetailDataFromClass())
        **/
        set questionsId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblQuestionsId_d", value);
        }
        /**
        * 评分 (Used In ShowDetailDataFromClass())
        **/
        set score_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblScore_d", value.toString());
        }
        /**
        * 评分类型 (Used In ShowDetailDataFromClass())
        **/
        set scoreType_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblScoreType_d", value);
        }
        /**
        * 修改人 (Used In ShowDetailDataFromClass())
        **/
        set updUser_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUpdUser_d", value);
        }
        /**
        * 用户名 (Used In ShowDetailDataFromClass())
        **/
        set userName_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUserName_d", value);
        }
        /**
        * 点赞计数 (Used In ShowDetailDataFromClass())
        **/
        set voteCount_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblVoteCount_d", value.toString());
        }
    }
    exports.vqa_Answer_Detail = vqa_Answer_Detail;
    vqa_Answer_Detail.TopicId_Cache = ""; //缓存分类字段1
});

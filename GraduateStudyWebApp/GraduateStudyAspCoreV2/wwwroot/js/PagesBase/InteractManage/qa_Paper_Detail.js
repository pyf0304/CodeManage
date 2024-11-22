(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/InteractManage/clsvqa_PaperWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_Paper_Detail = void 0;
    /**
    * 类名:qa_Paper_Detail(界面:qa_PaperCRUD)
    * 表名:qa_Paper(01120643)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:38:10
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
    const clsvqa_PaperWApi_js_1 = require("../../TS/L3_ForWApi/InteractManage/clsvqa_PaperWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /* qa_Paper_Detail 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
   */
    class qa_Paper_Detail {
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
            const strUrl = "./qa_Paper_Detail/";
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
        ShowDialog_qa_Paper(strOp) {
            const strThisFuncName = this.ShowDialog_qa_Paper.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_qa_Paper");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "h4", "lblDialogTitle_qa_Paper");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_qa_Paper').html('添加记录');
                //qa_Paper_DetailEx.GetMaxStrId('#txtqa_PaperId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_qa_Paper').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_qa_Paper').hide();
                $('#lblDialogTitle_qa_Paper').html('详细信息');
            }
            ShowDialog('#divDetailDialog_qa_Paper');
        }
        /**
         隐藏对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_qa_Paper() {
            const strThisFuncName = this.HideDialog_qa_Paper.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_qa_Paper");
            HideDialog('#divDetailDialog_qa_Paper');
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
        async DetailRecord(strqa_PaperId) {
            const strThisFuncName = this.DetailRecord.name;
            this.btnSubmit_d_vqa_Paper = "";
            this.btnCancel_d_vqa_Paper = "关闭";
            try {
                const objvqa_PaperEN = await (0, clsvqa_PaperWApi_js_1.vqa_Paper_GetObjByqa_PaperIdAsync)(strqa_PaperId);
                if (objvqa_PaperEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.ShowDetailDataFromvqa_PaperClass(objvqa_PaperEN);
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
         <param name = "pobjqa_PaperEN">表实体类对象</param>
       */
        ShowDetailDataFromvqa_PaperClass(pobjvqa_PaperEN) {
            const strThisFuncName = this.ShowDetailDataFromvqa_PaperClass.name;
            this.qa_PaperId_d = pobjvqa_PaperEN.qa_PaperId; // 论文答疑Id
            this.paperId_d = pobjvqa_PaperEN.paperId; // 论文Id
            this.questionsCount_d = pobjvqa_PaperEN.questionsCount; // 提问计数
            this.isDelete_d = pobjvqa_PaperEN.isDelete; // 是否删除
            this.isPublic_d = pobjvqa_PaperEN.isPublic; // 是否公开
            this.isSubmit_d = pobjvqa_PaperEN.isSubmit; // 是否提交
            this.userName_d = pobjvqa_PaperEN.userName; // 用户名
            this.updUser_d = pobjvqa_PaperEN.updUser; // 修改人
            this.memo_d = pobjvqa_PaperEN.memo; // 备注
            this.paperTitle_d = pobjvqa_PaperEN.paperTitle; // 论文标题
            this.attachmentCount_d = pobjvqa_PaperEN.attachmentCount; // 附件计数
            this.paperContent_d = pobjvqa_PaperEN.paperContent; // 主题内容
            this.periodical_d = pobjvqa_PaperEN.periodical; // 期刊
            this.author_d = pobjvqa_PaperEN.author; // 作者
            this.researchQuestion_d = pobjvqa_PaperEN.researchQuestion; // 研究问题
            this.literatureSources_d = pobjvqa_PaperEN.literatureSources; // 文献来源
            this.uploadfileUrl_d = pobjvqa_PaperEN.uploadfileUrl; // 文件地址
            this.majorName_d = pobjvqa_PaperEN.majorName; // 专业名称
            this.id_CurrEduCls_d = pobjvqa_PaperEN.id_CurrEduCls; // 当前教学班流水号
            this.answerCount_d = pobjvqa_PaperEN.answerCount; // 回答计数
        }
        /**
        * 回答计数 (Used In ShowDetailDataFromClass())
        **/
        set answerCount_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblAnswerCount_d", value.toString());
        }
        /**
        * 附件计数 (Used In ShowDetailDataFromClass())
        **/
        set attachmentCount_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblAttachmentCount_d", value.toString());
        }
        /**
        * 作者 (Used In ShowDetailDataFromClass())
        **/
        set author_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblAuthor_d", value);
        }
        /**
        * 设置取消按钮的标题(Used In DetailRecord())
        **/
        set btnCancel_d_vqa_Paper(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnCancel_d_vqa_Paper", value);
        }
        /**
        * 设置确定按钮的标题(Used In DetailRecord())
        **/
        set btnSubmit_d_vqa_Paper(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnSubmit_d_vqa_Paper", value);
        }
        /**
        * 教学班流水号 (Used In ShowDetailDataFromClass())
        **/
        set id_CurrEduCls_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblid_CurrEduCls_d", value);
        }
        /**
        * 是否删除 (Used In ShowDetailDataFromClass())
        **/
        set isDelete_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsDelete_d", value.toString());
        }
        /**
        * 是否公开 (Used In ShowDetailDataFromClass())
        **/
        set isPublic_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsPublic_d", value.toString());
        }
        /**
        * 是否提交 (Used In ShowDetailDataFromClass())
        **/
        set isSubmit_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsSubmit_d", value.toString());
        }
        /**
        * 文献来源 (Used In ShowDetailDataFromClass())
        **/
        set literatureSources_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLiteratureSources_d", value);
        }
        /**
        * 专业名称 (Used In ShowDetailDataFromClass())
        **/
        set majorName_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMajorName_d", value);
        }
        /**
        * 备注 (Used In ShowDetailDataFromClass())
        **/
        set memo_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMemo_d", value);
        }
        /**
        * 主题内容 (Used In ShowDetailDataFromClass())
        **/
        set paperContent_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPaperContent_d", value);
        }
        /**
        * 论文Id (Used In ShowDetailDataFromClass())
        **/
        set paperId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPaperId_d", value);
        }
        /**
        * 论文标题 (Used In ShowDetailDataFromClass())
        **/
        set paperTitle_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPaperTitle_d", value);
        }
        /**
        * 期刊 (Used In ShowDetailDataFromClass())
        **/
        set periodical_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPeriodical_d", value);
        }
        /**
        * 论文答疑Id (Used In ShowDetailDataFromClass())
        **/
        set qa_PaperId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblqa_PaperId_d", value);
        }
        /**
        * 提问计数 (Used In ShowDetailDataFromClass())
        **/
        set questionsCount_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblQuestionsCount_d", value.toString());
        }
        /**
        * 研究问题 (Used In ShowDetailDataFromClass())
        **/
        set researchQuestion_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblResearchQuestion_d", value);
        }
        /**
        * 修改人 (Used In ShowDetailDataFromClass())
        **/
        set updUser_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUpdUser_d", value);
        }
        /**
        * 文件地址 (Used In ShowDetailDataFromClass())
        **/
        set uploadfileUrl_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUploadfileUrl_d", value);
        }
        /**
        * 用户名 (Used In ShowDetailDataFromClass())
        **/
        set userName_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUserName_d", value);
        }
    }
    exports.qa_Paper_Detail = qa_Paper_Detail;
    qa_Paper_Detail.id_CurrEduCls_Cache = ""; //缓存分类字段1
});

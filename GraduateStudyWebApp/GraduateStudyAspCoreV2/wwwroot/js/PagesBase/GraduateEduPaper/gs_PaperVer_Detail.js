(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperVer_Detail = void 0;
    /**
    * 类名:gs_PaperVer_Detail(界面:gs_PaperVerCRUD)
    * 表名:gs_PaperVer(01120678)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:38:16
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsgs_PaperVerWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /* gs_PaperVer_Detail 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
   */
    class gs_PaperVer_Detail {
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
            const strUrl = "./gs_PaperVer_Detail/";
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
        ShowDialog_gs_PaperVer(strOp) {
            const strThisFuncName = this.ShowDialog_gs_PaperVer.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_gs_PaperVer");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "h4", "lblDialogTitle_gs_PaperVer");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_gs_PaperVer').html('添加记录');
                //gs_PaperVer_DetailEx.GetMaxStrId('#txtPaperVId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_gs_PaperVer').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_gs_PaperVer').hide();
                $('#lblDialogTitle_gs_PaperVer').html('详细信息');
            }
            ShowDialog('#divDetailDialog_gs_PaperVer');
        }
        /**
         隐藏对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_gs_PaperVer() {
            const strThisFuncName = this.HideDialog_gs_PaperVer.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_gs_PaperVer");
            HideDialog('#divDetailDialog_gs_PaperVer');
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
        async DetailRecord(lngPaperVId) {
            const strThisFuncName = this.DetailRecord.name;
            this.btnSubmit_d_gs_PaperVer = "";
            this.btnCancel_d_gs_PaperVer = "关闭";
            try {
                const objgs_PaperVerEN = await (0, clsgs_PaperVerWApi_js_1.gs_PaperVer_GetObjByPaperVIdAsync)(lngPaperVId);
                if (objgs_PaperVerEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.ShowDetailDataFromgs_PaperVerClass(objgs_PaperVerEN);
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
                this.ShowDialog_gs_PaperVer('Detail');
            }
            else {
                const lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
                this.ShowDialog_gs_PaperVer('Detail');
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
         <param name = "pobjgs_PaperVerEN">表实体类对象</param>
       */
        ShowDetailDataFromgs_PaperVerClass(pobjgs_PaperVerEN) {
            const strThisFuncName = this.ShowDetailDataFromgs_PaperVerClass.name;
            this.paperId_d = pobjgs_PaperVerEN.paperId; // 论文Id
            this.paperTitle_d = pobjgs_PaperVerEN.paperTitle; // 论文标题
            this.paperContent_d = pobjgs_PaperVerEN.paperContent; // 主题内容
            this.periodical_d = pobjgs_PaperVerEN.periodical; // 期刊
            this.author_d = pobjgs_PaperVerEN.author; // 作者
            this.researchQuestion_d = pobjgs_PaperVerEN.researchQuestion; // 研究问题
            this.keyword_d = pobjgs_PaperVerEN.keyword; // 关键字
            this.literatureSources_d = pobjgs_PaperVerEN.literatureSources; // 文献来源
            this.literatureLink_d = pobjgs_PaperVerEN.literatureLink; // 文献链接
            this.uploadfileUrl_d = pobjgs_PaperVerEN.uploadfileUrl; // 文件地址
            this.isQuotethesis_d = pobjgs_PaperVerEN.isQuotethesis; // 是否引用论文
            this.isSubmit_d = pobjgs_PaperVerEN.isSubmit; // 是否提交
            this.isChecked_d = pobjgs_PaperVerEN.isChecked; // 是否检查
            this.quoteId_d = pobjgs_PaperVerEN.quoteId; // 引用Id
            this.checker_d = pobjgs_PaperVerEN.checker; // 审核人
            this.literatureTypeId_d = pobjgs_PaperVerEN.literatureTypeId; // 作文类型Id
            this.updUser_d = pobjgs_PaperVerEN.updUser; // 修改人
            this.updDate_d = pobjgs_PaperVerEN.updDate; // 修改日期
            this.id_CurrEduCls_d = pobjgs_PaperVerEN.id_CurrEduCls; // 教学班流水号
            this.paperTypeId_d = pobjgs_PaperVerEN.paperTypeId; // 论文类型Id
            this.paperStatusId_d = pobjgs_PaperVerEN.paperStatusId; // 论文状态Id
            this.memo_d = pobjgs_PaperVerEN.memo; // 备注
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
        set btnCancel_d_gs_PaperVer(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnCancel_d_gs_PaperVer", value);
        }
        /**
        * 设置确定按钮的标题(Used In DetailRecord())
        **/
        set btnSubmit_d_gs_PaperVer(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnSubmit_d_gs_PaperVer", value);
        }
        /**
        * 审核人 (Used In ShowDetailDataFromClass())
        **/
        set checker_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblChecker_d", value);
        }
        /**
        * 教学班流水号 (Used In ShowDetailDataFromClass())
        **/
        set id_CurrEduCls_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblid_CurrEduCls_d", value);
        }
        /**
        * 是否检查 (Used In ShowDetailDataFromClass())
        **/
        set isChecked_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsChecked_d", value.toString());
        }
        /**
        * 是否引用论文 (Used In ShowDetailDataFromClass())
        **/
        set isQuotethesis_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsQuotethesis_d", value.toString());
        }
        /**
        * 是否提交 (Used In ShowDetailDataFromClass())
        **/
        set isSubmit_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblIsSubmit_d", value.toString());
        }
        /**
        * 关键字 (Used In ShowDetailDataFromClass())
        **/
        set keyword_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblKeyword_d", value);
        }
        /**
        * 文献链接 (Used In ShowDetailDataFromClass())
        **/
        set literatureLink_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLiteratureLink_d", value);
        }
        /**
        * 文献来源 (Used In ShowDetailDataFromClass())
        **/
        set literatureSources_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLiteratureSources_d", value);
        }
        /**
        * 作文类型Id (Used In ShowDetailDataFromClass())
        **/
        set literatureTypeId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblLiteratureTypeId_d", value);
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
        * 论文状态Id (Used In ShowDetailDataFromClass())
        **/
        set paperStatusId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPaperStatusId_d", value);
        }
        /**
        * 论文标题 (Used In ShowDetailDataFromClass())
        **/
        set paperTitle_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPaperTitle_d", value);
        }
        /**
        * 论文类型Id (Used In ShowDetailDataFromClass())
        **/
        set paperTypeId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPaperTypeId_d", value);
        }
        /**
        * 期刊 (Used In ShowDetailDataFromClass())
        **/
        set periodical_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblPeriodical_d", value);
        }
        /**
        * 引用Id (Used In ShowDetailDataFromClass())
        **/
        set quoteId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblQuoteId_d", value);
        }
        /**
        * 研究问题 (Used In ShowDetailDataFromClass())
        **/
        set researchQuestion_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblResearchQuestion_d", value);
        }
        /**
        * 修改日期 (Used In ShowDetailDataFromClass())
        **/
        set updDate_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUpdDate_d", value);
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
    }
    exports.gs_PaperVer_Detail = gs_PaperVer_Detail;
});

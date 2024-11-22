(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/Paper_EditEx.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperListEx = void 0;
    const Paper_EditEx_js_1 = require("../GraduateEduPaper/Paper_EditEx.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    /* Thesis_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class PaperListEx extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.recCount = 0;
        }
        //public objPager: clsPager = new clsPager();
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 200;
        }
        BindGv(strType, strPara) {
            this.BindGv_vPaper();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaper":
                    alert('该类没有绑定该函数：[this.BindGv_vPaper_Cache]！');
                    //this.BindGv_vPaper_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /**
        * 按钮单击,用于调用Js函数中btn_Click
        * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        **/
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (PaperCRUD_js_1.PaperCRUD.objPage_CRUD == null) {
                PaperCRUD_js_1.PaperCRUD.objPage_CRUD = new PaperListEx();
                objPage = PaperCRUD_js_1.PaperCRUD.objPage_CRUD;
            }
            else {
                objPage = PaperCRUD_js_1.PaperCRUD.objPage_CRUD;
            }
            const objPage_Edit = new Paper_EditEx_js_1.Paper_EditEx(objPage);
            let strMsg = '';
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                case "UpdateRecordInTab": //修改记录InTab
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        const strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (strCommandName == "UpdateRecordInTab") {
                        objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    }
                    else {
                        objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    }
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "ExportExcel": //导出Excel
                    //objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(PaperListExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //把类型存入session
                    //把论文ID存入session
                    var strhidQuoteGroupId = $("#hidQuoteGroupId").val();
                    const bolIsSuccess = this.SetSessionAsync("QuoteGroupId", strhidQuoteGroupId);
                    //1、为下拉框设置数据源,绑定列表数据
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "paperTitle Asc";
                    //var strWhereCond = await this.CombinevPaperCondition();
                    //const responseText = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vPaper();
                    ////2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vThesis();
                }
                else {
                    window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vPaper() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = await this.CombinevPaperCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                for (var i = 0; i < arrPaperExObjLst.length; i++) {
                    $("#thesis").append('<li class="ui-li-divider ui-bar-inherit ui-li-has-count ui-first-child"><a href="../GraduateEdu/ThesisDetail?paperId=' + arrPaperExObjLst[i].paperId + '" rel="external" class="ui-btn"><strong>' + '标题:' + arrPaperExObjLst[i].paperTitle + '</strong><p>' + '问题:' + arrPaperExObjLst[i].researchQuestion + '</p></a></li>');
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrPaperExObjLst.length == 0) {
                var strMsg = `当前没有数据！`;
                alert(strMsg);
                return;
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strhidQuoteGroupId = $("#hidQuoteGroupId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //根据参数判断是引用论文还是本组论文
                if (strhidQuoteGroupId == "01") {
                    //引用论文
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis} = '1'`;
                }
                else {
                    //本组论文
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis} = '0'`;
                }
                //if (this.paperTitle_q != "") {
                //    strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                //}
                //if (this.IsChecked_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '0'`;
                //}
                //if (this.IsQuotethesis_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '0'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        // /* 函数功能:把界面上的属性数据传到类对象中
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        //  <param name = "pobjThesisEN">数据传输的目的类对象</param>
        //*/
        // public PutDataToThesisClass(pobjThesisEN: clsThesisEN) {
        //     //pobjThesisEN.ThesisId = this.ThesisId;// 论文Id
        //     pobjThesisEN.ThesisTitle = this.ThesisTitle;// 论文标题
        //     pobjThesisEN.ThesisName = this.ThesisName;// 主题名称
        //     pobjThesisEN.ThesisContent = this.ThesisContent;// 主题内容
        //     pobjThesisEN.SetPeriodical(this.periodical;// 期刊
        //     pobjThesisEN.SetAuthor(this.author;// 作者
        //     pobjThesisEN.SetResearchQuestion(this.researchQuestion;// 研究问题
        //     var strOpTypeId = $("#hidOperationType").val();
        //     pobjThesisEN.SetOperationTypeId(strOpTypeId;// 操作类型
        //     pobjThesisEN.SetUploadfileUrl($("#hdnpic").val();
        //     pobjThesisEN.SetKeyword(this.keyword;// 关键字
        //     pobjThesisEN.SetLiteratureSources(this.literatureSources;// 文献来源
        //     pobjThesisEN.SetLiteratureLink(this.literatureLink;// 文献链接
        //     pobjThesisEN.ResearcherInformation = this.ResearcherInformation;// 研究者
        //     pobjThesisEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //     pobjThesisEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        //     //pobjThesisEN.SetMemo(this.memo;// 备注
        // }
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
        /*
        * 期刊
       */
        set periodical(value) {
            $("#txtPeriodical").val(value);
        }
        /*
        * 期刊
       */
        get periodical() {
            return $("#txtPeriodical").val();
        }
        /*
        * 研究问题
       */
        set researchQuestion(value) {
            $("#txtResearchQuestion").val(value);
        }
        /*
        * 研究问题
       */
        get researchQuestion() {
            return $("#txtResearchQuestion").val();
        }
        /*
         * 主题内容
        */
        set paperContent(value) {
            $("#txtPaperContent").val(value);
        }
        /*
        * 主题内容
       */
        get paperContent() {
            return $("#txtPaperContent").val();
        }
        // /*
        // * 论文Id
        //*/
        // public set paperId(value: string) {
        //     $("#txtPaperId").val(value);
        // }
        // /*
        // * 论文Id
        //*/
        // public get paperId(): string {
        //     return $("#txtPaperId").val();
        // }
        /*
        * 论文标题
       */
        set paperTitle(value) {
            $("#txtPaperTitle").val(value);
        }
        /*
        * 论文标题
       */
        get paperTitle() {
            return $("#txtPaperTitle").val();
        }
        /*
        * 研究者
       */
        set ResearcherInformation(value) {
            $("#txtResearcherInformation").val(value);
        }
        /*
        * 研究者
       */
        get ResearcherInformation() {
            return $("#txtResearcherInformation").val();
        }
        /*
       * 关键字
      */
        set keyword(value) {
            $("#txtKeyword").val(value);
        }
        /*
        * 关键字
       */
        get keyword() {
            return $("#txtKeyword").val();
        }
        // /*
        // * 关键字
        //*/
        // public get Keyword_q(): string {
        //     return $("#txtKeyword_q").val();
        // }
        /*
        * 文献链接
       */
        set literatureLink(value) {
            $("#txtLiteratureLink").val(value);
        }
        /*
        * 文献链接
       */
        get literatureLink() {
            return $("#txtLiteratureLink").val();
        }
        /*
        * 文献来源
       */
        set literatureSources(value) {
            $("#txtLiteratureSources").val(value);
        }
        /*
        * 文献来源
       */
        get literatureSources() {
            return $("#txtLiteratureSources").val();
        }
        SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                    }
                });
            });
        }
    }
    exports.PaperListEx = PaperListEx;
});

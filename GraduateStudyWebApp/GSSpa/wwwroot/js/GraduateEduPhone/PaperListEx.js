(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsPager.js", "../GraduateEduPaper/Paper_QUDI_TS.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/FunClass/stuUserLoginInfo.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperListEx = void 0;
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const Paper_QUDI_TS_js_1 = require("../GraduateEduPaper/Paper_QUDI_TS.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const stuUserLoginInfo_js_1 = require("../TS/FunClass/stuUserLoginInfo.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsPaperWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    /* Thesis_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class PaperListEx extends Paper_QUDI_TS_js_1.Paper_QUDI_TS {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 200;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if ($("#hidUserId").val() != "") {
                    //把类型存入session
                    //把论文ID存入session
                    var strhidQuoteGroupId = $("#hidQuoteGroupId").val();
                    const bolIsSuccess = this.SetSessionAsync("QuoteGroupId", strhidQuoteGroupId);
                    //1、为下拉框设置数据源,绑定列表数据
                    this.hidSortvPaperBy = "paperTitle Asc";
                    //var strWhereCond = this.CombinevPaperCondition();
                    //const responseText = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
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
            var strWhereCond = this.CombinevPaperCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst = [];
            try {
                const responseRecCount = await (0, clsvPaperWApi_js_1.vPaper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst = jsonData;
                    for (var i = 0; i < arrvPaperObjLst.length; i++) {
                        $("#thesis").append('<li class="ui-li-divider ui-bar-inherit ui-li-has-count ui-first-child"><a href="../GraduateEdu/ThesisDetail?paperId=' + arrvPaperObjLst[i].paperId + '" rel="external" class="ui-btn"><strong>' + '标题:' + arrvPaperObjLst[i].paperTitle + '</strong><p>' + '问题:' + arrvPaperObjLst[i].researchQuestion + '</p></a></li>');
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvPaperObjLst.length == 0) {
                var strMsg = `当前没有数据！`;
                alert(strMsg);
                return;
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strhidQuoteGroupId = $("#hidQuoteGroupId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //根据参数判断是引用论文还是本组论文
                if (strhidQuoteGroupId == "01") {
                    //引用论文
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis} = '1'`;
                }
                else {
                    //本组论文
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_IsQuotethesis} = '0'`;
                }
                //if (this.PaperTitle_q != "") {
                //    strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                //}
                //if (this.IsChecked_q == true) {
                //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '0'`;
                //}
                //if (this.IsQuotethesis_q == true) {
                //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '0'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //添加数据事件
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                //这是一个单表的插入的代码,由于逻辑层太简单,
                //就把逻辑层合并到控制层,
                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        //HideDialog();
                        this.Clear();
                        window.location.href = "#pageOne";
                        //去掉主页动态标签防止缓存问题；
                        $("#thesis li").not(":first").remove();
                        this.BindGv_vPaper();
                    }
                });
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
        async AddNewRecordSave() {
            //this.DivName = "divAddNewRecordSave";
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            this.PutDataToPaperClass(objPaperEN);
            try {
                //const responseText = await Thesis_IsExistAsync(objThesisEN.ThesisId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objThesisEN.ThesisId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await clsPaperWApiEx_js_1.clsPaperWApiEx.AddNewRecordAsyncEx(objPaperEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
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
        <param name = "pobjPaperEN">数据传输的目的类对象</param>
      */
        PutDataToPaperClass(pobjPaperEN) {
            //pobjPaperEN.paperId = this.paperId;// 论文Id
            pobjPaperEN.paperTitle = this.paperTitle; // 论文标题
            pobjPaperEN.paperContent = this.paperContent; // 主题内容
            pobjPaperEN.periodical = this.periodical; // 期刊
            pobjPaperEN.author = this.author; // 作者
            pobjPaperEN.researchQuestion = this.researchQuestion; // 研究问题
            pobjPaperEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjPaperEN.updUser = $("#hidUserId").val(); // 修改用户Id
            pobjPaperEN.keyword = this.keyword; // 关键字
            pobjPaperEN.literatureSources = this.literatureSources; // 文献来源
            pobjPaperEN.literatureLink = this.literatureLink; // 文献链接
            pobjPaperEN.uploadfileUrl = $("#hdnpic").val(); // 文件地址
            var strhidQuoteGroupId = $("#hidQuoteGroupId").val();
            //根据参数判断是引用论文还是本组论文
            if (strhidQuoteGroupId == "01") {
                //引用论文
                pobjPaperEN.isQuotethesis = true;
            }
            else {
                //本组论文
                pobjPaperEN.isQuotethesis = false;
            }
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserInfo_Hid = $("#hidUserInfo").val();
            var objvUserRoleRelation;
            objvUserRoleRelation = stuUserLoginInfo_js_1.stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
            //$('#userName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
            //判断角色 学生
            if (objvUserRoleRelation.roleId == "00620003") {
                //学生添加则false；
                pobjPaperEN.isChecked = false;
            }
            else {
                //教师00620002 或其他管理员
                pobjPaperEN.isChecked = true;
            }
            pobjPaperEN.isChecked = this.isChecked; // 是否检查
            pobjPaperEN.checker = this.checker; // 审核人
            pobjPaperEN.memo = this.memo; // 备注
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
        //     pobjThesisEN.periodical = this.periodical;// 期刊
        //     pobjThesisEN.author = this.author;// 作者
        //     pobjThesisEN.researchQuestion = this.researchQuestion;// 研究问题
        //     var strOpTypeId = $("#hidOperationType").val();
        //     pobjThesisEN.operationTypeId = strOpTypeId;// 操作类型
        //     pobjThesisEN.uploadfileUrl = $("#hdnpic").val();
        //     pobjThesisEN.keyword = this.keyword;// 关键字
        //     pobjThesisEN.literatureSources = this.literatureSources;// 文献来源
        //     pobjThesisEN.literatureLink = this.literatureLink;// 文献链接
        //     pobjThesisEN.ResearcherInformation = this.ResearcherInformation;// 研究者
        //     pobjThesisEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        //     pobjThesisEN.updUser = $("#hidUserId").val();// 修改用户Id
        //     //pobjThesisEN.memo = this.memo;// 备注
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
    }
    exports.PaperListEx = PaperListEx;
});

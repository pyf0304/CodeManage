(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsvDiscussionSubContentWApi.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MyComments = void 0;
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsvDiscussionSubContentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvDiscussionSubContentWApi.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class MyComments extends clsOperateList2_js_1.clsOperateList {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                //var strRoleId = clsPubSessionStorage.GetSession_RoleId();
                //1、为下拉框设置数据源,绑定列表数据
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    this.hidSortBy = "updDate Desc";
                    // const gvResult = await this.BindGv_PaperComment();
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
        /* 查询
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async btnQuery_Click(strListDiv) {
            try {
                //if ($("#hidQueryStata").val() == "1") {
                //    const gvResult1 = await this.BindGv_PaperComment();
                //} else if ($("#hidQueryStata").val() == "2") {
                //    const gvResult2 = await this.BindGv_PaperSubViewpointComment();
                //} else if ($("#hidQueryStata").val() == "3") {
                //    const gvResult3 = await this.BindGv_ViewpointComment();
                //} else {
                //    const gvResult4 = await this.BindGv_DiscussionTopicsComment();
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 论文评论
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async li_PaperComment_Click(strListDiv) {
            try {
                // const gvResult = await this.BindGv_PaperComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 论文子观点评论
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        //public async li_PaperSubViewpointComment_Click(strListDiv: string) {
        //    try {
        //        const gvResult = await this.BindGv_PaperSubViewpointComment();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 主题观点评论
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        //public async li_ViewpointComment_Click(strListDiv: string) {
        //    try {
        //        const gvResult = await this.BindGv_ViewpointComment();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 主题讨论评论
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async li_DiscussionTopicsComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_DiscussionTopicsComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        CombineCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                strWhereCond += " And updUser = '" + $("#hidUserId").val() + "'";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombineCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                strWhereCond += " And updUser = '" + $("#hidUserId").val() + "'";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        ////论文评论
        //public async  BindGv_PaperComment() {
        //    var strWhereCond = this.CombineCondition1();
        //    var arrvPaperAppraiseObjLst: Array<clsvPaperAppraiseEN> = [];
        //    var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        //    try {
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortBy
        //        };
        //        const responseText = await vPaperAppraise_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvPaperAppraiseObjLst = <Array<clsvPaperAppraiseEN>>jsonData;
        //            console.log("1");
        //        });
        //        var strhtml = "";
        //        var cateid: number = 0;
        //        //$('#tbList tr').remove();
        //        for (var i = 0; i < arrvPaperAppraiseObjLst.length; i++) {
        //            var strPaperAppraiseContent: string = arrvPaperAppraiseObjLst[i].PaperAppraiseContent;
        //            var strAppraiseScore: number = arrvPaperAppraiseObjLst[i].AppraiseScore;
        //            var strPaperTitle: string = arrvPaperAppraiseObjLst[i].paperTitle;
        //            var strUpdDate: string = arrvPaperAppraiseObjLst[i].updDate;
        //            strhtml += '<tr><td>' + cateid + '</td><td>' + strPaperAppraiseContent + '</td><td>' + strAppraiseScore + '</td><td>' + strPaperTitle + '</td><td>' + strUpdDate + '</td></tr>';
        //        }
        //        //拼接；
        //        //$("#tbList").append(strhtml);
        //        $("#tbList1").html(strhtml);
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //论文子观点评论
        //public async  BindGv_PaperSubViewpointComment() {
        //    var strWhereCond = this.CombineCondition2();
        //    var arrvPaperSubViewpointAppraiseObjLst: Array<clsvPaperSubViewpointAppraiseEN> = [];
        //    var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        //    try {
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortBy
        //        };
        //        //arrvPaperAppraiseObjLst = vPaperAppraise_GetObjLstByPager_WA_CacheAsync(objPagerPara);
        //        const responseText = await vPaperSubViewpointAppraise_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvPaperSubViewpointAppraiseObjLst = <Array<clsvPaperSubViewpointAppraiseEN>>jsonData;
        //            console.log("1");
        //        });
        //        var strhtml = "";
        //        var cateid: number = 0;
        //        //$('#tbList tr').remove();
        //        for (var i = 0; i < arrvPaperSubViewpointAppraiseObjLst.length; i++) {
        //            var strAppraiseContent: string = arrvPaperSubViewpointAppraiseObjLst[i].AppraiseContent;
        //            var strAppraiseScore: number = arrvPaperSubViewpointAppraiseObjLst[i].AppraiseScore;
        //            var strSubViewpointContent: string = arrvPaperSubViewpointAppraiseObjLst[i].subViewpointContent;
        //            var strUpdDate: string = arrvPaperSubViewpointAppraiseObjLst[i].updDate;
        //            strhtml += '<tr><td>' + cateid + '</td><td>' + strAppraiseContent + '</td><td>' + strAppraiseScore + '</td><td>' + strSubViewpointContent + '</td><td>' + strUpdDate + '</td></tr>';
        //        }
        //        //拼接；
        //        //$("#tbList").append(strhtml);
        //        $("#tbList2").html(strhtml);
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        ////主题观点评论
        //public async  BindGv_ViewpointComment() {
        //    var strWhereCond = this.CombineCondition2();
        //    var arrvViewpointAppraiseObjLst: Array<clsvViewpointAppraiseEN> = [];
        //    var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        //    try {
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortBy
        //        };
        //        const responseText = await vViewpointAppraise_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvViewpointAppraiseObjLst = <Array<clsvViewpointAppraiseEN>>jsonData;
        //            console.log("1");
        //        });
        //        var strhtml = "";
        //        var cateid: number = 0;
        //        //$('#tbList tr').remove();
        //        for (var i = 0; i < arrvViewpointAppraiseObjLst.length; i++) {
        //            var strAppraiseContent: string = arrvViewpointAppraiseObjLst[i].AppraiseContent;
        //            //var strAppraiseScore: number = arrvViewpointObjLst[i].AppraiseScore;
        //            var strViewpointName: string = arrvViewpointAppraiseObjLst[i].viewpointName;
        //            var strUpdDate: string = arrvViewpointAppraiseObjLst[i].updDate;
        //            strhtml += '<tr><td>' + cateid + '</td><td>' + strAppraiseContent + '</td><td>' + strViewpointName + '</td><td>' + strUpdDate + '</td></tr>';
        //        }
        //        //拼接；
        //        //$("#tbList").append(strhtml);
        //        $("#tbList3").html(strhtml);
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //主题讨论评论
        async BindGv_DiscussionTopicsComment() {
            var strWhereCond = this.CombineCondition1();
            var arrvDiscussionSubContentObjLst = [];
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            try {
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseText = await (0, clsvDiscussionSubContentWApi_js_1.vDiscussionSubContent_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvDiscussionSubContentObjLst = jsonData;
                    console.log("1");
                });
                var strhtml = "";
                var cateid = 0;
                //$('#tbList tr').remove();
                for (var i = 0; i < arrvDiscussionSubContentObjLst.length; i++) {
                    var strSubContent = arrvDiscussionSubContentObjLst[i].subContent;
                    //var strAppraiseScore: number = arrvDiscussionSubContentObjLst[i].AppraiseScore;
                    var strtopicsTitle = arrvDiscussionSubContentObjLst[i].topicsTitle;
                    var strUpdDate = arrvDiscussionSubContentObjLst[i].updDate;
                    strhtml += '<tr><td>' + cateid + '</td><td>' + strSubContent + '</td><td>' + strtopicsTitle + '</td><td>' + strUpdDate + '</td></tr>';
                }
                //拼接；
                //$("#tbList").append(strhtml);
                $("#tbList4").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortBy(value) {
            $("#hidSortBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortBy() {
            return $("#hidSortBy").val();
        }
        /*
       * 起始时间
      */
        get StartDate_q() {
            return $("#txtStartDate_q").val();
        }
        /*
        * 起始时间
       */
        set StartDate_q(value) {
            $("#txtStartDate_q").val(value);
        }
        /*
       * 结束时间
      */
        get EndDate_q() {
            return $("#txtEndDate_q").val();
        }
        /*
        * 结束时间
       */
        set EndDate_q(value) {
            $("#txtEndDate_q").val(value);
        }
    }
    exports.MyComments = MyComments;
});

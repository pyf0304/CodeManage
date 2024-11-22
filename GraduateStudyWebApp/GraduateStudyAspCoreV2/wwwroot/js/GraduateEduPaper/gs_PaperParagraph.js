(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/gs_PaperParagraphCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvSectionWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperParagraphExWApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubConfig/clsSysPara4WebApi.js", "./gs_PaperParagraph_EditEx.js", "./Section_EditEx.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsPrivateSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraph = void 0;
    const gs_PaperParagraphCRUD_js_1 = require("../PagesBase/GraduateEduPaper/gs_PaperParagraphCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsgs_PaperParagraphVerEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js");
    const clsvgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js");
    const clsvSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js");
    const clsRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsvRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js");
    const clsgs_PaperParagraphVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js");
    const clsgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js");
    const clsvgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js");
    const clsvSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvSectionWApi.js");
    const clsvRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsgs_PaperParagraphExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperParagraphExWApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const gs_PaperParagraph_EditEx_js_1 = require("./gs_PaperParagraph_EditEx.js");
    const Section_EditEx_js_1 = require("./Section_EditEx.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    /* gs_PaperParagraph 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PaperParagraph extends gs_PaperParagraphCRUD_js_1.gs_PaperParagraphCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperBy: string = "paperId";
        // public arrType6: PeoplebgColor[] = [];
        // arrType6: PeoplebgColor[] = [{ userId: "Mr.A", bgcolor: '' }, { userId: "Mr.B", bgcolor: '' }]
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            (0, clsvSectionWApi_js_1.vSection_ReFreshThisCache)();
            this.BindGv_vSection();
            (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_ReFreshThisCache)();
            this.BindGv_vgs_PaperParagraph();
        }
        BindGv_Cache(strType, strPara) {
            switch (strType) {
                case "vgs_TeachingDate":
                    alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                    //this.BindGv_vgs_TeachingDate_Cache();
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
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    //const responseText = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    this.hidSortvgs_PaperParagraphBy = "updDate Asc";
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    //判断角色
                    //管理员
                    if (strRoleId == "00620001") {
                    }
                    else if (strRoleId == "00620002") {
                    }
                    else {
                    }
                    //1、获取当前用户的色码块
                    const responseText = await this.GetLoginUserColorCode();
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示左边树中
                    const gvResult = await this.BindGv_vSection();
                    //显示右边内容
                    const gvResultOne = await this.BindGv_vgs_PaperParagraph();
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
        //获取当前登录用户的色码
        async GetLoginUserColorCode() {
            //主题用户关系
            var arrRTUserRelaObjLst = [];
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //获取缓存色码表；
            var arrGs_ColorObjLst = [];
            ////获取色码数据
            //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
            //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;
            //});
            var strWhereCondUser = ` 1=1 And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId} ='${strUserId}'`;
            //根据当前登录人和主题Id 查询用户排序号，根据排序号 得到色码对应色块；
            const responseText = await (0, clsvRTUserRelaWApi_js_1.vRTUserRela_GetFirstObjAsync)(strWhereCondUser).then((jsonData) => {
                var objRtUsersEN = jsonData;
                //通过用户的编号，获取色码表对应的编号色码
                //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRtUsersEN.orderNum);
                if (objRtUsersEN != null) {
                    $("#hidColorCode").val(objRtUsersEN.colorCode);
                    ////这里用固定背景色；
                    //$("#hidColorCode").val(objRtUsersEN.userBgColor);
                }
            });
        }
        //根据主题ID 查询得到改主题有几个用户，存放数组，存放用户id  背景色 等等；
        async ConstStr() {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var arrvRTUserRelaObjLst = [];
            var strWhereCond = ` And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
            const responseObjLst = await (0, clsvRTUserRelaWApi_js_1.vRTUserRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrvRTUserRelaObjLst = jsonData;
            });
            if (arrvRTUserRelaObjLst.length > 0) {
                for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
                    var strUserId = arrvRTUserRelaObjLst[i].userId;
                    var strColor = this.getRandomColor();
                }
            }
            var strUserId = "[";
            var strColor = "[";
            for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
                var strUserId = arrvRTUserRelaObjLst[i].userId;
                var strColor = this.getRandomColor();
                strUserId += '"' + strUserId + '",';
                strColor += '"' + this.getRandomColor() + '",';
            }
            strUserId = strUserId.substr(0, strUserId.length - 1);
            strColor = strColor.substr(0, strColor.length - 1);
            strUserId += "]";
            strColor += "]";
            var strLabelsJson = eval(strUserId);
            var strColorJson = eval(strColor);
            this.UserColor(strLabelsJson, strColorJson);
            //  this.arrType6 = [{ userId: "Mr.A", bgcolor: '' }, { userId: "Mr.B", bgcolor: '' }]
        }
        //获取不同色码
        getRandomColor() {
            return '#' + ('00000' + (Math.random() * 0x1000000 << 0).toString(16)).substr(-6);
        }
        //用户颜色数据组合
        UserColor(strlabelsJson, strColorJson) {
            var config = {
                "userId": strlabelsJson,
                "backgroundColor": strColorJson
            };
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        async Combinevgs_PaperParagraphCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperId = $("#hidPaperId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.ParagraphContent_q != "") {
                //    strWhereCond += ` And ${clsvgs_PaperParagraphEN.con_ParagraphContent} like '% ${this.ParagraphContent_q}%'`;
                //}
                if (strPaperId != "") {
                    strWhereCond += ` And ${clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId} = '${strPaperId}'`;
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperParagraphCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vgs_PaperParagraph() {
            if (this.hidSortvgs_PaperParagraphBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.Combinevgs_PaperParagraphCondition();
            var strWhereSectionCond = this.CombinevSectionCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvgs_PaperParagraphObjLst = [];
            //段落临时数据
            var arrParagraphObjLst = [];
            //节点数据源
            var arrvSectionObjLst = [];
            //小节
            var arrvSectionZhangObjLst = [];
            //小节子节
            var arrvSectionJieObjLst = [];
            //主题用户关系
            var arrRTUserRelaObjLst = [];
            //获取缓存色码表；
            var arrGs_ColorObjLst = [];
            //段落历史数据
            var arrgs_PaperParagraphVObjLst = [];
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            try {
                //this.recCount = await vgs_PaperParagraph_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                //var objPagerPara: stuPagerPara = {
                //    pageIndex: intCurrPageIndex,
                //    pageSize: this.pageSize,
                //    whereCond: strWhereCond,
                //    orderBy: this.hidSortvgs_PaperParagraphBy
                //};
                //const responseObjLst = await vgs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvgs_PaperParagraphObjLst = <Array<clsvgs_PaperParagraphEN>>jsonData;
                //});
                //获取段落数据
                const responseObjLst = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_PaperParagraphObjLst = jsonData;
                });
                //获取节点数据
                const responseObjLst1 = await (0, clsvSectionWApi_js_1.vSection_GetObjLstAsync)(strWhereSectionCond).then((jsonData) => {
                    arrvSectionObjLst = jsonData;
                });
                ////获取色码数据
                //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
                //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;
                //});
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                var strWhereCondUser = ` 1=1 And ${clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
                const responseObjLst2 = await (0, clsvRTUserRelaWApi_js_1.vRTUserRela_GetObjLstAsync)(strWhereCondUser).then((jsonData) => {
                    arrRTUserRelaObjLst = jsonData;
                });
                //获取段落历史数据
                var strPaperId = $("#hidPaperId").val();
                var strHistoryWhere = `  ${clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN.con_PaperId} = '${strPaperId}'`;
                const responseObjLst5 = await (0, clsgs_PaperParagraphExWApi_js_1.gs_PaperParagraphEx_GetObjLstAsync)(strHistoryWhere).then((jsonData) => {
                    arrgs_PaperParagraphVObjLst = jsonData;
                });
                var strhtml = '';
                //$('#divTwo li').remove();
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                $('#firstgarapht th').remove();
                //通过历史段落数据得到当前论文有多少用户；然后通过用户ID查询比对主题用户关系表 得到用户序号，通过序号 得到色码表；
                //var arrHistoryParagraphObjLst = arrgs_PaperParagraphVObjLst.filter(x => x.paragraphId == strParagraphId);
                //循环数据源 
                var strt = '<th colspan="2">';
                for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {
                    var strUserId = arrRTUserRelaObjLst[y].userId;
                    var orderNum = arrRTUserRelaObjLst[y].orderNum;
                    var strUserName = arrRTUserRelaObjLst[y].userName;
                    //var strColorCode = arrRTUserRelaObjLst[y].userBgColor;//这用固定背景色
                    var strColorCode = arrRTUserRelaObjLst[y].colorCode; //色码表中色码块
                    //判断Userid 在段落历史中是否存在
                    var objUser = arrgs_PaperParagraphVObjLst.find(x => x.updUser == strUserId);
                    if (objUser != null) {
                        //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == orderNum);
                        //if (Objgs_Color != null) {
                        // var strColorCode = objUser.colorCode;
                        strt += '<label style="background: ' + strColorCode + '">&nbsp;&nbsp;&nbsp;&nbsp;</label>&nbsp;&nbsp;<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';
                        // }
                    }
                }
                strt += '</th>';
                $('#firstgarapht').append(strt);
                $('#tbList tr').remove();
                if (arrvSectionObjLst.length > 0) {
                    //获取该论文下 所有的章节；
                    arrvSectionZhangObjLst = arrvSectionObjLst.filter(x => x.parentId == "root");
                    //循环所有的章节数据；
                    if (arrvSectionZhangObjLst.length > 0) {
                        for (var i = 0; i < arrvSectionZhangObjLst.length; i++) {
                            //得到ID 然后得到章节下面的所有节数据
                            var strSectionId = arrvSectionZhangObjLst[i].sectionId;
                            var strSectionName = arrvSectionZhangObjLst[i].sectionName;
                            //节点子数据
                            arrvSectionJieObjLst = arrvSectionObjLst.filter(x => x.parentId == strSectionId);
                            if (arrvSectionJieObjLst.length > 0) {
                                //得到子节点数据 循环输出；
                                for (var j = 0; j < arrvSectionJieObjLst.length; j++) {
                                    var strJieSectionId = arrvSectionJieObjLst[j].sectionId;
                                    var strJieSectionName = arrvSectionJieObjLst[j].sectionName;
                                    cateid++;
                                    intJ++;
                                    var fid = 0;
                                    //先创建子模块类型
                                    //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
                                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td colspan="2">';
                                    //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + strJieSectionName + '</h3></div>';
                                    strhtml += '<div style="float:left;"><h3>' + strSectionName + '-' + strJieSectionName + '</h3></div>';
                                    strhtml += '<div style="float:right;">';
                                    //if ($("#hidType").val() == "01") {
                                    //if ($("#hidIsSubmit").val() != "true") {
                                    strhtml += '<button title="添加段落" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewParagraphRecord_Click("' + strJieSectionId + '");><i class="layui-icon"></i></button>';
                                    //strhtml += '<button title="重新排列序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strJieSectionId + '")><i class="layui-icon">&#xe669;</i></button>';
                                    //   }
                                    // }
                                    strhtml += '</div></td></tr>';
                                    //子节点下面的段落数据
                                    //段落ID
                                    var strParagraphId = "";
                                    var strParagraphTypeId = ""; //段落类型
                                    var strParagraphContent = ""; //段落内容
                                    var strUserName = ""; //编辑人姓名
                                    cateid_ = cateid;
                                    var intK = 0;
                                    //通过目录子节点数据ID 查询得到对应的段落数据；
                                    arrParagraphObjLst = arrvgs_PaperParagraphObjLst.filter(x => x.sectionId == strJieSectionId);
                                    for (var k = 0; k < arrParagraphObjLst.length; k++) {
                                        strParagraphId = arrParagraphObjLst[k].paragraphId;
                                        strParagraphTypeId = arrParagraphObjLst[k].paragraphTypeId;
                                        strParagraphContent = arrParagraphObjLst[k].paragraphContent;
                                        cateid++;
                                        //查找比对用户
                                        var ObjRTUserRela = arrRTUserRelaObjLst.find(x => x.userId == arrParagraphObjLst[k].updUser);
                                        if (ObjRTUserRela != null) {
                                            strUserName = ObjRTUserRela.userName;
                                            var OrderNumber = ObjRTUserRela.orderNum;
                                            ////通过用户的编号，获取色码表对应的编号色码
                                            //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == OrderNumber);
                                            //if (Objgs_Color != null) {
                                            //    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="Color:' + Objgs_Color.colorCode + '"><td style="width:10%;">';
                                            //}
                                            //else {
                                            //    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td style="width:10%;">';
                                            //}
                                            //通过用户的编号，获取色码表对应的编号色码
                                            //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == OrderNumber);
                                            //if (Objgs_Color != null) {
                                            //    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="Color:' + Objgs_Color.colorCode + '"><td style="width:10%;">';
                                            // }
                                            // else {
                                            strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td style="width:10%;">';
                                            // }
                                        }
                                        else {
                                            strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td style="width:10%;">';
                                        }
                                        //strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" onmouseover=btnUpdatePaperPageNum_Click(' + arrParagraphObjLst[k].paperPageNum + ',"' + arrParagraphObjLst[k].explainContent + '")><td>';
                                        //tr行内分2列展示；
                                        //序号
                                        strhtml += '<span class="color3" > ' + arrParagraphObjLst[k].orderNum + '. </span>';
                                        //通过段落数据比对 获取历史中的用户数据 段落ID和历史段落ID 比对得到列表
                                        var arrHistoryParagraphObjLst = arrgs_PaperParagraphVObjLst.filter(x => x.paragraphId == strParagraphId);
                                        //循环数据源
                                        for (var p = 0; p < arrHistoryParagraphObjLst.length; p++) {
                                            //得到用户Id
                                            var strUserId = arrHistoryParagraphObjLst[p].updUser;
                                            //根据Id 查询用户缓存得到名字；
                                            //得到编辑人名字
                                            var objUsers = arrUsers.find(x => x.userId == strUserId);
                                            if (objUsers != null) {
                                                //姓名
                                                strhtml += '<br/><span class="color6" > ' + objUsers.userName + ' </span>';
                                            }
                                        }
                                        //日期
                                        strhtml += '<br/> <span class="colorRed" > ' + clsPubFun4Web_js_1.clsPubFun4Web.substrDate(arrParagraphObjLst[k].updDate) + ' </span></td><td>';
                                        //先判断段落类型，根据类型判断是图片，还是段落；
                                        if (strParagraphTypeId == "02") {
                                            //图片，如果图片存放字段不为空
                                            if (strParagraphContent != "") {
                                                var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                                                var strAddressAndPortfull = strAddressAndPort + strParagraphContent;
                                                strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strParagraphId + '"/>';
                                            }
                                        }
                                        else {
                                            ////文字
                                            //strhtml += '&nbsp;&nbsp;<span class="color3">' + arrParagraphObjLst[k].orderNum + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>' + strParagraphContent + '';
                                            //文字
                                            strhtml += '&nbsp;&nbsp;' + strParagraphContent + '';
                                        }
                                        //最底一行编辑
                                        strhtml += '<br/><div style="float:right;">';
                                        //strhtml += '<input id="txt_OrderNum' + cateid + '" type="text" class="layui-input" style="width:40px;" name="order" value="' + arrParagraphObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('段落历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strParagraphId + "&Type=11')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                                        strhtml += '<button title="添加中间段落" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddCenterParagraphRecord_Click("' + strJieSectionId + '",' + arrParagraphObjLst[k].orderNum + ');><i class="layui-icon"></i></button>';
                                        //上移
                                        strhtml += '<button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strParagraphId + '",' + arrParagraphObjLst[k].orderNum + ',"' + strJieSectionId + '")><i class="iconfont">&#xe6a5;</i></button>';
                                        //下移
                                        strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strParagraphId + '",' + arrParagraphObjLst[k].orderNum + ',"' + strJieSectionId + '")><i class="iconfont">&#xe6a6;</i></button>';
                                        //编辑
                                        strhtml += '<button title="编辑段落" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_PaperParagraph_Click("' + strParagraphId + '")><i class="layui-icon">&#xe642;</i></button>';
                                        //删除
                                        strhtml += '<button title="删除段落" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strParagraphId + '")><i class="layui-icon">&#xe640;</i></button>';
                                        strhtml += '</div></td></tr>';
                                    }
                                }
                            }
                        }
                        //拼接；
                        $("#tbList").append(strhtml);
                    }
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
            //try {
            //    this.BindTab_vgs_PaperParagraph(strListDiv, arrvgs_PaperParagraphObjLst);
            //    console.log("完成BindGv_vgs_PaperParagraph!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    //console.trace();
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
        }
        //删除段落
        /*
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                //删除之前先删除ID对应的历史版本记录；
                const responseTextV = await this.DelRecordgs_PaperParagraphW(strKeyId);
                const responseText = await this.DelRecord(strKeyId);
                const responseOrder = await this.btnReOrder_Click();
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async DelRecord(strParagraphId) {
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_DelRecordAsync)(strParagraphId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_PaperParagraph_ReFreshCache();
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async DelRecordgs_PaperParagraphW(strParagraphId) {
            try {
                //删除之前先删除ID对应的历史版本记录；
                var strWhere = " 1=1 And paragraphId = '" + strParagraphId + "'";
                const responseText = await (0, clsgs_PaperParagraphVerWApi_js_1.gs_PaperParagraphVer_Delgs_PaperParagraphVersByCondAsync)(strWhere);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_PaperParagraph_ReFreshCache();
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    //alert(strInfo);
                    console.log(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    // alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        CombinevSectionCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperId = $("#hidPaperId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (strPaperId != "") {
                    //论文ID
                    strWhereCond += ` And ${clsvSectionEN_js_1.clsvSectionEN.con_PaperId} = '${strPaperId}'`;
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSectionCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //章节数据源
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSection() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevSectionCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSectionObjLst = [];
            var arrvSectionZhangObjLst = [];
            var arrvSectionJieObjLst = [];
            try {
                //this.recCount = await vSection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                //var objPagerPara: stuPagerPara = {
                //    pageIndex: intCurrPageIndex,
                //    pageSize: this.pageSize,
                //    whereCond: strWhereCond,
                //    orderBy: SectionCRUD.sortvSectionBy
                //};
                //const responseObjLst = await vSection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvSectionObjLst = <Array<clsvSectionEN>>jsonData;
                //});
                const responseObjLst1 = await (0, clsvSectionWApi_js_1.vSection_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvSectionObjLst = jsonData;
                });
                var strhtml = "";
                $("#TreeBind li").remove();
                if (arrvSectionObjLst.length > 0) {
                    //获取该论文下 所有的章；
                    arrvSectionZhangObjLst = arrvSectionObjLst.filter(x => x.parentId == "root"); //技能引用人
                    //            <li id="li00000014" onclick = "btnSelectResearchTopic('00000014', '泰泽教育内部测试', '2')" >
                    //                <a href="#" title = "泰泽教育内部测试" > 泰泽教育内部测试 & nbsp;
                    //<i class="layui-icon layui-icon-group" style = "font-size: 16px; color: red;" title = "指导者" > </i>
                    //    < /a>
                    //    < /li>
                    //    < /ul>
                    //    < /li>
                    //循环章数据；
                    if (arrvSectionZhangObjLst.length > 0) {
                        for (var i = 0; i < arrvSectionZhangObjLst.length; i++) {
                            //得到ID 然后得到章下面的所有节数据
                            var strSectionId = arrvSectionZhangObjLst[i].sectionId;
                            var strSectionName = arrvSectionZhangObjLst[i].sectionName;
                            strhtml += '<li class="li">';
                            strhtml += '<a href="#" id = "' + strSectionId + '" class="main" title = "' + strSectionName + '" onclick =main_Click("' + strSectionId + '") style = "background: url(&quot;../images/st_folder_open.gif&quot;) left center no-repeat;" >' + strSectionName + '</a>';
                            strhtml += '<ul class="submenu" id = "ul' + strSectionId + '" style = "">';
                            arrvSectionJieObjLst = arrvSectionObjLst.filter(x => x.parentId == strSectionId);
                            if (arrvSectionJieObjLst.length > 0) {
                                //得到子节点数据 循环输出；
                                for (var j = 0; j < arrvSectionJieObjLst.length; j++) {
                                    var strJieSectionId = arrvSectionJieObjLst[j].sectionId;
                                    var strJieSectionName = arrvSectionJieObjLst[j].sectionName;
                                    strhtml += '<li id="li' + strJieSectionId + '" onclick=btnSelectResearchTopic("' + strJieSectionId + '","' + strJieSectionName + '")>';
                                    strhtml += '<a href="#" title ="' + strJieSectionName + '" > ' + strJieSectionName + '</a>';
                                    strhtml += '</li>';
                                }
                            }
                            strhtml += ' </ul></li>';
                        }
                    }
                }
                $("#TreeBind").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSectionObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            //try {
            //    this.BindTab_vSection(strListDiv, arrvSectionObjLst);
            //    console.log("完成BindGv_vSection!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
        }
        //-----------------添加节 、修改节、删除；
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
      */
        async btnAddNewRecord_Click() {
            try {
                var strLevelId = $("#hidLevelId").val();
                var strSectionId = $("#hidSectionId").val();
                //论文Id；
                var strPaperId = $('#hidPaperId').val();
                //操作之前 清空编辑区html
                $("#divEdit").html("");
                var objPage = new gs_PaperParagraph();
                var objPage_Edit = new Section_EditEx_js_1.Section_EditEx(objPage);
                //页面传入
                ///   var strzxPageType = $('#hidzxPageType').val();
                if (strLevelId == "1") {
                    //     var GroupTextId = $('#hidGroupTextId').val();
                    //父节点；
                    objPage_Edit.btnAddNewSection_Click(strPaperId, "root");
                }
                else {
                    //这里是等于2，等于3在页面已经处理；
                    objPage_Edit.btnAddNewSection_Click(strPaperId, strSectionId);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        //节修改
        async btn_UpdateSection() {
            //得到修改的主键
            var strSectionId = $('#hidSectionId').val();
            if (strSectionId != "") {
                $("#divEdit").html("");
                var objPage = new gs_PaperParagraph();
                var objPage_Edit = new Section_EditEx_js_1.Section_EditEx(objPage);
                objPage_Edit.btnUpdateRecordInTab_Click(strSectionId);
            } //个人
        }
        //添加子节点论文段落
        async btnAddNewParagraphRecord_Click(strKeyId) {
            try {
                var strSectionId = strKeyId;
                //获取色码块
                var strColorCode = $("#hidColorCode").val();
                //论文Id；
                var strPaperId = $('#hidPaperId').val();
                //操作之前 清空编辑区html
                $("#divEdit").html("");
                var objPage = new gs_PaperParagraph();
                var objPage_Edit = new gs_PaperParagraph_EditEx_js_1.gs_PaperParagraph_EditEx(objPage);
                //添加段落；
                objPage_Edit.btnAddNewParagraph_Click(strPaperId, strSectionId, "", strColorCode);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加中间段落
        async btnAddCenterParagraphRecord_Click(strJieSectionId, orderNum) {
            try {
                var strSectionId = strJieSectionId;
                //获取色码块
                var strColorCode = $("#hidColorCode").val();
                //论文Id；
                var strPaperId = $('#hidPaperId').val();
                //操作之前 清空编辑区html
                $("#divEdit").html("");
                var objPage = new gs_PaperParagraph();
                var objPage_Edit = new gs_PaperParagraph_EditEx_js_1.gs_PaperParagraph_EditEx(objPage);
                //添加段落；
                objPage_Edit.btnAddNewParagraph_Click(strPaperId, strSectionId, orderNum, strColorCode);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        //子节点段落修改
        /* 在数据表里修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdategs_PaperParagraph_Click)
      */
        async btnUpdategs_PaperParagraph_Click(strKeyId) {
            //得到修改的主键
            $('#hidParagraphId').val(strKeyId);
            //获取色码块
            var strColorCode = $("#hidColorCode").val();
            if (strKeyId != "") {
                $("#divEdit").html("");
                var objPage = new gs_PaperParagraph();
                var objPage_Edit = new gs_PaperParagraph_EditEx_js_1.gs_PaperParagraph_EditEx(objPage);
                objPage_Edit.btnUpdategs_PaperParagraph_Click(strKeyId, strColorCode);
            } //个人
        }
        /*
    重序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    */
        async btnReOrder_Click() {
            // if (this.PreCheck4Order() == false) return;
            var strSectionId = $("#hidJieSectionId").val();
            var strPaperId = $("#hidPaperId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "sectionId": strSectionId,
                    "paperId": strPaperId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_ReOrderAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        /*
        上移
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        */
        async btnUpMove_Click() {
            if ($('#hidOrderNum').val() == 0) {
                const responseOrder = await this.btnReOrder_Click();
            }
            //  if (this.PreCheck4Order() == false) return;
            var strSectionId = $("#hidJieSectionId").val();
            var strPaperId = $("#hidPaperId").val();
            var arrKeyIds = $("#hidKeyId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "sectionId": strSectionId,
                    "paperId": strPaperId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_UpMoveAsync)(objOrderByData);
                const responsegs = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_ReFreshCache)();
            }
            catch (e) {
                var strMsg = `上移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            //var strListDiv: string = this.mstrListDiv;
            //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /*
        下移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        */
        async btnDownMove_Click() {
            if ($('#hidOrderNum').val() == 0) {
                const responseOrder = await this.btnReOrder_Click();
            }
            //  if (this.PreCheck4Order() == false) return;
            var strSectionId = $("#hidJieSectionId").val();
            var strPaperId = $("#hidPaperId").val();
            var arrKeyIds = $("#hidKeyId").val();
            //先获取该节点段落最大段落数，如果和排序号相等，那么则是最后一条数据
            var orderNum = $('#hidOrderNum').val();
            var strWhere = " 1=1 And paperId='" + strPaperId + "' And sectionId='" + strSectionId + "'";
            var intCount = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetRecCountByCondAsync)(strWhere);
            if (intCount == orderNum) {
                var strMsg = `该记录已经是最后一条记录`;
                alert(strMsg);
                return;
            }
            else {
                try {
                    var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                    objOrderByData.KeyIdLst = arrKeyIds;
                    var jsonObject = {
                        "sectionId": strSectionId,
                        "paperId": strPaperId,
                    };
                    var jsonStr = JSON.stringify(jsonObject);
                    objOrderByData.ClassificationFieldValueLst = jsonStr;
                    const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_DownMoveAsync)(objOrderByData);
                    const responsegs = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_ReFreshCache)();
                }
                catch (e) {
                    var strMsg = `下移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                    alert(strMsg);
                    return;
                }
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            }
            //const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //var strListDiv: string = this.mstrListDiv;
            //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /*
      * 设置排序字段-相当使用ViewState功能
     */
        set hidSortvgs_PaperParagraphBy(value) {
            $("#hidSortvgs_PaperParagraphBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_PaperParagraphBy() {
            return $("#hidSortvgs_PaperParagraphBy").val();
        }
    }
    exports.gs_PaperParagraph = gs_PaperParagraph;
});

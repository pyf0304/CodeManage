(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.IndexIframe = void 0;
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js");
    const clsqa_PushWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class IndexIframe {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    $('#userName').append(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserName() + '(' + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleName() + ')');
                    //$("#hidUserId").val(objvUserRoleRelation.userId);
                    $("#spanmajorName").html(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_majorName() + '专业');
                    //获得被邀请数
                    const responseIntCount = await this.Bind_QuestionsCount();
                    if ($("#hidPage").val() != "") {
                        var strPage = $("#hidPage").val();
                        switch (strPage) {
                            case "1":
                                $("#li_PaperSee").show();
                                $("#li_PaperMg").show();
                                $("#li_TopicMg").hide();
                                $("#li_MajorDirection").hide();
                                $("#li_PaperQA").hide();
                                $("#li_UserManage").hide();
                                $("#li_UserCenter").hide();
                                $("#li_CurrEduCls").hide();
                                $("#li_SysTools").hide();
                                $("#ulModularName").show();
                                $("#ModularName").html("论文阅读");
                                break;
                            case "2":
                                $("#ulModularName").show();
                                $("#ModularName").html("答疑标注");
                                $("#li_PaperSee").hide();
                                $("#li_PaperMg").hide();
                                $("#li_TopicMg").hide();
                                $("#li_MajorDirection").hide();
                                $("#li_PaperQA").show();
                                $("#li_PaperSee").removeClass("open");
                                $("#li_PaperSee a").removeClass("active");
                                $("#li_PaperQA").addClass("open");
                                //$("#li_PaperQA a").addClass("active");
                                $("#li_PaperQA ul").css("display", "block");
                                $("#li_UserManage").hide();
                                $("#li_UserCenter").hide();
                                $("#li_CurrEduCls").hide();
                                $("#li_SysTools").hide();
                                break;
                            case "3":
                                $("#ulModularName").show();
                                $("#ModularName").html("个人中心");
                                $("#li_PaperSee").hide();
                                $("#li_PaperMg").hide();
                                $("#li_TopicMg").hide();
                                $("#li_MajorDirection").hide();
                                $("#li_PaperQA").hide();
                                $("#li_UserManage").hide();
                                $("#li_UserCenter").show();
                                $("#li_PaperSee").removeClass("open");
                                $("#li_PaperSee a").removeClass("active");
                                $("#li_UserCenter").addClass("open");
                                //$("#li_UserCenter a").addClass("active");
                                $("#li_UserCenter ul").css("display", "block");
                                $("#li_CurrEduCls").hide();
                                $("#li_SysTools").hide();
                                break;
                            case "4":
                                $("#ulModularName").show();
                                $("#ModularName").html("控制中心");
                                $("#li_PaperSee").hide();
                                $("#li_PaperMg").hide();
                                $("#li_TopicMg").hide();
                                $("#li_MajorDirection").hide();
                                $("#li_PaperQA").hide();
                                $("#li_UserManage").hide();
                                $("#li_UserCenter").hide();
                                $("#li_CurrEduCls").show();
                                $("#li_SysTools").show();
                                $("#li_PaperSee").removeClass("open");
                                $("#li_PaperSee a").removeClass("active");
                                $("#li_SysTools").addClass("open");
                                //$("#li_SysTools a").addClass("active");
                                $("#li_SysTools ul").css("display", "block");
                                break;
                            default:
                                break;
                        }
                    }
                    //判断角色
                    //管理员
                    if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                        $("#li_UserManage").show();
                        //$("#li__PaperReadWriteStatistics").show();
                        $("#li__ExplainType").show();
                        $("#li__SubViewpointType").show();
                        $("#li__LiteratureType").show();
                        $("#li__ViewpointType").show();
                        $("#li__DiscussionType").show();
                        $("#pdftest1").show();
                        $("#pdftest2").show();
                        $("#pdftest3").show();
                        $("#comment").show();
                        $("#PaperGroup").show();
                        $("#commentType").show();
                        $("#ScoreWeight").show();
                        $("#ScoreSummaryNew").show();
                        $("#TotalDataStatistics").show(); //数据周期统计
                        //$("#TotalDataStatisticsTest").show();//数据周期统计
                        $("#li_CurrEduCls").show();
                        $("#li_SysTools").show(); //系统设置
                        $("#licc_course").show(); //课程
                        //$("#liCurrEduClsStu").show();//教学班学生；
                        $("#liCurrEduClsTeacher").show(); //教学班老师；
                        $("#liCurrEduClsDate").show(); //教学班日期；
                        $("#liCurrEduCls").show(); //教学班；
                        $("#lixzMajor").show(); //专业；
                        $("#li__ke_Super").show(); //知识分类；
                        $("#li__ke_Sub").show(); //知识详细分类；
                        $("#li__TopicTask").show(); //主题任务状态；
                        $("#liTextType").show(); //课件类型；
                        $("#liUnit").show(); //课件单元；
                        $("#liTextStatus").show(); //课件状态；
                        $("#liGrade").show(); //中学年级；
                        $("#liCacheUseState").show(); //缓存配置；
                        //$("#li__Rela1").hide();
                        //$("#li__Rela2").hide();
                        //$("#li__Rela3").hide();
                        //$("#li__Rela4").hide();
                        //$("#li__Rela5").hide();
                        //$("#li__Rela6").hide();
                        //$("#li_PaperQA").show();//答疑；
                        const responseObjLst = await this.Bind_EduClsTeaList();
                    }
                    //老师
                    else if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                        $("#li_UserManage").hide();
                        //$("#li__PaperReadWriteStatistics").show();
                        $("#li__ExplainType").hide();
                        $("#li__SubViewpointType").hide();
                        $("#li__LiteratureType").hide();
                        $("#li__ViewpointType").hide();
                        $("#li__DiscussionType").hide();
                        $("#TotalDataStatistics").show(); //数据周期统计
                        $("#comment").show();
                        $("#PaperGroup").show();
                        $("#ScoreSummaryNew").show();
                        $("#licc_course").show(); //课程
                        //$("#liCurrEduClsStu").show();//教学班学生；
                        $("#liCurrEduClsTeacher").show(); //教学班老师；
                        $("#liCurrEduClsDate").show(); //教学班日期；
                        $("#liCurrEduCls").show(); //教学班；
                        $("#lixzMajor").show(); //专业；
                        //$("#li_ZXCourseware").show();
                        const responseObjLst = await this.Bind_EduClsTeaList();
                    }
                    //学生
                    else {
                        //if (clsPubSessionStorage.GetSession_UserId() == "0310276") {
                        //    //$("#li_attest1").show();
                        //    //$("#li_attest2").show();
                        //    $("#li_ZXCourseware").show();
                        //}
                        $("#li_UserManage").hide();
                        //$("#li__PaperReadWriteStatistics").hide();
                        $("#li__ExplainType").hide();
                        $("#li__SubViewpointType").hide();
                        $("#li__LiteratureType").hide();
                        $("#li__DiscussionType").hide();
                        $("#PersonalKnowledgeView").hide(); //个人知识点汇总
                        $("#liViewpointShare").show(); //个人观点配置
                        $("#comment").show();
                        $("#PaperGroup").show();
                        $("#ScoreSummaryNew").show();
                        $("#ligs_ReflectLog").show(); //反思日志 ，临时；
                        //const responseObjLst = await this.Bind_EduClsStuList();
                        //$("#EduCls").hide();
                        const responseObjLst = await this.Bind_EduClsStuList();
                    }
                    //$("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Index";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //答疑被邀请数
        async Bind_QuestionsCount() {
            try {
                var strWhereCond = " 1=1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
                strWhereCond += " and receiveUser='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "' and isReceive=0";
                var intQuestionsCount = await (0, clsqa_PushWApi_js_1.qa_Push_GetRecCountByCondAsync)(strWhereCond);
                $("#questionsCount").html(intQuestionsCount);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                //alert(strMsg);
                console.log(strMsg);
            }
        }
        //教学班教师
        async Bind_EduClsTeaList() {
            try {
                var strWhereCond = " teacherID='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "' order by updDate Desc";
                var arrvCurrEduClsTeacherObjLst = [];
                const responseObjLst = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsTeacherObjLst = jsonData;
                });
                var strhtml = "";
                for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                    if (i == 0) {
                        if (clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() == "") {
                            //$("#hidid_CurrEduCls").val(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                            $("#eduClsName").html(arrvCurrEduClsTeacherObjLst[i].eduClsName);
                            //存入session
                            clsPublocalStorage_js_1.clsPublocalStorage.Setid_CurrEduCls(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = arrvCurrEduClsTeacherObjLst[i].eduClsTypeId;
                            clsPublocalStorage_js_1.clsPublocalStorage.SeteduClsName(arrvCurrEduClsTeacherObjLst[i].eduClsName);
                        }
                        else {
                            $("#eduClsName").html(clsPublocalStorage_js_1.clsPublocalStorage.GeteduClsName());
                        }
                    }
                    strhtml += '<dd><a onclick=EduCls_Click("' + arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls + '","' + arrvCurrEduClsTeacherObjLst[i].eduClsName + '","' + arrvCurrEduClsTeacherObjLst[i].eduClsTypeId + '")> ' + arrvCurrEduClsTeacherObjLst[i].eduClsName + '</a></dd>';
                }
                $("#dlEduClsList").html(strhtml);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //教学班学生
        async Bind_EduClsStuList() {
            try {
                var strWhereCond = " stuID='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "' order by modifyDate Desc";
                var arrvCurrEduClsStuObjLst = [];
                const responseObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                });
                var strhtml = "";
                for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                    if (i == 0) {
                        if (clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() == "") {
                            //$("#hidid_CurrEduCls").val(arrvCurrEduClsStuObjLst[i].id_CurrEduCls);
                            $("#eduClsName").html(arrvCurrEduClsStuObjLst[i].eduClsName);
                            //存入session
                            clsPublocalStorage_js_1.clsPublocalStorage.Setid_CurrEduCls(arrvCurrEduClsStuObjLst[i].id_CurrEduCls);
                            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = arrvCurrEduClsStuObjLst[i].eduClsTypeId;
                            clsPublocalStorage_js_1.clsPublocalStorage.SeteduClsName(arrvCurrEduClsStuObjLst[i].eduClsName);
                        }
                        else {
                            $("#eduClsName").html(clsPublocalStorage_js_1.clsPublocalStorage.GeteduClsName());
                        }
                    }
                    strhtml += '<dd><a onclick=EduCls_Click("' + arrvCurrEduClsStuObjLst[i].id_CurrEduCls + '","' + arrvCurrEduClsStuObjLst[i].eduClsName + '","' + arrvCurrEduClsStuObjLst[i].eduClsTypeId + '")> ' + arrvCurrEduClsStuObjLst[i].eduClsName + '</a></dd>';
                }
                $("#dlEduClsList").html(strhtml);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //教学班教师
        async EduCls_Click(strkey, strName, strTypeID) {
            //$("#hidid_CurrEduCls").val(strkey);
            $("#eduClsName").html(strName);
            clsPublocalStorage_js_1.clsPublocalStorage.Setid_CurrEduCls(strkey);
            console.error("已经切换教学班", strkey);
            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = strTypeID;
            clsPublocalStorage_js_1.clsPublocalStorage.SeteduClsName(strName);
            layui_Alert(1, "已切换教学班！");
            $("#Index_iframe")[0].contentWindow.WelcomeLoad_Click();
        }
    }
    exports.IndexIframe = IndexIframe;
});

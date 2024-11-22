(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js", "../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsTeacherExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TopicIframe = void 0;
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js");
    const clsqa_PushWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js");
    const clsvCurrEduClsTeacherExWApi_js_1 = require("../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsTeacherExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class TopicIframe {
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
                    //判断角色
                    //管理员
                    if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                        const responseObjLst = await this.Bind_EduClsTeaList();
                    }
                    //老师
                    else if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                        const responseObjLst = await this.Bind_EduClsTeaList();
                    }
                    //学生
                    else {
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
                arrvCurrEduClsTeacherObjLst = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLstAsync)(strWhereCond);
                arrvCurrEduClsTeacherObjLst = arrvCurrEduClsTeacherObjLst.sort(clsvCurrEduClsTeacherExWApi_js_1.vCurrEduClsTeacherEx_SortFun_OrderNum);
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
            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = strTypeID;
            clsPublocalStorage_js_1.clsPublocalStorage.SeteduClsName(strName);
            layui_Alert(1, "已切换教学班！");
            $("#Topic_iframe")[0].contentWindow.btnQuery_Click();
            //$("#ResearchTopicList")[0].contentWindow.btnQuery_Click();
            RemoveIfame_Click();
        }
    }
    exports.TopicIframe = TopicIframe;
});

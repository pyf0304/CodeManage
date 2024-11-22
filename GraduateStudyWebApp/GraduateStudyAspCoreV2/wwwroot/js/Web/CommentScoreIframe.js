(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js", "../TS/L3_ForWApiEx/DailyRunning_Share/clsCurrEduClsExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CommentScoreIframe = void 0;
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js");
    const clsCurrEduClsExWApi_js_1 = require("../TS/L3_ForWApiEx/DailyRunning_Share/clsCurrEduClsExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CommentScoreIframe {
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    $('#lnkUserName').append(clsPublocalStorage_js_1.clsPublocalStorage.userName + '(' + clsPublocalStorage_js_1.clsPublocalStorage.roleName + ')');
                    $("#spanMajorName").html(clsPublocalStorage_js_1.clsPublocalStorage.majorName + '专业');
                    //获取教学班名称；
                    const responseObjLst = await this.GetCurreduClsNamebyId();
                    //把传递参数存放缓存；
                    clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = $('#hidId_CurrEduClspara').val();
                    ////判断角色
                    ////管理员
                    //if (clsPublocalStorage.roleId == "00620001") {
                    //    const responseObjLst = await this.Bind_EduClsTeaList();
                    //}
                    ////老师
                    //else if (clsPublocalStorage.roleId == "00620002") {
                    //    const responseObjLst = await this.Bind_EduClsTeaList();
                    //}
                    ////学生
                    //else {
                    //    const responseObjLst = await this.Bind_EduClsStuList();
                    //}
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
        //获取教学班名称；
        async GetCurreduClsNamebyId() {
            var objCurrEduCls = new clsCurrEduClsEN_js_1.clsCurrEduClsEN;
            var strWhereCond1 = " id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            // 获取教学班学生数据；
            const responseObjLst3 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetFirstObjAsync)(strWhereCond1).then((jsonData) => {
                objCurrEduCls = jsonData;
                if (objCurrEduCls != null) {
                    $("#CurrEduName").html(objCurrEduCls.eduClsName);
                }
            });
        }
        //教学班教师
        async Bind_EduClsTeaList() {
            try {
                var strWhereCond = " teacherID='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' order by updDate Desc";
                var arrvCurrEduClsTeacherObjLst = [];
                const responseObjLst = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsTeacherObjLst = jsonData;
                });
                var strhtml = "";
                for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                    if (i == 0) {
                        if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "") {
                            //$("#hidid_CurrEduCls").val(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                            $("#spnEduClsName").html(arrvCurrEduClsTeacherObjLst[i].eduClsName);
                            //存入session
                            clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls;
                            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = arrvCurrEduClsTeacherObjLst[i].eduClsTypeId;
                            clsPublocalStorage_js_1.clsPublocalStorage.eduClsName = arrvCurrEduClsTeacherObjLst[i].eduClsName;
                        }
                        else {
                            $("#spnEduClsName").html(clsPublocalStorage_js_1.clsPublocalStorage.eduClsName);
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
                var strWhereCond = " stuID='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' order by modifyDate Desc";
                var arrvCurrEduClsStuObjLst = [];
                const responseObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                });
                var strhtml = "";
                for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                    if (i == 0) {
                        if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "") {
                            //$("#hidid_CurrEduCls").val(arrvCurrEduClsStuObjLst[i].id_CurrEduCls);
                            $("#spnEduClsName").html(arrvCurrEduClsStuObjLst[i].eduClsName);
                            //存入session
                            clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = arrvCurrEduClsStuObjLst[i].id_CurrEduCls;
                            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = arrvCurrEduClsStuObjLst[i].eduClsTypeId;
                            clsPublocalStorage_js_1.clsPublocalStorage.eduClsName = arrvCurrEduClsStuObjLst[i].eduClsName;
                        }
                        else {
                            $("#spnEduClsName").html(clsPublocalStorage_js_1.clsPublocalStorage.eduClsName);
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
            $("#spnEduClsName").html(strName);
            const strCourseId = await (0, clsCurrEduClsExWApi_js_1.CurrEduClsEx_GetCourseIdById_CurrEduCls)(strkey);
            if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == false) {
                clsPublocalStorage_js_1.clsPublocalStorage.courseId = strCourseId;
            }
            clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = strkey;
            clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId = strTypeID;
            clsPublocalStorage_js_1.clsPublocalStorage.eduClsName = strName;
            layui_Alert(1, "已切换教学班！");
            $("#Topic_iframe")[0].contentWindow.btnQuery_Click();
            //$("#ResearchTopicList")[0].contentWindow.btnQuery_Click();
            RemoveIfame_Click();
        }
    }
    exports.CommentScoreIframe = CommentScoreIframe;
});

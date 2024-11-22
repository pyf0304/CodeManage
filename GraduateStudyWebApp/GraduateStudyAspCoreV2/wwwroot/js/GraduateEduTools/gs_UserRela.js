(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_UserRelaWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_UserRelaExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_UserRelaPositionExWApi.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_UserRela = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js");
    const clsgs_UserRelaPositionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js");
    const clsgs_UserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_UserRelaWApi.js");
    const clsgs_UserRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_UserRelaExWApi.js");
    const clsgs_UserRelaPositionExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_UserRelaPositionExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_UserRela {
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //1、从教学班表内获取当前教学班学生
                    //const ddl_UserId_q = await clsDropDownList.BindDdl_CurrEduClsStuUser("ddlUserId_q");
                    var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                    //默认显示数据
                    const gvResult1 = await this.Bind_UserRela(strid_CurrEduCls);
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
        //教学班学生关系
        //public async BindDdl_UserName(ddlUserId_q: string) {
        //    var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //    var objDdl = document.getElementById(ddlUserId_q);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlUserId_q} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    try {
        //        var arrObjLst_Sel: Array<clsvgs_TotalDataStatisticsEN> = await vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync(strWhereCond);
        //        //arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02");//客观数据；
        //        var arrUserId_Set: Set<string> = new Set(arrObjLst_Sel.map(x => x.updUser));
        //        console.log(arrUserId_Set);
        //        var arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //        var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        //        console.log(arrUsersList_Sel);
        //        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
        //        BindDdl_ObjLst(ddlUserId_q, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "教学班用户");
        //        console.log("完成BindDdl_vCurrEduClsStuId!");
        //    }
        //    catch (e) {
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //同步总数据统计
        async btnSynUserRelaNum_Click(strid_CurrEdu) {
            $("#divLoading").show();
            var strSeUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            var strid_CurrEduCls = "";
            if (strid_CurrEdu == "" || strid_CurrEdu == null) {
                strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strid_CurrEduCls = strid_CurrEdu;
            }
            try {
                const responseText1 = await clsgs_UserRelaExWApi_js_1.clsgs_UserRelaExWApi.SynUserRelaNumAsync(strid_CurrEduCls, strSeUserId);
                var returnBool2 = !!responseText1;
                if (returnBool2 == true) {
                    var strInfo = `同步用户关系成功!`;
                    Alert_layer(1, strInfo);
                    const gvResult1 = await this.Bind_UserRela(strid_CurrEduCls);
                    $("#divLoading").hide();
                }
                else {
                    var strInfo = `同步用户关系不成功!`;
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                return responseText1; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `同步用户关系异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }
        //绑定用户关系图
        async Bind_UserRela(strid_CurrEdu) {
            var strSeUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strid_CurrEduCls = "";
            if (strid_CurrEdu == "" || strid_CurrEdu == null) {
                strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strid_CurrEduCls = strid_CurrEdu;
            }
            var strWhereCond = "id_CurrEduCls='" + strid_CurrEduCls + "'";
            var arrvCurrEduClsStuObjLst = [];
            var arrvCurrEduClsTeacherObjLst = [];
            var arrgs_UserRelaObjLst = [];
            var arrgs_UserRelaPositionObjLst = [];
            try {
                //教学班学生
                const responseText1 = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLst_Cache)(strid_CurrEduCls).then((jsonData) => {
                    //const responseText1 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                    console.log("1");
                });
                //教学班教师
                const responseText2 = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLst_Cache)(strid_CurrEduCls).then((jsonData) => {
                    //const responseText2 = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsTeacherObjLst = jsonData;
                    console.log("2");
                });
                //用户关系
                const responseText3 = await (0, clsgs_UserRelaWApi_js_1.gs_UserRela_GetObjLst_Cache)(strid_CurrEduCls).then((jsonData) => {
                    //const responseText3 = await gs_UserRela_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrgs_UserRelaObjLst = jsonData;
                    console.log("3");
                });
                ////计算出圆形坐标
                //var nodeSize = arrvCurrEduClsTeacherObjLst.length + arrvCurrEduClsStuObjLst.length;
                //var center_x = 600;
                //var center_y = 500;
                //var radius = 360;
                //var ii, _i, _layouts: any = [];
                //for (ii = _i = 0; _i < nodeSize; ii = ++_i) {
                //    var x = center_x + radius * Math.sin(2 * Math.PI * ii / nodeSize),
                //        y = center_y + radius * Math.cos(2 * Math.PI * ii / nodeSize);
                //    _layouts.push({ 'x': x, 'y': y });
                //}
                //计算出教师圆形坐标
                var t_nodeSize = arrvCurrEduClsTeacherObjLst.length;
                var t_center_x = 600;
                var t_center_y = 400;
                var t_radius = 60;
                var t_ii, t_i, t_layouts = [];
                if ($("#hidQueryStata").val() == "1") {
                    for (t_ii = t_i = 0; t_i < t_nodeSize; t_ii = ++t_i) {
                        var x = t_center_x + t_radius * Math.sin(2 * Math.PI * t_ii / t_nodeSize), y = t_center_y + t_radius * Math.cos(2 * Math.PI * t_ii / t_nodeSize);
                        t_layouts.push({ 'x': x, 'y': y });
                    }
                }
                else if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "4") {
                    var strWhereCond4 = "id_CurrEduCls='" + strid_CurrEduCls + "' and updUser ='" + strSeUserId + "'";
                    //用户关系
                    const responseText4 = await (0, clsgs_UserRelaPositionWApi_js_1.gs_UserRelaPosition_GetObjLstAsync)(strWhereCond4).then((jsonData) => {
                        //const responseText4 = await gs_UserRelaPosition_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                        arrgs_UserRelaPositionObjLst = jsonData;
                        console.log("3");
                    });
                    //如果用户关系排列数据为空
                    if (arrgs_UserRelaPositionObjLst.length == 0) {
                        //Alert_layer(2, strMsg);
                        $("#hidQueryStata").val("2");
                        $("#btnSaveUserRela").show();
                        //先清除背景色
                        $("#li_IntelligenceArray").removeClass("btn-info");
                        //$("#li_RandomArray").removeClass("btn-info");
                        $("#li_UserArray").removeClass("btn-info");
                        $("#li_Anonymous").removeClass("btn-info");
                        //添加背景色
                        $("#li_RandomArray").addClass("btn-info");
                        var strMsg = "用户关系排列数据为空，请您先在随机图内保存关系图!";
                        alert(strMsg);
                    }
                }
                var strUserInfo1 = "";
                var strUserInfo2 = "";
                var strUserRela = "";
                var j = 0;
                strUserInfo1 += "[";
                strUserInfo2 += "[";
                //教学班教师
                for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                    var strUserId = arrvCurrEduClsTeacherObjLst[i].teacherID;
                    var strUserName = arrvCurrEduClsTeacherObjLst[i].teacherName;
                    var strcolor = this.getRandomColor();
                    var ti = i + 1;
                    if ($("#hidQueryStata").val() == "4") {
                        strUserInfo1 += '{ "id": "' + strUserId + '", "name": "t' + ti + '", "attributes": { "modularity_class": ' + j + ' } },';
                    }
                    else {
                        strUserInfo1 += '{ "id": "' + strUserId + '", "name": "' + strUserName + '", "attributes": { "modularity_class": ' + j + ' } },';
                    }
                    if ($("#hidQueryStata").val() == "1") {
                        var f_x = t_layouts[i].x;
                        var f_y = t_layouts[i].y;
                        strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + f_x + ",y:" + f_y + "},";
                    }
                    else if ($("#hidQueryStata").val() == "2") {
                        strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42]},";
                    }
                    else if ($("#hidQueryStata").val() == "3") {
                        var objgs_UserRelaPosition = arrgs_UserRelaPositionObjLst.find(x => x.userId == strUserId);
                        if (objgs_UserRelaPosition != null) {
                            strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + objgs_UserRelaPosition.x_Position + ",y:" + objgs_UserRelaPosition.y_Position + "},";
                        }
                    }
                    else if ($("#hidQueryStata").val() == "4") {
                        var objgs_UserRelaPosition = arrgs_UserRelaPositionObjLst.find(x => x.userId == strUserId);
                        if (objgs_UserRelaPosition != null) {
                            strUserInfo2 += "{id: " + j + ",name: 't" + ti + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + objgs_UserRelaPosition.x_Position + ",y:" + objgs_UserRelaPosition.y_Position + "},";
                        }
                    }
                    j++;
                }
                //计算出学生圆形坐标
                var s_nodeSize = arrvCurrEduClsStuObjLst.length;
                var s_center_x = 600;
                var s_center_y = 400;
                var s_radius = 330;
                var s_ii, s_i, s_layouts = [];
                if ($("#hidQueryStata").val() == "1") {
                    for (s_ii = s_i = 0; s_i < s_nodeSize; s_ii = ++s_i) {
                        var x = s_center_x + s_radius * Math.sin(2 * Math.PI * s_ii / s_nodeSize), y = s_center_y + s_radius * Math.cos(2 * Math.PI * s_ii / s_nodeSize);
                        s_layouts.push({ 'x': x, 'y': y });
                    }
                }
                //教学班学生
                for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                    var strUserId = arrvCurrEduClsStuObjLst[i].stuID;
                    var strUserName = arrvCurrEduClsStuObjLst[i].stuName;
                    var strcolor = this.getRandomColor();
                    var si = i + 1;
                    if ($("#hidQueryStata").val() == "4") {
                        strUserInfo1 += '{ "id": "' + strUserId + '", "name": "s' + si + '", "attributes": { "modularity_class": ' + j + ' } },';
                    }
                    else {
                        strUserInfo1 += '{ "id": "' + strUserId + '", "name": "' + strUserName + '", "attributes": { "modularity_class": ' + j + ' } },';
                    }
                    if ($("#hidQueryStata").val() == "1") {
                        var f_x = s_layouts[i].x;
                        var f_y = s_layouts[i].y;
                        strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + f_x + ",y:" + f_y + "},";
                    }
                    else if ($("#hidQueryStata").val() == "2") {
                        strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42]},";
                    }
                    else if ($("#hidQueryStata").val() == "3") {
                        var objgs_UserRelaPosition = arrgs_UserRelaPositionObjLst.find(x => x.userId == strUserId);
                        if (objgs_UserRelaPosition != null) {
                            strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + objgs_UserRelaPosition.x_Position + ",y:" + objgs_UserRelaPosition.y_Position + "},";
                        }
                    }
                    else if ($("#hidQueryStata").val() == "4") {
                        var objgs_UserRelaPosition = arrgs_UserRelaPositionObjLst.find(x => x.userId == strUserId);
                        if (objgs_UserRelaPosition != null) {
                            strUserInfo2 += "{id: " + j + ",name: 's" + si + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + objgs_UserRelaPosition.x_Position + ",y:" + objgs_UserRelaPosition.y_Position + "},";
                        }
                    }
                    j++;
                }
                if (strUserInfo1.length > 5) {
                    strUserInfo1 = strUserInfo1.substr(0, strUserInfo1.length - 1);
                }
                if (strUserInfo2.length > 5) {
                    strUserInfo2 = strUserInfo2.substr(0, strUserInfo2.length - 1);
                }
                strUserInfo1 += "]";
                strUserInfo2 += "]";
                var strUserInfo1Json = eval(strUserInfo1);
                var strUserInfo2Json = eval(strUserInfo2);
                //用户关系数据
                //如果用户关系有数据那么就显示关系图
                if (arrgs_UserRelaObjLst.length > 0) {
                    strUserRela += "[";
                    for (var i = 0; i < arrgs_UserRelaObjLst.length; i++) {
                        var strUserId = arrgs_UserRelaObjLst[i].userId;
                        var strUserRelaId = arrgs_UserRelaObjLst[i].userRelaId;
                        strUserRela += '{ "id": "' + i + '", "source": "' + strUserId + '", "target": "' + strUserRelaId + '" },';
                    }
                    strUserRela = strUserRela.substr(0, strUserRela.length - 1);
                    strUserRela += "]";
                    var strUserRelaJson = eval(strUserRela);
                    UserRelaCanvas(strUserInfo1Json, strUserInfo2Json, strUserRelaJson, strSeUserId);
                }
                //else {
                //    //如果没用户关系数据就去同步
                //    const gvResult1 = await this.btnSynUserRelaNum_Click();
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async btnSaveUserRela_Click(strUserRelax_y, strid_CurrEdu) {
            $("#divLoading").show();
            var strJson = '[';
            for (var i = 0; i < strUserRelax_y.length; i++) {
                var userId = strUserRelax_y[i].id;
                var x = strUserRelax_y[i].x;
                var y = strUserRelax_y[i].y;
                var updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                var updUser = clsPublocalStorage_js_1.clsPublocalStorage.userId; // 修改人
                //var id_CurrEduCls: string = clsPublocalStorage.id_CurrEduCls;
                var strid_CurrEduCls = "";
                if (strid_CurrEdu == "" || strid_CurrEdu == null) {
                    strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                }
                else {
                    strid_CurrEduCls = strid_CurrEdu;
                }
                strJson += '{';
                strJson += '"userId":"' + userId + '",';
                strJson += '"updUser":"' + updUser + '",';
                strJson += '"updDate":"' + updDate + '",';
                strJson += '"id_CurrEduCls":"' + strid_CurrEduCls + '",';
                strJson += '"orderNum":' + i + ',';
                strJson += '"x_Position":' + x + ',';
                strJson += '"y_Position":' + y;
                strJson += '},';
            }
            strJson = strJson.substr(0, strJson.length - 1);
            strJson += ']';
            //const responseText = await gs_UserRelaPositionEx_AddNewRecordAsync(strJson).then((jsonData) => {
            //    var returnBool: boolean = jsonData;
            //    if (returnBool == true) {
            //    } else {
            //    }
            //});
            //删除之前的用户关系排列图
            const gvResult1 = await this.DelRecord();
            //添加
            const responseText = await (0, clsgs_UserRelaPositionExWApi_js_1.gs_UserRelaPositionEx_AddNewRecordAsync)(strJson);
            var returnBool = !!responseText;
            if (returnBool == true) {
                var strInfo = `保存用户关系排列图成功!`;
                Alert_layer(1, strInfo);
                $("#hidQueryStata").val("3");
                // var strid_CurrEduCls: string = clsPublocalStorage.id_CurrEduCls;
                var strid_CurrEduCls = "";
                if (strid_CurrEdu == "" || strid_CurrEdu == null) {
                    strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                }
                else {
                    strid_CurrEduCls = strid_CurrEdu;
                }
                const gvResult1 = await this.Bind_UserRela(strid_CurrEduCls);
                $("#divLoading").hide();
            }
            else {
                var strInfo = `保存用户关系排列图不成功!`;
                alert(strInfo);
                $("#divLoading").hide();
            }
        }
        //删除之前的用户关系排列图
        DelRecord() {
            return new Promise((resolve, reject) => {
                try {
                    var strWhere = " id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "' and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                    const responseText = (0, clsgs_UserRelaPositionWApi_js_1.gs_UserRelaPosition_Delgs_UserRelaPositionsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除之前的用户关系排列图成功!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log(strInfo);
                        }
                        else {
                            var strInfo = `删除之前的用户关系排列图记录不成功!`;
                            //显示信息框
                            console.log(strInfo);
                            //alert(strInfo);
                        }
                        console.log("完成DelMultiRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        //获取不同色码
        getRandomColor() {
            return '#' + ('00000' + (Math.random() * 0x1000000 << 0).toString(16)).substr(-6);
        }
        /*
       * 用户
      */
        get userId_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 用户
       */
        set userId_q(value) {
            $("#ddlUserId_q").val(value);
        }
    }
    exports.gs_UserRela = gs_UserRela;
});

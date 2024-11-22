(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L3_ForWApi/Knowledges_Share/clscc_CourseKnowledgesWApi.js", "../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesLogicRelaWApi.js", "../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesLogicWApi.js", "../TS/L3_ForWApiEx/Knowledges/clsgs_KnowledgesLogicExWApi.js", "../TS/L3_ForWApiEx/Knowledges/clsgs_KnowledgesLogicRelaExWApi.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LogicRela = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clscc_CourseKnowledgesWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clscc_CourseKnowledgesWApi.js");
    const clsgs_KnowledgesLogicRelaWApi_js_1 = require("../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesLogicRelaWApi.js");
    const clsgs_KnowledgesLogicWApi_js_1 = require("../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesLogicWApi.js");
    const clsgs_KnowledgesLogicExWApi_js_1 = require("../TS/L3_ForWApiEx/Knowledges/clsgs_KnowledgesLogicExWApi.js");
    const clsgs_KnowledgesLogicRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/Knowledges/clsgs_KnowledgesLogicRelaExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* cc_CourseKnowledgesCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class LogicRela {
        constructor() {
            this.Arrgs_KnowledgesLogicObjLst = [];
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvcc_CourseKnowledgesBy: string = "courseKnowledgeId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                //const gvBindDdl = await this.BindDdl4QueryRegion();
                //this.hidSortvcc_CourseKnowledgesBy = "knowledgeTitle Asc";
                ////2、显示无条件的表内容在GridView中
                //const responseBindGv = await this.BindGv_vcc_CourseKnowledges();
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    const responseBindGv2 = await this.BindGv_gs_KnowledgesLogic();
                    const responseBindGv3 = await this.BindGv_gs_KnowledgesLogicRela();
                    const responseBindGv1 = await this.BindGv_vcc_CourseKnowledges();
                    LoadjsPlumb();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        //绑定左边的知识点标题
        async BindGv_vcc_CourseKnowledges() {
            var strWhereCond = " 1 = 1";
            //获取观点分类
            var arrcc_CourseKnowledgesObjLst = [];
            const responseObjLst = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_GetObjLst_Cache)("").then((jsonData) => {
                arrcc_CourseKnowledgesObjLst = jsonData;
            });
            var strhtml = "";
            let tempArr = arrcc_CourseKnowledgesObjLst;
            for (var i = 0; i < this.Arrgs_KnowledgesLogicObjLst.length; i++) {
                for (var j = 0; j < arrcc_CourseKnowledgesObjLst.length; j++) {
                    if (arrcc_CourseKnowledgesObjLst[j].courseKnowledgeId == this.Arrgs_KnowledgesLogicObjLst[i].courseKnowledgeId) {
                        tempArr.splice(tempArr.indexOf(arrcc_CourseKnowledgesObjLst[j]), 1);
                    }
                }
                //let result = arrcc_CourseKnowledgesObjLst.filter(item => this.Arrgs_KnowledgesLogicObjLst.some(id => id.courseKnowledgeId != arrcc_CourseKnowledgesObjLst[i].courseKnowledgeId));
            }
            //let result = arrcc_CourseKnowledgesObjLst.filter(item => this.Arrgs_KnowledgesLogicObjLst.some(id => id.courseKnowledgeId == item.courseKnowledgeId));
            //let result = this.Arrgs_KnowledgesLogicObjLst.filter(item => arrcc_CourseKnowledgesObjLst.some(id => id.courseKnowledgeId == item.courseKnowledgeId));
            //for (var i = 0; i < arrcc_CourseKnowledgesObjLst.length; i++) {
            //    let result = arrcc_CourseKnowledgesObjLst.filter(item => this.Arrgs_KnowledgesLogicObjLst.some(id => id.courseKnowledgeId != arrcc_CourseKnowledgesObjLst[i].courseKnowledgeId));
            //    //var strKnowledgesNode = document.getElementById("KnowledgesNode");
            //    //var div = document.createElement("div");
            //    //div.className = "node node1css";
            //    //div.setAttribute("data-type", "server");
            //    //div.innerHTML = arrcc_CourseKnowledgesObjLst[i].knowledgeTitle;
            //    ////strKnowledgesNode.a
            //    //strKnowledgesNode.appendChild(div);
            //}
            for (var i = 0; i < tempArr.length; i++) {
                strhtml += '<div id="' + tempArr[i].courseKnowledgeId + '" class="node node1css" data-type="server">' + tempArr[i].knowledgeTitle + '</div>';
            }
            //strhtml += '<div class+="node node1css" data-type="server">' + arrcc_CourseKnowledgesObjLst[0].knowledgeTitle + '</div>';
            $("#KnowledgesNode").html(strhtml);
        }
        //绑定知识点逻辑点位
        async BindGv_gs_KnowledgesLogic() {
            var strKnowledgeGraphId = $("#hidKnowledgeGraphId").val();
            var strWhereCond = " 1=1 and knowledgeGraphId='" + strKnowledgeGraphId + "'";
            //获取观点分类
            var arrgs_KnowledgesLogicObjLst = [];
            const responseObjLst = await (0, clsgs_KnowledgesLogicWApi_js_1.gs_KnowledgesLogic_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_KnowledgesLogicObjLst = jsonData;
            });
            this.Arrgs_KnowledgesLogicObjLst = arrgs_KnowledgesLogicObjLst;
            if (arrgs_KnowledgesLogicObjLst.length > 0) {
                var strLogicJson = '[';
                for (var i = 0; i < arrgs_KnowledgesLogicObjLst.length; i++) {
                    var strCourseKnowledgeId = arrgs_KnowledgesLogicObjLst[i].courseKnowledgeId;
                    var strLogicNodeId = arrgs_KnowledgesLogicObjLst[i].logicNodeId;
                    var strClassName = arrgs_KnowledgesLogicObjLst[i].className;
                    var strCourseKnowledgeTitle = arrgs_KnowledgesLogicObjLst[i].courseKnowledgeTitle;
                    var strX_Position = arrgs_KnowledgesLogicObjLst[i].x_Position;
                    var strY_Position = arrgs_KnowledgesLogicObjLst[i].y_Position;
                    //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                    strLogicJson += '{';
                    strLogicJson += '"courseKnowledgeId":"' + strCourseKnowledgeId + '",';
                    strLogicJson += '"courseKnowledgeTitle":"' + strCourseKnowledgeTitle + '",';
                    strLogicJson += '"logicNodeId":"' + strLogicNodeId + '",';
                    strLogicJson += '"className":"' + strClassName + '",';
                    strLogicJson += '"x_Position":' + strX_Position + ',';
                    strLogicJson += '"y_Position":' + strY_Position;
                    strLogicJson += '},';
                }
                strLogicJson = strLogicJson.substr(0, strLogicJson.length - 1);
                strLogicJson += ']';
                $("#hidLogicNodeJson").val(strLogicJson);
            }
        }
        //绑定知识点逻辑关系
        async BindGv_gs_KnowledgesLogicRela() {
            var strKnowledgeGraphId = $("#hidKnowledgeGraphId").val();
            var strWhereCond = " 1=1 and knowledgeGraphId='" + strKnowledgeGraphId + "'";
            //获取观点分类
            var arrgs_KnowledgesLogicRelaObjLst = [];
            const responseObjLst = await (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_KnowledgesLogicRelaObjLst = jsonData;
            });
            if (arrgs_KnowledgesLogicRelaObjLst.length > 0) {
                var strLogicRelaJson = '[';
                for (var i = 0; i < arrgs_KnowledgesLogicRelaObjLst.length; i++) {
                    var courseKnowledgeTitleA = arrgs_KnowledgesLogicRelaObjLst[i].courseKnowledgeTitleA;
                    var courseKnowledgeTitleB = arrgs_KnowledgesLogicRelaObjLst[i].courseKnowledgeTitleB;
                    var strSourceAnchor = arrgs_KnowledgesLogicRelaObjLst[i].sourceAnchor;
                    var strTargetAnchor = arrgs_KnowledgesLogicRelaObjLst[i].targetAnchor;
                    var strRelaTitle = arrgs_KnowledgesLogicRelaObjLst[i].relaTitle;
                    strLogicRelaJson += '{';
                    strLogicRelaJson += '"courseKnowledgeTitleA":"' + courseKnowledgeTitleA + '",';
                    strLogicRelaJson += '"courseKnowledgeTitleB":"' + courseKnowledgeTitleB + '",';
                    strLogicRelaJson += '"relaTitle":"' + strRelaTitle + '",';
                    strLogicRelaJson += '"sourceAnchor":"' + strSourceAnchor + '",';
                    strLogicRelaJson += '"targetAnchor":"' + strTargetAnchor + '"';
                    strLogicRelaJson += '},';
                }
                strLogicRelaJson = strLogicRelaJson.substr(0, strLogicRelaJson.length - 1);
                strLogicRelaJson += ']';
                $("#hidLogicRelaJson").val(strLogicRelaJson);
            }
        }
        //刷新逻辑关系
        //public async RefreshKnowledgeTitle(ojson: any) {
        //    var arrcc_CourseKnowledgesObjLst: Array<clscc_CourseKnowledgesEN> = [];
        //    const responseObjLst = await cc_CourseKnowledges_GetObjLst_Cache().then((jsonData) => {
        //        arrcc_CourseKnowledgesObjLst = <Array<clscc_CourseKnowledgesEN>>jsonData;
        //    });
        //    var strhtml = "";
        //    let tempArr = arrcc_CourseKnowledgesObjLst;
        //    for (var i = 0; i < ojson.server.length; i++) {
        //        for (var j = 0; j < arrcc_CourseKnowledgesObjLst.length; j++) {
        //            if (arrcc_CourseKnowledgesObjLst[j].courseKnowledgeId == ojson.server[i].id) {
        //                tempArr.splice(tempArr.indexOf(arrcc_CourseKnowledgesObjLst[j]), 1);
        //            }
        //        }
        //        //let result = arrcc_CourseKnowledgesObjLst.filter(item => this.Arrgs_KnowledgesLogicObjLst.some(id => id.courseKnowledgeId != arrcc_CourseKnowledgesObjLst[i].courseKnowledgeId));
        //    }
        //    for (var i = 0; i < tempArr.length; i++) {
        //        strhtml += '<div id="' + tempArr[i].courseKnowledgeId + '" class="node node1css" data-type="server">' + tempArr[i].knowledgeTitle + '</div>';
        //    }
        //    $("#KnowledgesNode").html(strhtml);
        //    LoadjsPlumb();
        //}
        //保存逻辑关系
        async btnSaveLogicRela_Click(ojson) {
            $("#divLoading").show();
            var strKnowledgeGraphId = $("#hidKnowledgeGraphId").val();
            var strLogicJson = '[';
            for (var i = 0; i < ojson.server.length; i++) {
                var strCourseKnowledgeId = ojson.server[i].id;
                var strLogicNodeId = ojson.server[i].divId;
                var strCourseKnowledgeTitle = ojson.server[i].name;
                var strX_Position = ojson.server[i].positionX;
                var strY_Position = ojson.server[i].positionY;
                var strClassName = ojson.server[i].class;
                var strUpdDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                var strUpdUser = clsPublocalStorage_js_1.clsPublocalStorage.userId; // 修改人
                //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                strLogicJson += '{';
                strLogicJson += '"courseKnowledgeId":"' + strCourseKnowledgeId + '",';
                strLogicJson += '"courseKnowledgeTitle":"' + strCourseKnowledgeTitle + '",';
                strLogicJson += '"logicNodeId":"' + strLogicNodeId + '",';
                strLogicJson += '"className":"' + strClassName + '",';
                strLogicJson += '"updUser":"' + strUpdUser + '",';
                strLogicJson += '"updDate":"' + strUpdDate + '",';
                strLogicJson += '"knowledgeGraphId":"' + strKnowledgeGraphId + '",';
                strLogicJson += '"x_Position":' + strX_Position + ',';
                strLogicJson += '"y_Position":' + strY_Position;
                strLogicJson += '},';
            }
            strLogicJson = strLogicJson.substr(0, strLogicJson.length - 1);
            strLogicJson += ']';
            var strLogicRelaJson = '[';
            for (var i = 0; i < ojson.line.length; i++) {
                var strCourseKnowledgeIdA = ojson.line[i].pageSourceId;
                var strCourseKnowledgeIdB = ojson.line[i].pageTargetId;
                var strSourceAnchor = ojson.line[i].pageSourceAnchor;
                var strTargetAnchor = ojson.line[i].pageTargetAnchor;
                var strRelaTitle = ojson.line[i].overlaysText;
                var strUpdDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                var strUpdUser = clsPublocalStorage_js_1.clsPublocalStorage.userId; // 修改人
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                strLogicRelaJson += '{';
                strLogicRelaJson += '"CourseKnowledgeIdA":"' + strCourseKnowledgeIdA + '",';
                strLogicRelaJson += '"courseKnowledgeTitleA":"' + strCourseKnowledgeIdA + '",';
                strLogicRelaJson += '"CourseKnowledgeIdB":"' + strCourseKnowledgeIdB + '",';
                strLogicRelaJson += '"courseKnowledgeTitleB":"' + strCourseKnowledgeIdB + '",';
                strLogicRelaJson += '"sourceAnchor":"' + strSourceAnchor + '",';
                strLogicRelaJson += '"targetAnchor":"' + strTargetAnchor + '",';
                strLogicRelaJson += '"relaTitle":"' + strRelaTitle + '",';
                strLogicRelaJson += '"updUser":"' + strUpdUser + '",';
                strLogicRelaJson += '"updDate":"' + strUpdDate + '",';
                strLogicRelaJson += '"knowledgeGraphId":"' + strKnowledgeGraphId + '"';
                strLogicRelaJson += '},';
            }
            strLogicRelaJson = strLogicRelaJson.substr(0, strLogicRelaJson.length - 1);
            strLogicRelaJson += ']';
            //删除1
            const DelResult1 = await this.DelRecord1();
            //添加1
            const responseText = await (0, clsgs_KnowledgesLogicExWApi_js_1.gs_KnowledgesLogicEx_AddNewRecordAsync)(strLogicJson);
            var returnBool = !!responseText;
            if (returnBool == true) {
                //删除2
                const DelResult2 = await this.DelRecord2();
                //添加2
                const responseText2 = await (0, clsgs_KnowledgesLogicRelaExWApi_js_1.gs_KnowledgesLogicRelaEx_AddNewRecordAsync)(strLogicRelaJson);
                var returnBool2 = !!responseText2;
                if (returnBool2 == true) {
                    var strInfo = `保存逻辑关系图成功!`;
                    Alert_layer(1, strInfo);
                    //const gvResult1 = await this.Bind_UserRela(strid_CurrEduCls);
                    $("#divLoading").hide();
                }
            }
            else {
                var strInfo = `保存用户关系排列图不成功!`;
                alert(strInfo);
                $("#divLoading").hide();
            }
        }
        //删除之前的用户关系排列图
        DelRecord1() {
            return new Promise((resolve, reject) => {
                try {
                    var strKnowledgeGraphId = $("#hidKnowledgeGraphId").val();
                    var strWhere = " knowledgeGraphId='" + strKnowledgeGraphId + "' and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                    const responseText = (0, clsgs_KnowledgesLogicWApi_js_1.gs_KnowledgesLogic_Delgs_KnowledgesLogicsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除知识点逻辑成功!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log(strInfo);
                        }
                        else {
                            var strInfo = `删除知识点逻辑不成功!`;
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
        //删除之前的用户关系排列图
        DelRecord2() {
            return new Promise((resolve, reject) => {
                try {
                    var strKnowledgeGraphId = $("#hidKnowledgeGraphId").val();
                    var strWhere = " knowledgeGraphId='" + strKnowledgeGraphId + "' and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                    const responseText = (0, clsgs_KnowledgesLogicRelaWApi_js_1.gs_KnowledgesLogicRela_Delgs_KnowledgesLogicRelasByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除知识点逻辑关系成功!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log(strInfo);
                        }
                        else {
                            var strInfo = `删除知识点逻辑关系不成功!`;
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
    }
    exports.LogicRela = LogicRela;
});

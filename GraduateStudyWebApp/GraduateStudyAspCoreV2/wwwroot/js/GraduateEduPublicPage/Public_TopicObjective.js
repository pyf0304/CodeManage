(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveExEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "./Public_Viewpoint.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Public_TopicObjective = void 0;
    const clsvTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsvTopicObjectiveExEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveExEN.js");
    const clsgs_TotalDataRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js");
    const clsgs_ViewsClassificationWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsObjectiveAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const Public_Viewpoint_js_1 = require("./Public_Viewpoint.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    class Public_TopicObjective {
        //绑定观点数据
        static async Bind_vTopicObjective(strTopicObjectiveId) {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var strhtml = "";
            var strWhereCond = "1=1 and topicObjectiveId='" + strTopicObjectiveId + "'";
            ////附件
            //var strWhereCondAttachment = "1=1";
            var objvTopicObjective = new clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN;
            //获取图片
            var arrObjectiveAttachmentObjLst = [];
            //var arrObjectiveAttachmentObjLst2: Array<clsObjectiveAttachmentEN> = [];
            try {
                const responseObjLst1 = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvTopicObjective = jsonData;
                });
                const responseObjLst2 = await (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrObjectiveAttachmentObjLst = jsonData;
                });
                //获取用户缓存；
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                if (objvTopicObjective != null) {
                    //客观
                    strhtml += '<div class="info" id="infoTopicObjective">';
                    strhtml += '<ul class="artlist">';
                    strhtml += '<li><span class="rowtit color6">[标题]：</span><span class="abstract-text">' + objvTopicObjective.objectiveName + '</span></li>';
                    strhtml += '<li><span class="rowtit color6">[内容]：</span><span class="abstract-text">' + objvTopicObjective.objectiveContent + '</span></li>';
                    strhtml += '<li><span class="rowtit color6">[推论]：</span><span class="abstract-text">' + objvTopicObjective.conclusion + '</span></li>';
                    //查询附件
                    //arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == objvTopicObjective.topicObjectiveId);
                    if (arrObjectiveAttachmentObjLst.length > 0) {
                        //var strAddressAndPort = "https://www.sh-tz.com/GraduateStudyWebApp/";
                        var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
                            strhtml += '<li><img data-action="zoom" src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px; " alt="" id="txtImgPath' + arrObjectiveAttachmentObjLst[y].objectiveAttachmentId + '"/></li>';
                        }
                    }
                    //获取用户名；
                    var objUser = arrUsers.find(x => x.userId == objvTopicObjective.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(objvTopicObjective.updDate);
                    strhtml += '</li>';
                    //如果当前观点有引用论文，那么就显示论文标题和作者
                    var varCitationId = objvTopicObjective.sourceId;
                    if (varCitationId != "" && varCitationId != null) {
                        var objPaper = await (0, clsPaperExWApi_js_1.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache)(varCitationId, strid_CurrEducls);
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    console.log("完成BindGv_vTopicObjective!");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            return strhtml;
        }
        //绑定观点列表数据
        static async BindList_vTopicObjectiveEx(strOperationType, strVType, arrvTopicObjectiveExObjLst) {
            var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            var strhtml = "";
            var strTitle = "";
            var strType = "";
            var strTypeId = "";
            //判断页面参数
            if (strVType == "01") {
                strTitle = "客观事实";
                strType = "06";
                strTypeId = "07";
                //客观事实
                strhtml += '<div class="info" id="infoFacts"><div class="title btn-3">';
            }
            else if (strVType == "02") {
                strTitle = "客观数据";
                strType = "07";
                strTypeId = "08";
                //个人观点
                strhtml += '<div class="info" id="infoBasis"><div class="title btn-3">';
            }
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            //获取观点图片
            var strWhereCondAttachment = "1=1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var arrObjectiveAttachmentObjLst = [];
            var arrObjectiveAttachmentObjLst2 = [];
            arrObjectiveAttachmentObjLst2 = await (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_GetObjLstAsync)(strWhereCondAttachment);
            //点赞
            var arrSysVoteObjLst = []; //新0605
            //观点关系
            var arrgs_TotalDataRelaObjLst = []; //
            var arrgs_TotalDataRelaObjLst0 = []; //
            //各观点实体
            var arrvViewpointObjLst0 = []; //
            var arrvViewpointObjLst = []; //
            var arrvConceptObjLst0 = []; //
            var arrvConceptObjLst = []; //
            var arrvTopicObjectiveObjLst0 = []; //
            var arrvTopicObjectiveObjLst = []; //
            var arrvSysSkillObjLst0 = []; //
            var arrvSysSkillObjLst = []; //
            var arrvSysSocialRelationsObjLst0 = []; //
            var arrvSysSocialRelationsObjLst = []; //
            //观点分类
            var arrgs_ViewsClassificationObjLst = [];
            //关系查看需要点赞功能
            if (strOperationType == "01" || strOperationType == "07") {
                var strWhereCondLike = `1=1 and voteTypeId='${strType}' And ${clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser} = '${strUserId}'`; //新0605
                const responseRecCount6 = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCondLike).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                const responseRecCount7 = await (0, clsgs_TotalDataRelaWApi_js_1.gs_TotalDataRela_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls).then((jsonData) => {
                    arrgs_TotalDataRelaObjLst0 = jsonData;
                });
                if (strOperationType == "07") {
                    //观点
                    const responseObjLst3 = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLst_Cache)(strid_CurrEducls).then((jsonData) => {
                        arrvViewpointObjLst0 = jsonData;
                    });
                    //概念
                    const responseObjLst4 = await (0, clsvConceptWApi_js_1.vConcept_GetObjLst_Cache)(strid_CurrEducls).then((jsonData) => {
                        arrvConceptObjLst0 = jsonData;
                    });
                    //客观
                    const responseObjLst5 = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLst_Cache)(strid_CurrEducls).then((jsonData) => {
                        arrvTopicObjectiveObjLst0 = jsonData;
                    });
                    //技能
                    const responseObjLst6 = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLst_Cache)(strid_CurrEducls).then((jsonData) => {
                        arrvSysSkillObjLst0 = jsonData;
                    });
                    //社会关系
                    const responseObjLst7 = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetObjLst_Cache)(strid_CurrEducls).then((jsonData) => {
                        arrvSysSocialRelationsObjLst0 = jsonData;
                    });
                }
            }
            if (strOperationType == "06") {
                //主题用户关系
                //主题用户关系
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                var strWhereCond = " 1 = 1 and topicId='" + strTopicId + "' order by updDate Asc";
                //获取观点分类
                const responseObjLst4 = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_ViewsClassificationObjLst = jsonData;
                });
            }
            if (strOperationType == "01") {
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
            }
            else {
                strhtml += '<div style="float:left;"><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
            }
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvTopicObjectiveExObjLst.length; i++) {
                //得到topicObjectiveId；
                var strTopicObjectiveId = arrvTopicObjectiveExObjLst[i].topicObjectiveId;
                //
                var strTotalDataId1 = strTypeId + "00" + strTopicObjectiveId;
                v++;
                //对内容进行换行替换
                var strObjectiveContent = arrvTopicObjectiveExObjLst[i].objectiveContent;
                var strConclusion = arrvTopicObjectiveExObjLst[i].conclusion;
                strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
                strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
                strConclusion = strConclusion.replace(/\r\n/g, strBr);
                strConclusion = strConclusion.replace(/\n/g, strBr);
                //strhtml += v + ".观点：" + arrvTopicObjectiveExObjLst[i].TopicObjectiveName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveExObjLst[i].TopicObjectiveContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveExObjLst[i].TopicObjectiveTypeName + ":" + arrvTopicObjectiveExObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveExObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                if (strOperationType == "06") {
                    var objClassification = arrgs_ViewsClassificationObjLst.find(x => x.classificationId == arrvTopicObjectiveExObjLst[i].memo);
                    if (objClassification != null) {
                        strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveExObjLst[i].objectiveName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')</span></li>';
                    }
                    else {
                        strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveExObjLst[i].objectiveName + '</span>&nbsp;&nbsp;<span style="color:red;">(未分类)</span></li>';
                    }
                }
                else {
                    strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveExObjLst[i].objectiveName + '</span></li>';
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
                //查询附件
                arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == strTopicObjectiveId);
                if (arrObjectiveAttachmentObjLst.length > 0) {
                    for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
                        var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
                        strhtml += '<li><div class="example"><img style="max-width:500px; margin-left: 10px; " src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
                    }
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：</span>';
                if (arrvTopicObjectiveExObjLst[i].okCount != 0) {
                    strhtml += '点赞数：' + arrvTopicObjectiveExObjLst[i].okCount + '&nbsp;&nbsp';
                }
                if (arrvTopicObjectiveExObjLst[i].appraiseCount != 0) {
                    //评论
                    strhtml += '&nbsp;&nbsp;评论数：' + arrvTopicObjectiveExObjLst[i].appraiseCount;
                }
                if (arrvTopicObjectiveExObjLst[i].score != 0) {
                    //评分
                    strhtml += '&nbsp;&nbsp;综合评分：' + arrvTopicObjectiveExObjLst[i].score;
                }
                if (arrvTopicObjectiveExObjLst[i].teaScore != 0) {
                    strhtml += '&nbsp;&nbsp;教师评分：' + arrvTopicObjectiveExObjLst[i].teaScore;
                }
                if (arrvTopicObjectiveExObjLst[i].stuScore != 0) {
                    strhtml += '&nbsp;&nbsp;学生评分：' + arrvTopicObjectiveExObjLst[i].stuScore;
                }
                //引用数
                strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvTopicObjectiveExObjLst[i].citationCount;
                if (arrvTopicObjectiveExObjLst[i].versionCount != 0) {
                    strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvTopicObjectiveExObjLst[i].versionCount;
                }
                if (arrvTopicObjectiveExObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
                }
                strhtml += '</li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                if (strOperationType == "06" || strOperationType == "07") {
                    //得到编辑人名字
                    var objUser = arrUsers.find(x => x.userId == arrvTopicObjectiveExObjLst[i].RelaUpdUser);
                    if (objUser != null) {
                        if (arrvTopicObjectiveExObjLst[i].updUser == arrvTopicObjectiveExObjLst[i].RelaUpdUser) {
                            strhtml += '<span class="rowtit color6">编辑引用人：</span>' + objUser.userName;
                        }
                        else {
                            //得到引用人名字
                            var objUserRT = arrUsers.find(x => x.userId == arrvTopicObjectiveExObjLst[i].updUser);
                            if (objUserRT != null) {
                                strhtml += '<span class="rowtit color6">编辑&nbsp;/&nbsp;引用人：</span>' + objUser.userName + '&nbsp;/&nbsp;' + objUserRT.userName;
                            }
                        }
                    }
                    if (arrvTopicObjectiveExObjLst[i].updDate == arrvTopicObjectiveExObjLst[i].RelaUpdDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color6">编辑引用时间：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvTopicObjectiveExObjLst[i].updDate);
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color6">编辑&nbsp;/&nbsp;引用时间：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvTopicObjectiveExObjLst[i].updDate) + '&nbsp;/&nbsp;' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvTopicObjectiveExObjLst[i].RelaUpdDate);
                    }
                    if (strOperationType == "06") {
                        //加入到观点分类
                        if (arrvTopicObjectiveExObjLst[i].memo == "0000000000") {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="加入当前分类" class="layui-btn layui-btn layui-btn-xs" onclick="btnAddClassificationRecordInTab_Click(' + arrvTopicObjectiveExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe61f;</i>加入分类</button>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="调整当前分类" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateClassificationRecordInTab_Click(' + arrvTopicObjectiveExObjLst[i].mId + ',"' + arrvTopicObjectiveExObjLst[i].memo + '") > <i class="layui-icon" >&#xe642;</i>调整分类</button>';
                        }
                        if (strUserId == arrvTopicObjectiveExObjLst[i].updUser) {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelObjectiveRecordInTab_Click(' + arrvTopicObjectiveExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除引用</button>';
                        }
                        if (arrvTopicObjectiveExObjLst[i].isSubmit != true) {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdObjective_Click("' + strTopicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                        }
                    }
                    else if (strOperationType == "07") {
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == strTopicObjectiveId); //新0605
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;';
                        if (objLike == null) {
                            strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strTopicObjectiveId + '","' + arrvTopicObjectiveExObjLst[i].updUser + '","' + strType + '")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                        }
                        else {
                            strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strTopicObjectiveId + '","' + arrvTopicObjectiveExObjLst[i].updUser + '","' + strType + '")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                        }
                        strhtml += '&nbsp;' + arrvTopicObjectiveExObjLst[i].okCount + '&nbsp;&nbsp;';
                        //评论
                        //strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvTopicObjectiveExObjLst[i].appraiseCount + '</span >';
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "评论', '../GraduateEduTools/SysComment?Key=" + strTopicObjectiveId + "&Type=" + strType + "&User=" + arrvTopicObjectiveExObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrvTopicObjectiveExObjLst[i].appraiseCount + "</span></button >";
                    }
                    if (arrvTopicObjectiveExObjLst[i].versionCount > 0 && arrvTopicObjectiveExObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strTopicObjectiveId + "&Type=" + strType + "')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                }
                else {
                    var objUser = arrUsers.find(x => x.userId == arrvTopicObjectiveExObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color6">编辑用户：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color6">编辑时间：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvTopicObjectiveExObjLst[i].updDate);
                }
                if (strOperationType == "01") {
                    //历史版本
                    if (arrvTopicObjectiveExObjLst[i].versionCount > 0 && arrvTopicObjectiveExObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strTopicObjectiveId + "&Type=" + strType + "')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    if (strUserId == arrvTopicObjectiveExObjLst[i].updUser) {
                        //修改个人观点
                        if (arrvTopicObjectiveExObjLst[i].isSubmit != true) {
                            strhtml += '&nbsp;&nbsp;<button title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strTopicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                            //观点提交
                            strhtml += '&nbsp;&nbsp;<button title="提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + strTopicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>提交</button>';
                            //删除个人观点
                            strhtml += '&nbsp;&nbsp;<button title="删除" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strTopicObjectiveId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                        }
                    }
                    if (strRoleId != "00620003") {
                        //取消提交
                        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + strTopicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                    }
                    //建立观点关系
                    arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1); //
                    strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strTopicObjectiveId + "&TypeId=" + strTypeId + "&OperationType=1','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                }
                else if (strOperationType == "02") {
                    strhtml += '&nbsp;&nbsp;<button title="引用该' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkObjectiveInTab_Click("' + strTopicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                }
                else if (strOperationType == "04") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除关系" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelObjectiveRecordInTab_Click("' + strTopicObjectiveId + '","' + strVType + '") > <i class="layui-icon" >&#xe640;</i>移除</button>';
                }
                else if (strOperationType == "05") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="建立关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkObjectiveInTab_Click("' + strTopicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>建立关系</button>';
                }
                strhtml += '</li>';
                //如果当前观点有引用论文，那么就显示论文标题和作者
                var varCitationId = arrvTopicObjectiveExObjLst[i].sourceId;
                if (varCitationId != "" && varCitationId != null) {
                    var objPaper = await (0, clsPaperExWApi_js_1.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache)(varCitationId, strid_CurrEducls);
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                }
                //主题查看——各观点关系查看
                if (strOperationType == "07") {
                    arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1); //
                    if (arrgs_TotalDataRelaObjLst.length > 0) {
                        strhtml += '<li>';
                        strhtml += await Public_Viewpoint_js_1.Public_Viewpoint.BindList_gs_TotalDataRela(arrgs_TotalDataRelaObjLst);
                        strhtml += "&nbsp;&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('关联观点查看', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strTopicObjectiveId + "&TypeId=" + strTypeId + "&OperationType=2')\"> <i class=\"layui-icon\" >&#xe642;</i>相关观点详细<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                        strhtml += '</li>';
                    }
                }
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定观点视图
        static async BindList_vTopicObjective(strOperationType, strVType, arrvTopicObjectiveObjLst) {
            var arrvTopicObjectiveExObjLst = arrvTopicObjectiveObjLst.map(this.GetVExByV);
            var strHtml = await this.BindList_vTopicObjectiveEx(strOperationType, strVType, arrvTopicObjectiveExObjLst);
            return strHtml;
        }
        //绑定论文观点关系视图
        static async BindList_vgs_PTopicObjectiveRela(strOperationType, strVType, arrvgs_PTopicObjectiveRelaObjLst) {
            var arrvTopicObjectiveExObjLst = arrvgs_PTopicObjectiveRelaObjLst.map(this.GetVExByPV);
            var strHtml = await this.BindList_vTopicObjectiveEx(strOperationType, strVType, arrvTopicObjectiveExObjLst);
            return strHtml;
        }
        //绑定主题观点关系视图
        static async BindList_vRTTopicObjectiveRela(strOperationType, strVType, arrvRTTopicObjectiveRelaObjLst) {
            var arrvTopicObjectiveExObjLst = arrvRTTopicObjectiveRelaObjLst.map(this.GetVExByRTV);
            var strHtml = await this.BindList_vTopicObjectiveEx(strOperationType, strVType, arrvTopicObjectiveExObjLst);
            return strHtml;
        }
        //转换论文观点数据到扩展观点实体
        static GetVExByV(objvTopicObjective) {
            var objvTopicObjectiveEx = new clsvTopicObjectiveExEN_js_1.clsvTopicObjectiveExEN();
            objvTopicObjectiveEx.topicObjectiveId = objvTopicObjective.topicObjectiveId;
            objvTopicObjectiveEx.objectiveName = objvTopicObjective.objectiveName;
            objvTopicObjectiveEx.objectiveContent = objvTopicObjective.objectiveContent;
            objvTopicObjectiveEx.conclusion = objvTopicObjective.conclusion;
            objvTopicObjectiveEx.okCount = objvTopicObjective.okCount;
            objvTopicObjectiveEx.appraiseCount = objvTopicObjective.appraiseCount;
            objvTopicObjectiveEx.score = objvTopicObjective.score;
            objvTopicObjectiveEx.teaScore = objvTopicObjective.teaScore;
            objvTopicObjectiveEx.stuScore = objvTopicObjective.stuScore;
            objvTopicObjectiveEx.citationCount = objvTopicObjective.citationCount;
            objvTopicObjectiveEx.versionCount = objvTopicObjective.versionCount;
            objvTopicObjectiveEx.isSubmit = objvTopicObjective.isSubmit;
            objvTopicObjectiveEx.sourceId = objvTopicObjective.sourceId;
            objvTopicObjectiveEx.updDate = objvTopicObjective.updDate;
            objvTopicObjectiveEx.updUser = objvTopicObjective.updUser;
            //  objvTopicObjectiveEx.userName = objvTopicObjective.userName;
            return objvTopicObjectiveEx;
        }
        //转换论文观点数据到扩展观点实体
        static GetVExByPV(objvgs_PTopicObjectiveRela) {
            var objvTopicObjectiveEx = new clsvTopicObjectiveExEN_js_1.clsvTopicObjectiveExEN();
            objvTopicObjectiveEx.topicObjectiveId = objvgs_PTopicObjectiveRela.topicObjectiveId;
            objvTopicObjectiveEx.objectiveName = objvgs_PTopicObjectiveRela.objectiveName;
            objvTopicObjectiveEx.objectiveContent = objvgs_PTopicObjectiveRela.objectiveContent;
            objvTopicObjectiveEx.conclusion = objvgs_PTopicObjectiveRela.conclusion;
            objvTopicObjectiveEx.okCount = objvgs_PTopicObjectiveRela.okCount;
            objvTopicObjectiveEx.appraiseCount = objvgs_PTopicObjectiveRela.appraiseCount;
            objvTopicObjectiveEx.score = objvgs_PTopicObjectiveRela.score;
            objvTopicObjectiveEx.teaScore = objvgs_PTopicObjectiveRela.teaScore;
            objvTopicObjectiveEx.stuScore = objvgs_PTopicObjectiveRela.stuScore;
            objvTopicObjectiveEx.citationCount = objvgs_PTopicObjectiveRela.citationCount;
            objvTopicObjectiveEx.versionCount = objvgs_PTopicObjectiveRela.versionCount;
            objvTopicObjectiveEx.isSubmit = objvgs_PTopicObjectiveRela.isSubmit;
            objvTopicObjectiveEx.mId = objvgs_PTopicObjectiveRela.mId;
            objvTopicObjectiveEx.updDate = objvgs_PTopicObjectiveRela.objDate;
            objvTopicObjectiveEx.updUser = objvgs_PTopicObjectiveRela.objUserId;
            //  objvTopicObjectiveEx.userName = objvgs_PTopicObjectiveRela.ObjUserName;
            objvTopicObjectiveEx.RelaUpdUser = objvgs_PTopicObjectiveRela.updUser;
            objvTopicObjectiveEx.RelaUpdDate = objvgs_PTopicObjectiveRela.updDate;
            return objvTopicObjectiveEx;
        }
        //转换主题观点数据到扩展观点实体
        static GetVExByRTV(objvRTTopicObjectiveRela) {
            var objvTopicObjectiveEx = new clsvTopicObjectiveExEN_js_1.clsvTopicObjectiveExEN();
            objvTopicObjectiveEx.topicObjectiveId = objvRTTopicObjectiveRela.topicObjectiveId;
            objvTopicObjectiveEx.objectiveName = objvRTTopicObjectiveRela.objectiveName;
            objvTopicObjectiveEx.objectiveContent = objvRTTopicObjectiveRela.objectiveContent;
            objvTopicObjectiveEx.conclusion = objvRTTopicObjectiveRela.conclusion;
            objvTopicObjectiveEx.okCount = objvRTTopicObjectiveRela.okCount;
            objvTopicObjectiveEx.appraiseCount = objvRTTopicObjectiveRela.appraiseCount;
            objvTopicObjectiveEx.score = objvRTTopicObjectiveRela.score;
            objvTopicObjectiveEx.teaScore = objvRTTopicObjectiveRela.teaScore;
            objvTopicObjectiveEx.stuScore = objvRTTopicObjectiveRela.stuScore;
            objvTopicObjectiveEx.citationCount = objvRTTopicObjectiveRela.citationCount;
            objvTopicObjectiveEx.versionCount = objvRTTopicObjectiveRela.versionCount;
            objvTopicObjectiveEx.isSubmit = objvRTTopicObjectiveRela.isSubmit;
            objvTopicObjectiveEx.mId = objvRTTopicObjectiveRela.mId;
            objvTopicObjectiveEx.sourceId = objvRTTopicObjectiveRela.sourceId;
            objvTopicObjectiveEx.updDate = objvRTTopicObjectiveRela.objDate;
            objvTopicObjectiveEx.updUser = objvRTTopicObjectiveRela.objUserId;
            // objvTopicObjectiveEx.userName = objvRTTopicObjectiveRela.ObjUserName;
            objvTopicObjectiveEx.RelaUpdUser = objvRTTopicObjectiveRela.updUser;
            // objvTopicObjectiveEx.RelaUserName = objvRTTopicObjectiveRela.userName
            objvTopicObjectiveEx.RelaUpdDate = objvRTTopicObjectiveRela.updDate;
            objvTopicObjectiveEx.memo = objvRTTopicObjectiveRela.classificationId;
            return objvTopicObjectiveEx;
        }
    }
    exports.Public_TopicObjective = Public_TopicObjective;
});

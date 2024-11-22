(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillExEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubFun/clsPublocalStorage.js", "./Public_Viewpoint.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Public_SysSkill = void 0;
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsvSysSkillExEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillExEN.js");
    const clsgs_TotalDataRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js");
    const clsgs_ViewsClassificationWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const Public_Viewpoint_js_1 = require("./Public_Viewpoint.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    class Public_SysSkill {
        //绑定观点数据
        static async Bind_vSysSkill(strSkillId) {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var strhtml = "";
            var strWhereCond = "1=1 and skillId='" + strSkillId + "'";
            var objvSysSkill = new clsvSysSkillEN_js_1.clsvSysSkillEN;
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseObjLst = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvSysSkill = jsonData;
                });
                if (objvSysSkill != null) {
                    //概念
                    //技能
                    strhtml += '<div class="info" id="infoSysskill">';
                    strhtml += '<ul class="artlist">';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[技能]：</span><span class="abstract-text">' + objvSysSkill.skillName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvSysSkill.operationTypeName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[保密等级]：</span><span class="abstract-text">' + objvSysSkill.levelName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[实施过程]：</span><span class="abstract-text">' + objvSysSkill.process + '</span></li>';
                    var objUser = arrUsers.find(x => x.userId == objvSysSkill.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(objvSysSkill.updDate);
                    strhtml += '</li>';
                    //如果当前观点有引用论文，那么就显示论文标题和作者
                    var varCitationId = objvSysSkill.citationId;
                    if (varCitationId != "" && varCitationId != null) {
                        var objPaper = await (0, clsPaperExWApi_js_1.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache)(varCitationId, strid_CurrEducls);
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    console.log("完成BindGv_SysSkill!");
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
        static async BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst) {
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var strhtml = "";
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
                var strWhereCondLike = `1=1 and voteTypeId='09' And ${clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser} = '${strUserId}'`; //新0605
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
            strhtml += '<div class="info" id="infoSysskill"><div class="title btn-3">';
            if (strOperationType == "01") {
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加技能" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加技能</button></div>';
            }
            else {
                strhtml += '<div style="float:left;"><a href="#" title="技能">技能</a></div>';
            }
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvSysSkillExObjLst.length; i++) {
                //得到skillId；
                var strSkillId = arrvSysSkillExObjLst[i].skillId;
                //各观点关系
                var strTotalDataId1 = "09" + strSkillId;
                v++;
                var strProcess = arrvSysSkillExObjLst[i].process;
                strProcess = strProcess.replace(/\r\n/g, strBr);
                strProcess = strProcess.replace(/\n/g, strBr);
                if (strOperationType == "06") {
                    var objClassification = arrgs_ViewsClassificationObjLst.find(x => x.classificationId == arrvSysSkillExObjLst[i].memo);
                    if (objClassification != null) {
                        strhtml += '<li><span class="rowtit color6">[技能]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].skillName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')</span></li>';
                    }
                    else {
                        strhtml += '<li><span class="rowtit color6">[技能]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].skillName + '</span>&nbsp;&nbsp;<span style="color:red;">(未分类)</span></li>';
                    }
                }
                else {
                    strhtml += '<li><span class="rowtit color6">[技能]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].skillName + '</span></li>';
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].operationTypeName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[保密等级]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].levelName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[实施过程]：</span><span class="abstract-text">' + strProcess + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
                if (arrvSysSkillExObjLst[i].okCount != 0) {
                    strhtml += '点赞数：' + arrvSysSkillExObjLst[i].okCount + '&nbsp;&nbsp';
                }
                if (arrvSysSkillExObjLst[i].appraiseCount != 0) {
                    //评论
                    strhtml += '&nbsp;&nbsp;评论数：' + arrvSysSkillExObjLst[i].appraiseCount;
                }
                if (arrvSysSkillExObjLst[i].score != 0) {
                    //评分
                    strhtml += '&nbsp;&nbsp;综合评分：' + arrvSysSkillExObjLst[i].score;
                }
                if (arrvSysSkillExObjLst[i].teaScore != 0) {
                    strhtml += '&nbsp;&nbsp;教师评分：' + arrvSysSkillExObjLst[i].teaScore;
                }
                if (arrvSysSkillExObjLst[i].stuScore != 0) {
                    strhtml += '&nbsp;&nbsp;学生评分：' + arrvSysSkillExObjLst[i].stuScore;
                }
                //引用数
                strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvSysSkillExObjLst[i].citationCount;
                if (arrvSysSkillExObjLst[i].versionCount != 0) {
                    strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvSysSkillExObjLst[i].versionCount;
                }
                if (arrvSysSkillExObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
                }
                strhtml += '</li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                var objUser = arrUsers.find(x => x.userId == arrvSysSkillExObjLst[i].updUser);
                var objUser2 = arrUsers.find(x => x.userId == arrvSysSkillExObjLst[i].RelaUpdUser);
                if (strOperationType == "06" || strOperationType == "07") {
                    if (objUser != null && objUser2 != null) {
                        if (arrvSysSkillExObjLst[i].updUser == arrvSysSkillExObjLst[i].RelaUpdUser) {
                            strhtml += '<span class="rowtit color4">编辑引用人：</span>' + objUser.userName;
                        }
                        else {
                            strhtml += '<span class="rowtit color4">编辑&nbsp;/&nbsp;引用人：</span>' + objUser.userName + '&nbsp;/&nbsp;' + objUser2.userName;
                        }
                    }
                    if (arrvSysSkillExObjLst[i].updDate == arrvSysSkillExObjLst[i].RelaUpdDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑引用时间：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].updDate);
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑&nbsp;/&nbsp;引用时间：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].updDate) + '&nbsp;/&nbsp;' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].RelaUpdDate);
                    }
                    if (strOperationType == "06") {
                        //加入到观点分类
                        if (arrvSysSkillExObjLst[i].memo == "0000000000") {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="加入当前分类" class="layui-btn layui-btn layui-btn-xs" onclick="btnAddClassificationRecordInTab_Click(' + arrvSysSkillExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe61f;</i>加入分类</button>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="调整当前分类" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateClassificationRecordInTab_Click(' + arrvSysSkillExObjLst[i].mId + ',"' + arrvSysSkillExObjLst[i].memo + '") > <i class="layui-icon" >&#xe642;</i>调整分类</button>';
                        }
                        if (strUserId == arrvSysSkillExObjLst[i].updUser) {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelSysskillRecordInTab_Click(' + arrvSysSkillExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                        }
                        if (arrvSysSkillExObjLst[i].isSubmit != true) {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdSysskill_Click("' + strSkillId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                        }
                    }
                    else if (strOperationType == "07") {
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSkillId); //新0605
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;';
                        if (objLike == null) {
                            strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strSkillId + '","' + arrvSysSkillExObjLst[i].updUser + '","09")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                        }
                        else {
                            strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strSkillId + '","' + arrvSysSkillExObjLst[i].updUser + '","09")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                        }
                        strhtml += '&nbsp;' + arrvSysSkillExObjLst[i].okCount + '&nbsp;&nbsp;';
                        //评论
                        //strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvSysSkillExObjLst[i].appraiseCount + '</span >';
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('相关技能评论', '../GraduateEduTools/SysComment?Key=" + strSkillId + "&Type=09&User=" + arrvSysSkillExObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrvSysSkillExObjLst[i].appraiseCount + "</span></button >";
                        //建立观点关系
                    }
                    if (arrvSysSkillExObjLst[i].versionCount > 0 && arrvSysSkillExObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strSkillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                }
                else {
                    if (objUser != null) {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑用户：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑时间：</span>' + Public_Viewpoint_js_1.Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].updDate);
                }
                if (strOperationType == "01") {
                    //历史版本
                    if (arrvSysSkillExObjLst[i].versionCount > 0 && arrvSysSkillExObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strSkillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    if (strUserId == arrvSysSkillExObjLst[i].updUser) {
                        if (arrvSysSkillExObjLst[i].isSubmit != true) {
                            //修改个人观点
                            strhtml += '&nbsp;&nbsp;<button title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSkillId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                            //删除个人观点
                            strhtml += '&nbsp;&nbsp;<button title="删除" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSkillId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                            //观点提交
                            strhtml += '&nbsp;&nbsp;<button title="提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + strSkillId + '")> <i class="layui-icon" >&#xe642;</i>提交</button>';
                        }
                    }
                    if (strRoleId != "00620003") {
                        //取消提交
                        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + strSkillId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                    }
                    //建立观点关系
                    arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1); //
                    strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strSkillId + "&TypeId=09&OperationType=1','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
                }
                else if (strOperationType == "02") {
                    strhtml += '&nbsp;&nbsp;<button title="引用相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSysskillInTab_Click("' + strSkillId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';
                }
                else if (strOperationType == "04") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除关系" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelSysskillRecordInTab_Click("' + strSkillId + '") > <i class="layui-icon" >&#xe640;</i>移除</button>';
                }
                else if (strOperationType == "05") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="建立关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSysskillInTab_Click("' + strSkillId + '")> <i class="layui-icon" >&#xe642;</i>建立关系</button>';
                }
                strhtml += '</li>';
                //如果当前观点有引用论文，那么就显示论文标题和作者
                var varCitationId = arrvSysSkillExObjLst[i].citationId;
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
                        strhtml += "&nbsp;&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('关联观点查看', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strSkillId + "&TypeId=09&OperationType=2')\"> <i class=\"layui-icon\" >&#xe642;</i>相关观点详细<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                        strhtml += '</li>';
                    }
                }
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定观点视图
        static async BindList_vSysSkill(strOperationType, arrvSysSkillObjLst) {
            var arrvSysSkillExObjLst = arrvSysSkillObjLst.map(this.GetVExByV);
            var strHtml = await this.BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst);
            return strHtml;
        }
        //绑定论文观点关系视图
        static async BindList_vgs_PSkillRela(strOperationType, arrvgs_PSkillRelaObjLst) {
            var arrvSysSkillExObjLst = arrvgs_PSkillRelaObjLst.map(this.GetVExByPV);
            var strHtml = await this.BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst);
            return strHtml;
        }
        //绑定主题观点关系视图
        static async BindList_vRTSysSkill(strOperationType, arrvRTSysSkillObjLst) {
            var arrvSysSkillExObjLst = arrvRTSysSkillObjLst.map(this.GetVExByRTV);
            var strHtml = await this.BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst);
            return strHtml;
        }
        //转换论文观点数据到扩展观点实体
        static GetVExByV(objvSysSkill) {
            var objvSysSkillEx = new clsvSysSkillExEN_js_1.clsvSysSkillExEN();
            objvSysSkillEx.skillId = objvSysSkill.skillId;
            objvSysSkillEx.skillName = objvSysSkill.skillName;
            objvSysSkillEx.operationTypeName = objvSysSkill.operationTypeName;
            objvSysSkillEx.process = objvSysSkill.process;
            objvSysSkillEx.okCount = objvSysSkill.okCount;
            objvSysSkillEx.appraiseCount = objvSysSkill.appraiseCount;
            objvSysSkillEx.score = objvSysSkill.score;
            objvSysSkillEx.teaScore = objvSysSkill.teaScore;
            objvSysSkillEx.stuScore = objvSysSkill.stuScore;
            objvSysSkillEx.citationCount = objvSysSkill.citationCount;
            objvSysSkillEx.versionCount = objvSysSkill.versionCount;
            objvSysSkillEx.isSubmit = objvSysSkill.isSubmit;
            objvSysSkillEx.citationId = objvSysSkill.citationId;
            objvSysSkillEx.updDate = objvSysSkill.updDate;
            objvSysSkillEx.updUser = objvSysSkill.updUser;
            return objvSysSkillEx;
        }
        //转换论文观点数据到扩展观点实体
        static GetVExByPV(objvgs_PSkillRela) {
            var objvSysSkillEx = new clsvSysSkillExEN_js_1.clsvSysSkillExEN();
            objvSysSkillEx.skillId = objvgs_PSkillRela.skillId;
            objvSysSkillEx.skillName = objvgs_PSkillRela.skillName;
            objvSysSkillEx.operationTypeName = objvgs_PSkillRela.operationTypeName;
            objvSysSkillEx.process = objvgs_PSkillRela.process;
            objvSysSkillEx.okCount = objvgs_PSkillRela.okCount;
            objvSysSkillEx.appraiseCount = objvgs_PSkillRela.appraiseCount;
            objvSysSkillEx.score = objvgs_PSkillRela.score;
            objvSysSkillEx.teaScore = objvgs_PSkillRela.teaScore;
            objvSysSkillEx.stuScore = objvgs_PSkillRela.stuScore;
            objvSysSkillEx.citationCount = objvgs_PSkillRela.citationCount;
            objvSysSkillEx.versionCount = objvgs_PSkillRela.versionCount;
            objvSysSkillEx.isSubmit = objvgs_PSkillRela.isSubmit;
            objvSysSkillEx.mId = objvgs_PSkillRela.mId;
            objvSysSkillEx.updDate = objvgs_PSkillRela.skillDate;
            objvSysSkillEx.updUser = objvgs_PSkillRela.skillUserId;
            objvSysSkillEx.RelaUpdUser = objvgs_PSkillRela.updUser;
            objvSysSkillEx.RelaUpdDate = objvgs_PSkillRela.updDate;
            return objvSysSkillEx;
        }
        //转换主题观点数据到扩展观点实体
        static GetVExByRTV(objvRTSysSkill) {
            var objvSysSkillEx = new clsvSysSkillExEN_js_1.clsvSysSkillExEN();
            objvSysSkillEx.skillId = objvRTSysSkill.skillId;
            objvSysSkillEx.skillName = objvRTSysSkill.skillName;
            objvSysSkillEx.operationTypeName = objvRTSysSkill.operationTypeName;
            objvSysSkillEx.process = objvRTSysSkill.process;
            objvSysSkillEx.okCount = objvRTSysSkill.okCount;
            objvSysSkillEx.appraiseCount = objvRTSysSkill.appraiseCount;
            objvSysSkillEx.score = objvRTSysSkill.score;
            objvSysSkillEx.teaScore = objvRTSysSkill.teaScore;
            objvSysSkillEx.stuScore = objvRTSysSkill.stuScore;
            objvSysSkillEx.citationCount = objvRTSysSkill.citationCount;
            objvSysSkillEx.versionCount = objvRTSysSkill.versionCount;
            objvSysSkillEx.isSubmit = objvRTSysSkill.isSubmit;
            objvSysSkillEx.mId = objvRTSysSkill.mId;
            objvSysSkillEx.citationId = objvRTSysSkill.citationId;
            objvSysSkillEx.updDate = objvRTSysSkill.skillUpdDate;
            objvSysSkillEx.updUser = objvRTSysSkill.skillUpdUser;
            objvSysSkillEx.RelaUpdUser = objvRTSysSkill.updUser;
            objvSysSkillEx.RelaUpdDate = objvRTSysSkill.updDate;
            objvSysSkillEx.memo = objvRTSysSkill.classificationId;
            return objvSysSkillEx;
        }
    }
    exports.Public_SysSkill = Public_SysSkill;
});

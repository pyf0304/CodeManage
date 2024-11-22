(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L0_EntityEx/GraduateEduTopic/clsvViewpointExEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Public_Viewpoint = void 0;
    const clsRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsvViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsvViewpointExEN_js_1 = require("../TS/L0_EntityEx/GraduateEduTopic/clsvViewpointExEN.js");
    const clsgs_TotalDataRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js");
    const clsgs_ViewsClassificationWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsViewpointAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsvPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsSysPara4WebApi2_js_1 = require("../TS/PubFun/clsSysPara4WebApi2.js");
    class Public_Viewpoint {
        //绑定观点数据
        static async Bind_vViewpoint(strViewpointId) {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var strhtml = "";
            var strWhereCond = "1=1 and viewpointId='" + strViewpointId + "'";
            var objvViewpoint = new clsvViewpointEN_js_1.clsvViewpointEN;
            //获取图片
            var arrViewpointAttachmentObjLst = [];
            try {
                const responseObjLst1 = await (0, clsvViewpointWApi_js_1.vViewpoint_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvViewpoint = jsonData;
                });
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                const responseObjLst2 = await (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrViewpointAttachmentObjLst = jsonData;
                });
                if (objvViewpoint != null) {
                    //个人观点
                    strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点]：</span><span class="abstract-text">' + objvViewpoint.viewpointName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[内容]：</span><span class="abstract-text">' + objvViewpoint.viewpointContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvViewpoint.viewpointTypeName + ']：</span><span class="abstract-text">' + objvViewpoint.reason + '</span></li>';
                    //查询附件
                    //arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == objvViewpoint.viewpointId);
                    if (arrViewpointAttachmentObjLst.length > 0) {
                        //var strAddressAndPort = "https://www.sh-tz.com/GraduateStudyWebApp/";
                        var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
                            strhtml += '<li><img data-action="zoom" src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px; " alt="" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></li>';
                        }
                    }
                    var objUser = arrUsers.find(x => x.userId == objvViewpoint.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + this.substrDate(objvViewpoint.updDate);
                    strhtml += '</li>';
                    //if (objvViewpoint.citationId != "" && objvViewpoint.citationId != null) {
                    //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    //}
                    //如果当前观点有引用论文，那么就显示论文标题和作者
                    var varCitationId = objvViewpoint.citationId;
                    if (varCitationId != "" && varCitationId != null) {
                        var objPaper = await (0, clsvPaperExWApi_js_1.vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache)(varCitationId, strid_CurrEducls);
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    console.log("完成BindGv_vViewpoint!");
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
        static async BindList_vViewpointEx(strOperationType, strVType, arrvViewpointExObjLst) {
            var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            var strWhereCondAttachment = "1=1 and id_CurrEduCls='" + strid_CurrEducls + "'";
            //获取观点图片
            var arrViewpointAttachmentObjLst = [];
            var arrViewpointAttachmentObjLst2 = [];
            const responseRecCount = await (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_GetObjLstAsync)(strWhereCondAttachment).then((jsonData) => {
                arrViewpointAttachmentObjLst2 = jsonData;
            });
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //点赞
            var arrSysVoteObjLst = []; //新0605
            //观点关系
            var arrgs_TotalDataRelaObjLst = []; //
            var arrgs_TotalDataRelaObjLst0 = []; //
            //主题用户关系列表
            //var arrRTUserRelaObjLst: Array<clsRTUserRelaEN> = [];
            var objRTUserRela = new clsRTUserRelaEN_js_1.clsRTUserRelaEN;
            //观点分类
            var arrgs_ViewsClassificationObjLst = [];
            //strOperationType == "01" 01是主题各个观点界面的主维护界面，有添加、修改、删除、提交、取消提交、建立观点关系等功能权限（应用在后台维护）
            //strOperationType == "02" 02是作为引用当前观点的数据列表使用，一般主题观点关系引用观点、论文观点关系引用观点等界面的弹出框引用界面使用
            //strOperationType == "03" 03
            //strOperationType == "04" 04 这个类型是用于“移除关系的”，主要应用在各个观点建立观点关系以后，显示的观点列表，如果如要接触关系那么就需要这个列表进行移除
            //strOperationType == "05" 05 这个类型是用于“建立观点关系”界面，主要应用添加各个观点的时候弹出框内展示的各个观点可以进行“添加关系”操作（和引用功能类似，但是因为子不同，避免造成歧义就分出来一个操作类型）
            //strOperationType == "06" 06 主题维护界面专门用于显示各个主题和观点建立关系的列表，主要功能是修改观点、移除主题关系等功能
            //strOperationType == "07" 07 主题查看界面使用，主要提供列表查看、点赞、评论、历史版本、各个观点关系的查看功能；
            var strhtml = "";
            var strTitle = "";
            var strType = "";
            var strTypeId = "";
            //判断页面参数
            if (strVType == "01") {
                strTitle = "个人观点";
                strType = "03";
                strTypeId = "04";
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
            }
            else if (strVType == "02") {
                //专家观点
                //$("#ListTitle").html("当前论文相关的专家观点");
                strTitle = "专家观点";
                strType = "04";
                strTypeId = "05";
                strhtml += '<div class="info" id="infoExpert"><div class="title btn-3">';
            }
            //关系查看需要点赞功能
            if (strOperationType == "01" || strOperationType == "07") {
                var strWhereCondLike = `1=1 and voteTypeId='${strType}' And ${clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser} = '${strUserId}'`; //新0605
                const responseRecCount1 = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCondLike).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                const responseRecCount2 = await (0, clsgs_TotalDataRelaWApi_js_1.gs_TotalDataRela_GetObjLst_Cache)(strid_CurrEducls).then((jsonData) => {
                    arrgs_TotalDataRelaObjLst0 = jsonData;
                });
            }
            if (strOperationType == "06") {
                //主题用户关系
                var strTopicId = arrvViewpointExObjLst[0].memo;
                var strWhereCond3 = "topicId ='" + strTopicId + "' and topicUserRoleId='0002'";
                const responseObjLst3 = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetFirstObjAsync)(strWhereCond3).then((jsonData) => {
                    objRTUserRela = jsonData;
                });
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
            for (var i = 0; i < arrvViewpointExObjLst.length; i++) {
                //得到viewpointId；
                var strViewpointId = arrvViewpointExObjLst[i].viewpointId;
                //各观点关系
                var strTotalDataId1 = strTypeId + "00" + strViewpointId;
                v++;
                //对内容进行换行替换
                var strViewpointContent = arrvViewpointExObjLst[i].viewpointContent;
                var strReason = arrvViewpointExObjLst[i].reason;
                strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
                strViewpointContent = strViewpointContent.replace(/\n/g, strBr);
                strReason = strReason.replace(/\r\n/g, strBr);
                strReason = strReason.replace(/\n/g, strBr);
                if (strOperationType == "06") {
                    var objClassification = arrgs_ViewsClassificationObjLst.find(x => x.classificationId == arrvViewpointExObjLst[i].classificationId);
                    if (objClassification != null) {
                        if (arrvViewpointExObjLst[i].isRecommend == true) {
                            strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointExObjLst[i].viewpointName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')(小组推荐观点)</span></li>';
                        }
                        else {
                            strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointExObjLst[i].viewpointName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')</span></li>';
                        }
                    }
                    else {
                        if (arrvViewpointExObjLst[i].isRecommend == true) {
                            strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointExObjLst[i].viewpointName + '</span><span style="color:red;">(小组推荐观点)</span></li>';
                        }
                        else {
                            strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointExObjLst[i].viewpointName + '</span>&nbsp;&nbsp;<span style="color:red;">(未分类)</span></li>';
                        }
                    }
                }
                else {
                    if (arrvViewpointExObjLst[i].isRecommend == true) {
                        strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointExObjLst[i].viewpointName + '</span><span style="color:red;">(小组推荐观点)</span></li>';
                    }
                    else {
                        strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointExObjLst[i].viewpointName + '</span></li>';
                    }
                }
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointExObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';
                //查询附件
                arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
                if (arrViewpointAttachmentObjLst.length > 0) {
                    for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
                        var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
                        strhtml += '<li><div class="example"><img style="max-width:500px; margin-left: 10px; " src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
                    }
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：</span>';
                if (arrvViewpointExObjLst[i].okCount != 0) {
                    strhtml += '点赞数：' + arrvViewpointExObjLst[i].okCount + '&nbsp;&nbsp';
                }
                if (arrvViewpointExObjLst[i].appraiseCount != 0) {
                    //评论
                    strhtml += '&nbsp;&nbsp;评论数：' + arrvViewpointExObjLst[i].appraiseCount;
                }
                if (arrvViewpointExObjLst[i].score != 0) {
                    //评分
                    strhtml += '&nbsp;&nbsp;综合评分：' + arrvViewpointExObjLst[i].score;
                }
                if (arrvViewpointExObjLst[i].teaScore != 0) {
                    strhtml += '&nbsp;&nbsp;教师评分：' + arrvViewpointExObjLst[i].teaScore;
                }
                if (arrvViewpointExObjLst[i].stuScore != 0) {
                    strhtml += '&nbsp;&nbsp;学生评分：' + arrvViewpointExObjLst[i].stuScore + '&nbsp;&nbsp;';
                }
                //引用数
                strhtml += '被引用数：' + arrvViewpointExObjLst[i].citationCount;
                if (arrvViewpointExObjLst[i].versionCount != 0) {
                    strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvViewpointExObjLst[i].versionCount;
                }
                if (arrvViewpointExObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
                }
                strhtml += '</li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                if (strOperationType == "06" || strOperationType == "07") {
                    var objUser = arrUsers.find(x => x.userId == arrvViewpointExObjLst[i].RelaUpdUser);
                    if (objUser != null) {
                        if (arrvViewpointExObjLst[i].updUser == arrvViewpointExObjLst[i].RelaUpdUser) {
                            strhtml += '<span class="rowtit color3">编辑引用人：</span>' + objUser.userName;
                        }
                        else {
                            var objUserRT = arrUsers.find(x => x.userId == arrvViewpointExObjLst[i].updUser);
                            if (objUserRT != null) {
                                strhtml += '<span class="rowtit color3">编辑&nbsp;/&nbsp;引用人：</span>' + objUser.userName + '&nbsp;/&nbsp;' + objUserRT.userName;
                            }
                        }
                    }
                    if (arrvViewpointExObjLst[i].updDate == arrvViewpointExObjLst[i].RelaUpdDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑引用时间：</span>' + this.substrDate(arrvViewpointExObjLst[i].updDate);
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑&nbsp;/&nbsp;引用时间：</span>' + this.substrDate(arrvViewpointExObjLst[i].updDate) + '&nbsp;/&nbsp;' + this.substrDate(arrvViewpointExObjLst[i].RelaUpdDate);
                    }
                    if (strOperationType == "06") {
                        //加入到观点分类
                        if (arrvViewpointExObjLst[i].classificationId == "0000000000") {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="加入当前分类" class="layui-btn layui-btn layui-btn-xs" onclick="btnAddClassificationRecordInTab_Click(' + arrvViewpointExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe61f;</i>加入分类</button>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="调整当前分类" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateClassificationRecordInTab_Click(' + arrvViewpointExObjLst[i].mId + ',"' + arrvViewpointExObjLst[i].classificationId + '") > <i class="layui-icon" >&#xe642;</i>调整分类</button>';
                        }
                        if (strUserId == arrvViewpointExObjLst[i].updUser) {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelViewPointRelaRecordInTab_Click(' + arrvViewpointExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                        }
                        if (arrvViewpointExObjLst[i].isSubmit != true) {
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdViewPoint_Click("' + strViewpointId + '","' + strVType + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                        }
                        //如果是小组长就可以对该篇观点可以推荐
                        var strRTUserId = objRTUserRela.userId;
                        if (strRTUserId == strUserId) {
                            if (arrvViewpointExObjLst[i].isRecommend != true) {
                                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="小组推荐" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnRecommendViewPoint_Click("' + strViewpointId + '","' + strVType + '") > <i class="layui-icon" >&#xe604;</i>小组推荐</button>';
                            }
                        }
                    }
                    else if (strOperationType == "07") {
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId); //新0605
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;';
                        if (objLike == null) {
                            strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strViewpointId + '","' + arrvViewpointExObjLst[i].updUser + '","' + strType + '")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                        }
                        else {
                            strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strViewpointId + '","' + arrvViewpointExObjLst[i].updUser + '","' + strType + '")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                        }
                        strhtml += '&nbsp;' + arrvViewpointExObjLst[i].okCount + '&nbsp;&nbsp;';
                        //评论
                        //strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvViewpointExObjLst[i].appraiseCount + '</span >';
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "评论', '../GraduateEduTools/SysComment?Key=" + strViewpointId + "&Type=" + strType + "&User=" + arrvViewpointExObjLst[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrvViewpointExObjLst[i].appraiseCount + "</span></button >";
                    }
                    if (arrvViewpointExObjLst[i].versionCount > 0 && arrvViewpointExObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button style=\"float: right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strViewpointId + "&Type=" + strType + "')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                }
                else {
                    var objUser = arrUsers.find(x => x.userId == arrvViewpointExObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑用户：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑时间：</span>' + this.substrDate(arrvViewpointExObjLst[i].updDate);
                }
                if (strOperationType == "01") {
                    //历史版本
                    if (arrvViewpointExObjLst[i].versionCount > 0 && arrvViewpointExObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strViewpointId + "&Type=" + strType + "')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    if (strUserId == arrvViewpointExObjLst[i].updUser) {
                        //修改个人观点
                        if (arrvViewpointExObjLst[i].isSubmit != true) {
                            strhtml += '&nbsp;&nbsp;<button title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strViewpointId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                            //观点提交
                            strhtml += '&nbsp;&nbsp;<button title="观点提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + strViewpointId + '")> <i class="layui-icon" >&#xe642;</i>观点提交</button>';
                            //删除个人观点
                            strhtml += '&nbsp;&nbsp;<button title="删除" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strViewpointId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                        }
                    }
                    if (strRoleId != "00620003") {
                        //取消提交
                        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + strViewpointId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                    }
                    arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1); //
                    strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strViewpointId + "&TypeId=" + strTypeId + "&OperationType=1','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                }
                else if (strOperationType == "02") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="引用' + strTitle + '" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnOkInTab_Click("' + strViewpointId + '")> <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                }
                else if (strOperationType == "04") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除关系" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelViewPointRelaRecordInTab_Click("' + strViewpointId + '","' + strVType + '") > <i class="layui-icon" >&#xe640;</i>移除</button>';
                }
                else if (strOperationType == "05") {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="建立关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnAdd_ViewpointRela_Click("' + strViewpointId + '")> <i class="layui-icon" >&#xe642;</i>建立关系</button>';
                }
                strhtml += '</li>';
                //如果当前观点有引用论文，那么就显示论文标题和作者
                var varCitationId = arrvViewpointExObjLst[i].citationId;
                if (varCitationId != "" && varCitationId != null) {
                    var objPaper = await (0, clsvPaperExWApi_js_1.vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache)(varCitationId, strid_CurrEducls);
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                }
                //主题查看——各观点关系查看
                if (strOperationType == "07") {
                    arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1); //
                    if (arrgs_TotalDataRelaObjLst.length > 0) {
                        strhtml += '<li>';
                        strhtml += await this.BindList_gs_TotalDataRela(arrgs_TotalDataRelaObjLst);
                        strhtml += "&nbsp;&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('相关观点查看', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strViewpointId + "&TypeId=" + strTypeId + "&OperationType=2')\"> <i class=\"layui-icon\" >&#xe642;</i>相关观点详细<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                        strhtml += '</li>';
                    }
                }
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定观点视图
        static async BindList_vViewpoint(strOperationType, strVType, arrvViewpointObjLst) {
            var arrvViewpointExObjLst = arrvViewpointObjLst.map(this.GetVExByV);
            var strHtml = await this.BindList_vViewpointEx(strOperationType, strVType, arrvViewpointExObjLst);
            return strHtml;
        }
        //绑定论文观点关系视图
        static async BindList_vgs_PViewpointRela(strOperationType, strVType, arrvgs_PViewpointRelaObjLst) {
            var arrvViewpointExObjLst = arrvgs_PViewpointRelaObjLst.map(this.GetVExByPV);
            var strHtml = await this.BindList_vViewpointEx(strOperationType, strVType, arrvViewpointExObjLst);
            return strHtml;
        }
        //绑定主题观点关系视图
        static async BindList_vRTViewpointRela(strOperationType, strVType, arrvRTViewpointRelaObjLst) {
            var arrvViewpointExObjLst = arrvRTViewpointRelaObjLst.map(this.GetVExByRTV);
            var strHtml = await this.BindList_vViewpointEx(strOperationType, strVType, arrvViewpointExObjLst);
            return strHtml;
        }
        //转换论文观点数据到扩展观点实体
        static GetVExByV(objvViewpoint) {
            var objvViewpointEx = new clsvViewpointExEN_js_1.clsvViewpointExEN();
            objvViewpointEx.viewpointId = objvViewpoint.viewpointId;
            objvViewpointEx.viewpointName = objvViewpoint.viewpointName;
            objvViewpointEx.viewpointContent = objvViewpoint.viewpointContent;
            objvViewpointEx.reason = objvViewpoint.reason;
            objvViewpointEx.viewpointTypeName = objvViewpoint.viewpointTypeName;
            objvViewpointEx.okCount = objvViewpoint.okCount;
            objvViewpointEx.appraiseCount = objvViewpoint.appraiseCount;
            objvViewpointEx.score = objvViewpoint.score;
            objvViewpointEx.teaScore = objvViewpoint.teaScore;
            objvViewpointEx.stuScore = objvViewpoint.stuScore;
            objvViewpointEx.citationCount = objvViewpoint.citationCount;
            objvViewpointEx.versionCount = objvViewpoint.versionCount;
            objvViewpointEx.isSubmit = objvViewpoint.isSubmit;
            objvViewpointEx.citationId = objvViewpoint.citationId;
            objvViewpointEx.updDate = objvViewpoint.updDate;
            objvViewpointEx.updUser = objvViewpoint.updUser;
            // objvViewpointEx.userName = objvViewpoint.userName;
            return objvViewpointEx;
        }
        //转换论文观点数据到扩展观点实体
        static GetVExByPV(objvgs_PViewpointRela) {
            var objvViewpointEx = new clsvViewpointExEN_js_1.clsvViewpointExEN();
            objvViewpointEx.viewpointId = objvgs_PViewpointRela.viewpointId;
            objvViewpointEx.viewpointName = objvgs_PViewpointRela.viewpointName;
            objvViewpointEx.viewpointContent = objvgs_PViewpointRela.viewpointContent;
            objvViewpointEx.reason = objvgs_PViewpointRela.reason;
            objvViewpointEx.viewpointTypeName = objvgs_PViewpointRela.viewpointTypeName;
            objvViewpointEx.okCount = objvgs_PViewpointRela.okCount;
            objvViewpointEx.appraiseCount = objvgs_PViewpointRela.appraiseCount;
            objvViewpointEx.score = objvgs_PViewpointRela.score;
            objvViewpointEx.teaScore = objvgs_PViewpointRela.teaScore;
            objvViewpointEx.stuScore = objvgs_PViewpointRela.stuScore;
            objvViewpointEx.citationCount = objvgs_PViewpointRela.citationCount;
            objvViewpointEx.versionCount = objvgs_PViewpointRela.versionCount;
            objvViewpointEx.isSubmit = objvgs_PViewpointRela.isSubmit;
            objvViewpointEx.mId = objvgs_PViewpointRela.mId;
            objvViewpointEx.updDate = objvgs_PViewpointRela.viewsDate;
            objvViewpointEx.updUser = objvgs_PViewpointRela.viewsUserId;
            //   objvViewpointEx.userName = objvgs_PViewpointRela.ViewsUserName;
            objvViewpointEx.RelaUpdUser = objvgs_PViewpointRela.updUser;
            objvViewpointEx.RelaUpdDate = objvgs_PViewpointRela.updDate;
            return objvViewpointEx;
        }
        //转换主题观点数据到扩展观点实体
        static GetVExByRTV(objvRTViewpointRela) {
            var objvViewpointEx = new clsvViewpointExEN_js_1.clsvViewpointExEN();
            objvViewpointEx.viewpointId = objvRTViewpointRela.viewpointId;
            objvViewpointEx.viewpointName = objvRTViewpointRela.viewpointName;
            objvViewpointEx.viewpointContent = objvRTViewpointRela.viewpointContent;
            objvViewpointEx.reason = objvRTViewpointRela.reason;
            objvViewpointEx.viewpointTypeName = objvRTViewpointRela.viewpointTypeName;
            objvViewpointEx.okCount = objvRTViewpointRela.okCount;
            objvViewpointEx.appraiseCount = objvRTViewpointRela.appraiseCount;
            objvViewpointEx.score = objvRTViewpointRela.score;
            objvViewpointEx.teaScore = objvRTViewpointRela.teaScore;
            objvViewpointEx.stuScore = objvRTViewpointRela.stuScore;
            objvViewpointEx.citationCount = objvRTViewpointRela.citationCount;
            objvViewpointEx.versionCount = objvRTViewpointRela.versionCount;
            objvViewpointEx.isSubmit = objvRTViewpointRela.isSubmit;
            objvViewpointEx.mId = objvRTViewpointRela.mId;
            objvViewpointEx.citationId = objvRTViewpointRela.citationId;
            objvViewpointEx.updDate = objvRTViewpointRela.viewsDate;
            objvViewpointEx.updUser = objvRTViewpointRela.viewsUserId;
            //   objvViewpointEx.userName = objvRTViewpointRela.ViewsUserName;
            objvViewpointEx.RelaUpdUser = objvRTViewpointRela.updUser;
            //   objvViewpointEx.RelaUserName = objvRTViewpointRela.userName
            objvViewpointEx.RelaUpdDate = objvRTViewpointRela.updDate;
            objvViewpointEx.memo = objvRTViewpointRela.topicId;
            objvViewpointEx.isRecommend = objvRTViewpointRela.isRecommend;
            objvViewpointEx.classificationId = objvRTViewpointRela.classificationId;
            return objvViewpointEx;
        }
        //绑定各观点关系
        static async BindList_gs_TotalDataRela(arrgs_TotalDataRelaObjLst) {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
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
            var strhtml = '';
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
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
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[相关观点]：</span>';
                for (var j = 0; j < arrgs_TotalDataRelaObjLst.length; j++) {
                    var totalDataId2 = arrgs_TotalDataRelaObjLst[j].totalDataId2;
                    var strVtypeId = totalDataId2.substr(0, 2);
                    var strVId = totalDataId2.substr(4, 8);
                    if (strVtypeId == "04" || strVtypeId == "05") {
                        arrvViewpointObjLst = arrvViewpointObjLst0.filter(x => x.viewpointId == strVId);
                        for (var k = 0; k < arrvViewpointObjLst.length; k++) {
                            var strYear = arrvViewpointObjLst[k].updDate;
                            strYear = strYear.substr(0, 4);
                            var objUser = arrUsers.find(x => x.userId == arrvViewpointObjLst[k].updUser);
                            if (objUser != null) {
                                strhtml += '' + arrvViewpointObjLst[k].viewpointName + '<span class="rowtit color1">(' + arrvViewpointObjLst[k].userTypeName + '观点/' + objUser.userName + '/' + strYear + ')</span>，';
                            }
                        }
                    }
                    else if (strVtypeId == "06") {
                        arrvConceptObjLst = arrvConceptObjLst0.filter(x => x.conceptId == strVId);
                        for (var k = 0; k < arrvConceptObjLst.length; k++) {
                            var strYear = arrvConceptObjLst[k].updDate;
                            strYear = strYear.substr(0, 4);
                            var objUser = arrUsers.find(x => x.userId == arrvConceptObjLst[k].updUser);
                            if (objUser != null) {
                                strhtml += '' + arrvConceptObjLst[k].conceptName + '<span class="rowtit color2">(相关概念/' + objUser.userName + '/' + strYear + ')</span>，';
                            }
                            //strhtml += '' + arrvConceptObjLst[k].conceptName + '<span class="rowtit color2">(相关概念/' + arrvConceptObjLst[k].userName + '/' + strYear + ')</span>，';
                        }
                    }
                    else if (strVtypeId == "07" || strVtypeId == "08") {
                        arrvTopicObjectiveObjLst = arrvTopicObjectiveObjLst0.filter(x => x.topicObjectiveId == strVId);
                        for (var k = 0; k < arrvTopicObjectiveObjLst.length; k++) {
                            var strYear = arrvTopicObjectiveObjLst[k].updDate;
                            strYear = strYear.substr(0, 4);
                            //获取用户名；
                            var objUser = arrUsers.find(x => x.userId == arrvTopicObjectiveObjLst[k].updUser);
                            if (objUser != null) {
                                strhtml += '' + arrvTopicObjectiveObjLst[k].objectiveName + '<span class="rowtit color3">(' + arrvTopicObjectiveObjLst[k].objectiveTypeName + '/' + objUser.userName + '/' + strYear + ')</span>，';
                            }
                            //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[相关' + arrvTopicObjectiveObjLst[k].objectiveTypeName + '关系]：</span>' + arrvTopicObjectiveObjLst[k].objectiveName + '';
                        }
                    }
                    else if (strVtypeId == "09") {
                        arrvSysSkillObjLst = arrvSysSkillObjLst0.filter(x => x.skillId == strVId);
                        for (var k = 0; k < arrvSysSkillObjLst.length; k++) {
                            var strYear = arrvSysSkillObjLst[k].updDate;
                            strYear = strYear.substr(0, 4);
                            var objUser = arrUsers.find(x => x.userId == arrvSysSkillObjLst[k].updUser);
                            if (objUser != null) {
                                strhtml += '' + arrvSysSkillObjLst[k].skillName + '<span class="rowtit color4">(相关技能，' + objUser.userName + '，' + strYear + ')</span>；';
                            }
                            //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[相关技能关系]：</span>' + arrvSysSkillObjLst[k].skillName + '';
                        }
                    }
                    else if (strVtypeId == "10") {
                        arrvSysSocialRelationsObjLst = arrvSysSocialRelationsObjLst0.filter(x => x.socialId == strVId);
                        for (var k = 0; k < arrvSysSocialRelationsObjLst.length; k++) {
                            var strYear = arrvSysSocialRelationsObjLst[k].updDate;
                            strYear = strYear.substr(0, 4);
                            var objUser = arrUsers.find(x => x.userId == arrvSysSocialRelationsObjLst[k].updUser);
                            if (objUser != null) {
                                strhtml += '' + arrvSysSocialRelationsObjLst[k].fullName + '<span class="rowtit color5">(社会关系，' + objUser.userName + '，' + strYear + ')</span>；';
                            }
                            //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[相关社会关系]：</span>' + arrvSysSocialRelationsObjLst[k].fullName + '';
                        }
                    }
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取各个观点关系不成功,${e}.`;
                alert(strMsg);
            }
            return strhtml;
        }
        //日期转换
        static substrDate(strDate) {
            var strUpdDate = strDate.substr(2, 14);
            return strUpdDate;
        }
    }
    exports.Public_Viewpoint = Public_Viewpoint;
});

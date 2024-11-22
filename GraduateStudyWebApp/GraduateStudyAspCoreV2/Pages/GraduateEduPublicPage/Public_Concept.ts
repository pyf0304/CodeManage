import { clsvgs_PConceptRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PConceptRelaEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsgs_TotalDataRelaEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js";
import { clsConceptAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js";
import { clsgs_ViewsClassificationEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { clsvConceptExEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptExEN.js";
import { gs_TotalDataRela_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js";
import { ConceptAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js";
import { gs_ViewsClassification_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js";
import { vConcept_GetFirstObjAsync, vConcept_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vSysSkill_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { vSysSocialRelations_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vTopicObjective_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vViewpoint_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { SysVote_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { Public_Viewpoint } from "./Public_Viewpoint.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { PaperEx_GetObjByPaperIdById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
declare var $;
declare var window;
export class Public_Concept {

    //绑定观点数据
    public static async Bind_vConcept(strConceptId: string): Promise<string> {
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
        const strCourseId = clsPublocalStorage.courseId;
        var strhtml: string = "";
        var strWhereCond = "1=1 and conceptId='" + strConceptId + "'";
        ////附件
        //var strWhereCondAttachment = "1=1";

        var objvConcept: clsvConceptEN = new clsvConceptEN;
        //获取图片
        var arrConceptAttachmentObjLst: Array<clsConceptAttachmentEN> = [];
        //var arrConceptAttachmentObjLst2: Array<clsConceptAttachmentEN> = [];
        try {
            const responseObjLst1 = await vConcept_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvConcept = <clsvConceptEN>jsonData;
            });

            const responseObjLst2 = await ConceptAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrConceptAttachmentObjLst = <Array<clsConceptAttachmentEN>>jsonData;
            });
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            if (objvConcept != null) {
                //概念
                strhtml += '<div class="info" id="infoConcept">';
                strhtml += '<ul class="artlist">';

                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[概念]：</span><span class="abstract-text">' + objvConcept.conceptName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + objvConcept.conceptContent + '</span></li>';
                //查询附件
                //arrConceptAttachmentObjLst = arrConceptAttachmentObjLst2.filter(x => x.conceptId == objvConcept.conceptId);
                if (arrConceptAttachmentObjLst.length > 0) {

                    //var strAddressAndPort = "https://www.sh-tz.com/GraduateStudyWebApp/";
                    var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;

                    for (var y = 0; y < arrConceptAttachmentObjLst.length; y++) {
                        var strAddressAndPortfull = strAddressAndPort + arrConceptAttachmentObjLst[y].filePath;
                        strhtml += '<li><img data-action="zoom" src="' + strAddressAndPortfull + '" style="max-width:400px; margin-left: 10px; " alt="" id="txtImgPath' + arrConceptAttachmentObjLst[y].conceptAttachmentId + '"/></li>';
                    }
                }
                var objUser = arrUsers.find(x => x.userId == objvConcept.updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objvConcept.userName;
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + Public_Viewpoint.substrDate(objvConcept.updDate);
                strhtml += '</li>';
                //如果当前观点有引用论文，那么就显示论文标题和作者
                var varCitationId = objvConcept.citationId;
                if (varCitationId != "" && varCitationId != null) {
                    var objPaper: clsPaperEN = await PaperEx_GetObjByPaperIdById_CurrEduCls_Cache(varCitationId, strid_CurrEducls);
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                }
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                strhtml += '</ul></div>';

                //拼接；

                console.log("完成BindGv_vConcept!");
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        return strhtml;
    }


    //绑定观点列表数据
    private static async BindList_vConceptEx(strOperationType: string, arrvConceptExObjLst: Array<clsvConceptExEN>): Promise<string> {
        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
        //换行符
        var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
        const strCourseId = clsPublocalStorage.courseId;
        var strUserId = clsPublocalStorage.userId;
        var strRoleId = clsPublocalStorage.roleId;
        var strhtml: string = "";

        //观点关系
        var arrgs_TotalDataRelaObjLst: Array<clsgs_TotalDataRelaEN> = [];//
        var arrgs_TotalDataRelaObjLst0: Array<clsgs_TotalDataRelaEN> = [];//

        //各观点实体
        var arrvViewpointObjLst0: Array<clsvViewpointEN> = [];//
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];//

        var arrvConceptObjLst0: Array<clsvConceptEN> = [];//
        var arrvConceptObjLst: Array<clsvConceptEN> = [];//

        var arrvTopicObjectiveObjLst0: Array<clsvTopicObjectiveEN> = [];//
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];//

        var arrvSysSkillObjLst0: Array<clsvSysSkillEN> = [];//
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];//

        var arrvSysSocialRelationsObjLst0: Array<clsvSysSocialRelationsEN> = [];//
        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];//

        //观点分类
        var arrgs_ViewsClassificationObjLst: Array<clsgs_ViewsClassificationEN> = [];

        //点赞
        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];//新0605
        //关系查看需要点赞功能
        if (strOperationType == "01" || strOperationType == "07") {
            var strWhereCondLike = `1=1 and voteTypeId='05' And ${clsSysVoteEN.con_UpdUser} = '${strUserId}'`;//新0605
            const responseRecCount6 = await SysVote_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });
            const responseRecCount7 = await gs_TotalDataRela_GetObjLst_Cache(clsPublocalStorage.id_CurrEduCls).then((jsonData) => {
                arrgs_TotalDataRelaObjLst0 = <Array<clsgs_TotalDataRelaEN>>jsonData;
            });

            if (strOperationType == "07") {
                //观点
                const responseObjLst3 = await vViewpoint_GetObjLst_Cache(strid_CurrEducls).then((jsonData) => {
                    arrvViewpointObjLst0 = <Array<clsvViewpointEN>>jsonData;
                });
                //概念
                const responseObjLst4 = await vConcept_GetObjLst_Cache(strid_CurrEducls).then((jsonData) => {
                    arrvConceptObjLst0 = <Array<clsvConceptEN>>jsonData;
                });
                //客观
                const responseObjLst5 = await vTopicObjective_GetObjLst_Cache(strid_CurrEducls).then((jsonData) => {
                    arrvTopicObjectiveObjLst0 = <Array<clsvTopicObjectiveEN>>jsonData;
                });
                //技能
                const responseObjLst6 = await vSysSkill_GetObjLst_Cache(strid_CurrEducls).then((jsonData) => {
                    arrvSysSkillObjLst0 = <Array<clsvSysSkillEN>>jsonData;
                });
                //社会关系
                const responseObjLst7 = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEducls).then((jsonData) => {
                    arrvSysSocialRelationsObjLst0 = <Array<clsvSysSocialRelationsEN>>jsonData;
                });
            }
        }

        if (strOperationType == "06") {
            //主题用户关系
            //主题用户关系
            var strTopicId = clsPrivateSessionStorage.topicId;
            var strWhereCond: string = " 1 = 1 and topicId='" + strTopicId + "' order by updDate Asc";
            //获取观点分类
            const responseObjLst4 = await gs_ViewsClassification_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_ViewsClassificationObjLst = <Array<clsgs_ViewsClassificationEN>>jsonData;

            });
        }
        //附件
        var strWhereCondAttachment = "1=1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //获取观点图片
        var arrConceptAttachmentObjLst: Array<clsConceptAttachmentEN> = [];
        var arrConceptAttachmentObjLst2: Array<clsConceptAttachmentEN> = [];
        arrConceptAttachmentObjLst2 = await ConceptAttachment_GetObjLstAsync(strWhereCondAttachment);
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

        strhtml += '<div class="info" id="infoConcept"><div class="title btn-3">';


        if (strOperationType == "01") {
            strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加概念</button></div>';
        } else {
            strhtml += '<div style="float:left;"><a href="#" title="相关概念">相关概念</a></div>';
        }

        strhtml += '</div><ul class="artlist">';
        var v = 0;//给内容加个序号
        for (var i = 0; i < arrvConceptExObjLst.length; i++) {
            //得到conceptId；
            var strConceptId = arrvConceptExObjLst[i].conceptId;
            //各观点关系
            var strTotalDataId1 = "0600" + strConceptId;
            v++;
            //对内容进行换行替换
            var strConceptContent = arrvConceptExObjLst[i].conceptContent;
            strConceptContent = strConceptContent.replace(/\r\n/g, strBr);
            strConceptContent = strConceptContent.replace(/\n/g, strBr);

            if (strOperationType == "06") {
                var objClassification = arrgs_ViewsClassificationObjLst.find(x => x.classificationId == arrvConceptExObjLst[i].memo)
                if (objClassification != null) {
                    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptExObjLst[i].conceptName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')</span></li>';
                }
                else {
                    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptExObjLst[i].conceptName + '</span>&nbsp;&nbsp;<span style="color:red;">(未分类)</span></li>';
                }
            } else {
                strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptExObjLst[i].conceptName + '</span></li>';
            }
           
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';

            //查询附件
            arrConceptAttachmentObjLst = arrConceptAttachmentObjLst2.filter(x => x.conceptId == strConceptId);
            if (arrConceptAttachmentObjLst.length > 0) {
                for (var y = 0; y < arrConceptAttachmentObjLst.length; y++) {
                    var strAddressAndPortfull = strAddressAndPort + arrConceptAttachmentObjLst[y].filePath;
                    strhtml += '<li><div class="example"><img style="max-width:400px; margin-left: 10px; " src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
                }
            }

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
            if (arrvConceptExObjLst[i].okCount != 0) {
                strhtml += '点赞数：' + arrvConceptExObjLst[i].okCount + '&nbsp;&nbsp';
            }
            if (arrvConceptExObjLst[i].appraiseCount != 0) {
                //评论
                strhtml += '&nbsp;&nbsp;评论数：' + arrvConceptExObjLst[i].appraiseCount;
            }
            if (arrvConceptExObjLst[i].score != 0) {
                //评分
                strhtml += '&nbsp;&nbsp;综合评分：' + arrvConceptExObjLst[i].score;
            }
            if (arrvConceptExObjLst[i].teaScore != 0) {
                strhtml += '&nbsp;&nbsp;教师评分：' + arrvConceptExObjLst[i].teaScore;
            }
            if (arrvConceptExObjLst[i].stuScore != 0) {
                strhtml += '&nbsp;&nbsp;学生评分：' + arrvConceptExObjLst[i].stuScore;
            }
            //引用数
            strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvConceptExObjLst[i].citationCount;

            if (arrvConceptExObjLst[i].versionCount != 0) {
                strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvConceptExObjLst[i].versionCount;
            }
            if (arrvConceptExObjLst[i].isSubmit == true) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
            }
            else {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
            }

            strhtml += '</li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';

            if (strOperationType == "06" || strOperationType == "07") {
                //得到编辑人名字
                var objUser = arrUsers.find(x => x.userId == arrvConceptExObjLst[i].RelaUpdUser);
                if (objUser != null) {
                    if (arrvConceptExObjLst[i].updUser == arrvConceptExObjLst[i].RelaUpdUser) {
                        strhtml += '<span class="rowtit color4">编辑引用人：</span>' + objUser.userName;
                    } else {
                        var objUserRT = arrUsers.find(x => x.userId == arrvConceptExObjLst[i].RelaUpdUser);
                        if (objUserRT != null) {
                            strhtml += '<span class="rowtit color4">编辑&nbsp;/&nbsp;引用人：</span>' + objUser.userName + '&nbsp;/&nbsp;' + objUserRT.userName;
                        }
                       
                    }
                }
                
                if (arrvConceptExObjLst[i].updDate == arrvConceptExObjLst[i].RelaUpdDate) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑引用时间：</span>' + Public_Viewpoint.substrDate(arrvConceptExObjLst[i].updDate);
                } else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑&nbsp;/&nbsp;引用时间：</span>' + Public_Viewpoint.substrDate(arrvConceptExObjLst[i].updDate) + '&nbsp;/&nbsp;' + Public_Viewpoint.substrDate(arrvConceptExObjLst[i].RelaUpdDate);
                }
                if (strOperationType == "06") {
                    //加入到观点分类
                    if (arrvConceptExObjLst[i].memo == "0000000000") {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="加入当前分类" class="layui-btn layui-btn layui-btn-xs" onclick="btnAddClassificationRecordInTab_Click(' + arrvConceptExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe61f;</i>加入分类</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="调整当前分类" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateClassificationRecordInTab_Click(' + arrvConceptExObjLst[i].mId + ',"' + arrvConceptExObjLst[i].memo + '") > <i class="layui-icon" >&#xe642;</i>调整分类</button>';
                    }

                    if (strUserId == arrvConceptExObjLst[i].updUser) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelConceptRecordInTab_Click(' + arrvConceptExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                    }
                    if (arrvConceptExObjLst[i].isSubmit != true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdConcept_Click("' + strConceptId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                    }
                }
                else if (strOperationType == "07") {
                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == strConceptId);//新0605
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;';
                    if (objLike == null) {
                        strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strConceptId + '","' + arrvConceptExObjLst[i].updUser + '","05")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                    } else {
                        strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strConceptId + '","' + arrvConceptExObjLst[i].updUser + '","05")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                    }
                    strhtml += '&nbsp;' + arrvConceptExObjLst[i].okCount + '&nbsp;&nbsp;';
                    //评论
                    //strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvConceptExObjLst[i].appraiseCount + '</span >';
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('相关概念评论', '../GraduateEduTools/SysComment?Key=" + strConceptId + "&Type=05&User=" + arrvConceptExObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrvConceptExObjLst[i].appraiseCount + "</span></button >";
                    //查看观点关系

                   
                }
                if (arrvConceptExObjLst[i].versionCount > 0 && arrvConceptExObjLst[i].versionCount != null) {
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strConceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                }

            }
            else {
                var objUser = arrUsers.find(x => x.userId == arrvConceptExObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑用户：</span>' + objUser.userName;
                }
                
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑时间：</span>' + Public_Viewpoint.substrDate(arrvConceptExObjLst[i].updDate);
            }
            if (strOperationType == "01") {
                //历史版本
                if (arrvConceptExObjLst[i].versionCount > 0 && arrvConceptExObjLst[i].versionCount != null) {
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strConceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                }
                if (strUserId == arrvConceptExObjLst[i].updUser) {
                    if (arrvConceptExObjLst[i].isSubmit != true) {
                        //修改个人观点
                        strhtml += '&nbsp;&nbsp;<button title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strConceptId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                        //删除个人观点
                        strhtml += '&nbsp;&nbsp;<button title="删除" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strConceptId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                        //观点提交
                        strhtml += '&nbsp;&nbsp;<button title="提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + strConceptId + '")> <i class="layui-icon" >&#xe642;</i>提交</button>';
                    }
                }
                if (strRoleId != "00620003") {
                    //取消提交
                    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + strConceptId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                }

                //建立观点关系

                arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1);//
                strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strConceptId + "&TypeId=06&OperationType=1','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
            }
            else if (strOperationType == "02") {
                strhtml += '&nbsp;&nbsp;<button title="引用该相关概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + strConceptId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';
            }
            else if (strOperationType == "04") {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除关系" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelConceptRelaRecordInTab_Click("' + strConceptId + '") > <i class="layui-icon" >&#xe640;</i>移除</button>';
            }
            else if (strOperationType == "05") {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="建立关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + strConceptId + '")> <i class="layui-icon" >&#xe642;</i>建立关系</button>';
            }

            strhtml += '</li>';

            //如果当前观点有引用论文，那么就显示论文标题和作者
            var varCitationId = arrvConceptExObjLst[i].citationId;
            if (varCitationId != "" && varCitationId != null) {
                var objPaper: clsPaperEN = await PaperEx_GetObjByPaperIdById_CurrEduCls_Cache(varCitationId, strid_CurrEducls);
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
            }

            //主题查看——各观点关系查看
            if (strOperationType == "07") {

                arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1);//
                if (arrgs_TotalDataRelaObjLst.length > 0) {
                    strhtml += '<li>';
                    
                    strhtml += await Public_Viewpoint.BindList_gs_TotalDataRela(arrgs_TotalDataRelaObjLst);
                    strhtml += "&nbsp;&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('关联观点查看', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strConceptId + "&TypeId=06&OperationType=2')\"> <i class=\"layui-icon\" >&#xe642;</i>相关观点详细<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                    strhtml += '</li>';
                }
            }

            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';

        return strhtml;
    }



    //绑定观点视图
    public static async BindList_vConcept(strOperationType: string, arrvConceptObjLst: Array<clsvConceptEN>){
        var arrvConceptExObjLst: Array<clsvConceptExEN> = arrvConceptObjLst.map(this.GetVExByV);
        var strHtml = await this.BindList_vConceptEx(strOperationType, arrvConceptExObjLst)
        return strHtml;
    }
    //public static async BindList_vConcept(strOperationType: string, arrvConceptObjLst: Array<clsvConceptEN>) {
    //    var arrViewpointAttachmentObjLst: Array<clsvConceptExEN> = [];
    //    const responseText4 = await this.GetVExByV().then((jsonData) => {
    //        arrViewpointAttachmentObjLst = <Array<clsvConceptExEN>>jsonData;
    //    });

    //    var arrvConceptExObjLst: Array<clsvConceptExEN> = arrvConceptObjLst.map(await this.GetVExByV);
    //    var strHtml = await this.BindList_vConceptEx(strOperationType, arrvConceptExObjLst)
    //    return strHtml;
    //}

    //绑定论文观点关系视图
    public static async BindList_vgs_PConceptRela(strOperationType: string, arrvgs_PConceptRelaObjLst: Array<clsvgs_PConceptRelaEN>) {
        var arrvConceptExObjLst: Array<clsvConceptExEN> = arrvgs_PConceptRelaObjLst.map(this.GetVExByPV);
        var strHtml = await this.BindList_vConceptEx(strOperationType, arrvConceptExObjLst)
        return strHtml;
    }
    //绑定主题观点关系视图
    public static async BindList_vRTConceptRela(strOperationType: string, arrvRTConceptRelaObjLst: Array<clsvRTConceptRelaEN>) {
        var arrvConceptExObjLst: Array<clsvConceptExEN> = arrvRTConceptRelaObjLst.map(this.GetVExByRTV);
        var strHtml = await this.BindList_vConceptEx(strOperationType, arrvConceptExObjLst)
        return strHtml;
    }

    //转换论文观点数据到扩展观点实体
    private static GetVExByV(objvConcept: clsvConceptEN): clsvConceptExEN {

        var objvConceptEx: clsvConceptExEN = new clsvConceptExEN();
        objvConceptEx.conceptId = objvConcept.conceptId;
        objvConceptEx.conceptName = objvConcept.conceptName;
        objvConceptEx.conceptContent = objvConcept.conceptContent;
        objvConceptEx.okCount = objvConcept.okCount;
        objvConceptEx.appraiseCount = objvConcept.appraiseCount;
        objvConceptEx.score = objvConcept.score;
        objvConceptEx.teaScore = objvConcept.teaScore;
        objvConceptEx.stuScore = objvConcept.stuScore;
        objvConceptEx.citationCount = objvConcept.citationCount;
        objvConceptEx.versionCount = objvConcept.versionCount;
        objvConceptEx.isSubmit = objvConcept.isSubmit;
        objvConceptEx.citationId = objvConcept.citationId;

        objvConceptEx.updDate = objvConcept.updDate;
        objvConceptEx.updUser = objvConcept.updUser;

        return objvConceptEx;
    }

    //转换论文观点数据到扩展观点实体
    private static GetVExByPV(objvgs_PConceptRela: clsvgs_PConceptRelaEN): clsvConceptExEN {
        var objvConceptEx: clsvConceptExEN = new clsvConceptExEN();
        objvConceptEx.conceptId = objvgs_PConceptRela.conceptId;
        objvConceptEx.conceptName = objvgs_PConceptRela.conceptName;
        objvConceptEx.conceptContent = objvgs_PConceptRela.conceptContent;
        objvConceptEx.okCount = objvgs_PConceptRela.okCount;
        objvConceptEx.appraiseCount = objvgs_PConceptRela.appraiseCount;
        objvConceptEx.score = objvgs_PConceptRela.score;
        objvConceptEx.teaScore = objvgs_PConceptRela.teaScore;
        objvConceptEx.stuScore = objvgs_PConceptRela.stuScore;
        objvConceptEx.citationCount = objvgs_PConceptRela.citationCount;
        objvConceptEx.versionCount = objvgs_PConceptRela.versionCount;
        objvConceptEx.isSubmit = objvgs_PConceptRela.isSubmit;
        objvConceptEx.mId = objvgs_PConceptRela.mId;

        objvConceptEx.updDate = objvgs_PConceptRela.concepDate;
        objvConceptEx.updUser = objvgs_PConceptRela.concepUserId;
        objvConceptEx.userName = objvgs_PConceptRela.conceptName;

        objvConceptEx.RelaUpdUser = objvgs_PConceptRela.updUser;
        //objvConceptEx.RelaUserName = objvgs_PConceptRela.userName
        objvConceptEx.RelaUpdDate = objvgs_PConceptRela.updDate;
        return objvConceptEx;
    }

    //转换主题观点数据到扩展观点实体
    private static GetVExByRTV(objvRTConceptRela: clsvRTConceptRelaEN): clsvConceptExEN {
        var objvConceptEx: clsvConceptExEN = new clsvConceptExEN();
        objvConceptEx.conceptId = objvRTConceptRela.conceptId;
        objvConceptEx.conceptName = objvRTConceptRela.conceptName;
        objvConceptEx.conceptContent = objvRTConceptRela.conceptContent;
        objvConceptEx.okCount = objvRTConceptRela.okCount;
        objvConceptEx.appraiseCount = objvRTConceptRela.appraiseCount;
        objvConceptEx.score = objvRTConceptRela.score;
        objvConceptEx.teaScore = objvRTConceptRela.teaScore;
        objvConceptEx.stuScore = objvRTConceptRela.stuScore;
        objvConceptEx.citationCount = objvRTConceptRela.citationCount;
        objvConceptEx.versionCount = objvRTConceptRela.versionCount;
        objvConceptEx.isSubmit = objvRTConceptRela.isSubmit;
        objvConceptEx.mId = objvRTConceptRela.mId;
        objvConceptEx.citationId = objvRTConceptRela.citationId;

        objvConceptEx.updDate = objvRTConceptRela.concepDate;
        objvConceptEx.updUser = objvRTConceptRela.concepUserId;
        objvConceptEx.userName = objvRTConceptRela.conceptName;

        objvConceptEx.RelaUpdUser = objvRTConceptRela.updUser;
       // objvConceptEx.RelaUserName = objvRTConceptRela.userName
        objvConceptEx.RelaUpdDate = objvRTConceptRela.updDate;

        objvConceptEx.memo = objvRTConceptRela.classificationId;
        return objvConceptEx;
    }

}
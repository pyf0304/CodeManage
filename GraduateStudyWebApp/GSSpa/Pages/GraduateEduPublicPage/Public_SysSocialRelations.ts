import { clsvgs_PSocialRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PSocialRelaEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsgs_TotalDataRelaEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js";
import { clsgs_ViewsClassificationEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { clsvSysSocialRelationsExEN } from "../TS/L0_EntityEx/GraduateEduTopic/clsvSysSocialRelationsExEN.js";
import { gs_TotalDataRela_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js";
import { gs_ViewsClassification_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js";
import { vConcept_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vSysSkill_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { vSysSocialRelations_GetFirstObjAsync, vSysSocialRelations_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vTopicObjective_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vViewpoint_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { SysVote_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Public_Viewpoint } from "./Public_Viewpoint.js";
declare var $;
declare var window;
export class Public_SysSocialRelations {

    //绑定观点数据
    public static async Bind_vSysSocialRelations(strSocialId: string): Promise<string> {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        var strhtml: string = "";
        var strWhereCond = "1=1 and socialId='" + strSocialId + "'";

        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

        var objvSysSocialRelations: clsvSysSocialRelationsEN = new clsvSysSocialRelationsEN;

        try {
            const responseObjLst1 = await vSysSocialRelations_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvSysSocialRelations = <clsvSysSocialRelationsEN>jsonData;
            });


            if (objvSysSocialRelations != null) {
                //概念
                strhtml += '<div class="info" id="infoSysSocialRelations">';
                strhtml += '<ul class="artlist">';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[姓名]：</span><span class="abstract-text">' + objvSysSocialRelations.fullName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[国籍]：</span><span class="abstract-text">' + objvSysSocialRelations.nationality + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[工作单位]：</span><span class="abstract-text">' + objvSysSocialRelations.workUnit + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[专业]：</span><span class="abstract-text">' + objvSysSocialRelations.major + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[成就]：</span><span class="abstract-text">' + objvSysSocialRelations.achievement + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[详细说明]：</span><span class="abstract-text">' + objvSysSocialRelations.detailedDescription + '</span></li>';

                var objUser = arrUsers.find(x => x.userId == objvSysSocialRelations.updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + Public_Viewpoint.substrDate(objvSysSocialRelations.updDate);
                strhtml += '</li>';

                //如果当前观点有引用论文，那么就显示论文标题和作者
                var varCitationId = objvSysSocialRelations.citationId;
                if (varCitationId != "" && varCitationId != null) {
                    var objPaper: clsvPaperEN = await vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(varCitationId, strid_CurrEducls);
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                }

                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                strhtml += '</ul></div>';


                //拼接；

                console.log("完成BindGv_vSysSocialRelations!");
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
    private static async BindList_vSysSocialRelationsEx(strOperationType: string, arrvSysSocialRelationsExObjLst: Array<clsvSysSocialRelationsExEN>): Promise<string> {

        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
        var strhtml: string = "";

        //换行符
        var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();


        //点赞
        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];//新0605
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

        //关系查看需要点赞功能
        if (strOperationType == "01" || strOperationType == "07") {
            var strWhereCondLike = `1=1 and voteTypeId='10' And ${clsSysVoteEN.con_UpdUser} = '${strUserId}'`;//新0605
            const responseRecCount6 = await SysVote_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });
            //var strWhereCondRela = "1=1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            const responseRecCount7 = await gs_TotalDataRela_GetObjLst_Cache(clsPublocalStorage.Getid_CurrEduCls()).then((jsonData) => {
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
            var strTopicId = $("#hidTopicRelaId").val();
            var strWhereCond: string = " 1 = 1 and topicId='" + strTopicId + "' order by updDate Asc";
            //获取观点分类
            const responseObjLst4 = await gs_ViewsClassification_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_ViewsClassificationObjLst = <Array<clsgs_ViewsClassificationEN>>jsonData;

            });
        }

        strhtml += '<div class="info" id="infoSysSocialRelations"><div class="title btn-3">';

        if (strOperationType == "01") {
            strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加社会关系" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加社会关系</button></div>';
        } else {
            strhtml += '<div style="float:left;"><a href="#" title="社会关系">社会关系</a></div>';
        }
        strhtml += '</div><ul class="artlist">';
        var v = 0;//给内容加个序号
        for (var i = 0; i < arrvSysSocialRelationsExObjLst.length; i++) {
            //得到conceptId；
            var strSocialId = arrvSysSocialRelationsExObjLst[i].socialId;
            var strTotalDataId1 = "10" + strSocialId;
            v++;

            var strDetailedDescription = arrvSysSocialRelationsExObjLst[i].detailedDescription;
            strDetailedDescription = strDetailedDescription.replace(/\r\n/g, strBr);
            strDetailedDescription = strDetailedDescription.replace(/\n/g, strBr);
            if (strOperationType == "06") {
                var objClassification = arrgs_ViewsClassificationObjLst.find(x => x.classificationId == arrvSysSocialRelationsExObjLst[i].memo)
                if (objClassification != null) {
                    strhtml += '<li><span class="rowtit color6">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].fullName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')</span></li>';
                }
                else {
                    strhtml += '<li><span class="rowtit color6">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].fullName + '</span>&nbsp;&nbsp;<span style="color:red;">(未分类)</span></li>';
                }
            } else {
                strhtml += '<li><span class="rowtit color6">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].fullName + '</span></li>';
            }

            

            strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].nationality + '</span>';
            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].workUnit + '</span>';
            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].major + '</span></li>';


            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsExObjLst[i].achievement + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[详细说明]：</span><span class="abstract-text">' + strDetailedDescription + '</span></li>';

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
            if (arrvSysSocialRelationsExObjLst[i].okCount != 0) {
                strhtml += '点赞数：' + arrvSysSocialRelationsExObjLst[i].okCount + '&nbsp;&nbsp';
            }
            if (arrvSysSocialRelationsExObjLst[i].appraiseCount != 0) {
                //评论
                strhtml += '&nbsp;&nbsp;评论数：' + arrvSysSocialRelationsExObjLst[i].appraiseCount;
            }
            if (arrvSysSocialRelationsExObjLst[i].score != 0) {
                //评分
                strhtml += '&nbsp;&nbsp;综合评分：' + arrvSysSocialRelationsExObjLst[i].score;
            }
            if (arrvSysSocialRelationsExObjLst[i].teaScore != 0) {
                strhtml += '&nbsp;&nbsp;教师评分：' + arrvSysSocialRelationsExObjLst[i].teaScore;
            }
            if (arrvSysSocialRelationsExObjLst[i].stuScore != 0) {
                strhtml += '&nbsp;&nbsp;学生评分：' + arrvSysSocialRelationsExObjLst[i].stuScore;
            }
            //引用数
            strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvSysSocialRelationsExObjLst[i].citationCount;

            if (arrvSysSocialRelationsExObjLst[i].versionCount != 0) {
                strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvSysSocialRelationsExObjLst[i].versionCount;
            }
            if (arrvSysSocialRelationsExObjLst[i].isSubmit == true) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
            }
            else {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
            }

            strhtml += '</li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';

            var objUser = arrUsers.find(x => x.userId == arrvSysSocialRelationsExObjLst[i].updUser);
            var objUser2 = arrUsers.find(x => x.userId == arrvSysSocialRelationsExObjLst[i].RelaUpdUser);

            if (strOperationType == "06" || strOperationType == "07") {
                if (objUser != null && objUser2 != null) {
                    if (arrvSysSocialRelationsExObjLst[i].updUser == arrvSysSocialRelationsExObjLst[i].RelaUpdUser) {
                        strhtml += '<span class="rowtit color3">编辑引用人：</span>' + objUser.userName;
                    } else {
                        strhtml += '<span class="rowtit color3">编辑&nbsp;/&nbsp;引用人：</span>' + objUser.userName + '&nbsp;/&nbsp;' + objUser2.userName;
                    }
                }
                if (arrvSysSocialRelationsExObjLst[i].updDate == arrvSysSocialRelationsExObjLst[i].RelaUpdDate) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑引用时间：</span>' + Public_Viewpoint.substrDate(arrvSysSocialRelationsExObjLst[i].updDate);
                } else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑&nbsp;/&nbsp;引用时间：</span>' + Public_Viewpoint.substrDate(arrvSysSocialRelationsExObjLst[i].updDate) + '&nbsp;/&nbsp;' + Public_Viewpoint.substrDate(arrvSysSocialRelationsExObjLst[i].RelaUpdDate);
                }

                if (strOperationType == "06") {
                    //加入到观点分类
                    if (arrvSysSocialRelationsExObjLst[i].memo == "0000000000") {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="加入当前分类" class="layui-btn layui-btn layui-btn-xs" onclick="btnAddClassificationRecordInTab_Click(' + arrvSysSocialRelationsExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe61f;</i>加入分类</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="调整当前分类" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateClassificationRecordInTab_Click(' + arrvSysSocialRelationsExObjLst[i].mId + ',"' + arrvSysSocialRelationsExObjLst[i].memo + '") > <i class="layui-icon" >&#xe642;</i>调整分类</button>';
                    }

                    if (strUserId == arrvSysSocialRelationsExObjLst[i].updUser) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelRTSysSocialRelaRecordInTab_Click(' + arrvSysSocialRelationsExObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                    }
                    if (arrvSysSocialRelationsExObjLst[i].isSubmit != true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdSyssocial_Click("' + arrvSysSocialRelationsExObjLst[i].socialId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                    }
                }
                else if (strOperationType == "07") {
                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSocialId);//新0605
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;';
                    if (objLike == null) {
                        strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strSocialId + '","' + arrvSysSocialRelationsExObjLst[i].updUser + '","10")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                    } else {
                        strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strSocialId + '","' + arrvSysSocialRelationsExObjLst[i].updUser + '","10")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                    }
                    strhtml += '&nbsp;' + arrvSysSocialRelationsExObjLst[i].okCount + '&nbsp;&nbsp;';
                    //评论
                    //strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvSysSocialRelationsExObjLst[i].appraiseCount + '</span >';
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('社会关系评论', '../GraduateEduTools/SysComment?Key=" + strSocialId + "&Type=10&User=" + arrvSysSocialRelationsExObjLst[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrvSysSocialRelationsExObjLst[i].appraiseCount + "</span></button >";
                    //建立观点关系

                   
                }
                if (arrvSysSocialRelationsExObjLst[i].versionCount > 0 && arrvSysSocialRelationsExObjLst[i].versionCount != null) {
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvSysSocialRelationsExObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                }

            }
            else {
                if (objUser != null) {
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑用户：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑时间：</span>' + Public_Viewpoint.substrDate(arrvSysSocialRelationsExObjLst[i].updDate);
            }
            if (strOperationType == "01") {
                //历史版本
                if (arrvSysSocialRelationsExObjLst[i].versionCount > 0 && arrvSysSocialRelationsExObjLst[i].versionCount != null) {
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strSocialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                }
                if (strUserId == arrvSysSocialRelationsExObjLst[i].updUser) {
                    if (arrvSysSocialRelationsExObjLst[i].isSubmit != true) {
                        //修改个人观点
                        strhtml += '&nbsp;&nbsp;<button title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSocialId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                        //删除个人观点
                        strhtml += '&nbsp;&nbsp;<button title="删除" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSocialId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                        //观点提交
                        strhtml += '&nbsp;&nbsp;<button title="提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + strSocialId + '")> <i class="layui-icon" >&#xe642;</i>提交</button>';
                    }
                }
                if (strRoleId != "00620003") {
                    //取消提交
                    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + strSocialId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                }
                //建立观点关系

                arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1);//
                strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strSocialId + "&TypeId=10&OperationType=1','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
            }
            else if (strOperationType == "02") {
                strhtml += '&nbsp;&nbsp;<button title="引用社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkRTSysSocialRelaInTab_Click("' + strSocialId + '")> <i class="layui-icon" >&#xe642;</i>引用该社会关系</button>';
            }
            else if (strOperationType == "04") {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除关系" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelgs_PSocialRelaRecordInTab_Click("' + strSocialId + '") > <i class="layui-icon" >&#xe640;</i>移除</button>';
            }
            else if (strOperationType == "05") {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="建立关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkgs_PSocialRelaInTab_Click("' + strSocialId + '")> <i class="layui-icon" >&#xe642;</i>建立关系</button>';
            }


            strhtml += '</li>';

            //如果当前观点有引用论文，那么就显示论文标题和作者
            var varCitationId = arrvSysSocialRelationsExObjLst[i].citationId;
            if (varCitationId != "" && varCitationId != null) {
                var objPaper: clsvPaperEN = await vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(varCitationId, strid_CurrEducls);
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
            }

            //主题查看——各观点关系查看
            if (strOperationType == "07") {

                arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1);//
                if (arrgs_TotalDataRelaObjLst.length > 0) {
                    strhtml += '<li>';
                    strhtml += await Public_Viewpoint.BindList_gs_TotalDataRela(arrgs_TotalDataRelaObjLst);
                    strhtml += "&nbsp;&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('关联观点查看', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strSocialId + "&TypeId=10&OperationType=2')\"> <i class=\"layui-icon\" >&#xe642;</i>相关观点详细<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                    strhtml += '</li>';
                }
            }

            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';

        return strhtml;
    }


    //绑定观点视图
    public static async BindList_vSysSocialRelations(strOperationType: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>): Promise<string> {
        var arrvSysSocialRelationsExObjLst: Array<clsvSysSocialRelationsExEN> = arrvSysSocialRelationsObjLst.map(this.GetVExByV);
        var strHtml = await this.BindList_vSysSocialRelationsEx(strOperationType, arrvSysSocialRelationsExObjLst)
        return strHtml;
    }


    //绑定论文观点关系视图
    public static async BindList_vgs_PSocialRela(strOperationType: string, arrvgs_PSocialRelaObjLst: Array<clsvgs_PSocialRelaEN>) {
        var arrvSysSocialRelationsExObjLst: Array<clsvSysSocialRelationsExEN> = arrvgs_PSocialRelaObjLst.map(this.GetVExByPV);
        var strHtml = await this.BindList_vSysSocialRelationsEx(strOperationType, arrvSysSocialRelationsExObjLst)
        return strHtml;
    }
    //绑定主题观点关系视图
    public static async BindList_vRTSysSocialRela(strOperationType: string, arrvRTSysSocialRelaObjLst: Array<clsvRTSysSocialRelaEN>) {
        var arrvSysSocialRelationsExObjLst: Array<clsvSysSocialRelationsExEN> = arrvRTSysSocialRelaObjLst.map(this.GetVExByRTV);
        var strHtml = await this.BindList_vSysSocialRelationsEx(strOperationType, arrvSysSocialRelationsExObjLst)
        return strHtml;
    }

    //转换论文观点数据到扩展观点实体
    private static GetVExByV(objvSysSocialRelations: clsvSysSocialRelationsEN): clsvSysSocialRelationsExEN {
        var objvSysSocialRelationsEx: clsvSysSocialRelationsExEN = new clsvSysSocialRelationsExEN();
        objvSysSocialRelationsEx.socialId = objvSysSocialRelations.socialId;
        objvSysSocialRelationsEx.fullName = objvSysSocialRelations.fullName;
        objvSysSocialRelationsEx.nationality = objvSysSocialRelations.nationality;
        objvSysSocialRelationsEx.workUnit = objvSysSocialRelations.workUnit;
        objvSysSocialRelationsEx.major = objvSysSocialRelations.major;
        objvSysSocialRelationsEx.achievement = objvSysSocialRelations.achievement;
        objvSysSocialRelationsEx.detailedDescription = objvSysSocialRelations.detailedDescription;
        objvSysSocialRelationsEx.okCount = objvSysSocialRelations.okCount;
        objvSysSocialRelationsEx.appraiseCount = objvSysSocialRelations.appraiseCount;
        objvSysSocialRelationsEx.score = objvSysSocialRelations.score;
        objvSysSocialRelationsEx.teaScore = objvSysSocialRelations.teaScore;
        objvSysSocialRelationsEx.stuScore = objvSysSocialRelations.stuScore;
        objvSysSocialRelationsEx.citationCount = objvSysSocialRelations.citationCount;
        objvSysSocialRelationsEx.versionCount = objvSysSocialRelations.versionCount;
        objvSysSocialRelationsEx.isSubmit = objvSysSocialRelations.isSubmit;
        objvSysSocialRelationsEx.citationId = objvSysSocialRelations.citationId;

        objvSysSocialRelationsEx.updDate = objvSysSocialRelations.updDate;
        objvSysSocialRelationsEx.updUser = objvSysSocialRelations.updUser;


        return objvSysSocialRelationsEx;
    }

    //转换论文观点数据到扩展观点实体
    private static GetVExByPV(objvgs_PSocialRela: clsvgs_PSocialRelaEN): clsvSysSocialRelationsExEN {
        var objvSysSocialRelationsEx: clsvSysSocialRelationsExEN = new clsvSysSocialRelationsExEN();
        objvSysSocialRelationsEx.socialId = objvgs_PSocialRela.socialId;
        objvSysSocialRelationsEx.fullName = objvgs_PSocialRela.fullName;
        objvSysSocialRelationsEx.nationality = objvgs_PSocialRela.nationality;
        objvSysSocialRelationsEx.workUnit = objvgs_PSocialRela.workUnit;
        objvSysSocialRelationsEx.major = objvgs_PSocialRela.major;
        objvSysSocialRelationsEx.achievement = objvgs_PSocialRela.achievement;
        objvSysSocialRelationsEx.detailedDescription = objvgs_PSocialRela.detailedDescription;
        objvSysSocialRelationsEx.okCount = objvgs_PSocialRela.okCount;
        objvSysSocialRelationsEx.appraiseCount = objvgs_PSocialRela.appraiseCount;
        objvSysSocialRelationsEx.score = objvgs_PSocialRela.score;
        objvSysSocialRelationsEx.teaScore = objvgs_PSocialRela.teaScore;
        objvSysSocialRelationsEx.stuScore = objvgs_PSocialRela.stuScore;
        objvSysSocialRelationsEx.citationCount = objvgs_PSocialRela.citationCount;
        objvSysSocialRelationsEx.versionCount = objvgs_PSocialRela.versionCount;
        objvSysSocialRelationsEx.isSubmit = objvgs_PSocialRela.isSubmit;
        objvSysSocialRelationsEx.mId = objvgs_PSocialRela.mId;

        objvSysSocialRelationsEx.updDate = objvgs_PSocialRela.socialDate;
        objvSysSocialRelationsEx.updUser = objvgs_PSocialRela.socialUserId;
        objvSysSocialRelationsEx.RelaUpdUser = objvgs_PSocialRela.updUser;
        objvSysSocialRelationsEx.RelaUpdDate = objvgs_PSocialRela.updDate;

        return objvSysSocialRelationsEx;
    }

    //转换主题观点数据到扩展观点实体
    private static GetVExByRTV(objvRTSysSocialRela: clsvRTSysSocialRelaEN): clsvSysSocialRelationsExEN {
        var objvSysSocialRelationsEx: clsvSysSocialRelationsExEN = new clsvSysSocialRelationsExEN();
        objvSysSocialRelationsEx.socialId = objvRTSysSocialRela.socialId;
        objvSysSocialRelationsEx.fullName = objvRTSysSocialRela.fullName;
        objvSysSocialRelationsEx.nationality = objvRTSysSocialRela.nationality;
        objvSysSocialRelationsEx.workUnit = objvRTSysSocialRela.workUnit;
        objvSysSocialRelationsEx.major = objvRTSysSocialRela.major;
        objvSysSocialRelationsEx.achievement = objvRTSysSocialRela.achievement;
        objvSysSocialRelationsEx.detailedDescription = objvRTSysSocialRela.detailedDescription;
        objvSysSocialRelationsEx.okCount = objvRTSysSocialRela.okCount;
        objvSysSocialRelationsEx.appraiseCount = objvRTSysSocialRela.appraiseCount;
        objvSysSocialRelationsEx.score = objvRTSysSocialRela.score;
        objvSysSocialRelationsEx.teaScore = objvRTSysSocialRela.teaScore;
        objvSysSocialRelationsEx.stuScore = objvRTSysSocialRela.stuScore;
        objvSysSocialRelationsEx.citationCount = objvRTSysSocialRela.citationCount;
        objvSysSocialRelationsEx.versionCount = objvRTSysSocialRela.versionCount;
        objvSysSocialRelationsEx.isSubmit = objvRTSysSocialRela.isSubmit;
        objvSysSocialRelationsEx.mId = objvRTSysSocialRela.mId;
        //objvSysSocialRelationsEx.citationId = objvRTSysSocialRela.citationId;

        objvSysSocialRelationsEx.updDate = objvRTSysSocialRela.socialUpdDate;
        objvSysSocialRelationsEx.updUser = objvRTSysSocialRela.socialUpdUser;
        objvSysSocialRelationsEx.RelaUpdUser = objvRTSysSocialRela.updUser;
        objvSysSocialRelationsEx.RelaUpdDate = objvRTSysSocialRela.updDate;

        objvSysSocialRelationsEx.memo = objvRTSysSocialRela.classificationId;
        return objvSysSocialRelationsEx;
    }

}
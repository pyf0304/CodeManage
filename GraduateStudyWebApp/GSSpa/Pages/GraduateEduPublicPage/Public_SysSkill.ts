import { clsvgs_PSkillRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PSkillRelaEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsgs_TotalDataRelaEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js";
import { clsgs_ViewsClassificationEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvRTSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { clsvSysSkillExEN } from "../TS/L0_EntityEx/GraduateEduTopic/clsvSysSkillExEN.js";
import { gs_TotalDataRela_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js";
import { gs_ViewsClassification_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js";
import { vConcept_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vSysSkill_GetFirstObjAsync, vSysSkill_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { vSysSocialRelations_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
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
export class Public_SysSkill {

    //绑定观点数据
    public static async Bind_vSysSkill(strSkillId: string): Promise<string> {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        var strhtml: string = "";
        var strWhereCond = "1=1 and skillId='" + strSkillId + "'";

        var objvSysSkill: clsvSysSkillEN = new clsvSysSkillEN;

        try {
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const responseObjLst = await vSysSkill_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvSysSkill = <clsvSysSkillEN>jsonData;
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
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + Public_Viewpoint.substrDate(objvSysSkill.updDate);
                strhtml += '</li>';

                //如果当前观点有引用论文，那么就显示论文标题和作者
                var varCitationId = objvSysSkill.citationId;
                if (varCitationId != "" && varCitationId != null) {
                    var objPaper: clsvPaperEN = await vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(varCitationId, strid_CurrEducls);
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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        return strhtml;
    }


    //绑定观点列表数据
    private static async BindList_vSysSkillEx(strOperationType: string, arrvSysSkillExObjLst: Array<clsvSysSkillExEN>): Promise<string> {
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
            var strWhereCondLike = `1=1 and voteTypeId='09' And ${clsSysVoteEN.con_UpdUser} = '${strUserId}'`;//新0605
            const responseRecCount6 = await SysVote_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

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

        strhtml += '<div class="info" id="infoSysskill"><div class="title btn-3">';
        if (strOperationType == "01") {
            strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加技能" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加技能</button></div>';
        } else {
            strhtml += '<div style="float:left;"><a href="#" title="技能">技能</a></div>';
        }


        strhtml += '</div><ul class="artlist">';
        var v = 0;//给内容加个序号
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
                var objClassification = arrgs_ViewsClassificationObjLst.find(x => x.classificationId == arrvSysSkillExObjLst[i].memo)
                if (objClassification != null) {
                    strhtml += '<li><span class="rowtit color6">[技能]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].skillName + '</span>&nbsp;&nbsp;<span style="color:#17a2b8;">(' + objClassification.classificationName + ')</span></li>';
                }
                else {
                    strhtml += '<li><span class="rowtit color6">[技能]：</span><span class="abstract-text">' + arrvSysSkillExObjLst[i].skillName + '</span>&nbsp;&nbsp;<span style="color:red;">(未分类)</span></li>';
                }
            } else {
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
                    } else {
                        strhtml += '<span class="rowtit color4">编辑&nbsp;/&nbsp;引用人：</span>' + objUser.userName + '&nbsp;/&nbsp;' + objUser2.userName;
                    }
                }
                if (arrvSysSkillExObjLst[i].updDate == arrvSysSkillExObjLst[i].RelaUpdDate) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑引用时间：</span>' + Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].updDate);
                } else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑&nbsp;/&nbsp;引用时间：</span>' + Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].updDate) + '&nbsp;/&nbsp;' + Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].RelaUpdDate);
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
                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSkillId);//新0605
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;';
                    if (objLike == null) {
                        strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strSkillId + '","' + arrvSysSkillExObjLst[i].updUser + '","09")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                    } else {
                        strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + strSkillId + '","' + arrvSysSkillExObjLst[i].updUser + '","09")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                    }
                    strhtml += '&nbsp;' + arrvSysSkillExObjLst[i].okCount + '&nbsp;&nbsp;';
                    //评论
                    //strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvSysSkillExObjLst[i].appraiseCount + '</span >';
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('相关技能评论', '../GraduateEduTools/SysComment?Key=" + strSkillId + "&Type=09&User=" + arrvSysSkillExObjLst[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrvSysSkillExObjLst[i].appraiseCount + "</span></button >";
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
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">编辑时间：</span>' + Public_Viewpoint.substrDate(arrvSysSkillExObjLst[i].updDate);
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

                arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1);//
                strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strSkillId + "&TypeId=09&OperationType=1','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";

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
                var objPaper: clsvPaperEN = await vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(varCitationId, strid_CurrEducls);
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[引用自]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
            }

            //主题查看——各观点关系查看
            if (strOperationType == "07") {

                arrgs_TotalDataRelaObjLst = arrgs_TotalDataRelaObjLst0.filter(x => x.totalDataId1 == strTotalDataId1);//
                if (arrgs_TotalDataRelaObjLst.length > 0) {
                    strhtml += '<li>';

                    strhtml += await Public_Viewpoint.BindList_gs_TotalDataRela(arrgs_TotalDataRelaObjLst);
                    strhtml += "&nbsp;&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('关联观点查看', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strSkillId + "&TypeId=09&OperationType=2')\"> <i class=\"layui-icon\" >&#xe642;</i>相关观点详细<span class=\"layui-badge\">" + arrgs_TotalDataRelaObjLst.length + "</span></button >";
                    strhtml += '</li>';
                }
            }

            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';

        return strhtml;
    }



    //绑定观点视图
    public static async BindList_vSysSkill(strOperationType: string, arrvSysSkillObjLst: Array<clsvSysSkillEN>): Promise<string> {
        var arrvSysSkillExObjLst: Array<clsvSysSkillExEN> = arrvSysSkillObjLst.map(this.GetVExByV);
        var strHtml = await this.BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst)
        return strHtml;
    }


    //绑定论文观点关系视图
    public static async BindList_vgs_PSkillRela(strOperationType: string, arrvgs_PSkillRelaObjLst: Array<clsvgs_PSkillRelaEN>) {
        var arrvSysSkillExObjLst: Array<clsvSysSkillExEN> = arrvgs_PSkillRelaObjLst.map(this.GetVExByPV);
        var strHtml = await this.BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst)
        return strHtml;
    }
    //绑定主题观点关系视图
    public static async BindList_vRTSysSkill(strOperationType: string, arrvRTSysSkillObjLst: Array<clsvRTSysSkillEN>) {
        var arrvSysSkillExObjLst: Array<clsvSysSkillExEN> = arrvRTSysSkillObjLst.map(this.GetVExByRTV);
        var strHtml = await this.BindList_vSysSkillEx(strOperationType, arrvSysSkillExObjLst)
        return strHtml;
    }

    //转换论文观点数据到扩展观点实体
    private static GetVExByV(objvSysSkill: clsvSysSkillEN): clsvSysSkillExEN {
        var objvSysSkillEx: clsvSysSkillExEN = new clsvSysSkillExEN();
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
    private static GetVExByPV(objvgs_PSkillRela: clsvgs_PSkillRelaEN): clsvSysSkillExEN {
        var objvSysSkillEx: clsvSysSkillExEN = new clsvSysSkillExEN();
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
    private static GetVExByRTV(objvRTSysSkill: clsvRTSysSkillEN): clsvSysSkillExEN {
        var objvSysSkillEx: clsvSysSkillExEN = new clsvSysSkillExEN();
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
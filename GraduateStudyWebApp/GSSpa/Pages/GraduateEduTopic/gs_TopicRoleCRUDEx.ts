
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TopicRoleCRUDEx
表名:gs_TopicRole(01120869)
生成代码版本:2021.01.08.1
生成日期:2021/01/08 01:08:04
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_TopicRoleEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js";
import { gs_TopicRole_GetObjLstAsync, gs_TopicRole_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRoleEx_AddDefaultSettingsAsync } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_TopicRoleExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { gs_TopicRoleCRUD } from "./gs_TopicRoleCRUD.js";
import { gs_TopicRole_EditEx } from "./gs_TopicRole_EditEx.js";
declare function ShowDialog_gs_TopicRole(strOpType): void;
declare function HideDialog_gs_TopicRole(): void;

declare function ShowDialogTopicRole(): void;
declare function HideDialogTopicRole(): void;

declare function layui_Alert(str1, str2): void;
declare var $;
declare var window;
/* gs_TopicRoleCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TopicRoleCRUDEx extends gs_TopicRoleCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortgs_TopicRoleBy: string = "topicRoleId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_gs_TopicRole();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "gs_TopicRole":
                alert('该类没有绑定该函数：[this.BindGv_gs_TopicRole_Cache]！');
                //this.BindGv_gs_TopicRole_Cache();
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_TopicRoleCRUDEx = new gs_TopicRoleCRUDEx();
        var objPage_Edit: gs_TopicRole_EditEx = new gs_TopicRole_EditEx(objPage);
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "UpdateRecordInTab":            //修改记录InTab
                objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordInTab":   //删除记录InTab 
                objPage.btnDelRecordInTab_Click(strKeyId);
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(gs_TopicRoleCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }


    //主题权限设置
    public async btnRoleTool_Click() {

        $("#divLoading").show();
        var strTopicId = $("#hidTopicRelaId").val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();



        var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = [];
        const responseObjLst1 = await gs_TopicRole_GetObjLstAsync("topicId='" + strTopicId + "' and menuNum not like'%6_%'").then((jsonData) => {
            arrgs_TopicRoleObjLst = <Array<clsgs_TopicRoleEN>>jsonData;
        });

        if (arrgs_TopicRoleObjLst.length > 0) {
            var strHtml = "";
            strHtml += "<ul>";
            for (var i = 0; i < arrgs_TopicRoleObjLst.length; i++) {
                var strTopicRoleId = arrgs_TopicRoleObjLst[i].topicRoleId;
                var strMenuNum = arrgs_TopicRoleObjLst[i].menuNum;
                var strMenuName = arrgs_TopicRoleObjLst[i].menuName;
                if (arrgs_TopicRoleObjLst[i].menuIsHide == true) {
                    strHtml += '<li><input type="checkbox" id="ckb' + strMenuNum + '" checked="checked" onclick=SubmitTopicRole_Click(this,"' + strTopicRoleId + '")>' + strMenuName + '</li>'
                } else {
                    strHtml += '<li><input type="checkbox" id="ckb' + strMenuNum + '" onclick=SubmitTopicRole_Click(this,"' + strTopicRoleId + '")>' + strMenuName + '</li>'
                }

            }
            strHtml += "</ul>";
            $("#editTopicRoleList").html(strHtml);

            ShowDialogTopicRole();
            $("#divLoading").hide();
        } else {
            try {

                const responseText1 = await gs_TopicRoleEx_AddDefaultSettingsAsync(strTopicId, strUserId);
                var returnBool3: boolean = !!responseText1;
                if (returnBool3 == true) {
                    var strInfo: string = `添加权限设置成功!`;
                    //$('#lblResult46').val(strInfo);
                    //显示信息框
                    //Alert1(strInfo);
                    //alert(strInfo);
                    console.log(strInfo);
                    this.btnRoleTool_Click();


                } else {
                    var strInfo: string = `添加权限设置出错!`;
                    //$('#lblResult46').val(strInfo);
                    //显示信息框
                    //Alert1(strInfo);
                    alert(strInfo);
                    //console.log(strInfo);
                    //$("#divLoading").hide();
                }



            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `添加权限设置异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }





    }



    //提交主题权限设置
    public async SubmitTopicRole_Click() {

        var objgs_TopicRoleEN: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
        objgs_TopicRoleEN.topicRoleId = $("#hidTopicRoleId").val();
        objgs_TopicRoleEN.menuIsHide = $("#hidMenuIsHide").val();
        objgs_TopicRoleEN.sf_UpdFldSetStr = objgs_TopicRoleEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_TopicRoleEN.topicRoleId == "" || objgs_TopicRoleEN.topicRoleId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await gs_TopicRole_UpdateRecordAsync(objgs_TopicRoleEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                const responseText1 = await this.btnRoleTool_Click();
                const responseText2 = await this.TopicMenuIsHide();
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }


    //得到3个关系列表数据；
    public async TopicMenuIsHide() {
        var strTopicId = $("#hidTopicRelaId").val();

        var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = [];
        const responseObjLst1 = await gs_TopicRole_GetObjLstAsync("topicId='" + strTopicId + "' and menuNum not like'%6_%'").then((jsonData) => {
            arrgs_TopicRoleObjLst = <Array<clsgs_TopicRoleEN>>jsonData;
        });

        if (arrgs_TopicRoleObjLst.length > 0) {
            for (var i = 0; i < arrgs_TopicRoleObjLst.length; i++) {
                //var strTopicRoleId = arrgs_TopicRoleObjLst[i].topicRoleId;
                var strMenuNum = arrgs_TopicRoleObjLst[i].menuNum;
                var menuIsHide = arrgs_TopicRoleObjLst[i].menuIsHide;

                switch (strMenuNum) {
                    case "1":
                        if (menuIsHide == true) {
                            $("#liUser").show();
                        } else {
                            $("#liUser").hide();
                        }
                        break;
                    case "2":
                        if (menuIsHide == true) {
                            $("#liResearchPlan").show();
                        } else {
                            $("#liResearchPlan").hide();
                        }
                        break;
                    case "3":
                        if (menuIsHide == true) {
                            $("#ligs_ReflectLog").show();
                        } else {
                            $("#ligs_ReflectLog").hide();
                        }
                        break;
                    case "4":
                        if (menuIsHide == true) {
                            $("#liPaper").show();
                        } else {
                            $("#liPaper").hide();
                        }
                        break;
                    case "5":
                        if (menuIsHide == true) {
                            $("#liSubViewpoint").show();
                        } else {
                            $("#liSubViewpoint").hide();
                        }
                        break;
                    case "6":
                        if (menuIsHide == true) {
                            $("#liAllViewpoint").show();
                        } else {
                            $("#liAllViewpoint").hide();
                        }
                        break;
                    case "7":
                        if (menuIsHide == true) {
                            $("#liOriginalPaper").show();
                        } else {
                            $("#liOriginalPaper").hide();
                        }
                        break;
                    case "8":
                        if (menuIsHide == true) {
                            $("#liMeetingMinutes").show();
                        } else {
                            $("#liMeetingMinutes").hide();
                        }
                        break;
                    case "9":
                        if (menuIsHide == true) {
                            $("#liPaperReport").show();
                        } else {
                            $("#liPaperReport").hide();
                        }
                        break;
                    case "10":
                        if (menuIsHide == true) {
                            $("#liTobeStudiedProblem").show();
                        } else {
                            $("#liTobeStudiedProblem").hide();
                        }
                        break;
                    case "11":
                        if (menuIsHide == true) {
                            $("#liResearchResult").show();
                        } else {
                            $("#liResearchResult").hide();
                        }
                        break;

                }

            }
        } else {
            $("#liUser").show();
            $("#liResearchPlan").show();
            $("#ligs_ReflectLog").show();
            $("#liPaper").show();
            $("#liSubViewpoint").show();
            $("#liAllViewpoint").show();
            $("#liOriginalPaper").show();
            $("#liMeetingMinutes").show();
            $("#liPaperReport").show();
            $("#liTobeStudiedProblem").show();
            $("#liResearchResult").show();
        }
    }

    //得到3个关系列表数据；
    public async TopicListMenuIsHide() {
        var strTopicId = $("#hidTopicRelaId").val();

        var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = [];
        const responseObjLst1 = await gs_TopicRole_GetObjLstAsync("topicId='" + strTopicId + "' and menuNum not like'%6_%'").then((jsonData) => {
            arrgs_TopicRoleObjLst = <Array<clsgs_TopicRoleEN>>jsonData;
        });

        if (arrgs_TopicRoleObjLst.length > 0) {
            for (var i = 0; i < arrgs_TopicRoleObjLst.length; i++) {
                //var strTopicRoleId = arrgs_TopicRoleObjLst[i].topicRoleId;
                var strMenuNum = arrgs_TopicRoleObjLst[i].menuNum;
                var menuIsHide = arrgs_TopicRoleObjLst[i].menuIsHide;

                switch (strMenuNum) {
                    case "1":
                        if (menuIsHide == true) {
                            $("#liUser").show();
                            $("#infoUser").show();
                            
                        } else {
                            $("#liUser").hide();
                            $("#infoUser").hide();
                        }
                        break;
                    case "2":
                        if (menuIsHide == true) {
                            $("#liResearchPlan").show();
                            $("#infoResearchPlan").show();
                        } else {
                            $("#liResearchPlan").hide();
                            $("#infoResearchPlan").hide();
                        }
                        break;
                    case "3":
                        if (menuIsHide == true) {
                            $("#ligs_ReflectLog").show();
                            $("#infogs_ReflectLog").show();
                        } else {
                            $("#ligs_ReflectLog").hide();
                            $("#infogs_ReflectLog").hide();
                        }
                        break;
                    case "4":
                        if (menuIsHide == true) {
                            $("#liPaper").show();
                            $("#infoPaper").show();
                        } else {
                            $("#liPaper").hide();
                            $("#infoPaper").hide();
                        }
                        break;
                    case "6":
                        if (menuIsHide == true) {
                            $("#divContent_menu2").show();

                            $("#infoViewpoint").show();
                            $("#infoExpert").show();
                            $("#infoConcept").show();
                            $("#infoFacts").show();
                            $("#infoBasis").show();
                            $("#infoSysskill").show();
                            $("#infoSysSocialRelations").show();
                        } else {
                            $("#divContent_menu2").hide();

                            $("#infoViewpoint").hide();
                            $("#infoExpert").hide();
                            $("#infoConcept").hide();
                            $("#infoFacts").hide();
                            $("#infoBasis").hide();
                            $("#infoSysskill").hide();
                            $("#infoSysSocialRelations").hide();
                        }
                        break;
                    case "7":
                        if (menuIsHide == true) {
                            $("#liOriginalPaper").show();
                            $("#infoPaper2").show();
                        } else {
                            $("#liOriginalPaper").hide();
                            $("#infoPaper2").hide();
                        }
                        break;
                    //case "8":
                    //    if (menuIsHide == true) {
                    //        $("#liMeetingMinutes").show();
                    //    } else {
                    //        $("#liMeetingMinutes").hide();
                    //    }
                    //    break;
                    //case "9":
                    //    if (menuIsHide == true) {
                    //        $("#liPaperReport").show();
                    //    } else {
                    //        $("#liPaperReport").hide();
                    //    }
                    //    break;
                    //case "10":
                    //    if (menuIsHide == true) {
                    //        $("#liTobeStudiedProblem").show();
                    //    } else {
                    //        $("#liTobeStudiedProblem").hide();
                    //    }
                    //    break;
                    //case "11":
                    //    if (menuIsHide == true) {
                    //        $("#liResearchResult").show();
                    //    } else {
                    //        $("#liResearchResult").hide();
                    //    }
                    //    break;

                }

            }
        } else {
            $("#liUser").show();
            $("#infoUser").show();

            $("#liResearchPlan").show();
            $("#infoResearchPlan").show();

            $("#ligs_ReflectLog").show();
            $("#infogs_ReflectLog").show();

            $("#liPaper").show();
            $("#infoPaper").show();

            $("#divContent_menu2").show();
            $("#infoViewpoint").show();
            $("#infoExpert").show();
            $("#infoConcept").show();
            $("#infoFacts").show();
            $("#infoBasis").show();
            $("#infoSysskill").show();
            $("#infoSysSocialRelations").show();

            $("#liOriginalPaper").show();
            $("#infoPaper2").show();

        }
    }
    
}
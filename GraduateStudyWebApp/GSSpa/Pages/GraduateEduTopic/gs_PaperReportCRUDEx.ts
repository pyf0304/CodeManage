
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_PaperReportCRUDEx
表名:gs_PaperReport(01120772)
生成代码版本:2020.11.22.1
生成日期:2020/12/01 00:55:27
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
import { clsgs_PaperReportEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_PaperReportEN.js";
import { clsvgs_PaperReportEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_PaperReportEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_PaperReport_DelRecordAsync, gs_PaperReport_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_PaperReportWApi.js";
import { vgs_PaperReport_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_PaperReportWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { gs_PaperReportEx_GetReportDateNumObjLstAsync, gs_PaperReportEx_GetReportMonthNumObjLstAsync, gs_PaperReportEx_GetReportYearNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_PaperReportExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi2 } from "../TS/PubFun/clsSysPara4WebApi2.js";
import { gs_PaperReportCRUD } from "./gs_PaperReportCRUD.js";
import { gs_PaperReport_EditEx } from "./gs_PaperReport_EditEx.js";
declare function ShowDialog_gs_PaperReport(strOpType): void;
declare function HideDialog_vgs_PaperReport(): void;
declare function layui_Alert(str1, str2): void;
declare var $;
declare var window;
/* gs_PaperReportCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PaperReportCRUDEx extends gs_PaperReportCRUD implements IShowList {
    public divName4Pager_ReportEdit = "divPaperReportEdit";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvgs_PaperReportBy: string = "reportId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.Page_Load();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "vgs_PaperReport":
                alert('该类没有绑定该函数：[this.BindGv_vgs_PaperReport_Cache]！');
                //this.BindGv_vgs_PaperReport_Cache();
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_PaperReportCRUDEx = new gs_PaperReportCRUDEx();
        var objPage_Edit: gs_PaperReport_EditEx = new gs_PaperReport_EditEx(objPage);
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_PaperReportCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //if (this.bolIsInitShow == false)  //
            //{
            //    this.objPager.InitShow(this.divName4Pager_ReportEdit);
            //    this.bolIsInitShow = true;  //
            //}
            const responseBindGv1 = await this.Bind_PaperReportTree();
            const responseBindGv2 = await this.Bind_PaperReportList();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }



    //论文汇报树绑定
    public async Bind_PaperReportTree() {
        var strWhereCond = " topicId='" + $("#hidTopicRelaId").val() + "'";

        //声明主题变量
        var arrgs_ReportYearNumObjLst: Array<clsgs_PaperReportEN> = [];
        var arrgs_ReportMonthNumObjLst1: Array<clsgs_PaperReportEN> = [];
        var arrgs_ReportMonthNumObjLst2: Array<clsgs_PaperReportEN> = [];

        const responseObjLst1 = await gs_PaperReportEx_GetReportYearNumObjLstAsync(strWhereCond).then((jsonData) => {
            arrgs_ReportYearNumObjLst = <Array<clsgs_PaperReportEN>>jsonData;

        });
        const responseObjLst2 = await gs_PaperReportEx_GetReportMonthNumObjLstAsync(strWhereCond).then((jsonData) => {
            arrgs_ReportMonthNumObjLst1 = <Array<clsgs_PaperReportEN>>jsonData;

        });

        var strhtml = "";

        for (var i = 0; i < arrgs_ReportYearNumObjLst.length; i++) {

            var strYear = arrgs_ReportYearNumObjLst[i].year

            strhtml += '<li class="li">';

            strhtml += '<a href="#" id="' + strYear + '" class="main" title="' + strYear + '" onclick=main_Click("' + strYear + '")>' + strYear + '年</a>';

            strhtml += '<ul class="submenu" id="ul' + strYear + '">';


            arrgs_ReportMonthNumObjLst2 = arrgs_ReportMonthNumObjLst1.filter(x => x.year == strYear);
            //循环数据
            for (var j = 0; j < arrgs_ReportMonthNumObjLst2.length; j++) {

                var strMonth = arrgs_ReportMonthNumObjLst2[j].month;


                strhtml += '<li id="' + strYear + strMonth + '" onclick=btnSelectMonth("' + strYear + '","' + strMonth + '")>';
                //默认存放第一条数据显示；
                //判断存放的id控件是否为空；

                if ($("#hidYear").val() == "") {
                    //存放Id
                    $("#hidYear").val(strYear);
                    $("#hidMonth").val(strMonth);

                    strhtml += '<a style="float:left;" href="#" title="' + strMonth + '" class="selected">' + strMonth + '月</a>';

                }
                else {
                    strhtml += '<a style="float:left;" href="#" title="' + strMonth + '">' + strMonth + '月</a>';

                }
                strhtml += '<div>';
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="badge badge-primary" title="论文汇报' + arrgs_ReportMonthNumObjLst2[j].memo + '条">' + arrgs_ReportMonthNumObjLst2[j].memo + '</span>';

                strhtml += '</div>';

                strhtml += '</li>';
            }
            strhtml += '</ul>';
            strhtml += '</li>';
        }
        $("#PaperReportTreeBind").html(strhtml);

    }


    //论文汇报列表绑定
    public async Bind_PaperReportList() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();
        var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;

        var strTopicId = $("#hidTopicRelaId").val();
        var strWhereCond = " topicId='" + strTopicId + "' and year='" + $("#hidYear").val() + "' and month='" + $("#hidMonth").val() + "'";

        //声明主题变量
        var arrgs_ReportDateNumObjLst: Array<clsgs_PaperReportEN> = [];
        var arrgs_PaperReportObjLst1: Array<clsvgs_PaperReportEN> = [];
        var arrgs_PaperReportObjLst2: Array<clsvgs_PaperReportEN> = [];

        try {
            const responseObjLst1 = await gs_PaperReportEx_GetReportDateNumObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_ReportDateNumObjLst = <Array<clsgs_PaperReportEN>>jsonData;

            });


            const responseObjLst2 = await vgs_PaperReport_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_PaperReportObjLst1 = <Array<clsvgs_PaperReportEN>>jsonData;

            });



            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';

            var strhtml = "";



            for (var i = 0; i < arrgs_ReportDateNumObjLst.length; i++) {
                var strReportDate = arrgs_ReportDateNumObjLst[i].reportDate
                strhtml += '<li class="layui-timeline-item">';
                strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
                strhtml += '<div class="layui-timeline-content layui-text">';
                strhtml += '<h3 class="layui-timeline-title">' + strReportDate + '</h3>';

                arrgs_PaperReportObjLst2 = arrgs_PaperReportObjLst1.filter(x => x.reportDate == strReportDate);
                for (var j = 0; j < arrgs_PaperReportObjLst2.length; j++) {
                    var strKeyId = arrgs_PaperReportObjLst2[j].reportId;
                    var strReportContent = arrgs_PaperReportObjLst2[j].reportContent;
                    //处理换行
                    strReportContent = strReportContent.replace(/\r\n/g, strBr);
                    strReportContent = strReportContent.replace(/\n/g, strBr);

                    var strPPT = arrgs_PaperReportObjLst2[j].ppTUrl;
                    var strPDF = arrgs_PaperReportObjLst2[j].pdFUrl;

                    var strUpdUser = arrgs_PaperReportObjLst2[j].updUser;
                    var isSubmit = arrgs_PaperReportObjLst2[j].isSubmit;
                    var versionCount = arrgs_PaperReportObjLst2[j].versionCount;
                    var strReportUser = arrgs_PaperReportObjLst2[j].reportUser;
                    var strReportPaper = arrgs_PaperReportObjLst2[j].paperTitle;
                    var strUpdDate = arrgs_PaperReportObjLst2[j].updDate;

                    //strhtml += '<div>汇报论文:' + strReportPaper + '</div>';
                    strhtml += '<span class="rowtit color1">[汇报论文]：</span>' + strReportPaper;

                    strhtml += '<div>' + strReportContent + '</div>';
                    strhtml += '<div>';
                    if (arrgs_PaperReportObjLst2[j].score != 0) {
                        //评分
                        strhtml += '综合评分：' + arrgs_PaperReportObjLst2[j].score;
                    }
                    if (arrgs_PaperReportObjLst2[j].teaScore != 0) {
                        strhtml += '&nbsp;&nbsp;教师评分：' + arrgs_PaperReportObjLst2[j].teaScore;
                    }
                    if (arrgs_PaperReportObjLst2[j].stuScore != 0) {
                        strhtml += '&nbsp;&nbsp;学生评分：' + arrgs_PaperReportObjLst2[j].stuScore + '&nbsp;&nbsp;';
                    }
                    strhtml += "<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('论文汇报评论', '../GraduateEduTools/SysComment?Key=" + strKeyId + "&Type=12&User=" + strUpdUser + "&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrgs_PaperReportObjLst2[j].appraiseCount + "</span></button >";

                    strhtml += '</div>';
                    strhtml += '<div style="width:100%;height:40px;">';
                    strhtml += '<div style="float:left;">';
                    var objUser = arrUsers.find(x => x.userId == strUpdUser);
                    if (objUser != null) {
                        strhtml += '<span class="rowtit color1">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[编辑时间]：</span>' + strUpdDate;
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[汇报人]：</span>' + strReportUser;
                    if (arrgs_PaperReportObjLst2[j].ppTUrl != "") {
                        var strfilepath = strAddressAndPort + arrgs_PaperReportObjLst2[j].ppTUrl;
                        var strfilename = strReportDate + "汇报的PPT";
                        strhtml += '<button title="下载PPT" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoad_PaperReport_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载PPT</button>';
                    }
                    if (arrgs_PaperReportObjLst2[j].pdFUrl != "") {
                        var strfilepath = strAddressAndPort + arrgs_PaperReportObjLst2[j].pdFUrl;
                        var strfilename = strReportDate + "汇报的PDF";
                        strhtml += '<button title="下载PDF" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoad_PaperReport_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载PDF</button>';
                        strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/Pdf?file=" + strfilepath + "')\">pdf查看</span>";
                    }
                    strhtml += '</div>';
                    strhtml += '<div style="float:right; margin-right:20px;">';
                    if (isSubmit == false) {
                        strhtml += '&nbsp;<span class="rowtit color2">未提交</span>&nbsp;&nbsp;';
                        if (strUserId == strUpdUser) {
                            //删除
                            strhtml += '<button title="提交论文汇报" class="layui-btn layui-btn-danger layui-btn-xs" onclick=UpdateIsSubmit_Click("' + strKeyId + '",1) href="javascript:;"><i class="layui-icon">&#x1005;</i>提交</button>';
                            //编辑
                            strhtml += '<button title="编辑论文汇报" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_PaperReport_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';
                        }
                        if (strRoleId != "00620003") {

                            //删除
                            strhtml += '<button title="删除论文汇报" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_PaperReport_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                        }
                    } else {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[已提交]</span>';
                        if (strRoleId == "00620001") {
                            //删除
                            strhtml += '<button title="撤销提交" class="layui-btn layui-btn-danger layui-btn-xs" onclick=UpdateIsSubmit_Click("' + strKeyId + '",0) href="javascript:;"><i class="layui-icon">&#xe9aa;</i>撤销提交</button>';
                        }

                    }
                    //判断角色
                    //不等于学生，其他角色都可以添加问题
                    strhtml += '</div>';

                    strhtml += '</div>';
                    //strhtml += '</br>';
                    strhtml += '<div style="border-bottom: 1px solid #eee;"></div>';

                }
                strhtml += '</div>';
                strhtml += '</li>';

            }
            $("#PaperReportList").html(strhtml);


        }
        catch (e) {
            console.error(e);
            var strMsg: string = `获取论文汇报列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //public GetPaperReport_PPT_PDF() {
    //    var strPapeId = $("#hidPaperId").val();
    //    //this.KeyId = strPaperRWId;
    //    var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
    //    var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
    //    try {
    //        const responseText = PaperAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //            arrPaperAttachmentObjLst = <Array<clsPaperAttachmentEN>>jsonData;
    //            for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {

    //                var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
    //                doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
    //            }
    //        });

    //    }
    //    catch (e) {
    //        console.error(e);
    //        var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}


    //论文汇报提交
    public async UpdateIsSubmit_Click(strKeyId: string, stata: number) {

        var objgs_PaperReportEN: clsgs_PaperReportEN = new clsgs_PaperReportEN();
        objgs_PaperReportEN.reportId = strKeyId;
        if (stata == 0) {
            objgs_PaperReportEN.isSubmit = false;
        } else {
            objgs_PaperReportEN.isSubmit = true;
        }
        objgs_PaperReportEN.sf_UpdFldSetStr = objgs_PaperReportEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_PaperReportEN.reportId == "" || objgs_PaperReportEN.reportId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await gs_PaperReport_UpdateRecordAsync(objgs_PaperReportEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                if (stata == 0) {
                    layui_Alert(1, "提交撤销成功！")
                } else {
                    layui_Alert(1, "会议提交成功！")
                }
                const responseBindGv = await this.Bind_PaperReportList();
                //gs_PaperReport_ReFreshCache();
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `会议提交不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }



    /* 
   在数据表里删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
  */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }

            const responseText = await this.DelRecord(strKeyId);
            const responseBindGv = await this.Bind_PaperReportList();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public async DelRecord(strReportId: string) {
        try {
            const responseText = await gs_PaperReport_DelRecordAsync(strReportId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_PaperReport_ReFreshCache();
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                //alert();
                layui_Alert(1, strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
}



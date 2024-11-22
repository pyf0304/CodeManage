
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TobeStudiedProblemCRUDEx
表名:gs_TobeStudiedProblem(01120776)
生成代码版本:2020.12.12.1
生成日期:2020/12/15 21:53:48
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
import { clsgs_TobeStudiedProblemEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js";
import { clsvgs_TobeStudiedProblemEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemVWApi.js";
import { gs_TobeStudiedProblem_DelRecordAsync, gs_TobeStudiedProblem_GetObjLstAsync, gs_TobeStudiedProblem_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js";
import { vRTUserRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { gs_TobeStudiedProblemEx_GetProblemDateNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_TobeStudiedProblemExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { gs_TobeStudiedProblemCRUD } from "./gs_TobeStudiedProblemCRUD.js";
import { gs_TobeStudiedProblem_EditEx } from "./gs_TobeStudiedProblem_EditEx.js";
declare function ShowDialog_gs_TobeStudiedProblem(strOpType): void;
declare function HideDialog_vgs_TobeStudiedProblem(): void;
declare var $;
declare var window;
declare function layui_Alert(str1, str2): void;
/* gs_TobeStudiedProblemCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TobeStudiedProblemCRUDEx extends gs_TobeStudiedProblemCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvgs_TobeStudiedProblemBy: string = "problemId";
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
            case "vgs_TobeStudiedProblem":
                alert('该类没有绑定该函数：[this.BindGv_vgs_TobeStudiedProblem_Cache]！');
                //this.BindGv_vgs_TobeStudiedProblem_Cache();
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_TobeStudiedProblemCRUDEx = new gs_TobeStudiedProblemCRUDEx();
        var objPage_Edit: gs_TobeStudiedProblem_EditEx = new gs_TobeStudiedProblem_EditEx(objPage);
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_TobeStudiedProblemCRUDExEx.btn_Click)中没有被处理！";
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
            //    this.objPager.InitShow(this.divName4Pager);
            //    this.bolIsInitShow = true;  //
            //}
            const responseBindGv2 = await this.Bind_TobeStudiedProblemList();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public Combinevgs_TobeStudiedProblemCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strTopicId = $("#hidTopicRelaId").val();
        var strWhereCond: string = " 1 = 1 and topicId='" + strTopicId + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ProblemTitle_q != "") {
                strWhereCond += ` And ${clsvgs_TobeStudiedProblemEN.con_ProblemTitle} like '% ${this.ProblemTitle_q}%'`;
            }
            if (this.ProblemDate_q != "") {
                strWhereCond += ` And ${clsvgs_TobeStudiedProblemEN.con_ProblemDate} like '% ${this.ProblemDate_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_TobeStudiedProblemCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //待研究问题列表绑定
    public async Bind_TobeStudiedProblemList() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();
        var strTopicId = $("#hidTopicRelaId").val();
        var strWhereCond = this.Combinevgs_TobeStudiedProblemCondition();
        //var strWhereCond = " topicId='" + strTopicId + "' and year='" + $("#hidYear").val() + "' and month='" + $("#hidMonth").val() + "'";

        //声明主题变量
        var arrgs_ProblemDateNumObjLst: Array<clsgs_TobeStudiedProblemEN> = [];
        var arrgs_TobeStudiedProblemObjLst1: Array<clsgs_TobeStudiedProblemEN> = [];
        var arrgs_TobeStudiedProblemObjLst2: Array<clsgs_TobeStudiedProblemEN> = [];

        var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        const responseObjLst1 = await gs_TobeStudiedProblemEx_GetProblemDateNumObjLstAsync(strWhereCond).then((jsonData) => {
            arrgs_ProblemDateNumObjLst = <Array<clsgs_TobeStudiedProblemEN>>jsonData;

        });


        const responseObjLst2 = await gs_TobeStudiedProblem_GetObjLstAsync(strWhereCond).then((jsonData) => {
            arrgs_TobeStudiedProblemObjLst1 = <Array<clsgs_TobeStudiedProblemEN>>jsonData;

        });

        var strWhereCond2 = "topicId ='" + strTopicId + "'";
        const responseObjLst3 = await vRTUserRela_GetObjLstAsync(strWhereCond2).then((jsonData) => {
            arrRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
        });

        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
        //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';

        var strhtml = "";

        //循环数据源 
        strhtml += '<div><th colspan="2">';
        for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {

            var strUserName = arrRTUserRelaObjLst[y].userName;
            var strColorCode = arrRTUserRelaObjLst[y].colorCode;
            //得到显示用户的色码块
            strhtml += '<label style="background: ' + strColorCode + '">&nbsp;&nbsp;&nbsp;&nbsp;</label>&nbsp;&nbsp;<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';

        }
        strhtml += '</th></div>';

        for (var i = 0; i < arrgs_ProblemDateNumObjLst.length; i++) {
            var strProblemDate = arrgs_ProblemDateNumObjLst[i].problemDate
            strhtml += '<li class="layui-timeline-item">';
            strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
            strhtml += '<div class="layui-timeline-content layui-text">';
            strhtml += '<h3 class="layui-timeline-title">' + strProblemDate + '</h3>';

            arrgs_TobeStudiedProblemObjLst2 = arrgs_TobeStudiedProblemObjLst1.filter(x => x.problemDate == strProblemDate);
            for (var j = 0; j < arrgs_TobeStudiedProblemObjLst2.length; j++) {
                var strKeyId = arrgs_TobeStudiedProblemObjLst2[j].problemId;
                var strProblemTitle = arrgs_TobeStudiedProblemObjLst2[j].problemTitle;
                var strProblemContent = arrgs_TobeStudiedProblemObjLst2[j].problemContent;
                ////处理换行
                //strProblemContent = strProblemContent.replace(/\r\n/g, strBr);
                //strProblemContent = strProblemContent.replace(/\n/g, strBr);

                var strUpdUser = arrgs_TobeStudiedProblemObjLst2[j].updUser;
                var isSubmit = arrgs_TobeStudiedProblemObjLst2[j].isSubmit;
                var versionCount = arrgs_TobeStudiedProblemObjLst2[j].versionCount;
                var strParticipant = arrgs_TobeStudiedProblemObjLst2[j].participant;

                //strhtml += '<h3>' + strProblemTitle + '</h3>';
                //strhtml += '<div>' + strProblemContent + '</div>';
                //strhtml += '<h3><span class="rowtit color1">[问题标题]：</span>' + strProblemTitle + '</h3>';
                strhtml += '<span class="rowtit color1">[问题名称]：</span>' + strProblemTitle;
                strhtml += '<br/>';
                strhtml += '<span class="rowtit color2">[问题说明]：</span>' + strProblemContent;
                //strhtml += '<div><span class="rowtit color2">[问题说明]：</span>' + strProblemContent + '</div>';

                strhtml += '<div style="width:100%;height:40px;">';
                strhtml += '<div style="float:left;">';
                var objUser = arrUsers.find(x => x.userId == strUpdUser);
                if (objUser != null) {
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[参与者]：</span>' + strParticipant;
                strhtml += '</div>';
                strhtml += '<div style="float:right;">';
                if (isSubmit == false) {
                    strhtml += '&nbsp;<span class="rowtit color2">未提交</span>&nbsp;&nbsp;';
                    if (strRoleId != "00620003") {
                        //删除
                        strhtml += '<button title="提交待研究问题" class="layui-btn layui-btn-danger layui-btn-xs" onclick=Update_ProblemIsSubmit_Click("' + strKeyId + '",1) href="javascript:;"><i class="layui-icon">&#x1005;</i>提交</button>';
                        //删除
                        strhtml += '<button title="删除待研究问题" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_TobeStudiedProblem_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                    }
                    //编辑
                    strhtml += '<button title="编辑待研究问题" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_TobeStudiedProblem_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';

                } else {
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[已提交]：</span>';
                    if (strRoleId == "00620001") {
                        //删除
                        strhtml += '<button title="撤销提交" class="layui-btn layui-btn-danger layui-btn-xs" onclick=Update_ProblemIsSubmit_Click("' + strKeyId + '",0) href="javascript:;"><i class="layui-icon">&#xe9aa;</i>撤销提交</button>';
                    }

                }
                strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('待研究问题历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strKeyId + "&Type=14')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本<span class=\"layui-badge\">" + versionCount + "</span></button >";
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
        $("#TobeStudiedProblemList").html(strhtml);

    }


    //待研究问题提交
    public async Update_ProblemIsSubmit_Click(strKeyId: string, stata: number) {

        var objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
        objgs_TobeStudiedProblemEN.problemId = strKeyId;
        if (stata == 0) {
            objgs_TobeStudiedProblemEN.isSubmit = false;
        } else {
            objgs_TobeStudiedProblemEN.isSubmit = true;
        }
        objgs_TobeStudiedProblemEN.sf_UpdFldSetStr = objgs_TobeStudiedProblemEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_TobeStudiedProblemEN.problemId == "" || objgs_TobeStudiedProblemEN.problemId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await gs_TobeStudiedProblem_UpdateRecordAsync(objgs_TobeStudiedProblemEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                if (stata == 0) {
                    layui_Alert(1, "提交撤销成功！")
                } else {
                    layui_Alert(1, "待研究问题提交成功！")
                }
                const responseBindGv = await this.Bind_TobeStudiedProblemList();
                //gs_TobeStudiedProblem_ReFreshCache();
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `待研究问题提交不成功,${e}.`;
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

            const responseText1 = await this.VDelRecord(strKeyId);
            const responseText2 = await this.DelRecord(strKeyId);
            const responseBindGv = await this.Bind_TobeStudiedProblemList();
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
    public async DelRecord(strProblemId: string) {
        try {
            const responseText = await gs_TobeStudiedProblem_DelRecordAsync(strProblemId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_TobeStudiedProblem_ReFreshCache();
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
    //历史版本删除
    public VDelRecord(arrProblemId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync("problemId='" + arrProblemId + "'").then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        var strInfo: string = `删除历史版本成功!`;
                        ////显示信息框
                        //alert(strInfo);
                        console.log(strInfo);
                    }
                    else {
                        var strInfo: string = `历史版本删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    console.log("完成DelMultiRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }


}
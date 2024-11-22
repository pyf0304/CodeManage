﻿
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperCollectionLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js";
import { clsvSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperCollectionLog_AddNewRecordAsync, PaperCollectionLog_GetRecCountByCondAsync, PaperCollectionLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js";
import { PaperDownloadLog_AddNewRecordAsync, PaperDownloadLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Paper_GetFirstObjAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vSysComment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { SysCommentEx_AddNewRecordExAsync, SysCommentEx_DelRecordAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;

declare function doDownLoad(filepath, filename): void;
declare var strAddressAndPort;

/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare function HideDialog(): void;

declare function AlertOK(): void;
declare function AlertNo(): void;
declare function AlertScore(): void;
declare function AlertComment(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* PaperReadWriteCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class PaperDetail extends PaperCRUD {
    public mstrListDiv: string = "divDataLst";
    //public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;


    /*
    //根据ID得到论文读写表数据
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
 */
    public async btnDetailRecord_Click() {
        try {
            if (clsPublocalStorage.userId != "") {
                $("#hidUserId").val(clsPublocalStorage.userId);
                $("#hidRoleId").val(clsPublocalStorage.roleId);
                $("#bUserName").append(clsPublocalStorage.userName);

                const gvResult1 = await this.IsVote();//判断是否点赞或者收藏
                const gvResult2 = await this.IsCollection();//判断是否点赞或者收藏
                //this.btnAddViews_Click();

                const gvResult3 = await this.DetailRecord();//绑定论文信息
                const gvResult4 = await this.Bind_ShowAppraise_Click();//绑定评论
                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }

    //判断是否点赞或收藏并作出反应
    public async IsVote() {
        var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and tableKey='" + $("#hidPaperId").val() + "' and voteTypeId='01'";

        try {
            const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                //var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                //alert(strMsg);

                $("#imgVotet").attr("src", "../img/vote2.png");
                //return responseText;//一定要有一个返回值，否则会出错！
            }
            else {
                $("#imgVotet").attr("src", "../img/vote.png");
            }

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    public async IsCollection() {

        var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and paperId=" + $("#hidPaperId").val();
        try {
            const responseText2 = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText2;
            if (bolIsExist == true) {
                $("#imgCollection").attr("src", "../img/collection2.png");
                //var strMsg: string = `您已经收藏过这条论文了！`;
                //alert(strMsg);
                //return responseText2;//一定要有一个返回值，否则会出错！
            }
            else {
                $("#imgCollection").attr("src", "../img/collection.png");
            }


        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 根据关键字获取相应的记录的对象
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
   <param name = "sender">参数列表</param>
 */
    public async DetailRecord() {
        const strThisFuncName = this.DetailRecord.name;
        //this.keyId = strPaperRWId;
        var strWhereCond = await this.CombinevPaperReadWriteCondition();

        try {
            const objvPaperEN = await Paper_GetFirstObjAsync(strWhereCond);
            if (objvPaperEN == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            this.GetReadWriteData(objvPaperEN);
            console.log("完成Detail!");



        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }

    }
    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjPaperReadWriteEN">表实体类对象</param>
  */
    public async GetReadWriteData(pobjvPaperEN: clsPaperEN) {
        if (pobjvPaperEN.attachmentCount > 0) {
            $("#btnDownLoadFile").show();
            $("#lblDownLoadFile").hide();

        } else {
            $("#btnDownLoadFile").hide();
            $("#lblDownLoadFile").show();
        }
        //判断引用论文，自研论文
        if (pobjvPaperEN.paperTypeId == "02") {
            var strPaperTitle = pobjvPaperEN.paperTitle;
            $("#txtPaperTitle").html(strPaperTitle);//论文标题
        }
        else {
            $("#txtPaperTitle").html(pobjvPaperEN.paperTitle);//论文标题
        }

        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

        $("#txtKeyword").html(pobjvPaperEN.keyword);//关键字Id
        $("#txtPeriodical").html(pobjvPaperEN.periodical);//
        $("#txtAuthor").html(pobjvPaperEN.author);//作者
        $("#txtResearchQuestion").html(pobjvPaperEN.researchQuestion);//研究问题
        $("#txtPaperContent").html(pobjvPaperEN.paperContent);//论文内容

        $("#lblUpdDate").text(pobjvPaperEN.updDate);//编辑时间
        var objUser = arrUsers.find(x => x.userId == pobjvPaperEN.updUser);
        if (objUser != null) {
            $("#lblUpdUser").text(objUser.userName);//编辑用户
        }

        $("#hidPaperUserId").val(pobjvPaperEN.updUser);//编辑用户

        $("#lblOKCount").text(pobjvPaperEN.okCount);//点赞数量

        $("#lblViews").text(pobjvPaperEN.browseNumber);//浏览量

        $("#lblViews").val(pobjvPaperEN.browseNumber);//浏览量

        if (pobjvPaperEN.score != null) {
            $("#lblScore").text(pobjvPaperEN.score);//统计平均评分
        }
        else {
            $("#lblScore").text(0);//统计平均评分
        }

        this.btnAddBrowseNumber_Click();

        //$("#txtMemo").html(pobjvPaperEN.memo);//备注
    }


    /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
    public async CombinevPaperReadWriteCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperId = $("#hidPaperId").val();
        //var strUserId = clsPublocalStorage.userId;

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {


            strWhereCond += " And paperId = '" + strPaperId + "'";


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    //添加论文浏览量

    public async btnAddBrowseNumber_Click() {
        const strThisFuncName = this.btnAddBrowseNumber_Click.name;
        //
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId($("#hidPaperId").val());
        var intBrowseNum: number = parseInt($("#lblViews").val());
        if (intBrowseNum == null && intBrowseNum == 0 && intBrowseNum == "") {
            objPaperEN.SetBrowseNumber(1);
        }
        else {
            objPaperEN.SetBrowseNumber(intBrowseNum + 1);
        }


        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        try {
            const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    //var strInfo: string = `论文审核成功!`;
                    //$('#lblResult44').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);

                    //HideDialog();
                    //this.BindGv_vPaper();
                    //this.DetailRecord();
                }
                else {
                    var strInfo: string = `不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("增加浏览量失败");
                }

            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
        }

    }

    //添加点赞
    public async btnAddVote_Click() {
        const strThisFuncName = this.btnAddVote_Click.name;

        //this.DivName = "divAddNewRecordSave";
        var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objSysVoteEN.SetTableKey($("#hidPaperId").val());
        objSysVoteEN.SetVoteTypeId("01");
        objSysVoteEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objSysVoteEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);

        var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and tableKey=" + $("#hidPaperId").val();
        try {
            const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await SysVote_AddNewRecordAsync(objSysVoteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and voteTypeId='01' and tableKey=" + $("#hidPaperId").val();
                var intVoteCount = await SysVote_GetRecCountByCondAsync(strWhereCond2);
                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.SetPaperId($("#hidPaperId").val());
                objPaperEN.SetOkCount(intVoteCount);

                objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        this.IsVote();//判断是否点赞或者收藏
                    }
                    else {
                        var strInfo: string = `点赞不成功!`;
                        alert(strInfo);
                        console.log("点赞不成功");
                    }

                });
            }
            else {
                var strInfo: string = `点赞不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);

            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `点赞不成功,${e}.`;
            alert(strMsg);
            return false;
        }

        return true;//一定要有一个返回值，否则会出错！
    }


    //添加收藏
    public async btnAddCollection_Click() {
        const strThisFuncName = this.btnAddCollection_Click.name;
        //this.DivName = "divAddNewRecordSave";
        var objPaperCollectionLogEN: clsPaperCollectionLogEN = new clsPaperCollectionLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperCollectionLogEN.SetPaperId($("#hidPaperId").val());
        objPaperCollectionLogEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objPaperCollectionLogEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + objPaperCollectionLogEN.paperId;
        try {
            const responseText = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经收藏过这条论文了！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " paperId=" + $("#hidPaperId").val();
                var intCollectionCount = await PaperCollectionLog_GetRecCountByCondAsync(strWhereCond2);
                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.SetPaperId($("#hidPaperId").val());
                objPaperEN.SetCollectionCount(intCollectionCount);

                objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        this.IsCollection();
                    }
                    else {
                        var strInfo: string = `收藏不成功!`;
                        alert(strInfo);
                        console.log("收藏不成功");
                    }

                });
            }
            else {
                var strInfo: string = `收藏不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `收藏不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }


    //     var objSysCommentEN: clsSysCommentEN = new clsSysCommentEN();
    //this.PutDataToSysCommentClass(objSysCommentEN);
    //try {
    //    const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);

    //添加评论
    public async SubmitAppraise1_Click() {
        this.divName4Layout = "divAddNewRecordSave";
        var objSysCommentEN: clsSysCommentEN = new clsSysCommentEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        objSysCommentEN.SetTableKey($("#hidPaperId").val());
        objSysCommentEN.SetCommentTypeId("01");
        objSysCommentEN.SetParentId($("#hidParentId").val());
        if ($("#hidRoleId").val() == "00620003") {
            objSysCommentEN.SetScoreType("1");
        } else {

            objSysCommentEN.SetScoreType("2");
            objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);

        }
        var strvalue = $("#pin1").val();
        //判断是否有打分 
        if (strvalue != "" && strvalue != undefined) {
            //获取值转化分数
            var strScore: string = this.GetScorebyText(strvalue);

            //判断内容是否输入
            if ($("#txtAppraiseContent").val() != "") {
                objSysCommentEN.SetComment($("#txtAppraiseContent").val());// 评议内容
                objSysCommentEN.SetScore(parseInt(strScore));// 打分
                objSysCommentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
                objSysCommentEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
                try {
                    const responseText2 = await SysCommentEx_AddNewRecordExAsync(objSysCommentEN);
                    //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                    var returnBool: boolean = !!responseText2;
                    if (returnBool == true) {
                        //var strInfo: string = `添加评论成功!`;
                        //$('#lblResult40').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        AlertOK();

                        this.Bind_ShowAppraise_Click();
                        //HideDialog3();
                        //this.BindGv_vPaperSubViewpoint();
                        //this.btnShowAppraise_Click();
                    }
                    else {
                        var strInfo: string = `添加评论不成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        this.Bind_ShowAppraise_Click();
                        //HideDialog3();
                        //this.BindGv_vPaperSubViewpoint();
                        //this.btnShowAppraise_Click();
                    }

                    $("#J_PostBtn").attr("disabled", false);
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    return responseText2;//一定要有一个返回值，否则会出错！
                }
                catch (e) {
                    $("#J_PostBtn").attr("disabled", false);
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg: string = `添加评论不成功,${e}.`;
                    alert(strMsg);
                }
            }
            else {
                $("#J_PostBtn").attr("disabled", false);
                $("#btnOKUpdAppraise").attr("disabled", false);
                //var strInfo: string = `请输入评语!`;
                ////显示信息框
                //alert(strInfo);
                AlertComment();
                return;
            }

        }
        else {
            $("#J_PostBtn").attr("disabled", false);
            $("#btnOKUpdAppraise").attr("disabled", false);
            //var strInfo: string = `请选择评分!`;
            ////显示信息框
            //alert(strInfo);
            AlertScore();

            return;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    //回复评论
    public async SubmitAppraise2_Click() {
        this.divName4Layout = "divAddNewRecordSave";
        var objSysCommentEN: clsSysCommentEN = new clsSysCommentEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        objSysCommentEN.SetTableKey($("#hidPaperId").val());
        objSysCommentEN.SetCommentTypeId("01");
        objSysCommentEN.SetParentId($("#hidParentId").val());
        if ($("#hidRoleId").val() == "00620003") {
            objSysCommentEN.SetScoreType("1");
        } else {
            objSysCommentEN.SetScoreType("2");
            objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        }

        var strvalue = $("#pin2").val();
        //判断是否有打分 
        if (strvalue != "" && strvalue != undefined) {
            //获取值转化分数
            var strScore: string = this.GetScorebyText(strvalue);

            //判断内容是否输入
            if ($("#txtAppraiseContent2").val() != "") {
                objSysCommentEN.SetComment($("#txtAppraiseContent2").val());// 评议内容
                objSysCommentEN.SetScore(parseInt(strScore));// 打分
                objSysCommentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
                objSysCommentEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
                try {
                    const responseText2 = await SysCommentEx_AddNewRecordExAsync(objSysCommentEN);
                    //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                    var returnBool: boolean = !!responseText2;
                    if (returnBool == true) {
                        var strInfo: string = `回复评论成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);


                        this.Bind_ShowAppraise_Click();
                        HideDialog();
                        //HideDialog3();
                        //this.BindGv_vPaperSubViewpoint();
                        //this.btnShowAppraise_Click();
                    }
                    else {
                        var strInfo: string = `回复评论不成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        this.Bind_ShowAppraise_Click();
                        HideDialog();
                        //HideDialog3();
                        //this.BindGv_vPaperSubViewpoint();
                        //this.btnShowAppraise_Click();
                    }


                    $("#btnOKUpdAppraise").attr("disabled", false);
                    return responseText2;//一定要有一个返回值，否则会出错！
                }
                catch (e) {

                    $("#btnOKUpdAppraise").attr("disabled", false);
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg: string = `添加评论不成功,${e}.`;
                    alert(strMsg);
                }
            }
            else {

                $("#btnOKUpdAppraise").attr("disabled", false);
                var strInfo: string = `请输入评语!`;
                //显示信息框
                alert(strInfo);
                return;
            }

        }
        else {

            $("#btnOKUpdAppraise").attr("disabled", false);
            var strInfo: string = `请选择评分!`;
            //显示信息框
            alert(strInfo);
            return;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    //通过得到的值判断，得到分数
    public GetScorebyText(sValue: string) {

        var Score: string = "";
        if (sValue == "1") {
            Score = "2";
        }
        else if (sValue == "2") {
            Score = "4";
        }
        else if (sValue == "3") {
            Score = "6";
        }
        else if (sValue == "4") {
            Score = "8";
        }
        else {
            Score = "10";
        }
        return Score;
    }


    /* 
    删除评论内容
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDeleteComment_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelRecord(strKeyId);
            const response1 = await this.Bind_ShowAppraise_Click();

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
    public async DelRecord_pyf(strCommentId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysCommentEx_DelRecordAsync(strCommentId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        AlertNo();
                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    console.log("完成DelRecord!");
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



    //显示评论
    public async Bind_ShowAppraise_Click() {

        var arrvSysCommentObjLst1: Array<clsvSysCommentEN> = [];
        var arrvSysCommentObjLst2: Array<clsvSysCommentEN> = [];
        var arrvSysCommentObjLst3: Array<clsvSysCommentEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";
        var strUserId = clsPublocalStorage.userId;

        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Desc";
        }
        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseText1 = await vSysComment_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvSysCommentObjLst1 = <Array<clsvSysCommentEN>>jsonData;
            });
            const responseText2 = await vSysComment_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvSysCommentObjLst2 = <Array<clsvSysCommentEN>>jsonData;
            });

            var strhtml = "";
            var varNum = 0;
            $('#J_ShortComment div').remove();
            for (var i = 0; i < arrvSysCommentObjLst1.length; i++) {
                varNum++;
                strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                var strUserName: string = "";
                var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst1[i].updUser);
                if (objUser != null) {
                    strUserName = objUser.userName;
                }
                if ($("#hidPaperUserId").val() == arrvSysCommentObjLst1[i].updUser) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + strUserName + '</span>';
                } else {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + strUserName + '</span>';
                }
                strhtml += '<span class="comment-time">' + arrvSysCommentObjLst1[i].updDate + '</span>';
                strhtml += '  <span class="comment-username J_User">' + varNum + '楼</span></p>';
                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                strhtml += '<div class="comment-content J_CommentContent">' + arrvSysCommentObjLst1[i].comment + '</div>';

                //回复区

                arrvSysCommentObjLst3 = arrvSysCommentObjLst2.filter(x => x.parentId == arrvSysCommentObjLst1[i].commentId);
                if (arrvSysCommentObjLst3.length > 0) {
                    strhtml += '<div class="reply J_ReplyBlock">';
                    for (var j = 0; j < arrvSysCommentObjLst3.length; j++) {

                        strhtml += '<div class="reply-block">';

                        strhtml += '<div class="reply-content">';
                        var strUserName: string = "";
                        var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst3[j].updUser);
                        if (objUser != null) {
                            strUserName = objUser.userName;
                        }
                        if ($("#hidPaperUserId").val() == arrvSysCommentObjLst3[j].updUser) {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + strUserName + ')</b>：</span>';
                        } else {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + strUserName + '</b>：</span>';
                        }
                        strhtml += '' + arrvSysCommentObjLst3[j].comment + '</div>';



                        strhtml += '<div class="reply-operate reply-operate--hot">'
                        if (arrvSysCommentObjLst3[j].scoreType == "2") {
                            strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分：<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                        } else {
                            strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分：<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                        }
                        strhtml += '<i class="reply-dot">·</i><span>' + arrvSysCommentObjLst3[j].updDate + '</span>';
                        strhtml += '</div>';


                        strhtml += '</div>';

                    }
                    strhtml += '</div>';
                }
                ///操作区
                strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                if (arrvSysCommentObjLst1[i].scoreType == "2") {
                    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分：<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                } else {
                    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分：<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                }

                strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrvSysCommentObjLst1[i].commentId + '")>回复</span>';
                strhtml += '</div>';

                if (strUserId == arrvSysCommentObjLst1[i].updUser) {
                    strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnDeleteComment_Click("' + arrvSysCommentObjLst1[i].commentId + '")>删除</div>';
                }

                strhtml += '</div></div>';
            }
            $("#J_ShortComment").append(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }

    }
    //下载文件
    public btnDownLoadFile_Click() {

        this.GetPaperAttachmentRecord();
        this.btnAddDownload_Click();
    }


    public GetPaperAttachmentRecord() {
        var strPapeId = $("#hidPaperId").val();
        //this.keyId = strPaperRWId;
        var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        try {
            const responseText = PaperAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrPaperAttachmentObjLst = <Array<clsPaperAttachmentEN>>jsonData;
                for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {

                    var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                }
            });

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }



    }

    //添加下载量
    public async btnAddDownload_Click() {
        const strThisFuncName = this.btnAddDownload_Click.name;
        //this.DivName = "divAddNewRecordSave";
        var objPaperDownloadLogEN: clsPaperDownloadLogEN = new clsPaperDownloadLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperDownloadLogEN.SetPaperId($("#hidPaperId").val());
        objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
        try {
            //const responseText = await PaperDownloadLog_IsExistRecordAsync(strWhereCond);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    //var strMsg: string = `您已经收藏过这条论文了！`;
            //    //alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}

            const responseText2 = await PaperDownloadLog_AddNewRecordAsync(objPaperDownloadLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strWhereCond2 = " paperId=" + $("#hidPaperId").val();
                var intDownloadCount = await PaperDownloadLog_GetRecCountByCondAsync(strWhereCond2);
                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.SetPaperId($("#hidPaperId").val());
                objPaperEN.SetDownloadCount(intDownloadCount);

                objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                    }
                    else {
                        var strInfo: string = `添加下载量不成功!`;
                        alert(strInfo);
                        console.log("添加下载量不成功");
                    }

                });
            }
            else {
                var strInfo: string = `添加下载量不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加下载量不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }




    /*
   * 获取当前页序号
  */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }

    /*
    * 论文标题
   */
    public set paperTitle(value: string) {
        $("#txtPaperTitle").val(value);
    }
    /*
    * 论文标题
   */
    public get paperTitle(): string {
        return $("#txtPaperTitle").val();
    }
    /*
    * 论文标题
   */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    /*
    * 期刊
   */
    public set periodical(value: string) {
        $("#txtPeriodical").val(value);
    }
    /*
    * 期刊
   */
    public get periodical(): string {
        return $("#txtPeriodical").val();
    }
    /*
    * 引用Id
   */
    public set quoteId(value: string) {
        $("#txtQuoteId").val(value);
    }
    /*
    * 引用Id
   */
    public get quoteId(): string {
        return $("#txtQuoteId").val();
    }
    /*
    * 研究问题
   */
    public set researchQuestion(value: string) {
        $("#txtResearchQuestion").val(value);
    }
    /*
    * 研究问题
   */
    public get researchQuestion(): string {
        return $("#txtResearchQuestion").val();
    }

    /*
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 主题内容
   */
    public set paperContent(value: string) {
        $("#txtPaperContent").val(value);
    }
    /*
    * 主题内容
   */
    public get paperContent(): string {
        return $("#txtPaperContent").val();
    }

    /*
    * 关键字
   */
    public set keyword(value: string) {
        $("#txtKeyword").val(value);
    }
    /*
    * 关键字
   */
    public get keyword(): string {
        return $("#txtKeyword").val();
    }
    /*
   * 作者
  */
    public set author(value: string) {
        $("#txtAuthor").val(value);
    }
    /*
    * 作者
   */
    public get author(): string {
        return $("#txtAuthor").val();
    }


    /*
* 获取年月日
*/
    public getNowDate(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
        if (month <= 9) {
            month = "0" + month;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }

        return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
    }
}
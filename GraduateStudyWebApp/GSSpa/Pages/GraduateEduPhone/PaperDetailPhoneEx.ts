
/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperReadWrite_QUDI_TS
表名:PaperReadWrite(01120547)
生成代码版本:2019.12.06.1
生成日期:2019/12/26 15:55:28
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/

import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
//import { clsPaperAppraiseEN } from "../TS/L0_Entity/GraduateEdu/clsPaperAppraiseEN.js";
//import { clsPaperAppraiseWApi } from "../TS/L3_ForWApi/GraduateEdu/clsPaperAppraiseWApi.js";
//import { clsvPaperAppraiseEN } from "../TS/L0_Entity/GraduateEdu/clsvPaperAppraiseEN.js";
//import { clsvPaperAppraiseWApi } from "../TS/L3_ForWApi/GraduateEdu/clsvPaperAppraiseWApi.js";
//import { clsPaperLikeLogEN } from "../TS/L0_Entity/GraduateEdu/clsPaperLikeLogEN.js";
//import { clsPaperLikeLogWApi } from "../TS/L3_ForWApi/GraduateEdu/clsPaperLikeLogWApi.js";
import { Paper_QUDI_TS } from "../GraduateEduPaper/Paper_QUDI_TS.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { vPaper_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { PaperDownloadLog_AddNewRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
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
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;

declare var varBrowseNumber;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* PaperReadWrite_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class PaperDetailPhoneEx extends Paper_QUDI_TS {
    public mstrListDiv: string = "divDataLst";
    public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /*
    //根据ID得到论文读写表数据
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
 */
    public async btnDetailRecord_Click() {
        try {
            if ($("#hidUserInfo").val() != "") {

                var strUserInfo_Hid = $("#hidUserInfo").val();
                var objvUserRoleRelation: clsvQxUserRoleRelationEN;
                objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                //$('#userName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                $("#hidUserId").val(objvUserRoleRelation.userId);
                $("#bUserName").append(objvUserRoleRelation.userName);

               
                //this.btnAddViews_Click();
                const gvResult2 = await this.DetailRecord();//绑定论文信息
                //const gvResult1 = await this.IsVoteCollection();//判断是否点赞或者收藏
               // const gvResult3 = await this.Bind_ShowAppraise_Click();//绑定评论
                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../WebApp/Login";
            }
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }

    //判断是否点赞或收藏并作出反应
    //public async IsVoteCollection() {
    //    var strWhereCond = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and paperId=" + $("#hidPaperId").val();
    //    try {


    //        const responseText = await PaperLikeLog_IsExistRecordAsync(strWhereCond);
    //        var bolIsExist: boolean = responseText;
    //        if (bolIsExist == true) {
    //            //var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
    //            //alert(strMsg);

    //            $("#imgVotet").attr("src", "../img/vote2.png");
    //            //return responseText;//一定要有一个返回值，否则会出错！
    //        }
    //        else {
    //            $("#imgVotet").attr("src", "../img/vote.png");
    //        }

    //        const responseText2 = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
    //        var bolIsExist: boolean = responseText2;
    //        if (bolIsExist == true) {
    //            $("#imgCollection").attr("src", "../img/collection2.png");
    //            //var strMsg: string = `您已经收藏过这条论文了！`;
    //            //alert(strMsg);
    //            //return responseText2;//一定要有一个返回值，否则会出错！
    //        }
    //        else {
    //            $("#imgCollection").attr("src", "../img/collection.png");
    //        }


    //    }
    //    catch (e) {
    //        console.error(e);
    //        var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}
    /* 根据关键字获取相应的记录的对象
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
   <param name = "sender">参数列表</param>
 */
    public async DetailRecord() {

        //this.KeyId = strPaperRWId;
        var strWhereCond = this.CombinevPaperReadWriteCondition();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vPaper_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                    var objvPaperEN: clsvPaperEN = <clsvPaperEN>jsonData;
                    this.GetReadWriteData(objvPaperEN);
                    console.log("完成Detail!");
                    resolve(jsonData);
                });


            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjPaperReadWriteEN">表实体类对象</param>
  */
    public GetReadWriteData(pobjvPaperEN: clsvPaperEN) {
        //if (pobjvPaperEN.attachmentCount > 0) {
        //    $("#btnDownLoadFile").show();
        //    $("#lblDownLoadFile").hide();

        //} else {
        //    $("#btnDownLoadFile").hide();
        //    $("#lblDownLoadFile").show();
        //}

        $("#txtPaperTitle").html(pobjvPaperEN.paperTitle);//论文标题
        $("#txtKeyword").html(pobjvPaperEN.keyword);//关键字Id
        $("#txtPeriodical").html(pobjvPaperEN.periodical);//
        $("#txtAuthor").html(pobjvPaperEN.author);//作者
        $("#txtResearchQuestion").html(pobjvPaperEN.researchQuestion);//研究问题
        $("#txtPaperContent").html(pobjvPaperEN.paperContent);//论文内容



        $("#lblUpdDate").text(pobjvPaperEN.updDate);//编辑时间


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
    //  /* 根据条件获取相应的记录对象的列表
    //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    //*/
    //  public async BindGv_vPaperReadWrite() {
    //      var strListDiv: string = this.mstrListDiv;
    //      var strWhereCond = this.CombinevPaperReadWriteCondition();
    //      var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
    //      var arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN> = [];
    //      try {
    //          const responseRecCount = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    //              this.RecCount = jsonData;
    //          });
    //          var objPagerPara: stuPagerPara = {
    //              pageIndex: intCurrPageIndex,
    //              pageSize: this.pageSize,
    //              whereCond: strWhereCond,
    //              orderBy: this.hidSortvPaperReadWriteBy
    //          };
    //          const responseObjLst = await vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
    //              arrvPaperReadWriteObjLst = <Array<clsvPaperReadWriteEN>>jsonData;
    //          });
    //      }
    //      catch (e) {
    //          console.error('catch(e)=');
    //          console.error(e);
    //          var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //          alert(strMsg);
    //      }
    //      if (arrvPaperReadWriteObjLst.length == 0) {
    //          var strMsg: string = `根据条件获取的对象列表数为空！`;
    //          alert(strMsg);
    //          return;
    //      }

    //  }
    /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
    public CombinevPaperReadWriteCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperId = $("#hidPaperId").val();
        //var strUserId = $("#hidUserId").val();

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
        //this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = $("#hidPaperId").val();
        var intBrowseNum: number = parseInt($("#lblViews").val());
        if (intBrowseNum == null && intBrowseNum == 0 && intBrowseNum == "") {
            objPaperEN.browseNumber = 1;
        }
        else {
            objPaperEN.browseNumber = intBrowseNum + 1;
        }


        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
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
    //public async btnAddVote_Click() {
    //    //this.DivName = "divAddNewRecordSave";
    //    var objPaperLikeLogEN: clsPaperLikeLogEN = new clsPaperLikeLogEN();

    //    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

    //    objPaperLikeLogEN.paperId = $("#hidPaperId").val();
    //    objPaperLikeLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
    //    objPaperLikeLogEN.updUser = $("#hidUserId").val();// 修改用户Id
    //    var strWhereCond = " 1 =1 and updUser='" + objPaperLikeLogEN.updUser + "' and paperId=" + objPaperLikeLogEN.paperId;
    //    try {
    //        const responseText = await PaperLikeLog_IsExistRecordAsync(strWhereCond);
    //        var bolIsExist: boolean = responseText;
    //        if (bolIsExist == true) {
    //            var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
    //            alert(strMsg);
    //            return responseText;//一定要有一个返回值，否则会出错！
    //        }

    //        const responseText2 = await PaperLikeLog_AddNewRecordAsync(objPaperLikeLogEN);
    //        var returnBool: boolean = !!responseText2;
    //        if (returnBool == true) {
    //            //var strInfo: string = `点赞成功!`;
    //            //$('#lblResult40').val(strInfo);
    //            ////显示信息框
    //            //alert(strInfo);
    //            this.DetailRecord();
    //            this.IsVoteCollection();
    //            //this.BindGv_vPaperSubViewpoint();
    //        }
    //        else {
    //            var strInfo: string = `点赞不成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //显示信息框
    //            alert(strInfo);
    //            //this.DetailRecord();
    //            //this.BindGv_vPaperSubViewpoint();
    //        }
    //        return responseText2;//一定要有一个返回值，否则会出错！
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `点赞不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //    return true;//一定要有一个返回值，否则会出错！
    //}


    //添加收藏
    //public async btnAddCollection_Click() {
    //    //this.DivName = "divAddNewRecordSave";
    //    var objPaperCollectionLogEN: clsPaperCollectionLogEN = new clsPaperCollectionLogEN();

    //    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

    //    objPaperCollectionLogEN.paperId = $("#hidPaperId").val();
    //    objPaperCollectionLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
    //    objPaperCollectionLogEN.updUser = $("#hidUserId").val();// 修改用户Id
    //    var strWhereCond = " 1 =1 and updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + objPaperCollectionLogEN.paperId;
    //    try {
    //        const responseText = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
    //        var bolIsExist: boolean = responseText;
    //        if (bolIsExist == true) {
    //            var strMsg: string = `您已经收藏过这条论文了！`;
    //            alert(strMsg);
    //            return responseText;//一定要有一个返回值，否则会出错！
    //        }

    //        const responseText2 = await PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN);
    //        var returnBool: boolean = !!responseText2;
    //        if (returnBool == true) {
    //            //var strInfo: string = `收藏成功!`;
    //            //$('#lblResult40').val(strInfo);
    //            ////显示信息框
    //            //alert(strInfo);
    //            this.IsVoteCollection();
    //            //this.BindGv_vPaperSubViewpoint();
    //        }
    //        else {
    //            var strInfo: string = `收藏不成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //显示信息框
    //            alert(strInfo);
    //            //this.BindGv_vPaperSubViewpoint();
    //        }
    //        return responseText2;//一定要有一个返回值，否则会出错！
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `收藏不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //    return true;//一定要有一个返回值，否则会出错！
    //}




    ////添加评论
    //public async SubmitAppraise_Click() {
    //    this.DivName = "divAddNewRecordSave";
    //    var objPaperAppraiseEN: clsPaperAppraiseEN = new clsPaperAppraiseEN();
    //    //this.PutDataToPaperAppraiseClass(objPaperAppraiseEN);
    //    objPaperAppraiseEN.paperId = $("#hidPaperId").val();

    //    var strvalue = $("#pin").val();
    //    //判断是否有打分 
    //    if (strvalue != "" && strvalue != undefined) {
    //        //获取值转化分数
    //        var strScore: string = this.GetScorebyText(strvalue);

    //        //判断内容是否输入
    //        if ($("#txtAppraiseContent").val() != "") {
    //            objPaperAppraiseEN.PaperAppraiseContent = $("#txtAppraiseContent").val();// 评议内容
    //            objPaperAppraiseEN.AppraiseScore = parseInt(strScore);// 打分
    //            objPaperAppraiseEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
    //            objPaperAppraiseEN.updUser = $("#hidUserId").val();// 修改用户Id
    //            try {
    //                const responseText2 = await PaperAppraise_AddNewRecordAsync(objPaperAppraiseEN);
    //                var returnBool: boolean = !!responseText2;
    //                if (returnBool == true) {
    //                    var strInfo: string = `添加评论成功!`;
    //                    $('#lblResult40').val(strInfo);
    //                    //显示信息框
    //                    alert(strInfo);
    //                    this.Bind_ShowAppraise_Click();
    //                    //HideDialog3();
    //                    //this.BindGv_vPaperSubViewpoint();
    //                    //this.btnShowAppraise_Click();
    //                }
    //                else {
    //                    var strInfo: string = `添加评论不成功!`;
    //                    $('#lblResult40').val(strInfo);
    //                    //显示信息框
    //                    alert(strInfo);
    //                    this.Bind_ShowAppraise_Click();
    //                    //HideDialog3();
    //                    //this.BindGv_vPaperSubViewpoint();
    //                    //this.btnShowAppraise_Click();
    //                }
    //                return responseText2;//一定要有一个返回值，否则会出错！
    //            }
    //            catch (e) {
    //                console.error('catch(e)=');
    //                console.error(e);
    //                var strMsg: string = `添加评论不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        }
    //        else {
    //            var strInfo: string = `请输入评语!`;
    //            //显示信息框
    //            alert(strInfo);
    //            return;
    //        }

    //    }
    //    else {

    //        var strInfo: string = `请选择评分!`;
    //        //显示信息框
    //        alert(strInfo);
    //        return;
    //    }
    //    return true;//一定要有一个返回值，否则会出错！
    //}




    //添加评论
    //public async SubmitAppraise_Click() {
    //    this.DivName = "divAddNewRecordSave";
    //    var objPaperAppraiseEN: clsPaperAppraiseEN = new clsPaperAppraiseEN();
    //    //this.PutDataToPaperAppraiseClass(objPaperAppraiseEN);
    //    objPaperAppraiseEN.paperId = $("#hidPaperId").val();

    //    var strvalue = $("#pin").val();
    //    //判断是否有打分 
    //    if (strvalue != "" && strvalue != undefined) {
    //        //获取值转化分数
    //        var strScore: string = this.GetScorebyText(strvalue);

    //        //判断内容是否输入
    //        if ($("#txtAppraiseContent").val() != "") {
    //            objPaperAppraiseEN.PaperAppraiseContent = $("#txtAppraiseContent").val();// 评议内容
    //            objPaperAppraiseEN.AppraiseScore = parseInt(strScore);// 打分
    //            //objPaperAppraiseEN.AppraiseScore = 10;// 打分
    //            objPaperAppraiseEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
    //            objPaperAppraiseEN.updUser = $("#hidUserId").val();// 修改用户Id
    //            try {
    //                const responseText2 = await PaperAppraise_AddNewRecordAsync(objPaperAppraiseEN);
    //                var returnBool: boolean = !!responseText2;
    //                if (returnBool == true) {
    //                    var strInfo: string = `添加评论成功!`;
    //                    $('#lblResult40').val(strInfo);
    //                    //显示信息框
    //                    alert(strInfo);
    //                    this.Bind_ShowAppraise_Click();
    //                    //HideDialog3();
    //                    //this.BindGv_vPaperSubViewpoint();
    //                    //this.btnShowAppraise_Click();
    //                }
    //                else {
    //                    var strInfo: string = `添加评论不成功!`;
    //                    $('#lblResult40').val(strInfo);
    //                    //显示信息框
    //                    alert(strInfo);
    //                    this.Bind_ShowAppraise_Click();
    //                    //HideDialog3();
    //                    //this.BindGv_vPaperSubViewpoint();
    //                    //this.btnShowAppraise_Click();
    //                }
    //                return responseText2;//一定要有一个返回值，否则会出错！
    //            }
    //            catch (e) {
    //                console.error('catch(e)=');
    //                console.error(e);
    //                var strMsg: string = `添加评论不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        }
    //        else {
    //            var strInfo: string = `请输入评语!`;
    //            //显示信息框
    //            alert(strInfo);
    //            return;
    //        }

    //    }
    //    else {

    //        var strInfo: string = `请选择评分!`;
    //        //显示信息框
    //        alert(strInfo);
    //        return;
    //    }
    //    return true;//一定要有一个返回值，否则会出错！
    //}

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


    //显示评论
    //public async Bind_ShowAppraise_Click() {
    //    var arrvPaperAppraiseObjLst: Array<clsvPaperAppraiseEN> = [];

    //    var strWhereCond = " paperId=" + $("#hidPaperId").val() + " order by updDate Desc";
    //    try {
    //        const responseText = vPaperAppraise_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //            arrvPaperAppraiseObjLst = <Array<clsvPaperAppraiseEN>>jsonData;

    //            var strhtml = "";
                
    //            $('#ulPinglun li').remove();
    //            for (var i = 0; i < arrvPaperAppraiseObjLst.length; i++) {
                  
    //                strhtml += '<li class="gitment-comment" ><a class="gitment-comment-avatar" ><img class="gitment-comment-avatar-img" src = "../img/avatar5.png" ></a>';
    //                strhtml += '<div class="gitment-comment-main"><div class="gitment-comment-header">';
    //                strhtml += '<a class="gitment-comment-name" >' + arrvPaperAppraiseObjLst[i].userName + '</a>';
    //                strhtml += '<span>' + arrvPaperAppraiseObjLst[i].updDate + '</span></div>';
    //                strhtml += '<div class="gitment-comment-body gitment-markdown"><p>' + arrvPaperAppraiseObjLst[i].PaperAppraiseContent + '</p></div></div></li>';



                  
    //            }
    //            $("#ulPinglun").append(strhtml);

    //            //$('#J_ShortComment div').remove();
    //            //for (var i = 0; i < arrvPaperAppraiseObjLst.length; i++) {
    //            //    //strhtml += '<tr><td>' + cateid + '</td><td>' + arrvPaperAppraiseObjLst[i].AppraiseContent + '</td><td>' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</td><td>' + arrvPaperAppraiseObjLst[i].userName + '</td><td>' + arrvPaperAppraiseObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';

    //            //    strhtml += '<div class="comment" id = "J_Comment6631028263006567418"><div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div><div class="comment-block" id="J_CommentBlock6631028263006567418"><p class="comment-user" >';
    //            //    strhtml += '<span class="comment-username J_User" data-userid="17755842">' + arrvPaperAppraiseObjLst[i].userName + '</span>';
    //            //    strhtml += '<span class="comment-time">' + arrvPaperAppraiseObjLst[i].updDate + '</span></p>';
    //            //    strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
    //            //    strhtml += '<div class="comment-content J_CommentContent">' + arrvPaperAppraiseObjLst[i].PaperAppraiseContent + '</div></div></div>';
    //            //}
    //            //$("#J_ShortComment").append(strhtml);
    //        });
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `获取数据不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //}
    //下载文件
    public btnDownLoadFile_Click() {

        this.GetPaperAttachmentRecord();
        this.btnAddDownload_Click();
    }


    public GetPaperAttachmentRecord() {
        var strPapeId = $("#hidPaperId").val();
        //this.KeyId = strPaperRWId;
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
        //this.DivName = "divAddNewRecordSave";
        var objPaperDownloadLogEN: clsPaperDownloadLogEN = new clsPaperDownloadLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperDownloadLogEN.paperId = $("#hidPaperId").val();
        objPaperDownloadLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objPaperDownloadLogEN.updUser = $("#hidUserId").val();// 修改用户Id
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
                //var strInfo: string = `收藏成功!`;
                //$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);

                //this.BindGv_vPaperSubViewpoint();
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
    public get PaperTitle_q(): string {
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
    public set OpType(value: string) {
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
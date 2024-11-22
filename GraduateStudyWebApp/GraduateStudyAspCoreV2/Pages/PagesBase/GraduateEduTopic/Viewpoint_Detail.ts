
 /**
 * 类名:Viewpoint_Detail(界面:ViewpointCRUD)
 * 表名:Viewpoint(01120542)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:40:42
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { Viewpoint_GetObjByViewpointIdAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { clsViewpointEN } from "../../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { arrSelectedKeys } from "../../TS/PubFun/clsCommFunc4Web.js";
import { CheckControlExist, SetButtonHtmlByIdInDiv, SetLabelHtmlByIdInDiv } from "../../TS/PubFun/clsCommFunc4Ctrl.js";
import { Format, IsNullOrEmpty } from "../../TS/PubFun/clsString.js";
import { IShowList } from "../../TS/PubFun/IShowList.js";
 /**
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strDialogName:string): void;
/**
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(strDialogName:string): void;
 /* Viewpoint_Detail 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
*/
export abstract class Viewpoint_Detail 
{
public opType = "";
public keyId = "";

public static id_CurrEduCls_Cache = "";//缓存分类字段1
private iShowList: IShowList;
public mstrListDiv = "divDataLst";
public bolIsLoadDetailRegion = false;  //记录是否导入编辑区的变量
public divName4Detail = "divDetail";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
}


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
 /// </summary>
 /// <returns></returns>
public async AddDPV_Detail(divName4Detail:string) {
const strThisFuncName = this.AddDPV_Detail.name;
const strUrl = "./Viewpoint_Detail/";
console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data:any) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Detail).html(data);
resolve(true);
//setTimeout(() => { clsDetailObj.BindTab(); }, 100);
//clsDetailObj.BindTab();
},
error: (e:any) => {
console.error(e);
reject(e);
}
});
});
}

 /**
  显示对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
 **/
public ShowDialog_Viewpoint(strOp:string) {
const strThisFuncName = this.ShowDialog_Viewpoint.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_Viewpoint");
CheckControlExist(this.divName4Detail, "h4", "lblDialogTitle_Viewpoint");
       if (strOp === "Add" || strOp === "AddWithMaxId" ) {
           $('#lblDialogTitle_Viewpoint').html('添加记录');
//Viewpoint_DetailEx.GetMaxStrId('#txtViewpointId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_Viewpoint').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_Viewpoint').hide();
            $('#lblDialogTitle_Viewpoint').html('详细信息');
}
        ShowDialog('#divDetailDialog_Viewpoint');
}

 /**
  隐藏对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_Viewpoint() {
const strThisFuncName = this.HideDialog_Viewpoint.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_Viewpoint");
      HideDialog('#divDetailDialog_Viewpoint');
}

 /* 
 在数据表里详细信息记录
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
*/
public async btnDetailRecordInTab_Click(strKeyId:string) {
const strThisFuncName = this.btnDetailRecordInTab_Click.name;
this.opType = "Detail";
try
{
 if (strKeyId == "")
{
alert("请选择需要详细信息的记录！");
return "";
}
this.DetailRecord(strKeyId);
}
catch(e)
{
const strMsg = Format("详细信息记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /* 
 根据关键字详细信息记录
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
  <param name = "sender">参数列表</param>
*/
public async DetailRecord(strViewpointId: string):Promise<boolean> 
{
const strThisFuncName = this.DetailRecord.name;
this.btnSubmit_d_Viewpoint = "";
this.btnCancel_d_Viewpoint = "关闭";
try
{
const objViewpointEN = await Viewpoint_GetObjByViewpointIdAsync(strViewpointId);
       if (objViewpointEN == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.ShowDetailDataFromViewpointClass(objViewpointEN);
console.log("完成DetailRecord!");
}
catch(e)
{
const strMsg = Format("显示详细信息不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
            return false;
}
            return true;
}

 /* 修改记录
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecord_Click)
*/
public async btnDetailRecord_Click(strKeyId:string) {
const strThisFuncName = this.btnDetailRecord_Click.name;
this.opType = "Detail";
if (IsNullOrEmpty(strKeyId) == true)
{
const strMsg = "需要显示详细信息记录的关键字为空，请检查！";
console.error(strMsg);
alert(strMsg);
}
if (this.bolIsLoadDetailRegion == false)  //
{
const responseBool = await this.AddDPV_Detail(this.divName4Detail);
 // 为编辑区绑定下拉框
//const conBindDdl = await this.BindDdl4DetailRegion();
this.bolIsLoadDetailRegion = true;  //
this.DetailRecord(strKeyId);
this.ShowDialog_Viewpoint('Detail');
}
else
{
this.DetailRecord(strKeyId);
this.ShowDialog_Viewpoint('Detail');
}
}

 /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
  <param name = "pobjViewpointEN">表实体类对象</param>
*/
public ShowDetailDataFromViewpointClass(pobjViewpointEN: clsViewpointEN )
{
const strThisFuncName = this.ShowDetailDataFromViewpointClass.name;
 this.viewpointId_d = pobjViewpointEN.viewpointId;// 观点Id
 this.viewpointName_d = pobjViewpointEN.viewpointName;// 观点名称
 this.viewpointContent_d = pobjViewpointEN.viewpointContent;// 观点内容
 this.reason_d = pobjViewpointEN.reason;// 理由
 this.source_d = pobjViewpointEN.source;// 来源
 this.vpProposePeople_d = pobjViewpointEN.vpProposePeople;// 观点提出人
 this.memo_d = pobjViewpointEN.memo;// 备注
 this.isSubmit_d = pobjViewpointEN.isSubmit;// 是否提交
 this.appraiseCount_d = pobjViewpointEN.appraiseCount;// 评论数
 this.score_d = pobjViewpointEN.score;// 评分
 this.okCount_d = pobjViewpointEN.okCount;// 点赞统计
 this.citationId_d = pobjViewpointEN.citationId;// 引用Id
 this.citationCount_d = pobjViewpointEN.citationCount;// 引用统计
 this.stuScore_d = pobjViewpointEN.stuScore;// 学生平均分
 this.teaScore_d = pobjViewpointEN.teaScore;// 教师评分
 this.viewpointId_d = pobjViewpointEN.viewpointId;// 观点Id
 this.id_CurrEduCls_d = pobjViewpointEN.id_CurrEduCls;// 教学班流水号
 this.viewpointName_d = pobjViewpointEN.viewpointName;// 观点名称
 this.pdfContent_d = pobjViewpointEN.pdfContent;// Pdf内容
 this.viewpointContent_d = pobjViewpointEN.viewpointContent;// 观点内容
 this.pdfPageNum_d = pobjViewpointEN.pdfPageNum;// Pdf页码
 this.viewpointTypeId_d = pobjViewpointEN.viewpointTypeId;// 观点类型Id
 this.versionCount_d = pobjViewpointEN.versionCount;// 版本统计
 this.reason_d = pobjViewpointEN.reason;// 理由
 this.createDate_d = pobjViewpointEN.createDate;// 建立日期
 this.source_d = pobjViewpointEN.source;// 来源
 this.shareId_d = pobjViewpointEN.shareId;// 分享Id
 this.vpProposePeople_d = pobjViewpointEN.vpProposePeople;// 观点提出人
 this.isRecommend_d = pobjViewpointEN.isRecommend;// 是否推荐
 this.updDate_d = pobjViewpointEN.updDate;// 修改日期
 this.memo_d = pobjViewpointEN.memo;// 备注
 this.isSubmit_d = pobjViewpointEN.isSubmit;// 是否提交
 this.userTypeId_d = pobjViewpointEN.userTypeId;// 用户类型Id
 this.citationId_d = pobjViewpointEN.citationId;// 引用Id
 this.appraiseCount_d = pobjViewpointEN.appraiseCount;// 评论数
 this.okCount_d = pobjViewpointEN.okCount;// 点赞统计
 this.score_d = pobjViewpointEN.score;// 评分
 this.stuScore_d = pobjViewpointEN.stuScore;// 学生平均分
 this.teaScore_d = pobjViewpointEN.teaScore;// 教师评分
 this.id_CurrEduCls_d = pobjViewpointEN.id_CurrEduCls;// 教学班流水号
 this.pdfContent_d = pobjViewpointEN.pdfContent;// Pdf内容
 this.pdfPageNum_d = pobjViewpointEN.pdfPageNum;// Pdf页码
 this.citationCount_d = pobjViewpointEN.citationCount;// 引用统计
 this.versionCount_d = pobjViewpointEN.versionCount;// 版本统计
 this.createDate_d = pobjViewpointEN.createDate;// 建立日期
 this.shareId_d = pobjViewpointEN.shareId;// 分享Id
 this.isRecommend_d = pobjViewpointEN.isRecommend;// 是否推荐
}
 /**
 * 评论数 (Used In ShowDetailDataFromClass())
 **/
public  set appraiseCount_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblAppraiseCount_d", value.toString());
}
 /**
 * 设置取消按钮的标题(Used In DetailRecord())
 **/
public  set btnCancel_d_Viewpoint(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnCancel_d_Viewpoint", value);
}
 /**
 * 设置确定按钮的标题(Used In DetailRecord())
 **/
public  set btnSubmit_d_Viewpoint(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnSubmit_d_Viewpoint", value);
}
 /**
 * 引用统计 (Used In ShowDetailDataFromClass())
 **/
public  set citationCount_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblCitationCount_d", value.toString());
}
 /**
 * 引用Id (Used In ShowDetailDataFromClass())
 **/
public  set citationId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblCitationId_d", value);
}
 /**
 * 建立日期 (Used In ShowDetailDataFromClass())
 **/
public  set createDate_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblCreateDate_d", value);
}
 /**
 * 教学班流水号 (Used In ShowDetailDataFromClass())
 **/
public  set id_CurrEduCls_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblid_CurrEduCls_d", value);
}
 /**
 * 是否推荐 (Used In ShowDetailDataFromClass())
 **/
public  set isRecommend_d(value: boolean) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblIsRecommend_d", value.toString());
}
 /**
 * 是否提交 (Used In ShowDetailDataFromClass())
 **/
public  set isSubmit_d(value: boolean) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblIsSubmit_d", value.toString());
}
 /**
 * 备注 (Used In ShowDetailDataFromClass())
 **/
public  set memo_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblMemo_d", value);
}
 /**
 * 点赞统计 (Used In ShowDetailDataFromClass())
 **/
public  set okCount_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblOkCount_d", value.toString());
}
 /**
 * Pdf内容 (Used In ShowDetailDataFromClass())
 **/
public  set pdfContent_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblPdfContent_d", value);
}
 /**
 * Pdf页码 (Used In ShowDetailDataFromClass())
 **/
public  set pdfPageNum_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblPdfPageNum_d", value.toString());
}
 /**
 * 理由 (Used In ShowDetailDataFromClass())
 **/
public  set reason_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblReason_d", value);
}
 /**
 * 评分 (Used In ShowDetailDataFromClass())
 **/
public  set score_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblScore_d", value.toString());
}
 /**
 * 分享Id (Used In ShowDetailDataFromClass())
 **/
public  set shareId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblShareId_d", value);
}
 /**
 * 来源 (Used In ShowDetailDataFromClass())
 **/
public  set source_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblSource_d", value);
}
 /**
 * 学生平均分 (Used In ShowDetailDataFromClass())
 **/
public  set stuScore_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblStuScore_d", value.toString());
}
 /**
 * 教师评分 (Used In ShowDetailDataFromClass())
 **/
public  set teaScore_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblTeaScore_d", value.toString());
}
 /**
 * 修改日期 (Used In ShowDetailDataFromClass())
 **/
public  set updDate_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblUpdDate_d", value);
}
 /**
 * 用户类型Id (Used In ShowDetailDataFromClass())
 **/
public  set userTypeId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblUserTypeId_d", value);
}
 /**
 * 版本统计 (Used In ShowDetailDataFromClass())
 **/
public  set versionCount_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblVersionCount_d", value.toString());
}
 /**
 * 观点内容 (Used In ShowDetailDataFromClass())
 **/
public  set viewpointContent_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblViewpointContent_d", value);
}
 /**
 * 观点Id (Used In ShowDetailDataFromClass())
 **/
public  set viewpointId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblViewpointId_d", value);
}
 /**
 * 观点名称 (Used In ShowDetailDataFromClass())
 **/
public  set viewpointName_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblViewpointName_d", value);
}
 /**
 * 观点类型Id (Used In ShowDetailDataFromClass())
 **/
public  set viewpointTypeId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblViewpointTypeId_d", value);
}
 /**
 * 观点提出人 (Used In ShowDetailDataFromClass())
 **/
public  set vpProposePeople_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblVPProposePeople_d", value);
}
}
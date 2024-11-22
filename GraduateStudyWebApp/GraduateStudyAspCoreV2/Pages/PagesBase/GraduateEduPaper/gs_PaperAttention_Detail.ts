
 /**
 * 类名:gs_PaperAttention_Detail(界面:gs_PaperAttentionCRUD)
 * 表名:gs_PaperAttention(01120748)
 * 版本:2023.02.18.1(服务器:WIN-SRV103-116)
 * 日期:2023/02/18 14:47:07
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { gs_PaperAttention_GetObjByPaperAttentionIdAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { clsgs_PaperAttentionEN } from "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
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
 /* gs_PaperAttention_Detail 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_PaperAttention_Detail 
{
public opType = "";
public keyId = "";

public static UserId_Cache = "";//缓存分类字段1
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
const strUrl = "./gs_PaperAttention_Detail/";
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
public ShowDialog_gs_PaperAttention(strOp:string) {
const strThisFuncName = this.ShowDialog_gs_PaperAttention.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_gs_PaperAttention");
CheckControlExist(this.divName4Detail, "h4", "lblDialogTitle_gs_PaperAttention");
       if (strOp === "Add" || strOp === "AddWithMaxId" ) {
           $('#lblDialogTitle_gs_PaperAttention').html('添加记录');
//gs_PaperAttention_DetailEx.GetMaxStrId('#txtPaperAttentionId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_gs_PaperAttention').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_gs_PaperAttention').hide();
            $('#lblDialogTitle_gs_PaperAttention').html('详细信息');
}
        ShowDialog('#divDetailDialog_gs_PaperAttention');
}

 /**
  隐藏对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_gs_PaperAttention() {
const strThisFuncName = this.HideDialog_gs_PaperAttention.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_gs_PaperAttention");
      HideDialog('#divDetailDialog_gs_PaperAttention');
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
const lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
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
public async DetailRecord(lngPaperAttentionId: number):Promise<boolean> 
{
const strThisFuncName = this.DetailRecord.name;
this.btnSubmit_d_gs_PaperAttention = "";
this.btnCancel_d_gs_PaperAttention = "关闭";
try
{
const objgs_PaperAttentionEN = await gs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
       if (objgs_PaperAttentionEN == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.ShowDetailDataFromgs_PaperAttentionClass(objgs_PaperAttentionEN);
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
const lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
this.ShowDialog_gs_PaperAttention('Detail');
}
else
{
const lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
this.ShowDialog_gs_PaperAttention('Detail');
}
}

 /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
  <param name = "pobjgs_PaperAttentionEN">表实体类对象</param>
*/
public ShowDetailDataFromgs_PaperAttentionClass(pobjgs_PaperAttentionEN: clsgs_PaperAttentionEN )
{
const strThisFuncName = this.ShowDetailDataFromgs_PaperAttentionClass.name;
 this.paperId_d = pobjgs_PaperAttentionEN.paperId;// 论文Id
 this.userId_d = pobjgs_PaperAttentionEN.userId;// 用户ID
 this.paperGroupId_d = pobjgs_PaperAttentionEN.paperGroupId;// 组Id
 this.meno_d = pobjgs_PaperAttentionEN.meno;// 备注
}
 /**
 * 设置取消按钮的标题(Used In DetailRecord())
 **/
public  set btnCancel_d_gs_PaperAttention(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnCancel_d_gs_PaperAttention", value);
}
 /**
 * 设置确定按钮的标题(Used In DetailRecord())
 **/
public  set btnSubmit_d_gs_PaperAttention(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnSubmit_d_gs_PaperAttention", value);
}
 /**
 * 备注 (Used In ShowDetailDataFromClass())
 **/
public  set meno_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblMeno_d", value);
}
 /**
 * 组Id (Used In ShowDetailDataFromClass())
 **/
public  set paperGroupId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblPaperGroupId_d", value);
}
 /**
 * 论文Id (Used In ShowDetailDataFromClass())
 **/
public  set paperId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblPaperId_d", value);
}
 /**
 * 用户ID (Used In ShowDetailDataFromClass())
 **/
public  set userId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblUserId_d", value);
}
}

 /**
 * 类名:JournalSubjectCategory_Detail(界面:JournalSubjectCategoryCRUD)
 * 表名:JournalSubjectCategory(01120931)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:41:14
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
import { JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js";
import { clsJournalSubjectCategoryEN } from "../../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js";
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
 /* JournalSubjectCategory_Detail 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
*/
export abstract class JournalSubjectCategory_Detail 
{
public opType = "";
public keyId = "";

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
const strUrl = "./JournalSubjectCategory_Detail/";
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
public ShowDialog_JournalSubjectCategory(strOp:string) {
const strThisFuncName = this.ShowDialog_JournalSubjectCategory.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_JournalSubjectCategory");
CheckControlExist(this.divName4Detail, "h4", "lblDialogTitle_JournalSubjectCategory");
       if (strOp === "Add" || strOp === "AddWithMaxId" ) {
           $('#lblDialogTitle_JournalSubjectCategory').html('添加记录');
//JournalSubjectCategory_DetailEx.GetMaxStrId('#txtJournalSubjectCategoryId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_JournalSubjectCategory').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_JournalSubjectCategory').hide();
            $('#lblDialogTitle_JournalSubjectCategory').html('详细信息');
}
        ShowDialog('#divDetailDialog_JournalSubjectCategory');
}

 /**
  隐藏对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_JournalSubjectCategory() {
const strThisFuncName = this.HideDialog_JournalSubjectCategory.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_JournalSubjectCategory");
      HideDialog('#divDetailDialog_JournalSubjectCategory');
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
public async DetailRecord(strJournalSubjectCategoryId: string):Promise<boolean> 
{
const strThisFuncName = this.DetailRecord.name;
this.btnSubmit_d_JournalSubjectCategory = "";
this.btnCancel_d_JournalSubjectCategory = "关闭";
try
{
const objJournalSubjectCategoryEN = await JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync(strJournalSubjectCategoryId);
       if (objJournalSubjectCategoryEN == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.ShowDetailDataFromJournalSubjectCategoryClass(objJournalSubjectCategoryEN);
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
this.ShowDialog_JournalSubjectCategory('Detail');
}
else
{
this.DetailRecord(strKeyId);
this.ShowDialog_JournalSubjectCategory('Detail');
}
}

 /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
  <param name = "pobjJournalSubjectCategoryEN">表实体类对象</param>
*/
public ShowDetailDataFromJournalSubjectCategoryClass(pobjJournalSubjectCategoryEN: clsJournalSubjectCategoryEN )
{
const strThisFuncName = this.ShowDetailDataFromJournalSubjectCategoryClass.name;
 this.journalSubjectCategoryName_d = pobjJournalSubjectCategoryEN.journalSubjectCategoryName;// 期刊学科门类名称
 this.memo_d = pobjJournalSubjectCategoryEN.memo;// 备注
}
 /**
 * 设置取消按钮的标题(Used In DetailRecord())
 **/
public  set btnCancel_d_JournalSubjectCategory(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnCancel_d_JournalSubjectCategory", value);
}
 /**
 * 设置确定按钮的标题(Used In DetailRecord())
 **/
public  set btnSubmit_d_JournalSubjectCategory(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnSubmit_d_JournalSubjectCategory", value);
}
 /**
 * 期刊学科门类名称 (Used In ShowDetailDataFromClass())
 **/
public  set journalSubjectCategoryName_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblJournalSubjectCategoryName_d", value);
}
 /**
 * 备注 (Used In ShowDetailDataFromClass())
 **/
public  set memo_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblMemo_d", value);
}
}

 /**
 * 类名:vqa_Answer_Detail(界面:qa_AnswerCRUD)
 * 表名:qa_Answer(01120641)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:40:53
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { vqa_Answer_GetObjByAnswerIdAsync } from "../../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
import { clsvqa_AnswerEN } from "../../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
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
 /* vqa_Answer_Detail 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
*/
export abstract class vqa_Answer_Detail 
{
public opType = "";
public keyId = "";

public static TopicId_Cache = "";//缓存分类字段1
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
const strUrl = "./vqa_Answer_Detail/";
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
public ShowDialog_qa_Answer(strOp:string) {
const strThisFuncName = this.ShowDialog_qa_Answer.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_qa_Answer");
CheckControlExist(this.divName4Detail, "h4", "lblDialogTitle_qa_Answer");
       if (strOp === "Add" || strOp === "AddWithMaxId" ) {
           $('#lblDialogTitle_qa_Answer').html('添加记录');
//vqa_Answer_DetailEx.GetMaxStrId('#txtAnswerId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_qa_Answer').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_qa_Answer').hide();
            $('#lblDialogTitle_qa_Answer').html('详细信息');
}
        ShowDialog('#divDetailDialog_qa_Answer');
}

 /**
  隐藏对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_qa_Answer() {
const strThisFuncName = this.HideDialog_qa_Answer.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_qa_Answer");
      HideDialog('#divDetailDialog_qa_Answer');
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
public async DetailRecord(strAnswerId: string):Promise<boolean> 
{
const strThisFuncName = this.DetailRecord.name;
this.btnSubmit_d_vqa_Answer = "";
this.btnCancel_d_vqa_Answer = "关闭";
try
{
const objvqa_AnswerEN = await vqa_Answer_GetObjByAnswerIdAsync(strAnswerId);
       if (objvqa_AnswerEN == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.ShowDetailDataFromvqa_AnswerClass(objvqa_AnswerEN);
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
}
else
{
this.DetailRecord(strKeyId);
}
}

 /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
  <param name = "pobjqa_AnswerEN">表实体类对象</param>
*/
public ShowDetailDataFromvqa_AnswerClass(pobjvqa_AnswerEN: clsvqa_AnswerEN )
{
const strThisFuncName = this.ShowDetailDataFromvqa_AnswerClass.name;
 this.answerId_d = pobjvqa_AnswerEN.answerId;// 回答Id
 this.questionsId_d = pobjvqa_AnswerEN.questionsId;// 提问Id
 this.answerContent_d = pobjvqa_AnswerEN.answerContent;// 答案内容
 this.score_d = pobjvqa_AnswerEN.score;// 评分
 this.scoreType_d = pobjvqa_AnswerEN.scoreType;// 评分类型
 this.isRight_d = pobjvqa_AnswerEN.isRight;// 是否正确
 this.parentId_d = pobjvqa_AnswerEN.parentId;// 父节点Id
 this.voteCount_d = pobjvqa_AnswerEN.voteCount;// 点赞计数
 this.updUser_d = pobjvqa_AnswerEN.updUser;// 修改人
 this.userName_d = pobjvqa_AnswerEN.userName;// 用户名
 this.memo_d = pobjvqa_AnswerEN.memo;// 备注
 this.qa_PaperId_d = pobjvqa_AnswerEN.qa_PaperId;// 论文答疑Id
 this.questionsContent_d = pobjvqa_AnswerEN.questionsContent;// 提问内容
}
 /**
 * 答案内容 (Used In ShowDetailDataFromClass())
 **/
public  set answerContent_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblAnswerContent_d", value);
}
 /**
 * 回答Id (Used In ShowDetailDataFromClass())
 **/
public  set answerId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblAnswerId_d", value);
}
 /**
 * 设置取消按钮的标题(Used In DetailRecord())
 **/
public  set btnCancel_d_vqa_Answer(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnCancel_d_vqa_Answer", value);
}
 /**
 * 设置确定按钮的标题(Used In DetailRecord())
 **/
public  set btnSubmit_d_vqa_Answer(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnSubmit_d_vqa_Answer", value);
}
 /**
 * 是否正确 (Used In ShowDetailDataFromClass())
 **/
public  set isRight_d(value: boolean) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblIsRight_d", value.toString());
}
 /**
 * 备注 (Used In ShowDetailDataFromClass())
 **/
public  set memo_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblMemo_d", value);
}
 /**
 * 父节点Id (Used In ShowDetailDataFromClass())
 **/
public  set parentId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblParentId_d", value);
}
 /**
 * 论文答疑Id (Used In ShowDetailDataFromClass())
 **/
public  set qa_PaperId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblqa_PaperId_d", value);
}
 /**
 * 提问内容 (Used In ShowDetailDataFromClass())
 **/
public  set questionsContent_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblQuestionsContent_d", value);
}
 /**
 * 提问Id (Used In ShowDetailDataFromClass())
 **/
public  set questionsId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblQuestionsId_d", value);
}
 /**
 * 评分 (Used In ShowDetailDataFromClass())
 **/
public  set score_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblScore_d", value.toString());
}
 /**
 * 评分类型 (Used In ShowDetailDataFromClass())
 **/
public  set scoreType_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblScoreType_d", value);
}
 /**
 * 修改人 (Used In ShowDetailDataFromClass())
 **/
public  set updUser_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblUpdUser_d", value);
}
 /**
 * 用户名 (Used In ShowDetailDataFromClass())
 **/
public  set userName_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblUserName_d", value);
}
 /**
 * 点赞计数 (Used In ShowDetailDataFromClass())
 **/
public  set voteCount_d(value: number) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblVoteCount_d", value.toString());
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WApiTopicObjective_UT
 表名:TopicObjective(01120613)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:45:02
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
 框架-层名:WA_界面UT后台(WA_ViewUTScriptCS)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
 ///生成查询删除记录的控制层代码

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Linq;
using Newtonsoft.Json;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using ExamLib.Const;
using ExamLib.Entity;
using ExamLib.BusinessLogicEx;
using ExamLib;
using ExamLib4WApi;
namespace ExamLib.WApiForm
{
 /// <summary>
 /// WApiTopicObjective_UT 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:GeneCode)
 /// </summary>
public partial class WApiTopicObjective_UT : System.Web.UI.Page
{

#region 页面启动函数
 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:GenPage_LoadCode)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用
{
//设置逻辑层的公共函数，包含：缓存刷新函数
if (string.IsNullOrEmpty(hidDivName.Value) == true)
{
hidDivName.Value = "divIsExistRecord";
}
}
}

#endregion 页面启动函数

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickIsExistRecord)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
protected void btnIsExistRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divIsExistRecord";
string strWhereCond = txtstrWhereCond1.Text.Trim();
try
{
bool returnBool = clsTopicObjectiveWApi.IsExistRecord(strWhereCond);
if (returnBool == false)
{
strWhereCond = txtstrWhereCond1.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 不存在!", strWhereCond);
lblResult1.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
strWhereCond = txtstrWhereCond1.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 存在!", strWhereCond);
lblResult1.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("检查相应关键字的记录是否存在不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetRecCountByCond)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
protected void btnGetRecCountByCond_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetRecCountByCond";
string strWhereCond = txtstrWhereCond2.Text.Trim();
try
{
int returnInt = clsTopicObjectiveWApi.GetRecCountByCond(strWhereCond);
strWhereCond = txtstrWhereCond2.Text.Trim();
string strInfo = string.Format("根据条件:{0}的记录数:{1}!", strWhereCond, returnInt);
lblResult2.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("获取某一条件的记录数不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 获取某一条件的字段值列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetFldValue)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
protected void btnGetFldValue_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetFldValue";
string strWhereCond = txtstrWhereCond3.Text.Trim();
string strFldName = txtstrFldName3.Text.Trim();
string strTabName = txtstrTabName3.Text.Trim();
try
{
List<string> arrFldValueLst = clsTopicObjectiveWApi.GetFldValue(strFldName, strWhereCond);
strWhereCond = txtstrWhereCond3.Text.Trim();
strFldName = txtstrFldName3.Text.Trim();
string strInfo = string.Format("根据条件:{0}的字段:[{1}]值列表:{2}!", strWhereCond, strFldName, string.Join(",", arrFldValueLst));
lblResult3.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("获取某一条件的记录数不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickAddNewRecord)
 /// </summary>
 /// <returns></returns>
protected void btnAddNewRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divAddNewRecord";
clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
objTopicObjectiveEN.TopicObjectiveId = "11111111";
objTopicObjectiveEN.ObjectiveName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.ObjectiveContent = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.ObjectiveType = "11";
objTopicObjectiveEN.SourceId = "11111111";
objTopicObjectiveEN.Conclusion = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.IsSubmit = false;
objTopicObjectiveEN.UpdDate = "11111111111111111111";
objTopicObjectiveEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.AppraiseCount = 0;
objTopicObjectiveEN.OkCount = 0;
objTopicObjectiveEN.score = 0.0f;
objTopicObjectiveEN.StuScore = 0.0f;
objTopicObjectiveEN.TeaScore = 0.0f;
objTopicObjectiveEN.id_CurrEduClass = "11111111";
objTopicObjectiveEN.PdfContent = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.PdfPageNum = 0;
objTopicObjectiveEN.CitationCount = 0;
objTopicObjectiveEN.VersionCount = 0;
objTopicObjectiveEN.CreateDate = "11111111111111111111";
objTopicObjectiveEN.ShareId = "11";
objTopicObjectiveEN.UpdUser = "11111111111111111111111111111111111111111111111111";
try
{
bool bolIsExist = clsTopicObjectiveWApi.IsExist(objTopicObjectiveEN.TopicObjectiveId);
if (bolIsExist == true)
{
string strMsg = string.Format("添加记录时，关键字：{0}已经存在！", objTopicObjectiveEN.TopicObjectiveId);
clsCommonJsFunc.Alert(this, strMsg);
return;
}
bool returnBool = clsTopicObjectiveWApi.AddNewRecord(objTopicObjectiveEN);
if (returnBool == true)
{
string strInfo = string.Format("添加记录成功!");
lblResult4.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("添加记录不成功!");
lblResult4.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("添加记录不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickAddNewRecord4GetMaxStrId)
 /// </summary>
 /// <returns></returns>
protected void btnAddNewRecord4GetMaxStrId_Click(object sender, EventArgs e) {
hidDivName.Value = "divAddNewRecord4GetMaxStrId";
string returnString = clsTopicObjectiveWApi.GetMaxStrId();
clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
objTopicObjectiveEN.TopicObjectiveId = returnString;
objTopicObjectiveEN.ObjectiveName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.ObjectiveContent = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.ObjectiveType = "11";
objTopicObjectiveEN.SourceId = "11111111";
objTopicObjectiveEN.Conclusion = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.IsSubmit = false;
objTopicObjectiveEN.UpdDate = "11111111111111111111";
objTopicObjectiveEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.AppraiseCount = 0;
objTopicObjectiveEN.OkCount = 0;
objTopicObjectiveEN.score = 0.0f;
objTopicObjectiveEN.StuScore = 0.0f;
objTopicObjectiveEN.TeaScore = 0.0f;
objTopicObjectiveEN.id_CurrEduClass = "11111111";
objTopicObjectiveEN.PdfContent = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.PdfPageNum = 0;
objTopicObjectiveEN.CitationCount = 0;
objTopicObjectiveEN.VersionCount = 0;
objTopicObjectiveEN.CreateDate = "11111111111111111111";
objTopicObjectiveEN.ShareId = "11";
objTopicObjectiveEN.UpdUser = "11111111111111111111111111111111111111111111111111";
try
{
bool returnBool = clsTopicObjectiveWApi.AddNewRecord(objTopicObjectiveEN);
if (returnBool == true)
{
string strInfo = string.Format("添加记录成功!");
lblResult5.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("添加记录不成功!");
lblResult5.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("添加记录不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetMaxStrId)
 /// </summary>
 /// <returns></returns>
protected void btnGetMaxStrId_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetMaxStrId";
try
{
string returnString = clsTopicObjectiveWApi.GetMaxStrId();
if (returnString == "")
{
string strInfo = string.Format("获取表TopicObjective的最大关键字为空，不成功，请检查!");
lblResult6.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("获取表TopicObjective的最大关键字为：{0}!", returnString);
lblResult6.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("获取表关键字的最大值不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns></returns>
protected void btnGetMaxStrIdByPrefix_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetMaxStrIdByPrefix";
string strPrefix = txtstrPrefix7.Text.Trim();
try
{
string returnString = clsTopicObjectiveWApi.GetMaxStrIdByPrefix(strPrefix);
if (returnString == "")
{
string strInfo = string.Format("获取表TopicObjective的最大关键字为空，不成功，请检查!");
lblResult7.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("获取表TopicObjective的最大关键字为：{0}!", returnString);
lblResult7.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("获取表关键字的最大值不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickUpdateRecord)
 /// </summary>
 /// <returns></returns>
protected void btnUpdateRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divUpdateRecord";
clsTopicObjectiveEN objTopicObjectiveEN = new clsTopicObjectiveEN();
objTopicObjectiveEN.TopicObjectiveId = "11111111";
objTopicObjectiveEN.ObjectiveName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.ObjectiveContent = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.ObjectiveType = "11";
objTopicObjectiveEN.SourceId = "11111111";
objTopicObjectiveEN.Conclusion = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.IsSubmit = false;
objTopicObjectiveEN.UpdDate = "11111111111111111111";
objTopicObjectiveEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.AppraiseCount = 0;
objTopicObjectiveEN.OkCount = 0;
objTopicObjectiveEN.score = 0.0f;
objTopicObjectiveEN.StuScore = 0.0f;
objTopicObjectiveEN.TeaScore = 0.0f;
objTopicObjectiveEN.id_CurrEduClass = "11111111";
objTopicObjectiveEN.PdfContent = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objTopicObjectiveEN.PdfPageNum = 0;
objTopicObjectiveEN.CitationCount = 0;
objTopicObjectiveEN.VersionCount = 0;
objTopicObjectiveEN.CreateDate = "11111111111111111111";
objTopicObjectiveEN.ShareId = "11";
objTopicObjectiveEN.UpdUser = "11111111111111111111111111111111111111111111111111";
try
{
objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.getsf_UpdFldSetStr();//设置哪些字段被修改(脏字段)
bool returnBool = clsTopicObjectiveWApi.UpdateRecord(objTopicObjectiveEN);
if (returnBool == true)
{
string strInfo = string.Format("修改记录成功!");
lblResult8.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("修改记录不成功!");
lblResult8.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("修改记录不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickDelRecord)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnDelRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divDelRecord";
string strKeyId = txtstrKeyId9.Text.Trim();
String strTopicObjectiveId = strKeyId;
try
{
int returnInt = clsTopicObjectiveWApi.DelRecord(strTopicObjectiveId);
if (returnInt > 0)
{
string strInfo = string.Format("删除记录成功, 共删除了{0}条记录!", returnInt);
lblResult9.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("删除记录不成功!");
lblResult9.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("删除记录不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickDelRecords)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnDelRecords_Click(object sender, EventArgs e) {
hidDivName.Value = "divDelRecords";
string strKeyIdLst = txtstrKeyIdLst10.Text.Trim();
try
{
int returnInt = clsTopicObjectiveWApi.DelRecords(strKeyIdLst);
if (returnInt > 0)
{
string strInfo = string.Format("删除记录成功,共删除{0}条记录!", returnInt);
lblResult10.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("删除记录不成功!");
lblResult10.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("删除记录不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的第一条记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetFirstObj)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetFirstObj_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetFirstObj";
string strWhereCond = txtstrWhereCond11.Text.Trim();
try
{
clsTopicObjectiveEN objTopicObjectiveEN = clsTopicObjectiveWApi.GetFirstObj(strWhereCond);
strWhereCond = txtstrWhereCond11.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 获取第一个记录对象：{1}!", strWhereCond, objTopicObjectiveEN.TopicObjectiveId);
lblResult11.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的第一条记录的对象不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjByKey)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
protected void btnGetObjByTopicObjectiveId_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjByTopicObjectiveId";
string strKeyId = txtvarKeyId12.Text.Trim();
String strTopicObjectiveId = strKeyId;
try
{
clsTopicObjectiveEN objTopicObjectiveEN = clsTopicObjectiveWApi.GetObjByTopicObjectiveId(strTopicObjectiveId);
string strInfo = string.Format("根据关键字:[{0}]获取对象：{1}!", strKeyId, objTopicObjectiveEN.TopicObjectiveId);
lblResult12.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字获取相应的记录的对象不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjByKey_WA_Cache)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
protected void btnGetObjByTopicObjectiveId_WA_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjByTopicObjectiveId_WA_Cache";
string strKeyId = txtvarKeyId13.Text.Trim();
String strTopicObjectiveId = strKeyId;
try
{
string strid_CurrEduClass = "01";
clsTopicObjectiveEN objTopicObjectiveEN = clsTopicObjectiveWApi.GetObjByTopicObjectiveId_WA_Cache(strTopicObjectiveId, strid_CurrEduClass);
string strInfo = string.Format("根据关键字:[{0}]获取对象(使用缓存)：{1}!", strKeyId, objTopicObjectiveEN.TopicObjectiveId);
lblResult13.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字获取相应的记录的对象不成功(使用缓存),{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLst_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLst";
string strWhereCond = txtstrWhereCond14.Text.Trim();
try
{
List<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLst(strWhereCond);
string strInfo = string.Format("根据条件:[{0}]共获取对象列表数：{1}!", strWhereCond, arrTopicObjectiveObjLst.Count);
lblResult14.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByKeyLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByKeyLst_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByKeyLst";
List<string> arrKeyId = txtarrKeyId15.Text.Trim().Split(",".ToCharArray()).ToList();
try
{
List<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLstByTopicObjectiveIdLst(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数：{1}!", string.Join(",",arrKeyId), arrTopicObjectiveObjLst.Count);
lblResult15.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字列表获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表,使用缓存
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByKeyLst_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByKeyLst_Cache";
List<string> arrKeyId = txtarrKeyId16.Text.Trim().Split(",".ToCharArray()).ToList();
try
{
string strid_CurrEduClass = "01";
IEnumerable<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLstByTopicObjectiveIdLst_Cache(arrKeyId, strid_CurrEduClass);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数(使用缓存)：{1}!", string.Join(",",arrKeyId), arrTopicObjectiveObjLst.Count());
lblResult16.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字列表获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表,使用缓存
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByKeyLst_WA_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByKeyLst_WA_Cache";
List<string> arrKeyId = txtarrKeyId17.Text.Trim().Split(",".ToCharArray()).ToList();
try
{
string strid_CurrEduClass = "01";
IEnumerable<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLstByTopicObjectiveIdLst_WA_Cache(arrKeyId, strid_CurrEduClass);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数(使用缓存)：{1}!", string.Join(",",arrKeyId), arrTopicObjectiveObjLst.Count());
lblResult17.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字列表获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的顶部对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetTopObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetTopObjLst_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetTopObjLst";
int intTopSize = int.Parse(txtintTopSize18.Text.ToString());
string strOrderBy = txtstrOrderBy18.Text.Trim();
string strWhereCond = txtstrWhereCond18.Text.Trim();
        stuTopPara objTopPara = new stuTopPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
TopSize = intTopSize,
IsCheckSQLAttack = "false",
Exclude = ""
};
try
{
List<clsTopicObjectiveEN> arrTopicObjectiveObjLst =clsTopicObjectiveWApi.GetTopObjLst(objTopPara);
string strInfo = string.Format("根据条件:[{0}],顶部数:[{1}]共获取顶部对象列表数：{2}!", strWhereCond, intTopSize, arrTopicObjectiveObjLst.Count);
lblResult18.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的顶部对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByPager)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByPager_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByPager";
int intPageIndex = int.Parse(txtintPageIndex19.Text.ToString());
int intPageSize = int.Parse(txtintPageSize19.Text.ToString());
string strOrderBy = txtstrOrderBy19.Text.Trim();
string strWhereCond = txtstrWhereCond19.Text.Trim();
        stuPagerPara objPagerPara = new stuPagerPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
PageIndex = intPageIndex,
PageSize = intPageSize
};
try
{
List<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLstByPager(objPagerPara);
string strInfo = string.Format("根据条件:[{0}],每页记录数:[{1}],第[{2}]页,共获取分页对象列表数：{3}!", strWhereCond, intPageSize, intPageIndex, arrTopicObjectiveObjLst.Count);
lblResult19.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的分页对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByPager_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByPager_Cache";
int intPageIndex = int.Parse(txtintPageIndex20.Text.ToString());
int intPageSize = int.Parse(txtintPageSize20.Text.ToString());
string strOrderBy = txtstrOrderBy20.Text.Trim();
string strWhereCond = txtstrWhereCond20.Text.Trim();
if (string.IsNullOrEmpty(strOrderBy) == true) strOrderBy = string.Format("{0} Asc", conTopicObjective.TopicObjectiveId);
clsTopicObjectiveEN objTopicObjective_Cond = new clsTopicObjectiveEN();
objTopicObjective_Cond.Setid_CurrEduClass("101", "=");
//objTopicObjective_Cond.SetTopicObjectiveId("101", "=");
//.SetUserStateId("01", "=");
objTopicObjective_Cond.sf_UpdFldSetStr = objTopicObjective_Cond.getsf_UpdFldSetStr();
string strFldComparisonOp = JsonConvert.SerializeObject(objTopicObjective_Cond.dicFldComparisonOp);
objTopicObjective_Cond.sf_FldComparisonOp = strFldComparisonOp;
strWhereCond = JsonConvert.SerializeObject(objTopicObjective_Cond);
        stuPagerPara objPagerPara = new stuPagerPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
PageIndex = intPageIndex,
PageSize = intPageSize
};
try
{
List<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLstByPager_Cache(objPagerPara);
string strInfo = string.Format("根据条件:[{0}],每页记录数:[{1}],第[{2}]页,共获取分页对象列表数：{3}!", strWhereCond, intPageSize, intPageIndex, arrTopicObjectiveObjLst.Count);
lblResult20.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的分页对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByRange)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByRange_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByRange";
string strOrderBy = txtstrOrderBy21.Text.Trim();
int intMaxNum = int.Parse(txtintMaxNum21.Text.ToString());
int intMinNum = int.Parse(txtintMinNum21.Text.ToString());
string strWhereCond = txtstrWhereCond21.Text.Trim();
        stuRangePara objRangePara = new stuRangePara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
MinNum = intMinNum,
MaxNum = intMaxNum
};
try
{
List<clsTopicObjectiveEN> arrTopicObjectiveObjLst = clsTopicObjectiveWApi.GetObjLstByRange(objRangePara);
string strInfo = string.Format("根据条件:[{0}],最小记录号:[{1}],最大记录号:[{2}],共获取分页对象列表数：{3}!", strWhereCond, intMinNum, intMaxNum, arrTopicObjectiveObjLst.Count);
lblResult21.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取范围内相应的对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}
}
}
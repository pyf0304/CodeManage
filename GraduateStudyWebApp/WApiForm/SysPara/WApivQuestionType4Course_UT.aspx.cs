
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WApivQuestionType4Course_UT
 表名:vQuestionType4Course(01120340)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 15:33:23
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// WApivQuestionType4Course_UT 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:GeneCode)
 /// </summary>
public partial class WApivQuestionType4Course_UT : System.Web.UI.Page
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
bool returnBool = clsvQuestionType4CourseWApi.IsExistRecord(strWhereCond);
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
int returnInt = clsvQuestionType4CourseWApi.GetRecCountByCond(strWhereCond);
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
List<string> arrFldValueLst = clsvQuestionType4CourseWApi.GetFldValue(strFldName, strWhereCond);
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
clsvQuestionType4CourseEN objvQuestionType4CourseEN = clsvQuestionType4CourseWApi.GetFirstObj(strWhereCond);
strWhereCond = txtstrWhereCond11.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 获取第一个记录对象：{1}!", strWhereCond, objvQuestionType4CourseEN.QuestionTypeId4Course);
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
protected void btnGetObjByQuestionTypeId4Course_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjByQuestionTypeId4Course";
string strKeyId = txtvarKeyId12.Text.Trim();
String strQuestionTypeId4Course = strKeyId;
try
{
clsvQuestionType4CourseEN objvQuestionType4CourseEN = clsvQuestionType4CourseWApi.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
string strInfo = string.Format("根据关键字:[{0}]获取对象：{1}!", strKeyId, objvQuestionType4CourseEN.QuestionTypeId4Course);
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
protected void btnGetObjByQuestionTypeId4Course_WA_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjByQuestionTypeId4Course_WA_Cache";
string strKeyId = txtvarKeyId13.Text.Trim();
String strQuestionTypeId4Course = strKeyId;
try
{
clsvQuestionType4CourseEN objvQuestionType4CourseEN = clsvQuestionType4CourseWApi.GetObjByQuestionTypeId4Course_WA_Cache(strQuestionTypeId4Course);
string strInfo = string.Format("根据关键字:[{0}]获取对象(使用缓存)：{1}!", strKeyId, objvQuestionType4CourseEN.QuestionTypeId4Course);
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
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLst(strWhereCond);
string strInfo = string.Format("根据条件:[{0}]共获取对象列表数：{1}!", strWhereCond, arrvQuestionType4CourseObjLst.Count);
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
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLstByQuestionTypeId4CourseLst(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数：{1}!", string.Join(",",arrKeyId), arrvQuestionType4CourseObjLst.Count);
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
IEnumerable<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLstByQuestionTypeId4CourseLst_Cache(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数(使用缓存)：{1}!", string.Join(",",arrKeyId), arrvQuestionType4CourseObjLst.Count());
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
IEnumerable<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLstByQuestionTypeId4CourseLst_WA_Cache(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数(使用缓存)：{1}!", string.Join(",",arrKeyId), arrvQuestionType4CourseObjLst.Count());
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
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst =clsvQuestionType4CourseWApi.GetTopObjLst(objTopPara);
string strInfo = string.Format("根据条件:[{0}],顶部数:[{1}]共获取顶部对象列表数：{2}!", strWhereCond, intTopSize, arrvQuestionType4CourseObjLst.Count);
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
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLstByPager(objPagerPara);
string strInfo = string.Format("根据条件:[{0}],每页记录数:[{1}],第[{2}]页,共获取分页对象列表数：{3}!", strWhereCond, intPageSize, intPageIndex, arrvQuestionType4CourseObjLst.Count);
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
if (string.IsNullOrEmpty(strOrderBy) == true) strOrderBy = string.Format("{0} Asc", convQuestionType4Course.QuestionTypeId4Course);
clsvQuestionType4CourseEN objvQuestionType4Course_Cond = new clsvQuestionType4CourseEN();
//objvQuestionType4Course_Cond.SetQuestionTypeId4Course("101", "=");
//.SetUserStateId("01", "=");
objvQuestionType4Course_Cond.sf_UpdFldSetStr = objvQuestionType4Course_Cond.getsf_UpdFldSetStr();
string strFldComparisonOp = JsonConvert.SerializeObject(objvQuestionType4Course_Cond.dicFldComparisonOp);
objvQuestionType4Course_Cond.sf_FldComparisonOp = strFldComparisonOp;
strWhereCond = JsonConvert.SerializeObject(objvQuestionType4Course_Cond);
        stuPagerPara objPagerPara = new stuPagerPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
PageIndex = intPageIndex,
PageSize = intPageSize
};
try
{
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLstByPager_Cache(objPagerPara);
string strInfo = string.Format("根据条件:[{0}],每页记录数:[{1}],第[{2}]页,共获取分页对象列表数：{3}!", strWhereCond, intPageSize, intPageIndex, arrvQuestionType4CourseObjLst.Count);
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
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = clsvQuestionType4CourseWApi.GetObjLstByRange(objRangePara);
string strInfo = string.Format("根据条件:[{0}],最小记录号:[{1}],最大记录号:[{2}],共获取分页对象列表数：{3}!", strWhereCond, intMinNum, intMaxNum, arrvQuestionType4CourseObjLst.Count);
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
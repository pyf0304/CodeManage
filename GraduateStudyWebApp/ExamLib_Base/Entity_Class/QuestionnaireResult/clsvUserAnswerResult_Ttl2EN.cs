
//类名:clsvUserAnswerResult_Ttl2EN
 ///----------------------
 ///生成代码版本:2016.10.01.1
 ///生成日期:2016/10/02
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:问卷结果
 ///模块英文名:QuestionnaireResult
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace ExamLib.Entity
{
 /// <summary>
 /// vUserAnswerResult_Ttl2(vUserAnswerResult_Ttl2)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvUserAnswerResult_Ttl2EN : clsEntityBase2
{
public const string _CurrTabName_S = "vUserAnswerResult_Ttl2"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "QuestionID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"QuestionID", "QuestionIndex", "QuestionName", "QuestionNo", "GridTitle", "QuestionnaireSetId", "RoleId", "AnswerID", "AnswerIndex", "AnswerName", "AnswerTypeName", "QuestionnaireSetName", "QuestionTypeName", "RoleName", "SelTimes"};
//以下是属性变量

protected string mstrQuestionID;    //题目ID
protected int mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionNo;    //题目编号
protected string mstrGridTitle;    //表格标题
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrRoleId;    //角色Id
protected long mlngAnswerID;    //问答ID
protected int mintAnswerIndex;    //问答序号
protected string mstrAnswerName;    //问答名称
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrQuestionnaireSetName;    //问卷集名
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrRoleName;    //角色名
protected int mintSelTimes;    //选择次数


 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionID  =  "QuestionID";    //题目ID

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionIndex  =  "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionName  =  "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionNo  =  "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GridTitle  =  "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionnaireSetId  =  "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId  =  "RoleId";    //角色Id

 /// <summary>
 /// 常量:"AnswerID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AnswerID  =  "AnswerID";    //问答ID

 /// <summary>
 /// 常量:"AnswerIndex"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AnswerIndex  =  "AnswerIndex";    //问答序号

 /// <summary>
 /// 常量:"AnswerName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AnswerName  =  "AnswerName";    //问答名称

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AnswerTypeName  =  "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"QuestionnaireSetName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionnaireSetName  =  "QuestionnaireSetName";    //问卷集名

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QuestionTypeName  =  "QuestionTypeName";    //题目类型名

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleName  =  "RoleName";    //角色名

 /// <summary>
 /// 常量:"SelTimes"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SelTimes  =  "SelTimes";    //选择次数

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvUserAnswerResult_Ttl2EN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vUserAnswerResult_Ttl2";
 lstKeyFldNames.Add("QuestionID");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrQuestionID">关键字:题目ID</param>
public clsvUserAnswerResult_Ttl2EN(string strQuestionID)
 {
strQuestionID  =  strQuestionID.Replace("'", "''");
if (strQuestionID.Length > 8)
{
throw new Exception("在表:vUserAnswerResult_Ttl2中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionID)  ==  true)
{
throw new Exception("在表:vUserAnswerResult_Ttl2中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strQuestionID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrQuestionID = strQuestionID;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vUserAnswerResult_Ttl2";
 lstKeyFldNames.Add("QuestionID");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  con_QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  con_QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  con_QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  con_GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  con_QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  con_AnswerID)
{
return mlngAnswerID;
}
else if (strAttributeName  ==  con_AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  con_AnswerName)
{
return mstrAnswerName;
}
else if (strAttributeName  ==  con_AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  con_QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  con_QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  con_RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  con_SelTimes)
{
return mintSelTimes;
}
return null;
}
set
{
if (strAttributeName  ==  con_QuestionID)
{
mstrQuestionID  =  value.ToString();
 AddUpdatedFld(con_QuestionID);
}
else if (strAttributeName  ==  con_QuestionIndex)
{
mintQuestionIndex  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_QuestionIndex);
}
else if (strAttributeName  ==  con_QuestionName)
{
mstrQuestionName  =  value.ToString();
 AddUpdatedFld(con_QuestionName);
}
else if (strAttributeName  ==  con_QuestionNo)
{
mstrQuestionNo  =  value.ToString();
 AddUpdatedFld(con_QuestionNo);
}
else if (strAttributeName  ==  con_GridTitle)
{
mstrGridTitle  =  value.ToString();
 AddUpdatedFld(con_GridTitle);
}
else if (strAttributeName  ==  con_QuestionnaireSetId)
{
mstrQuestionnaireSetId  =  value.ToString();
 AddUpdatedFld(con_QuestionnaireSetId);
}
else if (strAttributeName  ==  con_RoleId)
{
mstrRoleId  =  value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (strAttributeName  ==  con_AnswerID)
{
mlngAnswerID  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_AnswerID);
}
else if (strAttributeName  ==  con_AnswerIndex)
{
mintAnswerIndex  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_AnswerIndex);
}
else if (strAttributeName  ==  con_AnswerName)
{
mstrAnswerName  =  value.ToString();
 AddUpdatedFld(con_AnswerName);
}
else if (strAttributeName  ==  con_AnswerTypeName)
{
mstrAnswerTypeName  =  value.ToString();
 AddUpdatedFld(con_AnswerTypeName);
}
else if (strAttributeName  ==  con_QuestionnaireSetName)
{
mstrQuestionnaireSetName  =  value.ToString();
 AddUpdatedFld(con_QuestionnaireSetName);
}
else if (strAttributeName  ==  con_QuestionTypeName)
{
mstrQuestionTypeName  =  value.ToString();
 AddUpdatedFld(con_QuestionTypeName);
}
else if (strAttributeName  ==  con_RoleName)
{
mstrRoleName  =  value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (strAttributeName  ==  con_SelTimes)
{
mintSelTimes  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_SelTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (con_QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (con_QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (con_QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (con_QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (con_GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (con_QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (con_AnswerID  ==  AttributeName[intIndex])
{
return mlngAnswerID;
}
else if (con_AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (con_AnswerName  ==  AttributeName[intIndex])
{
return mstrAnswerName;
}
else if (con_AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (con_QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (con_QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (con_SelTimes  ==  AttributeName[intIndex])
{
return mintSelTimes;
}
return null;
}
set
{
if (con_QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID  =  value.ToString();
 AddUpdatedFld(con_QuestionID);
}
else if (con_QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_QuestionIndex);
}
else if (con_QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName  =  value.ToString();
 AddUpdatedFld(con_QuestionName);
}
else if (con_QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo  =  value.ToString();
 AddUpdatedFld(con_QuestionNo);
}
else if (con_GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle  =  value.ToString();
 AddUpdatedFld(con_GridTitle);
}
else if (con_QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId  =  value.ToString();
 AddUpdatedFld(con_QuestionnaireSetId);
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId  =  value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (con_AnswerID  ==  AttributeName[intIndex])
{
mlngAnswerID  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_AnswerID);
}
else if (con_AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_AnswerIndex);
}
else if (con_AnswerName  ==  AttributeName[intIndex])
{
mstrAnswerName  =  value.ToString();
 AddUpdatedFld(con_AnswerName);
}
else if (con_AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName  =  value.ToString();
 AddUpdatedFld(con_AnswerTypeName);
}
else if (con_QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName  =  value.ToString();
 AddUpdatedFld(con_QuestionnaireSetName);
}
else if (con_QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName  =  value.ToString();
 AddUpdatedFld(con_QuestionTypeName);
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
mstrRoleName  =  value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (con_SelTimes  ==  AttributeName[intIndex])
{
mintSelTimes  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_SelTimes);
}
}
}

/// <summary>
/// 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string QuestionID
{
get
{
return mstrQuestionID;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrQuestionID  =  value;
}
else
{
 mstrQuestionID  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_QuestionID);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex  =  value;
//记录修改过的字段
 AddUpdatedFld(con_QuestionIndex);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrQuestionName  =  value;
}
else
{
 mstrQuestionName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_QuestionName);
}
}
/// <summary>
/// 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string QuestionNo
{
get
{
return mstrQuestionNo;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrQuestionNo  =  value;
}
else
{
 mstrQuestionNo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_QuestionNo);
}
}
/// <summary>
/// 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GridTitle
{
get
{
return mstrGridTitle;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrGridTitle  =  value;
}
else
{
 mstrGridTitle  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_GridTitle);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrQuestionnaireSetId  =  value;
}
else
{
 mstrQuestionnaireSetId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_QuestionnaireSetId);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrRoleId  =  value;
}
else
{
 mstrRoleId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleId);
}
}
/// <summary>
/// 问答ID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long AnswerID
{
get
{
return mlngAnswerID;
}
set
{
 mlngAnswerID  =  value;
//记录修改过的字段
 AddUpdatedFld(con_AnswerID);
}
}
/// <summary>
/// 问答序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int AnswerIndex
{
get
{
return mintAnswerIndex;
}
set
{
 mintAnswerIndex  =  value;
//记录修改过的字段
 AddUpdatedFld(con_AnswerIndex);
}
}
/// <summary>
/// 问答名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string AnswerName
{
get
{
return mstrAnswerName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrAnswerName  =  value;
}
else
{
 mstrAnswerName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_AnswerName);
}
}
/// <summary>
/// 答案类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string AnswerTypeName
{
get
{
return mstrAnswerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrAnswerTypeName  =  value;
}
else
{
 mstrAnswerTypeName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_AnswerTypeName);
}
}
/// <summary>
/// 问卷集名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string QuestionnaireSetName
{
get
{
return mstrQuestionnaireSetName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrQuestionnaireSetName  =  value;
}
else
{
 mstrQuestionnaireSetName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_QuestionnaireSetName);
}
}
/// <summary>
/// 题目类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string QuestionTypeName
{
get
{
return mstrQuestionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrQuestionTypeName  =  value;
}
else
{
 mstrQuestionTypeName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_QuestionTypeName);
}
}
/// <summary>
/// 角色名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrRoleName  =  value;
}
else
{
 mstrRoleName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleName);
}
}
/// <summary>
/// 选择次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int SelTimes
{
get
{
return mintSelTimes;
}
set
{
 mintSelTimes  =  value;
//记录修改过的字段
 AddUpdatedFld(con_SelTimes);
}
}
}
}
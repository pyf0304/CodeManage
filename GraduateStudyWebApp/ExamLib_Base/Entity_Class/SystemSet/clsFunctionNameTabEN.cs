
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionNameTabEN
 表名:FunctionNameTab(01120204)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表FunctionNameTab的关键字(FunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionId_FunctionNameTab
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFunctionId">表关键字</param>
public K_FunctionId_FunctionNameTab(string strFunctionId)
{
if (IsValid(strFunctionId)) Value = strFunctionId;
else
{
Value = null;
}
}
private static bool IsValid(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true) return false;
if (strFunctionId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FunctionId_FunctionNameTab]类型的对象</returns>
public static implicit operator K_FunctionId_FunctionNameTab(string value)
{
return new K_FunctionId_FunctionNameTab(value);
}
}
 /// <summary>
 /// 函数名表(FunctionNameTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionNameTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionNameTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"FunctionId", "FunctionName", "FunctionNameCH", "ModuleName", "IsStudent", "IsTeacher", "IsQuestion", "ConstName", "PagePath", "PageName", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrFunctionId;    //功能Id
protected string mstrFunctionName;    //函数名
protected string mstrFunctionNameCH;    //功能中文名
protected string mstrModuleName;    //模块名
protected bool mbolIsStudent;    //是否学生
protected bool mbolIsTeacher;    //是否教师
protected bool mbolIsQuestion;    //是否题目
protected string mstrConstName;    //常量名
protected string mstrPagePath;    //页面路径
protected string mstrPageName;    //页面名称
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFunctionNameTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFunctionId">关键字:功能Id</param>
public clsFunctionNameTabEN(string strFunctionId)
 {
strFunctionId = strFunctionId.Replace("'", "''");
if (strFunctionId.Length > 4)
{
throw new Exception("在表:FunctionNameTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionId)  ==  true)
{
throw new Exception("在表:FunctionNameTab中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFunctionId = strFunctionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conFunctionNameTab.FunctionId)
{
return mstrFunctionId;
}
else if (strAttributeName  ==  conFunctionNameTab.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conFunctionNameTab.FunctionNameCH)
{
return mstrFunctionNameCH;
}
else if (strAttributeName  ==  conFunctionNameTab.ModuleName)
{
return mstrModuleName;
}
else if (strAttributeName  ==  conFunctionNameTab.IsStudent)
{
return mbolIsStudent;
}
else if (strAttributeName  ==  conFunctionNameTab.IsTeacher)
{
return mbolIsTeacher;
}
else if (strAttributeName  ==  conFunctionNameTab.IsQuestion)
{
return mbolIsQuestion;
}
else if (strAttributeName  ==  conFunctionNameTab.ConstName)
{
return mstrConstName;
}
else if (strAttributeName  ==  conFunctionNameTab.PagePath)
{
return mstrPagePath;
}
else if (strAttributeName  ==  conFunctionNameTab.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  conFunctionNameTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFunctionNameTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionNameTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionNameTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionNameTab.FunctionId)
{
mstrFunctionId = value.ToString();
 AddUpdatedFld(conFunctionNameTab.FunctionId);
}
else if (strAttributeName  ==  conFunctionNameTab.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.FunctionName);
}
else if (strAttributeName  ==  conFunctionNameTab.FunctionNameCH)
{
mstrFunctionNameCH = value.ToString();
 AddUpdatedFld(conFunctionNameTab.FunctionNameCH);
}
else if (strAttributeName  ==  conFunctionNameTab.ModuleName)
{
mstrModuleName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.ModuleName);
}
else if (strAttributeName  ==  conFunctionNameTab.IsStudent)
{
mbolIsStudent = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionNameTab.IsStudent);
}
else if (strAttributeName  ==  conFunctionNameTab.IsTeacher)
{
mbolIsTeacher = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionNameTab.IsTeacher);
}
else if (strAttributeName  ==  conFunctionNameTab.IsQuestion)
{
mbolIsQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionNameTab.IsQuestion);
}
else if (strAttributeName  ==  conFunctionNameTab.ConstName)
{
mstrConstName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.ConstName);
}
else if (strAttributeName  ==  conFunctionNameTab.PagePath)
{
mstrPagePath = value.ToString();
 AddUpdatedFld(conFunctionNameTab.PagePath);
}
else if (strAttributeName  ==  conFunctionNameTab.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.PageName);
}
else if (strAttributeName  ==  conFunctionNameTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionNameTab.OrderNum);
}
else if (strAttributeName  ==  conFunctionNameTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionNameTab.UpdDate);
}
else if (strAttributeName  ==  conFunctionNameTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionNameTab.UpdUser);
}
else if (strAttributeName  ==  conFunctionNameTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionNameTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionNameTab.FunctionId  ==  AttributeName[intIndex])
{
return mstrFunctionId;
}
else if (conFunctionNameTab.FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conFunctionNameTab.FunctionNameCH  ==  AttributeName[intIndex])
{
return mstrFunctionNameCH;
}
else if (conFunctionNameTab.ModuleName  ==  AttributeName[intIndex])
{
return mstrModuleName;
}
else if (conFunctionNameTab.IsStudent  ==  AttributeName[intIndex])
{
return mbolIsStudent;
}
else if (conFunctionNameTab.IsTeacher  ==  AttributeName[intIndex])
{
return mbolIsTeacher;
}
else if (conFunctionNameTab.IsQuestion  ==  AttributeName[intIndex])
{
return mbolIsQuestion;
}
else if (conFunctionNameTab.ConstName  ==  AttributeName[intIndex])
{
return mstrConstName;
}
else if (conFunctionNameTab.PagePath  ==  AttributeName[intIndex])
{
return mstrPagePath;
}
else if (conFunctionNameTab.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (conFunctionNameTab.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFunctionNameTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionNameTab.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionNameTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionNameTab.FunctionId  ==  AttributeName[intIndex])
{
mstrFunctionId = value.ToString();
 AddUpdatedFld(conFunctionNameTab.FunctionId);
}
else if (conFunctionNameTab.FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.FunctionName);
}
else if (conFunctionNameTab.FunctionNameCH  ==  AttributeName[intIndex])
{
mstrFunctionNameCH = value.ToString();
 AddUpdatedFld(conFunctionNameTab.FunctionNameCH);
}
else if (conFunctionNameTab.ModuleName  ==  AttributeName[intIndex])
{
mstrModuleName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.ModuleName);
}
else if (conFunctionNameTab.IsStudent  ==  AttributeName[intIndex])
{
mbolIsStudent = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionNameTab.IsStudent);
}
else if (conFunctionNameTab.IsTeacher  ==  AttributeName[intIndex])
{
mbolIsTeacher = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionNameTab.IsTeacher);
}
else if (conFunctionNameTab.IsQuestion  ==  AttributeName[intIndex])
{
mbolIsQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionNameTab.IsQuestion);
}
else if (conFunctionNameTab.ConstName  ==  AttributeName[intIndex])
{
mstrConstName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.ConstName);
}
else if (conFunctionNameTab.PagePath  ==  AttributeName[intIndex])
{
mstrPagePath = value.ToString();
 AddUpdatedFld(conFunctionNameTab.PagePath);
}
else if (conFunctionNameTab.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(conFunctionNameTab.PageName);
}
else if (conFunctionNameTab.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionNameTab.OrderNum);
}
else if (conFunctionNameTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionNameTab.UpdDate);
}
else if (conFunctionNameTab.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionNameTab.UpdUser);
}
else if (conFunctionNameTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionNameTab.Memo);
}
}
}

/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionId
{
get
{
return mstrFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionId = value;
}
else
{
 mstrFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.FunctionId);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.FunctionName);
}
}
/// <summary>
/// 功能中文名(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionNameCH
{
get
{
return mstrFunctionNameCH;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionNameCH = value;
}
else
{
 mstrFunctionNameCH = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.FunctionNameCH);
}
}
/// <summary>
/// 模块名(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModuleName
{
get
{
return mstrModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModuleName = value;
}
else
{
 mstrModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.ModuleName);
}
}
/// <summary>
/// 是否学生(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsStudent
{
get
{
return mbolIsStudent;
}
set
{
 mbolIsStudent = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.IsStudent);
}
}
/// <summary>
/// 是否教师(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTeacher
{
get
{
return mbolIsTeacher;
}
set
{
 mbolIsTeacher = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.IsTeacher);
}
}
/// <summary>
/// 是否题目(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsQuestion
{
get
{
return mbolIsQuestion;
}
set
{
 mbolIsQuestion = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.IsQuestion);
}
}
/// <summary>
/// 常量名(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConstName
{
get
{
return mstrConstName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConstName = value;
}
else
{
 mstrConstName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.ConstName);
}
}
/// <summary>
/// 页面路径(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PagePath
{
get
{
return mstrPagePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPagePath = value;
}
else
{
 mstrPagePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.PagePath);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.PageName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.OrderNum);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.UpdUser);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionNameTab.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrFunctionId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrFunctionName;
 }
 }
}
 /// <summary>
 /// 函数名表(FunctionNameTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionNameTab
{
public const string _CurrTabName = "FunctionNameTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FunctionId", "FunctionName", "FunctionNameCH", "ModuleName", "IsStudent", "IsTeacher", "IsQuestion", "ConstName", "PagePath", "PageName", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionId = "FunctionId";    //功能Id

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //函数名

 /// <summary>
 /// 常量:"FunctionNameCH"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionNameCH = "FunctionNameCH";    //功能中文名

 /// <summary>
 /// 常量:"ModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModuleName = "ModuleName";    //模块名

 /// <summary>
 /// 常量:"IsStudent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsStudent = "IsStudent";    //是否学生

 /// <summary>
 /// 常量:"IsTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTeacher = "IsTeacher";    //是否教师

 /// <summary>
 /// 常量:"IsQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsQuestion = "IsQuestion";    //是否题目

 /// <summary>
 /// 常量:"ConstName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConstName = "ConstName";    //常量名

 /// <summary>
 /// 常量:"PagePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PagePath = "PagePath";    //页面路径

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
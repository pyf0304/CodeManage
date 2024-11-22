
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseRelaInfoTypeEN
 表名:CaseRelaInfoType(01120486)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseRelaInfoType的关键字(IdCaseRelaInfoType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseRelaInfoType_CaseRelaInfoType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCaseRelaInfoType">表关键字</param>
public K_IdCaseRelaInfoType_CaseRelaInfoType(string strIdCaseRelaInfoType)
{
if (IsValid(strIdCaseRelaInfoType)) Value = strIdCaseRelaInfoType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdCaseRelaInfoType) == true) return false;
if (strIdCaseRelaInfoType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseRelaInfoType_CaseRelaInfoType]类型的对象</returns>
public static implicit operator K_IdCaseRelaInfoType_CaseRelaInfoType(string value)
{
return new K_IdCaseRelaInfoType_CaseRelaInfoType(value);
}
}
 /// <summary>
 /// 案例相关信息类型(CaseRelaInfoType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseRelaInfoTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdCaseRelaInfoType", "CaseRelaInfoTypeID", "CaseRelaInfoTypeName", "Memo"};

protected string mstrIdCaseRelaInfoType;    //案例相关信息类型流水号
protected string mstrCaseRelaInfoTypeID;    //案例相关信息类型ID
protected string mstrCaseRelaInfoTypeName;    //案例相关信息类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseRelaInfoTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseRelaInfoType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCaseRelaInfoType">关键字:案例相关信息类型流水号</param>
public clsCaseRelaInfoTypeEN(string strIdCaseRelaInfoType)
 {
strIdCaseRelaInfoType = strIdCaseRelaInfoType.Replace("'", "''");
if (strIdCaseRelaInfoType.Length > 4)
{
throw new Exception("在表:CaseRelaInfoType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCaseRelaInfoType)  ==  true)
{
throw new Exception("在表:CaseRelaInfoType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCaseRelaInfoType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCaseRelaInfoType = strIdCaseRelaInfoType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseRelaInfoType");
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
if (strAttributeName  ==  conCaseRelaInfoType.IdCaseRelaInfoType)
{
return mstrIdCaseRelaInfoType;
}
else if (strAttributeName  ==  conCaseRelaInfoType.CaseRelaInfoTypeID)
{
return mstrCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  conCaseRelaInfoType.CaseRelaInfoTypeName)
{
return mstrCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  conCaseRelaInfoType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseRelaInfoType.IdCaseRelaInfoType)
{
mstrIdCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.IdCaseRelaInfoType);
}
else if (strAttributeName  ==  conCaseRelaInfoType.CaseRelaInfoTypeID)
{
mstrCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.CaseRelaInfoTypeID);
}
else if (strAttributeName  ==  conCaseRelaInfoType.CaseRelaInfoTypeName)
{
mstrCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.CaseRelaInfoTypeName);
}
else if (strAttributeName  ==  conCaseRelaInfoType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseRelaInfoType.IdCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdCaseRelaInfoType;
}
else if (conCaseRelaInfoType.CaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrCaseRelaInfoTypeID;
}
else if (conCaseRelaInfoType.CaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrCaseRelaInfoTypeName;
}
else if (conCaseRelaInfoType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseRelaInfoType.IdCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.IdCaseRelaInfoType);
}
else if (conCaseRelaInfoType.CaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.CaseRelaInfoTypeID);
}
else if (conCaseRelaInfoType.CaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.CaseRelaInfoTypeName);
}
else if (conCaseRelaInfoType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseRelaInfoType.Memo);
}
}
}

/// <summary>
/// 案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseRelaInfoType
{
get
{
return mstrIdCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseRelaInfoType = value;
}
else
{
 mstrIdCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfoType.IdCaseRelaInfoType);
}
}
/// <summary>
/// 案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseRelaInfoTypeID
{
get
{
return mstrCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseRelaInfoTypeID = value;
}
else
{
 mstrCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfoType.CaseRelaInfoTypeID);
}
}
/// <summary>
/// 案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseRelaInfoTypeName
{
get
{
return mstrCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseRelaInfoTypeName = value;
}
else
{
 mstrCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfoType.CaseRelaInfoTypeName);
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
 AddUpdatedFld(conCaseRelaInfoType.Memo);
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
  return mstrIdCaseRelaInfoType;
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
  return mstrCaseRelaInfoTypeName;
 }
 }
}
 /// <summary>
 /// 案例相关信息类型(CaseRelaInfoType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseRelaInfoType
{
public const string _CurrTabName = "CaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseRelaInfoType", "CaseRelaInfoTypeID", "CaseRelaInfoTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseRelaInfoType = "IdCaseRelaInfoType";    //案例相关信息类型流水号

 /// <summary>
 /// 常量:"CaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseRelaInfoTypeID = "CaseRelaInfoTypeID";    //案例相关信息类型ID

 /// <summary>
 /// 常量:"CaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseRelaInfoTypeName = "CaseRelaInfoTypeName";    //案例相关信息类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
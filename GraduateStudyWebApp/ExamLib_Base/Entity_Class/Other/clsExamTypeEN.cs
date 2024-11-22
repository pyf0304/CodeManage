
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExamTypeEN
 表名:ExamType(01120532)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
 /// 表ExamType的关键字(ExamTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ExamTypeId_ExamType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strExamTypeId">表关键字</param>
public K_ExamTypeId_ExamType(string strExamTypeId)
{
if (IsValid(strExamTypeId)) Value = strExamTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strExamTypeId)
{
if (string.IsNullOrEmpty(strExamTypeId) == true) return false;
if (strExamTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ExamTypeId_ExamType]类型的对象</returns>
public static implicit operator K_ExamTypeId_ExamType(string value)
{
return new K_ExamTypeId_ExamType(value);
}
}
 /// <summary>
 /// 考试类型(ExamType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExamTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ExamType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ExamTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ExamTypeId", "ExamTypeName", "IsDeleted", "DeletedDate", "Memo"};

protected string mstrExamTypeId;    //题目类型ID
protected string mstrExamTypeName;    //题库类型名称
protected bool mbolIsDeleted;    //是否删除
protected string mstrDeletedDate;    //删除日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsExamTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExamTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strExamTypeId">关键字:题目类型ID</param>
public clsExamTypeEN(string strExamTypeId)
 {
strExamTypeId = strExamTypeId.Replace("'", "''");
if (strExamTypeId.Length > 8)
{
throw new Exception("在表:ExamType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strExamTypeId)  ==  true)
{
throw new Exception("在表:ExamType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strExamTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrExamTypeId = strExamTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExamTypeId");
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
if (strAttributeName  ==  conExamType.ExamTypeId)
{
return mstrExamTypeId;
}
else if (strAttributeName  ==  conExamType.ExamTypeName)
{
return mstrExamTypeName;
}
else if (strAttributeName  ==  conExamType.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  conExamType.DeletedDate)
{
return mstrDeletedDate;
}
else if (strAttributeName  ==  conExamType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conExamType.ExamTypeId)
{
mstrExamTypeId = value.ToString();
 AddUpdatedFld(conExamType.ExamTypeId);
}
else if (strAttributeName  ==  conExamType.ExamTypeName)
{
mstrExamTypeName = value.ToString();
 AddUpdatedFld(conExamType.ExamTypeName);
}
else if (strAttributeName  ==  conExamType.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conExamType.IsDeleted);
}
else if (strAttributeName  ==  conExamType.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conExamType.DeletedDate);
}
else if (strAttributeName  ==  conExamType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExamType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conExamType.ExamTypeId  ==  AttributeName[intIndex])
{
return mstrExamTypeId;
}
else if (conExamType.ExamTypeName  ==  AttributeName[intIndex])
{
return mstrExamTypeName;
}
else if (conExamType.IsDeleted  ==  AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (conExamType.DeletedDate  ==  AttributeName[intIndex])
{
return mstrDeletedDate;
}
else if (conExamType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conExamType.ExamTypeId  ==  AttributeName[intIndex])
{
mstrExamTypeId = value.ToString();
 AddUpdatedFld(conExamType.ExamTypeId);
}
else if (conExamType.ExamTypeName  ==  AttributeName[intIndex])
{
mstrExamTypeName = value.ToString();
 AddUpdatedFld(conExamType.ExamTypeName);
}
else if (conExamType.IsDeleted  ==  AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conExamType.IsDeleted);
}
else if (conExamType.DeletedDate  ==  AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conExamType.DeletedDate);
}
else if (conExamType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExamType.Memo);
}
}
}

/// <summary>
/// 题目类型ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamTypeId
{
get
{
return mstrExamTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamTypeId = value;
}
else
{
 mstrExamTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conExamType.ExamTypeId);
}
}
/// <summary>
/// 题库类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamTypeName
{
get
{
return mstrExamTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamTypeName = value;
}
else
{
 mstrExamTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExamType.ExamTypeName);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(conExamType.IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conExamType.DeletedDate);
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
 AddUpdatedFld(conExamType.Memo);
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
  return mstrExamTypeId;
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
  return mstrExamTypeName;
 }
 }
}
 /// <summary>
 /// 考试类型(ExamType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conExamType
{
public const string _CurrTabName = "ExamType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExamTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExamTypeId", "ExamTypeName", "IsDeleted", "DeletedDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExamTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTypeId = "ExamTypeId";    //题目类型ID

 /// <summary>
 /// 常量:"ExamTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTypeName = "ExamTypeName";    //题库类型名称

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
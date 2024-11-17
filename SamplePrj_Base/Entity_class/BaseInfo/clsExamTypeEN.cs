
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExamTypeEN
 表名:ExamType(01160053)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:45
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace SimplePrj.Entity
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
if (strExamTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "ExamType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExamTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ExamTypeId", "ExamTypeName", "_IsDeleted", "_DeletedDate", "Memo"};
//以下是属性变量

protected string mstrExamTypeId;    //考试类型Id
protected string mstrExamTypeName;    //考试类型名
protected bool mbol_IsDeleted;    //是否删除
protected string mstr_DeletedDate;    //删除日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsExamTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ExamType";
 lstKeyFldNames.Add("ExamTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strExamTypeId">关键字:考试类型Id</param>
public clsExamTypeEN(string strExamTypeId)
 {
strExamTypeId = strExamTypeId.Replace("'", "''");
if (strExamTypeId.Length > 2)
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
 _CurrTabName = "ExamType";
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
else if (strAttributeName  ==  conExamType._IsDeleted)
{
return mbol_IsDeleted;
}
else if (strAttributeName  ==  conExamType._DeletedDate)
{
return mstr_DeletedDate;
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
else if (strAttributeName  ==  conExamType._IsDeleted)
{
mbol_IsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conExamType._IsDeleted);
}
else if (strAttributeName  ==  conExamType._DeletedDate)
{
mstr_DeletedDate = value.ToString();
 AddUpdatedFld(conExamType._DeletedDate);
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
else if (conExamType._IsDeleted  ==  AttributeName[intIndex])
{
return mbol_IsDeleted;
}
else if (conExamType._DeletedDate  ==  AttributeName[intIndex])
{
return mstr_DeletedDate;
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
else if (conExamType._IsDeleted  ==  AttributeName[intIndex])
{
mbol_IsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conExamType._IsDeleted);
}
else if (conExamType._DeletedDate  ==  AttributeName[intIndex])
{
mstr_DeletedDate = value.ToString();
 AddUpdatedFld(conExamType._DeletedDate);
}
else if (conExamType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExamType.Memo);
}
}
}

/// <summary>
/// 考试类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
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
/// 考试类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
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
 public bool _IsDeleted
{
get
{
return mbol_IsDeleted;
}
set
{
 mbol_IsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(conExamType._IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string _DeletedDate
{
get
{
return mstr_DeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstr_DeletedDate = value;
}
else
{
 mstr_DeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conExamType._DeletedDate);
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
public const string _CurrTabName_S = "ExamType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExamTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExamTypeId", "ExamTypeName", "_IsDeleted", "_DeletedDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExamTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTypeId = "ExamTypeId";    //考试类型Id

 /// <summary>
 /// 常量:"ExamTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTypeName = "ExamTypeName";    //考试类型名

 /// <summary>
 /// 常量:"_IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string _IsDeleted = "_IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"_DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string _DeletedDate = "_DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
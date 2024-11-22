
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDisciplineTypeEN
 表名:DisciplineType(01120316)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成长档案(EPortfolio)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表DisciplineType的关键字(IdDisciplineType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdDisciplineType_DisciplineType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdDisciplineType">表关键字</param>
public K_IdDisciplineType_DisciplineType(string strIdDisciplineType)
{
if (IsValid(strIdDisciplineType)) Value = strIdDisciplineType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdDisciplineType)
{
if (string.IsNullOrEmpty(strIdDisciplineType) == true) return false;
if (strIdDisciplineType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdDisciplineType_DisciplineType]类型的对象</returns>
public static implicit operator K_IdDisciplineType_DisciplineType(string value)
{
return new K_IdDisciplineType_DisciplineType(value);
}
}
 /// <summary>
 /// 学科类型(DisciplineType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDisciplineTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DisciplineType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdDisciplineType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdDisciplineType", "DisciplineTypeID", "DisciplineTypeName", "Memo"};

protected string mstrIdDisciplineType;    //学科类型流水号
protected string mstrDisciplineTypeID;    //学科类型ID
protected string mstrDisciplineTypeName;    //学科类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDisciplineTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDisciplineType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdDisciplineType">关键字:学科类型流水号</param>
public clsDisciplineTypeEN(string strIdDisciplineType)
 {
strIdDisciplineType = strIdDisciplineType.Replace("'", "''");
if (strIdDisciplineType.Length > 4)
{
throw new Exception("在表:DisciplineType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdDisciplineType)  ==  true)
{
throw new Exception("在表:DisciplineType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdDisciplineType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdDisciplineType = strIdDisciplineType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDisciplineType");
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
if (strAttributeName  ==  conDisciplineType.IdDisciplineType)
{
return mstrIdDisciplineType;
}
else if (strAttributeName  ==  conDisciplineType.DisciplineTypeID)
{
return mstrDisciplineTypeID;
}
else if (strAttributeName  ==  conDisciplineType.DisciplineTypeName)
{
return mstrDisciplineTypeName;
}
else if (strAttributeName  ==  conDisciplineType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDisciplineType.IdDisciplineType)
{
mstrIdDisciplineType = value.ToString();
 AddUpdatedFld(conDisciplineType.IdDisciplineType);
}
else if (strAttributeName  ==  conDisciplineType.DisciplineTypeID)
{
mstrDisciplineTypeID = value.ToString();
 AddUpdatedFld(conDisciplineType.DisciplineTypeID);
}
else if (strAttributeName  ==  conDisciplineType.DisciplineTypeName)
{
mstrDisciplineTypeName = value.ToString();
 AddUpdatedFld(conDisciplineType.DisciplineTypeName);
}
else if (strAttributeName  ==  conDisciplineType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDisciplineType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDisciplineType.IdDisciplineType  ==  AttributeName[intIndex])
{
return mstrIdDisciplineType;
}
else if (conDisciplineType.DisciplineTypeID  ==  AttributeName[intIndex])
{
return mstrDisciplineTypeID;
}
else if (conDisciplineType.DisciplineTypeName  ==  AttributeName[intIndex])
{
return mstrDisciplineTypeName;
}
else if (conDisciplineType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDisciplineType.IdDisciplineType  ==  AttributeName[intIndex])
{
mstrIdDisciplineType = value.ToString();
 AddUpdatedFld(conDisciplineType.IdDisciplineType);
}
else if (conDisciplineType.DisciplineTypeID  ==  AttributeName[intIndex])
{
mstrDisciplineTypeID = value.ToString();
 AddUpdatedFld(conDisciplineType.DisciplineTypeID);
}
else if (conDisciplineType.DisciplineTypeName  ==  AttributeName[intIndex])
{
mstrDisciplineTypeName = value.ToString();
 AddUpdatedFld(conDisciplineType.DisciplineTypeName);
}
else if (conDisciplineType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDisciplineType.Memo);
}
}
}

/// <summary>
/// 学科类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDisciplineType
{
get
{
return mstrIdDisciplineType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDisciplineType = value;
}
else
{
 mstrIdDisciplineType = value;
}
//记录修改过的字段
 AddUpdatedFld(conDisciplineType.IdDisciplineType);
}
}
/// <summary>
/// 学科类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineTypeID
{
get
{
return mstrDisciplineTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineTypeID = value;
}
else
{
 mstrDisciplineTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conDisciplineType.DisciplineTypeID);
}
}
/// <summary>
/// 学科类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineTypeName
{
get
{
return mstrDisciplineTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineTypeName = value;
}
else
{
 mstrDisciplineTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDisciplineType.DisciplineTypeName);
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
 AddUpdatedFld(conDisciplineType.Memo);
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
  return mstrIdDisciplineType;
 }
 }
}
 /// <summary>
 /// 学科类型(DisciplineType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDisciplineType
{
public const string _CurrTabName = "DisciplineType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdDisciplineType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdDisciplineType", "DisciplineTypeID", "DisciplineTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdDisciplineType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDisciplineType = "IdDisciplineType";    //学科类型流水号

 /// <summary>
 /// 常量:"DisciplineTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineTypeID = "DisciplineTypeID";    //学科类型ID

 /// <summary>
 /// 常量:"DisciplineTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineTypeName = "DisciplineTypeName";    //学科类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
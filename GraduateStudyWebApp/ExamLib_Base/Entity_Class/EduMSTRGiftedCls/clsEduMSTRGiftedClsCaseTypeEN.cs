
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEduMSTRGiftedClsCaseTypeEN
 表名:EduMSTRGiftedClsCaseType(01120497)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// 表EduMSTRGiftedClsCaseType的关键字(IdEduMSTRGiftedClsCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduMSTRGiftedClsCaseType_EduMSTRGiftedClsCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdEduMSTRGiftedClsCaseType">表关键字</param>
public K_IdEduMSTRGiftedClsCaseType_EduMSTRGiftedClsCaseType(string strIdEduMSTRGiftedClsCaseType)
{
if (IsValid(strIdEduMSTRGiftedClsCaseType)) Value = strIdEduMSTRGiftedClsCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdEduMSTRGiftedClsCaseType)
{
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCaseType) == true) return false;
if (strIdEduMSTRGiftedClsCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduMSTRGiftedClsCaseType_EduMSTRGiftedClsCaseType]类型的对象</returns>
public static implicit operator K_IdEduMSTRGiftedClsCaseType_EduMSTRGiftedClsCaseType(string value)
{
return new K_IdEduMSTRGiftedClsCaseType_EduMSTRGiftedClsCaseType(value);
}
}
 /// <summary>
 /// 教育硕士优课案例类型(EduMSTRGiftedClsCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsEduMSTRGiftedClsCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "EduMSTRGiftedClsCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduMSTRGiftedClsCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeID", "EduMSTRGiftedClsCaseTypeName", "Memo"};

protected string mstrIdEduMSTRGiftedClsCaseType;    //教育硕士优课案例类型流水号
protected string mstrEduMSTRGiftedClsCaseTypeID;    //教育硕士优课案例类型Id
protected string mstrEduMSTRGiftedClsCaseTypeName;    //教育硕士优课案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsEduMSTRGiftedClsCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduMSTRGiftedClsCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdEduMSTRGiftedClsCaseType">关键字:教育硕士优课案例类型流水号</param>
public clsEduMSTRGiftedClsCaseTypeEN(string strIdEduMSTRGiftedClsCaseType)
 {
strIdEduMSTRGiftedClsCaseType = strIdEduMSTRGiftedClsCaseType.Replace("'", "''");
if (strIdEduMSTRGiftedClsCaseType.Length > 4)
{
throw new Exception("在表:EduMSTRGiftedClsCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCaseType)  ==  true)
{
throw new Exception("在表:EduMSTRGiftedClsCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduMSTRGiftedClsCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdEduMSTRGiftedClsCaseType = strIdEduMSTRGiftedClsCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduMSTRGiftedClsCaseType");
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
if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType)
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID)
{
return mstrEduMSTRGiftedClsCaseTypeID;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName)
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType)
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID)
{
mstrEduMSTRGiftedClsCaseTypeID = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName)
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeID;
}
else if (conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (conEduMSTRGiftedClsCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType);
}
else if (conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeID = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID);
}
else if (conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName);
}
else if (conEduMSTRGiftedClsCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.Memo);
}
}
}

/// <summary>
/// 教育硕士优课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCaseType
{
get
{
return mstrIdEduMSTRGiftedClsCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCaseType = value;
}
else
{
 mstrIdEduMSTRGiftedClsCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.IdEduMSTRGiftedClsCaseType);
}
}
/// <summary>
/// 教育硕士优课案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTypeID
{
get
{
return mstrEduMSTRGiftedClsCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTypeID = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeID);
}
}
/// <summary>
/// 教育硕士优课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTypeName
{
get
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.EduMSTRGiftedClsCaseTypeName);
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
 AddUpdatedFld(conEduMSTRGiftedClsCaseType.Memo);
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
  return mstrIdEduMSTRGiftedClsCaseType;
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
  return mstrEduMSTRGiftedClsCaseTypeName;
 }
 }
}
 /// <summary>
 /// 教育硕士优课案例类型(EduMSTRGiftedClsCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conEduMSTRGiftedClsCaseType
{
public const string _CurrTabName = "EduMSTRGiftedClsCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduMSTRGiftedClsCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeID", "EduMSTRGiftedClsCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduMSTRGiftedClsCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCaseType = "IdEduMSTRGiftedClsCaseType";    //教育硕士优课案例类型流水号

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTypeID = "EduMSTRGiftedClsCaseTypeID";    //教育硕士优课案例类型Id

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTypeName = "EduMSTRGiftedClsCaseTypeName";    //教育硕士优课案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
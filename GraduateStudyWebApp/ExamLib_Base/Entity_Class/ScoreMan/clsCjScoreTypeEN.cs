
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjScoreTypeEN
 表名:CjScoreType(01120345)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理(ScoreMan)
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
 /// 表CjScoreType的关键字(IdScoreType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdScoreType_CjScoreType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdScoreType">表关键字</param>
public K_IdScoreType_CjScoreType(string strIdScoreType)
{
if (IsValid(strIdScoreType)) Value = strIdScoreType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdScoreType)
{
if (string.IsNullOrEmpty(strIdScoreType) == true) return false;
if (strIdScoreType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdScoreType_CjScoreType]类型的对象</returns>
public static implicit operator K_IdScoreType_CjScoreType(string value)
{
return new K_IdScoreType_CjScoreType(value);
}
}
 /// <summary>
 /// 成绩类型(CjScoreType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCjScoreTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CjScoreType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdScoreType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdScoreType", "ScoreTypeId", "ScoreTypeName", "IdMainScoreType", "ModifyDate", "ModifyUserId"};

protected string mstrIdScoreType;    //成绩类型流水号
protected string mstrScoreTypeId;    //分数类型Id
protected string mstrScoreTypeName;    //分数类型名称
protected string mstrIdMainScoreType;    //成绩主类型流水号
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCjScoreTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdScoreType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdScoreType">关键字:成绩类型流水号</param>
public clsCjScoreTypeEN(string strIdScoreType)
 {
strIdScoreType = strIdScoreType.Replace("'", "''");
if (strIdScoreType.Length > 4)
{
throw new Exception("在表:CjScoreType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdScoreType)  ==  true)
{
throw new Exception("在表:CjScoreType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdScoreType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdScoreType = strIdScoreType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdScoreType");
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
if (strAttributeName  ==  conCjScoreType.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  conCjScoreType.ScoreTypeId)
{
return mstrScoreTypeId;
}
else if (strAttributeName  ==  conCjScoreType.ScoreTypeName)
{
return mstrScoreTypeName;
}
else if (strAttributeName  ==  conCjScoreType.IdMainScoreType)
{
return mstrIdMainScoreType;
}
else if (strAttributeName  ==  conCjScoreType.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conCjScoreType.ModifyUserId)
{
return mstrModifyUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conCjScoreType.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCjScoreType.IdScoreType);
}
else if (strAttributeName  ==  conCjScoreType.ScoreTypeId)
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conCjScoreType.ScoreTypeId);
}
else if (strAttributeName  ==  conCjScoreType.ScoreTypeName)
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(conCjScoreType.ScoreTypeName);
}
else if (strAttributeName  ==  conCjScoreType.IdMainScoreType)
{
mstrIdMainScoreType = value.ToString();
 AddUpdatedFld(conCjScoreType.IdMainScoreType);
}
else if (strAttributeName  ==  conCjScoreType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCjScoreType.ModifyDate);
}
else if (strAttributeName  ==  conCjScoreType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCjScoreType.ModifyUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conCjScoreType.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (conCjScoreType.ScoreTypeId  ==  AttributeName[intIndex])
{
return mstrScoreTypeId;
}
else if (conCjScoreType.ScoreTypeName  ==  AttributeName[intIndex])
{
return mstrScoreTypeName;
}
else if (conCjScoreType.IdMainScoreType  ==  AttributeName[intIndex])
{
return mstrIdMainScoreType;
}
else if (conCjScoreType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conCjScoreType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
return null;
}
set
{
if (conCjScoreType.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCjScoreType.IdScoreType);
}
else if (conCjScoreType.ScoreTypeId  ==  AttributeName[intIndex])
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conCjScoreType.ScoreTypeId);
}
else if (conCjScoreType.ScoreTypeName  ==  AttributeName[intIndex])
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(conCjScoreType.ScoreTypeName);
}
else if (conCjScoreType.IdMainScoreType  ==  AttributeName[intIndex])
{
mstrIdMainScoreType = value.ToString();
 AddUpdatedFld(conCjScoreType.IdMainScoreType);
}
else if (conCjScoreType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCjScoreType.ModifyDate);
}
else if (conCjScoreType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCjScoreType.ModifyUserId);
}
}
}

/// <summary>
/// 成绩类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdScoreType
{
get
{
return mstrIdScoreType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdScoreType = value;
}
else
{
 mstrIdScoreType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjScoreType.IdScoreType);
}
}
/// <summary>
/// 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeId
{
get
{
return mstrScoreTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeId = value;
}
else
{
 mstrScoreTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjScoreType.ScoreTypeId);
}
}
/// <summary>
/// 分数类型名称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeName
{
get
{
return mstrScoreTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeName = value;
}
else
{
 mstrScoreTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjScoreType.ScoreTypeName);
}
}
/// <summary>
/// 成绩主类型流水号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMainScoreType
{
get
{
return mstrIdMainScoreType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMainScoreType = value;
}
else
{
 mstrIdMainScoreType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjScoreType.IdMainScoreType);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjScoreType.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjScoreType.ModifyUserId);
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
  return mstrIdScoreType;
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
  return mstrScoreTypeName;
 }
 }
}
 /// <summary>
 /// 成绩类型(CjScoreType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCjScoreType
{
public const string _CurrTabName = "CjScoreType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdScoreType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdScoreType", "ScoreTypeId", "ScoreTypeName", "IdMainScoreType", "ModifyDate", "ModifyUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdScoreType = "IdScoreType";    //成绩类型流水号

 /// <summary>
 /// 常量:"ScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeId = "ScoreTypeId";    //分数类型Id

 /// <summary>
 /// 常量:"ScoreTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeName = "ScoreTypeName";    //分数类型名称

 /// <summary>
 /// 常量:"IdMainScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMainScoreType = "IdMainScoreType";    //成绩主类型流水号

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人
}

}
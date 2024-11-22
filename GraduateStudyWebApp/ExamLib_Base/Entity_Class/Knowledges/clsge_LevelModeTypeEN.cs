
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LevelModeTypeEN
 表名:ge_LevelModeType(01120907)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表ge_LevelModeType的关键字(LevelModeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LevelModeTypeId_ge_LevelModeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strLevelModeTypeId">表关键字</param>
public K_LevelModeTypeId_ge_LevelModeType(string strLevelModeTypeId)
{
if (IsValid(strLevelModeTypeId)) Value = strLevelModeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strLevelModeTypeId)
{
if (string.IsNullOrEmpty(strLevelModeTypeId) == true) return false;
if (strLevelModeTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LevelModeTypeId_ge_LevelModeType]类型的对象</returns>
public static implicit operator K_LevelModeTypeId_ge_LevelModeType(string value)
{
return new K_LevelModeTypeId_ge_LevelModeType(value);
}
}
 /// <summary>
 /// 关卡模式类型(ge_LevelModeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_LevelModeTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_LevelModeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LevelModeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"LevelModeTypeId", "LevelModeTypeName", "LevelModeTypeENName", "UpdUser", "UpdDate", "Memo"};

protected string mstrLevelModeTypeId;    //模式Id
protected string mstrLevelModeTypeName;    //模式名
protected string mstrLevelModeTypeENName;    //模式英文名
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_LevelModeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LevelModeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strLevelModeTypeId">关键字:模式Id</param>
public clsge_LevelModeTypeEN(string strLevelModeTypeId)
 {
strLevelModeTypeId = strLevelModeTypeId.Replace("'", "''");
if (strLevelModeTypeId.Length > 2)
{
throw new Exception("在表:ge_LevelModeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strLevelModeTypeId)  ==  true)
{
throw new Exception("在表:ge_LevelModeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLevelModeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrLevelModeTypeId = strLevelModeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LevelModeTypeId");
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
if (strAttributeName  ==  conge_LevelModeType.LevelModeTypeId)
{
return mstrLevelModeTypeId;
}
else if (strAttributeName  ==  conge_LevelModeType.LevelModeTypeName)
{
return mstrLevelModeTypeName;
}
else if (strAttributeName  ==  conge_LevelModeType.LevelModeTypeENName)
{
return mstrLevelModeTypeENName;
}
else if (strAttributeName  ==  conge_LevelModeType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_LevelModeType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_LevelModeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_LevelModeType.LevelModeTypeId)
{
mstrLevelModeTypeId = value.ToString();
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeId);
}
else if (strAttributeName  ==  conge_LevelModeType.LevelModeTypeName)
{
mstrLevelModeTypeName = value.ToString();
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeName);
}
else if (strAttributeName  ==  conge_LevelModeType.LevelModeTypeENName)
{
mstrLevelModeTypeENName = value.ToString();
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeENName);
}
else if (strAttributeName  ==  conge_LevelModeType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_LevelModeType.UpdUser);
}
else if (strAttributeName  ==  conge_LevelModeType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_LevelModeType.UpdDate);
}
else if (strAttributeName  ==  conge_LevelModeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_LevelModeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_LevelModeType.LevelModeTypeId  ==  AttributeName[intIndex])
{
return mstrLevelModeTypeId;
}
else if (conge_LevelModeType.LevelModeTypeName  ==  AttributeName[intIndex])
{
return mstrLevelModeTypeName;
}
else if (conge_LevelModeType.LevelModeTypeENName  ==  AttributeName[intIndex])
{
return mstrLevelModeTypeENName;
}
else if (conge_LevelModeType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_LevelModeType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_LevelModeType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_LevelModeType.LevelModeTypeId  ==  AttributeName[intIndex])
{
mstrLevelModeTypeId = value.ToString();
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeId);
}
else if (conge_LevelModeType.LevelModeTypeName  ==  AttributeName[intIndex])
{
mstrLevelModeTypeName = value.ToString();
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeName);
}
else if (conge_LevelModeType.LevelModeTypeENName  ==  AttributeName[intIndex])
{
mstrLevelModeTypeENName = value.ToString();
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeENName);
}
else if (conge_LevelModeType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_LevelModeType.UpdUser);
}
else if (conge_LevelModeType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_LevelModeType.UpdDate);
}
else if (conge_LevelModeType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_LevelModeType.Memo);
}
}
}

/// <summary>
/// 模式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelModeTypeId
{
get
{
return mstrLevelModeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelModeTypeId = value;
}
else
{
 mstrLevelModeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeId);
}
}
/// <summary>
/// 模式名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelModeTypeName
{
get
{
return mstrLevelModeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelModeTypeName = value;
}
else
{
 mstrLevelModeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeName);
}
}
/// <summary>
/// 模式英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelModeTypeENName
{
get
{
return mstrLevelModeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelModeTypeENName = value;
}
else
{
 mstrLevelModeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_LevelModeType.LevelModeTypeENName);
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
 AddUpdatedFld(conge_LevelModeType.UpdUser);
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
 AddUpdatedFld(conge_LevelModeType.UpdDate);
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
 AddUpdatedFld(conge_LevelModeType.Memo);
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
  return mstrLevelModeTypeId;
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
  return mstrLevelModeTypeName;
 }
 }
}
 /// <summary>
 /// 关卡模式类型(ge_LevelModeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_LevelModeType
{
public const string _CurrTabName = "ge_LevelModeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LevelModeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LevelModeTypeId", "LevelModeTypeName", "LevelModeTypeENName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"LevelModeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelModeTypeId = "LevelModeTypeId";    //模式Id

 /// <summary>
 /// 常量:"LevelModeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelModeTypeName = "LevelModeTypeName";    //模式名

 /// <summary>
 /// 常量:"LevelModeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelModeTypeENName = "LevelModeTypeENName";    //模式英文名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
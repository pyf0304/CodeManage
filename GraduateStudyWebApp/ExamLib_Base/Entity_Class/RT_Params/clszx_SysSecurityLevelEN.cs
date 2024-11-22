
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysSecurityLevelEN
 表名:zx_SysSecurityLevel(01120826)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_SysSecurityLevel的关键字(zxLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxLevelId_zx_SysSecurityLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxLevelId">表关键字</param>
public K_zxLevelId_zx_SysSecurityLevel(string strzxLevelId)
{
if (IsValid(strzxLevelId)) Value = strzxLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxLevelId)
{
if (string.IsNullOrEmpty(strzxLevelId) == true) return false;
if (strzxLevelId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxLevelId_zx_SysSecurityLevel]类型的对象</returns>
public static implicit operator K_zxLevelId_zx_SysSecurityLevel(string value)
{
return new K_zxLevelId_zx_SysSecurityLevel(value);
}
}
 /// <summary>
 /// 中学保密级别表(zx_SysSecurityLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysSecurityLevelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysSecurityLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxLevelId", "LevelName", "Memo"};

protected string mstrzxLevelId;    //级别Id
protected string mstrLevelName;    //级别名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysSecurityLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxLevelId">关键字:级别Id</param>
public clszx_SysSecurityLevelEN(string strzxLevelId)
 {
strzxLevelId = strzxLevelId.Replace("'", "''");
if (strzxLevelId.Length > 2)
{
throw new Exception("在表:zx_SysSecurityLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxLevelId)  ==  true)
{
throw new Exception("在表:zx_SysSecurityLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxLevelId = strzxLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxLevelId");
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
if (strAttributeName  ==  conzx_SysSecurityLevel.zxLevelId)
{
return mstrzxLevelId;
}
else if (strAttributeName  ==  conzx_SysSecurityLevel.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  conzx_SysSecurityLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysSecurityLevel.zxLevelId)
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(conzx_SysSecurityLevel.zxLevelId);
}
else if (strAttributeName  ==  conzx_SysSecurityLevel.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(conzx_SysSecurityLevel.LevelName);
}
else if (strAttributeName  ==  conzx_SysSecurityLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysSecurityLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysSecurityLevel.zxLevelId  ==  AttributeName[intIndex])
{
return mstrzxLevelId;
}
else if (conzx_SysSecurityLevel.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (conzx_SysSecurityLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_SysSecurityLevel.zxLevelId  ==  AttributeName[intIndex])
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(conzx_SysSecurityLevel.zxLevelId);
}
else if (conzx_SysSecurityLevel.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(conzx_SysSecurityLevel.LevelName);
}
else if (conzx_SysSecurityLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysSecurityLevel.Memo);
}
}
}

/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLevelId
{
get
{
return mstrzxLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLevelId = value;
}
else
{
 mstrzxLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysSecurityLevel.zxLevelId);
}
}
/// <summary>
/// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelName
{
get
{
return mstrLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelName = value;
}
else
{
 mstrLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysSecurityLevel.LevelName);
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
 AddUpdatedFld(conzx_SysSecurityLevel.Memo);
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
  return mstrzxLevelId;
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
  return mstrLevelName;
 }
 }
}
 /// <summary>
 /// 中学保密级别表(zx_SysSecurityLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysSecurityLevel
{
public const string _CurrTabName = "zx_SysSecurityLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxLevelId", "LevelName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLevelId = "zxLevelId";    //级别Id

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
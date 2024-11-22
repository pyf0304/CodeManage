
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ReadTypeEN
 表名:zx_ReadType(01120717)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_ReadType的关键字(ReadTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReadTypeId_zx_ReadType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strReadTypeId">表关键字</param>
public K_ReadTypeId_zx_ReadType(string strReadTypeId)
{
if (IsValid(strReadTypeId)) Value = strReadTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strReadTypeId)
{
if (string.IsNullOrEmpty(strReadTypeId) == true) return false;
if (strReadTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ReadTypeId_zx_ReadType]类型的对象</returns>
public static implicit operator K_ReadTypeId_zx_ReadType(string value)
{
return new K_ReadTypeId_zx_ReadType(value);
}
}
 /// <summary>
 /// 课文阅读类型表(zx_ReadType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ReadTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ReadType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReadTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ReadTypeId", "ReadTypeName", "UpdUser", "UpdDate", "Memo"};

protected string mstrReadTypeId;    //阅读类型
protected string mstrReadTypeName;    //阅读类型
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ReadTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReadTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strReadTypeId">关键字:阅读类型</param>
public clszx_ReadTypeEN(string strReadTypeId)
 {
strReadTypeId = strReadTypeId.Replace("'", "''");
if (strReadTypeId.Length > 2)
{
throw new Exception("在表:zx_ReadType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReadTypeId)  ==  true)
{
throw new Exception("在表:zx_ReadType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReadTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrReadTypeId = strReadTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReadTypeId");
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
if (strAttributeName  ==  conzx_ReadType.ReadTypeId)
{
return mstrReadTypeId;
}
else if (strAttributeName  ==  conzx_ReadType.ReadTypeName)
{
return mstrReadTypeName;
}
else if (strAttributeName  ==  conzx_ReadType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_ReadType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ReadType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ReadType.ReadTypeId)
{
mstrReadTypeId = value.ToString();
 AddUpdatedFld(conzx_ReadType.ReadTypeId);
}
else if (strAttributeName  ==  conzx_ReadType.ReadTypeName)
{
mstrReadTypeName = value.ToString();
 AddUpdatedFld(conzx_ReadType.ReadTypeName);
}
else if (strAttributeName  ==  conzx_ReadType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ReadType.UpdUser);
}
else if (strAttributeName  ==  conzx_ReadType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ReadType.UpdDate);
}
else if (strAttributeName  ==  conzx_ReadType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ReadType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ReadType.ReadTypeId  ==  AttributeName[intIndex])
{
return mstrReadTypeId;
}
else if (conzx_ReadType.ReadTypeName  ==  AttributeName[intIndex])
{
return mstrReadTypeName;
}
else if (conzx_ReadType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_ReadType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ReadType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ReadType.ReadTypeId  ==  AttributeName[intIndex])
{
mstrReadTypeId = value.ToString();
 AddUpdatedFld(conzx_ReadType.ReadTypeId);
}
else if (conzx_ReadType.ReadTypeName  ==  AttributeName[intIndex])
{
mstrReadTypeName = value.ToString();
 AddUpdatedFld(conzx_ReadType.ReadTypeName);
}
else if (conzx_ReadType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ReadType.UpdUser);
}
else if (conzx_ReadType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ReadType.UpdDate);
}
else if (conzx_ReadType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ReadType.Memo);
}
}
}

/// <summary>
/// 阅读类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReadTypeId
{
get
{
return mstrReadTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReadTypeId = value;
}
else
{
 mstrReadTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ReadType.ReadTypeId);
}
}
/// <summary>
/// 阅读类型(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReadTypeName
{
get
{
return mstrReadTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReadTypeName = value;
}
else
{
 mstrReadTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ReadType.ReadTypeName);
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
 AddUpdatedFld(conzx_ReadType.UpdUser);
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
 AddUpdatedFld(conzx_ReadType.UpdDate);
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
 AddUpdatedFld(conzx_ReadType.Memo);
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
  return mstrReadTypeId;
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
  return mstrReadTypeName;
 }
 }
}
 /// <summary>
 /// 课文阅读类型表(zx_ReadType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ReadType
{
public const string _CurrTabName = "zx_ReadType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReadTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ReadTypeId", "ReadTypeName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ReadTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReadTypeId = "ReadTypeId";    //阅读类型

 /// <summary>
 /// 常量:"ReadTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReadTypeName = "ReadTypeName";    //阅读类型

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
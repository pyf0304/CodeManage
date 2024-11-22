
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_RelaTypeEN
 表名:gs_RelaType(01120871)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:40
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
 /// 表gs_RelaType的关键字(RelaTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelaTypeId_gs_RelaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRelaTypeId">表关键字</param>
public K_RelaTypeId_gs_RelaType(string strRelaTypeId)
{
if (IsValid(strRelaTypeId)) Value = strRelaTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strRelaTypeId)
{
if (string.IsNullOrEmpty(strRelaTypeId) == true) return false;
if (strRelaTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelaTypeId_gs_RelaType]类型的对象</returns>
public static implicit operator K_RelaTypeId_gs_RelaType(string value)
{
return new K_RelaTypeId_gs_RelaType(value);
}
}
 /// <summary>
 /// 知识点关系类型表(gs_RelaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_RelaTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_RelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"RelaTypeId", "RelaTypeName", "RelaTypeENName", "UpdDate", "Memo", "UpdUser"};

protected string mstrRelaTypeId;    //关系类型Id
protected string mstrRelaTypeName;    //关系类型名
protected string mstrRelaTypeENName;    //关系类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_RelaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelaTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRelaTypeId">关键字:关系类型Id</param>
public clsgs_RelaTypeEN(string strRelaTypeId)
 {
strRelaTypeId = strRelaTypeId.Replace("'", "''");
if (strRelaTypeId.Length > 2)
{
throw new Exception("在表:gs_RelaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRelaTypeId)  ==  true)
{
throw new Exception("在表:gs_RelaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRelaTypeId = strRelaTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelaTypeId");
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
if (strAttributeName  ==  congs_RelaType.RelaTypeId)
{
return mstrRelaTypeId;
}
else if (strAttributeName  ==  congs_RelaType.RelaTypeName)
{
return mstrRelaTypeName;
}
else if (strAttributeName  ==  congs_RelaType.RelaTypeENName)
{
return mstrRelaTypeENName;
}
else if (strAttributeName  ==  congs_RelaType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_RelaType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_RelaType.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  congs_RelaType.RelaTypeId)
{
mstrRelaTypeId = value.ToString();
 AddUpdatedFld(congs_RelaType.RelaTypeId);
}
else if (strAttributeName  ==  congs_RelaType.RelaTypeName)
{
mstrRelaTypeName = value.ToString();
 AddUpdatedFld(congs_RelaType.RelaTypeName);
}
else if (strAttributeName  ==  congs_RelaType.RelaTypeENName)
{
mstrRelaTypeENName = value.ToString();
 AddUpdatedFld(congs_RelaType.RelaTypeENName);
}
else if (strAttributeName  ==  congs_RelaType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_RelaType.UpdDate);
}
else if (strAttributeName  ==  congs_RelaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_RelaType.Memo);
}
else if (strAttributeName  ==  congs_RelaType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_RelaType.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_RelaType.RelaTypeId  ==  AttributeName[intIndex])
{
return mstrRelaTypeId;
}
else if (congs_RelaType.RelaTypeName  ==  AttributeName[intIndex])
{
return mstrRelaTypeName;
}
else if (congs_RelaType.RelaTypeENName  ==  AttributeName[intIndex])
{
return mstrRelaTypeENName;
}
else if (congs_RelaType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_RelaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_RelaType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (congs_RelaType.RelaTypeId  ==  AttributeName[intIndex])
{
mstrRelaTypeId = value.ToString();
 AddUpdatedFld(congs_RelaType.RelaTypeId);
}
else if (congs_RelaType.RelaTypeName  ==  AttributeName[intIndex])
{
mstrRelaTypeName = value.ToString();
 AddUpdatedFld(congs_RelaType.RelaTypeName);
}
else if (congs_RelaType.RelaTypeENName  ==  AttributeName[intIndex])
{
mstrRelaTypeENName = value.ToString();
 AddUpdatedFld(congs_RelaType.RelaTypeENName);
}
else if (congs_RelaType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_RelaType.UpdDate);
}
else if (congs_RelaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_RelaType.Memo);
}
else if (congs_RelaType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_RelaType.UpdUser);
}
}
}

/// <summary>
/// 关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTypeId
{
get
{
return mstrRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTypeId = value;
}
else
{
 mstrRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_RelaType.RelaTypeId);
}
}
/// <summary>
/// 关系类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTypeName
{
get
{
return mstrRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTypeName = value;
}
else
{
 mstrRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_RelaType.RelaTypeName);
}
}
/// <summary>
/// 关系类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTypeENName
{
get
{
return mstrRelaTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTypeENName = value;
}
else
{
 mstrRelaTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_RelaType.RelaTypeENName);
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
 AddUpdatedFld(congs_RelaType.UpdDate);
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
 AddUpdatedFld(congs_RelaType.Memo);
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
 AddUpdatedFld(congs_RelaType.UpdUser);
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
  return mstrRelaTypeId;
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
  return mstrRelaTypeName;
 }
 }
}
 /// <summary>
 /// 知识点关系类型表(gs_RelaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_RelaType
{
public const string _CurrTabName = "gs_RelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RelaTypeId", "RelaTypeName", "RelaTypeENName", "UpdDate", "Memo", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTypeId = "RelaTypeId";    //关系类型Id

 /// <summary>
 /// 常量:"RelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTypeName = "RelaTypeName";    //关系类型名

 /// <summary>
 /// 常量:"RelaTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTypeENName = "RelaTypeENName";    //关系类型英文名

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

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}
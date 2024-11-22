﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ReflectLogEN
 表名:zx_ReflectLog(01120728)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表zx_ReflectLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_ReflectLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_zx_ReflectLog(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_zx_ReflectLog]类型的对象</returns>
public static implicit operator K_mId_zx_ReflectLog(long value)
{
return new K_mId_zx_ReflectLog(value);
}
}
 /// <summary>
 /// 中学课文反思(zx_ReflectLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ReflectLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ReflectLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "ReflectLogName", "ReflectLogContent", "UpdUser", "UpdDate", "Memo", "GroupTextId"};

protected long mlngmId;    //mId
protected string mstrReflectLogName;    //标题
protected string mstrReflectLogContent;    //内容
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ReflectLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clszx_ReflectLogEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conzx_ReflectLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_ReflectLog.ReflectLogName)
{
return mstrReflectLogName;
}
else if (strAttributeName  ==  conzx_ReflectLog.ReflectLogContent)
{
return mstrReflectLogContent;
}
else if (strAttributeName  ==  conzx_ReflectLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_ReflectLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ReflectLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_ReflectLog.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ReflectLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ReflectLog.mId);
}
else if (strAttributeName  ==  conzx_ReflectLog.ReflectLogName)
{
mstrReflectLogName = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.ReflectLogName);
}
else if (strAttributeName  ==  conzx_ReflectLog.ReflectLogContent)
{
mstrReflectLogContent = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.ReflectLogContent);
}
else if (strAttributeName  ==  conzx_ReflectLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.UpdUser);
}
else if (strAttributeName  ==  conzx_ReflectLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.UpdDate);
}
else if (strAttributeName  ==  conzx_ReflectLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.Memo);
}
else if (strAttributeName  ==  conzx_ReflectLog.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ReflectLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_ReflectLog.ReflectLogName  ==  AttributeName[intIndex])
{
return mstrReflectLogName;
}
else if (conzx_ReflectLog.ReflectLogContent  ==  AttributeName[intIndex])
{
return mstrReflectLogContent;
}
else if (conzx_ReflectLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_ReflectLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ReflectLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_ReflectLog.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_ReflectLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ReflectLog.mId);
}
else if (conzx_ReflectLog.ReflectLogName  ==  AttributeName[intIndex])
{
mstrReflectLogName = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.ReflectLogName);
}
else if (conzx_ReflectLog.ReflectLogContent  ==  AttributeName[intIndex])
{
mstrReflectLogContent = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.ReflectLogContent);
}
else if (conzx_ReflectLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.UpdUser);
}
else if (conzx_ReflectLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.UpdDate);
}
else if (conzx_ReflectLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.Memo);
}
else if (conzx_ReflectLog.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_ReflectLog.GroupTextId);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_ReflectLog.mId);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReflectLogName
{
get
{
return mstrReflectLogName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReflectLogName = value;
}
else
{
 mstrReflectLogName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ReflectLog.ReflectLogName);
}
}
/// <summary>
/// 内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReflectLogContent
{
get
{
return mstrReflectLogContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReflectLogContent = value;
}
else
{
 mstrReflectLogContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ReflectLog.ReflectLogContent);
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
 AddUpdatedFld(conzx_ReflectLog.UpdUser);
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
 AddUpdatedFld(conzx_ReflectLog.UpdDate);
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
 AddUpdatedFld(conzx_ReflectLog.Memo);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ReflectLog.GroupTextId);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 中学课文反思(zx_ReflectLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ReflectLog
{
public const string _CurrTabName = "zx_ReflectLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ReflectLogName", "ReflectLogContent", "UpdUser", "UpdDate", "Memo", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ReflectLogName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReflectLogName = "ReflectLogName";    //标题

 /// <summary>
 /// 常量:"ReflectLogContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReflectLogContent = "ReflectLogContent";    //内容

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

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id
}

}
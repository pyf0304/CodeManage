
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_OriginalPaperLogEN
 表名:zx_OriginalPaperLog(01120782)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表zx_OriginalPaperLog的关键字(PaperLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperLogId_zx_OriginalPaperLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperLogId">表关键字</param>
public K_PaperLogId_zx_OriginalPaperLog(long lngPaperLogId)
{
if (IsValid(lngPaperLogId)) Value = lngPaperLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperLogId)
{
if (lngPaperLogId == 0) return false;
if (lngPaperLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperLogId_zx_OriginalPaperLog]类型的对象</returns>
public static implicit operator K_PaperLogId_zx_OriginalPaperLog(long value)
{
return new K_PaperLogId_zx_OriginalPaperLog(value);
}
}
 /// <summary>
 /// 作文日志表(zx_OriginalPaperLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_OriginalPaperLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_OriginalPaperLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PaperLogId", "TextId", "zxLogTypeId", "LogDescription", "UpdUser", "UpdDate", "Memo"};

protected long mlngPaperLogId;    //论文日志Id
protected string mstrTextId;    //课件Id
protected string mstrzxLogTypeId;    //日志类型Id
protected string mstrLogDescription;    //日志描述
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_OriginalPaperLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperLogId">关键字:论文日志Id</param>
public clszx_OriginalPaperLogEN(long lngPaperLogId)
 {
 if (lngPaperLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperLogId = lngPaperLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperLogId");
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
if (strAttributeName  ==  conzx_OriginalPaperLog.PaperLogId)
{
return mlngPaperLogId;
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.zxLogTypeId)
{
return mstrzxLogTypeId;
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.LogDescription)
{
return mstrLogDescription;
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_OriginalPaperLog.PaperLogId)
{
mlngPaperLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_OriginalPaperLog.PaperLogId);
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.TextId);
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.zxLogTypeId)
{
mstrzxLogTypeId = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.zxLogTypeId);
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.LogDescription)
{
mstrLogDescription = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.LogDescription);
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.UpdUser);
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.UpdDate);
}
else if (strAttributeName  ==  conzx_OriginalPaperLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_OriginalPaperLog.PaperLogId  ==  AttributeName[intIndex])
{
return mlngPaperLogId;
}
else if (conzx_OriginalPaperLog.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_OriginalPaperLog.zxLogTypeId  ==  AttributeName[intIndex])
{
return mstrzxLogTypeId;
}
else if (conzx_OriginalPaperLog.LogDescription  ==  AttributeName[intIndex])
{
return mstrLogDescription;
}
else if (conzx_OriginalPaperLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_OriginalPaperLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_OriginalPaperLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_OriginalPaperLog.PaperLogId  ==  AttributeName[intIndex])
{
mlngPaperLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_OriginalPaperLog.PaperLogId);
}
else if (conzx_OriginalPaperLog.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.TextId);
}
else if (conzx_OriginalPaperLog.zxLogTypeId  ==  AttributeName[intIndex])
{
mstrzxLogTypeId = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.zxLogTypeId);
}
else if (conzx_OriginalPaperLog.LogDescription  ==  AttributeName[intIndex])
{
mstrLogDescription = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.LogDescription);
}
else if (conzx_OriginalPaperLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.UpdUser);
}
else if (conzx_OriginalPaperLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.UpdDate);
}
else if (conzx_OriginalPaperLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLog.Memo);
}
}
}

/// <summary>
/// 论文日志Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperLogId
{
get
{
return mlngPaperLogId;
}
set
{
 mlngPaperLogId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_OriginalPaperLog.PaperLogId);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_OriginalPaperLog.TextId);
}
}
/// <summary>
/// 日志类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLogTypeId
{
get
{
return mstrzxLogTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLogTypeId = value;
}
else
{
 mstrzxLogTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_OriginalPaperLog.zxLogTypeId);
}
}
/// <summary>
/// 日志描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogDescription
{
get
{
return mstrLogDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogDescription = value;
}
else
{
 mstrLogDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_OriginalPaperLog.LogDescription);
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
 AddUpdatedFld(conzx_OriginalPaperLog.UpdUser);
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
 AddUpdatedFld(conzx_OriginalPaperLog.UpdDate);
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
 AddUpdatedFld(conzx_OriginalPaperLog.Memo);
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
  return mlngPaperLogId.ToString();
 }
 }
}
 /// <summary>
 /// 作文日志表(zx_OriginalPaperLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_OriginalPaperLog
{
public const string _CurrTabName = "zx_OriginalPaperLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperLogId", "TextId", "zxLogTypeId", "LogDescription", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperLogId = "PaperLogId";    //论文日志Id

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"zxLogTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLogTypeId = "zxLogTypeId";    //日志类型Id

 /// <summary>
 /// 常量:"LogDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogDescription = "LogDescription";    //日志描述

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
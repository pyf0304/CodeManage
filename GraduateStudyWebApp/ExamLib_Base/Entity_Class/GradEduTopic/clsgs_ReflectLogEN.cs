
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ReflectLogEN
 表名:gs_ReflectLog(01120702)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表gs_ReflectLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_ReflectLog
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
public K_mId_gs_ReflectLog(long lngmId)
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
 /// <returns>返回:[K_mId_gs_ReflectLog]类型的对象</returns>
public static implicit operator K_mId_gs_ReflectLog(long value)
{
return new K_mId_gs_ReflectLog(value);
}
}
 /// <summary>
 /// 反思日志(gs_ReflectLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ReflectLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_ReflectLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "UserId", "IdCurrEduCls", "TopicId", "ReflectLogName", "ReflectLogContent", "UpdUser", "CreateDate", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrTopicId;    //主题Id
protected string mstrReflectLogName;    //标题
protected string mstrReflectLogContent;    //内容
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ReflectLogEN()
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
public clsgs_ReflectLogEN(long lngmId)
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
if (strAttributeName  ==  congs_ReflectLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_ReflectLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  congs_ReflectLog.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_ReflectLog.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_ReflectLog.ReflectLogName)
{
return mstrReflectLogName;
}
else if (strAttributeName  ==  congs_ReflectLog.ReflectLogContent)
{
return mstrReflectLogContent;
}
else if (strAttributeName  ==  congs_ReflectLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_ReflectLog.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  congs_ReflectLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_ReflectLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_ReflectLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_ReflectLog.mId);
}
else if (strAttributeName  ==  congs_ReflectLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_ReflectLog.UserId);
}
else if (strAttributeName  ==  congs_ReflectLog.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_ReflectLog.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_ReflectLog.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ReflectLog.TopicId);
}
else if (strAttributeName  ==  congs_ReflectLog.ReflectLogName)
{
mstrReflectLogName = value.ToString();
 AddUpdatedFld(congs_ReflectLog.ReflectLogName);
}
else if (strAttributeName  ==  congs_ReflectLog.ReflectLogContent)
{
mstrReflectLogContent = value.ToString();
 AddUpdatedFld(congs_ReflectLog.ReflectLogContent);
}
else if (strAttributeName  ==  congs_ReflectLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ReflectLog.UpdUser);
}
else if (strAttributeName  ==  congs_ReflectLog.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(congs_ReflectLog.CreateDate);
}
else if (strAttributeName  ==  congs_ReflectLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ReflectLog.UpdDate);
}
else if (strAttributeName  ==  congs_ReflectLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ReflectLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_ReflectLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_ReflectLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (congs_ReflectLog.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_ReflectLog.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_ReflectLog.ReflectLogName  ==  AttributeName[intIndex])
{
return mstrReflectLogName;
}
else if (congs_ReflectLog.ReflectLogContent  ==  AttributeName[intIndex])
{
return mstrReflectLogContent;
}
else if (congs_ReflectLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_ReflectLog.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (congs_ReflectLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_ReflectLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_ReflectLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_ReflectLog.mId);
}
else if (congs_ReflectLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_ReflectLog.UserId);
}
else if (congs_ReflectLog.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_ReflectLog.IdCurrEduCls);
}
else if (congs_ReflectLog.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ReflectLog.TopicId);
}
else if (congs_ReflectLog.ReflectLogName  ==  AttributeName[intIndex])
{
mstrReflectLogName = value.ToString();
 AddUpdatedFld(congs_ReflectLog.ReflectLogName);
}
else if (congs_ReflectLog.ReflectLogContent  ==  AttributeName[intIndex])
{
mstrReflectLogContent = value.ToString();
 AddUpdatedFld(congs_ReflectLog.ReflectLogContent);
}
else if (congs_ReflectLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ReflectLog.UpdUser);
}
else if (congs_ReflectLog.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(congs_ReflectLog.CreateDate);
}
else if (congs_ReflectLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ReflectLog.UpdDate);
}
else if (congs_ReflectLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ReflectLog.Memo);
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
 AddUpdatedFld(congs_ReflectLog.mId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ReflectLog.UserId);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ReflectLog.IdCurrEduCls);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ReflectLog.TopicId);
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
 AddUpdatedFld(congs_ReflectLog.ReflectLogName);
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
 AddUpdatedFld(congs_ReflectLog.ReflectLogContent);
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
 AddUpdatedFld(congs_ReflectLog.UpdUser);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ReflectLog.CreateDate);
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
 AddUpdatedFld(congs_ReflectLog.UpdDate);
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
 AddUpdatedFld(congs_ReflectLog.Memo);
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
 /// 反思日志(gs_ReflectLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_ReflectLog
{
public const string _CurrTabName = "gs_ReflectLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "IdCurrEduCls", "TopicId", "ReflectLogName", "ReflectLogContent", "UpdUser", "CreateDate", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

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
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

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
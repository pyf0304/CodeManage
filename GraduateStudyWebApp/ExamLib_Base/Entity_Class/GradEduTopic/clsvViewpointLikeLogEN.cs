
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointLikeLogEN
 表名:vViewpointLikeLog(01120608)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vViewpointLikeLog的关键字(ViewpointLikeLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointLikeLogId_vViewpointLikeLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointLikeLogId">表关键字</param>
public K_ViewpointLikeLogId_vViewpointLikeLog(long lngViewpointLikeLogId)
{
if (IsValid(lngViewpointLikeLogId)) Value = lngViewpointLikeLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointLikeLogId)
{
if (lngViewpointLikeLogId == 0) return false;
if (lngViewpointLikeLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointLikeLogId_vViewpointLikeLog]类型的对象</returns>
public static implicit operator K_ViewpointLikeLogId_vViewpointLikeLog(long value)
{
return new K_ViewpointLikeLogId_vViewpointLikeLog(value);
}
}
 /// <summary>
 /// vViewpointLikeLog(vViewpointLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewpointLikeLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"Memo", "UpdUserId", "UpdDate", "ViewpointId", "ViewpointLikeLogId", "ViewpointName", "ViewpointContent", "Reason", "UserName"};

protected string mstrMemo;    //备注
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrViewpointId;    //观点Id
protected long mlngViewpointLikeLogId;    //观点点赞Id
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrReason;    //理由
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewpointLikeLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointLikeLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointLikeLogId">关键字:观点点赞Id</param>
public clsvViewpointLikeLogEN(long lngViewpointLikeLogId)
 {
 if (lngViewpointLikeLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointLikeLogId = lngViewpointLikeLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointLikeLogId");
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
if (strAttributeName  ==  convViewpointLikeLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewpointLikeLog.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convViewpointLikeLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointLikeLogId)
{
return mlngViewpointLikeLogId;
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convViewpointLikeLog.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convViewpointLikeLog.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convViewpointLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.Memo);
}
else if (strAttributeName  ==  convViewpointLikeLog.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.UpdUserId);
}
else if (strAttributeName  ==  convViewpointLikeLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.UpdDate);
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.ViewpointId);
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointLikeLogId)
{
mlngViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointLikeLog.ViewpointLikeLogId);
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.ViewpointName);
}
else if (strAttributeName  ==  convViewpointLikeLog.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.ViewpointContent);
}
else if (strAttributeName  ==  convViewpointLikeLog.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.Reason);
}
else if (strAttributeName  ==  convViewpointLikeLog.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewpointLikeLog.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewpointLikeLog.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convViewpointLikeLog.ViewpointLikeLogId  ==  AttributeName[intIndex])
{
return mlngViewpointLikeLogId;
}
else if (convViewpointLikeLog.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convViewpointLikeLog.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convViewpointLikeLog.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convViewpointLikeLog.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.Memo);
}
else if (convViewpointLikeLog.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.UpdUserId);
}
else if (convViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.UpdDate);
}
else if (convViewpointLikeLog.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.ViewpointId);
}
else if (convViewpointLikeLog.ViewpointLikeLogId  ==  AttributeName[intIndex])
{
mlngViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointLikeLog.ViewpointLikeLogId);
}
else if (convViewpointLikeLog.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.ViewpointName);
}
else if (convViewpointLikeLog.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.ViewpointContent);
}
else if (convViewpointLikeLog.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.Reason);
}
else if (convViewpointLikeLog.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointLikeLog.UserName);
}
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
 AddUpdatedFld(convViewpointLikeLog.Memo);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.UpdUserId);
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
 AddUpdatedFld(convViewpointLikeLog.UpdDate);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.ViewpointId);
}
}
/// <summary>
/// 观点点赞Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointLikeLogId
{
get
{
return mlngViewpointLikeLogId;
}
set
{
 mlngViewpointLikeLogId = value;
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.ViewpointLikeLogId);
}
}
/// <summary>
/// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointName
{
get
{
return mstrViewpointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointName = value;
}
else
{
 mstrViewpointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.ViewpointName);
}
}
/// <summary>
/// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointContent
{
get
{
return mstrViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointContent = value;
}
else
{
 mstrViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.ViewpointContent);
}
}
/// <summary>
/// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Reason
{
get
{
return mstrReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReason = value;
}
else
{
 mstrReason = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.Reason);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointLikeLog.UserName);
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
  return mlngViewpointLikeLogId.ToString();
 }
 }
}
 /// <summary>
 /// vViewpointLikeLog(vViewpointLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewpointLikeLog
{
public const string _CurrTabName = "vViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "UpdUserId", "UpdDate", "ViewpointId", "ViewpointLikeLogId", "ViewpointName", "ViewpointContent", "Reason", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"ViewpointLikeLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointLikeLogId = "ViewpointLikeLogId";    //观点点赞Id

 /// <summary>
 /// 常量:"ViewpointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointName = "ViewpointName";    //观点名称

 /// <summary>
 /// 常量:"ViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointContent = "ViewpointContent";    //观点内容

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}
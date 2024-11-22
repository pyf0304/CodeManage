
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointLikeLogEN
 表名:zx_ViewpointLikeLog(01120858)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:05:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表zx_ViewpointLikeLog的关键字(ViewpointLikeLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointLikeLogId_zx_ViewpointLikeLog
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
public K_ViewpointLikeLogId_zx_ViewpointLikeLog(long lngViewpointLikeLogId)
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
 /// <returns>返回:[K_ViewpointLikeLogId_zx_ViewpointLikeLog]类型的对象</returns>
public static implicit operator K_ViewpointLikeLogId_zx_ViewpointLikeLog(long value)
{
return new K_ViewpointLikeLogId_zx_ViewpointLikeLog(value);
}
}
 /// <summary>
 /// 中学观点点赞表(zx_ViewpointLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewpointLikeLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ViewpointLikeLogId", "zxViewpointId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngViewpointLikeLogId;    //观点点赞Id
protected string mstrzxViewpointId;    //观点Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ViewpointLikeLogEN()
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
public clszx_ViewpointLikeLogEN(long lngViewpointLikeLogId)
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
if (strAttributeName  ==  conzx_ViewpointLikeLog.ViewpointLikeLogId)
{
return mlngViewpointLikeLogId;
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.zxViewpointId)
{
return mstrzxViewpointId;
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ViewpointLikeLog.ViewpointLikeLogId)
{
mlngViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointLikeLog.ViewpointLikeLogId);
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.zxViewpointId)
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.zxViewpointId);
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.UpdDate);
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.UpdUserId);
}
else if (strAttributeName  ==  conzx_ViewpointLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ViewpointLikeLog.ViewpointLikeLogId  ==  AttributeName[intIndex])
{
return mlngViewpointLikeLogId;
}
else if (conzx_ViewpointLikeLog.zxViewpointId  ==  AttributeName[intIndex])
{
return mstrzxViewpointId;
}
else if (conzx_ViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ViewpointLikeLog.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conzx_ViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ViewpointLikeLog.ViewpointLikeLogId  ==  AttributeName[intIndex])
{
mlngViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointLikeLog.ViewpointLikeLogId);
}
else if (conzx_ViewpointLikeLog.zxViewpointId  ==  AttributeName[intIndex])
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.zxViewpointId);
}
else if (conzx_ViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.UpdDate);
}
else if (conzx_ViewpointLikeLog.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.UpdUserId);
}
else if (conzx_ViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointLikeLog.Memo);
}
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
 AddUpdatedFld(conzx_ViewpointLikeLog.ViewpointLikeLogId);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxViewpointId
{
get
{
return mstrzxViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxViewpointId = value;
}
else
{
 mstrzxViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointLikeLog.zxViewpointId);
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
 AddUpdatedFld(conzx_ViewpointLikeLog.UpdDate);
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
 AddUpdatedFld(conzx_ViewpointLikeLog.UpdUserId);
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
 AddUpdatedFld(conzx_ViewpointLikeLog.Memo);
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
 /// 中学观点点赞表(zx_ViewpointLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ViewpointLikeLog
{
public const string _CurrTabName = "zx_ViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointLikeLogId", "zxViewpointId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointLikeLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointLikeLogId = "ViewpointLikeLogId";    //观点点赞Id

 /// <summary>
 /// 常量:"zxViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointId = "zxViewpointId";    //观点Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
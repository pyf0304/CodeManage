
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointLikeLogEN
 表名:vPaperSubViewpointLikeLog(01120563)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:25
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
 /// 表vPaperSubViewpointLikeLog的关键字(PaperSubViewpointLikeLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubViewpointLikeLogId_vPaperSubViewpointLikeLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperSubViewpointLikeLogId">表关键字</param>
public K_PaperSubViewpointLikeLogId_vPaperSubViewpointLikeLog(long lngPaperSubViewpointLikeLogId)
{
if (IsValid(lngPaperSubViewpointLikeLogId)) Value = lngPaperSubViewpointLikeLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperSubViewpointLikeLogId)
{
if (lngPaperSubViewpointLikeLogId == 0) return false;
if (lngPaperSubViewpointLikeLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperSubViewpointLikeLogId_vPaperSubViewpointLikeLog]类型的对象</returns>
public static implicit operator K_PaperSubViewpointLikeLogId_vPaperSubViewpointLikeLog(long value)
{
return new K_PaperSubViewpointLikeLogId_vPaperSubViewpointLikeLog(value);
}
}
 /// <summary>
 /// v子观点点赞表(vPaperSubViewpointLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperSubViewpointLikeLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperSubViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PaperSubViewpointLikeLogId", "SubViewpointId", "UpdDate", "Memo", "RWTitle", "SubViewpointContent", "ExplainContent", "PaperRWId", "UpdUser"};

protected long mlngPaperSubViewpointLikeLogId;    //点赞Id
protected long mlngSubViewpointId;    //子观点Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrRWTitle;    //读写标题
protected string mstrSubViewpointContent;    //详情内容
protected string mstrExplainContent;    //说明内容
protected string mstrPaperRWId;    //课文阅读
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperSubViewpointLikeLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubViewpointLikeLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperSubViewpointLikeLogId">关键字:点赞Id</param>
public clsvPaperSubViewpointLikeLogEN(long lngPaperSubViewpointLikeLogId)
 {
 if (lngPaperSubViewpointLikeLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperSubViewpointLikeLogId = lngPaperSubViewpointLikeLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubViewpointLikeLogId");
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
if (strAttributeName  ==  convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId)
{
return mlngPaperSubViewpointLikeLogId;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.RWTitle)
{
return mstrRWTitle;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.SubViewpointContent)
{
return mstrSubViewpointContent;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.ExplainContent)
{
return mstrExplainContent;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId)
{
mlngPaperSubViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointLikeLog.SubViewpointId);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.UpdDate);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.Memo);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.RWTitle)
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.RWTitle);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.SubViewpointContent)
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.SubViewpointContent);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.ExplainContent)
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.ExplainContent);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.PaperRWId);
}
else if (strAttributeName  ==  convPaperSubViewpointLikeLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId  ==  AttributeName[intIndex])
{
return mlngPaperSubViewpointLikeLogId;
}
else if (convPaperSubViewpointLikeLog.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (convPaperSubViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperSubViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperSubViewpointLikeLog.RWTitle  ==  AttributeName[intIndex])
{
return mstrRWTitle;
}
else if (convPaperSubViewpointLikeLog.SubViewpointContent  ==  AttributeName[intIndex])
{
return mstrSubViewpointContent;
}
else if (convPaperSubViewpointLikeLog.ExplainContent  ==  AttributeName[intIndex])
{
return mstrExplainContent;
}
else if (convPaperSubViewpointLikeLog.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (convPaperSubViewpointLikeLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId  ==  AttributeName[intIndex])
{
mlngPaperSubViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId);
}
else if (convPaperSubViewpointLikeLog.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointLikeLog.SubViewpointId);
}
else if (convPaperSubViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.UpdDate);
}
else if (convPaperSubViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.Memo);
}
else if (convPaperSubViewpointLikeLog.RWTitle  ==  AttributeName[intIndex])
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.RWTitle);
}
else if (convPaperSubViewpointLikeLog.SubViewpointContent  ==  AttributeName[intIndex])
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.SubViewpointContent);
}
else if (convPaperSubViewpointLikeLog.ExplainContent  ==  AttributeName[intIndex])
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.ExplainContent);
}
else if (convPaperSubViewpointLikeLog.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.PaperRWId);
}
else if (convPaperSubViewpointLikeLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSubViewpointLikeLog.UpdUser);
}
}
}

/// <summary>
/// 点赞Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperSubViewpointLikeLogId
{
get
{
return mlngPaperSubViewpointLikeLogId;
}
set
{
 mlngPaperSubViewpointLikeLogId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId);
}
}
/// <summary>
/// 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SubViewpointId
{
get
{
return mlngSubViewpointId;
}
set
{
 mlngSubViewpointId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointLikeLog.SubViewpointId);
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
 AddUpdatedFld(convPaperSubViewpointLikeLog.UpdDate);
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
 AddUpdatedFld(convPaperSubViewpointLikeLog.Memo);
}
}
/// <summary>
/// 读写标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RWTitle
{
get
{
return mstrRWTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRWTitle = value;
}
else
{
 mstrRWTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointLikeLog.RWTitle);
}
}
/// <summary>
/// 详情内容(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointContent
{
get
{
return mstrSubViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointContent = value;
}
else
{
 mstrSubViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointLikeLog.SubViewpointContent);
}
}
/// <summary>
/// 说明内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainContent
{
get
{
return mstrExplainContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainContent = value;
}
else
{
 mstrExplainContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointLikeLog.ExplainContent);
}
}
/// <summary>
/// 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperRWId
{
get
{
return mstrPaperRWId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperRWId = value;
}
else
{
 mstrPaperRWId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointLikeLog.PaperRWId);
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
 AddUpdatedFld(convPaperSubViewpointLikeLog.UpdUser);
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
  return mlngPaperSubViewpointLikeLogId.ToString();
 }
 }
}
 /// <summary>
 /// v子观点点赞表(vPaperSubViewpointLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperSubViewpointLikeLog
{
public const string _CurrTabName = "vPaperSubViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubViewpointLikeLogId", "SubViewpointId", "UpdDate", "Memo", "RWTitle", "SubViewpointContent", "ExplainContent", "PaperRWId", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperSubViewpointLikeLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubViewpointLikeLogId = "PaperSubViewpointLikeLogId";    //点赞Id

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

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
 /// 常量:"RWTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RWTitle = "RWTitle";    //读写标题

 /// <summary>
 /// 常量:"SubViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointContent = "SubViewpointContent";    //详情内容

 /// <summary>
 /// 常量:"ExplainContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainContent = "ExplainContent";    //说明内容

 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsObjectiveAttachmentEN
 表名:ObjectiveAttachment(01120614)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:48
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
 /// 表ObjectiveAttachment的关键字(ObjectiveAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ObjectiveAttachmentId_ObjectiveAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngObjectiveAttachmentId">表关键字</param>
public K_ObjectiveAttachmentId_ObjectiveAttachment(long lngObjectiveAttachmentId)
{
if (IsValid(lngObjectiveAttachmentId)) Value = lngObjectiveAttachmentId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngObjectiveAttachmentId)
{
if (lngObjectiveAttachmentId == 0) return false;
if (lngObjectiveAttachmentId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ObjectiveAttachmentId_ObjectiveAttachment]类型的对象</returns>
public static implicit operator K_ObjectiveAttachmentId_ObjectiveAttachment(long value)
{
return new K_ObjectiveAttachmentId_ObjectiveAttachment(value);
}
}
 /// <summary>
 /// 客观附件表(ObjectiveAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsObjectiveAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ObjectiveAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ObjectiveAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"TopicObjectiveId", "ObjectiveAttachmentId", "ObjectiveAttachmentName", "FilePath", "UpdDate", "UpdUserId", "Memo", "IdCurrEduCls"};

protected string mstrTopicObjectiveId;    //客观Id
protected long mlngObjectiveAttachmentId;    //客观附件Id
protected string mstrObjectiveAttachmentName;    //附件名称
protected string mstrFilePath;    //文件路径
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsObjectiveAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ObjectiveAttachmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngObjectiveAttachmentId">关键字:客观附件Id</param>
public clsObjectiveAttachmentEN(long lngObjectiveAttachmentId)
 {
 if (lngObjectiveAttachmentId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngObjectiveAttachmentId = lngObjectiveAttachmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ObjectiveAttachmentId");
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
if (strAttributeName  ==  conObjectiveAttachment.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  conObjectiveAttachment.ObjectiveAttachmentId)
{
return mlngObjectiveAttachmentId;
}
else if (strAttributeName  ==  conObjectiveAttachment.ObjectiveAttachmentName)
{
return mstrObjectiveAttachmentName;
}
else if (strAttributeName  ==  conObjectiveAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conObjectiveAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conObjectiveAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conObjectiveAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conObjectiveAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conObjectiveAttachment.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.TopicObjectiveId);
}
else if (strAttributeName  ==  conObjectiveAttachment.ObjectiveAttachmentId)
{
mlngObjectiveAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conObjectiveAttachment.ObjectiveAttachmentId);
}
else if (strAttributeName  ==  conObjectiveAttachment.ObjectiveAttachmentName)
{
mstrObjectiveAttachmentName = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.ObjectiveAttachmentName);
}
else if (strAttributeName  ==  conObjectiveAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.FilePath);
}
else if (strAttributeName  ==  conObjectiveAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.UpdDate);
}
else if (strAttributeName  ==  conObjectiveAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.UpdUserId);
}
else if (strAttributeName  ==  conObjectiveAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.Memo);
}
else if (strAttributeName  ==  conObjectiveAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conObjectiveAttachment.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (conObjectiveAttachment.ObjectiveAttachmentId  ==  AttributeName[intIndex])
{
return mlngObjectiveAttachmentId;
}
else if (conObjectiveAttachment.ObjectiveAttachmentName  ==  AttributeName[intIndex])
{
return mstrObjectiveAttachmentName;
}
else if (conObjectiveAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conObjectiveAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conObjectiveAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conObjectiveAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conObjectiveAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conObjectiveAttachment.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.TopicObjectiveId);
}
else if (conObjectiveAttachment.ObjectiveAttachmentId  ==  AttributeName[intIndex])
{
mlngObjectiveAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conObjectiveAttachment.ObjectiveAttachmentId);
}
else if (conObjectiveAttachment.ObjectiveAttachmentName  ==  AttributeName[intIndex])
{
mstrObjectiveAttachmentName = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.ObjectiveAttachmentName);
}
else if (conObjectiveAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.FilePath);
}
else if (conObjectiveAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.UpdDate);
}
else if (conObjectiveAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.UpdUserId);
}
else if (conObjectiveAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.Memo);
}
else if (conObjectiveAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conObjectiveAttachment.IdCurrEduCls);
}
}
}

/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicObjectiveId
{
get
{
return mstrTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicObjectiveId = value;
}
else
{
 mstrTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(conObjectiveAttachment.TopicObjectiveId);
}
}
/// <summary>
/// 客观附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ObjectiveAttachmentId
{
get
{
return mlngObjectiveAttachmentId;
}
set
{
 mlngObjectiveAttachmentId = value;
//记录修改过的字段
 AddUpdatedFld(conObjectiveAttachment.ObjectiveAttachmentId);
}
}
/// <summary>
/// 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveAttachmentName
{
get
{
return mstrObjectiveAttachmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveAttachmentName = value;
}
else
{
 mstrObjectiveAttachmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conObjectiveAttachment.ObjectiveAttachmentName);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conObjectiveAttachment.FilePath);
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
 AddUpdatedFld(conObjectiveAttachment.UpdDate);
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
 AddUpdatedFld(conObjectiveAttachment.UpdUserId);
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
 AddUpdatedFld(conObjectiveAttachment.Memo);
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
 AddUpdatedFld(conObjectiveAttachment.IdCurrEduCls);
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
  return mlngObjectiveAttachmentId.ToString();
 }
 }
}
 /// <summary>
 /// 客观附件表(ObjectiveAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conObjectiveAttachment
{
public const string _CurrTabName = "ObjectiveAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ObjectiveAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicObjectiveId", "ObjectiveAttachmentId", "ObjectiveAttachmentName", "FilePath", "UpdDate", "UpdUserId", "Memo", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

 /// <summary>
 /// 常量:"ObjectiveAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveAttachmentId = "ObjectiveAttachmentId";    //客观附件Id

 /// <summary>
 /// 常量:"ObjectiveAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveAttachmentName = "ObjectiveAttachmentName";    //附件名称

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

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

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}
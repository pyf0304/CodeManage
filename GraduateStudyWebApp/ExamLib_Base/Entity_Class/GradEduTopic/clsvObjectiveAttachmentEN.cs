
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvObjectiveAttachmentEN
 表名:vObjectiveAttachment(01120618)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:23
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
 /// 表vObjectiveAttachment的关键字(ObjectiveAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ObjectiveAttachmentId_vObjectiveAttachment
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
public K_ObjectiveAttachmentId_vObjectiveAttachment(long lngObjectiveAttachmentId)
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
 /// <returns>返回:[K_ObjectiveAttachmentId_vObjectiveAttachment]类型的对象</returns>
public static implicit operator K_ObjectiveAttachmentId_vObjectiveAttachment(long value)
{
return new K_ObjectiveAttachmentId_vObjectiveAttachment(value);
}
}
 /// <summary>
 /// vObjectiveAttachment(vObjectiveAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvObjectiveAttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vObjectiveAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ObjectiveAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"TopicObjectiveId", "ObjectiveAttachmentId", "ObjectiveAttachmentName", "FilePath", "UpdDate", "UpdUserId", "Memo", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "ObjectiveTypeName", "Conclusion", "IdCurrEduCls"};

protected string mstrTopicObjectiveId;    //客观Id
protected long mlngObjectiveAttachmentId;    //客观附件Id
protected string mstrObjectiveAttachmentName;    //附件名称
protected string mstrFilePath;    //文件路径
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrObjectiveType;    //客观类型
protected string mstrObjectiveTypeName;    //ObjectiveTypeName
protected string mstrConclusion;    //结论
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvObjectiveAttachmentEN()
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
public clsvObjectiveAttachmentEN(long lngObjectiveAttachmentId)
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
if (strAttributeName  ==  convObjectiveAttachment.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveAttachmentId)
{
return mlngObjectiveAttachmentId;
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveAttachmentName)
{
return mstrObjectiveAttachmentName;
}
else if (strAttributeName  ==  convObjectiveAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convObjectiveAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convObjectiveAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convObjectiveAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveTypeName)
{
return mstrObjectiveTypeName;
}
else if (strAttributeName  ==  convObjectiveAttachment.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  convObjectiveAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  convObjectiveAttachment.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.TopicObjectiveId);
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveAttachmentId)
{
mlngObjectiveAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convObjectiveAttachment.ObjectiveAttachmentId);
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveAttachmentName)
{
mstrObjectiveAttachmentName = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveAttachmentName);
}
else if (strAttributeName  ==  convObjectiveAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.FilePath);
}
else if (strAttributeName  ==  convObjectiveAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.UpdDate);
}
else if (strAttributeName  ==  convObjectiveAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.UpdUserId);
}
else if (strAttributeName  ==  convObjectiveAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.Memo);
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveName);
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveContent);
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveType);
}
else if (strAttributeName  ==  convObjectiveAttachment.ObjectiveTypeName)
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveTypeName);
}
else if (strAttributeName  ==  convObjectiveAttachment.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.Conclusion);
}
else if (strAttributeName  ==  convObjectiveAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (convObjectiveAttachment.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (convObjectiveAttachment.ObjectiveAttachmentId  ==  AttributeName[intIndex])
{
return mlngObjectiveAttachmentId;
}
else if (convObjectiveAttachment.ObjectiveAttachmentName  ==  AttributeName[intIndex])
{
return mstrObjectiveAttachmentName;
}
else if (convObjectiveAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convObjectiveAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convObjectiveAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convObjectiveAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convObjectiveAttachment.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (convObjectiveAttachment.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (convObjectiveAttachment.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (convObjectiveAttachment.ObjectiveTypeName  ==  AttributeName[intIndex])
{
return mstrObjectiveTypeName;
}
else if (convObjectiveAttachment.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (convObjectiveAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (convObjectiveAttachment.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.TopicObjectiveId);
}
else if (convObjectiveAttachment.ObjectiveAttachmentId  ==  AttributeName[intIndex])
{
mlngObjectiveAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convObjectiveAttachment.ObjectiveAttachmentId);
}
else if (convObjectiveAttachment.ObjectiveAttachmentName  ==  AttributeName[intIndex])
{
mstrObjectiveAttachmentName = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveAttachmentName);
}
else if (convObjectiveAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.FilePath);
}
else if (convObjectiveAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.UpdDate);
}
else if (convObjectiveAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.UpdUserId);
}
else if (convObjectiveAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.Memo);
}
else if (convObjectiveAttachment.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveName);
}
else if (convObjectiveAttachment.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveContent);
}
else if (convObjectiveAttachment.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveType);
}
else if (convObjectiveAttachment.ObjectiveTypeName  ==  AttributeName[intIndex])
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.ObjectiveTypeName);
}
else if (convObjectiveAttachment.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.Conclusion);
}
else if (convObjectiveAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convObjectiveAttachment.IdCurrEduCls);
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
 AddUpdatedFld(convObjectiveAttachment.TopicObjectiveId);
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
 AddUpdatedFld(convObjectiveAttachment.ObjectiveAttachmentId);
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
 AddUpdatedFld(convObjectiveAttachment.ObjectiveAttachmentName);
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
 AddUpdatedFld(convObjectiveAttachment.FilePath);
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
 AddUpdatedFld(convObjectiveAttachment.UpdDate);
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
 AddUpdatedFld(convObjectiveAttachment.UpdUserId);
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
 AddUpdatedFld(convObjectiveAttachment.Memo);
}
}
/// <summary>
/// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveName
{
get
{
return mstrObjectiveName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveName = value;
}
else
{
 mstrObjectiveName = value;
}
//记录修改过的字段
 AddUpdatedFld(convObjectiveAttachment.ObjectiveName);
}
}
/// <summary>
/// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveContent
{
get
{
return mstrObjectiveContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveContent = value;
}
else
{
 mstrObjectiveContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convObjectiveAttachment.ObjectiveContent);
}
}
/// <summary>
/// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveType
{
get
{
return mstrObjectiveType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveType = value;
}
else
{
 mstrObjectiveType = value;
}
//记录修改过的字段
 AddUpdatedFld(convObjectiveAttachment.ObjectiveType);
}
}
/// <summary>
/// ObjectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveTypeName
{
get
{
return mstrObjectiveTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveTypeName = value;
}
else
{
 mstrObjectiveTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convObjectiveAttachment.ObjectiveTypeName);
}
}
/// <summary>
/// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Conclusion
{
get
{
return mstrConclusion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConclusion = value;
}
else
{
 mstrConclusion = value;
}
//记录修改过的字段
 AddUpdatedFld(convObjectiveAttachment.Conclusion);
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
 AddUpdatedFld(convObjectiveAttachment.IdCurrEduCls);
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
 /// vObjectiveAttachment(vObjectiveAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convObjectiveAttachment
{
public const string _CurrTabName = "vObjectiveAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ObjectiveAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicObjectiveId", "ObjectiveAttachmentId", "ObjectiveAttachmentName", "FilePath", "UpdDate", "UpdUserId", "Memo", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "ObjectiveTypeName", "Conclusion", "IdCurrEduCls"};
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
 /// 常量:"ObjectiveName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveName = "ObjectiveName";    //客观名称

 /// <summary>
 /// 常量:"ObjectiveContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveContent = "ObjectiveContent";    //客观内容

 /// <summary>
 /// 常量:"ObjectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveType = "ObjectiveType";    //客观类型

 /// <summary>
 /// 常量:"ObjectiveTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveTypeName = "ObjectiveTypeName";    //ObjectiveTypeName

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}
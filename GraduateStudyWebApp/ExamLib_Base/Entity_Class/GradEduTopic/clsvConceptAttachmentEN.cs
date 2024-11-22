
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptAttachmentEN
 表名:vConceptAttachment(01120606)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:12
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
 /// 表vConceptAttachment的关键字(ConceptAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConceptAttachmentId_vConceptAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngConceptAttachmentId">表关键字</param>
public K_ConceptAttachmentId_vConceptAttachment(long lngConceptAttachmentId)
{
if (IsValid(lngConceptAttachmentId)) Value = lngConceptAttachmentId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngConceptAttachmentId)
{
if (lngConceptAttachmentId == 0) return false;
if (lngConceptAttachmentId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConceptAttachmentId_vConceptAttachment]类型的对象</returns>
public static implicit operator K_ConceptAttachmentId_vConceptAttachment(long value)
{
return new K_ConceptAttachmentId_vConceptAttachment(value);
}
}
 /// <summary>
 /// vConceptAttachment(vConceptAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvConceptAttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vConceptAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConceptAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"ConceptName", "ConceptAttachmentId", "ConceptContent", "ConceptAttachmentName", "ConceptId", "IsSubmit", "FilePath", "UpdDate", "Memo", "IdCurrEduCls"};

protected string mstrConceptName;    //概念名称
protected long mlngConceptAttachmentId;    //概念附件Id
protected string mstrConceptContent;    //概念内容
protected string mstrConceptAttachmentName;    //附件名称
protected string mstrConceptId;    //概念Id
protected bool mbolIsSubmit;    //是否提交
protected string mstrFilePath;    //文件路径
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvConceptAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptAttachmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngConceptAttachmentId">关键字:概念附件Id</param>
public clsvConceptAttachmentEN(long lngConceptAttachmentId)
 {
 if (lngConceptAttachmentId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngConceptAttachmentId = lngConceptAttachmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptAttachmentId");
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
if (strAttributeName  ==  convConceptAttachment.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  convConceptAttachment.ConceptAttachmentId)
{
return mlngConceptAttachmentId;
}
else if (strAttributeName  ==  convConceptAttachment.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  convConceptAttachment.ConceptAttachmentName)
{
return mstrConceptAttachmentName;
}
else if (strAttributeName  ==  convConceptAttachment.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  convConceptAttachment.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convConceptAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convConceptAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convConceptAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convConceptAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  convConceptAttachment.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptName);
}
else if (strAttributeName  ==  convConceptAttachment.ConceptAttachmentId)
{
mlngConceptAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convConceptAttachment.ConceptAttachmentId);
}
else if (strAttributeName  ==  convConceptAttachment.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptContent);
}
else if (strAttributeName  ==  convConceptAttachment.ConceptAttachmentName)
{
mstrConceptAttachmentName = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptAttachmentName);
}
else if (strAttributeName  ==  convConceptAttachment.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptId);
}
else if (strAttributeName  ==  convConceptAttachment.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convConceptAttachment.IsSubmit);
}
else if (strAttributeName  ==  convConceptAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convConceptAttachment.FilePath);
}
else if (strAttributeName  ==  convConceptAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConceptAttachment.UpdDate);
}
else if (strAttributeName  ==  convConceptAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convConceptAttachment.Memo);
}
else if (strAttributeName  ==  convConceptAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convConceptAttachment.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (convConceptAttachment.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (convConceptAttachment.ConceptAttachmentId  ==  AttributeName[intIndex])
{
return mlngConceptAttachmentId;
}
else if (convConceptAttachment.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (convConceptAttachment.ConceptAttachmentName  ==  AttributeName[intIndex])
{
return mstrConceptAttachmentName;
}
else if (convConceptAttachment.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (convConceptAttachment.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convConceptAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convConceptAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convConceptAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convConceptAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (convConceptAttachment.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptName);
}
else if (convConceptAttachment.ConceptAttachmentId  ==  AttributeName[intIndex])
{
mlngConceptAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convConceptAttachment.ConceptAttachmentId);
}
else if (convConceptAttachment.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptContent);
}
else if (convConceptAttachment.ConceptAttachmentName  ==  AttributeName[intIndex])
{
mstrConceptAttachmentName = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptAttachmentName);
}
else if (convConceptAttachment.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convConceptAttachment.ConceptId);
}
else if (convConceptAttachment.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convConceptAttachment.IsSubmit);
}
else if (convConceptAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convConceptAttachment.FilePath);
}
else if (convConceptAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConceptAttachment.UpdDate);
}
else if (convConceptAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convConceptAttachment.Memo);
}
else if (convConceptAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convConceptAttachment.IdCurrEduCls);
}
}
}

/// <summary>
/// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptName
{
get
{
return mstrConceptName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptName = value;
}
else
{
 mstrConceptName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptAttachment.ConceptName);
}
}
/// <summary>
/// 概念附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ConceptAttachmentId
{
get
{
return mlngConceptAttachmentId;
}
set
{
 mlngConceptAttachmentId = value;
//记录修改过的字段
 AddUpdatedFld(convConceptAttachment.ConceptAttachmentId);
}
}
/// <summary>
/// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptContent
{
get
{
return mstrConceptContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptContent = value;
}
else
{
 mstrConceptContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptAttachment.ConceptContent);
}
}
/// <summary>
/// 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptAttachmentName
{
get
{
return mstrConceptAttachmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptAttachmentName = value;
}
else
{
 mstrConceptAttachmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptAttachment.ConceptAttachmentName);
}
}
/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptId
{
get
{
return mstrConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptId = value;
}
else
{
 mstrConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptAttachment.ConceptId);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(convConceptAttachment.IsSubmit);
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
 AddUpdatedFld(convConceptAttachment.FilePath);
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
 AddUpdatedFld(convConceptAttachment.UpdDate);
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
 AddUpdatedFld(convConceptAttachment.Memo);
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
 AddUpdatedFld(convConceptAttachment.IdCurrEduCls);
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
  return mlngConceptAttachmentId.ToString();
 }
 }
}
 /// <summary>
 /// vConceptAttachment(vConceptAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convConceptAttachment
{
public const string _CurrTabName = "vConceptAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConceptAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConceptName", "ConceptAttachmentId", "ConceptContent", "ConceptAttachmentName", "ConceptId", "IsSubmit", "FilePath", "UpdDate", "Memo", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"ConceptAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptAttachmentId = "ConceptAttachmentId";    //概念附件Id

 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"ConceptAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptAttachmentName = "ConceptAttachmentName";    //附件名称

 /// <summary>
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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
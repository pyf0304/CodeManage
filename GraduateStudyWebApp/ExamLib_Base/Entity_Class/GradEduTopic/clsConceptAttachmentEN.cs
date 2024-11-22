
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptAttachmentEN
 表名:ConceptAttachment(01120603)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:45
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
 /// 表ConceptAttachment的关键字(ConceptAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConceptAttachmentId_ConceptAttachment
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
public K_ConceptAttachmentId_ConceptAttachment(long lngConceptAttachmentId)
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
 /// <returns>返回:[K_ConceptAttachmentId_ConceptAttachment]类型的对象</returns>
public static implicit operator K_ConceptAttachmentId_ConceptAttachment(long value)
{
return new K_ConceptAttachmentId_ConceptAttachment(value);
}
}
 /// <summary>
 /// 概念附件(ConceptAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsConceptAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ConceptAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConceptAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"ConceptAttachmentId", "ConceptAttachmentName", "ConceptId", "FilePath", "UpdDate", "UpdUserId", "Memo", "IdCurrEduCls"};

protected long mlngConceptAttachmentId;    //概念附件Id
protected string mstrConceptAttachmentName;    //附件名称
protected string mstrConceptId;    //概念Id
protected string mstrFilePath;    //文件路径
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsConceptAttachmentEN()
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
public clsConceptAttachmentEN(long lngConceptAttachmentId)
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
if (strAttributeName  ==  conConceptAttachment.ConceptAttachmentId)
{
return mlngConceptAttachmentId;
}
else if (strAttributeName  ==  conConceptAttachment.ConceptAttachmentName)
{
return mstrConceptAttachmentName;
}
else if (strAttributeName  ==  conConceptAttachment.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  conConceptAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conConceptAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conConceptAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conConceptAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conConceptAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conConceptAttachment.ConceptAttachmentId)
{
mlngConceptAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conConceptAttachment.ConceptAttachmentId);
}
else if (strAttributeName  ==  conConceptAttachment.ConceptAttachmentName)
{
mstrConceptAttachmentName = value.ToString();
 AddUpdatedFld(conConceptAttachment.ConceptAttachmentName);
}
else if (strAttributeName  ==  conConceptAttachment.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conConceptAttachment.ConceptId);
}
else if (strAttributeName  ==  conConceptAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conConceptAttachment.FilePath);
}
else if (strAttributeName  ==  conConceptAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConceptAttachment.UpdDate);
}
else if (strAttributeName  ==  conConceptAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conConceptAttachment.UpdUserId);
}
else if (strAttributeName  ==  conConceptAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConceptAttachment.Memo);
}
else if (strAttributeName  ==  conConceptAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conConceptAttachment.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conConceptAttachment.ConceptAttachmentId  ==  AttributeName[intIndex])
{
return mlngConceptAttachmentId;
}
else if (conConceptAttachment.ConceptAttachmentName  ==  AttributeName[intIndex])
{
return mstrConceptAttachmentName;
}
else if (conConceptAttachment.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (conConceptAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conConceptAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conConceptAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conConceptAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conConceptAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conConceptAttachment.ConceptAttachmentId  ==  AttributeName[intIndex])
{
mlngConceptAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conConceptAttachment.ConceptAttachmentId);
}
else if (conConceptAttachment.ConceptAttachmentName  ==  AttributeName[intIndex])
{
mstrConceptAttachmentName = value.ToString();
 AddUpdatedFld(conConceptAttachment.ConceptAttachmentName);
}
else if (conConceptAttachment.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conConceptAttachment.ConceptId);
}
else if (conConceptAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conConceptAttachment.FilePath);
}
else if (conConceptAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConceptAttachment.UpdDate);
}
else if (conConceptAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conConceptAttachment.UpdUserId);
}
else if (conConceptAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConceptAttachment.Memo);
}
else if (conConceptAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conConceptAttachment.IdCurrEduCls);
}
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
 AddUpdatedFld(conConceptAttachment.ConceptAttachmentId);
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
 AddUpdatedFld(conConceptAttachment.ConceptAttachmentName);
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
 AddUpdatedFld(conConceptAttachment.ConceptId);
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
 AddUpdatedFld(conConceptAttachment.FilePath);
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
 AddUpdatedFld(conConceptAttachment.UpdDate);
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
 AddUpdatedFld(conConceptAttachment.UpdUserId);
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
 AddUpdatedFld(conConceptAttachment.Memo);
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
 AddUpdatedFld(conConceptAttachment.IdCurrEduCls);
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
 /// 概念附件(ConceptAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conConceptAttachment
{
public const string _CurrTabName = "ConceptAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConceptAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConceptAttachmentId", "ConceptAttachmentName", "ConceptId", "FilePath", "UpdDate", "UpdUserId", "Memo", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConceptAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptAttachmentId = "ConceptAttachmentId";    //概念附件Id

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
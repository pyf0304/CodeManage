
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubAttachmentEN
 表名:vPaperSubAttachment(01120598)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vPaperSubAttachment的关键字(PaperSubAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubAttachmentId_vPaperSubAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperSubAttachmentId">表关键字</param>
public K_PaperSubAttachmentId_vPaperSubAttachment(long lngPaperSubAttachmentId)
{
if (IsValid(lngPaperSubAttachmentId)) Value = lngPaperSubAttachmentId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperSubAttachmentId)
{
if (lngPaperSubAttachmentId == 0) return false;
if (lngPaperSubAttachmentId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperSubAttachmentId_vPaperSubAttachment]类型的对象</returns>
public static implicit operator K_PaperSubAttachmentId_vPaperSubAttachment(long value)
{
return new K_PaperSubAttachmentId_vPaperSubAttachment(value);
}
}
 /// <summary>
 /// 子观点附件(vPaperSubAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperSubAttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperSubAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"ExplainContent", "SubViewpointId", "FilePath", "Memo", "PaperRWId", "PaperSubAttachmentName", "RWTitle", "SubViewpointContent", "UpdDate", "UpdUserId", "PaperSubAttachmentId"};

protected string mstrExplainContent;    //说明内容
protected string mstrSubViewpointId;    //子观点Id
protected string mstrFilePath;    //文件路径
protected string mstrMemo;    //备注
protected string mstrPaperRWId;    //课文阅读
protected string mstrPaperSubAttachmentName;    //附件名称
protected string mstrRWTitle;    //读写标题
protected string mstrSubViewpointContent;    //详情内容
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected long mlngPaperSubAttachmentId;    //子观点附件Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperSubAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubAttachmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperSubAttachmentId">关键字:子观点附件Id</param>
public clsvPaperSubAttachmentEN(long lngPaperSubAttachmentId)
 {
 if (lngPaperSubAttachmentId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperSubAttachmentId = lngPaperSubAttachmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubAttachmentId");
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
if (strAttributeName  ==  convPaperSubAttachment.ExplainContent)
{
return mstrExplainContent;
}
else if (strAttributeName  ==  convPaperSubAttachment.SubViewpointId)
{
return mstrSubViewpointId;
}
else if (strAttributeName  ==  convPaperSubAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convPaperSubAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperSubAttachment.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  convPaperSubAttachment.PaperSubAttachmentName)
{
return mstrPaperSubAttachmentName;
}
else if (strAttributeName  ==  convPaperSubAttachment.RWTitle)
{
return mstrRWTitle;
}
else if (strAttributeName  ==  convPaperSubAttachment.SubViewpointContent)
{
return mstrSubViewpointContent;
}
else if (strAttributeName  ==  convPaperSubAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperSubAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convPaperSubAttachment.PaperSubAttachmentId)
{
return mlngPaperSubAttachmentId;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperSubAttachment.ExplainContent)
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.ExplainContent);
}
else if (strAttributeName  ==  convPaperSubAttachment.SubViewpointId)
{
mstrSubViewpointId = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.SubViewpointId);
}
else if (strAttributeName  ==  convPaperSubAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.FilePath);
}
else if (strAttributeName  ==  convPaperSubAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.Memo);
}
else if (strAttributeName  ==  convPaperSubAttachment.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.PaperRWId);
}
else if (strAttributeName  ==  convPaperSubAttachment.PaperSubAttachmentName)
{
mstrPaperSubAttachmentName = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.PaperSubAttachmentName);
}
else if (strAttributeName  ==  convPaperSubAttachment.RWTitle)
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.RWTitle);
}
else if (strAttributeName  ==  convPaperSubAttachment.SubViewpointContent)
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.SubViewpointContent);
}
else if (strAttributeName  ==  convPaperSubAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.UpdDate);
}
else if (strAttributeName  ==  convPaperSubAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.UpdUserId);
}
else if (strAttributeName  ==  convPaperSubAttachment.PaperSubAttachmentId)
{
mlngPaperSubAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubAttachment.PaperSubAttachmentId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperSubAttachment.ExplainContent  ==  AttributeName[intIndex])
{
return mstrExplainContent;
}
else if (convPaperSubAttachment.SubViewpointId  ==  AttributeName[intIndex])
{
return mstrSubViewpointId;
}
else if (convPaperSubAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convPaperSubAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperSubAttachment.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (convPaperSubAttachment.PaperSubAttachmentName  ==  AttributeName[intIndex])
{
return mstrPaperSubAttachmentName;
}
else if (convPaperSubAttachment.RWTitle  ==  AttributeName[intIndex])
{
return mstrRWTitle;
}
else if (convPaperSubAttachment.SubViewpointContent  ==  AttributeName[intIndex])
{
return mstrSubViewpointContent;
}
else if (convPaperSubAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperSubAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convPaperSubAttachment.PaperSubAttachmentId  ==  AttributeName[intIndex])
{
return mlngPaperSubAttachmentId;
}
return null;
}
set
{
if (convPaperSubAttachment.ExplainContent  ==  AttributeName[intIndex])
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.ExplainContent);
}
else if (convPaperSubAttachment.SubViewpointId  ==  AttributeName[intIndex])
{
mstrSubViewpointId = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.SubViewpointId);
}
else if (convPaperSubAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.FilePath);
}
else if (convPaperSubAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.Memo);
}
else if (convPaperSubAttachment.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.PaperRWId);
}
else if (convPaperSubAttachment.PaperSubAttachmentName  ==  AttributeName[intIndex])
{
mstrPaperSubAttachmentName = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.PaperSubAttachmentName);
}
else if (convPaperSubAttachment.RWTitle  ==  AttributeName[intIndex])
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.RWTitle);
}
else if (convPaperSubAttachment.SubViewpointContent  ==  AttributeName[intIndex])
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.SubViewpointContent);
}
else if (convPaperSubAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.UpdDate);
}
else if (convPaperSubAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPaperSubAttachment.UpdUserId);
}
else if (convPaperSubAttachment.PaperSubAttachmentId  ==  AttributeName[intIndex])
{
mlngPaperSubAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubAttachment.PaperSubAttachmentId);
}
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
 AddUpdatedFld(convPaperSubAttachment.ExplainContent);
}
}
/// <summary>
/// 子观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointId
{
get
{
return mstrSubViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointId = value;
}
else
{
 mstrSubViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubAttachment.SubViewpointId);
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
 AddUpdatedFld(convPaperSubAttachment.FilePath);
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
 AddUpdatedFld(convPaperSubAttachment.Memo);
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
 AddUpdatedFld(convPaperSubAttachment.PaperRWId);
}
}
/// <summary>
/// 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperSubAttachmentName
{
get
{
return mstrPaperSubAttachmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperSubAttachmentName = value;
}
else
{
 mstrPaperSubAttachmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubAttachment.PaperSubAttachmentName);
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
 AddUpdatedFld(convPaperSubAttachment.RWTitle);
}
}
/// <summary>
/// 详情内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
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
 AddUpdatedFld(convPaperSubAttachment.SubViewpointContent);
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
 AddUpdatedFld(convPaperSubAttachment.UpdDate);
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
 AddUpdatedFld(convPaperSubAttachment.UpdUserId);
}
}
/// <summary>
/// 子观点附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperSubAttachmentId
{
get
{
return mlngPaperSubAttachmentId;
}
set
{
 mlngPaperSubAttachmentId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubAttachment.PaperSubAttachmentId);
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
  return mlngPaperSubAttachmentId.ToString();
 }
 }
}
 /// <summary>
 /// 子观点附件(vPaperSubAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperSubAttachment
{
public const string _CurrTabName = "vPaperSubAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExplainContent", "SubViewpointId", "FilePath", "Memo", "PaperRWId", "PaperSubAttachmentName", "RWTitle", "SubViewpointContent", "UpdDate", "UpdUserId", "PaperSubAttachmentId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExplainContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainContent = "ExplainContent";    //说明内容

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

 /// <summary>
 /// 常量:"PaperSubAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubAttachmentName = "PaperSubAttachmentName";    //附件名称

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
 /// 常量:"PaperSubAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubAttachmentId = "PaperSubAttachmentId";    //子观点附件Id
}

}
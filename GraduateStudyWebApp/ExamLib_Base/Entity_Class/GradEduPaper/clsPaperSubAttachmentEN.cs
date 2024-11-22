
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubAttachmentEN
 表名:PaperSubAttachment(01120579)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表PaperSubAttachment的关键字(PaperSubAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubAttachmentId_PaperSubAttachment
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
public K_PaperSubAttachmentId_PaperSubAttachment(long lngPaperSubAttachmentId)
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
 /// <returns>返回:[K_PaperSubAttachmentId_PaperSubAttachment]类型的对象</returns>
public static implicit operator K_PaperSubAttachmentId_PaperSubAttachment(long value)
{
return new K_PaperSubAttachmentId_PaperSubAttachment(value);
}
}
 /// <summary>
 /// 子观点附件(PaperSubAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperSubAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperSubAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PaperSubAttachmentId", "PaperSubAttachmentName", "FilePath", "IdCurrEduCls", "PaperRWId", "SubViewpointId", "UpdUserId", "UpdDate", "Memo"};

protected long mlngPaperSubAttachmentId;    //子观点附件Id
protected string mstrPaperSubAttachmentName;    //附件名称
protected string mstrFilePath;    //文件路径
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPaperRWId;    //课文阅读
protected long mlngSubViewpointId;    //子观点Id
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperSubAttachmentEN()
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
public clsPaperSubAttachmentEN(long lngPaperSubAttachmentId)
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
if (strAttributeName  ==  conPaperSubAttachment.PaperSubAttachmentId)
{
return mlngPaperSubAttachmentId;
}
else if (strAttributeName  ==  conPaperSubAttachment.PaperSubAttachmentName)
{
return mstrPaperSubAttachmentName;
}
else if (strAttributeName  ==  conPaperSubAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conPaperSubAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conPaperSubAttachment.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  conPaperSubAttachment.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  conPaperSubAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPaperSubAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperSubAttachment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperSubAttachment.PaperSubAttachmentId)
{
mlngPaperSubAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubAttachment.PaperSubAttachmentId);
}
else if (strAttributeName  ==  conPaperSubAttachment.PaperSubAttachmentName)
{
mstrPaperSubAttachmentName = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.PaperSubAttachmentName);
}
else if (strAttributeName  ==  conPaperSubAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.FilePath);
}
else if (strAttributeName  ==  conPaperSubAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.IdCurrEduCls);
}
else if (strAttributeName  ==  conPaperSubAttachment.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.PaperRWId);
}
else if (strAttributeName  ==  conPaperSubAttachment.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubAttachment.SubViewpointId);
}
else if (strAttributeName  ==  conPaperSubAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.UpdUserId);
}
else if (strAttributeName  ==  conPaperSubAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.UpdDate);
}
else if (strAttributeName  ==  conPaperSubAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperSubAttachment.PaperSubAttachmentId  ==  AttributeName[intIndex])
{
return mlngPaperSubAttachmentId;
}
else if (conPaperSubAttachment.PaperSubAttachmentName  ==  AttributeName[intIndex])
{
return mstrPaperSubAttachmentName;
}
else if (conPaperSubAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conPaperSubAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conPaperSubAttachment.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (conPaperSubAttachment.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (conPaperSubAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPaperSubAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperSubAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperSubAttachment.PaperSubAttachmentId  ==  AttributeName[intIndex])
{
mlngPaperSubAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubAttachment.PaperSubAttachmentId);
}
else if (conPaperSubAttachment.PaperSubAttachmentName  ==  AttributeName[intIndex])
{
mstrPaperSubAttachmentName = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.PaperSubAttachmentName);
}
else if (conPaperSubAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.FilePath);
}
else if (conPaperSubAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.IdCurrEduCls);
}
else if (conPaperSubAttachment.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.PaperRWId);
}
else if (conPaperSubAttachment.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubAttachment.SubViewpointId);
}
else if (conPaperSubAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.UpdUserId);
}
else if (conPaperSubAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.UpdDate);
}
else if (conPaperSubAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubAttachment.Memo);
}
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
 AddUpdatedFld(conPaperSubAttachment.PaperSubAttachmentId);
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
 AddUpdatedFld(conPaperSubAttachment.PaperSubAttachmentName);
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
 AddUpdatedFld(conPaperSubAttachment.FilePath);
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
 AddUpdatedFld(conPaperSubAttachment.IdCurrEduCls);
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
 AddUpdatedFld(conPaperSubAttachment.PaperRWId);
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
 AddUpdatedFld(conPaperSubAttachment.SubViewpointId);
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
 AddUpdatedFld(conPaperSubAttachment.UpdUserId);
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
 AddUpdatedFld(conPaperSubAttachment.UpdDate);
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
 AddUpdatedFld(conPaperSubAttachment.Memo);
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
 /// 子观点附件(PaperSubAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperSubAttachment
{
public const string _CurrTabName = "PaperSubAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubAttachmentId", "PaperSubAttachmentName", "FilePath", "IdCurrEduCls", "PaperRWId", "SubViewpointId", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperSubAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubAttachmentId = "PaperSubAttachmentId";    //子观点附件Id

 /// <summary>
 /// 常量:"PaperSubAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubAttachmentName = "PaperSubAttachmentName";    //附件名称

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
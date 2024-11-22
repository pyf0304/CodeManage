
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperAttachmentEN
 表名:PaperAttachment(01120578)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:47
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
 /// 表PaperAttachment的关键字(PaperAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperAttachmentId_PaperAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperAttachmentId">表关键字</param>
public K_PaperAttachmentId_PaperAttachment(long lngPaperAttachmentId)
{
if (IsValid(lngPaperAttachmentId)) Value = lngPaperAttachmentId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperAttachmentId)
{
if (lngPaperAttachmentId == 0) return false;
if (lngPaperAttachmentId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperAttachmentId_PaperAttachment]类型的对象</returns>
public static implicit operator K_PaperAttachmentId_PaperAttachment(long value)
{
return new K_PaperAttachmentId_PaperAttachment(value);
}
}
 /// <summary>
 /// 论文附件(PaperAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"PaperAttachmentId", "PaperAttachmentName", "PaperId", "FilePath", "IdCurrEduCls", "UpdUserId", "UpdDate", "Memo"};

protected long mlngPaperAttachmentId;    //论文附件Id
protected string mstrPaperAttachmentName;    //附件名称
protected string mstrPaperId;    //论文Id
protected string mstrFilePath;    //文件路径
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAttachmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperAttachmentId">关键字:论文附件Id</param>
public clsPaperAttachmentEN(long lngPaperAttachmentId)
 {
 if (lngPaperAttachmentId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperAttachmentId = lngPaperAttachmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAttachmentId");
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
if (strAttributeName  ==  conPaperAttachment.PaperAttachmentId)
{
return mlngPaperAttachmentId;
}
else if (strAttributeName  ==  conPaperAttachment.PaperAttachmentName)
{
return mstrPaperAttachmentName;
}
else if (strAttributeName  ==  conPaperAttachment.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conPaperAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conPaperAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPaperAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperAttachment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperAttachment.PaperAttachmentId)
{
mlngPaperAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperAttachment.PaperAttachmentId);
}
else if (strAttributeName  ==  conPaperAttachment.PaperAttachmentName)
{
mstrPaperAttachmentName = value.ToString();
 AddUpdatedFld(conPaperAttachment.PaperAttachmentName);
}
else if (strAttributeName  ==  conPaperAttachment.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperAttachment.PaperId);
}
else if (strAttributeName  ==  conPaperAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conPaperAttachment.FilePath);
}
else if (strAttributeName  ==  conPaperAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperAttachment.IdCurrEduCls);
}
else if (strAttributeName  ==  conPaperAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPaperAttachment.UpdUserId);
}
else if (strAttributeName  ==  conPaperAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperAttachment.UpdDate);
}
else if (strAttributeName  ==  conPaperAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperAttachment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperAttachment.PaperAttachmentId  ==  AttributeName[intIndex])
{
return mlngPaperAttachmentId;
}
else if (conPaperAttachment.PaperAttachmentName  ==  AttributeName[intIndex])
{
return mstrPaperAttachmentName;
}
else if (conPaperAttachment.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conPaperAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conPaperAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPaperAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperAttachment.PaperAttachmentId  ==  AttributeName[intIndex])
{
mlngPaperAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperAttachment.PaperAttachmentId);
}
else if (conPaperAttachment.PaperAttachmentName  ==  AttributeName[intIndex])
{
mstrPaperAttachmentName = value.ToString();
 AddUpdatedFld(conPaperAttachment.PaperAttachmentName);
}
else if (conPaperAttachment.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperAttachment.PaperId);
}
else if (conPaperAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conPaperAttachment.FilePath);
}
else if (conPaperAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperAttachment.IdCurrEduCls);
}
else if (conPaperAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPaperAttachment.UpdUserId);
}
else if (conPaperAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperAttachment.UpdDate);
}
else if (conPaperAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperAttachment.Memo);
}
}
}

/// <summary>
/// 论文附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperAttachmentId
{
get
{
return mlngPaperAttachmentId;
}
set
{
 mlngPaperAttachmentId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperAttachment.PaperAttachmentId);
}
}
/// <summary>
/// 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperAttachmentName
{
get
{
return mstrPaperAttachmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperAttachmentName = value;
}
else
{
 mstrPaperAttachmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperAttachment.PaperAttachmentName);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperAttachment.PaperId);
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
 AddUpdatedFld(conPaperAttachment.FilePath);
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
 AddUpdatedFld(conPaperAttachment.IdCurrEduCls);
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
 AddUpdatedFld(conPaperAttachment.UpdUserId);
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
 AddUpdatedFld(conPaperAttachment.UpdDate);
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
 AddUpdatedFld(conPaperAttachment.Memo);
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
  return mlngPaperAttachmentId.ToString();
 }
 }
}
 /// <summary>
 /// 论文附件(PaperAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperAttachment
{
public const string _CurrTabName = "PaperAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperAttachmentId", "PaperAttachmentName", "PaperId", "FilePath", "IdCurrEduCls", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAttachmentId = "PaperAttachmentId";    //论文附件Id

 /// <summary>
 /// 常量:"PaperAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAttachmentName = "PaperAttachmentName";    //附件名称

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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
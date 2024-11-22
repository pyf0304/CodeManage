
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointVerEN
 表名:ViewpointVer(01120650)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:31
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
 /// 表ViewpointVer的关键字(ViewpointVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointVId_ViewpointVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointVId">表关键字</param>
public K_ViewpointVId_ViewpointVer(long lngViewpointVId)
{
if (IsValid(lngViewpointVId)) Value = lngViewpointVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointVId)
{
if (lngViewpointVId == 0) return false;
if (lngViewpointVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointVId_ViewpointVer]类型的对象</returns>
public static implicit operator K_ViewpointVId_ViewpointVer(long value)
{
return new K_ViewpointVId_ViewpointVer(value);
}
}
 /// <summary>
 /// 观点版本表(ViewpointVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewpointVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewpointVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"ViewpointVId", "ViewpointId", "ViewpointName", "ViewpointContent", "ViewpointTypeId", "Reason", "Source", "VPProposePeople", "UserTypeId", "CitationId", "UpdDate", "UpdUser", "PdfContent", "PdfPageNum", "IdCurrEduCls", "Memo"};

protected long mlngViewpointVId;    //ViewpointVId
protected string mstrViewpointId;    //观点Id
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrReason;    //理由
protected string mstrSource;    //来源
protected string mstrVPProposePeople;    //观点提出人
protected string mstrUserTypeId;    //用户类型Id
protected string mstrCitationId;    //引用Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsViewpointVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointVId">关键字:ViewpointVId</param>
public clsViewpointVerEN(long lngViewpointVId)
 {
 if (lngViewpointVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointVId = lngViewpointVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointVId");
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
if (strAttributeName  ==  conViewpointVer.ViewpointVId)
{
return mlngViewpointVId;
}
else if (strAttributeName  ==  conViewpointVer.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  conViewpointVer.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  conViewpointVer.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  conViewpointVer.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  conViewpointVer.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  conViewpointVer.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  conViewpointVer.VPProposePeople)
{
return mstrVPProposePeople;
}
else if (strAttributeName  ==  conViewpointVer.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conViewpointVer.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  conViewpointVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewpointVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conViewpointVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conViewpointVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conViewpointVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conViewpointVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewpointVer.ViewpointVId)
{
mlngViewpointVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointVer.ViewpointVId);
}
else if (strAttributeName  ==  conViewpointVer.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointId);
}
else if (strAttributeName  ==  conViewpointVer.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointName);
}
else if (strAttributeName  ==  conViewpointVer.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointContent);
}
else if (strAttributeName  ==  conViewpointVer.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointTypeId);
}
else if (strAttributeName  ==  conViewpointVer.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(conViewpointVer.Reason);
}
else if (strAttributeName  ==  conViewpointVer.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(conViewpointVer.Source);
}
else if (strAttributeName  ==  conViewpointVer.VPProposePeople)
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(conViewpointVer.VPProposePeople);
}
else if (strAttributeName  ==  conViewpointVer.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conViewpointVer.UserTypeId);
}
else if (strAttributeName  ==  conViewpointVer.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conViewpointVer.CitationId);
}
else if (strAttributeName  ==  conViewpointVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewpointVer.UpdDate);
}
else if (strAttributeName  ==  conViewpointVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewpointVer.UpdUser);
}
else if (strAttributeName  ==  conViewpointVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conViewpointVer.PdfContent);
}
else if (strAttributeName  ==  conViewpointVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointVer.PdfPageNum);
}
else if (strAttributeName  ==  conViewpointVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conViewpointVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conViewpointVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewpointVer.ViewpointVId  ==  AttributeName[intIndex])
{
return mlngViewpointVId;
}
else if (conViewpointVer.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (conViewpointVer.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (conViewpointVer.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (conViewpointVer.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (conViewpointVer.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (conViewpointVer.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (conViewpointVer.VPProposePeople  ==  AttributeName[intIndex])
{
return mstrVPProposePeople;
}
else if (conViewpointVer.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conViewpointVer.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (conViewpointVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewpointVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conViewpointVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conViewpointVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conViewpointVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conViewpointVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewpointVer.ViewpointVId  ==  AttributeName[intIndex])
{
mlngViewpointVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointVer.ViewpointVId);
}
else if (conViewpointVer.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointId);
}
else if (conViewpointVer.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointName);
}
else if (conViewpointVer.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointContent);
}
else if (conViewpointVer.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(conViewpointVer.ViewpointTypeId);
}
else if (conViewpointVer.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(conViewpointVer.Reason);
}
else if (conViewpointVer.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(conViewpointVer.Source);
}
else if (conViewpointVer.VPProposePeople  ==  AttributeName[intIndex])
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(conViewpointVer.VPProposePeople);
}
else if (conViewpointVer.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conViewpointVer.UserTypeId);
}
else if (conViewpointVer.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conViewpointVer.CitationId);
}
else if (conViewpointVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewpointVer.UpdDate);
}
else if (conViewpointVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conViewpointVer.UpdUser);
}
else if (conViewpointVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conViewpointVer.PdfContent);
}
else if (conViewpointVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointVer.PdfPageNum);
}
else if (conViewpointVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conViewpointVer.IdCurrEduCls);
}
else if (conViewpointVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointVer.Memo);
}
}
}

/// <summary>
/// ViewpointVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointVId
{
get
{
return mlngViewpointVId;
}
set
{
 mlngViewpointVId = value;
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.ViewpointVId);
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
 AddUpdatedFld(conViewpointVer.ViewpointId);
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
 AddUpdatedFld(conViewpointVer.ViewpointName);
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
 AddUpdatedFld(conViewpointVer.ViewpointContent);
}
}
/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeId
{
get
{
return mstrViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeId = value;
}
else
{
 mstrViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.ViewpointTypeId);
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
 AddUpdatedFld(conViewpointVer.Reason);
}
}
/// <summary>
/// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Source
{
get
{
return mstrSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSource = value;
}
else
{
 mstrSource = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.Source);
}
}
/// <summary>
/// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VPProposePeople
{
get
{
return mstrVPProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVPProposePeople = value;
}
else
{
 mstrVPProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.VPProposePeople);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.UserTypeId);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CitationId
{
get
{
return mstrCitationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCitationId = value;
}
else
{
 mstrCitationId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.CitationId);
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
 AddUpdatedFld(conViewpointVer.UpdDate);
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
 AddUpdatedFld(conViewpointVer.UpdUser);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.PdfContent);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(conViewpointVer.PdfPageNum);
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
 AddUpdatedFld(conViewpointVer.IdCurrEduCls);
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
 AddUpdatedFld(conViewpointVer.Memo);
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
  return mlngViewpointVId.ToString();
 }
 }
}
 /// <summary>
 /// 观点版本表(ViewpointVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewpointVer
{
public const string _CurrTabName = "ViewpointVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointVId", "ViewpointId", "ViewpointName", "ViewpointContent", "ViewpointTypeId", "Reason", "Source", "VPProposePeople", "UserTypeId", "CitationId", "UpdDate", "UpdUser", "PdfContent", "PdfPageNum", "IdCurrEduCls", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointVId = "ViewpointVId";    //ViewpointVId

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

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
 /// 常量:"ViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeId = "ViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

 /// <summary>
 /// 常量:"VPProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VPProposePeople = "VPProposePeople";    //观点提出人

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
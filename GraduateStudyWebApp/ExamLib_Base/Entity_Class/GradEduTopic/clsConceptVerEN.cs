
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptVerEN
 表名:ConceptVer(01120649)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:27
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
 /// 表ConceptVer的关键字(ConceptVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConceptVId_ConceptVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngConceptVId">表关键字</param>
public K_ConceptVId_ConceptVer(long lngConceptVId)
{
if (IsValid(lngConceptVId)) Value = lngConceptVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngConceptVId)
{
if (lngConceptVId == 0) return false;
if (lngConceptVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConceptVId_ConceptVer]类型的对象</returns>
public static implicit operator K_ConceptVId_ConceptVer(long value)
{
return new K_ConceptVId_ConceptVer(value);
}
}
 /// <summary>
 /// 概念版本表(ConceptVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsConceptVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ConceptVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConceptVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"ConceptVId", "ConceptId", "ConceptContent", "ConceptName", "CitationId", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "Memo"};

protected long mlngConceptVId;    //ConceptVId
protected string mstrConceptId;    //概念Id
protected string mstrConceptContent;    //概念内容
protected string mstrConceptName;    //概念名称
protected string mstrCitationId;    //引用Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsConceptVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngConceptVId">关键字:ConceptVId</param>
public clsConceptVerEN(long lngConceptVId)
 {
 if (lngConceptVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngConceptVId = lngConceptVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptVId");
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
if (strAttributeName  ==  conConceptVer.ConceptVId)
{
return mlngConceptVId;
}
else if (strAttributeName  ==  conConceptVer.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  conConceptVer.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  conConceptVer.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  conConceptVer.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  conConceptVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conConceptVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conConceptVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conConceptVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conConceptVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conConceptVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conConceptVer.ConceptVId)
{
mlngConceptVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conConceptVer.ConceptVId);
}
else if (strAttributeName  ==  conConceptVer.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conConceptVer.ConceptId);
}
else if (strAttributeName  ==  conConceptVer.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(conConceptVer.ConceptContent);
}
else if (strAttributeName  ==  conConceptVer.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(conConceptVer.ConceptName);
}
else if (strAttributeName  ==  conConceptVer.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conConceptVer.CitationId);
}
else if (strAttributeName  ==  conConceptVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConceptVer.UpdDate);
}
else if (strAttributeName  ==  conConceptVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConceptVer.UpdUser);
}
else if (strAttributeName  ==  conConceptVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conConceptVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conConceptVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conConceptVer.PdfContent);
}
else if (strAttributeName  ==  conConceptVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conConceptVer.PdfPageNum);
}
else if (strAttributeName  ==  conConceptVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConceptVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conConceptVer.ConceptVId  ==  AttributeName[intIndex])
{
return mlngConceptVId;
}
else if (conConceptVer.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (conConceptVer.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (conConceptVer.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (conConceptVer.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (conConceptVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conConceptVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conConceptVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conConceptVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conConceptVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conConceptVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conConceptVer.ConceptVId  ==  AttributeName[intIndex])
{
mlngConceptVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conConceptVer.ConceptVId);
}
else if (conConceptVer.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conConceptVer.ConceptId);
}
else if (conConceptVer.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(conConceptVer.ConceptContent);
}
else if (conConceptVer.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(conConceptVer.ConceptName);
}
else if (conConceptVer.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conConceptVer.CitationId);
}
else if (conConceptVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConceptVer.UpdDate);
}
else if (conConceptVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConceptVer.UpdUser);
}
else if (conConceptVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conConceptVer.IdCurrEduCls);
}
else if (conConceptVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conConceptVer.PdfContent);
}
else if (conConceptVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conConceptVer.PdfPageNum);
}
else if (conConceptVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConceptVer.Memo);
}
}
}

/// <summary>
/// ConceptVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ConceptVId
{
get
{
return mlngConceptVId;
}
set
{
 mlngConceptVId = value;
//记录修改过的字段
 AddUpdatedFld(conConceptVer.ConceptVId);
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
 AddUpdatedFld(conConceptVer.ConceptId);
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
 AddUpdatedFld(conConceptVer.ConceptContent);
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
 AddUpdatedFld(conConceptVer.ConceptName);
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
 AddUpdatedFld(conConceptVer.CitationId);
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
 AddUpdatedFld(conConceptVer.UpdDate);
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
 AddUpdatedFld(conConceptVer.UpdUser);
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
 AddUpdatedFld(conConceptVer.IdCurrEduCls);
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
 AddUpdatedFld(conConceptVer.PdfContent);
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
 AddUpdatedFld(conConceptVer.PdfPageNum);
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
 AddUpdatedFld(conConceptVer.Memo);
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
  return mlngConceptVId.ToString();
 }
 }
}
 /// <summary>
 /// 概念版本表(ConceptVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conConceptVer
{
public const string _CurrTabName = "ConceptVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConceptVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConceptVId", "ConceptId", "ConceptContent", "ConceptName", "CitationId", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConceptVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptVId = "ConceptVId";    //ConceptVId

 /// <summary>
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
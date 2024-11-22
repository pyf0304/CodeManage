
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperParagraphVerEN
 表名:gs_PaperParagraphVer(01120743)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:50
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
 /// 表gs_PaperParagraphVer的关键字(ParagraphVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ParagraphVId_gs_PaperParagraphVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngParagraphVId">表关键字</param>
public K_ParagraphVId_gs_PaperParagraphVer(long lngParagraphVId)
{
if (IsValid(lngParagraphVId)) Value = lngParagraphVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngParagraphVId)
{
if (lngParagraphVId == 0) return false;
if (lngParagraphVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ParagraphVId_gs_PaperParagraphVer]类型的对象</returns>
public static implicit operator K_ParagraphVId_gs_PaperParagraphVer(long value)
{
return new K_ParagraphVId_gs_PaperParagraphVer(value);
}
}
 /// <summary>
 /// 论文段落版本(gs_PaperParagraphVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PaperParagraphVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PaperParagraphVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ParagraphVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ParagraphVId", "ParagraphId", "SectionId", "ParagraphTypeId", "ParagraphContent", "UpdDate", "UpdUser", "Memo", "PaperId"};

protected long mlngParagraphVId;    //段落版本Id
protected string mstrParagraphId;    //段落Id
protected string mstrSectionId;    //节Id
protected string mstrParagraphTypeId;    //段落类型Id
protected string mstrParagraphContent;    //段落内容
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrPaperId;    //论文Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PaperParagraphVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngParagraphVId">关键字:段落版本Id</param>
public clsgs_PaperParagraphVerEN(long lngParagraphVId)
 {
 if (lngParagraphVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngParagraphVId = lngParagraphVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphVId");
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
if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphVId)
{
return mlngParagraphVId;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphId)
{
return mstrParagraphId;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphTypeId)
{
return mstrParagraphTypeId;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphContent)
{
return mstrParagraphContent;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_PaperParagraphVer.PaperId)
{
return mstrPaperId;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphVId)
{
mlngParagraphVId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphVId);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphId)
{
mstrParagraphId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphId);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.SectionId);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphTypeId)
{
mstrParagraphTypeId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphTypeId);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.ParagraphContent)
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphContent);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.UpdDate);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.UpdUser);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.Memo);
}
else if (strAttributeName  ==  congs_PaperParagraphVer.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.PaperId);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PaperParagraphVer.ParagraphVId  ==  AttributeName[intIndex])
{
return mlngParagraphVId;
}
else if (congs_PaperParagraphVer.ParagraphId  ==  AttributeName[intIndex])
{
return mstrParagraphId;
}
else if (congs_PaperParagraphVer.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (congs_PaperParagraphVer.ParagraphTypeId  ==  AttributeName[intIndex])
{
return mstrParagraphTypeId;
}
else if (congs_PaperParagraphVer.ParagraphContent  ==  AttributeName[intIndex])
{
return mstrParagraphContent;
}
else if (congs_PaperParagraphVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_PaperParagraphVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_PaperParagraphVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_PaperParagraphVer.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
return null;
}
set
{
if (congs_PaperParagraphVer.ParagraphVId  ==  AttributeName[intIndex])
{
mlngParagraphVId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphVId);
}
else if (congs_PaperParagraphVer.ParagraphId  ==  AttributeName[intIndex])
{
mstrParagraphId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphId);
}
else if (congs_PaperParagraphVer.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.SectionId);
}
else if (congs_PaperParagraphVer.ParagraphTypeId  ==  AttributeName[intIndex])
{
mstrParagraphTypeId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphTypeId);
}
else if (congs_PaperParagraphVer.ParagraphContent  ==  AttributeName[intIndex])
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphContent);
}
else if (congs_PaperParagraphVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.UpdDate);
}
else if (congs_PaperParagraphVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.UpdUser);
}
else if (congs_PaperParagraphVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.Memo);
}
else if (congs_PaperParagraphVer.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PaperParagraphVer.PaperId);
}
}
}

/// <summary>
/// 段落版本Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ParagraphVId
{
get
{
return mlngParagraphVId;
}
set
{
 mlngParagraphVId = value;
//记录修改过的字段
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphVId);
}
}
/// <summary>
/// 段落Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphId
{
get
{
return mstrParagraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphId = value;
}
else
{
 mstrParagraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperParagraphVer.SectionId);
}
}
/// <summary>
/// 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphTypeId
{
get
{
return mstrParagraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphTypeId = value;
}
else
{
 mstrParagraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphTypeId);
}
}
/// <summary>
/// 段落内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphContent
{
get
{
return mstrParagraphContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphContent = value;
}
else
{
 mstrParagraphContent = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperParagraphVer.ParagraphContent);
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
 AddUpdatedFld(congs_PaperParagraphVer.UpdDate);
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
 AddUpdatedFld(congs_PaperParagraphVer.UpdUser);
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
 AddUpdatedFld(congs_PaperParagraphVer.Memo);
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
 AddUpdatedFld(congs_PaperParagraphVer.PaperId);
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
  return mlngParagraphVId.ToString();
 }
 }
}
 /// <summary>
 /// 论文段落版本(gs_PaperParagraphVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PaperParagraphVer
{
public const string _CurrTabName = "gs_PaperParagraphVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ParagraphVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ParagraphVId", "ParagraphId", "SectionId", "ParagraphTypeId", "ParagraphContent", "UpdDate", "UpdUser", "Memo", "PaperId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ParagraphVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphVId = "ParagraphVId";    //段落版本Id

 /// <summary>
 /// 常量:"ParagraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphId = "ParagraphId";    //段落Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"ParagraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphTypeId = "ParagraphTypeId";    //段落类型Id

 /// <summary>
 /// 常量:"ParagraphContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphContent = "ParagraphContent";    //段落内容

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id
}

}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSectionEN
 表名:vSection(01120559)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:56:48
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
 /// 表vSection的关键字(SectionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SectionId_vSection
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSectionId">表关键字</param>
public K_SectionId_vSection(string strSectionId)
{
if (IsValid(strSectionId)) Value = strSectionId;
else
{
Value = null;
}
}
private static bool IsValid(string strSectionId)
{
if (string.IsNullOrEmpty(strSectionId) == true) return false;
if (strSectionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SectionId_vSection]类型的对象</returns>
public static implicit operator K_SectionId_vSection(string value)
{
return new K_SectionId_vSection(value);
}
}
 /// <summary>
 /// 论文节视图(vSection)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSectionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"SectionId", "SectionName", "PaperId", "OrderNum", "UpdDate", "UpdUser", "Memo", "PaperTitle", "Author", "ResearchQuestion", "Keyword", "ParentId"};

protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrPaperId;    //论文Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrPaperTitle;    //论文标题
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrKeyword;    //关键字
protected string mstrParentId;    //父节点Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSectionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SectionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSectionId">关键字:节Id</param>
public clsvSectionEN(string strSectionId)
 {
strSectionId = strSectionId.Replace("'", "''");
if (strSectionId.Length > 8)
{
throw new Exception("在表:vSection中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSectionId)  ==  true)
{
throw new Exception("在表:vSection中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSectionId = strSectionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SectionId");
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
if (strAttributeName  ==  convSection.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convSection.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convSection.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convSection.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convSection.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSection.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSection.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSection.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convSection.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convSection.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convSection.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convSection.ParentId)
{
return mstrParentId;
}
return null;
}
set
{
if (strAttributeName  ==  convSection.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convSection.SectionId);
}
else if (strAttributeName  ==  convSection.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convSection.SectionName);
}
else if (strAttributeName  ==  convSection.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convSection.PaperId);
}
else if (strAttributeName  ==  convSection.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSection.OrderNum);
}
else if (strAttributeName  ==  convSection.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSection.UpdDate);
}
else if (strAttributeName  ==  convSection.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSection.UpdUser);
}
else if (strAttributeName  ==  convSection.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSection.Memo);
}
else if (strAttributeName  ==  convSection.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convSection.PaperTitle);
}
else if (strAttributeName  ==  convSection.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convSection.Author);
}
else if (strAttributeName  ==  convSection.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convSection.ResearchQuestion);
}
else if (strAttributeName  ==  convSection.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convSection.Keyword);
}
else if (strAttributeName  ==  convSection.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convSection.ParentId);
}
}
}
public object this[int intIndex]
{
get
{
if (convSection.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convSection.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convSection.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convSection.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convSection.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSection.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSection.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSection.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convSection.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convSection.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convSection.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convSection.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
return null;
}
set
{
if (convSection.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convSection.SectionId);
}
else if (convSection.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convSection.SectionName);
}
else if (convSection.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convSection.PaperId);
}
else if (convSection.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSection.OrderNum);
}
else if (convSection.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSection.UpdDate);
}
else if (convSection.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSection.UpdUser);
}
else if (convSection.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSection.Memo);
}
else if (convSection.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convSection.PaperTitle);
}
else if (convSection.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convSection.Author);
}
else if (convSection.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convSection.ResearchQuestion);
}
else if (convSection.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convSection.Keyword);
}
else if (convSection.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convSection.ParentId);
}
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
 AddUpdatedFld(convSection.SectionId);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSection.SectionName);
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
 AddUpdatedFld(convSection.PaperId);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convSection.OrderNum);
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
 AddUpdatedFld(convSection.UpdDate);
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
 AddUpdatedFld(convSection.UpdUser);
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
 AddUpdatedFld(convSection.Memo);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convSection.PaperTitle);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convSection.Author);
}
}
/// <summary>
/// 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchQuestion
{
get
{
return mstrResearchQuestion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchQuestion = value;
}
else
{
 mstrResearchQuestion = value;
}
//记录修改过的字段
 AddUpdatedFld(convSection.ResearchQuestion);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convSection.Keyword);
}
}
/// <summary>
/// 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentId
{
get
{
return mstrParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentId = value;
}
else
{
 mstrParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSection.ParentId);
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
  return mstrSectionId;
 }
 }
}
 /// <summary>
 /// 论文节视图(vSection)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSection
{
public const string _CurrTabName = "vSection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SectionId", "SectionName", "PaperId", "OrderNum", "UpdDate", "UpdUser", "Memo", "PaperTitle", "Author", "ResearchQuestion", "Keyword", "ParentId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id
}

}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SectionEN
 表名:vzx_Section(01120834)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表vzx_Section的关键字(zxSectionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxSectionId_vzx_Section
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxSectionId">表关键字</param>
public K_zxSectionId_vzx_Section(string strzxSectionId)
{
if (IsValid(strzxSectionId)) Value = strzxSectionId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxSectionId)
{
if (string.IsNullOrEmpty(strzxSectionId) == true) return false;
if (strzxSectionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxSectionId_vzx_Section]类型的对象</returns>
public static implicit operator K_zxSectionId_vzx_Section(string value)
{
return new K_zxSectionId_vzx_Section(value);
}
}
 /// <summary>
 /// vzx_Section(vzx_Section)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_SectionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Section"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxSectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"PaperTitle", "PaperName", "PaperContent", "Author", "Keyword", "SectionName", "UpdDate", "PaperId", "zxSectionId", "UpdUser", "Memo", "ParentId", "OrderNum", "ResearchQuestion"};

protected string mstrPaperTitle;    //论文标题
protected string mstrPaperName;    //主题名称
protected string mstrPaperContent;    //主题内容
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected string mstrSectionName;    //节名
protected string mstrUpdDate;    //修改日期
protected string mstrPaperId;    //论文Id
protected string mstrzxSectionId;    //节Id
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrParentId;    //父节点Id
protected int? mintOrderNum;    //序号
protected string mstrResearchQuestion;    //研究问题

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_SectionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxSectionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxSectionId">关键字:节Id</param>
public clsvzx_SectionEN(string strzxSectionId)
 {
strzxSectionId = strzxSectionId.Replace("'", "''");
if (strzxSectionId.Length > 8)
{
throw new Exception("在表:vzx_Section中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxSectionId)  ==  true)
{
throw new Exception("在表:vzx_Section中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxSectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxSectionId = strzxSectionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxSectionId");
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
if (strAttributeName  ==  convzx_Section.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convzx_Section.PaperName)
{
return mstrPaperName;
}
else if (strAttributeName  ==  convzx_Section.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convzx_Section.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_Section.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convzx_Section.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convzx_Section.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Section.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convzx_Section.zxSectionId)
{
return mstrzxSectionId;
}
else if (strAttributeName  ==  convzx_Section.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Section.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Section.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  convzx_Section.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convzx_Section.ResearchQuestion)
{
return mstrResearchQuestion;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Section.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convzx_Section.PaperTitle);
}
else if (strAttributeName  ==  convzx_Section.PaperName)
{
mstrPaperName = value.ToString();
 AddUpdatedFld(convzx_Section.PaperName);
}
else if (strAttributeName  ==  convzx_Section.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convzx_Section.PaperContent);
}
else if (strAttributeName  ==  convzx_Section.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Section.Author);
}
else if (strAttributeName  ==  convzx_Section.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Section.Keyword);
}
else if (strAttributeName  ==  convzx_Section.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convzx_Section.SectionName);
}
else if (strAttributeName  ==  convzx_Section.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Section.UpdDate);
}
else if (strAttributeName  ==  convzx_Section.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convzx_Section.PaperId);
}
else if (strAttributeName  ==  convzx_Section.zxSectionId)
{
mstrzxSectionId = value.ToString();
 AddUpdatedFld(convzx_Section.zxSectionId);
}
else if (strAttributeName  ==  convzx_Section.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Section.UpdUser);
}
else if (strAttributeName  ==  convzx_Section.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Section.Memo);
}
else if (strAttributeName  ==  convzx_Section.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convzx_Section.ParentId);
}
else if (strAttributeName  ==  convzx_Section.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Section.OrderNum);
}
else if (strAttributeName  ==  convzx_Section.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_Section.ResearchQuestion);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Section.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convzx_Section.PaperName  ==  AttributeName[intIndex])
{
return mstrPaperName;
}
else if (convzx_Section.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convzx_Section.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_Section.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convzx_Section.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convzx_Section.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Section.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convzx_Section.zxSectionId  ==  AttributeName[intIndex])
{
return mstrzxSectionId;
}
else if (convzx_Section.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Section.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Section.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (convzx_Section.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convzx_Section.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
return null;
}
set
{
if (convzx_Section.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convzx_Section.PaperTitle);
}
else if (convzx_Section.PaperName  ==  AttributeName[intIndex])
{
mstrPaperName = value.ToString();
 AddUpdatedFld(convzx_Section.PaperName);
}
else if (convzx_Section.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convzx_Section.PaperContent);
}
else if (convzx_Section.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Section.Author);
}
else if (convzx_Section.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Section.Keyword);
}
else if (convzx_Section.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convzx_Section.SectionName);
}
else if (convzx_Section.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Section.UpdDate);
}
else if (convzx_Section.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convzx_Section.PaperId);
}
else if (convzx_Section.zxSectionId  ==  AttributeName[intIndex])
{
mstrzxSectionId = value.ToString();
 AddUpdatedFld(convzx_Section.zxSectionId);
}
else if (convzx_Section.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Section.UpdUser);
}
else if (convzx_Section.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Section.Memo);
}
else if (convzx_Section.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convzx_Section.ParentId);
}
else if (convzx_Section.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Section.OrderNum);
}
else if (convzx_Section.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_Section.ResearchQuestion);
}
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
 AddUpdatedFld(convzx_Section.PaperTitle);
}
}
/// <summary>
/// 主题名称(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperName
{
get
{
return mstrPaperName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperName = value;
}
else
{
 mstrPaperName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Section.PaperName);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Section.PaperContent);
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
 AddUpdatedFld(convzx_Section.Author);
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
 AddUpdatedFld(convzx_Section.Keyword);
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
 AddUpdatedFld(convzx_Section.SectionName);
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
 AddUpdatedFld(convzx_Section.UpdDate);
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
 AddUpdatedFld(convzx_Section.PaperId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxSectionId
{
get
{
return mstrzxSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxSectionId = value;
}
else
{
 mstrzxSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Section.zxSectionId);
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
 AddUpdatedFld(convzx_Section.UpdUser);
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
 AddUpdatedFld(convzx_Section.Memo);
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
 AddUpdatedFld(convzx_Section.ParentId);
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
 AddUpdatedFld(convzx_Section.OrderNum);
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
 AddUpdatedFld(convzx_Section.ResearchQuestion);
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
  return mstrzxSectionId;
 }
 }
}
 /// <summary>
 /// vzx_Section(vzx_Section)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Section
{
public const string _CurrTabName = "vzx_Section"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxSectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperTitle", "PaperName", "PaperContent", "Author", "Keyword", "SectionName", "UpdDate", "PaperId", "zxSectionId", "UpdUser", "Memo", "ParentId", "OrderNum", "ResearchQuestion"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperName = "PaperName";    //主题名称

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"zxSectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxSectionId = "zxSectionId";    //节Id

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
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题
}

}
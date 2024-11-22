
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperAppraiseEN
 表名:vPaperAppraise(01120568)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
 /// 表vPaperAppraise的关键字(PaperAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperAppraiseId_vPaperAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperAppraiseId">表关键字</param>
public K_PaperAppraiseId_vPaperAppraise(long lngPaperAppraiseId)
{
if (IsValid(lngPaperAppraiseId)) Value = lngPaperAppraiseId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperAppraiseId)
{
if (lngPaperAppraiseId == 0) return false;
if (lngPaperAppraiseId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperAppraiseId_vPaperAppraise]类型的对象</returns>
public static implicit operator K_PaperAppraiseId_vPaperAppraise(long value)
{
return new K_PaperAppraiseId_vPaperAppraise(value);
}
}
 /// <summary>
 /// v论文评论表(vPaperAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"PaperAppraiseId", "PaperAppraiseContent", "AppraiseScore", "PaperId", "UpdUser", "UpdDate", "Memo", "PaperTitle", "ResearchQuestion", "Author", "Keyword", "BrowseNumber", "UserName"};

protected long mlngPaperAppraiseId;    //论文评论Id
protected string mstrPaperAppraiseContent;    //论文评论内容
protected float? mfltAppraiseScore;    //打分
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrPaperTitle;    //论文标题
protected string mstrResearchQuestion;    //研究问题
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected int? mintBrowseNumber;    //浏览量
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAppraiseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperAppraiseId">关键字:论文评论Id</param>
public clsvPaperAppraiseEN(long lngPaperAppraiseId)
 {
 if (lngPaperAppraiseId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperAppraiseId = lngPaperAppraiseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAppraiseId");
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
if (strAttributeName  ==  convPaperAppraise.PaperAppraiseId)
{
return mlngPaperAppraiseId;
}
else if (strAttributeName  ==  convPaperAppraise.PaperAppraiseContent)
{
return mstrPaperAppraiseContent;
}
else if (strAttributeName  ==  convPaperAppraise.AppraiseScore)
{
return mfltAppraiseScore;
}
else if (strAttributeName  ==  convPaperAppraise.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperAppraise.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaperAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperAppraise.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperAppraise.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperAppraise.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convPaperAppraise.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaperAppraise.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaperAppraise.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convPaperAppraise.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperAppraise.PaperAppraiseId)
{
mlngPaperAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperAppraise.PaperAppraiseId);
}
else if (strAttributeName  ==  convPaperAppraise.PaperAppraiseContent)
{
mstrPaperAppraiseContent = value.ToString();
 AddUpdatedFld(convPaperAppraise.PaperAppraiseContent);
}
else if (strAttributeName  ==  convPaperAppraise.AppraiseScore)
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperAppraise.AppraiseScore);
}
else if (strAttributeName  ==  convPaperAppraise.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperAppraise.PaperId);
}
else if (strAttributeName  ==  convPaperAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperAppraise.UpdUser);
}
else if (strAttributeName  ==  convPaperAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperAppraise.UpdDate);
}
else if (strAttributeName  ==  convPaperAppraise.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperAppraise.Memo);
}
else if (strAttributeName  ==  convPaperAppraise.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperAppraise.PaperTitle);
}
else if (strAttributeName  ==  convPaperAppraise.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaperAppraise.ResearchQuestion);
}
else if (strAttributeName  ==  convPaperAppraise.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperAppraise.Author);
}
else if (strAttributeName  ==  convPaperAppraise.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperAppraise.Keyword);
}
else if (strAttributeName  ==  convPaperAppraise.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperAppraise.BrowseNumber);
}
else if (strAttributeName  ==  convPaperAppraise.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperAppraise.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperAppraise.PaperAppraiseId  ==  AttributeName[intIndex])
{
return mlngPaperAppraiseId;
}
else if (convPaperAppraise.PaperAppraiseContent  ==  AttributeName[intIndex])
{
return mstrPaperAppraiseContent;
}
else if (convPaperAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
return mfltAppraiseScore;
}
else if (convPaperAppraise.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaperAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperAppraise.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperAppraise.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperAppraise.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convPaperAppraise.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaperAppraise.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaperAppraise.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convPaperAppraise.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convPaperAppraise.PaperAppraiseId  ==  AttributeName[intIndex])
{
mlngPaperAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperAppraise.PaperAppraiseId);
}
else if (convPaperAppraise.PaperAppraiseContent  ==  AttributeName[intIndex])
{
mstrPaperAppraiseContent = value.ToString();
 AddUpdatedFld(convPaperAppraise.PaperAppraiseContent);
}
else if (convPaperAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperAppraise.AppraiseScore);
}
else if (convPaperAppraise.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperAppraise.PaperId);
}
else if (convPaperAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperAppraise.UpdUser);
}
else if (convPaperAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperAppraise.UpdDate);
}
else if (convPaperAppraise.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperAppraise.Memo);
}
else if (convPaperAppraise.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperAppraise.PaperTitle);
}
else if (convPaperAppraise.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaperAppraise.ResearchQuestion);
}
else if (convPaperAppraise.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperAppraise.Author);
}
else if (convPaperAppraise.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperAppraise.Keyword);
}
else if (convPaperAppraise.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperAppraise.BrowseNumber);
}
else if (convPaperAppraise.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperAppraise.UserName);
}
}
}

/// <summary>
/// 论文评论Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperAppraiseId
{
get
{
return mlngPaperAppraiseId;
}
set
{
 mlngPaperAppraiseId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperAppraise.PaperAppraiseId);
}
}
/// <summary>
/// 论文评论内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperAppraiseContent
{
get
{
return mstrPaperAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperAppraiseContent = value;
}
else
{
 mstrPaperAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperAppraise.PaperAppraiseContent);
}
}
/// <summary>
/// 打分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? AppraiseScore
{
get
{
return mfltAppraiseScore;
}
set
{
 mfltAppraiseScore = value;
//记录修改过的字段
 AddUpdatedFld(convPaperAppraise.AppraiseScore);
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
 AddUpdatedFld(convPaperAppraise.PaperId);
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
 AddUpdatedFld(convPaperAppraise.UpdUser);
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
 AddUpdatedFld(convPaperAppraise.UpdDate);
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
 AddUpdatedFld(convPaperAppraise.Memo);
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
 AddUpdatedFld(convPaperAppraise.PaperTitle);
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
 AddUpdatedFld(convPaperAppraise.ResearchQuestion);
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
 AddUpdatedFld(convPaperAppraise.Author);
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
 AddUpdatedFld(convPaperAppraise.Keyword);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseNumber
{
get
{
return mintBrowseNumber;
}
set
{
 mintBrowseNumber = value;
//记录修改过的字段
 AddUpdatedFld(convPaperAppraise.BrowseNumber);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperAppraise.UserName);
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
  return mlngPaperAppraiseId.ToString();
 }
 }
}
 /// <summary>
 /// v论文评论表(vPaperAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperAppraise
{
public const string _CurrTabName = "vPaperAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperAppraiseId", "PaperAppraiseContent", "AppraiseScore", "PaperId", "UpdUser", "UpdDate", "Memo", "PaperTitle", "ResearchQuestion", "Author", "Keyword", "BrowseNumber", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperAppraiseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAppraiseId = "PaperAppraiseId";    //论文评论Id

 /// <summary>
 /// 常量:"PaperAppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAppraiseContent = "PaperAppraiseContent";    //论文评论内容

 /// <summary>
 /// 常量:"AppraiseScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseScore = "AppraiseScore";    //打分

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

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
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}
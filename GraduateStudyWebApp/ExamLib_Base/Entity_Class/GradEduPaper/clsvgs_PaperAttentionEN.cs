
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperAttentionEN
 表名:vgs_PaperAttention(01120750)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:14
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
 /// 表vgs_PaperAttention的关键字(PaperAttentionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperAttentionId_vgs_PaperAttention
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperAttentionId">表关键字</param>
public K_PaperAttentionId_vgs_PaperAttention(long lngPaperAttentionId)
{
if (IsValid(lngPaperAttentionId)) Value = lngPaperAttentionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperAttentionId)
{
if (lngPaperAttentionId == 0) return false;
if (lngPaperAttentionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperAttentionId_vgs_PaperAttention]类型的对象</returns>
public static implicit operator K_PaperAttentionId_vgs_PaperAttention(long value)
{
return new K_PaperAttentionId_vgs_PaperAttention(value);
}
}
 /// <summary>
 /// 论文关注视图(vgs_PaperAttention)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PaperAttentionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PaperAttention"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperAttentionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"PaperAttentionId", "PaperId", "PaperTitle", "Author", "Keyword", "BrowseNumber", "UserId", "PaperGroupId", "UpdUser", "UpdDate", "Meno", "PaperGroupName", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount"};

protected long mlngPaperAttentionId;    //论文收藏Id
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected int? mintBrowseNumber;    //浏览量
protected string mstrUserId;    //用户ID
protected string mstrPaperGroupId;    //组Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注
protected string mstrPaperGroupName;    //组名
protected int? mintPaperQCount;    //论文答疑数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTagsCount;    //论文标注数
protected int? mintTeaQCount;    //教师提问数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PaperAttentionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAttentionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperAttentionId">关键字:论文收藏Id</param>
public clsvgs_PaperAttentionEN(long lngPaperAttentionId)
 {
 if (lngPaperAttentionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperAttentionId = lngPaperAttentionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAttentionId");
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
if (strAttributeName  ==  convgs_PaperAttention.PaperAttentionId)
{
return mlngPaperAttentionId;
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PaperAttention.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convgs_PaperAttention.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convgs_PaperAttention.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convgs_PaperAttention.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperGroupId)
{
return mstrPaperGroupId;
}
else if (strAttributeName  ==  convgs_PaperAttention.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PaperAttention.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PaperAttention.Meno)
{
return mstrMeno;
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperGroupName)
{
return mstrPaperGroupName;
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convgs_PaperAttention.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convgs_PaperAttention.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convgs_PaperAttention.TeaQCount)
{
return mintTeaQCount;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PaperAttention.PaperAttentionId)
{
mlngPaperAttentionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.PaperAttentionId);
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperId);
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperTitle);
}
else if (strAttributeName  ==  convgs_PaperAttention.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.Author);
}
else if (strAttributeName  ==  convgs_PaperAttention.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.Keyword);
}
else if (strAttributeName  ==  convgs_PaperAttention.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.BrowseNumber);
}
else if (strAttributeName  ==  convgs_PaperAttention.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.UserId);
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperGroupId)
{
mstrPaperGroupId = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperGroupId);
}
else if (strAttributeName  ==  convgs_PaperAttention.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.UpdUser);
}
else if (strAttributeName  ==  convgs_PaperAttention.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.UpdDate);
}
else if (strAttributeName  ==  convgs_PaperAttention.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.Meno);
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperGroupName)
{
mstrPaperGroupName = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperGroupName);
}
else if (strAttributeName  ==  convgs_PaperAttention.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.PaperQCount);
}
else if (strAttributeName  ==  convgs_PaperAttention.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.SubVCount);
}
else if (strAttributeName  ==  convgs_PaperAttention.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.TagsCount);
}
else if (strAttributeName  ==  convgs_PaperAttention.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.TeaQCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PaperAttention.PaperAttentionId  ==  AttributeName[intIndex])
{
return mlngPaperAttentionId;
}
else if (convgs_PaperAttention.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PaperAttention.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PaperAttention.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convgs_PaperAttention.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convgs_PaperAttention.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convgs_PaperAttention.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convgs_PaperAttention.PaperGroupId  ==  AttributeName[intIndex])
{
return mstrPaperGroupId;
}
else if (convgs_PaperAttention.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PaperAttention.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PaperAttention.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
else if (convgs_PaperAttention.PaperGroupName  ==  AttributeName[intIndex])
{
return mstrPaperGroupName;
}
else if (convgs_PaperAttention.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convgs_PaperAttention.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convgs_PaperAttention.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convgs_PaperAttention.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
return null;
}
set
{
if (convgs_PaperAttention.PaperAttentionId  ==  AttributeName[intIndex])
{
mlngPaperAttentionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.PaperAttentionId);
}
else if (convgs_PaperAttention.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperId);
}
else if (convgs_PaperAttention.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperTitle);
}
else if (convgs_PaperAttention.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.Author);
}
else if (convgs_PaperAttention.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.Keyword);
}
else if (convgs_PaperAttention.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.BrowseNumber);
}
else if (convgs_PaperAttention.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.UserId);
}
else if (convgs_PaperAttention.PaperGroupId  ==  AttributeName[intIndex])
{
mstrPaperGroupId = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperGroupId);
}
else if (convgs_PaperAttention.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.UpdUser);
}
else if (convgs_PaperAttention.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.UpdDate);
}
else if (convgs_PaperAttention.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.Meno);
}
else if (convgs_PaperAttention.PaperGroupName  ==  AttributeName[intIndex])
{
mstrPaperGroupName = value.ToString();
 AddUpdatedFld(convgs_PaperAttention.PaperGroupName);
}
else if (convgs_PaperAttention.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.PaperQCount);
}
else if (convgs_PaperAttention.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.SubVCount);
}
else if (convgs_PaperAttention.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.TagsCount);
}
else if (convgs_PaperAttention.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperAttention.TeaQCount);
}
}
}

/// <summary>
/// 论文收藏Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperAttentionId
{
get
{
return mlngPaperAttentionId;
}
set
{
 mlngPaperAttentionId = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.PaperAttentionId);
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
 AddUpdatedFld(convgs_PaperAttention.PaperId);
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
 AddUpdatedFld(convgs_PaperAttention.PaperTitle);
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
 AddUpdatedFld(convgs_PaperAttention.Author);
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
 AddUpdatedFld(convgs_PaperAttention.Keyword);
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
 AddUpdatedFld(convgs_PaperAttention.BrowseNumber);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.UserId);
}
}
/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperGroupId
{
get
{
return mstrPaperGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperGroupId = value;
}
else
{
 mstrPaperGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.PaperGroupId);
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
 AddUpdatedFld(convgs_PaperAttention.UpdUser);
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
 AddUpdatedFld(convgs_PaperAttention.UpdDate);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Meno
{
get
{
return mstrMeno;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMeno = value;
}
else
{
 mstrMeno = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.Meno);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperGroupName
{
get
{
return mstrPaperGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperGroupName = value;
}
else
{
 mstrPaperGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.PaperGroupName);
}
}
/// <summary>
/// 论文答疑数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperQCount
{
get
{
return mintPaperQCount;
}
set
{
 mintPaperQCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.PaperQCount);
}
}
/// <summary>
/// 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubVCount
{
get
{
return mintSubVCount;
}
set
{
 mintSubVCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.SubVCount);
}
}
/// <summary>
/// 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TagsCount
{
get
{
return mintTagsCount;
}
set
{
 mintTagsCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.TagsCount);
}
}
/// <summary>
/// 教师提问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TeaQCount
{
get
{
return mintTeaQCount;
}
set
{
 mintTeaQCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperAttention.TeaQCount);
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
  return mlngPaperAttentionId.ToString();
 }
 }
}
 /// <summary>
 /// 论文关注视图(vgs_PaperAttention)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PaperAttention
{
public const string _CurrTabName = "vgs_PaperAttention"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperAttentionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperAttentionId", "PaperId", "PaperTitle", "Author", "Keyword", "BrowseNumber", "UserId", "PaperGroupId", "UpdUser", "UpdDate", "Meno", "PaperGroupName", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperAttentionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAttentionId = "PaperAttentionId";    //论文收藏Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"PaperGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperGroupId = "PaperGroupId";    //组Id

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
 /// 常量:"Meno"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Meno = "Meno";    //备注

 /// <summary>
 /// 常量:"PaperGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperGroupName = "PaperGroupName";    //组名

 /// <summary>
 /// 常量:"PaperQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperQCount = "PaperQCount";    //论文答疑数

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

 /// <summary>
 /// 常量:"TeaQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaQCount = "TeaQCount";    //教师提问数
}

}
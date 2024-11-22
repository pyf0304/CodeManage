
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCollectionLogEN
 表名:vPaperCollectionLog(01120569)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:00:43
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
 /// 表vPaperCollectionLog的关键字(PaperCollectionLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperCollectionLogId_vPaperCollectionLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperCollectionLogId">表关键字</param>
public K_PaperCollectionLogId_vPaperCollectionLog(long lngPaperCollectionLogId)
{
if (IsValid(lngPaperCollectionLogId)) Value = lngPaperCollectionLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperCollectionLogId)
{
if (lngPaperCollectionLogId == 0) return false;
if (lngPaperCollectionLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperCollectionLogId_vPaperCollectionLog]类型的对象</returns>
public static implicit operator K_PaperCollectionLogId_vPaperCollectionLog(long value)
{
return new K_PaperCollectionLogId_vPaperCollectionLog(value);
}
}
 /// <summary>
 /// v论文收藏(vPaperCollectionLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperCollectionLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperCollectionLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperCollectionLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PaperCollectionLogId", "PaperId", "UpdUser", "UpdDate", "Meno", "PaperTitle", "Author", "Keyword", "BrowseNumber"};

protected long mlngPaperCollectionLogId;    //论文收藏Id
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注
protected string mstrPaperTitle;    //论文标题
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected int? mintBrowseNumber;    //浏览量

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperCollectionLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperCollectionLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperCollectionLogId">关键字:论文收藏Id</param>
public clsvPaperCollectionLogEN(long lngPaperCollectionLogId)
 {
 if (lngPaperCollectionLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperCollectionLogId = lngPaperCollectionLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperCollectionLogId");
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
if (strAttributeName  ==  convPaperCollectionLog.PaperCollectionLogId)
{
return mlngPaperCollectionLogId;
}
else if (strAttributeName  ==  convPaperCollectionLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperCollectionLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaperCollectionLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperCollectionLog.Meno)
{
return mstrMeno;
}
else if (strAttributeName  ==  convPaperCollectionLog.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperCollectionLog.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaperCollectionLog.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaperCollectionLog.BrowseNumber)
{
return mintBrowseNumber;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperCollectionLog.PaperCollectionLogId)
{
mlngPaperCollectionLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCollectionLog.PaperCollectionLogId);
}
else if (strAttributeName  ==  convPaperCollectionLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.PaperId);
}
else if (strAttributeName  ==  convPaperCollectionLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.UpdUser);
}
else if (strAttributeName  ==  convPaperCollectionLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.UpdDate);
}
else if (strAttributeName  ==  convPaperCollectionLog.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.Meno);
}
else if (strAttributeName  ==  convPaperCollectionLog.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.PaperTitle);
}
else if (strAttributeName  ==  convPaperCollectionLog.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.Author);
}
else if (strAttributeName  ==  convPaperCollectionLog.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.Keyword);
}
else if (strAttributeName  ==  convPaperCollectionLog.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCollectionLog.BrowseNumber);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperCollectionLog.PaperCollectionLogId  ==  AttributeName[intIndex])
{
return mlngPaperCollectionLogId;
}
else if (convPaperCollectionLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperCollectionLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaperCollectionLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperCollectionLog.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
else if (convPaperCollectionLog.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperCollectionLog.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaperCollectionLog.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaperCollectionLog.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
return null;
}
set
{
if (convPaperCollectionLog.PaperCollectionLogId  ==  AttributeName[intIndex])
{
mlngPaperCollectionLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCollectionLog.PaperCollectionLogId);
}
else if (convPaperCollectionLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.PaperId);
}
else if (convPaperCollectionLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.UpdUser);
}
else if (convPaperCollectionLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.UpdDate);
}
else if (convPaperCollectionLog.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.Meno);
}
else if (convPaperCollectionLog.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.PaperTitle);
}
else if (convPaperCollectionLog.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.Author);
}
else if (convPaperCollectionLog.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperCollectionLog.Keyword);
}
else if (convPaperCollectionLog.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCollectionLog.BrowseNumber);
}
}
}

/// <summary>
/// 论文收藏Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperCollectionLogId
{
get
{
return mlngPaperCollectionLogId;
}
set
{
 mlngPaperCollectionLogId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCollectionLog.PaperCollectionLogId);
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
 AddUpdatedFld(convPaperCollectionLog.PaperId);
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
 AddUpdatedFld(convPaperCollectionLog.UpdUser);
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
 AddUpdatedFld(convPaperCollectionLog.UpdDate);
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
 AddUpdatedFld(convPaperCollectionLog.Meno);
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
 AddUpdatedFld(convPaperCollectionLog.PaperTitle);
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
 AddUpdatedFld(convPaperCollectionLog.Author);
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
 AddUpdatedFld(convPaperCollectionLog.Keyword);
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
 AddUpdatedFld(convPaperCollectionLog.BrowseNumber);
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
  return mlngPaperCollectionLogId.ToString();
 }
 }
}
 /// <summary>
 /// v论文收藏(vPaperCollectionLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperCollectionLog
{
public const string _CurrTabName = "vPaperCollectionLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperCollectionLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperCollectionLogId", "PaperId", "UpdUser", "UpdDate", "Meno", "PaperTitle", "Author", "Keyword", "BrowseNumber"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperCollectionLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperCollectionLogId = "PaperCollectionLogId";    //论文收藏Id

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
 /// 常量:"Meno"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Meno = "Meno";    //备注

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
}

}
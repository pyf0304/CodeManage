
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperLikeLogEN
 表名:vPaperLikeLog(01120570)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:23
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
 /// 表vPaperLikeLog的关键字(PaperLikeLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperLikeLogId_vPaperLikeLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperLikeLogId">表关键字</param>
public K_PaperLikeLogId_vPaperLikeLog(long lngPaperLikeLogId)
{
if (IsValid(lngPaperLikeLogId)) Value = lngPaperLikeLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperLikeLogId)
{
if (lngPaperLikeLogId == 0) return false;
if (lngPaperLikeLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperLikeLogId_vPaperLikeLog]类型的对象</returns>
public static implicit operator K_PaperLikeLogId_vPaperLikeLog(long value)
{
return new K_PaperLikeLogId_vPaperLikeLog(value);
}
}
 /// <summary>
 /// v论文点赞表(vPaperLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperLikeLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"PaperLikeLogId", "PaperId", "UpdUser", "UpdDate", "Memo", "PaperTitle", "Author", "Keyword", "BrowseNumber", "UserName"};

protected long mlngPaperLikeLogId;    //论文点赞表Id
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrPaperTitle;    //论文标题
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected int? mintBrowseNumber;    //浏览量
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperLikeLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperLikeLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperLikeLogId">关键字:论文点赞表Id</param>
public clsvPaperLikeLogEN(long lngPaperLikeLogId)
 {
 if (lngPaperLikeLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperLikeLogId = lngPaperLikeLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperLikeLogId");
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
if (strAttributeName  ==  convPaperLikeLog.PaperLikeLogId)
{
return mlngPaperLikeLogId;
}
else if (strAttributeName  ==  convPaperLikeLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperLikeLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaperLikeLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperLikeLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperLikeLog.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperLikeLog.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaperLikeLog.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaperLikeLog.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convPaperLikeLog.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperLikeLog.PaperLikeLogId)
{
mlngPaperLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperLikeLog.PaperLikeLogId);
}
else if (strAttributeName  ==  convPaperLikeLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperLikeLog.PaperId);
}
else if (strAttributeName  ==  convPaperLikeLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperLikeLog.UpdUser);
}
else if (strAttributeName  ==  convPaperLikeLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperLikeLog.UpdDate);
}
else if (strAttributeName  ==  convPaperLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperLikeLog.Memo);
}
else if (strAttributeName  ==  convPaperLikeLog.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperLikeLog.PaperTitle);
}
else if (strAttributeName  ==  convPaperLikeLog.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperLikeLog.Author);
}
else if (strAttributeName  ==  convPaperLikeLog.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperLikeLog.Keyword);
}
else if (strAttributeName  ==  convPaperLikeLog.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperLikeLog.BrowseNumber);
}
else if (strAttributeName  ==  convPaperLikeLog.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperLikeLog.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperLikeLog.PaperLikeLogId  ==  AttributeName[intIndex])
{
return mlngPaperLikeLogId;
}
else if (convPaperLikeLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperLikeLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaperLikeLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperLikeLog.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperLikeLog.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaperLikeLog.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaperLikeLog.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convPaperLikeLog.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convPaperLikeLog.PaperLikeLogId  ==  AttributeName[intIndex])
{
mlngPaperLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperLikeLog.PaperLikeLogId);
}
else if (convPaperLikeLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperLikeLog.PaperId);
}
else if (convPaperLikeLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperLikeLog.UpdUser);
}
else if (convPaperLikeLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperLikeLog.UpdDate);
}
else if (convPaperLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperLikeLog.Memo);
}
else if (convPaperLikeLog.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperLikeLog.PaperTitle);
}
else if (convPaperLikeLog.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperLikeLog.Author);
}
else if (convPaperLikeLog.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperLikeLog.Keyword);
}
else if (convPaperLikeLog.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperLikeLog.BrowseNumber);
}
else if (convPaperLikeLog.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperLikeLog.UserName);
}
}
}

/// <summary>
/// 论文点赞表Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperLikeLogId
{
get
{
return mlngPaperLikeLogId;
}
set
{
 mlngPaperLikeLogId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperLikeLog.PaperLikeLogId);
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
 AddUpdatedFld(convPaperLikeLog.PaperId);
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
 AddUpdatedFld(convPaperLikeLog.UpdUser);
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
 AddUpdatedFld(convPaperLikeLog.UpdDate);
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
 AddUpdatedFld(convPaperLikeLog.Memo);
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
 AddUpdatedFld(convPaperLikeLog.PaperTitle);
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
 AddUpdatedFld(convPaperLikeLog.Author);
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
 AddUpdatedFld(convPaperLikeLog.Keyword);
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
 AddUpdatedFld(convPaperLikeLog.BrowseNumber);
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
 AddUpdatedFld(convPaperLikeLog.UserName);
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
  return mlngPaperLikeLogId.ToString();
 }
 }
}
 /// <summary>
 /// v论文点赞表(vPaperLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperLikeLog
{
public const string _CurrTabName = "vPaperLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperLikeLogId", "PaperId", "UpdUser", "UpdDate", "Memo", "PaperTitle", "Author", "Keyword", "BrowseNumber", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperLikeLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperLikeLogId = "PaperLikeLogId";    //论文点赞表Id

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
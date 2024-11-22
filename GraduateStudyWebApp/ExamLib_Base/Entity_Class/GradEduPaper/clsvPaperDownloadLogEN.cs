
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperDownloadLogEN
 表名:vPaperDownloadLog(01120572)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:17
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
 /// 表vPaperDownloadLog的关键字(PaperDownloadId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperDownloadId_vPaperDownloadLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperDownloadId">表关键字</param>
public K_PaperDownloadId_vPaperDownloadLog(long lngPaperDownloadId)
{
if (IsValid(lngPaperDownloadId)) Value = lngPaperDownloadId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperDownloadId)
{
if (lngPaperDownloadId == 0) return false;
if (lngPaperDownloadId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperDownloadId_vPaperDownloadLog]类型的对象</returns>
public static implicit operator K_PaperDownloadId_vPaperDownloadLog(long value)
{
return new K_PaperDownloadId_vPaperDownloadLog(value);
}
}
 /// <summary>
 /// v论文下载记录(vPaperDownloadLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperDownloadLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperDownloadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperDownloadId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"PaperDownloadId", "DownloadFile", "DownloadLink", "PaperId", "UpdUser", "UpdDate", "Memo", "PaperTitle", "Author", "Keyword", "UserName"};

protected long mlngPaperDownloadId;    //PaperDownloadId
protected string mstrDownloadFile;    //DownloadFile
protected string mstrDownloadLink;    //DownloadLink
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrPaperTitle;    //论文标题
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperDownloadLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperDownloadId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperDownloadId">关键字:PaperDownloadId</param>
public clsvPaperDownloadLogEN(long lngPaperDownloadId)
 {
 if (lngPaperDownloadId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperDownloadId = lngPaperDownloadId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperDownloadId");
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
if (strAttributeName  ==  convPaperDownloadLog.PaperDownloadId)
{
return mlngPaperDownloadId;
}
else if (strAttributeName  ==  convPaperDownloadLog.DownloadFile)
{
return mstrDownloadFile;
}
else if (strAttributeName  ==  convPaperDownloadLog.DownloadLink)
{
return mstrDownloadLink;
}
else if (strAttributeName  ==  convPaperDownloadLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperDownloadLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaperDownloadLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperDownloadLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperDownloadLog.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperDownloadLog.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaperDownloadLog.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaperDownloadLog.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperDownloadLog.PaperDownloadId)
{
mlngPaperDownloadId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperDownloadLog.PaperDownloadId);
}
else if (strAttributeName  ==  convPaperDownloadLog.DownloadFile)
{
mstrDownloadFile = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.DownloadFile);
}
else if (strAttributeName  ==  convPaperDownloadLog.DownloadLink)
{
mstrDownloadLink = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.DownloadLink);
}
else if (strAttributeName  ==  convPaperDownloadLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.PaperId);
}
else if (strAttributeName  ==  convPaperDownloadLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.UpdUser);
}
else if (strAttributeName  ==  convPaperDownloadLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.UpdDate);
}
else if (strAttributeName  ==  convPaperDownloadLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.Memo);
}
else if (strAttributeName  ==  convPaperDownloadLog.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.PaperTitle);
}
else if (strAttributeName  ==  convPaperDownloadLog.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.Author);
}
else if (strAttributeName  ==  convPaperDownloadLog.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.Keyword);
}
else if (strAttributeName  ==  convPaperDownloadLog.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperDownloadLog.PaperDownloadId  ==  AttributeName[intIndex])
{
return mlngPaperDownloadId;
}
else if (convPaperDownloadLog.DownloadFile  ==  AttributeName[intIndex])
{
return mstrDownloadFile;
}
else if (convPaperDownloadLog.DownloadLink  ==  AttributeName[intIndex])
{
return mstrDownloadLink;
}
else if (convPaperDownloadLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperDownloadLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaperDownloadLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperDownloadLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperDownloadLog.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperDownloadLog.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaperDownloadLog.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaperDownloadLog.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convPaperDownloadLog.PaperDownloadId  ==  AttributeName[intIndex])
{
mlngPaperDownloadId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperDownloadLog.PaperDownloadId);
}
else if (convPaperDownloadLog.DownloadFile  ==  AttributeName[intIndex])
{
mstrDownloadFile = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.DownloadFile);
}
else if (convPaperDownloadLog.DownloadLink  ==  AttributeName[intIndex])
{
mstrDownloadLink = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.DownloadLink);
}
else if (convPaperDownloadLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.PaperId);
}
else if (convPaperDownloadLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.UpdUser);
}
else if (convPaperDownloadLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.UpdDate);
}
else if (convPaperDownloadLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.Memo);
}
else if (convPaperDownloadLog.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.PaperTitle);
}
else if (convPaperDownloadLog.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.Author);
}
else if (convPaperDownloadLog.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.Keyword);
}
else if (convPaperDownloadLog.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperDownloadLog.UserName);
}
}
}

/// <summary>
/// PaperDownloadId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperDownloadId
{
get
{
return mlngPaperDownloadId;
}
set
{
 mlngPaperDownloadId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperDownloadLog.PaperDownloadId);
}
}
/// <summary>
/// DownloadFile(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DownloadFile
{
get
{
return mstrDownloadFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDownloadFile = value;
}
else
{
 mstrDownloadFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperDownloadLog.DownloadFile);
}
}
/// <summary>
/// DownloadLink(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DownloadLink
{
get
{
return mstrDownloadLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDownloadLink = value;
}
else
{
 mstrDownloadLink = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperDownloadLog.DownloadLink);
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
 AddUpdatedFld(convPaperDownloadLog.PaperId);
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
 AddUpdatedFld(convPaperDownloadLog.UpdUser);
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
 AddUpdatedFld(convPaperDownloadLog.UpdDate);
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
 AddUpdatedFld(convPaperDownloadLog.Memo);
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
 AddUpdatedFld(convPaperDownloadLog.PaperTitle);
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
 AddUpdatedFld(convPaperDownloadLog.Author);
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
 AddUpdatedFld(convPaperDownloadLog.Keyword);
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
 AddUpdatedFld(convPaperDownloadLog.UserName);
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
  return mlngPaperDownloadId.ToString();
 }
 }
}
 /// <summary>
 /// v论文下载记录(vPaperDownloadLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperDownloadLog
{
public const string _CurrTabName = "vPaperDownloadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperDownloadId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperDownloadId", "DownloadFile", "DownloadLink", "PaperId", "UpdUser", "UpdDate", "Memo", "PaperTitle", "Author", "Keyword", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperDownloadId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperDownloadId = "PaperDownloadId";    //PaperDownloadId

 /// <summary>
 /// 常量:"DownloadFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadFile = "DownloadFile";    //DownloadFile

 /// <summary>
 /// 常量:"DownloadLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadLink = "DownloadLink";    //DownloadLink

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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}
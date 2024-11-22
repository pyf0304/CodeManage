
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperDownloadLogEN
 表名:PaperDownloadLog(01120571)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:47
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
 /// 表PaperDownloadLog的关键字(PaperDownloadId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperDownloadId_PaperDownloadLog
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
public K_PaperDownloadId_PaperDownloadLog(long lngPaperDownloadId)
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
 /// <returns>返回:[K_PaperDownloadId_PaperDownloadLog]类型的对象</returns>
public static implicit operator K_PaperDownloadId_PaperDownloadLog(long value)
{
return new K_PaperDownloadId_PaperDownloadLog(value);
}
}
 /// <summary>
 /// 论文下载记录(PaperDownloadLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperDownloadLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperDownloadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperDownloadId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PaperDownloadId", "DownloadFile", "DownloadLink", "PaperId", "UpdUser", "UpdDate", "Memo"};

protected long mlngPaperDownloadId;    //PaperDownloadId
protected string mstrDownloadFile;    //DownloadFile
protected string mstrDownloadLink;    //DownloadLink
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperDownloadLogEN()
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
public clsPaperDownloadLogEN(long lngPaperDownloadId)
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
if (strAttributeName  ==  conPaperDownloadLog.PaperDownloadId)
{
return mlngPaperDownloadId;
}
else if (strAttributeName  ==  conPaperDownloadLog.DownloadFile)
{
return mstrDownloadFile;
}
else if (strAttributeName  ==  conPaperDownloadLog.DownloadLink)
{
return mstrDownloadLink;
}
else if (strAttributeName  ==  conPaperDownloadLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperDownloadLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperDownloadLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperDownloadLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperDownloadLog.PaperDownloadId)
{
mlngPaperDownloadId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperDownloadLog.PaperDownloadId);
}
else if (strAttributeName  ==  conPaperDownloadLog.DownloadFile)
{
mstrDownloadFile = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.DownloadFile);
}
else if (strAttributeName  ==  conPaperDownloadLog.DownloadLink)
{
mstrDownloadLink = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.DownloadLink);
}
else if (strAttributeName  ==  conPaperDownloadLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.PaperId);
}
else if (strAttributeName  ==  conPaperDownloadLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.UpdUser);
}
else if (strAttributeName  ==  conPaperDownloadLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.UpdDate);
}
else if (strAttributeName  ==  conPaperDownloadLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperDownloadLog.PaperDownloadId  ==  AttributeName[intIndex])
{
return mlngPaperDownloadId;
}
else if (conPaperDownloadLog.DownloadFile  ==  AttributeName[intIndex])
{
return mstrDownloadFile;
}
else if (conPaperDownloadLog.DownloadLink  ==  AttributeName[intIndex])
{
return mstrDownloadLink;
}
else if (conPaperDownloadLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperDownloadLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperDownloadLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperDownloadLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperDownloadLog.PaperDownloadId  ==  AttributeName[intIndex])
{
mlngPaperDownloadId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperDownloadLog.PaperDownloadId);
}
else if (conPaperDownloadLog.DownloadFile  ==  AttributeName[intIndex])
{
mstrDownloadFile = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.DownloadFile);
}
else if (conPaperDownloadLog.DownloadLink  ==  AttributeName[intIndex])
{
mstrDownloadLink = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.DownloadLink);
}
else if (conPaperDownloadLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.PaperId);
}
else if (conPaperDownloadLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.UpdUser);
}
else if (conPaperDownloadLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.UpdDate);
}
else if (conPaperDownloadLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperDownloadLog.Memo);
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
 AddUpdatedFld(conPaperDownloadLog.PaperDownloadId);
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
 AddUpdatedFld(conPaperDownloadLog.DownloadFile);
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
 AddUpdatedFld(conPaperDownloadLog.DownloadLink);
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
 AddUpdatedFld(conPaperDownloadLog.PaperId);
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
 AddUpdatedFld(conPaperDownloadLog.UpdUser);
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
 AddUpdatedFld(conPaperDownloadLog.UpdDate);
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
 AddUpdatedFld(conPaperDownloadLog.Memo);
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
 /// 论文下载记录(PaperDownloadLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperDownloadLog
{
public const string _CurrTabName = "PaperDownloadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperDownloadId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperDownloadId", "DownloadFile", "DownloadLink", "PaperId", "UpdUser", "UpdDate", "Memo"};
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
}

}
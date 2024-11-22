
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCount2EN
 表名:vPaperCount2(01120596)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:15
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
 /// 表vPaperCount2的关键字(PaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperId_vPaperCount2
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperId">表关键字</param>
public K_PaperId_vPaperCount2(string strPaperId)
{
if (IsValid(strPaperId)) Value = strPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true) return false;
if (strPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperId_vPaperCount2]类型的对象</returns>
public static implicit operator K_PaperId_vPaperCount2(string value)
{
return new K_PaperId_vPaperCount2(value);
}
}
 /// <summary>
 /// vPaperCount2(vPaperCount2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperCount2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperCount2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PaperId", "Pcount", "OkCount", "AppraiseCount", "CollectionCount", "DownloadCount", "Score", "AttachmentCount", "UpdUser"};

protected string mstrPaperId;    //论文Id
protected int? mintPcount;    //读写数
protected int? mintOkCount;    //点赞统计
protected int? mintAppraiseCount;    //评论数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintDownloadCount;    //下载数
protected float? mfltScore;    //评分
protected int? mintAttachmentCount;    //附件计数
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperCount2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperId">关键字:论文Id</param>
public clsvPaperCount2EN(string strPaperId)
 {
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("在表:vPaperCount2中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("在表:vPaperCount2中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperId = strPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
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
if (strAttributeName  ==  convPaperCount2.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperCount2.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  convPaperCount2.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convPaperCount2.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convPaperCount2.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convPaperCount2.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convPaperCount2.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convPaperCount2.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convPaperCount2.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperCount2.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperCount2.PaperId);
}
else if (strAttributeName  ==  convPaperCount2.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.Pcount);
}
else if (strAttributeName  ==  convPaperCount2.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.OkCount);
}
else if (strAttributeName  ==  convPaperCount2.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.AppraiseCount);
}
else if (strAttributeName  ==  convPaperCount2.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.CollectionCount);
}
else if (strAttributeName  ==  convPaperCount2.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.DownloadCount);
}
else if (strAttributeName  ==  convPaperCount2.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount2.Score);
}
else if (strAttributeName  ==  convPaperCount2.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.AttachmentCount);
}
else if (strAttributeName  ==  convPaperCount2.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperCount2.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperCount2.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperCount2.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (convPaperCount2.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convPaperCount2.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convPaperCount2.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convPaperCount2.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convPaperCount2.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convPaperCount2.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convPaperCount2.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convPaperCount2.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperCount2.PaperId);
}
else if (convPaperCount2.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.Pcount);
}
else if (convPaperCount2.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.OkCount);
}
else if (convPaperCount2.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.AppraiseCount);
}
else if (convPaperCount2.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.CollectionCount);
}
else if (convPaperCount2.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.DownloadCount);
}
else if (convPaperCount2.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount2.Score);
}
else if (convPaperCount2.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount2.AttachmentCount);
}
else if (convPaperCount2.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperCount2.UpdUser);
}
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
 AddUpdatedFld(convPaperCount2.PaperId);
}
}
/// <summary>
/// 读写数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Pcount
{
get
{
return mintPcount;
}
set
{
 mintPcount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.Pcount);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.OkCount);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.AppraiseCount);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.CollectionCount);
}
}
/// <summary>
/// 下载数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadCount
{
get
{
return mintDownloadCount;
}
set
{
 mintDownloadCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.DownloadCount);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.Score);
}
}
/// <summary>
/// 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AttachmentCount
{
get
{
return mintAttachmentCount;
}
set
{
 mintAttachmentCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount2.AttachmentCount);
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
 AddUpdatedFld(convPaperCount2.UpdUser);
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
  return mstrPaperId;
 }
 }
}
 /// <summary>
 /// vPaperCount2(vPaperCount2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperCount2
{
public const string _CurrTabName = "vPaperCount2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperId", "Pcount", "OkCount", "AppraiseCount", "CollectionCount", "DownloadCount", "Score", "AttachmentCount", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"Pcount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Pcount = "Pcount";    //读写数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"DownloadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadCount = "DownloadCount";    //下载数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}
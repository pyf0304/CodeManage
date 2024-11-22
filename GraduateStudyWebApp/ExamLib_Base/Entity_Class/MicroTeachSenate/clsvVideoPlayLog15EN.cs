﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoPlayLog15EN
 表名:vVideoPlayLog15(01120299)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vVideoPlayLog15的关键字(IdVideoPlayLog)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoPlayLog_vVideoPlayLog15
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdVideoPlayLog">表关键字</param>
public K_IdVideoPlayLog_vVideoPlayLog15(long lngIdVideoPlayLog)
{
if (IsValid(lngIdVideoPlayLog)) Value = lngIdVideoPlayLog;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdVideoPlayLog)
{
if (lngIdVideoPlayLog == 0) return false;
if (lngIdVideoPlayLog == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoPlayLog_vVideoPlayLog15]类型的对象</returns>
public static implicit operator K_IdVideoPlayLog_vVideoPlayLog15(long value)
{
return new K_IdVideoPlayLog_vVideoPlayLog15(value);
}
}
 /// <summary>
 /// v视频播放日志表15(vVideoPlayLog15)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoPlayLog15EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoPlayLog15"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoPlayLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdVideoPlayLog", "FuncModuleId", "FuncModuleNameSim", "IdCase", "VideoLibName", "VideoUrl", "CoverPicUrl", "LikeNum", "PlayNum", "UserId", "PlayDate", "Memo"};

protected long mlngIdVideoPlayLog;    //视频播放日志流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrIdCase;    //案例流水号
protected string mstrVideoLibName;    //视频名称
protected string mstrVideoUrl;    //视频Url
protected string mstrCoverPicUrl;    //封面Url
protected int? mintLikeNum;    //点赞数
protected int? mintPlayNum;    //播放数
protected string mstrUserId;    //用户ID
protected string mstrPlayDate;    //播放日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoPlayLog15EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoPlayLog");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdVideoPlayLog">关键字:视频播放日志流水号</param>
public clsvVideoPlayLog15EN(long lngIdVideoPlayLog)
 {
 if (lngIdVideoPlayLog  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdVideoPlayLog = lngIdVideoPlayLog;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoPlayLog");
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
if (strAttributeName  ==  convVideoPlayLog15.IdVideoPlayLog)
{
return mlngIdVideoPlayLog;
}
else if (strAttributeName  ==  convVideoPlayLog15.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoPlayLog15.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convVideoPlayLog15.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  convVideoPlayLog15.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  convVideoPlayLog15.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convVideoPlayLog15.CoverPicUrl)
{
return mstrCoverPicUrl;
}
else if (strAttributeName  ==  convVideoPlayLog15.LikeNum)
{
return mintLikeNum;
}
else if (strAttributeName  ==  convVideoPlayLog15.PlayNum)
{
return mintPlayNum;
}
else if (strAttributeName  ==  convVideoPlayLog15.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convVideoPlayLog15.PlayDate)
{
return mstrPlayDate;
}
else if (strAttributeName  ==  convVideoPlayLog15.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoPlayLog15.IdVideoPlayLog)
{
mlngIdVideoPlayLog = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoPlayLog15.IdVideoPlayLog);
}
else if (strAttributeName  ==  convVideoPlayLog15.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.FuncModuleId);
}
else if (strAttributeName  ==  convVideoPlayLog15.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.FuncModuleNameSim);
}
else if (strAttributeName  ==  convVideoPlayLog15.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.IdCase);
}
else if (strAttributeName  ==  convVideoPlayLog15.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.VideoLibName);
}
else if (strAttributeName  ==  convVideoPlayLog15.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.VideoUrl);
}
else if (strAttributeName  ==  convVideoPlayLog15.CoverPicUrl)
{
mstrCoverPicUrl = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.CoverPicUrl);
}
else if (strAttributeName  ==  convVideoPlayLog15.LikeNum)
{
mintLikeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoPlayLog15.LikeNum);
}
else if (strAttributeName  ==  convVideoPlayLog15.PlayNum)
{
mintPlayNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoPlayLog15.PlayNum);
}
else if (strAttributeName  ==  convVideoPlayLog15.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.UserId);
}
else if (strAttributeName  ==  convVideoPlayLog15.PlayDate)
{
mstrPlayDate = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.PlayDate);
}
else if (strAttributeName  ==  convVideoPlayLog15.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoPlayLog15.IdVideoPlayLog  ==  AttributeName[intIndex])
{
return mlngIdVideoPlayLog;
}
else if (convVideoPlayLog15.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoPlayLog15.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convVideoPlayLog15.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (convVideoPlayLog15.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (convVideoPlayLog15.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convVideoPlayLog15.CoverPicUrl  ==  AttributeName[intIndex])
{
return mstrCoverPicUrl;
}
else if (convVideoPlayLog15.LikeNum  ==  AttributeName[intIndex])
{
return mintLikeNum;
}
else if (convVideoPlayLog15.PlayNum  ==  AttributeName[intIndex])
{
return mintPlayNum;
}
else if (convVideoPlayLog15.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convVideoPlayLog15.PlayDate  ==  AttributeName[intIndex])
{
return mstrPlayDate;
}
else if (convVideoPlayLog15.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convVideoPlayLog15.IdVideoPlayLog  ==  AttributeName[intIndex])
{
mlngIdVideoPlayLog = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoPlayLog15.IdVideoPlayLog);
}
else if (convVideoPlayLog15.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.FuncModuleId);
}
else if (convVideoPlayLog15.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.FuncModuleNameSim);
}
else if (convVideoPlayLog15.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.IdCase);
}
else if (convVideoPlayLog15.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.VideoLibName);
}
else if (convVideoPlayLog15.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.VideoUrl);
}
else if (convVideoPlayLog15.CoverPicUrl  ==  AttributeName[intIndex])
{
mstrCoverPicUrl = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.CoverPicUrl);
}
else if (convVideoPlayLog15.LikeNum  ==  AttributeName[intIndex])
{
mintLikeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoPlayLog15.LikeNum);
}
else if (convVideoPlayLog15.PlayNum  ==  AttributeName[intIndex])
{
mintPlayNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoPlayLog15.PlayNum);
}
else if (convVideoPlayLog15.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.UserId);
}
else if (convVideoPlayLog15.PlayDate  ==  AttributeName[intIndex])
{
mstrPlayDate = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.PlayDate);
}
else if (convVideoPlayLog15.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoPlayLog15.Memo);
}
}
}

/// <summary>
/// 视频播放日志流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdVideoPlayLog
{
get
{
return mlngIdVideoPlayLog;
}
set
{
 mlngIdVideoPlayLog = value;
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.IdVideoPlayLog);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.FuncModuleId);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.FuncModuleNameSim);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.IdCase);
}
}
/// <summary>
/// 视频名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibName
{
get
{
return mstrVideoLibName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibName = value;
}
else
{
 mstrVideoLibName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.VideoLibName);
}
}
/// <summary>
/// 视频Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoUrl
{
get
{
return mstrVideoUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoUrl = value;
}
else
{
 mstrVideoUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.VideoUrl);
}
}
/// <summary>
/// 封面Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoverPicUrl
{
get
{
return mstrCoverPicUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoverPicUrl = value;
}
else
{
 mstrCoverPicUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.CoverPicUrl);
}
}
/// <summary>
/// 点赞数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LikeNum
{
get
{
return mintLikeNum;
}
set
{
 mintLikeNum = value;
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.LikeNum);
}
}
/// <summary>
/// 播放数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PlayNum
{
get
{
return mintPlayNum;
}
set
{
 mintPlayNum = value;
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.PlayNum);
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
 AddUpdatedFld(convVideoPlayLog15.UserId);
}
}
/// <summary>
/// 播放日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PlayDate
{
get
{
return mstrPlayDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPlayDate = value;
}
else
{
 mstrPlayDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoPlayLog15.PlayDate);
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
 AddUpdatedFld(convVideoPlayLog15.Memo);
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
  return mlngIdVideoPlayLog.ToString();
 }
 }
}
 /// <summary>
 /// v视频播放日志表15(vVideoPlayLog15)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoPlayLog15
{
public const string _CurrTabName = "vVideoPlayLog15"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoPlayLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoPlayLog", "FuncModuleId", "FuncModuleNameSim", "IdCase", "VideoLibName", "VideoUrl", "CoverPicUrl", "LikeNum", "PlayNum", "UserId", "PlayDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoPlayLog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoPlayLog = "IdVideoPlayLog";    //视频播放日志流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"VideoLibName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibName = "VideoLibName";    //视频名称

 /// <summary>
 /// 常量:"VideoUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoUrl = "VideoUrl";    //视频Url

 /// <summary>
 /// 常量:"CoverPicUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoverPicUrl = "CoverPicUrl";    //封面Url

 /// <summary>
 /// 常量:"LikeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeNum = "LikeNum";    //点赞数

 /// <summary>
 /// 常量:"PlayNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlayNum = "PlayNum";    //播放数

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"PlayDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlayDate = "PlayDate";    //播放日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLikeLogEN
 表名:VideoLikeLog(01120291)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:55
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
 /// 表VideoLikeLog的关键字(IdVideoLikeLog)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoLikeLog_VideoLikeLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdVideoLikeLog">表关键字</param>
public K_IdVideoLikeLog_VideoLikeLog(long lngIdVideoLikeLog)
{
if (IsValid(lngIdVideoLikeLog)) Value = lngIdVideoLikeLog;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdVideoLikeLog)
{
if (lngIdVideoLikeLog == 0) return false;
if (lngIdVideoLikeLog == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoLikeLog_VideoLikeLog]类型的对象</returns>
public static implicit operator K_IdVideoLikeLog_VideoLikeLog(long value)
{
return new K_IdVideoLikeLog_VideoLikeLog(value);
}
}
 /// <summary>
 /// 视频点赞日志(VideoLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoLikeLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoLikeLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdVideoLikeLog", "FuncModuleId", "UserId", "IdCase", "LikeDate", "LikeDegree", "Memo"};

protected long mlngIdVideoLikeLog;    //视频点赞日志流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrUserId;    //用户ID
protected string mstrIdCase;    //案例流水号
protected string mstrLikeDate;    //点赞日期
protected int? mintLikeDegree;    //点赞度
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoLikeLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoLikeLog");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdVideoLikeLog">关键字:视频点赞日志流水号</param>
public clsVideoLikeLogEN(long lngIdVideoLikeLog)
 {
 if (lngIdVideoLikeLog  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdVideoLikeLog = lngIdVideoLikeLog;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoLikeLog");
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
if (strAttributeName  ==  conVideoLikeLog.IdVideoLikeLog)
{
return mlngIdVideoLikeLog;
}
else if (strAttributeName  ==  conVideoLikeLog.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conVideoLikeLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conVideoLikeLog.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  conVideoLikeLog.LikeDate)
{
return mstrLikeDate;
}
else if (strAttributeName  ==  conVideoLikeLog.LikeDegree)
{
return mintLikeDegree;
}
else if (strAttributeName  ==  conVideoLikeLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoLikeLog.IdVideoLikeLog)
{
mlngIdVideoLikeLog = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLikeLog.IdVideoLikeLog);
}
else if (strAttributeName  ==  conVideoLikeLog.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conVideoLikeLog.FuncModuleId);
}
else if (strAttributeName  ==  conVideoLikeLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conVideoLikeLog.UserId);
}
else if (strAttributeName  ==  conVideoLikeLog.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conVideoLikeLog.IdCase);
}
else if (strAttributeName  ==  conVideoLikeLog.LikeDate)
{
mstrLikeDate = value.ToString();
 AddUpdatedFld(conVideoLikeLog.LikeDate);
}
else if (strAttributeName  ==  conVideoLikeLog.LikeDegree)
{
mintLikeDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLikeLog.LikeDegree);
}
else if (strAttributeName  ==  conVideoLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoLikeLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoLikeLog.IdVideoLikeLog  ==  AttributeName[intIndex])
{
return mlngIdVideoLikeLog;
}
else if (conVideoLikeLog.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conVideoLikeLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conVideoLikeLog.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (conVideoLikeLog.LikeDate  ==  AttributeName[intIndex])
{
return mstrLikeDate;
}
else if (conVideoLikeLog.LikeDegree  ==  AttributeName[intIndex])
{
return mintLikeDegree;
}
else if (conVideoLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoLikeLog.IdVideoLikeLog  ==  AttributeName[intIndex])
{
mlngIdVideoLikeLog = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLikeLog.IdVideoLikeLog);
}
else if (conVideoLikeLog.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conVideoLikeLog.FuncModuleId);
}
else if (conVideoLikeLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conVideoLikeLog.UserId);
}
else if (conVideoLikeLog.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conVideoLikeLog.IdCase);
}
else if (conVideoLikeLog.LikeDate  ==  AttributeName[intIndex])
{
mstrLikeDate = value.ToString();
 AddUpdatedFld(conVideoLikeLog.LikeDate);
}
else if (conVideoLikeLog.LikeDegree  ==  AttributeName[intIndex])
{
mintLikeDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLikeLog.LikeDegree);
}
else if (conVideoLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoLikeLog.Memo);
}
}
}

/// <summary>
/// 视频点赞日志流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdVideoLikeLog
{
get
{
return mlngIdVideoLikeLog;
}
set
{
 mlngIdVideoLikeLog = value;
//记录修改过的字段
 AddUpdatedFld(conVideoLikeLog.IdVideoLikeLog);
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
 AddUpdatedFld(conVideoLikeLog.FuncModuleId);
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
 AddUpdatedFld(conVideoLikeLog.UserId);
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
 AddUpdatedFld(conVideoLikeLog.IdCase);
}
}
/// <summary>
/// 点赞日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LikeDate
{
get
{
return mstrLikeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLikeDate = value;
}
else
{
 mstrLikeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoLikeLog.LikeDate);
}
}
/// <summary>
/// 点赞度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LikeDegree
{
get
{
return mintLikeDegree;
}
set
{
 mintLikeDegree = value;
//记录修改过的字段
 AddUpdatedFld(conVideoLikeLog.LikeDegree);
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
 AddUpdatedFld(conVideoLikeLog.Memo);
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
  return mlngIdVideoLikeLog.ToString();
 }
 }
}
 /// <summary>
 /// 视频点赞日志(VideoLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoLikeLog
{
public const string _CurrTabName = "VideoLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoLikeLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoLikeLog", "FuncModuleId", "UserId", "IdCase", "LikeDate", "LikeDegree", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoLikeLog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLikeLog = "IdVideoLikeLog";    //视频点赞日志流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"LikeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeDate = "LikeDate";    //点赞日期

 /// <summary>
 /// 常量:"LikeDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeDegree = "LikeDegree";    //点赞度

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
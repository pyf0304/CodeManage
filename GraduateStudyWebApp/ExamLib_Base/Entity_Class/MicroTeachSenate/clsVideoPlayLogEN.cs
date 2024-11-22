
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoPlayLogEN
 表名:VideoPlayLog(01120290)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:58
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
 /// 表VideoPlayLog的关键字(IdVideoPlayLog)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoPlayLog_VideoPlayLog
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
public K_IdVideoPlayLog_VideoPlayLog(long lngIdVideoPlayLog)
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
 /// <returns>返回:[K_IdVideoPlayLog_VideoPlayLog]类型的对象</returns>
public static implicit operator K_IdVideoPlayLog_VideoPlayLog(long value)
{
return new K_IdVideoPlayLog_VideoPlayLog(value);
}
}
 /// <summary>
 /// 视频播放日志(VideoPlayLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoPlayLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoPlayLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoPlayLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdVideoPlayLog", "FuncModuleId", "IdCase", "UserId", "PlayDate", "Memo"};

protected long mlngIdVideoPlayLog;    //视频播放日志流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdCase;    //案例流水号
protected string mstrUserId;    //用户ID
protected string mstrPlayDate;    //播放日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoPlayLogEN()
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
public clsVideoPlayLogEN(long lngIdVideoPlayLog)
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
if (strAttributeName  ==  conVideoPlayLog.IdVideoPlayLog)
{
return mlngIdVideoPlayLog;
}
else if (strAttributeName  ==  conVideoPlayLog.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conVideoPlayLog.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  conVideoPlayLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conVideoPlayLog.PlayDate)
{
return mstrPlayDate;
}
else if (strAttributeName  ==  conVideoPlayLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoPlayLog.IdVideoPlayLog)
{
mlngIdVideoPlayLog = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoPlayLog.IdVideoPlayLog);
}
else if (strAttributeName  ==  conVideoPlayLog.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conVideoPlayLog.FuncModuleId);
}
else if (strAttributeName  ==  conVideoPlayLog.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conVideoPlayLog.IdCase);
}
else if (strAttributeName  ==  conVideoPlayLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conVideoPlayLog.UserId);
}
else if (strAttributeName  ==  conVideoPlayLog.PlayDate)
{
mstrPlayDate = value.ToString();
 AddUpdatedFld(conVideoPlayLog.PlayDate);
}
else if (strAttributeName  ==  conVideoPlayLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoPlayLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoPlayLog.IdVideoPlayLog  ==  AttributeName[intIndex])
{
return mlngIdVideoPlayLog;
}
else if (conVideoPlayLog.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conVideoPlayLog.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (conVideoPlayLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conVideoPlayLog.PlayDate  ==  AttributeName[intIndex])
{
return mstrPlayDate;
}
else if (conVideoPlayLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoPlayLog.IdVideoPlayLog  ==  AttributeName[intIndex])
{
mlngIdVideoPlayLog = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoPlayLog.IdVideoPlayLog);
}
else if (conVideoPlayLog.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conVideoPlayLog.FuncModuleId);
}
else if (conVideoPlayLog.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conVideoPlayLog.IdCase);
}
else if (conVideoPlayLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conVideoPlayLog.UserId);
}
else if (conVideoPlayLog.PlayDate  ==  AttributeName[intIndex])
{
mstrPlayDate = value.ToString();
 AddUpdatedFld(conVideoPlayLog.PlayDate);
}
else if (conVideoPlayLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoPlayLog.Memo);
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
 AddUpdatedFld(conVideoPlayLog.IdVideoPlayLog);
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
 AddUpdatedFld(conVideoPlayLog.FuncModuleId);
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
 AddUpdatedFld(conVideoPlayLog.IdCase);
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
 AddUpdatedFld(conVideoPlayLog.UserId);
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
 AddUpdatedFld(conVideoPlayLog.PlayDate);
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
 AddUpdatedFld(conVideoPlayLog.Memo);
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
 /// 视频播放日志(VideoPlayLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoPlayLog
{
public const string _CurrTabName = "VideoPlayLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoPlayLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoPlayLog", "FuncModuleId", "IdCase", "UserId", "PlayDate", "Memo"};
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
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

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

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoCollectionLogEN
 表名:VideoCollectionLog(01120300)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:45
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
 /// 表VideoCollectionLog的关键字(IdVideoCollectionLog)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoCollectionLog_VideoCollectionLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdVideoCollectionLog">表关键字</param>
public K_IdVideoCollectionLog_VideoCollectionLog(long lngIdVideoCollectionLog)
{
if (IsValid(lngIdVideoCollectionLog)) Value = lngIdVideoCollectionLog;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdVideoCollectionLog)
{
if (lngIdVideoCollectionLog == 0) return false;
if (lngIdVideoCollectionLog == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoCollectionLog_VideoCollectionLog]类型的对象</returns>
public static implicit operator K_IdVideoCollectionLog_VideoCollectionLog(long value)
{
return new K_IdVideoCollectionLog_VideoCollectionLog(value);
}
}
 /// <summary>
 /// 视频收藏日志(VideoCollectionLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoCollectionLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoCollectionLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoCollectionLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdVideoCollectionLog", "FuncModuleId", "IdCase", "UserId", "CollectionDate", "Memo"};

protected long mlngIdVideoCollectionLog;    //视频收藏日志流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdCase;    //案例流水号
protected string mstrUserId;    //用户ID
protected string mstrCollectionDate;    //收藏日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoCollectionLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoCollectionLog");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdVideoCollectionLog">关键字:视频收藏日志流水号</param>
public clsVideoCollectionLogEN(long lngIdVideoCollectionLog)
 {
 if (lngIdVideoCollectionLog  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdVideoCollectionLog = lngIdVideoCollectionLog;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoCollectionLog");
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
if (strAttributeName  ==  conVideoCollectionLog.IdVideoCollectionLog)
{
return mlngIdVideoCollectionLog;
}
else if (strAttributeName  ==  conVideoCollectionLog.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conVideoCollectionLog.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  conVideoCollectionLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conVideoCollectionLog.CollectionDate)
{
return mstrCollectionDate;
}
else if (strAttributeName  ==  conVideoCollectionLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoCollectionLog.IdVideoCollectionLog)
{
mlngIdVideoCollectionLog = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoCollectionLog.IdVideoCollectionLog);
}
else if (strAttributeName  ==  conVideoCollectionLog.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.FuncModuleId);
}
else if (strAttributeName  ==  conVideoCollectionLog.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.IdCase);
}
else if (strAttributeName  ==  conVideoCollectionLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.UserId);
}
else if (strAttributeName  ==  conVideoCollectionLog.CollectionDate)
{
mstrCollectionDate = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.CollectionDate);
}
else if (strAttributeName  ==  conVideoCollectionLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoCollectionLog.IdVideoCollectionLog  ==  AttributeName[intIndex])
{
return mlngIdVideoCollectionLog;
}
else if (conVideoCollectionLog.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conVideoCollectionLog.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (conVideoCollectionLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conVideoCollectionLog.CollectionDate  ==  AttributeName[intIndex])
{
return mstrCollectionDate;
}
else if (conVideoCollectionLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoCollectionLog.IdVideoCollectionLog  ==  AttributeName[intIndex])
{
mlngIdVideoCollectionLog = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoCollectionLog.IdVideoCollectionLog);
}
else if (conVideoCollectionLog.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.FuncModuleId);
}
else if (conVideoCollectionLog.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.IdCase);
}
else if (conVideoCollectionLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.UserId);
}
else if (conVideoCollectionLog.CollectionDate  ==  AttributeName[intIndex])
{
mstrCollectionDate = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.CollectionDate);
}
else if (conVideoCollectionLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoCollectionLog.Memo);
}
}
}

/// <summary>
/// 视频收藏日志流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdVideoCollectionLog
{
get
{
return mlngIdVideoCollectionLog;
}
set
{
 mlngIdVideoCollectionLog = value;
//记录修改过的字段
 AddUpdatedFld(conVideoCollectionLog.IdVideoCollectionLog);
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
 AddUpdatedFld(conVideoCollectionLog.FuncModuleId);
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
 AddUpdatedFld(conVideoCollectionLog.IdCase);
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
 AddUpdatedFld(conVideoCollectionLog.UserId);
}
}
/// <summary>
/// 收藏日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollectionDate
{
get
{
return mstrCollectionDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollectionDate = value;
}
else
{
 mstrCollectionDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoCollectionLog.CollectionDate);
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
 AddUpdatedFld(conVideoCollectionLog.Memo);
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
  return mlngIdVideoCollectionLog.ToString();
 }
 }
}
 /// <summary>
 /// 视频收藏日志(VideoCollectionLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoCollectionLog
{
public const string _CurrTabName = "VideoCollectionLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoCollectionLog"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoCollectionLog", "FuncModuleId", "IdCase", "UserId", "CollectionDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoCollectionLog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoCollectionLog = "IdVideoCollectionLog";    //视频收藏日志流水号

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
 /// 常量:"CollectionDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionDate = "CollectionDate";    //收藏日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
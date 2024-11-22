
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperLikeLogEN
 表名:PaperLikeLog(01120566)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:25
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
 /// 表PaperLikeLog的关键字(PaperLikeLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperLikeLogId_PaperLikeLog
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
public K_PaperLikeLogId_PaperLikeLog(long lngPaperLikeLogId)
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
 /// <returns>返回:[K_PaperLikeLogId_PaperLikeLog]类型的对象</returns>
public static implicit operator K_PaperLikeLogId_PaperLikeLog(long value)
{
return new K_PaperLikeLogId_PaperLikeLog(value);
}
}
 /// <summary>
 /// 论文点赞表(PaperLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperLikeLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"PaperLikeLogId", "PaperId", "UpdUser", "UpdDate", "Memo"};

protected long mlngPaperLikeLogId;    //论文点赞表Id
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperLikeLogEN()
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
public clsPaperLikeLogEN(long lngPaperLikeLogId)
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
if (strAttributeName  ==  conPaperLikeLog.PaperLikeLogId)
{
return mlngPaperLikeLogId;
}
else if (strAttributeName  ==  conPaperLikeLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperLikeLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperLikeLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperLikeLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperLikeLog.PaperLikeLogId)
{
mlngPaperLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperLikeLog.PaperLikeLogId);
}
else if (strAttributeName  ==  conPaperLikeLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperLikeLog.PaperId);
}
else if (strAttributeName  ==  conPaperLikeLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperLikeLog.UpdUser);
}
else if (strAttributeName  ==  conPaperLikeLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperLikeLog.UpdDate);
}
else if (strAttributeName  ==  conPaperLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperLikeLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperLikeLog.PaperLikeLogId  ==  AttributeName[intIndex])
{
return mlngPaperLikeLogId;
}
else if (conPaperLikeLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperLikeLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperLikeLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperLikeLog.PaperLikeLogId  ==  AttributeName[intIndex])
{
mlngPaperLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperLikeLog.PaperLikeLogId);
}
else if (conPaperLikeLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperLikeLog.PaperId);
}
else if (conPaperLikeLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperLikeLog.UpdUser);
}
else if (conPaperLikeLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperLikeLog.UpdDate);
}
else if (conPaperLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperLikeLog.Memo);
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
 AddUpdatedFld(conPaperLikeLog.PaperLikeLogId);
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
 AddUpdatedFld(conPaperLikeLog.PaperId);
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
 AddUpdatedFld(conPaperLikeLog.UpdUser);
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
 AddUpdatedFld(conPaperLikeLog.UpdDate);
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
 AddUpdatedFld(conPaperLikeLog.Memo);
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
 /// 论文点赞表(PaperLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperLikeLog
{
public const string _CurrTabName = "PaperLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperLikeLogId", "PaperId", "UpdUser", "UpdDate", "Memo"};
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
}

}
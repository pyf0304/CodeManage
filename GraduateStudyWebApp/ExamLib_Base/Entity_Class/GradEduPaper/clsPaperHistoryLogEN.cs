
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperHistoryLogEN
 表名:PaperHistoryLog(01120580)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:20
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
 /// 表PaperHistoryLog的关键字(PaperHistoryLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperHistoryLogId_PaperHistoryLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperHistoryLogId">表关键字</param>
public K_PaperHistoryLogId_PaperHistoryLog(long lngPaperHistoryLogId)
{
if (IsValid(lngPaperHistoryLogId)) Value = lngPaperHistoryLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperHistoryLogId)
{
if (lngPaperHistoryLogId == 0) return false;
if (lngPaperHistoryLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperHistoryLogId_PaperHistoryLog]类型的对象</returns>
public static implicit operator K_PaperHistoryLogId_PaperHistoryLog(long value)
{
return new K_PaperHistoryLogId_PaperHistoryLog(value);
}
}
 /// <summary>
 /// 论文历史记录(PaperHistoryLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperHistoryLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperHistoryLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperHistoryLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"PaperHistoryLogId", "PaperId", "UpdUser", "UpdDate", "Meno"};

protected long mlngPaperHistoryLogId;    //PaperHistoryLogId
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperHistoryLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperHistoryLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperHistoryLogId">关键字:PaperHistoryLogId</param>
public clsPaperHistoryLogEN(long lngPaperHistoryLogId)
 {
 if (lngPaperHistoryLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperHistoryLogId = lngPaperHistoryLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperHistoryLogId");
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
if (strAttributeName  ==  conPaperHistoryLog.PaperHistoryLogId)
{
return mlngPaperHistoryLogId;
}
else if (strAttributeName  ==  conPaperHistoryLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperHistoryLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperHistoryLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperHistoryLog.Meno)
{
return mstrMeno;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperHistoryLog.PaperHistoryLogId)
{
mlngPaperHistoryLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperHistoryLog.PaperHistoryLogId);
}
else if (strAttributeName  ==  conPaperHistoryLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.PaperId);
}
else if (strAttributeName  ==  conPaperHistoryLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.UpdUser);
}
else if (strAttributeName  ==  conPaperHistoryLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.UpdDate);
}
else if (strAttributeName  ==  conPaperHistoryLog.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.Meno);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperHistoryLog.PaperHistoryLogId  ==  AttributeName[intIndex])
{
return mlngPaperHistoryLogId;
}
else if (conPaperHistoryLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperHistoryLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperHistoryLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperHistoryLog.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
return null;
}
set
{
if (conPaperHistoryLog.PaperHistoryLogId  ==  AttributeName[intIndex])
{
mlngPaperHistoryLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperHistoryLog.PaperHistoryLogId);
}
else if (conPaperHistoryLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.PaperId);
}
else if (conPaperHistoryLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.UpdUser);
}
else if (conPaperHistoryLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.UpdDate);
}
else if (conPaperHistoryLog.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(conPaperHistoryLog.Meno);
}
}
}

/// <summary>
/// PaperHistoryLogId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperHistoryLogId
{
get
{
return mlngPaperHistoryLogId;
}
set
{
 mlngPaperHistoryLogId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperHistoryLog.PaperHistoryLogId);
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
 AddUpdatedFld(conPaperHistoryLog.PaperId);
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
 AddUpdatedFld(conPaperHistoryLog.UpdUser);
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
 AddUpdatedFld(conPaperHistoryLog.UpdDate);
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
 AddUpdatedFld(conPaperHistoryLog.Meno);
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
  return mlngPaperHistoryLogId.ToString();
 }
 }
}
 /// <summary>
 /// 论文历史记录(PaperHistoryLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperHistoryLog
{
public const string _CurrTabName = "PaperHistoryLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperHistoryLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperHistoryLogId", "PaperId", "UpdUser", "UpdDate", "Meno"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperHistoryLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperHistoryLogId = "PaperHistoryLogId";    //PaperHistoryLogId

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
}

}
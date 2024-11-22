
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubResEN
 表名:PaperSubRes(01120963)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:52
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
 /// 表PaperSubRes的关键字(PaperSubResId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubResId_PaperSubRes
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperSubResId">表关键字</param>
public K_PaperSubResId_PaperSubRes(long lngPaperSubResId)
{
if (IsValid(lngPaperSubResId)) Value = lngPaperSubResId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperSubResId)
{
if (lngPaperSubResId == 0) return false;
if (lngPaperSubResId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperSubResId_PaperSubRes]类型的对象</returns>
public static implicit operator K_PaperSubResId_PaperSubRes(long value)
{
return new K_PaperSubResId_PaperSubRes(value);
}
}
 /// <summary>
 /// 论文子资源(PaperSubRes)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperSubResEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperSubRes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubResId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"PaperSubResId", "PaperSubResName", "PaperSubResTypeId", "FilePath", "IdCurrEduCls", "UpdUserId", "UpdDate", "Memo"};

protected long mlngPaperSubResId;    //论文子资源Id
protected string mstrPaperSubResName;    //子资源名称
protected string mstrPaperSubResTypeId;    //论文子资源类型Id
protected string mstrFilePath;    //文件路径
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperSubResEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubResId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperSubResId">关键字:论文子资源Id</param>
public clsPaperSubResEN(long lngPaperSubResId)
 {
 if (lngPaperSubResId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperSubResId = lngPaperSubResId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubResId");
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
if (strAttributeName  ==  conPaperSubRes.PaperSubResId)
{
return mlngPaperSubResId;
}
else if (strAttributeName  ==  conPaperSubRes.PaperSubResName)
{
return mstrPaperSubResName;
}
else if (strAttributeName  ==  conPaperSubRes.PaperSubResTypeId)
{
return mstrPaperSubResTypeId;
}
else if (strAttributeName  ==  conPaperSubRes.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conPaperSubRes.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conPaperSubRes.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPaperSubRes.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperSubRes.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperSubRes.PaperSubResId)
{
mlngPaperSubResId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubRes.PaperSubResId);
}
else if (strAttributeName  ==  conPaperSubRes.PaperSubResName)
{
mstrPaperSubResName = value.ToString();
 AddUpdatedFld(conPaperSubRes.PaperSubResName);
}
else if (strAttributeName  ==  conPaperSubRes.PaperSubResTypeId)
{
mstrPaperSubResTypeId = value.ToString();
 AddUpdatedFld(conPaperSubRes.PaperSubResTypeId);
}
else if (strAttributeName  ==  conPaperSubRes.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conPaperSubRes.FilePath);
}
else if (strAttributeName  ==  conPaperSubRes.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperSubRes.IdCurrEduCls);
}
else if (strAttributeName  ==  conPaperSubRes.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPaperSubRes.UpdUserId);
}
else if (strAttributeName  ==  conPaperSubRes.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubRes.UpdDate);
}
else if (strAttributeName  ==  conPaperSubRes.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubRes.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperSubRes.PaperSubResId  ==  AttributeName[intIndex])
{
return mlngPaperSubResId;
}
else if (conPaperSubRes.PaperSubResName  ==  AttributeName[intIndex])
{
return mstrPaperSubResName;
}
else if (conPaperSubRes.PaperSubResTypeId  ==  AttributeName[intIndex])
{
return mstrPaperSubResTypeId;
}
else if (conPaperSubRes.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conPaperSubRes.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conPaperSubRes.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPaperSubRes.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperSubRes.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperSubRes.PaperSubResId  ==  AttributeName[intIndex])
{
mlngPaperSubResId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubRes.PaperSubResId);
}
else if (conPaperSubRes.PaperSubResName  ==  AttributeName[intIndex])
{
mstrPaperSubResName = value.ToString();
 AddUpdatedFld(conPaperSubRes.PaperSubResName);
}
else if (conPaperSubRes.PaperSubResTypeId  ==  AttributeName[intIndex])
{
mstrPaperSubResTypeId = value.ToString();
 AddUpdatedFld(conPaperSubRes.PaperSubResTypeId);
}
else if (conPaperSubRes.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conPaperSubRes.FilePath);
}
else if (conPaperSubRes.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperSubRes.IdCurrEduCls);
}
else if (conPaperSubRes.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPaperSubRes.UpdUserId);
}
else if (conPaperSubRes.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubRes.UpdDate);
}
else if (conPaperSubRes.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubRes.Memo);
}
}
}

/// <summary>
/// 论文子资源Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperSubResId
{
get
{
return mlngPaperSubResId;
}
set
{
 mlngPaperSubResId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubRes.PaperSubResId);
}
}
/// <summary>
/// 子资源名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperSubResName
{
get
{
return mstrPaperSubResName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperSubResName = value;
}
else
{
 mstrPaperSubResName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubRes.PaperSubResName);
}
}
/// <summary>
/// 论文子资源类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperSubResTypeId
{
get
{
return mstrPaperSubResTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperSubResTypeId = value;
}
else
{
 mstrPaperSubResTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubRes.PaperSubResTypeId);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubRes.FilePath);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubRes.IdCurrEduCls);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubRes.UpdUserId);
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
 AddUpdatedFld(conPaperSubRes.UpdDate);
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
 AddUpdatedFld(conPaperSubRes.Memo);
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
  return mlngPaperSubResId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrPaperSubResName;
 }
 }
}
 /// <summary>
 /// 论文子资源(PaperSubRes)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperSubRes
{
public const string _CurrTabName = "PaperSubRes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubResId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubResId", "PaperSubResName", "PaperSubResTypeId", "FilePath", "IdCurrEduCls", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperSubResId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubResId = "PaperSubResId";    //论文子资源Id

 /// <summary>
 /// 常量:"PaperSubResName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubResName = "PaperSubResName";    //子资源名称

 /// <summary>
 /// 常量:"PaperSubResTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubResTypeId = "PaperSubResTypeId";    //论文子资源类型Id

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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
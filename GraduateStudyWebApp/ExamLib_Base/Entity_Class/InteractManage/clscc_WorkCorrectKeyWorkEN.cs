
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkCorrectKeyWorkEN
 表名:cc_WorkCorrectKeyWork(01120190)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表cc_WorkCorrectKeyWork的关键字(IdWorkCorrectKeyWork)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkCorrectKeyWork_cc_WorkCorrectKeyWork
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdWorkCorrectKeyWork">表关键字</param>
public K_IdWorkCorrectKeyWork_cc_WorkCorrectKeyWork(long lngIdWorkCorrectKeyWork)
{
if (IsValid(lngIdWorkCorrectKeyWork)) Value = lngIdWorkCorrectKeyWork;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdWorkCorrectKeyWork)
{
if (lngIdWorkCorrectKeyWork == 0) return false;
if (lngIdWorkCorrectKeyWork == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWorkCorrectKeyWork_cc_WorkCorrectKeyWork]类型的对象</returns>
public static implicit operator K_IdWorkCorrectKeyWork_cc_WorkCorrectKeyWork(long value)
{
return new K_IdWorkCorrectKeyWork_cc_WorkCorrectKeyWork(value);
}
}
 /// <summary>
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_WorkCorrectKeyWorkEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_WorkCorrectKeyWork"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkCorrectKeyWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdWorkCorrectKeyWork", "QuestionID", "KeyWorkIndex", "CorrectKeyWork", "IsUseFormatPara", "FormatPara", "InOutTypeId", "Creator", "CreateDate", "IsEnable", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdWorkCorrectKeyWork;    //作业批改关键词流水号
protected string mstrQuestionID;    //题目ID
protected int? mintKeyWorkIndex;    //关键字序号
protected string mstrCorrectKeyWork;    //批改关键词
protected bool mbolIsUseFormatPara;    //是否使用格式化参数
protected string mstrFormatPara;    //格式化参数
protected string mstrInOutTypeId;    //InOut类型Id
protected string mstrCreator;    //创建者
protected string mstrCreateDate;    //建立日期
protected bool mbolIsEnable;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_WorkCorrectKeyWorkEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkCorrectKeyWork");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdWorkCorrectKeyWork">关键字:作业批改关键词流水号</param>
public clscc_WorkCorrectKeyWorkEN(long lngIdWorkCorrectKeyWork)
 {
 if (lngIdWorkCorrectKeyWork  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdWorkCorrectKeyWork = lngIdWorkCorrectKeyWork;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkCorrectKeyWork");
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
if (strAttributeName  ==  concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork)
{
return mlngIdWorkCorrectKeyWork;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.KeyWorkIndex)
{
return mintKeyWorkIndex;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.CorrectKeyWork)
{
return mstrCorrectKeyWork;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.IsUseFormatPara)
{
return mbolIsUseFormatPara;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.FormatPara)
{
return mstrFormatPara;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.Creator)
{
return mstrCreator;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.IsEnable)
{
return mbolIsEnable;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork)
{
mlngIdWorkCorrectKeyWork = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.QuestionID);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.KeyWorkIndex)
{
mintKeyWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.KeyWorkIndex);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.CorrectKeyWork)
{
mstrCorrectKeyWork = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.CorrectKeyWork);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.IsUseFormatPara)
{
mbolIsUseFormatPara = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.IsUseFormatPara);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.FormatPara)
{
mstrFormatPara = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.FormatPara);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.InOutTypeId);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.Creator)
{
mstrCreator = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.Creator);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.CreateDate);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.IsEnable)
{
mbolIsEnable = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.IsEnable);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.UpdDate);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.UpdUser);
}
else if (strAttributeName  ==  concc_WorkCorrectKeyWork.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork  ==  AttributeName[intIndex])
{
return mlngIdWorkCorrectKeyWork;
}
else if (concc_WorkCorrectKeyWork.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (concc_WorkCorrectKeyWork.KeyWorkIndex  ==  AttributeName[intIndex])
{
return mintKeyWorkIndex;
}
else if (concc_WorkCorrectKeyWork.CorrectKeyWork  ==  AttributeName[intIndex])
{
return mstrCorrectKeyWork;
}
else if (concc_WorkCorrectKeyWork.IsUseFormatPara  ==  AttributeName[intIndex])
{
return mbolIsUseFormatPara;
}
else if (concc_WorkCorrectKeyWork.FormatPara  ==  AttributeName[intIndex])
{
return mstrFormatPara;
}
else if (concc_WorkCorrectKeyWork.InOutTypeId  ==  AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (concc_WorkCorrectKeyWork.Creator  ==  AttributeName[intIndex])
{
return mstrCreator;
}
else if (concc_WorkCorrectKeyWork.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (concc_WorkCorrectKeyWork.IsEnable  ==  AttributeName[intIndex])
{
return mbolIsEnable;
}
else if (concc_WorkCorrectKeyWork.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_WorkCorrectKeyWork.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_WorkCorrectKeyWork.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork  ==  AttributeName[intIndex])
{
mlngIdWorkCorrectKeyWork = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork);
}
else if (concc_WorkCorrectKeyWork.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.QuestionID);
}
else if (concc_WorkCorrectKeyWork.KeyWorkIndex  ==  AttributeName[intIndex])
{
mintKeyWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.KeyWorkIndex);
}
else if (concc_WorkCorrectKeyWork.CorrectKeyWork  ==  AttributeName[intIndex])
{
mstrCorrectKeyWork = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.CorrectKeyWork);
}
else if (concc_WorkCorrectKeyWork.IsUseFormatPara  ==  AttributeName[intIndex])
{
mbolIsUseFormatPara = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.IsUseFormatPara);
}
else if (concc_WorkCorrectKeyWork.FormatPara  ==  AttributeName[intIndex])
{
mstrFormatPara = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.FormatPara);
}
else if (concc_WorkCorrectKeyWork.InOutTypeId  ==  AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.InOutTypeId);
}
else if (concc_WorkCorrectKeyWork.Creator  ==  AttributeName[intIndex])
{
mstrCreator = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.Creator);
}
else if (concc_WorkCorrectKeyWork.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.CreateDate);
}
else if (concc_WorkCorrectKeyWork.IsEnable  ==  AttributeName[intIndex])
{
mbolIsEnable = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkCorrectKeyWork.IsEnable);
}
else if (concc_WorkCorrectKeyWork.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.UpdDate);
}
else if (concc_WorkCorrectKeyWork.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.UpdUser);
}
else if (concc_WorkCorrectKeyWork.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkCorrectKeyWork.Memo);
}
}
}

/// <summary>
/// 作业批改关键词流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdWorkCorrectKeyWork
{
get
{
return mlngIdWorkCorrectKeyWork;
}
set
{
 mlngIdWorkCorrectKeyWork = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork);
}
}
/// <summary>
/// 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionID
{
get
{
return mstrQuestionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionID = value;
}
else
{
 mstrQuestionID = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.QuestionID);
}
}
/// <summary>
/// 关键字序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? KeyWorkIndex
{
get
{
return mintKeyWorkIndex;
}
set
{
 mintKeyWorkIndex = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.KeyWorkIndex);
}
}
/// <summary>
/// 批改关键词(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CorrectKeyWork
{
get
{
return mstrCorrectKeyWork;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCorrectKeyWork = value;
}
else
{
 mstrCorrectKeyWork = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.CorrectKeyWork);
}
}
/// <summary>
/// 是否使用格式化参数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseFormatPara
{
get
{
return mbolIsUseFormatPara;
}
set
{
 mbolIsUseFormatPara = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.IsUseFormatPara);
}
}
/// <summary>
/// 格式化参数(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FormatPara
{
get
{
return mstrFormatPara;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFormatPara = value;
}
else
{
 mstrFormatPara = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.FormatPara);
}
}
/// <summary>
/// InOut类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeId
{
get
{
return mstrInOutTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeId = value;
}
else
{
 mstrInOutTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.InOutTypeId);
}
}
/// <summary>
/// 创建者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Creator
{
get
{
return mstrCreator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreator = value;
}
else
{
 mstrCreator = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.Creator);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.CreateDate);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEnable
{
get
{
return mbolIsEnable;
}
set
{
 mbolIsEnable = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkCorrectKeyWork.IsEnable);
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
 AddUpdatedFld(concc_WorkCorrectKeyWork.UpdDate);
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
 AddUpdatedFld(concc_WorkCorrectKeyWork.UpdUser);
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
 AddUpdatedFld(concc_WorkCorrectKeyWork.Memo);
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
  return mlngIdWorkCorrectKeyWork.ToString();
 }
 }
}
 /// <summary>
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_WorkCorrectKeyWork
{
public const string _CurrTabName = "cc_WorkCorrectKeyWork"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkCorrectKeyWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkCorrectKeyWork", "QuestionID", "KeyWorkIndex", "CorrectKeyWork", "IsUseFormatPara", "FormatPara", "InOutTypeId", "Creator", "CreateDate", "IsEnable", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWorkCorrectKeyWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWorkCorrectKeyWork = "IdWorkCorrectKeyWork";    //作业批改关键词流水号

 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

 /// <summary>
 /// 常量:"KeyWorkIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWorkIndex = "KeyWorkIndex";    //关键字序号

 /// <summary>
 /// 常量:"CorrectKeyWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CorrectKeyWork = "CorrectKeyWork";    //批改关键词

 /// <summary>
 /// 常量:"IsUseFormatPara"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseFormatPara = "IsUseFormatPara";    //是否使用格式化参数

 /// <summary>
 /// 常量:"FormatPara"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FormatPara = "FormatPara";    //格式化参数

 /// <summary>
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //InOut类型Id

 /// <summary>
 /// 常量:"Creator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Creator = "Creator";    //创建者

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"IsEnable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEnable = "IsEnable";    //是否启用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
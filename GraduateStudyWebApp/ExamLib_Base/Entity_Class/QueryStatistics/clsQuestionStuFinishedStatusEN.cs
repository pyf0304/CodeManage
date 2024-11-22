
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionStuFinishedStatusEN
 表名:QuestionStuFinishedStatus(01120217)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表QuestionStuFinishedStatus的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QuestionStuFinishedStatus
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_QuestionStuFinishedStatus(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_QuestionStuFinishedStatus]类型的对象</returns>
public static implicit operator K_mId_QuestionStuFinishedStatus(long value)
{
return new K_mId_QuestionStuFinishedStatus(value);
}
}
 /// <summary>
 /// 题目学生完成状态(QuestionStuFinishedStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionStuFinishedStatusEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionStuFinishedStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "IdStudentInfo", "SubmitedNum", "AllQuestionNum", "MarkedNum", "NoMarkNum", "NoSubmitedNum"};

protected long mlngmId;    //mId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrIdStudentInfo;    //学生流水号
protected int mintSubmitedNum;    //提交作业数
protected int mintAllQuestionNum;    //所有题目数
protected int? mintMarkedNum;    //已批改数
protected int? mintNoMarkNum;    //未批改数
protected int? mintNoSubmitedNum;    //未提交作业数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionStuFinishedStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsQuestionStuFinishedStatusEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conQuestionStuFinishedStatus.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.SubmitedNum)
{
return mintSubmitedNum;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.AllQuestionNum)
{
return mintAllQuestionNum;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.MarkedNum)
{
return mintMarkedNum;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.NoMarkNum)
{
return mintNoMarkNum;
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.NoSubmitedNum)
{
return mintNoSubmitedNum;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionStuFinishedStatus.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.mId);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conQuestionStuFinishedStatus.IdCurrEduCls);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(conQuestionStuFinishedStatus.IdStudentInfo);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.SubmitedNum)
{
mintSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.SubmitedNum);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.AllQuestionNum)
{
mintAllQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.AllQuestionNum);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.MarkedNum)
{
mintMarkedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.MarkedNum);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.NoMarkNum)
{
mintNoMarkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.NoMarkNum);
}
else if (strAttributeName  ==  conQuestionStuFinishedStatus.NoSubmitedNum)
{
mintNoSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.NoSubmitedNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionStuFinishedStatus.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQuestionStuFinishedStatus.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conQuestionStuFinishedStatus.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (conQuestionStuFinishedStatus.SubmitedNum  ==  AttributeName[intIndex])
{
return mintSubmitedNum;
}
else if (conQuestionStuFinishedStatus.AllQuestionNum  ==  AttributeName[intIndex])
{
return mintAllQuestionNum;
}
else if (conQuestionStuFinishedStatus.MarkedNum  ==  AttributeName[intIndex])
{
return mintMarkedNum;
}
else if (conQuestionStuFinishedStatus.NoMarkNum  ==  AttributeName[intIndex])
{
return mintNoMarkNum;
}
else if (conQuestionStuFinishedStatus.NoSubmitedNum  ==  AttributeName[intIndex])
{
return mintNoSubmitedNum;
}
return null;
}
set
{
if (conQuestionStuFinishedStatus.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.mId);
}
else if (conQuestionStuFinishedStatus.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conQuestionStuFinishedStatus.IdCurrEduCls);
}
else if (conQuestionStuFinishedStatus.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(conQuestionStuFinishedStatus.IdStudentInfo);
}
else if (conQuestionStuFinishedStatus.SubmitedNum  ==  AttributeName[intIndex])
{
mintSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.SubmitedNum);
}
else if (conQuestionStuFinishedStatus.AllQuestionNum  ==  AttributeName[intIndex])
{
mintAllQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.AllQuestionNum);
}
else if (conQuestionStuFinishedStatus.MarkedNum  ==  AttributeName[intIndex])
{
mintMarkedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.MarkedNum);
}
else if (conQuestionStuFinishedStatus.NoMarkNum  ==  AttributeName[intIndex])
{
mintNoMarkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.NoMarkNum);
}
else if (conQuestionStuFinishedStatus.NoSubmitedNum  ==  AttributeName[intIndex])
{
mintNoSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionStuFinishedStatus.NoSubmitedNum);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.mId);
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
 AddUpdatedFld(conQuestionStuFinishedStatus.IdCurrEduCls);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.IdStudentInfo);
}
}
/// <summary>
/// 提交作业数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SubmitedNum
{
get
{
return mintSubmitedNum;
}
set
{
 mintSubmitedNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.SubmitedNum);
}
}
/// <summary>
/// 所有题目数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int AllQuestionNum
{
get
{
return mintAllQuestionNum;
}
set
{
 mintAllQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.AllQuestionNum);
}
}
/// <summary>
/// 已批改数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MarkedNum
{
get
{
return mintMarkedNum;
}
set
{
 mintMarkedNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.MarkedNum);
}
}
/// <summary>
/// 未批改数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoMarkNum
{
get
{
return mintNoMarkNum;
}
set
{
 mintNoMarkNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.NoMarkNum);
}
}
/// <summary>
/// 未提交作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoSubmitedNum
{
get
{
return mintNoSubmitedNum;
}
set
{
 mintNoSubmitedNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionStuFinishedStatus.NoSubmitedNum);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 题目学生完成状态(QuestionStuFinishedStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionStuFinishedStatus
{
public const string _CurrTabName = "QuestionStuFinishedStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "IdStudentInfo", "SubmitedNum", "AllQuestionNum", "MarkedNum", "NoMarkNum", "NoSubmitedNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"SubmitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitedNum = "SubmitedNum";    //提交作业数

 /// <summary>
 /// 常量:"AllQuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllQuestionNum = "AllQuestionNum";    //所有题目数

 /// <summary>
 /// 常量:"MarkedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkedNum = "MarkedNum";    //已批改数

 /// <summary>
 /// 常量:"NoMarkNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoMarkNum = "NoMarkNum";    //未批改数

 /// <summary>
 /// 常量:"NoSubmitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoSubmitedNum = "NoSubmitedNum";    //未提交作业数
}

}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkEN
 表名:cc_Work(01120144)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表cc_Work的关键字(IdWork)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWork_cc_Work
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdWork">表关键字</param>
public K_IdWork_cc_Work(string strIdWork)
{
if (IsValid(strIdWork)) Value = strIdWork;
else
{
Value = null;
}
}
private static bool IsValid(string strIdWork)
{
if (string.IsNullOrEmpty(strIdWork) == true) return false;
if (strIdWork.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWork_cc_Work]类型的对象</returns>
public static implicit operator K_IdWork_cc_Work(string value)
{
return new K_IdWork_cc_Work(value);
}
}
 /// <summary>
 /// 作业(cc_Work)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_WorkEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_Work"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdWork", "WorkIndex", "WorkName", "WorkDesc", "CourseId", "CourseChapterId", "Creator", "CreateDate", "AnswerAttLimitSize", "LimitedResourceType", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdWork;    //作业流水号
protected int? mintWorkIndex;    //作业序号
protected string mstrWorkName;    //作业名称
protected string mstrWorkDesc;    //作业说明
protected string mstrCourseId;    //课程Id
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCreator;    //创建者
protected string mstrCreateDate;    //建立日期
protected long? mlngAnswerAttLimitSize;    //回答附件限制大小
protected string mstrLimitedResourceType;    //限制资源类型
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_WorkEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWork");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdWork">关键字:作业流水号</param>
public clscc_WorkEN(string strIdWork)
 {
strIdWork = strIdWork.Replace("'", "''");
if (strIdWork.Length > 8)
{
throw new Exception("在表:cc_Work中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdWork)  ==  true)
{
throw new Exception("在表:cc_Work中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWork);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdWork = strIdWork;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWork");
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
if (strAttributeName  ==  concc_Work.IdWork)
{
return mstrIdWork;
}
else if (strAttributeName  ==  concc_Work.WorkIndex)
{
return mintWorkIndex;
}
else if (strAttributeName  ==  concc_Work.WorkName)
{
return mstrWorkName;
}
else if (strAttributeName  ==  concc_Work.WorkDesc)
{
return mstrWorkDesc;
}
else if (strAttributeName  ==  concc_Work.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_Work.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  concc_Work.Creator)
{
return mstrCreator;
}
else if (strAttributeName  ==  concc_Work.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  concc_Work.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  concc_Work.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  concc_Work.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_Work.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_Work.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_Work.IdWork)
{
mstrIdWork = value.ToString();
 AddUpdatedFld(concc_Work.IdWork);
}
else if (strAttributeName  ==  concc_Work.WorkIndex)
{
mintWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Work.WorkIndex);
}
else if (strAttributeName  ==  concc_Work.WorkName)
{
mstrWorkName = value.ToString();
 AddUpdatedFld(concc_Work.WorkName);
}
else if (strAttributeName  ==  concc_Work.WorkDesc)
{
mstrWorkDesc = value.ToString();
 AddUpdatedFld(concc_Work.WorkDesc);
}
else if (strAttributeName  ==  concc_Work.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_Work.CourseId);
}
else if (strAttributeName  ==  concc_Work.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_Work.CourseChapterId);
}
else if (strAttributeName  ==  concc_Work.Creator)
{
mstrCreator = value.ToString();
 AddUpdatedFld(concc_Work.Creator);
}
else if (strAttributeName  ==  concc_Work.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_Work.CreateDate);
}
else if (strAttributeName  ==  concc_Work.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Work.AnswerAttLimitSize);
}
else if (strAttributeName  ==  concc_Work.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(concc_Work.LimitedResourceType);
}
else if (strAttributeName  ==  concc_Work.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Work.UpdDate);
}
else if (strAttributeName  ==  concc_Work.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Work.UpdUserId);
}
else if (strAttributeName  ==  concc_Work.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Work.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_Work.IdWork  ==  AttributeName[intIndex])
{
return mstrIdWork;
}
else if (concc_Work.WorkIndex  ==  AttributeName[intIndex])
{
return mintWorkIndex;
}
else if (concc_Work.WorkName  ==  AttributeName[intIndex])
{
return mstrWorkName;
}
else if (concc_Work.WorkDesc  ==  AttributeName[intIndex])
{
return mstrWorkDesc;
}
else if (concc_Work.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_Work.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (concc_Work.Creator  ==  AttributeName[intIndex])
{
return mstrCreator;
}
else if (concc_Work.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (concc_Work.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (concc_Work.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (concc_Work.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_Work.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_Work.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_Work.IdWork  ==  AttributeName[intIndex])
{
mstrIdWork = value.ToString();
 AddUpdatedFld(concc_Work.IdWork);
}
else if (concc_Work.WorkIndex  ==  AttributeName[intIndex])
{
mintWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Work.WorkIndex);
}
else if (concc_Work.WorkName  ==  AttributeName[intIndex])
{
mstrWorkName = value.ToString();
 AddUpdatedFld(concc_Work.WorkName);
}
else if (concc_Work.WorkDesc  ==  AttributeName[intIndex])
{
mstrWorkDesc = value.ToString();
 AddUpdatedFld(concc_Work.WorkDesc);
}
else if (concc_Work.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_Work.CourseId);
}
else if (concc_Work.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_Work.CourseChapterId);
}
else if (concc_Work.Creator  ==  AttributeName[intIndex])
{
mstrCreator = value.ToString();
 AddUpdatedFld(concc_Work.Creator);
}
else if (concc_Work.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_Work.CreateDate);
}
else if (concc_Work.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Work.AnswerAttLimitSize);
}
else if (concc_Work.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(concc_Work.LimitedResourceType);
}
else if (concc_Work.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Work.UpdDate);
}
else if (concc_Work.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Work.UpdUserId);
}
else if (concc_Work.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Work.Memo);
}
}
}

/// <summary>
/// 作业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWork
{
get
{
return mstrIdWork;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWork = value;
}
else
{
 mstrIdWork = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Work.IdWork);
}
}
/// <summary>
/// 作业序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkIndex
{
get
{
return mintWorkIndex;
}
set
{
 mintWorkIndex = value;
//记录修改过的字段
 AddUpdatedFld(concc_Work.WorkIndex);
}
}
/// <summary>
/// 作业名称(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkName
{
get
{
return mstrWorkName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkName = value;
}
else
{
 mstrWorkName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Work.WorkName);
}
}
/// <summary>
/// 作业说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkDesc
{
get
{
return mstrWorkDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkDesc = value;
}
else
{
 mstrWorkDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Work.WorkDesc);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Work.CourseId);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Work.CourseChapterId);
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
 AddUpdatedFld(concc_Work.Creator);
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
 AddUpdatedFld(concc_Work.CreateDate);
}
}
/// <summary>
/// 回答附件限制大小(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? AnswerAttLimitSize
{
get
{
return mlngAnswerAttLimitSize;
}
set
{
 mlngAnswerAttLimitSize = value;
//记录修改过的字段
 AddUpdatedFld(concc_Work.AnswerAttLimitSize);
}
}
/// <summary>
/// 限制资源类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LimitedResourceType
{
get
{
return mstrLimitedResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLimitedResourceType = value;
}
else
{
 mstrLimitedResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Work.LimitedResourceType);
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
 AddUpdatedFld(concc_Work.UpdDate);
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
 AddUpdatedFld(concc_Work.UpdUserId);
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
 AddUpdatedFld(concc_Work.Memo);
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
  return mstrIdWork;
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
  return mstrWorkName;
 }
 }
}
 /// <summary>
 /// 作业(cc_Work)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_Work
{
public const string _CurrTabName = "cc_Work"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWork", "WorkIndex", "WorkName", "WorkDesc", "CourseId", "CourseChapterId", "Creator", "CreateDate", "AnswerAttLimitSize", "LimitedResourceType", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWork = "IdWork";    //作业流水号

 /// <summary>
 /// 常量:"WorkIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkIndex = "WorkIndex";    //作业序号

 /// <summary>
 /// 常量:"WorkName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkName = "WorkName";    //作业名称

 /// <summary>
 /// 常量:"WorkDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkDesc = "WorkDesc";    //作业说明

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

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
 /// 常量:"AnswerAttLimitSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerAttLimitSize = "AnswerAttLimitSize";    //回答附件限制大小

 /// <summary>
 /// 常量:"LimitedResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LimitedResourceType = "LimitedResourceType";    //限制资源类型

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}
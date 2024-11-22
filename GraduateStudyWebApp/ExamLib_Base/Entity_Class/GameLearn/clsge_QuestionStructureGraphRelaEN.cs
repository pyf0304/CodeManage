
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_QuestionStructureGraphRelaEN
 表名:ge_QuestionStructureGraphRela(01120906)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_QuestionStructureGraphRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_QuestionStructureGraphRela
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
public K_mId_ge_QuestionStructureGraphRela(long lngmId)
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
 /// <returns>返回:[K_mId_ge_QuestionStructureGraphRela]类型的对象</returns>
public static implicit operator K_mId_ge_QuestionStructureGraphRela(long value)
{
return new K_mId_ge_QuestionStructureGraphRela(value);
}
}
 /// <summary>
 /// 问题结构图关系(ge_QuestionStructureGraphRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_QuestionStructureGraphRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_QuestionStructureGraphRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "QuestionId", "StructureGraphId", "CourseId", "CreateUser", "UpdDate", "UpdUser", "Memo", "GameLevelId"};

protected long mlngmId;    //mId
protected long mlngQuestionId;    //题目Id
protected string mstrStructureGraphId;    //知识图谱Id
protected string mstrCourseId;    //课程Id
protected string mstrCreateUser;    //建立用户
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrGameLevelId;    //游戏关卡Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_QuestionStructureGraphRelaEN()
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
public clsge_QuestionStructureGraphRelaEN(long lngmId)
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
if (strAttributeName  ==  conge_QuestionStructureGraphRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.StructureGraphId)
{
return mstrStructureGraphId;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.GameLevelId)
{
return mstrGameLevelId;
}
return null;
}
set
{
if (strAttributeName  ==  conge_QuestionStructureGraphRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_QuestionStructureGraphRela.mId);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_QuestionStructureGraphRela.QuestionId);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.StructureGraphId)
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.StructureGraphId);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.CourseId);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.CreateUser);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.UpdDate);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.UpdUser);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.Memo);
}
else if (strAttributeName  ==  conge_QuestionStructureGraphRela.GameLevelId)
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.GameLevelId);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_QuestionStructureGraphRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_QuestionStructureGraphRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conge_QuestionStructureGraphRela.StructureGraphId  ==  AttributeName[intIndex])
{
return mstrStructureGraphId;
}
else if (conge_QuestionStructureGraphRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_QuestionStructureGraphRela.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (conge_QuestionStructureGraphRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_QuestionStructureGraphRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_QuestionStructureGraphRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_QuestionStructureGraphRela.GameLevelId  ==  AttributeName[intIndex])
{
return mstrGameLevelId;
}
return null;
}
set
{
if (conge_QuestionStructureGraphRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_QuestionStructureGraphRela.mId);
}
else if (conge_QuestionStructureGraphRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_QuestionStructureGraphRela.QuestionId);
}
else if (conge_QuestionStructureGraphRela.StructureGraphId  ==  AttributeName[intIndex])
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.StructureGraphId);
}
else if (conge_QuestionStructureGraphRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.CourseId);
}
else if (conge_QuestionStructureGraphRela.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.CreateUser);
}
else if (conge_QuestionStructureGraphRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.UpdDate);
}
else if (conge_QuestionStructureGraphRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.UpdUser);
}
else if (conge_QuestionStructureGraphRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.Memo);
}
else if (conge_QuestionStructureGraphRela.GameLevelId  ==  AttributeName[intIndex])
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_QuestionStructureGraphRela.GameLevelId);
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
 AddUpdatedFld(conge_QuestionStructureGraphRela.mId);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(conge_QuestionStructureGraphRela.QuestionId);
}
}
/// <summary>
/// 知识图谱Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureGraphId
{
get
{
return mstrStructureGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureGraphId = value;
}
else
{
 mstrStructureGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_QuestionStructureGraphRela.StructureGraphId);
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
 AddUpdatedFld(conge_QuestionStructureGraphRela.CourseId);
}
}
/// <summary>
/// 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUser
{
get
{
return mstrCreateUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUser = value;
}
else
{
 mstrCreateUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_QuestionStructureGraphRela.CreateUser);
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
 AddUpdatedFld(conge_QuestionStructureGraphRela.UpdDate);
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
 AddUpdatedFld(conge_QuestionStructureGraphRela.UpdUser);
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
 AddUpdatedFld(conge_QuestionStructureGraphRela.Memo);
}
}
/// <summary>
/// 游戏关卡Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GameLevelId
{
get
{
return mstrGameLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGameLevelId = value;
}
else
{
 mstrGameLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_QuestionStructureGraphRela.GameLevelId);
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
 /// 问题结构图关系(ge_QuestionStructureGraphRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_QuestionStructureGraphRela
{
public const string _CurrTabName = "ge_QuestionStructureGraphRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionId", "StructureGraphId", "CourseId", "CreateUser", "UpdDate", "UpdUser", "Memo", "GameLevelId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"StructureGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureGraphId = "StructureGraphId";    //知识图谱Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CreateUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUser = "CreateUser";    //建立用户

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

 /// <summary>
 /// 常量:"GameLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelId = "GameLevelId";    //游戏关卡Id
}

}
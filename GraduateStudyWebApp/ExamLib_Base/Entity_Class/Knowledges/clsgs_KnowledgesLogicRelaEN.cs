
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogicRelaEN
 表名:gs_KnowledgesLogicRela(01120870)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表gs_KnowledgesLogicRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_KnowledgesLogicRela
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
public K_mId_gs_KnowledgesLogicRela(long lngmId)
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
 /// <returns>返回:[K_mId_gs_KnowledgesLogicRela]类型的对象</returns>
public static implicit operator K_mId_gs_KnowledgesLogicRela(long value)
{
return new K_mId_gs_KnowledgesLogicRela(value);
}
}
 /// <summary>
 /// 知识点逻辑关系表(gs_KnowledgesLogicRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_KnowledgesLogicRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_KnowledgesLogicRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeIdA", "CourseKnowledgeTitleA", "CourseKnowledgeIdB", "CourseKnowledgeTitleB", "KnowledgeGraphId", "SourceAnchor", "TargetAnchor", "RelaTitle", "RelaTypeId", "CourseId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseKnowledgeIdA;    //课程知识点AId
protected string mstrCourseKnowledgeTitleA;    //课程知识点标题A
protected string mstrCourseKnowledgeIdB;    //课程知识点BId
protected string mstrCourseKnowledgeTitleB;    //课程知识点标题B
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrSourceAnchor;    //源锚点
protected string mstrTargetAnchor;    //目标锚点
protected string mstrRelaTitle;    //关系标题
protected string mstrRelaTypeId;    //关系类型Id
protected string mstrCourseId;    //课程Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_KnowledgesLogicRelaEN()
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
public clsgs_KnowledgesLogicRelaEN(long lngmId)
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
if (strAttributeName  ==  congs_KnowledgesLogicRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeIdA)
{
return mstrCourseKnowledgeIdA;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeTitleA)
{
return mstrCourseKnowledgeTitleA;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeIdB)
{
return mstrCourseKnowledgeIdB;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeTitleB)
{
return mstrCourseKnowledgeTitleB;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.SourceAnchor)
{
return mstrSourceAnchor;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.TargetAnchor)
{
return mstrTargetAnchor;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.RelaTitle)
{
return mstrRelaTitle;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.RelaTypeId)
{
return mstrRelaTypeId;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_KnowledgesLogicRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogicRela.mId);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeIdA)
{
mstrCourseKnowledgeIdA = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeIdA);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeTitleA)
{
mstrCourseKnowledgeTitleA = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeTitleA);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeIdB)
{
mstrCourseKnowledgeIdB = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeIdB);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseKnowledgeTitleB)
{
mstrCourseKnowledgeTitleB = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeTitleB);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.KnowledgeGraphId);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.SourceAnchor)
{
mstrSourceAnchor = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.SourceAnchor);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.TargetAnchor)
{
mstrTargetAnchor = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.TargetAnchor);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.RelaTitle)
{
mstrRelaTitle = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.RelaTitle);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.RelaTypeId)
{
mstrRelaTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.RelaTypeId);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseId);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.UpdUser);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.UpdDate);
}
else if (strAttributeName  ==  congs_KnowledgesLogicRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_KnowledgesLogicRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeIdA  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeIdA;
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeTitleA  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeTitleA;
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeIdB  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeIdB;
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeTitleB  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeTitleB;
}
else if (congs_KnowledgesLogicRela.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (congs_KnowledgesLogicRela.SourceAnchor  ==  AttributeName[intIndex])
{
return mstrSourceAnchor;
}
else if (congs_KnowledgesLogicRela.TargetAnchor  ==  AttributeName[intIndex])
{
return mstrTargetAnchor;
}
else if (congs_KnowledgesLogicRela.RelaTitle  ==  AttributeName[intIndex])
{
return mstrRelaTitle;
}
else if (congs_KnowledgesLogicRela.RelaTypeId  ==  AttributeName[intIndex])
{
return mstrRelaTypeId;
}
else if (congs_KnowledgesLogicRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (congs_KnowledgesLogicRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_KnowledgesLogicRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_KnowledgesLogicRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_KnowledgesLogicRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogicRela.mId);
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeIdA  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeIdA = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeIdA);
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeTitleA  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeTitleA = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeTitleA);
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeIdB  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeIdB = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeIdB);
}
else if (congs_KnowledgesLogicRela.CourseKnowledgeTitleB  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeTitleB = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeTitleB);
}
else if (congs_KnowledgesLogicRela.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.KnowledgeGraphId);
}
else if (congs_KnowledgesLogicRela.SourceAnchor  ==  AttributeName[intIndex])
{
mstrSourceAnchor = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.SourceAnchor);
}
else if (congs_KnowledgesLogicRela.TargetAnchor  ==  AttributeName[intIndex])
{
mstrTargetAnchor = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.TargetAnchor);
}
else if (congs_KnowledgesLogicRela.RelaTitle  ==  AttributeName[intIndex])
{
mstrRelaTitle = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.RelaTitle);
}
else if (congs_KnowledgesLogicRela.RelaTypeId  ==  AttributeName[intIndex])
{
mstrRelaTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.RelaTypeId);
}
else if (congs_KnowledgesLogicRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseId);
}
else if (congs_KnowledgesLogicRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.UpdUser);
}
else if (congs_KnowledgesLogicRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.UpdDate);
}
else if (congs_KnowledgesLogicRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogicRela.Memo);
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
 AddUpdatedFld(congs_KnowledgesLogicRela.mId);
}
}
/// <summary>
/// 课程知识点AId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeIdA
{
get
{
return mstrCourseKnowledgeIdA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeIdA = value;
}
else
{
 mstrCourseKnowledgeIdA = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeIdA);
}
}
/// <summary>
/// 课程知识点标题A(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeTitleA
{
get
{
return mstrCourseKnowledgeTitleA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeTitleA = value;
}
else
{
 mstrCourseKnowledgeTitleA = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeTitleA);
}
}
/// <summary>
/// 课程知识点BId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeIdB
{
get
{
return mstrCourseKnowledgeIdB;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeIdB = value;
}
else
{
 mstrCourseKnowledgeIdB = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeIdB);
}
}
/// <summary>
/// 课程知识点标题B(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeTitleB
{
get
{
return mstrCourseKnowledgeTitleB;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeTitleB = value;
}
else
{
 mstrCourseKnowledgeTitleB = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseKnowledgeTitleB);
}
}
/// <summary>
/// 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeGraphId
{
get
{
return mstrKnowledgeGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeGraphId = value;
}
else
{
 mstrKnowledgeGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.KnowledgeGraphId);
}
}
/// <summary>
/// 源锚点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceAnchor
{
get
{
return mstrSourceAnchor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceAnchor = value;
}
else
{
 mstrSourceAnchor = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.SourceAnchor);
}
}
/// <summary>
/// 目标锚点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetAnchor
{
get
{
return mstrTargetAnchor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetAnchor = value;
}
else
{
 mstrTargetAnchor = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.TargetAnchor);
}
}
/// <summary>
/// 关系标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTitle
{
get
{
return mstrRelaTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTitle = value;
}
else
{
 mstrRelaTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.RelaTitle);
}
}
/// <summary>
/// 关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTypeId
{
get
{
return mstrRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTypeId = value;
}
else
{
 mstrRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogicRela.RelaTypeId);
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
 AddUpdatedFld(congs_KnowledgesLogicRela.CourseId);
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
 AddUpdatedFld(congs_KnowledgesLogicRela.UpdUser);
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
 AddUpdatedFld(congs_KnowledgesLogicRela.UpdDate);
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
 AddUpdatedFld(congs_KnowledgesLogicRela.Memo);
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
 /// 知识点逻辑关系表(gs_KnowledgesLogicRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_KnowledgesLogicRela
{
public const string _CurrTabName = "gs_KnowledgesLogicRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeIdA", "CourseKnowledgeTitleA", "CourseKnowledgeIdB", "CourseKnowledgeTitleB", "KnowledgeGraphId", "SourceAnchor", "TargetAnchor", "RelaTitle", "RelaTypeId", "CourseId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseKnowledgeIdA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeIdA = "CourseKnowledgeIdA";    //课程知识点AId

 /// <summary>
 /// 常量:"CourseKnowledgeTitleA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeTitleA = "CourseKnowledgeTitleA";    //课程知识点标题A

 /// <summary>
 /// 常量:"CourseKnowledgeIdB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeIdB = "CourseKnowledgeIdB";    //课程知识点BId

 /// <summary>
 /// 常量:"CourseKnowledgeTitleB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeTitleB = "CourseKnowledgeTitleB";    //课程知识点标题B

 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"SourceAnchor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceAnchor = "SourceAnchor";    //源锚点

 /// <summary>
 /// 常量:"TargetAnchor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetAnchor = "TargetAnchor";    //目标锚点

 /// <summary>
 /// 常量:"RelaTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTitle = "RelaTitle";    //关系标题

 /// <summary>
 /// 常量:"RelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTypeId = "RelaTypeId";    //关系类型Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
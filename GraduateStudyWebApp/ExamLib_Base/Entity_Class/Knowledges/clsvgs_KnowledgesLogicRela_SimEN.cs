
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogicRela_SimEN
 表名:vgs_KnowledgesLogicRela_Sim(01120934)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:58:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表vgs_KnowledgesLogicRela_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_KnowledgesLogicRela_Sim
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
public K_mId_vgs_KnowledgesLogicRela_Sim(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_KnowledgesLogicRela_Sim]类型的对象</returns>
public static implicit operator K_mId_vgs_KnowledgesLogicRela_Sim(long value)
{
return new K_mId_vgs_KnowledgesLogicRela_Sim(value);
}
}
 /// <summary>
 /// v知识点逻辑关系_Sim(vgs_KnowledgesLogicRela_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_KnowledgesLogicRela_SimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_KnowledgesLogicRela_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeIdA", "CourseKnowledgeIdB", "CourseKnowledgeTitleA", "CourseKnowledgeTitleB", "RelaTypeId", "KnowledgeGraphId", "SourceAnchor", "TargetAnchor", "CourseId", "RelaTitle"};

protected long mlngmId;    //mId
protected string mstrCourseKnowledgeIdA;    //课程知识点AId
protected string mstrCourseKnowledgeIdB;    //课程知识点BId
protected string mstrCourseKnowledgeTitleA;    //课程知识点标题A
protected string mstrCourseKnowledgeTitleB;    //课程知识点标题B
protected string mstrRelaTypeId;    //关系类型Id
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrSourceAnchor;    //源锚点
protected string mstrTargetAnchor;    //目标锚点
protected string mstrCourseId;    //课程Id
protected string mstrRelaTitle;    //关系标题

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_KnowledgesLogicRela_SimEN()
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
public clsvgs_KnowledgesLogicRela_SimEN(long lngmId)
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
if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA)
{
return mstrCourseKnowledgeIdA;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB)
{
return mstrCourseKnowledgeIdB;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA)
{
return mstrCourseKnowledgeTitleA;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB)
{
return mstrCourseKnowledgeTitleB;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.RelaTypeId)
{
return mstrRelaTypeId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.SourceAnchor)
{
return mstrSourceAnchor;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.TargetAnchor)
{
return mstrTargetAnchor;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.RelaTitle)
{
return mstrRelaTitle;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.mId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA)
{
mstrCourseKnowledgeIdA = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB)
{
mstrCourseKnowledgeIdB = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA)
{
mstrCourseKnowledgeTitleA = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB)
{
mstrCourseKnowledgeTitleB = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.RelaTypeId)
{
mstrRelaTypeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.RelaTypeId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.SourceAnchor)
{
mstrSourceAnchor = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.SourceAnchor);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.TargetAnchor)
{
mstrTargetAnchor = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.TargetAnchor);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogicRela_Sim.RelaTitle)
{
mstrRelaTitle = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.RelaTitle);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_KnowledgesLogicRela_Sim.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeIdA;
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeIdB;
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeTitleA;
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeTitleB;
}
else if (convgs_KnowledgesLogicRela_Sim.RelaTypeId  ==  AttributeName[intIndex])
{
return mstrRelaTypeId;
}
else if (convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (convgs_KnowledgesLogicRela_Sim.SourceAnchor  ==  AttributeName[intIndex])
{
return mstrSourceAnchor;
}
else if (convgs_KnowledgesLogicRela_Sim.TargetAnchor  ==  AttributeName[intIndex])
{
return mstrTargetAnchor;
}
else if (convgs_KnowledgesLogicRela_Sim.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convgs_KnowledgesLogicRela_Sim.RelaTitle  ==  AttributeName[intIndex])
{
return mstrRelaTitle;
}
return null;
}
set
{
if (convgs_KnowledgesLogicRela_Sim.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.mId);
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeIdA = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA);
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeIdB = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB);
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeTitleA = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA);
}
else if (convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeTitleB = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB);
}
else if (convgs_KnowledgesLogicRela_Sim.RelaTypeId  ==  AttributeName[intIndex])
{
mstrRelaTypeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.RelaTypeId);
}
else if (convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId);
}
else if (convgs_KnowledgesLogicRela_Sim.SourceAnchor  ==  AttributeName[intIndex])
{
mstrSourceAnchor = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.SourceAnchor);
}
else if (convgs_KnowledgesLogicRela_Sim.TargetAnchor  ==  AttributeName[intIndex])
{
mstrTargetAnchor = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.TargetAnchor);
}
else if (convgs_KnowledgesLogicRela_Sim.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseId);
}
else if (convgs_KnowledgesLogicRela_Sim.RelaTitle  ==  AttributeName[intIndex])
{
mstrRelaTitle = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.RelaTitle);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.mId);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.RelaTypeId);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.SourceAnchor);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.TargetAnchor);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.CourseId);
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
 AddUpdatedFld(convgs_KnowledgesLogicRela_Sim.RelaTitle);
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
 /// v知识点逻辑关系_Sim(vgs_KnowledgesLogicRela_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_KnowledgesLogicRela_Sim
{
public const string _CurrTabName = "vgs_KnowledgesLogicRela_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeIdA", "CourseKnowledgeIdB", "CourseKnowledgeTitleA", "CourseKnowledgeTitleB", "RelaTypeId", "KnowledgeGraphId", "SourceAnchor", "TargetAnchor", "CourseId", "RelaTitle"};
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
 /// 常量:"CourseKnowledgeIdB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeIdB = "CourseKnowledgeIdB";    //课程知识点BId

 /// <summary>
 /// 常量:"CourseKnowledgeTitleA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeTitleA = "CourseKnowledgeTitleA";    //课程知识点标题A

 /// <summary>
 /// 常量:"CourseKnowledgeTitleB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeTitleB = "CourseKnowledgeTitleB";    //课程知识点标题B

 /// <summary>
 /// 常量:"RelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTypeId = "RelaTypeId";    //关系类型Id

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"RelaTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTitle = "RelaTitle";    //关系标题
}

}
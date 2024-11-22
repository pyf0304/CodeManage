
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogic_User_SimEN
 表名:vgs_KnowledgesLogic_User_Sim(01120933)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:57:52
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
 /// 表vgs_KnowledgesLogic_User_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_KnowledgesLogic_User_Sim
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
public K_mId_vgs_KnowledgesLogic_User_Sim(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_KnowledgesLogic_User_Sim]类型的对象</returns>
public static implicit operator K_mId_vgs_KnowledgesLogic_User_Sim(long value)
{
return new K_mId_vgs_KnowledgesLogic_User_Sim(value);
}
}
 /// <summary>
 /// v知识点逻辑用户关系_Sim(vgs_KnowledgesLogic_User_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_KnowledgesLogic_User_SimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_KnowledgesLogic_User_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeId", "KnowledgeGraphId", "ClassName", "CourseId", "IdCurrEduCls", "UserId"};

protected long mlngmId;    //mId
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrClassName;    //样式名称
protected string mstrCourseId;    //课程Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_KnowledgesLogic_User_SimEN()
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
public clsvgs_KnowledgesLogic_User_SimEN(long lngmId)
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
if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.ClassName)
{
return mstrClassName;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.mId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.ClassName)
{
mstrClassName = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.ClassName);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.CourseId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_User_Sim.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_KnowledgesLogic_User_Sim.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (convgs_KnowledgesLogic_User_Sim.ClassName  ==  AttributeName[intIndex])
{
return mstrClassName;
}
else if (convgs_KnowledgesLogic_User_Sim.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convgs_KnowledgesLogic_User_Sim.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convgs_KnowledgesLogic_User_Sim.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (convgs_KnowledgesLogic_User_Sim.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.mId);
}
else if (convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
}
else if (convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
}
else if (convgs_KnowledgesLogic_User_Sim.ClassName  ==  AttributeName[intIndex])
{
mstrClassName = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.ClassName);
}
else if (convgs_KnowledgesLogic_User_Sim.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.CourseId);
}
else if (convgs_KnowledgesLogic_User_Sim.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
}
else if (convgs_KnowledgesLogic_User_Sim.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.UserId);
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
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.mId);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
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
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
}
}
/// <summary>
/// 样式名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassName
{
get
{
return mstrClassName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassName = value;
}
else
{
 mstrClassName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.ClassName);
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
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.CourseId);
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
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
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
 AddUpdatedFld(convgs_KnowledgesLogic_User_Sim.UserId);
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
 /// v知识点逻辑用户关系_Sim(vgs_KnowledgesLogic_User_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_KnowledgesLogic_User_Sim
{
public const string _CurrTabName = "vgs_KnowledgesLogic_User_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeId", "KnowledgeGraphId", "ClassName", "CourseId", "IdCurrEduCls", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"ClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassName = "ClassName";    //样式名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}
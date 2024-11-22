
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogic_SimEN
 表名:vgs_KnowledgesLogic_Sim(01120935)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:57:49
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
 /// 表vgs_KnowledgesLogic_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_KnowledgesLogic_Sim
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
public K_mId_vgs_KnowledgesLogic_Sim(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_KnowledgesLogic_Sim]类型的对象</returns>
public static implicit operator K_mId_vgs_KnowledgesLogic_Sim(long value)
{
return new K_mId_vgs_KnowledgesLogic_Sim(value);
}
}
 /// <summary>
 /// v知识点结点_Sim(vgs_KnowledgesLogic_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_KnowledgesLogic_SimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_KnowledgesLogic_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "CourseKnowledgeTitle", "XPosition", "YPosition", "KnowledgeGraphId", "LogicNodeId", "NodeColor", "ClassName", "CourseId", "mId"};

protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrCourseKnowledgeTitle;    //知识点标题
protected float? mfltXPosition;    //X_坐标
protected float? mfltYPosition;    //Y_坐标
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrLogicNodeId;    //逻辑节点Id
protected string mstrNodeColor;    //结点颜色
protected string mstrClassName;    //样式名称
protected string mstrCourseId;    //课程Id
protected long mlngmId;    //mId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_KnowledgesLogic_SimEN()
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
public clsvgs_KnowledgesLogic_SimEN(long lngmId)
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
if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle)
{
return mstrCourseKnowledgeTitle;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.XPosition)
{
return mfltXPosition;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.YPosition)
{
return mfltYPosition;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.LogicNodeId)
{
return mstrLogicNodeId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.NodeColor)
{
return mstrNodeColor;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.ClassName)
{
return mstrClassName;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.mId)
{
return mlngmId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseKnowledgeId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle)
{
mstrCourseKnowledgeTitle = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.XPosition)
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.XPosition);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.YPosition)
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.YPosition);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.KnowledgeGraphId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.LogicNodeId)
{
mstrLogicNodeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.LogicNodeId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.NodeColor)
{
mstrNodeColor = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.NodeColor);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.ClassName)
{
mstrClassName = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.ClassName);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseId);
}
else if (strAttributeName  ==  convgs_KnowledgesLogic_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.mId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_KnowledgesLogic_Sim.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeTitle;
}
else if (convgs_KnowledgesLogic_Sim.XPosition  ==  AttributeName[intIndex])
{
return mfltXPosition;
}
else if (convgs_KnowledgesLogic_Sim.YPosition  ==  AttributeName[intIndex])
{
return mfltYPosition;
}
else if (convgs_KnowledgesLogic_Sim.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (convgs_KnowledgesLogic_Sim.LogicNodeId  ==  AttributeName[intIndex])
{
return mstrLogicNodeId;
}
else if (convgs_KnowledgesLogic_Sim.NodeColor  ==  AttributeName[intIndex])
{
return mstrNodeColor;
}
else if (convgs_KnowledgesLogic_Sim.ClassName  ==  AttributeName[intIndex])
{
return mstrClassName;
}
else if (convgs_KnowledgesLogic_Sim.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convgs_KnowledgesLogic_Sim.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
return null;
}
set
{
if (convgs_KnowledgesLogic_Sim.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseKnowledgeId);
}
else if (convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeTitle = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle);
}
else if (convgs_KnowledgesLogic_Sim.XPosition  ==  AttributeName[intIndex])
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.XPosition);
}
else if (convgs_KnowledgesLogic_Sim.YPosition  ==  AttributeName[intIndex])
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.YPosition);
}
else if (convgs_KnowledgesLogic_Sim.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.KnowledgeGraphId);
}
else if (convgs_KnowledgesLogic_Sim.LogicNodeId  ==  AttributeName[intIndex])
{
mstrLogicNodeId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.LogicNodeId);
}
else if (convgs_KnowledgesLogic_Sim.NodeColor  ==  AttributeName[intIndex])
{
mstrNodeColor = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.NodeColor);
}
else if (convgs_KnowledgesLogic_Sim.ClassName  ==  AttributeName[intIndex])
{
mstrClassName = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.ClassName);
}
else if (convgs_KnowledgesLogic_Sim.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseId);
}
else if (convgs_KnowledgesLogic_Sim.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.mId);
}
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
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseKnowledgeId);
}
}
/// <summary>
/// 知识点标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeTitle
{
get
{
return mstrCourseKnowledgeTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeTitle = value;
}
else
{
 mstrCourseKnowledgeTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseKnowledgeTitle);
}
}
/// <summary>
/// X_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? XPosition
{
get
{
return mfltXPosition;
}
set
{
 mfltXPosition = value;
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.XPosition);
}
}
/// <summary>
/// Y_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? YPosition
{
get
{
return mfltYPosition;
}
set
{
 mfltYPosition = value;
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.YPosition);
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
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.KnowledgeGraphId);
}
}
/// <summary>
/// 逻辑节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogicNodeId
{
get
{
return mstrLogicNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogicNodeId = value;
}
else
{
 mstrLogicNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.LogicNodeId);
}
}
/// <summary>
/// 结点颜色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NodeColor
{
get
{
return mstrNodeColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNodeColor = value;
}
else
{
 mstrNodeColor = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.NodeColor);
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
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.ClassName);
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
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.CourseId);
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
 AddUpdatedFld(convgs_KnowledgesLogic_Sim.mId);
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
 /// v知识点结点_Sim(vgs_KnowledgesLogic_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_KnowledgesLogic_Sim
{
public const string _CurrTabName = "vgs_KnowledgesLogic_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "CourseKnowledgeTitle", "XPosition", "YPosition", "KnowledgeGraphId", "LogicNodeId", "NodeColor", "ClassName", "CourseId", "mId"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"CourseKnowledgeTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeTitle = "CourseKnowledgeTitle";    //知识点标题

 /// <summary>
 /// 常量:"XPosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XPosition = "XPosition";    //X_坐标

 /// <summary>
 /// 常量:"YPosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YPosition = "YPosition";    //Y_坐标

 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"LogicNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogicNodeId = "LogicNodeId";    //逻辑节点Id

 /// <summary>
 /// 常量:"NodeColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeColor = "NodeColor";    //结点颜色

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
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId
}

}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogicEN
 表名:gs_KnowledgesLogic(01120872)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:04
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
 /// 表gs_KnowledgesLogic的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_KnowledgesLogic
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
public K_mId_gs_KnowledgesLogic(long lngmId)
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
 /// <returns>返回:[K_mId_gs_KnowledgesLogic]类型的对象</returns>
public static implicit operator K_mId_gs_KnowledgesLogic(long value)
{
return new K_mId_gs_KnowledgesLogic(value);
}
}
 /// <summary>
 /// 知识点逻辑(gs_KnowledgesLogic)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_KnowledgesLogicEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_KnowledgesLogic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeId", "CourseKnowledgeTitle", "XPosition", "YPosition", "KnowledgeGraphId", "NodeColor", "LogicNodeId", "ClassNameCss", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrCourseKnowledgeTitle;    //知识点标题
protected float? mfltXPosition;    //X_坐标
protected float? mfltYPosition;    //Y_坐标
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrNodeColor;    //结点颜色
protected string mstrLogicNodeId;    //逻辑节点Id
protected string mstrClassNameCss;    //样式名称
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_KnowledgesLogicEN()
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
public clsgs_KnowledgesLogicEN(long lngmId)
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
if (strAttributeName  ==  congs_KnowledgesLogic.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.CourseKnowledgeTitle)
{
return mstrCourseKnowledgeTitle;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.XPosition)
{
return mfltXPosition;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.YPosition)
{
return mfltYPosition;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.NodeColor)
{
return mstrNodeColor;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.LogicNodeId)
{
return mstrLogicNodeId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.ClassNameCss)
{
return mstrClassNameCss;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_KnowledgesLogic.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_KnowledgesLogic.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic.mId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.CourseKnowledgeId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.CourseKnowledgeTitle)
{
mstrCourseKnowledgeTitle = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.CourseKnowledgeTitle);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.XPosition)
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic.XPosition);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.YPosition)
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic.YPosition);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.KnowledgeGraphId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.NodeColor)
{
mstrNodeColor = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.NodeColor);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.LogicNodeId)
{
mstrLogicNodeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.LogicNodeId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.ClassNameCss)
{
mstrClassNameCss = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.ClassNameCss);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.CourseId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.UpdDate);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.UpdUser);
}
else if (strAttributeName  ==  congs_KnowledgesLogic.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_KnowledgesLogic.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_KnowledgesLogic.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (congs_KnowledgesLogic.CourseKnowledgeTitle  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeTitle;
}
else if (congs_KnowledgesLogic.XPosition  ==  AttributeName[intIndex])
{
return mfltXPosition;
}
else if (congs_KnowledgesLogic.YPosition  ==  AttributeName[intIndex])
{
return mfltYPosition;
}
else if (congs_KnowledgesLogic.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (congs_KnowledgesLogic.NodeColor  ==  AttributeName[intIndex])
{
return mstrNodeColor;
}
else if (congs_KnowledgesLogic.LogicNodeId  ==  AttributeName[intIndex])
{
return mstrLogicNodeId;
}
else if (congs_KnowledgesLogic.ClassNameCss  ==  AttributeName[intIndex])
{
return mstrClassNameCss;
}
else if (congs_KnowledgesLogic.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (congs_KnowledgesLogic.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_KnowledgesLogic.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_KnowledgesLogic.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_KnowledgesLogic.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic.mId);
}
else if (congs_KnowledgesLogic.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.CourseKnowledgeId);
}
else if (congs_KnowledgesLogic.CourseKnowledgeTitle  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeTitle = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.CourseKnowledgeTitle);
}
else if (congs_KnowledgesLogic.XPosition  ==  AttributeName[intIndex])
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic.XPosition);
}
else if (congs_KnowledgesLogic.YPosition  ==  AttributeName[intIndex])
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic.YPosition);
}
else if (congs_KnowledgesLogic.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.KnowledgeGraphId);
}
else if (congs_KnowledgesLogic.NodeColor  ==  AttributeName[intIndex])
{
mstrNodeColor = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.NodeColor);
}
else if (congs_KnowledgesLogic.LogicNodeId  ==  AttributeName[intIndex])
{
mstrLogicNodeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.LogicNodeId);
}
else if (congs_KnowledgesLogic.ClassNameCss  ==  AttributeName[intIndex])
{
mstrClassNameCss = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.ClassNameCss);
}
else if (congs_KnowledgesLogic.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.CourseId);
}
else if (congs_KnowledgesLogic.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.UpdDate);
}
else if (congs_KnowledgesLogic.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.UpdUser);
}
else if (congs_KnowledgesLogic.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic.Memo);
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
 AddUpdatedFld(congs_KnowledgesLogic.mId);
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
 AddUpdatedFld(congs_KnowledgesLogic.CourseKnowledgeId);
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
 AddUpdatedFld(congs_KnowledgesLogic.CourseKnowledgeTitle);
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
 AddUpdatedFld(congs_KnowledgesLogic.XPosition);
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
 AddUpdatedFld(congs_KnowledgesLogic.YPosition);
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
 AddUpdatedFld(congs_KnowledgesLogic.KnowledgeGraphId);
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
 AddUpdatedFld(congs_KnowledgesLogic.NodeColor);
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
 AddUpdatedFld(congs_KnowledgesLogic.LogicNodeId);
}
}
/// <summary>
/// 样式名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassNameCss
{
get
{
return mstrClassNameCss;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassNameCss = value;
}
else
{
 mstrClassNameCss = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogic.ClassNameCss);
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
 AddUpdatedFld(congs_KnowledgesLogic.CourseId);
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
 AddUpdatedFld(congs_KnowledgesLogic.UpdDate);
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
 AddUpdatedFld(congs_KnowledgesLogic.UpdUser);
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
 AddUpdatedFld(congs_KnowledgesLogic.Memo);
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
 /// 知识点逻辑(gs_KnowledgesLogic)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_KnowledgesLogic
{
public const string _CurrTabName = "gs_KnowledgesLogic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseKnowledgeId", "CourseKnowledgeTitle", "XPosition", "YPosition", "KnowledgeGraphId", "NodeColor", "LogicNodeId", "ClassNameCss", "CourseId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"NodeColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NodeColor = "NodeColor";    //结点颜色

 /// <summary>
 /// 常量:"LogicNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogicNodeId = "LogicNodeId";    //逻辑节点Id

 /// <summary>
 /// 常量:"ClassNameCss"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNameCss = "ClassNameCss";    //样式名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
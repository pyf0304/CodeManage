
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SimEN
 表名:vCurrEduCls_Sim(01120951)
 * 版本:2023.10.12.1(服务器:WIN-SRV103-116)
 日期:2023/10/28 09:48:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表vCurrEduCls_Sim的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_vCurrEduCls_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
public K_IdCurrEduCls_vCurrEduCls_Sim(string strIdCurrEduCls)
{
if (IsValid(strIdCurrEduCls)) Value = strIdCurrEduCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return false;
if (strIdCurrEduCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduCls_vCurrEduCls_Sim]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_vCurrEduCls_Sim(string value)
{
return new K_IdCurrEduCls_vCurrEduCls_Sim(value);
}
}
 /// <summary>
 /// vCurrEduCls_Sim(vCurrEduCls_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCurrEduCls_SimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCurrEduCls_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "IdXzCollege", "IdXzMajor"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrCourseId;    //课程Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCurrEduCls_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCurrEduCls">关键字:教学班流水号</param>
public clsvCurrEduCls_SimEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:vCurrEduCls_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:vCurrEduCls_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCurrEduCls = strIdCurrEduCls;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
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
if (strAttributeName  ==  convCurrEduCls_Sim.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convCurrEduCls_Sim.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convCurrEduCls_Sim.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convCurrEduCls_Sim.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  convCurrEduCls_Sim.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCurrEduCls_Sim.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCurrEduCls_Sim.IdXzMajor)
{
return mstrIdXzMajor;
}
return null;
}
set
{
if (strAttributeName  ==  convCurrEduCls_Sim.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.IdCurrEduCls);
}
else if (strAttributeName  ==  convCurrEduCls_Sim.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.CurrEduClsId);
}
else if (strAttributeName  ==  convCurrEduCls_Sim.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.EduClsName);
}
else if (strAttributeName  ==  convCurrEduCls_Sim.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.EduClsTypeId);
}
else if (strAttributeName  ==  convCurrEduCls_Sim.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.CourseId);
}
else if (strAttributeName  ==  convCurrEduCls_Sim.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.IdXzCollege);
}
else if (strAttributeName  ==  convCurrEduCls_Sim.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.IdXzMajor);
}
}
}
public object this[int intIndex]
{
get
{
if (convCurrEduCls_Sim.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convCurrEduCls_Sim.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convCurrEduCls_Sim.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convCurrEduCls_Sim.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (convCurrEduCls_Sim.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCurrEduCls_Sim.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCurrEduCls_Sim.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
return null;
}
set
{
if (convCurrEduCls_Sim.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.IdCurrEduCls);
}
else if (convCurrEduCls_Sim.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.CurrEduClsId);
}
else if (convCurrEduCls_Sim.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.EduClsName);
}
else if (convCurrEduCls_Sim.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.EduClsTypeId);
}
else if (convCurrEduCls_Sim.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.CourseId);
}
else if (convCurrEduCls_Sim.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.IdXzCollege);
}
else if (convCurrEduCls_Sim.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCurrEduCls_Sim.IdXzMajor);
}
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
 AddUpdatedFld(convCurrEduCls_Sim.IdCurrEduCls);
}
}
/// <summary>
/// 教学班Id(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CurrEduClsId
{
get
{
return mstrCurrEduClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCurrEduClsId = value;
}
else
{
 mstrCurrEduClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Sim.CurrEduClsId);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Sim.EduClsName);
}
}
/// <summary>
/// 教学班类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTypeId
{
get
{
return mstrEduClsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTypeId = value;
}
else
{
 mstrEduClsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Sim.EduClsTypeId);
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
 AddUpdatedFld(convCurrEduCls_Sim.CourseId);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Sim.IdXzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Sim.IdXzMajor);
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
  return mstrIdCurrEduCls;
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
  return mstrEduClsName;
 }
 }
}
 /// <summary>
 /// vCurrEduCls_Sim(vCurrEduCls_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCurrEduCls_Sim
{
public const string _CurrTabName = "vCurrEduCls_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "IdXzCollege", "IdXzMajor"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CurrEduClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrEduClsId = "CurrEduClsId";    //教学班Id

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

 /// <summary>
 /// 常量:"EduClsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeId = "EduClsTypeId";    //教学班类型Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号
}

}
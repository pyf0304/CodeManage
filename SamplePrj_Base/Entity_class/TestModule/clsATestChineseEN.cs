
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsATestChineseEN
 表名:ATestChinese(01160067)
 生成代码版本:2018.07.23.1
 生成日期:2018/07/30 11:07:27
 生成者:潘以锋
 生成服务器IP:202.121.63.42
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:测试模块
 模块英文名:TestModule
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace SimplePrj.Entity
{
 /// <summary>
 /// ATestChinese(ATestChinese)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsATestChineseEN : clsEntityBase2
{
public const string CurrTabName_S = "ATestChinese"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "StuId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"StuId", "姓名"};
//以下是属性变量

protected string mstrStuId;    //StuId
protected string mstr姓名;    //姓名


 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuId = "StuId";    //StuId

 /// <summary>
 /// 常量:"姓名"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_姓名 = "姓名";    //姓名

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsATestChineseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
            _CurrTabName = "ATestChinese";
 lstKeyFldNames.Add("StuId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrStuId">关键字:StuId</param>
public clsATestChineseEN(string strStuId)
 {
strStuId = strStuId.Replace("'", "''");
if (strStuId.Length > 4)
{
throw new Exception("在表:ATestChinese中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStuId)  ==  true)
{
throw new Exception("在表:ATestChinese中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrStuId = strStuId;
 SetInit();
 mbolIsCheckProperty = false;
            _CurrTabName = "ATestChinese";
 lstKeyFldNames.Add("StuId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  con_姓名)
{
return mstr姓名;
}
return null;
}
set
{
if (strAttributeName  ==  con_StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(con_StuId);
}
else if (strAttributeName  ==  con_姓名)
{
mstr姓名 = value.ToString();
 AddUpdatedFld(con_姓名);
}
}
}
public object this[int intIndex]
{
get
{
if (con_StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (con_姓名  ==  AttributeName[intIndex])
{
return mstr姓名;
}
return null;
}
set
{
if (con_StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(con_StuId);
}
else if (con_姓名  ==  AttributeName[intIndex])
{
mstr姓名 = value.ToString();
 AddUpdatedFld(con_姓名);
}
}
}

/// <summary>
/// StuId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StuId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string 姓名
{
get
{
return mstr姓名;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstr姓名 = value;
}
else
{
 mstr姓名 = value;
}
//记录修改过的字段
 AddUpdatedFld(con_姓名);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrStuId;
 }
 }
}
}
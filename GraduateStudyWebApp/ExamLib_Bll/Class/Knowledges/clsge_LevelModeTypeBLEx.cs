
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LevelModeTypeBLEx
 表名:ge_LevelModeType(01120907)
 生成代码版本:2021.03.30.1
 生成日期:2021/03/31 20:23:46
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clsge_LevelModeTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_LevelModeTypeEN:objge_LevelModeTypeENT</returns>
 public static clsge_LevelModeTypeENEx CopyToEx(this clsge_LevelModeTypeEN objge_LevelModeTypeENS)
{
try
{
 clsge_LevelModeTypeENEx objge_LevelModeTypeENT = new clsge_LevelModeTypeENEx();
clsge_LevelModeTypeBL.ge_LevelModeTypeDA.CopyTo(objge_LevelModeTypeENS, objge_LevelModeTypeENT);
 return objge_LevelModeTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_LevelModeTypeEN:objge_LevelModeTypeENT</returns>
 public static clsge_LevelModeTypeEN CopyTo(this clsge_LevelModeTypeENEx objge_LevelModeTypeENS)
{
try
{
 clsge_LevelModeTypeEN objge_LevelModeTypeENT = new clsge_LevelModeTypeEN();
clsge_LevelModeTypeBL.CopyTo(objge_LevelModeTypeENS, objge_LevelModeTypeENT);
 return objge_LevelModeTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 关卡模式类型(ge_LevelModeType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_LevelModeTypeBLEx : clsge_LevelModeTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_LevelModeTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_LevelModeTypeDAEx ge_LevelModeTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_LevelModeTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_LevelModeTypeEN:objge_LevelModeTypeENT</returns>
 public static clsge_LevelModeTypeENEx CopyToEx(clsge_LevelModeTypeEN objge_LevelModeTypeENS)
{
try
{
 clsge_LevelModeTypeENEx objge_LevelModeTypeENT = new clsge_LevelModeTypeENEx();
clsge_LevelModeTypeBL.ge_LevelModeTypeDA.CopyTo(objge_LevelModeTypeENS, objge_LevelModeTypeENT);
 return objge_LevelModeTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsge_LevelModeTypeENEx> GetObjExLst(string strCondition)
{
List <clsge_LevelModeTypeEN> arrObjLst = clsge_LevelModeTypeBL.GetObjLst(strCondition);
List <clsge_LevelModeTypeENEx> arrObjExLst = new List<clsge_LevelModeTypeENEx>();
foreach (clsge_LevelModeTypeEN objInFor in arrObjLst)
{
clsge_LevelModeTypeENEx objge_LevelModeTypeENEx = new clsge_LevelModeTypeENEx();
clsge_LevelModeTypeBL.CopyTo(objInFor, objge_LevelModeTypeENEx);
arrObjExLst.Add(objge_LevelModeTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strLevelModeTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_LevelModeTypeENEx GetObjExByLevelModeTypeId(string strLevelModeTypeId)
{
clsge_LevelModeTypeEN objge_LevelModeTypeEN = clsge_LevelModeTypeBL.GetObjByLevelModeTypeId(strLevelModeTypeId);
clsge_LevelModeTypeENEx objge_LevelModeTypeENEx = new clsge_LevelModeTypeENEx();
clsge_LevelModeTypeBL.CopyTo(objge_LevelModeTypeEN, objge_LevelModeTypeENEx);
return objge_LevelModeTypeENEx;
}
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSkillRelaBLEx
 表名:vgs_PSkillRela(01120666)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 23:27:27
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsvgs_PSkillRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PSkillRelaEN:objvgs_PSkillRelaENT</returns>
 public static clsvgs_PSkillRelaENEx CopyToEx(this clsvgs_PSkillRelaEN objvgs_PSkillRelaENS)
{
try
{
 clsvgs_PSkillRelaENEx objvgs_PSkillRelaENT = new clsvgs_PSkillRelaENEx();
clsvgs_PSkillRelaBL.vgs_PSkillRelaDA.CopyTo(objvgs_PSkillRelaENS, objvgs_PSkillRelaENT);
 return objvgs_PSkillRelaENT;
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
 /// <param name = "objvgs_PSkillRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PSkillRelaEN:objvgs_PSkillRelaENT</returns>
 public static clsvgs_PSkillRelaEN CopyTo(this clsvgs_PSkillRelaENEx objvgs_PSkillRelaENS)
{
try
{
 clsvgs_PSkillRelaEN objvgs_PSkillRelaENT = new clsvgs_PSkillRelaEN();
clsvgs_PSkillRelaBL.CopyTo(objvgs_PSkillRelaENS, objvgs_PSkillRelaENT);
 return objvgs_PSkillRelaENT;
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
 /// 论文技能关系视图(vgs_PSkillRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_PSkillRelaBLEx : clsvgs_PSkillRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_PSkillRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_PSkillRelaDAEx vgs_PSkillRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_PSkillRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvgs_PSkillRelaENEx> GetObjExLst(string strCondition)
{
List <clsvgs_PSkillRelaEN> arrObjLst = clsvgs_PSkillRelaBL.GetObjLst(strCondition);
List <clsvgs_PSkillRelaENEx> arrObjExLst = new List<clsvgs_PSkillRelaENEx>();
foreach (clsvgs_PSkillRelaEN objInFor in arrObjLst)
{
clsvgs_PSkillRelaENEx objvgs_PSkillRelaENEx = new clsvgs_PSkillRelaENEx();
clsvgs_PSkillRelaBL.CopyTo(objInFor, objvgs_PSkillRelaENEx);
arrObjExLst.Add(objvgs_PSkillRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_PSkillRelaENEx GetObjExBymId(long lngmId)
{
clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = clsvgs_PSkillRelaBL.GetObjBymId(lngmId);
clsvgs_PSkillRelaENEx objvgs_PSkillRelaENEx = new clsvgs_PSkillRelaENEx();
clsvgs_PSkillRelaBL.CopyTo(objvgs_PSkillRelaEN, objvgs_PSkillRelaENEx);
return objvgs_PSkillRelaENEx;
}
}
}
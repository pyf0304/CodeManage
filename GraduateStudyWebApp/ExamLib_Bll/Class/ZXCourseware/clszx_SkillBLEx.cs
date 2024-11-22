
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SkillBLEx
 表名:zx_Skill(01120706)
 生成代码版本:2020.07.31.1
 生成日期:2020/08/03 09:32:16
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
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
public static class clszx_SkillBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <returns>目标对象=>clszx_SkillEN:objzx_SkillENT</returns>
 public static clszx_SkillENEx CopyToEx(this clszx_SkillEN objzx_SkillENS)
{
try
{
 clszx_SkillENEx objzx_SkillENT = new clszx_SkillENEx();
clszx_SkillBL.zx_SkillDA.CopyTo(objzx_SkillENS, objzx_SkillENT);
 return objzx_SkillENT;
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
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <returns>目标对象=>clszx_SkillEN:objzx_SkillENT</returns>
 public static clszx_SkillEN CopyTo(this clszx_SkillENEx objzx_SkillENS)
{
try
{
 clszx_SkillEN objzx_SkillENT = new clszx_SkillEN();
clszx_SkillBL.CopyTo(objzx_SkillENS, objzx_SkillENT);
 return objzx_SkillENT;
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
 /// 中学技能表(zx_Skill)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_SkillBLEx : clszx_SkillBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_SkillDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_SkillDAEx zx_SkillDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_SkillDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <returns>目标对象=>clszx_SkillEN:objzx_SkillENT</returns>
 public static clszx_SkillENEx CopyToEx(clszx_SkillEN objzx_SkillENS)
{
try
{
 clszx_SkillENEx objzx_SkillENT = new clszx_SkillENEx();
clszx_SkillBL.zx_SkillDA.CopyTo(objzx_SkillENS, objzx_SkillENT);
 return objzx_SkillENT;
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
public static List<clszx_SkillENEx> GetObjExLst(string strCondition)
{
List <clszx_SkillEN> arrObjLst = clszx_SkillBL.GetObjLst(strCondition);
List <clszx_SkillENEx> arrObjExLst = new List<clszx_SkillENEx>();
foreach (clszx_SkillEN objInFor in arrObjLst)
{
clszx_SkillENEx objzx_SkillENEx = new clszx_SkillENEx();
clszx_SkillBL.CopyTo(objInFor, objzx_SkillENEx);
arrObjExLst.Add(objzx_SkillENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_SkillENEx GetObjExBySkillId(string strSkillId)
{
clszx_SkillEN objzx_SkillEN = clszx_SkillBL.GetObjByzxSkillId(strSkillId);
clszx_SkillENEx objzx_SkillENEx = new clszx_SkillENEx();
clszx_SkillBL.CopyTo(objzx_SkillEN, objzx_SkillENEx);
return objzx_SkillENEx;
}
}
}
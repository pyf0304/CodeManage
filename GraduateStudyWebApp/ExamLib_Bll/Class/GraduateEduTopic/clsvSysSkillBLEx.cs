
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysSkillBLEx
 表名:vSysSkill(01120653)
 生成代码版本:2020.06.27.2
 生成日期:2020/06/30 16:02:51
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
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
public static class clsvSysSkillBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvSysSkillENS">源对象</param>
 /// <returns>目标对象=>clsvSysSkillEN:objvSysSkillENT</returns>
 public static clsvSysSkillENEx CopyToEx(this clsvSysSkillEN objvSysSkillENS)
{
try
{
 clsvSysSkillENEx objvSysSkillENT = new clsvSysSkillENEx();
clsvSysSkillBL.vSysSkillDA.CopyTo(objvSysSkillENS, objvSysSkillENT);
 return objvSysSkillENT;
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
 /// <param name = "objvSysSkillENS">源对象</param>
 /// <returns>目标对象=>clsvSysSkillEN:objvSysSkillENT</returns>
 public static clsvSysSkillEN CopyTo(this clsvSysSkillENEx objvSysSkillENS)
{
try
{
 clsvSysSkillEN objvSysSkillENT = new clsvSysSkillEN();
clsvSysSkillBL.CopyTo(objvSysSkillENS, objvSysSkillENT);
 return objvSysSkillENT;
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
 /// 技能表视图(vSysSkill)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvSysSkillBLEx : clsvSysSkillBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvSysSkillDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvSysSkillDAEx vSysSkillDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvSysSkillDAEx();
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
public static List<clsvSysSkillENEx> GetObjExLst(string strCondition)
{
List <clsvSysSkillEN> arrObjLst = clsvSysSkillBL.GetObjLst(strCondition);
List <clsvSysSkillENEx> arrObjExLst = new List<clsvSysSkillENEx>();
foreach (clsvSysSkillEN objInFor in arrObjLst)
{
clsvSysSkillENEx objvSysSkillENEx = new clsvSysSkillENEx();
clsvSysSkillBL.CopyTo(objInFor, objvSysSkillENEx);
arrObjExLst.Add(objvSysSkillENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvSysSkillENEx GetObjExBySkillId(string strSkillId)
{
clsvSysSkillEN objvSysSkillEN = clsvSysSkillBL.GetObjBySkillId(strSkillId);
clsvSysSkillENEx objvSysSkillENEx = new clsvSysSkillENEx();
clsvSysSkillBL.CopyTo(objvSysSkillEN, objvSysSkillENEx);
return objvSysSkillENEx;
}
}
}
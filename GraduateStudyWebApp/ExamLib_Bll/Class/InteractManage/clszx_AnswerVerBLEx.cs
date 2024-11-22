
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerVerBLEx
 表名:zx_AnswerVer(01120868)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 06:12:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_zx_AnswerVerEx: RelatedActions_zx_AnswerVer
{
public override bool UpdRelaTabDate(long lngAnswerVId, string strOpUser)
{
return true;
}
}
public static class  clszx_AnswerVerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerVerEN:objzx_AnswerVerENT</returns>
 public static clszx_AnswerVerENEx CopyToEx(this clszx_AnswerVerEN objzx_AnswerVerENS)
{
try
{
 clszx_AnswerVerENEx objzx_AnswerVerENT = new clszx_AnswerVerENEx();
clszx_AnswerVerBL.zx_AnswerVerDA.CopyTo(objzx_AnswerVerENS, objzx_AnswerVerENT);
 return objzx_AnswerVerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objzx_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerVerEN:objzx_AnswerVerENT</returns>
 public static clszx_AnswerVerEN CopyTo(this clszx_AnswerVerENEx objzx_AnswerVerENS)
{
try
{
 clszx_AnswerVerEN objzx_AnswerVerENT = new clszx_AnswerVerEN();
clszx_AnswerVerBL.CopyTo(objzx_AnswerVerENS, objzx_AnswerVerENT);
 return objzx_AnswerVerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 中学答疑回答历史Ver(zx_AnswerVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clszx_AnswerVerBLEx : clszx_AnswerVerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_AnswerVerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_AnswerVerDAEx zx_AnswerVerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_AnswerVerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerVerEN:objzx_AnswerVerENT</returns>
 public static clszx_AnswerVerENEx CopyToEx(clszx_AnswerVerEN objzx_AnswerVerENS)
{
try
{
 clszx_AnswerVerENEx objzx_AnswerVerENT = new clszx_AnswerVerENEx();
clszx_AnswerVerBL.zx_AnswerVerDA.CopyTo(objzx_AnswerVerENS, objzx_AnswerVerENT);
 return objzx_AnswerVerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
public static List<clszx_AnswerVerENEx> GetObjExLst(string strCondition)
{
List <clszx_AnswerVerEN> arrObjLst = clszx_AnswerVerBL.GetObjLst(strCondition);
List <clszx_AnswerVerENEx> arrObjExLst = new List<clszx_AnswerVerENEx>();
foreach (clszx_AnswerVerEN objInFor in arrObjLst)
{
clszx_AnswerVerENEx objzx_AnswerVerENEx = new clszx_AnswerVerENEx();
clszx_AnswerVerBL.CopyTo(objInFor, objzx_AnswerVerENEx);
arrObjExLst.Add(objzx_AnswerVerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_AnswerVerENEx GetObjExByAnswerVId(long lngAnswerVId)
{
clszx_AnswerVerEN objzx_AnswerVerEN = clszx_AnswerVerBL.GetObjByAnswerVId(lngAnswerVId);
clszx_AnswerVerENEx objzx_AnswerVerENEx = new clszx_AnswerVerENEx();
clszx_AnswerVerBL.CopyTo(objzx_AnswerVerEN, objzx_AnswerVerENEx);
return objzx_AnswerVerENEx;
}
}
}
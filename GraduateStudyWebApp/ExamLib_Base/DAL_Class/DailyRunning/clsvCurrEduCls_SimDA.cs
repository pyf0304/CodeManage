﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SimDA
 表名:vCurrEduCls_Sim(01120951)
 * 版本:2023.10.12.1(服务器:WIN-SRV103-116)
 日期:2023/10/28 09:48:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// vCurrEduCls_Sim(vCurrEduCls_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCurrEduCls_SimDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsvCurrEduCls_SimEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvCurrEduCls_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduCls_SimEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsvCurrEduCls_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCurrEduCls_SimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCurrEduCls)
{
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCurrEduCls_Sim中,检查关键字,长度不正确!(clsvCurrEduCls_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCurrEduCls_Sim中,关键字不能为空 或 null!(clsvCurrEduCls_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCurrEduCls_SimDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCurrEduCls_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable_vCurrEduCls_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vCurrEduCls_Sim.* from vCurrEduCls_Sim Left Join {1} on {2} where {3} and vCurrEduCls_Sim.IdCurrEduCls not in (Select top {5} vCurrEduCls_Sim.IdCurrEduCls from vCurrEduCls_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from vCurrEduCls_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from vCurrEduCls_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vCurrEduCls_Sim.* from vCurrEduCls_Sim Left Join {1} on {2} where {3} and vCurrEduCls_Sim.IdCurrEduCls not in (Select top {5} vCurrEduCls_Sim.IdCurrEduCls from vCurrEduCls_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from vCurrEduCls_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Sim where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from vCurrEduCls_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvCurrEduCls_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA:GetObjLst)", objException.Message));
}
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetObjLst)", objException.Message));
}
objvCurrEduCls_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvCurrEduCls_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetObjLst)", objException.Message));
}
objvCurrEduCls_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCurrEduCls_Sim(ref clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where IdCurrEduCls = " + "'"+ objvCurrEduCls_SimEN.IdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCurrEduCls_SimEN.IdCurrEduCls = objDT.Rows[0][convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SimEN.CurrEduClsId = objDT.Rows[0][convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduCls_SimEN.EduClsName = objDT.Rows[0][convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SimEN.EduClsTypeId = objDT.Rows[0][convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SimEN.CourseId = objDT.Rows[0][convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduCls_SimEN.IdXzCollege = objDT.Rows[0][convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SimEN.IdXzMajor = objDT.Rows[0][convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetvCurrEduCls_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public clsvCurrEduCls_SimEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
 objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetObjByIdCurrEduCls)", objException.Message));
}
return objvCurrEduCls_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCurrEduCls_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN()
{
IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(), //教学班类型Id
CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(), //课程Id
IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim() //专业流水号
};
objvCurrEduCls_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduCls_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCurrEduCls_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetObjByDataRowvCurrEduCls_Sim)", objException.Message));
}
objvCurrEduCls_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduCls_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCurrEduCls_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCurrEduCls_SimDA: GetObjByDataRow)", objException.Message));
}
objvCurrEduCls_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduCls_SimEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduCls_SimEN._CurrTabName, convCurrEduCls_Sim.IdCurrEduCls, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduCls_SimEN._CurrTabName, convCurrEduCls_Sim.IdCurrEduCls, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduCls from vCurrEduCls_Sim where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduCls from vCurrEduCls_Sim where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduCls_Sim", "IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCurrEduCls_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduCls_Sim", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCurrEduCls_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimENS">源对象</param>
 /// <param name = "objvCurrEduCls_SimENT">目标对象</param>
public void CopyTo(clsvCurrEduCls_SimEN objvCurrEduCls_SimENS, clsvCurrEduCls_SimEN objvCurrEduCls_SimENT)
{
objvCurrEduCls_SimENT.IdCurrEduCls = objvCurrEduCls_SimENS.IdCurrEduCls; //教学班流水号
objvCurrEduCls_SimENT.CurrEduClsId = objvCurrEduCls_SimENS.CurrEduClsId; //教学班Id
objvCurrEduCls_SimENT.EduClsName = objvCurrEduCls_SimENS.EduClsName; //教学班名
objvCurrEduCls_SimENT.EduClsTypeId = objvCurrEduCls_SimENS.EduClsTypeId; //教学班类型Id
objvCurrEduCls_SimENT.CourseId = objvCurrEduCls_SimENS.CourseId; //课程Id
objvCurrEduCls_SimENT.IdXzCollege = objvCurrEduCls_SimENS.IdXzCollege; //学院流水号
objvCurrEduCls_SimENT.IdXzMajor = objvCurrEduCls_SimENS.IdXzMajor; //专业流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.IdCurrEduCls, 8, convCurrEduCls_Sim.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.CurrEduClsId, 15, convCurrEduCls_Sim.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.EduClsName, 100, convCurrEduCls_Sim.EduClsName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.EduClsTypeId, 4, convCurrEduCls_Sim.EduClsTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.CourseId, 8, convCurrEduCls_Sim.CourseId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.IdXzCollege, 4, convCurrEduCls_Sim.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SimEN.IdXzMajor, 8, convCurrEduCls_Sim.IdXzMajor);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.IdCurrEduCls, convCurrEduCls_Sim.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.CurrEduClsId, convCurrEduCls_Sim.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.EduClsName, convCurrEduCls_Sim.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.EduClsTypeId, convCurrEduCls_Sim.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.CourseId, convCurrEduCls_Sim.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.IdXzCollege, convCurrEduCls_Sim.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SimEN.IdXzMajor, convCurrEduCls_Sim.IdXzMajor);
//检查外键字段长度
 objvCurrEduCls_SimEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCurrEduCls()
{
//获取某学院所有专业信息
string strSQL = "select IdCurrEduCls, EduClsName from vCurrEduCls_Sim ";
 clsSpecSQLforSql mySql = clsvCurrEduCls_SimDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduCls_SimEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduCls_SimEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
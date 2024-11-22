﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogic_User_SimDA
 表名:vgs_KnowledgesLogic_User_Sim(01120933)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:57:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// v知识点逻辑用户关系_Sim(vgs_KnowledgesLogic_User_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_KnowledgesLogic_User_SimDA : clsCommBase4DA
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
 return clsvgs_KnowledgesLogic_User_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_KnowledgesLogic_User_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_KnowledgesLogic_User_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_KnowledgesLogic_User_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_KnowledgesLogic_User_SimEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_KnowledgesLogic_User_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable_vgs_KnowledgesLogic_User_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_KnowledgesLogic_User_Sim.* from vgs_KnowledgesLogic_User_Sim Left Join {1} on {2} where {3} and vgs_KnowledgesLogic_User_Sim.mId not in (Select top {5} vgs_KnowledgesLogic_User_Sim.mId from vgs_KnowledgesLogic_User_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1} and mId not in (Select top {2} mId from vgs_KnowledgesLogic_User_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1} and mId not in (Select top {3} mId from vgs_KnowledgesLogic_User_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_KnowledgesLogic_User_Sim.* from vgs_KnowledgesLogic_User_Sim Left Join {1} on {2} where {3} and vgs_KnowledgesLogic_User_Sim.mId not in (Select top {5} vgs_KnowledgesLogic_User_Sim.mId from vgs_KnowledgesLogic_User_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1} and mId not in (Select top {2} mId from vgs_KnowledgesLogic_User_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_KnowledgesLogic_User_Sim where {1} and mId not in (Select top {3} mId from vgs_KnowledgesLogic_User_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA:GetObjLst)", objException.Message));
}
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = TransNullToInt(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetObjLst)", objException.Message));
}
objvgs_KnowledgesLogic_User_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
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
public List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = TransNullToInt(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetObjLst)", objException.Message));
}
objvgs_KnowledgesLogic_User_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_KnowledgesLogic_User_Sim(ref clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where mId = " + ""+ objvgs_KnowledgesLogic_User_SimEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_KnowledgesLogic_User_SimEN.mId = TransNullToInt(objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.ClassName = objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.CourseId = objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_KnowledgesLogic_User_SimEN.UserId = objDT.Rows[0][convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: Getvgs_KnowledgesLogic_User_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_KnowledgesLogic_User_SimEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
 objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetObjBymId)", objException.Message));
}
return objvgs_KnowledgesLogic_User_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_KnowledgesLogic_User_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
strSQL = "Select * from vgs_KnowledgesLogic_User_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN()
{
mId = TransNullToInt(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()), //mId
CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(), //知识点Id
KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(), //知识点图Id
ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(), //样式名称
CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(), //课程Id
IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim() //用户ID
};
objvgs_KnowledgesLogic_User_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_KnowledgesLogic_User_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_KnowledgesLogic_User_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = TransNullToInt(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetObjByDataRowvgs_KnowledgesLogic_User_Sim)", objException.Message));
}
objvgs_KnowledgesLogic_User_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_KnowledgesLogic_User_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_KnowledgesLogic_User_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = TransNullToInt(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA: GetObjByDataRow)", objException.Message));
}
objvgs_KnowledgesLogic_User_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_KnowledgesLogic_User_SimEN;
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
objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_KnowledgesLogic_User_SimEN._CurrTabName, convgs_KnowledgesLogic_User_Sim.mId, 8, "");
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
objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_KnowledgesLogic_User_SimEN._CurrTabName, convgs_KnowledgesLogic_User_Sim.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_KnowledgesLogic_User_Sim where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_KnowledgesLogic_User_Sim where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_KnowledgesLogic_User_Sim", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_KnowledgesLogic_User_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_KnowledgesLogic_User_Sim", strCondition))
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
objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_KnowledgesLogic_User_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimENS">源对象</param>
 /// <param name = "objvgs_KnowledgesLogic_User_SimENT">目标对象</param>
public void CopyTo(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENS, clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENT)
{
objvgs_KnowledgesLogic_User_SimENT.mId = objvgs_KnowledgesLogic_User_SimENS.mId; //mId
objvgs_KnowledgesLogic_User_SimENT.CourseKnowledgeId = objvgs_KnowledgesLogic_User_SimENS.CourseKnowledgeId; //知识点Id
objvgs_KnowledgesLogic_User_SimENT.KnowledgeGraphId = objvgs_KnowledgesLogic_User_SimENS.KnowledgeGraphId; //知识点图Id
objvgs_KnowledgesLogic_User_SimENT.ClassName = objvgs_KnowledgesLogic_User_SimENS.ClassName; //样式名称
objvgs_KnowledgesLogic_User_SimENT.CourseId = objvgs_KnowledgesLogic_User_SimENS.CourseId; //课程Id
objvgs_KnowledgesLogic_User_SimENT.IdCurrEduCls = objvgs_KnowledgesLogic_User_SimENS.IdCurrEduCls; //教学班流水号
objvgs_KnowledgesLogic_User_SimENT.UserId = objvgs_KnowledgesLogic_User_SimENS.UserId; //用户ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId, 8, convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId, 10, convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objvgs_KnowledgesLogic_User_SimEN.ClassName, 100, convgs_KnowledgesLogic_User_Sim.ClassName);
clsCheckSql.CheckFieldLen(objvgs_KnowledgesLogic_User_SimEN.CourseId, 8, convgs_KnowledgesLogic_User_Sim.CourseId);
clsCheckSql.CheckFieldLen(objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls, 8, convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_KnowledgesLogic_User_SimEN.UserId, 18, convgs_KnowledgesLogic_User_Sim.UserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId, convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId, convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
clsCheckSql.CheckSqlInjection4Field(objvgs_KnowledgesLogic_User_SimEN.ClassName, convgs_KnowledgesLogic_User_Sim.ClassName);
clsCheckSql.CheckSqlInjection4Field(objvgs_KnowledgesLogic_User_SimEN.CourseId, convgs_KnowledgesLogic_User_Sim.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls, convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_KnowledgesLogic_User_SimEN.UserId, convgs_KnowledgesLogic_User_Sim.UserId);
//检查外键字段长度
 objvgs_KnowledgesLogic_User_SimEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vgs_KnowledgesLogic_User_Sim(v知识点逻辑用户关系_Sim),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.UserId);
 if (objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphId is null");
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
}
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId);
 if (objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
}
return sbCondition.ToString();
}

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
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
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
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
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
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_KnowledgesLogic_User_SimEN._CurrTabName);
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
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_KnowledgesLogic_User_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_KnowledgesLogic_User_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
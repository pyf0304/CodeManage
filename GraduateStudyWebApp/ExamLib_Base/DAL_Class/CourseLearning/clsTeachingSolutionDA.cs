﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingSolutionDA
 表名:TeachingSolution(01120137)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// 教学方案(TeachingSolution)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachingSolutionDA : clsCommBase4DA
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
 return clsTeachingSolutionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachingSolutionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingSolutionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachingSolutionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachingSolutionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTeachingSolutionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTeachingSolutionId)
{
strTeachingSolutionId = strTeachingSolutionId.Replace("'", "''");
if (strTeachingSolutionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TeachingSolution中,检查关键字,长度不正确!(clsTeachingSolutionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTeachingSolutionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TeachingSolution中,关键字不能为空 或 null!(clsTeachingSolutionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingSolutionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTeachingSolutionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachingSolution(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable_TeachingSolution)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingSolution.* from TeachingSolution Left Join {1} on {2} where {3} and TeachingSolution.TeachingSolutionId not in (Select top {5} TeachingSolution.TeachingSolutionId from TeachingSolution Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1} and TeachingSolutionId not in (Select top {2} TeachingSolutionId from TeachingSolution where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1} and TeachingSolutionId not in (Select top {3} TeachingSolutionId from TeachingSolution where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingSolution.* from TeachingSolution Left Join {1} on {2} where {3} and TeachingSolution.TeachingSolutionId not in (Select top {5} TeachingSolution.TeachingSolutionId from TeachingSolution Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1} and TeachingSolutionId not in (Select top {2} TeachingSolutionId from TeachingSolution where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingSolution where {1} and TeachingSolutionId not in (Select top {3} TeachingSolutionId from TeachingSolution where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachingSolutionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachingSolutionDA:GetObjLst)", objException.Message));
}
List<clsTeachingSolutionEN> arrObjLst = new List<clsTeachingSolutionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN();
try
{
objTeachingSolutionEN.TeachingSolutionId = objRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objTeachingSolutionEN.TeachingSolutionName = objRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objTeachingSolutionEN.CourseId = objRow[conTeachingSolution.CourseId].ToString().Trim(); //课程Id
objTeachingSolutionEN.IdTeacher = objRow[conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objTeachingSolutionEN.BriefIntroduction = objRow[conTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objTeachingSolutionEN.UpdDate = objRow[conTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objTeachingSolutionEN.UpdUser = objRow[conTeachingSolution.UpdUser] == DBNull.Value ? null : objRow[conTeachingSolution.UpdUser].ToString().Trim(); //修改人
objTeachingSolutionEN.Memo = objRow[conTeachingSolution.Memo] == DBNull.Value ? null : objRow[conTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingSolutionDA: GetObjLst)", objException.Message));
}
objTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingSolutionEN);
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
public List<clsTeachingSolutionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachingSolutionDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachingSolutionEN> arrObjLst = new List<clsTeachingSolutionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN();
try
{
objTeachingSolutionEN.TeachingSolutionId = objRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objTeachingSolutionEN.TeachingSolutionName = objRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objTeachingSolutionEN.CourseId = objRow[conTeachingSolution.CourseId].ToString().Trim(); //课程Id
objTeachingSolutionEN.IdTeacher = objRow[conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objTeachingSolutionEN.BriefIntroduction = objRow[conTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objTeachingSolutionEN.UpdDate = objRow[conTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objTeachingSolutionEN.UpdUser = objRow[conTeachingSolution.UpdUser] == DBNull.Value ? null : objRow[conTeachingSolution.UpdUser].ToString().Trim(); //修改人
objTeachingSolutionEN.Memo = objRow[conTeachingSolution.Memo] == DBNull.Value ? null : objRow[conTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingSolutionDA: GetObjLst)", objException.Message));
}
objTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingSolutionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachingSolution(ref clsTeachingSolutionEN objTeachingSolutionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where TeachingSolutionId = " + "'"+ objTeachingSolutionEN.TeachingSolutionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachingSolutionEN.TeachingSolutionId = objDT.Rows[0][conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objTeachingSolutionEN.TeachingSolutionName = objDT.Rows[0][conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objTeachingSolutionEN.CourseId = objDT.Rows[0][conTeachingSolution.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objTeachingSolutionEN.IdTeacher = objDT.Rows[0][conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingSolutionEN.BriefIntroduction = objDT.Rows[0][conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachingSolutionEN.UpdDate = objDT.Rows[0][conTeachingSolution.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingSolutionEN.UpdUser = objDT.Rows[0][conTeachingSolution.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingSolutionEN.Memo = objDT.Rows[0][conTeachingSolution.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachingSolutionDA: GetTeachingSolution)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachingSolutionEN GetObjByTeachingSolutionId(string strTeachingSolutionId)
{
CheckPrimaryKey(strTeachingSolutionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where TeachingSolutionId = " + "'"+ strTeachingSolutionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN();
try
{
 objTeachingSolutionEN.TeachingSolutionId = objRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objTeachingSolutionEN.TeachingSolutionName = objRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objTeachingSolutionEN.CourseId = objRow[conTeachingSolution.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objTeachingSolutionEN.IdTeacher = objRow[conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingSolutionEN.BriefIntroduction = objRow[conTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachingSolutionEN.UpdDate = objRow[conTeachingSolution.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingSolutionEN.UpdUser = objRow[conTeachingSolution.UpdUser] == DBNull.Value ? null : objRow[conTeachingSolution.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingSolutionEN.Memo = objRow[conTeachingSolution.Memo] == DBNull.Value ? null : objRow[conTeachingSolution.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachingSolutionDA: GetObjByTeachingSolutionId)", objException.Message));
}
return objTeachingSolutionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachingSolutionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN()
{
TeachingSolutionId = objRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(), //教学方案Id
TeachingSolutionName = objRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(), //教学方案名称
CourseId = objRow[conTeachingSolution.CourseId].ToString().Trim(), //课程Id
IdTeacher = objRow[conTeachingSolution.IdTeacher].ToString().Trim(), //教师流水号
BriefIntroduction = objRow[conTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[conTeachingSolution.BriefIntroduction].ToString().Trim(), //简介
UpdDate = objRow[conTeachingSolution.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conTeachingSolution.UpdUser] == DBNull.Value ? null : objRow[conTeachingSolution.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conTeachingSolution.Memo] == DBNull.Value ? null : objRow[conTeachingSolution.Memo].ToString().Trim() //备注
};
objTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingSolutionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachingSolutionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachingSolutionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN();
try
{
objTeachingSolutionEN.TeachingSolutionId = objRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objTeachingSolutionEN.TeachingSolutionName = objRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objTeachingSolutionEN.CourseId = objRow[conTeachingSolution.CourseId].ToString().Trim(); //课程Id
objTeachingSolutionEN.IdTeacher = objRow[conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objTeachingSolutionEN.BriefIntroduction = objRow[conTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objTeachingSolutionEN.UpdDate = objRow[conTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objTeachingSolutionEN.UpdUser = objRow[conTeachingSolution.UpdUser] == DBNull.Value ? null : objRow[conTeachingSolution.UpdUser].ToString().Trim(); //修改人
objTeachingSolutionEN.Memo = objRow[conTeachingSolution.Memo] == DBNull.Value ? null : objRow[conTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachingSolutionDA: GetObjByDataRowTeachingSolution)", objException.Message));
}
objTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingSolutionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachingSolutionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN();
try
{
objTeachingSolutionEN.TeachingSolutionId = objRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objTeachingSolutionEN.TeachingSolutionName = objRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objTeachingSolutionEN.CourseId = objRow[conTeachingSolution.CourseId].ToString().Trim(); //课程Id
objTeachingSolutionEN.IdTeacher = objRow[conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objTeachingSolutionEN.BriefIntroduction = objRow[conTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objTeachingSolutionEN.UpdDate = objRow[conTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objTeachingSolutionEN.UpdUser = objRow[conTeachingSolution.UpdUser] == DBNull.Value ? null : objRow[conTeachingSolution.UpdUser].ToString().Trim(); //修改人
objTeachingSolutionEN.Memo = objRow[conTeachingSolution.Memo] == DBNull.Value ? null : objRow[conTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachingSolutionDA: GetObjByDataRow)", objException.Message));
}
objTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingSolutionEN;
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
objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingSolutionEN._CurrTabName, conTeachingSolution.TeachingSolutionId, 8, "");
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
objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingSolutionEN._CurrTabName, conTeachingSolution.TeachingSolutionId, 8, strPrefix);
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TeachingSolutionId from TeachingSolution where " + strCondition;
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TeachingSolutionId from TeachingSolution where " + strCondition;
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
 /// <param name = "strTeachingSolutionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTeachingSolutionId)
{
CheckPrimaryKey(strTeachingSolutionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingSolution", "TeachingSolutionId = " + "'"+ strTeachingSolutionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachingSolutionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingSolution", strCondition))
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
objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachingSolution");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachingSolutionEN objTeachingSolutionEN)
 {
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingSolutionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingSolution");
objRow = objDS.Tables["TeachingSolution"].NewRow();
objRow[conTeachingSolution.TeachingSolutionId] = objTeachingSolutionEN.TeachingSolutionId; //教学方案Id
objRow[conTeachingSolution.TeachingSolutionName] = objTeachingSolutionEN.TeachingSolutionName; //教学方案名称
objRow[conTeachingSolution.CourseId] = objTeachingSolutionEN.CourseId; //课程Id
objRow[conTeachingSolution.IdTeacher] = objTeachingSolutionEN.IdTeacher; //教师流水号
 if (objTeachingSolutionEN.BriefIntroduction !=  "")
 {
objRow[conTeachingSolution.BriefIntroduction] = objTeachingSolutionEN.BriefIntroduction; //简介
 }
objRow[conTeachingSolution.UpdDate] = objTeachingSolutionEN.UpdDate; //修改日期
 if (objTeachingSolutionEN.UpdUser !=  "")
 {
objRow[conTeachingSolution.UpdUser] = objTeachingSolutionEN.UpdUser; //修改人
 }
 if (objTeachingSolutionEN.Memo !=  "")
 {
objRow[conTeachingSolution.Memo] = objTeachingSolutionEN.Memo; //备注
 }
objDS.Tables[clsTeachingSolutionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachingSolutionEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingSolutionEN objTeachingSolutionEN)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingSolutionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingSolutionEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionId);
 var strTeachingSolutionId = objTeachingSolutionEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionName);
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionName + "'");
 }
 
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.CourseId);
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.IdTeacher);
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.BriefIntroduction);
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBriefIntroduction + "'");
 }
 
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdDate);
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdUser);
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTeachingSolutionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.Memo);
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingSolution");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingSolutionEN objTeachingSolutionEN)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingSolutionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingSolutionEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionId);
 var strTeachingSolutionId = objTeachingSolutionEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionName);
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionName + "'");
 }
 
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.CourseId);
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.IdTeacher);
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.BriefIntroduction);
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBriefIntroduction + "'");
 }
 
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdDate);
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdUser);
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTeachingSolutionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.Memo);
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingSolution");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTeachingSolutionEN.TeachingSolutionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingSolutionEN objTeachingSolutionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingSolutionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingSolutionEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionId);
 var strTeachingSolutionId = objTeachingSolutionEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionName);
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionName + "'");
 }
 
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.CourseId);
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.IdTeacher);
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.BriefIntroduction);
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBriefIntroduction + "'");
 }
 
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdDate);
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdUser);
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTeachingSolutionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.Memo);
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingSolution");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTeachingSolutionEN.TeachingSolutionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingSolutionEN objTeachingSolutionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingSolutionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingSolutionEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionId);
 var strTeachingSolutionId = objTeachingSolutionEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.TeachingSolutionName);
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionName + "'");
 }
 
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.CourseId);
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.IdTeacher);
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.BriefIntroduction);
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBriefIntroduction + "'");
 }
 
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdDate);
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.UpdUser);
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTeachingSolutionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingSolution.Memo);
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingSolution");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachingSolutions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where TeachingSolutionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingSolution");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTeachingSolutionId = oRow[conTeachingSolution.TeachingSolutionId].ToString().Trim();
if (IsExist(strTeachingSolutionId))
{
 string strResult = "关键字变量值为:" + string.Format("TeachingSolutionId = {0}", strTeachingSolutionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachingSolutionEN._CurrTabName ].NewRow();
objRow[conTeachingSolution.TeachingSolutionId] = oRow[conTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objRow[conTeachingSolution.TeachingSolutionName] = oRow[conTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objRow[conTeachingSolution.CourseId] = oRow[conTeachingSolution.CourseId].ToString().Trim(); //课程Id
objRow[conTeachingSolution.IdTeacher] = oRow[conTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objRow[conTeachingSolution.BriefIntroduction] = oRow[conTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objRow[conTeachingSolution.UpdDate] = oRow[conTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objRow[conTeachingSolution.UpdUser] = oRow[conTeachingSolution.UpdUser].ToString().Trim(); //修改人
objRow[conTeachingSolution.Memo] = oRow[conTeachingSolution.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachingSolutionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachingSolutionEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachingSolutionEN objTeachingSolutionEN)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingSolutionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingSolution where TeachingSolutionId = " + "'"+ objTeachingSolutionEN.TeachingSolutionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachingSolutionEN._CurrTabName);
if (objDS.Tables[clsTeachingSolutionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TeachingSolutionId = " + "'"+ objTeachingSolutionEN.TeachingSolutionId+"'");
return false;
}
objRow = objDS.Tables[clsTeachingSolutionEN._CurrTabName].Rows[0];
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.TeachingSolutionId))
 {
objRow[conTeachingSolution.TeachingSolutionId] = objTeachingSolutionEN.TeachingSolutionId; //教学方案Id
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.TeachingSolutionName))
 {
objRow[conTeachingSolution.TeachingSolutionName] = objTeachingSolutionEN.TeachingSolutionName; //教学方案名称
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.CourseId))
 {
objRow[conTeachingSolution.CourseId] = objTeachingSolutionEN.CourseId; //课程Id
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.IdTeacher))
 {
objRow[conTeachingSolution.IdTeacher] = objTeachingSolutionEN.IdTeacher; //教师流水号
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.BriefIntroduction))
 {
objRow[conTeachingSolution.BriefIntroduction] = objTeachingSolutionEN.BriefIntroduction; //简介
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdDate))
 {
objRow[conTeachingSolution.UpdDate] = objTeachingSolutionEN.UpdDate; //修改日期
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdUser))
 {
objRow[conTeachingSolution.UpdUser] = objTeachingSolutionEN.UpdUser; //修改人
 }
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.Memo))
 {
objRow[conTeachingSolution.Memo] = objTeachingSolutionEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachingSolutionEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingSolutionEN objTeachingSolutionEN)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingSolutionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachingSolution Set ");
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.TeachingSolutionName))
 {
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionName, conTeachingSolution.TeachingSolutionName); //教学方案名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.TeachingSolutionName); //教学方案名称
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.CourseId))
 {
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conTeachingSolution.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.CourseId); //课程Id
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.IdTeacher))
 {
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeacher, conTeachingSolution.IdTeacher); //教师流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.IdTeacher); //教师流水号
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.BriefIntroduction))
 {
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBriefIntroduction, conTeachingSolution.BriefIntroduction); //简介
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.BriefIntroduction); //简介
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdDate))
 {
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingSolution.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.UpdDate); //修改日期
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdUser))
 {
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTeachingSolution.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.UpdUser); //修改人
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.Memo))
 {
 if (objTeachingSolutionEN.Memo !=  null)
 {
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingSolution.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TeachingSolutionId = '{0}'", objTeachingSolutionEN.TeachingSolutionId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachingSolutionEN objTeachingSolutionEN, string strCondition)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingSolutionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingSolution Set ");
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.TeachingSolutionName))
 {
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionName = '{0}',", strTeachingSolutionName); //教学方案名称
 }
 else
 {
 sbSQL.Append(" TeachingSolutionName = null,"); //教学方案名称
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.CourseId))
 {
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.IdTeacher))
 {
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeacher = '{0}',", strIdTeacher); //教师流水号
 }
 else
 {
 sbSQL.Append(" IdTeacher = null,"); //教师流水号
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.BriefIntroduction))
 {
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BriefIntroduction = '{0}',", strBriefIntroduction); //简介
 }
 else
 {
 sbSQL.Append(" BriefIntroduction = null,"); //简介
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdDate))
 {
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdUser))
 {
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.Memo))
 {
 if (objTeachingSolutionEN.Memo !=  null)
 {
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachingSolutionEN objTeachingSolutionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingSolutionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingSolution Set ");
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.TeachingSolutionName))
 {
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionName = '{0}',", strTeachingSolutionName); //教学方案名称
 }
 else
 {
 sbSQL.Append(" TeachingSolutionName = null,"); //教学方案名称
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.CourseId))
 {
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.IdTeacher))
 {
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeacher = '{0}',", strIdTeacher); //教师流水号
 }
 else
 {
 sbSQL.Append(" IdTeacher = null,"); //教师流水号
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.BriefIntroduction))
 {
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BriefIntroduction = '{0}',", strBriefIntroduction); //简介
 }
 else
 {
 sbSQL.Append(" BriefIntroduction = null,"); //简介
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdDate))
 {
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdUser))
 {
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.Memo))
 {
 if (objTeachingSolutionEN.Memo !=  null)
 {
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingSolutionEN objTeachingSolutionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingSolutionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingSolutionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingSolutionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingSolution Set ");
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.TeachingSolutionName))
 {
 if (objTeachingSolutionEN.TeachingSolutionName !=  null)
 {
 var strTeachingSolutionName = objTeachingSolutionEN.TeachingSolutionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionName, conTeachingSolution.TeachingSolutionName); //教学方案名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.TeachingSolutionName); //教学方案名称
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.CourseId))
 {
 if (objTeachingSolutionEN.CourseId  ==  "")
 {
 objTeachingSolutionEN.CourseId = null;
 }
 if (objTeachingSolutionEN.CourseId !=  null)
 {
 var strCourseId = objTeachingSolutionEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conTeachingSolution.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.CourseId); //课程Id
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.IdTeacher))
 {
 if (objTeachingSolutionEN.IdTeacher  ==  "")
 {
 objTeachingSolutionEN.IdTeacher = null;
 }
 if (objTeachingSolutionEN.IdTeacher !=  null)
 {
 var strIdTeacher = objTeachingSolutionEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeacher, conTeachingSolution.IdTeacher); //教师流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.IdTeacher); //教师流水号
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.BriefIntroduction))
 {
 if (objTeachingSolutionEN.BriefIntroduction !=  null)
 {
 var strBriefIntroduction = objTeachingSolutionEN.BriefIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBriefIntroduction, conTeachingSolution.BriefIntroduction); //简介
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.BriefIntroduction); //简介
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdDate))
 {
 if (objTeachingSolutionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingSolutionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingSolution.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.UpdDate); //修改日期
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.UpdUser))
 {
 if (objTeachingSolutionEN.UpdUser !=  null)
 {
 var strUpdUser = objTeachingSolutionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTeachingSolution.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.UpdUser); //修改人
 }
 }
 
 if (objTeachingSolutionEN.IsUpdated(conTeachingSolution.Memo))
 {
 if (objTeachingSolutionEN.Memo !=  null)
 {
 var strMemo = objTeachingSolutionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingSolution.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingSolution.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TeachingSolutionId = '{0}'", objTeachingSolutionEN.TeachingSolutionId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strTeachingSolutionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTeachingSolutionId) 
{
CheckPrimaryKey(strTeachingSolutionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTeachingSolutionId,
};
 objSQL.ExecSP("TeachingSolution_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTeachingSolutionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTeachingSolutionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTeachingSolutionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
//删除TeachingSolution本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingSolution where TeachingSolutionId = " + "'"+ strTeachingSolutionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachingSolution(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除TeachingSolution本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingSolution where TeachingSolutionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTeachingSolutionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTeachingSolutionId) 
{
CheckPrimaryKey(strTeachingSolutionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
//删除TeachingSolution本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingSolution where TeachingSolutionId = " + "'"+ strTeachingSolutionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachingSolution(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: DelTeachingSolution)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingSolution where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelTeachingSolutionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachingSolutionDA: DelTeachingSolutionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingSolution where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objTeachingSolutionENS">源对象</param>
 /// <param name = "objTeachingSolutionENT">目标对象</param>
public void CopyTo(clsTeachingSolutionEN objTeachingSolutionENS, clsTeachingSolutionEN objTeachingSolutionENT)
{
objTeachingSolutionENT.TeachingSolutionId = objTeachingSolutionENS.TeachingSolutionId; //教学方案Id
objTeachingSolutionENT.TeachingSolutionName = objTeachingSolutionENS.TeachingSolutionName; //教学方案名称
objTeachingSolutionENT.CourseId = objTeachingSolutionENS.CourseId; //课程Id
objTeachingSolutionENT.IdTeacher = objTeachingSolutionENS.IdTeacher; //教师流水号
objTeachingSolutionENT.BriefIntroduction = objTeachingSolutionENS.BriefIntroduction; //简介
objTeachingSolutionENT.UpdDate = objTeachingSolutionENS.UpdDate; //修改日期
objTeachingSolutionENT.UpdUser = objTeachingSolutionENS.UpdUser; //修改人
objTeachingSolutionENT.Memo = objTeachingSolutionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachingSolutionEN objTeachingSolutionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachingSolutionEN.TeachingSolutionName, conTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldNotNull(objTeachingSolutionEN.CourseId, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldNotNull(objTeachingSolutionEN.IdTeacher, conTeachingSolution.IdTeacher);
clsCheckSql.CheckFieldNotNull(objTeachingSolutionEN.UpdDate, conTeachingSolution.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.TeachingSolutionId, 8, conTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.TeachingSolutionName, 100, conTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.CourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.IdTeacher, 8, conTeachingSolution.IdTeacher);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.BriefIntroduction, 8000, conTeachingSolution.BriefIntroduction);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.UpdDate, 20, conTeachingSolution.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.UpdUser, 20, conTeachingSolution.UpdUser);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.Memo, 1000, conTeachingSolution.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeachingSolutionEN.CourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldForeignKey(objTeachingSolutionEN.IdTeacher, 8, conTeachingSolution.IdTeacher);
 objTeachingSolutionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachingSolutionEN objTeachingSolutionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.TeachingSolutionName, 100, conTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.CourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.IdTeacher, 8, conTeachingSolution.IdTeacher);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.BriefIntroduction, 8000, conTeachingSolution.BriefIntroduction);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.UpdDate, 20, conTeachingSolution.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.UpdUser, 20, conTeachingSolution.UpdUser);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.Memo, 1000, conTeachingSolution.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachingSolutionEN.CourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldForeignKey(objTeachingSolutionEN.IdTeacher, 8, conTeachingSolution.IdTeacher);
 objTeachingSolutionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachingSolutionEN objTeachingSolutionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.TeachingSolutionId, 8, conTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.TeachingSolutionName, 100, conTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.CourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.IdTeacher, 8, conTeachingSolution.IdTeacher);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.BriefIntroduction, 8000, conTeachingSolution.BriefIntroduction);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.UpdDate, 20, conTeachingSolution.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.UpdUser, 20, conTeachingSolution.UpdUser);
clsCheckSql.CheckFieldLen(objTeachingSolutionEN.Memo, 1000, conTeachingSolution.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.TeachingSolutionId, conTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.TeachingSolutionName, conTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.CourseId, conTeachingSolution.CourseId);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.IdTeacher, conTeachingSolution.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.BriefIntroduction, conTeachingSolution.BriefIntroduction);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.UpdDate, conTeachingSolution.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.UpdUser, conTeachingSolution.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objTeachingSolutionEN.Memo, conTeachingSolution.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachingSolutionEN.CourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldForeignKey(objTeachingSolutionEN.IdTeacher, 8, conTeachingSolution.IdTeacher);
 objTeachingSolutionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTeachingSolutionId()
{
//获取某学院所有专业信息
string strSQL = "select TeachingSolutionId, TeachingSolutionName from TeachingSolution ";
 clsSpecSQLforSql mySql = clsTeachingSolutionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TeachingSolution(教学方案),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTeachingSolutionEN objTeachingSolutionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingSolutionName = '{0}'", objTeachingSolutionEN.TeachingSolutionName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objTeachingSolutionEN.CourseId);
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingSolutionEN._CurrTabName);
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingSolutionEN._CurrTabName, strCondition);
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
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingSolutionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
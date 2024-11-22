﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnDetailDA
 表名:vKnowledgeLearnDetail(01120157)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:27
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
 /// v知识点学习情况(vKnowledgeLearnDetail)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvKnowledgeLearnDetailDA : clsCommBase4DA
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
 return clsvKnowledgeLearnDetailEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvKnowledgeLearnDetailEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvKnowledgeLearnDetailEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvKnowledgeLearnDetailEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvKnowledgeLearnDetailEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vKnowledgeLearnDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable_vKnowledgeLearnDetail)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vKnowledgeLearnDetail.* from vKnowledgeLearnDetail Left Join {1} on {2} where {3} and vKnowledgeLearnDetail.mId not in (Select top {5} vKnowledgeLearnDetail.mId from vKnowledgeLearnDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1} and mId not in (Select top {2} mId from vKnowledgeLearnDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1} and mId not in (Select top {3} mId from vKnowledgeLearnDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vKnowledgeLearnDetail.* from vKnowledgeLearnDetail Left Join {1} on {2} where {3} and vKnowledgeLearnDetail.mId not in (Select top {5} vKnowledgeLearnDetail.mId from vKnowledgeLearnDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1} and mId not in (Select top {2} mId from vKnowledgeLearnDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vKnowledgeLearnDetail where {1} and mId not in (Select top {3} mId from vKnowledgeLearnDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvKnowledgeLearnDetailEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA:GetObjLst)", objException.Message));
}
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = TransNullToInt(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetObjLst)", objException.Message));
}
objvKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
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
public List<clsvKnowledgeLearnDetailEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA:GetObjLstByTabName)", objException.Message));
}
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = TransNullToInt(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetObjLst)", objException.Message));
}
objvKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvKnowledgeLearnDetail(ref clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where mId = " + ""+ objvKnowledgeLearnDetailEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvKnowledgeLearnDetailEN.mId = TransNullToInt(objDT.Rows[0][convKnowledgeLearnDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvKnowledgeLearnDetailEN.UserId = objDT.Rows[0][convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvKnowledgeLearnDetailEN.UserName = objDT.Rows[0][convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvKnowledgeLearnDetailEN.CourseKnowledgeId = objDT.Rows[0][convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvKnowledgeLearnDetailEN.KnowledgeName = objDT.Rows[0][convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvKnowledgeLearnDetailEN.CourseId = objDT.Rows[0][convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvKnowledgeLearnDetailEN.CourseName = objDT.Rows[0][convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvKnowledgeLearnDetailEN.CourseChapterId = objDT.Rows[0][convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvKnowledgeLearnDetailEN.LearnDate = objDT.Rows[0][convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvKnowledgeLearnDetailEN.LearnModeId = objDT.Rows[0][convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id(字段类型:char,字段长度:4,是否可空:False)
 objvKnowledgeLearnDetailEN.LearnModeName = objDT.Rows[0][convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objvKnowledgeLearnDetailEN.IdCase = objDT.Rows[0][convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvKnowledgeLearnDetailEN.IdCaseType = objDT.Rows[0][convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objDT.Rows[0][convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握(字段类型:bit,字段长度:1,是否可空:False)
 objvKnowledgeLearnDetailEN.MasterDegree = TransNullToInt(objDT.Rows[0][convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度(字段类型:int,字段长度:4,是否可空:False)
 objvKnowledgeLearnDetailEN.MarkerId = objDT.Rows[0][convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objvKnowledgeLearnDetailEN.MarkTime = objDT.Rows[0][convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvKnowledgeLearnDetailEN.UpdDate = objDT.Rows[0][convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvKnowledgeLearnDetailEN.UpdUser = objDT.Rows[0][convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvKnowledgeLearnDetailEN.Memo = objDT.Rows[0][convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetvKnowledgeLearnDetail)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvKnowledgeLearnDetailEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
 objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id(字段类型:char,字段长度:4,是否可空:False)
 objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握(字段类型:bit,字段长度:1,是否可空:False)
 objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度(字段类型:int,字段长度:4,是否可空:False)
 objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetObjBymId)", objException.Message));
}
return objvKnowledgeLearnDetailEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvKnowledgeLearnDetailEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from vKnowledgeLearnDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN()
{
mId = TransNullToInt(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()), //mId
UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(), //用户ID
UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(), //用户名
CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(), //知识点Id
KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(), //知识点名称
CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(), //课程章节ID
LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(), //学习日期
LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(), //学习模式Id
LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(), //学习模式名
IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(), //案例流水号
IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(), //案例类型流水号
IsMaster = TransNullToBool(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()), //是否掌握
MasterDegree = TransNullToInt(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()), //掌握程度
MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(), //打分者
MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(), //批改时间
UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim() //备注
};
objvKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvKnowledgeLearnDetailEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvKnowledgeLearnDetailEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = TransNullToInt(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetObjByDataRowvKnowledgeLearnDetail)", objException.Message));
}
objvKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvKnowledgeLearnDetailEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvKnowledgeLearnDetailEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = TransNullToInt(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvKnowledgeLearnDetailDA: GetObjByDataRow)", objException.Message));
}
objvKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvKnowledgeLearnDetailEN;
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
objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvKnowledgeLearnDetailEN._CurrTabName, convKnowledgeLearnDetail.mId, 8, "");
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
objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvKnowledgeLearnDetailEN._CurrTabName, convKnowledgeLearnDetail.mId, 8, strPrefix);
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vKnowledgeLearnDetail where " + strCondition;
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vKnowledgeLearnDetail where " + strCondition;
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vKnowledgeLearnDetail", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvKnowledgeLearnDetailDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vKnowledgeLearnDetail", strCondition))
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
objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vKnowledgeLearnDetail");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objvKnowledgeLearnDetailENT">目标对象</param>
public void CopyTo(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENS, clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENT)
{
objvKnowledgeLearnDetailENT.mId = objvKnowledgeLearnDetailENS.mId; //mId
objvKnowledgeLearnDetailENT.UserId = objvKnowledgeLearnDetailENS.UserId; //用户ID
objvKnowledgeLearnDetailENT.UserName = objvKnowledgeLearnDetailENS.UserName; //用户名
objvKnowledgeLearnDetailENT.CourseKnowledgeId = objvKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objvKnowledgeLearnDetailENT.KnowledgeName = objvKnowledgeLearnDetailENS.KnowledgeName; //知识点名称
objvKnowledgeLearnDetailENT.CourseId = objvKnowledgeLearnDetailENS.CourseId; //课程Id
objvKnowledgeLearnDetailENT.CourseName = objvKnowledgeLearnDetailENS.CourseName; //课程名称
objvKnowledgeLearnDetailENT.CourseChapterId = objvKnowledgeLearnDetailENS.CourseChapterId; //课程章节ID
objvKnowledgeLearnDetailENT.LearnDate = objvKnowledgeLearnDetailENS.LearnDate; //学习日期
objvKnowledgeLearnDetailENT.LearnModeId = objvKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objvKnowledgeLearnDetailENT.LearnModeName = objvKnowledgeLearnDetailENS.LearnModeName; //学习模式名
objvKnowledgeLearnDetailENT.IdCase = objvKnowledgeLearnDetailENS.IdCase; //案例流水号
objvKnowledgeLearnDetailENT.IdCaseType = objvKnowledgeLearnDetailENS.IdCaseType; //案例类型流水号
objvKnowledgeLearnDetailENT.IsMaster = objvKnowledgeLearnDetailENS.IsMaster; //是否掌握
objvKnowledgeLearnDetailENT.MasterDegree = objvKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objvKnowledgeLearnDetailENT.MarkerId = objvKnowledgeLearnDetailENS.MarkerId; //打分者
objvKnowledgeLearnDetailENT.MarkTime = objvKnowledgeLearnDetailENS.MarkTime; //批改时间
objvKnowledgeLearnDetailENT.UpdDate = objvKnowledgeLearnDetailENS.UpdDate; //修改日期
objvKnowledgeLearnDetailENT.UpdUser = objvKnowledgeLearnDetailENS.UpdUser; //修改人
objvKnowledgeLearnDetailENT.Memo = objvKnowledgeLearnDetailENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.UserId, 18, convKnowledgeLearnDetail.UserId);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.UserName, 30, convKnowledgeLearnDetail.UserName);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.CourseKnowledgeId, 8, convKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.KnowledgeName, 100, convKnowledgeLearnDetail.KnowledgeName);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.CourseId, 8, convKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.CourseName, 100, convKnowledgeLearnDetail.CourseName);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.CourseChapterId, 8, convKnowledgeLearnDetail.CourseChapterId);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.LearnDate, 14, convKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.LearnModeId, 4, convKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.LearnModeName, 30, convKnowledgeLearnDetail.LearnModeName);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.IdCase, 8, convKnowledgeLearnDetail.IdCase);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.IdCaseType, 4, convKnowledgeLearnDetail.IdCaseType);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.MarkerId, 20, convKnowledgeLearnDetail.MarkerId);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.MarkTime, 14, convKnowledgeLearnDetail.MarkTime);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.UpdDate, 20, convKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.UpdUser, 20, convKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckFieldLen(objvKnowledgeLearnDetailEN.Memo, 1000, convKnowledgeLearnDetail.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.UserId, convKnowledgeLearnDetail.UserId);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.UserName, convKnowledgeLearnDetail.UserName);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.CourseKnowledgeId, convKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.KnowledgeName, convKnowledgeLearnDetail.KnowledgeName);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.CourseId, convKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.CourseName, convKnowledgeLearnDetail.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.CourseChapterId, convKnowledgeLearnDetail.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.LearnDate, convKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.LearnModeId, convKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.LearnModeName, convKnowledgeLearnDetail.LearnModeName);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.IdCase, convKnowledgeLearnDetail.IdCase);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.IdCaseType, convKnowledgeLearnDetail.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.MarkerId, convKnowledgeLearnDetail.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.MarkTime, convKnowledgeLearnDetail.MarkTime);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.UpdDate, convKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.UpdUser, convKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvKnowledgeLearnDetailEN.Memo, convKnowledgeLearnDetail.Memo);
//检查外键字段长度
 objvKnowledgeLearnDetailEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvKnowledgeLearnDetailEN._CurrTabName);
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvKnowledgeLearnDetailEN._CurrTabName, strCondition);
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
 objSQL = clsvKnowledgeLearnDetailDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
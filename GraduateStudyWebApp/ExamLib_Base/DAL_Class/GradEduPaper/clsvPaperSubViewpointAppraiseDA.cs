﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointAppraiseDA
 表名:vPaperSubViewpointAppraise(01120562)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// v子观点评论表(vPaperSubViewpointAppraise)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperSubViewpointAppraiseDA : clsCommBase4DA
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
 return clsvPaperSubViewpointAppraiseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperSubViewpointAppraiseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointAppraiseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperSubViewpointAppraiseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointAppraiseEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperSubViewpointAppraise(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable_vPaperSubViewpointAppraise)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperSubViewpointAppraise.* from vPaperSubViewpointAppraise Left Join {1} on {2} where {3} and vPaperSubViewpointAppraise.PaperSubViewpointAppraiseId not in (Select top {5} vPaperSubViewpointAppraise.PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1} and PaperSubViewpointAppraiseId not in (Select top {2} PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1} and PaperSubViewpointAppraiseId not in (Select top {3} PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperSubViewpointAppraise.* from vPaperSubViewpointAppraise Left Join {1} on {2} where {3} and vPaperSubViewpointAppraise.PaperSubViewpointAppraiseId not in (Select top {5} vPaperSubViewpointAppraise.PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1} and PaperSubViewpointAppraiseId not in (Select top {2} PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperSubViewpointAppraise where {1} and PaperSubViewpointAppraiseId not in (Select top {3} PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperSubViewpointAppraiseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA:GetObjLst)", objException.Message));
}
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = TransNullToInt(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetObjLst)", objException.Message));
}
objvPaperSubViewpointAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
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
public List<clsvPaperSubViewpointAppraiseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = TransNullToInt(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetObjLst)", objException.Message));
}
objvPaperSubViewpointAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperSubViewpointAppraise(ref clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where PaperSubViewpointAppraiseId = " + ""+ objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = TransNullToInt(objDT.Rows[0][convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvPaperSubViewpointAppraiseEN.SubViewpointId = TransNullToInt(objDT.Rows[0][convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperSubViewpointAppraiseEN.AppraiseScore = TransNullToFloat(objDT.Rows[0][convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointAppraiseEN.AppraiseContent = objDT.Rows[0][convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSubViewpointAppraiseEN.UpdDate = objDT.Rows[0][convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointAppraiseEN.Meno = objDT.Rows[0][convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSubViewpointAppraiseEN.RWTitle = objDT.Rows[0][convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointAppraiseEN.SubViewpointContent = objDT.Rows[0][convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperSubViewpointAppraiseEN.ExplainContent = objDT.Rows[0][convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointAppraiseEN.PaperRWId = objDT.Rows[0][convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointAppraiseEN.UpdUser = objDT.Rows[0][convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetvPaperSubViewpointAppraise)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId(long lngPaperSubViewpointAppraiseId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where PaperSubViewpointAppraiseId = " + ""+ lngPaperSubViewpointAppraiseId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
 objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetObjByPaperSubViewpointAppraiseId)", objException.Message));
}
return objvPaperSubViewpointAppraiseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperSubViewpointAppraiseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from vPaperSubViewpointAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN()
{
PaperSubViewpointAppraiseId = TransNullToInt(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()), //子观点评价Id
SubViewpointId = TransNullToInt(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()), //子观点Id
AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()), //打分
AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(), //评议内容
UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(), //修改日期
Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(), //备注
RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(), //读写标题
SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(), //详情内容
ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(), //说明内容
PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(), //课文阅读
UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim() //修改人
};
objvPaperSubViewpointAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSubViewpointAppraiseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperSubViewpointAppraiseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = TransNullToInt(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetObjByDataRowvPaperSubViewpointAppraise)", objException.Message));
}
objvPaperSubViewpointAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSubViewpointAppraiseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperSubViewpointAppraiseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = TransNullToInt(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = TransNullToInt(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperSubViewpointAppraiseDA: GetObjByDataRow)", objException.Message));
}
objvPaperSubViewpointAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperSubViewpointAppraiseEN;
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
objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperSubViewpointAppraiseEN._CurrTabName, convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, 8, "");
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
objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperSubViewpointAppraiseEN._CurrTabName, convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, 8, strPrefix);
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise where " + strCondition;
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperSubViewpointAppraiseId from vPaperSubViewpointAppraise where " + strCondition;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPaperSubViewpointAppraiseId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperSubViewpointAppraise", "PaperSubViewpointAppraiseId = " + ""+ lngPaperSubViewpointAppraiseId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperSubViewpointAppraiseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperSubViewpointAppraise", strCondition))
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
objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperSubViewpointAppraise");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objvPaperSubViewpointAppraiseENT">目标对象</param>
public void CopyTo(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENS, clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENT)
{
objvPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //子观点评价Id
objvPaperSubViewpointAppraiseENT.SubViewpointId = objvPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objvPaperSubViewpointAppraiseENT.AppraiseScore = objvPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objvPaperSubViewpointAppraiseENT.AppraiseContent = objvPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objvPaperSubViewpointAppraiseENT.UpdDate = objvPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objvPaperSubViewpointAppraiseENT.Meno = objvPaperSubViewpointAppraiseENS.Meno; //备注
objvPaperSubViewpointAppraiseENT.RWTitle = objvPaperSubViewpointAppraiseENS.RWTitle; //读写标题
objvPaperSubViewpointAppraiseENT.SubViewpointContent = objvPaperSubViewpointAppraiseENS.SubViewpointContent; //详情内容
objvPaperSubViewpointAppraiseENT.ExplainContent = objvPaperSubViewpointAppraiseENS.ExplainContent; //说明内容
objvPaperSubViewpointAppraiseENT.PaperRWId = objvPaperSubViewpointAppraiseENS.PaperRWId; //课文阅读
objvPaperSubViewpointAppraiseENT.UpdUser = objvPaperSubViewpointAppraiseENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.AppraiseContent, 2000, convPaperSubViewpointAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.UpdDate, 20, convPaperSubViewpointAppraise.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.Meno, 2000, convPaperSubViewpointAppraise.Meno);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.RWTitle, 50, convPaperSubViewpointAppraise.RWTitle);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.SubViewpointContent, 500, convPaperSubViewpointAppraise.SubViewpointContent);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.ExplainContent, 5000, convPaperSubViewpointAppraise.ExplainContent);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.PaperRWId, 8, convPaperSubViewpointAppraise.PaperRWId);
clsCheckSql.CheckFieldLen(objvPaperSubViewpointAppraiseEN.UpdUser, 20, convPaperSubViewpointAppraise.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.AppraiseContent, convPaperSubViewpointAppraise.AppraiseContent);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.UpdDate, convPaperSubViewpointAppraise.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.Meno, convPaperSubViewpointAppraise.Meno);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.RWTitle, convPaperSubViewpointAppraise.RWTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.SubViewpointContent, convPaperSubViewpointAppraise.SubViewpointContent);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.ExplainContent, convPaperSubViewpointAppraise.ExplainContent);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.PaperRWId, convPaperSubViewpointAppraise.PaperRWId);
clsCheckSql.CheckSqlInjection4Field(objvPaperSubViewpointAppraiseEN.UpdUser, convPaperSubViewpointAppraise.UpdUser);
//检查外键字段长度
 objvPaperSubViewpointAppraiseEN._IsCheckProperty = true;
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperSubViewpointAppraiseEN._CurrTabName);
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperSubViewpointAppraiseEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperSubViewpointAppraiseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
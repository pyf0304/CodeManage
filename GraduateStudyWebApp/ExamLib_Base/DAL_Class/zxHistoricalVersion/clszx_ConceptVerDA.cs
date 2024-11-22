
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConceptVerDA
 表名:zx_ConceptVer(01120740)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 概念版本(zx_ConceptVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ConceptVerDA : clsCommBase4DA
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
 return clszx_ConceptVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ConceptVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ConceptVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ConceptVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ConceptVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_ConceptVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable_zx_ConceptVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ConceptVer.* from zx_ConceptVer Left Join {1} on {2} where {3} and zx_ConceptVer.ConceptVId not in (Select top {5} zx_ConceptVer.ConceptVId from zx_ConceptVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1} and ConceptVId not in (Select top {2} ConceptVId from zx_ConceptVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1} and ConceptVId not in (Select top {3} ConceptVId from zx_ConceptVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ConceptVer.* from zx_ConceptVer Left Join {1} on {2} where {3} and zx_ConceptVer.ConceptVId not in (Select top {5} zx_ConceptVer.ConceptVId from zx_ConceptVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1} and ConceptVId not in (Select top {2} ConceptVId from zx_ConceptVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ConceptVer where {1} and ConceptVId not in (Select top {3} ConceptVId from zx_ConceptVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ConceptVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ConceptVerDA:GetObjLst)", objException.Message));
}
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = TransNullToInt(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = TransNullToBool(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ConceptVerDA: GetObjLst)", objException.Message));
}
objzx_ConceptVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ConceptVerEN);
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
public List<clszx_ConceptVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ConceptVerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = TransNullToInt(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = TransNullToBool(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ConceptVerDA: GetObjLst)", objException.Message));
}
objzx_ConceptVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ConceptVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_ConceptVer(ref clszx_ConceptVerEN objzx_ConceptVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where ConceptVId = " + ""+ objzx_ConceptVerEN.ConceptVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ConceptVerEN.ConceptVId = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.zxConceptId = objDT.Rows[0][conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.ConceptName = objDT.Rows[0][conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ConceptVerEN.ConceptContent = objDT.Rows[0][conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ConceptVerEN.TextId = objDT.Rows[0][conzx_ConceptVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ConceptVerEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.Score = TransNullToFloat(objDT.Rows[0][conzx_ConceptVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptVerEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptVerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptVerEN.CreateDate = objDT.Rows[0][conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptVerEN.UpdDate = objDT.Rows[0][conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptVerEN.UpdUser = objDT.Rows[0][conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptVerEN.IdCurrEduCls = objDT.Rows[0][conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.PdfContent = objDT.Rows[0][conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ConceptVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.zxShareId = objDT.Rows[0][conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ConceptVerEN.Memo = objDT.Rows[0][conzx_ConceptVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ConceptVerEN.PdfDivLet = objDT.Rows[0][conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.PdfDivTop = objDT.Rows[0][conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.PdfPageNumIn = objDT.Rows[0][conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.PdfZoom = objDT.Rows[0][conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.GroupTextId = objDT.Rows[0][conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ConceptVerDA: Getzx_ConceptVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngConceptVId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ConceptVerEN GetObjByConceptVId(long lngConceptVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where ConceptVId = " + ""+ lngConceptVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
 objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ConceptVerDA: GetObjByConceptVId)", objException.Message));
}
return objzx_ConceptVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ConceptVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN()
{
ConceptVId = TransNullToInt(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()), //ConceptVId
zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(), //概念Id
ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(), //概念名称
ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(), //概念内容
TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(), //课件Id
IsSubmit = TransNullToBool(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(), //修改人
IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(), //分享Id
Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim() //小组Id
};
objzx_ConceptVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ConceptVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ConceptVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ConceptVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = TransNullToInt(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = TransNullToBool(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ConceptVerDA: GetObjByDataRowzx_ConceptVer)", objException.Message));
}
objzx_ConceptVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ConceptVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ConceptVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = TransNullToInt(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = TransNullToBool(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ConceptVerDA: GetObjByDataRow)", objException.Message));
}
objzx_ConceptVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ConceptVerEN;
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
objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ConceptVerEN._CurrTabName, conzx_ConceptVer.ConceptVId, 8, "");
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
objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ConceptVerEN._CurrTabName, conzx_ConceptVer.ConceptVId, 8, strPrefix);
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ConceptVId from zx_ConceptVer where " + strCondition;
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ConceptVId from zx_ConceptVer where " + strCondition;
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
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngConceptVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ConceptVer", "ConceptVId = " + ""+ lngConceptVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ConceptVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ConceptVer", strCondition))
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
objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_ConceptVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ConceptVerEN objzx_ConceptVerEN)
 {
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ConceptVer");
objRow = objDS.Tables["zx_ConceptVer"].NewRow();
objRow[conzx_ConceptVer.zxConceptId] = objzx_ConceptVerEN.zxConceptId; //概念Id
 if (objzx_ConceptVerEN.ConceptName !=  "")
 {
objRow[conzx_ConceptVer.ConceptName] = objzx_ConceptVerEN.ConceptName; //概念名称
 }
 if (objzx_ConceptVerEN.ConceptContent !=  "")
 {
objRow[conzx_ConceptVer.ConceptContent] = objzx_ConceptVerEN.ConceptContent; //概念内容
 }
 if (objzx_ConceptVerEN.TextId !=  "")
 {
objRow[conzx_ConceptVer.TextId] = objzx_ConceptVerEN.TextId; //课件Id
 }
objRow[conzx_ConceptVer.IsSubmit] = objzx_ConceptVerEN.IsSubmit; //是否提交
objRow[conzx_ConceptVer.VoteCount] = objzx_ConceptVerEN.VoteCount; //点赞计数
objRow[conzx_ConceptVer.AppraiseCount] = objzx_ConceptVerEN.AppraiseCount; //评论数
objRow[conzx_ConceptVer.Score] = objzx_ConceptVerEN.Score; //评分
objRow[conzx_ConceptVer.StuScore] = objzx_ConceptVerEN.StuScore; //学生平均分
objRow[conzx_ConceptVer.TeaScore] = objzx_ConceptVerEN.TeaScore; //教师评分
 if (objzx_ConceptVerEN.CreateDate !=  "")
 {
objRow[conzx_ConceptVer.CreateDate] = objzx_ConceptVerEN.CreateDate; //建立日期
 }
 if (objzx_ConceptVerEN.UpdDate !=  "")
 {
objRow[conzx_ConceptVer.UpdDate] = objzx_ConceptVerEN.UpdDate; //修改日期
 }
 if (objzx_ConceptVerEN.UpdUser !=  "")
 {
objRow[conzx_ConceptVer.UpdUser] = objzx_ConceptVerEN.UpdUser; //修改人
 }
 if (objzx_ConceptVerEN.IdCurrEduCls !=  "")
 {
objRow[conzx_ConceptVer.IdCurrEduCls] = objzx_ConceptVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ConceptVerEN.PdfContent !=  "")
 {
objRow[conzx_ConceptVer.PdfContent] = objzx_ConceptVerEN.PdfContent; //Pdf内容
 }
objRow[conzx_ConceptVer.PdfPageNum] = objzx_ConceptVerEN.PdfPageNum; //Pdf页码
objRow[conzx_ConceptVer.CitationCount] = objzx_ConceptVerEN.CitationCount; //引用统计
objRow[conzx_ConceptVer.VersionCount] = objzx_ConceptVerEN.VersionCount; //版本统计
objRow[conzx_ConceptVer.zxShareId] = objzx_ConceptVerEN.zxShareId; //分享Id
 if (objzx_ConceptVerEN.Memo !=  "")
 {
objRow[conzx_ConceptVer.Memo] = objzx_ConceptVerEN.Memo; //备注
 }
 if (objzx_ConceptVerEN.PdfDivLet !=  "")
 {
objRow[conzx_ConceptVer.PdfDivLet] = objzx_ConceptVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ConceptVerEN.PdfDivTop !=  "")
 {
objRow[conzx_ConceptVer.PdfDivTop] = objzx_ConceptVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ConceptVerEN.PdfPageNumIn !=  "")
 {
objRow[conzx_ConceptVer.PdfPageNumIn] = objzx_ConceptVerEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_ConceptVer.PdfPageTop] = objzx_ConceptVerEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_ConceptVerEN.PdfZoom !=  "")
 {
objRow[conzx_ConceptVer.PdfZoom] = objzx_ConceptVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_ConceptVerEN.GroupTextId !=  "")
 {
objRow[conzx_ConceptVer.GroupTextId] = objzx_ConceptVerEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_ConceptVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ConceptVerEN._CurrTabName);
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxConceptId);
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptName);
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptContent);
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TextId);
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ConceptVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Score);
 arrValueListForInsert.Add(objzx_ConceptVerEN.Score.ToString());
 }
 
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.StuScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.StuScore.ToString());
 }
 
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CreateDate);
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdDate);
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdUser);
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfContent);
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxShareId);
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Memo);
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivLet);
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivTop);
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfZoom);
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.GroupTextId);
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ConceptVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxConceptId);
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptName);
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptContent);
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TextId);
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ConceptVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Score);
 arrValueListForInsert.Add(objzx_ConceptVerEN.Score.ToString());
 }
 
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.StuScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.StuScore.ToString());
 }
 
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CreateDate);
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdDate);
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdUser);
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfContent);
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxShareId);
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Memo);
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivLet);
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivTop);
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfZoom);
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.GroupTextId);
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ConceptVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ConceptVerEN objzx_ConceptVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxConceptId);
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptName);
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptContent);
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TextId);
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ConceptVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Score);
 arrValueListForInsert.Add(objzx_ConceptVerEN.Score.ToString());
 }
 
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.StuScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.StuScore.ToString());
 }
 
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CreateDate);
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdDate);
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdUser);
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfContent);
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxShareId);
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Memo);
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivLet);
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivTop);
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfZoom);
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.GroupTextId);
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ConceptVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ConceptVerEN objzx_ConceptVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxConceptId);
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptName);
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.ConceptContent);
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TextId);
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ConceptVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Score);
 arrValueListForInsert.Add(objzx_ConceptVerEN.Score.ToString());
 }
 
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.StuScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.StuScore.ToString());
 }
 
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptVerEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CreateDate);
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdDate);
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.UpdUser);
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfContent);
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptVerEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.zxShareId);
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.Memo);
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivLet);
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfDivTop);
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.PdfZoom);
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ConceptVer.GroupTextId);
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ConceptVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_ConceptVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where ConceptVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ConceptVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngConceptVId = TransNullToInt(oRow[conzx_ConceptVer.ConceptVId].ToString().Trim());
if (IsExist(lngConceptVId))
{
 string strResult = "关键字变量值为:" + string.Format("ConceptVId = {0}", lngConceptVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ConceptVerEN._CurrTabName ].NewRow();
objRow[conzx_ConceptVer.zxConceptId] = oRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objRow[conzx_ConceptVer.ConceptName] = oRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objRow[conzx_ConceptVer.ConceptContent] = oRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objRow[conzx_ConceptVer.TextId] = oRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objRow[conzx_ConceptVer.IsSubmit] = oRow[conzx_ConceptVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_ConceptVer.VoteCount] = oRow[conzx_ConceptVer.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_ConceptVer.AppraiseCount] = oRow[conzx_ConceptVer.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_ConceptVer.Score] = oRow[conzx_ConceptVer.Score].ToString().Trim(); //评分
objRow[conzx_ConceptVer.StuScore] = oRow[conzx_ConceptVer.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_ConceptVer.TeaScore] = oRow[conzx_ConceptVer.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_ConceptVer.CreateDate] = oRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_ConceptVer.UpdDate] = oRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_ConceptVer.UpdUser] = oRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_ConceptVer.IdCurrEduCls] = oRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_ConceptVer.PdfContent] = oRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_ConceptVer.PdfPageNum] = oRow[conzx_ConceptVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_ConceptVer.CitationCount] = oRow[conzx_ConceptVer.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_ConceptVer.VersionCount] = oRow[conzx_ConceptVer.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_ConceptVer.zxShareId] = oRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_ConceptVer.Memo] = oRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objRow[conzx_ConceptVer.PdfDivLet] = oRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_ConceptVer.PdfDivTop] = oRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_ConceptVer.PdfPageNumIn] = oRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_ConceptVer.PdfPageTop] = oRow[conzx_ConceptVer.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_ConceptVer.PdfZoom] = oRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_ConceptVer.GroupTextId] = oRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_ConceptVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ConceptVerEN._CurrTabName);
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
 /// <param name = "objzx_ConceptVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_ConceptVer where ConceptVId = " + ""+ objzx_ConceptVerEN.ConceptVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ConceptVerEN._CurrTabName);
if (objDS.Tables[clszx_ConceptVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ConceptVId = " + ""+ objzx_ConceptVerEN.ConceptVId+"");
return false;
}
objRow = objDS.Tables[clszx_ConceptVerEN._CurrTabName].Rows[0];
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxConceptId))
 {
objRow[conzx_ConceptVer.zxConceptId] = objzx_ConceptVerEN.zxConceptId; //概念Id
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptName))
 {
objRow[conzx_ConceptVer.ConceptName] = objzx_ConceptVerEN.ConceptName; //概念名称
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptContent))
 {
objRow[conzx_ConceptVer.ConceptContent] = objzx_ConceptVerEN.ConceptContent; //概念内容
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TextId))
 {
objRow[conzx_ConceptVer.TextId] = objzx_ConceptVerEN.TextId; //课件Id
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IsSubmit))
 {
objRow[conzx_ConceptVer.IsSubmit] = objzx_ConceptVerEN.IsSubmit; //是否提交
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VoteCount))
 {
objRow[conzx_ConceptVer.VoteCount] = objzx_ConceptVerEN.VoteCount; //点赞计数
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.AppraiseCount))
 {
objRow[conzx_ConceptVer.AppraiseCount] = objzx_ConceptVerEN.AppraiseCount; //评论数
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Score))
 {
objRow[conzx_ConceptVer.Score] = objzx_ConceptVerEN.Score; //评分
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.StuScore))
 {
objRow[conzx_ConceptVer.StuScore] = objzx_ConceptVerEN.StuScore; //学生平均分
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TeaScore))
 {
objRow[conzx_ConceptVer.TeaScore] = objzx_ConceptVerEN.TeaScore; //教师评分
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CreateDate))
 {
objRow[conzx_ConceptVer.CreateDate] = objzx_ConceptVerEN.CreateDate; //建立日期
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdDate))
 {
objRow[conzx_ConceptVer.UpdDate] = objzx_ConceptVerEN.UpdDate; //修改日期
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdUser))
 {
objRow[conzx_ConceptVer.UpdUser] = objzx_ConceptVerEN.UpdUser; //修改人
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IdCurrEduCls))
 {
objRow[conzx_ConceptVer.IdCurrEduCls] = objzx_ConceptVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfContent))
 {
objRow[conzx_ConceptVer.PdfContent] = objzx_ConceptVerEN.PdfContent; //Pdf内容
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNum))
 {
objRow[conzx_ConceptVer.PdfPageNum] = objzx_ConceptVerEN.PdfPageNum; //Pdf页码
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CitationCount))
 {
objRow[conzx_ConceptVer.CitationCount] = objzx_ConceptVerEN.CitationCount; //引用统计
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VersionCount))
 {
objRow[conzx_ConceptVer.VersionCount] = objzx_ConceptVerEN.VersionCount; //版本统计
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxShareId))
 {
objRow[conzx_ConceptVer.zxShareId] = objzx_ConceptVerEN.zxShareId; //分享Id
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Memo))
 {
objRow[conzx_ConceptVer.Memo] = objzx_ConceptVerEN.Memo; //备注
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivLet))
 {
objRow[conzx_ConceptVer.PdfDivLet] = objzx_ConceptVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivTop))
 {
objRow[conzx_ConceptVer.PdfDivTop] = objzx_ConceptVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNumIn))
 {
objRow[conzx_ConceptVer.PdfPageNumIn] = objzx_ConceptVerEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageTop))
 {
objRow[conzx_ConceptVer.PdfPageTop] = objzx_ConceptVerEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfZoom))
 {
objRow[conzx_ConceptVer.PdfZoom] = objzx_ConceptVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.GroupTextId))
 {
objRow[conzx_ConceptVer.GroupTextId] = objzx_ConceptVerEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_ConceptVerEN._CurrTabName);
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_ConceptVer Set ");
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxConceptId))
 {
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxConceptId, conzx_ConceptVer.zxConceptId); //概念Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.zxConceptId); //概念Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptName))
 {
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptName, conzx_ConceptVer.ConceptName); //概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.ConceptName); //概念名称
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptContent))
 {
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptContent, conzx_ConceptVer.ConceptContent); //概念内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.ConceptContent); //概念内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TextId))
 {
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ConceptVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.TextId); //课件Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ConceptVerEN.IsSubmit == true?"1":"0", conzx_ConceptVer.IsSubmit); //是否提交
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VoteCount))
 {
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VoteCount, conzx_ConceptVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.AppraiseCount))
 {
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.AppraiseCount, conzx_ConceptVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Score))
 {
 if (objzx_ConceptVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.Score, conzx_ConceptVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.Score); //评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.StuScore))
 {
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.StuScore, conzx_ConceptVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TeaScore))
 {
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.TeaScore, conzx_ConceptVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CreateDate))
 {
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_ConceptVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdDate))
 {
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ConceptVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdUser))
 {
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ConceptVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.UpdUser); //修改人
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IdCurrEduCls))
 {
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_ConceptVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfContent))
 {
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_ConceptVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNum))
 {
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageNum, conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CitationCount))
 {
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.CitationCount, conzx_ConceptVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VersionCount))
 {
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VersionCount, conzx_ConceptVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxShareId))
 {
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_ConceptVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Memo))
 {
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ConceptVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.Memo); //备注
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivLet))
 {
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_ConceptVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivTop))
 {
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_ConceptVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNumIn))
 {
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_ConceptVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageTop))
 {
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageTop, conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfZoom))
 {
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_ConceptVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.GroupTextId))
 {
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ConceptVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ConceptVId = {0}", objzx_ConceptVerEN.ConceptVId); 
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
 /// <param name = "objzx_ConceptVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ConceptVerEN objzx_ConceptVerEN, string strCondition)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ConceptVer Set ");
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxConceptId))
 {
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxConceptId = '{0}',", strzxConceptId); //概念Id
 }
 else
 {
 sbSQL.Append(" zxConceptId = null,"); //概念Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptName))
 {
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptName = '{0}',", strConceptName); //概念名称
 }
 else
 {
 sbSQL.Append(" ConceptName = null,"); //概念名称
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptContent))
 {
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptContent = '{0}',", strConceptContent); //概念内容
 }
 else
 {
 sbSQL.Append(" ConceptContent = null,"); //概念内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TextId))
 {
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ConceptVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VoteCount))
 {
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VoteCount, conzx_ConceptVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.AppraiseCount))
 {
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.AppraiseCount, conzx_ConceptVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Score))
 {
 if (objzx_ConceptVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.Score, conzx_ConceptVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.Score); //评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.StuScore))
 {
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.StuScore, conzx_ConceptVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TeaScore))
 {
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.TeaScore, conzx_ConceptVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CreateDate))
 {
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdDate))
 {
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdUser))
 {
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IdCurrEduCls))
 {
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfContent))
 {
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNum))
 {
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageNum, conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CitationCount))
 {
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.CitationCount, conzx_ConceptVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VersionCount))
 {
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VersionCount, conzx_ConceptVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxShareId))
 {
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Memo))
 {
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivLet))
 {
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivTop))
 {
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNumIn))
 {
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageTop))
 {
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageTop, conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfZoom))
 {
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.GroupTextId))
 {
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_ConceptVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ConceptVerEN objzx_ConceptVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ConceptVer Set ");
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxConceptId))
 {
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxConceptId = '{0}',", strzxConceptId); //概念Id
 }
 else
 {
 sbSQL.Append(" zxConceptId = null,"); //概念Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptName))
 {
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptName = '{0}',", strConceptName); //概念名称
 }
 else
 {
 sbSQL.Append(" ConceptName = null,"); //概念名称
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptContent))
 {
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptContent = '{0}',", strConceptContent); //概念内容
 }
 else
 {
 sbSQL.Append(" ConceptContent = null,"); //概念内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TextId))
 {
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ConceptVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VoteCount))
 {
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VoteCount, conzx_ConceptVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.AppraiseCount))
 {
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.AppraiseCount, conzx_ConceptVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Score))
 {
 if (objzx_ConceptVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.Score, conzx_ConceptVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.Score); //评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.StuScore))
 {
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.StuScore, conzx_ConceptVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TeaScore))
 {
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.TeaScore, conzx_ConceptVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CreateDate))
 {
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdDate))
 {
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdUser))
 {
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IdCurrEduCls))
 {
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfContent))
 {
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNum))
 {
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageNum, conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CitationCount))
 {
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.CitationCount, conzx_ConceptVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VersionCount))
 {
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VersionCount, conzx_ConceptVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxShareId))
 {
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Memo))
 {
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivLet))
 {
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivTop))
 {
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNumIn))
 {
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageTop))
 {
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageTop, conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfZoom))
 {
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.GroupTextId))
 {
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ConceptVerEN objzx_ConceptVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ConceptVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ConceptVer Set ");
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxConceptId))
 {
 if (objzx_ConceptVerEN.zxConceptId !=  null)
 {
 var strzxConceptId = objzx_ConceptVerEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxConceptId, conzx_ConceptVer.zxConceptId); //概念Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.zxConceptId); //概念Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptName))
 {
 if (objzx_ConceptVerEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptVerEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptName, conzx_ConceptVer.ConceptName); //概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.ConceptName); //概念名称
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.ConceptContent))
 {
 if (objzx_ConceptVerEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptVerEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptContent, conzx_ConceptVer.ConceptContent); //概念内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.ConceptContent); //概念内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TextId))
 {
 if (objzx_ConceptVerEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_ConceptVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.TextId); //课件Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ConceptVerEN.IsSubmit == true?"1":"0", conzx_ConceptVer.IsSubmit); //是否提交
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VoteCount))
 {
 if (objzx_ConceptVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VoteCount, conzx_ConceptVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.AppraiseCount))
 {
 if (objzx_ConceptVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.AppraiseCount, conzx_ConceptVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Score))
 {
 if (objzx_ConceptVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.Score, conzx_ConceptVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.Score); //评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.StuScore))
 {
 if (objzx_ConceptVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.StuScore, conzx_ConceptVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.TeaScore))
 {
 if (objzx_ConceptVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.TeaScore, conzx_ConceptVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CreateDate))
 {
 if (objzx_ConceptVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_ConceptVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdDate))
 {
 if (objzx_ConceptVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ConceptVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.UpdUser))
 {
 if (objzx_ConceptVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ConceptVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.UpdUser); //修改人
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.IdCurrEduCls))
 {
 if (objzx_ConceptVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_ConceptVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfContent))
 {
 if (objzx_ConceptVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_ConceptVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNum))
 {
 if (objzx_ConceptVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageNum, conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.CitationCount))
 {
 if (objzx_ConceptVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.CitationCount, conzx_ConceptVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.VersionCount))
 {
 if (objzx_ConceptVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.VersionCount, conzx_ConceptVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.zxShareId))
 {
 if (objzx_ConceptVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_ConceptVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.Memo))
 {
 if (objzx_ConceptVerEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ConceptVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.Memo); //备注
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivLet))
 {
 if (objzx_ConceptVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_ConceptVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfDivTop))
 {
 if (objzx_ConceptVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_ConceptVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageNumIn))
 {
 if (objzx_ConceptVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_ConceptVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfPageTop))
 {
 if (objzx_ConceptVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptVerEN.PdfPageTop, conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.PdfZoom))
 {
 if (objzx_ConceptVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_ConceptVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ConceptVerEN.IsUpdated(conzx_ConceptVer.GroupTextId))
 {
 if (objzx_ConceptVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ConceptVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ConceptVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ConceptVId = {0}", objzx_ConceptVerEN.ConceptVId); 
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
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngConceptVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngConceptVId,
};
 objSQL.ExecSP("zx_ConceptVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngConceptVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
//删除zx_ConceptVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ConceptVer where ConceptVId = " + ""+ lngConceptVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_ConceptVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除zx_ConceptVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ConceptVer where ConceptVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngConceptVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
//删除zx_ConceptVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ConceptVer where ConceptVId = " + ""+ lngConceptVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_ConceptVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: Delzx_ConceptVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ConceptVer where " + strCondition ;
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
public bool Delzx_ConceptVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ConceptVerDA: Delzx_ConceptVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ConceptVer where " + strCondition ;
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
 /// <param name = "objzx_ConceptVerENS">源对象</param>
 /// <param name = "objzx_ConceptVerENT">目标对象</param>
public void CopyTo(clszx_ConceptVerEN objzx_ConceptVerENS, clszx_ConceptVerEN objzx_ConceptVerENT)
{
objzx_ConceptVerENT.ConceptVId = objzx_ConceptVerENS.ConceptVId; //ConceptVId
objzx_ConceptVerENT.zxConceptId = objzx_ConceptVerENS.zxConceptId; //概念Id
objzx_ConceptVerENT.ConceptName = objzx_ConceptVerENS.ConceptName; //概念名称
objzx_ConceptVerENT.ConceptContent = objzx_ConceptVerENS.ConceptContent; //概念内容
objzx_ConceptVerENT.TextId = objzx_ConceptVerENS.TextId; //课件Id
objzx_ConceptVerENT.IsSubmit = objzx_ConceptVerENS.IsSubmit; //是否提交
objzx_ConceptVerENT.VoteCount = objzx_ConceptVerENS.VoteCount; //点赞计数
objzx_ConceptVerENT.AppraiseCount = objzx_ConceptVerENS.AppraiseCount; //评论数
objzx_ConceptVerENT.Score = objzx_ConceptVerENS.Score; //评分
objzx_ConceptVerENT.StuScore = objzx_ConceptVerENS.StuScore; //学生平均分
objzx_ConceptVerENT.TeaScore = objzx_ConceptVerENS.TeaScore; //教师评分
objzx_ConceptVerENT.CreateDate = objzx_ConceptVerENS.CreateDate; //建立日期
objzx_ConceptVerENT.UpdDate = objzx_ConceptVerENS.UpdDate; //修改日期
objzx_ConceptVerENT.UpdUser = objzx_ConceptVerENS.UpdUser; //修改人
objzx_ConceptVerENT.IdCurrEduCls = objzx_ConceptVerENS.IdCurrEduCls; //教学班流水号
objzx_ConceptVerENT.PdfContent = objzx_ConceptVerENS.PdfContent; //Pdf内容
objzx_ConceptVerENT.PdfPageNum = objzx_ConceptVerENS.PdfPageNum; //Pdf页码
objzx_ConceptVerENT.CitationCount = objzx_ConceptVerENS.CitationCount; //引用统计
objzx_ConceptVerENT.VersionCount = objzx_ConceptVerENS.VersionCount; //版本统计
objzx_ConceptVerENT.zxShareId = objzx_ConceptVerENS.zxShareId; //分享Id
objzx_ConceptVerENT.Memo = objzx_ConceptVerENS.Memo; //备注
objzx_ConceptVerENT.PdfDivLet = objzx_ConceptVerENS.PdfDivLet; //PdfDivLet
objzx_ConceptVerENT.PdfDivTop = objzx_ConceptVerENS.PdfDivTop; //PdfDivTop
objzx_ConceptVerENT.PdfPageNumIn = objzx_ConceptVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_ConceptVerENT.PdfPageTop = objzx_ConceptVerENS.PdfPageTop; //pdf页面顶部位置
objzx_ConceptVerENT.PdfZoom = objzx_ConceptVerENS.PdfZoom; //PdfZoom
objzx_ConceptVerENT.GroupTextId = objzx_ConceptVerENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ConceptVerEN objzx_ConceptVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_ConceptVerEN.zxConceptId, conzx_ConceptVer.zxConceptId);
clsCheckSql.CheckFieldNotNull(objzx_ConceptVerEN.zxShareId, conzx_ConceptVer.zxShareId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.zxConceptId, 8, conzx_ConceptVer.zxConceptId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.ConceptName, 500, conzx_ConceptVer.ConceptName);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.TextId, 8, conzx_ConceptVer.TextId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.CreateDate, 20, conzx_ConceptVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.UpdDate, 20, conzx_ConceptVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.UpdUser, 20, conzx_ConceptVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.IdCurrEduCls, 8, conzx_ConceptVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfContent, 2000, conzx_ConceptVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.zxShareId, 2, conzx_ConceptVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.Memo, 1000, conzx_ConceptVer.Memo);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfDivLet, 50, conzx_ConceptVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfDivTop, 50, conzx_ConceptVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfPageNumIn, 50, conzx_ConceptVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfZoom, 50, conzx_ConceptVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.GroupTextId, 8, conzx_ConceptVer.GroupTextId);
//检查字段外键固定长度
 objzx_ConceptVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ConceptVerEN objzx_ConceptVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.zxConceptId, 8, conzx_ConceptVer.zxConceptId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.ConceptName, 500, conzx_ConceptVer.ConceptName);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.TextId, 8, conzx_ConceptVer.TextId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.CreateDate, 20, conzx_ConceptVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.UpdDate, 20, conzx_ConceptVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.UpdUser, 20, conzx_ConceptVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.IdCurrEduCls, 8, conzx_ConceptVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfContent, 2000, conzx_ConceptVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.zxShareId, 2, conzx_ConceptVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.Memo, 1000, conzx_ConceptVer.Memo);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfDivLet, 50, conzx_ConceptVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfDivTop, 50, conzx_ConceptVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfPageNumIn, 50, conzx_ConceptVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfZoom, 50, conzx_ConceptVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.GroupTextId, 8, conzx_ConceptVer.GroupTextId);
//检查外键字段长度
 objzx_ConceptVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ConceptVerEN objzx_ConceptVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.zxConceptId, 8, conzx_ConceptVer.zxConceptId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.ConceptName, 500, conzx_ConceptVer.ConceptName);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.TextId, 8, conzx_ConceptVer.TextId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.CreateDate, 20, conzx_ConceptVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.UpdDate, 20, conzx_ConceptVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.UpdUser, 20, conzx_ConceptVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.IdCurrEduCls, 8, conzx_ConceptVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfContent, 2000, conzx_ConceptVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.zxShareId, 2, conzx_ConceptVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.Memo, 1000, conzx_ConceptVer.Memo);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfDivLet, 50, conzx_ConceptVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfDivTop, 50, conzx_ConceptVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfPageNumIn, 50, conzx_ConceptVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.PdfZoom, 50, conzx_ConceptVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ConceptVerEN.GroupTextId, 8, conzx_ConceptVer.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.zxConceptId, conzx_ConceptVer.zxConceptId);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.ConceptName, conzx_ConceptVer.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.TextId, conzx_ConceptVer.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.CreateDate, conzx_ConceptVer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.UpdDate, conzx_ConceptVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.UpdUser, conzx_ConceptVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.IdCurrEduCls, conzx_ConceptVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.PdfContent, conzx_ConceptVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.zxShareId, conzx_ConceptVer.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.Memo, conzx_ConceptVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.PdfDivLet, conzx_ConceptVer.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.PdfDivTop, conzx_ConceptVer.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.PdfPageNumIn, conzx_ConceptVer.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.PdfZoom, conzx_ConceptVer.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptVerEN.GroupTextId, conzx_ConceptVer.GroupTextId);
//检查外键字段长度
 objzx_ConceptVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_ConceptVer(概念版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ConceptVerEN objzx_ConceptVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptVerEN.zxConceptId);
 if (objzx_ConceptVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ConceptVerEN.GroupTextId);
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ConceptVerEN._CurrTabName);
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ConceptVerEN._CurrTabName, strCondition);
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
 objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
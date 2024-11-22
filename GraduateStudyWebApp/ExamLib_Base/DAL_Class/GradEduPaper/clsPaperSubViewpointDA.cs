
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointDA
 表名:PaperSubViewpoint(01120534)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 子观点表(PaperSubViewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPaperSubViewpointDA : clsCommBase4DA
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
 return clsPaperSubViewpointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPaperSubViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubViewpointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPaperSubViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPaperSubViewpointEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PaperSubViewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable_PaperSubViewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PaperSubViewpoint.* from PaperSubViewpoint Left Join {1} on {2} where {3} and PaperSubViewpoint.SubViewpointId not in (Select top {5} PaperSubViewpoint.SubViewpointId from PaperSubViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1} and SubViewpointId not in (Select top {2} SubViewpointId from PaperSubViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1} and SubViewpointId not in (Select top {3} SubViewpointId from PaperSubViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PaperSubViewpoint.* from PaperSubViewpoint Left Join {1} on {2} where {3} and PaperSubViewpoint.SubViewpointId not in (Select top {5} PaperSubViewpoint.SubViewpointId from PaperSubViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1} and SubViewpointId not in (Select top {2} SubViewpointId from PaperSubViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpoint where {1} and SubViewpointId not in (Select top {3} SubViewpointId from PaperSubViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPaperSubViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA:GetObjLst)", objException.Message));
}
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperSubViewpointDA: GetObjLst)", objException.Message));
}
objPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperSubViewpointEN);
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
public List<clsPaperSubViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperSubViewpointDA: GetObjLst)", objException.Message));
}
objPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperSubViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPaperSubViewpoint(ref clsPaperSubViewpointEN objPaperSubViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where SubViewpointId = " + ""+ objPaperSubViewpointEN.SubViewpointId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPaperSubViewpointEN.SubViewpointId = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.SubViewpointContent = objDT.Rows[0][conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objPaperSubViewpointEN.PaperRWId = objDT.Rows[0][conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.PaperId = objDT.Rows[0][conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.IdCurrEduCls = objDT.Rows[0][conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objPaperSubViewpointEN.UserId = objDT.Rows[0][conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objPaperSubViewpointEN.SectionId = objDT.Rows[0][conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.SubViewpointTypeId = objDT.Rows[0][conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objPaperSubViewpointEN.gsKnowledgeTypeId = objDT.Rows[0][conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperSubViewpointEN.RWTitle = objDT.Rows[0][conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.ExplainTypeId = objDT.Rows[0][conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperSubViewpointEN.ExplainContent = objDT.Rows[0][conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperSubViewpointEN.IsPublic = TransNullToBool(objDT.Rows[0][conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objPaperSubViewpointEN.LiteratureSourcesId = objDT.Rows[0][conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.OperationTypeId = objDT.Rows[0][conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objPaperSubViewpointEN.LevelId = objDT.Rows[0][conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperSubViewpointEN.Conclusion = objDT.Rows[0][conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperSubViewpointEN.Nationality = objDT.Rows[0][conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.Achievement = objDT.Rows[0][conPaperSubViewpoint.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperSubViewpointEN.Major = objDT.Rows[0][conPaperSubViewpoint.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.WorkUnit = objDT.Rows[0][conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objPaperSubViewpointEN.PageNumber = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.OrderNum = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.PdfContent = objDT.Rows[0][conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objPaperSubViewpointEN.selectSpanRange = objDT.Rows[0][conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.PaperLineNum = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.PaperPageNum = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.OkCount = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.Score = TransNullToFloat(objDT.Rows[0][conPaperSubViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.CreateDate = objDT.Rows[0][conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointEN.ShareId = objDT.Rows[0][conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperSubViewpointEN.TopicId = objDT.Rows[0][conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.AttitudesId = objDT.Rows[0][conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperSubViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.CourseId = objDT.Rows[0][conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.IsRecommend = TransNullToBool(objDT.Rows[0][conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objPaperSubViewpointEN.UpdDate = objDT.Rows[0][conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointEN.UpdUser = objDT.Rows[0][conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointEN.Memo = objDT.Rows[0][conPaperSubViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPaperSubViewpointDA: GetPaperSubViewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clsPaperSubViewpointEN GetObjBySubViewpointId(long lngSubViewpointId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where SubViewpointId = " + ""+ lngSubViewpointId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
 objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPaperSubViewpointDA: GetObjBySubViewpointId)", objException.Message));
}
return objPaperSubViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPaperSubViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN()
{
SubViewpointId = TransNullToInt(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()), //子观点Id
SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(), //详情内容
PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(), //课文阅读
PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(), //论文Id
IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(), //用户ID
SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(), //节Id
SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(), //类型Id
gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(), //知识类型Id
RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(), //读写标题
ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(), //说明类型Id
ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(), //说明内容
IsPublic = TransNullToBool(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()), //是否公开
LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(), //文献来源
OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(), //操作类型ID
LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(), //级别Id
Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(), //结论
Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(), //国籍
Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(), //成就
Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(), //专业
WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(), //工作单位
PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()), //页码
OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()), //序号
PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(), //Pdf内容
selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(), //选择Span范围
PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()), //论文行号
PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()), //论文页码
AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()), //点赞统计
Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.Score].ToString().Trim()), //评分
StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(), //分享Id
TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(), //主题Id
AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(), //态度Id
VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()), //版本统计
CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()), //引用统计
CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(), //课程Id
IsRecommend = TransNullToBool(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()), //是否推荐
UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim() //备注
};
objPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperSubViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPaperSubViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPaperSubViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPaperSubViewpointDA: GetObjByDataRowPaperSubViewpoint)", objException.Message));
}
objPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperSubViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPaperSubViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = TransNullToBool(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = TransNullToBool(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPaperSubViewpointDA: GetObjByDataRow)", objException.Message));
}
objPaperSubViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperSubViewpointEN;
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
objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperSubViewpointEN._CurrTabName, conPaperSubViewpoint.SubViewpointId, 8, "");
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
objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperSubViewpointEN._CurrTabName, conPaperSubViewpoint.SubViewpointId, 8, strPrefix);
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SubViewpointId from PaperSubViewpoint where " + strCondition;
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SubViewpointId from PaperSubViewpoint where " + strCondition;
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngSubViewpointId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PaperSubViewpoint", "SubViewpointId = " + ""+ lngSubViewpointId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PaperSubViewpoint", strCondition))
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
objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PaperSubViewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPaperSubViewpointEN objPaperSubViewpointEN)
 {
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PaperSubViewpoint");
objRow = objDS.Tables["PaperSubViewpoint"].NewRow();
 if (objPaperSubViewpointEN.SubViewpointContent !=  "")
 {
objRow[conPaperSubViewpoint.SubViewpointContent] = objPaperSubViewpointEN.SubViewpointContent; //详情内容
 }
 if (objPaperSubViewpointEN.PaperRWId !=  "")
 {
objRow[conPaperSubViewpoint.PaperRWId] = objPaperSubViewpointEN.PaperRWId; //课文阅读
 }
objRow[conPaperSubViewpoint.PaperId] = objPaperSubViewpointEN.PaperId; //论文Id
objRow[conPaperSubViewpoint.IdCurrEduCls] = objPaperSubViewpointEN.IdCurrEduCls; //教学班流水号
objRow[conPaperSubViewpoint.UserId] = objPaperSubViewpointEN.UserId; //用户ID
 if (objPaperSubViewpointEN.SectionId !=  "")
 {
objRow[conPaperSubViewpoint.SectionId] = objPaperSubViewpointEN.SectionId; //节Id
 }
objRow[conPaperSubViewpoint.SubViewpointTypeId] = objPaperSubViewpointEN.SubViewpointTypeId; //类型Id
objRow[conPaperSubViewpoint.gsKnowledgeTypeId] = objPaperSubViewpointEN.gsKnowledgeTypeId; //知识类型Id
 if (objPaperSubViewpointEN.RWTitle !=  "")
 {
objRow[conPaperSubViewpoint.RWTitle] = objPaperSubViewpointEN.RWTitle; //读写标题
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  "")
 {
objRow[conPaperSubViewpoint.ExplainTypeId] = objPaperSubViewpointEN.ExplainTypeId; //说明类型Id
 }
 if (objPaperSubViewpointEN.ExplainContent !=  "")
 {
objRow[conPaperSubViewpoint.ExplainContent] = objPaperSubViewpointEN.ExplainContent; //说明内容
 }
objRow[conPaperSubViewpoint.IsPublic] = objPaperSubViewpointEN.IsPublic; //是否公开
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  "")
 {
objRow[conPaperSubViewpoint.LiteratureSourcesId] = objPaperSubViewpointEN.LiteratureSourcesId; //文献来源
 }
 if (objPaperSubViewpointEN.OperationTypeId !=  "")
 {
objRow[conPaperSubViewpoint.OperationTypeId] = objPaperSubViewpointEN.OperationTypeId; //操作类型ID
 }
 if (objPaperSubViewpointEN.LevelId !=  "")
 {
objRow[conPaperSubViewpoint.LevelId] = objPaperSubViewpointEN.LevelId; //级别Id
 }
 if (objPaperSubViewpointEN.Conclusion !=  "")
 {
objRow[conPaperSubViewpoint.Conclusion] = objPaperSubViewpointEN.Conclusion; //结论
 }
 if (objPaperSubViewpointEN.Nationality !=  "")
 {
objRow[conPaperSubViewpoint.Nationality] = objPaperSubViewpointEN.Nationality; //国籍
 }
 if (objPaperSubViewpointEN.Achievement !=  "")
 {
objRow[conPaperSubViewpoint.Achievement] = objPaperSubViewpointEN.Achievement; //成就
 }
 if (objPaperSubViewpointEN.Major !=  "")
 {
objRow[conPaperSubViewpoint.Major] = objPaperSubViewpointEN.Major; //专业
 }
 if (objPaperSubViewpointEN.WorkUnit !=  "")
 {
objRow[conPaperSubViewpoint.WorkUnit] = objPaperSubViewpointEN.WorkUnit; //工作单位
 }
objRow[conPaperSubViewpoint.PageNumber] = objPaperSubViewpointEN.PageNumber; //页码
objRow[conPaperSubViewpoint.OrderNum] = objPaperSubViewpointEN.OrderNum; //序号
 if (objPaperSubViewpointEN.PdfContent !=  "")
 {
objRow[conPaperSubViewpoint.PdfContent] = objPaperSubViewpointEN.PdfContent; //Pdf内容
 }
 if (objPaperSubViewpointEN.selectSpanRange !=  "")
 {
objRow[conPaperSubViewpoint.selectSpanRange] = objPaperSubViewpointEN.selectSpanRange; //选择Span范围
 }
objRow[conPaperSubViewpoint.PaperLineNum] = objPaperSubViewpointEN.PaperLineNum; //论文行号
objRow[conPaperSubViewpoint.PaperPageNum] = objPaperSubViewpointEN.PaperPageNum; //论文页码
objRow[conPaperSubViewpoint.AppraiseCount] = objPaperSubViewpointEN.AppraiseCount; //评论数
objRow[conPaperSubViewpoint.OkCount] = objPaperSubViewpointEN.OkCount; //点赞统计
objRow[conPaperSubViewpoint.Score] = objPaperSubViewpointEN.Score; //评分
objRow[conPaperSubViewpoint.StuScore] = objPaperSubViewpointEN.StuScore; //学生平均分
objRow[conPaperSubViewpoint.TeaScore] = objPaperSubViewpointEN.TeaScore; //教师评分
 if (objPaperSubViewpointEN.CreateDate !=  "")
 {
objRow[conPaperSubViewpoint.CreateDate] = objPaperSubViewpointEN.CreateDate; //建立日期
 }
objRow[conPaperSubViewpoint.ShareId] = objPaperSubViewpointEN.ShareId; //分享Id
 if (objPaperSubViewpointEN.TopicId !=  "")
 {
objRow[conPaperSubViewpoint.TopicId] = objPaperSubViewpointEN.TopicId; //主题Id
 }
 if (objPaperSubViewpointEN.AttitudesId !=  "")
 {
objRow[conPaperSubViewpoint.AttitudesId] = objPaperSubViewpointEN.AttitudesId; //态度Id
 }
objRow[conPaperSubViewpoint.VersionCount] = objPaperSubViewpointEN.VersionCount; //版本统计
objRow[conPaperSubViewpoint.CitationCount] = objPaperSubViewpointEN.CitationCount; //引用统计
 if (objPaperSubViewpointEN.CourseId !=  "")
 {
objRow[conPaperSubViewpoint.CourseId] = objPaperSubViewpointEN.CourseId; //课程Id
 }
objRow[conPaperSubViewpoint.IsRecommend] = objPaperSubViewpointEN.IsRecommend; //是否推荐
 if (objPaperSubViewpointEN.UpdDate !=  "")
 {
objRow[conPaperSubViewpoint.UpdDate] = objPaperSubViewpointEN.UpdDate; //修改日期
 }
 if (objPaperSubViewpointEN.UpdUser !=  "")
 {
objRow[conPaperSubViewpoint.UpdUser] = objPaperSubViewpointEN.UpdUser; //修改人
 }
 if (objPaperSubViewpointEN.Memo !=  "")
 {
objRow[conPaperSubViewpoint.Memo] = objPaperSubViewpointEN.Memo; //备注
 }
objDS.Tables[clsPaperSubViewpointEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPaperSubViewpointEN._CurrTabName);
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointContent);
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointContent + "'");
 }
 
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperRWId);
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperId);
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UserId);
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SectionId);
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointTypeId);
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.gsKnowledgeTypeId);
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strgsKnowledgeTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.RWTitle);
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRWTitle + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainTypeId);
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainContent);
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainContent + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LiteratureSourcesId);
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSourcesId + "'");
 }
 
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OperationTypeId);
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LevelId);
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Conclusion);
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Nationality);
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Achievement);
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objPaperSubViewpointEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Major);
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.WorkUnit);
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PageNumber);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PageNumber.ToString());
 }
 
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OrderNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OrderNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PdfContent);
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.selectSpanRange);
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperLineNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperLineNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperPageNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperPageNum.ToString());
 }
 
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.AppraiseCount.ToString());
 }
 
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OkCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OkCount.ToString());
 }
 
 if (objPaperSubViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Score);
 arrValueListForInsert.Add(objPaperSubViewpointEN.Score.ToString());
 }
 
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.StuScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.StuScore.ToString());
 }
 
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TeaScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.TeaScore.ToString());
 }
 
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CreateDate);
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ShareId);
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TopicId);
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AttitudesId);
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttitudesId + "'");
 }
 
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.VersionCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.VersionCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CitationCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.CitationCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CourseId);
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdDate);
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdUser);
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Memo);
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointContent);
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointContent + "'");
 }
 
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperRWId);
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperId);
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UserId);
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SectionId);
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointTypeId);
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.gsKnowledgeTypeId);
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strgsKnowledgeTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.RWTitle);
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRWTitle + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainTypeId);
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainContent);
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainContent + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LiteratureSourcesId);
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSourcesId + "'");
 }
 
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OperationTypeId);
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LevelId);
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Conclusion);
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Nationality);
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Achievement);
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objPaperSubViewpointEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Major);
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.WorkUnit);
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PageNumber);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PageNumber.ToString());
 }
 
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OrderNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OrderNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PdfContent);
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.selectSpanRange);
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperLineNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperLineNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperPageNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperPageNum.ToString());
 }
 
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.AppraiseCount.ToString());
 }
 
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OkCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OkCount.ToString());
 }
 
 if (objPaperSubViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Score);
 arrValueListForInsert.Add(objPaperSubViewpointEN.Score.ToString());
 }
 
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.StuScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.StuScore.ToString());
 }
 
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TeaScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.TeaScore.ToString());
 }
 
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CreateDate);
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ShareId);
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TopicId);
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AttitudesId);
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttitudesId + "'");
 }
 
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.VersionCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.VersionCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CitationCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.CitationCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CourseId);
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdDate);
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdUser);
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Memo);
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperSubViewpointEN objPaperSubViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointContent);
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointContent + "'");
 }
 
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperRWId);
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperId);
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UserId);
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SectionId);
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointTypeId);
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.gsKnowledgeTypeId);
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strgsKnowledgeTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.RWTitle);
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRWTitle + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainTypeId);
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainContent);
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainContent + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LiteratureSourcesId);
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSourcesId + "'");
 }
 
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OperationTypeId);
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LevelId);
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Conclusion);
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Nationality);
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Achievement);
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objPaperSubViewpointEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Major);
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.WorkUnit);
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PageNumber);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PageNumber.ToString());
 }
 
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OrderNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OrderNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PdfContent);
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.selectSpanRange);
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperLineNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperLineNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperPageNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperPageNum.ToString());
 }
 
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.AppraiseCount.ToString());
 }
 
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OkCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OkCount.ToString());
 }
 
 if (objPaperSubViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Score);
 arrValueListForInsert.Add(objPaperSubViewpointEN.Score.ToString());
 }
 
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.StuScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.StuScore.ToString());
 }
 
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TeaScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.TeaScore.ToString());
 }
 
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CreateDate);
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ShareId);
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TopicId);
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AttitudesId);
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttitudesId + "'");
 }
 
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.VersionCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.VersionCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CitationCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.CitationCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CourseId);
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdDate);
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdUser);
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Memo);
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperSubViewpointEN objPaperSubViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointContent);
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointContent + "'");
 }
 
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperRWId);
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperId);
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UserId);
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SectionId);
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.SubViewpointTypeId);
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.gsKnowledgeTypeId);
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strgsKnowledgeTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.RWTitle);
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRWTitle + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainTypeId);
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ExplainContent);
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplainContent + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LiteratureSourcesId);
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureSourcesId + "'");
 }
 
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OperationTypeId);
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.LevelId);
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelId + "'");
 }
 
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Conclusion);
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Nationality);
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNationality + "'");
 }
 
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Achievement);
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAchievement + "'");
 }
 
 if (objPaperSubViewpointEN.Major !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Major);
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajor + "'");
 }
 
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.WorkUnit);
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PageNumber);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PageNumber.ToString());
 }
 
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OrderNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OrderNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PdfContent);
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.selectSpanRange);
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperLineNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperLineNum.ToString());
 }
 
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.PaperPageNum);
 arrValueListForInsert.Add(objPaperSubViewpointEN.PaperPageNum.ToString());
 }
 
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.AppraiseCount.ToString());
 }
 
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.OkCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.OkCount.ToString());
 }
 
 if (objPaperSubViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Score);
 arrValueListForInsert.Add(objPaperSubViewpointEN.Score.ToString());
 }
 
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.StuScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.StuScore.ToString());
 }
 
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TeaScore);
 arrValueListForInsert.Add(objPaperSubViewpointEN.TeaScore.ToString());
 }
 
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CreateDate);
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.ShareId);
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.TopicId);
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.AttitudesId);
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttitudesId + "'");
 }
 
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.VersionCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.VersionCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CitationCount);
 arrValueListForInsert.Add(objPaperSubViewpointEN.CitationCount.ToString());
 }
 
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.CourseId);
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conPaperSubViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objPaperSubViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdDate);
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.UpdUser);
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpoint.Memo);
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPaperSubViewpoints(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where SubViewpointId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PaperSubViewpoint");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngSubViewpointId = TransNullToInt(oRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim());
if (IsExist(lngSubViewpointId))
{
 string strResult = "关键字变量值为:" + string.Format("SubViewpointId = {0}", lngSubViewpointId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPaperSubViewpointEN._CurrTabName ].NewRow();
objRow[conPaperSubViewpoint.SubViewpointContent] = oRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objRow[conPaperSubViewpoint.PaperRWId] = oRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objRow[conPaperSubViewpoint.PaperId] = oRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objRow[conPaperSubViewpoint.IdCurrEduCls] = oRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conPaperSubViewpoint.UserId] = oRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objRow[conPaperSubViewpoint.SectionId] = oRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objRow[conPaperSubViewpoint.SubViewpointTypeId] = oRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objRow[conPaperSubViewpoint.gsKnowledgeTypeId] = oRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objRow[conPaperSubViewpoint.RWTitle] = oRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objRow[conPaperSubViewpoint.ExplainTypeId] = oRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objRow[conPaperSubViewpoint.ExplainContent] = oRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objRow[conPaperSubViewpoint.IsPublic] = oRow[conPaperSubViewpoint.IsPublic].ToString().Trim(); //是否公开
objRow[conPaperSubViewpoint.LiteratureSourcesId] = oRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objRow[conPaperSubViewpoint.OperationTypeId] = oRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objRow[conPaperSubViewpoint.LevelId] = oRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objRow[conPaperSubViewpoint.Conclusion] = oRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objRow[conPaperSubViewpoint.Nationality] = oRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objRow[conPaperSubViewpoint.Achievement] = oRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objRow[conPaperSubViewpoint.Major] = oRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objRow[conPaperSubViewpoint.WorkUnit] = oRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objRow[conPaperSubViewpoint.PageNumber] = oRow[conPaperSubViewpoint.PageNumber].ToString().Trim(); //页码
objRow[conPaperSubViewpoint.OrderNum] = oRow[conPaperSubViewpoint.OrderNum].ToString().Trim(); //序号
objRow[conPaperSubViewpoint.PdfContent] = oRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objRow[conPaperSubViewpoint.selectSpanRange] = oRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objRow[conPaperSubViewpoint.PaperLineNum] = oRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim(); //论文行号
objRow[conPaperSubViewpoint.PaperPageNum] = oRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim(); //论文页码
objRow[conPaperSubViewpoint.AppraiseCount] = oRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim(); //评论数
objRow[conPaperSubViewpoint.OkCount] = oRow[conPaperSubViewpoint.OkCount].ToString().Trim(); //点赞统计
objRow[conPaperSubViewpoint.Score] = oRow[conPaperSubViewpoint.Score].ToString().Trim(); //评分
objRow[conPaperSubViewpoint.StuScore] = oRow[conPaperSubViewpoint.StuScore].ToString().Trim(); //学生平均分
objRow[conPaperSubViewpoint.TeaScore] = oRow[conPaperSubViewpoint.TeaScore].ToString().Trim(); //教师评分
objRow[conPaperSubViewpoint.CreateDate] = oRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objRow[conPaperSubViewpoint.ShareId] = oRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objRow[conPaperSubViewpoint.TopicId] = oRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objRow[conPaperSubViewpoint.AttitudesId] = oRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objRow[conPaperSubViewpoint.VersionCount] = oRow[conPaperSubViewpoint.VersionCount].ToString().Trim(); //版本统计
objRow[conPaperSubViewpoint.CitationCount] = oRow[conPaperSubViewpoint.CitationCount].ToString().Trim(); //引用统计
objRow[conPaperSubViewpoint.CourseId] = oRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objRow[conPaperSubViewpoint.IsRecommend] = oRow[conPaperSubViewpoint.IsRecommend].ToString().Trim(); //是否推荐
objRow[conPaperSubViewpoint.UpdDate] = oRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objRow[conPaperSubViewpoint.UpdUser] = oRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objRow[conPaperSubViewpoint.Memo] = oRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
 objDS.Tables[clsPaperSubViewpointEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPaperSubViewpointEN._CurrTabName);
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
 /// <param name = "objPaperSubViewpointEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpoint where SubViewpointId = " + ""+ objPaperSubViewpointEN.SubViewpointId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPaperSubViewpointEN._CurrTabName);
if (objDS.Tables[clsPaperSubViewpointEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SubViewpointId = " + ""+ objPaperSubViewpointEN.SubViewpointId+"");
return false;
}
objRow = objDS.Tables[clsPaperSubViewpointEN._CurrTabName].Rows[0];
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointContent))
 {
objRow[conPaperSubViewpoint.SubViewpointContent] = objPaperSubViewpointEN.SubViewpointContent; //详情内容
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperRWId))
 {
objRow[conPaperSubViewpoint.PaperRWId] = objPaperSubViewpointEN.PaperRWId; //课文阅读
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperId))
 {
objRow[conPaperSubViewpoint.PaperId] = objPaperSubViewpointEN.PaperId; //论文Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IdCurrEduCls))
 {
objRow[conPaperSubViewpoint.IdCurrEduCls] = objPaperSubViewpointEN.IdCurrEduCls; //教学班流水号
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UserId))
 {
objRow[conPaperSubViewpoint.UserId] = objPaperSubViewpointEN.UserId; //用户ID
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SectionId))
 {
objRow[conPaperSubViewpoint.SectionId] = objPaperSubViewpointEN.SectionId; //节Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointTypeId))
 {
objRow[conPaperSubViewpoint.SubViewpointTypeId] = objPaperSubViewpointEN.SubViewpointTypeId; //类型Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.gsKnowledgeTypeId))
 {
objRow[conPaperSubViewpoint.gsKnowledgeTypeId] = objPaperSubViewpointEN.gsKnowledgeTypeId; //知识类型Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.RWTitle))
 {
objRow[conPaperSubViewpoint.RWTitle] = objPaperSubViewpointEN.RWTitle; //读写标题
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainTypeId))
 {
objRow[conPaperSubViewpoint.ExplainTypeId] = objPaperSubViewpointEN.ExplainTypeId; //说明类型Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainContent))
 {
objRow[conPaperSubViewpoint.ExplainContent] = objPaperSubViewpointEN.ExplainContent; //说明内容
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsPublic))
 {
objRow[conPaperSubViewpoint.IsPublic] = objPaperSubViewpointEN.IsPublic; //是否公开
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LiteratureSourcesId))
 {
objRow[conPaperSubViewpoint.LiteratureSourcesId] = objPaperSubViewpointEN.LiteratureSourcesId; //文献来源
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OperationTypeId))
 {
objRow[conPaperSubViewpoint.OperationTypeId] = objPaperSubViewpointEN.OperationTypeId; //操作类型ID
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LevelId))
 {
objRow[conPaperSubViewpoint.LevelId] = objPaperSubViewpointEN.LevelId; //级别Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Conclusion))
 {
objRow[conPaperSubViewpoint.Conclusion] = objPaperSubViewpointEN.Conclusion; //结论
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Nationality))
 {
objRow[conPaperSubViewpoint.Nationality] = objPaperSubViewpointEN.Nationality; //国籍
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Achievement))
 {
objRow[conPaperSubViewpoint.Achievement] = objPaperSubViewpointEN.Achievement; //成就
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Major))
 {
objRow[conPaperSubViewpoint.Major] = objPaperSubViewpointEN.Major; //专业
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.WorkUnit))
 {
objRow[conPaperSubViewpoint.WorkUnit] = objPaperSubViewpointEN.WorkUnit; //工作单位
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PageNumber))
 {
objRow[conPaperSubViewpoint.PageNumber] = objPaperSubViewpointEN.PageNumber; //页码
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OrderNum))
 {
objRow[conPaperSubViewpoint.OrderNum] = objPaperSubViewpointEN.OrderNum; //序号
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PdfContent))
 {
objRow[conPaperSubViewpoint.PdfContent] = objPaperSubViewpointEN.PdfContent; //Pdf内容
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.selectSpanRange))
 {
objRow[conPaperSubViewpoint.selectSpanRange] = objPaperSubViewpointEN.selectSpanRange; //选择Span范围
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperLineNum))
 {
objRow[conPaperSubViewpoint.PaperLineNum] = objPaperSubViewpointEN.PaperLineNum; //论文行号
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperPageNum))
 {
objRow[conPaperSubViewpoint.PaperPageNum] = objPaperSubViewpointEN.PaperPageNum; //论文页码
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AppraiseCount))
 {
objRow[conPaperSubViewpoint.AppraiseCount] = objPaperSubViewpointEN.AppraiseCount; //评论数
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OkCount))
 {
objRow[conPaperSubViewpoint.OkCount] = objPaperSubViewpointEN.OkCount; //点赞统计
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Score))
 {
objRow[conPaperSubViewpoint.Score] = objPaperSubViewpointEN.Score; //评分
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.StuScore))
 {
objRow[conPaperSubViewpoint.StuScore] = objPaperSubViewpointEN.StuScore; //学生平均分
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TeaScore))
 {
objRow[conPaperSubViewpoint.TeaScore] = objPaperSubViewpointEN.TeaScore; //教师评分
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CreateDate))
 {
objRow[conPaperSubViewpoint.CreateDate] = objPaperSubViewpointEN.CreateDate; //建立日期
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ShareId))
 {
objRow[conPaperSubViewpoint.ShareId] = objPaperSubViewpointEN.ShareId; //分享Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TopicId))
 {
objRow[conPaperSubViewpoint.TopicId] = objPaperSubViewpointEN.TopicId; //主题Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AttitudesId))
 {
objRow[conPaperSubViewpoint.AttitudesId] = objPaperSubViewpointEN.AttitudesId; //态度Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.VersionCount))
 {
objRow[conPaperSubViewpoint.VersionCount] = objPaperSubViewpointEN.VersionCount; //版本统计
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CitationCount))
 {
objRow[conPaperSubViewpoint.CitationCount] = objPaperSubViewpointEN.CitationCount; //引用统计
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CourseId))
 {
objRow[conPaperSubViewpoint.CourseId] = objPaperSubViewpointEN.CourseId; //课程Id
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsRecommend))
 {
objRow[conPaperSubViewpoint.IsRecommend] = objPaperSubViewpointEN.IsRecommend; //是否推荐
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdDate))
 {
objRow[conPaperSubViewpoint.UpdDate] = objPaperSubViewpointEN.UpdDate; //修改日期
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdUser))
 {
objRow[conPaperSubViewpoint.UpdUser] = objPaperSubViewpointEN.UpdUser; //修改人
 }
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Memo))
 {
objRow[conPaperSubViewpoint.Memo] = objPaperSubViewpointEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsPaperSubViewpointEN._CurrTabName);
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PaperSubViewpoint Set ");
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointContent))
 {
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointContent, conPaperSubViewpoint.SubViewpointContent); //详情内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.SubViewpointContent); //详情内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperRWId))
 {
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperRWId, conPaperSubViewpoint.PaperRWId); //课文阅读
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperRWId); //课文阅读
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperId))
 {
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conPaperSubViewpoint.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperId); //论文Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IdCurrEduCls))
 {
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conPaperSubViewpoint.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UserId))
 {
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPaperSubViewpoint.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.UserId); //用户ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SectionId))
 {
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionId, conPaperSubViewpoint.SectionId); //节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.SectionId); //节Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointTypeId))
 {
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointTypeId, conPaperSubViewpoint.SubViewpointTypeId); //类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.SubViewpointTypeId); //类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.gsKnowledgeTypeId))
 {
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strgsKnowledgeTypeId, conPaperSubViewpoint.gsKnowledgeTypeId); //知识类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.gsKnowledgeTypeId); //知识类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.RWTitle))
 {
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRWTitle, conPaperSubViewpoint.RWTitle); //读写标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.RWTitle); //读写标题
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainTypeId))
 {
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExplainTypeId, conPaperSubViewpoint.ExplainTypeId); //说明类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.ExplainTypeId); //说明类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainContent))
 {
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExplainContent, conPaperSubViewpoint.ExplainContent); //说明内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.ExplainContent); //说明内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperSubViewpointEN.IsPublic == true?"1":"0", conPaperSubViewpoint.IsPublic); //是否公开
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LiteratureSourcesId))
 {
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSourcesId, conPaperSubViewpoint.LiteratureSourcesId); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.LiteratureSourcesId); //文献来源
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OperationTypeId))
 {
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conPaperSubViewpoint.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OperationTypeId); //操作类型ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LevelId))
 {
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conPaperSubViewpoint.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.LevelId); //级别Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Conclusion))
 {
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conPaperSubViewpoint.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Conclusion); //结论
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Nationality))
 {
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conPaperSubViewpoint.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Nationality); //国籍
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Achievement))
 {
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conPaperSubViewpoint.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Achievement); //成就
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Major))
 {
 if (objPaperSubViewpointEN.Major !=  null)
 {
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conPaperSubViewpoint.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Major); //专业
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.WorkUnit))
 {
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conPaperSubViewpoint.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.WorkUnit); //工作单位
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PageNumber))
 {
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PageNumber, conPaperSubViewpoint.PageNumber); //页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PageNumber); //页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OrderNum))
 {
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OrderNum, conPaperSubViewpoint.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OrderNum); //序号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PdfContent))
 {
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conPaperSubViewpoint.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PdfContent); //Pdf内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.selectSpanRange))
 {
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strselectSpanRange, conPaperSubViewpoint.selectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.selectSpanRange); //选择Span范围
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperLineNum))
 {
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperLineNum, conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperPageNum))
 {
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperPageNum, conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AppraiseCount))
 {
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.AppraiseCount, conPaperSubViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OkCount))
 {
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OkCount, conPaperSubViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Score))
 {
 if (objPaperSubViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.Score, conPaperSubViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Score); //评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.StuScore))
 {
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.StuScore, conPaperSubViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TeaScore))
 {
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.TeaScore, conPaperSubViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CreateDate))
 {
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conPaperSubViewpoint.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CreateDate); //建立日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ShareId))
 {
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conPaperSubViewpoint.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.ShareId); //分享Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TopicId))
 {
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conPaperSubViewpoint.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.TopicId); //主题Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AttitudesId))
 {
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAttitudesId, conPaperSubViewpoint.AttitudesId); //态度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.AttitudesId); //态度Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.VersionCount))
 {
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.VersionCount, conPaperSubViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CitationCount))
 {
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.CitationCount, conPaperSubViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CourseId))
 {
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conPaperSubViewpoint.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CourseId); //课程Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperSubViewpointEN.IsRecommend == true?"1":"0", conPaperSubViewpoint.IsRecommend); //是否推荐
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdDate))
 {
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaperSubViewpoint.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.UpdDate); //修改日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdUser))
 {
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaperSubViewpoint.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.UpdUser); //修改人
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Memo))
 {
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaperSubViewpoint.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SubViewpointId = {0}", objPaperSubViewpointEN.SubViewpointId); 
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
 /// <param name = "objPaperSubViewpointEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPaperSubViewpointEN objPaperSubViewpointEN, string strCondition)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperSubViewpoint Set ");
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointContent))
 {
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointContent = '{0}',", strSubViewpointContent); //详情内容
 }
 else
 {
 sbSQL.Append(" SubViewpointContent = null,"); //详情内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperRWId))
 {
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperRWId = '{0}',", strPaperRWId); //课文阅读
 }
 else
 {
 sbSQL.Append(" PaperRWId = null,"); //课文阅读
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperId))
 {
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IdCurrEduCls))
 {
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UserId))
 {
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SectionId))
 {
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionId = '{0}',", strSectionId); //节Id
 }
 else
 {
 sbSQL.Append(" SectionId = null,"); //节Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointTypeId))
 {
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointTypeId = '{0}',", strSubViewpointTypeId); //类型Id
 }
 else
 {
 sbSQL.Append(" SubViewpointTypeId = null,"); //类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.gsKnowledgeTypeId))
 {
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" gsKnowledgeTypeId = '{0}',", strgsKnowledgeTypeId); //知识类型Id
 }
 else
 {
 sbSQL.Append(" gsKnowledgeTypeId = null,"); //知识类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.RWTitle))
 {
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RWTitle = '{0}',", strRWTitle); //读写标题
 }
 else
 {
 sbSQL.Append(" RWTitle = null,"); //读写标题
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainTypeId))
 {
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExplainTypeId = '{0}',", strExplainTypeId); //说明类型Id
 }
 else
 {
 sbSQL.Append(" ExplainTypeId = null,"); //说明类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainContent))
 {
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExplainContent = '{0}',", strExplainContent); //说明内容
 }
 else
 {
 sbSQL.Append(" ExplainContent = null,"); //说明内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objPaperSubViewpointEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LiteratureSourcesId))
 {
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSourcesId = '{0}',", strLiteratureSourcesId); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSourcesId = null,"); //文献来源
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OperationTypeId))
 {
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LevelId))
 {
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Conclusion))
 {
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Nationality))
 {
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Achievement))
 {
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Major))
 {
 if (objPaperSubViewpointEN.Major !=  null)
 {
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.WorkUnit))
 {
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PageNumber))
 {
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PageNumber, conPaperSubViewpoint.PageNumber); //页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PageNumber); //页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OrderNum))
 {
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OrderNum, conPaperSubViewpoint.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OrderNum); //序号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PdfContent))
 {
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.selectSpanRange))
 {
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" selectSpanRange = '{0}',", strselectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.Append(" selectSpanRange = null,"); //选择Span范围
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperLineNum))
 {
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperLineNum, conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperPageNum))
 {
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperPageNum, conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AppraiseCount))
 {
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.AppraiseCount, conPaperSubViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OkCount))
 {
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OkCount, conPaperSubViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Score))
 {
 if (objPaperSubViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.Score, conPaperSubViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Score); //评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.StuScore))
 {
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.StuScore, conPaperSubViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TeaScore))
 {
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.TeaScore, conPaperSubViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CreateDate))
 {
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ShareId))
 {
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TopicId))
 {
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AttitudesId))
 {
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AttitudesId = '{0}',", strAttitudesId); //态度Id
 }
 else
 {
 sbSQL.Append(" AttitudesId = null,"); //态度Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.VersionCount))
 {
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.VersionCount, conPaperSubViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CitationCount))
 {
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.CitationCount, conPaperSubViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CourseId))
 {
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objPaperSubViewpointEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdDate))
 {
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdUser))
 {
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Memo))
 {
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPaperSubViewpointEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPaperSubViewpointEN objPaperSubViewpointEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperSubViewpoint Set ");
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointContent))
 {
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointContent = '{0}',", strSubViewpointContent); //详情内容
 }
 else
 {
 sbSQL.Append(" SubViewpointContent = null,"); //详情内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperRWId))
 {
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperRWId = '{0}',", strPaperRWId); //课文阅读
 }
 else
 {
 sbSQL.Append(" PaperRWId = null,"); //课文阅读
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperId))
 {
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IdCurrEduCls))
 {
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UserId))
 {
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SectionId))
 {
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionId = '{0}',", strSectionId); //节Id
 }
 else
 {
 sbSQL.Append(" SectionId = null,"); //节Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointTypeId))
 {
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointTypeId = '{0}',", strSubViewpointTypeId); //类型Id
 }
 else
 {
 sbSQL.Append(" SubViewpointTypeId = null,"); //类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.gsKnowledgeTypeId))
 {
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" gsKnowledgeTypeId = '{0}',", strgsKnowledgeTypeId); //知识类型Id
 }
 else
 {
 sbSQL.Append(" gsKnowledgeTypeId = null,"); //知识类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.RWTitle))
 {
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RWTitle = '{0}',", strRWTitle); //读写标题
 }
 else
 {
 sbSQL.Append(" RWTitle = null,"); //读写标题
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainTypeId))
 {
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExplainTypeId = '{0}',", strExplainTypeId); //说明类型Id
 }
 else
 {
 sbSQL.Append(" ExplainTypeId = null,"); //说明类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainContent))
 {
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExplainContent = '{0}',", strExplainContent); //说明内容
 }
 else
 {
 sbSQL.Append(" ExplainContent = null,"); //说明内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objPaperSubViewpointEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LiteratureSourcesId))
 {
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureSourcesId = '{0}',", strLiteratureSourcesId); //文献来源
 }
 else
 {
 sbSQL.Append(" LiteratureSourcesId = null,"); //文献来源
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OperationTypeId))
 {
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LevelId))
 {
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelId = '{0}',", strLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" LevelId = null,"); //级别Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Conclusion))
 {
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Nationality))
 {
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Nationality = '{0}',", strNationality); //国籍
 }
 else
 {
 sbSQL.Append(" Nationality = null,"); //国籍
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Achievement))
 {
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Achievement = '{0}',", strAchievement); //成就
 }
 else
 {
 sbSQL.Append(" Achievement = null,"); //成就
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Major))
 {
 if (objPaperSubViewpointEN.Major !=  null)
 {
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Major = '{0}',", strMajor); //专业
 }
 else
 {
 sbSQL.Append(" Major = null,"); //专业
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.WorkUnit))
 {
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PageNumber))
 {
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PageNumber, conPaperSubViewpoint.PageNumber); //页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PageNumber); //页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OrderNum))
 {
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OrderNum, conPaperSubViewpoint.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OrderNum); //序号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PdfContent))
 {
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.selectSpanRange))
 {
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" selectSpanRange = '{0}',", strselectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.Append(" selectSpanRange = null,"); //选择Span范围
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperLineNum))
 {
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperLineNum, conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperPageNum))
 {
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperPageNum, conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AppraiseCount))
 {
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.AppraiseCount, conPaperSubViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OkCount))
 {
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OkCount, conPaperSubViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Score))
 {
 if (objPaperSubViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.Score, conPaperSubViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Score); //评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.StuScore))
 {
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.StuScore, conPaperSubViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TeaScore))
 {
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.TeaScore, conPaperSubViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CreateDate))
 {
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ShareId))
 {
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TopicId))
 {
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AttitudesId))
 {
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AttitudesId = '{0}',", strAttitudesId); //态度Id
 }
 else
 {
 sbSQL.Append(" AttitudesId = null,"); //态度Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.VersionCount))
 {
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.VersionCount, conPaperSubViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CitationCount))
 {
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.CitationCount, conPaperSubViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CourseId))
 {
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objPaperSubViewpointEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdDate))
 {
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdUser))
 {
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Memo))
 {
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperSubViewpointEN objPaperSubViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPaperSubViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperSubViewpoint Set ");
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointContent))
 {
 if (objPaperSubViewpointEN.SubViewpointContent !=  null)
 {
 var strSubViewpointContent = objPaperSubViewpointEN.SubViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointContent, conPaperSubViewpoint.SubViewpointContent); //详情内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.SubViewpointContent); //详情内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperRWId))
 {
 if (objPaperSubViewpointEN.PaperRWId  ==  "")
 {
 objPaperSubViewpointEN.PaperRWId = null;
 }
 if (objPaperSubViewpointEN.PaperRWId !=  null)
 {
 var strPaperRWId = objPaperSubViewpointEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperRWId, conPaperSubViewpoint.PaperRWId); //课文阅读
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperRWId); //课文阅读
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperId))
 {
 if (objPaperSubViewpointEN.PaperId !=  null)
 {
 var strPaperId = objPaperSubViewpointEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conPaperSubViewpoint.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperId); //论文Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IdCurrEduCls))
 {
 if (objPaperSubViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conPaperSubViewpoint.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UserId))
 {
 if (objPaperSubViewpointEN.UserId !=  null)
 {
 var strUserId = objPaperSubViewpointEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPaperSubViewpoint.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.UserId); //用户ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SectionId))
 {
 if (objPaperSubViewpointEN.SectionId !=  null)
 {
 var strSectionId = objPaperSubViewpointEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionId, conPaperSubViewpoint.SectionId); //节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.SectionId); //节Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.SubViewpointTypeId))
 {
 if (objPaperSubViewpointEN.SubViewpointTypeId  ==  "")
 {
 objPaperSubViewpointEN.SubViewpointTypeId = null;
 }
 if (objPaperSubViewpointEN.SubViewpointTypeId !=  null)
 {
 var strSubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointTypeId, conPaperSubViewpoint.SubViewpointTypeId); //类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.SubViewpointTypeId); //类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.gsKnowledgeTypeId))
 {
 if (objPaperSubViewpointEN.gsKnowledgeTypeId  ==  "")
 {
 objPaperSubViewpointEN.gsKnowledgeTypeId = null;
 }
 if (objPaperSubViewpointEN.gsKnowledgeTypeId !=  null)
 {
 var strgsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strgsKnowledgeTypeId, conPaperSubViewpoint.gsKnowledgeTypeId); //知识类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.gsKnowledgeTypeId); //知识类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.RWTitle))
 {
 if (objPaperSubViewpointEN.RWTitle !=  null)
 {
 var strRWTitle = objPaperSubViewpointEN.RWTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRWTitle, conPaperSubViewpoint.RWTitle); //读写标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.RWTitle); //读写标题
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainTypeId))
 {
 if (objPaperSubViewpointEN.ExplainTypeId  ==  "")
 {
 objPaperSubViewpointEN.ExplainTypeId = null;
 }
 if (objPaperSubViewpointEN.ExplainTypeId !=  null)
 {
 var strExplainTypeId = objPaperSubViewpointEN.ExplainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExplainTypeId, conPaperSubViewpoint.ExplainTypeId); //说明类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.ExplainTypeId); //说明类型Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ExplainContent))
 {
 if (objPaperSubViewpointEN.ExplainContent !=  null)
 {
 var strExplainContent = objPaperSubViewpointEN.ExplainContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExplainContent, conPaperSubViewpoint.ExplainContent); //说明内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.ExplainContent); //说明内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperSubViewpointEN.IsPublic == true?"1":"0", conPaperSubViewpoint.IsPublic); //是否公开
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LiteratureSourcesId))
 {
 if (objPaperSubViewpointEN.LiteratureSourcesId !=  null)
 {
 var strLiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureSourcesId, conPaperSubViewpoint.LiteratureSourcesId); //文献来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.LiteratureSourcesId); //文献来源
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OperationTypeId))
 {
 if (objPaperSubViewpointEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperSubViewpointEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conPaperSubViewpoint.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OperationTypeId); //操作类型ID
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.LevelId))
 {
 if (objPaperSubViewpointEN.LevelId !=  null)
 {
 var strLevelId = objPaperSubViewpointEN.LevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelId, conPaperSubViewpoint.LevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.LevelId); //级别Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Conclusion))
 {
 if (objPaperSubViewpointEN.Conclusion !=  null)
 {
 var strConclusion = objPaperSubViewpointEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conPaperSubViewpoint.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Conclusion); //结论
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Nationality))
 {
 if (objPaperSubViewpointEN.Nationality !=  null)
 {
 var strNationality = objPaperSubViewpointEN.Nationality.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNationality, conPaperSubViewpoint.Nationality); //国籍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Nationality); //国籍
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Achievement))
 {
 if (objPaperSubViewpointEN.Achievement !=  null)
 {
 var strAchievement = objPaperSubViewpointEN.Achievement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAchievement, conPaperSubViewpoint.Achievement); //成就
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Achievement); //成就
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Major))
 {
 if (objPaperSubViewpointEN.Major !=  null)
 {
 var strMajor = objPaperSubViewpointEN.Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajor, conPaperSubViewpoint.Major); //专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Major); //专业
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.WorkUnit))
 {
 if (objPaperSubViewpointEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPaperSubViewpointEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conPaperSubViewpoint.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.WorkUnit); //工作单位
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PageNumber))
 {
 if (objPaperSubViewpointEN.PageNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PageNumber, conPaperSubViewpoint.PageNumber); //页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PageNumber); //页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OrderNum))
 {
 if (objPaperSubViewpointEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OrderNum, conPaperSubViewpoint.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OrderNum); //序号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PdfContent))
 {
 if (objPaperSubViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objPaperSubViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conPaperSubViewpoint.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PdfContent); //Pdf内容
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.selectSpanRange))
 {
 if (objPaperSubViewpointEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objPaperSubViewpointEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strselectSpanRange, conPaperSubViewpoint.selectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.selectSpanRange); //选择Span范围
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperLineNum))
 {
 if (objPaperSubViewpointEN.PaperLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperLineNum, conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperLineNum); //论文行号
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.PaperPageNum))
 {
 if (objPaperSubViewpointEN.PaperPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.PaperPageNum, conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.PaperPageNum); //论文页码
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AppraiseCount))
 {
 if (objPaperSubViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.AppraiseCount, conPaperSubViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.OkCount))
 {
 if (objPaperSubViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.OkCount, conPaperSubViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Score))
 {
 if (objPaperSubViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.Score, conPaperSubViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Score); //评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.StuScore))
 {
 if (objPaperSubViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.StuScore, conPaperSubViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TeaScore))
 {
 if (objPaperSubViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.TeaScore, conPaperSubViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CreateDate))
 {
 if (objPaperSubViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperSubViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conPaperSubViewpoint.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CreateDate); //建立日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.ShareId))
 {
 if (objPaperSubViewpointEN.ShareId !=  null)
 {
 var strShareId = objPaperSubViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conPaperSubViewpoint.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.ShareId); //分享Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.TopicId))
 {
 if (objPaperSubViewpointEN.TopicId !=  null)
 {
 var strTopicId = objPaperSubViewpointEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conPaperSubViewpoint.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.TopicId); //主题Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.AttitudesId))
 {
 if (objPaperSubViewpointEN.AttitudesId !=  null)
 {
 var strAttitudesId = objPaperSubViewpointEN.AttitudesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAttitudesId, conPaperSubViewpoint.AttitudesId); //态度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.AttitudesId); //态度Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.VersionCount))
 {
 if (objPaperSubViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.VersionCount, conPaperSubViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CitationCount))
 {
 if (objPaperSubViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointEN.CitationCount, conPaperSubViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.CourseId))
 {
 if (objPaperSubViewpointEN.CourseId !=  null)
 {
 var strCourseId = objPaperSubViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conPaperSubViewpoint.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.CourseId); //课程Id
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperSubViewpointEN.IsRecommend == true?"1":"0", conPaperSubViewpoint.IsRecommend); //是否推荐
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdDate))
 {
 if (objPaperSubViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaperSubViewpoint.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.UpdDate); //修改日期
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.UpdUser))
 {
 if (objPaperSubViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaperSubViewpoint.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.UpdUser); //修改人
 }
 }
 
 if (objPaperSubViewpointEN.IsUpdated(conPaperSubViewpoint.Memo))
 {
 if (objPaperSubViewpointEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaperSubViewpoint.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpoint.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SubViewpointId = {0}", objPaperSubViewpointEN.SubViewpointId); 
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngSubViewpointId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngSubViewpointId,
};
 objSQL.ExecSP("PaperSubViewpoint_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngSubViewpointId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
//删除PaperSubViewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperSubViewpoint where SubViewpointId = " + ""+ lngSubViewpointId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPaperSubViewpoint(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
//删除PaperSubViewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperSubViewpoint where SubViewpointId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngSubViewpointId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
//删除PaperSubViewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperSubViewpoint where SubViewpointId = " + ""+ lngSubViewpointId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPaperSubViewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: DelPaperSubViewpoint)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PaperSubViewpoint where " + strCondition ;
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
public bool DelPaperSubViewpointWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPaperSubViewpointDA: DelPaperSubViewpointWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PaperSubViewpoint where " + strCondition ;
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
 /// <param name = "objPaperSubViewpointENS">源对象</param>
 /// <param name = "objPaperSubViewpointENT">目标对象</param>
public void CopyTo(clsPaperSubViewpointEN objPaperSubViewpointENS, clsPaperSubViewpointEN objPaperSubViewpointENT)
{
objPaperSubViewpointENT.SubViewpointId = objPaperSubViewpointENS.SubViewpointId; //子观点Id
objPaperSubViewpointENT.SubViewpointContent = objPaperSubViewpointENS.SubViewpointContent; //详情内容
objPaperSubViewpointENT.PaperRWId = objPaperSubViewpointENS.PaperRWId; //课文阅读
objPaperSubViewpointENT.PaperId = objPaperSubViewpointENS.PaperId; //论文Id
objPaperSubViewpointENT.IdCurrEduCls = objPaperSubViewpointENS.IdCurrEduCls; //教学班流水号
objPaperSubViewpointENT.UserId = objPaperSubViewpointENS.UserId; //用户ID
objPaperSubViewpointENT.SectionId = objPaperSubViewpointENS.SectionId; //节Id
objPaperSubViewpointENT.SubViewpointTypeId = objPaperSubViewpointENS.SubViewpointTypeId; //类型Id
objPaperSubViewpointENT.gsKnowledgeTypeId = objPaperSubViewpointENS.gsKnowledgeTypeId; //知识类型Id
objPaperSubViewpointENT.RWTitle = objPaperSubViewpointENS.RWTitle; //读写标题
objPaperSubViewpointENT.ExplainTypeId = objPaperSubViewpointENS.ExplainTypeId; //说明类型Id
objPaperSubViewpointENT.ExplainContent = objPaperSubViewpointENS.ExplainContent; //说明内容
objPaperSubViewpointENT.IsPublic = objPaperSubViewpointENS.IsPublic; //是否公开
objPaperSubViewpointENT.LiteratureSourcesId = objPaperSubViewpointENS.LiteratureSourcesId; //文献来源
objPaperSubViewpointENT.OperationTypeId = objPaperSubViewpointENS.OperationTypeId; //操作类型ID
objPaperSubViewpointENT.LevelId = objPaperSubViewpointENS.LevelId; //级别Id
objPaperSubViewpointENT.Conclusion = objPaperSubViewpointENS.Conclusion; //结论
objPaperSubViewpointENT.Nationality = objPaperSubViewpointENS.Nationality; //国籍
objPaperSubViewpointENT.Achievement = objPaperSubViewpointENS.Achievement; //成就
objPaperSubViewpointENT.Major = objPaperSubViewpointENS.Major; //专业
objPaperSubViewpointENT.WorkUnit = objPaperSubViewpointENS.WorkUnit; //工作单位
objPaperSubViewpointENT.PageNumber = objPaperSubViewpointENS.PageNumber; //页码
objPaperSubViewpointENT.OrderNum = objPaperSubViewpointENS.OrderNum; //序号
objPaperSubViewpointENT.PdfContent = objPaperSubViewpointENS.PdfContent; //Pdf内容
objPaperSubViewpointENT.selectSpanRange = objPaperSubViewpointENS.selectSpanRange; //选择Span范围
objPaperSubViewpointENT.PaperLineNum = objPaperSubViewpointENS.PaperLineNum; //论文行号
objPaperSubViewpointENT.PaperPageNum = objPaperSubViewpointENS.PaperPageNum; //论文页码
objPaperSubViewpointENT.AppraiseCount = objPaperSubViewpointENS.AppraiseCount; //评论数
objPaperSubViewpointENT.OkCount = objPaperSubViewpointENS.OkCount; //点赞统计
objPaperSubViewpointENT.Score = objPaperSubViewpointENS.Score; //评分
objPaperSubViewpointENT.StuScore = objPaperSubViewpointENS.StuScore; //学生平均分
objPaperSubViewpointENT.TeaScore = objPaperSubViewpointENS.TeaScore; //教师评分
objPaperSubViewpointENT.CreateDate = objPaperSubViewpointENS.CreateDate; //建立日期
objPaperSubViewpointENT.ShareId = objPaperSubViewpointENS.ShareId; //分享Id
objPaperSubViewpointENT.TopicId = objPaperSubViewpointENS.TopicId; //主题Id
objPaperSubViewpointENT.AttitudesId = objPaperSubViewpointENS.AttitudesId; //态度Id
objPaperSubViewpointENT.VersionCount = objPaperSubViewpointENS.VersionCount; //版本统计
objPaperSubViewpointENT.CitationCount = objPaperSubViewpointENS.CitationCount; //引用统计
objPaperSubViewpointENT.CourseId = objPaperSubViewpointENS.CourseId; //课程Id
objPaperSubViewpointENT.IsRecommend = objPaperSubViewpointENS.IsRecommend; //是否推荐
objPaperSubViewpointENT.UpdDate = objPaperSubViewpointENS.UpdDate; //修改日期
objPaperSubViewpointENT.UpdUser = objPaperSubViewpointENS.UpdUser; //修改人
objPaperSubViewpointENT.Memo = objPaperSubViewpointENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointEN.PaperId, conPaperSubViewpoint.PaperId);
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointEN.IdCurrEduCls, conPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointEN.UserId, conPaperSubViewpoint.UserId);
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointEN.SubViewpointTypeId, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointEN.gsKnowledgeTypeId, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointEN.ShareId, conPaperSubViewpoint.ShareId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SubViewpointContent, 500, conPaperSubViewpoint.SubViewpointContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PaperRWId, 8, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PaperId, 8, conPaperSubViewpoint.PaperId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.IdCurrEduCls, 8, conPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UserId, 18, conPaperSubViewpoint.UserId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SectionId, 8, conPaperSubViewpoint.SectionId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.gsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.RWTitle, 50, conPaperSubViewpoint.RWTitle);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ExplainContent, 5000, conPaperSubViewpoint.ExplainContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.LiteratureSourcesId, 8, conPaperSubViewpoint.LiteratureSourcesId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.OperationTypeId, 4, conPaperSubViewpoint.OperationTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.LevelId, 2, conPaperSubViewpoint.LevelId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Conclusion, 5000, conPaperSubViewpoint.Conclusion);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Nationality, 50, conPaperSubViewpoint.Nationality);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Achievement, 5000, conPaperSubViewpoint.Achievement);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Major, 50, conPaperSubViewpoint.Major);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.WorkUnit, 100, conPaperSubViewpoint.WorkUnit);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PdfContent, 2000, conPaperSubViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.selectSpanRange, 50, conPaperSubViewpoint.selectSpanRange);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.CreateDate, 20, conPaperSubViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ShareId, 2, conPaperSubViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.TopicId, 8, conPaperSubViewpoint.TopicId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.AttitudesId, 2, conPaperSubViewpoint.AttitudesId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.CourseId, 8, conPaperSubViewpoint.CourseId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UpdDate, 20, conPaperSubViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UpdUser, 20, conPaperSubViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Memo, 1000, conPaperSubViewpoint.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.PaperRWId, 8, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.SubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.gsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.ExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
 objPaperSubViewpointEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SubViewpointContent, 500, conPaperSubViewpoint.SubViewpointContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PaperRWId, 8, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PaperId, 8, conPaperSubViewpoint.PaperId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.IdCurrEduCls, 8, conPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UserId, 18, conPaperSubViewpoint.UserId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SectionId, 8, conPaperSubViewpoint.SectionId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.gsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.RWTitle, 50, conPaperSubViewpoint.RWTitle);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ExplainContent, 5000, conPaperSubViewpoint.ExplainContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.LiteratureSourcesId, 8, conPaperSubViewpoint.LiteratureSourcesId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.OperationTypeId, 4, conPaperSubViewpoint.OperationTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.LevelId, 2, conPaperSubViewpoint.LevelId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Conclusion, 5000, conPaperSubViewpoint.Conclusion);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Nationality, 50, conPaperSubViewpoint.Nationality);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Achievement, 5000, conPaperSubViewpoint.Achievement);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Major, 50, conPaperSubViewpoint.Major);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.WorkUnit, 100, conPaperSubViewpoint.WorkUnit);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PdfContent, 2000, conPaperSubViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.selectSpanRange, 50, conPaperSubViewpoint.selectSpanRange);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.CreateDate, 20, conPaperSubViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ShareId, 2, conPaperSubViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.TopicId, 8, conPaperSubViewpoint.TopicId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.AttitudesId, 2, conPaperSubViewpoint.AttitudesId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.CourseId, 8, conPaperSubViewpoint.CourseId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UpdDate, 20, conPaperSubViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UpdUser, 20, conPaperSubViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Memo, 1000, conPaperSubViewpoint.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.PaperRWId, 8, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.SubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.gsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.ExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
 objPaperSubViewpointEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SubViewpointContent, 500, conPaperSubViewpoint.SubViewpointContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PaperRWId, 8, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PaperId, 8, conPaperSubViewpoint.PaperId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.IdCurrEduCls, 8, conPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UserId, 18, conPaperSubViewpoint.UserId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SectionId, 8, conPaperSubViewpoint.SectionId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.SubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.gsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.RWTitle, 50, conPaperSubViewpoint.RWTitle);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ExplainContent, 5000, conPaperSubViewpoint.ExplainContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.LiteratureSourcesId, 8, conPaperSubViewpoint.LiteratureSourcesId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.OperationTypeId, 4, conPaperSubViewpoint.OperationTypeId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.LevelId, 2, conPaperSubViewpoint.LevelId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Conclusion, 5000, conPaperSubViewpoint.Conclusion);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Nationality, 50, conPaperSubViewpoint.Nationality);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Achievement, 5000, conPaperSubViewpoint.Achievement);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Major, 50, conPaperSubViewpoint.Major);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.WorkUnit, 100, conPaperSubViewpoint.WorkUnit);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.PdfContent, 2000, conPaperSubViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.selectSpanRange, 50, conPaperSubViewpoint.selectSpanRange);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.CreateDate, 20, conPaperSubViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.ShareId, 2, conPaperSubViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.TopicId, 8, conPaperSubViewpoint.TopicId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.AttitudesId, 2, conPaperSubViewpoint.AttitudesId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.CourseId, 8, conPaperSubViewpoint.CourseId);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UpdDate, 20, conPaperSubViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.UpdUser, 20, conPaperSubViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objPaperSubViewpointEN.Memo, 1000, conPaperSubViewpoint.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.SubViewpointContent, conPaperSubViewpoint.SubViewpointContent);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.PaperRWId, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.PaperId, conPaperSubViewpoint.PaperId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.IdCurrEduCls, conPaperSubViewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.UserId, conPaperSubViewpoint.UserId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.SectionId, conPaperSubViewpoint.SectionId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.SubViewpointTypeId, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.gsKnowledgeTypeId, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.RWTitle, conPaperSubViewpoint.RWTitle);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.ExplainTypeId, conPaperSubViewpoint.ExplainTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.ExplainContent, conPaperSubViewpoint.ExplainContent);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.LiteratureSourcesId, conPaperSubViewpoint.LiteratureSourcesId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.OperationTypeId, conPaperSubViewpoint.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.LevelId, conPaperSubViewpoint.LevelId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.Conclusion, conPaperSubViewpoint.Conclusion);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.Nationality, conPaperSubViewpoint.Nationality);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.Achievement, conPaperSubViewpoint.Achievement);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.Major, conPaperSubViewpoint.Major);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.WorkUnit, conPaperSubViewpoint.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.PdfContent, conPaperSubViewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.selectSpanRange, conPaperSubViewpoint.selectSpanRange);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.CreateDate, conPaperSubViewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.ShareId, conPaperSubViewpoint.ShareId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.TopicId, conPaperSubViewpoint.TopicId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.AttitudesId, conPaperSubViewpoint.AttitudesId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.CourseId, conPaperSubViewpoint.CourseId);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.UpdDate, conPaperSubViewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.UpdUser, conPaperSubViewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointEN.Memo, conPaperSubViewpoint.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.PaperRWId, 8, conPaperSubViewpoint.PaperRWId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.SubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.gsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldForeignKey(objPaperSubViewpointEN.ExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
 objPaperSubViewpointEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSubViewpointId()
{
//获取某学院所有专业信息
string strSQL = "select SubViewpointId, SubViewpointContent from PaperSubViewpoint ";
 clsSpecSQLforSql mySql = clsPaperSubViewpointDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperSubViewpointEN.PaperId);
 sbCondition.AppendFormat(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPaperSubViewpointEN.UserId);
 if (objPaperSubViewpointEN.SubViewpointContent == null)
{
 sbCondition.AppendFormat(" and SubViewpointContent is null");
}
else
{
 sbCondition.AppendFormat(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.SubViewpointContent);
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperSubViewpointEN._CurrTabName);
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperSubViewpointEN._CurrTabName, strCondition);
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
 objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperParagraphDA
 表名:vgs_PaperParagraph(01120747)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 论文段落视图(vgs_PaperParagraph)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PaperParagraphDA : clsCommBase4DA
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
 return clsvgs_PaperParagraphEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PaperParagraphEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperParagraphEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PaperParagraphEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PaperParagraphEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strParagraphId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strParagraphId)
{
strParagraphId = strParagraphId.Replace("'", "''");
if (strParagraphId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vgs_PaperParagraph中,检查关键字,长度不正确!(clsvgs_PaperParagraphDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strParagraphId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_PaperParagraph中,关键字不能为空 或 null!(clsvgs_PaperParagraphDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strParagraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_PaperParagraphDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PaperParagraph(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable_vgs_PaperParagraph)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PaperParagraph.* from vgs_PaperParagraph Left Join {1} on {2} where {3} and vgs_PaperParagraph.ParagraphId not in (Select top {5} vgs_PaperParagraph.ParagraphId from vgs_PaperParagraph Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1} and ParagraphId not in (Select top {2} ParagraphId from vgs_PaperParagraph where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1} and ParagraphId not in (Select top {3} ParagraphId from vgs_PaperParagraph where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PaperParagraph.* from vgs_PaperParagraph Left Join {1} on {2} where {3} and vgs_PaperParagraph.ParagraphId not in (Select top {5} vgs_PaperParagraph.ParagraphId from vgs_PaperParagraph Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1} and ParagraphId not in (Select top {2} ParagraphId from vgs_PaperParagraph where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PaperParagraph where {1} and ParagraphId not in (Select top {3} ParagraphId from vgs_PaperParagraph where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PaperParagraphEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA:GetObjLst)", objException.Message));
}
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PaperParagraphDA: GetObjLst)", objException.Message));
}
objvgs_PaperParagraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PaperParagraphEN);
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
public List<clsvgs_PaperParagraphEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PaperParagraphDA: GetObjLst)", objException.Message));
}
objvgs_PaperParagraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PaperParagraphEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PaperParagraph(ref clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where ParagraphId = " + "'"+ objvgs_PaperParagraphEN.ParagraphId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PaperParagraphEN.ParagraphId = objDT.Rows[0][convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PaperParagraphEN.ParagraphStateName = objDT.Rows[0][convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperParagraphEN.ParagraphTypeName = objDT.Rows[0][convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperParagraphEN.PaperId = objDT.Rows[0][convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperParagraphEN.SectionId = objDT.Rows[0][convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperParagraphEN.ParagraphStateId = objDT.Rows[0][convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperParagraphEN.ParagraphTypeId = objDT.Rows[0][convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperParagraphEN.ParagraphContent = objDT.Rows[0][convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PaperParagraphEN.VoteCount = TransNullToInt(objDT.Rows[0][convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperParagraphEN.CommentCount = TransNullToInt(objDT.Rows[0][convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperParagraphEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperParagraphEN.CreateDate = objDT.Rows[0][convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperParagraphEN.CreateUser = objDT.Rows[0][convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PaperParagraphEN.UpdDate = objDT.Rows[0][convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperParagraphEN.UpdUser = objDT.Rows[0][convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperParagraphEN.Memo = objDT.Rows[0][convgs_PaperParagraph.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperParagraphEN.OrderNum = TransNullToInt(objDT.Rows[0][convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PaperParagraphDA: Getvgs_PaperParagraph)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PaperParagraphEN GetObjByParagraphId(string strParagraphId)
{
CheckPrimaryKey(strParagraphId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where ParagraphId = " + "'"+ strParagraphId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
 objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PaperParagraphDA: GetObjByParagraphId)", objException.Message));
}
return objvgs_PaperParagraphEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PaperParagraphEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PaperParagraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN()
{
ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(), //段落Id
ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(), //段落状态
ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(), //段落类型
PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(), //论文Id
SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(), //节Id
ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(), //段落状态Id
ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(), //段落类型Id
ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(), //段落内容
VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()), //点赞计数
CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()), //评论数
VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(), //建立日期
CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(), //建立用户
UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(), //备注
OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()) //序号
};
objvgs_PaperParagraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperParagraphEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PaperParagraphDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PaperParagraphEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PaperParagraphDA: GetObjByDataRowvgs_PaperParagraph)", objException.Message));
}
objvgs_PaperParagraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperParagraphEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PaperParagraphEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PaperParagraphDA: GetObjByDataRow)", objException.Message));
}
objvgs_PaperParagraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PaperParagraphEN;
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
objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PaperParagraphEN._CurrTabName, convgs_PaperParagraph.ParagraphId, 10, "");
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
objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PaperParagraphEN._CurrTabName, convgs_PaperParagraph.ParagraphId, 10, strPrefix);
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ParagraphId from vgs_PaperParagraph where " + strCondition;
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ParagraphId from vgs_PaperParagraph where " + strCondition;
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
 /// <param name = "strParagraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strParagraphId)
{
CheckPrimaryKey(strParagraphId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PaperParagraph", "ParagraphId = " + "'"+ strParagraphId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PaperParagraphDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PaperParagraph", strCondition))
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
objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PaperParagraph");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphENS">源对象</param>
 /// <param name = "objvgs_PaperParagraphENT">目标对象</param>
public void CopyTo(clsvgs_PaperParagraphEN objvgs_PaperParagraphENS, clsvgs_PaperParagraphEN objvgs_PaperParagraphENT)
{
objvgs_PaperParagraphENT.ParagraphId = objvgs_PaperParagraphENS.ParagraphId; //段落Id
objvgs_PaperParagraphENT.ParagraphStateName = objvgs_PaperParagraphENS.ParagraphStateName; //段落状态
objvgs_PaperParagraphENT.ParagraphTypeName = objvgs_PaperParagraphENS.ParagraphTypeName; //段落类型
objvgs_PaperParagraphENT.PaperId = objvgs_PaperParagraphENS.PaperId; //论文Id
objvgs_PaperParagraphENT.SectionId = objvgs_PaperParagraphENS.SectionId; //节Id
objvgs_PaperParagraphENT.ParagraphStateId = objvgs_PaperParagraphENS.ParagraphStateId; //段落状态Id
objvgs_PaperParagraphENT.ParagraphTypeId = objvgs_PaperParagraphENS.ParagraphTypeId; //段落类型Id
objvgs_PaperParagraphENT.ParagraphContent = objvgs_PaperParagraphENS.ParagraphContent; //段落内容
objvgs_PaperParagraphENT.VoteCount = objvgs_PaperParagraphENS.VoteCount; //点赞计数
objvgs_PaperParagraphENT.CommentCount = objvgs_PaperParagraphENS.CommentCount; //评论数
objvgs_PaperParagraphENT.VersionCount = objvgs_PaperParagraphENS.VersionCount; //版本统计
objvgs_PaperParagraphENT.CreateDate = objvgs_PaperParagraphENS.CreateDate; //建立日期
objvgs_PaperParagraphENT.CreateUser = objvgs_PaperParagraphENS.CreateUser; //建立用户
objvgs_PaperParagraphENT.UpdDate = objvgs_PaperParagraphENS.UpdDate; //修改日期
objvgs_PaperParagraphENT.UpdUser = objvgs_PaperParagraphENS.UpdUser; //修改人
objvgs_PaperParagraphENT.Memo = objvgs_PaperParagraphENS.Memo; //备注
objvgs_PaperParagraphENT.OrderNum = objvgs_PaperParagraphENS.OrderNum; //序号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.ParagraphId, 10, convgs_PaperParagraph.ParagraphId);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.ParagraphStateName, 100, convgs_PaperParagraph.ParagraphStateName);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.ParagraphTypeName, 100, convgs_PaperParagraph.ParagraphTypeName);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.PaperId, 8, convgs_PaperParagraph.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.SectionId, 8, convgs_PaperParagraph.SectionId);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.ParagraphStateId, 2, convgs_PaperParagraph.ParagraphStateId);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.ParagraphTypeId, 2, convgs_PaperParagraph.ParagraphTypeId);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.CreateDate, 20, convgs_PaperParagraph.CreateDate);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.CreateUser, 50, convgs_PaperParagraph.CreateUser);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.UpdDate, 20, convgs_PaperParagraph.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.UpdUser, 20, convgs_PaperParagraph.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PaperParagraphEN.Memo, 1000, convgs_PaperParagraph.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.ParagraphId, convgs_PaperParagraph.ParagraphId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.ParagraphStateName, convgs_PaperParagraph.ParagraphStateName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.ParagraphTypeName, convgs_PaperParagraph.ParagraphTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.PaperId, convgs_PaperParagraph.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.SectionId, convgs_PaperParagraph.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.ParagraphStateId, convgs_PaperParagraph.ParagraphStateId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.ParagraphTypeId, convgs_PaperParagraph.ParagraphTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.CreateDate, convgs_PaperParagraph.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.CreateUser, convgs_PaperParagraph.CreateUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.UpdDate, convgs_PaperParagraph.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.UpdUser, convgs_PaperParagraph.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PaperParagraphEN.Memo, convgs_PaperParagraph.Memo);
//检查外键字段长度
 objvgs_PaperParagraphEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetParagraphId()
{
//获取某学院所有专业信息
string strSQL = "select ParagraphId, ParagraphTypeName from vgs_PaperParagraph ";
 clsSpecSQLforSql mySql = clsvgs_PaperParagraphDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vgs_PaperParagraph(论文段落视图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.ParagraphId);
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PaperParagraphEN._CurrTabName);
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PaperParagraphEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PaperParagraphDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
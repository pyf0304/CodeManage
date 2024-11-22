
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvThesisDA
 表名:vThesis(01120537)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:19:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养(GraduateEdu)
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
 /// vThesis(vThesis)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvThesisDA : clsCommBase4DA
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
 return clsvThesisEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvThesisEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvThesisEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvThesisEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvThesisEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strThesisId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strThesisId)
{
strThesisId = strThesisId.Replace("'", "''");
if (strThesisId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vThesis中,检查关键字,长度不正确!(clsvThesisDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strThesisId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vThesis中,关键字不能为空 或 null!(clsvThesisDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strThesisId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvThesisDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vThesis(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable_vThesis)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vThesis where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vThesis where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvThesisDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vThesis where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvThesisDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vThesis.* from vThesis Left Join {1} on {2} where {3} and vThesis.ThesisId not in (Select top {5} vThesis.ThesisId from vThesis Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vThesis where {1} and ThesisId not in (Select top {2} ThesisId from vThesis where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vThesis where {1} and ThesisId not in (Select top {3} ThesisId from vThesis where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvThesisDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vThesis.* from vThesis Left Join {1} on {2} where {3} and vThesis.ThesisId not in (Select top {5} vThesis.ThesisId from vThesis Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vThesis where {1} and ThesisId not in (Select top {2} ThesisId from vThesis where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vThesis where {1} and ThesisId not in (Select top {3} ThesisId from vThesis where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvThesisEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvThesisDA:GetObjLst)", objException.Message));
}
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = TransNullToBool(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvThesisDA: GetObjLst)", objException.Message));
}
objvThesisEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvThesisEN);
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
public List<clsvThesisEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvThesisDA:GetObjLstByTabName)", objException.Message));
}
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = TransNullToBool(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvThesisDA: GetObjLst)", objException.Message));
}
objvThesisEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvThesisEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvThesisEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvThesis(ref clsvThesisEN objvThesisEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where ThesisId = " + "'"+ objvThesisEN.ThesisId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvThesisEN.ThesisId = objDT.Rows[0][convThesis.ThesisId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:False)
 objvThesisEN.ThesisTitle = objDT.Rows[0][convThesis.ThesisTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:100,是否可空:False)
 objvThesisEN.ThesisName = objDT.Rows[0][convThesis.ThesisName].ToString().Trim(); //主题名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvThesisEN.ThesisContent = objDT.Rows[0][convThesis.ThesisContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvThesisEN.Periodical = objDT.Rows[0][convThesis.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvThesisEN.Author = objDT.Rows[0][convThesis.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvThesisEN.ResearchQuestion = objDT.Rows[0][convThesis.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvThesisEN.UpdDate = objDT.Rows[0][convThesis.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvThesisEN.UpdUserId = objDT.Rows[0][convThesis.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvThesisEN.Memo = objDT.Rows[0][convThesis.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.OperationTypeId = objDT.Rows[0][convThesis.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvThesisEN.OperationTypeName = objDT.Rows[0][convThesis.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvThesisEN.Keyword = objDT.Rows[0][convThesis.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.LiteratureLink = objDT.Rows[0][convThesis.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.LiteratureSources = objDT.Rows[0][convThesis.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.ResearcherInformation = objDT.Rows[0][convThesis.ResearcherInformation].ToString().Trim(); //研究者(字段类型:varchar,字段长度:200,是否可空:True)
 objvThesisEN.UploadfileUrl = objDT.Rows[0][convThesis.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvThesisEN.QuoteId = objDT.Rows[0][convThesis.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvThesisEN.QuoteThesisContent = objDT.Rows[0][convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvThesisEN.QuoteThesisName = objDT.Rows[0][convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName(字段类型:varchar,字段长度:100,是否可空:True)
 objvThesisEN.QuoteThesisTitle = objDT.Rows[0][convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvThesisDA: GetvThesis)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strThesisId">表关键字</param>
 /// <returns>表对象</returns>
public clsvThesisEN GetObjByThesisId(string strThesisId)
{
CheckPrimaryKey(strThesisId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where ThesisId = " + "'"+ strThesisId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
 objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:False)
 objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:100,是否可空:False)
 objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者(字段类型:varchar,字段长度:200,是否可空:True)
 objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName(字段类型:varchar,字段长度:100,是否可空:True)
 objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvThesisDA: GetObjByThesisId)", objException.Message));
}
return objvThesisEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvThesisEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvThesisDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
strSQL = "Select * from vThesis where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvThesisEN objvThesisEN = new clsvThesisEN()
{
ThesisId = objRow[convThesis.ThesisId].ToString().Trim(), //论文Id
ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(), //论文标题
ThesisName = objRow[convThesis.ThesisName].ToString().Trim(), //主题名称
ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(), //主题内容
Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(), //期刊
Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(), //研究问题
UpdDate = objRow[convThesis.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(), //备注
OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(), //操作类型ID
OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(), //操作类型名
Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(), //关键字
LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(), //文献链接
LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(), //文献来源
ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(), //研究者
UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[convThesis.IsQuotethesis].ToString().Trim()), //是否引用论文
QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(), //引用Id
QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(), //QuoteThesisContent
QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(), //QuoteThesisName
QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim() //QuoteThesisTitle
};
objvThesisEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvThesisEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvThesisDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvThesisEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = TransNullToBool(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvThesisDA: GetObjByDataRowvThesis)", objException.Message));
}
objvThesisEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvThesisEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvThesisEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = TransNullToBool(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvThesisDA: GetObjByDataRow)", objException.Message));
}
objvThesisEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvThesisEN;
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
objSQL = clsvThesisDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvThesisEN._CurrTabName, convThesis.ThesisId, 8, "");
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
objSQL = clsvThesisDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvThesisEN._CurrTabName, convThesis.ThesisId, 8, strPrefix);
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ThesisId from vThesis where " + strCondition;
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ThesisId from vThesis where " + strCondition;
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
 /// <param name = "strThesisId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strThesisId)
{
CheckPrimaryKey(strThesisId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vThesis", "ThesisId = " + "'"+ strThesisId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvThesisDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvThesisDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vThesis", strCondition))
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
objSQL = clsvThesisDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vThesis");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvThesisENS">源对象</param>
 /// <param name = "objvThesisENT">目标对象</param>
public void CopyTo(clsvThesisEN objvThesisENS, clsvThesisEN objvThesisENT)
{
objvThesisENT.ThesisId = objvThesisENS.ThesisId; //论文Id
objvThesisENT.ThesisTitle = objvThesisENS.ThesisTitle; //论文标题
objvThesisENT.ThesisName = objvThesisENS.ThesisName; //主题名称
objvThesisENT.ThesisContent = objvThesisENS.ThesisContent; //主题内容
objvThesisENT.Periodical = objvThesisENS.Periodical; //期刊
objvThesisENT.Author = objvThesisENS.Author; //作者
objvThesisENT.ResearchQuestion = objvThesisENS.ResearchQuestion; //研究问题
objvThesisENT.UpdDate = objvThesisENS.UpdDate; //修改日期
objvThesisENT.UpdUserId = objvThesisENS.UpdUserId; //修改用户Id
objvThesisENT.Memo = objvThesisENS.Memo; //备注
objvThesisENT.OperationTypeId = objvThesisENS.OperationTypeId; //操作类型ID
objvThesisENT.OperationTypeName = objvThesisENS.OperationTypeName; //操作类型名
objvThesisENT.Keyword = objvThesisENS.Keyword; //关键字
objvThesisENT.LiteratureLink = objvThesisENS.LiteratureLink; //文献链接
objvThesisENT.LiteratureSources = objvThesisENS.LiteratureSources; //文献来源
objvThesisENT.ResearcherInformation = objvThesisENS.ResearcherInformation; //研究者
objvThesisENT.UploadfileUrl = objvThesisENS.UploadfileUrl; //文件地址
objvThesisENT.IsQuotethesis = objvThesisENS.IsQuotethesis; //是否引用论文
objvThesisENT.QuoteId = objvThesisENS.QuoteId; //引用Id
objvThesisENT.QuoteThesisContent = objvThesisENS.QuoteThesisContent; //QuoteThesisContent
objvThesisENT.QuoteThesisName = objvThesisENS.QuoteThesisName; //QuoteThesisName
objvThesisENT.QuoteThesisTitle = objvThesisENS.QuoteThesisTitle; //QuoteThesisTitle
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvThesisEN objvThesisEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvThesisEN.ThesisId, 8, convThesis.ThesisId);
clsCheckSql.CheckFieldLen(objvThesisEN.ThesisTitle, 100, convThesis.ThesisTitle);
clsCheckSql.CheckFieldLen(objvThesisEN.ThesisName, 100, convThesis.ThesisName);
clsCheckSql.CheckFieldLen(objvThesisEN.Periodical, 100, convThesis.Periodical);
clsCheckSql.CheckFieldLen(objvThesisEN.Author, 200, convThesis.Author);
clsCheckSql.CheckFieldLen(objvThesisEN.ResearchQuestion, 2000, convThesis.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvThesisEN.UpdDate, 20, convThesis.UpdDate);
clsCheckSql.CheckFieldLen(objvThesisEN.UpdUserId, 20, convThesis.UpdUserId);
clsCheckSql.CheckFieldLen(objvThesisEN.Memo, 1000, convThesis.Memo);
clsCheckSql.CheckFieldLen(objvThesisEN.OperationTypeId, 4, convThesis.OperationTypeId);
clsCheckSql.CheckFieldLen(objvThesisEN.OperationTypeName, 50, convThesis.OperationTypeName);
clsCheckSql.CheckFieldLen(objvThesisEN.Keyword, 1000, convThesis.Keyword);
clsCheckSql.CheckFieldLen(objvThesisEN.LiteratureLink, 1000, convThesis.LiteratureLink);
clsCheckSql.CheckFieldLen(objvThesisEN.LiteratureSources, 1000, convThesis.LiteratureSources);
clsCheckSql.CheckFieldLen(objvThesisEN.ResearcherInformation, 200, convThesis.ResearcherInformation);
clsCheckSql.CheckFieldLen(objvThesisEN.UploadfileUrl, 1000, convThesis.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvThesisEN.QuoteId, 8, convThesis.QuoteId);
clsCheckSql.CheckFieldLen(objvThesisEN.QuoteThesisName, 100, convThesis.QuoteThesisName);
clsCheckSql.CheckFieldLen(objvThesisEN.QuoteThesisTitle, 100, convThesis.QuoteThesisTitle);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.ThesisId, convThesis.ThesisId);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.ThesisTitle, convThesis.ThesisTitle);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.ThesisName, convThesis.ThesisName);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.Periodical, convThesis.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.Author, convThesis.Author);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.ResearchQuestion, convThesis.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.UpdDate, convThesis.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.UpdUserId, convThesis.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.Memo, convThesis.Memo);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.OperationTypeId, convThesis.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.OperationTypeName, convThesis.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.Keyword, convThesis.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.LiteratureLink, convThesis.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.LiteratureSources, convThesis.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.ResearcherInformation, convThesis.ResearcherInformation);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.UploadfileUrl, convThesis.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.QuoteId, convThesis.QuoteId);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.QuoteThesisName, convThesis.QuoteThesisName);
clsCheckSql.CheckSqlInjection4Field(objvThesisEN.QuoteThesisTitle, convThesis.QuoteThesisTitle);
//检查外键字段长度
 objvThesisEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetThesisId()
{
//获取某学院所有专业信息
string strSQL = "select ThesisId, OperationTypeName from vThesis ";
 clsSpecSQLforSql mySql = clsvThesisDA.GetSpecSQLObj();
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvThesisEN._CurrTabName);
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvThesisEN._CurrTabName, strCondition);
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
 objSQL = clsvThesisDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
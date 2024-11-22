
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDecompressionFileDA
 表名:DecompressionFile(01120522)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站(AddiSite)
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
 /// 解压缩文件(DecompressionFile)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDecompressionFileDA : clsCommBase4DA
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
 return clsDecompressionFileEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDecompressionFileEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDecompressionFileEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDecompressionFileEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDecompressionFileEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DecompressionFile(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable_DecompressionFile)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DecompressionFile.* from DecompressionFile Left Join {1} on {2} where {3} and DecompressionFile.IdDecompressionFile not in (Select top {5} DecompressionFile.IdDecompressionFile from DecompressionFile Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1} and IdDecompressionFile not in (Select top {2} IdDecompressionFile from DecompressionFile where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1} and IdDecompressionFile not in (Select top {3} IdDecompressionFile from DecompressionFile where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDecompressionFileDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DecompressionFile.* from DecompressionFile Left Join {1} on {2} where {3} and DecompressionFile.IdDecompressionFile not in (Select top {5} DecompressionFile.IdDecompressionFile from DecompressionFile Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1} and IdDecompressionFile not in (Select top {2} IdDecompressionFile from DecompressionFile where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DecompressionFile where {1} and IdDecompressionFile not in (Select top {3} IdDecompressionFile from DecompressionFile where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDecompressionFileEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDecompressionFileDA:GetObjLst)", objException.Message));
}
List<clsDecompressionFileEN> arrObjLst = new List<clsDecompressionFileEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDecompressionFileEN objDecompressionFileEN = new clsDecompressionFileEN();
try
{
objDecompressionFileEN.IdDecompressionFile = TransNullToInt(objRow[conDecompressionFile.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objDecompressionFileEN.UploadFileDir = objRow[conDecompressionFile.UploadFileDir] == DBNull.Value ? null : objRow[conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径
objDecompressionFileEN.UploadPerson = objRow[conDecompressionFile.UploadPerson] == DBNull.Value ? null : objRow[conDecompressionFile.UploadPerson].ToString().Trim(); //上传人
objDecompressionFileEN.NewName = objRow[conDecompressionFile.NewName] == DBNull.Value ? null : objRow[conDecompressionFile.NewName].ToString().Trim(); //新名称
objDecompressionFileEN.NewPath = objRow[conDecompressionFile.NewPath] == DBNull.Value ? null : objRow[conDecompressionFile.NewPath].ToString().Trim(); //新路径
objDecompressionFileEN.UploadDate = TransNullToDate(objRow[conDecompressionFile.UploadDate].ToString().Trim()); //上传时间
objDecompressionFileEN.DecompressionFilePath = objRow[conDecompressionFile.DecompressionFilePath] == DBNull.Value ? null : objRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径
objDecompressionFileEN.FileName = objRow[conDecompressionFile.FileName] == DBNull.Value ? null : objRow[conDecompressionFile.FileName].ToString().Trim(); //文件名称
objDecompressionFileEN.FilePath = objRow[conDecompressionFile.FilePath] == DBNull.Value ? null : objRow[conDecompressionFile.FilePath].ToString().Trim(); //文件路径
objDecompressionFileEN.FileSize = objRow[conDecompressionFile.FileSize] == DBNull.Value ? null : objRow[conDecompressionFile.FileSize].ToString().Trim(); //文件大小
objDecompressionFileEN.FileSizeUnit = objRow[conDecompressionFile.FileSizeUnit] == DBNull.Value ? null : objRow[conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objDecompressionFileEN.IsRar = TransNullToBool(objRow[conDecompressionFile.IsRar].ToString().Trim()); //是否解压缩
objDecompressionFileEN.UserId = objRow[conDecompressionFile.UserId].ToString().Trim(); //用户ID
objDecompressionFileEN.HomePage = objRow[conDecompressionFile.HomePage] == DBNull.Value ? null : objRow[conDecompressionFile.HomePage].ToString().Trim(); //HomePage
objDecompressionFileEN.HomePageDir = objRow[conDecompressionFile.HomePageDir] == DBNull.Value ? null : objRow[conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录
objDecompressionFileEN.Memo = objRow[conDecompressionFile.Memo] == DBNull.Value ? null : objRow[conDecompressionFile.Memo].ToString().Trim(); //备注
objDecompressionFileEN.Memo1 = objRow[conDecompressionFile.Memo1] == DBNull.Value ? null : objRow[conDecompressionFile.Memo1].ToString().Trim(); //Memo1
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDecompressionFileDA: GetObjLst)", objException.Message));
}
objDecompressionFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDecompressionFileEN);
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
public List<clsDecompressionFileEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDecompressionFileDA:GetObjLstByTabName)", objException.Message));
}
List<clsDecompressionFileEN> arrObjLst = new List<clsDecompressionFileEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDecompressionFileEN objDecompressionFileEN = new clsDecompressionFileEN();
try
{
objDecompressionFileEN.IdDecompressionFile = TransNullToInt(objRow[conDecompressionFile.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objDecompressionFileEN.UploadFileDir = objRow[conDecompressionFile.UploadFileDir] == DBNull.Value ? null : objRow[conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径
objDecompressionFileEN.UploadPerson = objRow[conDecompressionFile.UploadPerson] == DBNull.Value ? null : objRow[conDecompressionFile.UploadPerson].ToString().Trim(); //上传人
objDecompressionFileEN.NewName = objRow[conDecompressionFile.NewName] == DBNull.Value ? null : objRow[conDecompressionFile.NewName].ToString().Trim(); //新名称
objDecompressionFileEN.NewPath = objRow[conDecompressionFile.NewPath] == DBNull.Value ? null : objRow[conDecompressionFile.NewPath].ToString().Trim(); //新路径
objDecompressionFileEN.UploadDate = TransNullToDate(objRow[conDecompressionFile.UploadDate].ToString().Trim()); //上传时间
objDecompressionFileEN.DecompressionFilePath = objRow[conDecompressionFile.DecompressionFilePath] == DBNull.Value ? null : objRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径
objDecompressionFileEN.FileName = objRow[conDecompressionFile.FileName] == DBNull.Value ? null : objRow[conDecompressionFile.FileName].ToString().Trim(); //文件名称
objDecompressionFileEN.FilePath = objRow[conDecompressionFile.FilePath] == DBNull.Value ? null : objRow[conDecompressionFile.FilePath].ToString().Trim(); //文件路径
objDecompressionFileEN.FileSize = objRow[conDecompressionFile.FileSize] == DBNull.Value ? null : objRow[conDecompressionFile.FileSize].ToString().Trim(); //文件大小
objDecompressionFileEN.FileSizeUnit = objRow[conDecompressionFile.FileSizeUnit] == DBNull.Value ? null : objRow[conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objDecompressionFileEN.IsRar = TransNullToBool(objRow[conDecompressionFile.IsRar].ToString().Trim()); //是否解压缩
objDecompressionFileEN.UserId = objRow[conDecompressionFile.UserId].ToString().Trim(); //用户ID
objDecompressionFileEN.HomePage = objRow[conDecompressionFile.HomePage] == DBNull.Value ? null : objRow[conDecompressionFile.HomePage].ToString().Trim(); //HomePage
objDecompressionFileEN.HomePageDir = objRow[conDecompressionFile.HomePageDir] == DBNull.Value ? null : objRow[conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录
objDecompressionFileEN.Memo = objRow[conDecompressionFile.Memo] == DBNull.Value ? null : objRow[conDecompressionFile.Memo].ToString().Trim(); //备注
objDecompressionFileEN.Memo1 = objRow[conDecompressionFile.Memo1] == DBNull.Value ? null : objRow[conDecompressionFile.Memo1].ToString().Trim(); //Memo1
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDecompressionFileDA: GetObjLst)", objException.Message));
}
objDecompressionFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDecompressionFileEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDecompressionFile(ref clsDecompressionFileEN objDecompressionFileEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where IdDecompressionFile = " + ""+ objDecompressionFileEN.IdDecompressionFile+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDecompressionFileEN.IdDecompressionFile = TransNullToInt(objDT.Rows[0][conDecompressionFile.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objDecompressionFileEN.UploadFileDir = objDT.Rows[0][conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.UploadPerson = objDT.Rows[0][conDecompressionFile.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objDecompressionFileEN.NewName = objDT.Rows[0][conDecompressionFile.NewName].ToString().Trim(); //新名称(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.NewPath = objDT.Rows[0][conDecompressionFile.NewPath].ToString().Trim(); //新路径(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.UploadDate = TransNullToDate(objDT.Rows[0][conDecompressionFile.UploadDate].ToString().Trim()); //上传时间(字段类型:datetime,字段长度:16,是否可空:False)
 objDecompressionFileEN.DecompressionFilePath = objDT.Rows[0][conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objDecompressionFileEN.FileName = objDT.Rows[0][conDecompressionFile.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objDecompressionFileEN.FilePath = objDT.Rows[0][conDecompressionFile.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objDecompressionFileEN.FileSize = objDT.Rows[0][conDecompressionFile.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objDecompressionFileEN.FileSizeUnit = objDT.Rows[0][conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objDecompressionFileEN.IsRar = TransNullToBool(objDT.Rows[0][conDecompressionFile.IsRar].ToString().Trim()); //是否解压缩(字段类型:bit,字段长度:1,是否可空:True)
 objDecompressionFileEN.UserId = objDT.Rows[0][conDecompressionFile.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objDecompressionFileEN.HomePage = objDT.Rows[0][conDecompressionFile.HomePage].ToString().Trim(); //HomePage(字段类型:varchar,字段长度:100,是否可空:True)
 objDecompressionFileEN.HomePageDir = objDT.Rows[0][conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录(字段类型:varchar,字段长度:200,是否可空:True)
 objDecompressionFileEN.Memo = objDT.Rows[0][conDecompressionFile.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.Memo1 = objDT.Rows[0][conDecompressionFile.Memo1].ToString().Trim(); //Memo1(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDecompressionFileDA: GetDecompressionFile)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdDecompressionFile">表关键字</param>
 /// <returns>表对象</returns>
public clsDecompressionFileEN GetObjByIdDecompressionFile(long lngIdDecompressionFile)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where IdDecompressionFile = " + ""+ lngIdDecompressionFile+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDecompressionFileEN objDecompressionFileEN = new clsDecompressionFileEN();
try
{
 objDecompressionFileEN.IdDecompressionFile = Int32.Parse(objRow[conDecompressionFile.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objDecompressionFileEN.UploadFileDir = objRow[conDecompressionFile.UploadFileDir] == DBNull.Value ? null : objRow[conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.UploadPerson = objRow[conDecompressionFile.UploadPerson] == DBNull.Value ? null : objRow[conDecompressionFile.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objDecompressionFileEN.NewName = objRow[conDecompressionFile.NewName] == DBNull.Value ? null : objRow[conDecompressionFile.NewName].ToString().Trim(); //新名称(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.NewPath = objRow[conDecompressionFile.NewPath] == DBNull.Value ? null : objRow[conDecompressionFile.NewPath].ToString().Trim(); //新路径(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.UploadDate = clsEntityBase2.TransNullToDate_S(objRow[conDecompressionFile.UploadDate].ToString().Trim()); //上传时间(字段类型:datetime,字段长度:16,是否可空:False)
 objDecompressionFileEN.DecompressionFilePath = objRow[conDecompressionFile.DecompressionFilePath] == DBNull.Value ? null : objRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objDecompressionFileEN.FileName = objRow[conDecompressionFile.FileName] == DBNull.Value ? null : objRow[conDecompressionFile.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objDecompressionFileEN.FilePath = objRow[conDecompressionFile.FilePath] == DBNull.Value ? null : objRow[conDecompressionFile.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objDecompressionFileEN.FileSize = objRow[conDecompressionFile.FileSize] == DBNull.Value ? null : objRow[conDecompressionFile.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objDecompressionFileEN.FileSizeUnit = objRow[conDecompressionFile.FileSizeUnit] == DBNull.Value ? null : objRow[conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objDecompressionFileEN.IsRar = clsEntityBase2.TransNullToBool_S(objRow[conDecompressionFile.IsRar].ToString().Trim()); //是否解压缩(字段类型:bit,字段长度:1,是否可空:True)
 objDecompressionFileEN.UserId = objRow[conDecompressionFile.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objDecompressionFileEN.HomePage = objRow[conDecompressionFile.HomePage] == DBNull.Value ? null : objRow[conDecompressionFile.HomePage].ToString().Trim(); //HomePage(字段类型:varchar,字段长度:100,是否可空:True)
 objDecompressionFileEN.HomePageDir = objRow[conDecompressionFile.HomePageDir] == DBNull.Value ? null : objRow[conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录(字段类型:varchar,字段长度:200,是否可空:True)
 objDecompressionFileEN.Memo = objRow[conDecompressionFile.Memo] == DBNull.Value ? null : objRow[conDecompressionFile.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objDecompressionFileEN.Memo1 = objRow[conDecompressionFile.Memo1] == DBNull.Value ? null : objRow[conDecompressionFile.Memo1].ToString().Trim(); //Memo1(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDecompressionFileDA: GetObjByIdDecompressionFile)", objException.Message));
}
return objDecompressionFileEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDecompressionFileEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDecompressionFileDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDecompressionFileEN objDecompressionFileEN = new clsDecompressionFileEN()
{
IdDecompressionFile = TransNullToInt(objRow[conDecompressionFile.IdDecompressionFile].ToString().Trim()), //解压缩文件流水号
UploadFileDir = objRow[conDecompressionFile.UploadFileDir] == DBNull.Value ? null : objRow[conDecompressionFile.UploadFileDir].ToString().Trim(), //上传文件的路径
UploadPerson = objRow[conDecompressionFile.UploadPerson] == DBNull.Value ? null : objRow[conDecompressionFile.UploadPerson].ToString().Trim(), //上传人
NewName = objRow[conDecompressionFile.NewName] == DBNull.Value ? null : objRow[conDecompressionFile.NewName].ToString().Trim(), //新名称
NewPath = objRow[conDecompressionFile.NewPath] == DBNull.Value ? null : objRow[conDecompressionFile.NewPath].ToString().Trim(), //新路径
UploadDate = TransNullToDate(objRow[conDecompressionFile.UploadDate].ToString().Trim()), //上传时间
DecompressionFilePath = objRow[conDecompressionFile.DecompressionFilePath] == DBNull.Value ? null : objRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(), //解压缩文件路径
FileName = objRow[conDecompressionFile.FileName] == DBNull.Value ? null : objRow[conDecompressionFile.FileName].ToString().Trim(), //文件名称
FilePath = objRow[conDecompressionFile.FilePath] == DBNull.Value ? null : objRow[conDecompressionFile.FilePath].ToString().Trim(), //文件路径
FileSize = objRow[conDecompressionFile.FileSize] == DBNull.Value ? null : objRow[conDecompressionFile.FileSize].ToString().Trim(), //文件大小
FileSizeUnit = objRow[conDecompressionFile.FileSizeUnit] == DBNull.Value ? null : objRow[conDecompressionFile.FileSizeUnit].ToString().Trim(), //文件大小单位
IsRar = TransNullToBool(objRow[conDecompressionFile.IsRar].ToString().Trim()), //是否解压缩
UserId = objRow[conDecompressionFile.UserId].ToString().Trim(), //用户ID
HomePage = objRow[conDecompressionFile.HomePage] == DBNull.Value ? null : objRow[conDecompressionFile.HomePage].ToString().Trim(), //HomePage
HomePageDir = objRow[conDecompressionFile.HomePageDir] == DBNull.Value ? null : objRow[conDecompressionFile.HomePageDir].ToString().Trim(), //首页文件目录
Memo = objRow[conDecompressionFile.Memo] == DBNull.Value ? null : objRow[conDecompressionFile.Memo].ToString().Trim(), //备注
Memo1 = objRow[conDecompressionFile.Memo1] == DBNull.Value ? null : objRow[conDecompressionFile.Memo1].ToString().Trim() //Memo1
};
objDecompressionFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDecompressionFileEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDecompressionFileDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDecompressionFileEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDecompressionFileEN objDecompressionFileEN = new clsDecompressionFileEN();
try
{
objDecompressionFileEN.IdDecompressionFile = TransNullToInt(objRow[conDecompressionFile.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objDecompressionFileEN.UploadFileDir = objRow[conDecompressionFile.UploadFileDir] == DBNull.Value ? null : objRow[conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径
objDecompressionFileEN.UploadPerson = objRow[conDecompressionFile.UploadPerson] == DBNull.Value ? null : objRow[conDecompressionFile.UploadPerson].ToString().Trim(); //上传人
objDecompressionFileEN.NewName = objRow[conDecompressionFile.NewName] == DBNull.Value ? null : objRow[conDecompressionFile.NewName].ToString().Trim(); //新名称
objDecompressionFileEN.NewPath = objRow[conDecompressionFile.NewPath] == DBNull.Value ? null : objRow[conDecompressionFile.NewPath].ToString().Trim(); //新路径
objDecompressionFileEN.UploadDate = TransNullToDate(objRow[conDecompressionFile.UploadDate].ToString().Trim()); //上传时间
objDecompressionFileEN.DecompressionFilePath = objRow[conDecompressionFile.DecompressionFilePath] == DBNull.Value ? null : objRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径
objDecompressionFileEN.FileName = objRow[conDecompressionFile.FileName] == DBNull.Value ? null : objRow[conDecompressionFile.FileName].ToString().Trim(); //文件名称
objDecompressionFileEN.FilePath = objRow[conDecompressionFile.FilePath] == DBNull.Value ? null : objRow[conDecompressionFile.FilePath].ToString().Trim(); //文件路径
objDecompressionFileEN.FileSize = objRow[conDecompressionFile.FileSize] == DBNull.Value ? null : objRow[conDecompressionFile.FileSize].ToString().Trim(); //文件大小
objDecompressionFileEN.FileSizeUnit = objRow[conDecompressionFile.FileSizeUnit] == DBNull.Value ? null : objRow[conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objDecompressionFileEN.IsRar = TransNullToBool(objRow[conDecompressionFile.IsRar].ToString().Trim()); //是否解压缩
objDecompressionFileEN.UserId = objRow[conDecompressionFile.UserId].ToString().Trim(); //用户ID
objDecompressionFileEN.HomePage = objRow[conDecompressionFile.HomePage] == DBNull.Value ? null : objRow[conDecompressionFile.HomePage].ToString().Trim(); //HomePage
objDecompressionFileEN.HomePageDir = objRow[conDecompressionFile.HomePageDir] == DBNull.Value ? null : objRow[conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录
objDecompressionFileEN.Memo = objRow[conDecompressionFile.Memo] == DBNull.Value ? null : objRow[conDecompressionFile.Memo].ToString().Trim(); //备注
objDecompressionFileEN.Memo1 = objRow[conDecompressionFile.Memo1] == DBNull.Value ? null : objRow[conDecompressionFile.Memo1].ToString().Trim(); //Memo1
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDecompressionFileDA: GetObjByDataRowDecompressionFile)", objException.Message));
}
objDecompressionFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDecompressionFileEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDecompressionFileEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDecompressionFileEN objDecompressionFileEN = new clsDecompressionFileEN();
try
{
objDecompressionFileEN.IdDecompressionFile = TransNullToInt(objRow[conDecompressionFile.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objDecompressionFileEN.UploadFileDir = objRow[conDecompressionFile.UploadFileDir] == DBNull.Value ? null : objRow[conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径
objDecompressionFileEN.UploadPerson = objRow[conDecompressionFile.UploadPerson] == DBNull.Value ? null : objRow[conDecompressionFile.UploadPerson].ToString().Trim(); //上传人
objDecompressionFileEN.NewName = objRow[conDecompressionFile.NewName] == DBNull.Value ? null : objRow[conDecompressionFile.NewName].ToString().Trim(); //新名称
objDecompressionFileEN.NewPath = objRow[conDecompressionFile.NewPath] == DBNull.Value ? null : objRow[conDecompressionFile.NewPath].ToString().Trim(); //新路径
objDecompressionFileEN.UploadDate = TransNullToDate(objRow[conDecompressionFile.UploadDate].ToString().Trim()); //上传时间
objDecompressionFileEN.DecompressionFilePath = objRow[conDecompressionFile.DecompressionFilePath] == DBNull.Value ? null : objRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径
objDecompressionFileEN.FileName = objRow[conDecompressionFile.FileName] == DBNull.Value ? null : objRow[conDecompressionFile.FileName].ToString().Trim(); //文件名称
objDecompressionFileEN.FilePath = objRow[conDecompressionFile.FilePath] == DBNull.Value ? null : objRow[conDecompressionFile.FilePath].ToString().Trim(); //文件路径
objDecompressionFileEN.FileSize = objRow[conDecompressionFile.FileSize] == DBNull.Value ? null : objRow[conDecompressionFile.FileSize].ToString().Trim(); //文件大小
objDecompressionFileEN.FileSizeUnit = objRow[conDecompressionFile.FileSizeUnit] == DBNull.Value ? null : objRow[conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objDecompressionFileEN.IsRar = TransNullToBool(objRow[conDecompressionFile.IsRar].ToString().Trim()); //是否解压缩
objDecompressionFileEN.UserId = objRow[conDecompressionFile.UserId].ToString().Trim(); //用户ID
objDecompressionFileEN.HomePage = objRow[conDecompressionFile.HomePage] == DBNull.Value ? null : objRow[conDecompressionFile.HomePage].ToString().Trim(); //HomePage
objDecompressionFileEN.HomePageDir = objRow[conDecompressionFile.HomePageDir] == DBNull.Value ? null : objRow[conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录
objDecompressionFileEN.Memo = objRow[conDecompressionFile.Memo] == DBNull.Value ? null : objRow[conDecompressionFile.Memo].ToString().Trim(); //备注
objDecompressionFileEN.Memo1 = objRow[conDecompressionFile.Memo1] == DBNull.Value ? null : objRow[conDecompressionFile.Memo1].ToString().Trim(); //Memo1
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDecompressionFileDA: GetObjByDataRow)", objException.Message));
}
objDecompressionFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDecompressionFileEN;
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
objSQL = clsDecompressionFileDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDecompressionFileEN._CurrTabName, conDecompressionFile.IdDecompressionFile, 8, "");
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
objSQL = clsDecompressionFileDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDecompressionFileEN._CurrTabName, conDecompressionFile.IdDecompressionFile, 8, strPrefix);
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdDecompressionFile from DecompressionFile where " + strCondition;
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdDecompressionFile from DecompressionFile where " + strCondition;
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
 /// <param name = "lngIdDecompressionFile">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdDecompressionFile)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DecompressionFile", "IdDecompressionFile = " + ""+ lngIdDecompressionFile+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDecompressionFileDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DecompressionFile", strCondition))
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
objSQL = clsDecompressionFileDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DecompressionFile");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDecompressionFileEN objDecompressionFileEN)
 {
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDecompressionFileEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DecompressionFile");
objRow = objDS.Tables["DecompressionFile"].NewRow();
 if (objDecompressionFileEN.UploadFileDir !=  "")
 {
objRow[conDecompressionFile.UploadFileDir] = objDecompressionFileEN.UploadFileDir; //上传文件的路径
 }
 if (objDecompressionFileEN.UploadPerson !=  "")
 {
objRow[conDecompressionFile.UploadPerson] = objDecompressionFileEN.UploadPerson; //上传人
 }
 if (objDecompressionFileEN.NewName !=  "")
 {
objRow[conDecompressionFile.NewName] = objDecompressionFileEN.NewName; //新名称
 }
 if (objDecompressionFileEN.NewPath !=  "")
 {
objRow[conDecompressionFile.NewPath] = objDecompressionFileEN.NewPath; //新路径
 }
objRow[conDecompressionFile.UploadDate] = objDecompressionFileEN.UploadDate; //上传时间
 if (objDecompressionFileEN.DecompressionFilePath !=  "")
 {
objRow[conDecompressionFile.DecompressionFilePath] = objDecompressionFileEN.DecompressionFilePath; //解压缩文件路径
 }
 if (objDecompressionFileEN.FileName !=  "")
 {
objRow[conDecompressionFile.FileName] = objDecompressionFileEN.FileName; //文件名称
 }
 if (objDecompressionFileEN.FilePath !=  "")
 {
objRow[conDecompressionFile.FilePath] = objDecompressionFileEN.FilePath; //文件路径
 }
 if (objDecompressionFileEN.FileSize !=  "")
 {
objRow[conDecompressionFile.FileSize] = objDecompressionFileEN.FileSize; //文件大小
 }
 if (objDecompressionFileEN.FileSizeUnit !=  "")
 {
objRow[conDecompressionFile.FileSizeUnit] = objDecompressionFileEN.FileSizeUnit; //文件大小单位
 }
objRow[conDecompressionFile.IsRar] = objDecompressionFileEN.IsRar; //是否解压缩
objRow[conDecompressionFile.UserId] = objDecompressionFileEN.UserId; //用户ID
 if (objDecompressionFileEN.HomePage !=  "")
 {
objRow[conDecompressionFile.HomePage] = objDecompressionFileEN.HomePage; //HomePage
 }
 if (objDecompressionFileEN.HomePageDir !=  "")
 {
objRow[conDecompressionFile.HomePageDir] = objDecompressionFileEN.HomePageDir; //首页文件目录
 }
 if (objDecompressionFileEN.Memo !=  "")
 {
objRow[conDecompressionFile.Memo] = objDecompressionFileEN.Memo; //备注
 }
 if (objDecompressionFileEN.Memo1 !=  "")
 {
objRow[conDecompressionFile.Memo1] = objDecompressionFileEN.Memo1; //Memo1
 }
objDS.Tables[clsDecompressionFileEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDecompressionFileEN._CurrTabName);
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
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDecompressionFileEN objDecompressionFileEN)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDecompressionFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadFileDir);
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadFileDir + "'");
 }
 
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadPerson);
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objDecompressionFileEN.NewName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewName);
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewName + "'");
 }
 
 if (objDecompressionFileEN.NewPath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewPath);
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewPath + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.UploadDate);
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 arrValueListForInsert.Add("'" + dteUploadDate + "'");
 
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.DecompressionFilePath);
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDecompressionFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileName);
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objDecompressionFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FilePath);
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSize);
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSizeUnit);
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.IsRar);
 arrValueListForInsert.Add("'" + (objDecompressionFileEN.IsRar  ==  false ? "0" : "1") + "'");
 
 if (objDecompressionFileEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UserId);
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objDecompressionFileEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePage);
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePageDir);
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePageDir + "'");
 }
 
 if (objDecompressionFileEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo);
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo1);
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo1 + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DecompressionFile");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDecompressionFileEN objDecompressionFileEN)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDecompressionFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadFileDir);
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadFileDir + "'");
 }
 
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadPerson);
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objDecompressionFileEN.NewName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewName);
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewName + "'");
 }
 
 if (objDecompressionFileEN.NewPath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewPath);
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewPath + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.UploadDate);
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 arrValueListForInsert.Add("'" + dteUploadDate + "'");
 
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.DecompressionFilePath);
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDecompressionFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileName);
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objDecompressionFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FilePath);
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSize);
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSizeUnit);
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.IsRar);
 arrValueListForInsert.Add("'" + (objDecompressionFileEN.IsRar  ==  false ? "0" : "1") + "'");
 
 if (objDecompressionFileEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UserId);
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objDecompressionFileEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePage);
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePageDir);
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePageDir + "'");
 }
 
 if (objDecompressionFileEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo);
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo1);
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo1 + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DecompressionFile");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDecompressionFileEN objDecompressionFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDecompressionFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadFileDir);
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadFileDir + "'");
 }
 
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadPerson);
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objDecompressionFileEN.NewName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewName);
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewName + "'");
 }
 
 if (objDecompressionFileEN.NewPath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewPath);
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewPath + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.UploadDate);
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 arrValueListForInsert.Add("'" + dteUploadDate + "'");
 
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.DecompressionFilePath);
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDecompressionFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileName);
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objDecompressionFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FilePath);
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSize);
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSizeUnit);
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.IsRar);
 arrValueListForInsert.Add("'" + (objDecompressionFileEN.IsRar  ==  false ? "0" : "1") + "'");
 
 if (objDecompressionFileEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UserId);
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objDecompressionFileEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePage);
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePageDir);
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePageDir + "'");
 }
 
 if (objDecompressionFileEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo);
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo1);
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo1 + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DecompressionFile");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDecompressionFileEN objDecompressionFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDecompressionFileEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadFileDir);
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadFileDir + "'");
 }
 
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UploadPerson);
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objDecompressionFileEN.NewName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewName);
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewName + "'");
 }
 
 if (objDecompressionFileEN.NewPath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.NewPath);
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNewPath + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.UploadDate);
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 arrValueListForInsert.Add("'" + dteUploadDate + "'");
 
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.DecompressionFilePath);
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDecompressionFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileName);
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objDecompressionFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FilePath);
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objDecompressionFileEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSize);
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.FileSizeUnit);
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 arrFieldListForInsert.Add(conDecompressionFile.IsRar);
 arrValueListForInsert.Add("'" + (objDecompressionFileEN.IsRar  ==  false ? "0" : "1") + "'");
 
 if (objDecompressionFileEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.UserId);
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objDecompressionFileEN.HomePage !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePage);
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePage + "'");
 }
 
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.HomePageDir);
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePageDir + "'");
 }
 
 if (objDecompressionFileEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo);
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 arrFieldListForInsert.Add(conDecompressionFile.Memo1);
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo1 + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DecompressionFile");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDecompressionFiles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where IdDecompressionFile = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DecompressionFile");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdDecompressionFile = TransNullToInt(oRow[conDecompressionFile.IdDecompressionFile].ToString().Trim());
if (IsExist(lngIdDecompressionFile))
{
 string strResult = "关键字变量值为:" + string.Format("IdDecompressionFile = {0}", lngIdDecompressionFile) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDecompressionFileEN._CurrTabName ].NewRow();
objRow[conDecompressionFile.UploadFileDir] = oRow[conDecompressionFile.UploadFileDir].ToString().Trim(); //上传文件的路径
objRow[conDecompressionFile.UploadPerson] = oRow[conDecompressionFile.UploadPerson].ToString().Trim(); //上传人
objRow[conDecompressionFile.NewName] = oRow[conDecompressionFile.NewName].ToString().Trim(); //新名称
objRow[conDecompressionFile.NewPath] = oRow[conDecompressionFile.NewPath].ToString().Trim(); //新路径
objRow[conDecompressionFile.UploadDate] = oRow[conDecompressionFile.UploadDate].ToString().Trim(); //上传时间
objRow[conDecompressionFile.DecompressionFilePath] = oRow[conDecompressionFile.DecompressionFilePath].ToString().Trim(); //解压缩文件路径
objRow[conDecompressionFile.FileName] = oRow[conDecompressionFile.FileName].ToString().Trim(); //文件名称
objRow[conDecompressionFile.FilePath] = oRow[conDecompressionFile.FilePath].ToString().Trim(); //文件路径
objRow[conDecompressionFile.FileSize] = oRow[conDecompressionFile.FileSize].ToString().Trim(); //文件大小
objRow[conDecompressionFile.FileSizeUnit] = oRow[conDecompressionFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objRow[conDecompressionFile.IsRar] = oRow[conDecompressionFile.IsRar].ToString().Trim(); //是否解压缩
objRow[conDecompressionFile.UserId] = oRow[conDecompressionFile.UserId].ToString().Trim(); //用户ID
objRow[conDecompressionFile.HomePage] = oRow[conDecompressionFile.HomePage].ToString().Trim(); //HomePage
objRow[conDecompressionFile.HomePageDir] = oRow[conDecompressionFile.HomePageDir].ToString().Trim(); //首页文件目录
objRow[conDecompressionFile.Memo] = oRow[conDecompressionFile.Memo].ToString().Trim(); //备注
objRow[conDecompressionFile.Memo1] = oRow[conDecompressionFile.Memo1].ToString().Trim(); //Memo1
 objDS.Tables[clsDecompressionFileEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDecompressionFileEN._CurrTabName);
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
 /// <param name = "objDecompressionFileEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDecompressionFileEN objDecompressionFileEN)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDecompressionFileEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
strSQL = "Select * from DecompressionFile where IdDecompressionFile = " + ""+ objDecompressionFileEN.IdDecompressionFile+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDecompressionFileEN._CurrTabName);
if (objDS.Tables[clsDecompressionFileEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdDecompressionFile = " + ""+ objDecompressionFileEN.IdDecompressionFile+"");
return false;
}
objRow = objDS.Tables[clsDecompressionFileEN._CurrTabName].Rows[0];
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadFileDir))
 {
objRow[conDecompressionFile.UploadFileDir] = objDecompressionFileEN.UploadFileDir; //上传文件的路径
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadPerson))
 {
objRow[conDecompressionFile.UploadPerson] = objDecompressionFileEN.UploadPerson; //上传人
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewName))
 {
objRow[conDecompressionFile.NewName] = objDecompressionFileEN.NewName; //新名称
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewPath))
 {
objRow[conDecompressionFile.NewPath] = objDecompressionFileEN.NewPath; //新路径
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadDate))
 {
objRow[conDecompressionFile.UploadDate] = objDecompressionFileEN.UploadDate; //上传时间
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.DecompressionFilePath))
 {
objRow[conDecompressionFile.DecompressionFilePath] = objDecompressionFileEN.DecompressionFilePath; //解压缩文件路径
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileName))
 {
objRow[conDecompressionFile.FileName] = objDecompressionFileEN.FileName; //文件名称
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FilePath))
 {
objRow[conDecompressionFile.FilePath] = objDecompressionFileEN.FilePath; //文件路径
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSize))
 {
objRow[conDecompressionFile.FileSize] = objDecompressionFileEN.FileSize; //文件大小
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSizeUnit))
 {
objRow[conDecompressionFile.FileSizeUnit] = objDecompressionFileEN.FileSizeUnit; //文件大小单位
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.IsRar))
 {
objRow[conDecompressionFile.IsRar] = objDecompressionFileEN.IsRar; //是否解压缩
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UserId))
 {
objRow[conDecompressionFile.UserId] = objDecompressionFileEN.UserId; //用户ID
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePage))
 {
objRow[conDecompressionFile.HomePage] = objDecompressionFileEN.HomePage; //HomePage
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePageDir))
 {
objRow[conDecompressionFile.HomePageDir] = objDecompressionFileEN.HomePageDir; //首页文件目录
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo))
 {
objRow[conDecompressionFile.Memo] = objDecompressionFileEN.Memo; //备注
 }
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo1))
 {
objRow[conDecompressionFile.Memo1] = objDecompressionFileEN.Memo1; //Memo1
 }
try
{
objDA.Update(objDS, clsDecompressionFileEN._CurrTabName);
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
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDecompressionFileEN objDecompressionFileEN)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDecompressionFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DecompressionFile Set ");
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadFileDir))
 {
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadFileDir, conDecompressionFile.UploadFileDir); //上传文件的路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UploadFileDir); //上传文件的路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadPerson))
 {
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadPerson, conDecompressionFile.UploadPerson); //上传人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UploadPerson); //上传人
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewName))
 {
 if (objDecompressionFileEN.NewName !=  null)
 {
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNewName, conDecompressionFile.NewName); //新名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.NewName); //新名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewPath))
 {
 if (objDecompressionFileEN.NewPath !=  null)
 {
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNewPath, conDecompressionFile.NewPath); //新路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.NewPath); //新路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadDate))
 {
 if (objDecompressionFileEN.UploadDate !=  null)
 {
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 sbSQL.AppendFormat("{1} = '{0}',", dteUploadDate, conDecompressionFile.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UploadDate); //上传时间
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.DecompressionFilePath))
 {
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDecompressionFilePath, conDecompressionFile.DecompressionFilePath); //解压缩文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.DecompressionFilePath); //解压缩文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileName))
 {
 if (objDecompressionFileEN.FileName !=  null)
 {
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conDecompressionFile.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FileName); //文件名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FilePath))
 {
 if (objDecompressionFileEN.FilePath !=  null)
 {
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conDecompressionFile.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FilePath); //文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSize))
 {
 if (objDecompressionFileEN.FileSize !=  null)
 {
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSize, conDecompressionFile.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FileSize); //文件大小
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSizeUnit))
 {
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, conDecompressionFile.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.IsRar))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDecompressionFileEN.IsRar == true?"1":"0", conDecompressionFile.IsRar); //是否解压缩
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UserId))
 {
 if (objDecompressionFileEN.UserId !=  null)
 {
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conDecompressionFile.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UserId); //用户ID
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePage))
 {
 if (objDecompressionFileEN.HomePage !=  null)
 {
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePage, conDecompressionFile.HomePage); //HomePage
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.HomePage); //HomePage
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePageDir))
 {
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePageDir, conDecompressionFile.HomePageDir); //首页文件目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.HomePageDir); //首页文件目录
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo))
 {
 if (objDecompressionFileEN.Memo !=  null)
 {
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDecompressionFile.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.Memo); //备注
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo1))
 {
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo1, conDecompressionFile.Memo1); //Memo1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.Memo1); //Memo1
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdDecompressionFile = {0}", objDecompressionFileEN.IdDecompressionFile); 
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
 /// <param name = "objDecompressionFileEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDecompressionFileEN objDecompressionFileEN, string strCondition)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDecompressionFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DecompressionFile Set ");
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadFileDir))
 {
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadFileDir = '{0}',", strUploadFileDir); //上传文件的路径
 }
 else
 {
 sbSQL.Append(" UploadFileDir = null,"); //上传文件的路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadPerson))
 {
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadPerson = '{0}',", strUploadPerson); //上传人
 }
 else
 {
 sbSQL.Append(" UploadPerson = null,"); //上传人
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewName))
 {
 if (objDecompressionFileEN.NewName !=  null)
 {
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewName = '{0}',", strNewName); //新名称
 }
 else
 {
 sbSQL.Append(" NewName = null,"); //新名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewPath))
 {
 if (objDecompressionFileEN.NewPath !=  null)
 {
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewPath = '{0}',", strNewPath); //新路径
 }
 else
 {
 sbSQL.Append(" NewPath = null,"); //新路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadDate))
 {
 if (objDecompressionFileEN.UploadDate !=  null)
 {
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 sbSQL.AppendFormat(" UploadDate = '{0}',", dteUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.DecompressionFilePath))
 {
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DecompressionFilePath = '{0}',", strDecompressionFilePath); //解压缩文件路径
 }
 else
 {
 sbSQL.Append(" DecompressionFilePath = null,"); //解压缩文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileName))
 {
 if (objDecompressionFileEN.FileName !=  null)
 {
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FilePath))
 {
 if (objDecompressionFileEN.FilePath !=  null)
 {
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSize))
 {
 if (objDecompressionFileEN.FileSize !=  null)
 {
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSize = '{0}',", strFileSize); //文件大小
 }
 else
 {
 sbSQL.Append(" FileSize = null,"); //文件大小
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSizeUnit))
 {
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.IsRar))
 {
 sbSQL.AppendFormat(" IsRar = '{0}',", objDecompressionFileEN.IsRar == true?"1":"0"); //是否解压缩
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UserId))
 {
 if (objDecompressionFileEN.UserId !=  null)
 {
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePage))
 {
 if (objDecompressionFileEN.HomePage !=  null)
 {
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePage = '{0}',", strHomePage); //HomePage
 }
 else
 {
 sbSQL.Append(" HomePage = null,"); //HomePage
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePageDir))
 {
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePageDir = '{0}',", strHomePageDir); //首页文件目录
 }
 else
 {
 sbSQL.Append(" HomePageDir = null,"); //首页文件目录
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo))
 {
 if (objDecompressionFileEN.Memo !=  null)
 {
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo1))
 {
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo1 = '{0}',", strMemo1); //Memo1
 }
 else
 {
 sbSQL.Append(" Memo1 = null,"); //Memo1
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
 /// <param name = "objDecompressionFileEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDecompressionFileEN objDecompressionFileEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDecompressionFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DecompressionFile Set ");
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadFileDir))
 {
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadFileDir = '{0}',", strUploadFileDir); //上传文件的路径
 }
 else
 {
 sbSQL.Append(" UploadFileDir = null,"); //上传文件的路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadPerson))
 {
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadPerson = '{0}',", strUploadPerson); //上传人
 }
 else
 {
 sbSQL.Append(" UploadPerson = null,"); //上传人
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewName))
 {
 if (objDecompressionFileEN.NewName !=  null)
 {
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewName = '{0}',", strNewName); //新名称
 }
 else
 {
 sbSQL.Append(" NewName = null,"); //新名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewPath))
 {
 if (objDecompressionFileEN.NewPath !=  null)
 {
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewPath = '{0}',", strNewPath); //新路径
 }
 else
 {
 sbSQL.Append(" NewPath = null,"); //新路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadDate))
 {
 if (objDecompressionFileEN.UploadDate !=  null)
 {
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 sbSQL.AppendFormat(" UploadDate = '{0}',", dteUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.DecompressionFilePath))
 {
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DecompressionFilePath = '{0}',", strDecompressionFilePath); //解压缩文件路径
 }
 else
 {
 sbSQL.Append(" DecompressionFilePath = null,"); //解压缩文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileName))
 {
 if (objDecompressionFileEN.FileName !=  null)
 {
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FilePath))
 {
 if (objDecompressionFileEN.FilePath !=  null)
 {
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSize))
 {
 if (objDecompressionFileEN.FileSize !=  null)
 {
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSize = '{0}',", strFileSize); //文件大小
 }
 else
 {
 sbSQL.Append(" FileSize = null,"); //文件大小
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSizeUnit))
 {
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.IsRar))
 {
 sbSQL.AppendFormat(" IsRar = '{0}',", objDecompressionFileEN.IsRar == true?"1":"0"); //是否解压缩
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UserId))
 {
 if (objDecompressionFileEN.UserId !=  null)
 {
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePage))
 {
 if (objDecompressionFileEN.HomePage !=  null)
 {
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePage = '{0}',", strHomePage); //HomePage
 }
 else
 {
 sbSQL.Append(" HomePage = null,"); //HomePage
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePageDir))
 {
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePageDir = '{0}',", strHomePageDir); //首页文件目录
 }
 else
 {
 sbSQL.Append(" HomePageDir = null,"); //首页文件目录
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo))
 {
 if (objDecompressionFileEN.Memo !=  null)
 {
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo1))
 {
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo1 = '{0}',", strMemo1); //Memo1
 }
 else
 {
 sbSQL.Append(" Memo1 = null,"); //Memo1
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
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDecompressionFileEN objDecompressionFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDecompressionFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDecompressionFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DecompressionFile Set ");
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadFileDir))
 {
 if (objDecompressionFileEN.UploadFileDir !=  null)
 {
 var strUploadFileDir = objDecompressionFileEN.UploadFileDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadFileDir, conDecompressionFile.UploadFileDir); //上传文件的路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UploadFileDir); //上传文件的路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadPerson))
 {
 if (objDecompressionFileEN.UploadPerson !=  null)
 {
 var strUploadPerson = objDecompressionFileEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadPerson, conDecompressionFile.UploadPerson); //上传人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UploadPerson); //上传人
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewName))
 {
 if (objDecompressionFileEN.NewName !=  null)
 {
 var strNewName = objDecompressionFileEN.NewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNewName, conDecompressionFile.NewName); //新名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.NewName); //新名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.NewPath))
 {
 if (objDecompressionFileEN.NewPath !=  null)
 {
 var strNewPath = objDecompressionFileEN.NewPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNewPath, conDecompressionFile.NewPath); //新路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.NewPath); //新路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UploadDate))
 {
 if (objDecompressionFileEN.UploadDate !=  null)
 {
 var dteUploadDate = objDecompressionFileEN.UploadDate;
 sbSQL.AppendFormat("{1} = '{0}',", dteUploadDate, conDecompressionFile.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UploadDate); //上传时间
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.DecompressionFilePath))
 {
 if (objDecompressionFileEN.DecompressionFilePath !=  null)
 {
 var strDecompressionFilePath = objDecompressionFileEN.DecompressionFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDecompressionFilePath, conDecompressionFile.DecompressionFilePath); //解压缩文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.DecompressionFilePath); //解压缩文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileName))
 {
 if (objDecompressionFileEN.FileName !=  null)
 {
 var strFileName = objDecompressionFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conDecompressionFile.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FileName); //文件名称
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FilePath))
 {
 if (objDecompressionFileEN.FilePath !=  null)
 {
 var strFilePath = objDecompressionFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conDecompressionFile.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FilePath); //文件路径
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSize))
 {
 if (objDecompressionFileEN.FileSize !=  null)
 {
 var strFileSize = objDecompressionFileEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSize, conDecompressionFile.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FileSize); //文件大小
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.FileSizeUnit))
 {
 if (objDecompressionFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objDecompressionFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, conDecompressionFile.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.IsRar))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDecompressionFileEN.IsRar == true?"1":"0", conDecompressionFile.IsRar); //是否解压缩
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.UserId))
 {
 if (objDecompressionFileEN.UserId !=  null)
 {
 var strUserId = objDecompressionFileEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conDecompressionFile.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.UserId); //用户ID
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePage))
 {
 if (objDecompressionFileEN.HomePage !=  null)
 {
 var strHomePage = objDecompressionFileEN.HomePage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePage, conDecompressionFile.HomePage); //HomePage
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.HomePage); //HomePage
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.HomePageDir))
 {
 if (objDecompressionFileEN.HomePageDir !=  null)
 {
 var strHomePageDir = objDecompressionFileEN.HomePageDir.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePageDir, conDecompressionFile.HomePageDir); //首页文件目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.HomePageDir); //首页文件目录
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo))
 {
 if (objDecompressionFileEN.Memo !=  null)
 {
 var strMemo = objDecompressionFileEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDecompressionFile.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.Memo); //备注
 }
 }
 
 if (objDecompressionFileEN.IsUpdated(conDecompressionFile.Memo1))
 {
 if (objDecompressionFileEN.Memo1 !=  null)
 {
 var strMemo1 = objDecompressionFileEN.Memo1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo1, conDecompressionFile.Memo1); //Memo1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDecompressionFile.Memo1); //Memo1
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdDecompressionFile = {0}", objDecompressionFileEN.IdDecompressionFile); 
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
 /// <param name = "lngIdDecompressionFile">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdDecompressionFile) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdDecompressionFile,
};
 objSQL.ExecSP("DecompressionFile_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdDecompressionFile">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdDecompressionFile, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
//删除DecompressionFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DecompressionFile where IdDecompressionFile = " + ""+ lngIdDecompressionFile+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDecompressionFile(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
//删除DecompressionFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DecompressionFile where IdDecompressionFile in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdDecompressionFile">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdDecompressionFile) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
//删除DecompressionFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DecompressionFile where IdDecompressionFile = " + ""+ lngIdDecompressionFile+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDecompressionFile(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDecompressionFileDA: DelDecompressionFile)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DecompressionFile where " + strCondition ;
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
public bool DelDecompressionFileWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDecompressionFileDA: DelDecompressionFileWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DecompressionFile where " + strCondition ;
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
 /// <param name = "objDecompressionFileENS">源对象</param>
 /// <param name = "objDecompressionFileENT">目标对象</param>
public void CopyTo(clsDecompressionFileEN objDecompressionFileENS, clsDecompressionFileEN objDecompressionFileENT)
{
objDecompressionFileENT.IdDecompressionFile = objDecompressionFileENS.IdDecompressionFile; //解压缩文件流水号
objDecompressionFileENT.UploadFileDir = objDecompressionFileENS.UploadFileDir; //上传文件的路径
objDecompressionFileENT.UploadPerson = objDecompressionFileENS.UploadPerson; //上传人
objDecompressionFileENT.NewName = objDecompressionFileENS.NewName; //新名称
objDecompressionFileENT.NewPath = objDecompressionFileENS.NewPath; //新路径
objDecompressionFileENT.UploadDate = objDecompressionFileENS.UploadDate; //上传时间
objDecompressionFileENT.DecompressionFilePath = objDecompressionFileENS.DecompressionFilePath; //解压缩文件路径
objDecompressionFileENT.FileName = objDecompressionFileENS.FileName; //文件名称
objDecompressionFileENT.FilePath = objDecompressionFileENS.FilePath; //文件路径
objDecompressionFileENT.FileSize = objDecompressionFileENS.FileSize; //文件大小
objDecompressionFileENT.FileSizeUnit = objDecompressionFileENS.FileSizeUnit; //文件大小单位
objDecompressionFileENT.IsRar = objDecompressionFileENS.IsRar; //是否解压缩
objDecompressionFileENT.UserId = objDecompressionFileENS.UserId; //用户ID
objDecompressionFileENT.HomePage = objDecompressionFileENS.HomePage; //HomePage
objDecompressionFileENT.HomePageDir = objDecompressionFileENS.HomePageDir; //首页文件目录
objDecompressionFileENT.Memo = objDecompressionFileENS.Memo; //备注
objDecompressionFileENT.Memo1 = objDecompressionFileENS.Memo1; //Memo1
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDecompressionFileEN objDecompressionFileEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDecompressionFileEN.UserId, conDecompressionFile.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UploadFileDir, 1000, conDecompressionFile.UploadFileDir);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UploadPerson, 20, conDecompressionFile.UploadPerson);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.NewName, 1000, conDecompressionFile.NewName);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.NewPath, 1000, conDecompressionFile.NewPath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.DecompressionFilePath, 500, conDecompressionFile.DecompressionFilePath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileName, 500, conDecompressionFile.FileName);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FilePath, 500, conDecompressionFile.FilePath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileSize, 50, conDecompressionFile.FileSize);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileSizeUnit, 10, conDecompressionFile.FileSizeUnit);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UserId, 18, conDecompressionFile.UserId);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.HomePage, 100, conDecompressionFile.HomePage);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.HomePageDir, 200, conDecompressionFile.HomePageDir);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.Memo, 1000, conDecompressionFile.Memo);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.Memo1, 1000, conDecompressionFile.Memo1);
//检查字段外键固定长度
 objDecompressionFileEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDecompressionFileEN objDecompressionFileEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UploadFileDir, 1000, conDecompressionFile.UploadFileDir);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UploadPerson, 20, conDecompressionFile.UploadPerson);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.NewName, 1000, conDecompressionFile.NewName);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.NewPath, 1000, conDecompressionFile.NewPath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.DecompressionFilePath, 500, conDecompressionFile.DecompressionFilePath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileName, 500, conDecompressionFile.FileName);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FilePath, 500, conDecompressionFile.FilePath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileSize, 50, conDecompressionFile.FileSize);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileSizeUnit, 10, conDecompressionFile.FileSizeUnit);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UserId, 18, conDecompressionFile.UserId);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.HomePage, 100, conDecompressionFile.HomePage);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.HomePageDir, 200, conDecompressionFile.HomePageDir);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.Memo, 1000, conDecompressionFile.Memo);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.Memo1, 1000, conDecompressionFile.Memo1);
//检查外键字段长度
 objDecompressionFileEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDecompressionFileEN objDecompressionFileEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UploadFileDir, 1000, conDecompressionFile.UploadFileDir);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UploadPerson, 20, conDecompressionFile.UploadPerson);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.NewName, 1000, conDecompressionFile.NewName);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.NewPath, 1000, conDecompressionFile.NewPath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.DecompressionFilePath, 500, conDecompressionFile.DecompressionFilePath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileName, 500, conDecompressionFile.FileName);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FilePath, 500, conDecompressionFile.FilePath);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileSize, 50, conDecompressionFile.FileSize);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.FileSizeUnit, 10, conDecompressionFile.FileSizeUnit);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.UserId, 18, conDecompressionFile.UserId);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.HomePage, 100, conDecompressionFile.HomePage);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.HomePageDir, 200, conDecompressionFile.HomePageDir);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.Memo, 1000, conDecompressionFile.Memo);
clsCheckSql.CheckFieldLen(objDecompressionFileEN.Memo1, 1000, conDecompressionFile.Memo1);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.UploadFileDir, conDecompressionFile.UploadFileDir);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.UploadPerson, conDecompressionFile.UploadPerson);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.NewName, conDecompressionFile.NewName);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.NewPath, conDecompressionFile.NewPath);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.DecompressionFilePath, conDecompressionFile.DecompressionFilePath);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.FileName, conDecompressionFile.FileName);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.FilePath, conDecompressionFile.FilePath);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.FileSize, conDecompressionFile.FileSize);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.FileSizeUnit, conDecompressionFile.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.UserId, conDecompressionFile.UserId);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.HomePage, conDecompressionFile.HomePage);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.HomePageDir, conDecompressionFile.HomePageDir);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.Memo, conDecompressionFile.Memo);
clsCheckSql.CheckSqlInjection4Field(objDecompressionFileEN.Memo1, conDecompressionFile.Memo1);
//检查外键字段长度
 objDecompressionFileEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DecompressionFile(解压缩文件),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDecompressionFileEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDecompressionFileEN objDecompressionFileEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objDecompressionFileEN.FileName == null)
{
 sbCondition.AppendFormat(" and FileName is null");
}
else
{
 sbCondition.AppendFormat(" and FileName = '{0}'", objDecompressionFileEN.FileName);
}
 if (objDecompressionFileEN.UploadPerson == null)
{
 sbCondition.AppendFormat(" and UploadPerson is null");
}
else
{
 sbCondition.AppendFormat(" and UploadPerson = '{0}'", objDecompressionFileEN.UploadPerson);
}
 if (objDecompressionFileEN.UploadFileDir == null)
{
 sbCondition.AppendFormat(" and UploadFileDir is null");
}
else
{
 sbCondition.AppendFormat(" and UploadFileDir = '{0}'", objDecompressionFileEN.UploadFileDir);
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDecompressionFileEN._CurrTabName);
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDecompressionFileEN._CurrTabName, strCondition);
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
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
 objSQL = clsDecompressionFileDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
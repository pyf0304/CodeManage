
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerDA
 表名:FileServer(01120325)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 文件服务(FileServer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFileServerDA : clsCommBase4DA
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
 return clsFileServerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFileServerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFileServerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFileServerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFileServerEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdFile">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdFile)
{
strIdFile = strIdFile.Replace("'", "''");
if (strIdFile.Length > 8)
{
throw new Exception("(errid:Data000001)在表:FileServer中,检查关键字,长度不正确!(clsFileServerDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdFile)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FileServer中,关键字不能为空 或 null!(clsFileServerDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFile);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFileServerDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FileServer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_FileServer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FileServer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FileServer.* from FileServer Left Join {1} on {2} where {3} and FileServer.IdFile not in (Select top {5} FileServer.IdFile from FileServer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and IdFile not in (Select top {2} IdFile from FileServer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and IdFile not in (Select top {3} IdFile from FileServer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FileServer.* from FileServer Left Join {1} on {2} where {3} and FileServer.IdFile not in (Select top {5} FileServer.IdFile from FileServer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and IdFile not in (Select top {2} IdFile from FileServer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and IdFile not in (Select top {3} IdFile from FileServer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFileServerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFileServerDA:GetObjLst)", objException.Message));
}
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFileServerDA: GetObjLst)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileServerEN);
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
public List<clsFileServerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFileServerDA:GetObjLstByTabName)", objException.Message));
}
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFileServerDA: GetObjLst)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFileServer(ref clsFileServerEN objFileServerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where IdFile = " + "'"+ objFileServerEN.IdFile+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFileServerEN.IdFile = objDT.Rows[0][conFileServer.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.FileName = objDT.Rows[0][conFileServer.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objFileServerEN.FileContent = (byte[])objDT.Rows[0][conFileServer.FileContent]; //文件内容(字段类型:image,字段长度:2147483647,是否可空:True)
 objFileServerEN.FileType = objDT.Rows[0][conFileServer.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.SaveDate = objDT.Rows[0][conFileServer.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.FileSize = objDT.Rows[0][conFileServer.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objFileServerEN.SaveTime = objDT.Rows[0][conFileServer.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objFileServerEN.ResourceOwner = objDT.Rows[0][conFileServer.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objFileServerEN.FileOriginName = objDT.Rows[0][conFileServer.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFileServerDA: GetFileServer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdFile">表关键字</param>
 /// <returns>表对象</returns>
public clsFileServerEN GetObjByIdFile(string strIdFile)
{
CheckPrimaryKey(strIdFile);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where IdFile = " + "'"+ strIdFile+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
 objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容(字段类型:image,字段长度:2147483647,是否可空:True)
 objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFileServerDA: GetObjByIdFile)", objException.Message));
}
return objFileServerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFileServerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFileServerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFileServerEN objFileServerEN = new clsFileServerEN()
{
IdFile = objRow[conFileServer.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(), //文件名称
FileContent = (byte[])objRow[conFileServer.FileContent], //文件内容
FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(), //创建时间
ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(), //上传者
FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim() //原文件名
};
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFileServerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFileServerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = objRow[conFileServer.FileContent] as byte[]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFileServerDA: GetObjByDataRowFileServer)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFileServerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.IdFile = objRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objFileServerEN.FileName = objRow[conFileServer.FileName] == DBNull.Value ? null : objRow[conFileServer.FileName].ToString().Trim(); //文件名称
objFileServerEN.FileContent = objRow[conFileServer.FileContent] as byte[]; //文件内容
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? null : objRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objFileServerEN.SaveTime = objRow[conFileServer.SaveTime] == DBNull.Value ? null : objRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objFileServerEN.ResourceOwner = objRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objFileServerEN.FileOriginName = objRow[conFileServer.FileOriginName] == DBNull.Value ? null : objRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFileServerDA: GetObjByDataRow)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
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
objSQL = clsFileServerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFileServerEN._CurrTabName, conFileServer.IdFile, 8, "");
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
objSQL = clsFileServerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFileServerEN._CurrTabName, conFileServer.IdFile, 8, strPrefix);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdFile from FileServer where " + strCondition;
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdFile from FileServer where " + strCondition;
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
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdFile)
{
CheckPrimaryKey(strIdFile);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FileServer", "IdFile = " + "'"+ strIdFile+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFileServerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FileServer", strCondition))
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
objSQL = clsFileServerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FileServer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFileServerEN objFileServerEN)
 {
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FileServer");
objRow = objDS.Tables["FileServer"].NewRow();
objRow[conFileServer.IdFile] = objFileServerEN.IdFile; //文件流水号
 if (objFileServerEN.FileName !=  "")
 {
objRow[conFileServer.FileName] = objFileServerEN.FileName; //文件名称
 }
objRow[conFileServer.FileContent] = objFileServerEN.FileContent; //文件内容
 if (objFileServerEN.FileType !=  "")
 {
objRow[conFileServer.FileType] = objFileServerEN.FileType; //文件类型
 }
 if (objFileServerEN.SaveDate !=  "")
 {
objRow[conFileServer.SaveDate] = objFileServerEN.SaveDate; //创建日期
 }
 if (objFileServerEN.FileSize !=  "")
 {
objRow[conFileServer.FileSize] = objFileServerEN.FileSize; //文件大小
 }
 if (objFileServerEN.SaveTime !=  "")
 {
objRow[conFileServer.SaveTime] = objFileServerEN.SaveTime; //创建时间
 }
objRow[conFileServer.ResourceOwner] = objFileServerEN.ResourceOwner; //上传者
 if (objFileServerEN.FileOriginName !=  "")
 {
objRow[conFileServer.FileOriginName] = objFileServerEN.FileOriginName; //原文件名
 }
objDS.Tables[clsFileServerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFileServerEN._CurrTabName);
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFileServerEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFile);
 var strIdFile = objFileServerEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveDate + "'");
 }
 
 if (objFileServerEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileSize);
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objFileServerEN.SaveTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveTime);
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveTime + "'");
 }
 
 if (objFileServerEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ResourceOwner);
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceOwner + "'");
 }
 
 if (objFileServerEN.FileOriginName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileOriginName);
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileOriginName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFileServerEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFile);
 var strIdFile = objFileServerEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveDate + "'");
 }
 
 if (objFileServerEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileSize);
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objFileServerEN.SaveTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveTime);
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveTime + "'");
 }
 
 if (objFileServerEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ResourceOwner);
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceOwner + "'");
 }
 
 if (objFileServerEN.FileOriginName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileOriginName);
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileOriginName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFileServerEN.IdFile;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFileServerEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFile);
 var strIdFile = objFileServerEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveDate + "'");
 }
 
 if (objFileServerEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileSize);
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objFileServerEN.SaveTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveTime);
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveTime + "'");
 }
 
 if (objFileServerEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ResourceOwner);
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceOwner + "'");
 }
 
 if (objFileServerEN.FileOriginName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileOriginName);
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileOriginName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFileServerEN.IdFile;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFileServerEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFile);
 var strIdFile = objFileServerEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveDate + "'");
 }
 
 if (objFileServerEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileSize);
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSize + "'");
 }
 
 if (objFileServerEN.SaveTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveTime);
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSaveTime + "'");
 }
 
 if (objFileServerEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ResourceOwner);
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceOwner + "'");
 }
 
 if (objFileServerEN.FileOriginName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileOriginName);
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileOriginName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFileServers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where IdFile = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FileServer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdFile = oRow[conFileServer.IdFile].ToString().Trim();
if (IsExist(strIdFile))
{
 string strResult = "关键字变量值为:" + string.Format("IdFile = {0}", strIdFile) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFileServerEN._CurrTabName ].NewRow();
objRow[conFileServer.IdFile] = oRow[conFileServer.IdFile].ToString().Trim(); //文件流水号
objRow[conFileServer.FileName] = oRow[conFileServer.FileName].ToString().Trim(); //文件名称
objRow[conFileServer.FileContent] = oRow[conFileServer.FileContent].ToString().Trim(); //文件内容
objRow[conFileServer.FileType] = oRow[conFileServer.FileType].ToString().Trim(); //文件类型
objRow[conFileServer.SaveDate] = oRow[conFileServer.SaveDate].ToString().Trim(); //创建日期
objRow[conFileServer.FileSize] = oRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objRow[conFileServer.SaveTime] = oRow[conFileServer.SaveTime].ToString().Trim(); //创建时间
objRow[conFileServer.ResourceOwner] = oRow[conFileServer.ResourceOwner].ToString().Trim(); //上传者
objRow[conFileServer.FileOriginName] = oRow[conFileServer.FileOriginName].ToString().Trim(); //原文件名
 objDS.Tables[clsFileServerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFileServerEN._CurrTabName);
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
 /// <param name = "objFileServerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where IdFile = " + "'"+ objFileServerEN.IdFile+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFileServerEN._CurrTabName);
if (objDS.Tables[clsFileServerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdFile = " + "'"+ objFileServerEN.IdFile+"'");
return false;
}
objRow = objDS.Tables[clsFileServerEN._CurrTabName].Rows[0];
 if (objFileServerEN.IsUpdated(conFileServer.IdFile))
 {
objRow[conFileServer.IdFile] = objFileServerEN.IdFile; //文件流水号
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
objRow[conFileServer.FileName] = objFileServerEN.FileName; //文件名称
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
objRow[conFileServer.FileContent] = objFileServerEN.FileContent; //文件内容
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
objRow[conFileServer.FileType] = objFileServerEN.FileType; //文件类型
 }
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
objRow[conFileServer.SaveDate] = objFileServerEN.SaveDate; //创建日期
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
objRow[conFileServer.FileSize] = objFileServerEN.FileSize; //文件大小
 }
 if (objFileServerEN.IsUpdated(conFileServer.SaveTime))
 {
objRow[conFileServer.SaveTime] = objFileServerEN.SaveTime; //创建时间
 }
 if (objFileServerEN.IsUpdated(conFileServer.ResourceOwner))
 {
objRow[conFileServer.ResourceOwner] = objFileServerEN.ResourceOwner; //上传者
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileOriginName))
 {
objRow[conFileServer.FileOriginName] = objFileServerEN.FileOriginName; //原文件名
 }
try
{
objDA.Update(objDS, clsFileServerEN._CurrTabName);
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conFileServer.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileName); //文件名称
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileContent, conFileServer.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileType, conFileServer.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileType); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSaveDate, conFileServer.SaveDate); //创建日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveDate); //创建日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 if (objFileServerEN.FileSize !=  null)
 {
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSize, conFileServer.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileSize); //文件大小
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveTime))
 {
 if (objFileServerEN.SaveTime !=  null)
 {
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSaveTime, conFileServer.SaveTime); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveTime); //创建时间
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ResourceOwner))
 {
 if (objFileServerEN.ResourceOwner !=  null)
 {
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceOwner, conFileServer.ResourceOwner); //上传者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.ResourceOwner); //上传者
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileOriginName))
 {
 if (objFileServerEN.FileOriginName !=  null)
 {
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileOriginName, conFileServer.FileOriginName); //原文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileOriginName); //原文件名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdFile = '{0}'", objFileServerEN.IdFile); 
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFileServerEN objFileServerEN, string strCondition)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat(" FileContent = '{0}',", objFileServerEN.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", strFileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveDate = '{0}',", strSaveDate); //创建日期
 }
 else
 {
 sbSQL.Append(" SaveDate = null,"); //创建日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 if (objFileServerEN.FileSize !=  null)
 {
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSize = '{0}',", strFileSize); //文件大小
 }
 else
 {
 sbSQL.Append(" FileSize = null,"); //文件大小
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveTime))
 {
 if (objFileServerEN.SaveTime !=  null)
 {
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveTime = '{0}',", strSaveTime); //创建时间
 }
 else
 {
 sbSQL.Append(" SaveTime = null,"); //创建时间
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ResourceOwner))
 {
 if (objFileServerEN.ResourceOwner !=  null)
 {
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceOwner = '{0}',", strResourceOwner); //上传者
 }
 else
 {
 sbSQL.Append(" ResourceOwner = null,"); //上传者
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileOriginName))
 {
 if (objFileServerEN.FileOriginName !=  null)
 {
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileOriginName = '{0}',", strFileOriginName); //原文件名
 }
 else
 {
 sbSQL.Append(" FileOriginName = null,"); //原文件名
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFileServerEN objFileServerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat(" FileContent = '{0}',", objFileServerEN.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", strFileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveDate = '{0}',", strSaveDate); //创建日期
 }
 else
 {
 sbSQL.Append(" SaveDate = null,"); //创建日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 if (objFileServerEN.FileSize !=  null)
 {
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSize = '{0}',", strFileSize); //文件大小
 }
 else
 {
 sbSQL.Append(" FileSize = null,"); //文件大小
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveTime))
 {
 if (objFileServerEN.SaveTime !=  null)
 {
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveTime = '{0}',", strSaveTime); //创建时间
 }
 else
 {
 sbSQL.Append(" SaveTime = null,"); //创建时间
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ResourceOwner))
 {
 if (objFileServerEN.ResourceOwner !=  null)
 {
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceOwner = '{0}',", strResourceOwner); //上传者
 }
 else
 {
 sbSQL.Append(" ResourceOwner = null,"); //上传者
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileOriginName))
 {
 if (objFileServerEN.FileOriginName !=  null)
 {
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileOriginName = '{0}',", strFileOriginName); //原文件名
 }
 else
 {
 sbSQL.Append(" FileOriginName = null,"); //原文件名
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 var strFileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conFileServer.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileName); //文件名称
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileContent, conFileServer.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 var strFileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileType, conFileServer.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileType); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 var strSaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSaveDate, conFileServer.SaveDate); //创建日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveDate); //创建日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 if (objFileServerEN.FileSize !=  null)
 {
 var strFileSize = objFileServerEN.FileSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSize, conFileServer.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileSize); //文件大小
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveTime))
 {
 if (objFileServerEN.SaveTime !=  null)
 {
 var strSaveTime = objFileServerEN.SaveTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSaveTime, conFileServer.SaveTime); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveTime); //创建时间
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ResourceOwner))
 {
 if (objFileServerEN.ResourceOwner !=  null)
 {
 var strResourceOwner = objFileServerEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceOwner, conFileServer.ResourceOwner); //上传者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.ResourceOwner); //上传者
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileOriginName))
 {
 if (objFileServerEN.FileOriginName !=  null)
 {
 var strFileOriginName = objFileServerEN.FileOriginName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileOriginName, conFileServer.FileOriginName); //原文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileOriginName); //原文件名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdFile = '{0}'", objFileServerEN.IdFile); 
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
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdFile) 
{
CheckPrimaryKey(strIdFile);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdFile,
};
 objSQL.ExecSP("FileServer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdFile, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdFile);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
//删除FileServer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileServer where IdFile = " + "'"+ strIdFile+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFileServer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
//删除FileServer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileServer where IdFile in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdFile">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdFile) 
{
CheckPrimaryKey(strIdFile);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
//删除FileServer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileServer where IdFile = " + "'"+ strIdFile+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFileServer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFileServerDA: DelFileServer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FileServer where " + strCondition ;
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
public bool DelFileServerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFileServerDA: DelFileServerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FileServer where " + strCondition ;
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
public void CopyTo(clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
objFileServerENT.IdFile = objFileServerENS.IdFile; //文件流水号
objFileServerENT.FileName = objFileServerENS.FileName; //文件名称
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //创建日期
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.SaveTime = objFileServerENS.SaveTime; //创建时间
objFileServerENT.ResourceOwner = objFileServerENS.ResourceOwner; //上传者
objFileServerENT.FileOriginName = objFileServerENS.FileOriginName; //原文件名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFileServerEN objFileServerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFileServerEN.ResourceOwner, conFileServer.ResourceOwner);
//检查字段长度
clsCheckSql.CheckFieldLen(objFileServerEN.IdFile, 8, conFileServer.IdFile);
clsCheckSql.CheckFieldLen(objFileServerEN.FileName, 500, conFileServer.FileName);
clsCheckSql.CheckFieldLen(objFileServerEN.FileType, 30, conFileServer.FileType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveDate, 8, conFileServer.SaveDate);
clsCheckSql.CheckFieldLen(objFileServerEN.FileSize, 50, conFileServer.FileSize);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveTime, 6, conFileServer.SaveTime);
clsCheckSql.CheckFieldLen(objFileServerEN.ResourceOwner, 50, conFileServer.ResourceOwner);
clsCheckSql.CheckFieldLen(objFileServerEN.FileOriginName, 500, conFileServer.FileOriginName);
//检查字段外键固定长度
 objFileServerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFileServerEN objFileServerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFileServerEN.FileName, 500, conFileServer.FileName);
clsCheckSql.CheckFieldLen(objFileServerEN.FileType, 30, conFileServer.FileType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveDate, 8, conFileServer.SaveDate);
clsCheckSql.CheckFieldLen(objFileServerEN.FileSize, 50, conFileServer.FileSize);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveTime, 6, conFileServer.SaveTime);
clsCheckSql.CheckFieldLen(objFileServerEN.ResourceOwner, 50, conFileServer.ResourceOwner);
clsCheckSql.CheckFieldLen(objFileServerEN.FileOriginName, 500, conFileServer.FileOriginName);
//检查外键字段长度
 objFileServerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFileServerEN objFileServerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFileServerEN.IdFile, 8, conFileServer.IdFile);
clsCheckSql.CheckFieldLen(objFileServerEN.FileName, 500, conFileServer.FileName);
clsCheckSql.CheckFieldLen(objFileServerEN.FileType, 30, conFileServer.FileType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveDate, 8, conFileServer.SaveDate);
clsCheckSql.CheckFieldLen(objFileServerEN.FileSize, 50, conFileServer.FileSize);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveTime, 6, conFileServer.SaveTime);
clsCheckSql.CheckFieldLen(objFileServerEN.ResourceOwner, 50, conFileServer.ResourceOwner);
clsCheckSql.CheckFieldLen(objFileServerEN.FileOriginName, 500, conFileServer.FileOriginName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.IdFile, conFileServer.IdFile);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.FileName, conFileServer.FileName);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.FileType, conFileServer.FileType);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.SaveDate, conFileServer.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.FileSize, conFileServer.FileSize);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.SaveTime, conFileServer.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.ResourceOwner, conFileServer.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.FileOriginName, conFileServer.FileOriginName);
//检查外键字段长度
 objFileServerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdFile()
{
//获取某学院所有专业信息
string strSQL = "select IdFile, FileName from FileServer ";
 clsSpecSQLforSql mySql = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFileServerEN._CurrTabName);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFileServerEN._CurrTabName, strCondition);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
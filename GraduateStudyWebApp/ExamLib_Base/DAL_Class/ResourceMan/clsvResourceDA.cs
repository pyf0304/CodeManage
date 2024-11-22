
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResourceDA
 表名:vResource(01120321)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// v资源(vResource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvResourceDA : clsCommBase4DA
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
 return clsvResourceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvResourceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvResourceEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdResource">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdResource)
{
strIdResource = strIdResource.Replace("'", "''");
if (strIdResource.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vResource中,检查关键字,长度不正确!(clsvResourceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdResource)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vResource中,关键字不能为空 或 null!(clsvResourceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvResourceDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable_vResource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vResource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vResource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vResource.* from vResource Left Join {1} on {2} where {3} and vResource.IdResource not in (Select top {5} vResource.IdResource from vResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vResource where {1} and IdResource not in (Select top {2} IdResource from vResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vResource where {1} and IdResource not in (Select top {3} IdResource from vResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vResource.* from vResource Left Join {1} on {2} where {3} and vResource.IdResource not in (Select top {5} vResource.IdResource from vResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vResource where {1} and IdResource not in (Select top {2} IdResource from vResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vResource where {1} and IdResource not in (Select top {3} IdResource from vResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvResourceDA:GetObjLst)", objException.Message));
}
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = TransNullToBool(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = TransNullToBool(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvResourceDA: GetObjLst)", objException.Message));
}
objvResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvResourceEN);
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
public List<clsvResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = TransNullToBool(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = TransNullToBool(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvResourceDA: GetObjLst)", objException.Message));
}
objvResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvResource(ref clsvResourceEN objvResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where IdResource = " + "'"+ objvResourceEN.IdResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvResourceEN.IdResource = objDT.Rows[0][convResource.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvResourceEN.ResourceID = objDT.Rows[0][convResource.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvResourceEN.ResourceName = objDT.Rows[0][convResource.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvResourceEN.SaveMode = TransNullToBool(objDT.Rows[0][convResource.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvResourceEN.IdFtpResource = objDT.Rows[0][convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.FtpResourceID = objDT.Rows[0][convResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvResourceEN.FileOriginalName = objDT.Rows[0][convResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvResourceEN.FileDirName = objDT.Rows[0][convResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvResourceEN.FileRename = objDT.Rows[0][convResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvResourceEN.FileUpDate = objDT.Rows[0][convResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.FileUpTime = objDT.Rows[0][convResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvResourceEN.FileSize = objDT.Rows[0][convResource.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvResourceEN.FileType = objDT.Rows[0][convResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvResourceEN.ResourceOwner = objDT.Rows[0][convResource.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvResourceEN.IsExistFile = TransNullToBool(objDT.Rows[0][convResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvResourceEN.IdFile = objDT.Rows[0][convResource.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.FileName = objDT.Rows[0][convResource.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvResourceEN.SaveDate = objDT.Rows[0][convResource.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.SaveTime = objDT.Rows[0][convResource.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvResourceEN.FileOriginName = objDT.Rows[0][convResource.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvResourceEN.IdResourceType = objDT.Rows[0][convResource.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvResourceEN.ResourceTypeID = objDT.Rows[0][convResource.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvResourceEN.ResourceTypeName = objDT.Rows[0][convResource.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvResourceEN.Memo = objDT.Rows[0][convResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvResourceEN.FuncModuleId = objDT.Rows[0][convResource.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvResourceEN.FuncModuleNameSim = objDT.Rows[0][convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvResourceEN.OrderNum = TransNullToInt(objDT.Rows[0][convResource.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvResourceEN.CheckDate = objDT.Rows[0][convResource.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvResourceEN.CheckUser = objDT.Rows[0][convResource.CheckUser].ToString().Trim(); //检查用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvResourceEN.CheckResult = objDT.Rows[0][convResource.CheckResult].ToString().Trim(); //检查结果(字段类型:varchar,字段长度:1000,是否可空:True)
 objvResourceEN.FileNewName = objDT.Rows[0][convResource.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvResourceEN.FileOldName = objDT.Rows[0][convResource.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvResourceEN.ftpFileType = objDT.Rows[0][convResource.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvResourceEN.ftpFileSize = objDT.Rows[0][convResource.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvResourceEN.ftpResourceOwner = objDT.Rows[0][convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvResourceDA: GetvResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdResource">表关键字</param>
 /// <returns>表对象</returns>
public clsvResourceEN GetObjByIdResource(string strIdResource)
{
CheckPrimaryKey(strIdResource);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where IdResource = " + "'"+ strIdResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
 objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果(字段类型:varchar,字段长度:1000,是否可空:True)
 objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvResourceDA: GetObjByIdResource)", objException.Message));
}
return objvResourceEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
strSQL = "Select * from vResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvResourceEN objvResourceEN = new clsvResourceEN()
{
IdResource = objRow[convResource.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convResource.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convResource.ResourceName].ToString().Trim(), //资源名称
SaveMode = TransNullToBool(objRow[convResource.SaveMode].ToString().Trim()), //文件存放方式
IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(), //文件类型
ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(), //上传者
IsExistFile = TransNullToBool(objRow[convResource.IsExistFile].ToString().Trim()), //是否存在文件
IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(), //文件名称
SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(), //创建日期
SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(), //创建时间
FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(), //原文件名
IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(), //资源类型名称
Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(), //备注
FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(), //功能模块简称
OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convResource.OrderNum].ToString().Trim()), //序号
CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(), //检查日期
CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(), //检查用户Id
CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(), //检查结果
FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(), //旧文件名
ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim() //Ftp资源拥有者
};
objvResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = TransNullToBool(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = TransNullToBool(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvResourceDA: GetObjByDataRowvResource)", objException.Message));
}
objvResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = TransNullToBool(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = TransNullToBool(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvResourceDA: GetObjByDataRow)", objException.Message));
}
objvResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvResourceEN;
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
objSQL = clsvResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvResourceEN._CurrTabName, convResource.IdResource, 8, "");
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
objSQL = clsvResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvResourceEN._CurrTabName, convResource.IdResource, 8, strPrefix);
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdResource from vResource where " + strCondition;
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdResource from vResource where " + strCondition;
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
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdResource)
{
CheckPrimaryKey(strIdResource);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vResource", "IdResource = " + "'"+ strIdResource+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vResource", strCondition))
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
objSQL = clsvResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vResource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvResourceENS">源对象</param>
 /// <param name = "objvResourceENT">目标对象</param>
public void CopyTo(clsvResourceEN objvResourceENS, clsvResourceEN objvResourceENT)
{
objvResourceENT.IdResource = objvResourceENS.IdResource; //资源流水号
objvResourceENT.ResourceID = objvResourceENS.ResourceID; //资源ID
objvResourceENT.ResourceName = objvResourceENS.ResourceName; //资源名称
objvResourceENT.SaveMode = objvResourceENS.SaveMode; //文件存放方式
objvResourceENT.IdFtpResource = objvResourceENS.IdFtpResource; //FTP资源流水号
objvResourceENT.FtpResourceID = objvResourceENS.FtpResourceID; //FTP资源ID
objvResourceENT.FileOriginalName = objvResourceENS.FileOriginalName; //文件原名
objvResourceENT.FileDirName = objvResourceENS.FileDirName; //文件目录名
objvResourceENT.FileRename = objvResourceENS.FileRename; //文件新名
objvResourceENT.FileUpDate = objvResourceENS.FileUpDate; //创建日期
objvResourceENT.FileUpTime = objvResourceENS.FileUpTime; //创建时间
objvResourceENT.FileSize = objvResourceENS.FileSize; //文件大小
objvResourceENT.FileType = objvResourceENS.FileType; //文件类型
objvResourceENT.ResourceOwner = objvResourceENS.ResourceOwner; //上传者
objvResourceENT.IsExistFile = objvResourceENS.IsExistFile; //是否存在文件
objvResourceENT.IdFile = objvResourceENS.IdFile; //文件流水号
objvResourceENT.FileName = objvResourceENS.FileName; //文件名称
objvResourceENT.SaveDate = objvResourceENS.SaveDate; //创建日期
objvResourceENT.SaveTime = objvResourceENS.SaveTime; //创建时间
objvResourceENT.FileOriginName = objvResourceENS.FileOriginName; //原文件名
objvResourceENT.IdResourceType = objvResourceENS.IdResourceType; //资源类型流水号
objvResourceENT.ResourceTypeID = objvResourceENS.ResourceTypeID; //资源类型ID
objvResourceENT.ResourceTypeName = objvResourceENS.ResourceTypeName; //资源类型名称
objvResourceENT.Memo = objvResourceENS.Memo; //备注
objvResourceENT.FuncModuleId = objvResourceENS.FuncModuleId; //功能模块Id
objvResourceENT.FuncModuleNameSim = objvResourceENS.FuncModuleNameSim; //功能模块简称
objvResourceENT.OrderNum = objvResourceENS.OrderNum; //序号
objvResourceENT.CheckDate = objvResourceENS.CheckDate; //检查日期
objvResourceENT.CheckUser = objvResourceENS.CheckUser; //检查用户Id
objvResourceENT.CheckResult = objvResourceENS.CheckResult; //检查结果
objvResourceENT.FileNewName = objvResourceENS.FileNewName; //新文件名
objvResourceENT.FileOldName = objvResourceENS.FileOldName; //旧文件名
objvResourceENT.ftpFileType = objvResourceENS.ftpFileType; //ftp文件类型
objvResourceENT.ftpFileSize = objvResourceENS.ftpFileSize; //ftp文件大小
objvResourceENT.ftpResourceOwner = objvResourceENS.ftpResourceOwner; //Ftp资源拥有者
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvResourceEN objvResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvResourceEN.IdResource, 8, convResource.IdResource);
clsCheckSql.CheckFieldLen(objvResourceEN.ResourceID, 8, convResource.ResourceID);
clsCheckSql.CheckFieldLen(objvResourceEN.ResourceName, 100, convResource.ResourceName);
clsCheckSql.CheckFieldLen(objvResourceEN.IdFtpResource, 8, convResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objvResourceEN.FtpResourceID, 8, convResource.FtpResourceID);
clsCheckSql.CheckFieldLen(objvResourceEN.FileOriginalName, 200, convResource.FileOriginalName);
clsCheckSql.CheckFieldLen(objvResourceEN.FileDirName, 200, convResource.FileDirName);
clsCheckSql.CheckFieldLen(objvResourceEN.FileRename, 200, convResource.FileRename);
clsCheckSql.CheckFieldLen(objvResourceEN.FileUpDate, 8, convResource.FileUpDate);
clsCheckSql.CheckFieldLen(objvResourceEN.FileUpTime, 6, convResource.FileUpTime);
clsCheckSql.CheckFieldLen(objvResourceEN.FileSize, 50, convResource.FileSize);
clsCheckSql.CheckFieldLen(objvResourceEN.FileType, 30, convResource.FileType);
clsCheckSql.CheckFieldLen(objvResourceEN.ResourceOwner, 50, convResource.ResourceOwner);
clsCheckSql.CheckFieldLen(objvResourceEN.IdFile, 8, convResource.IdFile);
clsCheckSql.CheckFieldLen(objvResourceEN.FileName, 500, convResource.FileName);
clsCheckSql.CheckFieldLen(objvResourceEN.SaveDate, 8, convResource.SaveDate);
clsCheckSql.CheckFieldLen(objvResourceEN.SaveTime, 6, convResource.SaveTime);
clsCheckSql.CheckFieldLen(objvResourceEN.FileOriginName, 500, convResource.FileOriginName);
clsCheckSql.CheckFieldLen(objvResourceEN.IdResourceType, 4, convResource.IdResourceType);
clsCheckSql.CheckFieldLen(objvResourceEN.ResourceTypeID, 4, convResource.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvResourceEN.ResourceTypeName, 50, convResource.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvResourceEN.Memo, 1000, convResource.Memo);
clsCheckSql.CheckFieldLen(objvResourceEN.FuncModuleId, 4, convResource.FuncModuleId);
clsCheckSql.CheckFieldLen(objvResourceEN.FuncModuleNameSim, 30, convResource.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvResourceEN.CheckDate, 20, convResource.CheckDate);
clsCheckSql.CheckFieldLen(objvResourceEN.CheckUser, 18, convResource.CheckUser);
clsCheckSql.CheckFieldLen(objvResourceEN.CheckResult, 1000, convResource.CheckResult);
clsCheckSql.CheckFieldLen(objvResourceEN.FileNewName, 530, convResource.FileNewName);
clsCheckSql.CheckFieldLen(objvResourceEN.FileOldName, 530, convResource.FileOldName);
clsCheckSql.CheckFieldLen(objvResourceEN.ftpFileType, 30, convResource.ftpFileType);
clsCheckSql.CheckFieldLen(objvResourceEN.ftpFileSize, 50, convResource.ftpFileSize);
clsCheckSql.CheckFieldLen(objvResourceEN.ftpResourceOwner, 50, convResource.ftpResourceOwner);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.IdResource, convResource.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ResourceID, convResource.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ResourceName, convResource.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.IdFtpResource, convResource.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FtpResourceID, convResource.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileOriginalName, convResource.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileDirName, convResource.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileRename, convResource.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileUpDate, convResource.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileUpTime, convResource.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileSize, convResource.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileType, convResource.FileType);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ResourceOwner, convResource.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.IdFile, convResource.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileName, convResource.FileName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.SaveDate, convResource.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.SaveTime, convResource.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileOriginName, convResource.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.IdResourceType, convResource.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ResourceTypeID, convResource.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ResourceTypeName, convResource.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.Memo, convResource.Memo);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FuncModuleId, convResource.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FuncModuleNameSim, convResource.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.CheckDate, convResource.CheckDate);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.CheckUser, convResource.CheckUser);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.CheckResult, convResource.CheckResult);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileNewName, convResource.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.FileOldName, convResource.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ftpFileType, convResource.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ftpFileSize, convResource.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvResourceEN.ftpResourceOwner, convResource.ftpResourceOwner);
//检查外键字段长度
 objvResourceEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdResource()
{
//获取某学院所有专业信息
string strSQL = "select IdResource, ResourceName from vResource ";
 clsSpecSQLforSql mySql = clsvResourceDA.GetSpecSQLObj();
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvResourceEN._CurrTabName);
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvResourceEN._CurrTabName, strCondition);
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
 objSQL = clsvResourceDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
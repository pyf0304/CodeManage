
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_AttachmentDA
 表名:cc_Attachment(01120149)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
 /// 附件(cc_Attachment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_AttachmentDA : clsCommBase4DA
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
 return clscc_AttachmentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_AttachmentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_AttachmentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_AttachmentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_AttachmentEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_Attachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable_cc_Attachment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Attachment.* from cc_Attachment Left Join {1} on {2} where {3} and cc_Attachment.AttachmentID not in (Select top {5} cc_Attachment.AttachmentID from cc_Attachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1} and AttachmentID not in (Select top {2} AttachmentID from cc_Attachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1} and AttachmentID not in (Select top {3} AttachmentID from cc_Attachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_AttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Attachment.* from cc_Attachment Left Join {1} on {2} where {3} and cc_Attachment.AttachmentID not in (Select top {5} cc_Attachment.AttachmentID from cc_Attachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1} and AttachmentID not in (Select top {2} AttachmentID from cc_Attachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Attachment where {1} and AttachmentID not in (Select top {3} AttachmentID from cc_Attachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_AttachmentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_AttachmentDA:GetObjLst)", objException.Message));
}
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_AttachmentDA: GetObjLst)", objException.Message));
}
objcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_AttachmentEN);
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
public List<clscc_AttachmentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_AttachmentDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_AttachmentDA: GetObjLst)", objException.Message));
}
objcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_AttachmentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_Attachment(ref clscc_AttachmentEN objcc_AttachmentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where AttachmentID = " + ""+ objcc_AttachmentEN.AttachmentID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_AttachmentEN.AttachmentID = TransNullToInt(objDT.Rows[0][concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_AttachmentEN.TableName = objDT.Rows[0][concc_Attachment.TableName].ToString().Trim(); //主表表名(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_AttachmentEN.FileName = objDT.Rows[0][concc_Attachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_AttachmentEN.Extension = objDT.Rows[0][concc_Attachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_AttachmentEN.FilePath = objDT.Rows[0][concc_Attachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objcc_AttachmentEN.FileSize = TransNullToDouble(objDT.Rows[0][concc_Attachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objcc_AttachmentEN.FileSizeUnit = objDT.Rows[0][concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_AttachmentEN.ImageHeight = TransNullToInt(objDT.Rows[0][concc_Attachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objcc_AttachmentEN.ImageWidth = TransNullToInt(objDT.Rows[0][concc_Attachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
 objcc_AttachmentEN.UploadDate = objDT.Rows[0][concc_Attachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_AttachmentEN.UploadPerson = objDT.Rows[0][concc_Attachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_AttachmentEN.TableNameKey = objDT.Rows[0][concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_AttachmentEN.IdResourceType = objDT.Rows[0][concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objcc_AttachmentEN.UpdDate = objDT.Rows[0][concc_Attachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_AttachmentEN.UpdUserId = objDT.Rows[0][concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_AttachmentEN.Memo = objDT.Rows[0][concc_Attachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_AttachmentDA: Getcc_Attachment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public clscc_AttachmentEN GetObjByAttachmentID(long lngAttachmentID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where AttachmentID = " + ""+ lngAttachmentID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
 objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
 objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_AttachmentDA: GetObjByAttachmentID)", objException.Message));
}
return objcc_AttachmentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_AttachmentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_AttachmentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN()
{
AttachmentID = TransNullToInt(objRow[concc_Attachment.AttachmentID].ToString().Trim()), //附件流水号
TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(), //主表表名
FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(), //文件名称
Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(), //扩展名
FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(), //文件路径
FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_Attachment.FileSize].ToString().Trim()), //文件大小
FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(), //文件大小单位
ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageHeight].ToString().Trim()), //图像高
ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageWidth].ToString().Trim()), //图像宽
UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(), //上传时间
UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(), //上传人
TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(), //主表主键值
IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(), //资源类型流水号
UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim() //备注
};
objcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_AttachmentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_AttachmentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_AttachmentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_AttachmentDA: GetObjByDataRowcc_Attachment)", objException.Message));
}
objcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_AttachmentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_AttachmentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_AttachmentDA: GetObjByDataRow)", objException.Message));
}
objcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_AttachmentEN;
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
objSQL = clscc_AttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_AttachmentEN._CurrTabName, concc_Attachment.AttachmentID, 8, "");
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
objSQL = clscc_AttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_AttachmentEN._CurrTabName, concc_Attachment.AttachmentID, 8, strPrefix);
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AttachmentID from cc_Attachment where " + strCondition;
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AttachmentID from cc_Attachment where " + strCondition;
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
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngAttachmentID)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Attachment", "AttachmentID = " + ""+ lngAttachmentID+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_AttachmentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Attachment", strCondition))
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
objSQL = clscc_AttachmentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_Attachment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_AttachmentEN objcc_AttachmentEN)
 {
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_AttachmentEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Attachment");
objRow = objDS.Tables["cc_Attachment"].NewRow();
 if (objcc_AttachmentEN.TableName !=  "")
 {
objRow[concc_Attachment.TableName] = objcc_AttachmentEN.TableName; //主表表名
 }
 if (objcc_AttachmentEN.FileName !=  "")
 {
objRow[concc_Attachment.FileName] = objcc_AttachmentEN.FileName; //文件名称
 }
 if (objcc_AttachmentEN.Extension !=  "")
 {
objRow[concc_Attachment.Extension] = objcc_AttachmentEN.Extension; //扩展名
 }
objRow[concc_Attachment.FilePath] = objcc_AttachmentEN.FilePath; //文件路径
objRow[concc_Attachment.FileSize] = objcc_AttachmentEN.FileSize; //文件大小
 if (objcc_AttachmentEN.FileSizeUnit !=  "")
 {
objRow[concc_Attachment.FileSizeUnit] = objcc_AttachmentEN.FileSizeUnit; //文件大小单位
 }
objRow[concc_Attachment.ImageHeight] = objcc_AttachmentEN.ImageHeight; //图像高
objRow[concc_Attachment.ImageWidth] = objcc_AttachmentEN.ImageWidth; //图像宽
objRow[concc_Attachment.UploadDate] = objcc_AttachmentEN.UploadDate; //上传时间
 if (objcc_AttachmentEN.UploadPerson !=  "")
 {
objRow[concc_Attachment.UploadPerson] = objcc_AttachmentEN.UploadPerson; //上传人
 }
objRow[concc_Attachment.TableNameKey] = objcc_AttachmentEN.TableNameKey; //主表主键值
objRow[concc_Attachment.IdResourceType] = objcc_AttachmentEN.IdResourceType; //资源类型流水号
objRow[concc_Attachment.UpdDate] = objcc_AttachmentEN.UpdDate; //修改日期
 if (objcc_AttachmentEN.UpdUserId !=  "")
 {
objRow[concc_Attachment.UpdUserId] = objcc_AttachmentEN.UpdUserId; //修改用户Id
 }
 if (objcc_AttachmentEN.Memo !=  "")
 {
objRow[concc_Attachment.Memo] = objcc_AttachmentEN.Memo; //备注
 }
objDS.Tables[clscc_AttachmentEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_AttachmentEN._CurrTabName);
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
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_AttachmentEN objcc_AttachmentEN)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_AttachmentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_AttachmentEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableName);
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objcc_AttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileName);
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objcc_AttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Extension);
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FilePath);
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_AttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSize);
 arrValueListForInsert.Add(objcc_AttachmentEN.FileSize.ToString());
 }
 
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSizeUnit);
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_AttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageHeight);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageHeight.ToString());
 }
 
 if (objcc_AttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageWidth);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageWidth.ToString());
 }
 
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadDate);
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadPerson);
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableNameKey);
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.IdResourceType);
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdDate);
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdUserId);
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_AttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Memo);
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Attachment");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_AttachmentEN objcc_AttachmentEN)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_AttachmentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_AttachmentEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableName);
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objcc_AttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileName);
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objcc_AttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Extension);
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FilePath);
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_AttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSize);
 arrValueListForInsert.Add(objcc_AttachmentEN.FileSize.ToString());
 }
 
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSizeUnit);
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_AttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageHeight);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageHeight.ToString());
 }
 
 if (objcc_AttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageWidth);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageWidth.ToString());
 }
 
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadDate);
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadPerson);
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableNameKey);
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.IdResourceType);
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdDate);
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdUserId);
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_AttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Memo);
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Attachment");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_AttachmentEN objcc_AttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_AttachmentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_AttachmentEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableName);
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objcc_AttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileName);
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objcc_AttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Extension);
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FilePath);
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_AttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSize);
 arrValueListForInsert.Add(objcc_AttachmentEN.FileSize.ToString());
 }
 
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSizeUnit);
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_AttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageHeight);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageHeight.ToString());
 }
 
 if (objcc_AttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageWidth);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageWidth.ToString());
 }
 
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadDate);
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadPerson);
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableNameKey);
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.IdResourceType);
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdDate);
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdUserId);
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_AttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Memo);
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Attachment");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_AttachmentEN objcc_AttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_AttachmentEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_AttachmentEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableName);
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objcc_AttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileName);
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objcc_AttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Extension);
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FilePath);
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objcc_AttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSize);
 arrValueListForInsert.Add(objcc_AttachmentEN.FileSize.ToString());
 }
 
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.FileSizeUnit);
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objcc_AttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageHeight);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageHeight.ToString());
 }
 
 if (objcc_AttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.ImageWidth);
 arrValueListForInsert.Add(objcc_AttachmentEN.ImageWidth.ToString());
 }
 
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadDate);
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UploadPerson);
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.TableNameKey);
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.IdResourceType);
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdDate);
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.UpdUserId);
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_AttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Attachment.Memo);
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Attachment");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_Attachments(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where AttachmentID = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Attachment");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngAttachmentID = TransNullToInt(oRow[concc_Attachment.AttachmentID].ToString().Trim());
if (IsExist(lngAttachmentID))
{
 string strResult = "关键字变量值为:" + string.Format("AttachmentID = {0}", lngAttachmentID) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_AttachmentEN._CurrTabName ].NewRow();
objRow[concc_Attachment.TableName] = oRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objRow[concc_Attachment.FileName] = oRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objRow[concc_Attachment.Extension] = oRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objRow[concc_Attachment.FilePath] = oRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objRow[concc_Attachment.FileSize] = oRow[concc_Attachment.FileSize].ToString().Trim(); //文件大小
objRow[concc_Attachment.FileSizeUnit] = oRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objRow[concc_Attachment.ImageHeight] = oRow[concc_Attachment.ImageHeight].ToString().Trim(); //图像高
objRow[concc_Attachment.ImageWidth] = oRow[concc_Attachment.ImageWidth].ToString().Trim(); //图像宽
objRow[concc_Attachment.UploadDate] = oRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objRow[concc_Attachment.UploadPerson] = oRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objRow[concc_Attachment.TableNameKey] = oRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objRow[concc_Attachment.IdResourceType] = oRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objRow[concc_Attachment.UpdDate] = oRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objRow[concc_Attachment.UpdUserId] = oRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_Attachment.Memo] = oRow[concc_Attachment.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_AttachmentEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_AttachmentEN._CurrTabName);
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
 /// <param name = "objcc_AttachmentEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_AttachmentEN objcc_AttachmentEN)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_AttachmentEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from cc_Attachment where AttachmentID = " + ""+ objcc_AttachmentEN.AttachmentID+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_AttachmentEN._CurrTabName);
if (objDS.Tables[clscc_AttachmentEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AttachmentID = " + ""+ objcc_AttachmentEN.AttachmentID+"");
return false;
}
objRow = objDS.Tables[clscc_AttachmentEN._CurrTabName].Rows[0];
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableName))
 {
objRow[concc_Attachment.TableName] = objcc_AttachmentEN.TableName; //主表表名
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileName))
 {
objRow[concc_Attachment.FileName] = objcc_AttachmentEN.FileName; //文件名称
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Extension))
 {
objRow[concc_Attachment.Extension] = objcc_AttachmentEN.Extension; //扩展名
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FilePath))
 {
objRow[concc_Attachment.FilePath] = objcc_AttachmentEN.FilePath; //文件路径
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSize))
 {
objRow[concc_Attachment.FileSize] = objcc_AttachmentEN.FileSize; //文件大小
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSizeUnit))
 {
objRow[concc_Attachment.FileSizeUnit] = objcc_AttachmentEN.FileSizeUnit; //文件大小单位
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageHeight))
 {
objRow[concc_Attachment.ImageHeight] = objcc_AttachmentEN.ImageHeight; //图像高
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageWidth))
 {
objRow[concc_Attachment.ImageWidth] = objcc_AttachmentEN.ImageWidth; //图像宽
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadDate))
 {
objRow[concc_Attachment.UploadDate] = objcc_AttachmentEN.UploadDate; //上传时间
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadPerson))
 {
objRow[concc_Attachment.UploadPerson] = objcc_AttachmentEN.UploadPerson; //上传人
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableNameKey))
 {
objRow[concc_Attachment.TableNameKey] = objcc_AttachmentEN.TableNameKey; //主表主键值
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.IdResourceType))
 {
objRow[concc_Attachment.IdResourceType] = objcc_AttachmentEN.IdResourceType; //资源类型流水号
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdDate))
 {
objRow[concc_Attachment.UpdDate] = objcc_AttachmentEN.UpdDate; //修改日期
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdUserId))
 {
objRow[concc_Attachment.UpdUserId] = objcc_AttachmentEN.UpdUserId; //修改用户Id
 }
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Memo))
 {
objRow[concc_Attachment.Memo] = objcc_AttachmentEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_AttachmentEN._CurrTabName);
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
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_AttachmentEN objcc_AttachmentEN)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_AttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_Attachment Set ");
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableName))
 {
 if (objcc_AttachmentEN.TableName !=  null)
 {
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableName, concc_Attachment.TableName); //主表表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.TableName); //主表表名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileName))
 {
 if (objcc_AttachmentEN.FileName !=  null)
 {
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, concc_Attachment.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FileName); //文件名称
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Extension))
 {
 if (objcc_AttachmentEN.Extension !=  null)
 {
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, concc_Attachment.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.Extension); //扩展名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FilePath))
 {
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, concc_Attachment.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FilePath); //文件路径
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSize))
 {
 if (objcc_AttachmentEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_AttachmentEN.FileSize, concc_Attachment.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FileSize); //文件大小
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSizeUnit))
 {
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, concc_Attachment.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageHeight))
 {
 if (objcc_AttachmentEN.ImageHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_AttachmentEN.ImageHeight, concc_Attachment.ImageHeight); //图像高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.ImageHeight); //图像高
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageWidth))
 {
 if (objcc_AttachmentEN.ImageWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_AttachmentEN.ImageWidth, concc_Attachment.ImageWidth); //图像宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.ImageWidth); //图像宽
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadDate))
 {
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_Attachment.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UploadDate); //上传时间
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadPerson))
 {
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadPerson, concc_Attachment.UploadPerson); //上传人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UploadPerson); //上传人
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableNameKey))
 {
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableNameKey, concc_Attachment.TableNameKey); //主表主键值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.TableNameKey); //主表主键值
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.IdResourceType))
 {
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResourceType, concc_Attachment.IdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.IdResourceType); //资源类型流水号
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdDate))
 {
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Attachment.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UpdDate); //修改日期
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdUserId))
 {
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Attachment.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Memo))
 {
 if (objcc_AttachmentEN.Memo !=  null)
 {
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Attachment.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AttachmentID = {0}", objcc_AttachmentEN.AttachmentID); 
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
 /// <param name = "objcc_AttachmentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_AttachmentEN objcc_AttachmentEN, string strCondition)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_AttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Attachment Set ");
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableName))
 {
 if (objcc_AttachmentEN.TableName !=  null)
 {
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableName = '{0}',", strTableName); //主表表名
 }
 else
 {
 sbSQL.Append(" TableName = null,"); //主表表名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileName))
 {
 if (objcc_AttachmentEN.FileName !=  null)
 {
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Extension))
 {
 if (objcc_AttachmentEN.Extension !=  null)
 {
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FilePath))
 {
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objcc_AttachmentEN.FileSize); //文件大小
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSizeUnit))
 {
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageHeight))
 {
 sbSQL.AppendFormat(" ImageHeight = {0},", objcc_AttachmentEN.ImageHeight); //图像高
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageWidth))
 {
 sbSQL.AppendFormat(" ImageWidth = {0},", objcc_AttachmentEN.ImageWidth); //图像宽
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadDate))
 {
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadPerson))
 {
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadPerson = '{0}',", strUploadPerson); //上传人
 }
 else
 {
 sbSQL.Append(" UploadPerson = null,"); //上传人
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableNameKey))
 {
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableNameKey = '{0}',", strTableNameKey); //主表主键值
 }
 else
 {
 sbSQL.Append(" TableNameKey = null,"); //主表主键值
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.IdResourceType))
 {
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResourceType = '{0}',", strIdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdDate))
 {
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdUserId))
 {
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Memo))
 {
 if (objcc_AttachmentEN.Memo !=  null)
 {
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_AttachmentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_AttachmentEN objcc_AttachmentEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_AttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Attachment Set ");
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableName))
 {
 if (objcc_AttachmentEN.TableName !=  null)
 {
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableName = '{0}',", strTableName); //主表表名
 }
 else
 {
 sbSQL.Append(" TableName = null,"); //主表表名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileName))
 {
 if (objcc_AttachmentEN.FileName !=  null)
 {
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Extension))
 {
 if (objcc_AttachmentEN.Extension !=  null)
 {
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FilePath))
 {
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objcc_AttachmentEN.FileSize); //文件大小
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSizeUnit))
 {
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageHeight))
 {
 sbSQL.AppendFormat(" ImageHeight = {0},", objcc_AttachmentEN.ImageHeight); //图像高
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageWidth))
 {
 sbSQL.AppendFormat(" ImageWidth = {0},", objcc_AttachmentEN.ImageWidth); //图像宽
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadDate))
 {
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadPerson))
 {
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadPerson = '{0}',", strUploadPerson); //上传人
 }
 else
 {
 sbSQL.Append(" UploadPerson = null,"); //上传人
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableNameKey))
 {
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableNameKey = '{0}',", strTableNameKey); //主表主键值
 }
 else
 {
 sbSQL.Append(" TableNameKey = null,"); //主表主键值
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.IdResourceType))
 {
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResourceType = '{0}',", strIdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdDate))
 {
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdUserId))
 {
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Memo))
 {
 if (objcc_AttachmentEN.Memo !=  null)
 {
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_AttachmentEN objcc_AttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_AttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_AttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Attachment Set ");
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableName))
 {
 if (objcc_AttachmentEN.TableName !=  null)
 {
 var strTableName = objcc_AttachmentEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableName, concc_Attachment.TableName); //主表表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.TableName); //主表表名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileName))
 {
 if (objcc_AttachmentEN.FileName !=  null)
 {
 var strFileName = objcc_AttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, concc_Attachment.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FileName); //文件名称
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Extension))
 {
 if (objcc_AttachmentEN.Extension !=  null)
 {
 var strExtension = objcc_AttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, concc_Attachment.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.Extension); //扩展名
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FilePath))
 {
 if (objcc_AttachmentEN.FilePath !=  null)
 {
 var strFilePath = objcc_AttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, concc_Attachment.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FilePath); //文件路径
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSize))
 {
 if (objcc_AttachmentEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_AttachmentEN.FileSize, concc_Attachment.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FileSize); //文件大小
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.FileSizeUnit))
 {
 if (objcc_AttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objcc_AttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, concc_Attachment.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageHeight))
 {
 if (objcc_AttachmentEN.ImageHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_AttachmentEN.ImageHeight, concc_Attachment.ImageHeight); //图像高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.ImageHeight); //图像高
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.ImageWidth))
 {
 if (objcc_AttachmentEN.ImageWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_AttachmentEN.ImageWidth, concc_Attachment.ImageWidth); //图像宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.ImageWidth); //图像宽
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadDate))
 {
 if (objcc_AttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_AttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_Attachment.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UploadDate); //上传时间
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UploadPerson))
 {
 if (objcc_AttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objcc_AttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadPerson, concc_Attachment.UploadPerson); //上传人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UploadPerson); //上传人
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.TableNameKey))
 {
 if (objcc_AttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objcc_AttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableNameKey, concc_Attachment.TableNameKey); //主表主键值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.TableNameKey); //主表主键值
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.IdResourceType))
 {
 if (objcc_AttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objcc_AttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResourceType, concc_Attachment.IdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.IdResourceType); //资源类型流水号
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdDate))
 {
 if (objcc_AttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_AttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Attachment.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UpdDate); //修改日期
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.UpdUserId))
 {
 if (objcc_AttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_AttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Attachment.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_AttachmentEN.IsUpdated(concc_Attachment.Memo))
 {
 if (objcc_AttachmentEN.Memo !=  null)
 {
 var strMemo = objcc_AttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Attachment.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Attachment.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AttachmentID = {0}", objcc_AttachmentEN.AttachmentID); 
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
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngAttachmentID) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngAttachmentID,
};
 objSQL.ExecSP("cc_Attachment_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngAttachmentID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
//删除cc_Attachment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Attachment where AttachmentID = " + ""+ lngAttachmentID+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_Attachment(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
//删除cc_Attachment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Attachment where AttachmentID in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngAttachmentID) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
//删除cc_Attachment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Attachment where AttachmentID = " + ""+ lngAttachmentID+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_Attachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_AttachmentDA: Delcc_Attachment)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Attachment where " + strCondition ;
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
public bool Delcc_AttachmentWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_AttachmentDA: Delcc_AttachmentWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Attachment where " + strCondition ;
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
 /// <param name = "objcc_AttachmentENS">源对象</param>
 /// <param name = "objcc_AttachmentENT">目标对象</param>
public void CopyTo(clscc_AttachmentEN objcc_AttachmentENS, clscc_AttachmentEN objcc_AttachmentENT)
{
objcc_AttachmentENT.AttachmentID = objcc_AttachmentENS.AttachmentID; //附件流水号
objcc_AttachmentENT.TableName = objcc_AttachmentENS.TableName; //主表表名
objcc_AttachmentENT.FileName = objcc_AttachmentENS.FileName; //文件名称
objcc_AttachmentENT.Extension = objcc_AttachmentENS.Extension; //扩展名
objcc_AttachmentENT.FilePath = objcc_AttachmentENS.FilePath; //文件路径
objcc_AttachmentENT.FileSize = objcc_AttachmentENS.FileSize; //文件大小
objcc_AttachmentENT.FileSizeUnit = objcc_AttachmentENS.FileSizeUnit; //文件大小单位
objcc_AttachmentENT.ImageHeight = objcc_AttachmentENS.ImageHeight; //图像高
objcc_AttachmentENT.ImageWidth = objcc_AttachmentENS.ImageWidth; //图像宽
objcc_AttachmentENT.UploadDate = objcc_AttachmentENS.UploadDate; //上传时间
objcc_AttachmentENT.UploadPerson = objcc_AttachmentENS.UploadPerson; //上传人
objcc_AttachmentENT.TableNameKey = objcc_AttachmentENS.TableNameKey; //主表主键值
objcc_AttachmentENT.IdResourceType = objcc_AttachmentENS.IdResourceType; //资源类型流水号
objcc_AttachmentENT.UpdDate = objcc_AttachmentENS.UpdDate; //修改日期
objcc_AttachmentENT.UpdUserId = objcc_AttachmentENS.UpdUserId; //修改用户Id
objcc_AttachmentENT.Memo = objcc_AttachmentENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_AttachmentEN objcc_AttachmentEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_AttachmentEN.FilePath, concc_Attachment.FilePath);
clsCheckSql.CheckFieldNotNull(objcc_AttachmentEN.UploadDate, concc_Attachment.UploadDate);
clsCheckSql.CheckFieldNotNull(objcc_AttachmentEN.TableNameKey, concc_Attachment.TableNameKey);
clsCheckSql.CheckFieldNotNull(objcc_AttachmentEN.IdResourceType, concc_Attachment.IdResourceType);
clsCheckSql.CheckFieldNotNull(objcc_AttachmentEN.UpdDate, concc_Attachment.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.TableName, 100, concc_Attachment.TableName);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FileName, 500, concc_Attachment.FileName);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.Extension, 10, concc_Attachment.Extension);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FilePath, 500, concc_Attachment.FilePath);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FileSizeUnit, 10, concc_Attachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UploadDate, 20, concc_Attachment.UploadDate);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UploadPerson, 20, concc_Attachment.UploadPerson);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.TableNameKey, 20, concc_Attachment.TableNameKey);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.IdResourceType, 4, concc_Attachment.IdResourceType);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UpdDate, 20, concc_Attachment.UpdDate);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UpdUserId, 20, concc_Attachment.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.Memo, 1000, concc_Attachment.Memo);
//检查字段外键固定长度
 objcc_AttachmentEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_AttachmentEN objcc_AttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.TableName, 100, concc_Attachment.TableName);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FileName, 500, concc_Attachment.FileName);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.Extension, 10, concc_Attachment.Extension);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FilePath, 500, concc_Attachment.FilePath);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FileSizeUnit, 10, concc_Attachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UploadDate, 20, concc_Attachment.UploadDate);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UploadPerson, 20, concc_Attachment.UploadPerson);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.TableNameKey, 20, concc_Attachment.TableNameKey);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.IdResourceType, 4, concc_Attachment.IdResourceType);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UpdDate, 20, concc_Attachment.UpdDate);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UpdUserId, 20, concc_Attachment.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.Memo, 1000, concc_Attachment.Memo);
//检查外键字段长度
 objcc_AttachmentEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_AttachmentEN objcc_AttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.TableName, 100, concc_Attachment.TableName);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FileName, 500, concc_Attachment.FileName);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.Extension, 10, concc_Attachment.Extension);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FilePath, 500, concc_Attachment.FilePath);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.FileSizeUnit, 10, concc_Attachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UploadDate, 20, concc_Attachment.UploadDate);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UploadPerson, 20, concc_Attachment.UploadPerson);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.TableNameKey, 20, concc_Attachment.TableNameKey);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.IdResourceType, 4, concc_Attachment.IdResourceType);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UpdDate, 20, concc_Attachment.UpdDate);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.UpdUserId, 20, concc_Attachment.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_AttachmentEN.Memo, 1000, concc_Attachment.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.TableName, concc_Attachment.TableName);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.FileName, concc_Attachment.FileName);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.Extension, concc_Attachment.Extension);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.FilePath, concc_Attachment.FilePath);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.FileSizeUnit, concc_Attachment.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.UploadDate, concc_Attachment.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.UploadPerson, concc_Attachment.UploadPerson);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.TableNameKey, concc_Attachment.TableNameKey);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.IdResourceType, concc_Attachment.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.UpdDate, concc_Attachment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.UpdUserId, concc_Attachment.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_AttachmentEN.Memo, concc_Attachment.Memo);
//检查外键字段长度
 objcc_AttachmentEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_Attachment(附件),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_AttachmentEN objcc_AttachmentEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_AttachmentEN.TableName == null)
{
 sbCondition.AppendFormat(" and TableName is null");
}
else
{
 sbCondition.AppendFormat(" and TableName = '{0}'", objcc_AttachmentEN.TableName);
}
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objcc_AttachmentEN.TableNameKey);
 if (objcc_AttachmentEN.FileName == null)
{
 sbCondition.AppendFormat(" and FileName is null");
}
else
{
 sbCondition.AppendFormat(" and FileName = '{0}'", objcc_AttachmentEN.FileName);
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_AttachmentEN._CurrTabName);
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_AttachmentEN._CurrTabName, strCondition);
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
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
 objSQL = clscc_AttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvtz_ContentAttachmentDA
 表名:vtz_ContentAttachment(01120208)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:20
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
 /// v内容附件(vtz_ContentAttachment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvtz_ContentAttachmentDA : clsCommBase4DA
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
 return clsvtz_ContentAttachmentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvtz_ContentAttachmentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvtz_ContentAttachmentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvtz_ContentAttachmentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvtz_ContentAttachmentEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vtz_ContentAttachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable_vtz_ContentAttachment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vtz_ContentAttachment.* from vtz_ContentAttachment Left Join {1} on {2} where {3} and vtz_ContentAttachment.mId not in (Select top {5} vtz_ContentAttachment.mId from vtz_ContentAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1} and mId not in (Select top {2} mId from vtz_ContentAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1} and mId not in (Select top {3} mId from vtz_ContentAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vtz_ContentAttachment.* from vtz_ContentAttachment Left Join {1} on {2} where {3} and vtz_ContentAttachment.mId not in (Select top {5} vtz_ContentAttachment.mId from vtz_ContentAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1} and mId not in (Select top {2} mId from vtz_ContentAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vtz_ContentAttachment where {1} and mId not in (Select top {3} mId from vtz_ContentAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvtz_ContentAttachmentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA:GetObjLst)", objException.Message));
}
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = TransNullToInt(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: GetObjLst)", objException.Message));
}
objvtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvtz_ContentAttachmentEN);
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
public List<clsvtz_ContentAttachmentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = TransNullToInt(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: GetObjLst)", objException.Message));
}
objvtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvtz_ContentAttachment(ref clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where mId = " + ""+ objvtz_ContentAttachmentEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvtz_ContentAttachmentEN.mId = TransNullToInt(objDT.Rows[0][convtz_ContentAttachment.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvtz_ContentAttachmentEN.ContentTypeId = objDT.Rows[0][convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.ContentTypeName = objDT.Rows[0][convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvtz_ContentAttachmentEN.TableName = objDT.Rows[0][convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvtz_ContentAttachmentEN.FldName = objDT.Rows[0][convtz_ContentAttachment.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvtz_ContentAttachmentEN.TableNameKey = objDT.Rows[0][convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objvtz_ContentAttachmentEN.OrderNum = TransNullToInt(objDT.Rows[0][convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.AttachmentTitle = objDT.Rows[0][convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题(字段类型:varchar,字段长度:100,是否可空:False)
 objvtz_ContentAttachmentEN.IdResourceType = objDT.Rows[0][convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvtz_ContentAttachmentEN.ResourceTypeID = objDT.Rows[0][convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvtz_ContentAttachmentEN.ResourceTypeName = objDT.Rows[0][convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvtz_ContentAttachmentEN.TextContent = objDT.Rows[0][convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容(字段类型:varchar,字段长度:8000,是否可空:False)
 objvtz_ContentAttachmentEN.FileName = objDT.Rows[0][convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvtz_ContentAttachmentEN.Extension = objDT.Rows[0][convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvtz_ContentAttachmentEN.FilePath = objDT.Rows[0][convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvtz_ContentAttachmentEN.PdfFilePath = objDT.Rows[0][convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvtz_ContentAttachmentEN.SwfFilePath = objDT.Rows[0][convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvtz_ContentAttachmentEN.FileSize = TransNullToDouble(objDT.Rows[0][convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objvtz_ContentAttachmentEN.FileSizeUnit = objDT.Rows[0][convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objvtz_ContentAttachmentEN.ImageHeight = TransNullToInt(objDT.Rows[0][convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.ImageWidth = TransNullToInt(objDT.Rows[0][convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.UploadDate = objDT.Rows[0][convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objvtz_ContentAttachmentEN.UploadPerson = objDT.Rows[0][convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objvtz_ContentAttachmentEN.UpdDate = objDT.Rows[0][convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvtz_ContentAttachmentEN.UpdUserId = objDT.Rows[0][convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvtz_ContentAttachmentEN.Memo = objDT.Rows[0][convtz_ContentAttachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvtz_ContentAttachmentEN.CourseId = objDT.Rows[0][convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: Getvtz_ContentAttachment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvtz_ContentAttachmentEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
 objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题(字段类型:varchar,字段长度:100,是否可空:False)
 objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容(字段类型:varchar,字段长度:8000,是否可空:False)
 objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
 objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: GetObjBymId)", objException.Message));
}
return objvtz_ContentAttachmentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvtz_ContentAttachmentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vtz_ContentAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN()
{
mId = TransNullToInt(objRow[convtz_ContentAttachment.mId].ToString().Trim()), //mId
ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(), //内容类型Id
ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(), //内容类型名
TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(), //主表表名
FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(), //字段名
TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(), //主表主键值
OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()), //序号
AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(), //附件标题
IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(), //资源类型名称
TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(), //文本内容
FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(), //文件名称
Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(), //扩展名
FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(), //文件路径
PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(), //Pdf文件路径
SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(), //Swf文件路径
FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()), //文件大小
FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(), //文件大小单位
ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()), //图像高
ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()), //图像宽
UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(), //上传时间
UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(), //上传人
UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(), //备注
CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim() //课程Id
};
objvtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvtz_ContentAttachmentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvtz_ContentAttachmentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = TransNullToInt(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: GetObjByDataRowvtz_ContentAttachment)", objException.Message));
}
objvtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvtz_ContentAttachmentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvtz_ContentAttachmentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = TransNullToInt(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvtz_ContentAttachmentDA: GetObjByDataRow)", objException.Message));
}
objvtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvtz_ContentAttachmentEN;
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
objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvtz_ContentAttachmentEN._CurrTabName, convtz_ContentAttachment.mId, 8, "");
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
objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvtz_ContentAttachmentEN._CurrTabName, convtz_ContentAttachment.mId, 8, strPrefix);
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vtz_ContentAttachment where " + strCondition;
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vtz_ContentAttachment where " + strCondition;
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vtz_ContentAttachment", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvtz_ContentAttachmentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vtz_ContentAttachment", strCondition))
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
objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vtz_ContentAttachment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentENS">源对象</param>
 /// <param name = "objvtz_ContentAttachmentENT">目标对象</param>
public void CopyTo(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENS, clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENT)
{
objvtz_ContentAttachmentENT.mId = objvtz_ContentAttachmentENS.mId; //mId
objvtz_ContentAttachmentENT.ContentTypeId = objvtz_ContentAttachmentENS.ContentTypeId; //内容类型Id
objvtz_ContentAttachmentENT.ContentTypeName = objvtz_ContentAttachmentENS.ContentTypeName; //内容类型名
objvtz_ContentAttachmentENT.TableName = objvtz_ContentAttachmentENS.TableName; //主表表名
objvtz_ContentAttachmentENT.FldName = objvtz_ContentAttachmentENS.FldName; //字段名
objvtz_ContentAttachmentENT.TableNameKey = objvtz_ContentAttachmentENS.TableNameKey; //主表主键值
objvtz_ContentAttachmentENT.OrderNum = objvtz_ContentAttachmentENS.OrderNum; //序号
objvtz_ContentAttachmentENT.AttachmentTitle = objvtz_ContentAttachmentENS.AttachmentTitle; //附件标题
objvtz_ContentAttachmentENT.IdResourceType = objvtz_ContentAttachmentENS.IdResourceType; //资源类型流水号
objvtz_ContentAttachmentENT.ResourceTypeID = objvtz_ContentAttachmentENS.ResourceTypeID; //资源类型ID
objvtz_ContentAttachmentENT.ResourceTypeName = objvtz_ContentAttachmentENS.ResourceTypeName; //资源类型名称
objvtz_ContentAttachmentENT.TextContent = objvtz_ContentAttachmentENS.TextContent; //文本内容
objvtz_ContentAttachmentENT.FileName = objvtz_ContentAttachmentENS.FileName; //文件名称
objvtz_ContentAttachmentENT.Extension = objvtz_ContentAttachmentENS.Extension; //扩展名
objvtz_ContentAttachmentENT.FilePath = objvtz_ContentAttachmentENS.FilePath; //文件路径
objvtz_ContentAttachmentENT.PdfFilePath = objvtz_ContentAttachmentENS.PdfFilePath; //Pdf文件路径
objvtz_ContentAttachmentENT.SwfFilePath = objvtz_ContentAttachmentENS.SwfFilePath; //Swf文件路径
objvtz_ContentAttachmentENT.FileSize = objvtz_ContentAttachmentENS.FileSize; //文件大小
objvtz_ContentAttachmentENT.FileSizeUnit = objvtz_ContentAttachmentENS.FileSizeUnit; //文件大小单位
objvtz_ContentAttachmentENT.ImageHeight = objvtz_ContentAttachmentENS.ImageHeight; //图像高
objvtz_ContentAttachmentENT.ImageWidth = objvtz_ContentAttachmentENS.ImageWidth; //图像宽
objvtz_ContentAttachmentENT.UploadDate = objvtz_ContentAttachmentENS.UploadDate; //上传时间
objvtz_ContentAttachmentENT.UploadPerson = objvtz_ContentAttachmentENS.UploadPerson; //上传人
objvtz_ContentAttachmentENT.UpdDate = objvtz_ContentAttachmentENS.UpdDate; //修改日期
objvtz_ContentAttachmentENT.UpdUserId = objvtz_ContentAttachmentENS.UpdUserId; //修改用户Id
objvtz_ContentAttachmentENT.Memo = objvtz_ContentAttachmentENS.Memo; //备注
objvtz_ContentAttachmentENT.CourseId = objvtz_ContentAttachmentENS.CourseId; //课程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.ContentTypeId, 4, convtz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.ContentTypeName, 50, convtz_ContentAttachment.ContentTypeName);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.TableName, 100, convtz_ContentAttachment.TableName);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.FldName, 50, convtz_ContentAttachment.FldName);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.TableNameKey, 20, convtz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.AttachmentTitle, 100, convtz_ContentAttachment.AttachmentTitle);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.IdResourceType, 4, convtz_ContentAttachment.IdResourceType);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.ResourceTypeID, 4, convtz_ContentAttachment.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.ResourceTypeName, 50, convtz_ContentAttachment.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.TextContent, 8000, convtz_ContentAttachment.TextContent);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.FileName, 500, convtz_ContentAttachment.FileName);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.Extension, 10, convtz_ContentAttachment.Extension);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.FilePath, 500, convtz_ContentAttachment.FilePath);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.PdfFilePath, 500, convtz_ContentAttachment.PdfFilePath);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.SwfFilePath, 500, convtz_ContentAttachment.SwfFilePath);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.FileSizeUnit, 10, convtz_ContentAttachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.UploadDate, 20, convtz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.UploadPerson, 20, convtz_ContentAttachment.UploadPerson);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.UpdDate, 20, convtz_ContentAttachment.UpdDate);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.UpdUserId, 20, convtz_ContentAttachment.UpdUserId);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.Memo, 1000, convtz_ContentAttachment.Memo);
clsCheckSql.CheckFieldLen(objvtz_ContentAttachmentEN.CourseId, 8, convtz_ContentAttachment.CourseId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.ContentTypeId, convtz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.ContentTypeName, convtz_ContentAttachment.ContentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.TableName, convtz_ContentAttachment.TableName);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.FldName, convtz_ContentAttachment.FldName);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.TableNameKey, convtz_ContentAttachment.TableNameKey);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.AttachmentTitle, convtz_ContentAttachment.AttachmentTitle);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.IdResourceType, convtz_ContentAttachment.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.ResourceTypeID, convtz_ContentAttachment.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.ResourceTypeName, convtz_ContentAttachment.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.TextContent, convtz_ContentAttachment.TextContent);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.FileName, convtz_ContentAttachment.FileName);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.Extension, convtz_ContentAttachment.Extension);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.FilePath, convtz_ContentAttachment.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.PdfFilePath, convtz_ContentAttachment.PdfFilePath);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.SwfFilePath, convtz_ContentAttachment.SwfFilePath);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.FileSizeUnit, convtz_ContentAttachment.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.UploadDate, convtz_ContentAttachment.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.UploadPerson, convtz_ContentAttachment.UploadPerson);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.UpdDate, convtz_ContentAttachment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.UpdUserId, convtz_ContentAttachment.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.Memo, convtz_ContentAttachment.Memo);
clsCheckSql.CheckSqlInjection4Field(objvtz_ContentAttachmentEN.CourseId, convtz_ContentAttachment.CourseId);
//检查外键字段长度
 objvtz_ContentAttachmentEN._IsCheckProperty = true;
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvtz_ContentAttachmentEN._CurrTabName);
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvtz_ContentAttachmentEN._CurrTabName, strCondition);
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
 objSQL = clsvtz_ContentAttachmentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
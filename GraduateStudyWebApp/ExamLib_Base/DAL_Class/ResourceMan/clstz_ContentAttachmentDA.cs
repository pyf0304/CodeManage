
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_ContentAttachmentDA
 表名:tz_ContentAttachment(01120207)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// 内容附件(tz_ContentAttachment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clstz_ContentAttachmentDA : clsCommBase4DA
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
 return clstz_ContentAttachmentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clstz_ContentAttachmentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clstz_ContentAttachmentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clstz_ContentAttachmentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clstz_ContentAttachmentEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_tz_ContentAttachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable_tz_ContentAttachment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} tz_ContentAttachment.* from tz_ContentAttachment Left Join {1} on {2} where {3} and tz_ContentAttachment.mId not in (Select top {5} tz_ContentAttachment.mId from tz_ContentAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1} and mId not in (Select top {2} mId from tz_ContentAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1} and mId not in (Select top {3} mId from tz_ContentAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} tz_ContentAttachment.* from tz_ContentAttachment Left Join {1} on {2} where {3} and tz_ContentAttachment.mId not in (Select top {5} tz_ContentAttachment.mId from tz_ContentAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1} and mId not in (Select top {2} mId from tz_ContentAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from tz_ContentAttachment where {1} and mId not in (Select top {3} mId from tz_ContentAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clstz_ContentAttachmentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA:GetObjLst)", objException.Message));
}
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = TransNullToInt(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clstz_ContentAttachmentDA: GetObjLst)", objException.Message));
}
objtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objtz_ContentAttachmentEN);
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
public List<clstz_ContentAttachmentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA:GetObjLstByTabName)", objException.Message));
}
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = TransNullToInt(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clstz_ContentAttachmentDA: GetObjLst)", objException.Message));
}
objtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Gettz_ContentAttachment(ref clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where mId = " + ""+ objtz_ContentAttachmentEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objtz_ContentAttachmentEN.mId = TransNullToInt(objDT.Rows[0][contz_ContentAttachment.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objtz_ContentAttachmentEN.ContentTypeId = objDT.Rows[0][contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id(字段类型:char,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.TableNameKey = objDT.Rows[0][contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objtz_ContentAttachmentEN.OrderNum = TransNullToInt(objDT.Rows[0][contz_ContentAttachment.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.AttachmentTitle = objDT.Rows[0][contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题(字段类型:varchar,字段长度:100,是否可空:False)
 objtz_ContentAttachmentEN.IdResourceType = objDT.Rows[0][contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objtz_ContentAttachmentEN.TextContent = objDT.Rows[0][contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容(字段类型:varchar,字段长度:8000,是否可空:False)
 objtz_ContentAttachmentEN.FileName = objDT.Rows[0][contz_ContentAttachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objtz_ContentAttachmentEN.Extension = objDT.Rows[0][contz_ContentAttachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objtz_ContentAttachmentEN.FilePath = objDT.Rows[0][contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objtz_ContentAttachmentEN.PdfFilePath = objDT.Rows[0][contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objtz_ContentAttachmentEN.SwfFilePath = objDT.Rows[0][contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objtz_ContentAttachmentEN.FileSize = TransNullToDouble(objDT.Rows[0][contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objtz_ContentAttachmentEN.FileSizeUnit = objDT.Rows[0][contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objtz_ContentAttachmentEN.ImageHeight = TransNullToInt(objDT.Rows[0][contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.ImageWidth = TransNullToInt(objDT.Rows[0][contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.UploadDate = objDT.Rows[0][contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objtz_ContentAttachmentEN.UploadPerson = objDT.Rows[0][contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objtz_ContentAttachmentEN.UpdDate = objDT.Rows[0][contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_ContentAttachmentEN.UpdUserId = objDT.Rows[0][contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_ContentAttachmentEN.Memo = objDT.Rows[0][contz_ContentAttachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objtz_ContentAttachmentEN.CourseId = objDT.Rows[0][contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clstz_ContentAttachmentDA: Gettz_ContentAttachment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clstz_ContentAttachmentEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
 objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id(字段类型:char,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题(字段类型:varchar,字段长度:100,是否可空:False)
 objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容(字段类型:varchar,字段长度:8000,是否可空:False)
 objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径(字段类型:varchar,字段长度:500,是否可空:True)
 objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
 objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clstz_ContentAttachmentDA: GetObjBymId)", objException.Message));
}
return objtz_ContentAttachmentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clstz_ContentAttachmentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN()
{
mId = TransNullToInt(objRow[contz_ContentAttachment.mId].ToString().Trim()), //mId
ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(), //内容类型Id
TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(), //主表主键值
OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()), //序号
AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(), //附件标题
IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(), //资源类型流水号
TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(), //文本内容
FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(), //文件名称
Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(), //扩展名
FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(), //文件路径
PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(), //Pdf文件路径
SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(), //Swf文件路径
FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[contz_ContentAttachment.FileSize].ToString().Trim()), //文件大小
FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(), //文件大小单位
ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()), //图像高
ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()), //图像宽
UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(), //上传时间
UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(), //上传人
UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(), //备注
CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim() //课程Id
};
objtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objtz_ContentAttachmentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clstz_ContentAttachmentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clstz_ContentAttachmentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = TransNullToInt(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clstz_ContentAttachmentDA: GetObjByDataRowtz_ContentAttachment)", objException.Message));
}
objtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objtz_ContentAttachmentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clstz_ContentAttachmentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = TransNullToInt(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clstz_ContentAttachmentDA: GetObjByDataRow)", objException.Message));
}
objtz_ContentAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objtz_ContentAttachmentEN;
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
objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clstz_ContentAttachmentEN._CurrTabName, contz_ContentAttachment.mId, 8, "");
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
objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clstz_ContentAttachmentEN._CurrTabName, contz_ContentAttachment.mId, 8, strPrefix);
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from tz_ContentAttachment where " + strCondition;
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from tz_ContentAttachment where " + strCondition;
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("tz_ContentAttachment", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("tz_ContentAttachment", strCondition))
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
objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("tz_ContentAttachment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
 {
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_ContentAttachmentEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "tz_ContentAttachment");
objRow = objDS.Tables["tz_ContentAttachment"].NewRow();
objRow[contz_ContentAttachment.ContentTypeId] = objtz_ContentAttachmentEN.ContentTypeId; //内容类型Id
objRow[contz_ContentAttachment.TableNameKey] = objtz_ContentAttachmentEN.TableNameKey; //主表主键值
objRow[contz_ContentAttachment.OrderNum] = objtz_ContentAttachmentEN.OrderNum; //序号
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  "")
 {
objRow[contz_ContentAttachment.AttachmentTitle] = objtz_ContentAttachmentEN.AttachmentTitle; //附件标题
 }
objRow[contz_ContentAttachment.IdResourceType] = objtz_ContentAttachmentEN.IdResourceType; //资源类型流水号
 if (objtz_ContentAttachmentEN.TextContent !=  "")
 {
objRow[contz_ContentAttachment.TextContent] = objtz_ContentAttachmentEN.TextContent; //文本内容
 }
 if (objtz_ContentAttachmentEN.FileName !=  "")
 {
objRow[contz_ContentAttachment.FileName] = objtz_ContentAttachmentEN.FileName; //文件名称
 }
 if (objtz_ContentAttachmentEN.Extension !=  "")
 {
objRow[contz_ContentAttachment.Extension] = objtz_ContentAttachmentEN.Extension; //扩展名
 }
 if (objtz_ContentAttachmentEN.FilePath !=  "")
 {
objRow[contz_ContentAttachment.FilePath] = objtz_ContentAttachmentEN.FilePath; //文件路径
 }
 if (objtz_ContentAttachmentEN.PdfFilePath !=  "")
 {
objRow[contz_ContentAttachment.PdfFilePath] = objtz_ContentAttachmentEN.PdfFilePath; //Pdf文件路径
 }
 if (objtz_ContentAttachmentEN.SwfFilePath !=  "")
 {
objRow[contz_ContentAttachment.SwfFilePath] = objtz_ContentAttachmentEN.SwfFilePath; //Swf文件路径
 }
objRow[contz_ContentAttachment.FileSize] = objtz_ContentAttachmentEN.FileSize; //文件大小
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  "")
 {
objRow[contz_ContentAttachment.FileSizeUnit] = objtz_ContentAttachmentEN.FileSizeUnit; //文件大小单位
 }
objRow[contz_ContentAttachment.ImageHeight] = objtz_ContentAttachmentEN.ImageHeight; //图像高
objRow[contz_ContentAttachment.ImageWidth] = objtz_ContentAttachmentEN.ImageWidth; //图像宽
objRow[contz_ContentAttachment.UploadDate] = objtz_ContentAttachmentEN.UploadDate; //上传时间
 if (objtz_ContentAttachmentEN.UploadPerson !=  "")
 {
objRow[contz_ContentAttachment.UploadPerson] = objtz_ContentAttachmentEN.UploadPerson; //上传人
 }
objRow[contz_ContentAttachment.UpdDate] = objtz_ContentAttachmentEN.UpdDate; //修改日期
 if (objtz_ContentAttachmentEN.UpdUserId !=  "")
 {
objRow[contz_ContentAttachment.UpdUserId] = objtz_ContentAttachmentEN.UpdUserId; //修改用户Id
 }
 if (objtz_ContentAttachmentEN.Memo !=  "")
 {
objRow[contz_ContentAttachment.Memo] = objtz_ContentAttachmentEN.Memo; //备注
 }
 if (objtz_ContentAttachmentEN.CourseId !=  "")
 {
objRow[contz_ContentAttachment.CourseId] = objtz_ContentAttachmentEN.CourseId; //课程Id
 }
objDS.Tables[clstz_ContentAttachmentEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clstz_ContentAttachmentEN._CurrTabName);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_ContentAttachmentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ContentTypeId);
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContentTypeId + "'");
 }
 
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TableNameKey);
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.OrderNum);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.OrderNum.ToString());
 }
 
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.AttachmentTitle);
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttachmentTitle + "'");
 }
 
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.IdResourceType);
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TextContent);
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileName);
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Extension);
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FilePath);
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.PdfFilePath);
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.SwfFilePath);
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSize);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.FileSize.ToString());
 }
 
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSizeUnit);
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageHeight);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageHeight.ToString());
 }
 
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageWidth);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageWidth.ToString());
 }
 
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadDate);
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadPerson);
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdDate);
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdUserId);
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Memo);
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.CourseId);
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_ContentAttachment");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_ContentAttachmentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ContentTypeId);
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContentTypeId + "'");
 }
 
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TableNameKey);
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.OrderNum);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.OrderNum.ToString());
 }
 
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.AttachmentTitle);
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttachmentTitle + "'");
 }
 
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.IdResourceType);
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TextContent);
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileName);
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Extension);
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FilePath);
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.PdfFilePath);
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.SwfFilePath);
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSize);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.FileSize.ToString());
 }
 
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSizeUnit);
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageHeight);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageHeight.ToString());
 }
 
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageWidth);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageWidth.ToString());
 }
 
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadDate);
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadPerson);
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdDate);
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdUserId);
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Memo);
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.CourseId);
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_ContentAttachment");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_ContentAttachmentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ContentTypeId);
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContentTypeId + "'");
 }
 
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TableNameKey);
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.OrderNum);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.OrderNum.ToString());
 }
 
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.AttachmentTitle);
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttachmentTitle + "'");
 }
 
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.IdResourceType);
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TextContent);
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileName);
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Extension);
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FilePath);
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.PdfFilePath);
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.SwfFilePath);
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSize);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.FileSize.ToString());
 }
 
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSizeUnit);
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageHeight);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageHeight.ToString());
 }
 
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageWidth);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageWidth.ToString());
 }
 
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadDate);
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadPerson);
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdDate);
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdUserId);
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Memo);
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.CourseId);
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_ContentAttachment");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objtz_ContentAttachmentEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ContentTypeId);
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContentTypeId + "'");
 }
 
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TableNameKey);
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameKey + "'");
 }
 
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.OrderNum);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.OrderNum.ToString());
 }
 
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.AttachmentTitle);
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttachmentTitle + "'");
 }
 
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.IdResourceType);
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.TextContent);
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextContent + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileName);
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Extension);
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FilePath);
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.PdfFilePath);
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.SwfFilePath);
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSwfFilePath + "'");
 }
 
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSize);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.FileSize.ToString());
 }
 
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.FileSizeUnit);
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageHeight);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageHeight.ToString());
 }
 
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.ImageWidth);
 arrValueListForInsert.Add(objtz_ContentAttachmentEN.ImageWidth.ToString());
 }
 
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadDate);
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UploadPerson);
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadPerson + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdDate);
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.UpdUserId);
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.Memo);
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(contz_ContentAttachment.CourseId);
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into tz_ContentAttachment");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewtz_ContentAttachments(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "tz_ContentAttachment");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clstz_ContentAttachmentEN._CurrTabName ].NewRow();
objRow[contz_ContentAttachment.ContentTypeId] = oRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objRow[contz_ContentAttachment.TableNameKey] = oRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objRow[contz_ContentAttachment.OrderNum] = oRow[contz_ContentAttachment.OrderNum].ToString().Trim(); //序号
objRow[contz_ContentAttachment.AttachmentTitle] = oRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objRow[contz_ContentAttachment.IdResourceType] = oRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objRow[contz_ContentAttachment.TextContent] = oRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objRow[contz_ContentAttachment.FileName] = oRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objRow[contz_ContentAttachment.Extension] = oRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objRow[contz_ContentAttachment.FilePath] = oRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objRow[contz_ContentAttachment.PdfFilePath] = oRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objRow[contz_ContentAttachment.SwfFilePath] = oRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objRow[contz_ContentAttachment.FileSize] = oRow[contz_ContentAttachment.FileSize].ToString().Trim(); //文件大小
objRow[contz_ContentAttachment.FileSizeUnit] = oRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objRow[contz_ContentAttachment.ImageHeight] = oRow[contz_ContentAttachment.ImageHeight].ToString().Trim(); //图像高
objRow[contz_ContentAttachment.ImageWidth] = oRow[contz_ContentAttachment.ImageWidth].ToString().Trim(); //图像宽
objRow[contz_ContentAttachment.UploadDate] = oRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objRow[contz_ContentAttachment.UploadPerson] = oRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objRow[contz_ContentAttachment.UpdDate] = oRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objRow[contz_ContentAttachment.UpdUserId] = oRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objRow[contz_ContentAttachment.Memo] = oRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objRow[contz_ContentAttachment.CourseId] = oRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
 objDS.Tables[clstz_ContentAttachmentEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clstz_ContentAttachmentEN._CurrTabName);
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_ContentAttachmentEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from tz_ContentAttachment where mId = " + ""+ objtz_ContentAttachmentEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clstz_ContentAttachmentEN._CurrTabName);
if (objDS.Tables[clstz_ContentAttachmentEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objtz_ContentAttachmentEN.mId+"");
return false;
}
objRow = objDS.Tables[clstz_ContentAttachmentEN._CurrTabName].Rows[0];
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ContentTypeId))
 {
objRow[contz_ContentAttachment.ContentTypeId] = objtz_ContentAttachmentEN.ContentTypeId; //内容类型Id
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TableNameKey))
 {
objRow[contz_ContentAttachment.TableNameKey] = objtz_ContentAttachmentEN.TableNameKey; //主表主键值
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.OrderNum))
 {
objRow[contz_ContentAttachment.OrderNum] = objtz_ContentAttachmentEN.OrderNum; //序号
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.AttachmentTitle))
 {
objRow[contz_ContentAttachment.AttachmentTitle] = objtz_ContentAttachmentEN.AttachmentTitle; //附件标题
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.IdResourceType))
 {
objRow[contz_ContentAttachment.IdResourceType] = objtz_ContentAttachmentEN.IdResourceType; //资源类型流水号
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TextContent))
 {
objRow[contz_ContentAttachment.TextContent] = objtz_ContentAttachmentEN.TextContent; //文本内容
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileName))
 {
objRow[contz_ContentAttachment.FileName] = objtz_ContentAttachmentEN.FileName; //文件名称
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Extension))
 {
objRow[contz_ContentAttachment.Extension] = objtz_ContentAttachmentEN.Extension; //扩展名
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FilePath))
 {
objRow[contz_ContentAttachment.FilePath] = objtz_ContentAttachmentEN.FilePath; //文件路径
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.PdfFilePath))
 {
objRow[contz_ContentAttachment.PdfFilePath] = objtz_ContentAttachmentEN.PdfFilePath; //Pdf文件路径
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.SwfFilePath))
 {
objRow[contz_ContentAttachment.SwfFilePath] = objtz_ContentAttachmentEN.SwfFilePath; //Swf文件路径
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSize))
 {
objRow[contz_ContentAttachment.FileSize] = objtz_ContentAttachmentEN.FileSize; //文件大小
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSizeUnit))
 {
objRow[contz_ContentAttachment.FileSizeUnit] = objtz_ContentAttachmentEN.FileSizeUnit; //文件大小单位
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageHeight))
 {
objRow[contz_ContentAttachment.ImageHeight] = objtz_ContentAttachmentEN.ImageHeight; //图像高
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageWidth))
 {
objRow[contz_ContentAttachment.ImageWidth] = objtz_ContentAttachmentEN.ImageWidth; //图像宽
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadDate))
 {
objRow[contz_ContentAttachment.UploadDate] = objtz_ContentAttachmentEN.UploadDate; //上传时间
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadPerson))
 {
objRow[contz_ContentAttachment.UploadPerson] = objtz_ContentAttachmentEN.UploadPerson; //上传人
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdDate))
 {
objRow[contz_ContentAttachment.UpdDate] = objtz_ContentAttachmentEN.UpdDate; //修改日期
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdUserId))
 {
objRow[contz_ContentAttachment.UpdUserId] = objtz_ContentAttachmentEN.UpdUserId; //修改用户Id
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Memo))
 {
objRow[contz_ContentAttachment.Memo] = objtz_ContentAttachmentEN.Memo; //备注
 }
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.CourseId))
 {
objRow[contz_ContentAttachment.CourseId] = objtz_ContentAttachmentEN.CourseId; //课程Id
 }
try
{
objDA.Update(objDS, clstz_ContentAttachmentEN._CurrTabName);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_ContentAttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update tz_ContentAttachment Set ");
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ContentTypeId))
 {
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContentTypeId, contz_ContentAttachment.ContentTypeId); //内容类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ContentTypeId); //内容类型Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TableNameKey))
 {
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableNameKey, contz_ContentAttachment.TableNameKey); //主表主键值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.TableNameKey); //主表主键值
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.OrderNum))
 {
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.OrderNum, contz_ContentAttachment.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.OrderNum); //序号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.AttachmentTitle))
 {
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAttachmentTitle, contz_ContentAttachment.AttachmentTitle); //附件标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.AttachmentTitle); //附件标题
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.IdResourceType))
 {
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResourceType, contz_ContentAttachment.IdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.IdResourceType); //资源类型流水号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TextContent))
 {
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextContent, contz_ContentAttachment.TextContent); //文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.TextContent); //文本内容
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileName))
 {
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, contz_ContentAttachment.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileName); //文件名称
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Extension))
 {
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, contz_ContentAttachment.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.Extension); //扩展名
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FilePath))
 {
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, contz_ContentAttachment.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FilePath); //文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.PdfFilePath))
 {
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfFilePath, contz_ContentAttachment.PdfFilePath); //Pdf文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.PdfFilePath); //Pdf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.SwfFilePath))
 {
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSwfFilePath, contz_ContentAttachment.SwfFilePath); //Swf文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.SwfFilePath); //Swf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSize))
 {
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.FileSize, contz_ContentAttachment.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileSize); //文件大小
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSizeUnit))
 {
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, contz_ContentAttachment.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageHeight))
 {
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageHeight, contz_ContentAttachment.ImageHeight); //图像高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageHeight); //图像高
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageWidth))
 {
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageWidth, contz_ContentAttachment.ImageWidth); //图像宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageWidth); //图像宽
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadDate))
 {
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, contz_ContentAttachment.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UploadDate); //上传时间
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadPerson))
 {
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadPerson, contz_ContentAttachment.UploadPerson); //上传人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UploadPerson); //上传人
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdDate))
 {
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, contz_ContentAttachment.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UpdDate); //修改日期
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdUserId))
 {
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, contz_ContentAttachment.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UpdUserId); //修改用户Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Memo))
 {
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, contz_ContentAttachment.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.Memo); //备注
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.CourseId))
 {
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, contz_ContentAttachment.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.CourseId); //课程Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objtz_ContentAttachmentEN.mId); 
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strCondition)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_ContentAttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update tz_ContentAttachment Set ");
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ContentTypeId))
 {
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContentTypeId = '{0}',", strContentTypeId); //内容类型Id
 }
 else
 {
 sbSQL.Append(" ContentTypeId = null,"); //内容类型Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TableNameKey))
 {
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableNameKey = '{0}',", strTableNameKey); //主表主键值
 }
 else
 {
 sbSQL.Append(" TableNameKey = null,"); //主表主键值
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.OrderNum))
 {
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.OrderNum, contz_ContentAttachment.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.OrderNum); //序号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.AttachmentTitle))
 {
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AttachmentTitle = '{0}',", strAttachmentTitle); //附件标题
 }
 else
 {
 sbSQL.Append(" AttachmentTitle = null,"); //附件标题
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.IdResourceType))
 {
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResourceType = '{0}',", strIdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TextContent))
 {
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextContent = '{0}',", strTextContent); //文本内容
 }
 else
 {
 sbSQL.Append(" TextContent = null,"); //文本内容
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileName))
 {
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Extension))
 {
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FilePath))
 {
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.PdfFilePath))
 {
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfFilePath = '{0}',", strPdfFilePath); //Pdf文件路径
 }
 else
 {
 sbSQL.Append(" PdfFilePath = null,"); //Pdf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.SwfFilePath))
 {
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SwfFilePath = '{0}',", strSwfFilePath); //Swf文件路径
 }
 else
 {
 sbSQL.Append(" SwfFilePath = null,"); //Swf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSize))
 {
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.FileSize, contz_ContentAttachment.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileSize); //文件大小
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSizeUnit))
 {
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageHeight))
 {
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageHeight, contz_ContentAttachment.ImageHeight); //图像高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageHeight); //图像高
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageWidth))
 {
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageWidth, contz_ContentAttachment.ImageWidth); //图像宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageWidth); //图像宽
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadDate))
 {
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadPerson))
 {
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadPerson = '{0}',", strUploadPerson); //上传人
 }
 else
 {
 sbSQL.Append(" UploadPerson = null,"); //上传人
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdDate))
 {
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdUserId))
 {
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Memo))
 {
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.CourseId))
 {
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_ContentAttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update tz_ContentAttachment Set ");
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ContentTypeId))
 {
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContentTypeId = '{0}',", strContentTypeId); //内容类型Id
 }
 else
 {
 sbSQL.Append(" ContentTypeId = null,"); //内容类型Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TableNameKey))
 {
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableNameKey = '{0}',", strTableNameKey); //主表主键值
 }
 else
 {
 sbSQL.Append(" TableNameKey = null,"); //主表主键值
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.OrderNum))
 {
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.OrderNum, contz_ContentAttachment.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.OrderNum); //序号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.AttachmentTitle))
 {
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AttachmentTitle = '{0}',", strAttachmentTitle); //附件标题
 }
 else
 {
 sbSQL.Append(" AttachmentTitle = null,"); //附件标题
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.IdResourceType))
 {
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResourceType = '{0}',", strIdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TextContent))
 {
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextContent = '{0}',", strTextContent); //文本内容
 }
 else
 {
 sbSQL.Append(" TextContent = null,"); //文本内容
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileName))
 {
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Extension))
 {
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FilePath))
 {
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.PdfFilePath))
 {
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfFilePath = '{0}',", strPdfFilePath); //Pdf文件路径
 }
 else
 {
 sbSQL.Append(" PdfFilePath = null,"); //Pdf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.SwfFilePath))
 {
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SwfFilePath = '{0}',", strSwfFilePath); //Swf文件路径
 }
 else
 {
 sbSQL.Append(" SwfFilePath = null,"); //Swf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSize))
 {
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.FileSize, contz_ContentAttachment.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileSize); //文件大小
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSizeUnit))
 {
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageHeight))
 {
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageHeight, contz_ContentAttachment.ImageHeight); //图像高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageHeight); //图像高
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageWidth))
 {
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageWidth, contz_ContentAttachment.ImageWidth); //图像宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageWidth); //图像宽
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadDate))
 {
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadPerson))
 {
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadPerson = '{0}',", strUploadPerson); //上传人
 }
 else
 {
 sbSQL.Append(" UploadPerson = null,"); //上传人
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdDate))
 {
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdUserId))
 {
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Memo))
 {
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.CourseId))
 {
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objtz_ContentAttachmentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objtz_ContentAttachmentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update tz_ContentAttachment Set ");
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ContentTypeId))
 {
 if (objtz_ContentAttachmentEN.ContentTypeId !=  null)
 {
 var strContentTypeId = objtz_ContentAttachmentEN.ContentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContentTypeId, contz_ContentAttachment.ContentTypeId); //内容类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ContentTypeId); //内容类型Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TableNameKey))
 {
 if (objtz_ContentAttachmentEN.TableNameKey !=  null)
 {
 var strTableNameKey = objtz_ContentAttachmentEN.TableNameKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableNameKey, contz_ContentAttachment.TableNameKey); //主表主键值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.TableNameKey); //主表主键值
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.OrderNum))
 {
 if (objtz_ContentAttachmentEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.OrderNum, contz_ContentAttachment.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.OrderNum); //序号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.AttachmentTitle))
 {
 if (objtz_ContentAttachmentEN.AttachmentTitle !=  null)
 {
 var strAttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAttachmentTitle, contz_ContentAttachment.AttachmentTitle); //附件标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.AttachmentTitle); //附件标题
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.IdResourceType))
 {
 if (objtz_ContentAttachmentEN.IdResourceType !=  null)
 {
 var strIdResourceType = objtz_ContentAttachmentEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResourceType, contz_ContentAttachment.IdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.IdResourceType); //资源类型流水号
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.TextContent))
 {
 if (objtz_ContentAttachmentEN.TextContent !=  null)
 {
 var strTextContent = objtz_ContentAttachmentEN.TextContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextContent, contz_ContentAttachment.TextContent); //文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.TextContent); //文本内容
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileName))
 {
 if (objtz_ContentAttachmentEN.FileName !=  null)
 {
 var strFileName = objtz_ContentAttachmentEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, contz_ContentAttachment.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileName); //文件名称
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Extension))
 {
 if (objtz_ContentAttachmentEN.Extension !=  null)
 {
 var strExtension = objtz_ContentAttachmentEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, contz_ContentAttachment.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.Extension); //扩展名
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FilePath))
 {
 if (objtz_ContentAttachmentEN.FilePath !=  null)
 {
 var strFilePath = objtz_ContentAttachmentEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, contz_ContentAttachment.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FilePath); //文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.PdfFilePath))
 {
 if (objtz_ContentAttachmentEN.PdfFilePath !=  null)
 {
 var strPdfFilePath = objtz_ContentAttachmentEN.PdfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfFilePath, contz_ContentAttachment.PdfFilePath); //Pdf文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.PdfFilePath); //Pdf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.SwfFilePath))
 {
 if (objtz_ContentAttachmentEN.SwfFilePath !=  null)
 {
 var strSwfFilePath = objtz_ContentAttachmentEN.SwfFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSwfFilePath, contz_ContentAttachment.SwfFilePath); //Swf文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.SwfFilePath); //Swf文件路径
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSize))
 {
 if (objtz_ContentAttachmentEN.FileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.FileSize, contz_ContentAttachment.FileSize); //文件大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileSize); //文件大小
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.FileSizeUnit))
 {
 if (objtz_ContentAttachmentEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, contz_ContentAttachment.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageHeight))
 {
 if (objtz_ContentAttachmentEN.ImageHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageHeight, contz_ContentAttachment.ImageHeight); //图像高
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageHeight); //图像高
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.ImageWidth))
 {
 if (objtz_ContentAttachmentEN.ImageWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objtz_ContentAttachmentEN.ImageWidth, contz_ContentAttachment.ImageWidth); //图像宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.ImageWidth); //图像宽
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadDate))
 {
 if (objtz_ContentAttachmentEN.UploadDate !=  null)
 {
 var strUploadDate = objtz_ContentAttachmentEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, contz_ContentAttachment.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UploadDate); //上传时间
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UploadPerson))
 {
 if (objtz_ContentAttachmentEN.UploadPerson !=  null)
 {
 var strUploadPerson = objtz_ContentAttachmentEN.UploadPerson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadPerson, contz_ContentAttachment.UploadPerson); //上传人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UploadPerson); //上传人
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdDate))
 {
 if (objtz_ContentAttachmentEN.UpdDate !=  null)
 {
 var strUpdDate = objtz_ContentAttachmentEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, contz_ContentAttachment.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UpdDate); //修改日期
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.UpdUserId))
 {
 if (objtz_ContentAttachmentEN.UpdUserId !=  null)
 {
 var strUpdUserId = objtz_ContentAttachmentEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, contz_ContentAttachment.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.UpdUserId); //修改用户Id
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.Memo))
 {
 if (objtz_ContentAttachmentEN.Memo !=  null)
 {
 var strMemo = objtz_ContentAttachmentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, contz_ContentAttachment.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.Memo); //备注
 }
 }
 
 if (objtz_ContentAttachmentEN.IsUpdated(contz_ContentAttachment.CourseId))
 {
 if (objtz_ContentAttachmentEN.CourseId !=  null)
 {
 var strCourseId = objtz_ContentAttachmentEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, contz_ContentAttachment.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",contz_ContentAttachment.CourseId); //课程Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objtz_ContentAttachmentEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("tz_ContentAttachment_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
//删除tz_ContentAttachment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from tz_ContentAttachment where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Deltz_ContentAttachment(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
//删除tz_ContentAttachment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from tz_ContentAttachment where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
//删除tz_ContentAttachment本表中与当前对象有关的记录
strSQL = strSQL + "Delete from tz_ContentAttachment where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Deltz_ContentAttachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: Deltz_ContentAttachment)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from tz_ContentAttachment where " + strCondition ;
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
public bool Deltz_ContentAttachmentWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clstz_ContentAttachmentDA: Deltz_ContentAttachmentWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from tz_ContentAttachment where " + strCondition ;
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
 /// <param name = "objtz_ContentAttachmentENS">源对象</param>
 /// <param name = "objtz_ContentAttachmentENT">目标对象</param>
public void CopyTo(clstz_ContentAttachmentEN objtz_ContentAttachmentENS, clstz_ContentAttachmentEN objtz_ContentAttachmentENT)
{
objtz_ContentAttachmentENT.mId = objtz_ContentAttachmentENS.mId; //mId
objtz_ContentAttachmentENT.ContentTypeId = objtz_ContentAttachmentENS.ContentTypeId; //内容类型Id
objtz_ContentAttachmentENT.TableNameKey = objtz_ContentAttachmentENS.TableNameKey; //主表主键值
objtz_ContentAttachmentENT.OrderNum = objtz_ContentAttachmentENS.OrderNum; //序号
objtz_ContentAttachmentENT.AttachmentTitle = objtz_ContentAttachmentENS.AttachmentTitle; //附件标题
objtz_ContentAttachmentENT.IdResourceType = objtz_ContentAttachmentENS.IdResourceType; //资源类型流水号
objtz_ContentAttachmentENT.TextContent = objtz_ContentAttachmentENS.TextContent; //文本内容
objtz_ContentAttachmentENT.FileName = objtz_ContentAttachmentENS.FileName; //文件名称
objtz_ContentAttachmentENT.Extension = objtz_ContentAttachmentENS.Extension; //扩展名
objtz_ContentAttachmentENT.FilePath = objtz_ContentAttachmentENS.FilePath; //文件路径
objtz_ContentAttachmentENT.PdfFilePath = objtz_ContentAttachmentENS.PdfFilePath; //Pdf文件路径
objtz_ContentAttachmentENT.SwfFilePath = objtz_ContentAttachmentENS.SwfFilePath; //Swf文件路径
objtz_ContentAttachmentENT.FileSize = objtz_ContentAttachmentENS.FileSize; //文件大小
objtz_ContentAttachmentENT.FileSizeUnit = objtz_ContentAttachmentENS.FileSizeUnit; //文件大小单位
objtz_ContentAttachmentENT.ImageHeight = objtz_ContentAttachmentENS.ImageHeight; //图像高
objtz_ContentAttachmentENT.ImageWidth = objtz_ContentAttachmentENS.ImageWidth; //图像宽
objtz_ContentAttachmentENT.UploadDate = objtz_ContentAttachmentENS.UploadDate; //上传时间
objtz_ContentAttachmentENT.UploadPerson = objtz_ContentAttachmentENS.UploadPerson; //上传人
objtz_ContentAttachmentENT.UpdDate = objtz_ContentAttachmentENS.UpdDate; //修改日期
objtz_ContentAttachmentENT.UpdUserId = objtz_ContentAttachmentENS.UpdUserId; //修改用户Id
objtz_ContentAttachmentENT.Memo = objtz_ContentAttachmentENS.Memo; //备注
objtz_ContentAttachmentENT.CourseId = objtz_ContentAttachmentENS.CourseId; //课程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objtz_ContentAttachmentEN.ContentTypeId, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldNotNull(objtz_ContentAttachmentEN.TableNameKey, contz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldNotNull(objtz_ContentAttachmentEN.IdResourceType, contz_ContentAttachment.IdResourceType);
clsCheckSql.CheckFieldNotNull(objtz_ContentAttachmentEN.UploadDate, contz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldNotNull(objtz_ContentAttachmentEN.UpdDate, contz_ContentAttachment.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.ContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.TableNameKey, 20, contz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.AttachmentTitle, 100, contz_ContentAttachment.AttachmentTitle);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.IdResourceType, 4, contz_ContentAttachment.IdResourceType);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.TextContent, 8000, contz_ContentAttachment.TextContent);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FileName, 500, contz_ContentAttachment.FileName);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.Extension, 10, contz_ContentAttachment.Extension);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FilePath, 500, contz_ContentAttachment.FilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.PdfFilePath, 500, contz_ContentAttachment.PdfFilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.SwfFilePath, 500, contz_ContentAttachment.SwfFilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FileSizeUnit, 10, contz_ContentAttachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UploadDate, 20, contz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UploadPerson, 20, contz_ContentAttachment.UploadPerson);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UpdDate, 20, contz_ContentAttachment.UpdDate);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UpdUserId, 20, contz_ContentAttachment.UpdUserId);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.Memo, 1000, contz_ContentAttachment.Memo);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.CourseId, 8, contz_ContentAttachment.CourseId);
//检查字段外键固定长度
 objtz_ContentAttachmentEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.ContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.TableNameKey, 20, contz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.AttachmentTitle, 100, contz_ContentAttachment.AttachmentTitle);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.IdResourceType, 4, contz_ContentAttachment.IdResourceType);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.TextContent, 8000, contz_ContentAttachment.TextContent);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FileName, 500, contz_ContentAttachment.FileName);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.Extension, 10, contz_ContentAttachment.Extension);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FilePath, 500, contz_ContentAttachment.FilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.PdfFilePath, 500, contz_ContentAttachment.PdfFilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.SwfFilePath, 500, contz_ContentAttachment.SwfFilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FileSizeUnit, 10, contz_ContentAttachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UploadDate, 20, contz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UploadPerson, 20, contz_ContentAttachment.UploadPerson);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UpdDate, 20, contz_ContentAttachment.UpdDate);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UpdUserId, 20, contz_ContentAttachment.UpdUserId);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.Memo, 1000, contz_ContentAttachment.Memo);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.CourseId, 8, contz_ContentAttachment.CourseId);
//检查外键字段长度
 objtz_ContentAttachmentEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.ContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.TableNameKey, 20, contz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.AttachmentTitle, 100, contz_ContentAttachment.AttachmentTitle);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.IdResourceType, 4, contz_ContentAttachment.IdResourceType);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.TextContent, 8000, contz_ContentAttachment.TextContent);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FileName, 500, contz_ContentAttachment.FileName);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.Extension, 10, contz_ContentAttachment.Extension);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FilePath, 500, contz_ContentAttachment.FilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.PdfFilePath, 500, contz_ContentAttachment.PdfFilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.SwfFilePath, 500, contz_ContentAttachment.SwfFilePath);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.FileSizeUnit, 10, contz_ContentAttachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UploadDate, 20, contz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UploadPerson, 20, contz_ContentAttachment.UploadPerson);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UpdDate, 20, contz_ContentAttachment.UpdDate);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.UpdUserId, 20, contz_ContentAttachment.UpdUserId);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.Memo, 1000, contz_ContentAttachment.Memo);
clsCheckSql.CheckFieldLen(objtz_ContentAttachmentEN.CourseId, 8, contz_ContentAttachment.CourseId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.ContentTypeId, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.TableNameKey, contz_ContentAttachment.TableNameKey);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.AttachmentTitle, contz_ContentAttachment.AttachmentTitle);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.IdResourceType, contz_ContentAttachment.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.TextContent, contz_ContentAttachment.TextContent);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.FileName, contz_ContentAttachment.FileName);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.Extension, contz_ContentAttachment.Extension);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.FilePath, contz_ContentAttachment.FilePath);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.PdfFilePath, contz_ContentAttachment.PdfFilePath);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.SwfFilePath, contz_ContentAttachment.SwfFilePath);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.FileSizeUnit, contz_ContentAttachment.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.UploadDate, contz_ContentAttachment.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.UploadPerson, contz_ContentAttachment.UploadPerson);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.UpdDate, contz_ContentAttachment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.UpdUserId, contz_ContentAttachment.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.Memo, contz_ContentAttachment.Memo);
clsCheckSql.CheckSqlInjection4Field(objtz_ContentAttachmentEN.CourseId, contz_ContentAttachment.CourseId);
//检查外键字段长度
 objtz_ContentAttachmentEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--tz_ContentAttachment(内容附件),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 if (objtz_ContentAttachmentEN.AttachmentTitle == null)
{
 sbCondition.AppendFormat(" and AttachmentTitle is null");
}
else
{
 sbCondition.AppendFormat(" and AttachmentTitle = '{0}'", objtz_ContentAttachmentEN.AttachmentTitle);
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clstz_ContentAttachmentEN._CurrTabName);
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clstz_ContentAttachmentEN._CurrTabName, strCondition);
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
 objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
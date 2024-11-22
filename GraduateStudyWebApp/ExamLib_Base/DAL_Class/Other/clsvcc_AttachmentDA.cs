
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_AttachmentDA
 表名:vcc_Attachment(01120160)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:44
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
 /// v附件(vcc_Attachment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_AttachmentDA : clsCommBase4DA
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
 return clsvcc_AttachmentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_AttachmentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_AttachmentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_AttachmentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_AttachmentEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_Attachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable_vcc_Attachment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_Attachment.* from vcc_Attachment Left Join {1} on {2} where {3} and vcc_Attachment.AttachmentID not in (Select top {5} vcc_Attachment.AttachmentID from vcc_Attachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1} and AttachmentID not in (Select top {2} AttachmentID from vcc_Attachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1} and AttachmentID not in (Select top {3} AttachmentID from vcc_Attachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_Attachment.* from vcc_Attachment Left Join {1} on {2} where {3} and vcc_Attachment.AttachmentID not in (Select top {5} vcc_Attachment.AttachmentID from vcc_Attachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1} and AttachmentID not in (Select top {2} AttachmentID from vcc_Attachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Attachment where {1} and AttachmentID not in (Select top {3} AttachmentID from vcc_Attachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_AttachmentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA:GetObjLst)", objException.Message));
}
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_AttachmentDA: GetObjLst)", objException.Message));
}
objvcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_AttachmentEN);
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
public List<clsvcc_AttachmentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_AttachmentDA: GetObjLst)", objException.Message));
}
objvcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_AttachmentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_Attachment(ref clsvcc_AttachmentEN objvcc_AttachmentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where AttachmentID = " + ""+ objvcc_AttachmentEN.AttachmentID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_AttachmentEN.AttachmentID = TransNullToInt(objDT.Rows[0][convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_AttachmentEN.TableName = objDT.Rows[0][convcc_Attachment.TableName].ToString().Trim(); //主表表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_AttachmentEN.FileName = objDT.Rows[0][convcc_Attachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_AttachmentEN.Extension = objDT.Rows[0][convcc_Attachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_AttachmentEN.FilePath = objDT.Rows[0][convcc_Attachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvcc_AttachmentEN.FileSize = TransNullToDouble(objDT.Rows[0][convcc_Attachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objvcc_AttachmentEN.FileSizeUnit = objDT.Rows[0][convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_AttachmentEN.UploadDate = objDT.Rows[0][convcc_Attachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_AttachmentEN.UploadPerson = objDT.Rows[0][convcc_Attachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_AttachmentEN.TableNameKey = objDT.Rows[0][convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_AttachmentEN.IdResourceType = objDT.Rows[0][convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvcc_AttachmentEN.ResourceTypeID = objDT.Rows[0][convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_AttachmentEN.ResourceTypeName = objDT.Rows[0][convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_AttachmentEN.UpdDate = objDT.Rows[0][convcc_Attachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_AttachmentEN.UpdUserId = objDT.Rows[0][convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_AttachmentEN.Memo = objDT.Rows[0][convcc_Attachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_AttachmentEN.ImageHeight = TransNullToInt(objDT.Rows[0][convcc_Attachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objvcc_AttachmentEN.ImageWidth = TransNullToInt(objDT.Rows[0][convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_AttachmentDA: Getvcc_Attachment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_AttachmentEN GetObjByAttachmentID(long lngAttachmentID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where AttachmentID = " + ""+ lngAttachmentID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
 objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高(字段类型:int,字段长度:4,是否可空:True)
 objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_AttachmentDA: GetObjByAttachmentID)", objException.Message));
}
return objvcc_AttachmentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_AttachmentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Attachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN()
{
AttachmentID = TransNullToInt(objRow[convcc_Attachment.AttachmentID].ToString().Trim()), //附件流水号
TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(), //主表表名
FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(), //文件名称
Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(), //扩展名
FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(), //文件路径
FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_Attachment.FileSize].ToString().Trim()), //文件大小
FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(), //文件大小单位
UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(), //上传时间
UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(), //上传人
TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(), //主表主键值
IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(), //资源类型名称
UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(), //备注
ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageHeight].ToString().Trim()), //图像高
ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageWidth].ToString().Trim()) //图像宽
};
objvcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_AttachmentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_AttachmentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_AttachmentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_AttachmentDA: GetObjByDataRowvcc_Attachment)", objException.Message));
}
objvcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_AttachmentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_AttachmentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = TransNullToInt(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_AttachmentDA: GetObjByDataRow)", objException.Message));
}
objvcc_AttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_AttachmentEN;
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
objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_AttachmentEN._CurrTabName, convcc_Attachment.AttachmentID, 8, "");
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
objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_AttachmentEN._CurrTabName, convcc_Attachment.AttachmentID, 8, strPrefix);
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AttachmentID from vcc_Attachment where " + strCondition;
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AttachmentID from vcc_Attachment where " + strCondition;
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_Attachment", "AttachmentID = " + ""+ lngAttachmentID+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_AttachmentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_Attachment", strCondition))
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
objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_Attachment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_AttachmentENS">源对象</param>
 /// <param name = "objvcc_AttachmentENT">目标对象</param>
public void CopyTo(clsvcc_AttachmentEN objvcc_AttachmentENS, clsvcc_AttachmentEN objvcc_AttachmentENT)
{
objvcc_AttachmentENT.AttachmentID = objvcc_AttachmentENS.AttachmentID; //附件流水号
objvcc_AttachmentENT.TableName = objvcc_AttachmentENS.TableName; //主表表名
objvcc_AttachmentENT.FileName = objvcc_AttachmentENS.FileName; //文件名称
objvcc_AttachmentENT.Extension = objvcc_AttachmentENS.Extension; //扩展名
objvcc_AttachmentENT.FilePath = objvcc_AttachmentENS.FilePath; //文件路径
objvcc_AttachmentENT.FileSize = objvcc_AttachmentENS.FileSize; //文件大小
objvcc_AttachmentENT.FileSizeUnit = objvcc_AttachmentENS.FileSizeUnit; //文件大小单位
objvcc_AttachmentENT.UploadDate = objvcc_AttachmentENS.UploadDate; //上传时间
objvcc_AttachmentENT.UploadPerson = objvcc_AttachmentENS.UploadPerson; //上传人
objvcc_AttachmentENT.TableNameKey = objvcc_AttachmentENS.TableNameKey; //主表主键值
objvcc_AttachmentENT.IdResourceType = objvcc_AttachmentENS.IdResourceType; //资源类型流水号
objvcc_AttachmentENT.ResourceTypeID = objvcc_AttachmentENS.ResourceTypeID; //资源类型ID
objvcc_AttachmentENT.ResourceTypeName = objvcc_AttachmentENS.ResourceTypeName; //资源类型名称
objvcc_AttachmentENT.UpdDate = objvcc_AttachmentENS.UpdDate; //修改日期
objvcc_AttachmentENT.UpdUserId = objvcc_AttachmentENS.UpdUserId; //修改用户Id
objvcc_AttachmentENT.Memo = objvcc_AttachmentENS.Memo; //备注
objvcc_AttachmentENT.ImageHeight = objvcc_AttachmentENS.ImageHeight; //图像高
objvcc_AttachmentENT.ImageWidth = objvcc_AttachmentENS.ImageWidth; //图像宽
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_AttachmentEN objvcc_AttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.TableName, 100, convcc_Attachment.TableName);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.FileName, 500, convcc_Attachment.FileName);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.Extension, 10, convcc_Attachment.Extension);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.FilePath, 500, convcc_Attachment.FilePath);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.FileSizeUnit, 10, convcc_Attachment.FileSizeUnit);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.UploadDate, 20, convcc_Attachment.UploadDate);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.UploadPerson, 20, convcc_Attachment.UploadPerson);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.TableNameKey, 20, convcc_Attachment.TableNameKey);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.IdResourceType, 4, convcc_Attachment.IdResourceType);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.ResourceTypeID, 4, convcc_Attachment.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.ResourceTypeName, 50, convcc_Attachment.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.UpdDate, 20, convcc_Attachment.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.UpdUserId, 20, convcc_Attachment.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_AttachmentEN.Memo, 1000, convcc_Attachment.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.TableName, convcc_Attachment.TableName);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.FileName, convcc_Attachment.FileName);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.Extension, convcc_Attachment.Extension);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.FilePath, convcc_Attachment.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.FileSizeUnit, convcc_Attachment.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.UploadDate, convcc_Attachment.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.UploadPerson, convcc_Attachment.UploadPerson);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.TableNameKey, convcc_Attachment.TableNameKey);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.IdResourceType, convcc_Attachment.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.ResourceTypeID, convcc_Attachment.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.ResourceTypeName, convcc_Attachment.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.UpdDate, convcc_Attachment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.UpdUserId, convcc_Attachment.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_AttachmentEN.Memo, convcc_Attachment.Memo);
//检查外键字段长度
 objvcc_AttachmentEN._IsCheckProperty = true;
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_AttachmentEN._CurrTabName);
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_AttachmentEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_AttachmentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
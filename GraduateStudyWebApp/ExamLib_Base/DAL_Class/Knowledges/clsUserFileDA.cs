
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserFileDA
 表名:UserFile(01120085)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 课程资源管理(UserFile)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserFileDA : clsCommBase4DA
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
 return clsUserFileEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserFileEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserFileEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserFileEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserFileEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFileName">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFileName)
{
strFileName = strFileName.Replace("'", "''");
if (strFileName.Length > 500)
{
throw new Exception("(errid:Data000001)在表:UserFile中,检查关键字,长度不正确!(clsUserFileDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFileName)  ==  true)
{
throw new Exception("(errid:Data000002)在表:UserFile中,关键字不能为空 或 null!(clsUserFileDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFileName);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUserFileDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserFile(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable_UserFile)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserFile where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserFile where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserFileDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserFile where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserFileDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} UserFile.* from UserFile Left Join {1} on {2} where {3} and UserFile.FileName not in (Select top {5} UserFile.FileName from UserFile Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserFile where {1} and FileName not in (Select top {2} FileName from UserFile where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserFile where {1} and FileName not in (Select top {3} FileName from UserFile where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserFileDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} UserFile.* from UserFile Left Join {1} on {2} where {3} and UserFile.FileName not in (Select top {5} UserFile.FileName from UserFile Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserFile where {1} and FileName not in (Select top {2} FileName from UserFile where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserFile where {1} and FileName not in (Select top {3} FileName from UserFile where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserFileEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserFileDA:GetObjLst)", objException.Message));
}
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = TransNullToDouble(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserFileDA: GetObjLst)", objException.Message));
}
objUserFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserFileEN);
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
public List<clsUserFileEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserFileDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = TransNullToDouble(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserFileDA: GetObjLst)", objException.Message));
}
objUserFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserFile(ref clsUserFileEN objUserFileEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where FileName = " + "'"+ objUserFileEN.FileName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserFileEN.FileName = objDT.Rows[0][conUserFile.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objUserFileEN.OrderNum = TransNullToInt(objDT.Rows[0][conUserFile.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objUserFileEN.FileSize = TransNullToDouble(objDT.Rows[0][conUserFile.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objUserFileEN.Extension = objDT.Rows[0][conUserFile.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objUserFileEN.ResourceTypeName = objDT.Rows[0][conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objUserFileEN.FileSizeUnit = objDT.Rows[0][conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objUserFileEN.ResourcePicPath = objDT.Rows[0][conUserFile.ResourcePicPath].ToString().Trim(); //图片位置(字段类型:varchar,字段长度:500,是否可空:True)
 objUserFileEN.UploadDateTime = objDT.Rows[0][conUserFile.UploadDateTime].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:200,是否可空:True)
 objUserFileEN.FileNamePath = objDT.Rows[0][conUserFile.FileNamePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserFileDA: GetUserFile)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFileName">表关键字</param>
 /// <returns>表对象</returns>
public clsUserFileEN GetObjByFileName(string strFileName)
{
CheckPrimaryKey(strFileName);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where FileName = " + "'"+ strFileName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
 objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小(字段类型:decimal,字段长度:22,是否可空:True)
 objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位(字段类型:varchar,字段长度:10,是否可空:True)
 objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置(字段类型:varchar,字段长度:500,是否可空:True)
 objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:200,是否可空:True)
 objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserFileDA: GetObjByFileName)", objException.Message));
}
return objUserFileEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserFileEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserFileDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserFileEN objUserFileEN = new clsUserFileEN()
{
FileName = objRow[conUserFile.FileName].ToString().Trim(), //文件名称
OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserFile.OrderNum].ToString().Trim()), //序号
FileSize = TransNullToDouble(objRow[conUserFile.FileSize].ToString().Trim()), //文件大小
Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(), //扩展名
ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(), //资源类型名称
FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(), //文件大小单位
ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(), //图片位置
UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(), //上传时间
FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim() //文件路径
};
objUserFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserFileEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserFileDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserFileEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = TransNullToDouble(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserFileDA: GetObjByDataRowUserFile)", objException.Message));
}
objUserFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserFileEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserFileEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = TransNullToDouble(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserFileDA: GetObjByDataRow)", objException.Message));
}
objUserFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserFileEN;
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
objSQL = clsUserFileDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserFileEN._CurrTabName, conUserFile.FileName, 500, "");
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
objSQL = clsUserFileDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserFileEN._CurrTabName, conUserFile.FileName, 500, strPrefix);
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FileName from UserFile where " + strCondition;
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FileName from UserFile where " + strCondition;
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
 /// <param name = "strFileName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFileName)
{
CheckPrimaryKey(strFileName);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserFile", "FileName = " + "'"+ strFileName+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserFileDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserFile", strCondition))
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
objSQL = clsUserFileDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserFile");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserFileEN objUserFileEN)
 {
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserFileEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserFile");
objRow = objDS.Tables["UserFile"].NewRow();
objRow[conUserFile.FileName] = objUserFileEN.FileName; //文件名称
objRow[conUserFile.OrderNum] = objUserFileEN.OrderNum; //序号
objRow[conUserFile.FileSize] = objUserFileEN.FileSize; //文件大小
 if (objUserFileEN.Extension !=  "")
 {
objRow[conUserFile.Extension] = objUserFileEN.Extension; //扩展名
 }
 if (objUserFileEN.ResourceTypeName !=  "")
 {
objRow[conUserFile.ResourceTypeName] = objUserFileEN.ResourceTypeName; //资源类型名称
 }
 if (objUserFileEN.FileSizeUnit !=  "")
 {
objRow[conUserFile.FileSizeUnit] = objUserFileEN.FileSizeUnit; //文件大小单位
 }
 if (objUserFileEN.ResourcePicPath !=  "")
 {
objRow[conUserFile.ResourcePicPath] = objUserFileEN.ResourcePicPath; //图片位置
 }
 if (objUserFileEN.UploadDateTime !=  "")
 {
objRow[conUserFile.UploadDateTime] = objUserFileEN.UploadDateTime; //上传时间
 }
 if (objUserFileEN.FileNamePath !=  "")
 {
objRow[conUserFile.FileNamePath] = objUserFileEN.FileNamePath; //文件路径
 }
objDS.Tables[clsUserFileEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserFileEN._CurrTabName);
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
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserFileEN objUserFileEN)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileName);
 var strFileName = objUserFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUserFileEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.OrderNum);
 arrValueListForInsert.Add(objUserFileEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conUserFile.FileSize);
 arrValueListForInsert.Add(objUserFileEN.FileSize.ToString());
 
 if (objUserFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.Extension);
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourceTypeName);
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileSizeUnit);
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourcePicPath);
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 if (objUserFileEN.UploadDateTime !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.UploadDateTime);
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDateTime + "'");
 }
 
 if (objUserFileEN.FileNamePath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileNamePath);
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNamePath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserFile");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserFileEN objUserFileEN)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileName);
 var strFileName = objUserFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUserFileEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.OrderNum);
 arrValueListForInsert.Add(objUserFileEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conUserFile.FileSize);
 arrValueListForInsert.Add(objUserFileEN.FileSize.ToString());
 
 if (objUserFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.Extension);
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourceTypeName);
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileSizeUnit);
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourcePicPath);
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 if (objUserFileEN.UploadDateTime !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.UploadDateTime);
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDateTime + "'");
 }
 
 if (objUserFileEN.FileNamePath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileNamePath);
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNamePath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserFile");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUserFileEN.FileName;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserFileEN objUserFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileName);
 var strFileName = objUserFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUserFileEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.OrderNum);
 arrValueListForInsert.Add(objUserFileEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conUserFile.FileSize);
 arrValueListForInsert.Add(objUserFileEN.FileSize.ToString());
 
 if (objUserFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.Extension);
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourceTypeName);
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileSizeUnit);
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourcePicPath);
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 if (objUserFileEN.UploadDateTime !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.UploadDateTime);
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDateTime + "'");
 }
 
 if (objUserFileEN.FileNamePath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileNamePath);
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNamePath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserFile");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUserFileEN.FileName;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserFileEN objUserFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserFileEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileName);
 var strFileName = objUserFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUserFileEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.OrderNum);
 arrValueListForInsert.Add(objUserFileEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conUserFile.FileSize);
 arrValueListForInsert.Add(objUserFileEN.FileSize.ToString());
 
 if (objUserFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.Extension);
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourceTypeName);
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileSizeUnit);
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileSizeUnit + "'");
 }
 
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.ResourcePicPath);
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourcePicPath + "'");
 }
 
 if (objUserFileEN.UploadDateTime !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.UploadDateTime);
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDateTime + "'");
 }
 
 if (objUserFileEN.FileNamePath !=  null)
 {
 arrFieldListForInsert.Add(conUserFile.FileNamePath);
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNamePath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserFile");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserFiles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where FileName = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserFile");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFileName = oRow[conUserFile.FileName].ToString().Trim();
if (IsExist(strFileName))
{
 string strResult = "关键字变量值为:" + string.Format("FileName = {0}", strFileName) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserFileEN._CurrTabName ].NewRow();
objRow[conUserFile.FileName] = oRow[conUserFile.FileName].ToString().Trim(); //文件名称
objRow[conUserFile.OrderNum] = oRow[conUserFile.OrderNum].ToString().Trim(); //序号
objRow[conUserFile.FileSize] = oRow[conUserFile.FileSize].ToString().Trim(); //文件大小
objRow[conUserFile.Extension] = oRow[conUserFile.Extension].ToString().Trim(); //扩展名
objRow[conUserFile.ResourceTypeName] = oRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objRow[conUserFile.FileSizeUnit] = oRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objRow[conUserFile.ResourcePicPath] = oRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objRow[conUserFile.UploadDateTime] = oRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objRow[conUserFile.FileNamePath] = oRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
 objDS.Tables[clsUserFileEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserFileEN._CurrTabName);
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
 /// <param name = "objUserFileEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserFileEN objUserFileEN)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserFileEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
strSQL = "Select * from UserFile where FileName = " + "'"+ objUserFileEN.FileName+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserFileEN._CurrTabName);
if (objDS.Tables[clsUserFileEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FileName = " + "'"+ objUserFileEN.FileName+"'");
return false;
}
objRow = objDS.Tables[clsUserFileEN._CurrTabName].Rows[0];
 if (objUserFileEN.IsUpdated(conUserFile.FileName))
 {
objRow[conUserFile.FileName] = objUserFileEN.FileName; //文件名称
 }
 if (objUserFileEN.IsUpdated(conUserFile.OrderNum))
 {
objRow[conUserFile.OrderNum] = objUserFileEN.OrderNum; //序号
 }
 if (objUserFileEN.IsUpdated(conUserFile.FileSize))
 {
objRow[conUserFile.FileSize] = objUserFileEN.FileSize; //文件大小
 }
 if (objUserFileEN.IsUpdated(conUserFile.Extension))
 {
objRow[conUserFile.Extension] = objUserFileEN.Extension; //扩展名
 }
 if (objUserFileEN.IsUpdated(conUserFile.ResourceTypeName))
 {
objRow[conUserFile.ResourceTypeName] = objUserFileEN.ResourceTypeName; //资源类型名称
 }
 if (objUserFileEN.IsUpdated(conUserFile.FileSizeUnit))
 {
objRow[conUserFile.FileSizeUnit] = objUserFileEN.FileSizeUnit; //文件大小单位
 }
 if (objUserFileEN.IsUpdated(conUserFile.ResourcePicPath))
 {
objRow[conUserFile.ResourcePicPath] = objUserFileEN.ResourcePicPath; //图片位置
 }
 if (objUserFileEN.IsUpdated(conUserFile.UploadDateTime))
 {
objRow[conUserFile.UploadDateTime] = objUserFileEN.UploadDateTime; //上传时间
 }
 if (objUserFileEN.IsUpdated(conUserFile.FileNamePath))
 {
objRow[conUserFile.FileNamePath] = objUserFileEN.FileNamePath; //文件路径
 }
try
{
objDA.Update(objDS, clsUserFileEN._CurrTabName);
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
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserFileEN objUserFileEN)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserFile Set ");
 
 if (objUserFileEN.IsUpdated(conUserFile.OrderNum))
 {
 if (objUserFileEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserFileEN.OrderNum, conUserFile.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.OrderNum); //序号
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserFileEN.FileSize, conUserFile.FileSize); //文件大小
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.Extension))
 {
 if (objUserFileEN.Extension !=  null)
 {
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, conUserFile.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.Extension); //扩展名
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourceTypeName))
 {
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeName, conUserFile.ResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.ResourceTypeName); //资源类型名称
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSizeUnit))
 {
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, conUserFile.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourcePicPath))
 {
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourcePicPath, conUserFile.ResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.ResourcePicPath); //图片位置
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.UploadDateTime))
 {
 if (objUserFileEN.UploadDateTime !=  null)
 {
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDateTime, conUserFile.UploadDateTime); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.UploadDateTime); //上传时间
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileNamePath))
 {
 if (objUserFileEN.FileNamePath !=  null)
 {
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileNamePath, conUserFile.FileNamePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.FileNamePath); //文件路径
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FileName = '{0}'", objUserFileEN.FileName); 
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
 /// <param name = "objUserFileEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserFileEN objUserFileEN, string strCondition)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserFile Set ");
 
 if (objUserFileEN.IsUpdated(conUserFile.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objUserFileEN.OrderNum); //序号
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objUserFileEN.FileSize); //文件大小
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.Extension))
 {
 if (objUserFileEN.Extension !=  null)
 {
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourceTypeName))
 {
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeName = '{0}',", strResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.Append(" ResourceTypeName = null,"); //资源类型名称
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSizeUnit))
 {
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourcePicPath))
 {
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourcePicPath = '{0}',", strResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.Append(" ResourcePicPath = null,"); //图片位置
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.UploadDateTime))
 {
 if (objUserFileEN.UploadDateTime !=  null)
 {
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDateTime = '{0}',", strUploadDateTime); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDateTime = null,"); //上传时间
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileNamePath))
 {
 if (objUserFileEN.FileNamePath !=  null)
 {
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileNamePath = '{0}',", strFileNamePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FileNamePath = null,"); //文件路径
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
 /// <param name = "objUserFileEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserFileEN objUserFileEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserFile Set ");
 
 if (objUserFileEN.IsUpdated(conUserFile.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objUserFileEN.OrderNum); //序号
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objUserFileEN.FileSize); //文件大小
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.Extension))
 {
 if (objUserFileEN.Extension !=  null)
 {
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourceTypeName))
 {
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeName = '{0}',", strResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.Append(" ResourceTypeName = null,"); //资源类型名称
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSizeUnit))
 {
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileSizeUnit = '{0}',", strFileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.Append(" FileSizeUnit = null,"); //文件大小单位
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourcePicPath))
 {
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourcePicPath = '{0}',", strResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.Append(" ResourcePicPath = null,"); //图片位置
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.UploadDateTime))
 {
 if (objUserFileEN.UploadDateTime !=  null)
 {
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDateTime = '{0}',", strUploadDateTime); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDateTime = null,"); //上传时间
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileNamePath))
 {
 if (objUserFileEN.FileNamePath !=  null)
 {
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileNamePath = '{0}',", strFileNamePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FileNamePath = null,"); //文件路径
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
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserFileEN objUserFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserFile Set ");
 
 if (objUserFileEN.IsUpdated(conUserFile.OrderNum))
 {
 if (objUserFileEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserFileEN.OrderNum, conUserFile.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.OrderNum); //序号
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserFileEN.FileSize, conUserFile.FileSize); //文件大小
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.Extension))
 {
 if (objUserFileEN.Extension !=  null)
 {
 var strExtension = objUserFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, conUserFile.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.Extension); //扩展名
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourceTypeName))
 {
 if (objUserFileEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objUserFileEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeName, conUserFile.ResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.ResourceTypeName); //资源类型名称
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileSizeUnit))
 {
 if (objUserFileEN.FileSizeUnit !=  null)
 {
 var strFileSizeUnit = objUserFileEN.FileSizeUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileSizeUnit, conUserFile.FileSizeUnit); //文件大小单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.FileSizeUnit); //文件大小单位
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.ResourcePicPath))
 {
 if (objUserFileEN.ResourcePicPath !=  null)
 {
 var strResourcePicPath = objUserFileEN.ResourcePicPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourcePicPath, conUserFile.ResourcePicPath); //图片位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.ResourcePicPath); //图片位置
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.UploadDateTime))
 {
 if (objUserFileEN.UploadDateTime !=  null)
 {
 var strUploadDateTime = objUserFileEN.UploadDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDateTime, conUserFile.UploadDateTime); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.UploadDateTime); //上传时间
 }
 }
 
 if (objUserFileEN.IsUpdated(conUserFile.FileNamePath))
 {
 if (objUserFileEN.FileNamePath !=  null)
 {
 var strFileNamePath = objUserFileEN.FileNamePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileNamePath, conUserFile.FileNamePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserFile.FileNamePath); //文件路径
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FileName = '{0}'", objUserFileEN.FileName); 
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
 /// <param name = "strFileName">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFileName) 
{
CheckPrimaryKey(strFileName);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFileName,
};
 objSQL.ExecSP("UserFile_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFileName">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFileName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFileName);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
//删除UserFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserFile where FileName = " + "'"+ strFileName+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserFile(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
//删除UserFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserFile where FileName in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFileName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFileName) 
{
CheckPrimaryKey(strFileName);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
//删除UserFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserFile where FileName = " + "'"+ strFileName+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserFile(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserFileDA: DelUserFile)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserFile where " + strCondition ;
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
public bool DelUserFileWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserFileDA: DelUserFileWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserFileDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserFile where " + strCondition ;
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
 /// <param name = "objUserFileENS">源对象</param>
 /// <param name = "objUserFileENT">目标对象</param>
public void CopyTo(clsUserFileEN objUserFileENS, clsUserFileEN objUserFileENT)
{
objUserFileENT.FileName = objUserFileENS.FileName; //文件名称
objUserFileENT.OrderNum = objUserFileENS.OrderNum; //序号
objUserFileENT.FileSize = objUserFileENS.FileSize; //文件大小
objUserFileENT.Extension = objUserFileENS.Extension; //扩展名
objUserFileENT.ResourceTypeName = objUserFileENS.ResourceTypeName; //资源类型名称
objUserFileENT.FileSizeUnit = objUserFileENS.FileSizeUnit; //文件大小单位
objUserFileENT.ResourcePicPath = objUserFileENS.ResourcePicPath; //图片位置
objUserFileENT.UploadDateTime = objUserFileENS.UploadDateTime; //上传时间
objUserFileENT.FileNamePath = objUserFileENS.FileNamePath; //文件路径
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserFileEN objUserFileEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserFileEN.FileSize, conUserFile.FileSize);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserFileEN.FileName, 500, conUserFile.FileName);
clsCheckSql.CheckFieldLen(objUserFileEN.Extension, 10, conUserFile.Extension);
clsCheckSql.CheckFieldLen(objUserFileEN.ResourceTypeName, 50, conUserFile.ResourceTypeName);
clsCheckSql.CheckFieldLen(objUserFileEN.FileSizeUnit, 10, conUserFile.FileSizeUnit);
clsCheckSql.CheckFieldLen(objUserFileEN.ResourcePicPath, 500, conUserFile.ResourcePicPath);
clsCheckSql.CheckFieldLen(objUserFileEN.UploadDateTime, 200, conUserFile.UploadDateTime);
clsCheckSql.CheckFieldLen(objUserFileEN.FileNamePath, 1000, conUserFile.FileNamePath);
//检查字段外键固定长度
 objUserFileEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserFileEN objUserFileEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserFileEN.Extension, 10, conUserFile.Extension);
clsCheckSql.CheckFieldLen(objUserFileEN.ResourceTypeName, 50, conUserFile.ResourceTypeName);
clsCheckSql.CheckFieldLen(objUserFileEN.FileSizeUnit, 10, conUserFile.FileSizeUnit);
clsCheckSql.CheckFieldLen(objUserFileEN.ResourcePicPath, 500, conUserFile.ResourcePicPath);
clsCheckSql.CheckFieldLen(objUserFileEN.UploadDateTime, 200, conUserFile.UploadDateTime);
clsCheckSql.CheckFieldLen(objUserFileEN.FileNamePath, 1000, conUserFile.FileNamePath);
//检查外键字段长度
 objUserFileEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserFileEN objUserFileEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserFileEN.FileName, 500, conUserFile.FileName);
clsCheckSql.CheckFieldLen(objUserFileEN.Extension, 10, conUserFile.Extension);
clsCheckSql.CheckFieldLen(objUserFileEN.ResourceTypeName, 50, conUserFile.ResourceTypeName);
clsCheckSql.CheckFieldLen(objUserFileEN.FileSizeUnit, 10, conUserFile.FileSizeUnit);
clsCheckSql.CheckFieldLen(objUserFileEN.ResourcePicPath, 500, conUserFile.ResourcePicPath);
clsCheckSql.CheckFieldLen(objUserFileEN.UploadDateTime, 200, conUserFile.UploadDateTime);
clsCheckSql.CheckFieldLen(objUserFileEN.FileNamePath, 1000, conUserFile.FileNamePath);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.FileName, conUserFile.FileName);
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.Extension, conUserFile.Extension);
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.ResourceTypeName, conUserFile.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.FileSizeUnit, conUserFile.FileSizeUnit);
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.ResourcePicPath, conUserFile.ResourcePicPath);
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.UploadDateTime, conUserFile.UploadDateTime);
clsCheckSql.CheckSqlInjection4Field(objUserFileEN.FileNamePath, conUserFile.FileNamePath);
//检查外键字段长度
 objUserFileEN._IsCheckProperty = true;
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserFileEN._CurrTabName);
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserFileEN._CurrTabName, strCondition);
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
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
 objSQL = clsUserFileDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
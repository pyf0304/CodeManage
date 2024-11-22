
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureResourcesDA
 表名:PictureResources(01120040)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 图片资源(PictureResources)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPictureResourcesDA : clsCommBase4DA
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
 return clsPictureResourcesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPictureResourcesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPictureResourcesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPictureResourcesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPictureResourcesEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PictureResources(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable_PictureResources)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PictureResources where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PictureResources where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PictureResources where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PictureResources.* from PictureResources Left Join {1} on {2} where {3} and PictureResources.PictureId not in (Select top {5} PictureResources.PictureId from PictureResources Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PictureResources where {1} and PictureId not in (Select top {2} PictureId from PictureResources where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PictureResources where {1} and PictureId not in (Select top {3} PictureId from PictureResources where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPictureResourcesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PictureResources.* from PictureResources Left Join {1} on {2} where {3} and PictureResources.PictureId not in (Select top {5} PictureResources.PictureId from PictureResources Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PictureResources where {1} and PictureId not in (Select top {2} PictureId from PictureResources where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PictureResources where {1} and PictureId not in (Select top {3} PictureId from PictureResources where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPictureResourcesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPictureResourcesDA:GetObjLst)", objException.Message));
}
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = TransNullToInt(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = TransNullToInt(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = TransNullToInt(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPictureResourcesDA: GetObjLst)", objException.Message));
}
objPictureResourcesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPictureResourcesEN);
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
public List<clsPictureResourcesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPictureResourcesDA:GetObjLstByTabName)", objException.Message));
}
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = TransNullToInt(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = TransNullToInt(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = TransNullToInt(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPictureResourcesDA: GetObjLst)", objException.Message));
}
objPictureResourcesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPictureResourcesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPictureResources(ref clsPictureResourcesEN objPictureResourcesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where PictureId = " + ""+ objPictureResourcesEN.PictureId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPictureResourcesEN.Memo = objDT.Rows[0][conPictureResources.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objPictureResourcesEN.PictureId = TransNullToInt(objDT.Rows[0][conPictureResources.PictureId].ToString().Trim()); //PictureId(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.PictureName = objDT.Rows[0][conPictureResources.PictureName].ToString().Trim(); //PictureName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.OrginialFileName = objDT.Rows[0][conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.OrginialFileSize = TransNullToInt(objDT.Rows[0][conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.ResizePictureSize = TransNullToInt(objDT.Rows[0][conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.ThumbSize = TransNullToInt(objDT.Rows[0][conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.OrginialFileWidth = TransNullToInt(objDT.Rows[0][conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.PictureConfigerId = objDT.Rows[0][conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objPictureResourcesEN.ResizePictureName = objDT.Rows[0][conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.ThumbName = objDT.Rows[0][conPictureResources.ThumbName].ToString().Trim(); //ThumbName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.OrginialFileHeight = TransNullToInt(objDT.Rows[0][conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPictureResourcesDA: GetPictureResources)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intPictureId">表关键字</param>
 /// <returns>表对象</returns>
public clsPictureResourcesEN GetObjByPictureId(int intPictureId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where PictureId = " + ""+ intPictureId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
 objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth(字段类型:int,字段长度:4,是否可空:True)
 objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName(字段类型:varchar,字段长度:100,是否可空:True)
 objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPictureResourcesDA: GetObjByPictureId)", objException.Message));
}
return objPictureResourcesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPictureResourcesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPictureResourcesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN()
{
Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(), //备注
PictureId = TransNullToInt(objRow[conPictureResources.PictureId].ToString().Trim()), //PictureId
PictureName = objRow[conPictureResources.PictureName].ToString().Trim(), //PictureName
OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(), //OrginialFileName
OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileSize].ToString().Trim()), //OrginialFileSize
ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.ResizePictureSize].ToString().Trim()), //ResizePictureSize
ThumbSize = TransNullToInt(objRow[conPictureResources.ThumbSize].ToString().Trim()), //ThumbSize
OrginialFileWidth = TransNullToInt(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()), //OrginialFileWidth
PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(), //PictureConfigerId
ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(), //ResizePictureName
ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(), //ThumbName
OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()) //OrginialFileHeight
};
objPictureResourcesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPictureResourcesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPictureResourcesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPictureResourcesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = TransNullToInt(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = TransNullToInt(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = TransNullToInt(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPictureResourcesDA: GetObjByDataRowPictureResources)", objException.Message));
}
objPictureResourcesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPictureResourcesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPictureResourcesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = TransNullToInt(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = TransNullToInt(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = TransNullToInt(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPictureResourcesDA: GetObjByDataRow)", objException.Message));
}
objPictureResourcesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPictureResourcesEN;
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
objSQL = clsPictureResourcesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPictureResourcesEN._CurrTabName, conPictureResources.PictureId, 4, "");
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
objSQL = clsPictureResourcesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPictureResourcesEN._CurrTabName, conPictureResources.PictureId, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public int GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PictureId from PictureResources where " + strCondition;
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
return int.Parse(strKeyValue);
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PictureId from PictureResources where " + strCondition;
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
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intPictureId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PictureResources", "PictureId = " + ""+ intPictureId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPictureResourcesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PictureResources", strCondition))
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
objSQL = clsPictureResourcesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PictureResources");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPictureResourcesEN objPictureResourcesEN)
 {
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureResourcesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PictureResources");
objRow = objDS.Tables["PictureResources"].NewRow();
 if (objPictureResourcesEN.Memo !=  "")
 {
objRow[conPictureResources.Memo] = objPictureResourcesEN.Memo; //备注
 }
objRow[conPictureResources.PictureName] = objPictureResourcesEN.PictureName; //PictureName
 if (objPictureResourcesEN.OrginialFileName !=  "")
 {
objRow[conPictureResources.OrginialFileName] = objPictureResourcesEN.OrginialFileName; //OrginialFileName
 }
objRow[conPictureResources.OrginialFileSize] = objPictureResourcesEN.OrginialFileSize; //OrginialFileSize
objRow[conPictureResources.ResizePictureSize] = objPictureResourcesEN.ResizePictureSize; //ResizePictureSize
objRow[conPictureResources.ThumbSize] = objPictureResourcesEN.ThumbSize; //ThumbSize
objRow[conPictureResources.OrginialFileWidth] = objPictureResourcesEN.OrginialFileWidth; //OrginialFileWidth
 if (objPictureResourcesEN.PictureConfigerId !=  "")
 {
objRow[conPictureResources.PictureConfigerId] = objPictureResourcesEN.PictureConfigerId; //PictureConfigerId
 }
objRow[conPictureResources.ResizePictureName] = objPictureResourcesEN.ResizePictureName; //ResizePictureName
objRow[conPictureResources.ThumbName] = objPictureResourcesEN.ThumbName; //ThumbName
objRow[conPictureResources.OrginialFileHeight] = objPictureResourcesEN.OrginialFileHeight; //OrginialFileHeight
objDS.Tables[clsPictureResourcesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPictureResourcesEN._CurrTabName);
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureResourcesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureResourcesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.Memo);
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objPictureResourcesEN.PictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureName);
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileName);
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrginialFileName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileSize);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileSize.ToString());
 }
 
 if (objPictureResourcesEN.ResizePictureSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ResizePictureSize.ToString());
 }
 
 arrFieldListForInsert.Add(conPictureResources.ThumbSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ThumbSize.ToString());
 
 arrFieldListForInsert.Add(conPictureResources.OrginialFileWidth);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileWidth.ToString());
 
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureConfigerId);
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureName);
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResizePictureName + "'");
 }
 
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ThumbName);
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThumbName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileHeight !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileHeight);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileHeight.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureResources");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureResourcesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureResourcesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.Memo);
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objPictureResourcesEN.PictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureName);
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileName);
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrginialFileName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileSize);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileSize.ToString());
 }
 
 if (objPictureResourcesEN.ResizePictureSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ResizePictureSize.ToString());
 }
 
 arrFieldListForInsert.Add(conPictureResources.ThumbSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ThumbSize.ToString());
 
 arrFieldListForInsert.Add(conPictureResources.OrginialFileWidth);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileWidth.ToString());
 
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureConfigerId);
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureName);
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResizePictureName + "'");
 }
 
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ThumbName);
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThumbName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileHeight !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileHeight);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileHeight.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureResources");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPictureResourcesEN objPictureResourcesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureResourcesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureResourcesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.Memo);
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objPictureResourcesEN.PictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureName);
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileName);
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrginialFileName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileSize);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileSize.ToString());
 }
 
 if (objPictureResourcesEN.ResizePictureSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ResizePictureSize.ToString());
 }
 
 arrFieldListForInsert.Add(conPictureResources.ThumbSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ThumbSize.ToString());
 
 arrFieldListForInsert.Add(conPictureResources.OrginialFileWidth);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileWidth.ToString());
 
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureConfigerId);
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureName);
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResizePictureName + "'");
 }
 
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ThumbName);
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThumbName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileHeight !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileHeight);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileHeight.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureResources");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPictureResourcesEN objPictureResourcesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureResourcesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureResourcesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.Memo);
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objPictureResourcesEN.PictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureName);
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileName);
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrginialFileName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileSize);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileSize.ToString());
 }
 
 if (objPictureResourcesEN.ResizePictureSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ResizePictureSize.ToString());
 }
 
 arrFieldListForInsert.Add(conPictureResources.ThumbSize);
 arrValueListForInsert.Add(objPictureResourcesEN.ThumbSize.ToString());
 
 arrFieldListForInsert.Add(conPictureResources.OrginialFileWidth);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileWidth.ToString());
 
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.PictureConfigerId);
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ResizePictureName);
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResizePictureName + "'");
 }
 
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.ThumbName);
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThumbName + "'");
 }
 
 if (objPictureResourcesEN.OrginialFileHeight !=  null)
 {
 arrFieldListForInsert.Add(conPictureResources.OrginialFileHeight);
 arrValueListForInsert.Add(objPictureResourcesEN.OrginialFileHeight.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureResources");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPictureResourcess(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where PictureId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PictureResources");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intPictureId = TransNullToInt(oRow[conPictureResources.PictureId].ToString().Trim());
if (IsExist(intPictureId))
{
 string strResult = "关键字变量值为:" + string.Format("PictureId = {0}", intPictureId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPictureResourcesEN._CurrTabName ].NewRow();
objRow[conPictureResources.Memo] = oRow[conPictureResources.Memo].ToString().Trim(); //备注
objRow[conPictureResources.PictureName] = oRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objRow[conPictureResources.OrginialFileName] = oRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objRow[conPictureResources.OrginialFileSize] = oRow[conPictureResources.OrginialFileSize].ToString().Trim(); //OrginialFileSize
objRow[conPictureResources.ResizePictureSize] = oRow[conPictureResources.ResizePictureSize].ToString().Trim(); //ResizePictureSize
objRow[conPictureResources.ThumbSize] = oRow[conPictureResources.ThumbSize].ToString().Trim(); //ThumbSize
objRow[conPictureResources.OrginialFileWidth] = oRow[conPictureResources.OrginialFileWidth].ToString().Trim(); //OrginialFileWidth
objRow[conPictureResources.PictureConfigerId] = oRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objRow[conPictureResources.ResizePictureName] = oRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objRow[conPictureResources.ThumbName] = oRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objRow[conPictureResources.OrginialFileHeight] = oRow[conPictureResources.OrginialFileHeight].ToString().Trim(); //OrginialFileHeight
 objDS.Tables[clsPictureResourcesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPictureResourcesEN._CurrTabName);
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
 /// <param name = "objPictureResourcesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureResourcesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
strSQL = "Select * from PictureResources where PictureId = " + ""+ objPictureResourcesEN.PictureId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPictureResourcesEN._CurrTabName);
if (objDS.Tables[clsPictureResourcesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PictureId = " + ""+ objPictureResourcesEN.PictureId+"");
return false;
}
objRow = objDS.Tables[clsPictureResourcesEN._CurrTabName].Rows[0];
 if (objPictureResourcesEN.IsUpdated(conPictureResources.Memo))
 {
objRow[conPictureResources.Memo] = objPictureResourcesEN.Memo; //备注
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureName))
 {
objRow[conPictureResources.PictureName] = objPictureResourcesEN.PictureName; //PictureName
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileName))
 {
objRow[conPictureResources.OrginialFileName] = objPictureResourcesEN.OrginialFileName; //OrginialFileName
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileSize))
 {
objRow[conPictureResources.OrginialFileSize] = objPictureResourcesEN.OrginialFileSize; //OrginialFileSize
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureSize))
 {
objRow[conPictureResources.ResizePictureSize] = objPictureResourcesEN.ResizePictureSize; //ResizePictureSize
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbSize))
 {
objRow[conPictureResources.ThumbSize] = objPictureResourcesEN.ThumbSize; //ThumbSize
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileWidth))
 {
objRow[conPictureResources.OrginialFileWidth] = objPictureResourcesEN.OrginialFileWidth; //OrginialFileWidth
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureConfigerId))
 {
objRow[conPictureResources.PictureConfigerId] = objPictureResourcesEN.PictureConfigerId; //PictureConfigerId
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureName))
 {
objRow[conPictureResources.ResizePictureName] = objPictureResourcesEN.ResizePictureName; //ResizePictureName
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbName))
 {
objRow[conPictureResources.ThumbName] = objPictureResourcesEN.ThumbName; //ThumbName
 }
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileHeight))
 {
objRow[conPictureResources.OrginialFileHeight] = objPictureResourcesEN.OrginialFileHeight; //OrginialFileHeight
 }
try
{
objDA.Update(objDS, clsPictureResourcesEN._CurrTabName);
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureResourcesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PictureResources Set ");
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.Memo))
 {
 if (objPictureResourcesEN.Memo !=  null)
 {
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPictureResources.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.Memo); //备注
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureName))
 {
 if (objPictureResourcesEN.PictureName !=  null)
 {
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureName, conPictureResources.PictureName); //PictureName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.PictureName); //PictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileName))
 {
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOrginialFileName, conPictureResources.OrginialFileName); //OrginialFileName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.OrginialFileName); //OrginialFileName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileSize))
 {
 if (objPictureResourcesEN.OrginialFileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.OrginialFileSize, conPictureResources.OrginialFileSize); //OrginialFileSize
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.OrginialFileSize); //OrginialFileSize
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureSize))
 {
 if (objPictureResourcesEN.ResizePictureSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.ResizePictureSize, conPictureResources.ResizePictureSize); //ResizePictureSize
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.ResizePictureSize); //ResizePictureSize
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.ThumbSize, conPictureResources.ThumbSize); //ThumbSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.OrginialFileWidth, conPictureResources.OrginialFileWidth); //OrginialFileWidth
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureConfigerId))
 {
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureConfigerId, conPictureResources.PictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.PictureConfigerId); //PictureConfigerId
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureName))
 {
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResizePictureName, conPictureResources.ResizePictureName); //ResizePictureName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.ResizePictureName); //ResizePictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbName))
 {
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThumbName, conPictureResources.ThumbName); //ThumbName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.ThumbName); //ThumbName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileHeight))
 {
 if (objPictureResourcesEN.OrginialFileHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.OrginialFileHeight, conPictureResources.OrginialFileHeight); //OrginialFileHeight
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.OrginialFileHeight); //OrginialFileHeight
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PictureId = {0}", objPictureResourcesEN.PictureId); 
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
 /// <param name = "objPictureResourcesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPictureResourcesEN objPictureResourcesEN, string strCondition)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureResourcesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PictureResources Set ");
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.Memo))
 {
 if (objPictureResourcesEN.Memo !=  null)
 {
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureName))
 {
 if (objPictureResourcesEN.PictureName !=  null)
 {
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureName = '{0}',", strPictureName); //PictureName
 }
 else
 {
 sbSQL.Append(" PictureName = null,"); //PictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileName))
 {
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OrginialFileName = '{0}',", strOrginialFileName); //OrginialFileName
 }
 else
 {
 sbSQL.Append(" OrginialFileName = null,"); //OrginialFileName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileSize))
 {
 sbSQL.AppendFormat(" OrginialFileSize = {0},", objPictureResourcesEN.OrginialFileSize); //OrginialFileSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureSize))
 {
 sbSQL.AppendFormat(" ResizePictureSize = {0},", objPictureResourcesEN.ResizePictureSize); //ResizePictureSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbSize))
 {
 sbSQL.AppendFormat(" ThumbSize = {0},", objPictureResourcesEN.ThumbSize); //ThumbSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileWidth))
 {
 sbSQL.AppendFormat(" OrginialFileWidth = {0},", objPictureResourcesEN.OrginialFileWidth); //OrginialFileWidth
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureConfigerId))
 {
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureConfigerId = '{0}',", strPictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.Append(" PictureConfigerId = null,"); //PictureConfigerId
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureName))
 {
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResizePictureName = '{0}',", strResizePictureName); //ResizePictureName
 }
 else
 {
 sbSQL.Append(" ResizePictureName = null,"); //ResizePictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbName))
 {
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThumbName = '{0}',", strThumbName); //ThumbName
 }
 else
 {
 sbSQL.Append(" ThumbName = null,"); //ThumbName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileHeight))
 {
 sbSQL.AppendFormat(" OrginialFileHeight = {0},", objPictureResourcesEN.OrginialFileHeight); //OrginialFileHeight
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
 /// <param name = "objPictureResourcesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPictureResourcesEN objPictureResourcesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureResourcesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PictureResources Set ");
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.Memo))
 {
 if (objPictureResourcesEN.Memo !=  null)
 {
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureName))
 {
 if (objPictureResourcesEN.PictureName !=  null)
 {
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureName = '{0}',", strPictureName); //PictureName
 }
 else
 {
 sbSQL.Append(" PictureName = null,"); //PictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileName))
 {
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OrginialFileName = '{0}',", strOrginialFileName); //OrginialFileName
 }
 else
 {
 sbSQL.Append(" OrginialFileName = null,"); //OrginialFileName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileSize))
 {
 sbSQL.AppendFormat(" OrginialFileSize = {0},", objPictureResourcesEN.OrginialFileSize); //OrginialFileSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureSize))
 {
 sbSQL.AppendFormat(" ResizePictureSize = {0},", objPictureResourcesEN.ResizePictureSize); //ResizePictureSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbSize))
 {
 sbSQL.AppendFormat(" ThumbSize = {0},", objPictureResourcesEN.ThumbSize); //ThumbSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileWidth))
 {
 sbSQL.AppendFormat(" OrginialFileWidth = {0},", objPictureResourcesEN.OrginialFileWidth); //OrginialFileWidth
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureConfigerId))
 {
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureConfigerId = '{0}',", strPictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.Append(" PictureConfigerId = null,"); //PictureConfigerId
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureName))
 {
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResizePictureName = '{0}',", strResizePictureName); //ResizePictureName
 }
 else
 {
 sbSQL.Append(" ResizePictureName = null,"); //ResizePictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbName))
 {
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThumbName = '{0}',", strThumbName); //ThumbName
 }
 else
 {
 sbSQL.Append(" ThumbName = null,"); //ThumbName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileHeight))
 {
 sbSQL.AppendFormat(" OrginialFileHeight = {0},", objPictureResourcesEN.OrginialFileHeight); //OrginialFileHeight
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPictureResourcesEN objPictureResourcesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPictureResourcesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureResourcesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PictureResources Set ");
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.Memo))
 {
 if (objPictureResourcesEN.Memo !=  null)
 {
 var strMemo = objPictureResourcesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPictureResources.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.Memo); //备注
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureName))
 {
 if (objPictureResourcesEN.PictureName !=  null)
 {
 var strPictureName = objPictureResourcesEN.PictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureName, conPictureResources.PictureName); //PictureName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.PictureName); //PictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileName))
 {
 if (objPictureResourcesEN.OrginialFileName !=  null)
 {
 var strOrginialFileName = objPictureResourcesEN.OrginialFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOrginialFileName, conPictureResources.OrginialFileName); //OrginialFileName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.OrginialFileName); //OrginialFileName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileSize))
 {
 if (objPictureResourcesEN.OrginialFileSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.OrginialFileSize, conPictureResources.OrginialFileSize); //OrginialFileSize
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.OrginialFileSize); //OrginialFileSize
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureSize))
 {
 if (objPictureResourcesEN.ResizePictureSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.ResizePictureSize, conPictureResources.ResizePictureSize); //ResizePictureSize
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.ResizePictureSize); //ResizePictureSize
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.ThumbSize, conPictureResources.ThumbSize); //ThumbSize
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.OrginialFileWidth, conPictureResources.OrginialFileWidth); //OrginialFileWidth
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.PictureConfigerId))
 {
 if (objPictureResourcesEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objPictureResourcesEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureConfigerId, conPictureResources.PictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.PictureConfigerId); //PictureConfigerId
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ResizePictureName))
 {
 if (objPictureResourcesEN.ResizePictureName !=  null)
 {
 var strResizePictureName = objPictureResourcesEN.ResizePictureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResizePictureName, conPictureResources.ResizePictureName); //ResizePictureName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.ResizePictureName); //ResizePictureName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.ThumbName))
 {
 if (objPictureResourcesEN.ThumbName !=  null)
 {
 var strThumbName = objPictureResourcesEN.ThumbName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThumbName, conPictureResources.ThumbName); //ThumbName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.ThumbName); //ThumbName
 }
 }
 
 if (objPictureResourcesEN.IsUpdated(conPictureResources.OrginialFileHeight))
 {
 if (objPictureResourcesEN.OrginialFileHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureResourcesEN.OrginialFileHeight, conPictureResources.OrginialFileHeight); //OrginialFileHeight
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureResources.OrginialFileHeight); //OrginialFileHeight
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PictureId = {0}", objPictureResourcesEN.PictureId); 
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
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intPictureId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intPictureId,
};
 objSQL.ExecSP("PictureResources_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intPictureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
//删除PictureResources本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PictureResources where PictureId = " + ""+ intPictureId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPictureResources(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
//删除PictureResources本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PictureResources where PictureId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intPictureId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
//删除PictureResources本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PictureResources where PictureId = " + ""+ intPictureId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPictureResources(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPictureResourcesDA: DelPictureResources)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PictureResources where " + strCondition ;
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
public bool DelPictureResourcesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPictureResourcesDA: DelPictureResourcesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PictureResources where " + strCondition ;
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
 /// <param name = "objPictureResourcesENS">源对象</param>
 /// <param name = "objPictureResourcesENT">目标对象</param>
public void CopyTo(clsPictureResourcesEN objPictureResourcesENS, clsPictureResourcesEN objPictureResourcesENT)
{
objPictureResourcesENT.Memo = objPictureResourcesENS.Memo; //备注
objPictureResourcesENT.PictureId = objPictureResourcesENS.PictureId; //PictureId
objPictureResourcesENT.PictureName = objPictureResourcesENS.PictureName; //PictureName
objPictureResourcesENT.OrginialFileName = objPictureResourcesENS.OrginialFileName; //OrginialFileName
objPictureResourcesENT.OrginialFileSize = objPictureResourcesENS.OrginialFileSize; //OrginialFileSize
objPictureResourcesENT.ResizePictureSize = objPictureResourcesENS.ResizePictureSize; //ResizePictureSize
objPictureResourcesENT.ThumbSize = objPictureResourcesENS.ThumbSize; //ThumbSize
objPictureResourcesENT.OrginialFileWidth = objPictureResourcesENS.OrginialFileWidth; //OrginialFileWidth
objPictureResourcesENT.PictureConfigerId = objPictureResourcesENS.PictureConfigerId; //PictureConfigerId
objPictureResourcesENT.ResizePictureName = objPictureResourcesENS.ResizePictureName; //ResizePictureName
objPictureResourcesENT.ThumbName = objPictureResourcesENS.ThumbName; //ThumbName
objPictureResourcesENT.OrginialFileHeight = objPictureResourcesENS.OrginialFileHeight; //OrginialFileHeight
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPictureResourcesEN objPictureResourcesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPictureResourcesEN.PictureName, conPictureResources.PictureName);
clsCheckSql.CheckFieldNotNull(objPictureResourcesEN.ThumbSize, conPictureResources.ThumbSize);
clsCheckSql.CheckFieldNotNull(objPictureResourcesEN.OrginialFileWidth, conPictureResources.OrginialFileWidth);
clsCheckSql.CheckFieldNotNull(objPictureResourcesEN.ResizePictureName, conPictureResources.ResizePictureName);
clsCheckSql.CheckFieldNotNull(objPictureResourcesEN.ThumbName, conPictureResources.ThumbName);
//检查字段长度
clsCheckSql.CheckFieldLen(objPictureResourcesEN.Memo, 1000, conPictureResources.Memo);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.PictureName, 100, conPictureResources.PictureName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.OrginialFileName, 100, conPictureResources.OrginialFileName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.PictureConfigerId, 4, conPictureResources.PictureConfigerId);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.ResizePictureName, 100, conPictureResources.ResizePictureName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.ThumbName, 100, conPictureResources.ThumbName);
//检查字段外键固定长度
 objPictureResourcesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPictureResourcesEN objPictureResourcesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPictureResourcesEN.Memo, 1000, conPictureResources.Memo);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.PictureName, 100, conPictureResources.PictureName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.OrginialFileName, 100, conPictureResources.OrginialFileName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.PictureConfigerId, 4, conPictureResources.PictureConfigerId);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.ResizePictureName, 100, conPictureResources.ResizePictureName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.ThumbName, 100, conPictureResources.ThumbName);
//检查外键字段长度
 objPictureResourcesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPictureResourcesEN objPictureResourcesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPictureResourcesEN.Memo, 1000, conPictureResources.Memo);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.PictureName, 100, conPictureResources.PictureName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.OrginialFileName, 100, conPictureResources.OrginialFileName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.PictureConfigerId, 4, conPictureResources.PictureConfigerId);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.ResizePictureName, 100, conPictureResources.ResizePictureName);
clsCheckSql.CheckFieldLen(objPictureResourcesEN.ThumbName, 100, conPictureResources.ThumbName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPictureResourcesEN.Memo, conPictureResources.Memo);
clsCheckSql.CheckSqlInjection4Field(objPictureResourcesEN.PictureName, conPictureResources.PictureName);
clsCheckSql.CheckSqlInjection4Field(objPictureResourcesEN.OrginialFileName, conPictureResources.OrginialFileName);
clsCheckSql.CheckSqlInjection4Field(objPictureResourcesEN.PictureConfigerId, conPictureResources.PictureConfigerId);
clsCheckSql.CheckSqlInjection4Field(objPictureResourcesEN.ResizePictureName, conPictureResources.ResizePictureName);
clsCheckSql.CheckSqlInjection4Field(objPictureResourcesEN.ThumbName, conPictureResources.ThumbName);
//检查外键字段长度
 objPictureResourcesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PictureResources(图片资源),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPictureResourcesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPictureResourcesEN objPictureResourcesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 if (objPictureResourcesEN.PictureConfigerId == null)
{
 sbCondition.AppendFormat(" and PictureConfigerId is null");
}
else
{
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPictureResourcesEN._CurrTabName);
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPictureResourcesEN._CurrTabName, strCondition);
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
 objSQL = clsPictureResourcesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureConfigerDA
 表名:PictureConfiger(01120039)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 图片配置(PictureConfiger)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPictureConfigerDA : clsCommBase4DA
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
 return clsPictureConfigerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPictureConfigerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPictureConfigerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPictureConfigerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPictureConfigerEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPictureConfigerId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPictureConfigerId)
{
strPictureConfigerId = strPictureConfigerId.Replace("'", "''");
if (strPictureConfigerId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:PictureConfiger中,检查关键字,长度不正确!(clsPictureConfigerDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPictureConfigerId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PictureConfiger中,关键字不能为空 或 null!(clsPictureConfigerDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPictureConfigerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPictureConfigerDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PictureConfiger(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable_PictureConfiger)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PictureConfiger.* from PictureConfiger Left Join {1} on {2} where {3} and PictureConfiger.PictureConfigerId not in (Select top {5} PictureConfiger.PictureConfigerId from PictureConfiger Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1} and PictureConfigerId not in (Select top {2} PictureConfigerId from PictureConfiger where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1} and PictureConfigerId not in (Select top {3} PictureConfigerId from PictureConfiger where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPictureConfigerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PictureConfiger.* from PictureConfiger Left Join {1} on {2} where {3} and PictureConfiger.PictureConfigerId not in (Select top {5} PictureConfiger.PictureConfigerId from PictureConfiger Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1} and PictureConfigerId not in (Select top {2} PictureConfigerId from PictureConfiger where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PictureConfiger where {1} and PictureConfigerId not in (Select top {3} PictureConfigerId from PictureConfiger where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPictureConfigerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPictureConfigerDA:GetObjLst)", objException.Message));
}
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = TransNullToInt(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = TransNullToInt(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = TransNullToInt(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = TransNullToInt(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPictureConfigerDA: GetObjLst)", objException.Message));
}
objPictureConfigerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPictureConfigerEN);
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
public List<clsPictureConfigerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPictureConfigerDA:GetObjLstByTabName)", objException.Message));
}
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = TransNullToInt(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = TransNullToInt(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = TransNullToInt(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = TransNullToInt(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPictureConfigerDA: GetObjLst)", objException.Message));
}
objPictureConfigerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPictureConfigerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPictureConfiger(ref clsPictureConfigerEN objPictureConfigerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where PictureConfigerId = " + "'"+ objPictureConfigerEN.PictureConfigerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPictureConfigerEN.PictureConfigerId = objDT.Rows[0][conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objPictureConfigerEN.PictureConfigName = objDT.Rows[0][conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName(字段类型:varchar,字段长度:50,是否可空:True)
 objPictureConfigerEN.PicturePath = objDT.Rows[0][conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath(字段类型:varchar,字段长度:50,是否可空:True)
 objPictureConfigerEN.ThumbHeight = TransNullToInt(objDT.Rows[0][conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.ThumbWidth = TransNullToInt(objDT.Rows[0][conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.ResizePictureHeight = TransNullToInt(objDT.Rows[0][conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.MaxSize = objDT.Rows[0][conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize(字段类型:varchar,字段长度:50,是否可空:True)
 objPictureConfigerEN.ResizePictureWidth = TransNullToInt(objDT.Rows[0][conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.Memo = objDT.Rows[0][conPictureConfiger.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPictureConfigerDA: GetPictureConfiger)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPictureConfigerId">表关键字</param>
 /// <returns>表对象</returns>
public clsPictureConfigerEN GetObjByPictureConfigerId(string strPictureConfigerId)
{
CheckPrimaryKey(strPictureConfigerId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where PictureConfigerId = " + "'"+ strPictureConfigerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
 objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName(字段类型:varchar,字段长度:50,是否可空:True)
 objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath(字段类型:varchar,字段长度:50,是否可空:True)
 objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize(字段类型:varchar,字段长度:50,是否可空:True)
 objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth(字段类型:int,字段长度:4,是否可空:True)
 objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPictureConfigerDA: GetObjByPictureConfigerId)", objException.Message));
}
return objPictureConfigerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPictureConfigerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPictureConfigerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN()
{
PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(), //PictureConfigerId
PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(), //PictureConfigName
PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(), //PicturePath
ThumbHeight = TransNullToInt(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()), //ThumbHeight
ThumbWidth = TransNullToInt(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()), //ThumbWidth
ResizePictureHeight = TransNullToInt(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()), //ResizePictureHeight
MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(), //MaxSize
ResizePictureWidth = TransNullToInt(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()), //ResizePictureWidth
Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim() //备注
};
objPictureConfigerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPictureConfigerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPictureConfigerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPictureConfigerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = TransNullToInt(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = TransNullToInt(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = TransNullToInt(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = TransNullToInt(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPictureConfigerDA: GetObjByDataRowPictureConfiger)", objException.Message));
}
objPictureConfigerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPictureConfigerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPictureConfigerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = TransNullToInt(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = TransNullToInt(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = TransNullToInt(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = TransNullToInt(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPictureConfigerDA: GetObjByDataRow)", objException.Message));
}
objPictureConfigerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPictureConfigerEN;
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
objSQL = clsPictureConfigerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPictureConfigerEN._CurrTabName, conPictureConfiger.PictureConfigerId, 4, "");
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
objSQL = clsPictureConfigerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPictureConfigerEN._CurrTabName, conPictureConfiger.PictureConfigerId, 4, strPrefix);
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PictureConfigerId from PictureConfiger where " + strCondition;
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PictureConfigerId from PictureConfiger where " + strCondition;
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
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPictureConfigerId)
{
CheckPrimaryKey(strPictureConfigerId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PictureConfiger", "PictureConfigerId = " + "'"+ strPictureConfigerId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPictureConfigerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PictureConfiger", strCondition))
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
objSQL = clsPictureConfigerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PictureConfiger");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPictureConfigerEN objPictureConfigerEN)
 {
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureConfigerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PictureConfiger");
objRow = objDS.Tables["PictureConfiger"].NewRow();
objRow[conPictureConfiger.PictureConfigerId] = objPictureConfigerEN.PictureConfigerId; //PictureConfigerId
objRow[conPictureConfiger.PictureConfigName] = objPictureConfigerEN.PictureConfigName; //PictureConfigName
objRow[conPictureConfiger.PicturePath] = objPictureConfigerEN.PicturePath; //PicturePath
objRow[conPictureConfiger.ThumbHeight] = objPictureConfigerEN.ThumbHeight; //ThumbHeight
objRow[conPictureConfiger.ThumbWidth] = objPictureConfigerEN.ThumbWidth; //ThumbWidth
objRow[conPictureConfiger.ResizePictureHeight] = objPictureConfigerEN.ResizePictureHeight; //ResizePictureHeight
objRow[conPictureConfiger.MaxSize] = objPictureConfigerEN.MaxSize; //MaxSize
objRow[conPictureConfiger.ResizePictureWidth] = objPictureConfigerEN.ResizePictureWidth; //ResizePictureWidth
 if (objPictureConfigerEN.Memo !=  "")
 {
objRow[conPictureConfiger.Memo] = objPictureConfigerEN.Memo; //备注
 }
objDS.Tables[clsPictureConfigerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPictureConfigerEN._CurrTabName);
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPictureConfigerEN objPictureConfigerEN)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureConfigerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureConfigerEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigerId);
 var strPictureConfigerId = objPictureConfigerEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigName);
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigName + "'");
 }
 
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PicturePath);
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPicturePath + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbHeight.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbWidth.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureHeight.ToString());
 
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.MaxSize);
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxSize + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureWidth.ToString());
 
 if (objPictureConfigerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.Memo);
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureConfiger");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPictureConfigerEN objPictureConfigerEN)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureConfigerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureConfigerEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigerId);
 var strPictureConfigerId = objPictureConfigerEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigName);
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigName + "'");
 }
 
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PicturePath);
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPicturePath + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbHeight.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbWidth.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureHeight.ToString());
 
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.MaxSize);
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxSize + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureWidth.ToString());
 
 if (objPictureConfigerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.Memo);
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureConfiger");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPictureConfigerEN.PictureConfigerId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPictureConfigerEN objPictureConfigerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureConfigerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureConfigerEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigerId);
 var strPictureConfigerId = objPictureConfigerEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigName);
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigName + "'");
 }
 
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PicturePath);
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPicturePath + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbHeight.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbWidth.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureHeight.ToString());
 
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.MaxSize);
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxSize + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureWidth.ToString());
 
 if (objPictureConfigerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.Memo);
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureConfiger");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPictureConfigerEN.PictureConfigerId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPictureConfigerEN objPictureConfigerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPictureConfigerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPictureConfigerEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigerId);
 var strPictureConfigerId = objPictureConfigerEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PictureConfigName);
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigName + "'");
 }
 
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.PicturePath);
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPicturePath + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbHeight.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ThumbWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ThumbWidth.ToString());
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureHeight);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureHeight.ToString());
 
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.MaxSize);
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxSize + "'");
 }
 
 arrFieldListForInsert.Add(conPictureConfiger.ResizePictureWidth);
 arrValueListForInsert.Add(objPictureConfigerEN.ResizePictureWidth.ToString());
 
 if (objPictureConfigerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPictureConfiger.Memo);
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PictureConfiger");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPictureConfigers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where PictureConfigerId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PictureConfiger");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPictureConfigerId = oRow[conPictureConfiger.PictureConfigerId].ToString().Trim();
if (IsExist(strPictureConfigerId))
{
 string strResult = "关键字变量值为:" + string.Format("PictureConfigerId = {0}", strPictureConfigerId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPictureConfigerEN._CurrTabName ].NewRow();
objRow[conPictureConfiger.PictureConfigerId] = oRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objRow[conPictureConfiger.PictureConfigName] = oRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objRow[conPictureConfiger.PicturePath] = oRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objRow[conPictureConfiger.ThumbHeight] = oRow[conPictureConfiger.ThumbHeight].ToString().Trim(); //ThumbHeight
objRow[conPictureConfiger.ThumbWidth] = oRow[conPictureConfiger.ThumbWidth].ToString().Trim(); //ThumbWidth
objRow[conPictureConfiger.ResizePictureHeight] = oRow[conPictureConfiger.ResizePictureHeight].ToString().Trim(); //ResizePictureHeight
objRow[conPictureConfiger.MaxSize] = oRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objRow[conPictureConfiger.ResizePictureWidth] = oRow[conPictureConfiger.ResizePictureWidth].ToString().Trim(); //ResizePictureWidth
objRow[conPictureConfiger.Memo] = oRow[conPictureConfiger.Memo].ToString().Trim(); //备注
 objDS.Tables[clsPictureConfigerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPictureConfigerEN._CurrTabName);
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
 /// <param name = "objPictureConfigerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPictureConfigerEN objPictureConfigerEN)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureConfigerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
strSQL = "Select * from PictureConfiger where PictureConfigerId = " + "'"+ objPictureConfigerEN.PictureConfigerId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPictureConfigerEN._CurrTabName);
if (objDS.Tables[clsPictureConfigerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PictureConfigerId = " + "'"+ objPictureConfigerEN.PictureConfigerId+"'");
return false;
}
objRow = objDS.Tables[clsPictureConfigerEN._CurrTabName].Rows[0];
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PictureConfigerId))
 {
objRow[conPictureConfiger.PictureConfigerId] = objPictureConfigerEN.PictureConfigerId; //PictureConfigerId
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PictureConfigName))
 {
objRow[conPictureConfiger.PictureConfigName] = objPictureConfigerEN.PictureConfigName; //PictureConfigName
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PicturePath))
 {
objRow[conPictureConfiger.PicturePath] = objPictureConfigerEN.PicturePath; //PicturePath
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbHeight))
 {
objRow[conPictureConfiger.ThumbHeight] = objPictureConfigerEN.ThumbHeight; //ThumbHeight
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbWidth))
 {
objRow[conPictureConfiger.ThumbWidth] = objPictureConfigerEN.ThumbWidth; //ThumbWidth
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureHeight))
 {
objRow[conPictureConfiger.ResizePictureHeight] = objPictureConfigerEN.ResizePictureHeight; //ResizePictureHeight
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.MaxSize))
 {
objRow[conPictureConfiger.MaxSize] = objPictureConfigerEN.MaxSize; //MaxSize
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureWidth))
 {
objRow[conPictureConfiger.ResizePictureWidth] = objPictureConfigerEN.ResizePictureWidth; //ResizePictureWidth
 }
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.Memo))
 {
objRow[conPictureConfiger.Memo] = objPictureConfigerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsPictureConfigerEN._CurrTabName);
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPictureConfigerEN objPictureConfigerEN)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureConfigerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PictureConfiger Set ");
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PictureConfigName))
 {
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureConfigName, conPictureConfiger.PictureConfigName); //PictureConfigName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.PictureConfigName); //PictureConfigName
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PicturePath))
 {
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPicturePath, conPictureConfiger.PicturePath); //PicturePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.PicturePath); //PicturePath
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbHeight))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ThumbHeight, conPictureConfiger.ThumbHeight); //ThumbHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ThumbWidth, conPictureConfiger.ThumbWidth); //ThumbWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureHeight))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ResizePictureHeight, conPictureConfiger.ResizePictureHeight); //ResizePictureHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.MaxSize))
 {
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMaxSize, conPictureConfiger.MaxSize); //MaxSize
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.MaxSize); //MaxSize
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ResizePictureWidth, conPictureConfiger.ResizePictureWidth); //ResizePictureWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.Memo))
 {
 if (objPictureConfigerEN.Memo !=  null)
 {
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPictureConfiger.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PictureConfigerId = '{0}'", objPictureConfigerEN.PictureConfigerId); 
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
 /// <param name = "objPictureConfigerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPictureConfigerEN objPictureConfigerEN, string strCondition)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureConfigerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PictureConfiger Set ");
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PictureConfigName))
 {
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureConfigName = '{0}',", strPictureConfigName); //PictureConfigName
 }
 else
 {
 sbSQL.Append(" PictureConfigName = null,"); //PictureConfigName
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PicturePath))
 {
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PicturePath = '{0}',", strPicturePath); //PicturePath
 }
 else
 {
 sbSQL.Append(" PicturePath = null,"); //PicturePath
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbHeight))
 {
 sbSQL.AppendFormat(" ThumbHeight = {0},", objPictureConfigerEN.ThumbHeight); //ThumbHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbWidth))
 {
 sbSQL.AppendFormat(" ThumbWidth = {0},", objPictureConfigerEN.ThumbWidth); //ThumbWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureHeight))
 {
 sbSQL.AppendFormat(" ResizePictureHeight = {0},", objPictureConfigerEN.ResizePictureHeight); //ResizePictureHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.MaxSize))
 {
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MaxSize = '{0}',", strMaxSize); //MaxSize
 }
 else
 {
 sbSQL.Append(" MaxSize = null,"); //MaxSize
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureWidth))
 {
 sbSQL.AppendFormat(" ResizePictureWidth = {0},", objPictureConfigerEN.ResizePictureWidth); //ResizePictureWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.Memo))
 {
 if (objPictureConfigerEN.Memo !=  null)
 {
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPictureConfigerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPictureConfigerEN objPictureConfigerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureConfigerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PictureConfiger Set ");
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PictureConfigName))
 {
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureConfigName = '{0}',", strPictureConfigName); //PictureConfigName
 }
 else
 {
 sbSQL.Append(" PictureConfigName = null,"); //PictureConfigName
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PicturePath))
 {
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PicturePath = '{0}',", strPicturePath); //PicturePath
 }
 else
 {
 sbSQL.Append(" PicturePath = null,"); //PicturePath
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbHeight))
 {
 sbSQL.AppendFormat(" ThumbHeight = {0},", objPictureConfigerEN.ThumbHeight); //ThumbHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbWidth))
 {
 sbSQL.AppendFormat(" ThumbWidth = {0},", objPictureConfigerEN.ThumbWidth); //ThumbWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureHeight))
 {
 sbSQL.AppendFormat(" ResizePictureHeight = {0},", objPictureConfigerEN.ResizePictureHeight); //ResizePictureHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.MaxSize))
 {
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MaxSize = '{0}',", strMaxSize); //MaxSize
 }
 else
 {
 sbSQL.Append(" MaxSize = null,"); //MaxSize
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureWidth))
 {
 sbSQL.AppendFormat(" ResizePictureWidth = {0},", objPictureConfigerEN.ResizePictureWidth); //ResizePictureWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.Memo))
 {
 if (objPictureConfigerEN.Memo !=  null)
 {
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPictureConfigerEN objPictureConfigerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPictureConfigerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPictureConfigerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PictureConfiger Set ");
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PictureConfigName))
 {
 if (objPictureConfigerEN.PictureConfigName !=  null)
 {
 var strPictureConfigName = objPictureConfigerEN.PictureConfigName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureConfigName, conPictureConfiger.PictureConfigName); //PictureConfigName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.PictureConfigName); //PictureConfigName
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.PicturePath))
 {
 if (objPictureConfigerEN.PicturePath !=  null)
 {
 var strPicturePath = objPictureConfigerEN.PicturePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPicturePath, conPictureConfiger.PicturePath); //PicturePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.PicturePath); //PicturePath
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbHeight))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ThumbHeight, conPictureConfiger.ThumbHeight); //ThumbHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ThumbWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ThumbWidth, conPictureConfiger.ThumbWidth); //ThumbWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureHeight))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ResizePictureHeight, conPictureConfiger.ResizePictureHeight); //ResizePictureHeight
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.MaxSize))
 {
 if (objPictureConfigerEN.MaxSize !=  null)
 {
 var strMaxSize = objPictureConfigerEN.MaxSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMaxSize, conPictureConfiger.MaxSize); //MaxSize
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.MaxSize); //MaxSize
 }
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.ResizePictureWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objPictureConfigerEN.ResizePictureWidth, conPictureConfiger.ResizePictureWidth); //ResizePictureWidth
 }
 
 if (objPictureConfigerEN.IsUpdated(conPictureConfiger.Memo))
 {
 if (objPictureConfigerEN.Memo !=  null)
 {
 var strMemo = objPictureConfigerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPictureConfiger.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPictureConfiger.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PictureConfigerId = '{0}'", objPictureConfigerEN.PictureConfigerId); 
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
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPictureConfigerId) 
{
CheckPrimaryKey(strPictureConfigerId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPictureConfigerId,
};
 objSQL.ExecSP("PictureConfiger_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPictureConfigerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPictureConfigerId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
//删除PictureConfiger本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PictureConfiger where PictureConfigerId = " + "'"+ strPictureConfigerId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPictureConfiger(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
//删除PictureConfiger本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PictureConfiger where PictureConfigerId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPictureConfigerId) 
{
CheckPrimaryKey(strPictureConfigerId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
//删除PictureConfiger本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PictureConfiger where PictureConfigerId = " + "'"+ strPictureConfigerId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPictureConfiger(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPictureConfigerDA: DelPictureConfiger)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PictureConfiger where " + strCondition ;
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
public bool DelPictureConfigerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPictureConfigerDA: DelPictureConfigerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PictureConfiger where " + strCondition ;
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
 /// <param name = "objPictureConfigerENS">源对象</param>
 /// <param name = "objPictureConfigerENT">目标对象</param>
public void CopyTo(clsPictureConfigerEN objPictureConfigerENS, clsPictureConfigerEN objPictureConfigerENT)
{
objPictureConfigerENT.PictureConfigerId = objPictureConfigerENS.PictureConfigerId; //PictureConfigerId
objPictureConfigerENT.PictureConfigName = objPictureConfigerENS.PictureConfigName; //PictureConfigName
objPictureConfigerENT.PicturePath = objPictureConfigerENS.PicturePath; //PicturePath
objPictureConfigerENT.ThumbHeight = objPictureConfigerENS.ThumbHeight; //ThumbHeight
objPictureConfigerENT.ThumbWidth = objPictureConfigerENS.ThumbWidth; //ThumbWidth
objPictureConfigerENT.ResizePictureHeight = objPictureConfigerENS.ResizePictureHeight; //ResizePictureHeight
objPictureConfigerENT.MaxSize = objPictureConfigerENS.MaxSize; //MaxSize
objPictureConfigerENT.ResizePictureWidth = objPictureConfigerENS.ResizePictureWidth; //ResizePictureWidth
objPictureConfigerENT.Memo = objPictureConfigerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPictureConfigerEN objPictureConfigerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.PictureConfigName, conPictureConfiger.PictureConfigName);
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.PicturePath, conPictureConfiger.PicturePath);
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.ThumbHeight, conPictureConfiger.ThumbHeight);
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.ThumbWidth, conPictureConfiger.ThumbWidth);
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.ResizePictureHeight, conPictureConfiger.ResizePictureHeight);
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.MaxSize, conPictureConfiger.MaxSize);
clsCheckSql.CheckFieldNotNull(objPictureConfigerEN.ResizePictureWidth, conPictureConfiger.ResizePictureWidth);
//检查字段长度
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PictureConfigerId, 4, conPictureConfiger.PictureConfigerId);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PictureConfigName, 50, conPictureConfiger.PictureConfigName);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PicturePath, 50, conPictureConfiger.PicturePath);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.MaxSize, 50, conPictureConfiger.MaxSize);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.Memo, 1000, conPictureConfiger.Memo);
//检查字段外键固定长度
 objPictureConfigerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPictureConfigerEN objPictureConfigerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PictureConfigName, 50, conPictureConfiger.PictureConfigName);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PicturePath, 50, conPictureConfiger.PicturePath);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.MaxSize, 50, conPictureConfiger.MaxSize);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.Memo, 1000, conPictureConfiger.Memo);
//检查外键字段长度
 objPictureConfigerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPictureConfigerEN objPictureConfigerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PictureConfigerId, 4, conPictureConfiger.PictureConfigerId);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PictureConfigName, 50, conPictureConfiger.PictureConfigName);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.PicturePath, 50, conPictureConfiger.PicturePath);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.MaxSize, 50, conPictureConfiger.MaxSize);
clsCheckSql.CheckFieldLen(objPictureConfigerEN.Memo, 1000, conPictureConfiger.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPictureConfigerEN.PictureConfigerId, conPictureConfiger.PictureConfigerId);
clsCheckSql.CheckSqlInjection4Field(objPictureConfigerEN.PictureConfigName, conPictureConfiger.PictureConfigName);
clsCheckSql.CheckSqlInjection4Field(objPictureConfigerEN.PicturePath, conPictureConfiger.PicturePath);
clsCheckSql.CheckSqlInjection4Field(objPictureConfigerEN.MaxSize, conPictureConfiger.MaxSize);
clsCheckSql.CheckSqlInjection4Field(objPictureConfigerEN.Memo, conPictureConfiger.Memo);
//检查外键字段长度
 objPictureConfigerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPictureConfigerId()
{
//获取某学院所有专业信息
string strSQL = "select PictureConfigerId, PictureConfigName from PictureConfiger ";
 clsSpecSQLforSql mySql = clsPictureConfigerDA.GetSpecSQLObj();
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPictureConfigerEN._CurrTabName);
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPictureConfigerEN._CurrTabName, strCondition);
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
 objSQL = clsPictureConfigerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoCollectionLog15DA
 表名:vVideoCollectionLog15(01120301)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// v视频收藏日志15(vVideoCollectionLog15)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoCollectionLog15DA : clsCommBase4DA
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
 return clsvVideoCollectionLog15EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoCollectionLog15EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoCollectionLog15EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoCollectionLog15EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoCollectionLog15EN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoCollectionLog15(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable_vVideoCollectionLog15)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoCollectionLog15.* from vVideoCollectionLog15 Left Join {1} on {2} where {3} and vVideoCollectionLog15.IdVideoCollectionLog not in (Select top {5} vVideoCollectionLog15.IdVideoCollectionLog from vVideoCollectionLog15 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1} and IdVideoCollectionLog not in (Select top {2} IdVideoCollectionLog from vVideoCollectionLog15 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1} and IdVideoCollectionLog not in (Select top {3} IdVideoCollectionLog from vVideoCollectionLog15 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoCollectionLog15.* from vVideoCollectionLog15 Left Join {1} on {2} where {3} and vVideoCollectionLog15.IdVideoCollectionLog not in (Select top {5} vVideoCollectionLog15.IdVideoCollectionLog from vVideoCollectionLog15 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1} and IdVideoCollectionLog not in (Select top {2} IdVideoCollectionLog from vVideoCollectionLog15 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoCollectionLog15 where {1} and IdVideoCollectionLog not in (Select top {3} IdVideoCollectionLog from vVideoCollectionLog15 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoCollectionLog15EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA:GetObjLst)", objException.Message));
}
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = TransNullToInt(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetObjLst)", objException.Message));
}
objvVideoCollectionLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoCollectionLog15EN);
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
public List<clsvVideoCollectionLog15EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = TransNullToInt(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetObjLst)", objException.Message));
}
objvVideoCollectionLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoCollectionLog15EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoCollectionLog15(ref clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where IdVideoCollectionLog = " + ""+ objvVideoCollectionLog15EN.IdVideoCollectionLog+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoCollectionLog15EN.IdVideoCollectionLog = TransNullToInt(objDT.Rows[0][convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoCollectionLog15EN.FuncModuleId = objDT.Rows[0][convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoCollectionLog15EN.FuncModuleNameSim = objDT.Rows[0][convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoCollectionLog15EN.IdCase = objDT.Rows[0][convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoCollectionLog15EN.VideoLibName = objDT.Rows[0][convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoCollectionLog15EN.VideoUrl = objDT.Rows[0][convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoCollectionLog15EN.CoverPicUrl = objDT.Rows[0][convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoCollectionLog15EN.LikeNum = TransNullToInt(objDT.Rows[0][convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoCollectionLog15EN.PlayNum = TransNullToInt(objDT.Rows[0][convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoCollectionLog15EN.UserId = objDT.Rows[0][convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoCollectionLog15EN.CollectionDate = objDT.Rows[0][convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoCollectionLog15EN.Memo = objDT.Rows[0][convVideoCollectionLog15.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetvVideoCollectionLog15)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdVideoCollectionLog">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoCollectionLog15EN GetObjByIdVideoCollectionLog(long lngIdVideoCollectionLog)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where IdVideoCollectionLog = " + ""+ lngIdVideoCollectionLog+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
 objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetObjByIdVideoCollectionLog)", objException.Message));
}
return objvVideoCollectionLog15EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoCollectionLog15EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoCollectionLog15 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN()
{
IdVideoCollectionLog = TransNullToInt(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()), //视频收藏日志流水号
FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(), //功能模块简称
IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(), //案例流水号
VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(), //视频名称
VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(), //视频Url
CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(), //封面Url
LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()), //点赞数
PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()), //播放数
UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(), //用户ID
CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(), //收藏日期
Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim() //备注
};
objvVideoCollectionLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoCollectionLog15EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoCollectionLog15EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = TransNullToInt(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetObjByDataRowvVideoCollectionLog15)", objException.Message));
}
objvVideoCollectionLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoCollectionLog15EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoCollectionLog15EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = TransNullToInt(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoCollectionLog15DA: GetObjByDataRow)", objException.Message));
}
objvVideoCollectionLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoCollectionLog15EN;
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
objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoCollectionLog15EN._CurrTabName, convVideoCollectionLog15.IdVideoCollectionLog, 8, "");
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
objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoCollectionLog15EN._CurrTabName, convVideoCollectionLog15.IdVideoCollectionLog, 8, strPrefix);
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoCollectionLog from vVideoCollectionLog15 where " + strCondition;
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoCollectionLog from vVideoCollectionLog15 where " + strCondition;
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
 /// <param name = "lngIdVideoCollectionLog">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdVideoCollectionLog)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoCollectionLog15", "IdVideoCollectionLog = " + ""+ lngIdVideoCollectionLog+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoCollectionLog15DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoCollectionLog15", strCondition))
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
objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoCollectionLog15");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15ENS">源对象</param>
 /// <param name = "objvVideoCollectionLog15ENT">目标对象</param>
public void CopyTo(clsvVideoCollectionLog15EN objvVideoCollectionLog15ENS, clsvVideoCollectionLog15EN objvVideoCollectionLog15ENT)
{
objvVideoCollectionLog15ENT.IdVideoCollectionLog = objvVideoCollectionLog15ENS.IdVideoCollectionLog; //视频收藏日志流水号
objvVideoCollectionLog15ENT.FuncModuleId = objvVideoCollectionLog15ENS.FuncModuleId; //功能模块Id
objvVideoCollectionLog15ENT.FuncModuleNameSim = objvVideoCollectionLog15ENS.FuncModuleNameSim; //功能模块简称
objvVideoCollectionLog15ENT.IdCase = objvVideoCollectionLog15ENS.IdCase; //案例流水号
objvVideoCollectionLog15ENT.VideoLibName = objvVideoCollectionLog15ENS.VideoLibName; //视频名称
objvVideoCollectionLog15ENT.VideoUrl = objvVideoCollectionLog15ENS.VideoUrl; //视频Url
objvVideoCollectionLog15ENT.CoverPicUrl = objvVideoCollectionLog15ENS.CoverPicUrl; //封面Url
objvVideoCollectionLog15ENT.LikeNum = objvVideoCollectionLog15ENS.LikeNum; //点赞数
objvVideoCollectionLog15ENT.PlayNum = objvVideoCollectionLog15ENS.PlayNum; //播放数
objvVideoCollectionLog15ENT.UserId = objvVideoCollectionLog15ENS.UserId; //用户ID
objvVideoCollectionLog15ENT.CollectionDate = objvVideoCollectionLog15ENS.CollectionDate; //收藏日期
objvVideoCollectionLog15ENT.Memo = objvVideoCollectionLog15ENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.FuncModuleId, 4, convVideoCollectionLog15.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.FuncModuleNameSim, 30, convVideoCollectionLog15.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.IdCase, 8, convVideoCollectionLog15.IdCase);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.VideoLibName, 100, convVideoCollectionLog15.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.VideoUrl, 1000, convVideoCollectionLog15.VideoUrl);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.CoverPicUrl, 1000, convVideoCollectionLog15.CoverPicUrl);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.UserId, 18, convVideoCollectionLog15.UserId);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.CollectionDate, 20, convVideoCollectionLog15.CollectionDate);
clsCheckSql.CheckFieldLen(objvVideoCollectionLog15EN.Memo, 1000, convVideoCollectionLog15.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.FuncModuleId, convVideoCollectionLog15.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.FuncModuleNameSim, convVideoCollectionLog15.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.IdCase, convVideoCollectionLog15.IdCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.VideoLibName, convVideoCollectionLog15.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.VideoUrl, convVideoCollectionLog15.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.CoverPicUrl, convVideoCollectionLog15.CoverPicUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.UserId, convVideoCollectionLog15.UserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.CollectionDate, convVideoCollectionLog15.CollectionDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoCollectionLog15EN.Memo, convVideoCollectionLog15.Memo);
//检查外键字段长度
 objvVideoCollectionLog15EN._IsCheckProperty = true;
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoCollectionLog15EN._CurrTabName);
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoCollectionLog15EN._CurrTabName, strCondition);
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
 objSQL = clsvVideoCollectionLog15DA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
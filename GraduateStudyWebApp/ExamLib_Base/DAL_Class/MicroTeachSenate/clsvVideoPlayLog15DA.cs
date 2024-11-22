
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoPlayLog15DA
 表名:vVideoPlayLog15(01120299)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:52
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
 /// v视频播放日志表15(vVideoPlayLog15)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoPlayLog15DA : clsCommBase4DA
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
 return clsvVideoPlayLog15EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoPlayLog15EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoPlayLog15EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoPlayLog15EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoPlayLog15EN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoPlayLog15(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable_vVideoPlayLog15)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoPlayLog15.* from vVideoPlayLog15 Left Join {1} on {2} where {3} and vVideoPlayLog15.IdVideoPlayLog not in (Select top {5} vVideoPlayLog15.IdVideoPlayLog from vVideoPlayLog15 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1} and IdVideoPlayLog not in (Select top {2} IdVideoPlayLog from vVideoPlayLog15 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1} and IdVideoPlayLog not in (Select top {3} IdVideoPlayLog from vVideoPlayLog15 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoPlayLog15.* from vVideoPlayLog15 Left Join {1} on {2} where {3} and vVideoPlayLog15.IdVideoPlayLog not in (Select top {5} vVideoPlayLog15.IdVideoPlayLog from vVideoPlayLog15 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1} and IdVideoPlayLog not in (Select top {2} IdVideoPlayLog from vVideoPlayLog15 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoPlayLog15 where {1} and IdVideoPlayLog not in (Select top {3} IdVideoPlayLog from vVideoPlayLog15 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoPlayLog15EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA:GetObjLst)", objException.Message));
}
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = TransNullToInt(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetObjLst)", objException.Message));
}
objvVideoPlayLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoPlayLog15EN);
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
public List<clsvVideoPlayLog15EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = TransNullToInt(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetObjLst)", objException.Message));
}
objvVideoPlayLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoPlayLog15EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoPlayLog15(ref clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where IdVideoPlayLog = " + ""+ objvVideoPlayLog15EN.IdVideoPlayLog+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoPlayLog15EN.IdVideoPlayLog = TransNullToInt(objDT.Rows[0][convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoPlayLog15EN.FuncModuleId = objDT.Rows[0][convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoPlayLog15EN.FuncModuleNameSim = objDT.Rows[0][convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoPlayLog15EN.IdCase = objDT.Rows[0][convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoPlayLog15EN.VideoLibName = objDT.Rows[0][convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoPlayLog15EN.VideoUrl = objDT.Rows[0][convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoPlayLog15EN.CoverPicUrl = objDT.Rows[0][convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoPlayLog15EN.LikeNum = TransNullToInt(objDT.Rows[0][convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoPlayLog15EN.PlayNum = TransNullToInt(objDT.Rows[0][convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoPlayLog15EN.UserId = objDT.Rows[0][convVideoPlayLog15.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoPlayLog15EN.PlayDate = objDT.Rows[0][convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoPlayLog15EN.Memo = objDT.Rows[0][convVideoPlayLog15.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetvVideoPlayLog15)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoPlayLog15EN GetObjByIdVideoPlayLog(long lngIdVideoPlayLog)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where IdVideoPlayLog = " + ""+ lngIdVideoPlayLog+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
 objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetObjByIdVideoPlayLog)", objException.Message));
}
return objvVideoPlayLog15EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoPlayLog15EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
strSQL = "Select * from vVideoPlayLog15 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN()
{
IdVideoPlayLog = TransNullToInt(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()), //视频播放日志流水号
FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(), //功能模块简称
IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(), //案例流水号
VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(), //视频名称
VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(), //视频Url
CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(), //封面Url
LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()), //点赞数
PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()), //播放数
UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(), //用户ID
PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(), //播放日期
Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim() //备注
};
objvVideoPlayLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoPlayLog15EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoPlayLog15EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = TransNullToInt(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetObjByDataRowvVideoPlayLog15)", objException.Message));
}
objvVideoPlayLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoPlayLog15EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoPlayLog15EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = TransNullToInt(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoPlayLog15DA: GetObjByDataRow)", objException.Message));
}
objvVideoPlayLog15EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoPlayLog15EN;
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
objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoPlayLog15EN._CurrTabName, convVideoPlayLog15.IdVideoPlayLog, 8, "");
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
objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoPlayLog15EN._CurrTabName, convVideoPlayLog15.IdVideoPlayLog, 8, strPrefix);
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoPlayLog from vVideoPlayLog15 where " + strCondition;
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoPlayLog from vVideoPlayLog15 where " + strCondition;
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
 /// <param name = "lngIdVideoPlayLog">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdVideoPlayLog)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoPlayLog15", "IdVideoPlayLog = " + ""+ lngIdVideoPlayLog+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoPlayLog15DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoPlayLog15", strCondition))
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
objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoPlayLog15");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoPlayLog15ENS">源对象</param>
 /// <param name = "objvVideoPlayLog15ENT">目标对象</param>
public void CopyTo(clsvVideoPlayLog15EN objvVideoPlayLog15ENS, clsvVideoPlayLog15EN objvVideoPlayLog15ENT)
{
objvVideoPlayLog15ENT.IdVideoPlayLog = objvVideoPlayLog15ENS.IdVideoPlayLog; //视频播放日志流水号
objvVideoPlayLog15ENT.FuncModuleId = objvVideoPlayLog15ENS.FuncModuleId; //功能模块Id
objvVideoPlayLog15ENT.FuncModuleNameSim = objvVideoPlayLog15ENS.FuncModuleNameSim; //功能模块简称
objvVideoPlayLog15ENT.IdCase = objvVideoPlayLog15ENS.IdCase; //案例流水号
objvVideoPlayLog15ENT.VideoLibName = objvVideoPlayLog15ENS.VideoLibName; //视频名称
objvVideoPlayLog15ENT.VideoUrl = objvVideoPlayLog15ENS.VideoUrl; //视频Url
objvVideoPlayLog15ENT.CoverPicUrl = objvVideoPlayLog15ENS.CoverPicUrl; //封面Url
objvVideoPlayLog15ENT.LikeNum = objvVideoPlayLog15ENS.LikeNum; //点赞数
objvVideoPlayLog15ENT.PlayNum = objvVideoPlayLog15ENS.PlayNum; //播放数
objvVideoPlayLog15ENT.UserId = objvVideoPlayLog15ENS.UserId; //用户ID
objvVideoPlayLog15ENT.PlayDate = objvVideoPlayLog15ENS.PlayDate; //播放日期
objvVideoPlayLog15ENT.Memo = objvVideoPlayLog15ENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.FuncModuleId, 4, convVideoPlayLog15.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.FuncModuleNameSim, 30, convVideoPlayLog15.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.IdCase, 8, convVideoPlayLog15.IdCase);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.VideoLibName, 100, convVideoPlayLog15.VideoLibName);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.VideoUrl, 1000, convVideoPlayLog15.VideoUrl);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.CoverPicUrl, 1000, convVideoPlayLog15.CoverPicUrl);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.UserId, 18, convVideoPlayLog15.UserId);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.PlayDate, 20, convVideoPlayLog15.PlayDate);
clsCheckSql.CheckFieldLen(objvVideoPlayLog15EN.Memo, 1000, convVideoPlayLog15.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.FuncModuleId, convVideoPlayLog15.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.FuncModuleNameSim, convVideoPlayLog15.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.IdCase, convVideoPlayLog15.IdCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.VideoLibName, convVideoPlayLog15.VideoLibName);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.VideoUrl, convVideoPlayLog15.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.CoverPicUrl, convVideoPlayLog15.CoverPicUrl);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.UserId, convVideoPlayLog15.UserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.PlayDate, convVideoPlayLog15.PlayDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoPlayLog15EN.Memo, convVideoPlayLog15.Memo);
//检查外键字段长度
 objvVideoPlayLog15EN._IsCheckProperty = true;
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoPlayLog15EN._CurrTabName);
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoPlayLog15EN._CurrTabName, strCondition);
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
 objSQL = clsvVideoPlayLog15DA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
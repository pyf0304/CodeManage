
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGroupPicRelationDA
 表名:GroupPicRelation(01120036)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:13
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
 /// 用户组图片关系(GroupPicRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGroupPicRelationDA : clsCommBase4DA
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
 return clsGroupPicRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGroupPicRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGroupPicRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGroupPicRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGroupPicRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GroupPicRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable_GroupPicRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} GroupPicRelation.* from GroupPicRelation Left Join {1} on {2} where {3} and GroupPicRelation.RelationshipId not in (Select top {5} GroupPicRelation.RelationshipId from GroupPicRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1} and RelationshipId not in (Select top {2} RelationshipId from GroupPicRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1} and RelationshipId not in (Select top {3} RelationshipId from GroupPicRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} GroupPicRelation.* from GroupPicRelation Left Join {1} on {2} where {3} and GroupPicRelation.RelationshipId not in (Select top {5} GroupPicRelation.RelationshipId from GroupPicRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1} and RelationshipId not in (Select top {2} RelationshipId from GroupPicRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GroupPicRelation where {1} and RelationshipId not in (Select top {3} RelationshipId from GroupPicRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGroupPicRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGroupPicRelationDA:GetObjLst)", objException.Message));
}
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGroupPicRelationDA: GetObjLst)", objException.Message));
}
objGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGroupPicRelationEN);
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
public List<clsGroupPicRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGroupPicRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGroupPicRelationDA: GetObjLst)", objException.Message));
}
objGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGroupPicRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGroupPicRelation(ref clsGroupPicRelationEN objGroupPicRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where RelationshipId = " + ""+ objGroupPicRelationEN.RelationshipId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGroupPicRelationEN.RelationshipId = TransNullToInt(objDT.Rows[0][conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId(字段类型:int,字段长度:4,是否可空:True)
 objGroupPicRelationEN.GroupId = objDT.Rows[0][conGroupPicRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objGroupPicRelationEN.PictureId = TransNullToInt(objDT.Rows[0][conGroupPicRelation.PictureId].ToString().Trim()); //PictureId(字段类型:int,字段长度:4,是否可空:True)
 objGroupPicRelationEN.CreateTime = objDT.Rows[0][conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objGroupPicRelationEN.CreateUserID = objDT.Rows[0][conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objGroupPicRelationEN.LastModifyUserID = objDT.Rows[0][conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objGroupPicRelationEN.LastModifyTime = objDT.Rows[0][conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:16,是否可空:True)
 objGroupPicRelationEN.PictureConfigerId = objDT.Rows[0][conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objGroupPicRelationEN.Memo = objDT.Rows[0][conGroupPicRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGroupPicRelationDA: GetGroupPicRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public clsGroupPicRelationEN GetObjByRelationshipId(int intRelationshipId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where RelationshipId = " + ""+ intRelationshipId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
 objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId(字段类型:int,字段长度:4,是否可空:True)
 objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId(字段类型:int,字段长度:4,是否可空:True)
 objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:16,是否可空:True)
 objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGroupPicRelationDA: GetObjByRelationshipId)", objException.Message));
}
return objGroupPicRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGroupPicRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN()
{
RelationshipId = TransNullToInt(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()), //RelationshipId
GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(), //组Id
PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGroupPicRelation.PictureId].ToString().Trim()), //PictureId
CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(), //建立时间
CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(), //建立用户ID
LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(), //最后修改用户ID
LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(), //最后修改时间
PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(), //PictureConfigerId
Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim() //备注
};
objGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGroupPicRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGroupPicRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGroupPicRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGroupPicRelationDA: GetObjByDataRowGroupPicRelation)", objException.Message));
}
objGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGroupPicRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGroupPicRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGroupPicRelationDA: GetObjByDataRow)", objException.Message));
}
objGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGroupPicRelationEN;
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
objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGroupPicRelationEN._CurrTabName, conGroupPicRelation.RelationshipId, 4, "");
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
objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGroupPicRelationEN._CurrTabName, conGroupPicRelation.RelationshipId, 4, strPrefix);
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RelationshipId from GroupPicRelation where " + strCondition;
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RelationshipId from GroupPicRelation where " + strCondition;
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
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intRelationshipId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GroupPicRelation", "RelationshipId = " + ""+ intRelationshipId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGroupPicRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GroupPicRelation", strCondition))
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
objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GroupPicRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGroupPicRelationEN objGroupPicRelationEN)
 {
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGroupPicRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GroupPicRelation");
objRow = objDS.Tables["GroupPicRelation"].NewRow();
 if (objGroupPicRelationEN.GroupId !=  "")
 {
objRow[conGroupPicRelation.GroupId] = objGroupPicRelationEN.GroupId; //组Id
 }
objRow[conGroupPicRelation.PictureId] = objGroupPicRelationEN.PictureId; //PictureId
 if (objGroupPicRelationEN.CreateTime !=  "")
 {
objRow[conGroupPicRelation.CreateTime] = objGroupPicRelationEN.CreateTime; //建立时间
 }
 if (objGroupPicRelationEN.CreateUserID !=  "")
 {
objRow[conGroupPicRelation.CreateUserID] = objGroupPicRelationEN.CreateUserID; //建立用户ID
 }
 if (objGroupPicRelationEN.LastModifyUserID !=  "")
 {
objRow[conGroupPicRelation.LastModifyUserID] = objGroupPicRelationEN.LastModifyUserID; //最后修改用户ID
 }
 if (objGroupPicRelationEN.LastModifyTime !=  "")
 {
objRow[conGroupPicRelation.LastModifyTime] = objGroupPicRelationEN.LastModifyTime; //最后修改时间
 }
 if (objGroupPicRelationEN.PictureConfigerId !=  "")
 {
objRow[conGroupPicRelation.PictureConfigerId] = objGroupPicRelationEN.PictureConfigerId; //PictureConfigerId
 }
 if (objGroupPicRelationEN.Memo !=  "")
 {
objRow[conGroupPicRelation.Memo] = objGroupPicRelationEN.Memo; //备注
 }
objDS.Tables[clsGroupPicRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGroupPicRelationEN._CurrTabName);
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGroupPicRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.GroupId);
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objGroupPicRelationEN.PictureId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureId);
 arrValueListForInsert.Add(objGroupPicRelationEN.PictureId.ToString());
 }
 
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateTime);
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateUserID);
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyUserID);
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyTime);
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyTime + "'");
 }
 
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureConfigerId);
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objGroupPicRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.Memo);
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GroupPicRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGroupPicRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.GroupId);
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objGroupPicRelationEN.PictureId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureId);
 arrValueListForInsert.Add(objGroupPicRelationEN.PictureId.ToString());
 }
 
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateTime);
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateUserID);
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyUserID);
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyTime);
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyTime + "'");
 }
 
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureConfigerId);
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objGroupPicRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.Memo);
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GroupPicRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGroupPicRelationEN objGroupPicRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGroupPicRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.GroupId);
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objGroupPicRelationEN.PictureId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureId);
 arrValueListForInsert.Add(objGroupPicRelationEN.PictureId.ToString());
 }
 
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateTime);
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateUserID);
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyUserID);
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyTime);
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyTime + "'");
 }
 
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureConfigerId);
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objGroupPicRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.Memo);
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GroupPicRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGroupPicRelationEN objGroupPicRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGroupPicRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.GroupId);
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupId + "'");
 }
 
 if (objGroupPicRelationEN.PictureId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureId);
 arrValueListForInsert.Add(objGroupPicRelationEN.PictureId.ToString());
 }
 
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateTime);
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.CreateUserID);
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyUserID);
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyUserID + "'");
 }
 
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.LastModifyTime);
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastModifyTime + "'");
 }
 
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.PictureConfigerId);
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPictureConfigerId + "'");
 }
 
 if (objGroupPicRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGroupPicRelation.Memo);
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GroupPicRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGroupPicRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where RelationshipId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GroupPicRelation");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intRelationshipId = TransNullToInt(oRow[conGroupPicRelation.RelationshipId].ToString().Trim());
if (IsExist(intRelationshipId))
{
 string strResult = "关键字变量值为:" + string.Format("RelationshipId = {0}", intRelationshipId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGroupPicRelationEN._CurrTabName ].NewRow();
objRow[conGroupPicRelation.GroupId] = oRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objRow[conGroupPicRelation.PictureId] = oRow[conGroupPicRelation.PictureId].ToString().Trim(); //PictureId
objRow[conGroupPicRelation.CreateTime] = oRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objRow[conGroupPicRelation.CreateUserID] = oRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objRow[conGroupPicRelation.LastModifyUserID] = oRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRow[conGroupPicRelation.LastModifyTime] = oRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objRow[conGroupPicRelation.PictureConfigerId] = oRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objRow[conGroupPicRelation.Memo] = oRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
 objDS.Tables[clsGroupPicRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGroupPicRelationEN._CurrTabName);
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
 /// <param name = "objGroupPicRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGroupPicRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from GroupPicRelation where RelationshipId = " + ""+ objGroupPicRelationEN.RelationshipId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGroupPicRelationEN._CurrTabName);
if (objDS.Tables[clsGroupPicRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RelationshipId = " + ""+ objGroupPicRelationEN.RelationshipId+"");
return false;
}
objRow = objDS.Tables[clsGroupPicRelationEN._CurrTabName].Rows[0];
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.GroupId))
 {
objRow[conGroupPicRelation.GroupId] = objGroupPicRelationEN.GroupId; //组Id
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureId))
 {
objRow[conGroupPicRelation.PictureId] = objGroupPicRelationEN.PictureId; //PictureId
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateTime))
 {
objRow[conGroupPicRelation.CreateTime] = objGroupPicRelationEN.CreateTime; //建立时间
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateUserID))
 {
objRow[conGroupPicRelation.CreateUserID] = objGroupPicRelationEN.CreateUserID; //建立用户ID
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyUserID))
 {
objRow[conGroupPicRelation.LastModifyUserID] = objGroupPicRelationEN.LastModifyUserID; //最后修改用户ID
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyTime))
 {
objRow[conGroupPicRelation.LastModifyTime] = objGroupPicRelationEN.LastModifyTime; //最后修改时间
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureConfigerId))
 {
objRow[conGroupPicRelation.PictureConfigerId] = objGroupPicRelationEN.PictureConfigerId; //PictureConfigerId
 }
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.Memo))
 {
objRow[conGroupPicRelation.Memo] = objGroupPicRelationEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsGroupPicRelationEN._CurrTabName);
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGroupPicRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GroupPicRelation Set ");
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.GroupId))
 {
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupId, conGroupPicRelation.GroupId); //组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.GroupId); //组Id
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureId))
 {
 if (objGroupPicRelationEN.PictureId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGroupPicRelationEN.PictureId, conGroupPicRelation.PictureId); //PictureId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.PictureId); //PictureId
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateTime))
 {
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, conGroupPicRelation.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.CreateTime); //建立时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateUserID))
 {
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserID, conGroupPicRelation.CreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.CreateUserID); //建立用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyUserID))
 {
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastModifyUserID, conGroupPicRelation.LastModifyUserID); //最后修改用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.LastModifyUserID); //最后修改用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyTime))
 {
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastModifyTime, conGroupPicRelation.LastModifyTime); //最后修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.LastModifyTime); //最后修改时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureConfigerId))
 {
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureConfigerId, conGroupPicRelation.PictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.PictureConfigerId); //PictureConfigerId
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.Memo))
 {
 if (objGroupPicRelationEN.Memo !=  null)
 {
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGroupPicRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelationshipId = {0}", objGroupPicRelationEN.RelationshipId); 
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
 /// <param name = "objGroupPicRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGroupPicRelationEN objGroupPicRelationEN, string strCondition)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGroupPicRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GroupPicRelation Set ");
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.GroupId))
 {
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupId = '{0}',", strGroupId); //组Id
 }
 else
 {
 sbSQL.Append(" GroupId = null,"); //组Id
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureId))
 {
 sbSQL.AppendFormat(" PictureId = {0},", objGroupPicRelationEN.PictureId); //PictureId
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateTime))
 {
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateUserID))
 {
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserID = '{0}',", strCreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.Append(" CreateUserID = null,"); //建立用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyUserID))
 {
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastModifyUserID = '{0}',", strLastModifyUserID); //最后修改用户ID
 }
 else
 {
 sbSQL.Append(" LastModifyUserID = null,"); //最后修改用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyTime))
 {
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastModifyTime = '{0}',", strLastModifyTime); //最后修改时间
 }
 else
 {
 sbSQL.Append(" LastModifyTime = null,"); //最后修改时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureConfigerId))
 {
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureConfigerId = '{0}',", strPictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.Append(" PictureConfigerId = null,"); //PictureConfigerId
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.Memo))
 {
 if (objGroupPicRelationEN.Memo !=  null)
 {
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGroupPicRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGroupPicRelationEN objGroupPicRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGroupPicRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GroupPicRelation Set ");
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.GroupId))
 {
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupId = '{0}',", strGroupId); //组Id
 }
 else
 {
 sbSQL.Append(" GroupId = null,"); //组Id
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureId))
 {
 sbSQL.AppendFormat(" PictureId = {0},", objGroupPicRelationEN.PictureId); //PictureId
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateTime))
 {
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateUserID))
 {
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserID = '{0}',", strCreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.Append(" CreateUserID = null,"); //建立用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyUserID))
 {
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastModifyUserID = '{0}',", strLastModifyUserID); //最后修改用户ID
 }
 else
 {
 sbSQL.Append(" LastModifyUserID = null,"); //最后修改用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyTime))
 {
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastModifyTime = '{0}',", strLastModifyTime); //最后修改时间
 }
 else
 {
 sbSQL.Append(" LastModifyTime = null,"); //最后修改时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureConfigerId))
 {
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PictureConfigerId = '{0}',", strPictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.Append(" PictureConfigerId = null,"); //PictureConfigerId
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.Memo))
 {
 if (objGroupPicRelationEN.Memo !=  null)
 {
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGroupPicRelationEN objGroupPicRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objGroupPicRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGroupPicRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GroupPicRelation Set ");
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.GroupId))
 {
 if (objGroupPicRelationEN.GroupId !=  null)
 {
 var strGroupId = objGroupPicRelationEN.GroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupId, conGroupPicRelation.GroupId); //组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.GroupId); //组Id
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureId))
 {
 if (objGroupPicRelationEN.PictureId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGroupPicRelationEN.PictureId, conGroupPicRelation.PictureId); //PictureId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.PictureId); //PictureId
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateTime))
 {
 if (objGroupPicRelationEN.CreateTime !=  null)
 {
 var strCreateTime = objGroupPicRelationEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, conGroupPicRelation.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.CreateTime); //建立时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.CreateUserID))
 {
 if (objGroupPicRelationEN.CreateUserID !=  null)
 {
 var strCreateUserID = objGroupPicRelationEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserID, conGroupPicRelation.CreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.CreateUserID); //建立用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyUserID))
 {
 if (objGroupPicRelationEN.LastModifyUserID !=  null)
 {
 var strLastModifyUserID = objGroupPicRelationEN.LastModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastModifyUserID, conGroupPicRelation.LastModifyUserID); //最后修改用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.LastModifyUserID); //最后修改用户ID
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.LastModifyTime))
 {
 if (objGroupPicRelationEN.LastModifyTime !=  null)
 {
 var strLastModifyTime = objGroupPicRelationEN.LastModifyTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastModifyTime, conGroupPicRelation.LastModifyTime); //最后修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.LastModifyTime); //最后修改时间
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.PictureConfigerId))
 {
 if (objGroupPicRelationEN.PictureConfigerId !=  null)
 {
 var strPictureConfigerId = objGroupPicRelationEN.PictureConfigerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPictureConfigerId, conGroupPicRelation.PictureConfigerId); //PictureConfigerId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.PictureConfigerId); //PictureConfigerId
 }
 }
 
 if (objGroupPicRelationEN.IsUpdated(conGroupPicRelation.Memo))
 {
 if (objGroupPicRelationEN.Memo !=  null)
 {
 var strMemo = objGroupPicRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGroupPicRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGroupPicRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelationshipId = {0}", objGroupPicRelationEN.RelationshipId); 
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
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intRelationshipId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intRelationshipId,
};
 objSQL.ExecSP("GroupPicRelation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intRelationshipId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
//删除GroupPicRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GroupPicRelation where RelationshipId = " + ""+ intRelationshipId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelGroupPicRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
//删除GroupPicRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GroupPicRelation where RelationshipId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intRelationshipId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
//删除GroupPicRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GroupPicRelation where RelationshipId = " + ""+ intRelationshipId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGroupPicRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: DelGroupPicRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GroupPicRelation where " + strCondition ;
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
public bool DelGroupPicRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGroupPicRelationDA: DelGroupPicRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GroupPicRelation where " + strCondition ;
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
 /// <param name = "objGroupPicRelationENS">源对象</param>
 /// <param name = "objGroupPicRelationENT">目标对象</param>
public void CopyTo(clsGroupPicRelationEN objGroupPicRelationENS, clsGroupPicRelationEN objGroupPicRelationENT)
{
objGroupPicRelationENT.RelationshipId = objGroupPicRelationENS.RelationshipId; //RelationshipId
objGroupPicRelationENT.GroupId = objGroupPicRelationENS.GroupId; //组Id
objGroupPicRelationENT.PictureId = objGroupPicRelationENS.PictureId; //PictureId
objGroupPicRelationENT.CreateTime = objGroupPicRelationENS.CreateTime; //建立时间
objGroupPicRelationENT.CreateUserID = objGroupPicRelationENS.CreateUserID; //建立用户ID
objGroupPicRelationENT.LastModifyUserID = objGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objGroupPicRelationENT.LastModifyTime = objGroupPicRelationENS.LastModifyTime; //最后修改时间
objGroupPicRelationENT.PictureConfigerId = objGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objGroupPicRelationENT.Memo = objGroupPicRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGroupPicRelationEN objGroupPicRelationEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.GroupId, 8, conGroupPicRelation.GroupId);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.CreateTime, 16, conGroupPicRelation.CreateTime);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.CreateUserID, 20, conGroupPicRelation.CreateUserID);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.LastModifyUserID, 20, conGroupPicRelation.LastModifyUserID);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.LastModifyTime, 16, conGroupPicRelation.LastModifyTime);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.PictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.Memo, 1000, conGroupPicRelation.Memo);
//检查字段外键固定长度
 objGroupPicRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGroupPicRelationEN objGroupPicRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.GroupId, 8, conGroupPicRelation.GroupId);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.CreateTime, 16, conGroupPicRelation.CreateTime);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.CreateUserID, 20, conGroupPicRelation.CreateUserID);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.LastModifyUserID, 20, conGroupPicRelation.LastModifyUserID);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.LastModifyTime, 16, conGroupPicRelation.LastModifyTime);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.PictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.Memo, 1000, conGroupPicRelation.Memo);
//检查外键字段长度
 objGroupPicRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGroupPicRelationEN objGroupPicRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.GroupId, 8, conGroupPicRelation.GroupId);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.CreateTime, 16, conGroupPicRelation.CreateTime);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.CreateUserID, 20, conGroupPicRelation.CreateUserID);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.LastModifyUserID, 20, conGroupPicRelation.LastModifyUserID);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.LastModifyTime, 16, conGroupPicRelation.LastModifyTime);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.PictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckFieldLen(objGroupPicRelationEN.Memo, 1000, conGroupPicRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.GroupId, conGroupPicRelation.GroupId);
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.CreateTime, conGroupPicRelation.CreateTime);
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.CreateUserID, conGroupPicRelation.CreateUserID);
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.LastModifyUserID, conGroupPicRelation.LastModifyUserID);
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.LastModifyTime, conGroupPicRelation.LastModifyTime);
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.PictureConfigerId, conGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckSqlInjection4Field(objGroupPicRelationEN.Memo, conGroupPicRelation.Memo);
//检查外键字段长度
 objGroupPicRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--GroupPicRelation(用户组图片关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsGroupPicRelationEN objGroupPicRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objGroupPicRelationEN.GroupId == null)
{
 sbCondition.AppendFormat(" and GroupId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
}
 if (objGroupPicRelationEN.PictureId == null)
{
 sbCondition.AppendFormat(" and PictureId is null");
}
else
{
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGroupPicRelationEN._CurrTabName);
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGroupPicRelationEN._CurrTabName, strCondition);
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
 objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
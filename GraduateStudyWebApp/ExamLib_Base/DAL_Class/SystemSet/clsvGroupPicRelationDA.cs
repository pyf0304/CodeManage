
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGroupPicRelationDA
 表名:vGroupPicRelation(01120018)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:43
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
 /// v用户组图片关系(vGroupPicRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvGroupPicRelationDA : clsCommBase4DA
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
 return clsvGroupPicRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvGroupPicRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvGroupPicRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvGroupPicRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvGroupPicRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vGroupPicRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable_vGroupPicRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vGroupPicRelation.* from vGroupPicRelation Left Join {1} on {2} where {3} and vGroupPicRelation.RelationshipId not in (Select top {5} vGroupPicRelation.RelationshipId from vGroupPicRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1} and RelationshipId not in (Select top {2} RelationshipId from vGroupPicRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1} and RelationshipId not in (Select top {3} RelationshipId from vGroupPicRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vGroupPicRelation.* from vGroupPicRelation Left Join {1} on {2} where {3} and vGroupPicRelation.RelationshipId not in (Select top {5} vGroupPicRelation.RelationshipId from vGroupPicRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1} and RelationshipId not in (Select top {2} RelationshipId from vGroupPicRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vGroupPicRelation where {1} and RelationshipId not in (Select top {3} RelationshipId from vGroupPicRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvGroupPicRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA:GetObjLst)", objException.Message));
}
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvGroupPicRelationDA: GetObjLst)", objException.Message));
}
objvGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvGroupPicRelationEN);
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
public List<clsvGroupPicRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvGroupPicRelationDA: GetObjLst)", objException.Message));
}
objvGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvGroupPicRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvGroupPicRelation(ref clsvGroupPicRelationEN objvGroupPicRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where RelationshipId = " + ""+ objvGroupPicRelationEN.RelationshipId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvGroupPicRelationEN.Memo = objDT.Rows[0][convGroupPicRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvGroupPicRelationEN.GroupId = objDT.Rows[0][convGroupPicRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objvGroupPicRelationEN.RelationshipId = TransNullToInt(objDT.Rows[0][convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.GroupName = objDT.Rows[0][convGroupPicRelation.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:40,是否可空:True)
 objvGroupPicRelationEN.PictureId = TransNullToInt(objDT.Rows[0][convGroupPicRelation.PictureId].ToString().Trim()); //PictureId(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.PictureName = objDT.Rows[0][convGroupPicRelation.PictureName].ToString().Trim(); //PictureName(字段类型:varchar,字段长度:100,是否可空:True)
 objvGroupPicRelationEN.PictureConfigName = objDT.Rows[0][convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName(字段类型:varchar,字段长度:50,是否可空:True)
 objvGroupPicRelationEN.CreateTime = objDT.Rows[0][convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objvGroupPicRelationEN.CreateUserID = objDT.Rows[0][convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objvGroupPicRelationEN.LastModifyUserID = objDT.Rows[0][convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objvGroupPicRelationEN.LastModifyTime = objDT.Rows[0][convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:16,是否可空:True)
 objvGroupPicRelationEN.LastModifyUserName = objDT.Rows[0][convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvGroupPicRelationEN.PictureConfigerId = objDT.Rows[0][convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.OrginialFileName = objDT.Rows[0][convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName(字段类型:varchar,字段长度:100,是否可空:True)
 objvGroupPicRelationEN.OrginialFileSize = TransNullToInt(objDT.Rows[0][convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.ResizePictureSize = TransNullToInt(objDT.Rows[0][convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.ThumbSize = TransNullToInt(objDT.Rows[0][convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.OrginialFileWidth = TransNullToInt(objDT.Rows[0][convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.CreateUserName = objDT.Rows[0][convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvGroupPicRelationEN.PicturePath = objDT.Rows[0][convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvGroupPicRelationDA: GetvGroupPicRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public clsvGroupPicRelationEN GetObjByRelationshipId(int intRelationshipId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where RelationshipId = " + ""+ intRelationshipId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
 objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id(字段类型:char,字段长度:8,是否可空:True)
 objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:40,是否可空:True)
 objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName(字段类型:varchar,字段长度:100,是否可空:True)
 objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName(字段类型:varchar,字段长度:50,是否可空:True)
 objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:16,是否可空:True)
 objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId(字段类型:char,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName(字段类型:varchar,字段长度:100,是否可空:True)
 objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth(字段类型:int,字段长度:4,是否可空:True)
 objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvGroupPicRelationDA: GetObjByRelationshipId)", objException.Message));
}
return objvGroupPicRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvGroupPicRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
strSQL = "Select * from vGroupPicRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN()
{
Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(), //备注
GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(), //组Id
RelationshipId = TransNullToInt(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()), //RelationshipId
GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(), //组名
PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.PictureId].ToString().Trim()), //PictureId
PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(), //PictureName
PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(), //PictureConfigName
CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(), //建立时间
CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(), //建立用户ID
LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(), //最后修改用户ID
LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(), //最后修改时间
LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(), //最后修改用户名
PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(), //PictureConfigerId
OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(), //OrginialFileName
OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()), //OrginialFileSize
ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()), //ResizePictureSize
ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()), //ThumbSize
OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()), //OrginialFileWidth
CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(), //建立用户名
PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim() //PicturePath
};
objvGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvGroupPicRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvGroupPicRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvGroupPicRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvGroupPicRelationDA: GetObjByDataRowvGroupPicRelation)", objException.Message));
}
objvGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvGroupPicRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvGroupPicRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = TransNullToInt(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvGroupPicRelationDA: GetObjByDataRow)", objException.Message));
}
objvGroupPicRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvGroupPicRelationEN;
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
objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvGroupPicRelationEN._CurrTabName, convGroupPicRelation.RelationshipId, 4, "");
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
objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvGroupPicRelationEN._CurrTabName, convGroupPicRelation.RelationshipId, 4, strPrefix);
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RelationshipId from vGroupPicRelation where " + strCondition;
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RelationshipId from vGroupPicRelation where " + strCondition;
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vGroupPicRelation", "RelationshipId = " + ""+ intRelationshipId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvGroupPicRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vGroupPicRelation", strCondition))
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
objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vGroupPicRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvGroupPicRelationENS">源对象</param>
 /// <param name = "objvGroupPicRelationENT">目标对象</param>
public void CopyTo(clsvGroupPicRelationEN objvGroupPicRelationENS, clsvGroupPicRelationEN objvGroupPicRelationENT)
{
objvGroupPicRelationENT.Memo = objvGroupPicRelationENS.Memo; //备注
objvGroupPicRelationENT.GroupId = objvGroupPicRelationENS.GroupId; //组Id
objvGroupPicRelationENT.RelationshipId = objvGroupPicRelationENS.RelationshipId; //RelationshipId
objvGroupPicRelationENT.GroupName = objvGroupPicRelationENS.GroupName; //组名
objvGroupPicRelationENT.PictureId = objvGroupPicRelationENS.PictureId; //PictureId
objvGroupPicRelationENT.PictureName = objvGroupPicRelationENS.PictureName; //PictureName
objvGroupPicRelationENT.PictureConfigName = objvGroupPicRelationENS.PictureConfigName; //PictureConfigName
objvGroupPicRelationENT.CreateTime = objvGroupPicRelationENS.CreateTime; //建立时间
objvGroupPicRelationENT.CreateUserID = objvGroupPicRelationENS.CreateUserID; //建立用户ID
objvGroupPicRelationENT.LastModifyUserID = objvGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objvGroupPicRelationENT.LastModifyTime = objvGroupPicRelationENS.LastModifyTime; //最后修改时间
objvGroupPicRelationENT.LastModifyUserName = objvGroupPicRelationENS.LastModifyUserName; //最后修改用户名
objvGroupPicRelationENT.PictureConfigerId = objvGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objvGroupPicRelationENT.OrginialFileName = objvGroupPicRelationENS.OrginialFileName; //OrginialFileName
objvGroupPicRelationENT.OrginialFileSize = objvGroupPicRelationENS.OrginialFileSize; //OrginialFileSize
objvGroupPicRelationENT.ResizePictureSize = objvGroupPicRelationENS.ResizePictureSize; //ResizePictureSize
objvGroupPicRelationENT.ThumbSize = objvGroupPicRelationENS.ThumbSize; //ThumbSize
objvGroupPicRelationENT.OrginialFileWidth = objvGroupPicRelationENS.OrginialFileWidth; //OrginialFileWidth
objvGroupPicRelationENT.CreateUserName = objvGroupPicRelationENS.CreateUserName; //建立用户名
objvGroupPicRelationENT.PicturePath = objvGroupPicRelationENS.PicturePath; //PicturePath
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvGroupPicRelationEN objvGroupPicRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.Memo, 1000, convGroupPicRelation.Memo);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.GroupId, 8, convGroupPicRelation.GroupId);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.GroupName, 40, convGroupPicRelation.GroupName);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.PictureName, 100, convGroupPicRelation.PictureName);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.PictureConfigName, 50, convGroupPicRelation.PictureConfigName);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.CreateTime, 16, convGroupPicRelation.CreateTime);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.CreateUserID, 20, convGroupPicRelation.CreateUserID);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.LastModifyUserID, 20, convGroupPicRelation.LastModifyUserID);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.LastModifyTime, 16, convGroupPicRelation.LastModifyTime);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.LastModifyUserName, 30, convGroupPicRelation.LastModifyUserName);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.PictureConfigerId, 4, convGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.OrginialFileName, 100, convGroupPicRelation.OrginialFileName);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.CreateUserName, 30, convGroupPicRelation.CreateUserName);
clsCheckSql.CheckFieldLen(objvGroupPicRelationEN.PicturePath, 50, convGroupPicRelation.PicturePath);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.Memo, convGroupPicRelation.Memo);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.GroupId, convGroupPicRelation.GroupId);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.GroupName, convGroupPicRelation.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.PictureName, convGroupPicRelation.PictureName);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.PictureConfigName, convGroupPicRelation.PictureConfigName);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.CreateTime, convGroupPicRelation.CreateTime);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.CreateUserID, convGroupPicRelation.CreateUserID);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.LastModifyUserID, convGroupPicRelation.LastModifyUserID);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.LastModifyTime, convGroupPicRelation.LastModifyTime);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.LastModifyUserName, convGroupPicRelation.LastModifyUserName);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.PictureConfigerId, convGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.OrginialFileName, convGroupPicRelation.OrginialFileName);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.CreateUserName, convGroupPicRelation.CreateUserName);
clsCheckSql.CheckSqlInjection4Field(objvGroupPicRelationEN.PicturePath, convGroupPicRelation.PicturePath);
//检查外键字段长度
 objvGroupPicRelationEN._IsCheckProperty = true;
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvGroupPicRelationEN._CurrTabName);
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvGroupPicRelationEN._CurrTabName, strCondition);
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
 objSQL = clsvGroupPicRelationDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
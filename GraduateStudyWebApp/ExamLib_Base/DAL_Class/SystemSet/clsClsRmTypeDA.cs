
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTypeDA
 表名:ClsRmType(01120576)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:27
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
 /// 教室类型(ClsRmType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsClsRmTypeDA : clsCommBase4DA
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
 return clsClsRmTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsClsRmTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClsRmTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsClsRmTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsClsRmTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdClassRoomType">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdClassRoomType)
{
strIdClassRoomType = strIdClassRoomType.Replace("'", "''");
if (strIdClassRoomType.Length > 4)
{
throw new Exception("(errid:Data000001)在表:ClsRmType中,检查关键字,长度不正确!(clsClsRmTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdClassRoomType)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ClsRmType中,关键字不能为空 或 null!(clsClsRmTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClassRoomType);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsClsRmTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ClsRmType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable_ClsRmType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClsRmType.* from ClsRmType Left Join {1} on {2} where {3} and ClsRmType.IdClassRoomType not in (Select top {5} ClsRmType.IdClassRoomType from ClsRmType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1} and IdClassRoomType not in (Select top {2} IdClassRoomType from ClsRmType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1} and IdClassRoomType not in (Select top {3} IdClassRoomType from ClsRmType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsClsRmTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClsRmType.* from ClsRmType Left Join {1} on {2} where {3} and ClsRmType.IdClassRoomType not in (Select top {5} ClsRmType.IdClassRoomType from ClsRmType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1} and IdClassRoomType not in (Select top {2} IdClassRoomType from ClsRmType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClsRmType where {1} and IdClassRoomType not in (Select top {3} IdClassRoomType from ClsRmType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsClsRmTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsClsRmTypeDA:GetObjLst)", objException.Message));
}
List<clsClsRmTypeEN> arrObjLst = new List<clsClsRmTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
try
{
objClsRmTypeEN.IdClassRoomType = objRow[conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号
objClsRmTypeEN.ClassRoomTypeID = objRow[conClsRmType.ClassRoomTypeID] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号
objClsRmTypeEN.ClassRoomTypeDesc = objRow[conClsRmType.ClassRoomTypeDesc] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述
objClsRmTypeEN.ClassRoomTypeDescA = objRow[conClsRmType.ClassRoomTypeDescA] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称
objClsRmTypeEN.ModifyUserId = objRow[conClsRmType.ModifyUserId].ToString().Trim(); //修改人
objClsRmTypeEN.ModifyDate = objRow[conClsRmType.ModifyDate].ToString().Trim(); //修改日期
objClsRmTypeEN.Memo = objRow[conClsRmType.Memo] == DBNull.Value ? null : objRow[conClsRmType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClsRmTypeDA: GetObjLst)", objException.Message));
}
objClsRmTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClsRmTypeEN);
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
public List<clsClsRmTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsClsRmTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsClsRmTypeEN> arrObjLst = new List<clsClsRmTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
try
{
objClsRmTypeEN.IdClassRoomType = objRow[conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号
objClsRmTypeEN.ClassRoomTypeID = objRow[conClsRmType.ClassRoomTypeID] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号
objClsRmTypeEN.ClassRoomTypeDesc = objRow[conClsRmType.ClassRoomTypeDesc] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述
objClsRmTypeEN.ClassRoomTypeDescA = objRow[conClsRmType.ClassRoomTypeDescA] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称
objClsRmTypeEN.ModifyUserId = objRow[conClsRmType.ModifyUserId].ToString().Trim(); //修改人
objClsRmTypeEN.ModifyDate = objRow[conClsRmType.ModifyDate].ToString().Trim(); //修改日期
objClsRmTypeEN.Memo = objRow[conClsRmType.Memo] == DBNull.Value ? null : objRow[conClsRmType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClsRmTypeDA: GetObjLst)", objException.Message));
}
objClsRmTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClsRmTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objClsRmTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetClsRmType(ref clsClsRmTypeEN objClsRmTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where IdClassRoomType = " + "'"+ objClsRmTypeEN.IdClassRoomType+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objClsRmTypeEN.IdClassRoomType = objDT.Rows[0][conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTypeEN.ClassRoomTypeID = objDT.Rows[0][conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTypeEN.ClassRoomTypeDesc = objDT.Rows[0][conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述(字段类型:varchar,字段长度:100,是否可空:True)
 objClsRmTypeEN.ClassRoomTypeDescA = objDT.Rows[0][conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称(字段类型:varchar,字段长度:100,是否可空:True)
 objClsRmTypeEN.ModifyUserId = objDT.Rows[0][conClsRmType.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objClsRmTypeEN.ModifyDate = objDT.Rows[0][conClsRmType.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClsRmTypeEN.Memo = objDT.Rows[0][conClsRmType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsClsRmTypeDA: GetClsRmType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdClassRoomType">表关键字</param>
 /// <returns>表对象</returns>
public clsClsRmTypeEN GetObjByIdClassRoomType(string strIdClassRoomType)
{
CheckPrimaryKey(strIdClassRoomType);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where IdClassRoomType = " + "'"+ strIdClassRoomType+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
try
{
 objClsRmTypeEN.IdClassRoomType = objRow[conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTypeEN.ClassRoomTypeID = objRow[conClsRmType.ClassRoomTypeID] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTypeEN.ClassRoomTypeDesc = objRow[conClsRmType.ClassRoomTypeDesc] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述(字段类型:varchar,字段长度:100,是否可空:True)
 objClsRmTypeEN.ClassRoomTypeDescA = objRow[conClsRmType.ClassRoomTypeDescA] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称(字段类型:varchar,字段长度:100,是否可空:True)
 objClsRmTypeEN.ModifyUserId = objRow[conClsRmType.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objClsRmTypeEN.ModifyDate = objRow[conClsRmType.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClsRmTypeEN.Memo = objRow[conClsRmType.Memo] == DBNull.Value ? null : objRow[conClsRmType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsClsRmTypeDA: GetObjByIdClassRoomType)", objException.Message));
}
return objClsRmTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsClsRmTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsClsRmTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN()
{
IdClassRoomType = objRow[conClsRmType.IdClassRoomType].ToString().Trim(), //教室类型流水号
ClassRoomTypeID = objRow[conClsRmType.ClassRoomTypeID] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeID].ToString().Trim(), //教室类型代号
ClassRoomTypeDesc = objRow[conClsRmType.ClassRoomTypeDesc] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(), //教室类型描述
ClassRoomTypeDescA = objRow[conClsRmType.ClassRoomTypeDescA] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(), //教室类型简称
ModifyUserId = objRow[conClsRmType.ModifyUserId].ToString().Trim(), //修改人
ModifyDate = objRow[conClsRmType.ModifyDate].ToString().Trim(), //修改日期
Memo = objRow[conClsRmType.Memo] == DBNull.Value ? null : objRow[conClsRmType.Memo].ToString().Trim() //备注
};
objClsRmTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClsRmTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsClsRmTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsClsRmTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
try
{
objClsRmTypeEN.IdClassRoomType = objRow[conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号
objClsRmTypeEN.ClassRoomTypeID = objRow[conClsRmType.ClassRoomTypeID] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号
objClsRmTypeEN.ClassRoomTypeDesc = objRow[conClsRmType.ClassRoomTypeDesc] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述
objClsRmTypeEN.ClassRoomTypeDescA = objRow[conClsRmType.ClassRoomTypeDescA] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称
objClsRmTypeEN.ModifyUserId = objRow[conClsRmType.ModifyUserId].ToString().Trim(); //修改人
objClsRmTypeEN.ModifyDate = objRow[conClsRmType.ModifyDate].ToString().Trim(); //修改日期
objClsRmTypeEN.Memo = objRow[conClsRmType.Memo] == DBNull.Value ? null : objRow[conClsRmType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsClsRmTypeDA: GetObjByDataRowClsRmType)", objException.Message));
}
objClsRmTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClsRmTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsClsRmTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
try
{
objClsRmTypeEN.IdClassRoomType = objRow[conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号
objClsRmTypeEN.ClassRoomTypeID = objRow[conClsRmType.ClassRoomTypeID] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号
objClsRmTypeEN.ClassRoomTypeDesc = objRow[conClsRmType.ClassRoomTypeDesc] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述
objClsRmTypeEN.ClassRoomTypeDescA = objRow[conClsRmType.ClassRoomTypeDescA] == DBNull.Value ? null : objRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称
objClsRmTypeEN.ModifyUserId = objRow[conClsRmType.ModifyUserId].ToString().Trim(); //修改人
objClsRmTypeEN.ModifyDate = objRow[conClsRmType.ModifyDate].ToString().Trim(); //修改日期
objClsRmTypeEN.Memo = objRow[conClsRmType.Memo] == DBNull.Value ? null : objRow[conClsRmType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsClsRmTypeDA: GetObjByDataRow)", objException.Message));
}
objClsRmTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClsRmTypeEN;
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
objSQL = clsClsRmTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClsRmTypeEN._CurrTabName, conClsRmType.IdClassRoomType, 4, "");
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
objSQL = clsClsRmTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClsRmTypeEN._CurrTabName, conClsRmType.IdClassRoomType, 4, strPrefix);
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdClassRoomType from ClsRmType where " + strCondition;
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdClassRoomType from ClsRmType where " + strCondition;
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
 /// <param name = "strIdClassRoomType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdClassRoomType)
{
CheckPrimaryKey(strIdClassRoomType);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClsRmType", "IdClassRoomType = " + "'"+ strIdClassRoomType+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsClsRmTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClsRmType", strCondition))
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
objSQL = clsClsRmTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ClsRmType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsClsRmTypeEN objClsRmTypeEN)
 {
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClsRmType");
objRow = objDS.Tables["ClsRmType"].NewRow();
objRow[conClsRmType.IdClassRoomType] = objClsRmTypeEN.IdClassRoomType; //教室类型流水号
 if (objClsRmTypeEN.ClassRoomTypeID !=  "")
 {
objRow[conClsRmType.ClassRoomTypeID] = objClsRmTypeEN.ClassRoomTypeID; //教室类型代号
 }
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  "")
 {
objRow[conClsRmType.ClassRoomTypeDesc] = objClsRmTypeEN.ClassRoomTypeDesc; //教室类型描述
 }
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  "")
 {
objRow[conClsRmType.ClassRoomTypeDescA] = objClsRmTypeEN.ClassRoomTypeDescA; //教室类型简称
 }
objRow[conClsRmType.ModifyUserId] = objClsRmTypeEN.ModifyUserId; //修改人
objRow[conClsRmType.ModifyDate] = objClsRmTypeEN.ModifyDate; //修改日期
 if (objClsRmTypeEN.Memo !=  "")
 {
objRow[conClsRmType.Memo] = objClsRmTypeEN.Memo; //备注
 }
objDS.Tables[clsClsRmTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsClsRmTypeEN._CurrTabName);
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
 /// <param name = "objClsRmTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClsRmTypeEN objClsRmTypeEN)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTypeEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.IdClassRoomType);
 var strIdClassRoomType = objClsRmTypeEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeID);
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeID + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDesc);
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDesc + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDescA);
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDescA + "'");
 }
 
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyUserId);
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyDate);
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objClsRmTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.Memo);
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objClsRmTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClsRmTypeEN objClsRmTypeEN)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTypeEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.IdClassRoomType);
 var strIdClassRoomType = objClsRmTypeEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeID);
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeID + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDesc);
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDesc + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDescA);
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDescA + "'");
 }
 
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyUserId);
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyDate);
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objClsRmTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.Memo);
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objClsRmTypeEN.IdClassRoomType;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objClsRmTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClsRmTypeEN objClsRmTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTypeEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.IdClassRoomType);
 var strIdClassRoomType = objClsRmTypeEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeID);
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeID + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDesc);
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDesc + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDescA);
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDescA + "'");
 }
 
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyUserId);
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyDate);
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objClsRmTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.Memo);
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objClsRmTypeEN.IdClassRoomType;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objClsRmTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClsRmTypeEN objClsRmTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTypeEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.IdClassRoomType);
 var strIdClassRoomType = objClsRmTypeEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeID);
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeID + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDesc);
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDesc + "'");
 }
 
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ClassRoomTypeDescA);
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassRoomTypeDescA + "'");
 }
 
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyUserId);
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.ModifyDate);
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objClsRmTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmType.Memo);
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewClsRmTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where IdClassRoomType = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClsRmType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdClassRoomType = oRow[conClsRmType.IdClassRoomType].ToString().Trim();
if (IsExist(strIdClassRoomType))
{
 string strResult = "关键字变量值为:" + string.Format("IdClassRoomType = {0}", strIdClassRoomType) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsClsRmTypeEN._CurrTabName ].NewRow();
objRow[conClsRmType.IdClassRoomType] = oRow[conClsRmType.IdClassRoomType].ToString().Trim(); //教室类型流水号
objRow[conClsRmType.ClassRoomTypeID] = oRow[conClsRmType.ClassRoomTypeID].ToString().Trim(); //教室类型代号
objRow[conClsRmType.ClassRoomTypeDesc] = oRow[conClsRmType.ClassRoomTypeDesc].ToString().Trim(); //教室类型描述
objRow[conClsRmType.ClassRoomTypeDescA] = oRow[conClsRmType.ClassRoomTypeDescA].ToString().Trim(); //教室类型简称
objRow[conClsRmType.ModifyUserId] = oRow[conClsRmType.ModifyUserId].ToString().Trim(); //修改人
objRow[conClsRmType.ModifyDate] = oRow[conClsRmType.ModifyDate].ToString().Trim(); //修改日期
objRow[conClsRmType.Memo] = oRow[conClsRmType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsClsRmTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsClsRmTypeEN._CurrTabName);
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
 /// <param name = "objClsRmTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsClsRmTypeEN objClsRmTypeEN)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmType where IdClassRoomType = " + "'"+ objClsRmTypeEN.IdClassRoomType+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsClsRmTypeEN._CurrTabName);
if (objDS.Tables[clsClsRmTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdClassRoomType = " + "'"+ objClsRmTypeEN.IdClassRoomType+"'");
return false;
}
objRow = objDS.Tables[clsClsRmTypeEN._CurrTabName].Rows[0];
 if (objClsRmTypeEN.IsUpdated(conClsRmType.IdClassRoomType))
 {
objRow[conClsRmType.IdClassRoomType] = objClsRmTypeEN.IdClassRoomType; //教室类型流水号
 }
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeID))
 {
objRow[conClsRmType.ClassRoomTypeID] = objClsRmTypeEN.ClassRoomTypeID; //教室类型代号
 }
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDesc))
 {
objRow[conClsRmType.ClassRoomTypeDesc] = objClsRmTypeEN.ClassRoomTypeDesc; //教室类型描述
 }
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDescA))
 {
objRow[conClsRmType.ClassRoomTypeDescA] = objClsRmTypeEN.ClassRoomTypeDescA; //教室类型简称
 }
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyUserId))
 {
objRow[conClsRmType.ModifyUserId] = objClsRmTypeEN.ModifyUserId; //修改人
 }
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyDate))
 {
objRow[conClsRmType.ModifyDate] = objClsRmTypeEN.ModifyDate; //修改日期
 }
 if (objClsRmTypeEN.IsUpdated(conClsRmType.Memo))
 {
objRow[conClsRmType.Memo] = objClsRmTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsClsRmTypeEN._CurrTabName);
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
 /// <param name = "objClsRmTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClsRmTypeEN objClsRmTypeEN)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ClsRmType Set ");
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeID))
 {
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassRoomTypeID, conClsRmType.ClassRoomTypeID); //教室类型代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ClassRoomTypeID); //教室类型代号
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDesc))
 {
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassRoomTypeDesc, conClsRmType.ClassRoomTypeDesc); //教室类型描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ClassRoomTypeDesc); //教室类型描述
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDescA))
 {
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassRoomTypeDescA, conClsRmType.ClassRoomTypeDescA); //教室类型简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ClassRoomTypeDescA); //教室类型简称
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyUserId))
 {
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conClsRmType.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ModifyUserId); //修改人
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyDate))
 {
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conClsRmType.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ModifyDate); //修改日期
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.Memo))
 {
 if (objClsRmTypeEN.Memo !=  null)
 {
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClsRmType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdClassRoomType = '{0}'", objClsRmTypeEN.IdClassRoomType); 
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
 /// <param name = "objClsRmTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsClsRmTypeEN objClsRmTypeEN, string strCondition)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClsRmType Set ");
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeID))
 {
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassRoomTypeID = '{0}',", strClassRoomTypeID); //教室类型代号
 }
 else
 {
 sbSQL.Append(" ClassRoomTypeID = null,"); //教室类型代号
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDesc))
 {
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassRoomTypeDesc = '{0}',", strClassRoomTypeDesc); //教室类型描述
 }
 else
 {
 sbSQL.Append(" ClassRoomTypeDesc = null,"); //教室类型描述
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDescA))
 {
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassRoomTypeDescA = '{0}',", strClassRoomTypeDescA); //教室类型简称
 }
 else
 {
 sbSQL.Append(" ClassRoomTypeDescA = null,"); //教室类型简称
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyUserId))
 {
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyDate))
 {
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.Memo))
 {
 if (objClsRmTypeEN.Memo !=  null)
 {
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClsRmTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsClsRmTypeEN objClsRmTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClsRmType Set ");
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeID))
 {
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassRoomTypeID = '{0}',", strClassRoomTypeID); //教室类型代号
 }
 else
 {
 sbSQL.Append(" ClassRoomTypeID = null,"); //教室类型代号
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDesc))
 {
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassRoomTypeDesc = '{0}',", strClassRoomTypeDesc); //教室类型描述
 }
 else
 {
 sbSQL.Append(" ClassRoomTypeDesc = null,"); //教室类型描述
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDescA))
 {
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassRoomTypeDescA = '{0}',", strClassRoomTypeDescA); //教室类型简称
 }
 else
 {
 sbSQL.Append(" ClassRoomTypeDescA = null,"); //教室类型简称
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyUserId))
 {
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyDate))
 {
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.Memo))
 {
 if (objClsRmTypeEN.Memo !=  null)
 {
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClsRmTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClsRmTypeEN objClsRmTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objClsRmTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClsRmType Set ");
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeID))
 {
 if (objClsRmTypeEN.ClassRoomTypeID !=  null)
 {
 var strClassRoomTypeID = objClsRmTypeEN.ClassRoomTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassRoomTypeID, conClsRmType.ClassRoomTypeID); //教室类型代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ClassRoomTypeID); //教室类型代号
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDesc))
 {
 if (objClsRmTypeEN.ClassRoomTypeDesc !=  null)
 {
 var strClassRoomTypeDesc = objClsRmTypeEN.ClassRoomTypeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassRoomTypeDesc, conClsRmType.ClassRoomTypeDesc); //教室类型描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ClassRoomTypeDesc); //教室类型描述
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ClassRoomTypeDescA))
 {
 if (objClsRmTypeEN.ClassRoomTypeDescA !=  null)
 {
 var strClassRoomTypeDescA = objClsRmTypeEN.ClassRoomTypeDescA.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassRoomTypeDescA, conClsRmType.ClassRoomTypeDescA); //教室类型简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ClassRoomTypeDescA); //教室类型简称
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyUserId))
 {
 if (objClsRmTypeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objClsRmTypeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conClsRmType.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ModifyUserId); //修改人
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.ModifyDate))
 {
 if (objClsRmTypeEN.ModifyDate !=  null)
 {
 var strModifyDate = objClsRmTypeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conClsRmType.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.ModifyDate); //修改日期
 }
 }
 
 if (objClsRmTypeEN.IsUpdated(conClsRmType.Memo))
 {
 if (objClsRmTypeEN.Memo !=  null)
 {
 var strMemo = objClsRmTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClsRmType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdClassRoomType = '{0}'", objClsRmTypeEN.IdClassRoomType); 
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
 /// <param name = "strIdClassRoomType">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdClassRoomType) 
{
CheckPrimaryKey(strIdClassRoomType);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdClassRoomType,
};
 objSQL.ExecSP("ClsRmType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdClassRoomType">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdClassRoomType, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdClassRoomType);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
//删除ClsRmType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClsRmType where IdClassRoomType = " + "'"+ strIdClassRoomType+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelClsRmType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
//删除ClsRmType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClsRmType where IdClassRoomType in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdClassRoomType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdClassRoomType) 
{
CheckPrimaryKey(strIdClassRoomType);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
//删除ClsRmType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClsRmType where IdClassRoomType = " + "'"+ strIdClassRoomType+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelClsRmType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsClsRmTypeDA: DelClsRmType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClsRmType where " + strCondition ;
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
public bool DelClsRmTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsClsRmTypeDA: DelClsRmTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClsRmType where " + strCondition ;
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
 /// <param name = "objClsRmTypeENS">源对象</param>
 /// <param name = "objClsRmTypeENT">目标对象</param>
public void CopyTo(clsClsRmTypeEN objClsRmTypeENS, clsClsRmTypeEN objClsRmTypeENT)
{
objClsRmTypeENT.IdClassRoomType = objClsRmTypeENS.IdClassRoomType; //教室类型流水号
objClsRmTypeENT.ClassRoomTypeID = objClsRmTypeENS.ClassRoomTypeID; //教室类型代号
objClsRmTypeENT.ClassRoomTypeDesc = objClsRmTypeENS.ClassRoomTypeDesc; //教室类型描述
objClsRmTypeENT.ClassRoomTypeDescA = objClsRmTypeENS.ClassRoomTypeDescA; //教室类型简称
objClsRmTypeENT.ModifyUserId = objClsRmTypeENS.ModifyUserId; //修改人
objClsRmTypeENT.ModifyDate = objClsRmTypeENS.ModifyDate; //修改日期
objClsRmTypeENT.Memo = objClsRmTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsClsRmTypeEN objClsRmTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objClsRmTypeEN.ModifyUserId, conClsRmType.ModifyUserId);
clsCheckSql.CheckFieldNotNull(objClsRmTypeEN.ModifyDate, conClsRmType.ModifyDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objClsRmTypeEN.IdClassRoomType, 4, conClsRmType.IdClassRoomType);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeID, 4, conClsRmType.ClassRoomTypeID);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeDesc, 100, conClsRmType.ClassRoomTypeDesc);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeDescA, 100, conClsRmType.ClassRoomTypeDescA);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ModifyUserId, 18, conClsRmType.ModifyUserId);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ModifyDate, 20, conClsRmType.ModifyDate);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.Memo, 1000, conClsRmType.Memo);
//检查字段外键固定长度
 objClsRmTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsClsRmTypeEN objClsRmTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeID, 4, conClsRmType.ClassRoomTypeID);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeDesc, 100, conClsRmType.ClassRoomTypeDesc);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeDescA, 100, conClsRmType.ClassRoomTypeDescA);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ModifyUserId, 18, conClsRmType.ModifyUserId);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ModifyDate, 20, conClsRmType.ModifyDate);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.Memo, 1000, conClsRmType.Memo);
//检查外键字段长度
 objClsRmTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsClsRmTypeEN objClsRmTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClsRmTypeEN.IdClassRoomType, 4, conClsRmType.IdClassRoomType);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeID, 4, conClsRmType.ClassRoomTypeID);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeDesc, 100, conClsRmType.ClassRoomTypeDesc);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ClassRoomTypeDescA, 100, conClsRmType.ClassRoomTypeDescA);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ModifyUserId, 18, conClsRmType.ModifyUserId);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.ModifyDate, 20, conClsRmType.ModifyDate);
clsCheckSql.CheckFieldLen(objClsRmTypeEN.Memo, 1000, conClsRmType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.IdClassRoomType, conClsRmType.IdClassRoomType);
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.ClassRoomTypeID, conClsRmType.ClassRoomTypeID);
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.ClassRoomTypeDesc, conClsRmType.ClassRoomTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.ClassRoomTypeDescA, conClsRmType.ClassRoomTypeDescA);
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.ModifyUserId, conClsRmType.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.ModifyDate, conClsRmType.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objClsRmTypeEN.Memo, conClsRmType.Memo);
//检查外键字段长度
 objClsRmTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdClassRoomType()
{
//获取某学院所有专业信息
string strSQL = "select IdClassRoomType, ClassRoomTypeDesc from ClsRmType ";
 clsSpecSQLforSql mySql = clsClsRmTypeDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClsRmTypeEN._CurrTabName);
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClsRmTypeEN._CurrTabName, strCondition);
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}

 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvke_SubDA
 表名:vke_Sub(01120659)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 知识经济子类视图(vke_Sub)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvke_SubDA : clsCommBase4DA
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
 return clsvke_SubEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvke_SubEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvke_SubEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvke_SubEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvke_SubEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strKeSubId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strKeSubId)
{
strKeSubId = strKeSubId.Replace("'", "''");
if (strKeSubId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vke_Sub中,检查关键字,长度不正确!(clsvke_SubDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strKeSubId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vke_Sub中,关键字不能为空 或 null!(clsvke_SubDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeSubId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvke_SubDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vke_Sub(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable_vke_Sub)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vke_Sub.* from vke_Sub Left Join {1} on {2} where {3} and vke_Sub.KeSubId not in (Select top {5} vke_Sub.KeSubId from vke_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1} and KeSubId not in (Select top {2} KeSubId from vke_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1} and KeSubId not in (Select top {3} KeSubId from vke_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvke_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vke_Sub.* from vke_Sub Left Join {1} on {2} where {3} and vke_Sub.KeSubId not in (Select top {5} vke_Sub.KeSubId from vke_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1} and KeSubId not in (Select top {2} KeSubId from vke_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vke_Sub where {1} and KeSubId not in (Select top {3} KeSubId from vke_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvke_SubEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvke_SubDA:GetObjLst)", objException.Message));
}
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvke_SubDA: GetObjLst)", objException.Message));
}
objvke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvke_SubEN);
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
public List<clsvke_SubEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvke_SubDA:GetObjLstByTabName)", objException.Message));
}
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvke_SubDA: GetObjLst)", objException.Message));
}
objvke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvke_SubEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvke_SubEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvke_Sub(ref clsvke_SubEN objvke_SubEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where KeSubId = " + "'"+ objvke_SubEN.KeSubId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvke_SubEN.KeSubId = objDT.Rows[0][convke_Sub.KeSubId].ToString().Trim(); //知识子类Id(字段类型:char,字段长度:4,是否可空:False)
 objvke_SubEN.KeSuperId = objDT.Rows[0][convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id(字段类型:char,字段长度:4,是否可空:False)
 objvke_SubEN.KeSuperNameCn = objDT.Rows[0][convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名(字段类型:varchar,字段长度:200,是否可空:True)
 objvke_SubEN.KeSuperNameEn = objDT.Rows[0][convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvke_SubEN.KeSubNameCn = objDT.Rows[0][convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名(字段类型:varchar,字段长度:200,是否可空:False)
 objvke_SubEN.KeSubNameEn = objDT.Rows[0][convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvke_SubEN.KeSuperDescribeCn = objDT.Rows[0][convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.KeSubDescribeCn = objDT.Rows[0][convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.KeSuperDescribeEn = objDT.Rows[0][convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.KeSubDescribeEn = objDT.Rows[0][convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.UpdDate = objDT.Rows[0][convke_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvke_SubEN.UpdUser = objDT.Rows[0][convke_Sub.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvke_SubEN.Memo = objDT.Rows[0][convke_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvke_SubEN.Link = objDT.Rows[0][convke_Sub.Link].ToString().Trim(); //相应链接(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvke_SubDA: Getvke_Sub)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKeSubId">表关键字</param>
 /// <returns>表对象</returns>
public clsvke_SubEN GetObjByKeSubId(string strKeSubId)
{
CheckPrimaryKey(strKeSubId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where KeSubId = " + "'"+ strKeSubId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
 objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id(字段类型:char,字段长度:4,是否可空:False)
 objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id(字段类型:char,字段长度:4,是否可空:False)
 objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名(字段类型:varchar,字段长度:200,是否可空:True)
 objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名(字段类型:varchar,字段长度:200,是否可空:False)
 objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述(字段类型:varchar,字段长度:500,是否可空:True)
 objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvke_SubDA: GetObjByKeSubId)", objException.Message));
}
return objvke_SubEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvke_SubEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvke_SubDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
strSQL = "Select * from vke_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN()
{
KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(), //知识子类Id
KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(), //知识分类Id
KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(), //知识分类名
KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(), //知识分类英文名
KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(), //知识子类名
KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(), //知识子类英文名
KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(), //知识分类描述
KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(), //知识子类描述
KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(), //知识分类英文描述
KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(), //知识子类英文描述
UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(), //备注
Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim() //相应链接
};
objvke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvke_SubEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvke_SubDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvke_SubEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvke_SubDA: GetObjByDataRowvke_Sub)", objException.Message));
}
objvke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvke_SubEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvke_SubEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvke_SubDA: GetObjByDataRow)", objException.Message));
}
objvke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvke_SubEN;
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
objSQL = clsvke_SubDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvke_SubEN._CurrTabName, convke_Sub.KeSubId, 4, "");
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
objSQL = clsvke_SubDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvke_SubEN._CurrTabName, convke_Sub.KeSubId, 4, strPrefix);
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select KeSubId from vke_Sub where " + strCondition;
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select KeSubId from vke_Sub where " + strCondition;
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
 /// <param name = "strKeSubId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strKeSubId)
{
CheckPrimaryKey(strKeSubId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vke_Sub", "KeSubId = " + "'"+ strKeSubId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvke_SubDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvke_SubDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vke_Sub", strCondition))
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
objSQL = clsvke_SubDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vke_Sub");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvke_SubENS">源对象</param>
 /// <param name = "objvke_SubENT">目标对象</param>
public void CopyTo(clsvke_SubEN objvke_SubENS, clsvke_SubEN objvke_SubENT)
{
objvke_SubENT.KeSubId = objvke_SubENS.KeSubId; //知识子类Id
objvke_SubENT.KeSuperId = objvke_SubENS.KeSuperId; //知识分类Id
objvke_SubENT.KeSuperNameCn = objvke_SubENS.KeSuperNameCn; //知识分类名
objvke_SubENT.KeSuperNameEn = objvke_SubENS.KeSuperNameEn; //知识分类英文名
objvke_SubENT.KeSubNameCn = objvke_SubENS.KeSubNameCn; //知识子类名
objvke_SubENT.KeSubNameEn = objvke_SubENS.KeSubNameEn; //知识子类英文名
objvke_SubENT.KeSuperDescribeCn = objvke_SubENS.KeSuperDescribeCn; //知识分类描述
objvke_SubENT.KeSubDescribeCn = objvke_SubENS.KeSubDescribeCn; //知识子类描述
objvke_SubENT.KeSuperDescribeEn = objvke_SubENS.KeSuperDescribeEn; //知识分类英文描述
objvke_SubENT.KeSubDescribeEn = objvke_SubENS.KeSubDescribeEn; //知识子类英文描述
objvke_SubENT.UpdDate = objvke_SubENS.UpdDate; //修改日期
objvke_SubENT.UpdUser = objvke_SubENS.UpdUser; //修改人
objvke_SubENT.Memo = objvke_SubENS.Memo; //备注
objvke_SubENT.Link = objvke_SubENS.Link; //相应链接
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvke_SubEN objvke_SubEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSubId, 4, convke_Sub.KeSubId);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSuperId, 4, convke_Sub.KeSuperId);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSuperNameCn, 200, convke_Sub.KeSuperNameCn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSuperNameEn, 200, convke_Sub.KeSuperNameEn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSubNameCn, 200, convke_Sub.KeSubNameCn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSubNameEn, 200, convke_Sub.KeSubNameEn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSuperDescribeCn, 500, convke_Sub.KeSuperDescribeCn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSubDescribeCn, 500, convke_Sub.KeSubDescribeCn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSuperDescribeEn, 500, convke_Sub.KeSuperDescribeEn);
clsCheckSql.CheckFieldLen(objvke_SubEN.KeSubDescribeEn, 500, convke_Sub.KeSubDescribeEn);
clsCheckSql.CheckFieldLen(objvke_SubEN.UpdDate, 20, convke_Sub.UpdDate);
clsCheckSql.CheckFieldLen(objvke_SubEN.UpdUser, 20, convke_Sub.UpdUser);
clsCheckSql.CheckFieldLen(objvke_SubEN.Memo, 1000, convke_Sub.Memo);
clsCheckSql.CheckFieldLen(objvke_SubEN.Link, 200, convke_Sub.Link);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSubId, convke_Sub.KeSubId);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSuperId, convke_Sub.KeSuperId);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSuperNameCn, convke_Sub.KeSuperNameCn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSuperNameEn, convke_Sub.KeSuperNameEn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSubNameCn, convke_Sub.KeSubNameCn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSubNameEn, convke_Sub.KeSubNameEn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSuperDescribeCn, convke_Sub.KeSuperDescribeCn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSubDescribeCn, convke_Sub.KeSubDescribeCn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSuperDescribeEn, convke_Sub.KeSuperDescribeEn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.KeSubDescribeEn, convke_Sub.KeSubDescribeEn);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.UpdDate, convke_Sub.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.UpdUser, convke_Sub.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.Memo, convke_Sub.Memo);
clsCheckSql.CheckSqlInjection4Field(objvke_SubEN.Link, convke_Sub.Link);
//检查外键字段长度
 objvke_SubEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetKeSubId()
{
//获取某学院所有专业信息
string strSQL = "select KeSubId, KeSuperNameCn from vke_Sub ";
 clsSpecSQLforSql mySql = clsvke_SubDA.GetSpecSQLObj();
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvke_SubEN._CurrTabName);
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvke_SubEN._CurrTabName, strCondition);
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
 objSQL = clsvke_SubDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}
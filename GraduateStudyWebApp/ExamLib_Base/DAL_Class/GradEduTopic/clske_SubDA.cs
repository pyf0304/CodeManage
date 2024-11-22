
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clske_SubDA
 表名:ke_Sub(01120660)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 知识经济子类(ke_Sub)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clske_SubDA : clsCommBase4DA
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
 return clske_SubEN._CurrTabName;
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
if (string.IsNullOrEmpty(clske_SubEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clske_SubEN._ConnectString);
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
 if (string.IsNullOrEmpty(clske_SubEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clske_SubEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:ke_Sub中,检查关键字,长度不正确!(clske_SubDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strKeSubId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ke_Sub中,关键字不能为空 或 null!(clske_SubDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeSubId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clske_SubDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ke_Sub(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable_ke_Sub)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clske_SubDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clske_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ke_Sub.* from ke_Sub Left Join {1} on {2} where {3} and ke_Sub.KeSubId not in (Select top {5} ke_Sub.KeSubId from ke_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1} and KeSubId not in (Select top {2} KeSubId from ke_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1} and KeSubId not in (Select top {3} KeSubId from ke_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clske_SubDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ke_Sub.* from ke_Sub Left Join {1} on {2} where {3} and ke_Sub.KeSubId not in (Select top {5} ke_Sub.KeSubId from ke_Sub Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1} and KeSubId not in (Select top {2} KeSubId from ke_Sub where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ke_Sub where {1} and KeSubId not in (Select top {3} KeSubId from ke_Sub where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clske_SubEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clske_SubDA:GetObjLst)", objException.Message));
}
List<clske_SubEN> arrObjLst = new List<clske_SubEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clske_SubEN objke_SubEN = new clske_SubEN();
try
{
objke_SubEN.KeSubId = objRow[conke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objke_SubEN.KeSuperId = objRow[conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objke_SubEN.KeSubNameCn = objRow[conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objke_SubEN.KeSubNameEn = objRow[conke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objke_SubEN.KeSubDescribeCn = objRow[conke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objke_SubEN.KeSubDescribeEn = objRow[conke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objke_SubEN.UpdDate = objRow[conke_Sub.UpdDate] == DBNull.Value ? null : objRow[conke_Sub.UpdDate].ToString().Trim(); //修改日期
objke_SubEN.UpdUser = objRow[conke_Sub.UpdUser] == DBNull.Value ? null : objRow[conke_Sub.UpdUser].ToString().Trim(); //修改人
objke_SubEN.Memo = objRow[conke_Sub.Memo] == DBNull.Value ? null : objRow[conke_Sub.Memo].ToString().Trim(); //备注
objke_SubEN.Link = objRow[conke_Sub.Link] == DBNull.Value ? null : objRow[conke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clske_SubDA: GetObjLst)", objException.Message));
}
objke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objke_SubEN);
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
public List<clske_SubEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clske_SubDA:GetObjLstByTabName)", objException.Message));
}
List<clske_SubEN> arrObjLst = new List<clske_SubEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clske_SubEN objke_SubEN = new clske_SubEN();
try
{
objke_SubEN.KeSubId = objRow[conke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objke_SubEN.KeSuperId = objRow[conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objke_SubEN.KeSubNameCn = objRow[conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objke_SubEN.KeSubNameEn = objRow[conke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objke_SubEN.KeSubDescribeCn = objRow[conke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objke_SubEN.KeSubDescribeEn = objRow[conke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objke_SubEN.UpdDate = objRow[conke_Sub.UpdDate] == DBNull.Value ? null : objRow[conke_Sub.UpdDate].ToString().Trim(); //修改日期
objke_SubEN.UpdUser = objRow[conke_Sub.UpdUser] == DBNull.Value ? null : objRow[conke_Sub.UpdUser].ToString().Trim(); //修改人
objke_SubEN.Memo = objRow[conke_Sub.Memo] == DBNull.Value ? null : objRow[conke_Sub.Memo].ToString().Trim(); //备注
objke_SubEN.Link = objRow[conke_Sub.Link] == DBNull.Value ? null : objRow[conke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clske_SubDA: GetObjLst)", objException.Message));
}
objke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objke_SubEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objke_SubEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getke_Sub(ref clske_SubEN objke_SubEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where KeSubId = " + "'"+ objke_SubEN.KeSubId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objke_SubEN.KeSubId = objDT.Rows[0][conke_Sub.KeSubId].ToString().Trim(); //知识子类Id(字段类型:char,字段长度:4,是否可空:False)
 objke_SubEN.KeSuperId = objDT.Rows[0][conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id(字段类型:char,字段长度:4,是否可空:False)
 objke_SubEN.KeSubNameCn = objDT.Rows[0][conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名(字段类型:varchar,字段长度:200,是否可空:False)
 objke_SubEN.KeSubNameEn = objDT.Rows[0][conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objke_SubEN.KeSubDescribeCn = objDT.Rows[0][conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述(字段类型:varchar,字段长度:500,是否可空:True)
 objke_SubEN.KeSubDescribeEn = objDT.Rows[0][conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述(字段类型:varchar,字段长度:500,是否可空:True)
 objke_SubEN.UpdDate = objDT.Rows[0][conke_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objke_SubEN.UpdUser = objDT.Rows[0][conke_Sub.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objke_SubEN.Memo = objDT.Rows[0][conke_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objke_SubEN.Link = objDT.Rows[0][conke_Sub.Link].ToString().Trim(); //相应链接(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clske_SubDA: Getke_Sub)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKeSubId">表关键字</param>
 /// <returns>表对象</returns>
public clske_SubEN GetObjByKeSubId(string strKeSubId)
{
CheckPrimaryKey(strKeSubId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where KeSubId = " + "'"+ strKeSubId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clske_SubEN objke_SubEN = new clske_SubEN();
try
{
 objke_SubEN.KeSubId = objRow[conke_Sub.KeSubId].ToString().Trim(); //知识子类Id(字段类型:char,字段长度:4,是否可空:False)
 objke_SubEN.KeSuperId = objRow[conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id(字段类型:char,字段长度:4,是否可空:False)
 objke_SubEN.KeSubNameCn = objRow[conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名(字段类型:varchar,字段长度:200,是否可空:False)
 objke_SubEN.KeSubNameEn = objRow[conke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objke_SubEN.KeSubDescribeCn = objRow[conke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述(字段类型:varchar,字段长度:500,是否可空:True)
 objke_SubEN.KeSubDescribeEn = objRow[conke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述(字段类型:varchar,字段长度:500,是否可空:True)
 objke_SubEN.UpdDate = objRow[conke_Sub.UpdDate] == DBNull.Value ? null : objRow[conke_Sub.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objke_SubEN.UpdUser = objRow[conke_Sub.UpdUser] == DBNull.Value ? null : objRow[conke_Sub.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objke_SubEN.Memo = objRow[conke_Sub.Memo] == DBNull.Value ? null : objRow[conke_Sub.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objke_SubEN.Link = objRow[conke_Sub.Link] == DBNull.Value ? null : objRow[conke_Sub.Link].ToString().Trim(); //相应链接(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clske_SubDA: GetObjByKeSubId)", objException.Message));
}
return objke_SubEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clske_SubEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clske_SubDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clske_SubEN objke_SubEN = new clske_SubEN()
{
KeSubId = objRow[conke_Sub.KeSubId].ToString().Trim(), //知识子类Id
KeSuperId = objRow[conke_Sub.KeSuperId].ToString().Trim(), //知识分类Id
KeSubNameCn = objRow[conke_Sub.KeSubNameCn].ToString().Trim(), //知识子类名
KeSubNameEn = objRow[conke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubNameEn].ToString().Trim(), //知识子类英文名
KeSubDescribeCn = objRow[conke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeCn].ToString().Trim(), //知识子类描述
KeSubDescribeEn = objRow[conke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeEn].ToString().Trim(), //知识子类英文描述
UpdDate = objRow[conke_Sub.UpdDate] == DBNull.Value ? null : objRow[conke_Sub.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conke_Sub.UpdUser] == DBNull.Value ? null : objRow[conke_Sub.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conke_Sub.Memo] == DBNull.Value ? null : objRow[conke_Sub.Memo].ToString().Trim(), //备注
Link = objRow[conke_Sub.Link] == DBNull.Value ? null : objRow[conke_Sub.Link].ToString().Trim() //相应链接
};
objke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objke_SubEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clske_SubDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clske_SubEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clske_SubEN objke_SubEN = new clske_SubEN();
try
{
objke_SubEN.KeSubId = objRow[conke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objke_SubEN.KeSuperId = objRow[conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objke_SubEN.KeSubNameCn = objRow[conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objke_SubEN.KeSubNameEn = objRow[conke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objke_SubEN.KeSubDescribeCn = objRow[conke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objke_SubEN.KeSubDescribeEn = objRow[conke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objke_SubEN.UpdDate = objRow[conke_Sub.UpdDate] == DBNull.Value ? null : objRow[conke_Sub.UpdDate].ToString().Trim(); //修改日期
objke_SubEN.UpdUser = objRow[conke_Sub.UpdUser] == DBNull.Value ? null : objRow[conke_Sub.UpdUser].ToString().Trim(); //修改人
objke_SubEN.Memo = objRow[conke_Sub.Memo] == DBNull.Value ? null : objRow[conke_Sub.Memo].ToString().Trim(); //备注
objke_SubEN.Link = objRow[conke_Sub.Link] == DBNull.Value ? null : objRow[conke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clske_SubDA: GetObjByDataRowke_Sub)", objException.Message));
}
objke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objke_SubEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clske_SubEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clske_SubEN objke_SubEN = new clske_SubEN();
try
{
objke_SubEN.KeSubId = objRow[conke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objke_SubEN.KeSuperId = objRow[conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objke_SubEN.KeSubNameCn = objRow[conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objke_SubEN.KeSubNameEn = objRow[conke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objke_SubEN.KeSubDescribeCn = objRow[conke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objke_SubEN.KeSubDescribeEn = objRow[conke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objke_SubEN.UpdDate = objRow[conke_Sub.UpdDate] == DBNull.Value ? null : objRow[conke_Sub.UpdDate].ToString().Trim(); //修改日期
objke_SubEN.UpdUser = objRow[conke_Sub.UpdUser] == DBNull.Value ? null : objRow[conke_Sub.UpdUser].ToString().Trim(); //修改人
objke_SubEN.Memo = objRow[conke_Sub.Memo] == DBNull.Value ? null : objRow[conke_Sub.Memo].ToString().Trim(); //备注
objke_SubEN.Link = objRow[conke_Sub.Link] == DBNull.Value ? null : objRow[conke_Sub.Link].ToString().Trim(); //相应链接
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clske_SubDA: GetObjByDataRow)", objException.Message));
}
objke_SubEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objke_SubEN;
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
objSQL = clske_SubDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clske_SubEN._CurrTabName, conke_Sub.KeSubId, 4, "");
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
objSQL = clske_SubDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clske_SubEN._CurrTabName, conke_Sub.KeSubId, 4, strPrefix);
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
 objSQL = clske_SubDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select KeSubId from ke_Sub where " + strCondition;
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
 objSQL = clske_SubDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select KeSubId from ke_Sub where " + strCondition;
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
 objSQL = clske_SubDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ke_Sub", "KeSubId = " + "'"+ strKeSubId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clske_SubDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ke_Sub", strCondition))
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
objSQL = clske_SubDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ke_Sub");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clske_SubEN objke_SubEN)
 {
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objke_SubEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ke_Sub");
objRow = objDS.Tables["ke_Sub"].NewRow();
objRow[conke_Sub.KeSubId] = objke_SubEN.KeSubId; //知识子类Id
objRow[conke_Sub.KeSuperId] = objke_SubEN.KeSuperId; //知识分类Id
objRow[conke_Sub.KeSubNameCn] = objke_SubEN.KeSubNameCn; //知识子类名
 if (objke_SubEN.KeSubNameEn !=  "")
 {
objRow[conke_Sub.KeSubNameEn] = objke_SubEN.KeSubNameEn; //知识子类英文名
 }
 if (objke_SubEN.KeSubDescribeCn !=  "")
 {
objRow[conke_Sub.KeSubDescribeCn] = objke_SubEN.KeSubDescribeCn; //知识子类描述
 }
 if (objke_SubEN.KeSubDescribeEn !=  "")
 {
objRow[conke_Sub.KeSubDescribeEn] = objke_SubEN.KeSubDescribeEn; //知识子类英文描述
 }
 if (objke_SubEN.UpdDate !=  "")
 {
objRow[conke_Sub.UpdDate] = objke_SubEN.UpdDate; //修改日期
 }
 if (objke_SubEN.UpdUser !=  "")
 {
objRow[conke_Sub.UpdUser] = objke_SubEN.UpdUser; //修改人
 }
 if (objke_SubEN.Memo !=  "")
 {
objRow[conke_Sub.Memo] = objke_SubEN.Memo; //备注
 }
 if (objke_SubEN.Link !=  "")
 {
objRow[conke_Sub.Link] = objke_SubEN.Link; //相应链接
 }
objDS.Tables[clske_SubEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clske_SubEN._CurrTabName);
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
 /// <param name = "objke_SubEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clske_SubEN objke_SubEN)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objke_SubEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objke_SubEN.KeSubId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubId);
 var strKeSubId = objke_SubEN.KeSubId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubId + "'");
 }
 
 if (objke_SubEN.KeSuperId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSuperId);
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSuperId + "'");
 }
 
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameCn);
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameCn + "'");
 }
 
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameEn);
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameEn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeCn);
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeCn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeEn);
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeEn + "'");
 }
 
 if (objke_SubEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdDate);
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objke_SubEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdUser);
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objke_SubEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Memo);
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objke_SubEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Link);
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ke_Sub");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objke_SubEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clske_SubEN objke_SubEN)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objke_SubEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objke_SubEN.KeSubId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubId);
 var strKeSubId = objke_SubEN.KeSubId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubId + "'");
 }
 
 if (objke_SubEN.KeSuperId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSuperId);
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSuperId + "'");
 }
 
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameCn);
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameCn + "'");
 }
 
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameEn);
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameEn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeCn);
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeCn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeEn);
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeEn + "'");
 }
 
 if (objke_SubEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdDate);
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objke_SubEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdUser);
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objke_SubEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Memo);
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objke_SubEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Link);
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ke_Sub");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objke_SubEN.KeSubId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objke_SubEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clske_SubEN objke_SubEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objke_SubEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objke_SubEN.KeSubId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubId);
 var strKeSubId = objke_SubEN.KeSubId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubId + "'");
 }
 
 if (objke_SubEN.KeSuperId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSuperId);
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSuperId + "'");
 }
 
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameCn);
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameCn + "'");
 }
 
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameEn);
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameEn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeCn);
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeCn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeEn);
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeEn + "'");
 }
 
 if (objke_SubEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdDate);
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objke_SubEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdUser);
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objke_SubEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Memo);
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objke_SubEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Link);
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ke_Sub");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objke_SubEN.KeSubId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objke_SubEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clske_SubEN objke_SubEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objke_SubEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objke_SubEN.KeSubId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubId);
 var strKeSubId = objke_SubEN.KeSubId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubId + "'");
 }
 
 if (objke_SubEN.KeSuperId !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSuperId);
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSuperId + "'");
 }
 
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameCn);
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameCn + "'");
 }
 
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubNameEn);
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubNameEn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeCn);
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeCn + "'");
 }
 
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.KeSubDescribeEn);
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeSubDescribeEn + "'");
 }
 
 if (objke_SubEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdDate);
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objke_SubEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.UpdUser);
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objke_SubEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Memo);
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objke_SubEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conke_Sub.Link);
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ke_Sub");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewke_Subs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where KeSubId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ke_Sub");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strKeSubId = oRow[conke_Sub.KeSubId].ToString().Trim();
if (IsExist(strKeSubId))
{
 string strResult = "关键字变量值为:" + string.Format("KeSubId = {0}", strKeSubId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clske_SubEN._CurrTabName ].NewRow();
objRow[conke_Sub.KeSubId] = oRow[conke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objRow[conke_Sub.KeSuperId] = oRow[conke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objRow[conke_Sub.KeSubNameCn] = oRow[conke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objRow[conke_Sub.KeSubNameEn] = oRow[conke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objRow[conke_Sub.KeSubDescribeCn] = oRow[conke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objRow[conke_Sub.KeSubDescribeEn] = oRow[conke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objRow[conke_Sub.UpdDate] = oRow[conke_Sub.UpdDate].ToString().Trim(); //修改日期
objRow[conke_Sub.UpdUser] = oRow[conke_Sub.UpdUser].ToString().Trim(); //修改人
objRow[conke_Sub.Memo] = oRow[conke_Sub.Memo].ToString().Trim(); //备注
objRow[conke_Sub.Link] = oRow[conke_Sub.Link].ToString().Trim(); //相应链接
 objDS.Tables[clske_SubEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clske_SubEN._CurrTabName);
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
 /// <param name = "objke_SubEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clske_SubEN objke_SubEN)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objke_SubEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
strSQL = "Select * from ke_Sub where KeSubId = " + "'"+ objke_SubEN.KeSubId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clske_SubEN._CurrTabName);
if (objDS.Tables[clske_SubEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:KeSubId = " + "'"+ objke_SubEN.KeSubId+"'");
return false;
}
objRow = objDS.Tables[clske_SubEN._CurrTabName].Rows[0];
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubId))
 {
objRow[conke_Sub.KeSubId] = objke_SubEN.KeSubId; //知识子类Id
 }
 if (objke_SubEN.IsUpdated(conke_Sub.KeSuperId))
 {
objRow[conke_Sub.KeSuperId] = objke_SubEN.KeSuperId; //知识分类Id
 }
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameCn))
 {
objRow[conke_Sub.KeSubNameCn] = objke_SubEN.KeSubNameCn; //知识子类名
 }
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameEn))
 {
objRow[conke_Sub.KeSubNameEn] = objke_SubEN.KeSubNameEn; //知识子类英文名
 }
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeCn))
 {
objRow[conke_Sub.KeSubDescribeCn] = objke_SubEN.KeSubDescribeCn; //知识子类描述
 }
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeEn))
 {
objRow[conke_Sub.KeSubDescribeEn] = objke_SubEN.KeSubDescribeEn; //知识子类英文描述
 }
 if (objke_SubEN.IsUpdated(conke_Sub.UpdDate))
 {
objRow[conke_Sub.UpdDate] = objke_SubEN.UpdDate; //修改日期
 }
 if (objke_SubEN.IsUpdated(conke_Sub.UpdUser))
 {
objRow[conke_Sub.UpdUser] = objke_SubEN.UpdUser; //修改人
 }
 if (objke_SubEN.IsUpdated(conke_Sub.Memo))
 {
objRow[conke_Sub.Memo] = objke_SubEN.Memo; //备注
 }
 if (objke_SubEN.IsUpdated(conke_Sub.Link))
 {
objRow[conke_Sub.Link] = objke_SubEN.Link; //相应链接
 }
try
{
objDA.Update(objDS, clske_SubEN._CurrTabName);
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
 /// <param name = "objke_SubEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clske_SubEN objke_SubEN)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objke_SubEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ke_Sub Set ");
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSuperId))
 {
 if (objke_SubEN.KeSuperId !=  null)
 {
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSuperId, conke_Sub.KeSuperId); //知识分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSuperId); //知识分类Id
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameCn))
 {
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubNameCn, conke_Sub.KeSubNameCn); //知识子类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubNameCn); //知识子类名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameEn))
 {
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubNameEn, conke_Sub.KeSubNameEn); //知识子类英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubNameEn); //知识子类英文名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeCn))
 {
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubDescribeCn, conke_Sub.KeSubDescribeCn); //知识子类描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubDescribeCn); //知识子类描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeEn))
 {
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubDescribeEn, conke_Sub.KeSubDescribeEn); //知识子类英文描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubDescribeEn); //知识子类英文描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdDate))
 {
 if (objke_SubEN.UpdDate !=  null)
 {
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conke_Sub.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.UpdDate); //修改日期
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdUser))
 {
 if (objke_SubEN.UpdUser !=  null)
 {
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conke_Sub.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.UpdUser); //修改人
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Memo))
 {
 if (objke_SubEN.Memo !=  null)
 {
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conke_Sub.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.Memo); //备注
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Link))
 {
 if (objke_SubEN.Link !=  null)
 {
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLink, conke_Sub.Link); //相应链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.Link); //相应链接
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KeSubId = '{0}'", objke_SubEN.KeSubId); 
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
 /// <param name = "objke_SubEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clske_SubEN objke_SubEN, string strCondition)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objke_SubEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ke_Sub Set ");
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSuperId))
 {
 if (objke_SubEN.KeSuperId !=  null)
 {
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSuperId = '{0}',", strKeSuperId); //知识分类Id
 }
 else
 {
 sbSQL.Append(" KeSuperId = null,"); //知识分类Id
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameCn))
 {
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubNameCn = '{0}',", strKeSubNameCn); //知识子类名
 }
 else
 {
 sbSQL.Append(" KeSubNameCn = null,"); //知识子类名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameEn))
 {
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubNameEn = '{0}',", strKeSubNameEn); //知识子类英文名
 }
 else
 {
 sbSQL.Append(" KeSubNameEn = null,"); //知识子类英文名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeCn))
 {
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubDescribeCn = '{0}',", strKeSubDescribeCn); //知识子类描述
 }
 else
 {
 sbSQL.Append(" KeSubDescribeCn = null,"); //知识子类描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeEn))
 {
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubDescribeEn = '{0}',", strKeSubDescribeEn); //知识子类英文描述
 }
 else
 {
 sbSQL.Append(" KeSubDescribeEn = null,"); //知识子类英文描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdDate))
 {
 if (objke_SubEN.UpdDate !=  null)
 {
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdUser))
 {
 if (objke_SubEN.UpdUser !=  null)
 {
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Memo))
 {
 if (objke_SubEN.Memo !=  null)
 {
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Link))
 {
 if (objke_SubEN.Link !=  null)
 {
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Link = '{0}',", strLink); //相应链接
 }
 else
 {
 sbSQL.Append(" Link = null,"); //相应链接
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
 /// <param name = "objke_SubEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clske_SubEN objke_SubEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objke_SubEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ke_Sub Set ");
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSuperId))
 {
 if (objke_SubEN.KeSuperId !=  null)
 {
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSuperId = '{0}',", strKeSuperId); //知识分类Id
 }
 else
 {
 sbSQL.Append(" KeSuperId = null,"); //知识分类Id
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameCn))
 {
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubNameCn = '{0}',", strKeSubNameCn); //知识子类名
 }
 else
 {
 sbSQL.Append(" KeSubNameCn = null,"); //知识子类名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameEn))
 {
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubNameEn = '{0}',", strKeSubNameEn); //知识子类英文名
 }
 else
 {
 sbSQL.Append(" KeSubNameEn = null,"); //知识子类英文名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeCn))
 {
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubDescribeCn = '{0}',", strKeSubDescribeCn); //知识子类描述
 }
 else
 {
 sbSQL.Append(" KeSubDescribeCn = null,"); //知识子类描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeEn))
 {
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeSubDescribeEn = '{0}',", strKeSubDescribeEn); //知识子类英文描述
 }
 else
 {
 sbSQL.Append(" KeSubDescribeEn = null,"); //知识子类英文描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdDate))
 {
 if (objke_SubEN.UpdDate !=  null)
 {
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdUser))
 {
 if (objke_SubEN.UpdUser !=  null)
 {
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Memo))
 {
 if (objke_SubEN.Memo !=  null)
 {
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Link))
 {
 if (objke_SubEN.Link !=  null)
 {
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Link = '{0}',", strLink); //相应链接
 }
 else
 {
 sbSQL.Append(" Link = null,"); //相应链接
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
 /// <param name = "objke_SubEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clske_SubEN objke_SubEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objke_SubEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objke_SubEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objke_SubEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ke_Sub Set ");
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSuperId))
 {
 if (objke_SubEN.KeSuperId !=  null)
 {
 var strKeSuperId = objke_SubEN.KeSuperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSuperId, conke_Sub.KeSuperId); //知识分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSuperId); //知识分类Id
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameCn))
 {
 if (objke_SubEN.KeSubNameCn !=  null)
 {
 var strKeSubNameCn = objke_SubEN.KeSubNameCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubNameCn, conke_Sub.KeSubNameCn); //知识子类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubNameCn); //知识子类名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubNameEn))
 {
 if (objke_SubEN.KeSubNameEn !=  null)
 {
 var strKeSubNameEn = objke_SubEN.KeSubNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubNameEn, conke_Sub.KeSubNameEn); //知识子类英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubNameEn); //知识子类英文名
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeCn))
 {
 if (objke_SubEN.KeSubDescribeCn !=  null)
 {
 var strKeSubDescribeCn = objke_SubEN.KeSubDescribeCn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubDescribeCn, conke_Sub.KeSubDescribeCn); //知识子类描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubDescribeCn); //知识子类描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.KeSubDescribeEn))
 {
 if (objke_SubEN.KeSubDescribeEn !=  null)
 {
 var strKeSubDescribeEn = objke_SubEN.KeSubDescribeEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeSubDescribeEn, conke_Sub.KeSubDescribeEn); //知识子类英文描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.KeSubDescribeEn); //知识子类英文描述
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdDate))
 {
 if (objke_SubEN.UpdDate !=  null)
 {
 var strUpdDate = objke_SubEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conke_Sub.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.UpdDate); //修改日期
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.UpdUser))
 {
 if (objke_SubEN.UpdUser !=  null)
 {
 var strUpdUser = objke_SubEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conke_Sub.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.UpdUser); //修改人
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Memo))
 {
 if (objke_SubEN.Memo !=  null)
 {
 var strMemo = objke_SubEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conke_Sub.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.Memo); //备注
 }
 }
 
 if (objke_SubEN.IsUpdated(conke_Sub.Link))
 {
 if (objke_SubEN.Link !=  null)
 {
 var strLink = objke_SubEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLink, conke_Sub.Link); //相应链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conke_Sub.Link); //相应链接
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KeSubId = '{0}'", objke_SubEN.KeSubId); 
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
 /// <param name = "strKeSubId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strKeSubId) 
{
CheckPrimaryKey(strKeSubId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strKeSubId,
};
 objSQL.ExecSP("ke_Sub_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strKeSubId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strKeSubId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strKeSubId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
//删除ke_Sub本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ke_Sub where KeSubId = " + "'"+ strKeSubId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delke_Sub(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
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
//删除ke_Sub本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ke_Sub where KeSubId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strKeSubId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strKeSubId) 
{
CheckPrimaryKey(strKeSubId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
//删除ke_Sub本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ke_Sub where KeSubId = " + "'"+ strKeSubId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delke_Sub(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clske_SubDA: Delke_Sub)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ke_Sub where " + strCondition ;
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
public bool Delke_SubWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clske_SubDA: Delke_SubWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clske_SubDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ke_Sub where " + strCondition ;
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
 /// <param name = "objke_SubENS">源对象</param>
 /// <param name = "objke_SubENT">目标对象</param>
public void CopyTo(clske_SubEN objke_SubENS, clske_SubEN objke_SubENT)
{
objke_SubENT.KeSubId = objke_SubENS.KeSubId; //知识子类Id
objke_SubENT.KeSuperId = objke_SubENS.KeSuperId; //知识分类Id
objke_SubENT.KeSubNameCn = objke_SubENS.KeSubNameCn; //知识子类名
objke_SubENT.KeSubNameEn = objke_SubENS.KeSubNameEn; //知识子类英文名
objke_SubENT.KeSubDescribeCn = objke_SubENS.KeSubDescribeCn; //知识子类描述
objke_SubENT.KeSubDescribeEn = objke_SubENS.KeSubDescribeEn; //知识子类英文描述
objke_SubENT.UpdDate = objke_SubENS.UpdDate; //修改日期
objke_SubENT.UpdUser = objke_SubENS.UpdUser; //修改人
objke_SubENT.Memo = objke_SubENS.Memo; //备注
objke_SubENT.Link = objke_SubENS.Link; //相应链接
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clske_SubEN objke_SubEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objke_SubEN.KeSuperId, conke_Sub.KeSuperId);
clsCheckSql.CheckFieldNotNull(objke_SubEN.KeSubNameCn, conke_Sub.KeSubNameCn);
//检查字段长度
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubId, 4, conke_Sub.KeSubId);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSuperId, 4, conke_Sub.KeSuperId);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubNameCn, 200, conke_Sub.KeSubNameCn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubNameEn, 200, conke_Sub.KeSubNameEn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubDescribeCn, 500, conke_Sub.KeSubDescribeCn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubDescribeEn, 500, conke_Sub.KeSubDescribeEn);
clsCheckSql.CheckFieldLen(objke_SubEN.UpdDate, 20, conke_Sub.UpdDate);
clsCheckSql.CheckFieldLen(objke_SubEN.UpdUser, 20, conke_Sub.UpdUser);
clsCheckSql.CheckFieldLen(objke_SubEN.Memo, 1000, conke_Sub.Memo);
clsCheckSql.CheckFieldLen(objke_SubEN.Link, 200, conke_Sub.Link);
//检查字段外键固定长度
 objke_SubEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clske_SubEN objke_SubEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objke_SubEN.KeSuperId, 4, conke_Sub.KeSuperId);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubNameCn, 200, conke_Sub.KeSubNameCn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubNameEn, 200, conke_Sub.KeSubNameEn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubDescribeCn, 500, conke_Sub.KeSubDescribeCn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubDescribeEn, 500, conke_Sub.KeSubDescribeEn);
clsCheckSql.CheckFieldLen(objke_SubEN.UpdDate, 20, conke_Sub.UpdDate);
clsCheckSql.CheckFieldLen(objke_SubEN.UpdUser, 20, conke_Sub.UpdUser);
clsCheckSql.CheckFieldLen(objke_SubEN.Memo, 1000, conke_Sub.Memo);
clsCheckSql.CheckFieldLen(objke_SubEN.Link, 200, conke_Sub.Link);
//检查外键字段长度
 objke_SubEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clske_SubEN objke_SubEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubId, 4, conke_Sub.KeSubId);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSuperId, 4, conke_Sub.KeSuperId);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubNameCn, 200, conke_Sub.KeSubNameCn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubNameEn, 200, conke_Sub.KeSubNameEn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubDescribeCn, 500, conke_Sub.KeSubDescribeCn);
clsCheckSql.CheckFieldLen(objke_SubEN.KeSubDescribeEn, 500, conke_Sub.KeSubDescribeEn);
clsCheckSql.CheckFieldLen(objke_SubEN.UpdDate, 20, conke_Sub.UpdDate);
clsCheckSql.CheckFieldLen(objke_SubEN.UpdUser, 20, conke_Sub.UpdUser);
clsCheckSql.CheckFieldLen(objke_SubEN.Memo, 1000, conke_Sub.Memo);
clsCheckSql.CheckFieldLen(objke_SubEN.Link, 200, conke_Sub.Link);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.KeSubId, conke_Sub.KeSubId);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.KeSuperId, conke_Sub.KeSuperId);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.KeSubNameCn, conke_Sub.KeSubNameCn);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.KeSubNameEn, conke_Sub.KeSubNameEn);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.KeSubDescribeCn, conke_Sub.KeSubDescribeCn);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.KeSubDescribeEn, conke_Sub.KeSubDescribeEn);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.UpdDate, conke_Sub.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.UpdUser, conke_Sub.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.Memo, conke_Sub.Memo);
clsCheckSql.CheckSqlInjection4Field(objke_SubEN.Link, conke_Sub.Link);
//检查外键字段长度
 objke_SubEN._IsCheckProperty = true;
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
 objSQL = clske_SubDA.GetSpecSQLObj();
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
 objSQL = clske_SubDA.GetSpecSQLObj();
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
 objSQL = clske_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clske_SubEN._CurrTabName);
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
 objSQL = clske_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clske_SubEN._CurrTabName, strCondition);
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
 objSQL = clske_SubDA.GetSpecSQLObj();
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
 objSQL = clske_SubDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}
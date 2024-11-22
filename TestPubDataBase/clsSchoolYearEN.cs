
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsSchoolYearEN
表名:SchoolYear
生成代码版本:2018.04.11.1
生成日期:2018/04/13 11:25:21
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:中学教学管理平台
工程ID:0169
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:实体层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace MSEdu.Entity
{
    /// <summary>
    /// 学年信息(SchoolYear)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
    /// </summary>
    [Serializable]
    public class clsSchoolYearEN : clsEntityBase2
    {
        public override string _NameValue
        {
            get
            {
                return mstrSchoolYearName;
            }
        }
        public const string CurrTabName_S = "SchoolYear"; //当前表名,与该类相关的表名
        public const string CurrTabKeyFldName_S = "SchoolYear"; //当前表中的关键字名称,与该类相关的表中关键字名
        protected const int mintAttributeCount = 6;
        public static string[] AttributeName = new string[] { "SchoolYear", "SchoolYearName", "BeginYear", "IsCurrentSchoolYear", "IsPkSchoolYear", "IsVisible" };
        //以下是属性变量

        protected string mstrSchoolYear;    //学年
        protected string mstrSchoolYearName;    //学年名
        protected int mintBeginYear;    //开始年
        protected bool mbolIsCurrentSchoolYear;    //是否当前学年
        protected bool mbolIsPkSchoolYear;    //是否排课学年
        protected bool mbolIsVisible;    //是否可见


        /// <summary>
        /// 常量:"SchoolYear"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_SchoolYear = "SchoolYear";    //学年

        /// <summary>
        /// 常量:"SchoolYearName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_SchoolYearName = "SchoolYearName";    //学年名

        /// <summary>
        /// 常量:"BeginYear"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_BeginYear = "BeginYear";    //开始年

        /// <summary>
        /// 常量:"IsCurrentSchoolYear"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IsCurrentSchoolYear = "IsCurrentSchoolYear";    //是否当前学年

        /// <summary>
        /// 常量:"IsPkSchoolYear"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IsPkSchoolYear = "IsPkSchoolYear";    //是否排课学年

        /// <summary>
        /// 常量:"IsVisible"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IsVisible = "IsVisible";    //是否可见

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
        /// </summary>
        public clsSchoolYearEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "SchoolYear";
            lstKeyFldNames.Add("SchoolYear");
        }

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
        /// </summary>
        /// <param name = "mstrSchoolYear">关键字:学年</param>
        public clsSchoolYearEN(string strSchoolYear)
        {
            strSchoolYear = strSchoolYear.Replace("'", "''");
            if (strSchoolYear.Length > 10)
            {
                throw new Exception("在表:SchoolYear中,关键字长度不正确!");
            }
            if (string.IsNullOrEmpty(strSchoolYear) == true)
            {
                throw new Exception("在表:SchoolYear中,关键字不能为空 或 null!");
            }
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strSchoolYear);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
            }

            mstrSchoolYear = strSchoolYear;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "SchoolYear";
            lstKeyFldNames.Add("SchoolYear");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == con_SchoolYear)
                {
                    return mstrSchoolYear;
                }
                else if (strAttributeName == con_SchoolYearName)
                {
                    return mstrSchoolYearName;
                }
                else if (strAttributeName == con_BeginYear)
                {
                    return mintBeginYear;
                }
                else if (strAttributeName == con_IsCurrentSchoolYear)
                {
                    return mbolIsCurrentSchoolYear;
                }
                else if (strAttributeName == con_IsPkSchoolYear)
                {
                    return mbolIsPkSchoolYear;
                }
                else if (strAttributeName == con_IsVisible)
                {
                    return mbolIsVisible;
                }
                return null;
            }
            set
            {
                if (strAttributeName == con_SchoolYear)
                {
                    mstrSchoolYear = value.ToString();
                    AddUpdatedFld(con_SchoolYear);
                }
                else if (strAttributeName == con_SchoolYearName)
                {
                    mstrSchoolYearName = value.ToString();
                    AddUpdatedFld(con_SchoolYearName);
                }
                else if (strAttributeName == con_BeginYear)
                {
                    mintBeginYear = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_BeginYear);
                }
                else if (strAttributeName == con_IsCurrentSchoolYear)
                {
                    mbolIsCurrentSchoolYear = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsCurrentSchoolYear);
                }
                else if (strAttributeName == con_IsPkSchoolYear)
                {
                    mbolIsPkSchoolYear = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsPkSchoolYear);
                }
                else if (strAttributeName == con_IsVisible)
                {
                    mbolIsVisible = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsVisible);
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if (con_SchoolYear == AttributeName[intIndex])
                {
                    return mstrSchoolYear;
                }
                else if (con_SchoolYearName == AttributeName[intIndex])
                {
                    return mstrSchoolYearName;
                }
                else if (con_BeginYear == AttributeName[intIndex])
                {
                    return mintBeginYear;
                }
                else if (con_IsCurrentSchoolYear == AttributeName[intIndex])
                {
                    return mbolIsCurrentSchoolYear;
                }
                else if (con_IsPkSchoolYear == AttributeName[intIndex])
                {
                    return mbolIsPkSchoolYear;
                }
                else if (con_IsVisible == AttributeName[intIndex])
                {
                    return mbolIsVisible;
                }
                return null;
            }
            set
            {
                if (con_SchoolYear == AttributeName[intIndex])
                {
                    mstrSchoolYear = value.ToString();
                    AddUpdatedFld(con_SchoolYear);
                }
                else if (con_SchoolYearName == AttributeName[intIndex])
                {
                    mstrSchoolYearName = value.ToString();
                    AddUpdatedFld(con_SchoolYearName);
                }
                else if (con_BeginYear == AttributeName[intIndex])
                {
                    mintBeginYear = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_BeginYear);
                }
                else if (con_IsCurrentSchoolYear == AttributeName[intIndex])
                {
                    mbolIsCurrentSchoolYear = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsCurrentSchoolYear);
                }
                else if (con_IsPkSchoolYear == AttributeName[intIndex])
                {
                    mbolIsPkSchoolYear = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsPkSchoolYear);
                }
                else if (con_IsVisible == AttributeName[intIndex])
                {
                    mbolIsVisible = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsVisible);
                }
            }
        }

        /// <summary>
        /// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:False)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public string SchoolYear
        {
            get
            {
                return mstrSchoolYear;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSchoolYear = value;
                }
                else
                {
                    mstrSchoolYear = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_SchoolYear);
            }
        }
        /// <summary>
        /// 学年名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public string SchoolYearName
        {
            get
            {
                return mstrSchoolYearName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSchoolYearName = value;
                }
                else
                {
                    mstrSchoolYearName = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_SchoolYearName);
            }
        }
        /// <summary>
        /// 开始年(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public int BeginYear
        {
            get
            {
                return mintBeginYear;
            }
            set
            {
                mintBeginYear = value;
                //记录修改过的字段
                AddUpdatedFld(con_BeginYear);
            }
        }
        /// <summary>
        /// 是否当前学年(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public bool IsCurrentSchoolYear
        {
            get
            {
                return mbolIsCurrentSchoolYear;
            }
            set
            {
                mbolIsCurrentSchoolYear = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsCurrentSchoolYear);
            }
        }
        /// <summary>
        /// 是否排课学年(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public bool IsPkSchoolYear
        {
            get
            {
                return mbolIsPkSchoolYear;
            }
            set
            {
                mbolIsPkSchoolYear = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsPkSchoolYear);
            }
        }
        /// <summary>
        /// 是否可见(说明:;字段类型:bit;字段长度:1;是否可空:False)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return mbolIsVisible;
            }
            set
            {
                mbolIsVisible = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsVisible);
            }
        }
    }
}
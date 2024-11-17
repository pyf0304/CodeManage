using System;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

/*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCollegeEN
 表名:College(01160017)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/22 14:58:05
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息
 模块英文名:BaseInfo
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == ==
 */
namespace SimplePrj.Entity
{
    /// <summary>
    /// 表College的关键字(CollegeId)的类型定义. 以便检查类型以及操作方便.
    /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
    /// </summary>
    public class K_CollegeId_College1
    {
        private string _value = "";
        /// <summary>
        /// 关键字类型内面的值
        /// </summary>
        public string Value
        {
            get
            {
                return _value;

            }
            set
            {
                _value = value;

            }

        }
        /// <summary>
        /// 关键字类型构造函数
        /// </summary>
        /// <param name="strCollegeId">表关键字</param>
        public K_CollegeId_College1(string strCollegeId)
        {
            if (IsValid(strCollegeId))
            {
                Value = strCollegeId;

            }
            else
            {
                Value = null;

            }

        }
        private static bool IsValid(string strCollegeId)
        {
            if (string.IsNullOrEmpty(strCollegeId) == true)
            {
                return false;

            }
            if (strCollegeId.Length > 6)
            {
                return false;

            }
            if (strCollegeId.IndexOf(' ') >= 0)
            {
                return false;

            }
            if (strCollegeId.IndexOf(')') >= 0)
            {
                return false;

            }
            if (strCollegeId.IndexOf('(') >= 0)
            {
                return false;

            }
            return true;

        }
        /// <summary>
        /// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
        /// </summary>
        /// <param name="value">原类型表关键字</param>
        /// <returns>返回:[K_CollegeId_College]类型的对象</returns>
        public static implicit operator K_CollegeId_College1(string value)
        {
            return new K_CollegeId_College1(value);

        }

    }
    [Serializable]
    [DataContractAttribute]
    public class clsCollegeEN1 : clsEntityBase2
    {
        public const string _CurrTabName_S = "College";
        //当前表名,与该类相关的表名
        public const string _CurrTabKeyFldName_S = "CollegeId";
        //当前表中的关键字名称,与该类相关的表中关键字名
        protected const int mintAttributeCount = 7;
        //备注
        /// <summary>
        /// 常量:"CollegeId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_CollegeId = "CollegeId";
        //学院Id
        /// <summary>
        /// 常量:"CollegeName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_CollegeName = "CollegeName";
        //学院名称
        /// <summary>
        /// 常量:"OrderNum"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_OrderNum = "OrderNum";
        //排序
        /// <summary>
        /// 常量:"_IsDeleted"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con__IsDeleted = "_IsDeleted";
        //是否删除
        /// <summary>
        /// 常量:"_DeletedDate"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con__DeletedDate = "_DeletedDate";
        //删除日期
        /// <summary>
        /// 常量:"InUse"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_InUse = "InUse";
        //是否在用
        /// <summary>
        /// 常量:"Memo"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_Memo = "Memo";
        public static string[] AttributeName = new string[] { "CollegeId", "CollegeName", "OrderNum", "_IsDeleted", "_DeletedDate", "InUse", "Memo" };
        //以下是属性变量
        protected string mstrCollegeId;
        //学院Id
        protected string mstrCollegeName;
        //学院名称
        protected int mintOrderNum;
        //排序
        protected bool mbol_IsDeleted;
        //是否删除
        protected string mstr_DeletedDate;
        //删除日期
        protected bool mbolInUse;
        //是否在用
        protected string mstrMemo;
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;

            }

        }
        /// <summary>
        /// 学院Id(说明:;字段类型:varchar;字段长度:6;是否可空:False)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public string CollegeId
        {
            get
            {
                return mstrCollegeId;

            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCollegeId = value;

                }
                else
                {
                    mstrCollegeId = value;

                }
                AddUpdatedFld(con_CollegeId);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 学院名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public string CollegeName
        {
            get
            {
                return mstrCollegeName;

            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCollegeName = value;

                }
                else
                {
                    mstrCollegeName = value;

                }
                AddUpdatedFld(con_CollegeName);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public int OrderNum
        {
            get
            {
                return mintOrderNum;

            }
            set
            {
                mintOrderNum = value;
                AddUpdatedFld(con_OrderNum);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public bool _IsDeleted
        {
            get
            {
                return mbol_IsDeleted;

            }
            set
            {
                mbol_IsDeleted = value;
                AddUpdatedFld(con__IsDeleted);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public string _DeletedDate
        {
            get
            {
                return mstr_DeletedDate;

            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstr_DeletedDate = value;

                }
                else
                {
                    mstr_DeletedDate = value;

                }
                AddUpdatedFld(con__DeletedDate);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public bool InUse
        {
            get
            {
                return mbolInUse;

            }
            set
            {
                mbolInUse = value;
                AddUpdatedFld(con_InUse);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
        /// </summary>
        //非常重要
        [DataMember]
        public string Memo
        {
            get
            {
                return mstrMemo;

            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMemo = value;

                }
                else
                {
                    mstrMemo = value;

                }
                AddUpdatedFld(con_Memo);

            }

        }
        //记录修改过的字段
        /// <summary>
        /// 获取关键字Id(KeyId)
        /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
        /// </summary>
        public override string _KeyId
        {
            get
            {
                return mstrCollegeId;

            }

        }
        /// <summary>
        /// 获取名称字段值(NameValue)
        /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
        /// </summary>
        public override string _NameValue
        {
            get
            {
                return mstrCollegeName;

            }

        }
        //备注
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
        /// </summary>
        public clsCollegeEN1()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "College";
            lstKeyFldNames.Add("CollegeId");

        }
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
        /// </summary>
        /// <param name = "strCollegeId">关键字:学院Id</param>
        public clsCollegeEN1(string strCollegeId)
        {
            strCollegeId = strCollegeId.Replace("'", "''");
            if (strCollegeId.Length > 6)
            {
                throw new Exception("在表:College中,关键字长度不正确!");

            }
            if (string.IsNullOrEmpty(strCollegeId) == true)
            {
                throw new Exception("在表:College中,关键字不能为空 或 null!");

            }
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCollegeId);

            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));

            }
            this.mstrCollegeId = strCollegeId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "College";
            lstKeyFldNames.Add("CollegeId");

        }
        public override object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == con_CollegeId)
                {
                    return mstrCollegeId;

                }
                else
                {
                    if (strAttributeName == con_CollegeName)
                    {
                        return mstrCollegeName;

                    }
                    else
                    {
                        if (strAttributeName == con_OrderNum)
                        {
                            return mintOrderNum;

                        }
                        else
                        {
                            if (strAttributeName == con__IsDeleted)
                            {
                                return mbol_IsDeleted;

                            }
                            else
                            {
                                if (strAttributeName == con__DeletedDate)
                                {
                                    return mstr_DeletedDate;

                                }
                                else
                                {
                                    if (strAttributeName == con_InUse)
                                    {
                                        return mbolInUse;

                                    }
                                    else
                                    {
                                        if (strAttributeName == con_Memo)
                                        {
                                            return mstrMemo;

                                        }

                                    }

                                }

                            }

                        }

                    }

                }
                return null;

            }
            set
            {
                if (strAttributeName == con_CollegeId)
                {
                    mstrCollegeId = value.ToString();
                    AddUpdatedFld(con_CollegeId);

                }
                else
                {
                    if (strAttributeName == con_CollegeName)
                    {
                        mstrCollegeName = value.ToString();
                        AddUpdatedFld(con_CollegeName);

                    }
                    else
                    {
                        if (strAttributeName == con_OrderNum)
                        {
                            mintOrderNum = TransNullToInt(value.ToString());
                            AddUpdatedFld(con_OrderNum);

                        }
                        else
                        {
                            if (strAttributeName == con__IsDeleted)
                            {
                                mbol_IsDeleted = TransNullToBool(value.ToString());
                                AddUpdatedFld(con__IsDeleted);

                            }
                            else
                            {
                                if (strAttributeName == con__DeletedDate)
                                {
                                    mstr_DeletedDate = value.ToString();
                                    AddUpdatedFld(con__DeletedDate);

                                }
                                else
                                {
                                    if (strAttributeName == con_InUse)
                                    {
                                        mbolInUse = TransNullToBool(value.ToString());
                                        AddUpdatedFld(con_InUse);

                                    }
                                    else
                                    {
                                        if (strAttributeName == con_Memo)
                                        {
                                            mstrMemo = value.ToString();
                                            AddUpdatedFld(con_Memo);

                                        }

                                    }

                                }

                            }

                        }

                    }

                }

            }

        }
        public object this[int intIndex]
        {
            get
            {
                if (con_CollegeId == AttributeName[intIndex])
                {
                    return mstrCollegeId;

                }
                else
                {
                    if (con_CollegeName == AttributeName[intIndex])
                    {
                        return mstrCollegeName;

                    }
                    else
                    {
                        if (con_OrderNum == AttributeName[intIndex])
                        {
                            return mintOrderNum;

                        }
                        else
                        {
                            if (con__IsDeleted == AttributeName[intIndex])
                            {
                                return mbol_IsDeleted;

                            }
                            else
                            {
                                if (con__DeletedDate == AttributeName[intIndex])
                                {
                                    return mstr_DeletedDate;

                                }
                                else
                                {
                                    if (con_InUse == AttributeName[intIndex])
                                    {
                                        return mbolInUse;

                                    }
                                    else
                                    {
                                        if (con_Memo == AttributeName[intIndex])
                                        {
                                            return mstrMemo;

                                        }

                                    }

                                }

                            }

                        }

                    }

                }
                return null;

            }
            set
            {
                if (con_CollegeId == AttributeName[intIndex])
                {
                    mstrCollegeId = value.ToString();
                    AddUpdatedFld(con_CollegeId);

                }
                else
                {
                    if (con_CollegeName == AttributeName[intIndex])
                    {
                        mstrCollegeName = value.ToString();
                        AddUpdatedFld(con_CollegeName);

                    }
                    else
                    {
                        if (con_OrderNum == AttributeName[intIndex])
                        {
                            mintOrderNum = TransNullToInt(value.ToString());
                            AddUpdatedFld(con_OrderNum);

                        }
                        else
                        {
                            if (con__IsDeleted == AttributeName[intIndex])
                            {
                                mbol_IsDeleted = TransNullToBool(value.ToString());
                                AddUpdatedFld(con__IsDeleted);

                            }
                            else
                            {
                                if (con__DeletedDate == AttributeName[intIndex])
                                {
                                    mstr_DeletedDate = value.ToString();
                                    AddUpdatedFld(con__DeletedDate);

                                }
                                else
                                {
                                    if (con_InUse == AttributeName[intIndex])
                                    {
                                        mbolInUse = TransNullToBool(value.ToString());
                                        AddUpdatedFld(con_InUse);

                                    }
                                    else
                                    {
                                        if (con_Memo == AttributeName[intIndex])
                                        {
                                            mstrMemo = value.ToString();
                                            AddUpdatedFld(con_Memo);

                                        }

                                    }

                                }

                            }

                        }

                    }

                }

            }

        }

    }

}



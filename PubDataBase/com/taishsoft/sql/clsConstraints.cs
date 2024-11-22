using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using System.Collections.Generic;

namespace com.taishsoft.sql
{
    /// <summary>
    /// 有关表列（Constraints）的类
    /// </summary>
    public class clsConstraints
    {
        protected const int mintAttributeCount = 6;
        public static string[] AttributeName = new string[] { "Constraint_Name", "Constraint_type", "Delete_action", "Status_for_replication", "Constraint_keys", "Update_action" };
        //以下是属性变量

        protected string mstrConstraint_Name;    //列名
        protected string mstrConstraint_type;    //数据类型
        protected string mstrDelete_action;    //字段长度
        protected string mstrStatus_for_replication;    //是否可空
        protected string mstrConstraint_keys;    //字段缺省值
        protected string mstrUpdate_action;    //精确度

        public clsConstraints()
        {
            
        }

        public clsConstraints(string strConstraint_Name)
        {

            mstrConstraint_Name = strConstraint_Name;
            
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
                if (strAttributeName == "Constraint_Name")
                {
                    return mstrConstraint_Name;
                }
                else if (strAttributeName == "Constraint_type")
                {
                    return mstrConstraint_type;
                }
                else if (strAttributeName == "Delete_action")
                {
                    return mstrDelete_action;
                }
                else if (strAttributeName == "Status_for_replication")
                {
                    return mstrStatus_for_replication;
                }
                else if (strAttributeName == "Constraint_keys")
                {
                    return mstrConstraint_keys;
                }
                else if (strAttributeName == "Update_action")
                {
                    return mstrUpdate_action;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Constraint_Name")
                {
                    mstrConstraint_Name = value.ToString();
                }
                else if (strAttributeName == "Constraint_type")
                {
                    mstrConstraint_type = value.ToString();
                }
                else if (strAttributeName == "Delete_action")
                {
                    mstrDelete_action = value.ToString();
                }
                else if (strAttributeName == "Status_for_replication")
                {
                    mstrStatus_for_replication = value.ToString();
                }
                else if (strAttributeName == "Constraint_keys")
                {
                    mstrConstraint_keys = value.ToString();
                }
                else if (strAttributeName == "Update_action")
                {
                    mstrUpdate_action = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("Constraint_Name" == AttributeName[intIndex])
                {
                    return mstrConstraint_Name;
                }
                else if ("Constraint_type" == AttributeName[intIndex])
                {
                    return mstrConstraint_type;
                }
                else if ("Delete_action" == AttributeName[intIndex])
                {
                    return mstrDelete_action;
                }
                else if ("Status_for_replication" == AttributeName[intIndex])
                {
                    return mstrStatus_for_replication;
                }
                else if ("Constraint_keys" == AttributeName[intIndex])
                {
                    return mstrConstraint_keys;
                }
                else if ("Update_action" == AttributeName[intIndex])
                {
                    return mstrUpdate_action;
                }
                return null;
            }
            set
            {
                if ("Constraint_Name" == AttributeName[intIndex])
                {
                    mstrConstraint_Name = value.ToString();
                }
                else if ("Constraint_type" == AttributeName[intIndex])
                {
                    mstrConstraint_type = value.ToString();
                }
                else if ("Delete_action" == AttributeName[intIndex])
                {
                    mstrDelete_action = value.ToString();
                }
                else if ("Status_for_replication" == AttributeName[intIndex])
                {
                    mstrStatus_for_replication = value.ToString();
                }
                else if ("Constraint_keys" == AttributeName[intIndex])
                {
                    mstrConstraint_keys = value.ToString();
                }
                else if ("Update_action" == AttributeName[intIndex])
                {
                    mstrUpdate_action = value.ToString();
                }
            }
        }

        /// <summary>
        /// 列名
        /// </summary>
        public string Constraint_Name
        {
            get
            {
                return mstrConstraint_Name;
            }
            set
            {
                if (value == "")
                {
                    
                    mstrConstraint_Name = value;
                }
                else
                {
                    mstrConstraint_Name = value;
                }
            }
        }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string Constraint_type
        {
            get
            {
                return mstrConstraint_type;
            }
            set
            {
                if (value == "")
                {
                    
                    mstrConstraint_type = value;
                }
                else
                {
                    mstrConstraint_type = value;
                }
            }
        }
        /// <summary>
        /// 字段长度
        /// </summary>
        public string Delete_action
        {
            get
            {
                return mstrDelete_action;
            }
            set
            {
                mstrDelete_action = value;
            }
        }
        /// <summary>
        /// 是否可空
        /// </summary>
        public string Status_for_replication
        {
            get
            {
                return mstrStatus_for_replication;
            }
            set
            {
                if (value == "")
                {
                    
                    mstrStatus_for_replication = value;
                }
                else
                {
                    mstrStatus_for_replication = value;
                }
            }
        }
        /// <summary>
        /// 字段缺省值
        /// </summary>
        public string Constraint_keys
        {
            get
            {
                return mstrConstraint_keys;
            }
            set
            {
                if (value == "")
                {
                    
                    mstrConstraint_keys = value;
                }
                else
                {
                    mstrConstraint_keys = value;
                }
            }
        }
        /// <summary>
        /// 精确度
        /// </summary>
        public string Update_action
        {
            get
            {
                return mstrUpdate_action;
            }
            set
            {
                mstrUpdate_action = value;
            }
        }
           

        public List<clsConstraints> GetObjList(string strTabName)
        {
            List<clsConstraints> arrObjList = new List<clsConstraints>();
            
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();            
            objDT = objSQL.GetConstraint(strTabName);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsConstraints objConstraints = new clsConstraints();
                objConstraints.Constraint_Name = objRow["Constraint_Name"].ToString().Trim();     //列名
                objConstraints.Constraint_type = objRow["Constraint_type"].ToString().Trim();     //数据类型
                objConstraints.Delete_action = objRow["Delete_action"].ToString().Trim();     //字段长度
                objConstraints.Status_for_replication = objRow["Status_for_replication"].ToString().Trim();     //是否可空
                objConstraints.Constraint_keys = objRow["Constraint_keys"].ToString().Trim();     //字段缺省值
                objConstraints.Update_action = objRow["Update_action"].ToString().Trim();     //精确度
                arrObjList.Add(objConstraints);
            }
            objDT = null;
            return arrObjList;
        }
             

      

        public bool IsExist()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("Constraints", "Constraint_Name=" + "'" + mstrConstraint_Name + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strConstraint_Name">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExist(string strConstraint_Name)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("Constraints", "Constraint_Name=" + "'" + strConstraint_Name + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
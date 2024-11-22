
using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsViewGroupBLEx
    {

        public static bool InitViewGroupENEx1(clsViewGroupENEx objViewGroupENEx, bool bolIsFstLcase)
        {
            clsViewGroupEN objViewGroupEN = new clsViewGroupEN(objViewGroupENEx.ViewGroupId);
            
            //���������Ϊ����

            clsViewGroupBL.CopyTo(objViewGroupEN, objViewGroupENEx);

            //����������û����Ӧ����ӡ��޸ġ���ϸ��Ϣ���б����,���û��,�Ͳ���������Ӧ��Manager
            string strViewId;
            //��ʼ����ӽ���
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0013' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewAdd =        new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewAdd, bolIsFstLcase, objViewGroupENEx.PrjId);
            //��ʼ���޸Ľ���
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0016' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewUpdate = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewUpdate, bolIsFstLcase, objViewGroupENEx.PrjId);
            //��ʼ����ѯ����
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0015' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewQuery = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewQuery, bolIsFstLcase, objViewGroupENEx.PrjId);
            //��ʼ����ϸ��Ϣ����
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0017' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewDetail = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewDetail, bolIsFstLcase, objViewGroupENEx.PrjId);
            //��ʼ���б����
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0014' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewList = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewList, bolIsFstLcase, objViewGroupENEx.PrjId);
            objViewGroupENEx.arrDetailFldSet = new ArrayList();
            initDGRegionFldSet(objViewGroupENEx);
            initEditRegionFldSet(objViewGroupENEx);
            initEditRegionFldSet_Update(objViewGroupENEx);
            initQryRegionFldSet(objViewGroupENEx);
            initViewRelaTabFldSet(objViewGroupENEx);
            //objViewGroupENEx.arrvViewGroupFldSet = clsvViewGroupFldsBL.GetObjLst(" ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            //string strCondition = string.Format("PrjId = '{0}'", objViewGroupENEx.PrjId);
            //objViewGroupENEx.arrFieldTabExObjLstBak = clsFieldTabBLEx.GetObjLstEx(strCondition);
            return true;
        }

        //public string FolderName
        //{
        //    get
        //    {
        //        return mstrFolderName; // '�ļ�Ŀ¼��
        //    }
        //    set
        //    {
        //        mstrFolderName = value;
        //    }
        //}
        //public string FileName
        //{
        //    get
        //    {
        //        return mstrFileName;
        //    }
        //    set
        //    {
        //        mstrFileName = value;
        //    }
        //}


        public static void initQryRegionFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewGroupENEx.objViewQuery.ViewId,
                clsRegionTypeENEx.QUERYREGION , objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewGroupENEx. objQueryRegion = (clsQueryRegionENEx) clsQueryRegionBLEx.GetObjByRegionIdCacheEx(lngRegionId, objViewGroupENEx.PrjId);
            //clsQueryRegionBLEx.InitViewRegion(objViewGroupENEx.objQueryRegion);
            objViewGroupENEx.arrQryRegionFldSet_Query = clsQryRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewGroupENEx.arrQryRegionFldSet_Query)
            {
                //objQryRegionFldsEx.arrFieldTabExObjLstBak = objViewGroupENEx.arrFieldTabExObjLstBak;
                
                objQryRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objQryRegionFldsEx.FldId, objViewGroupENEx.PrjId);
                
                objQryRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFldsEx.CtlTypeId);
            }
        }

        public static void initEditRegionFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            //����:
            //1���жϳ�ʼ�����Ƿ�Ϸ�
            //2���ѱ��������Ϣ��ʼ����һ���������,
            //  Ȼ��浽������
            //3��            
            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewGroupENEx.objViewAdd.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //��ʼ����ӽ���༭�����ֶ��б�
            objViewGroupENEx.arrEditRegionFldSet_Add = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Add)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
            //��ʼ��<�޸�>����༭�����ֶ��б�
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache( objViewGroupENEx.objViewUpdate.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Update = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Update)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }

            //��ʼ��<��ϸ��Ϣ>����༭�����ֶ��б�
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache( objViewGroupENEx.objViewDetail.ViewId ,
                clsRegionTypeENEx.DETAILREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Detail = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Detail)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
        }

        public static void initEditRegionFldSet_Update(clsViewGroupENEx objViewGroupENEx)
        {
            //����:
            //1���жϳ�ʼ�����Ƿ�Ϸ�
            //2���ѱ��������Ϣ��ʼ����һ���������,
            //  Ȼ��浽������
            //3��
            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewGroupENEx.objViewUpdate.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //��ʼ����ӽ���༭�����ֶ��б�
            objViewGroupENEx.arrEditRegionFldSet_Add = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Add)
            {
               
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
            //��ʼ��<�޸�>����༭�����ֶ��б�
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache( objViewGroupENEx.objViewUpdate.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Update = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Update)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);


                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }

            //��ʼ��<��ϸ��Ϣ>����༭�����ֶ��б�
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache( objViewGroupENEx.objViewDetail.ViewId ,
                clsRegionTypeENEx.DETAILREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Detail = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Detail)
            {

                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
        }


        public static void initDGRegionFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            //��ȡ����ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache( objViewGroupENEx.objViewList.ViewId ,
                clsRegionTypeENEx.DGREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrDGRegionFldSet_List = clsDGRegionFldsBLEx.GetObjExLst("RegionId = " + lngRegionId);
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewGroupENEx.arrDGRegionFldSet_List)
            {                
                objDGRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
            }
        }
        public static void initViewRelaTabFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            if (objViewGroupENEx.OutRelaTabId !=  "")
            {
                objViewGroupENEx .objOUTPrjTab = new clsPrjTabENEx(objViewGroupENEx.OutRelaTabId);
                     objViewGroupENEx.objOUTPrjTab.GetObjAllInfoEx();
              objViewGroupENEx .arrOUTTabFldSet = clsPrjTabFldBLEx.GetObjLstEx("TabId = '" + objViewGroupENEx.OutRelaTabId + "'");
            }
            if (objViewGroupENEx.InRelaTabId !=  "")
            {
                objViewGroupENEx .objINPrjTab = new clsPrjTabENEx(objViewGroupENEx.InRelaTabId);
                 objViewGroupENEx.objINPrjTab.GetObjAllInfoEx();
          objViewGroupENEx .arrINTabFldSet = clsPrjTabFldBLEx.GetObjLstEx("TabId = '" + objViewGroupENEx.InRelaTabId + "'");
            }
            //��ȡ���ֶζ���(PrjTabFld)���ֶ�(FieldTab)��������
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewGroupENEx.arrOUTTabFldSet)
            {
                //objPrjtabFldEx.arrFieldTabExObjLstBak = objViewGroupENEx. arrFieldTabExObjLstBak;
                //clsPrjTabFldBLEx.InitFieldTab(objPrjtabFldEx);
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                {
                    objViewGroupENEx.objMainTabKeyFld = objPrjTabFldENEx;
                }

            }
            if (objViewGroupENEx.objMainTabKeyFld  ==  null)
            {
                string strOutRelaTabName = clsPrjTabBL.GetObjByTabId(objViewGroupENEx.OutRelaTabId).TabName;
                throw new clsDbObjException("���������Դ:" + strOutRelaTabName + "��û�����ñ�ؼ���!");
            }
            if (objViewGroupENEx.arrINTabFldSet !=  null)
            {
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewGroupENEx.arrINTabFldSet)
                {
                    //objPrjtabFldEx.arrFieldTabExObjLstBak = objViewGroupENEx. arrFieldTabExObjLstBak;
                    //clsPrjTabFldBLEx.InitFieldTab(objPrjtabFldEx);
                    objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                    if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                    {
                        objViewGroupENEx. objDetailTabKeyFld = objPrjTabFldENEx;
                    }
                }
            }
        }

        private static void InsertToDetailFldSet(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewGroupENEx objViewGroupENEx)
        {
            string strNewFldName = objEditRegionFldsEx.ObjFieldTabENEx.FldName;
            bool bolIsExist = false;
            foreach (clsEditRegionFldsENEx objDetailFld in objViewGroupENEx.arrDetailFldSet)
            {
                if (objDetailFld.ObjFieldTabENEx.FldName  ==  strNewFldName)
                {
                    bolIsExist = true;
                    break;
                }
            }
            if (bolIsExist  ==  false)
            {
                objViewGroupENEx.arrDetailFldSet.Add(objEditRegionFldsEx);
            }
        }


        public static System.Data.DataTable GetViewGroupId(string strPrjId)
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup where PrjId = '" + strPrjId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_ViewGroupIdEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //Ϊ����ԴΪ�����������������
            System.Data.DataTable objDT = GetViewGroupId(strPrjId);
            clsViewGroupEN objViewGroup;
            //��ʼ��һ�������б�
            ArrayList ViewGroupList = new ArrayList();
            //�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�
            objViewGroup = new clsViewGroupEN();
            objViewGroup.ViewGroupId = "0";
            objViewGroup.ViewGroupName = "��ѡ��...";
            ViewGroupList.Add(objViewGroup);
            //��DataTable�е���������ӵ������б���
            foreach (DataRow objRow in objDT.Rows)
            {
                objViewGroup = new clsViewGroupEN();
                objViewGroup.ViewGroupId = objRow["ViewGroupId"].ToString();
                objViewGroup.ViewGroupName = objRow["ViewGroupName"].ToString();
                ViewGroupList.Add(objViewGroup);
            }
            //���������������Դ���Լ�����ֵ���ʾ��
            objComboBox.DataSource = ViewGroupList;
            objComboBox.ValueMember = "ViewGroupId";
            objComboBox.DisplayMember = "ViewGroupName";
            objComboBox.SelectedIndex = 0;
        }

        public static void BindDdl_ViewGroupIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //Ϊ����Դ�ڱ����������������
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("��ѡ��...", "0");
//            System.Data.DataTable objDT = GetViewGroupId(strPrjId);
            List<clsViewGroupEN> arrViewGroupObjLst = clsViewGroupBLEx.GetViewGroupObjLstByPrjIdCache(strPrjId);
            objDDL.DataValueField = "ViewGroupId";
            objDDL.DataTextField = "ViewGroupName";
            objDDL.DataSource = arrViewGroupObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_ViewGroup(System.Windows.Forms.ListView lvViewGroup, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviViewGroup;
            List<clsViewGroupEN> arrViewGroupObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrViewGroupObjList = clsViewGroupBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvViewGroup.Items.Clear();//���ԭ������Item
            lvViewGroup.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvViewGroup.Columns.Add("������ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("����������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("��������Դ��ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("��������Դ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("�������Դ��ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("��/����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("����ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("�û�ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("�޸�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("�������Դ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsViewGroupEN objViewGroup in arrViewGroupObjList)
            {
                lviViewGroup = new System.Windows.Forms.ListViewItem();
                lviViewGroup.Tag = objViewGroup.ViewGroupId;
                lviViewGroup.Text = objViewGroup.ViewGroupId;
                lviViewGroup.SubItems.Add(objViewGroup.ViewGroupName);
                lviViewGroup.SubItems.Add(objViewGroup.InRelaTabId);
                lviViewGroup.SubItems.Add(objViewGroup.InSqlDsTypeId);
                lviViewGroup.SubItems.Add(objViewGroup.OutRelaTabId);
                lviViewGroup.SubItems.Add(objViewGroup.PrjDomain);
                lviViewGroup.SubItems.Add(objViewGroup.PrjId);
                lviViewGroup.SubItems.Add(objViewGroup.UserId);
                lviViewGroup.SubItems.Add(objViewGroup.UpdDate);
                lviViewGroup.SubItems.Add(objViewGroup.Memo);
                lviViewGroup.SubItems.Add(objViewGroup.OutSqlDsTypeId);
                lvViewGroup.Items.Add(lviViewGroup);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrViewGroupObjList.Count;
        }
    }
}

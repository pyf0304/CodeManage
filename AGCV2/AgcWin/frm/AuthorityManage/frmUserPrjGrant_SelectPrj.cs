///���������صĿؼ����Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using CommFunc4Win;
using AGC.Entity;
using System.Collections.Generic;
//using AGC.BusinessLogicEx;

using AGC4WApi;

namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_QD_LV ��ժҪ˵����
    /// </summary>
    public partial class frmUserPrjGrant_SelectPrj : System.Windows.Forms.Form, IBindListView
    {
        //clsUserPrjGrantEN objUserPrjGrant = null;
        
        private System.Data.DataTable objDTUserPrjGrant = null;
        private clsListViewSorter objvUserPrjGrantSorter;
        private int intLastSelectedvUserPrjGrantColumIndex;
        public frmUserPrjGrant_SelectPrj()
        {
            // �õ����� Windows.Forms ���������������ġ�
            InitializeComponent();

            // TODO: �� InitializeComponent ���ú�����κγ�ʼ��
            objvUserPrjGrantSorter = new clsListViewSorter();
            //ΪListViewItemSorterָ��������
            this.lvvUserPrjGrant.ListViewItemSorter = objvUserPrjGrantSorter;
            objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmUserPrjGrant_QD_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            ///1��Ϊ��������������Դ�����б�����
            this.SetAllComboBox();
            BindLv_vUserPrjGrant();

        }
        /// <summary>
        /// ������İ󶨺���
        /// </summary>
        private void SetAllComboBox()
        {
        }
        ///������ϲ�ѯ�����Ĵ���
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion()
        {
            ///ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            ///���� 1=1 && UserName = '����'
            string strWhereCond = string.Format(" 1=1 and {0} = '{1}' And {2}='0001'",
                convUserPrjGrant.UserId,  clsSysParaEN.strUserId ,
                convUserPrjGrant.UseStateId);
            return strWhereCond;
        }
       
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��ListView�С�
        /// </summary>
        private void BindLv_vUserPrjGrant()
        {
            ///	�������裺(��4��)
            ///	1����Ͻ�����������
            ///	2��������������ȡ�ñ�����������DataTable��
            ///	3������ListView����ͷ��Ϣ
            ///	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            ///		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            ListViewItem lvivUserPrjGrant;
            List<clsvUserPrjGrantEN> arrvUserPrjGrantObjList;
            ///	1����Ͻ�����������
            string strWhereCond = this.CombineUserPrjGrantCondion();	//  CombineUserPrjGrantCondion();
            ///	2��������������ȡ�ñ�����������DataTable��
            //if (clsSysParaEN.bolIsUseXmlDataSource == true)
            //{
            //    arrvUserPrjGrantObjList = new clsvUserPrjGrantEx().GetObjLstForXml(strWhereCond);
            //}
            //else
            //{
                arrvUserPrjGrantObjList =  clsvUserPrjGrantWApi.GetObjLst(strWhereCond + " Order by VisitedNum Desc");
            //}
            ///	3������ListView����ͷ��Ϣ
            this.lvvUserPrjGrant.Items.Clear();//���ԭ������Item
            this.lvvUserPrjGrant.Columns.Clear();//���ԭ��������ͷ��Ϣ
            this.lvvUserPrjGrant.Columns.Add("�û�ID", 60, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("�û���", 60, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��Ŀ����", 240, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��ɫ����", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("������", 60, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("������", 80, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("�û�״̬", 100, HorizontalAlignment.Left);
            //this.lvvUserPrjGrant.Columns.Add("������Id", 100, HorizontalAlignment.Left);
            //this.lvvUserPrjGrant.Columns.Add("��������", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��ע", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.View = View.Details;
            ///	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsvUserPrjGrantEN objvUserPrjGrant in arrvUserPrjGrantObjList)
            {
                lvivUserPrjGrant = new ListViewItem();
                lvivUserPrjGrant.Tag = objvUserPrjGrant.mId;
                lvivUserPrjGrant.Text = objvUserPrjGrant.UserId;
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.UserName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.PrjName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.RoleName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.VisitedNum.ToString());
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.DepartmentName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.UserStateName);
                //lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptId);
                //lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptDate);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.Memo);
                this.lvvUserPrjGrant.Items.Add(lvivUserPrjGrant);
            }
            ///	4�����ü�¼����״̬��
            ///		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            this.lblRecNum.Text = "��¼����" + arrvUserPrjGrantObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //�ѱ��¼��������ʾ��ListView��
            BindLv_vUserPrjGrant();
        }
        /// <summary>
        /// ��ȡDataGrid�е�ǰ�е�����ֵ
        /// </summary>
        /// <param name="objDataGrid">��������DataGrid</param>
        /// <returns>��ǰ�е�����ֵ</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTUserPrjGrant.Rows[intCurrRow]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            return lngmId;
        }
        /// <summary>
        /// ��ȡListView�е�ǰ�е�����ֵ
        /// </summary>
        /// <param name="objListViewItem">��������ListView</param>
        /// <returns>��ǰ�е�����ֵ</returns>
        private long GetCurrKey(ListViewItem objListViewItem)
        {
            string strKeyId = objListViewItem.Tag.ToString();
            return long.Parse(strKeyId);
        }
        /// <summary>
        /// ��ȡListView�е�ǰ�е�����ֵ
        /// </summary>
        /// <param name="objListView">��������ListView</param>
        /// <returns>��ǰ�е�����ֵ</returns>
        private long GetCurrKey(ListView objListView)
        {
            ListViewItem lviUserPrjGrant;
            if (objListView.SelectedItems.Count == 0) return 0;
            lviUserPrjGrant = objListView.SelectedItems[0];
            string strUserPrjGrantId = lviUserPrjGrant.Tag.ToString();
            long lngmId = long.Parse(strUserPrjGrantId);
            return lngmId;
        }
      
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateUserPrjGrantRecord();
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteUserPrjGrantRecord();
        }
       
 
        /// <summary>
        /// �������ܣ�LISTVIEW���е����¼�����
        /// </summary>
        private void lvvUserPrjGrant_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvUserPrjGrantSorter.SortColumn)
            {

            }
            else
            {
                this.objvUserPrjGrantSorter.SortColumn = e.Column;
            }

            if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column) //���Ƿ��ظ����һ��
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else //����������һ���ˣ���ôǰ������һ������ȥ��
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('��', '��');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Descending) // �� ��
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column)
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('��', '��');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvUserPrjGrant.Sort();
        }

        /// <summary>
        /// ʵ�ֽӿں�����ͨ���Ӵ�����ã���ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vUserPrjGrant();
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        private void UpdateUserPrjGrantRecord()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("��ѡ��һ����¼��");
                return;
            }
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            string strKeyId = this.lvvUserPrjGrant.SelectedItems[0].Tag.ToString();
            frm.mId_key = long.Parse(strKeyId);
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        ///ɾ����¼���̴���for C#
        private void DeleteUserPrjGrantRecord()
        {
            DialogResult result;
            result = MessageBox.Show("�����Ҫɾ���ü�¼��", "ȷ��ɾ��", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvUserPrjGrant.SelectedItems)
                {
                    long lngmId = GetCurrKey(lvi);
                    if (clsUserPrjGrantWApi.DelRecord(lngmId) == 0)
                    {
                        MessageBox.Show("ɾ����¼ʧ�ܣ�");
                        BindLv_vUserPrjGrant();
                        return;
                    }
                }
                MessageBox.Show("ɾ����¼�ɹ���");
                BindLv_vUserPrjGrant();
            }
        }

        private void btnSelectPrj_Click(object sender, EventArgs e)
        {
            SelectProject();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvvUserPrjGrant_DoubleClick(object sender, EventArgs e)
        {
            SelectProject();
        }
        private void SelectProject()
        {
            long lngmId = GetCurrKey(lvvUserPrjGrant);
            if (lngmId == 0) return;
            clsUserPrjGrantEN objUserPrjGrant = clsUserPrjGrantWApi.GetObjBymId(lngmId);
            //if (clsSysParaEN.bolIsUseXmlDataSource == true)
            //{
            //    objUserPrjGrant.GetUserPrjGrantForXml();
            //}
            //else
            //{
            //    objUserPrjGrant.GetUserPrjGrant();
            //}
            //clsFieldSetEN.arrFieldObjLst = null;
            //clsFieldSetEN.arrFieldTabObjLst = null;
            clsPubVar.arrUserCodePathENObjLst = null;
            clsSysParaEN.CurrSelPrjId = objUserPrjGrant.PrjId;
            clsSysParaEN.strUserRoleId = objUserPrjGrant.RoleId;
            clsPubVar.CurrSelPrjId = objUserPrjGrant.PrjId;
            clsPubVar.CurrPrjDataBaseId = clsUserDefaPrjDataBaseExWApi.GetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
               
            clsPubVar.objCurrSelProjectEN = clsProjectsWApi.GetObjByPrjId( clsSysParaEN.CurrSelPrjId);
                  
            if (clsSysParaEN.bolIsUseXmlDataSource == false)
            {
                clsUserLogExWApi.SetUsedLog(clsSysParaEN.strUserId, "Project", clsPubVar.CurrSelPrjId);
                try
                {
                    //��������1
                    objUserPrjGrant.VisitedNum++;
                    objUserPrjGrant.sfUpdFldSetStr = objUserPrjGrant.getsfUpdFldSetStr();
                    objUserPrjGrant.Update();
                }
                catch (Exception objException)
                {
                    MessageBox.Show("�޸ķ��ʴ������ɹ�!\r\n" + objException.Message);
                }
            }
            if (clsPubVar.objMainForm == null)
            {
                clsPubVar.objMainForm = new MdiForm();
            }

            clsPubVar.objMainForm.DispMenu();
            clsPubVar.bolIsDispMenu = true;
            this.Close();
        }
    }
}
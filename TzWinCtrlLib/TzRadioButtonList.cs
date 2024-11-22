using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TzWinCtrlLib.Properties;

namespace TzWinCtrlLib
{
    public partial class TzRadioButtonList : UserControl
    {
        #region Variable
        private Object _dataSource;
        private ButtonValueMapping[] _mappings;
        private Object _internalDataSource;
        private string _displayMember;
        private string _valueMember;
        private string _value;
        private System.Windows.Forms.FlowDirection _flowDirection;
        #endregion

        #region ctor.
        public TzRadioButtonList()
        {
            InitializeComponent();
        }
        #endregion ctor

        #region prop
        public System.Object DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
            }
        }
        public string DisplayMember
        {
            get
            {
                return _displayMember;
            }
            set
            {
                _displayMember = value;
            }
        }
        public string ValueMember
        {
            get
            {
                return _valueMember;
            }
            set
            {
                _valueMember = value;
            }
        }
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value != null)
                {
                    _value = value;
                    SetValue(value);
                }
            }

        }

        public System.Windows.Forms.FlowDirection FlowDirection
        {
            get
            {
                return _flowDirection;
            }

            set
            {
                flowLayoutPanel1.FlowDirection = value;// System.Windows.Forms.FlowDirection.
                _flowDirection = value;
            }
        }
        #endregion

        #region event
        //SelectedIndexChanged
        public delegate void RadioSelectedHandler(object sender, SelectedEventArgs e);
        public event RadioSelectedHandler RadioItemSeleted;
        #endregion

        #region public method
        public void DataBind()
        {
            if (_dataSource == null)
                throw new NullReferenceException("Null reference in Property: DataSource ");
            PrepareData();
            DrawControl();
        }
        #endregion

        //Internal Function
        #region internal function

        void DrawControl()
        {
            flowLayoutPanel1.Controls.Clear();
            int count = _mappings.Length;
            //Draw and set control
            int height = 0;
            int x_aris = 10;
            int y_aris = 20;
            for (int i = 0; i < count; i++)
            {
                //create the radio button
                RadioButton radio = new RadioButton();
                radio.Name = i.ToString();
                radio.Text = _mappings[i].Text;
                radio.AutoSize = true;

                //put radio button into the panel
                flowLayoutPanel1.Controls.Add(radio);
                radio.Location = new Point(x_aris, y_aris + height);
                height += radio.Height;

                //Add click event to radio button
                radio.Click += new EventHandler(radio_Click);
            }

        }
        //Deal with the data source. Add additional code here if you want some new type of objet to be the datasource.
        void PrepareData()
        {
            string str1 = _dataSource.GetType().ToString();
            if (str1.Contains("List") == true)
            {
                string str2 = _dataSource.GetType().ToString();
                //foreach (var item in _dataSource)
                //{
                //    Project proj = (Project)item;
                //    if (proj.equals(myProject))//判断是不是等于你的数据,需要重写equals方法,当然你也可以跟据名字判断(如果名字不会重复的话)
                //    {
                //        listHasMyproject = true;
                //    }
                //}
            }
            if (_dataSource is DataTable)
            {
                _internalDataSource = ((DataTable)_dataSource).DefaultView;
            }
            if (_dataSource is DataView)
                _internalDataSource = _dataSource;
            //Exception
            if (_internalDataSource == null) throw new InvalidCastException("The data source is not a desinged type.");

            //prepare the _radiobutton & _mappings to creat the radio listre
            #region DataView & DataTable as data source
            if (_internalDataSource is DataView)
            {
                int radioCount = ((DataView)_internalDataSource).Count;
                _mappings = new ButtonValueMapping[radioCount];
                try
                {
                    for (int i = 0; i < radioCount; i++)
                    {
                        //Set index
                        _mappings[i].Index = i;
                        //Set display text
                        _mappings[i].Text = ((DataView)_internalDataSource)[i][_displayMember].ToString();
                        //Set value
                        if (_valueMember == null || _valueMember == string.Empty)
                        {
                            _mappings[i].Value = i.ToString();
                        }
                        else
                        {
                            _mappings[i].Value = ((DataView)_internalDataSource)[i][_valueMember].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            #endregion
        }

        //internal event when a radio button is clicked. this fuction will call a public event.
        void radio_Click(object sender, EventArgs e)
        {
            Value = _mappings[int.Parse(((RadioButton)sender).Name)].Value;
            SelectedEventArgs se = new SelectedEventArgs();
            se.Value = _mappings[int.Parse(((RadioButton)sender).Name)].Value;
            //after click,execute the SelectedIndexChanged. if the parent doesnot use this event ,you should not write the underline
            if (RadioItemSeleted != null)
            {
                RadioItemSeleted(this, se);
            }
        }

        //When Value changes , set the relative radio button is selected.
        void SetValue(string value)
        {
            if (_mappings == null)
                throw new NullReferenceException("Data has not bound to the control");
            foreach (ButtonValueMapping map in _mappings)
            {
                if (map.Value == value)
                {
                    ((RadioButton)flowLayoutPanel1.Controls[map.Index.ToString()]).Checked = true;
                    return;
                }
            }
        }
        #endregion

        internal struct ButtonValueMapping
        {
            public int Index;
            public string Value;
            public string Text;
        }

        /// <summary>
        /// self defined class use for storaging the selected value, also can use as a parameter type
        /// </summary>
        public class SelectedEventArgs : EventArgs
        {
            public string Value;
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 22);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TzRadioButtonList
            // 
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TzRadioButtonList";
            this.Size = new System.Drawing.Size(272, 36);
            this.SizeChanged += new System.EventHandler(this.TzRadioButtonList_SizeChanged);
            this.ResumeLayout(false);

        }

        private void TzRadioButtonList_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Left = 0;
            flowLayoutPanel1.Top = 0;
            flowLayoutPanel1.Width = this.Width;
            flowLayoutPanel1.Height = this.Height;
        }
    }
}

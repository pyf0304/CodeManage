using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoGCLib
{
  /// ColumnTemplate ��ITemplate�̳С�
  /// "InstantiateIn"�����ӿؼ�������˭

  public class ColumnTemplate : ITemplate
  {
    public void InstantiateIn(Control container)
    {
      Label myLabel = new Label();
      myLabel.Text = "���ɾ��";
      CheckBox mycheckbox = new CheckBox();
      container.Controls.Add(myLabel);
      container.Controls.Add(mycheckbox);
    }
  }

  public class ColumnTemplate_Chk : ITemplate
  {
    public void InstantiateIn(Control container)
    {
      CheckBox mycheckbox = new CheckBox();
      container.Controls.Add(mycheckbox);
    }
  }
  public class ColumnTemplate_Radio : ITemplate
  {
    public void InstantiateIn(Control container)
    {
      RadioButton myRadioBtn = new RadioButton();
      container.Controls.Add(myRadioBtn);
    }
  }

}

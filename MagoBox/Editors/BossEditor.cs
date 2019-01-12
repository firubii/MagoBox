using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDLLVL;

namespace MagoBox.Editors
{
    public partial class BossEditor : Form
    {
        public RDLLVL.Boss obj;
        Objects objs = new Objects();

        public BossEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.BossList.Values.ToArray());
            type.Text = obj.Type.ToString();
            p1.Text = obj.Param1.ToString("X");
            p2.Text = obj.Param2.ToString("X");
            p3.Text = obj.Param3.ToString("X");
            super.Checked = obj.HasSuperAbility;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Param1 = uint.Parse(p1.Text, System.Globalization.NumberStyles.HexNumber);
            obj.Param2 = uint.Parse(p2.Text, System.Globalization.NumberStyles.HexNumber);
            obj.Param3 = uint.Parse(p3.Text, System.Globalization.NumberStyles.HexNumber);
            obj.HasSuperAbility = super.Checked;
            obj.X = (uint)xCoord.Value;
            obj.XOffset = (uint)xOffs.Value;
            obj.Y = (uint)yCoord.Value;
            obj.YOffset = (uint)yOffs.Value;
            DialogResult = DialogResult.OK;
        }

        private void type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (objs.BossList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.BossList[uint.Parse(type.Text)];
                }
                else
                {
                    objDropDown.Text = "";
                }
            }
            catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Text = objs.BossList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();
        }
    }
}

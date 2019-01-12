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
    public partial class EnemyEditor : Form
    {
        public RDLLVL.Enemy obj;
        Objects objs = new Objects();

        public EnemyEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.EnemyList.Values.ToArray());

            type.Text = obj.Type.ToString();
            behavior.Text = obj.Behavior.ToString();
            p1.Text = obj.Param1.ToString();
            p2.Text = obj.Param2.ToString();
            sizeAd.Value = obj.SizeAD;
            sizeEx.Value = obj.SizeEX;
            movingId.Value = obj.MovingTerrainID;
            super.Checked = obj.HasSuperAbility;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Behavior = uint.Parse(behavior.Text);
            obj.Param1 = uint.Parse(p1.Text);
            obj.Param2 = uint.Parse(p2.Text);
            obj.SizeAD = (uint)sizeAd.Value;
            obj.SizeEX = (uint)sizeEx.Value;
            obj.MovingTerrainID = (int)movingId.Value;
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
                if (objs.EnemyList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.EnemyList[uint.Parse(type.Text)];
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
            type.Text = objs.EnemyList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();
        }
    }
}

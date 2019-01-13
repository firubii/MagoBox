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
    public partial class ItemEditor : Form
    {
        public RDLLVL.Item obj;
        Objects objs = new Objects();

        public ItemEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.ItemList.Values.ToArray());

            type.Text = obj.Type.ToString();
            subtype.Text = obj.SubType.ToString();
            behavior.Text = obj.Behavior.ToString();
            movingId.Value = obj.MovingTerrainID;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.SubType = uint.Parse(subtype.Text);
            obj.Behavior = uint.Parse(behavior.Text);
            obj.MovingTerrainID = (int)movingId.Value;
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
                if (objs.ItemList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.ItemList[uint.Parse(type.Text)];
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
            type.Text = objs.ItemList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();
        }
    }
}

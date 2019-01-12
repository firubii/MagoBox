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
    public partial class ObjectEditor : Form
    {
        public RDLLVL.Object obj;
        Objects objs = new Objects();

        public ObjectEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.ObjectList.Values.ToArray());

            type.Text = obj.Type.ToString();
            p1.Text = obj.Param1.ToString();
            p2.Text = obj.Param2.ToString();
            p3.Text = obj.Param3.ToString();
            p4.Text = obj.Param4.ToString();
            p5.Text = obj.Param5.ToString();
            p6.Text = obj.Param6.ToString();
            p7.Text = obj.Param7.ToString();
            p8.Text = obj.Param8.ToString();
            p9.Text = obj.Param9.ToString();
            p10.Text = obj.Param10.ToString();
            p11.Text = obj.Param11.ToString();
            p12.Text = obj.Param12.ToString();
            unk.Text = obj.Unknown.ToString();
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Param1 = uint.Parse(p1.Text);
            obj.Param2 = uint.Parse(p2.Text);
            obj.Param3 = uint.Parse(p3.Text);
            obj.Param4 = uint.Parse(p4.Text);
            obj.Param5 = uint.Parse(p5.Text);
            obj.Param6 = uint.Parse(p6.Text);
            obj.Param7 = uint.Parse(p7.Text);
            obj.Param8 = uint.Parse(p8.Text);
            obj.Param9 = uint.Parse(p9.Text);
            obj.Param10 = uint.Parse(p10.Text);
            obj.Param11 = uint.Parse(p11.Text);
            obj.Param12 = uint.Parse(p12.Text);
            obj.Unknown = uint.Parse(unk.Text);
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
                if (objs.ObjectList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.ObjectList[uint.Parse(type.Text)];
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
            type.Text = objs.ObjectList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();
        }
    }
}

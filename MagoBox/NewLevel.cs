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

namespace MagoBox
{
    public partial class NewLevel : Form
    {
        public Level level;
        Objects objs = new Objects();

        public NewLevel()
        {
            InitializeComponent();
        }

        private void NewLevel_Load(object sender, EventArgs e)
        {
            bg.Items.AddRange(objs.DecorationList.Values.ToArray());
            tileset.Items.AddRange(objs.DecorationList.Values.ToArray());
            bgm.Items.AddRange(objs.BGMList.ToArray());
            bg.SelectedIndex = 0;
            tileset.SelectedIndex = 0;
            bgm.SelectedIndex = 0;
        }

        private void createLevel_Click(object sender, EventArgs e)
        {
            level = new Level();

            level.Height = (uint)sizeH.Value;
            level.Width = (uint)sizeW.Value;

            Collision c = new Collision();
            Block b = new Block();
            Decoration d = new Decoration();
            b.ID = -1;
            d.Unk_1 = 255;
            d.Unk_2 = 255;
            d.Unk_3 = 0;
            d.MovingTerrainID = -1;

            for (int i = 0; i < level.Height * level.Width; i++)
            {
                level.TileCollision.Add(c);
                level.TileBlock.Add(b);
                level.BLandDecoration.Add(d);
                level.MLandDecoration.Add(d);
                level.FLandDecoration.Add(d);
            }

            level.Background = objs.DecorationList.FirstOrDefault(x => x.Value == bg.Text).Key;
            level.Tileset = objs.DecorationList.FirstOrDefault(x => x.Value == tileset.Text).Key;
            level.StageData.BGM = bgm.Text;

            DialogResult = DialogResult.OK;
        }
    }
}

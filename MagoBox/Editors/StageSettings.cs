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
    public partial class StageSettings : Form
    {
        public Stage data;
        public uint tileset;
        public uint background;
        Objects objs = new Objects();

        public StageSettings()
        {
            InitializeComponent();
        }

        private void StageSettings_Load(object sender, EventArgs e)
        {
            bgDropDown.Items.AddRange(objs.DecorationList.Values.ToArray());
            tilesetDropDown.Items.AddRange(objs.DecorationList.Values.ToArray());
            filterDropDown.Items.AddRange(objs.FilterList.Values.ToArray());
            runEffectDropDown.Items.AddRange(objs.RunEffectList.Values.ToArray());
            bgmDropDown.Items.AddRange(objs.BGMList.ToArray());

            x.Text = data.BgX.ToString();
            y.Text = data.BgY.ToString();
            z.Text = data.BgZ.ToString();
            xrot.Text = data.BgRotX.ToString();
            yrot.Text = data.BgRotY.ToString();
            zrot.Text = data.BgRotZ.ToString();
            dist.Text = data.BgDistance.ToString();

            scrollx.Text = data.BgScrollSpeedX.ToString();
            scrolly.Text = data.BgScrollSpeedY.ToString();
            scrolldx.Text = data.BgScrollDownX.ToString();
            scrollbx.Text = data.BgScrollBackX.ToString();
            scrollry.Text = data.BgScrollRightY.ToString();
            scrollby.Text = data.BgScrollBackY.ToString();

            bgDropDown.Text = objs.DecorationList[background];
            tilesetDropDown.Text = objs.DecorationList[tileset];
            filterDropDown.Text = objs.FilterList[data.Filter];
            runEffectDropDown.Text = objs.RunEffectList[data.RunEffect];
            bgmDropDown.Text = data.BGM;

            respawnId.Text = data.DeathStartID.ToString();
            stepChange.Text = data.DeathStepChange.ToString();
            changeStep.Checked = Convert.ToBoolean(data.DeathStepFlag);
        }

        private void changeStep_CheckedChanged(object sender, EventArgs e)
        {
            stepChange.Enabled = changeStep.Checked;
        }

        private void save_Click(object sender, EventArgs e)
        {
            data.BgX = float.Parse(x.Text);
            data.BgY = float.Parse(y.Text);
            data.BgZ = float.Parse(z.Text);
            data.BgRotX = float.Parse(xrot.Text);
            data.BgRotY = float.Parse(yrot.Text);
            data.BgRotZ = float.Parse(zrot.Text);
            data.BgDistance = float.Parse(dist.Text);

            data.BgScrollSpeedX = float.Parse(scrollx.Text);
            data.BgScrollSpeedY = float.Parse(scrolly.Text);
            data.BgScrollDownX = float.Parse(scrolldx.Text);
            data.BgScrollBackX = float.Parse(scrollbx.Text);
            data.BgScrollRightY = float.Parse(scrollry.Text);
            data.BgScrollBackY = float.Parse(scrollby.Text);

            background = objs.DecorationList.FirstOrDefault(x => x.Value == bgDropDown.Text).Key;
            tileset = objs.DecorationList.FirstOrDefault(x => x.Value == tilesetDropDown.Text).Key;
            data.Filter = objs.FilterList.FirstOrDefault(x => x.Value == filterDropDown.Text).Key;
            data.RunEffect = objs.RunEffectList.FirstOrDefault(x => x.Value == runEffectDropDown.Text).Key;
            data.BGM = bgmDropDown.Text;

            data.DeathStartID = uint.Parse(respawnId.Text);
            data.DeathStepChange = int.Parse(stepChange.Text);
            data.DeathStepFlag = Convert.ToUInt32(changeStep.Checked);

            DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MagoBox.Editors;
using MagoBox.Rendering;
using RDLLVL;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace MagoBox
{
    public partial class MainForm : Form
    {
        public Level level;
        public string filePath;

        List<int> texIds = new List<int>();
        List<int> modTexIds = new List<int>();
        List<int> objTexIds = new List<int>();
        Dictionary<short, int> blockTexIds = new Dictionary<short, int>();

        Renderer renderer;
        Texturing texturing;
        Camera camera;

        private System.Timers.Timer t;

        bool moveCam = false;
        int mouseX = 0;
        int mouseY = 0;

        int moveObj;

        int tool;

        uint tileX;
        uint tileY;

        public MainForm()
        {
            InitializeComponent();
        }

        public void RefreshObjectLists()
        {
            Objects objs = new Objects();
            int selIndex = 0;

            if (tabControl1.SelectedTab == objTab) selIndex = objList.SelectedIndex;
            if (tabControl1.SelectedTab == specItemTab) selIndex = specItemList.SelectedIndex;
            if (tabControl1.SelectedTab == itemTab) selIndex = itemList.SelectedIndex;
            if (tabControl1.SelectedTab == bossTab) selIndex = bossList.SelectedIndex;
            if (tabControl1.SelectedTab == enemyTab) selIndex = enemyList.SelectedIndex;

            objList.Items.Clear();
            specItemList.Items.Clear();
            itemList.Items.Clear();
            bossList.Items.Clear();
            enemyList.Items.Clear();

            objList.BeginUpdate();
            specItemList.BeginUpdate();
            itemList.BeginUpdate();
            bossList.BeginUpdate();
            enemyList.BeginUpdate();

            for (int i = 0; i < level.Objects.Count; i++)
            {
                if (objs.ObjectList.ContainsKey(level.Objects[i].Type))
                {
                    objList.Items.Add(objs.ObjectList[level.Objects[i].Type]);
                }
                else
                {
                    objList.Items.Add($"Unknown ({level.Objects[i].Type})");
                }
            }
            for (int i = 0; i < level.SpecialItems.Count; i++)
            {
                if (objs.SpecialItemList.ContainsKey(level.SpecialItems[i].Type))
                {
                    specItemList.Items.Add(objs.SpecialItemList[level.SpecialItems[i].Type]);
                }
                else
                {
                    specItemList.Items.Add($"Unknown ({level.SpecialItems[i].Type})");
                }
            }
            for (int i = 0; i < level.Items.Count; i++)
            {
                if (objs.ItemList.ContainsKey(level.Items[i].Type))
                {
                    itemList.Items.Add(objs.ItemList[level.Items[i].Type]);
                }
                else
                {
                    itemList.Items.Add($"Unknown ({level.Items[i].Type})");
                }
            }
            for (int i = 0; i < level.Bosses.Count; i++)
            {
                if (objs.BossList.ContainsKey(level.Bosses[i].Type))
                {
                    bossList.Items.Add(objs.BossList[level.Bosses[i].Type]);
                }
                else
                {
                    bossList.Items.Add($"Unknown ({level.Bosses[i].Type})");
                }
            }
            for (int i = 0; i < level.Enemies.Count; i++)
            {
                if (objs.EnemyList.ContainsKey(level.Enemies[i].Type))
                {
                    enemyList.Items.Add(objs.EnemyList[level.Enemies[i].Type]);
                }
                else
                {
                    enemyList.Items.Add($"Unknown ({level.Enemies[i].Type})");
                }
            }

            if (tabControl1.SelectedTab == objTab && objList.Items.Count >= selIndex + 1) objList.SelectedIndex = selIndex;
            if (tabControl1.SelectedTab == specItemTab && specItemList.Items.Count >= selIndex + 1) specItemList.SelectedIndex = selIndex;
            if (tabControl1.SelectedTab == itemTab && itemList.Items.Count >= selIndex + 1) itemList.SelectedIndex = selIndex;
            if (tabControl1.SelectedTab == bossTab && bossList.Items.Count >= selIndex + 1) bossList.SelectedIndex = selIndex;
            if (tabControl1.SelectedTab == enemyTab && enemyList.Items.Count >= selIndex + 1) enemyList.SelectedIndex = selIndex;

            objList.EndUpdate();
            specItemList.EndUpdate();
            itemList.EndUpdate();
            bossList.EndUpdate();
            enemyList.EndUpdate();
        }

        public void Save()
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            this.Text = $"MagoBox - Saving {filePath}...";

            BigEndianBinaryWriter writer = new BigEndianBinaryWriter(new FileStream(filePath, FileMode.Create));
            level.Write(writer);

            this.Enabled = true;
            this.Text = $"MagoBox - {filePath}";
            this.Cursor = Cursors.Arrow;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLevel newlvl = new NewLevel();
            if (newlvl.ShowDialog() == DialogResult.OK)
            {
                a = true;

                objList.Items.Clear();
                specItemList.Items.Clear();
                itemList.Items.Clear();
                bossList.Items.Clear();
                enemyList.Items.Clear();

                level = newlvl.level;

                camera.pos = Vector2.Zero;
                camera.zoom = 1.1;
                RefreshObjectLists();

                sizeH.Value = level.Height;
                sizeW.Value = level.Width;

                this.Text = $"MagoBox - New Level";

                saveAsToolStripMenuItem.Enabled = true;

                a = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Kirby's Return to Dream Land Level Files|*.dat";
            open.DefaultExt = ".dat";
            open.CheckFileExists = true;
            open.Title = "Open Level File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                a = true;

                filePath = open.FileName;
                objList.Items.Clear();
                specItemList.Items.Clear();
                itemList.Items.Clear();
                bossList.Items.Clear();
                enemyList.Items.Clear();

                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                this.Text = $"MagoBox - Opening {filePath}...";

                level = new Level(open.FileName);
                
                camera.pos = Vector2.Zero;
                camera.zoom = 1.1;
                RefreshObjectLists();

                sizeH.Value = level.Height;
                sizeW.Value = level.Width;

                this.Text = $"MagoBox - {filePath}";
                this.Cursor = Cursors.Arrow;
                this.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;

                a = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Kirby's Return to Dream Land Level Files|*.dat";
            save.DefaultExt = ".dat";
            save.Title = "Save Level File";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
                Save();
            }
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            glControl.MakeCurrent();
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            renderer = new Renderer();
            texturing = new Texturing();
            camera = new Camera(new Vector2(0, 0), 1.1);

            for (int i = 0; i < 52; i++)
            {
                texIds.Add(texturing.LoadTexture("Resources/tiles/" + i + ".png"));
            }
            texIds.Add(texturing.LoadTexture("Resources/tiles/select.png"));

            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/ladder.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/boundary.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/water.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/spike.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/ice.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/lava.png"));

            blockTexIds.Add(0xFF, texturing.LoadTexture("Resources/blocks/unknown.png"));
            blockTexIds.Add(0, texturing.LoadTexture("Resources/blocks/star.png"));
            blockTexIds.Add(1, texturing.LoadTexture("Resources/blocks/super.png"));
            blockTexIds.Add(2, texturing.LoadTexture("Resources/blocks/stone2x2.png"));
            blockTexIds.Add(3, texturing.LoadTexture("Resources/blocks/super_top2x2.png"));
            blockTexIds.Add(4, texturing.LoadTexture("Resources/blocks/stone.png"));
            blockTexIds.Add(5, texturing.LoadTexture("Resources/blocks/stone3x3.png"));
            blockTexIds.Add(6, texturing.LoadTexture("Resources/blocks/super.png"));
            blockTexIds.Add(7, texturing.LoadTexture("Resources/blocks/super2x2.png"));
            blockTexIds.Add(18, texturing.LoadTexture("Resources/blocks/bomb.png"));
            blockTexIds.Add(19, texturing.LoadTexture("Resources/blocks/bomb_chain.png"));
            blockTexIds.Add(20, texturing.LoadTexture("Resources/blocks/bomb_chain_invisible.png"));
            blockTexIds.Add(30, texturing.LoadTexture("Resources/blocks/breakable.png"));
            blockTexIds.Add(32, texturing.LoadTexture("Resources/blocks/fire.png"));
            blockTexIds.Add(33, texturing.LoadTexture("Resources/blocks/falling.png"));
            blockTexIds.Add(36, texturing.LoadTexture("Resources/blocks/ice.png"));
            blockTexIds.Add(47, texturing.LoadTexture("Resources/blocks/metal_falling.png"));
            blockTexIds.Add(48, texturing.LoadTexture("Resources/blocks/super.png"));
            blockTexIds.Add(49, texturing.LoadTexture("Resources/blocks/super1x2.png"));
            blockTexIds.Add(50, texturing.LoadTexture("Resources/blocks/super2x2.png"));
            blockTexIds.Add(52, texturing.LoadTexture("Resources/blocks/super4x2.png"));
            blockTexIds.Add(55, texturing.LoadTexture("Resources/blocks/super_top.png"));
            blockTexIds.Add(56, texturing.LoadTexture("Resources/blocks/super_top2x2.png"));
            blockTexIds.Add(57, texturing.LoadTexture("Resources/blocks/super4x4.png"));
            blockTexIds.Add(58, texturing.LoadTexture("Resources/blocks/super3x3.png"));

            objTexIds.Add(texturing.LoadTexture("Resources/obj/object.png"));
            objTexIds.Add(texturing.LoadTexture("Resources/obj/specialItem.png"));
            objTexIds.Add(texturing.LoadTexture("Resources/obj/item.png"));
            objTexIds.Add(texturing.LoadTexture("Resources/obj/boss.png"));
            objTexIds.Add(texturing.LoadTexture("Resources/obj/enemy.png"));
            objTexIds.Add(texturing.LoadTexture("Resources/obj/select.png"));

            t = new System.Timers.Timer(1000.0 / 60.0);
            t.Elapsed += t_Elapsed;
            t.Start();
        }

        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            glControl.Invalidate();
            t.Start();
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            renderer.Begin(glControl.Width, glControl.Height);
            camera.Transform();

            if (level != null)
            {
                //Crop Tiles outside camera view.
                int tileStartX = (int)Math.Max(0,Math.Floor(
                        (camera.pos.X - glControl.Width/camera.zoom*0.5f)/16.0f
                    ));
                int tileEndX = (int)Math.Min(level.Width, Math.Ceiling(
                        (camera.pos.X + glControl.Width / camera.zoom*0.5f) / 16.0f
                    ));
                int tileStartY = (int)Math.Max(0, 1+Math.Floor(
                        -(camera.pos.Y + glControl.Height / camera.zoom*0.5f) / 16.0f
                    ));
                int tileEndY = (int)Math.Min(level.Height,1+ Math.Ceiling(
                        -(camera.pos.Y - glControl.Height / camera.zoom*0.5f) / 16.0f
                    ));

                Vector2 vec_scale = new Vector2(1.0f, 1.0f);

                //Collisions
                for (int ty = tileStartY; ty < tileEndY; ty++)
                {
                    for (int tx = tileStartX; tx < tileEndX; tx++)
                    {
                        int ix = ty * (int)level.Width + tx;
                        Collision c = level.TileCollision[ix];
                        Vector2 v = new Vector2(tx * 16f, -ty * 16f);
                        
                        renderer.Draw(texIds[c.Shape], v, vec_scale, 17, 17);
                    }
                }

                //Blocks
                if (renderBlocksToolStripMenuItem.Checked)
                {
                    for (int ty = tileStartY; ty < tileEndY; ty++)
                    {
                        for (int tx = tileStartX; tx < tileEndX; tx++)
                        {
                            int ix = ty * (int)level.Width + tx;
                            Block b = level.TileBlock[ix];
                            Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                            if (b.ID != -1)
                            {
                                if (b.ID == 2 || b.ID == 3 || b.ID == 7 || b.ID == 50 || b.ID == 56) //2x2
                                {
                                    renderer.Draw(blockTexIds[b.ID], v - new Vector2(0, 16f), vec_scale, 33, 33);
                                }
                                else if (b.ID == 49) //1x2
                                {
                                    renderer.Draw(blockTexIds[b.ID], v - new Vector2(0, 16f), vec_scale, 17, 33);
                                }
                                else if (b.ID == 52) //4x2
                                {
                                    renderer.Draw(blockTexIds[b.ID], v - new Vector2(0, 16f), vec_scale, 65, 33);
                                }
                                else if (b.ID == 57) //4x4
                                {
                                    renderer.Draw(blockTexIds[b.ID], v - new Vector2(0, 48f), vec_scale, 65, 65);
                                }
                                else if (b.ID == 58) //3x3
                                {
                                    renderer.Draw(blockTexIds[b.ID], v - new Vector2(0, 32f), vec_scale, 49, 49);
                                }
                                else if (blockTexIds.ContainsKey(b.ID))
                                {
                                    renderer.Draw(blockTexIds[b.ID], v, vec_scale, 17, 17);
                                }
                                else //Unknown
                                {
                                    renderer.Draw(blockTexIds[0xFF], v, vec_scale, 17, 17);
                                }
                            }
                        }
                    }
                }

                //Modifiers
                if (renderTileModifiersToolStripMenuItem.Checked)
                {
                    for (int ty = tileStartY; ty < tileEndY; ty++)
                    {
                        for (int tx = tileStartX; tx < tileEndX; tx++)
                        {
                            int ix = ty * (int)level.Width + tx;
                            Collision c = level.TileCollision[ix];
                            Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                            if ((c.Modifier & (1 << 1)) != 0) //Ladder
                            {
                                renderer.Draw(modTexIds[0], v, vec_scale, 17, 17);
                            }
                            if ((c.Modifier & (1 << 2)) != 0) //Boundary
                            {
                                renderer.Draw(modTexIds[1], v, vec_scale, 17, 17);
                            }
                            if ((c.Modifier & (1 << 3)) != 0) //Water
                            {
                                renderer.Draw(modTexIds[2], v, vec_scale, 17, 17);
                            }
                            if ((c.Modifier & (1 << 4)) != 0) //Spike
                            {
                                renderer.Draw(modTexIds[3], v, vec_scale, 17, 17);
                            }
                            if ((c.Modifier & (1 << 5)) != 0) //Ice
                            {
                                renderer.Draw(modTexIds[4], v, vec_scale, 17, 17);
                            }
                            if ((c.Modifier & (1 << 6)) != 0) //Lava
                            {
                                renderer.Draw(modTexIds[5], v, vec_scale, 17, 17);
                            }
                        }
                    }
                }

                if (true)
                {
                    Vector2 v = new Vector2(tileX * 16f, -tileY * 16f);
                    renderer.Draw(texIds[52], v, vec_scale, 17, 17);
                }

                if (renderObjectPointsToolStripMenuItem.Checked)
                {
                    for (int i = 0; i < level.Objects.Count; i++)
                    {
                        try
                        {
                            renderer.Draw(objTexIds[0], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            if (i == objList.SelectedIndex)
                            {
                                renderer.Draw(objTexIds[5], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            }
                        }
                        catch { }
                    }
                }

                if (renderSpecialItemPointsToolStripMenuItem.Checked)
                {
                    for (int i = 0; i < level.SpecialItems.Count; i++)
                    {
                        try
                        {
                            renderer.Draw(objTexIds[1], new Vector2(((level.SpecialItems[i].X * 16f) - 3f) + (level.SpecialItems[i].XOffset * 0.95f), ((-level.SpecialItems[i].Y * 16f) + 13f) - (level.SpecialItems[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            if (i == specItemList.SelectedIndex)
                            {
                                renderer.Draw(objTexIds[5], new Vector2(((level.SpecialItems[i].X * 16f) - 3f) + (level.SpecialItems[i].XOffset * 0.95f), ((-level.SpecialItems[i].Y * 16f) + 13f) - (level.SpecialItems[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            }
                        }
                        catch { }
                    }
                }

                if (renderItemPointsToolStripMenuItem.Checked)
                {
                    for (int i = 0; i < level.Items.Count; i++)
                    {
                        try
                        {
                            renderer.Draw(objTexIds[2], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            if (i == itemList.SelectedIndex)
                            {
                                renderer.Draw(objTexIds[5], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            }
                        }
                        catch { }
                    }
                }

                if (renderBossPointsToolStripMenuItem.Checked)
                {
                    for (int i = 0; i < level.Bosses.Count; i++)
                    {
                        try
                        {
                            renderer.Draw(objTexIds[3], new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            if (i == bossList.SelectedIndex)
                            {
                                renderer.Draw(objTexIds[5], new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            }
                        }
                        catch { }
                    }
                }

                if (renderEnemyPointsToolStripMenuItem.Checked)
                {
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        try
                        {
                            renderer.Draw(objTexIds[4], new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            if (i == enemyList.SelectedIndex)
                            {
                                renderer.Draw(objTexIds[5], new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                            }
                        }
                        catch { }
                    }
                }
            }

            glControl.SwapBuffers();
        }
        
        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                moveCam = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tool == 0)
                {

                }
                else if (tool == 1)
                {

                }
                else if (tool == 2)
                {
                    Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
                    if (p.X > level.Width - 1)
                    {
                        tileX = level.Width - 1;
                    }
                    else if (p.X > 0)
                    {
                        tileX = (uint)p.X;
                    }
                    else { tileX = 0; }
                    if (p.Y < -(level.Height - 1))
                    {
                        tileY = level.Height - 1;
                    }
                    else if (p.Y < 0)
                    {
                        tileY = (uint)-p.Y + 1;
                    }
                    else { tileY = 0; }

                    int ix = (int)((tileY * level.Width) + tileX);

                    if (editCol.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Shape = (byte)vshape.Value;
                        c.Modifier = 0;
                        if (ladder.Checked) c.Modifier += 2;
                        if (boundary.Checked) c.Modifier += 4;
                        if (water.Checked) c.Modifier += 8;
                        if (spike.Checked) c.Modifier += 16;
                        if (ice.Checked) c.Modifier += 32;
                        if (lava.Checked) c.Modifier += 64;
                        c.Material = (byte)vmat.Value;
                        c.AutoMoveSpeed = (sbyte)vautomove.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editBlock.Checked)
                    {
                        Block b = level.TileBlock[ix];
                        b.ID = (short)vblock.Value;
                        level.TileBlock[ix] = b;
                    }
                    if (editDeco.Checked)
                    {
                        Decoration ml = level.MLandDecoration[ix];
                        Decoration bl = level.BLandDecoration[ix];
                        Decoration fl = level.FLandDecoration[ix];

                        bl.Unk_1 = (byte)d1_1.Value;
                        bl.Unk_2 = (byte)d1_2.Value;
                        bl.Unk_3 = (byte)d1_3.Value;
                        bl.MovingTerrainID = (sbyte)d1_4.Value;

                        ml.Unk_1 = (byte)d2_1.Value;
                        ml.Unk_2 = (byte)d2_2.Value;
                        ml.Unk_3 = (byte)d2_3.Value;
                        ml.MovingTerrainID = (sbyte)d2_4.Value;

                        fl.Unk_1 = (byte)d3_1.Value;
                        fl.Unk_2 = (byte)d3_2.Value;
                        fl.Unk_3 = (byte)d3_3.Value;
                        fl.MovingTerrainID = (sbyte)d3_4.Value;

                        level.MLandDecoration[ix] = bl;
                        level.BLandDecoration[ix] = ml;
                        level.FLandDecoration[ix] = fl;
                    }
                }
                else if (tool == 3)
                {
                    Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
                    if (p.X > level.Width - 1)
                    {
                        tileX = level.Width - 1;
                    }
                    else if (p.X > 0)
                    {
                        tileX = (uint)p.X;
                    }
                    else { tileX = 0; }
                    if (p.Y < -(level.Height - 1))
                    {
                        tileY = level.Height - 1;
                    }
                    else if (p.Y < 0)
                    {
                        tileY = (uint)-p.Y + 1;
                    }
                    else { tileY = 0; }

                    int ix = (int)((tileY * level.Width) + tileX);
                    Collision c = level.TileCollision[ix];
                    Block b = level.TileBlock[ix];
                    Decoration ml = level.MLandDecoration[ix];
                    Decoration bl = level.BLandDecoration[ix];
                    Decoration fl = level.FLandDecoration[ix];

                    vshape.Value = c.Shape;
                    if ((c.Modifier & (1 << 1)) != 0)
                    {
                        ladder.Checked = true;
                    }
                    else { ladder.Checked = false; }

                    if ((c.Modifier & (1 << 2)) != 0)
                    {
                        boundary.Checked = true;
                    }
                    else { boundary.Checked = false; }

                    if ((c.Modifier & (1 << 3)) != 0)
                    {
                        water.Checked = true;
                    }
                    else { water.Checked = false; }

                    if ((c.Modifier & (1 << 4)) != 0)
                    {
                        spike.Checked = true;
                    }
                    else { spike.Checked = false; }

                    if ((c.Modifier & (1 << 5)) != 0)
                    {
                        ice.Checked = true;
                    }
                    else { ice.Checked = false; }

                    if ((c.Modifier & (1 << 6)) != 0)
                    {
                        lava.Checked = true;
                    }
                    else { lava.Checked = false; }

                    vmat.Value = c.Material;
                    vautomove.Value = c.AutoMoveSpeed;

                    vblock.Value = b.ID;

                    d1_1.Value = bl.Unk_1;
                    d1_2.Value = bl.Unk_2;
                    d1_3.Value = bl.Unk_3;
                    d1_4.Value = bl.MovingTerrainID;

                    d2_1.Value = ml.Unk_1;
                    d2_2.Value = ml.Unk_2;
                    d2_3.Value = ml.Unk_3;
                    d2_4.Value = ml.MovingTerrainID;

                    d3_1.Value = fl.Unk_1;
                    d3_2.Value = fl.Unk_2;
                    d3_3.Value = fl.Unk_3;
                    d3_4.Value = fl.MovingTerrainID;
                }
            }
        }

        private void glControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
                if (p.X > level.Width - 1)
                {
                    tileX = level.Width - 1;
                }
                else if (p.X > 0)
                {
                    tileX = (uint)p.X;
                }
                else { tileX = 0; }
                if (p.Y < -(level.Height - 1))
                {
                    tileY = level.Height - 1;
                }
                else if (p.Y < 0)
                {
                    tileY = (uint)-p.Y + 1;
                }
                else { tileY = 0; }
            }

            if (e.Button == MouseButtons.Right)
            {
                float moveSpeed = 1.0f/(float)camera.zoom;
                camera.pos.X += (mouseX - e.X) * moveSpeed;
                camera.pos.Y += (mouseY - e.Y) * moveSpeed;
                mouseX = e.X;
                mouseY = e.Y;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tool == 2)
                {
                    int ix = (int)((tileY * level.Width) + tileX);

                    if (editCol.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Shape = (byte)vshape.Value;
                        c.Modifier = 0;
                        if (ladder.Checked) c.Modifier += 2;
                        if (boundary.Checked) c.Modifier += 4;
                        if (water.Checked) c.Modifier += 8;
                        if (spike.Checked) c.Modifier += 16;
                        if (ice.Checked) c.Modifier += 32;
                        if (lava.Checked) c.Modifier += 64;
                        c.Material = (byte)vmat.Value;
                        c.AutoMoveSpeed = (sbyte)vautomove.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editBlock.Checked)
                    {
                        Block b = level.TileBlock[ix];
                        b.ID = (short)vblock.Value;
                        level.TileBlock[ix] = b;
                    }
                    if (editDeco.Checked)
                    {
                        Decoration ml = level.MLandDecoration[ix];
                        Decoration bl = level.BLandDecoration[ix];
                        Decoration fl = level.FLandDecoration[ix];

                        bl.Unk_1 = (byte)d1_1.Value;
                        bl.Unk_2 = (byte)d1_2.Value;
                        bl.Unk_3 = (byte)d1_3.Value;
                        bl.MovingTerrainID = (sbyte)d1_4.Value;

                        ml.Unk_1 = (byte)d2_1.Value;
                        ml.Unk_2 = (byte)d2_2.Value;
                        ml.Unk_3 = (byte)d2_3.Value;
                        ml.MovingTerrainID = (sbyte)d2_4.Value;

                        fl.Unk_1 = (byte)d3_1.Value;
                        fl.Unk_2 = (byte)d3_2.Value;
                        fl.Unk_3 = (byte)d3_3.Value;
                        fl.MovingTerrainID = (sbyte)d3_4.Value;

                        level.MLandDecoration[ix] = bl;
                        level.BLandDecoration[ix] = ml;
                        level.FLandDecoration[ix] = fl;
                    }
                }
            }
        }

        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                moveCam = false;
                mouseX = 0;
                mouseY = 0;
            }
        }

        private void glControl_MouseLeave(object sender, EventArgs e)
        {
            moveCam = false;
            mouseX = 0;
            mouseY = 0;
        }

        private void glControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                camera.zoom += 0.1 * camera.zoom;
                if (camera.zoom > 4)
                {
                    camera.zoom = 4;
                }
            }
            else if (e.Delta < 0)
            {
                camera.zoom -= 0.1 * camera.zoom;
                if (camera.zoom < 0.25)
                {
                    camera.zoom = 0.25;
                }
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            tool = 0;
            select.Enabled = false;
            move.Enabled = true;
            draw.Enabled = true;
            pick.Enabled = true;
        }

        private void move_Click(object sender, EventArgs e)
        {
            tool = 1;
            select.Enabled = true;
            move.Enabled = false;
            draw.Enabled = true;
            pick.Enabled = true;
        }

        private void draw_Click(object sender, EventArgs e)
        {
            tool = 2;
            select.Enabled = true;
            move.Enabled = true;
            draw.Enabled = false;
            pick.Enabled = true;
        }

        private void pick_Click(object sender, EventArgs e)
        {
            tool = 3;
            select.Enabled = true;
            move.Enabled = true;
            draw.Enabled = true;
            pick.Enabled = false;
        }

        private void resetCamera_Click(object sender, EventArgs e)
        {
            camera.zoom = 1.1;
            //Move Camera into Level Bounds
            camera.pos.X = Math.Max(0, Math.Min(level.Width*15 , camera.pos.X));
            camera.pos.Y = Math.Max(-level.Height*15, Math.Min(0, camera.pos.Y));
        }

        private void UpdateLevelSize(object sender, EventArgs e)
        {
            if (!a)
            {
                Collision c = new Collision();
                Block b = new Block();
                Decoration d = new Decoration();
                b.ID = -1;
                d.Unk_1 = 255;
                d.Unk_2 = 255;
                d.Unk_3 = 0;
                d.MovingTerrainID = -1;

                if (sizeW.Value > level.Width)
                {
                    for (int h = 0; h < sizeH.Value; h++)
                    {
                        level.TileCollision.Insert(((h * (int)level.Width) + (int)level.Width) + h, c);
                        level.TileBlock.Insert(((h * (int)level.Width) + (int)level.Width) + h, b);
                        level.BLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                        level.MLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                        level.FLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                    }
                    level.Width = (uint)sizeW.Value;
                }
                else if (sizeW.Value < level.Width)
                {
                    for (int h = 0; h < sizeH.Value - 1; h++)
                    {
                        level.TileCollision.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.TileBlock.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.BLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.MLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.FLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                    }
                    level.Width = (uint)sizeW.Value;
                }
                else if (sizeH.Value > level.Height)
                {
                    for (int w = 0; w < level.Width; w++)
                    {
                        level.TileCollision.Add(c);
                        level.TileBlock.Add(b);
                        level.BLandDecoration.Add(d);
                        level.MLandDecoration.Add(d);
                        level.FLandDecoration.Add(d);
                    }
                    level.Height = (uint)sizeH.Value;
                }
                else if (sizeH.Value < level.Height)
                {
                    level.TileCollision.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.TileBlock.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.BLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.MLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.FLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.Height = (uint)sizeH.Value;
                }
            }
        }

        private Vector2 ConvertMouseCoords(Vector2 i)
        {
            i -= new Vector2(glControl.Width, glControl.Height) / 2f;
            i /= (float)camera.zoom;
            return (camera.pos + i)/16f;
        }

        bool a;

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 0;
                    xCoord.Value = level.Objects[objList.SelectedIndex].X;
                    xOffset.Value = level.Objects[objList.SelectedIndex].XOffset;
                    yCoord.Value = level.Objects[objList.SelectedIndex].Y;
                    yOffset.Value = level.Objects[objList.SelectedIndex].YOffset;
                } catch { }
                specItemList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
                a = false;
            }
        }

        private void specItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 1;
                    xCoord.Value = level.SpecialItems[specItemList.SelectedIndex].X;
                    xOffset.Value = level.SpecialItems[specItemList.SelectedIndex].XOffset;
                    yCoord.Value = level.SpecialItems[specItemList.SelectedIndex].Y;
                    yOffset.Value = level.SpecialItems[specItemList.SelectedIndex].YOffset;
                } catch { }
                objList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
                a = false;
            }
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 2;
                    xCoord.Value = level.Items[itemList.SelectedIndex].X;
                    xOffset.Value = level.Items[itemList.SelectedIndex].XOffset;
                    yCoord.Value = level.Items[itemList.SelectedIndex].Y;
                    yOffset.Value = level.Items[itemList.SelectedIndex].YOffset;
                } catch { }
                objList.ClearSelected();
                specItemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
                a = false;
            }
        }

        private void bossList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 3;
                    xCoord.Value = level.Bosses[bossList.SelectedIndex].X;
                    xOffset.Value = level.Bosses[bossList.SelectedIndex].XOffset;
                    yCoord.Value = level.Bosses[bossList.SelectedIndex].Y;
                    yOffset.Value = level.Bosses[bossList.SelectedIndex].YOffset;
                } catch { }
                objList.ClearSelected();
                specItemList.ClearSelected();
                itemList.ClearSelected();
                enemyList.ClearSelected();
                a = false;
            }
        }

        private void enemyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 4;
                    xCoord.Value = level.Enemies[enemyList.SelectedIndex].X;
                    xOffset.Value = level.Enemies[enemyList.SelectedIndex].XOffset;
                    yCoord.Value = level.Enemies[enemyList.SelectedIndex].Y;
                    yOffset.Value = level.Enemies[enemyList.SelectedIndex].YOffset;
                } catch { }
                objList.ClearSelected();
                specItemList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                a = false;
            }
        }

        void UpdateCoords()
        {
            switch (moveObj)
            {
                case 0:
                    {
                        RDLLVL.Object obj = level.Objects[objList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Objects[objList.SelectedIndex] = obj;
                        break;
                    }
                case 1:
                    {
                        RDLLVL.SpecialItem obj = level.SpecialItems[specItemList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.SpecialItems[specItemList.SelectedIndex] = obj;
                        break;
                    }
                case 2:
                    {
                        RDLLVL.Item obj = level.Items[itemList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Items[itemList.SelectedIndex] = obj;
                        break;
                    }
                case 3:
                    {
                        RDLLVL.Boss obj = level.Bosses[bossList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Bosses[bossList.SelectedIndex] = obj;
                        break;
                    }
                case 4:
                    {
                        RDLLVL.Enemy obj = level.Enemies[enemyList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Enemies[enemyList.SelectedIndex] = obj;
                        break;
                    }
            }
        }

        private void xCoord_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
            {
                UpdateCoords();
            }
        }

        private void xOffset_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
            {
                UpdateCoords();
            }
        }

        private void yCoord_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
            {
                UpdateCoords();
            }
        }

        private void yOffset_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
            {
                UpdateCoords();
            }
        }

        private void addObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Objects.Add(new RDLLVL.Object());
                RefreshObjectLists();
            }
        }

        private void addSpecItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.SpecialItems.Add(new SpecialItem());
                RefreshObjectLists();
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Items.Add(new Item());
                RefreshObjectLists();
            }
        }

        private void addBoss_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Bosses.Add(new Boss());
                RefreshObjectLists();
            }
        }

        private void addEnemy_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Enemies.Add(new Enemy());
                RefreshObjectLists();
            }
        }

        private void delObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Objects.RemoveAt(objList.SelectedIndex);
                RefreshObjectLists();
            }
        }

        private void delSpecItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.SpecialItems.RemoveAt(specItemList.SelectedIndex);
                RefreshObjectLists();
            }
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Items.RemoveAt(itemList.SelectedIndex);
                RefreshObjectLists();
            }
        }

        private void delBoss_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Bosses.RemoveAt(bossList.SelectedIndex);
                RefreshObjectLists();
            }
        }

        private void delEnemy_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Enemies.RemoveAt(enemyList.SelectedIndex);
                RefreshObjectLists();
            }
        }

        private void editObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                ObjectEditor editor = new ObjectEditor();
                editor.obj = level.Objects[objList.SelectedIndex];
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    level.Objects[objList.SelectedIndex] = editor.obj;
                    RefreshObjectLists();
                }
            }
        }

        private void editSpecItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                SpecialItemEditor editor = new SpecialItemEditor();
                editor.obj = level.SpecialItems[specItemList.SelectedIndex];
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    level.SpecialItems[specItemList.SelectedIndex] = editor.obj;
                    RefreshObjectLists();
                }
            }
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                ItemEditor editor = new ItemEditor();
                editor.obj = level.Items[itemList.SelectedIndex];
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    level.Items[itemList.SelectedIndex] = editor.obj;
                    RefreshObjectLists();
                }
            }
        }

        private void editBoss_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                BossEditor editor = new BossEditor();
                editor.obj = level.Bosses[bossList.SelectedIndex];
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    level.Bosses[bossList.SelectedIndex] = editor.obj;
                    RefreshObjectLists();
                }
            }
        }

        private void editEnemy_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                EnemyEditor editor = new EnemyEditor();
                editor.obj = level.Enemies[enemyList.SelectedIndex];
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    level.Enemies[enemyList.SelectedIndex] = editor.obj;
                    RefreshObjectLists();
                }
            }
        }

        private void cloneObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Objects.Add(level.Objects[objList.SelectedIndex]);
                RefreshObjectLists();
            }
        }

        private void cloneSpecItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.SpecialItems.Add(level.SpecialItems[specItemList.SelectedIndex]);
                RefreshObjectLists();
            }
        }

        private void cloneItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Items.Add(level.Items[itemList.SelectedIndex]);
                RefreshObjectLists();
            }
        }

        private void cloneBoss_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Bosses.Add(level.Bosses[bossList.SelectedIndex]);
                RefreshObjectLists();
            }
        }

        private void cloneEnemy_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                level.Enemies.Add(level.Enemies[enemyList.SelectedIndex]);
                RefreshObjectLists();
            }
        }

        private void objList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                if (objList.SelectedItem != null)
                {
                    editObj_Click(this, new EventArgs());
                }
            }
        }

        private void specItemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                if (specItemList.SelectedItem != null)
                {
                    editSpecItem_Click(this, new EventArgs());
                }
            }
        }

        private void itemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                if (itemList.SelectedItem != null)
                {
                    editItem_Click(this, new EventArgs());
                }
            }
        }

        private void bossList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                if (bossList.SelectedItem != null)
                {
                    editBoss_Click(this, new EventArgs());
                }
            }
        }

        private void enemyList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                if (enemyList.SelectedItem != null)
                {
                    editEnemy_Click(this, new EventArgs());
                }
            }
        }

        private void stageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                StageSettings settings = new StageSettings();
                settings.data = level.StageData;
                settings.background = level.Background;
                settings.tileset = level.Tileset;
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    level.StageData = settings.data;
                    level.Background = settings.background;
                    level.Tileset = settings.tileset;
                }
            }
        }
    }
}

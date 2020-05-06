
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace WindowsFormsApp1_geponAuto_20200415
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.portButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu2 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.extendedPanel1 = new Stepi.UI.ExtendedPanel();
            this.portFxCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.portComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.graphTestButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.testButton = new MetroFramework.Controls.MetroButton();
            this.autoPeriodTextBox = new MetroFramework.Controls.MetroTextBox();
            this.manulCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.portComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.portComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroContextMenu2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.extendedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(123, 54);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cartesianChart1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.cartesianChart1, true);
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(674, 145);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // portButton
            // 
            this.portButton.Location = new System.Drawing.Point(416, 9);
            this.portButton.Name = "portButton";
            this.portButton.Size = new System.Drawing.Size(63, 23);
            this.portButton.TabIndex = 1;
            this.portButton.Text = "Open";
            this.portButton.UseSelectable = true;
            this.portButton.Click += new System.EventHandler(this.portButton_Click);
            // 
            // metroContextMenu2
            // 
            this.metroContextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.toolStripSeparator1});
            this.metroContextMenu2.Name = "metroContextMenu2";
            this.metroContextMenu2.Size = new System.Drawing.Size(105, 54);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.test1ToolStripMenuItem.Text = "test1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.test2ToolStripMenuItem.Text = "test2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(101, 6);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile8.Location = new System.Drawing.Point(560, 5);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(51, 49);
            this.metroTile8.TabIndex = 3;
            this.metroTile8.TileImage = global::WindowsFormsApp1_geponAuto_20200415.Properties.Resources.appbar_smiley_squint;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.cartesianChart1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 85);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(674, 145);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // extendedPanel1
            // 
            this.extendedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extendedPanel1.BorderColor = System.Drawing.Color.Gray;
            this.extendedPanel1.CaptionAlign = Stepi.UI.DirectionStyle.Down;
            this.extendedPanel1.CaptionColorOne = System.Drawing.Color.White;
            this.extendedPanel1.CaptionColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.extendedPanel1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedPanel1.CaptionImage = ((System.Drawing.Icon)(resources.GetObject("extendedPanel1.CaptionImage")));
            this.extendedPanel1.CaptionSize = 43;
            this.extendedPanel1.CaptionText = "Top";
            this.extendedPanel1.CaptionTextColor = System.Drawing.Color.Black;
            this.extendedPanel1.Controls.Add(this.portFxCheckBox);
            this.extendedPanel1.Controls.Add(this.portComboBox3);
            this.extendedPanel1.Controls.Add(this.metroLabel2);
            this.extendedPanel1.Controls.Add(this.metroLabel1);
            this.extendedPanel1.Controls.Add(this.timerLabel);
            this.extendedPanel1.Controls.Add(this.graphTestButton);
            this.extendedPanel1.Controls.Add(this.clearButton);
            this.extendedPanel1.Controls.Add(this.testButton);
            this.extendedPanel1.Controls.Add(this.autoPeriodTextBox);
            this.extendedPanel1.Controls.Add(this.manulCheckBox);
            this.extendedPanel1.Controls.Add(this.portComboBox2);
            this.extendedPanel1.Controls.Add(this.portComboBox1);
            this.extendedPanel1.Controls.Add(this.portButton);
            this.extendedPanel1.CornerStyle = Stepi.UI.CornerStyle.Normal;
            this.extendedPanel1.DirectionCtrlColor = System.Drawing.Color.DarkGray;
            this.extendedPanel1.DirectionCtrlHoverColor = System.Drawing.Color.Orange;
            this.extendedPanel1.Location = new System.Drawing.Point(23, 247);
            this.extendedPanel1.Moveable = true;
            this.extendedPanel1.Name = "extendedPanel1";
            this.extendedPanel1.Size = new System.Drawing.Size(674, 151);
            this.extendedPanel1.TabIndex = 5;
            // 
            // portFxCheckBox
            // 
            this.portFxCheckBox.AutoSize = true;
            this.portFxCheckBox.Location = new System.Drawing.Point(130, 87);
            this.portFxCheckBox.Name = "portFxCheckBox";
            this.portFxCheckBox.Size = new System.Drawing.Size(34, 15);
            this.portFxCheckBox.TabIndex = 15;
            this.portFxCheckBox.Text = "Fx";
            this.portFxCheckBox.UseSelectable = true;
            // 
            // portComboBox3
            // 
            this.portComboBox3.FormattingEnabled = true;
            this.portComboBox3.ItemHeight = 23;
            this.portComboBox3.Location = new System.Drawing.Point(3, 73);
            this.portComboBox3.Name = "portComboBox3";
            this.portComboBox3.Size = new System.Drawing.Size(121, 29);
            this.portComboBox3.TabIndex = 12;
            this.portComboBox3.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(130, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(16, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "S";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(130, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(16, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "F";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(236, 48);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(57, 19);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "Timer: 0";
            // 
            // graphTestButton
            // 
            this.graphTestButton.Location = new System.Drawing.Point(554, 67);
            this.graphTestButton.Name = "graphTestButton";
            this.graphTestButton.Size = new System.Drawing.Size(63, 23);
            this.graphTestButton.TabIndex = 8;
            this.graphTestButton.Text = "Test";
            this.graphTestButton.UseSelectable = true;
            this.graphTestButton.Click += new System.EventHandler(this.graphTestButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(554, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(485, 9);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(63, 23);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "Start";
            this.testButton.UseSelectable = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // autoPeriodTextBox
            // 
            // 
            // 
            // 
            this.autoPeriodTextBox.CustomButton.Image = null;
            this.autoPeriodTextBox.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.autoPeriodTextBox.CustomButton.Name = "";
            this.autoPeriodTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.autoPeriodTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.autoPeriodTextBox.CustomButton.TabIndex = 1;
            this.autoPeriodTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.autoPeriodTextBox.CustomButton.UseSelectable = true;
            this.autoPeriodTextBox.CustomButton.Visible = false;
            this.autoPeriodTextBox.Lines = new string[] {
        "2"};
            this.autoPeriodTextBox.Location = new System.Drawing.Point(236, 9);
            this.autoPeriodTextBox.MaxLength = 32767;
            this.autoPeriodTextBox.Name = "autoPeriodTextBox";
            this.autoPeriodTextBox.PasswordChar = '\0';
            this.autoPeriodTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.autoPeriodTextBox.SelectedText = "";
            this.autoPeriodTextBox.SelectionLength = 0;
            this.autoPeriodTextBox.SelectionStart = 0;
            this.autoPeriodTextBox.ShortcutsEnabled = true;
            this.autoPeriodTextBox.Size = new System.Drawing.Size(79, 23);
            this.autoPeriodTextBox.TabIndex = 5;
            this.autoPeriodTextBox.Text = "2";
            this.autoPeriodTextBox.UseSelectable = true;
            this.autoPeriodTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.autoPeriodTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // manulCheckBox
            // 
            this.manulCheckBox.AutoSize = true;
            this.manulCheckBox.Checked = true;
            this.manulCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manulCheckBox.Location = new System.Drawing.Point(321, 17);
            this.manulCheckBox.Name = "manulCheckBox";
            this.manulCheckBox.Size = new System.Drawing.Size(50, 15);
            this.manulCheckBox.TabIndex = 4;
            this.manulCheckBox.Text = "auto ";
            this.manulCheckBox.UseSelectable = true;
            // 
            // portComboBox2
            // 
            this.portComboBox2.FormattingEnabled = true;
            this.portComboBox2.ItemHeight = 23;
            this.portComboBox2.Location = new System.Drawing.Point(3, 3);
            this.portComboBox2.Name = "portComboBox2";
            this.portComboBox2.Size = new System.Drawing.Size(121, 29);
            this.portComboBox2.TabIndex = 3;
            this.portComboBox2.UseSelectable = true;
            // 
            // portComboBox1
            // 
            this.portComboBox1.FormattingEnabled = true;
            this.portComboBox1.ItemHeight = 23;
            this.portComboBox1.Location = new System.Drawing.Point(3, 38);
            this.portComboBox1.Name = "portComboBox1";
            this.portComboBox1.Size = new System.Drawing.Size(121, 29);
            this.portComboBox1.TabIndex = 2;
            this.portComboBox1.UseSelectable = true;
            // 
            // timerDraw
            // 
            this.timerDraw.Interval = 200;
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // Form1
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(300, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.Controls.Add(this.extendedPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile8);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StyleManager = this.metroStyleManager;
            this.Text = "hello";
            this.Load += new System.EventHandler(this.Labels_Load);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroContextMenu2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.extendedPanel1.ResumeLayout(false);
            this.extendedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroContextMenu metroContextMenu2;
        private ToolStripMenuItem test1ToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private MetroTile metroTile8;
        private MetroPanel metroPanel1;
        private Stepi.UI.ExtendedPanel extendedPanel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MetroButton portButton;
        private MetroComboBox portComboBox2;
        private MetroComboBox portComboBox1;
        private MetroTextBox autoPeriodTextBox;
        private MetroCheckBox manulCheckBox;
        private MetroButton clearButton;
        private MetroButton testButton;
        private MetroButton graphTestButton;
        private Timer timerDraw;
        private MetroLabel timerLabel;
        private MetroLabel metroLabel2;
        private MetroLabel metroLabel1;
        private MetroCheckBox portFxCheckBox;
        private MetroComboBox portComboBox3;
        // private MetroFramework.Controls.MetroDropDownButton metroDropDownButton1;
    }
}


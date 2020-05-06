using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;


namespace WindowsFormsApp1_geponAuto_20200415
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }



        /// <summary>
        /// slaver's changes trans to master
        /// </summary>
        public Action<MetroThemeStyle> ChangeTheme;
        public Action<MetroColorStyle> ChangeStyle;


        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;


            slaverToMasterTheme();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;

            slaverToMasterStyle();
        }

        private void slaverToMasterTheme()
        {
            ChangeTheme?.Invoke(metroStyleManager.Theme);
        }

        private void slaverToMasterStyle()
        {
            ChangeStyle?.Invoke(metroStyleManager.Style);
        }



        /// <summary>
        /// Class TransEventArg, master's changes trans to slaver 
        /// </summary>
        /// <param name="theme"></param> 
        /// <param name="style"></param>
        public void SetTrans(MetroThemeStyle theme)
        {
            this.metroStyleManager.Theme = theme;
        }

        public void AfterParentFrmThemeChange(object sender, EventArgs e)
        {
            //get master's theme
            TransEventArg arg = e as TransEventArg;
            this.SetTrans(arg.Theme);
        }

        internal void MainFormThemeChaned(object sender, EventArgs e)
        {
            //get master's theme
            TransEventArg arg = e as TransEventArg;
            this.SetTrans(arg.Theme);

        }

        public void SetTrans1(MetroColorStyle style)
        {
            metroStyleManager.Style = style;
        }

        public void AfterParentFrmStyleChange(object sender, EventArgs e)
        {
            TransEventArg arg1 = e as TransEventArg;
            this.SetTrans1(arg1.Style);
        }

        internal void MainFormStyleChaned(object sender, EventArgs e)
        {
            TransEventArg arg1 = e as TransEventArg;
            this.SetTrans1(arg1.Style);

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 10);
            metroTile8.TileImage = this.imageList1.Images[next];

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharpminor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMin_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {
           // bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(format: DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(format: DataFormats.FileDrop);
            foreach (string item in files)
            {
                FileInfo fi = new FileInfo(item);
                TagLib.File f TagLib.File.Create(fi.FullName);
                var r = picPlayer.Rows.Add(new object[]
                {
                    null,
                    fi.Name,
                    Math.Round(f.Properties.Duration.Totalminutes,2)+" Mins",
                    f.Tag.JoiedGenres,
                    f.Tag.JoinedAlbumArtist

                });

                picPlayer.Rows[r].Tag = fi;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

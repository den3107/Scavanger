using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavanger
{
    public partial class ChooseWorldForm : Form
    {
        public String SelectedWorld { get; private set; }

        public ChooseWorldForm()
        {
            InitializeComponent();

            SelectedWorld = "";

            String[] fileNames = AssetLocation.GetFileNames(Directory.GetFiles(AssetLocation.World, "*.world"));
            worldsListBox.Items.Clear();
            foreach (String file in fileNames)
            {
                worldsListBox.Items.Add(file);
            }
        }

        private void worldsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(worldsListBox.SelectedItem != null)
            {
                SelectedWorld = (String) worldsListBox.SelectedItem;
                selectButton.Enabled = true;
            }
            else
            {
                SelectedWorld = "";
                selectButton.Enabled = false;
            }
        }
    }
}

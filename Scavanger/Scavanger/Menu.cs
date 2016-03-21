using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavanger
{
    public partial class Menu : Form
    {
        private String worldName;

        public Menu()
        {
            InitializeComponent();

            worldName = "";
        }

        private void chooseMapButton_Click(object sender, EventArgs e)
        {
            ChooseWorld();
        }

        private void loadMapButton_Click(object sender, EventArgs e)
        {
            loadedMapLabel.Text = "Not yet implemented";
            loadedMapLabel.Visible = true;
            startButton.Visible = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ChooseWorld()
        {
            using (ChooseWorldForm dialog = new ChooseWorldForm())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    worldName = dialog.SelectedWorld;
                    loadedMapLabel.Visible = true;
                    startButton.Visible = true;
                    loadedMapLabel.Text = "Map: " + worldName.Remove(worldName.Length-6,6);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (GameForm dialog = new GameForm(this))
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                }
            }
            Visible = true;
        }
    }
}

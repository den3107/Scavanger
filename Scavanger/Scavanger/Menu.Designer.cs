namespace Scavanger
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.Label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.chooseMapButton = new System.Windows.Forms.Button();
            this.loadMapButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.loadedMapLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Papyrus", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(982, 205);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Scavenger";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.DimGray;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(732, 622);
            this.quitButton.Margin = new System.Windows.Forms.Padding(15);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(250, 75);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // chooseMapButton
            // 
            this.chooseMapButton.BackColor = System.Drawing.Color.DimGray;
            this.chooseMapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chooseMapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.chooseMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseMapButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMapButton.ForeColor = System.Drawing.Color.White;
            this.chooseMapButton.Location = new System.Drawing.Point(387, 622);
            this.chooseMapButton.Margin = new System.Windows.Forms.Padding(15);
            this.chooseMapButton.Name = "chooseMapButton";
            this.chooseMapButton.Size = new System.Drawing.Size(250, 75);
            this.chooseMapButton.TabIndex = 2;
            this.chooseMapButton.Text = "Choose map";
            this.chooseMapButton.UseVisualStyleBackColor = false;
            this.chooseMapButton.Click += new System.EventHandler(this.chooseMapButton_Click);
            // 
            // loadMapButton
            // 
            this.loadMapButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadMapButton.BackColor = System.Drawing.Color.DimGray;
            this.loadMapButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadMapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.loadMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMapButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMapButton.ForeColor = System.Drawing.Color.White;
            this.loadMapButton.Location = new System.Drawing.Point(24, 622);
            this.loadMapButton.Margin = new System.Windows.Forms.Padding(15);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(250, 75);
            this.loadMapButton.TabIndex = 3;
            this.loadMapButton.Text = "Load map";
            this.loadMapButton.UseVisualStyleBackColor = false;
            this.loadMapButton.Click += new System.EventHandler(this.loadMapButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DimGray;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(387, 425);
            this.startButton.Margin = new System.Windows.Forms.Padding(15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 75);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadedMapLabel
            // 
            this.loadedMapLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedMapLabel.ForeColor = System.Drawing.Color.White;
            this.loadedMapLabel.Location = new System.Drawing.Point(17, 319);
            this.loadedMapLabel.Name = "loadedMapLabel";
            this.loadedMapLabel.Size = new System.Drawing.Size(982, 91);
            this.loadedMapLabel.TabIndex = 5;
            this.loadedMapLabel.Text = "Map: ";
            this.loadedMapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadedMapLabel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.loadedMapLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.loadMapButton);
            this.Controls.Add(this.chooseMapButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Scavenger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button chooseMapButton;
        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label loadedMapLabel;
    }
}


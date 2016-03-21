namespace Scavanger
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.entitiesPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.turnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.returnToMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // entitiesPictureBox
            // 
            this.entitiesPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.entitiesPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.entitiesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.entitiesPictureBox.Location = new System.Drawing.Point(0, 0);
            this.entitiesPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.entitiesPictureBox.Name = "entitiesPictureBox";
            this.entitiesPictureBox.Size = new System.Drawing.Size(704, 704);
            this.entitiesPictureBox.TabIndex = 1;
            this.entitiesPictureBox.TabStop = false;
            this.entitiesPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.entitiesPictureBox_Paint);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackColor = System.Drawing.Color.Black;
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(704, 704);
            this.backgroundPictureBox.TabIndex = 0;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPictureBox_Paint);
            // 
            // turnLabel
            // 
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.ForeColor = System.Drawing.Color.White;
            this.turnLabel.Location = new System.Drawing.Point(719, 19);
            this.turnLabel.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(393, 58);
            this.turnLabel.TabIndex = 2;
            this.turnLabel.Text = "Loading...";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(719, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(857, 97);
            this.healthLabel.Margin = new System.Windows.Forms.Padding(0, 10, 15, 10);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(91, 36);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "??/??";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.ForeColor = System.Drawing.Color.White;
            this.foodLabel.Location = new System.Drawing.Point(857, 153);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(0, 10, 15, 10);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(91, 36);
            this.foodLabel.TabIndex = 6;
            this.foodLabel.Text = "??/??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(719, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Food:";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.ForeColor = System.Drawing.Color.White;
            this.strengthLabel.Location = new System.Drawing.Point(857, 209);
            this.strengthLabel.Margin = new System.Windows.Forms.Padding(0, 10, 15, 10);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(49, 36);
            this.strengthLabel.TabIndex = 8;
            this.strengthLabel.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(721, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Strength:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(857, 265);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(0, 10, 15, 10);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(49, 36);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "??";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(719, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Speed:";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeLabel.ForeColor = System.Drawing.Color.White;
            this.rangeLabel.Location = new System.Drawing.Point(857, 321);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(0, 10, 15, 10);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(49, 36);
            this.rangeLabel.TabIndex = 12;
            this.rangeLabel.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(721, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "Range:";
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 50;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // returnToMenuButton
            // 
            this.returnToMenuButton.BackColor = System.Drawing.Color.DimGray;
            this.returnToMenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnToMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnToMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.returnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMenuButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMenuButton.ForeColor = System.Drawing.Color.White;
            this.returnToMenuButton.Location = new System.Drawing.Point(804, 605);
            this.returnToMenuButton.Margin = new System.Windows.Forms.Padding(15);
            this.returnToMenuButton.Name = "returnToMenuButton";
            this.returnToMenuButton.Size = new System.Drawing.Size(250, 75);
            this.returnToMenuButton.TabIndex = 14;
            this.returnToMenuButton.Text = "Return to menu";
            this.returnToMenuButton.UseVisualStyleBackColor = false;
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CancelButton = this.returnToMenuButton;
            this.ClientSize = new System.Drawing.Size(1136, 704);
            this.ControlBox = false;
            this.Controls.Add(this.returnToMenuButton);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.entitiesPictureBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = " ";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.entitiesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.PictureBox entitiesPictureBox;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Button returnToMenuButton;
    }
}
namespace Scavanger
{
    partial class ChooseWorldForm
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
            this.worldsListBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // worldsListBox
            // 
            this.worldsListBox.FormattingEnabled = true;
            this.worldsListBox.ItemHeight = 16;
            this.worldsListBox.Items.AddRange(new object[] {
            "Loading worlds..."});
            this.worldsListBox.Location = new System.Drawing.Point(0, 0);
            this.worldsListBox.Name = "worldsListBox";
            this.worldsListBox.ScrollAlwaysVisible = true;
            this.worldsListBox.Size = new System.Drawing.Size(200, 404);
            this.worldsListBox.TabIndex = 1;
            this.worldsListBox.SelectedIndexChanged += new System.EventHandler(this.worldsListBox_SelectedIndexChanged);
            // 
            // selectButton
            // 
            this.selectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.selectButton.Enabled = false;
            this.selectButton.Location = new System.Drawing.Point(0, 403);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(100, 50);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(100, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ChooseWorldForm
            // 
            this.AcceptButton = this.selectButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(200, 453);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.worldsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseWorldForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Choose world";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox worldsListBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
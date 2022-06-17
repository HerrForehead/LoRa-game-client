
namespace game_voor_challenge
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gameDestroyer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gameDestroyer
            // 
            this.gameDestroyer.AutoSize = true;
            this.gameDestroyer.Checked = true;
            this.gameDestroyer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gameDestroyer.Location = new System.Drawing.Point(12, 10);
            this.gameDestroyer.Name = "gameDestroyer";
            this.gameDestroyer.Size = new System.Drawing.Size(670, 21);
            this.gameDestroyer.TabIndex = 0;
            this.gameDestroyer.Text = "The game is currently running but you actually don\'t want it to be so just unchec" +
    "k this checkbox okay?";
            this.gameDestroyer.UseVisualStyleBackColor = true;
            this.gameDestroyer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 43);
            this.Controls.Add(this.gameDestroyer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox gameDestroyer;
    }
}
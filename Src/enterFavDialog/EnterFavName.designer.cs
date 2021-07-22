
namespace Typing_Practice
{
    partial class EnterFavName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterFavName));
            this.EnterFavTxtBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterFavTxtBox
            // 
            this.EnterFavTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFavTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EnterFavTxtBox.Location = new System.Drawing.Point(22, 21);
            this.EnterFavTxtBox.Name = "EnterFavTxtBox";
            this.EnterFavTxtBox.Size = new System.Drawing.Size(162, 27);
            this.EnterFavTxtBox.TabIndex = 0;
            this.EnterFavTxtBox.Text = "Enter fav name";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.GreenYellow;
            this.ok.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ok.Location = new System.Drawing.Point(62, 64);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(78, 47);
            this.ok.TabIndex = 1;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // EnterFavName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(212, 133);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.EnterFavTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterFavName";
            this.Text = "Enter_fav_name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterFavTxtBox;
        private System.Windows.Forms.Button ok;
    }
}
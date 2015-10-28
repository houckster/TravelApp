namespace Travel_Group_Project
{
    partial class Summary
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panMountains = new System.Windows.Forms.Panel();
            this.panCoastal = new System.Windows.Forms.Panel();
            this.panUrban = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panMountains.SuspendLayout();
            this.panCoastal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 207);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panMountains
            // 
            this.panMountains.Controls.Add(this.panCoastal);
            this.panMountains.Location = new System.Drawing.Point(21, 21);
            this.panMountains.Name = "panMountains";
            this.panMountains.Size = new System.Drawing.Size(200, 100);
            this.panMountains.TabIndex = 4;
            // 
            // panCoastal
            // 
            this.panCoastal.Controls.Add(this.panUrban);
            this.panCoastal.Location = new System.Drawing.Point(16, 18);
            this.panCoastal.Name = "panCoastal";
            this.panCoastal.Size = new System.Drawing.Size(200, 100);
            this.panCoastal.TabIndex = 0;
            // 
            // panUrban
            // 
            this.panUrban.Location = new System.Drawing.Point(23, 23);
            this.panUrban.Name = "panUrban";
            this.panUrban.Size = new System.Drawing.Size(200, 100);
            this.panUrban.TabIndex = 0;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panMountains);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Summary";
            this.Text = "Summary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panMountains.ResumeLayout(false);
            this.panCoastal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panMountains;
        private System.Windows.Forms.Panel panCoastal;
        private System.Windows.Forms.Panel panUrban;
    }
}
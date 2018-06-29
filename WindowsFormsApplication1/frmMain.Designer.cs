namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.btnCHU = new System.Windows.Forms.Button();
            this.btnClip = new System.Windows.Forms.Button();
            this.btnJoinName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCHU
            // 
            this.btnCHU.Location = new System.Drawing.Point(36, 46);
            this.btnCHU.Name = "btnCHU";
            this.btnCHU.Size = new System.Drawing.Size(75, 23);
            this.btnCHU.TabIndex = 0;
            this.btnCHU.Text = "除以10000";
            this.btnCHU.UseVisualStyleBackColor = true;
            this.btnCHU.Click += new System.EventHandler(this.btnCHU_Click);
            // 
            // btnClip
            // 
            this.btnClip.Location = new System.Drawing.Point(208, 46);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(75, 23);
            this.btnClip.TabIndex = 1;
            this.btnClip.Text = "裁剪";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // btnJoinName
            // 
            this.btnJoinName.Location = new System.Drawing.Point(378, 46);
            this.btnJoinName.Name = "btnJoinName";
            this.btnJoinName.Size = new System.Drawing.Size(118, 23);
            this.btnJoinName.TabIndex = 2;
            this.btnJoinName.Text = "生成影像txt列表";
            this.btnJoinName.UseVisualStyleBackColor = true;
            this.btnJoinName.Click += new System.EventHandler(this.btnJoinName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "批量改名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJoinName);
            this.Controls.Add(this.btnClip);
            this.Controls.Add(this.btnCHU);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCHU;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.Button btnJoinName;
        private System.Windows.Forms.Button button1;
    }
}
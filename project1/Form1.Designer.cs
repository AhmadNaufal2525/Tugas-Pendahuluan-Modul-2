namespace project1
{
    partial class Form1
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.Outputname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(360, 202);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 25);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(296, 164);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(208, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(345, 135);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(116, 13);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Masukkan Nama Anda";
            this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(262, 248);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(45, 13);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Output :";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // Outputname
            // 
            this.Outputname.AutoSize = true;
            this.Outputname.Location = new System.Drawing.Point(307, 248);
            this.Outputname.Name = "Outputname";
            this.Outputname.Size = new System.Drawing.Size(0, 13);
            this.Outputname.TabIndex = 8;
            this.Outputname.Click += new System.EventHandler(this.Outputname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Outputname);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.submitBtn);
            this.Name = "Form1";
            this.Text = "TP_MOD_2_KPL";
            this.Load += new System.EventHandler(this.TP_MOD_2_KPL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label Outputname;
    }
}


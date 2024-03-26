namespace TempConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fh = new System.Windows.Forms.TextBox();
            this.txt_cl = new System.Windows.Forms.TextBox();
            this.txt_kl = new System.Windows.Forms.TextBox();
            this.btb_fh = new System.Windows.Forms.Button();
            this.btn_cl = new System.Windows.Forms.Button();
            this.btn_kl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(109, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferhenheight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(109, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(109, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_fh
            // 
            this.txt_fh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fh.Location = new System.Drawing.Point(425, 72);
            this.txt_fh.Name = "txt_fh";
            this.txt_fh.Size = new System.Drawing.Size(189, 45);
            this.txt_fh.TabIndex = 3;
            // 
            // txt_cl
            // 
            this.txt_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cl.Location = new System.Drawing.Point(425, 179);
            this.txt_cl.Name = "txt_cl";
            this.txt_cl.Size = new System.Drawing.Size(189, 45);
            this.txt_cl.TabIndex = 4;
            // 
            // txt_kl
            // 
            this.txt_kl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kl.Location = new System.Drawing.Point(425, 286);
            this.txt_kl.Name = "txt_kl";
            this.txt_kl.Size = new System.Drawing.Size(189, 45);
            this.txt_kl.TabIndex = 5;
            // 
            // btb_fh
            // 
            this.btb_fh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_fh.Location = new System.Drawing.Point(660, 72);
            this.btb_fh.Name = "btb_fh";
            this.btb_fh.Size = new System.Drawing.Size(94, 46);
            this.btb_fh.TabIndex = 6;
            this.btb_fh.Text = "Convert";
            this.btb_fh.UseVisualStyleBackColor = true;
            this.btb_fh.Click += new System.EventHandler(this.btb_fh_Click);
            // 
            // btn_cl
            // 
            this.btn_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cl.Location = new System.Drawing.Point(660, 179);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(94, 45);
            this.btn_cl.TabIndex = 7;
            this.btn_cl.Text = "Convert";
            this.btn_cl.UseVisualStyleBackColor = true;
            this.btn_cl.Click += new System.EventHandler(this.btn_cl_Click);
            // 
            // btn_kl
            // 
            this.btn_kl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kl.Location = new System.Drawing.Point(660, 286);
            this.btn_kl.Name = "btn_kl";
            this.btn_kl.Size = new System.Drawing.Size(94, 44);
            this.btn_kl.TabIndex = 8;
            this.btn_kl.Text = "Convert";
            this.btn_kl.UseVisualStyleBackColor = true;
            this.btn_kl.Click += new System.EventHandler(this.btn_kl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 461);
            this.Controls.Add(this.btn_kl);
            this.Controls.Add(this.btn_cl);
            this.Controls.Add(this.btb_fh);
            this.Controls.Add(this.txt_kl);
            this.Controls.Add(this.txt_cl);
            this.Controls.Add(this.txt_fh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fh;
        private System.Windows.Forms.TextBox txt_cl;
        private System.Windows.Forms.TextBox txt_kl;
        private System.Windows.Forms.Button btb_fh;
        private System.Windows.Forms.Button btn_cl;
        private System.Windows.Forms.Button btn_kl;
    }
}


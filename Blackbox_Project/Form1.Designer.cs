namespace Blackbox_Project
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Logintxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.Teal;
            this.SearchBtn.Location = new System.Drawing.Point(307, 257);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(176, 37);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "SEARCH";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logintxtbox
            // 
            this.Logintxtbox.BackColor = System.Drawing.SystemColors.Control;
            this.Logintxtbox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logintxtbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Logintxtbox.Location = new System.Drawing.Point(288, 180);
            this.Logintxtbox.Multiline = true;
            this.Logintxtbox.Name = "Logintxtbox";
            this.Logintxtbox.Size = new System.Drawing.Size(207, 38);
            this.Logintxtbox.TabIndex = 3;
            this.Logintxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Logintxtbox.TextChanged += new System.EventHandler(this.Logintxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(270, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "LICENCE PLATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(321, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "eXtreme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(287, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 110);
            this.label2.TabIndex = 7;
            this.label2.Text = "!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 315);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 70);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 421);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logintxtbox);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Form1";
            this.Text = "TEAM !XTREME APPLICATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Logintxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


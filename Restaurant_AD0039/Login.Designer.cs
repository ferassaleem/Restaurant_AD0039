
namespace Restaurant_AD0039
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJuices = new System.Windows.Forms.Button();
            this.btnSeafood = new System.Windows.Forms.Button();
            this.btnAppetizers = new System.Windows.Forms.Button();
            this.btnSandwiches = new System.Windows.Forms.Button();
            this.btnFastfood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 76);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(10, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(56, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnJuices);
            this.panel2.Controls.Add(this.btnSeafood);
            this.panel2.Controls.Add(this.btnAppetizers);
            this.panel2.Controls.Add(this.btnSandwiches);
            this.panel2.Controls.Add(this.btnFastfood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 361);
            this.panel2.TabIndex = 1;
            // 
            // btnJuices
            // 
            this.btnJuices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJuices.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnJuices.Location = new System.Drawing.Point(29, 257);
            this.btnJuices.Name = "btnJuices";
            this.btnJuices.Size = new System.Drawing.Size(96, 36);
            this.btnJuices.TabIndex = 9;
            this.btnJuices.Text = "Juices";
            this.btnJuices.UseVisualStyleBackColor = false;
            this.btnJuices.Click += new System.EventHandler(this.btnJuices_Click);
            // 
            // btnSeafood
            // 
            this.btnSeafood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeafood.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeafood.Location = new System.Drawing.Point(29, 26);
            this.btnSeafood.Name = "btnSeafood";
            this.btnSeafood.Size = new System.Drawing.Size(96, 36);
            this.btnSeafood.TabIndex = 8;
            this.btnSeafood.Text = "Seafood";
            this.btnSeafood.UseVisualStyleBackColor = false;
            this.btnSeafood.Click += new System.EventHandler(this.btnSeafood_Click);
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAppetizers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAppetizers.Location = new System.Drawing.Point(29, 200);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(96, 36);
            this.btnAppetizers.TabIndex = 7;
            this.btnAppetizers.Text = "Appetizers";
            this.btnAppetizers.UseVisualStyleBackColor = false;
            this.btnAppetizers.Click += new System.EventHandler(this.btnAppetizers_Click);
            // 
            // btnSandwiches
            // 
            this.btnSandwiches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSandwiches.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSandwiches.Location = new System.Drawing.Point(29, 143);
            this.btnSandwiches.Name = "btnSandwiches";
            this.btnSandwiches.Size = new System.Drawing.Size(96, 36);
            this.btnSandwiches.TabIndex = 6;
            this.btnSandwiches.Text = "Sandwiches";
            this.btnSandwiches.UseVisualStyleBackColor = false;
            this.btnSandwiches.Click += new System.EventHandler(this.btnSandwiches_Click);
            // 
            // btnFastfood
            // 
            this.btnFastfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFastfood.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnFastfood.Location = new System.Drawing.Point(29, 83);
            this.btnFastfood.Name = "btnFastfood";
            this.btnFastfood.Size = new System.Drawing.Size(96, 36);
            this.btnFastfood.TabIndex = 5;
            this.btnFastfood.Text = "Fast food";
            this.btnFastfood.UseVisualStyleBackColor = false;
            this.btnFastfood.Click += new System.EventHandler(this.btnFastfood_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(149, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 361);
            this.panel3.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 437);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnJuices;
        private System.Windows.Forms.Button btnSeafood;
        private System.Windows.Forms.Button btnAppetizers;
        private System.Windows.Forms.Button btnSandwiches;
        private System.Windows.Forms.Button btnFastfood;
    }
}
﻿
namespace Restaurant_AD0039
{
    partial class frmfastfood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfastfood));
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.cmbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lbxSelection2 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.BackColor = System.Drawing.Color.Pink;
            this.btnClearSelection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSelection.Location = new System.Drawing.Point(214, 255);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(100, 60);
            this.btnClearSelection.TabIndex = 18;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = false;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click_1);
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.BackColor = System.Drawing.Color.Pink;
            this.btnProcessOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProcessOrder.Location = new System.Drawing.Point(101, 255);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(100, 60);
            this.btnProcessOrder.TabIndex = 17;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = false;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click_1);
            // 
            // cmbxQuantity
            // 
            this.cmbxQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.cmbxQuantity.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbxQuantity.FormattingEnabled = true;
            this.cmbxQuantity.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.cmbxQuantity.Location = new System.Drawing.Point(260, 111);
            this.cmbxQuantity.Name = "cmbxQuantity";
            this.cmbxQuantity.Size = new System.Drawing.Size(54, 29);
            this.cmbxQuantity.TabIndex = 16;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(260, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 23);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity ";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFood.Location = new System.Drawing.Point(124, 80);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(45, 23);
            this.lblFood.TabIndex = 14;
            this.lblFood.Text = "Food";
            // 
            // lbxSelection2
            // 
            this.lbxSelection2.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbxSelection2.FormattingEnabled = true;
            this.lbxSelection2.ItemHeight = 21;
            this.lbxSelection2.Location = new System.Drawing.Point(124, 111);
            this.lbxSelection2.Name = "lbxSelection2";
            this.lbxSelection2.Size = new System.Drawing.Size(108, 109);
            this.lbxSelection2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmfastfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(418, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.cmbxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lbxSelection2);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "frmfastfood";
            this.Text = "FastFood";
            this.Load += new System.EventHandler(this.frmfastfood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.ComboBox cmbxQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.ListBox lbxSelection2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
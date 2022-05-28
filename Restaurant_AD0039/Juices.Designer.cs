
namespace Restaurant_AD0039
{
    partial class frmJuices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuices));
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.cmbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblJuices = new System.Windows.Forms.Label();
            this.lbxSelection5 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.BackColor = System.Drawing.Color.MediumOrchid;
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
            this.btnProcessOrder.BackColor = System.Drawing.Color.MediumOrchid;
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
            // lblJuices
            // 
            this.lblJuices.AutoSize = true;
            this.lblJuices.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuices.Location = new System.Drawing.Point(124, 80);
            this.lblJuices.Name = "lblJuices";
            this.lblJuices.Size = new System.Drawing.Size(58, 23);
            this.lblJuices.TabIndex = 14;
            this.lblJuices.Text = "Juices";
            // 
            // lbxSelection5
            // 
            this.lbxSelection5.BackColor = System.Drawing.SystemColors.Window;
            this.lbxSelection5.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbxSelection5.FormattingEnabled = true;
            this.lbxSelection5.ItemHeight = 21;
            this.lbxSelection5.Location = new System.Drawing.Point(124, 111);
            this.lbxSelection5.Name = "lbxSelection5";
            this.lbxSelection5.Size = new System.Drawing.Size(107, 109);
            this.lbxSelection5.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmJuices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(418, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.cmbxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblJuices);
            this.Controls.Add(this.lbxSelection5);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "frmJuices";
            this.Text = "Juices";
            this.Load += new System.EventHandler(this.frmJuices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.ComboBox cmbxQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblJuices;
        private System.Windows.Forms.ListBox lbxSelection5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
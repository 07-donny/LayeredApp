namespace Sales_Donny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dGVEmployee = new System.Windows.Forms.DataGridView();
            this.dGVOrder = new System.Windows.Forms.DataGridView();
            this.OhiMark = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVEmployee
            // 
            this.dGVEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dGVEmployee.Location = new System.Drawing.Point(12, 25);
            this.dGVEmployee.Name = "dGVEmployee";
            this.dGVEmployee.Size = new System.Drawing.Size(404, 413);
            this.dGVEmployee.TabIndex = 0;
            this.dGVEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_CellContentClick);
            this.dGVEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_CellContentClick);
            // 
            // dGVOrder
            // 
            this.dGVOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrder.Location = new System.Drawing.Point(422, 25);
            this.dGVOrder.Name = "dGVOrder";
            this.dGVOrder.Size = new System.Drawing.Size(482, 413);
            this.dGVOrder.TabIndex = 1;
            // 
            // OhiMark
            // 
            this.OhiMark.AutoSize = true;
            this.OhiMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OhiMark.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OhiMark.Location = new System.Drawing.Point(12, 0);
            this.OhiMark.Name = "OhiMark";
            this.OhiMark.Size = new System.Drawing.Size(98, 22);
            this.OhiMark.TabIndex = 2;
            this.OhiMark.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(839, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OhiMark);
            this.Controls.Add(this.dGVOrder);
            this.Controls.Add(this.dGVEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sales door Donny Meijer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVEmployee;
        private System.Windows.Forms.DataGridView dGVOrder;
        private System.Windows.Forms.Label OhiMark;
        private System.Windows.Forms.Label label2;
    }
}


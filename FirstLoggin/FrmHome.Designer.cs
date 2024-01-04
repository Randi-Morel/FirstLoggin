namespace FirstLoggin
{
    partial class FrmHome
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddHome = new System.Windows.Forms.Button();
            this.btnEditHome = new System.Windows.Forms.Button();
            this.btnDeleteHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(753, 321);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(663, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 33);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddHome
            // 
            this.btnAddHome.Location = new System.Drawing.Point(24, 78);
            this.btnAddHome.Name = "btnAddHome";
            this.btnAddHome.Size = new System.Drawing.Size(102, 33);
            this.btnAddHome.TabIndex = 3;
            this.btnAddHome.Text = "Add";
            this.btnAddHome.UseVisualStyleBackColor = true;
            this.btnAddHome.Click += new System.EventHandler(this.btnAddHome_Click);
            // 
            // btnEditHome
            // 
            this.btnEditHome.Location = new System.Drawing.Point(142, 78);
            this.btnEditHome.Name = "btnEditHome";
            this.btnEditHome.Size = new System.Drawing.Size(102, 33);
            this.btnEditHome.TabIndex = 4;
            this.btnEditHome.Text = "Edit";
            this.btnEditHome.UseVisualStyleBackColor = true;
            this.btnEditHome.Click += new System.EventHandler(this.btnEditHome_Click);
            // 
            // btnDeleteHome
            // 
            this.btnDeleteHome.Location = new System.Drawing.Point(263, 78);
            this.btnDeleteHome.Name = "btnDeleteHome";
            this.btnDeleteHome.Size = new System.Drawing.Size(102, 33);
            this.btnDeleteHome.TabIndex = 5;
            this.btnDeleteHome.Text = "Delete";
            this.btnDeleteHome.UseVisualStyleBackColor = true;
            this.btnDeleteHome.Click += new System.EventHandler(this.btnDeleteHome_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteHome);
            this.Controls.Add(this.btnEditHome);
            this.Controls.Add(this.btnAddHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddHome;
        private System.Windows.Forms.Button btnEditHome;
        private System.Windows.Forms.Button btnDeleteHome;
    }
}
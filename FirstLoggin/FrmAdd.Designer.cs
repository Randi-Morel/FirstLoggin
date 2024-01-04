namespace FirstLoggin
{
    partial class FrmAdd
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
            this.labelAddUserName = new System.Windows.Forms.Label();
            this.labelAddPassword = new System.Windows.Forms.Label();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddUserName
            // 
            this.labelAddUserName.AutoSize = true;
            this.labelAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddUserName.Location = new System.Drawing.Point(68, 87);
            this.labelAddUserName.Name = "labelAddUserName";
            this.labelAddUserName.Size = new System.Drawing.Size(70, 25);
            this.labelAddUserName.TabIndex = 0;
            this.labelAddUserName.Text = "Name:";
            // 
            // labelAddPassword
            // 
            this.labelAddPassword.AutoSize = true;
            this.labelAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPassword.Location = new System.Drawing.Point(68, 141);
            this.labelAddPassword.Name = "labelAddPassword";
            this.labelAddPassword.Size = new System.Drawing.Size(104, 25);
            this.labelAddPassword.TabIndex = 1;
            this.labelAddPassword.Text = "Password:";
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(220, 91);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(204, 22);
            this.txtAddUserName.TabIndex = 2;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(220, 144);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(204, 22);
            this.txtAddPassword.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 343);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddUserName);
            this.Controls.Add(this.labelAddPassword);
            this.Controls.Add(this.labelAddUserName);
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddUserName;
        private System.Windows.Forms.Label labelAddPassword;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Button btnAdd;
    }
}
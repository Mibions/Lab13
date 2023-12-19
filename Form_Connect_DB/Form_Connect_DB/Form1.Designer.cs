
namespace Form_Connect_DB
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
            this.tb_name_pc = new System.Windows.Forms.TextBox();
            this.lb_Name_PC = new System.Windows.Forms.Label();
            this.tb_name_db = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb_Name_DB = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name_pc
            // 
            this.tb_name_pc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name_pc.Location = new System.Drawing.Point(149, 56);
            this.tb_name_pc.Multiline = true;
            this.tb_name_pc.Name = "tb_name_pc";
            this.tb_name_pc.Size = new System.Drawing.Size(167, 37);
            this.tb_name_pc.TabIndex = 0;
            // 
            // lb_Name_PC
            // 
            this.lb_Name_PC.AutoSize = true;
            this.lb_Name_PC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name_PC.Location = new System.Drawing.Point(29, 71);
            this.lb_Name_PC.Name = "lb_Name_PC";
            this.lb_Name_PC.Size = new System.Drawing.Size(84, 22);
            this.lb_Name_PC.TabIndex = 1;
            this.lb_Name_PC.Text = "Tên Máy";
            // 
            // tb_name_db
            // 
            this.tb_name_db.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name_db.Location = new System.Drawing.Point(149, 102);
            this.tb_name_db.Multiline = true;
            this.tb_name_db.Name = "tb_name_db";
            this.tb_name_db.Size = new System.Drawing.Size(167, 37);
            this.tb_name_db.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(149, 188);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(167, 37);
            this.tb_pass.TabIndex = 0;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(149, 145);
            this.tb_user.Multiline = true;
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(167, 37);
            this.tb_user.TabIndex = 0;
            // 
            // lb_Name_DB
            // 
            this.lb_Name_DB.AutoSize = true;
            this.lb_Name_DB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name_DB.Location = new System.Drawing.Point(29, 117);
            this.lb_Name_DB.Name = "lb_Name_DB";
            this.lb_Name_DB.Size = new System.Drawing.Size(98, 22);
            this.lb_Name_DB.TabIndex = 1;
            this.lb_Name_DB.Text = "Tên CSDL";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(29, 160);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(48, 22);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "User";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(29, 203);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(90, 22);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Password";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(34, 270);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(79, 37);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(207, 270);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 37);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kết Nối Hệ Thống";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 358);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.lb_Name_DB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Name_PC);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name_db);
            this.Controls.Add(this.tb_name_pc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name_pc;
        private System.Windows.Forms.Label lb_Name_PC;
        private System.Windows.Forms.TextBox tb_name_db;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb_Name_DB;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


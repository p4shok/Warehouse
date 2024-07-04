namespace Warehouse
{
    partial class Label
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            Users = new Button();
            Storage = new Button();
            URLforGit = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(205, 78);
            label1.Name = "label1";
            label1.Size = new Size(391, 62);
            label1.TabIndex = 0;
            label1.Text = "Курсовая работа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(214, 166);
            label2.Name = "label2";
            label2.Size = new Size(381, 62);
            label2.TabIndex = 1;
            label2.Text = "Поршнев 22ВП1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(323, 248);
            label3.Name = "label3";
            label3.Size = new Size(154, 62);
            label3.TabIndex = 2;
            label3.Text = "Склад";
            // 
            // Users
            // 
            Users.Font = new Font("Segoe UI", 20F);
            Users.Location = new Point(243, 439);
            Users.Name = "Users";
            Users.Size = new Size(315, 65);
            Users.TabIndex = 4;
            Users.Text = "Контрагенты";
            Users.UseVisualStyleBackColor = true;
            // 
            // Storage
            // 
            Storage.Font = new Font("Segoe UI", 20F);
            Storage.Location = new Point(243, 538);
            Storage.Name = "Storage";
            Storage.Size = new Size(315, 65);
            Storage.TabIndex = 5;
            Storage.Text = "Товары";
            Storage.UseVisualStyleBackColor = true;
            // 
            // URLforGit
            // 
            URLforGit.AutoSize = true;
            URLforGit.Font = new Font("Segoe UI", 20F);
            URLforGit.Location = new Point(30, 351);
            URLforGit.Name = "URLforGit";
            URLforGit.Size = new Size(742, 62);
            URLforGit.TabIndex = 6;
            URLforGit.TabStop = true;
            URLforGit.Text = "Тут нужно вставить ссылку на Git";
            URLforGit.LinkClicked += URLforGit_LinkClicked;
            // 
            // Label
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 795);
            Controls.Add(URLforGit);
            Controls.Add(Storage);
            Controls.Add(Users);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Label";
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Button Users;
        private Button Storage;
        private LinkLabel URLforGit;
    }
}

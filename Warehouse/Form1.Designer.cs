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
            StorageButton = new Button();
            URLforGit = new LinkLabel();
            UsersButton = new Button();
            CountDownLabel = new System.Windows.Forms.Label();
            TimerLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(200, 78);
            label1.Name = "label1";
            label1.Size = new Size(391, 62);
            label1.TabIndex = 0;
            label1.Text = "Курсовая работа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(209, 166);
            label2.Name = "label2";
            label2.Size = new Size(381, 62);
            label2.TabIndex = 1;
            label2.Text = "Поршнев 22ВП1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(318, 248);
            label3.Name = "label3";
            label3.Size = new Size(154, 62);
            label3.TabIndex = 2;
            label3.Text = "Склад";
            // 
            // StorageButton
            // 
            StorageButton.Font = new Font("Segoe UI", 20F);
            StorageButton.Location = new Point(239, 534);
            StorageButton.Name = "StorageButton";
            StorageButton.Size = new Size(315, 65);
            StorageButton.TabIndex = 5;
            StorageButton.Text = "Товары";
            StorageButton.UseVisualStyleBackColor = true;
            StorageButton.Click += StorageButton_Click;
            // 
            // URLforGit
            // 
            URLforGit.AutoSize = true;
            URLforGit.Font = new Font("Segoe UI", 20F);
            URLforGit.Location = new Point(25, 351);
            URLforGit.Name = "URLforGit";
            URLforGit.Size = new Size(838, 62);
            URLforGit.TabIndex = 6;
            URLforGit.TabStop = true;
            URLforGit.Text = "https://github.com/p4shok/Warehouse";
            URLforGit.LinkClicked += URLforGit_LinkClicked;
            // 
            // UsersButton
            // 
            UsersButton.Font = new Font("Segoe UI", 20F);
            UsersButton.Location = new Point(239, 427);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(315, 65);
            UsersButton.TabIndex = 8;
            UsersButton.Text = "Контрагенты";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // CountDownLabel
            // 
            CountDownLabel.AutoSize = true;
            CountDownLabel.Font = new Font("Segoe UI", 20F);
            CountDownLabel.Location = new Point(25, 724);
            CountDownLabel.Name = "CountDownLabel";
            CountDownLabel.Size = new Size(490, 62);
            CountDownLabel.TabIndex = 9;
            CountDownLabel.Text = "До закрытия формы: ";
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Font = new Font("Segoe UI", 20F);
            TimerLabel.Location = new Point(492, 724);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(77, 62);
            TimerLabel.TabIndex = 10;
            TimerLabel.Text = "10";
            // 
            // Label
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 795);
            Controls.Add(TimerLabel);
            Controls.Add(CountDownLabel);
            Controls.Add(UsersButton);
            Controls.Add(URLforGit);
            Controls.Add(StorageButton);
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
        private Button StorageButton;
        private LinkLabel URLforGit;
        private Button UsersButton;
        private System.Windows.Forms.Label CountDownLabel;
        private System.Windows.Forms.Label TimerLabel;
    }
}

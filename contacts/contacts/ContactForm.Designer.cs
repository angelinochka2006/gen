namespace contacts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            //this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(125, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(125, 38);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberTextBox.TabIndex = 1;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Location = new System.Drawing.Point(12, 65);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(75, 23);
            this.AddContactButton.TabIndex = 2;
            this.AddContactButton.Text = "Добавить";
            this.AddContactButton.UseVisualStyleBackColor = true;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Location = new System.Drawing.Point(138, 65);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveContactButton.TabIndex = 3;
            this.RemoveContactButton.Text = "Удалить";
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(125, 105);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(13, 140);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(13, 196);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(120, 95);
            this.ContactsListBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "поиск";
            // 
            // Form1
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Controls.Add(this.label3);
            //this.Controls.Add(this.label2);
            //this.Controls.Add(this.label1);
            //this.Controls.Add(this.ContactsListBox);
            //this.Controls.Add(this.SearchButton);
            //this.Controls.Add(this.SearchTextBox);
            //this.Controls.Add(this.RemoveContactButton);
            //this.Controls.Add(this.AddContactButton);
            //this.Controls.Add(this.PhoneNumberTextBox);
            //this.Controls.Add(this.NameTextBox);
            //this.Name = "Form1";
            //this.Text = "Form1";
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


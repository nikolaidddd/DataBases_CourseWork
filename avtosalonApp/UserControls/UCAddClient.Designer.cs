namespace VPIProject
{
    partial class UCAddArendator
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblReg_Password = new System.Windows.Forms.Label();
            this.lblReg_Surname = new System.Windows.Forms.Label();
            this.lblReg_Name = new System.Windows.Forms.Label();
            this.lblReg_NumTel = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNomTel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(76, 37);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(125, 27);
            this.tbLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(76, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 25);
            this.lblLogin.TabIndex = 31;
            this.lblLogin.Text = "Логин";
            // 
            // lblReg_Password
            // 
            this.lblReg_Password.AutoSize = true;
            this.lblReg_Password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReg_Password.Location = new System.Drawing.Point(76, 90);
            this.lblReg_Password.Name = "lblReg_Password";
            this.lblReg_Password.Size = new System.Drawing.Size(78, 25);
            this.lblReg_Password.TabIndex = 32;
            this.lblReg_Password.Text = "Пароль";
            // 
            // lblReg_Surname
            // 
            this.lblReg_Surname.AutoSize = true;
            this.lblReg_Surname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReg_Surname.Location = new System.Drawing.Point(240, 13);
            this.lblReg_Surname.Name = "lblReg_Surname";
            this.lblReg_Surname.Size = new System.Drawing.Size(91, 25);
            this.lblReg_Surname.TabIndex = 35;
            this.lblReg_Surname.Text = "Фамилия";
            // 
            // lblReg_Name
            // 
            this.lblReg_Name.AutoSize = true;
            this.lblReg_Name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReg_Name.Location = new System.Drawing.Point(240, 90);
            this.lblReg_Name.Name = "lblReg_Name";
            this.lblReg_Name.Size = new System.Drawing.Size(44, 23);
            this.lblReg_Name.TabIndex = 36;
            this.lblReg_Name.Text = "Имя";
            // 
            // lblReg_NumTel
            // 
            this.lblReg_NumTel.AutoSize = true;
            this.lblReg_NumTel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReg_NumTel.Location = new System.Drawing.Point(410, 13);
            this.lblReg_NumTel.Name = "lblReg_NumTel";
            this.lblReg_NumTel.Size = new System.Drawing.Size(87, 25);
            this.lblReg_NumTel.TabIndex = 37;
            this.lblReg_NumTel.Text = "Телефон";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(76, 116);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 27);
            this.tbPassword.TabIndex = 38;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSurname.Location = new System.Drawing.Point(240, 37);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(127, 27);
            this.tbSurname.TabIndex = 39;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(240, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 27);
            this.tbName.TabIndex = 40;
            // 
            // tbNomTel
            // 
            this.tbNomTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNomTel.Location = new System.Drawing.Point(410, 37);
            this.tbNomTel.Name = "tbNomTel";
            this.tbNomTel.PlaceholderText = "+7...";
            this.tbNomTel.Size = new System.Drawing.Size(127, 27);
            this.tbNomTel.TabIndex = 41;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(410, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 60);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UCAddArendator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNomTel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblReg_NumTel);
            this.Controls.Add(this.lblReg_Name);
            this.Controls.Add(this.lblReg_Surname);
            this.Controls.Add(this.lblReg_Password);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbLogin);
            this.Name = "UCAddArendator";
            this.Size = new System.Drawing.Size(638, 210);
            this.Load += new System.EventHandler(this.UCAddArendator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbLogin;
        private Label lblLogin;
        private Label lblReg_Password;
        private Label lblReg_Surname;
        private Label lblReg_Name;
        private Label lblReg_NumTel;
        private TextBox tbPassword;
        private TextBox tbSurname;
        private TextBox tbName;
        private TextBox tbNomTel;
        private Button btnAdd;
    }
}

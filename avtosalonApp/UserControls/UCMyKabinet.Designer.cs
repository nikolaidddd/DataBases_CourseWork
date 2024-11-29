namespace VPIProject
{
    partial class UCMyKabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMyKabinet));
            this.lblKabNomTel = new System.Windows.Forms.Label();
            this.pctbox = new System.Windows.Forms.PictureBox();
            this.lblKabName = new System.Windows.Forms.Label();
            this.lblKabLogin = new System.Windows.Forms.Label();
            this.lblKabSurname = new System.Windows.Forms.Label();
            this.lblKabPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKabNomTel
            // 
            this.lblKabNomTel.AutoSize = true;
            this.lblKabNomTel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKabNomTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKabNomTel.Location = new System.Drawing.Point(199, 192);
            this.lblKabNomTel.Name = "lblKabNomTel";
            this.lblKabNomTel.Size = new System.Drawing.Size(216, 28);
            this.lblKabNomTel.TabIndex = 18;
            this.lblKabNomTel.Text = "Мобильный телефон: ";
            // 
            // pctbox
            // 
            this.pctbox.Image = ((System.Drawing.Image)(resources.GetObject("pctbox.Image")));
            this.pctbox.Location = new System.Drawing.Point(25, 16);
            this.pctbox.Name = "pctbox";
            this.pctbox.Size = new System.Drawing.Size(144, 145);
            this.pctbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox.TabIndex = 13;
            this.pctbox.TabStop = false;
            // 
            // lblKabName
            // 
            this.lblKabName.AutoSize = true;
            this.lblKabName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKabName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKabName.Location = new System.Drawing.Point(199, 151);
            this.lblKabName.Name = "lblKabName";
            this.lblKabName.Size = new System.Drawing.Size(60, 28);
            this.lblKabName.TabIndex = 17;
            this.lblKabName.Text = "Имя: ";
            // 
            // lblKabLogin
            // 
            this.lblKabLogin.AutoSize = true;
            this.lblKabLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKabLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKabLogin.Location = new System.Drawing.Point(199, 16);
            this.lblKabLogin.Name = "lblKabLogin";
            this.lblKabLogin.Size = new System.Drawing.Size(78, 28);
            this.lblKabLogin.TabIndex = 14;
            this.lblKabLogin.Text = "Логин: ";
            // 
            // lblKabSurname
            // 
            this.lblKabSurname.AutoSize = true;
            this.lblKabSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKabSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKabSurname.Location = new System.Drawing.Point(199, 106);
            this.lblKabSurname.Name = "lblKabSurname";
            this.lblKabSurname.Size = new System.Drawing.Size(105, 28);
            this.lblKabSurname.TabIndex = 16;
            this.lblKabSurname.Text = "Фамилия: ";
            // 
            // lblKabPassword
            // 
            this.lblKabPassword.AutoSize = true;
            this.lblKabPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKabPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKabPassword.Location = new System.Drawing.Point(199, 61);
            this.lblKabPassword.Name = "lblKabPassword";
            this.lblKabPassword.Size = new System.Drawing.Size(90, 28);
            this.lblKabPassword.TabIndex = 15;
            this.lblKabPassword.Text = "Пароль: ";
            // 
            // UCMyKabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblKabNomTel);
            this.Controls.Add(this.pctbox);
            this.Controls.Add(this.lblKabName);
            this.Controls.Add(this.lblKabLogin);
            this.Controls.Add(this.lblKabSurname);
            this.Controls.Add(this.lblKabPassword);
            this.Name = "UCMyKabinet";
            this.Size = new System.Drawing.Size(750, 250);
            this.Load += new System.EventHandler(this.UCMyKabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKabNomTel;
        private PictureBox pctbox;
        private Label lblKabName;
        private Label lblKabLogin;
        private Label lblKabSurname;
        private Label lblKabPassword;
    }
}

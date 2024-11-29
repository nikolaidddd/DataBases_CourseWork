namespace VPIProject
{
    partial class UCMyDogovors
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
            this.dgvDogovors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogovors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogovors
            // 
            this.dgvDogovors.AllowUserToAddRows = false;
            this.dgvDogovors.AllowUserToDeleteRows = false;
            this.dgvDogovors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDogovors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogovors.Location = new System.Drawing.Point(3, 19);
            this.dgvDogovors.Name = "dgvDogovors";
            this.dgvDogovors.ReadOnly = true;
            this.dgvDogovors.RowHeadersWidth = 51;
            this.dgvDogovors.RowTemplate.Height = 29;
            this.dgvDogovors.Size = new System.Drawing.Size(630, 302);
            this.dgvDogovors.TabIndex = 0;
            // 
            // UCMyDogovors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgvDogovors);
            this.Name = "UCMyDogovors";
            this.Size = new System.Drawing.Size(638, 360);
            this.Load += new System.EventHandler(this.UCMyDogovors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogovors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDogovors;
    }
}

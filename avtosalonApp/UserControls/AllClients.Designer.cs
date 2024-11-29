namespace VPIProject
{
    partial class UCAllArendators
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
            this.dgvArendators = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArendators)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArendators
            // 
            this.dgvArendators.AllowUserToAddRows = false;
            this.dgvArendators.AllowUserToDeleteRows = false;
            this.dgvArendators.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArendators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArendators.Location = new System.Drawing.Point(3, 18);
            this.dgvArendators.Name = "dgvArendators";
            this.dgvArendators.ReadOnly = true;
            this.dgvArendators.RowHeadersWidth = 51;
            this.dgvArendators.RowTemplate.Height = 29;
            this.dgvArendators.Size = new System.Drawing.Size(630, 302);
            this.dgvArendators.TabIndex = 1;
            // 
            // UCAllArendators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.dgvArendators);
            this.Name = "UCAllArendators";
            this.Size = new System.Drawing.Size(638, 360);
            this.Load += new System.EventHandler(this.UCAllArendators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArendators)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvArendators;
    }
}

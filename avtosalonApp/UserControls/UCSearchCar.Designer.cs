namespace VPIProject
{
    partial class UCSearchRoom
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
            this.txtboxSpace = new System.Windows.Forms.TextBox();
            this.txtboxFloor = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFurniture = new System.Windows.Forms.CheckBox();
            this.cbCondition = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxSpace
            // 
            this.txtboxSpace.Location = new System.Drawing.Point(242, 32);
            this.txtboxSpace.Name = "txtboxSpace";
            this.txtboxSpace.PlaceholderText = "Не менее";
            this.txtboxSpace.Size = new System.Drawing.Size(151, 27);
            this.txtboxSpace.TabIndex = 0;
            this.txtboxSpace.TextChanged += new System.EventHandler(this.txtboxSpace_TextChanged);
            // 
            // txtboxFloor
            // 
            this.txtboxFloor.Location = new System.Drawing.Point(424, 32);
            this.txtboxFloor.Name = "txtboxFloor";
            this.txtboxFloor.PlaceholderText = "Не менее";
            this.txtboxFloor.Size = new System.Drawing.Size(151, 27);
            this.txtboxFloor.TabIndex = 1;
            this.txtboxFloor.TextChanged += new System.EventHandler(this.txtboxFloor_TextChanged);
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(73, 32);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.PlaceholderText = "Не более";
            this.txtboxCost.Size = new System.Drawing.Size(151, 27);
            this.txtboxCost.TabIndex = 2;
            this.txtboxCost.TextChanged += new System.EventHandler(this.txtboxCost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Площадь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер этажа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоимость";
            // 
            // cbFurniture
            // 
            this.cbFurniture.AutoSize = true;
            this.cbFurniture.Location = new System.Drawing.Point(73, 97);
            this.cbFurniture.Name = "cbFurniture";
            this.cbFurniture.Size = new System.Drawing.Size(85, 24);
            this.cbFurniture.TabIndex = 10;
            this.cbFurniture.Text = "Мебель";
            this.cbFurniture.UseVisualStyleBackColor = true;
            // 
            // cbCondition
            // 
            this.cbCondition.AutoSize = true;
            this.cbCondition.Location = new System.Drawing.Point(73, 72);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(128, 24);
            this.cbCondition.TabIndex = 11;
            this.cbCondition.Text = "Кондиционер";
            this.cbCondition.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 54);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(471, 299);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(91, 299);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 40);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Назад";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // UCSearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.cbFurniture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxFloor);
            this.Controls.Add(this.txtboxSpace);
            this.Name = "UCSearchRoom";
            this.Size = new System.Drawing.Size(638, 360);
            this.Load += new System.EventHandler(this.UCSearchRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtboxSpace;
        private TextBox txtboxFloor;
        private TextBox txtboxCost;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbFurniture;
        private CheckBox cbCondition;
        private Button btnSearch;
        private Button btnNext;
        private Button btnPrev;
    }
}

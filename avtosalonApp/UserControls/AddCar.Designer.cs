namespace VPIProject
{
    partial class UCAddRoom
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCondition = new System.Windows.Forms.CheckBox();
            this.cbFurniture = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxFloor = new System.Windows.Forms.TextBox();
            this.txtboxSpace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxNumRoom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(406, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 54);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCondition
            // 
            this.cbCondition.AutoSize = true;
            this.cbCondition.Location = new System.Drawing.Point(55, 73);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(128, 24);
            this.cbCondition.TabIndex = 20;
            this.cbCondition.Text = "Кондиционер";
            this.cbCondition.UseVisualStyleBackColor = true;
            // 
            // cbFurniture
            // 
            this.cbFurniture.AutoSize = true;
            this.cbFurniture.Location = new System.Drawing.Point(55, 98);
            this.cbFurniture.Name = "cbFurniture";
            this.cbFurniture.Size = new System.Drawing.Size(85, 24);
            this.cbFurniture.TabIndex = 19;
            this.cbFurniture.Text = "Мебель";
            this.cbFurniture.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Номер этажа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Площадь";
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(224, 109);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(151, 27);
            this.txtboxCost.TabIndex = 15;
            // 
            // txtboxFloor
            // 
            this.txtboxFloor.Location = new System.Drawing.Point(406, 33);
            this.txtboxFloor.Name = "txtboxFloor";
            this.txtboxFloor.Size = new System.Drawing.Size(151, 27);
            this.txtboxFloor.TabIndex = 14;
            // 
            // txtboxSpace
            // 
            this.txtboxSpace.Location = new System.Drawing.Point(224, 33);
            this.txtboxSpace.Name = "txtboxSpace";
            this.txtboxSpace.Size = new System.Drawing.Size(151, 27);
            this.txtboxSpace.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Номер комнаты";
            // 
            // txtboxNumRoom
            // 
            this.txtboxNumRoom.Location = new System.Drawing.Point(55, 33);
            this.txtboxNumRoom.Name = "txtboxNumRoom";
            this.txtboxNumRoom.Size = new System.Drawing.Size(151, 27);
            this.txtboxNumRoom.TabIndex = 22;
            // 
            // UCAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxNumRoom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.cbFurniture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxFloor);
            this.Controls.Add(this.txtboxSpace);
            this.Name = "UCAddRoom";
            this.Size = new System.Drawing.Size(638, 287);
            this.Load += new System.EventHandler(this.UCAddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private CheckBox cbCondition;
        private CheckBox cbFurniture;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtboxCost;
        private TextBox txtboxFloor;
        private TextBox txtboxSpace;
        private Label label4;
        private TextBox txtboxNumRoom;
    }
}

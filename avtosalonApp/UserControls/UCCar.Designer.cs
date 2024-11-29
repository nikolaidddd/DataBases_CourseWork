namespace VPIProject
{
    partial class UCRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRoom));
            this.lblNumRoom = new System.Windows.Forms.Label();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblFurniture = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumRoom
            // 
            this.lblNumRoom.AutoSize = true;
            this.lblNumRoom.Location = new System.Drawing.Point(124, 11);
            this.lblNumRoom.Name = "lblNumRoom";
            this.lblNumRoom.Size = new System.Drawing.Size(129, 20);
            this.lblNumRoom.TabIndex = 0;
            this.lblNumRoom.Text = "Номер комнаты: ";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(124, 41);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(80, 20);
            this.lblSpace.TabIndex = 1;
            this.lblSpace.Text = "Площадь: ";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(124, 71);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(50, 20);
            this.lblFloor.TabIndex = 2;
            this.lblFloor.Text = "Этаж: ";
            // 
            // lblFurniture
            // 
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Location = new System.Drawing.Point(309, 11);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(70, 20);
            this.lblFurniture.TabIndex = 3;
            this.lblFurniture.Text = "Мебель: ";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(309, 41);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(113, 20);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Кондиционер: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(309, 71);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(90, 20);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Стоимость: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UCRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblFurniture);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.lblNumRoom);
            this.Name = "UCRoom";
            this.Size = new System.Drawing.Size(480, 120);
            this.Load += new System.EventHandler(this.UCRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumRoom;
        private Label lblSpace;
        private Label lblFloor;
        private Label lblFurniture;
        private Label lblCondition;
        private Label lblCost;
        private PictureBox pictureBox1;
    }
}

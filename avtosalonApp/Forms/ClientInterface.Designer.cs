namespace avtosalonApp
{
    partial class ClientInterface
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnMyDogovor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.btnKab = new System.Windows.Forms.Button();
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(12, 165);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(136, 61);
            this.btnKatalog.TabIndex = 1;
            this.btnKatalog.Text = "Каталог";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnMyDogovor
            // 
            this.btnMyDogovor.Location = new System.Drawing.Point(12, 299);
            this.btnMyDogovor.Name = "btnMyDogovor";
            this.btnMyDogovor.Size = new System.Drawing.Size(136, 61);
            this.btnMyDogovor.TabIndex = 2;
            this.btnMyDogovor.Text = "Мои договоры";
            this.btnMyDogovor.UseVisualStyleBackColor = true;
            this.btnMyDogovor.Click += new System.EventHandler(this.btnMyDogovor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(12, 232);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(136, 61);
            this.btnSearchRoom.TabIndex = 4;
            this.btnSearchRoom.Text = "Поиск автомобиля";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // btnKab
            // 
            this.btnKab.Location = new System.Drawing.Point(12, 98);
            this.btnKab.Name = "btnKab";
            this.btnKab.Size = new System.Drawing.Size(136, 61);
            this.btnKab.TabIndex = 5;
            this.btnKab.Text = "Личный кабинет";
            this.btnKab.UseVisualStyleBackColor = true;
            this.btnKab.Click += new System.EventHandler(this.btnKab_Click);
            // 
            // lblCurrPage
            // 
            this.lblCurrPage.AutoSize = true;
            this.lblCurrPage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrPage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCurrPage.Location = new System.Drawing.Point(12, 9);
            this.lblCurrPage.Name = "lblCurrPage";
            this.lblCurrPage.Size = new System.Drawing.Size(0, 46);
            this.lblCurrPage.TabIndex = 6;
            // 
            // ArendatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(978, 561);
            this.Controls.Add(this.lblCurrPage);
            this.Controls.Add(this.btnKab);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMyDogovor);
            this.Controls.Add(this.btnKatalog);
            this.Name = "ClientInterface";
            this.Text = "ClientInterface";
            this.Load += new System.EventHandler(this.ClientInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBox1;
        private Button btnKatalog;
        private Button btnMyDogovor;
        private Button btnExit;
        private Button btnSearchRoom;
        private Button btnKab;
        private Label lblCurrPage;
    }
}
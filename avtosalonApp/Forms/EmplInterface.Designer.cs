namespace avtosalonApp
{
    partial class EmplInterface
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
            this.btnAddArendator = new System.Windows.Forms.Button();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.btnAddDogovor = new System.Windows.Forms.Button();
            this.btnAllArendators = new System.Windows.Forms.Button();
            this.btnMyDogovor = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnRemoveArendator = new System.Windows.Forms.Button();
            this.btnRemoveDogovor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddArendator
            // 
            this.btnAddArendator.Location = new System.Drawing.Point(12, 87);
            this.btnAddArendator.Name = "btnAddArendator";
            this.btnAddArendator.Size = new System.Drawing.Size(172, 50);
            this.btnAddArendator.TabIndex = 0;
            this.btnAddArendator.Text = "Добавить клиента";
            this.btnAddArendator.UseVisualStyleBackColor = true;
            this.btnAddArendator.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(12, 255);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(172, 50);
            this.btnSearchRoom.TabIndex = 1;
            this.btnSearchRoom.Text = "Поиск автомобиля";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // btnAddDogovor
            // 
            this.btnAddDogovor.Location = new System.Drawing.Point(12, 143);
            this.btnAddDogovor.Name = "btnAddDogovor";
            this.btnAddDogovor.Size = new System.Drawing.Size(172, 50);
            this.btnAddDogovor.TabIndex = 2;
            this.btnAddDogovor.Text = "Добавить договор";
            this.btnAddDogovor.UseVisualStyleBackColor = true;
            this.btnAddDogovor.Click += new System.EventHandler(this.btnAddDogovor_Click);
            // 
            // btnAllArendators
            // 
            this.btnAllArendators.Location = new System.Drawing.Point(12, 311);
            this.btnAllArendators.Name = "btnAllArendators";
            this.btnAllArendators.Size = new System.Drawing.Size(172, 52);
            this.btnAllArendators.TabIndex = 3;
            this.btnAllArendators.Text = "Просмотр всех клиентов";
            this.btnAllArendators.UseVisualStyleBackColor = true;
            this.btnAllArendators.Click += new System.EventHandler(this.btnAllClients_Click);
            // 
            // btnMyDogovor
            // 
            this.btnMyDogovor.Location = new System.Drawing.Point(12, 369);
            this.btnMyDogovor.Name = "btnMyDogovor";
            this.btnMyDogovor.Size = new System.Drawing.Size(172, 47);
            this.btnMyDogovor.TabIndex = 4;
            this.btnMyDogovor.Text = "Мои договоры";
            this.btnMyDogovor.UseVisualStyleBackColor = true;
            this.btnMyDogovor.Click += new System.EventHandler(this.btnMyDogovor_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(12, 199);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(172, 50);
            this.btnKatalog.TabIndex = 5;
            this.btnKatalog.Text = "Все автомобили";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 47);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(12, 31);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(172, 50);
            this.btnAddRoom.TabIndex = 7;
            this.btnAddRoom.Text = "Добавить автомобиль";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(853, 31);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(131, 50);
            this.btnRemoveRoom.TabIndex = 8;
            this.btnRemoveRoom.Text = "Удалить автомобиль";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnRemoveArendator
            // 
            this.btnRemoveArendator.Location = new System.Drawing.Point(853, 87);
            this.btnRemoveArendator.Name = "btnRemoveArendator";
            this.btnRemoveArendator.Size = new System.Drawing.Size(131, 50);
            this.btnRemoveArendator.TabIndex = 9;
            this.btnRemoveArendator.Text = "Удалить клиента";
            this.btnRemoveArendator.UseVisualStyleBackColor = true;
            this.btnRemoveArendator.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnRemoveDogovor
            // 
            this.btnRemoveDogovor.Location = new System.Drawing.Point(853, 143);
            this.btnRemoveDogovor.Name = "btnRemoveDogovor";
            this.btnRemoveDogovor.Size = new System.Drawing.Size(131, 50);
            this.btnRemoveDogovor.TabIndex = 10;
            this.btnRemoveDogovor.Text = "Удалить договор";
            this.btnRemoveDogovor.UseVisualStyleBackColor = true;
            this.btnRemoveDogovor.Click += new System.EventHandler(this.btnRemoveDogovor_Click);
            // 
            // ArendodatelInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 489);
            this.Controls.Add(this.btnRemoveDogovor);
            this.Controls.Add(this.btnRemoveArendator);
            this.Controls.Add(this.btnRemoveRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.btnMyDogovor);
            this.Controls.Add(this.btnAllArendators);
            this.Controls.Add(this.btnAddDogovor);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.btnAddArendator);
            this.Name = "EmplInterface";
            this.Text = "EmplInterface";
            this.Load += new System.EventHandler(this.ArendodatelInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddArendator;
        private Button btnSearchRoom;
        private Button btnAddDogovor;
        private Button btnAllArendators;
        private Button btnMyDogovor;
        private Button btnKatalog;
        private Button btnExit;
        private Button btnAddRoom;
        private Button btnRemoveRoom;
        private Button btnRemoveArendator;
        private Button btnRemoveDogovor;
    }
}

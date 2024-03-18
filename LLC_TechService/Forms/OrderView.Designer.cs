namespace LLC_TechService.Forms
{
    partial class OrderView
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelEquip = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelMaster = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelProblem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(22, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(75, 23);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "Заказ №";
            // 
            // labelEquip
            // 
            this.labelEquip.AutoSize = true;
            this.labelEquip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquip.Location = new System.Drawing.Point(22, 56);
            this.labelEquip.Name = "labelEquip";
            this.labelEquip.Size = new System.Drawing.Size(119, 23);
            this.labelEquip.TabIndex = 3;
            this.labelEquip.Text = "Оборудование";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClient.Location = new System.Drawing.Point(22, 131);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(70, 23);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Клиент:";
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaster.Location = new System.Drawing.Point(22, 167);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(71, 23);
            this.labelMaster.TabIndex = 5;
            this.labelMaster.Text = "Мастер:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(441, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(61, 23);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Статус";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(441, 55);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(96, 23);
            this.labelPriority.TabIndex = 7;
            this.labelPriority.Text = "Приоритет";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(441, 155);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(275, 32);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Редактировать заказ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelProblem.Location = new System.Drawing.Point(22, 85);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(81, 23);
            this.labelProblem.TabIndex = 9;
            this.labelProblem.Text = "Поломка";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelProblem);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMaster);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelEquip);
            this.Controls.Add(this.labelID);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(748, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelID;
        private Label labelEquip;
        private Label labelClient;
        private Label labelMaster;
        private Label labelStatus;
        private Label labelPriority;
        private Button buttonEdit;
        private Label labelProblem;
    }
}

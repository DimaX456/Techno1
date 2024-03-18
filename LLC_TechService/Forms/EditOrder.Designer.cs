namespace LLC_TechService.Forms
{
    partial class EditOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelMalfunction = new System.Windows.Forms.Label();
            this.textBoxProblem = new System.Windows.Forms.TextBox();
            this.labelEquip = new System.Windows.Forms.Label();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboMaster = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 46);
            this.label2.TabIndex = 41;
            this.label2.Text = "Серийный \r\nномер*";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSerial.Location = new System.Drawing.Point(204, 91);
            this.textBoxSerial.Multiline = true;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(246, 40);
            this.textBoxSerial.TabIndex = 40;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(88, 593);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(348, 34);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 46);
            this.label6.TabIndex = 38;
            this.label6.Text = "Комментарий\r\nк заказу\r\n";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(204, 431);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(246, 93);
            this.textBoxDesc.TabIndex = 37;
            // 
            // labelMalfunction
            // 
            this.labelMalfunction.AutoSize = true;
            this.labelMalfunction.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMalfunction.Location = new System.Drawing.Point(60, 194);
            this.labelMalfunction.Name = "labelMalfunction";
            this.labelMalfunction.Size = new System.Drawing.Size(134, 23);
            this.labelMalfunction.TabIndex = 36;
            this.labelMalfunction.Text = "Неисправность*\r\n";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProblem.Location = new System.Drawing.Point(204, 191);
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.Size = new System.Drawing.Size(246, 32);
            this.textBoxProblem.TabIndex = 35;
            // 
            // labelEquip
            // 
            this.labelEquip.AutoSize = true;
            this.labelEquip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquip.Location = new System.Drawing.Point(60, 34);
            this.labelEquip.Name = "labelEquip";
            this.labelEquip.Size = new System.Drawing.Size(124, 69);
            this.labelEquip.TabIndex = 34;
            this.labelEquip.Text = "Наименование\r\nоборудования*\r\n\r\n";
            // 
            // textBoxEquip
            // 
            this.textBoxEquip.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEquip.Location = new System.Drawing.Point(204, 34);
            this.textBoxEquip.Multiline = true;
            this.textBoxEquip.Name = "textBoxEquip";
            this.textBoxEquip.Size = new System.Drawing.Size(246, 40);
            this.textBoxEquip.TabIndex = 33;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(88, 553);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(348, 34);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Изменить заказ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(204, 148);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(246, 28);
            this.comboType.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Тип техники*";
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(204, 243);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(246, 28);
            this.comboStatus.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Статус*";
            // 
            // comboPriority
            // 
            this.comboPriority.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(204, 290);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(246, 28);
            this.comboPriority.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Приоритет*";
            // 
            // comboMaster
            // 
            this.comboMaster.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboMaster.FormattingEnabled = true;
            this.comboMaster.Location = new System.Drawing.Point(204, 336);
            this.comboMaster.Name = "comboMaster";
            this.comboMaster.Size = new System.Drawing.Size(246, 28);
            this.comboMaster.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ответственный*";
            // 
            // comboClient
            // 
            this.comboClient.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(204, 380);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(246, 28);
            this.comboClient.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(60, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Клиент*";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 651);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboMaster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelMalfunction);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.labelEquip);
            this.Controls.Add(this.textBoxEquip);
            this.Controls.Add(this.buttonEdit);
            this.MaximumSize = new System.Drawing.Size(534, 690);
            this.MinimumSize = new System.Drawing.Size(534, 690);
            this.Name = "EditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox textBoxSerial;
        private Button buttonCancel;
        private Label label6;
        private TextBox textBoxDesc;
        private Label labelMalfunction;
        private TextBox textBoxProblem;
        private Label labelEquip;
        private TextBox textBoxEquip;
        private Button buttonEdit;
        private ComboBox comboType;
        private Label label1;
        private ComboBox comboStatus;
        private Label label3;
        private ComboBox comboPriority;
        private Label label4;
        private ComboBox comboMaster;
        private Label label5;
        private ComboBox comboClient;
        private Label label7;
    }
}
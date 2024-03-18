namespace LLC_TechService.Forms
{
    partial class CreateOrder
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelMalfunction = new System.Windows.Forms.Label();
            this.textBoxProblem = new System.Windows.Forms.TextBox();
            this.labelEquip = new System.Windows.Forms.Label();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(70, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 46);
            this.label6.TabIndex = 26;
            this.label6.Text = "Комментарий\r\nк заказу\r\n";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(205, 279);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(246, 93);
            this.textBoxDesc.TabIndex = 25;
            // 
            // labelMalfunction
            // 
            this.labelMalfunction.AutoSize = true;
            this.labelMalfunction.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMalfunction.Location = new System.Drawing.Point(70, 214);
            this.labelMalfunction.Name = "labelMalfunction";
            this.labelMalfunction.Size = new System.Drawing.Size(94, 46);
            this.labelMalfunction.TabIndex = 24;
            this.labelMalfunction.Text = "Опишите \r\nпроблему*\r\n";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProblem.Location = new System.Drawing.Point(205, 214);
            this.textBoxProblem.Multiline = true;
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.Size = new System.Drawing.Size(246, 40);
            this.textBoxProblem.TabIndex = 23;
            // 
            // labelEquip
            // 
            this.labelEquip.AutoSize = true;
            this.labelEquip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquip.Location = new System.Drawing.Point(70, 50);
            this.labelEquip.Name = "labelEquip";
            this.labelEquip.Size = new System.Drawing.Size(124, 69);
            this.labelEquip.TabIndex = 22;
            this.labelEquip.Text = "Наименование\r\nоборудования*\r\n\r\n";
            // 
            // textBoxEquip
            // 
            this.textBoxEquip.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEquip.Location = new System.Drawing.Point(205, 50);
            this.textBoxEquip.Multiline = true;
            this.textBoxEquip.Name = "textBoxEquip";
            this.textBoxEquip.Size = new System.Drawing.Size(246, 40);
            this.textBoxEquip.TabIndex = 21;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.Location = new System.Drawing.Point(88, 412);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(348, 34);
            this.buttonCreate.TabIndex = 20;
            this.buttonCreate.Text = "Оформить заказ";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(88, 452);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(348, 34);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Тип техники*";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(205, 167);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(246, 23);
            this.comboType.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 46);
            this.label2.TabIndex = 31;
            this.label2.Text = "Серийный \r\nномер*";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSerial.Location = new System.Drawing.Point(205, 107);
            this.textBoxSerial.Multiline = true;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(246, 40);
            this.textBoxSerial.TabIndex = 30;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelMalfunction);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.labelEquip);
            this.Controls.Add(this.textBoxEquip);
            this.Controls.Add(this.buttonCreate);
            this.MaximumSize = new System.Drawing.Size(544, 539);
            this.MinimumSize = new System.Drawing.Size(544, 539);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox textBoxDesc;
        private Label labelMalfunction;
        private TextBox textBoxProblem;
        private Label labelEquip;
        private TextBox textBoxEquip;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label label1;
        private ComboBox comboType;
        private Label label2;
        private TextBox textBoxSerial;
    }
}
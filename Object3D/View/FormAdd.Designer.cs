
namespace View
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParam3 = new System.Windows.Forms.TextBox();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonОк = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(26, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Радиус";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(290, 54);
            this.textBoxParam1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(247, 20);
            this.textBoxParam1.TabIndex = 63;
            this.textBoxParam1.Text = "1";
            this.textBoxParam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Сфера",
            "Пирамида",
            "Параллеллепипед"});
            this.comboBoxType.Location = new System.Drawing.Point(288, 18);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(247, 21);
            this.comboBoxType.TabIndex = 57;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Тип фигуры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Длина";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Площадь основания";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxParam3
            // 
            this.textBoxParam3.Location = new System.Drawing.Point(290, 127);
            this.textBoxParam3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParam3.Name = "textBoxParam3";
            this.textBoxParam3.Size = new System.Drawing.Size(247, 20);
            this.textBoxParam3.TabIndex = 53;
            this.textBoxParam3.Text = "1";
            this.textBoxParam3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Location = new System.Drawing.Point(290, 92);
            this.textBoxParam2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(247, 20);
            this.textBoxParam2.TabIndex = 52;
            this.textBoxParam2.Text = "1";
            this.textBoxParam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonCansel
            // 
            this.buttonCansel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCansel.Location = new System.Drawing.Point(459, 176);
            this.buttonCansel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(78, 28);
            this.buttonCansel.TabIndex = 51;
            this.buttonCansel.Text = "Отмена";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonОк
            // 
            this.buttonОк.BackColor = System.Drawing.SystemColors.Control;
            this.buttonОк.Location = new System.Drawing.Point(28, 176);
            this.buttonОк.Margin = new System.Windows.Forms.Padding(2);
            this.buttonОк.Name = "buttonОк";
            this.buttonОк.Size = new System.Drawing.Size(78, 28);
            this.buttonОк.TabIndex = 50;
            this.buttonОк.Text = "OK";
            this.buttonОк.UseVisualStyleBackColor = false;
            this.buttonОк.Click += new System.EventHandler(this.buttonОк_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRandom.Location = new System.Drawing.Point(218, 176);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(140, 28);
            this.buttonRandom.TabIndex = 49;
            this.buttonRandom.Text = "CreateRandom Data";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 223);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxParam1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxParam3);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonОк);
            this.Controls.Add(this.buttonRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фигура";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParam3;
        private System.Windows.Forms.TextBox textBoxParam2;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonОк;
        private System.Windows.Forms.Button buttonRandom;
    }
}
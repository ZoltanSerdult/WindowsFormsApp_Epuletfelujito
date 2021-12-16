
namespace WindowsFormsApp_Epuletfelujito
{
    partial class Form_T_epulet
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
            this.dateTimePicker_T_Munkaveg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_T_MunkaKezd = new System.Windows.Forms.DateTimePicker();
            this.comboBox_T_Anyag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_T_Alap = new System.Windows.Forms.NumericUpDown();
            this.textBox_T_Cim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_T_Lakasszam = new System.Windows.Forms.NumericUpDown();
            this.comboBox_T_Fentartas = new System.Windows.Forms.ComboBox();
            this.checkBox_T_VaneLift = new System.Windows.Forms.CheckBox();
            this.button_T_Rogzit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_T_Alap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_T_Lakasszam)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_T_Munkaveg
            // 
            this.dateTimePicker_T_Munkaveg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_T_Munkaveg.Location = new System.Drawing.Point(161, 149);
            this.dateTimePicker_T_Munkaveg.Name = "dateTimePicker_T_Munkaveg";
            this.dateTimePicker_T_Munkaveg.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker_T_Munkaveg.TabIndex = 25;
            // 
            // dateTimePicker_T_MunkaKezd
            // 
            this.dateTimePicker_T_MunkaKezd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_T_MunkaKezd.Location = new System.Drawing.Point(161, 115);
            this.dateTimePicker_T_MunkaKezd.Name = "dateTimePicker_T_MunkaKezd";
            this.dateTimePicker_T_MunkaKezd.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker_T_MunkaKezd.TabIndex = 24;
            // 
            // comboBox_T_Anyag
            // 
            this.comboBox_T_Anyag.FormattingEnabled = true;
            this.comboBox_T_Anyag.Location = new System.Drawing.Point(161, 84);
            this.comboBox_T_Anyag.Name = "comboBox_T_Anyag";
            this.comboBox_T_Anyag.Size = new System.Drawing.Size(160, 21);
            this.comboBox_T_Anyag.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "NM";
            // 
            // numericUpDown_T_Alap
            // 
            this.numericUpDown_T_Alap.Location = new System.Drawing.Point(161, 51);
            this.numericUpDown_T_Alap.Name = "numericUpDown_T_Alap";
            this.numericUpDown_T_Alap.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown_T_Alap.TabIndex = 21;
            // 
            // textBox_T_Cim
            // 
            this.textBox_T_Cim.Location = new System.Drawing.Point(161, 16);
            this.textBox_T_Cim.Name = "textBox_T_Cim";
            this.textBox_T_Cim.Size = new System.Drawing.Size(160, 20);
            this.textBox_T_Cim.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Munka vég";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Munka ketdet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Épitésanyag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alapterület";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Lakások száma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fantartás tipusa";
            // 
            // numericUpDown_T_Lakasszam
            // 
            this.numericUpDown_T_Lakasszam.Location = new System.Drawing.Point(162, 187);
            this.numericUpDown_T_Lakasszam.Name = "numericUpDown_T_Lakasszam";
            this.numericUpDown_T_Lakasszam.Size = new System.Drawing.Size(159, 20);
            this.numericUpDown_T_Lakasszam.TabIndex = 28;
            // 
            // comboBox_T_Fentartas
            // 
            this.comboBox_T_Fentartas.FormattingEnabled = true;
            this.comboBox_T_Fentartas.Location = new System.Drawing.Point(162, 220);
            this.comboBox_T_Fentartas.Name = "comboBox_T_Fentartas";
            this.comboBox_T_Fentartas.Size = new System.Drawing.Size(159, 21);
            this.comboBox_T_Fentartas.TabIndex = 29;
            // 
            // checkBox_T_VaneLift
            // 
            this.checkBox_T_VaneLift.AutoSize = true;
            this.checkBox_T_VaneLift.Location = new System.Drawing.Point(130, 263);
            this.checkBox_T_VaneLift.Name = "checkBox_T_VaneLift";
            this.checkBox_T_VaneLift.Size = new System.Drawing.Size(73, 17);
            this.checkBox_T_VaneLift.TabIndex = 30;
            this.checkBox_T_VaneLift.Text = "Van-e lift?";
            this.checkBox_T_VaneLift.UseVisualStyleBackColor = true;
            // 
            // button_T_Rogzit
            // 
            this.button_T_Rogzit.Location = new System.Drawing.Point(26, 295);
            this.button_T_Rogzit.Name = "button_T_Rogzit";
            this.button_T_Rogzit.Size = new System.Drawing.Size(295, 36);
            this.button_T_Rogzit.TabIndex = 31;
            this.button_T_Rogzit.Text = "Rögzit";
            this.button_T_Rogzit.UseVisualStyleBackColor = true;
            // 
            // Form_T_epulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 360);
            this.Controls.Add(this.button_T_Rogzit);
            this.Controls.Add(this.checkBox_T_VaneLift);
            this.Controls.Add(this.comboBox_T_Fentartas);
            this.Controls.Add(this.numericUpDown_T_Lakasszam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_T_Munkaveg);
            this.Controls.Add(this.dateTimePicker_T_MunkaKezd);
            this.Controls.Add(this.comboBox_T_Anyag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_T_Alap);
            this.Controls.Add(this.textBox_T_Cim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_T_epulet";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_T_Alap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_T_Lakasszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_T_Munkaveg;
        private System.Windows.Forms.DateTimePicker dateTimePicker_T_MunkaKezd;
        private System.Windows.Forms.ComboBox comboBox_T_Anyag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_T_Alap;
        private System.Windows.Forms.TextBox textBox_T_Cim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_T_Lakasszam;
        private System.Windows.Forms.ComboBox comboBox_T_Fentartas;
        private System.Windows.Forms.CheckBox checkBox_T_VaneLift;
        private System.Windows.Forms.Button button_T_Rogzit;
    }
}
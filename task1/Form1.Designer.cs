using System.Drawing;

namespace task1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meterToKilometerBtn = new System.Windows.Forms.RadioButton();
            this.meterToMileBtn = new System.Windows.Forms.RadioButton();
            this.mileToMeterBtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result :";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(185, 150);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 22);
            this.valueTextBox.TabIndex = 2;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(185, 224);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 22);
            this.resultTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose Unit :";
            // 
            // meterToKilometerBtn
            // 
            this.meterToKilometerBtn.AutoSize = true;
            this.meterToKilometerBtn.Location = new System.Drawing.Point(452, 144);
            this.meterToKilometerBtn.Name = "meterToKilometerBtn";
            this.meterToKilometerBtn.Size = new System.Drawing.Size(134, 20);
            this.meterToKilometerBtn.TabIndex = 5;
            this.meterToKilometerBtn.TabStop = true;
            this.meterToKilometerBtn.Text = "Meter to kilometer";
            this.meterToKilometerBtn.UseVisualStyleBackColor = true;
            // 
            // meterToMileBtn
            // 
            this.meterToMileBtn.AutoSize = true;
            this.meterToMileBtn.Location = new System.Drawing.Point(452, 193);
            this.meterToMileBtn.Name = "meterToMileBtn";
            this.meterToMileBtn.Size = new System.Drawing.Size(104, 20);
            this.meterToMileBtn.TabIndex = 6;
            this.meterToMileBtn.TabStop = true;
            this.meterToMileBtn.Text = "Meter to mile";
            this.meterToMileBtn.UseVisualStyleBackColor = true;
            // 
            // mileToMeterBtn
            // 
            this.mileToMeterBtn.AutoSize = true;
            this.mileToMeterBtn.Location = new System.Drawing.Point(452, 240);
            this.mileToMeterBtn.Name = "mileToMeterBtn";
            this.mileToMeterBtn.Size = new System.Drawing.Size(104, 20);
            this.mileToMeterBtn.TabIndex = 7;
            this.mileToMeterBtn.TabStop = true;
            this.mileToMeterBtn.Text = "Mile to meter";
            this.mileToMeterBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mileToMeterBtn);
            this.Controls.Add(this.meterToMileBtn);
            this.Controls.Add(this.meterToKilometerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton meterToKilometerBtn;
        private System.Windows.Forms.RadioButton meterToMileBtn;
        private System.Windows.Forms.RadioButton mileToMeterBtn;
        private System.Windows.Forms.Button button1;
    }
}


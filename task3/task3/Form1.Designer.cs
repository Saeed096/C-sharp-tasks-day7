namespace task3
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
            this.labsComboBox = new System.Windows.Forms.ComboBox();
            this.singleGoBtn = new System.Windows.Forms.Button();
            this.multipleGoBtn = new System.Windows.Forms.Button();
            this.singleReturnBtn = new System.Windows.Forms.Button();
            this.multipleReturnBtn = new System.Windows.Forms.Button();
            this.TraineesList = new System.Windows.Forms.CheckedListBox();
            this.labTraineesList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainees";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lab : ";
            // 
            // labsComboBox
            // 
            this.labsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labsComboBox.FormattingEnabled = true;
            this.labsComboBox.Location = new System.Drawing.Point(633, 61);
            this.labsComboBox.Name = "labsComboBox";
            this.labsComboBox.Size = new System.Drawing.Size(121, 24);
            this.labsComboBox.TabIndex = 5;
            this.labsComboBox.SelectedIndexChanged += new System.EventHandler(this.labsComboBox_SelectedIndexChanged);
            // 
            // singleGoBtn
            // 
            this.singleGoBtn.Location = new System.Drawing.Point(360, 151);
            this.singleGoBtn.Name = "singleGoBtn";
            this.singleGoBtn.Size = new System.Drawing.Size(58, 23);
            this.singleGoBtn.TabIndex = 6;
            this.singleGoBtn.Text = ">";
            this.singleGoBtn.UseVisualStyleBackColor = true;
            this.singleGoBtn.Click += new System.EventHandler(this.singleGoBtn_Click);
            // 
            // multipleGoBtn
            // 
            this.multipleGoBtn.Location = new System.Drawing.Point(360, 207);
            this.multipleGoBtn.Name = "multipleGoBtn";
            this.multipleGoBtn.Size = new System.Drawing.Size(58, 23);
            this.multipleGoBtn.TabIndex = 7;
            this.multipleGoBtn.Text = ">>";
            this.multipleGoBtn.UseVisualStyleBackColor = true;
            this.multipleGoBtn.Click += new System.EventHandler(this.multipleGoBtn_Click);
            // 
            // singleReturnBtn
            // 
            this.singleReturnBtn.Location = new System.Drawing.Point(360, 258);
            this.singleReturnBtn.Name = "singleReturnBtn";
            this.singleReturnBtn.Size = new System.Drawing.Size(58, 23);
            this.singleReturnBtn.TabIndex = 8;
            this.singleReturnBtn.Text = "<";
            this.singleReturnBtn.UseVisualStyleBackColor = true;
            this.singleReturnBtn.Click += new System.EventHandler(this.singleReturnBtn_Click);
            // 
            // multipleReturnBtn
            // 
            this.multipleReturnBtn.Location = new System.Drawing.Point(360, 321);
            this.multipleReturnBtn.Name = "multipleReturnBtn";
            this.multipleReturnBtn.Size = new System.Drawing.Size(67, 23);
            this.multipleReturnBtn.TabIndex = 9;
            this.multipleReturnBtn.Text = "<<";
            this.multipleReturnBtn.UseVisualStyleBackColor = true;
            this.multipleReturnBtn.Click += new System.EventHandler(this.multipleReturnBtn_Click);
            // 
            // TraineesList
            // 
            this.TraineesList.CheckOnClick = true;
            this.TraineesList.FormattingEnabled = true;
            this.TraineesList.Items.AddRange(new object[] {
            "saeed",
            "ahmed",
            "hany"});
            this.TraineesList.Location = new System.Drawing.Point(34, 126);
            this.TraineesList.Name = "TraineesList";
            this.TraineesList.Size = new System.Drawing.Size(187, 225);
            this.TraineesList.TabIndex = 11;
            // 
            // labTraineesList
            // 
            this.labTraineesList.CheckOnClick = true;
            this.labTraineesList.FormattingEnabled = true;
            this.labTraineesList.Location = new System.Drawing.Point(567, 126);
            this.labTraineesList.Name = "labTraineesList";
            this.labTraineesList.Size = new System.Drawing.Size(187, 225);
            this.labTraineesList.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTraineesList);
            this.Controls.Add(this.TraineesList);
            this.Controls.Add(this.multipleReturnBtn);
            this.Controls.Add(this.singleReturnBtn);
            this.Controls.Add(this.multipleGoBtn);
            this.Controls.Add(this.singleGoBtn);
            this.Controls.Add(this.labsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trainees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox labsComboBox;
        private System.Windows.Forms.Button singleGoBtn;
        private System.Windows.Forms.Button multipleGoBtn;
        private System.Windows.Forms.Button singleReturnBtn;
        private System.Windows.Forms.Button multipleReturnBtn;
        private System.Windows.Forms.CheckedListBox TraineesList;
        private System.Windows.Forms.CheckedListBox labTraineesList;
    }
}


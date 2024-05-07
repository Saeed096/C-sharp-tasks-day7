namespace task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            emailValidationLabel = new Label();
            nameValidationLabel = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            hoppiesValidationLabel = new Label();
            label8 = new Label();
            footballChB = new CheckBox();
            tennisChB = new CheckBox();
            pingChB = new CheckBox();
            button1 = new Button();
            validRegisterationLabel = new Label();
            hoppyValidationLabel = new Label();
            thanksLabel = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(151, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(151, 170);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 86);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 173);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // emailValidationLabel
            // 
            emailValidationLabel.AutoSize = true;
            emailValidationLabel.ForeColor = Color.Brown;
            emailValidationLabel.Location = new Point(326, 177);
            emailValidationLabel.Name = "emailValidationLabel";
            emailValidationLabel.Size = new Size(153, 20);
            emailValidationLabel.TabIndex = 4;
            emailValidationLabel.Text = "email must contain @";
            emailValidationLabel.Visible = false;
            // 
            // nameValidationLabel
            // 
            nameValidationLabel.AutoSize = true;
            nameValidationLabel.ForeColor = Color.Brown;
            nameValidationLabel.Location = new Point(326, 90);
            nameValidationLabel.Name = "nameValidationLabel";
            nameValidationLabel.Size = new Size(231, 20);
            nameValidationLabel.TabIndex = 5;
            nameValidationLabel.Text = "name must contain 5 char at least";
            nameValidationLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 229);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 7;
            label6.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(159, 229);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(339, 229);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // hoppiesValidationLabel
            // 
            hoppiesValidationLabel.AutoSize = true;
            hoppiesValidationLabel.Location = new Point(617, 319);
            hoppiesValidationLabel.Name = "hoppiesValidationLabel";
            hoppiesValidationLabel.Size = new Size(0, 20);
            hoppiesValidationLabel.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 312);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 6;
            label8.Text = "Hoppies";
            // 
            // footballChB
            // 
            footballChB.AutoSize = true;
            footballChB.Location = new Point(153, 315);
            footballChB.Name = "footballChB";
            footballChB.Size = new Size(86, 24);
            footballChB.TabIndex = 10;
            footballChB.Text = "Football";
            footballChB.UseVisualStyleBackColor = true;
            // 
            // tennisChB
            // 
            tennisChB.AutoSize = true;
            tennisChB.Location = new Point(283, 315);
            tennisChB.Name = "tennisChB";
            tennisChB.Size = new Size(72, 24);
            tennisChB.TabIndex = 11;
            tennisChB.Text = "Tennis";
            tennisChB.UseVisualStyleBackColor = true;
            // 
            // pingChB
            // 
            pingChB.AutoSize = true;
            pingChB.Location = new Point(412, 312);
            pingChB.Name = "pingChB";
            pingChB.Size = new Size(93, 24);
            pingChB.TabIndex = 12;
            pingChB.Text = "PingPong";
            pingChB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(261, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // validRegisterationLabel
            // 
            validRegisterationLabel.AutoSize = true;
            validRegisterationLabel.ForeColor = Color.Brown;
            validRegisterationLabel.Location = new Point(276, 410);
            validRegisterationLabel.Name = "validRegisterationLabel";
            validRegisterationLabel.Size = new Size(0, 20);
            validRegisterationLabel.TabIndex = 15;
            validRegisterationLabel.Click += label5_Click;
            // 
            // hoppyValidationLabel
            // 
            hoppyValidationLabel.AutoSize = true;
            hoppyValidationLabel.ForeColor = Color.Brown;
            hoppyValidationLabel.Location = new Point(575, 316);
            hoppyValidationLabel.Name = "hoppyValidationLabel";
            hoppyValidationLabel.Size = new Size(183, 20);
            hoppyValidationLabel.TabIndex = 16;
            hoppyValidationLabel.Text = "choose at least one hoppy";
            hoppyValidationLabel.Visible = false;
            // 
            // thanksLabel
            // 
            thanksLabel.AutoSize = true;
            thanksLabel.ForeColor = Color.LimeGreen;
            thanksLabel.Location = new Point(276, 410);
            thanksLabel.Name = "thanksLabel";
            thanksLabel.Size = new Size(51, 20);
            thanksLabel.TabIndex = 17;
            thanksLabel.Text = "thanks";
            thanksLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thanksLabel);
            Controls.Add(hoppyValidationLabel);
            Controls.Add(validRegisterationLabel);
            Controls.Add(button1);
            Controls.Add(hoppiesValidationLabel);
            Controls.Add(pingChB);
            Controls.Add(tennisChB);
            Controls.Add(footballChB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(nameValidationLabel);
            Controls.Add(emailValidationLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Registeration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Label label1;
        private Label label2;
        private Label emailValidationLabel;
        private Label nameValidationLabel;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label hoppiesValidationLabel;
        private Label label8;
        private CheckBox footballChB;
        private CheckBox tennisChB;
        private CheckBox pingChB;
        private Button button1;
        private Label validRegisterationLabel;
        private Label hoppyValidationLabel;
        private Label thanksLabel;
    }
}

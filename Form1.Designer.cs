namespace CSharp_GiaiPTBac2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblKQ1 = new Label();
            lblKQ2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            lblDT = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(85, 33);
            label2.TabIndex = 1;
            label2.Text = "Số a :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(86, 33);
            label3.TabIndex = 2;
            label3.Text = "Số b :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(83, 33);
            label4.TabIndex = 3;
            label4.Text = "Số c :";
            // 
            // txtA
            // 
            txtA.Location = new Point(112, 79);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 40);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(112, 121);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 40);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(112, 163);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 40);
            txtC.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 79);
            label5.Name = "label5";
            label5.Size = new Size(64, 33);
            label5.TabIndex = 5;
            label5.Text = "X1 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 121);
            label6.Name = "label6";
            label6.Size = new Size(64, 33);
            label6.TabIndex = 5;
            label6.Text = "X2 :";
            // 
            // lblKQ1
            // 
            lblKQ1.AutoSize = true;
            lblKQ1.Location = new Point(445, 79);
            lblKQ1.Name = "lblKQ1";
            lblKQ1.Size = new Size(129, 33);
            lblKQ1.TabIndex = 5;
            lblKQ1.Text = "Nghiệm 1";
            // 
            // lblKQ2
            // 
            lblKQ2.AutoSize = true;
            lblKQ2.Location = new Point(445, 121);
            lblKQ2.Name = "lblKQ2";
            lblKQ2.Size = new Size(129, 33);
            lblKQ2.TabIndex = 5;
            lblKQ2.Text = "Nghiệm 2";
            // 
            // button1
            // 
            button1.Location = new Point(12, 209);
            button1.Name = "button1";
            button1.Size = new Size(166, 38);
            button1.TabIndex = 6;
            button1.Text = "Giải PT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(611, 421);
            button2.Name = "button2";
            button2.Size = new Size(113, 38);
            button2.TabIndex = 6;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 163);
            label7.Name = "label7";
            label7.Size = new Size(109, 33);
            label7.TabIndex = 5;
            label7.Text = "Dental :";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Location = new Point(445, 163);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(86, 33);
            lblDT.TabIndex = 5;
            lblDT.Text = "Giá trị";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 471);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDT);
            Controls.Add(lblKQ2);
            Controls.Add(label6);
            Controls.Add(lblKQ1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label5;
        private Label label6;
        private Label lblKQ1;
        private Label lblKQ2;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label lblDT;
    }
}

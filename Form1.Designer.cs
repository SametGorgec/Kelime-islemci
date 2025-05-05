namespace Kelime_işlemci
{
    partial class samet_grgc
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            cbBoyut = new ComboBox();
            Renk = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            Renk.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Yazı fontum";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(121, 3);
            button1.Name = "button1";
            button1.Size = new Size(36, 31);
            button1.TabIndex = 1;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            button2.Location = new Point(247, 3);
            button2.Name = "button2";
            button2.Size = new Size(36, 31);
            button2.TabIndex = 2;
            button2.Text = "A";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.Location = new Point(205, 3);
            button3.Name = "button3";
            button3.Size = new Size(36, 31);
            button3.TabIndex = 3;
            button3.Text = "İ ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(163, 3);
            button4.Name = "button4";
            button4.Size = new Size(36, 31);
            button4.TabIndex = 4;
            button4.Text = "K";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 8);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Yazı boyutum";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(173, 39);
            button5.Name = "button5";
            button5.Size = new Size(52, 29);
            button5.TabIndex = 7;
            button5.TabStop = false;
            button5.Text = "A^";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(231, 40);
            button6.Name = "button6";
            button6.Size = new Size(52, 29);
            button6.TabIndex = 8;
            button6.Text = "Av";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // cbBoyut
            // 
            cbBoyut.FormattingEnabled = true;
            cbBoyut.Location = new Point(289, 41);
            cbBoyut.Name = "cbBoyut";
            cbBoyut.Size = new Size(151, 28);
            cbBoyut.TabIndex = 9;
            cbBoyut.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Renk
            // 
            Renk.BackColor = SystemColors.ButtonFace;
            Renk.Controls.Add(radioButton2);
            Renk.Controls.Add(radioButton3);
            Renk.Controls.Add(radioButton4);
            Renk.Controls.Add(radioButton1);
            Renk.Location = new Point(289, 87);
            Renk.Name = "Renk";
            Renk.Size = new Size(151, 153);
            Renk.TabIndex = 10;
            Renk.TabStop = false;
            Renk.Text = "Renk Paleti";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Yeşil";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 24);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Sarı";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 116);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(57, 24);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "Mor";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mavi";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 87);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(267, 333);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // samet_grgc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(Renk);
            Controls.Add(cbBoyut);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "samet_grgc";
            Text = "Samet_grgc";
            Load += samet_grgc_Load;
            Renk.ResumeLayout(false);
            Renk.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private ComboBox cbBoyut;
        private GroupBox Renk;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
    }
}

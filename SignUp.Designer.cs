namespace ITEC_MANAGEMENT
{
    partial class SignUp
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            PASSWORD = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, -92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._7775db217786049_Y3JvcCwxODA3LDE0MTQsOTMsMA;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(667, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 83);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(825, 77);
            label1.Margin = new Padding(3, 30, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 42);
            label1.TabIndex = 3;
            label1.Text = "SIGN - UP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PASSWORD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(825, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 367);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "ITECH Manager" });
            comboBox1.Location = new Point(31, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 23);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(30, 229);
            label4.Name = "label4";
            label4.Size = new Size(239, 33);
            label4.TabIndex = 7;
            label4.Text = "ROLE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 169);
            label3.Name = "label3";
            label3.Size = new Size(239, 24);
            label3.TabIndex = 5;
            label3.Text = "EMAIL";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.istockphoto_1031925314_612x612;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(163, 325);
            button1.Name = "button1";
            button1.Size = new Size(43, 36);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PASSWORD
            // 
            PASSWORD.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PASSWORD.ForeColor = SystemColors.ButtonHighlight;
            PASSWORD.Location = new Point(32, 105);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(239, 24);
            PASSWORD.TabIndex = 3;
            PASSWORD.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 29);
            label2.Name = "label2";
            label2.Size = new Size(208, 37);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 134);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 0;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Vector_2640;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1277, 618);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Label PASSWORD;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private ComboBox comboBox1;
    }
}
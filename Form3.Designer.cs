namespace ITEC_MANAGEMENT
{
    partial class Form3
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Event_id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ADD = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            Column9 = new DataGridViewButtonColumn();
            pictureBox3 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SEARCH = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(381, 30);
            label1.Name = "label1";
            label1.Size = new Size(553, 87);
            label1.TabIndex = 0;
            label1.Text = "ITECH EVENTS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources._360_F_414136392_1HxAobZWtcgc5yuhUL05JNUwIQc9Ab41_removebg_preview;
            pictureBox1.Location = new Point(908, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources._360_F_414136392_1HxAobZWtcgc5yuhUL05JNUwIQc9Ab41_removebg_preview;
            pictureBox2.Location = new Point(217, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 70);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 23);
            textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Event_id, Column1, Column4, Column5, Column2, Column3, Column6, ADD, Column7, Column9 });
            dataGridView1.Location = new Point(129, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1041, 325);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Event_id
            // 
            Event_id.HeaderText = "Event_id";
            Event_id.Name = "Event_id";
            // 
            // Column1
            // 
            Column1.HeaderText = "Event Name";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Event_Time";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Event_Date";
            Column5.Name = "Column5";
            // 
            // Column2
            // 
            Column2.HeaderText = "Venue_id";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Venue_Name";
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.HeaderText = "Description";
            Column6.Name = "Column6";
            // 
            // ADD
            // 
            ADD.FlatStyle = FlatStyle.System;
            ADD.HeaderText = "ADD";
            ADD.Name = "ADD";
            // 
            // Column7
            // 
            Column7.HeaderText = "DELETE";
            Column7.Name = "Column7";
            // 
            // Column9
            // 
            Column9.HeaderText = "UPDATE";
            Column9.Name = "Column9";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.search_icon_2044x2048_psdrpqwp;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(141, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 49);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(0, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(97, 17);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // SEARCH
            // 
            SEARCH.BackColor = Color.Transparent;
            SEARCH.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SEARCH.ForeColor = SystemColors.ButtonHighlight;
            SEARCH.Location = new Point(202, 146);
            SEARCH.Name = "SEARCH";
            SEARCH.Size = new Size(129, 23);
            SEARCH.TabIndex = 7;
            SEARCH.Text = "SEARCH";
            SEARCH.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1145, 47);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 15;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4127298;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1283, 560);
            Controls.Add(button1);
            Controls.Add(SEARCH);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Event_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ADD;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column9;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label SEARCH;
        private Button button1;
    }
}
namespace ITEC_MANAGEMENT
{
    partial class Form4
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
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            SEARCH = new Label();
            dataGridView1 = new DataGridView();
            Event_id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ADD = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            Column9 = new DataGridViewButtonColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(370, 50);
            label1.Name = "label1";
            label1.Size = new Size(663, 55);
            label1.TabIndex = 0;
            label1.Text = "COMMITTE  'N'  MEMBERS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 23);
            textBox1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.search_icon_2044x2048_psdrpqwp;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(143, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 49);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // SEARCH
            // 
            SEARCH.BackColor = Color.Transparent;
            SEARCH.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SEARCH.ForeColor = SystemColors.ButtonHighlight;
            SEARCH.Location = new Point(204, 106);
            SEARCH.Name = "SEARCH";
            SEARCH.Size = new Size(129, 23);
            SEARCH.TabIndex = 8;
            SEARCH.Text = "SEARCH";
            SEARCH.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Event_id, Column1, Column4, Column5, Column2, Column3, Column6, ADD, Column7, Column9 });
            dataGridView1.Location = new Point(122, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1041, 361);
            dataGridView1.TabIndex = 9;
            // 
            // Event_id
            // 
            Event_id.HeaderText = "Member_ID";
            Event_id.Name = "Event_id";
            // 
            // Column1
            // 
            Column1.HeaderText = "Member_Name";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Member's_CNIC";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Committe";
            Column5.Name = "Column5";
            // 
            // Column2
            // 
            Column2.HeaderText = "Committe_Head";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Column3.HeaderText = "Role of Member";
            Column3.Items.AddRange(new object[] { "Student", "Event_Manager" });
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1171, 33);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 14;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.robot_handshake_human_background_futuristic_digital_age;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1287, 563);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(SEARCH);
            Controls.Add(pictureBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private Label SEARCH;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Event_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ADD;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column9;
        private Button button1;
    }
}
namespace ITEC_MANAGEMENT
{
    partial class finance
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
            Column3 = new DataGridViewComboBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ADD = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            Column9 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(498, 57);
            label1.Name = "label1";
            label1.Size = new Size(264, 55);
            label1.TabIndex = 1;
            label1.Text = "FINANCE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 23);
            textBox1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.search_icon_2044x2048_psdrpqwp;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(194, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 49);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // SEARCH
            // 
            SEARCH.BackColor = Color.Transparent;
            SEARCH.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SEARCH.ForeColor = SystemColors.ButtonHighlight;
            SEARCH.Location = new Point(247, 120);
            SEARCH.Name = "SEARCH";
            SEARCH.Size = new Size(129, 23);
            SEARCH.TabIndex = 9;
            SEARCH.Text = "SEARCH";
            SEARCH.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Event_id, Column1, Column4, Column5, Column3, Column6, ADD, Column7, Column9, Column2 });
            dataGridView1.Location = new Point(159, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1043, 385);
            dataGridView1.TabIndex = 10;
            // 
            // Event_id
            // 
            Event_id.HeaderText = "Transaction_ID";
            Event_id.Name = "Event_id";
            // 
            // Column1
            // 
            Column1.HeaderText = "Sender Name";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Sender's Acc.No";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Amount (Rs)";
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Column3.HeaderText = "Transaction Category";
            Column3.Items.AddRange(new object[] { "For Qawali Night", "For Coding Competition", "For Dinner", "For ITEC" });
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
            // Column2
            // 
            Column2.HeaderText = "Payment Status";
            Column2.Name = "Column2";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1161, 35);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 13;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            // 
            // finance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.businesswoman_networking_using_digital_devices;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1296, 592);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(SEARCH);
            Controls.Add(pictureBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "finance";
            Text = "finance";
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
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ADD;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
    }
}
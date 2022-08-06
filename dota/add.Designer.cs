
namespace dota
{
    partial class add
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dotaDataSet1 = new dota.dotaDataSet1();
            this.dotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotaTableAdapter = new dota.dotaDataSet1TableAdapters.dotaTableAdapter();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.перваяКомандаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.втораяКомандаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.победаКомандыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаМатчаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоЛучшегоИгрокаDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.состоялсяDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(630, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 60);
            this.button3.TabIndex = 99;
            this.button3.Text = "Сохранить изменения и Выйти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(305, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 60);
            this.button2.TabIndex = 98;
            this.button2.Text = "Добавить матч";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 594);
            this.panel1.TabIndex = 97;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 46);
            this.button1.TabIndex = 88;
            this.button1.Text = "Загрузить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "Лучший игрок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Первая команда";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(21, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 25);
            this.textBox1.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "Состоялся";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "Вторая команда";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(21, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 27);
            this.comboBox1.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Победа команды";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(21, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 25);
            this.textBox2.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Дата матча";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.перваяКомандаDataGridViewTextBoxColumn,
            this.втораяКомандаDataGridViewTextBoxColumn,
            this.победаКомандыDataGridViewTextBoxColumn,
            this.датаМатчаDataGridViewTextBoxColumn,
            this.фотоЛучшегоИгрокаDataGridViewImageColumn,
            this.состоялсяDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.dotaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(305, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 520);
            this.dataGridView1.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(21, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 149);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // dotaDataSet1
            // 
            this.dotaDataSet1.DataSetName = "dotaDataSet1";
            this.dotaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dotaBindingSource
            // 
            this.dotaBindingSource.DataMember = "dota";
            this.dotaBindingSource.DataSource = this.dotaDataSet1;
            // 
            // dotaTableAdapter
            // 
            this.dotaTableAdapter.ClearBeforeFill = true;
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "GameID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "GameID";
            this.gameIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            this.gameIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // перваяКомандаDataGridViewTextBoxColumn
            // 
            this.перваяКомандаDataGridViewTextBoxColumn.DataPropertyName = "Первая команда";
            this.перваяКомандаDataGridViewTextBoxColumn.HeaderText = "Первая команда";
            this.перваяКомандаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.перваяКомандаDataGridViewTextBoxColumn.Name = "перваяКомандаDataGridViewTextBoxColumn";
            this.перваяКомандаDataGridViewTextBoxColumn.Width = 125;
            // 
            // втораяКомандаDataGridViewTextBoxColumn
            // 
            this.втораяКомандаDataGridViewTextBoxColumn.DataPropertyName = "Вторая команда";
            this.втораяКомандаDataGridViewTextBoxColumn.HeaderText = "Вторая команда";
            this.втораяКомандаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.втораяКомандаDataGridViewTextBoxColumn.Name = "втораяКомандаDataGridViewTextBoxColumn";
            this.втораяКомандаDataGridViewTextBoxColumn.Width = 125;
            // 
            // победаКомандыDataGridViewTextBoxColumn
            // 
            this.победаКомандыDataGridViewTextBoxColumn.DataPropertyName = "Победа команды";
            this.победаКомандыDataGridViewTextBoxColumn.HeaderText = "Победа команды";
            this.победаКомандыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.победаКомандыDataGridViewTextBoxColumn.Name = "победаКомандыDataGridViewTextBoxColumn";
            this.победаКомандыDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаМатчаDataGridViewTextBoxColumn
            // 
            this.датаМатчаDataGridViewTextBoxColumn.DataPropertyName = "Дата матча";
            this.датаМатчаDataGridViewTextBoxColumn.HeaderText = "Дата матча";
            this.датаМатчаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаМатчаDataGridViewTextBoxColumn.Name = "датаМатчаDataGridViewTextBoxColumn";
            this.датаМатчаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фотоЛучшегоИгрокаDataGridViewImageColumn
            // 
            this.фотоЛучшегоИгрокаDataGridViewImageColumn.DataPropertyName = "Фото лучшего игрока";
            this.фотоЛучшегоИгрокаDataGridViewImageColumn.HeaderText = "Фото лучшего игрока";
            this.фотоЛучшегоИгрокаDataGridViewImageColumn.MinimumWidth = 6;
            this.фотоЛучшегоИгрокаDataGridViewImageColumn.Name = "фотоЛучшегоИгрокаDataGridViewImageColumn";
            this.фотоЛучшегоИгрокаDataGridViewImageColumn.Width = 125;
            // 
            // состоялсяDataGridViewCheckBoxColumn
            // 
            this.состоялсяDataGridViewCheckBoxColumn.DataPropertyName = "Состоялся";
            this.состоялсяDataGridViewCheckBoxColumn.HeaderText = "Состоялся";
            this.состоялсяDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.состоялсяDataGridViewCheckBoxColumn.Name = "состоялсяDataGridViewCheckBoxColumn";
            this.состоялсяDataGridViewCheckBoxColumn.Width = 125;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.comboBox2.Location = new System.Drawing.Point(23, 302);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 27);
            this.comboBox2.TabIndex = 94;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 615);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add";
            this.Load += new System.EventHandler(this.add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dotaDataSet1 dotaDataSet1;
        private System.Windows.Forms.BindingSource dotaBindingSource;
        private dotaDataSet1TableAdapters.dotaTableAdapter dotaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn перваяКомандаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn втораяКомандаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn победаКомандыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаМатчаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоЛучшегоИгрокаDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn состоялсяDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
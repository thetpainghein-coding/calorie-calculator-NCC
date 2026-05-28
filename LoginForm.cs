namespace ddocpTPH
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTarCal = new System.Windows.Forms.Label();
            this.gboxChgCal = new System.Windows.Forms.GroupBox();
            this.btnChgCancel = new System.Windows.Forms.Button();
            this.btnChgCal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChgCal = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxActivity = new System.Windows.Forms.ComboBox();
            this.lblCurrentCal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateNum = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalCurCal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxChgCal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddRecord.Location = new System.Drawing.Point(417, 190);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(98, 40);
            this.btnAddRecord.TabIndex = 6;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(876, 668);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 48);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(799, 244);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // lblTarCal
            // 
            this.lblTarCal.AutoSize = true;
            this.lblTarCal.BackColor = System.Drawing.Color.Transparent;
            this.lblTarCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarCal.Location = new System.Drawing.Point(817, 163);
            this.lblTarCal.Name = "lblTarCal";
            this.lblTarCal.Size = new System.Drawing.Size(135, 22);
            this.lblTarCal.TabIndex = 6;
            this.lblTarCal.Text = "Target Calorie: ";
            // 
            // gboxChgCal
            // 
            this.gboxChgCal.BackColor = System.Drawing.Color.Transparent;
            this.gboxChgCal.Controls.Add(this.btnChgCancel);
            this.gboxChgCal.Controls.Add(this.btnChgCal);
            this.gboxChgCal.Controls.Add(this.label2);
            this.gboxChgCal.Controls.Add(this.txtChgCal);
            this.gboxChgCal.Location = new System.Drawing.Point(812, 196);
            this.gboxChgCal.Name = "gboxChgCal";
            this.gboxChgCal.Size = new System.Drawing.Size(210, 178);
            this.gboxChgCal.TabIndex = 7;
            this.gboxChgCal.TabStop = false;
            this.gboxChgCal.Text = "Change Daily Target Calorie";
            // 
            // btnChgCancel
            // 
            this.btnChgCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChgCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChgCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChgCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChgCancel.Location = new System.Drawing.Point(18, 114);
            this.btnChgCancel.Name = "btnChgCancel";
            this.btnChgCancel.Size = new System.Drawing.Size(82, 35);
            this.btnChgCancel.TabIndex = 10;
            this.btnChgCancel.Text = "Cancel";
            this.btnChgCancel.UseVisualStyleBackColor = false;
            this.btnChgCancel.Click += new System.EventHandler(this.btnChgCancel_Click);
            // 
            // btnChgCal
            // 
            this.btnChgCal.BackColor = System.Drawing.Color.LightCoral;
            this.btnChgCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChgCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChgCal.Location = new System.Drawing.Point(116, 114);
            this.btnChgCal.Name = "btnChgCal";
            this.btnChgCal.Size = new System.Drawing.Size(82, 35);
            this.btnChgCal.TabIndex = 9;
            this.btnChgCal.Text = "Change";
            this.btnChgCal.UseVisualStyleBackColor = false;
            this.btnChgCal.Click += new System.EventHandler(this.btnChgCal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Calorie";
            // 
            // txtChgCal
            // 
            this.txtChgCal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChgCal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChgCal.Location = new System.Drawing.Point(106, 54);
            this.txtChgCal.Name = "txtChgCal";
            this.txtChgCal.Size = new System.Drawing.Size(90, 21);
            this.txtChgCal.TabIndex = 9;
            this.txtChgCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChgCal_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(861, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 48);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Tan;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(536, 190);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCyan;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(652, 190);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric1.Location = new System.Drawing.Point(52, 106);
            this.lblMetric1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMetric1.Size = new System.Drawing.Size(73, 22);
            this.lblMetric1.TabIndex = 11;
            this.lblMetric1.Text = "Metric 1";
            this.lblMetric1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMetric1
            // 
            this.txtMetric1.BackColor = System.Drawing.Color.Snow;
            this.txtMetric1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetric1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetric1.Location = new System.Drawing.Point(272, 110);
            this.txtMetric1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(89, 23);
            this.txtMetric1.TabIndex = 4;
            this.txtMetric1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetric1_KeyPress);
            // 
            // txtMetric2
            // 
            this.txtMetric2.BackColor = System.Drawing.Color.Snow;
            this.txtMetric2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetric2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetric2.Location = new System.Drawing.Point(272, 159);
            this.txtMetric2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(89, 23);
            this.txtMetric2.TabIndex = 5;
            this.txtMetric2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetric2_KeyPress);
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric2.Location = new System.Drawing.Point(52, 155);
            this.lblMetric2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(73, 22);
            this.lblMetric2.TabIndex = 13;
            this.lblMetric2.Text = "Metric 2";
            this.lblMetric2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMetric3
            // 
            this.txtMetric3.BackColor = System.Drawing.Color.Snow;
            this.txtMetric3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetric3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetric3.Location = new System.Drawing.Point(272, 206);
            this.txtMetric3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(89, 23);
            this.txtMetric3.TabIndex = 5;
            this.txtMetric3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetric3_KeyPress);
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric3.Location = new System.Drawing.Point(52, 202);
            this.lblMetric3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(73, 22);
            this.lblMetric3.TabIndex = 15;
            this.lblMetric3.Text = "Metric 3";
            this.lblMetric3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboxActivity);
            this.groupBox1.Controls.Add(this.lblCurrentCal);
            this.groupBox1.Controls.Add(this.txtMetric3);
            this.groupBox1.Controls.Add(this.lblMetric3);
            this.groupBox1.Controls.Add(this.txtMetric2);
            this.groupBox1.Controls.Add(this.lblMetric2);
            this.groupBox1.Controls.Add(this.txtMetric1);
            this.groupBox1.Controls.Add(this.lblMetric1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAddRecord);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(773, 251);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(581, 39);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 1, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 30);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select Activity:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxActivity
            // 
            this.cboxActivity.DisplayMember = "--Select-- ";
            this.cboxActivity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxActivity.FormattingEnabled = true;
            this.cboxActivity.Location = new System.Drawing.Point(150, 34);
            this.cboxActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxActivity.Name = "cboxActivity";
            this.cboxActivity.Size = new System.Drawing.Size(216, 28);
            this.cboxActivity.TabIndex = 1;
            this.cboxActivity.Text = " Select one";
            this.cboxActivity.SelectedIndexChanged += new System.EventHandler(this.cboxActivity_SelectedIndexChanged_1);
            // 
            // lblCurrentCal
            // 
            this.lblCurrentCal.AutoSize = true;
            this.lblCurrentCal.Location = new System.Drawing.Point(414, 106);
            this.lblCurrentCal.Name = "lblCurrentCal";
            this.lblCurrentCal.Size = new System.Drawing.Size(206, 25);
            this.lblCurrentCal.TabIndex = 21;
            this.lblCurrentCal.Text = "Current Calorie Burnt: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(861, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 48);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date:";
            // 
            // lblDateNum
            // 
            this.lblDateNum.AutoSize = true;
            this.lblDateNum.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNum.Location = new System.Drawing.Point(110, 76);
            this.lblDateNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNum.Name = "lblDateNum";
            this.lblDateNum.Size = new System.Drawing.Size(81, 25);
            this.lblDateNum.TabIndex = 20;
            this.lblDateNum.Text = "Number";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Location = new System.Drawing.Point(41, 668);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(43, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(175, 26);
            this.lblWelcome.TabIndex = 23;
            this.lblWelcome.Text = "Welcome, Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(972, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTotalCurCal
            // 
            this.lblTotalCurCal.AutoSize = true;
            this.lblTotalCurCal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCurCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCurCal.Location = new System.Drawing.Point(817, 123);
            this.lblTotalCurCal.Name = "lblTotalCurCal";
            this.lblTotalCurCal.Size = new System.Drawing.Size(118, 22);
            this.lblTotalCurCal.TabIndex = 25;
            this.lblTotalCurCal.Text = "Total Calorie:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(23, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 275);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Records of Activity Name";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Location = new System.Drawing.Point(974, 65);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(47, 20);
            this.lblProfile.TabIndex = 27;
            this.lblProfile.Text = "Profile";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 744);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotalCurCal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDateNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxChgCal);
            this.Controls.Add(this.lblTarCal);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1069, 800);
            this.Name = "HomeForm";
            this.Text = "Fitness Tracker";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxChgCal.ResumeLayout(false);
            this.gboxChgCal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTarCal;
        private System.Windows.Forms.GroupBox gboxChgCal;
        private System.Windows.Forms.TextBox txtChgCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChgCal;
        private System.Windows.Forms.Button btnChgCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxActivity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDateNum;
        private System.Windows.Forms.Label lblCurrentCal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalCurCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProfile;
    }
}
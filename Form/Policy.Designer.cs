﻿namespace OOAD_Form
{
    partial class Policy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtResidentID = new TextBox();
            txtResidentName = new TextBox();
            dateCreate = new DateTimePicker();
            dateUpdate = new DateTimePicker();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            titleLabel = new Label();
            inputGroup = new GroupBox();
            buttonPanel = new Panel();
            inputGroup.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();

            // Title Label
            titleLabel.BackColor = Color.FromArgb(51, 122, 183);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(10, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(780, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Policy Management";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Labels
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Policy ID:";

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 1;
            label2.Text = "Policy Name:";

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 2;
            label3.Text = "Description:";

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 200);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 3;
            label4.Text = "Create Date:";

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(20, 240);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 4;
            label5.Text = "Update Date:";

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(20, 280);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 5;
            label6.Text = "Resident ID:";

            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(20, 320);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 6;
            label7.Text = "Resident Name:";

            // Input Controls
            txtID.BackColor = Color.FromArgb(240, 240, 240);
            txtID.Location = new Point(140, 38);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(180, 30);
            txtID.TabIndex = 7;

            txtName.Location = new Point(140, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 30);
            txtName.TabIndex = 8;

            txtDesc.Location = new Point(140, 118);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(180, 70);
            txtDesc.TabIndex = 9;

            dateCreate.Format = DateTimePickerFormat.Short;
            dateCreate.Location = new Point(140, 198);
            dateCreate.Name = "dateCreate";
            dateCreate.Size = new Size(180, 30);
            dateCreate.TabIndex = 10;
            dateCreate.Enabled = false;

            dateUpdate.Format = DateTimePickerFormat.Short;
            dateUpdate.Location = new Point(140, 238);
            dateUpdate.Name = "dateUpdate";
            dateUpdate.Size = new Size(180, 30);
            dateUpdate.TabIndex = 11;
            dateUpdate.Enabled = false;

            txtResidentID.Location = new Point(140, 278);
            txtResidentID.Name = "txtResidentID";
            txtResidentID.Size = new Size(180, 30);
            txtResidentID.TabIndex = 12;

            txtResidentName.BackColor = Color.FromArgb(240, 240, 240);
            txtResidentName.Location = new Point(140, 318);
            txtResidentName.Name = "txtResidentName";
            txtResidentName.ReadOnly = true;
            txtResidentName.Size = new Size(180, 30);
            txtResidentName.TabIndex = 13;

            // Buttons
            btnInsert.BackColor = Color.FromArgb(92, 184, 92);
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(0, 0);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(95, 35);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;

            btnUpdate.BackColor = Color.FromArgb(240, 173, 78);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(105, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;

            btnDelete.BackColor = Color.FromArgb(217, 83, 79);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(210, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;

            // Button Panel
            buttonPanel.Controls.Add(btnInsert);
            buttonPanel.Controls.Add(btnUpdate);
            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Location = new Point(20, 370);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(310, 50);
            buttonPanel.TabIndex = 14;

            // ListView
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(390, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(380, 440);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Description", 150);
            listView1.Columns.Add("Create Date", 100);
            listView1.Columns.Add("Update Date", 100);
            listView1.Columns.Add("Resident ID", 80);

            // Input Group
            inputGroup.BackColor = Color.White;
            inputGroup.Controls.Add(label1);
            inputGroup.Controls.Add(label2);
            inputGroup.Controls.Add(label3);
            inputGroup.Controls.Add(label4);
            inputGroup.Controls.Add(label5);
            inputGroup.Controls.Add(label6);
            inputGroup.Controls.Add(label7);
            inputGroup.Controls.Add(txtID);
            inputGroup.Controls.Add(txtName);
            inputGroup.Controls.Add(txtDesc);
            inputGroup.Controls.Add(dateCreate);
            inputGroup.Controls.Add(dateUpdate);
            inputGroup.Controls.Add(txtResidentID);
            inputGroup.Controls.Add(txtResidentName);
            inputGroup.Controls.Add(buttonPanel);
            inputGroup.Font = new Font("Segoe UI", 10F);
            inputGroup.Location = new Point(20, 60);
            inputGroup.Name = "inputGroup";
            inputGroup.Size = new Size(350, 440);
            inputGroup.TabIndex = 1;
            inputGroup.TabStop = false;
            inputGroup.Text = "Policy Details";

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 520);
            Controls.Add(titleLabel);
            Controls.Add(inputGroup);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 520);
            Name = "Policy";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Policy Management";
            inputGroup.ResumeLayout(false);
            inputGroup.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListView listView1;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDesc;
        private DateTimePicker dateCreate;
        private DateTimePicker dateUpdate;
        private TextBox txtResidentID;
        private TextBox txtResidentName;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label titleLabel;
        private GroupBox inputGroup;
        private Panel buttonPanel;
    }
}

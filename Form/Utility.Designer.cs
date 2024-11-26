namespace OOAD_Form
{
    partial class Utility
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
            listView1 = new ListView();
            txtID = new TextBox();
            txtCost = new TextBox();
            cboUtilityType = new ComboBox();
            txtRoomID = new TextBox();
            dateUsage = new DateTimePicker();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            titleLabel = new Label();
            inputGroup = new GroupBox();
            buttonPanel = new Panel();
            inputGroup.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Utility ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 1;
            label2.Text = "Utility Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 2;
            label3.Text = "Cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 160);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 3;
            label4.Text = "Usage Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(20, 200);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 4;
            label5.Text = "Room ID:";
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(390, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(380, 360);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Type", 80);
            listView1.Columns.Add("Cost", 80);
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("Room", 70);
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(240, 240, 240);
            txtID.Location = new Point(140, 38);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(180, 30);
            txtID.TabIndex = 5;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(140, 118);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(180, 30);
            txtCost.TabIndex = 7;
            // 
            // cboUtilityType
            // 
            cboUtilityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUtilityType.Location = new Point(140, 78);
            cboUtilityType.Name = "cboUtilityType";
            cboUtilityType.Size = new Size(180, 31);
            cboUtilityType.TabIndex = 6;
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(140, 198);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(180, 30);
            txtRoomID.TabIndex = 9;
            // 
            // dateUsage
            // 
            dateUsage.Format = DateTimePickerFormat.Short;
            dateUsage.Location = new Point(140, 158);
            dateUsage.Name = "dateUsage";
            dateUsage.Size = new Size(180, 30);
            dateUsage.TabIndex = 8;
            // 
            // btnInsert
            // 
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
            // 
            // btnUpdate
            // 
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
            // 
            // btnDelete
            // 
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
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(51, 122, 183);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(10, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(780, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Utility Management";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputGroup
            // 
            inputGroup.BackColor = Color.White;
            inputGroup.Controls.Add(label1);
            inputGroup.Controls.Add(label2);
            inputGroup.Controls.Add(label3);
            inputGroup.Controls.Add(label4);
            inputGroup.Controls.Add(label5);
            inputGroup.Controls.Add(txtID);
            inputGroup.Controls.Add(cboUtilityType);
            inputGroup.Controls.Add(txtCost);
            inputGroup.Controls.Add(dateUsage);
            inputGroup.Controls.Add(txtRoomID);
            inputGroup.Controls.Add(buttonPanel);
            inputGroup.Font = new Font("Segoe UI", 10F);
            inputGroup.Location = new Point(20, 60);
            inputGroup.Name = "inputGroup";
            inputGroup.Size = new Size(350, 360);
            inputGroup.TabIndex = 1;
            inputGroup.TabStop = false;
            inputGroup.Text = "Utility Details";
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(btnInsert);
            buttonPanel.Controls.Add(btnUpdate);
            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Location = new Point(20, 280);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(310, 50);
            buttonPanel.TabIndex = 10;
            // 
            // Utility
            // 
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 450);
            Controls.Add(titleLabel);
            Controls.Add(inputGroup);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 450);
            Name = "Utility";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utility Management";
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
        private ListView listView1;
        private TextBox txtID;
        private ComboBox cboUtilityType;
        private TextBox txtCost;
        private DateTimePicker dateUsage;
        private TextBox txtRoomID;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label titleLabel;
        private GroupBox inputGroup;
        private Panel buttonPanel;
    }
} 
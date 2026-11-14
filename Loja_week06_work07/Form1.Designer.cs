namespace Loja_week06_work07
{
    partial class Form_EquipmentManager
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblHeader = new Label();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgv = new DataGridView();
            colAssetTag = new DataGridViewTextBoxColumn();
            colEquipment = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlStatus = new Panel();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            btnUpdateStatus = new Button();
            grpAdd = new GroupBox();
            lblAssetTag = new Label();
            txtAssetTag = new TextBox();
            lblEquipment = new Label();
            txtEquipment = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnAdd = new Button();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnlStatus.SuspendLayout();
            grpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.DimGray;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(900, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "  Equipment Manager";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            lblHeader.Click += lblHeader_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnShowAll);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 50);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(900, 50);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.Location = new Point(15, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(65, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            lblSearch.Click += lblSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(75, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Asset tag or equipment name...";
            txtSearch.Size = new Size(480, 29);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.DimGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(570, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowAll.BackColor = Color.Transparent;
            btnShowAll.Location = new Point(715, 10);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(130, 30);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colAssetTag, colEquipment, colCategory, colLocation, colStatus });
            dgv.Dock = DockStyle.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(0, 100);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(900, 340);
            dgv.TabIndex = 2;
            // 
            // colAssetTag
            // 
            colAssetTag.HeaderText = "Asset Tag";
            colAssetTag.MinimumWidth = 6;
            colAssetTag.Name = "colAssetTag";
            colAssetTag.ReadOnly = true;
            // 
            // colEquipment
            // 
            colEquipment.HeaderText = "Equipment";
            colEquipment.MinimumWidth = 6;
            colEquipment.Name = "colEquipment";
            colEquipment.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Controls.Add(cboStatus);
            pnlStatus.Controls.Add(btnUpdateStatus);
            pnlStatus.Dock = DockStyle.Bottom;
            pnlStatus.Location = new Point(0, 570);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(900, 50);
            pnlStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatus.Location = new Point(15, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(167, 21);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Selected item status:";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Checked Out", "Under Maintenance" });
            cboStatus.Location = new Point(175, 11);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(230, 29);
            cboStatus.TabIndex = 1;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.Gray;
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(420, 9);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(140, 30);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(lblAssetTag);
            grpAdd.Controls.Add(txtAssetTag);
            grpAdd.Controls.Add(lblEquipment);
            grpAdd.Controls.Add(txtEquipment);
            grpAdd.Controls.Add(lblCategory);
            grpAdd.Controls.Add(txtCategory);
            grpAdd.Controls.Add(lblLocation);
            grpAdd.Controls.Add(txtLocation);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Dock = DockStyle.Bottom;
            grpAdd.Location = new Point(0, 440);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(900, 130);
            grpAdd.TabIndex = 4;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add Equipment";
            // 
            // lblAssetTag
            // 
            lblAssetTag.AutoSize = true;
            lblAssetTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAssetTag.Location = new Point(15, 28);
            lblAssetTag.Name = "lblAssetTag";
            lblAssetTag.Size = new Size(85, 21);
            lblAssetTag.TabIndex = 0;
            lblAssetTag.Text = "Asset Tag:";
            // 
            // txtAssetTag
            // 
            txtAssetTag.Location = new Point(15, 50);
            txtAssetTag.Name = "txtAssetTag";
            txtAssetTag.Size = new Size(195, 29);
            txtAssetTag.TabIndex = 1;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEquipment.Location = new Point(230, 28);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(98, 21);
            lblEquipment.TabIndex = 2;
            lblEquipment.Text = "Equipment:";
            // 
            // txtEquipment
            // 
            txtEquipment.Location = new Point(230, 50);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.Size = new Size(195, 29);
            txtEquipment.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategory.Location = new Point(445, 28);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 21);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(445, 50);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(195, 29);
            txtCategory.TabIndex = 5;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLocation.Location = new Point(660, 28);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(80, 21);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(660, 50);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(195, 29);
            txtLocation.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(685, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 32);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+ Add Equipment";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form_EquipmentManager
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 620);
            Controls.Add(dgv);
            Controls.Add(grpAdd);
            Controls.Add(pnlStatus);
            Controls.Add(pnlSearch);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "Form_EquipmentManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment Manager";
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colAssetTag;
        private DataGridViewTextBoxColumn colEquipment;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colStatus;
        private Panel pnlStatus;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Button btnUpdateStatus;
        private GroupBox grpAdd;
        private Label lblAssetTag;
        private TextBox txtAssetTag;
        private Label lblEquipment;
        private TextBox txtEquipment;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblLocation;
        private TextBox txtLocation;
        private Button btnAdd;
    }
}

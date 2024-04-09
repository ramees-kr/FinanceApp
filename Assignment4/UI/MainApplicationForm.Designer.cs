namespace Assignment4.UI
{
    partial class MainApplicationForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewTransactionHistory = new DataGridView();
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            btnAddTransaction = new ToolStripMenuItem();
            btnUpdateTransaction = new ToolStripMenuItem();
            btnDeleteTransaction = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            lblCurrentBalance = new TextBox();
            lblAccountType = new TextBox();
            label2 = new Label();
            label1 = new Label();
            viewToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTransactionHistory
            // 
            dataGridViewTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransactionHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionHistory.Dock = DockStyle.Fill;
            dataGridViewTransactionHistory.Location = new Point(4, 31);
            dataGridViewTransactionHistory.Margin = new Padding(4);
            dataGridViewTransactionHistory.Name = "dataGridViewTransactionHistory";
            dataGridViewTransactionHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTransactionHistory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTransactionHistory.RowTemplate.Height = 29;
            dataGridViewTransactionHistory.Size = new Size(1297, 522);
            dataGridViewTransactionHistory.TabIndex = 0;
            dataGridViewTransactionHistory.SelectionChanged += dataGridViewTransactionHistory_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewTransactionHistory);
            groupBox1.Location = new Point(30, 205);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1305, 557);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, transactionToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1352, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnAddTransaction, btnUpdateTransaction, btnDeleteTransaction });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(98, 24);
            transactionToolStripMenuItem.Text = "Transaction";
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(141, 26);
            btnAddTransaction.Text = "&Add";
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnUpdateTransaction
            // 
            btnUpdateTransaction.Enabled = false;
            btnUpdateTransaction.Name = "btnUpdateTransaction";
            btnUpdateTransaction.Size = new Size(141, 26);
            btnUpdateTransaction.Text = "&Update";
            btnUpdateTransaction.Click += btnUpdateTransaction_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Enabled = false;
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(141, 26);
            btnDeleteTransaction.Text = "&Delete";
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "&Account";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCurrentBalance);
            groupBox2.Controls.Add(lblAccountType);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(30, 62);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1301, 120);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.Location = new Point(800, 49);
            lblCurrentBalance.Margin = new Padding(4);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.ReadOnly = true;
            lblCurrentBalance.Size = new Size(356, 34);
            lblCurrentBalance.TabIndex = 3;
            // 
            // lblAccountType
            // 
            lblAccountType.Location = new Point(205, 49);
            lblAccountType.Margin = new Padding(4);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.ReadOnly = true;
            lblAccountType.Size = new Size(356, 34);
            lblAccountType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(628, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 1;
            label2.Text = "Current Balance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 0;
            label1.Text = "Account Type";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(224, 26);
            viewToolStripMenuItem.Text = "&View Summary";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // MainApplicationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 794);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MainApplicationForm";
            Text = "Main Application Form";
            Load += MainApplicationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).EndInit();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTransactionHistory;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem btnUpdateTransaction;
        private ToolStripMenuItem btnDeleteTransaction;
        private GroupBox groupBox2;
        private TextBox lblCurrentBalance;
        private TextBox lblAccountType;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem btnAddTransaction;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}
namespace Assignment4.UI
{
    partial class AddTransactionForm
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
            labelAccountId = new Label();
            dateTimePickerTransactionDate = new DateTimePicker();
            labelTransactionDate = new Label();
            labelAmount = new Label();
            textBoxAccountID = new TextBox();
            labelDescription = new Label();
            textBoxAmount = new TextBox();
            textBoxDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelAccountId
            // 
            labelAccountId.AutoSize = true;
            labelAccountId.Location = new Point(49, 43);
            labelAccountId.Margin = new Padding(4, 0, 4, 0);
            labelAccountId.Name = "labelAccountId";
            labelAccountId.Size = new Size(106, 28);
            labelAccountId.TabIndex = 1;
            labelAccountId.Text = "Account Id";
            // 
            // dateTimePickerTransactionDate
            // 
            dateTimePickerTransactionDate.Location = new Point(53, 171);
            dateTimePickerTransactionDate.Margin = new Padding(4);
            dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            dateTimePickerTransactionDate.Size = new Size(243, 34);
            dateTimePickerTransactionDate.TabIndex = 2;
            // 
            // labelTransactionDate
            // 
            labelTransactionDate.AutoSize = true;
            labelTransactionDate.Location = new Point(49, 139);
            labelTransactionDate.Margin = new Padding(4, 0, 4, 0);
            labelTransactionDate.Name = "labelTransactionDate";
            labelTransactionDate.Size = new Size(156, 28);
            labelTransactionDate.TabIndex = 3;
            labelTransactionDate.Text = "Transaction Date";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(53, 238);
            labelAmount.Margin = new Padding(4, 0, 4, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(83, 28);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Amount";
            // 
            // textBoxAccountID
            // 
            textBoxAccountID.Location = new Point(53, 75);
            textBoxAccountID.Margin = new Padding(4);
            textBoxAccountID.Name = "textBoxAccountID";
            textBoxAccountID.ReadOnly = true;
            textBoxAccountID.Size = new Size(385, 34);
            textBoxAccountID.TabIndex = 6;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(49, 330);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(112, 28);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Description";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(53, 270);
            textBoxAmount.Margin = new Padding(4);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(385, 34);
            textBoxAmount.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(53, 362);
            textBoxDescription.Margin = new Padding(4);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(385, 34);
            textBoxDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(275, 445);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 49);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(72, 445);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 49);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddTransactionForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(489, 552);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxAmount);
            Controls.Add(labelDescription);
            Controls.Add(textBoxAccountID);
            Controls.Add(labelAmount);
            Controls.Add(labelTransactionDate);
            Controls.Add(dateTimePickerTransactionDate);
            Controls.Add(labelAccountId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddTransactionForm";
            Text = "Add Transaction Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAccountId;
        private DateTimePicker dateTimePickerTransactionDate;
        private Label labelTransactionDate;
        private Label labelAmount;
        private TextBox textBoxAccountID;
        private Label labelDescription;
        private TextBox textBoxAmount;
        private TextBox textBoxDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}
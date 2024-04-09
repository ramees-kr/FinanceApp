namespace Assignment4.UI
{
    partial class UpdateTransactionForm
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
            btnCancel = new Button();
            btnUpdate = new Button();
            textBoxDescription = new TextBox();
            textBoxAmount = new TextBox();
            labelDescription = new Label();
            textBoxTransactionID = new TextBox();
            labelAmount = new Label();
            labelTransactionDate = new Label();
            dateTimePickerTransactionDate = new DateTimePicker();
            labelTransactionID = new Label();
            textBoxAccountID = new TextBox();
            labelAccountID = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(51, 508);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 49);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(254, 508);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 49);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(32, 425);
            textBoxDescription.Margin = new Padding(4);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(385, 34);
            textBoxDescription.TabIndex = 19;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(32, 333);
            textBoxAmount.Margin = new Padding(4);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(385, 34);
            textBoxAmount.TabIndex = 18;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(28, 393);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(112, 28);
            labelDescription.TabIndex = 17;
            labelDescription.Text = "Description";
            // 
            // textBoxTransactionID
            // 
            textBoxTransactionID.Location = new Point(32, 149);
            textBoxTransactionID.Margin = new Padding(4);
            textBoxTransactionID.Name = "textBoxTransactionID";
            textBoxTransactionID.ReadOnly = true;
            textBoxTransactionID.Size = new Size(385, 34);
            textBoxTransactionID.TabIndex = 16;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(32, 301);
            labelAmount.Margin = new Padding(4, 0, 4, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(83, 28);
            labelAmount.TabIndex = 15;
            labelAmount.Text = "Amount";
            // 
            // labelTransactionDate
            // 
            labelTransactionDate.AutoSize = true;
            labelTransactionDate.Location = new Point(28, 202);
            labelTransactionDate.Margin = new Padding(4, 0, 4, 0);
            labelTransactionDate.Name = "labelTransactionDate";
            labelTransactionDate.Size = new Size(156, 28);
            labelTransactionDate.TabIndex = 14;
            labelTransactionDate.Text = "Transaction Date";
            // 
            // dateTimePickerTransactionDate
            // 
            dateTimePickerTransactionDate.Location = new Point(32, 234);
            dateTimePickerTransactionDate.Margin = new Padding(4);
            dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            dateTimePickerTransactionDate.Size = new Size(243, 34);
            dateTimePickerTransactionDate.TabIndex = 13;
            // 
            // labelTransactionID
            // 
            labelTransactionID.AutoSize = true;
            labelTransactionID.Location = new Point(28, 117);
            labelTransactionID.Margin = new Padding(4, 0, 4, 0);
            labelTransactionID.Name = "labelTransactionID";
            labelTransactionID.Size = new Size(134, 28);
            labelTransactionID.TabIndex = 12;
            labelTransactionID.Text = "Transaction ID";
            // 
            // textBoxAccountID
            // 
            textBoxAccountID.Location = new Point(32, 61);
            textBoxAccountID.Margin = new Padding(4);
            textBoxAccountID.Name = "textBoxAccountID";
            textBoxAccountID.ReadOnly = true;
            textBoxAccountID.Size = new Size(385, 34);
            textBoxAccountID.TabIndex = 23;
            // 
            // labelAccountID
            // 
            labelAccountID.AutoSize = true;
            labelAccountID.Location = new Point(32, 29);
            labelAccountID.Margin = new Padding(4, 0, 4, 0);
            labelAccountID.Name = "labelAccountID";
            labelAccountID.Size = new Size(106, 28);
            labelAccountID.TabIndex = 22;
            labelAccountID.Text = "Account Id";
            // 
            // UpdateTransactionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 601);
            Controls.Add(textBoxAccountID);
            Controls.Add(labelAccountID);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxAmount);
            Controls.Add(labelDescription);
            Controls.Add(textBoxTransactionID);
            Controls.Add(labelAmount);
            Controls.Add(labelTransactionDate);
            Controls.Add(dateTimePickerTransactionDate);
            Controls.Add(labelTransactionID);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UpdateTransactionForm";
            Text = "Update Transaction Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private TextBox textBoxDescription;
        private TextBox textBoxAmount;
        private Label labelDescription;
        private TextBox textBoxTransactionID;
        private Label labelAmount;
        private Label labelTransactionDate;
        private DateTimePicker dateTimePickerTransactionDate;
        private Label labelTransactionID;
        private TextBox textBoxAccountID;
        private Label labelAccountID;
    }
}
namespace Robin
{
    partial class ReviewForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridReview = new DataGridView();
            cbRewiewGridColumn = new DataGridViewCheckBoxColumn();
            tbReviewGridColumn = new DataGridViewTextBoxColumn();
            lblReviewMessage = new Label();
            btnReviewContinue = new Button();
            btnReviewCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridReview).BeginInit();
            SuspendLayout();
            // 
            // dataGridReview
            // 
            dataGridReview.AllowUserToAddRows = false;
            dataGridReview.AllowUserToDeleteRows = false;
            dataGridReview.AllowUserToResizeColumns = false;
            dataGridReview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridReview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReview.Columns.AddRange(new DataGridViewColumn[] { cbRewiewGridColumn, tbReviewGridColumn });
            dataGridReview.GridColor = SystemColors.ActiveBorder;
            dataGridReview.Location = new Point(34, 80);
            dataGridReview.Margin = new Padding(3, 4, 3, 4);
            dataGridReview.Name = "dataGridReview";
            dataGridReview.Size = new Size(1325, 693);
            dataGridReview.TabIndex = 0;
            // 
            // cbRewiewGridColumn
            // 
            cbRewiewGridColumn.HeaderText = "";
            cbRewiewGridColumn.Name = "cbRewiewGridColumn";
            // 
            // tbReviewGridColumn
            // 
            tbReviewGridColumn.HeaderText = "Scripts";
            tbReviewGridColumn.Name = "tbReviewGridColumn";
            // 
            // lblReviewMessage
            // 
            lblReviewMessage.AutoSize = true;
            lblReviewMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReviewMessage.Location = new Point(34, 32);
            lblReviewMessage.Name = "lblReviewMessage";
            lblReviewMessage.Size = new Size(280, 20);
            lblReviewMessage.TabIndex = 1;
            lblReviewMessage.Text = "Please Review following Scripts carefully:";
            // 
            // btnReviewContinue
            // 
            btnReviewContinue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReviewContinue.Location = new Point(1113, 821);
            btnReviewContinue.Margin = new Padding(3, 4, 3, 4);
            btnReviewContinue.Name = "btnReviewContinue";
            btnReviewContinue.Size = new Size(114, 43);
            btnReviewContinue.TabIndex = 2;
            btnReviewContinue.Text = "Continue";
            btnReviewContinue.UseVisualStyleBackColor = true;
            btnReviewContinue.Click += btnReviewContinue_Click;
            // 
            // btnReviewCancel
            // 
            btnReviewCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReviewCancel.Location = new Point(1245, 821);
            btnReviewCancel.Margin = new Padding(3, 4, 3, 4);
            btnReviewCancel.Name = "btnReviewCancel";
            btnReviewCancel.Size = new Size(114, 43);
            btnReviewCancel.TabIndex = 3;
            btnReviewCancel.Text = "Cancel";
            btnReviewCancel.UseVisualStyleBackColor = true;
            btnReviewCancel.Click += btnReviewCancel_Click;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 895);
            Controls.Add(btnReviewCancel);
            Controls.Add(btnReviewContinue);
            Controls.Add(lblReviewMessage);
            Controls.Add(dataGridReview);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReviewForm";
            Text = "ReviewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridReview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridReview;
        private DataGridViewCheckBoxColumn cbRewiewGridColumn;
        private DataGridViewTextBoxColumn tbReviewGridColumn;
        private Label lblReviewMessage;
        private Button btnReviewContinue;
        private Button btnReviewCancel;
    }
}
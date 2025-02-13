
namespace Robin
{
    partial class Robin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            InputFileBtn = new Button();
            lblFilePath = new Label();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tbOutputConsole = new RichTextBox();
            grpBoxText2Speech = new GroupBox();
            dgScriptsReview = new DataGridView();
            groupBox1 = new GroupBox();
            btnContinue = new Button();
            grpBoxText2Speech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgScriptsReview).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // InputFileBtn
            // 
            InputFileBtn.Location = new Point(21, 56);
            InputFileBtn.Name = "InputFileBtn";
            InputFileBtn.Size = new Size(132, 40);
            InputFileBtn.TabIndex = 0;
            InputFileBtn.Text = "Input File ...";
            InputFileBtn.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(172, 65);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(0, 20);
            lblFilePath.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 100);
            tabPage2.TabIndex = 0;
            // 
            // tbOutputConsole
            // 
            tbOutputConsole.BackColor = Color.Blue;
            tbOutputConsole.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOutputConsole.ForeColor = Color.White;
            tbOutputConsole.Location = new Point(18, 44);
            tbOutputConsole.Name = "tbOutputConsole";
            tbOutputConsole.Size = new Size(1603, 177);
            tbOutputConsole.TabIndex = 0;
            tbOutputConsole.Text = "Please select a input file to continue...";
            // 
            // grpBoxText2Speech
            // 
            grpBoxText2Speech.BackgroundImageLayout = ImageLayout.None;
            grpBoxText2Speech.Controls.Add(tbOutputConsole);
            grpBoxText2Speech.FlatStyle = FlatStyle.Popup;
            grpBoxText2Speech.Location = new Point(21, 717);
            grpBoxText2Speech.Name = "grpBoxText2Speech";
            grpBoxText2Speech.Size = new Size(1646, 241);
            grpBoxText2Speech.TabIndex = 2;
            grpBoxText2Speech.TabStop = false;
            grpBoxText2Speech.Text = "Text to Speech";
            // 
            // dgScriptsReview
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgScriptsReview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgScriptsReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgScriptsReview.DefaultCellStyle = dataGridViewCellStyle2;
            dgScriptsReview.Location = new Point(21, 44);
            dgScriptsReview.Name = "dgScriptsReview";
            dgScriptsReview.Size = new Size(1600, 362);
            dgScriptsReview.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnContinue);
            groupBox1.Controls.Add(dgScriptsReview);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(21, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1646, 587);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Review and Accept";
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnContinue.Location = new Point(18, 530);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(132, 40);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            // 
            // Robin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1690, 984);
            Controls.Add(grpBoxText2Speech);
            Controls.Add(lblFilePath);
            Controls.Add(InputFileBtn);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Robin";
            Text = "Robin";
            Load += Robin_Load;
            grpBoxText2Speech.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgScriptsReview).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button InputFileBtn;
        private Label lblFilePath;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox tbOutputConsole;
        private GroupBox grpBoxText2Speech;
        private DataGridView dgScriptsReview;
        private GroupBox groupBox1;
        private Button btnContinue;
    }
}

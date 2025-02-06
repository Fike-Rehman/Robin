
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
            InputFileBtn = new Button();
            lblFilePath = new Label();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            grpBoxText2Speech = new GroupBox();
            tbOutputConsole = new RichTextBox();
            btnGenerate = new Button();
            grpBoxText2Speech.SuspendLayout();
            SuspendLayout();
            // 
            // InputFileBtn
            // 
            InputFileBtn.Location = new Point(21, 55);
            InputFileBtn.Name = "InputFileBtn";
            InputFileBtn.Size = new Size(132, 39);
            InputFileBtn.TabIndex = 0;
            InputFileBtn.Text = "Input File ...";
            InputFileBtn.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(178, 64);
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
            // grpBoxText2Speech
            // 
            grpBoxText2Speech.BackgroundImageLayout = ImageLayout.None;
            grpBoxText2Speech.Controls.Add(tbOutputConsole);
            grpBoxText2Speech.FlatStyle = FlatStyle.Popup;
            grpBoxText2Speech.Location = new Point(21, 191);
            grpBoxText2Speech.Name = "grpBoxText2Speech";
            grpBoxText2Speech.Size = new Size(1160, 564);
            grpBoxText2Speech.TabIndex = 2;
            grpBoxText2Speech.TabStop = false;
            grpBoxText2Speech.Text = "Text to Speech";
            // 
            // tbOutputConsole
            // 
            tbOutputConsole.BackColor = Color.Blue;
            tbOutputConsole.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOutputConsole.ForeColor = Color.White;
            tbOutputConsole.Location = new Point(21, 48);
            tbOutputConsole.Name = "tbOutputConsole";
            tbOutputConsole.Size = new Size(1115, 487);
            tbOutputConsole.TabIndex = 0;
            tbOutputConsole.Text = "Please select a input file to continue...";
            // 
            // btnGenerate
            // 
            btnGenerate.Enabled = false;
            btnGenerate.Location = new Point(21, 124);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(132, 39);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // Robin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 784);
            Controls.Add(btnGenerate);
            Controls.Add(grpBoxText2Speech);
            Controls.Add(lblFilePath);
            Controls.Add(InputFileBtn);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Robin";
            Text = "Robin";
            Load += Robin_Load;
            grpBoxText2Speech.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button InputFileBtn;
        private Label lblFilePath;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox grpBoxText2Speech;
        private RichTextBox tbOutputConsole;
        private Button btnGenerate;
    }
}

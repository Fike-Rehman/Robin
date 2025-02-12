using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robin
{
    public partial class ReviewForm : Form
    {
        public bool ContinueProcessing { get; set; } = false;

        public ReviewForm(IReadOnlyList<string> scripts)
        {
            InitializeComponent();
            InitializeDataGrid(scripts);
        }

        private void btnReviewContinue_Click(object sender, EventArgs e)
        {
            ContinueProcessing = true;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnReviewCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeDataGrid(IReadOnlyList<string> scripts)
        {
            dataGridReview.Columns.Clear();
            dataGridReview.Rows.Clear();
            dataGridReview.RowHeadersVisible = false;
            dataGridReview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Add Checkbox Column
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Accept",
                Name = "AcceptColumn",
                Width = 50,
                ReadOnly = false // Allows user selection
            };
            dataGridReview.Columns.Add(checkboxColumn);

            // Add Text Column (CSV Data)
            DataGridViewTextBoxColumn scriptsColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Scripts",
                Name = "ScriptsColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            dataGridReview.Columns.Add(scriptsColumn);

            dataGridReview.ColumnCount = 2;
            dataGridReview.Columns[0].Name = "";
            dataGridReview.Columns[1].Name = "Scripts";

            foreach (var script in scripts)
            {
                dataGridReview.Rows.Add(false, script);
            }

            dataGridReview.AllowUserToAddRows = false;
            dataGridReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

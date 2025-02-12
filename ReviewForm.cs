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
        private IReadOnlyList<string> _scripts;

        public bool ContinueProcessing { get; set; } = false;

        public ReviewForm(IReadOnlyList<string> scripts)
        {
            InitializeComponent();
            _scripts = scripts;
           
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

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
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
                Width = 80,
                ReadOnly = false // Allows user selection
            };
            dataGridReview.Columns.Add(checkboxColumn);

            // Add Text Column (CSV Data)
            DataGridViewTextBoxColumn scriptsColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Scripts",
                Name = "ScriptsColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                ReadOnly = true
            };
            dataGridReview.Columns.Add(scriptsColumn);

            foreach (var script in _scripts)
            {
                dataGridReview.Rows.Add(false, script);
            }

            dataGridReview.AllowUserToAddRows = false;
            dataGridReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReview.ScrollBars = ScrollBars.None;

            AdjustGridSize();

            // TODO: doesn't adjust the form as expecected. Come bakc to this later
            AdjustFormSize();
        }

        private void AdjustGridSize()
        {
            // Get total height needed for all rows and headers
            int totalRowHeight = dataGridReview.Rows.Cast<DataGridViewRow>().Sum(r => r.Height);
            int totalHeight = totalRowHeight + dataGridReview.ColumnHeadersHeight;

            // Get total width of columns + padding
             int totalWidth = dataGridReview.Columns.Cast<DataGridViewColumn>().Sum(c => c.Width) + 3;
  
            // Resize DataGridView to match content
            dataGridReview.Size = new Size(totalWidth, totalHeight);
        }

        private void AdjustFormSize()
        {
            // Adjust form width based on DataGridView content
            int formPadding = 80; // Padding to prevent overlap

            int girdWidth = dataGridReview.Size.Width;
            int gridHeight = dataGridReview.Size.Height;

            this.Size = new Size(dataGridReview.PreferredSize.Width + formPadding, dataGridReview.PreferredSize.Height + formPadding);
        }
    }
}

namespace Robin
{
    public class ScriptReviewGridManager
    {
        const int REVIEW_GRID_INIT_NUM_ROWS = 13;

        private DataGridView? _dgScriptsReview;

        public void InitializeGrid(DataGridView reviewGrid)
        {
            _dgScriptsReview = reviewGrid ?? throw new ArgumentNullException(nameof(reviewGrid));

            _dgScriptsReview.Columns.Clear();
            _dgScriptsReview.Rows.Clear();
            _dgScriptsReview.RowHeadersVisible = false;
            _dgScriptsReview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Row wrapping and height adjustment
            _dgScriptsReview.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            _dgScriptsReview.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            _dgScriptsReview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Checkbox Column
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Accept",
                Name = "AcceptColumn",
                Width = 80,
                ReadOnly = false // Allows user selection
            };
            _dgScriptsReview.Columns.Add(checkboxColumn);

            // scripts Column
            DataGridViewTextBoxColumn scriptsColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Scripts",
                Name = "ScriptsColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            _dgScriptsReview.Columns.Add(scriptsColumn);

            _dgScriptsReview.RowCount = REVIEW_GRID_INIT_NUM_ROWS;

            AdjustReviewGridSize();
        }

        public void PopulateGrid(IReadOnlyList<string> scripts)
        {
            _dgScriptsReview?.Rows.Clear();

            foreach (var script in scripts)
            {
                _dgScriptsReview?.Rows.Add(false, script);
            }
        }

        private void AdjustReviewGridSize()
        {
            if(_dgScriptsReview == null)
            {
                return;
            }   
            // Get total height needed for all rows and headers
            int totalRowHeight = _dgScriptsReview.Rows.Cast<DataGridViewRow>().Sum(r => r.Height);
            int totalHeight = totalRowHeight + _dgScriptsReview.ColumnHeadersHeight;

            // Get total width of columns + padding
            int totalWidth = _dgScriptsReview.Columns.Cast<DataGridViewColumn>().Sum(c => c.Width);

            // Resize DataGridView to match content
            _dgScriptsReview.Size = new Size(totalWidth, totalHeight);
        }
    }
}

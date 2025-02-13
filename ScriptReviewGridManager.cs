namespace Robin
{
    public class ScriptReviewGridManager
    {
        const int REVIEW_GRID_INIT_NUM_ROWS = 12;

        private DataGridView? _dgScriptsReview;
        private Action<bool>? _updateContineButtonState;

        // NOTE: We had to add this method as this cannot be done in the constructor
        // due do it interering with Dependency Injection. We are passing in DataGridView
        // UI element and that causes a circular dependency.
        public void SetUpReviewGrid(DataGridView reviewGrid, Action<bool> updateContineButtonState)
        {
            _dgScriptsReview = reviewGrid ?? throw new ArgumentNullException(nameof(reviewGrid));
            _updateContineButtonState = updateContineButtonState;

            // 
            // Setup event handler
            _dgScriptsReview.CellContentClick += OnCheckboxClicked;
            _dgScriptsReview.AllowUserToAddRows = false;
        }

        public void InitializeGrid()
        {
            if (_dgScriptsReview == null) { return; }

            _dgScriptsReview!.Columns.Clear();
            _dgScriptsReview!.Rows.Clear();
            _dgScriptsReview!.RowHeadersVisible = false;
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

        private void OnCheckboxClicked(object? sender, DataGridViewCellEventArgs e)
        {
            if (_dgScriptsReview == null || _updateContineButtonState == null) return;

            if (e.ColumnIndex == _dgScriptsReview?.Columns["AcceptColumn"].Index && e.RowIndex >= 0)
            {
                _dgScriptsReview.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool allChecked = _dgScriptsReview.Rows.Cast<DataGridViewRow>()
                                .All(row => Convert.ToBoolean(row.Cells["AcceptColumn"].Value) == true);

                _updateContineButtonState(allChecked);

            }
        }
    }
}

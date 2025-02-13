using Robin.InputFileProcessor;
using System.Windows.Forms;

namespace Robin
{
    public partial class Robin : Form
    {
        const int REVIEW_GRID_INIT_NUM_ROWS = 13;

        private string _inputFilePath; 
        private readonly IInputFileProcessor _inputFileProcessor;

        public Robin(IInputFileProcessor inputFileProcessor)
        {
            InitializeComponent();

            _inputFileProcessor = inputFileProcessor ?? throw new ArgumentNullException(nameof(inputFileProcessor));

            _inputFilePath = string.Empty;

            InputFileBtn.Click += this.InputFileBtn_Click;
          
        }

        private void Robin_Load(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_inputFilePath))
            {
                lblFilePath.Text =  string.Empty;

                InitializeScriptsReviewGrid();
                AdjustReviewGridSize();
            }
        }
        private void InputFileBtn_Click(object? sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.Title = "Select a CSV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _inputFilePath = openFileDialog.FileName;
                    lblFilePath.Text = _inputFilePath;

                    PopulateScriptsReviewGrid();

                    tbOutputConsole.AppendText($"{Environment.NewLine} Input File Selected: {_inputFilePath}");

                    
                }
            }
        }

       private void InitializeScriptsReviewGrid()
       {
            dgScriptsReview.Columns.Clear();
            dgScriptsReview.Rows.Clear();
            dgScriptsReview.RowHeadersVisible = false;
            dgScriptsReview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Row wrapping and height adjustment
            dgScriptsReview.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgScriptsReview.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dgScriptsReview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Checkbox Column
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Accept",
                Name = "AcceptColumn",
                Width = 80,
                ReadOnly = false // Allows user selection
            };
            dgScriptsReview.Columns.Add(checkboxColumn);

            // scripts Column
            DataGridViewTextBoxColumn scriptsColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Scripts",
                Name = "ScriptsColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            dgScriptsReview.Columns.Add(scriptsColumn);

            dgScriptsReview.RowCount = REVIEW_GRID_INIT_NUM_ROWS;
        }

        private void AdjustReviewGridSize()
        {
            // Get total height needed for all rows and headers
            int totalRowHeight = dgScriptsReview.Rows.Cast<DataGridViewRow>().Sum(r => r.Height);
            int totalHeight = totalRowHeight + dgScriptsReview.ColumnHeadersHeight;

            // Get total width of columns + padding
            int totalWidth = dgScriptsReview.Columns.Cast<DataGridViewColumn>().Sum(c => c.Width);

            // Resize DataGridView to match content
            dgScriptsReview.Size = new Size(totalWidth, totalHeight);
        }

        private void PopulateScriptsReviewGrid()
        {
            dgScriptsReview.Rows.Clear();

            var scripts = _inputFileProcessor.ProcessInputFile(_inputFilePath);

            foreach (var script in scripts)
            {
                dgScriptsReview.Rows.Add(false, script);
            }
        }
    }
}

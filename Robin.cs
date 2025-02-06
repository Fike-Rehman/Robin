namespace Robin
{
    public partial class Robin : Form
    {
        private string _inputFilePath; 

        public Robin()
        {
            InitializeComponent();

            _inputFilePath = string.Empty;

            InputFileBtn.Click += this.InputFileBtn_Click;
            btnGenerate.Click += this.btnGenerate_Click;
        }

        private void Robin_Load(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_inputFilePath))
            {
                lblFilePath.Text =  string.Empty;
                btnGenerate.Enabled = false;
            }
        }

        private void btnGenerate_Click(object? sender, EventArgs e)
        {
           MessageBox.Show("Generate button clicked");
        }

        private void InputFileBtn_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.Title = "Select a CSV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _inputFilePath = openFileDialog.FileName;
                    lblFilePath.Text = _inputFilePath;
                    btnGenerate.Enabled = true;

                    tbOutputConsole.AppendText($"{Environment.NewLine} Input File Selected: {_inputFilePath}");
                }
            }
        }
    }
}

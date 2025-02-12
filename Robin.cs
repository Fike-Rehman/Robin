using Robin.InputFileProcessor;

namespace Robin
{
    public partial class Robin : Form
    {
        private string _inputFilePath; 
        private readonly IInputFileProcessor _inputFileProcessor;

        public Robin(IInputFileProcessor inputFileProcessor)
        {
            InitializeComponent();

            _inputFileProcessor = inputFileProcessor ?? throw new ArgumentNullException(nameof(inputFileProcessor));

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
            try
            {
                if (string.IsNullOrEmpty(_inputFilePath))
                {
                    tbOutputConsole.AppendText($"{Environment.NewLine} Please select an input file.");
                    return;
                }
                var scriptTexts = _inputFileProcessor.ProcessInputFile(_inputFilePath);

                // display the review modal:
                using(var reviewModal = new ReviewForm(scriptTexts))
                {
                    var modalResult = reviewModal.ShowDialog();

                    if (modalResult == DialogResult.OK && reviewModal.ContinueProcessing)
                    {
                        tbOutputConsole.AppendText($"{Environment.NewLine} Review completed successfully.");
                    }
                    else
                    {
                        tbOutputConsole.AppendText($"{Environment.NewLine} Review cancelled.");
                    }
                }
            }
            catch (Exception ex)
            {
                tbOutputConsole.AppendText($"{Environment.NewLine} Error: {ex.Message}");
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
                    btnGenerate.Enabled = true;

                    tbOutputConsole.AppendText($"{Environment.NewLine} Input File Selected: {_inputFilePath}");
                }
            }
        }
    }
}

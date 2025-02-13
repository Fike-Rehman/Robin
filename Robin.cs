using Robin.InputFileProcessor;

namespace Robin
{
    public partial class Robin : Form
    {
        private string _inputFilePath; 
        private readonly IInputFileProcessor _inputFileProcessor;
        private readonly ScriptReviewGridManager _scriptReviewGridManager;

        public Robin(IInputFileProcessor inputFileProcessor, ScriptReviewGridManager scriptReviewGridManager)
        {
            InitializeComponent();

            _inputFileProcessor = inputFileProcessor ?? throw new ArgumentNullException(nameof(inputFileProcessor));
            _scriptReviewGridManager = scriptReviewGridManager ?? throw new ArgumentNullException(nameof(scriptReviewGridManager));

            _inputFilePath = string.Empty;

            btnInputFile.Click += this.InputFileBtn_Click;
            btnContinue.Enabled = false;
        }
            
        private void Robin_Load(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_inputFilePath))
            {
                lblFilePath.Text =  string.Empty;
             _scriptReviewGridManager.InitializeGrid(dgScriptsReview);
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
                    tbOutputConsole.AppendText($"{Environment.NewLine} Input File Selected: {_inputFilePath}");

                    var scripts = _inputFileProcessor.ProcessInputFile(_inputFilePath);
                    _scriptReviewGridManager.PopulateGrid(scripts);

                    tbOutputConsole.AppendText($"{Environment.NewLine} Available scripts loaded. Please review and accept each script individaully and click continue");
                }
            }
        }
    }
}

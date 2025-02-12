using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Robin.InputFileProcessor
{
    public class InputCSVFileProcessor : IInputFileProcessor
    {
        public IReadOnlyList<string> ProcessInputFile(string inputFilePath)
        {
            // Validate that the file exists
            if (!File.Exists(inputFilePath))
            {
                throw new FileNotFoundException("File not found.", inputFilePath);
            }

            // Validate file format (ensure it has a .csv extension)
            if (!Path.GetExtension(inputFilePath).Equals(".csv", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new InvalidOperationException("Invalid file format. Expected a CSV file.");
            }

            List<string> scriptTexts = new();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ","
            };

            using (var reader = new StreamReader(inputFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                if (csv == null)
                {
                    return scriptTexts.AsReadOnly();
                }

                while (csv.Read())
                {
                    // Get the last column dynamically
                    int lastColumnIndex = csv.Parser.Count - 1;

                    if (lastColumnIndex >= 0)
                    {
                        var field = csv[lastColumnIndex];
                        if (!string.IsNullOrWhiteSpace(field))
                        {
                            scriptTexts.Add(field);
                        }
                    }
                }

                return scriptTexts.AsReadOnly();
            }
        }
    }
}

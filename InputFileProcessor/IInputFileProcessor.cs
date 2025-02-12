namespace Robin.InputFileProcessor
{
    public interface IInputFileProcessor
    {
        /// <summary>
        /// Process the input file and builds a list of strings that are needed for speech sysnthesis
        /// </summary>
        /// <param name="inputFilePath"></param>
        IReadOnlyList<string> ProcessInputFile(string inputFilePath);
    }
}

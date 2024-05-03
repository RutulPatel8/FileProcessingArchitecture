namespace FileProcessingArchitecture
{
    public interface IFileParser
    {
        void OpenFile(string filePath);
        string ReadFile();
        bool ValidateFile();
        void WriteFile(string content);
        void ProcessFile(string algorithm);
    }

    public interface IMSProjectFileParser : IFileParser
    {
        string Application { get; set; }
    }
}

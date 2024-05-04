namespace FileProcessingArchitecture.MSProject
{
    public interface IMSProjectFileParser : IFileParser
    {
        string Application { get; set; }
    }
}

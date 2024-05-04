namespace FileProcessingArchitecture.ExcelProject
{
    public interface IExcelFileParser : IFileParser
    {
        public string Application { get; set; }
    }
}

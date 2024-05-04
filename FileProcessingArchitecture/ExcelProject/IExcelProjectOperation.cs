namespace FileProcessingArchitecture.ExcelProject
{
    public interface IExcelProjectOperation : IProjectOperation
    {
        string Application { get; set; }
    }
}

namespace FileProcessingArchitecture.ExcelProject
{
    public interface IExcelTaskOperation : ITaskOperation
    {
        string Application { get; set; }
    }
}

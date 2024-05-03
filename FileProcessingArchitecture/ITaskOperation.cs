namespace FileProcessingArchitecture
{
    public interface ITaskOperation
    {
        Dictionary<string, string> GetTaskHeaderInfo(int taskId);
        List<string> GetSubTaskUsingTemplate(int templateId);
        List<int> GetTaskPredecessor(int taskId);
        List<int> GetTaskSuccessor(int taskId);
        string CalculateOpenTaskStatus();
    }
}

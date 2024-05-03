namespace FileProcessingArchitecture
{
    public interface IProjectOperation
    {
        Dictionary<string, string> GetProjectHeaderInfo();
        List<string> GetTaskList();
        string GetResourceType(int resourceId);
        void RunBufferManagement();
        void ScheduleProject();
        double CalculatePlannedCycle();
    }
}

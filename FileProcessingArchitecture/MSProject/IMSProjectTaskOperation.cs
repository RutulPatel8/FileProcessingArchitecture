namespace FileProcessingArchitecture.MSProject
{
    public interface IMSProjectTaskOperation : ITaskOperation
    {
        string Application { get; set; }

        #region TaskOperation
        public string CalculateOpenTaskStatus()
        {
            throw new NotImplementedException();
        }

        public List<string> GetSubTaskUsingTemplate(int templateId)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetTaskHeaderInfo(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTaskPredecessor(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTaskSuccessor(int taskId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

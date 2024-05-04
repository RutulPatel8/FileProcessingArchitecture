namespace FileProcessingArchitecture.MSProject
{
    public interface IMSProjectOperation : IProjectOperation
    {
        string Application { get; set; }

        #region ProjectOperation
        public double CalculatePlannedCycle()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetProjectHeaderInfo()
        {
            throw new NotImplementedException();
        }

        public string GetResourceType(int resourceId)
        {
            throw new NotImplementedException();
        }

        public List<string> GetTaskList()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

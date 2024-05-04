using FileProcessingArchitecture.ExcelProject;
using FileProcessingArchitecture.MSProject;

namespace FileProcessingArchitecture
{

    // Abstract Factory Interface
    interface IFileFactory
    {
        IFileParser createFileParser();
        IProjectOperation createProjectOperation();
        ITaskOperation createTaskOperation();
    }

    // Concrete Factory for MS Project files
    class MSProjectFactory : IFileFactory
    {
        public IFileParser createFileParser()
        {
            return new MSProjectFileParser();
        }

        public IProjectOperation createProjectOperation()
        {
            return new MSProjectOperation();
        }

        public ITaskOperation createTaskOperation()
        {
            return new MSProjectTaskOperation();
        }
    }

    // Concrete Factory for Excel files
    class ExcelFactory : IFileFactory
    {
        public IFileParser createFileParser()
        {
            return new ExcelFileParser();
        }

        public IProjectOperation createProjectOperation()
        {
            return new ExcelProjectOperation();
        }

        public ITaskOperation createTaskOperation()
        {
            return new ExcelTaskOperation();
        }
    }


    class FactoryClient
    {
        private IFileFactory fileFactory;

        public FactoryClient(IFileFactory fileFactory)
        {
            this.fileFactory = fileFactory;
        }

        public void processFile(String fileType)
        {
            IFileParser fileParser = fileFactory.createFileParser();
            fileParser.OpenFile("xyz." + fileType);
            fileParser.ReadFile();
            fileParser.ValidateFile();
            fileParser.ProcessFile("Prochain");

            IProjectOperation projectOperation = fileFactory.createProjectOperation();
            projectOperation.GetProjectHeaderInfo();
            projectOperation.CalculatePlannedCycle();
            projectOperation.GetTaskList();

            ITaskOperation taskOperation = fileFactory.createTaskOperation();
            taskOperation.GetTaskSuccessor(1);
            taskOperation.GetTaskPredecessor(1);
            taskOperation.GetTaskHeaderInfo(1);
            taskOperation.GetSubTaskUsingTemplate(1);
            taskOperation.CalculateOpenTaskStatus();
        }
    }
}

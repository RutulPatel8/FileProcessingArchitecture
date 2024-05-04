using FileProcessingArchitecture.ExcelProject;
using FileProcessingArchitecture.MSProject;

namespace FileProcessingArchitecture
{
    // Factory for creating File Parser
    class FileParserFactory
    {
        public static IFileParser createFileParser(String fileType)
        {
            switch (fileType)
            {
                case "MSProject":
                    return new MSProjectFileParser();
                case "Excel":
                    return new ExcelFileParser();
                default:
                    throw new Exception("Invalid file type");
            }
        }
    }

    // Factory for creating Project Operation
    class ProjectOperationFactory
    {
        public static IProjectOperation createProjectOperation(String fileType)
        {
            switch (fileType)
            {
                case "MSProject":
                    return new MSProjectOperation();
                case "Excel":
                    return new ExcelProjectOperation();
                default:
                    throw new Exception("Invalid file type");
            }
        }
    }

    // Factory for creating Task Operation
    class TaskOperationFactory
    {
        public static ITaskOperation createTaskOperation(String fileType)
        {
            switch (fileType)
            {
                case "MSProject":
                    return new MSProjectTaskOperation();
                case "Excel":
                    return new ExcelTaskOperation();
                default:
                    throw new Exception("Invalid file type");
            }
        }
    }
}

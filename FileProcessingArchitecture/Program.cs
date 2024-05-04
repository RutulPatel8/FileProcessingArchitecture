using FileProcessingArchitecture;
using FileProcessingArchitecture.ExcelProject;
using FileProcessingArchitecture.MSProject;

//------------------------------------------------------------------------------------------------------------------
//Technique-1 Simple methdology to use complex functionality.
//----------------------------------------------------------------------------------------------------
//For MsProject
IMSProjectFileParser msProjectFileParser = new MSProjectFileParser();
msProjectFileParser.OpenFile("xyz.mpp");
msProjectFileParser.ReadFile();
msProjectFileParser.ValidateFile();
msProjectFileParser.ProcessFile("Prochain");


IMSProjectOperation msProjectOperation = new MSProjectOperation();
msProjectOperation.Application = msProjectFileParser.Application;
msProjectOperation.GetProjectHeaderInfo();
msProjectOperation.CalculatePlannedCycle();
msProjectOperation.GetTaskList();

IMSProjectTaskOperation msProjectTaskOperation = new MSProjectTaskOperation();
msProjectTaskOperation.Application = msProjectFileParser.Application;
msProjectTaskOperation.GetTaskSuccessor(1);
msProjectTaskOperation.GetTaskPredecessor(1);
msProjectTaskOperation.GetTaskHeaderInfo(1);
msProjectTaskOperation.GetSubTaskUsingTemplate(1);
msProjectTaskOperation.CalculateOpenTaskStatus();

//Excel File
//IExcelFileParser excelFileParser = new ExcelFileParser();
//excelFileParser.OpenFile("xyz.xls");
//excelFileParser.ReadFile();
//excelFileParser.ValidateFile();
//excelFileParser.ProcessFile("Prochain");


//IExcelProjectOperation excelProjectOperation = new ExcelProjectOperation();
//excelProjectOperation.Application = msProjectFileParser.Application;
//excelProjectOperation.GetProjectHeaderInfo();
//excelProjectOperation.CalculatePlannedCycle();
//excelProjectOperation.GetTaskList();

//IExcelTaskOperation excelTaskOperation = new ExcelTaskOperation();
//excelTaskOperation.Application = msProjectFileParser.Application;
//excelTaskOperation.GetTaskSuccessor(1);
//excelTaskOperation.GetTaskPredecessor(1);
//excelTaskOperation.GetTaskHeaderInfo(1);
//excelTaskOperation.GetSubTaskUsingTemplate(1);
//excelTaskOperation.CalculateOpenTaskStatus();


//------------------------------------------------------------------------------------------------------------------
//Technique-2 Factory Design pattern --------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------
//Advantage you can access everything without touching internal Logic
//----------------------------------------------------------------------------------------------------
String fileType = "MSProject"; // or "Excel"
IFileParser fileParser = FileParserFactory.createFileParser(fileType);
fileParser.OpenFile("xyz.mpp");
fileParser.ReadFile();
fileParser.ValidateFile();
fileParser.ProcessFile("Prochain");

IProjectOperation projectOperation = ProjectOperationFactory.createProjectOperation(fileType);
projectOperation.GetProjectHeaderInfo();
projectOperation.CalculatePlannedCycle();
projectOperation.GetTaskList();

ITaskOperation taskOperation = TaskOperationFactory.createTaskOperation(fileType);
taskOperation.GetTaskSuccessor(1);
taskOperation.GetTaskPredecessor(1);
taskOperation.GetTaskHeaderInfo(1);
taskOperation.GetSubTaskUsingTemplate(1);
taskOperation.CalculateOpenTaskStatus();


///-----------------------------------------------------------------------------------------------------------
///Technique-3 Factory design pattern(2)
///-----------------------------------------------------------------------------------
///User just want to share File operation will be execute automatically as per our requirment.
///---------------------------------------------------------------------
FactoryClient msProjectClient = new FactoryClient(new MSProjectFactory());
msProjectClient.processFile("mpp");

FactoryClient excelClient = new FactoryClient(new ExcelFactory());
excelClient.processFile("xls");


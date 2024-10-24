namespace LeKhanhLy423.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}



//dotnet aspnet-codegenerator controller -name EmployeeController -m Employee -dc DemoMvc.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

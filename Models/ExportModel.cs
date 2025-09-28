namespace ExportDialogApp.Models
{
    public class ExportModel
    {
        public bool IncludeScopingDoc { get; set; }
        public bool IncludeAllDoc { get; set; }
        public string ExportType { get; set; } = "selected";
        public bool IncludeTimestamp { get; set; }
        public string FileFormat { get; set; } = "PDF";

        public bool IsValid => IncludeScopingDoc || IncludeAllDoc;
    }
}
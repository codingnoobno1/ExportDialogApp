namespace ExportDialogApp.ViewModels
{
    public class ExportViewModel
    {
        public bool IncludeScopingDoc { get; set; }
        public bool IncludeAllDoc { get; set; }
        public string ExportType { get; set; }
        public bool IncludeTimestamp { get; set; }
        public string[] FileFormats { get; set; }
        public string SelectedFormat { get; set; }
    }
}
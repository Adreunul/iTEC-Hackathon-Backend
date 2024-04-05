namespace iTEC_Hackathon.DTOs.Report
{
    public class ReportInsertDTO
    {
        int IdApplication { get; set; }
        int IdEndpoint { get; set; }
        int IdUser { get; set; }
        DateTime DateCreated { get; set; }
        string Mentions { get; set; }
    }
}

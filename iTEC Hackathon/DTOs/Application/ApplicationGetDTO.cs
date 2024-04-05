namespace iTEC_Hackathon.DTOs.Application
{
    public class ApplicationGetDTO
    {
        public int IdApplication { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdUserAuthor { get; set; }
        public string ApplicationState { get; set; }

    }
}

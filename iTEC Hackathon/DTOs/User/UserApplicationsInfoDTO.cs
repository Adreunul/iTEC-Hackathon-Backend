namespace iTEC_Hackathon.DTOs.User
{
    public class UserApplicationsInfoDTO
    {
        public int NrOfApplications { get; set; }
        public int NrOfEndpoints { get; set; }
        public int NrOfEndpointsStable { get; set; }
        public int NrOfEndpointsUnstable { get; set; }
        public int NrOfEndpointsDown { get; set; }
    }
}

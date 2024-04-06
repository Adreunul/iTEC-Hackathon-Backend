namespace iTEC_Hackathon.DTOs.EndpointHistory
{
    public class EndpointHistoryGetEndpointsState
    {
        public int IdEndpoint { get; set; }
        public int IdUser { get; set; }
        public string EndpointState { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

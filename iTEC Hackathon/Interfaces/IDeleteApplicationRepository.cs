namespace iTEC_Hackathon.Interfaces
{
    public interface IDeleteApplicationRepository
    {
        Task<int> DeleteApplicationAsyncRepo(int idApplication);
    }
}

using System.Data;
using Dapper;
using iTEC_Hackathon.DTOs.Application;
using iTEC_Hackathon.Interfaces;


namespace iTEC_Hackathon.Repositories
{
    public class GetApplicationRepository : IGetApplicationRepository
    {
      private readonly IDbConnectionFactory _dbconnectionFactory;
        public GetApplicationRepository(IDbConnectionFactory dbconnectionFactory)
        {
            _dbconnectionFactory = dbconnectionFactory;
        }

        public async Task<IEnumerable<ApplicationGetDTO>> GetApplicationAsyncRepo(int idUserAuthor)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@IdUserAuthor", idUserAuthor);
            using (var connection = _dbconnectionFactory.ConnectToDataBase())
            {
                var result = await connection.QueryAsync<ApplicationGetDTO>("GetApplications", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}

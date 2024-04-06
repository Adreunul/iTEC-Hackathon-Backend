using Dapper;
using System.Data;
using iTEC_Hackathon.DTOs.EndpointHistory;
using iTEC_Hackathon.Interfaces;



namespace iTEC_Hackathon.Repositories.EndpointHistory
{
    public class AddEndpointHistoryRepository
    {
        private readonly IDbConnectionFactory _dbconnectionFactory;
        public AddEndpointHistoryRepository(IDbConnectionFactory dbconnectionFactory)
        {
            _dbconnectionFactory = dbconnectionFactory;
        }
        
        public async Task<int> AddEndpointHistoryAsyncRepo(EndpointHistoryInsertDTO endpointHistoryInsertDTO)
        {
            var parameters = new DynamicParameters();

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            parameters.Add("@IdEndpointHistory", endpointHistoryInsertDTO.IdEndpoint);
            parameters.Add("@IdUser", endpointHistoryInsertDTO.IdUser);
            parameters.Add("@Code", endpointHistoryInsertDTO.Code);
            parameters.Add("@Mentions", endpointHistoryInsertDTO.Mentions);
            parameters.Add("@DateCreated", sqlFormattedDate);
            parameters.Add("@IdEndpointHistory", dbType: DbType.Int32, direction: ParameterDirection.Output);

            using (var connection = _dbconnectionFactory.ConnectToDataBase())
            {
                await connection.ExecuteAsync("InsertEndpointHistory", parameters, commandType: CommandType.StoredProcedure);
                var result = parameters.Get<int>("IdEndpointHistory");
                return result;
            }
        }   
    }
}

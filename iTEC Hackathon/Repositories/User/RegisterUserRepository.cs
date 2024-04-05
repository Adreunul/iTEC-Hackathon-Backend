using Dapper;
using iTEC_Hackathon.DTOs;
using iTEC_Hackathon.Interfaces;
using System.Data;

namespace iTEC_Hackathon.Repositories
{
    public class RegisterUserRepository : IRegisterUserRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public RegisterUserRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<int> RegisterUserAsyncRepo(UserCredentialsRegisterDTO userCredentialsRegisterDTO)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Email", userCredentialsRegisterDTO.Email);
            parameters.Add("@Password", userCredentialsRegisterDTO.Password);
            parameters.Add("@IdRole", userCredentialsRegisterDTO.IdRole);
            parameters.Add("@UserID", dbType: DbType.Int32, direction: ParameterDirection.Output);
            using (var connection = _dbConnectionFactory.ConnectToDataBase())
            {
                await connection.ExecuteAsync("RegisterUser", parameters, commandType: CommandType.StoredProcedure);
                return parameters.Get<int>("UserID");
            }
        }
    }
}

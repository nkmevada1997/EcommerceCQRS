using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ecommerce.Repository.Repositories
{
    public class CountryRepository(IConfiguration configuration) : ICountryRepository
    {
        readonly string _connectionString = configuration.GetConnectionString("DefaultConnection");

        public async Task<AddCountryResponse> AddCountryAsync(AddCountryRequest request)
        {
            try
            {
                Guid newCountryId = Guid.Empty;
                using SqlConnection connection = new(_connectionString);
                using SqlCommand command = new("sp_AddCountry", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", request.Name);
                command.Parameters.AddWithValue("@CreatedBy", Guid.Empty);

                //SqlParameter newIdParameter = new("@NewId", SqlDbType.UniqueIdentifier)
                //{
                //    Direction = ParameterDirection.Output
                //};

                //command.Parameters.Add(newIdParameter);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                //newCountryId = (Guid)newIdParameter.Value;

                if (newCountryId != Guid.Empty)
                {
                    return new AddCountryResponse
                    {
                        IsError = false,
                        Success = true,
                        Message = "Country Added",
                    };
                }

                return new AddCountryResponse
                {
                    IsError = false,
                    Success = false,
                    Message = "Something Went Wrong",
                };
            }
            catch (Exception ex)
            {
                return new AddCountryResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Add Country",
                    ExceptionMessage = ex.Message
                };
            }
        }

        public async Task<GetCountriesResponse> GetCountriesAsync()
        {
            try
            {
                List<CountryDTO> countries = [];
                using (SqlConnection connection = new(_connectionString))
                {
                    using SqlCommand command = new("sp_GetCountries", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            countries.Add(new CountryDTO
                            {
                                Id = reader["Id"] != DBNull.Value ? (Guid)reader["Id"] : Guid.Empty,
                                Name = (string)reader["Name"],
                                CreatedBy = reader["CreatedBy"] != DBNull.Value ? (Guid)reader["CreatedBy"] : Guid.Empty,
                                CreatedDate = (DateTime)reader["CreatedDate"],
                                UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? (Guid)reader["UpdatedBy"] : Guid.Empty,
                                UpdatedDate = reader["UpdatedBy"] != DBNull.Value ? (DateTime)reader["UpdatedDate"] : null,
                                IsActive = (bool)reader["IsActive"]
                            });
                        }
                    }
                }

                return new GetCountriesResponse
                {
                    IsError = false,
                    Result = countries,
                    Message = "Countries Retrieved",
                };

            }
            catch (Exception ex)
            {
                return new GetCountriesResponse
                {
                    IsError = true,
                    Result = [],
                    Message = "Unable to Retrieve Data",
                    ExceptionMessage = ex.Message
                };
            }
        }

        public async Task<GetCountryDetailResponse> GetCountryDetailAsync(Guid Id)
        {
            try
            {
                using SqlConnection connection = new(_connectionString);
                using SqlCommand command = new("sp_GetCountryDetail", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);

                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    await reader.ReadAsync();
                    return new GetCountryDetailResponse
                    {
                        IsError = false,
                        Message = "Country Detail Retrieved",
                        Result = new CountryDTO
                        {
                            Id = reader["Id"] != DBNull.Value ? (Guid)reader["Id"] : Guid.Empty,
                            Name = (string)reader["Name"],
                            CreatedBy = reader["CreatedBy"] != DBNull.Value ? (Guid)reader["CreatedBy"] : Guid.Empty,
                            CreatedDate = (DateTime)reader["CreatedDate"],
                            UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? (Guid)reader["UpdatedBy"] : Guid.Empty,
                            UpdatedDate = reader["UpdatedBy"] != DBNull.Value ? (DateTime)reader["UpdatedDate"] : null,
                            IsActive = (bool)reader["IsActive"]
                        }
                    };
                }
                else
                {
                    return new GetCountryDetailResponse
                    {
                        IsError = false,
                        Message = "Country Detail Not Found",
                    };
                }
            }
            catch (Exception ex)
            {
                return new GetCountryDetailResponse
                {
                    IsError = true,
                    Result = null,
                    Message = "Unable to Retrieve Data",
                    ExceptionMessage = ex.Message
                };

            }
        }

        public async Task<EditCountryResponse> EditCountryAsync(Guid Id, EditCountryRequest request)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                using SqlCommand command = new SqlCommand("sp_UpdateCountry", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Name", request.Name);
                command.Parameters.AddWithValue("@UpdatedBy", Guid.Empty);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return new EditCountryResponse
                {
                    IsError = false,
                    Success = true,
                    Message = "Country Updated",
                };
            }
            catch (Exception ex)
            {
                return new EditCountryResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Update Country",
                    ExceptionMessage = ex.Message
                };
            }
        }

        public async Task<DeleteCountryResponse> DeleteCountryAsync(Guid Id)
        {
            try
            {
                using SqlConnection connection = new(_connectionString);
                using SqlCommand command = new("sp_DeleteCountry", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@UpdatedBy", Guid.Empty);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return new DeleteCountryResponse
                {
                    IsError = false,
                    Success = true,
                    Message = "Country Deleted",
                };
            }
            catch (Exception ex)
            {
                return new DeleteCountryResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Delete Country",
                    ExceptionMessage = ex.Message
                };
            }
        }
    }
}

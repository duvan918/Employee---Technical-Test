using EmployeesManagementApp.Interfaces;
using EmployeesManagementApp.Models;
using Newtonsoft.Json;

namespace EmployeesManagementApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var response = await _httpClient.GetAsync("http://dummy.restapiexample.com/api/v1/employees");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}", null, response.StatusCode);
            }

            var responseString = await response.Content.ReadAsStringAsync();
            EmployeeListResponse? responseObject = JsonConvert.DeserializeObject<EmployeeListResponse>(responseString);

            if (responseObject == null || responseObject.DataList == null || responseObject.DataList.Count == 0)
            {
                throw new Exception("Failed to get employees or no employees found.");
            }

            return responseObject.DataList;
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"http://dummy.restapiexample.com/api/v1/employee/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}", null, response.StatusCode);
            }

            var responseString = await response.Content.ReadAsStringAsync();
            EmployeeResponse? responseObject = JsonConvert.DeserializeObject<EmployeeResponse>(responseString);

            if (responseObject == null || responseObject.Data == null)
            {
                throw new Exception($"Failed to get employee with ID {id}.");
            }

            return responseObject.Data;
        }
    }
}

using Newtonsoft.Json;

namespace EmployeesManagementApp.Models
{
    public class EmployeeListResponse
    {
        public string Status { get; set; }
        [JsonProperty("data")]
        public List<Employee> DataList { get; set; }
        public string Message { get; set; }
    }

    public class EmployeeResponse
    {
        public string Status { get; set; }
        public Employee Data { get; set; }
        public string Message { get; set; }
    }
}

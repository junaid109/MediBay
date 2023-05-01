using MediBaseApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediBaseApp.Core.Services
{
    public class PatientDataService : IPatientDataService
    {
        private readonly HttpClient _httpClient;

        public PatientDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<Patient>> GetPatientsAsync()
        {
            var response = await _httpClient.GetAsync("https://api.example.com/patients");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var patients = JsonSerializer.Deserialize<IList<Patient>>(content);
                return patients;
            }

            throw new Exception("Failed to get patients");
        }
    }

}

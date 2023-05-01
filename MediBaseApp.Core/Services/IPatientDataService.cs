using MediBaseApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediBaseApp.Core.Services
{
    public interface IPatientDataService
    {
        Task<IList<Patient>> GetPatientsAsync();
        
       
        
        
    }
}

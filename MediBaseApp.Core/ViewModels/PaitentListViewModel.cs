using MediBaseApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediBaseApp.Core.ViewModels
{

    public class PatientListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Patient> _patients;

        public PatientListViewModel()
        {
            _patients = new ObservableCollection<Patient>();
        }

        public ObservableCollection<Patient> Patients => _patients;

        public async Task LoadPatientsAsync()
        {
            // fetch patient data from REST API or local database
            // and add the patients to the _patients collection
            // for example:
            _patients.Add(new Patient { Name = "John Doe", Age = 42, Gender = "Male" });
            _patients.Add(new Patient { Name = "Jane Doe", Age = 35, Gender = "Female" });
            
        }
    }

}

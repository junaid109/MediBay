using MediBaseApp.Core.Models;
using MediBaseApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediBaseApp.Core.ViewModels
{

    internal class PatientListViewModel : BaseViewModel
    {
        private readonly IPatientDataService _patientDataService;

        public PatientListViewModel(IPatientDataService patientDataService)
        {
            _patientDataService = patientDataService;
        }

        public PatientListViewModel(IPatientDataService patientDataService, ObservableCollection<Patient> patients) : this(patientDataService)
        {
            Patients = patients;
        }

        public ObservableCollection<Patient> Patients { get; } = new ObservableCollection<Patient>();

        public async Task LoadPatientsAsync()
        {
            var patients = await _patientDataService.GetPatientsAsync();

            Patients.Clear();

            foreach (var patient in patients)
            {
                Patients.Add(patient);
            }
        }
    }

}

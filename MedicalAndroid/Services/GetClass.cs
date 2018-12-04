using System;
using System.Collections.Generic;
using System.Linq;
using MedicalAndroid.Models;
using MedicalAndroid.Models.Enums;
using MvvmCross.ViewModels;

namespace MedicalAndroid.Services
{
    public class GetClass
    {
        private MedicalWebService.MedicalWebService service;

        public GetClass()
        {
            service = new MedicalWebService.MedicalWebService();
        }

        public MvxObservableCollection<Patient> GetPatientList()
        {
            MvxObservableCollection<Patient> patientsList = new MvxObservableCollection<Patient>();

            //try
            //{
            //    var value = service.PatientsList();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            //foreach (var patient in service.PatientsList())
            //{
            //    Patient localPatient = new Patient();
            //    localPatient.Id = patient.Id;
            //    localPatient.DateOfBirth = patient.DateOfBirth;
            //    localPatient.Name = patient.Name;
            //    localPatient.Pesel = patient.Pesel;
            //    patientsList.Add(localPatient);
            //}

            //return patientsList;

            List<Patient> Patients = new List<Patient>
            {
                new Patient {Id = 1, Name = "Tomek Wójcik", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 2, Name = "Andrzej Nowak", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 3, Name = "Zbyszek Wodzirej", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 4, Name = "Patryk Myszka", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 5, Name = "Grzegorz Słowikowski", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 6, Name = "Małgorzata Gżegzółka", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 7, Name = "Kasia Małosolna", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 8, Name = "Ełgienia Krawczyk", DateOfBirth = "01.09.1989", Pesel = "01098975243"},
                new Patient {Id = 9, Name = "Barbara Wójcikowska", DateOfBirth = "01.09.1989", Pesel = "01098975243"}
            };

            foreach (var patient in Patients)
            {
                patientsList.Add(patient);
            }

            return patientsList;
        }

        public MvxObservableCollection<MedicalTest> GetPatientMedicalTests(int patientId)
        {
            List<MedicalTest> MedicalTests = new List<MedicalTest>
            {
                new MedicalTest { Id = 1, DateTime = new DateTime(2011, 6, 10), PatientId = 1, IsDone = true, MedicalTestTypes = MedicalTestTypes.OphthalmologicalExamination },
                new MedicalTest { Id = 2, DateTime = new DateTime(2019, 1, 8), PatientId = 2, IsDone = false, MedicalTestTypes = MedicalTestTypes.BloodTest },
                new MedicalTest { Id = 3, DateTime = new DateTime(2013, 3, 24), PatientId = 3, IsDone = true, MedicalTestTypes = MedicalTestTypes.NeurologicalResearch },
                new MedicalTest { Id = 4, DateTime = new DateTime(2017, 1, 12), PatientId = 4, IsDone = true, MedicalTestTypes = MedicalTestTypes.Usg },
                new MedicalTest { Id = 5, DateTime = new DateTime(2020, 1, 7), PatientId = 5, IsDone = false, MedicalTestTypes = MedicalTestTypes.Usg },
                new MedicalTest { Id = 6, DateTime = new DateTime(2013, 8, 5), PatientId = 8, IsDone = true, MedicalTestTypes = MedicalTestTypes.BloodTest },
                new MedicalTest { Id = 7, DateTime = new DateTime(2015, 12, 2), PatientId = 9, IsDone = true, MedicalTestTypes = MedicalTestTypes.Rtg },
                new MedicalTest { Id = 8, DateTime = new DateTime(2015, 1, 9), PatientId = 5, IsDone = true, MedicalTestTypes = MedicalTestTypes.BloodTest },
                new MedicalTest { Id = 9, DateTime = new DateTime(2023, 9, 8), PatientId = 7, IsDone = false, MedicalTestTypes = MedicalTestTypes.NeurologicalResearch },
                new MedicalTest { Id = 10, DateTime = new DateTime(2018, 1, 1), PatientId = 1, IsDone = true, MedicalTestTypes = MedicalTestTypes.OphthalmologicalExamination },
                new MedicalTest { Id = 11, DateTime = new DateTime(2017, 3, 10), PatientId = 4, IsDone = true, MedicalTestTypes = MedicalTestTypes.Usg },
                new MedicalTest { Id = 12, DateTime = new DateTime(2021, 4, 25), PatientId = 2, IsDone = false, MedicalTestTypes = MedicalTestTypes.NeurologicalResearch },
                new MedicalTest { Id = 13, DateTime = new DateTime(2016, 3, 21), PatientId = 7, IsDone = true, MedicalTestTypes = MedicalTestTypes.OphthalmologicalExamination },
                new MedicalTest { Id = 14, DateTime = new DateTime(2017, 8, 16), PatientId = 3, IsDone = true, MedicalTestTypes = MedicalTestTypes.OphthalmologicalExamination },
                new MedicalTest { Id = 15, DateTime = new DateTime(2015, 1, 3), PatientId = 5, IsDone = true, MedicalTestTypes = MedicalTestTypes.Usg },
                new MedicalTest { Id = 16, DateTime = new DateTime(2019, 7, 13), PatientId = 9, IsDone = false, MedicalTestTypes = MedicalTestTypes.Rtg },
                new MedicalTest { Id = 17, DateTime = new DateTime(2016, 6, 6), PatientId = 1, IsDone = true, MedicalTestTypes = MedicalTestTypes.Rtg },
                new MedicalTest { Id = 18, DateTime = new DateTime(2012, 10, 28), PatientId = 2, IsDone = true, MedicalTestTypes = MedicalTestTypes.BloodTest },
                new MedicalTest { Id = 19, DateTime = new DateTime(2017, 1, 16), PatientId = 8, IsDone = true, MedicalTestTypes = MedicalTestTypes.OphthalmologicalExamination },
                new MedicalTest { Id = 20, DateTime = new DateTime(2016, 11, 25), PatientId = 1, IsDone = true, MedicalTestTypes = MedicalTestTypes.NeurologicalResearch },
                new MedicalTest { Id = 21, DateTime = new DateTime(2014, 8, 19), PatientId = 5, IsDone = true, MedicalTestTypes = MedicalTestTypes.BloodTest },
                new MedicalTest { Id = 22, DateTime = new DateTime(2012, 6, 11), PatientId = 6, IsDone = true, MedicalTestTypes = MedicalTestTypes.NeurologicalResearch },
                new MedicalTest { Id = 23, DateTime = new DateTime(2013, 12, 22), PatientId = 3, IsDone = true, MedicalTestTypes = MedicalTestTypes.Usg },
                new MedicalTest { Id = 24, DateTime = new DateTime(2020, 4, 25), PatientId = 2, IsDone = false, MedicalTestTypes = MedicalTestTypes.Rtg },
                new MedicalTest { Id = 25, DateTime = new DateTime(2020, 2, 23), PatientId = 9, IsDone = false, MedicalTestTypes = MedicalTestTypes.OphthalmologicalExamination },
            };

            var resoultFiltering = MedicalTests.Where(x => x.PatientId == patientId);

            MvxObservableCollection<MedicalTest> medicalTests = new MvxObservableCollection<MedicalTest>();

            foreach (var test in resoultFiltering)
            {
                medicalTests.Add(test);
            }

            return medicalTests;
        }
    }
}

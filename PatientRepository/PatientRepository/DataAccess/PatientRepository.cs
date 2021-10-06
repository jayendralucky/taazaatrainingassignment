using System.Collections.Generic;
using PatientRepository.Models;
using PatientRepository.DataAccess;
using System.Linq;

namespace PatientRepository
{
    public class PatientRepository : IPatientRepository
    {
        PatientDBContext patientDBContext;
        public PatientRepository(PatientDBContext _patientDBContext)
        {
            patientDBContext = _patientDBContext; 
        }
        void IPatientRepository.AddPatientRecord(Patient patient)
        {
            patientDBContext.Add(patient);
            patientDBContext.SaveChanges();//commit or save a record in db
        }

        void IPatientRepository.DeletePatientRecord(string id)
        {
              var entity = patientDBContext.patients.FirstOrDefault(t => t.id == id);  
            patientDBContext.patients.Remove(entity);  
            patientDBContext.SaveChanges();  
        }

        List<Patient> IPatientRepository.GetPatientRecords()
        {
             return patientDBContext.patients.ToList();  
        }

        Patient IPatientRepository.GetPatientSingleRecord(string id)
        {
           return patientDBContext.patients.FirstOrDefault(t => t.id == id);  
        }

        void IPatientRepository.UpdatePatientRecord(Patient patient)
        {
             patientDBContext.patients.Update(patient);  
            patientDBContext.SaveChanges();  
        }
        
       
    }
}
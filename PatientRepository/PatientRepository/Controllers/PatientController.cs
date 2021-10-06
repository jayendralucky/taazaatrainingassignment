using PatientRepository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController:ControllerBase
    {
        IPatientRepository ipatientRepository;
        public PatientController(IPatientRepository _ipatientRepository)
        {
            ipatientRepository = _ipatientRepository;
            
        }
        [HttpPost("Add")]
        public IActionResult createPatient(Patient patient)
        {
           ipatientRepository.AddPatientRecord(patient);
            return Ok("record added");
        }
         [HttpPut("Update")]  
        public IActionResult Edit(Patient patient)  
        {  
            if (ModelState.IsValid)  
            {  
                ipatientRepository.UpdatePatientRecord(patient);  
                return Ok("RECORD updated");  
            }  
            return BadRequest();  
        }  
        [HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data = ipatientRepository.GetPatientSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            ipatientRepository.DeletePatientRecord(id);
            return Ok("Record Deleted");  
        } 
         [HttpGet("{id}")]  
        public Patient Details(string id)  
        {  
            return ipatientRepository.GetPatientSingleRecord(id);  
        }  
        [HttpGet]  
        public IEnumerable<Patient> Get()  
        {  
            return ipatientRepository.GetPatientRecords();  
        }  

        
    }
}
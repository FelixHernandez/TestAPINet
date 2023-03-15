using Microsoft.AspNetCore.Mvc;
using TestAPINet.Models;

namespace TestAPINet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeneficiaryController : ControllerBase
    {
        private Context _db;
        public BeneficiaryController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Beneficiaries);
        }

        [HttpPost]
        public IActionResult SaveBeneficiary(Beneficiary beneficiary)
        {
            _db.Beneficiaries.Add(beneficiary);
            _db.SaveChanges();
            return Ok(beneficiary);
        }
        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Employee employee)
        {
            var _beneficiary = _db.Beneficiaries.FirstOrDefault(x => x.Id == Id);
            if (_beneficiary == null) return BadRequest("Beneficiary Not Found");
            _db.Beneficiaries.Update(_beneficiary);
            _db.SaveChanges();
            return Ok(_beneficiary);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var _beneficiary = _db.Beneficiaries.FirstOrDefault(x => x.Id == Id);
            if (_beneficiary == null) return BadRequest("Beneficiary Not Found");
            _beneficiary.IsDeleted = true;
            return Ok(_beneficiary);
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskMgmService.Models;
using TaskMgmService.Repository;

namespace TaskMgmService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegisterRepository registerRepository = null;
        public RegistrationController(IRegisterRepository registerRepository)
        {
            this.registerRepository = registerRepository;
        }

        [HttpGet]
        [Route("GetRegistration")]
        public async Task<IActionResult> GetRegistration()
        {
            try
            {
                var data = await registerRepository.GetRegistrations();
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetRegistrationbyId/{Id}")]
        public async Task<IActionResult> GetRegistrationsById(int Id)
        {
            try
            {
                var data = await registerRepository.GetRegistrationsById(Id);
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("PostRegistration")]
        public async Task<IActionResult> AddRegistration(Registration registration)
        {
            try
            {
                int result = 0;
                result = await registerRepository.AddRegistration(registration);

                if (result != 0)
                    return Ok(result);

                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("UpdateRegistration")]
        public async Task<IActionResult> UpdateRegistration(Registration registration)
        {
            try
            {
                int result = 0;
                result = await registerRepository.UpdateRegistration(registration);

                if (result != 0)
                    return Ok(result);

                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("DeleteRegistration")]
        public async Task<IActionResult> DeleteRegistration(int Id)
        {
            try
            {
                int result = 0;
                result = await registerRepository.DeleteRegistration(Id);

                if (result != 0)
                    return Ok(result);

                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using TaskMgmService.Models;
using TaskMgmService.Repository;

namespace TaskMgmService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var data = await usersRepository.GetUsers();
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
        [Route("GetUsersById/{Id}")]
        public async Task<IActionResult> GetUsersById(int Id)
        {
            try
            {
                var data = await usersRepository.GetUsersById(Id);
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
        [Route("PostUser")]
        public async Task<IActionResult> AddRegistration(User user)
        {
            try
            {
                int result = 0;
                result = await usersRepository.AddUser(user);

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
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            try
            {
                int result = 0;
                result = await usersRepository.UpdateUser(user);

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
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int Id)
        {
            try
            {
                int result = 0;
                result = await usersRepository.DeleteUser(Id);

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

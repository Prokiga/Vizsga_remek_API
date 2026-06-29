using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        DatabaseContext db_context = new DatabaseContext();

        // Post végpont létrehozása a felhasználó regisztrációjához
        [HttpPost]
        public ActionResult RegisterNewUser(AddNewUserDTO newUserDTO)
        {
            // Itt lehetne a felhasználó regisztrációs logikáját implementálni
            try
            {
                var newUser = new users
                {
                    user_name = newUserDTO.user_name,
                    pass_word = newUserDTO.pass_word
                };

                db_context.users.Add(newUser);
                db_context.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, new { message = "User registered successfully.", user = newUser });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "An error occurred while registering the user.", ex.Message });
                throw;
            }
        }
    }
}

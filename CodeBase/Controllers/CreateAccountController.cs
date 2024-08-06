using CodeBase.IServices;
using CodeBase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeBase.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CreateAccountController : ControllerBase
    {
        private readonly ICreateAccountService _createAccountService;

        public CreateAccountController(ICreateAccountService createAccountService)
        {
            _createAccountService = createAccountService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAccounts()
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                var accounts = await _createAccountService.GetAllService();
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountByNIC(long id) 
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                var account = await _createAccountService.GetByNICService(id);
                return Ok(account);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        
        }
        [HttpPost]
        public async Task<IActionResult> CreateRegisterAccount(CreateAccount createAccount)
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                await _createAccountService.AddService(createAccount);
                return CreatedAtAction(nameof(GetAccountByNIC), new { id = createAccount.NicNumber }, createAccount);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }
        [HttpPut]
        public IActionResult UpdateAccount(CreateAccount updateAccount)
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                _createAccountService.UpdateService(updateAccount);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(long id) 
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                await _createAccountService.DeleteService(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

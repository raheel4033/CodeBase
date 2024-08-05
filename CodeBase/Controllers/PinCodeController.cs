using CodeBase.IServices;
using CodeBase.Models;
using CodeBase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PinCodeController : ControllerBase
    {
        private readonly IPinCodeService _pinCodeService;

        public PinCodeController(IPinCodeService pinCodeService)
        {
            _pinCodeService = pinCodeService;
        }
        [HttpPost]
        public IActionResult AddEmailPin(PinCode pinCode)
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                _pinCodeService.AddEmailCodeService(pinCode);
                return CreatedAtAction("EmailCodeAdded", pinCode);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        public IActionResult UpdateEmailAccount(PinCode pinCode)
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                _pinCodeService.UpdateEmailCodeService(pinCode);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAccount(long id)
        {
            //WE SHOULD USE CUSTOM EXCEPTIONS INSTEAD OF TRY CATCH
            try
            {
                _pinCodeService.DeleteCodeService(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("GenerateCode")]
        public IActionResult GenerateCode(PinCode pinCode)
        {
            _pinCodeService.GeneratePhoneCode(pinCode);
            _pinCodeService.AddEmailCodeService(pinCode);
            return Ok("Generatred Code");
        }
    }
}

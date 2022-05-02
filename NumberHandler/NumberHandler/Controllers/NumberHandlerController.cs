using Microsoft.AspNetCore.Mvc;
using NumberHandler.Core.Interfaces;

namespace NumberHandlerController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberHandlerController : ControllerBase
    {
        private readonly INumberSortingHandler _numberSortingHandler;
        public NumberHandlerController(INumberSortingHandler numberSortingHandler)
        {
            _numberSortingHandler = numberSortingHandler;
        }

        [HttpPost]
        public async Task<ActionResult> MoveLargestNumbersToCenter([FromBody]List<int> numbers, int numberOfLargestNumbersToMove)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid input");
            }

            return Ok(await _numberSortingHandler.MoveLargestNumbersToCenterAsync(numbers, numberOfLargestNumbersToMove));
        }
    }
}

using Microservice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardActionsController : ControllerBase
    {
        private readonly CardService _cardService;
        private readonly ICardActionService _cardActionService;

        public CardActionsController(CardService cardService, ICardActionService cardActionService)
        {
            _cardService = cardService;
            _cardActionService = cardActionService;
        }

        [HttpGet("{userId}/{cardNumber}")]
        public async Task<IActionResult> GetCardActions(string userId, string cardNumber)
        {
            var cardDetails = await _cardService.GetCardDetails(userId, cardNumber);
            if (cardDetails == null)
            {
                return NotFound($"Card with '{cardNumber}' for user '{userId}' not found.");
            }

            var allowedActions = _cardActionService.GetAllowedActions(
                cardDetails.CardType,
                cardDetails.CardStatus,
                cardDetails.IsPinSet
            );

            var allowedActionNames = allowedActions.Select(action => action.ToString()).ToList();

            return Ok(new { AllowedActions = allowedActionNames });
        }
    }
}
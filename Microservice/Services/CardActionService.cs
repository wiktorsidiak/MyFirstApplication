using Microservice.Enums;
using Microservice.Repository;

namespace Microservice.Services
{
    public class CardActionService : ICardActionService
    {
        private readonly ICardActionRepository _cardActionRepository;

        public CardActionService(ICardActionRepository cardActionRepository)
        {
            _cardActionRepository = cardActionRepository;
        }
        public List<CardAction> GetAllowedActions(CardType cardType, CardStatus cardStatus, bool isPinAssigned)
        {
            var rules = _cardActionRepository.GetAllowedActions();

            List<CardAction>? allowedActions = rules
                .Where(rule =>
                    rule.CardType == cardType &&
                    rule.CardStatus == cardStatus &&
                    (rule.RequiresPin == null || rule.RequiresPin == isPinAssigned)
                )
                .Select(rule => rule.CardAction)
                .Distinct() 
                .ToList();

            return allowedActions;
        }
    }
}

using Microservice.Enums;

namespace Microservice.Services
{
    public interface ICardActionService
    {
        List<CardAction> GetAllowedActions(CardType cardType, CardStatus cardStatus, bool isPinAssigned);

    }
}

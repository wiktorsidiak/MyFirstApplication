using Microservice.Enums;

namespace Microservice.Models
{
    public class CardActionRule
    {
        public CardAction CardAction { get; set; }
        public CardType CardType { get; set; }
        public CardStatus CardStatus { get; set; }
        public bool? RequiresPin { get; set; }
    }
}

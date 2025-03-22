using Microservice.Models;

namespace Microservice.Repository
{
    public interface ICardActionRepository
    {
        public List<CardActionRule> GetAllowedActions();
    }
}

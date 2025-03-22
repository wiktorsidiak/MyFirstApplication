using Microservice.Enums;
using Microservice.Models;
using Microservice.Repository;
using Microservice.Services;
using Moq;

public class CardActionServiceTests
{
    private readonly Mock<ICardActionRepository> _mockRepository;
    private readonly CardActionService _service;

    public CardActionServiceTests()
    {
        _mockRepository = new Mock<ICardActionRepository>();
        _service = new CardActionService(_mockRepository.Object);
    }

    [Fact]
    public void GetAllowedActions_ShouldReturnCorrectActions_WhenMatchingRulesExist()
    {
        var rules = new List<CardActionRule>
        {
            new CardActionRule { CardAction = CardAction.ACTION1, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
            new CardActionRule { CardAction = CardAction.ACTION2, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },
            new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },
            new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
        };
        _mockRepository.Setup(repo => repo.GetAllowedActions()).Returns(rules);

        var result = _service.GetAllowedActions(CardType.Prepaid, CardStatus.Active, false);

        Assert.NotEmpty(result);
        Assert.Contains(CardAction.ACTION1, result);
        Assert.Contains(CardAction.ACTION4, result);
    }

    [Fact]
    public void GetAllowedActions_ShouldReturnEmptyList_WhenNoMatchingRulesExist()
    {
        var rules = new List<CardActionRule>
        {
            new CardActionRule { CardAction = CardAction.ACTION2, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = true }
        };
        _mockRepository.Setup(repo => repo.GetAllowedActions()).Returns(rules);

        var result = _service.GetAllowedActions(CardType.Prepaid, CardStatus.Active, false);

        Assert.Empty(result);
    }

    [Fact]
    public void GetAllowedActions_ShouldConsiderPinAssignment_WhenRequiresPinIsNotNull()
    {
        var rules = new List<CardActionRule>
        {
            new CardActionRule { CardAction = CardAction.ACTION1, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = true },
            new CardActionRule { CardAction = CardAction.ACTION2, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = false }
        };
        _mockRepository.Setup(repo => repo.GetAllowedActions()).Returns(rules);

        var resultWithPin = _service.GetAllowedActions(CardType.Prepaid, CardStatus.Active, true);
        var resultWithoutPin = _service.GetAllowedActions(CardType.Prepaid, CardStatus.Active, false);

        Assert.Single(resultWithPin);
        Assert.Contains(CardAction.ACTION1, resultWithPin);

        Assert.Single(resultWithoutPin);
        Assert.Contains(CardAction.ACTION2, resultWithoutPin);
    }
}

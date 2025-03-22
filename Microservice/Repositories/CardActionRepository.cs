using Microservice.Enums;
using Microservice.Models;

namespace Microservice.Repository
{
    public class CardActionRepository : ICardActionRepository
    {
        public List<CardActionRule> GetAllowedActions()
        {
            return new List<CardActionRule>
            {
                #region action1
                new CardActionRule { CardAction = CardAction.ACTION1, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION1, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION1, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },
                #endregion
                 
                #region action2
                new CardActionRule { CardAction = CardAction.ACTION2, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION2, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION2, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                #endregion
                
                #region action3
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Restricted, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Restricted, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Restricted, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Expired, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Expired, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Expired, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Prepaid, CardStatus = CardStatus.Closed, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Debit, CardStatus = CardStatus.Closed, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Closed, RequiresPin = null },
                #endregion
                
                #region action4
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Restricted, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Restricted, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Restricted, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Expired, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Expired, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Expired, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Prepaid, CardStatus = CardStatus.Closed, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Debit, CardStatus = CardStatus.Closed, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION4, CardType = CardType.Credit, CardStatus = CardStatus.Closed, RequiresPin = null },
                #endregion

                #region action5

                new CardActionRule { CardAction = CardAction.ACTION5, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION5, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION5, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION5, CardType = CardType.Credit, CardStatus = CardStatus.Restricted, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION5, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Expired, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION3, CardType = CardType.Credit, CardStatus = CardStatus.Closed, RequiresPin = null },
                #endregion

                #region action6
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = true },

                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = true },

                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = true },

                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Debit, CardStatus = CardStatus.Blocked, RequiresPin = true },
                new CardActionRule { CardAction = CardAction.ACTION6, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = true },
                #endregion

                #region action7
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = false },

                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = false },

                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = false },

                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Debit, CardStatus = CardStatus.Blocked, RequiresPin = false },
                new CardActionRule { CardAction = CardAction.ACTION7, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = false },
                #endregion

                #region action8
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Debit, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION8, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = null },
                #endregion

                #region action9
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Restricted, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Restricted, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Restricted, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Blocked, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Blocked, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Expired, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Expired, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Expired, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Prepaid, CardStatus = CardStatus.Closed, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Debit, CardStatus = CardStatus.Closed, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION9, CardType = CardType.Credit, CardStatus = CardStatus.Closed, RequiresPin = null },
                #endregion

                #region action10
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION10, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },
                #endregion

                #region action11                                     
                new CardActionRule { CardAction = CardAction.ACTION11, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION11, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION11, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION11, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION11, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION11, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },
                #endregion

                #region action12
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION12, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },
                #endregion

                #region action13
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Debit, CardStatus = CardStatus.Ordered, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Credit, CardStatus = CardStatus.Ordered, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Debit, CardStatus = CardStatus.Inactive, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Credit, CardStatus = CardStatus.Inactive, RequiresPin = null },

                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Prepaid, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Debit, CardStatus = CardStatus.Active, RequiresPin = null },
                new CardActionRule { CardAction = CardAction.ACTION13, CardType = CardType.Credit, CardStatus = CardStatus.Active, RequiresPin = null },
                #endregion
            };
        }
    }
}
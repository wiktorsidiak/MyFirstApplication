﻿namespace Microservice.Services
{
    public interface ICardService
    {
        Task<CardDetails?> GetCardDetails(string userId, string cardNumber);
    }
}

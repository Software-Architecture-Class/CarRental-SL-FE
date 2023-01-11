﻿namespace CarRentalServiceAPI.Data.Dto
{
    public class AccountDto
    {   
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
    }
}
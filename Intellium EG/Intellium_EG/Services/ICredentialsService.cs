﻿namespace Intellium_EG
{
    public interface ICredentialsService
    {
        string ServerName { get; }
        string UserName { get; }
        string Password { get; }
        void SaveCredentials(string userName, string password);
        void DeleteCredentials();
        bool DoCredentialsExist();
    }
}
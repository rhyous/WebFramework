﻿namespace Rhyous.WebFramework.Interfaces
{
    public partial interface IUser : IEntity<long>, IAuditable, IActivateable
    {
        string Username { get; set; }
        string OrganizationId { get; set; }
        string Password { get; set; }
        string Salt { get; set; }
        bool IsHashed { get; set; }
        bool ExternalAuth { get; set; }
    }
}

﻿using Rhyous.WebFramework.Interfaces;
using System;

namespace Rhyous.WebFramework.Entities
{
    [AlternateKey("Name")]
    public partial class UserGroup : IUserGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}

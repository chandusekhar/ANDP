﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using System.Collections.Generic;

namespace Thinktecture.IdentityManager.Core
{
    public class UserResult
    {
        public string Subject { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Tenant { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public IEnumerable<UserClaim> Claims { get; set; }
    }
}

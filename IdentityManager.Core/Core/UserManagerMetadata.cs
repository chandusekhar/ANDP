﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using System.Collections.Generic;

namespace Thinktecture.IdentityManager.Core
{
    public enum ClaimDataType
    {
        String,
        Number,
        Boolean,
    }

    public class ClaimMetadata
    {
        public string ClaimType { get; set; }
        public ClaimDataType DataType { get; set; }
        public string DisplayName { get; set; }
        public bool Required { get; set; }
        public IEnumerable<string> AllowedValues { get; set; }
    }

    public class UserManagerMetadata
    {
        public string UniqueIdentitiferClaimType { get; set; }
        public IEnumerable<ClaimMetadata> Claims { get; set; }
    }
}

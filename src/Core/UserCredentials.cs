using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaNET.Core
{
    public struct UserCredentials
    {
        public string Id { get; set; }
        public string ApiToken { get; set; }
        public bool IsNewUser { get; set; }
    }
}

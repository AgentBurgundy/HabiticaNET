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

        public byte[] EncodedCredentials { get; set; }

        public void SetUserCredentials(byte[] credentials)
        {
            EncodedCredentials = credentials;
        }
    }
}

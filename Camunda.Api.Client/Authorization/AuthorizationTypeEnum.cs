using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public enum AuthorizationTypeEnum
    {
        /// <summary>
        /// global
        /// </summary>
        [EnumMember(Value = "0")]
        Global ,

        /// <summary>
        /// grant
        /// </summary
        [EnumMember(Value = "1")]
        Grant ,

        /// <summary>
        /// revoke
        /// </summary>
        [EnumMember(Value = "2")]
        Revoke ,
    }

}

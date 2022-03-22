using System.Runtime.Serialization;

namespace Nop.Core.Configuration
{
    /// <summary>
    /// Represents distributed cache types enumeration
    /// </summary>
    public enum DistributedCacheType
    {
        [EnumMember(Value = "memory")]
        Memory,

        [EnumMember(Value = "redis")]
        Redis
    }
}
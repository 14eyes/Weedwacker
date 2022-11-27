﻿using System.Numerics;
using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarHeroEntityExcelConfigData.json")]
    internal class AvatarHeroEntityData
    {
        [JsonProperty] public readonly int avatarId;
        [JsonProperty] public readonly BigInteger prefabPathHashSuffix;
        [JsonProperty] public readonly int prefabPathHashPre;
        [JsonProperty] public readonly long animatorConfigPathHashSuffix;
        [JsonProperty] public readonly int animatorConfigPathHashPre;
    }
}

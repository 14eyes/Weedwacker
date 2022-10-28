﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifySkillCDByModifierCountMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly TargetType targetType;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly string cdDelta;
    }
}

﻿using System.Text.Json.Serialization;

namespace Marvin.DbAccess.Models.Clan;

public class ClanBannerDataDbModel
{
    [JsonPropertyName("decalId")] public uint DecalId { get; set; }

    [JsonPropertyName("decalColorId")] public uint DecalColorId { get; set; }

    [JsonPropertyName("decalBackgroundColorId")] public uint DecalBackgroundColorId { get; set; }

    [JsonPropertyName("gonfalonId")] public uint GonfalonId { get; set; }

    [JsonPropertyName("gonfalonColorId")] public uint GonfalonColorId { get; set; }

    [JsonPropertyName("gonfalonDetailId")] public uint GonfalonDetailId { get; set; }

    [JsonPropertyName("gonfalonDetailColorId")] public uint GonfalonDetailColorId { get; set; }
}
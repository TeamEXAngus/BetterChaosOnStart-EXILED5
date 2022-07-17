using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace BetterChaosOnStart
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("The percent chance that Chaos replaces Facility Guards when the round starts")]
        public byte CIOnStartChance { get; set; } = 15;

        [Description("Whether or not Chaos spawning in place of Facility Guards consumes respawn tickets")]
        public bool CIOnStartConsumeTickets { get; set; } = true;

        [Description("The items given to Chaos Insurgents when they spawn at round start")]
        public List<ItemType> CIOnStartItems { get; set; } = new()
        {
            ItemType.KeycardGuard,
            ItemType.GunRevolver,
            ItemType.Medkit,
            ItemType.Painkillers,
            ItemType.ArmorLight
        };

        [Description("The ammo given to cuffed Chaos Insurgents when they spawn at round start")]
        public Dictionary<AmmoType, ushort> CIOnStartAmmmo { get; set; } = new()
        {
            { AmmoType.Ammo44Cal, 12 },
            { AmmoType.Nato9, 12 }
        };
    }
}
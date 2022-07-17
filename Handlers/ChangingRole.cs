/*using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using Exiled.API.Extensions;
using System;

namespace BetterChaosOnStart.Handlers
{
    internal class ChangingRole
    {
        private Config Configs => BetterChaosOnStart.Instance.Config;

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Reason == SpawnReason.RoundStart &&
                ev.NewRole == RoleType.FacilityGuard &&
                BetterChaosOnStart.Instance.CIOnStart)
            {
                ev.NewRole = RoleType.ChaosConscript;

                if (Configs.CIOnStartConsumeTickets)
                    Respawn.ChaosTickets -= 1;

                Log.Debug($"{ev.Player.Position.x}, {ev.Player.Position.y}, {ev.Player.Position.z}");

                Timing.CallDelayed(1f, () =>
                {
                    (ev.Player.Position, _) = RoleExtensions.GetRandomSpawnProperties(RoleType.FacilityGuard); // Returns Tuple with (spawpos, rotation)

                    ev.Player.ResetInventory(Configs.CIOnStartItems);
                    foreach (var kvp in Configs.CIOnStartAmmmo)
                        ev.Player.SetAmmo(kvp.Key, kvp.Value);
                });
            }
        }
    }
}*/
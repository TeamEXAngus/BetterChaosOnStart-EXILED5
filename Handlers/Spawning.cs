using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace BetterChaosOnStart.Handlers
{
    internal class Spawning
    {
        private Config Configs => BetterChaosOnStart.Instance.Config;

        public void OnSpawning(SpawningEventArgs ev)
        {
            if (Round.ElapsedTime.TotalSeconds < 5 &&
                ev.RoleType == RoleType.FacilityGuard &&
                BetterChaosOnStart.Instance.CIOnStart)
            {
                ev.Player.SetRole(Configs.CIOnStartRole, lite: true);

                if (Configs.CIOnStartConsumeTickets)
                    Respawn.ChaosTickets -= 1;

                ev.Player.ResetInventory(Configs.CIOnStartItems);
                foreach (var kvp in Configs.CIOnStartAmmmo)
                    ev.Player.SetAmmo(kvp.Key, kvp.Value);
            }
        }
    }
}
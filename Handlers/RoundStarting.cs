using UnityEngine;

namespace BetterChaosOnStart.Handlers
{
    internal class RoundStarting
    {
        private Config Configs => BetterChaosOnStart.Instance.Config;

        public void OnRoundStarting()
        {
            BetterChaosOnStart.Instance.CIOnStart = Configs.CIOnStartChance >= Random.Range(1, 101);
        }
    }
}
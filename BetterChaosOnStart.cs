using System;
using Exiled.API.Features;
using ServerHandler = Exiled.Events.Handlers.Server;
using PlayerHandler = Exiled.Events.Handlers.Player;

namespace BetterChaosOnStart
{
    public class BetterChaosOnStart : Plugin<Config>
    {
        internal static BetterChaosOnStart Instance;

        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 1);
        public override Version Version { get; } = new Version(1, 0, 0);

        public override string Name { get; } = "Better Chaos On Start";
        public override string Author { get; } = "TeamEXAngus#5525";

        internal bool CIOnStart;

        private Handlers.RoundStarting RoundStarting;
        private Handlers.Spawning Spawning;

        public BetterChaosOnStart()
        {
            Instance = this;
        }

        public override void OnEnabled()
        {
            RoundStarting = new Handlers.RoundStarting();
            Spawning = new Handlers.Spawning();

            ServerHandler.RoundStarted += RoundStarting.OnRoundStarting;
            PlayerHandler.Spawning += Spawning.OnSpawning;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            ServerHandler.RoundStarted -= RoundStarting.OnRoundStarting;
            PlayerHandler.Spawning -= Spawning.OnSpawning;

            RoundStarting = null;
            Spawning = null;

            base.OnDisabled();
        }
    }
}
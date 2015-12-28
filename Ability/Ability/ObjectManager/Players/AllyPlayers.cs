﻿namespace Ability.ObjectManager.Players
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Ability.OnUpdate;

    using Ensage;
    using Ensage.Common;
    using Ensage.Common.Objects;

    internal class AllyPlayers
    {
        #region Static Fields

        public static List<Player> All;

        #endregion

        #region Public Methods and Operators

        public static void Update(EventArgs args)
        {
            if (!OnUpdateChecks.CanUpdate())
            {
                return;
            }
            if (!Utils.SleepCheck("Players.Update.Ally"))
            {
                return;
            }
            if (All.Count < 5)
            {
                All = Players.All.Where(x => x.Hero != null && x.Team == AbilityMain.Me.Team).ToList();
            }
            Utils.Sleep(2000, "Players.Update.Ally");
        }

        #endregion
    }
}
// Recall Command v1.3.1
// Author: Felladrin
// Created at 2010-06-20
// Updated at 2016-01-01

using System.Collections.Generic;
using Server;
using Server.Commands;
using Server.Misc;
using Server.Mobiles;
using Server.Spells;

namespace Felladrin.Commands
{
    public static class Recall
    {
        public static class Config
        {
            public static bool Enabled = true;                                       // Is this command enabled?
            public static bool AllowUsageIfIsOverloaded = false;                     // Should we allow players to use this command if they are overloaded?
            public static bool AllowUsageIfIsInCombat = true;                        // Should we allow players to use this command if they are in combat?
            public static bool DecreaseFameIfUsedInCombat = false;                   // Should we decrease the player fame if he use this command to flee from combat?
            public static bool SpecialEffects = true;                                // Should we use special effects after teleporting the player?
            public static bool BringFollowers = true;                                // Should we also teleport the player's followers? 
            public static bool AffectOnlyControlledFollowers = true;                 // Should we only teleport the player's followers that are controlled? 
            public static Point3D TargetLocation = new Point3D(1202, 1116, -25);     // To what coordinates should we teleport the player?
            public static Map TargetMap = Map.Ilshenar;                              // To what map should we teleport the player?
        }

        public static void Initialize()
        {
            if (Config.Enabled)
            {
                CommandSystem.Register("Recall", AccessLevel.Player, new CommandEventHandler(Recall_OnCommand));
            }
        }

        [Usage("Recall")]
        [Description("Teleports you to a safe location.")]
        static void Recall_OnCommand(CommandEventArgs e)
        {
            Mobile m = e.Mobile;

            if (!Config.AllowUsageIfIsOverloaded && WeightOverloading.IsOverloaded(m))
            {
                m.SendMessage("You can't recall because you are carrying too much weight!");
                return;
            }

            if (!Config.AllowUsageIfIsInCombat)
            {
                m.SendMessage("You can't recall during the heat of battle!");
                return;
            }

            m.MoveToWorld(Config.TargetLocation, Config.TargetMap);

            if (Config.BringFollowers)
            {
                PlayerMobile master = (PlayerMobile)m;
                List<Mobile> followers = master.AllFollowers;

                if (followers.Count > 0)
                {
                    foreach (var follower in followers)
                    {
                        var mount = follower as IMount;
                        if (mount != null)
                        {
                            if (mount.Rider == master)
                                continue;

                            mount.Rider = null;
                        }

                        if (Config.AffectOnlyControlledFollowers)
                        {
                            var baseCreature = follower as BaseCreature;
                            if (baseCreature != null)
                            {
                                if (!baseCreature.Controlled)
                                    continue;
                            } 
                        }

                        follower.MoveToWorld(master.Location, master.Map);
                    }
                }
            }

            if (Config.SpecialEffects)
            {
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y, m.Z + 4), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y, m.Z), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y, m.Z - 4), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X, m.Y + 1, m.Z + 4), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X, m.Y + 1, m.Z), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X, m.Y + 1, m.Z - 4), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z + 11), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z + 7), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z + 3), m.Map, 0x3728, 13);
                Effects.SendLocationEffect(new Point3D(m.X + 1, m.Y + 1, m.Z - 1), m.Map, 0x3728, 13);

                m.PlaySound(0x228);

                m.Emote("*appears in a puff of smoke*");
            }

            if (Config.DecreaseFameIfUsedInCombat && SpellHelper.CheckCombat(m))
            {
                Titles.AwardFame(m, -(m.Fame / 20), true);
            }
        }
    }
}
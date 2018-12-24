using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace day_24
{
   class Program
   {
      static void Main(string[] args)
      {
         List<GroupInfo> immuneSystem = new List<GroupInfo>();
         List<GroupInfo> infection = new List<GroupInfo>();

         //List<GroupInfo> current = immuneSystem;


         //string pattern = @"([0-9]+)";         

         //foreach (String line in File.ReadAllLines("input.txt").Skip(1))
         //{
         //   var matches = Regex.Matches(line, pattern);

         //   foreach (Match m in )
         //   {
         //      Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
         //   }
         //}

         #region immune
         immuneSystem.Add(new GroupInfo()
         {
            Units = 4592,
            HitPoints = 2061,
            Immunities = new HashSet<string>()
            {
               "slashing",
               "radiation"
            },
            Weaknesses = new HashSet<string>()
            {
               "cold"
            },
            AttackDamage = 4,
            AttackType = "fire",
            Initiative = 9
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 1383,
            HitPoints = 3687,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 26,
            AttackType = "radiation",
            Initiative = 15
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 2736,
            HitPoints = 6429,
            Immunities = new HashSet<string>()
            {
               "slashing"
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 20,
            AttackType = "slashing",
            Initiative = 2
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 777,
            HitPoints = 3708,
            Immunities = new HashSet<string>()
            {
               "radiation",
               "cold"
            },
            Weaknesses = new HashSet<string>()
            {
               "slashing",
               "fire"
            },
            AttackDamage = 39,
            AttackType = "cold",
            Initiative = 4
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 6761,
            HitPoints = 2792,
            Immunities = new HashSet<string>()
            {
               "bludgeoning",
               "fire",
               "cold",
               "slashing"
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 3,
            AttackType = "radiation",
            Initiative = 17
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 6028,
            HitPoints = 5537,
            Immunities = new HashSet<string>()
            {
               "slashing"
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 7,
            AttackType = "radiation",
            Initiative = 6
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 2412,
            HitPoints = 2787,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 9,
            AttackType = "bludgeoning",
            Initiative = 20
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 6042,
            HitPoints = 7747,
            Immunities = new HashSet<string>()
            {
               "radiation"
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 12,
            AttackType = "slashing",
            Initiative = 12
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 1734,
            HitPoints = 7697,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
               "radiation",
               "cold"
            },
            AttackDamage = 38,
            AttackType = "cold",
            Initiative = 10
         });

         immuneSystem.Add(new GroupInfo()
         {
            Units = 4391,
            HitPoints = 3250,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 7,
            AttackType = "cold",
            Initiative = 19
         });
         #endregion
         // ###################################### INFECTION ##############################
         #region infection
         infection.Add(new GroupInfo()
         {
            Units = 820,
            HitPoints = 46229,
            Immunities = new HashSet<string>()
            {
               "cold",
               "bludgeoning"
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 106,
            AttackType = "slashing",
            Initiative = 18
         });

         infection.Add(new GroupInfo()
         {
            Units = 723,
            HitPoints = 30757,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
               "bludgeoning"
            },
            AttackDamage = 80,
            AttackType = "fire",
            Initiative = 3
         });

         infection.Add(new GroupInfo()
         {
            Units = 2907,
            HitPoints = 51667,
            Immunities = new HashSet<string>()
            {
               "bludgeoning"
            },
            Weaknesses = new HashSet<string>()
            {
               "slashing"
            },
            AttackDamage = 32,
            AttackType = "fire",
            Initiative = 1
         });

         infection.Add(new GroupInfo()
         {
            Units = 2755,
            HitPoints = 49292,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
               "bludgeoning"
            },
            AttackDamage = 34,
            AttackType = "fire",
            Initiative = 5
         });

         infection.Add(new GroupInfo()
         {
            Units = 5824,
            HitPoints = 24708,
            Immunities = new HashSet<string>()
            {
               "bludgeoning",
               "cold",
               "radiation",
               "slashing"
            },
            Weaknesses = new HashSet<string>()
            {
            },
            AttackDamage = 7,
            AttackType = "bludgeoning",
            Initiative = 11
         });

         infection.Add(new GroupInfo()
         {
            Units = 7501,
            HitPoints = 6943,
            Immunities = new HashSet<string>()
            {
               "slashing"
            },
            Weaknesses = new HashSet<string>()
            {
               "cold"
            },
            AttackDamage = 1,
            AttackType = "radiation",
            Initiative = 8
         });

         infection.Add(new GroupInfo()
         {
            Units = 573,
            HitPoints = 10367,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
               "cold",
               "slashing"
            },
            AttackDamage = 30,
            AttackType = "radiation",
            Initiative = 16
         });

         infection.Add(new GroupInfo()
         {
            Units = 84,
            HitPoints = 31020,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
               "cold"
            },
            AttackDamage = 639,
            AttackType = "slashing",
            Initiative = 14
         });

         infection.Add(new GroupInfo()
         {
            Units = 2063,
            HitPoints = 31223,
            Immunities = new HashSet<string>()
            {
               "bludgeoning"
            },
            Weaknesses = new HashSet<string>()
            {
               "radiation"
            },
            AttackDamage = 25,
            AttackType = "cold",
            Initiative = 13
         });

         infection.Add(new GroupInfo()
         {
            Units = 214,
            HitPoints = 31088,
            Immunities = new HashSet<string>()
            {
            },
            Weaknesses = new HashSet<string>()
            {
               "fire"
            },
            AttackDamage = 271,
            AttackType = "slashing",
            Initiative = 7
         });
         #endregion

         //immuneSystem = new List<GroupInfo>();
         //infection = new List<GroupInfo>();


         //immuneSystem.Add(new GroupInfo()
         //{
         //   Index = 1,
         //   Units = 17,
         //   HitPoints = 5390,
         //   Immunities = new HashSet<string>()
         //   {
         //   },
         //   Weaknesses = new HashSet<string>()
         //   {
         //      "bludgeoning",
         //      "radiation"
         //   },
         //   AttackDamage = 4507,
         //   AttackType = "fire",
         //   Initiative = 2
         //});
         //immuneSystem.Add(new GroupInfo()
         //{
         //   Index=2,
         //   Units = 989,
         //   HitPoints = 1274,
         //   Immunities = new HashSet<string>()
         //   {
         //      "fire"
         //   },
         //   Weaknesses = new HashSet<string>()
         //   {
         //      "bludgeoning",
         //      "slashing"
         //   },
         //   AttackDamage = 25,
         //   AttackType = "slashing",
         //   Initiative = 3
         //});


         //infection.Add(new GroupInfo()
         //{
         //   Index=1,
         //   Units = 801,
         //   HitPoints = 4706,
         //   Immunities = new HashSet<string>()
         //   {
         //   },
         //   Weaknesses = new HashSet<string>()
         //   {
         //      "radiation"
         //   },
         //   AttackDamage = 116,
         //   AttackType = "bludgeoning",
         //   Initiative = 1
         //});
         //infection.Add(new GroupInfo()
         //{
         //   Index=2,
         //   Units = 4485,
         //   HitPoints = 2961,
         //   Immunities = new HashSet<string>()
         //   {
         //      "radiation"
         //   },
         //   Weaknesses = new HashSet<string>()
         //   {
         //      "fire",
         //      "cold"
         //   },
         //   AttackDamage = 12,
         //   AttackType = "slashing",
         //   Initiative = 4
         //});

         // fight
         while (immuneSystem.Count > 0 && infection.Count > 0)
         {
            List<(GroupInfo attacker, GroupInfo defender)> attacks = new List<(GroupInfo attacker, GroupInfo defender)>();

            HashSet<GroupInfo> targetsImmune = new HashSet<GroupInfo>();
            foreach (GroupInfo attackerImmune in immuneSystem.OrderByDescending(p => p.EffectivePower).ThenByDescending(p => p.Initiative))
            {
               GroupInfo targetImmune = infection.Where(p => !targetsImmune.Contains(p) && CalcDamage(attackerImmune, p) > 0).OrderByDescending(p => CalcDamage(attackerImmune, p)).ThenByDescending(p => p.EffectivePower).ThenByDescending(p => p.Initiative).FirstOrDefault();

               if (targetImmune != null)
               {
                  targetsImmune.Add(targetImmune);

                  attacks.Add((attackerImmune, targetImmune));
               }
            }

            HashSet<GroupInfo> targetsInfection = new HashSet<GroupInfo>();
            foreach (GroupInfo attackerInfection in infection.OrderByDescending(p => p.EffectivePower).ThenByDescending(p => p.Initiative))
            {
               GroupInfo targetInfection = immuneSystem.Where(p => !targetsInfection.Contains(p) && CalcDamage(attackerInfection, p) > 0).OrderByDescending(p => CalcDamage(attackerInfection, p)).ThenByDescending(p => p.EffectivePower).ThenByDescending(p => p.Initiative).FirstOrDefault();

               if (targetInfection != null)
               {
                  targetsInfection.Add(targetInfection);

                  attacks.Add((attackerInfection, targetInfection));
               }
            }

            foreach ((GroupInfo attacker, GroupInfo defender) in attacks.OrderByDescending(p => p.attacker.Initiative))
            {
               double damage = CalcDamage(attacker, defender);

               int killedUnits = (int)Math.Floor(damage / (double)defender.HitPoints);

               defender.Units = defender.Units - killedUnits;

               //Console.WriteLine(defender.Units);
            }

            immuneSystem.RemoveAll(p => p.Units <= 0);
            infection.RemoveAll(p => p.Units <= 0);
         }

         if (immuneSystem.Count > 0)
         {
            Console.WriteLine(immuneSystem.Sum(p => p.Units));
         }

         if (infection.Count > 0)
         {
            Console.WriteLine(infection.Sum(p => p.Units));
         }

         Console.ReadLine();
      }

      private static int CalcDamage(GroupInfo attacker, GroupInfo defender)
      {
         int ret = attacker.EffectivePower;

         if (defender.Units <= 0)
            return 0;

         if (defender.Immunities.Contains(attacker.AttackType))
            ret = 0;

         if (defender.Weaknesses.Contains(attacker.AttackType))
            ret *= 2;

         return ret;
      }

      public class GroupInfo
      {
         public int Index { get; set; }


         public int Units { get; set; }
         public int HitPoints { get; set; }
         public int AttackDamage { get; set; }
         public string AttackType { get; set; }
         public int Initiative { get; set; }
         public HashSet<String> Immunities { get; set; } = new HashSet<string>();
         public HashSet<String> Weaknesses { get; set; } = new HashSet<string>();

         public int EffectivePower => Math.Max(Units, 0) * AttackDamage;
      }
   }
}

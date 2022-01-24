﻿using System;
using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions 
            => (IReadOnlyCollection<IMission>) this.missions;

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString())
              .AppendLine($"Missions:");

            foreach (var mission in missions)
            {
                sb.AppendLine("  " + mission.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
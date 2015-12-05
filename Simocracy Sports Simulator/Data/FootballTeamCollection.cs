﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simocracy.SportSim.Data
{
	/// <summary>
	/// Stellt verschiedene Methoden zum Verwalten von Fußballteams zur Verfügung
	/// </summary>
	public class FootballTeamCollection : List<FootballTeam>, ITeamCollection<FootballTeam>
	{
		#region Manage Teams

		/// <summary>
		/// Erstellt ein neues Fußballteam und fügt es der Liste hinzu
		/// </summary>
		/// <param name="name">Name des Teams</param>
		public void Add(string name)
		{
			Add(new FootballTeam(name));
		}

		/// <summary>
		/// Erstellt ein neues Fußballteam und fügt es der Liste hinzu
		/// </summary>
		/// <param name="name">Name des Teams</param>
		/// <param name="goalkeeperStrength">Stärke des Torhüters</param>
		/// <param name="defenseStrength">Stärke der Verteidigung</param>
		/// <param name="midfieldStrength">Stärke des Mittelfelds</param>
		/// <param name="forwardStrength">Stärke der Offensive</param>
		public void Add(string name, int goalkeeperStrength, int defenseStrength, int midfieldStrength, int forwardStrength)
		{
			Add(new FootballTeam(name, goalkeeperStrength, defenseStrength, midfieldStrength, forwardStrength));
		}

		/// <summary>
		/// Erstellt ein neues Fußballteam und fügt es der Liste hinzu
		/// </summary>
		/// <param name="name">Name des Teams</param>
		/// <param name="logo">Name der Logodatei</param>
		/// <param name="goalkeeperStrength">Stärke des Torhüters</param>
		/// <param name="defenseStrength">Stärke der Verteidigung</param>
		/// <param name="midfieldStrength">Stärke des Mittelfelds</param>
		/// <param name="forwardStrength">Stärke der Offensive</param>
		public void Add(string name, string logo, int goalkeeperStrength, int defenseStrength, int midfieldStrength, int forwardStrength)
		{
			Add(new FootballTeam(name, logo, goalkeeperStrength, defenseStrength, midfieldStrength, forwardStrength));
		}

		/// <summary>
		/// Gibt das Team mit dem angegebenen Namen zurück
		/// </summary>
		/// <param name="name">Name des Teams</param>
		/// <returns>Team mit dem angegebenen Namen</returns>
		public FootballTeam Get(string name)
		{
			var teams = this.Where(x => x.Name == name);
			return (teams.Count() != 1) ? null : teams.First();
		}

		#endregion

		#region Stats

		/// <summary>
		/// Gibt das Team mit der größten Stärke zurück
		/// </summary>
		/// <returns>Team mit der größten Stärke</returns>
		public FootballTeam GetBestTeam()
		{
			var maxStrength = this.Max(x => x.Strength);
			return this.First(x => x.Strength == maxStrength);
		}

		/// <summary>
		/// Gibt das Team mit dem besten Torhüter zurück
		/// </summary>
		/// <returns>Team mit dem besten Torhüter</returns>
		public FootballTeam GetBestGoalKeeper()
		{
			var maxStrength = this.Max(x => x.DefenseStrength);
			return this.First(x => x.DefenseStrength == maxStrength);
		}

		/// <summary>
		/// Gibt das Team mit der besten Defensive zurück
		/// </summary>
		/// <returns>Team mit der besten Defensive</returns>
		public Team GetBestDefense()
		{
			var maxStrength = this.Max(x => x.DefenseStrength);
			return this.First(x => x.DefenseStrength == maxStrength);
		}

		/// <summary>
		/// Gibt das Team mit dem besten Mittelfeld zurück
		/// </summary>
		/// <returns>Team mit dem besten Mittelfeld</returns>
		public Team GetBestMidfield()
		{
			var maxStrength = this.Max(x => x.MidfieldStrength);
			return this.First(x => x.MidfieldStrength == maxStrength);
		}

		/// <summary>
		/// Gibt das Team mit dem besten Sturm zurück
		/// </summary>
		/// <returns>Team mit dem besten Sturm</returns>
		public Team GetBestForward()
		{
			var maxStrength = this.Max(x => x.ForwardStrength);
			return this.First(x => x.ForwardStrength == maxStrength);
		}

		#endregion
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Simocracy.SportSim
{
	/// <summary>
	/// Klasse für Staaten in Simocracy
	/// </summary>
	[DataContract]
	public class State : SSSDataObject
	{
		#region Members

		/// <summary>
		/// Leerer Staat ohne Angaben
		/// </summary>
		private static State _NoneState = new State(-1, String.Empty, String.Empty, Continent.Unknown);

		#endregion

		#region Constructors

		/// <summary>
		/// Erstellt einen neuen Staat
		/// </summary>
		/// <param name="id">ID des Staates</param>
		/// <param name="name">Name des Staates</param>
		public State(int id, string name)
			: this(id, name, String.Empty, Continent.Unknown)
		{ }

		/// <summary>
		/// Erstellt einen neuen Staat
		/// </summary>
		/// <param name="id">ID des Staates</param>
		/// <param name="name">Name des Staates</param>
		/// <param name="flag">Flaggenkürzel des Staates</param>
		/// <param name="continent">Kontinent des Staates</param>
		public State(int id, string name, string flag, Continent continent)
			: base(id, name)
		{
			Flag = flag;
			Continent = continent;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Leerer Staat ohne Angaben
		/// </summary>
		public static State NoneState
		{
			get
			{
				return _NoneState;
			}
		}

		/// <summary>
		/// Flaggenkürzel des Staates
		/// </summary>
		[DataMember(Order = 100)]
		public string Flag { get; private set; }

		/// <summary>
		/// Hauptkontinent des Staates
		/// </summary>
		[DataMember(Order = 110)]
		public Continent Continent { get; private set; }

		#endregion
	}
}

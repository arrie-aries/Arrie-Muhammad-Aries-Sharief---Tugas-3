using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Module.Game
{
	public interface IClickGameModel : IBaseModel
	{
		public int Coin { get; }
	}
}
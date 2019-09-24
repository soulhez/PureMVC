using UnityEngine;

namespace PureMVC.Game
{
	public class Test : MonoBehaviour 
	{

		// Use this for initialization
		void Start () 
		{
            new TestFacade(gameObject);
		}
	}
}
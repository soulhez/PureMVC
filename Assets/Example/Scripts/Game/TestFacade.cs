using UnityEngine;
using PureMVC.Patterns;

namespace PureMVC.Game
{
	public class TestFacade : Facade
    {
        public TestFacade(GameObject canvas)
        {
            RegisterCommand(NotificationConstant.LevelUp, typeof(TestCommand));
            RegisterMediator(new TestMediator(canvas));
            RegisterProxy(new TestProxy());
        }
	}
}
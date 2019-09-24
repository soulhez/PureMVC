using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace PureMVC.Game
{
	public class TestCommand : SimpleCommand
    {

        public new const string NAME = "TestCommand";

        public override void Execute(INotification notification)
        {
            base.Execute(notification);
            TestProxy proxy = (TestProxy)Facade.RetrieveProxy(TestProxy.NAME);
            proxy.ChangeLevel(1);
        }
    }
}
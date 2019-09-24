namespace PureMVC.Game
{
	public class CharacterInfo 
	{
        public int Level
        {
            get;
            set;
        }
        public int Hp
        {
            get;
            set;
        }

        public CharacterInfo()
        {

        }

        public CharacterInfo(int level, int hp)
        {
            Level = level;
            Hp = hp;
        }
	}
}
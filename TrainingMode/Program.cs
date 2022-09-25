using System.Windows.Input;
using TrainingMode.Command;

namespace TrainingMode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region adapter
            Toaster t = new Toaster(2, 5);
            PaniniPress paniniPress = new ToasterAdapter(t);
            Console.WriteLine(paniniPress.TouchBrown("bread ass mofo"));
            #endregion

            #region Command

            List<Command.ICommand> actions = new List<Command.ICommand>
            {
                new BatchestAction(true),
                new KappaAction(true),
                new KappaAction(false)
            };

            foreach (Command.ICommand action in actions)
            {
                action.Execute();
            }

            #endregion

            #region Iterator

            #endregion
        }
    }
}
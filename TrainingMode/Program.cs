using System.Windows.Input;
using TrainingMode.Command;
using TrainingMode.Iterator;

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

            int[] elems = { 1, 2, 3, 4, 5, 6, 7 };
            ArrayIterator iterat = new ArrayIterator(elems);
            while (iterat.HasNext())
            {
                Console.WriteLine(iterat.Next().ToString());
            }

            #endregion
        }
    }
}
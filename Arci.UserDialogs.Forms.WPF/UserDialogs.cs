using System;
using System.Threading.Tasks;


namespace Arci.UserDialogs
{
    public static partial class UserDialogs
    {
        /// <summary>
        /// Initialize WPF user dialogs
        /// </summary>
        public static void Init(Func<Action, Task> customDispatcher = null)
        {
            Acr.UserDialogs.UserDialogs.Instance = new UserDialogsImpl(customDispatcher);
        }

    }
}

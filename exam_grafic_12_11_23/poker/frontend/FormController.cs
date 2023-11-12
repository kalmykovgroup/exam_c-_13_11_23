


using poker.backend; 

namespace poker.frontend
{
    internal static class FormController 
    {  
         
        public static Form MainForm; //Здесь храться главная форма для закрытия всего приложения

        static FormController() => MainForm ??= new InputForm(); //Инициализация формы        
         
        public static void Run() => Application.Run(MainForm); //Загрузка формы

        public static void ExitApp() => MainForm.Close(); //Закрыть приложение

        public static void NextView(Form form, Action action) //Передаем форму из которой переходим и делегат на форму которую хотим показать
        {
            //Скрываем только главную форму, остальные закрываем
            if (form == MainForm)  form.Hide();
            else form.Close(); 
          
            action.Invoke();
        }

        public static void ActionInput() => new InputForm().Show(); //Включение формы выбора игрока

        public static void ActionGame(Player player) => new GameForm(player).Show();



    }
}

namespace PageObjectLibrary.Base
{
    public class BaseStep:BaseDriver
    {
        //metodo de navegacion de nuestra pagina
        public void NavigateToInitialSite()
        {
            GetDriver().Navigate().GoToUrl("http://automationpractice.com/index.php?");
        }

        public void NavigateToLoginSite()
        {
            GetDriver().Navigate().GoToUrl("http://automationpractice.com/index.php?");
        }

        //aqui puedo poner las navegaciones a diferentes paginas.
    }
}

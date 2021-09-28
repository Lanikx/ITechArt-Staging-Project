using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    class User
    {

        public AtBookStorePage atBookStorePage;
        public AtLoginPage atLoginPage;
        public AtMainPage atMainPage;
        public AtElementsPage atElementsPage;
        public AtAlertsFramesPage atAlertsFramesPage;
        public AtFormsPage atFormsPage;
        public AtInteractionsPage atInteractionsPage;
        public AtWidgetsPage atWidgetsPage;


        public PageProvider pageProvider;
        
        public AtAlertsPage atAlertsPage;
        public AtTextBoxPage atTextBoxPage;
        public AtPracticeFormPage atPracticeFormPage;
        public AtWebTablesPage atWebTablesPage;

        public User()
        {

        }

        public User(PageProvider pageProvider)
        {
            this.pageProvider = pageProvider;
            atBookStorePage = new AtBookStorePage(pageProvider.InitPage<BookStorePage>());
            atLoginPage = new AtLoginPage(pageProvider.InitPage<LoginPage>());
            atMainPage = new AtMainPage(pageProvider.InitPage<MainPage>());
            atElementsPage = new AtElementsPage(pageProvider.InitPage<ElementsPage>());
            atAlertsFramesPage = new AtAlertsFramesPage(pageProvider.InitPage<AlertsFramesPage>());
            atFormsPage = new AtFormsPage(pageProvider.InitPage<FormsPage>());
            atInteractionsPage = new AtInteractionsPage(pageProvider.InitPage<InteractionsPage>());
            atWidgetsPage = new AtWidgetsPage(pageProvider.InitPage<WidgetsPage>());
            atAlertsPage = new AtAlertsPage(pageProvider.InitPage<AlertsPage>());
            atTextBoxPage = new AtTextBoxPage(pageProvider.InitPage<TextBoxPage>());
            atPracticeFormPage = new AtPracticeFormPage(pageProvider.InitPage<PracticeFormPage>());
            atWebTablesPage = new AtWebTablesPage(pageProvider.InitPage<WebTablesPage>());
        }
    }

}


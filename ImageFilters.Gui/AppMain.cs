using ImagesFilters.Logic.Controller;
using ImagesFilters.Logic.Model;

namespace ImagesFilters;

internal static class AppMain
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var logic = new AppLogic();
        var view = new AppForm();
        var appPresenter = new AppPresenter(logic, view);
        view.Presenter = appPresenter;

        Application.Run(view);
    }
}
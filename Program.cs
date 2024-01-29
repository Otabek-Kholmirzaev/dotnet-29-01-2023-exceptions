using static System.Console;

AppDomain appDomain = AppDomain.CurrentDomain;

appDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);
int num = int.Parse(ReadLine()!);

void HandleException(object sender, UnhandledExceptionEventArgs e)
{
    WriteLine($"Sorry there was a problem and we need to close. Details: {e.ExceptionObject}");
}
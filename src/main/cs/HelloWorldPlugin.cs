namespace Bud.Examples.HelloWorldPlugin {
  public class HelloWorldPlugin {
    public static readonly TaskKey HelloWorldTask = Key.Define("helloWorld", "Prints a hello world message.");

    public static Settings Enable(Settings settings) {
      return settings.Globally(HelloWorldTask.InitSync(HelloWorldImpl));
    }

    private static void HelloWorldImpl(IContext context) {
      context.Logger.Info("Hello world!");
    }
  }
}
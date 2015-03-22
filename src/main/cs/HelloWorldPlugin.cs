namespace Bud.Examples.HelloWorldPlugin {
  public class HelloWorldPlugin : Plugin {
    public static readonly TaskKey HelloWorldTask = Key.Define("helloWorld", "Prints a hello world message in the log.");

    public override Settings Setup(Settings settings) {
      return settings.AddGlobally(HelloWorldTask.InitSync(HelloWorldImpl));
    }

    private static void HelloWorldImpl(IContext context) {
      context.Logger.Info("Hello world!");
    }
  }
}
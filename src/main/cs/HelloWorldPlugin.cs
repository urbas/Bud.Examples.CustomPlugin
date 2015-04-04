namespace Bud.Examples.HelloWorldPlugin {
  public class HelloWorldPlugin : Plugin {
    public static readonly ConfigKey<string> HelloWorldMessage = Key.Define("helloWorldMessage", "The message to be printed by the hello world task.");
    public static readonly TaskKey HelloWorld = Key.Define("helloWorld", "Prints a hello world message in the log.");

    public override Settings Setup(Settings settings) {
      return settings.AddGlobally(HelloWorld.InitSync(HelloWorldImpl),
                                  HelloWorldMessage.Init("Hello, world!"));
    }

    private static void HelloWorldImpl(IContext context) {
      var helloWorldMessage = context.Evaluate(Key.Root / HelloWorldMessage);
      context.Logger.Info(helloWorldMessage);
    }
  }
}
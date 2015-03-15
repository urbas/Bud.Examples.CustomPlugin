namespace Bud.Examples.HelloWorldPlugin {
  public static class HelloWorldPlugin {
    public static readonly TaskKey HelloWorldTask = Key.Define("helloWorld", "Prints a hello world message.");

    public static Setup Enable() {
      return settings => settings.Globally(HelloWorldTask.InitSync(HelloWorldImpl));
    }

    public static void HelloWorld(this IContext context) {
      context.Evaluate(Key.Root / HelloWorldTask);
    }

    private static void HelloWorldImpl(IContext context) {
      context.Logger.Info("Hello world!");
    }
  }
}
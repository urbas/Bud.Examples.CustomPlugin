using Bud;
using Bud.Projects;

public class Build : IBuild {
  public Settings Setup(Settings settings, string baseDir) {
    return settings.BudPlugin("Bud.Examples.HelloWorldPlugin", baseDir);
  }
}
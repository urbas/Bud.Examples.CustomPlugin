using Bud;
using Bud.Projects;

public class Build : IBuild {
  public Settings Setup(Settings settings, string baseDir) {
    return settings
      .Version("0.0.3")
      .BudPlugin("Bud.Examples.HelloWorldPlugin", baseDir);
  }
}
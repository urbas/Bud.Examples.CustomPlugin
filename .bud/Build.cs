using Bud;
using Bud.CSharp;
using Bud.Projects;

public class Build : IBuild {
  public Settings Setup(Settings settings, string baseDir) {
    return settings.Version("1.2.3")
                   .Project("Bud.Examples.SetVersion", baseDir, Cs.Exe());
  }
}
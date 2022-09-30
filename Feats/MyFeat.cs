using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;

namespace GreenFateIcon.Feats
{
  public class MyFeat
  {
    public static void Configure()
    {
      FeatureConfigurator.For(FeatureRefs.GreenFaithFeature.Reference.ToString())
         .SetIcon(FeatureRefs.GozrehFeature.Reference.Get().Icon)
         .Configure(delayed: true);
    }
  }
}


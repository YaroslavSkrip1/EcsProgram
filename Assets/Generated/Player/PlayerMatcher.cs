//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class PlayerMatcher {

    public static Entitas.IAllOfMatcher<PlayerEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<PlayerEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<PlayerEntity> AllOf(params Entitas.IMatcher<PlayerEntity>[] matchers) {
          return Entitas.Matcher<PlayerEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<PlayerEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<PlayerEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<PlayerEntity> AnyOf(params Entitas.IMatcher<PlayerEntity>[] matchers) {
          return Entitas.Matcher<PlayerEntity>.AnyOf(matchers);
    }
}

#if PIXYZ_PLUGIN_FOR_UNITY
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.PixyzPlugin4Unity.Actions;

// Please ensure your class and your file have the same name
public class CustomAction : ActionInOut<IList<GameObject>, IList<GameObject>> 
{
    [UserParameter] // User parameters are displayed in the action's inspector
    public float aFloatParameter = 1f;

    [UserParameter]
    public string aStringParameter = "Text";

    [HelperMethod] // Helper methods can be accessed from the action's context menu
    public void ResetParameters() 
    {
        aFloatParameter = 1f;
        aStringParameter = "Text";
    }

    public override int Id => 263161655;
    public override string MenuPathRuleEngine => "Custom/CustomAction";
    public override string MenuPathToolbox =>  "Custom/CustomAction";
    public override string Tooltip => "";
    public override string Icon => null;
    public override int Priority => 15001; 

    public override IList<GameObject> Run(IList<GameObject> input) 
    {
        // Your code here
        return input;
    }
}
#endif
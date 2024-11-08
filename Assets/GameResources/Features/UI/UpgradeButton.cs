namespace Features.UI
{
    using UnityEngine.UI;
    using UnityEngine;
    using Features.Utils;
    using Features.Parameters;

    /// <summary>
    ///  нопка апгрейда
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class UpgradeButton : AbstractButton
    {
        [SerializeField] private ParametersModel parametersModel = default;

        protected override void OnButtonClicked() => parametersModel.LevelUp();
    }
}
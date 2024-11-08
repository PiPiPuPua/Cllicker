namespace Features.UI
{
    using Features.Utils;

    /// <summary>
    /// Отображение цены за апгрейд
    /// </summary>
    public class UpgradePriceView : AbstractView
    {
        private void Awake() => prefix = "UPGRADE";

        private void Start() => ActionOnEvent();

        public override void SubscribeOnEvent() => parametersModel.onUpgradePriceChanged += ActionOnEvent;

        public override void UnSubscribeOnEvent() => parametersModel.onUpgradePriceChanged -= ActionOnEvent;

        public override void ActionOnEvent()
        {
            parameter = parametersModel.UpgradePrice.ToString();
            textField.text = prefix + ' ' + parameter;
        }
    }
}
namespace Features.UI
{
    using Features.Utils;

    /// <summary>
    /// Отображение дохода за клик
    /// </summary>
    public class ClickIncomeView : AbstractView
    {
        private void Awake() => prefix = "+";

        private void Start() => ActionOnEvent();

        public override void SubscribeOnEvent() => parametersModel.onIncomePerClickChanged += ActionOnEvent;

        public override void UnSubscribeOnEvent() => parametersModel.onIncomePerClickChanged -= ActionOnEvent;

        public override void ActionOnEvent()
        {
            parameter = parametersModel.IncomePerClick.ToString();
            textField.text = prefix + parameter;
        }
    }
}
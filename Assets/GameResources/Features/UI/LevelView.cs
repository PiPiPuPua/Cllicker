namespace Features.UI
{
    using Features.Utils;

    /// <summary>
    /// ����������� ������ ������
    /// </summary>
    public class LevelView : AbstractView
    {
        private void Awake() => prefix = "LVL";

        private void Start() => ActionOnEvent();
    
        public override void SubscribeOnEvent() => parametersModel.onLevelChanged += ActionOnEvent;

        public override void UnSubscribeOnEvent() => parametersModel.onLevelChanged -= ActionOnEvent;

        public override void ActionOnEvent()
        {
            parameter = parametersModel.Level.ToString();
            textField.text = prefix + ' ' + parameter;
        }
    }
}
namespace Weather_App.Resources
{
    public class LabelButton: Label
    {
        public LabelButton()
        {
            SetStyle(ControlStyles.Selectable, true);
            TabStop = true;
        }
    }
}

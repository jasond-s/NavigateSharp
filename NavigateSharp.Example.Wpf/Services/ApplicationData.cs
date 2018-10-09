namespace NavigateSharp.Example.Wpf.States
{
    public interface IApplicationData
    {
        void SetIntroductionText(string introduction);
        string GetIntroductionText();
    }

    public class ApplicationData : IApplicationData
    {
        private string _introductionText;

        public void SetIntroductionText(string introduction)
        {
            _introductionText = introduction;
        }

        public string GetIntroductionText()
        {
            return _introductionText;
        }
    }
}
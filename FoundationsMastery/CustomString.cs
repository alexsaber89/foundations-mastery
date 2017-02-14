namespace FoundationsMastery
{
    public class CustomString
    {
        private char[] mychars;

        public CustomString()
        {

        }

        public CustomString(char[] mychars)
        {
            this.mychars = mychars;
        }

        public char[] GetMyChars()
        {
            return mychars;
        }

        public string ConvertMyCharsToString()
        {
            string s = new string(mychars);
            return s;
        }

        public void Clear()
        {
            mychars = null;
        }
    }
}
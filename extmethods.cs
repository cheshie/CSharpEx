namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

    	static void Main()
    	{
    		string s = "Hello Extension Methods";
		int i = s.WordCount();
	}
    }
}

namespace tot;

public class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }
    private static int CompareLanguages(string x, string y)
    {
        if (x == null)
        {
            if (y == null)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        else
        {
            if (y == null)
            {
                return 1;
            }
            else
            {

                return x.CompareTo(y);
            }
        }

    }
    public static List<string> GetExistingLanguages()
    {
        return new List<string> { "C#", "Clojure", "Elm" };
    }
    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }
    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }
    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }
    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }
    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        if ((languages[0] == "C#") || ((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#"))
        {
            Console.WriteLine(string.Join(',', languages.ToArray()));
            return true;
        }
        return false;
    }
    public static List<string> RemoveLanugage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }
    public static bool IsUnique(List<string> languages)
    {
        Display(languages);
        languages.Sort(CompareLanguages);
        return languages.Count == languages.Distinct().ToList().Count ? true : false;

    }
    public static void Display(List<string> languages)
    {
        Console.WriteLine(string.Join(',', languages.ToArray()));
    }
}
public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new();
    }
    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new()
        {
            [1] = "United States of America",
            [55] = "Brazil",
            [91] = "India"
        };
    }
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new(){
            {countryCode,countryName}
        };
    }
    public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }
    public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode] : string.Empty;
    }
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }
    public static Dictionary<int, string> UpdateDictionary(
       Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }
    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int max = 0;
        string longest = "";
        foreach (var name in existingDictionary.Values)
        {
            if (max < name.Length)
            {
                max = name.Length;
                longest = name;
            }
        }
        return longest;
    }
}
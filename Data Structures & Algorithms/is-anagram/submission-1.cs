public class Solution {
    public bool IsAnagram(string s, string t)
{
    char[] arrT;
    char[] arrS;

    arrS = s.ToCharArray(0, s.Length);
    arrT = t.ToCharArray(0, t.Length);

    Array.Sort(arrS);
    Array.Sort(arrT);
    if(arrT.SequenceEqual(arrS))
    {
        return true;
    }
    return false;
}
}

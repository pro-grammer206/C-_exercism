using System.Text;

namespace Clean;

public class Identifier{
    public static string Clean(string Identifier){
        StringBuilder sb = new StringBuilder();
        bool camelCase = false;
        foreach(char c in Identifier){
            if(camelCase){
                sb.Append(Char.ToUpper(c));
                camelCase = false;
                continue;
            }
            if(Char.IsControl(c)){
                sb.Append(new Char[]{'C','T','R','L'});
                continue;
            }
            if(Char.IsWhiteSpace(c)){
                sb.Append('_');
                continue;
            }
            if(c=='-'){
                camelCase = true;
                continue;
            }
            if(!Char.IsLetter(c)){
                continue;
            }
            if(c>'α' && c<='ω'){
                continue;
            }
            sb.Append(c);
        }
        return sb.ToString();
    }
}
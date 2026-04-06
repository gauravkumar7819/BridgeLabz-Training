using System;
class AutoCorrect
{
    static void Main(string[] args)
    {
        string str=Console.ReadLine();
        string ss=StringFormatter(str);
        Console.WriteLine(ss);

        
      
    }
static string CapitalString(string str)
{
    string result = "";
    bool makeCapital = true;

    foreach (char c in str)
    {
        if (makeCapital && char.IsLetter(c))
        {
            result += char.ToUpper(c);
            makeCapital = false;
        }
        else
        {
            result += c;
        }

        if (c == '.' || c == '!' || c == '?')
        {
            makeCapital = true;
        }
    }

    return result;
}

    static string StringFormatter(string str)
    {
         string result="";
    bool spaceFound=false;
        foreach(char c in str)
        {
            if(c==' ' ){
                if(!spaceFound && result.Length>0){
                    result+=c;
                    spaceFound=true;
                }
            }
            else
            {
                result+=c;
                spaceFound=false;
            }
        }
        
       
        return FixSpacing(result);
    }
    static string FixSpacing( string str)

    {
        string result="";
        foreach(char c in str)
        {

           if(c=='.' || c==',' || c=='!' || c=='?' )
           {
           result+=c;
              result+=' ';
           }
           else
           {
            result+=c;
           }
      
      
      
        } 
        return  CapitalString(result); 
        }  }
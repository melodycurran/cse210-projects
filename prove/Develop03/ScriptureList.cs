using System.Collections.Generic;
using System;

public class ScripturesList

{
    List<string> scriptures = new List<string>(
        new string [] { 
        "Matthew 1:1 The book of the generation of Jesus Christ, the son of David, the son of Abraham.",
        "Matthew 1:2 Abraham begat Isaac; and Isaac begat Jacob; and Jacob begat Judas and his brethren;",
        "Matthew 1:3 And Judas begat Phares and Zara of Thamar; and Phares begat Esrom; and Esrom begat Aram;",
        "Matthew 1:4 And Aram begat Aminadab; and Aminadab begat Naasson; and Naasson begat Salmon;",
        "Matthew 1:5 And Salmon begat Booz of Rachab; and Booz begat Obed of Ruth; and Obed begat Jesse;"
        }
    );

    public string GenerateScripture()
    {
        Random randomNum = new Random();
        int random = randomNum.Next(0,5);

        string stringScripture = scriptures[random];
        
        return stringScripture;
    }
}
namespace DataStructuresAndAlgorithms{
    public class StringDataStructures{
        public int LengthOfLongestSubstring(string s)
            {
                //Loop Each
                //Start From First Item and concatenate till a repreated character, keeping record of the length
                //If there is a repeated character we repeat 2 above on the next item on the list
                //Compare length from previous length recorded if the current length is biiger update length with current length else dont update
                
                string subString = "";
                
                if(s.Length <= 1)
                    return s.Length;
                
                for(int i = 0; i < s.Length;i++)
                {
                    string tempString = s[i].ToString();
                    for(int j = i+1; j < s.Length; j++)
                    {
                        if(!tempString.Contains(s[j]))
                        {
                            tempString += s[j].ToString();
                        }else
                        {
                            j = s.Length;
                        }
                    }
                    
                    if(tempString.Length > subString.Length)
                    {
                        subString = tempString;
                    }
                }
                
                return subString.Length;
            }
    }
}